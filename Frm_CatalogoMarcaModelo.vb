Public Class Frm_CatalogoMarcaModelo

    Private Sub Frm_CatalogoMarcaModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Table_Almacen' Puede moverla o quitarla según sea necesario.
        Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaMarca' Puede moverla o quitarla según sea necesario.
        'Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaMarca' Puede moverla o quitarla según sea necesario.
        rb_brand.Checked = True
        DatosMarcaModelo.llenarComboMarcas(cb_Marcas)
        cb_Marcas.SelectedIndex = 0
        chk_exist.Checked = True
        F_ubic.Checked = False
        bt_add.Enabled = False
        bt_del.Enabled = False
        cb_grupo.Enabled = False
        dgv_c1.Enabled = False
        dgv_c2.Enabled = False
        dtpick.Value = Today.AddMonths(-1)
        dgv_c1.Rows.Clear()

    End Sub

    Public Sub verTodas()

        Dim a As Boolean = False
        Dim i As Integer

        For i = 0 To lst_Consultar.RowCount - 1

            If lst_Consultar.Rows(i).Cells(1).ToString = "Todas" Then
                a = True
            End If

        Next

        If a = True Then

            For i = lst_Consultar.RowCount - 1 To 0 Step -1

                If lst_Consultar.Rows(i).Cells(1).ToString <> "Todas" Then

                    lst_Consultar.Rows.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click

        If lst_Modelo.Items.Count > 0 Then

            If cb_Marcas.Text = "Todas" And recorrerList(cb_Marcas.Text, lst_Consultar) = False Then

                'Seleccionar todas las marcas
                lst_Consultar.Rows.Add(cb_Marcas.Text)
                lst_Modelo.Items.Clear()
                cb_Marcas.Enabled = False
                bt_agregar.Enabled = False

            Else

                If (Me.lst_Modelo.SelectedItem() <> "Todas" And lst_Modelo.Items.Count > 0) Then

                    lst_Consultar.Rows.Add(lst_Modelo.SelectedItem.ToString)
                    lst_Modelo.Items.RemoveAt(lst_Modelo.SelectedIndex)

                ElseIf (Me.lst_Modelo.SelectedItem() = "Todas" And lst_Modelo.Items.Count > 0) Then
                    lst_Modelo.Items.Clear()
                    If (recorrerList(cb_Marcas.Text, lst_Consultar) = False) Then

                        lst_Consultar.Rows.Add(cb_Marcas.Text, "M")

                    Else
                        MsgBox("La Marca ya fué agregada a la consulta")
                    End If
                Else
                    'MsgBox("Seleccione otra Marca y/o Modelo a consultar")
                End If

            End If
            verTodas()
        Else

            MsgBox("Debe agregar un elemento a consultar", MsgBoxStyle.Critical)

        End If


           
    End Sub

    Private Sub bt_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_quitar.Click

        Try

            If (lst_Consultar.SelectedRows.Count > 0) Then

                If (lst_Consultar.SelectedRows(0).Cells(0).Value = "Todas") Then
                    bt_agregar.Enabled = True
                    cb_Marcas.Enabled = True
                    Me.lst_Consultar.Rows.RemoveAt(lst_Consultar.SelectedRows(0).Index)
                Else
                    Me.lst_Consultar.Rows.RemoveAt(lst_Consultar.SelectedRows(0).Index)
                    Me.cb_Marcas_SelectedIndexChanged(Me.cb_Marcas, New System.EventArgs)
                End If

                
            Else

            End If

        Catch ex As Exception

            MsgBox("Debe seleccionar un elemento de la lista", MsgBoxStyle.Critical)

        End Try


    End Sub

    Public Function recorrerList(ByVal d As String, ByVal list As DataGridView) As Boolean

        Dim esta As Boolean = False
        Dim i As Integer

        If list.RowCount = 0 Then
            esta = False
        Else
            For i = 0 To list.RowCount - 1

                If list.Rows(i).Cells(0).Value = d Then

                    esta = True

                End If

            Next
        End If

        Return esta

    End Function

    Private Sub bt_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cb_Marcas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Marcas.SelectedIndexChanged

        If cb_Marcas.Text = "Todas" Then
            lst_Modelo.Items.Clear()
            lst_Consultar.Rows.Clear()
            lst_Modelo.Items.Add("Todas")
            lst_Modelo.SelectedIndex = 0
            bt_agregar_Click(bt_agregar, New EventArgs)
        Else
            If (recorrerList(cb_Marcas.Text, lst_Consultar) = True) Then
                MsgBox("La Marca ya fué agregada a la consulta")
                lst_Modelo.Items.Clear()
                bt_agregar.Enabled = False

            Else
                DatosMarcaModelo.llenarListModelo(cb_Marcas.Text, lst_Modelo, lst_Consultar)
                If (lst_Modelo.Items.Count = 1) Then
                    lst_Modelo.Items.Clear()
                    MsgBox("No existen modelos sociados a esta marca")

                Else
                    bt_agregar.Enabled = True
                    lst_Modelo.SelectedIndex() = lst_Modelo.TopIndex
                End If
            End If
        End If



    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        If (chk_Todos.Checked = True) Then

            chk_CodInt.Checked = True
            chk_CodProFa.Checked = True
            chk_Ubicacion.Checked = True
            chk_Precio.Checked = True
            chk_Modelo.Checked = True
            chk_MarcaProducto.Checked = True
            chk_Marca.Checked = True
            chk_Existencia.Checked = True
            chk_Descripcion.Checked = True
            chk_empaque.Checked = True

            chk_CodInt.Enabled = False
            chk_CodProFa.Enabled = False
            chk_Ubicacion.Enabled = False
            chk_Precio.Enabled = False
            chk_Modelo.Enabled = False
            chk_MarcaProducto.Enabled = False
            chk_Marca.Enabled = False
            chk_Existencia.Enabled = False
            chk_Descripcion.Enabled = False
            chk_empaque.Enabled = False
        Else

            chk_CodInt.Checked = False
            chk_CodProFa.Checked = False
            chk_Ubicacion.Checked = False
            chk_Precio.Checked = False
            chk_Modelo.Checked = False
            chk_MarcaProducto.Checked = False
            chk_Marca.Checked = False
            chk_Existencia.Checked = False
            chk_Descripcion.Checked = False
            chk_exist.Checked = False
            chk_empaque.Checked = False

            chk_CodInt.Enabled = True
            chk_CodProFa.Enabled = True
            chk_Ubicacion.Enabled = True
            chk_Precio.Enabled = True
            chk_Modelo.Enabled = True
            chk_MarcaProducto.Enabled = True
            chk_Marca.Enabled = True
            chk_Existencia.Enabled = True
            chk_Descripcion.Enabled = True
            chk_exist.Enabled = True
            chk_empaque.Enabled = True

            If (rb_Marca.Checked = True) Then
                chk_Marca.Enabled = False
                chk_Marca.Checked = True
            End If

            If (rb_Descripcion.Checked = True) Then
                chk_Descripcion.Enabled = False
                chk_Descripcion.Checked = True
            End If

            If (rb_CodFab.Checked = True) Then
                chk_CodProFa.Enabled = False
                chk_CodProFa.Checked = True
            End If

            If (rb_CodInt.Checked = True) Then
                chk_CodInt.Enabled = False
                chk_CodInt.Checked = True
            End If

        End If
    End Sub

    Private Sub rb_Marca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Marca.CheckedChanged

        If (rb_Marca.Checked = True) Then
            chk_Marca.Enabled = False
            chk_Marca.Checked = True
        Else
            If chk_Todos.Checked = False Then
                chk_Marca.Enabled = True
            End If
        End If

    End Sub

    Private Sub rb_Descripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Descripcion.CheckedChanged

        If (rb_Descripcion.Checked = True) Then
            chk_Descripcion.Enabled = False
            chk_Descripcion.Checked = True
        Else
            If chk_Todos.Checked = False Then
                chk_Descripcion.Enabled = True
            End If
        End If
    End Sub

    Private Sub rb_CodInt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_CodInt.CheckedChanged

        If (rb_CodInt.Checked = True) Then
            chk_CodInt.Enabled = False
            chk_CodInt.Checked = True
        Else
            If chk_Todos.Checked = False Then
                chk_CodInt.Enabled = True
            End If
        End If

    End Sub

    Private Sub rb_CodFab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_CodFab.CheckedChanged

        If (rb_CodFab.Checked = True) Then
            chk_CodProFa.Enabled = False
            chk_CodProFa.Checked = True
        Else
            If chk_Todos.Checked = False Then
                chk_CodProFa.Enabled = True
            End If
        End If

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_imprimir Then

            If L_alfabetico.Checked Then
                Dim r_Lis_Alf As New R_Listado_Alfabetico
                Dim c As Integer
                Dim model As String = ""
                Dim marc As String = ""
                Dim i As Integer = 1
                If chk_exist.Checked Then
                    c = 0
                Else
                    c = -1
                End If
                Dim v As Boolean = False
                If lst_Consultar.Rows(0).Cells(1).Value = "M" Then

                    If lst_Consultar.Rows.Count > 1 Then
                        marc = lst_Consultar.Rows(0).Cells(0).Value & ","
                    ElseIf lst_Consultar.Rows.Count = 1 And lst_Consultar.Rows(0).Cells(0).Value = "Todas" Then
                        marc = ""
                    Else
                        marc = lst_Consultar.Rows(0).Cells(0).Value
                    End If

                Else

                    If lst_Consultar.Rows.Count > 1 Then
                        model = lst_Consultar.Rows(0).Cells(0).Value & ","
                    ElseIf lst_Consultar.Rows.Count = 1 And lst_Consultar.Rows(0).Cells(0).Value = "Todas" Then
                        model = ""
                    Else
                        model = lst_Consultar.Rows(0).Cells(0).Value
                    End If

                End If

                While i < lst_Consultar.RowCount

                    If lst_Consultar.Rows(i).Cells(1).Value = "M" Then
                        marc = marc & lst_Consultar.Rows(i).Cells(0).Value & ","
                    Else
                        model = model & lst_Consultar.Rows(i).Cells(0).Value & ","
                    End If

                    i = i + 1
                    v = True

                End While

                If (v = True) Then
                    If model.Length > 0 Then
                        model = model.Remove(model.Length - 1)
                    End If
                    If marc.Length > 0 Then
                        marc = marc.Remove(marc.Length - 1)
                    End If
                End If

                r_Lis_Alf.valores(c, model, marc, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                r_Lis_Alf.Show()
            ElseIf L_modelo.Checked Then
                Dim r_Lis As New R_Listado_Modelo
                Dim m As String = ""
                Dim ex As String = ""
                If chk_exist.Checked Then
                    ex = "mayorcero"
                End If
                Dim v As Boolean = False
                Dim i As Integer = 0
                While i < lst_Consultar.RowCount
                    m = m & lst_Consultar.Rows(i).Cells(0).Value & ","
                    i = i + 1
                    v = True
                End While

                If (v = True) Then
                    If m.Length > 0 Then
                        m = m.Remove(m.Length - 1)
                    End If
                End If
                r_Lis.valores(ex, m, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                r_Lis.Show()
            ElseIf L_modelocant.Checked Then
                Dim r_LisC As New R_Listado_Modelo_Cantidad
                Dim m As String = ""
                Dim ex As String = ""
                If chk_exist.Checked Then
                    ex = "mayorcero"
                End If
                Dim v As Boolean = False
                Dim i As Integer = 0
                While i < lst_Consultar.RowCount
                    m = m & lst_Consultar.Rows(i).Cells(0).Value & ","
                    i = i + 1
                    v = True
                End While

                If (v = True) Then
                    If m.Length > 0 Then
                        m = m.Remove(m.Length - 1)
                    End If
                End If
                r_LisC.valores(ex, m, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                r_LisC.Show()
            ElseIf L_personalizado.Checked Then
                If rb_brand.Checked Then
                    Dim Fc As New R_Catalogo_Marca_Modelo_Corto
                    Dim FcU As New R_Catalogo_Marca_Modelo_Corto_Ubic
                    Dim F As New R_Catalogo_Marca_Modelo
                    Dim Fu As New R_Catalogo_Marca_Modelo_Ubic
                    Dim m As String = ""
                    Dim ex As Integer = 0
                    Dim order As String = ""
                    Dim ubic As String = ""
                    If chk_exist.Checked Then
                        ex = 0
                    Else
                        ex = -1
                    End If
                    Dim v As Boolean = False
                    Dim i As Integer = 0
                    If lst_Consultar.Rows(0).Cells(0).Value <> "Todas" Then
                        While i < lst_Consultar.RowCount
                            m = m & lst_Consultar.Rows(i).Cells(0).Value & ","
                            i = i + 1
                            v = True
                        End While
                    End If
                    If (v = True) Then
                        If m.Length > 0 Then
                            m = m.Remove(m.Length - 1)
                        End If
                    End If
                    If rb_Marca.Checked Then
                        order = "M"
                    ElseIf rb_CodFab.Checked Then
                        order = "CF"
                    ElseIf rb_CodInt.Checked Then
                        order = "CI"
                    ElseIf rb_Descripcion.Checked Then
                        order = "D"
                    ElseIf rb_ubic.Checked Then
                        order = "U"
                    End If

                    If F_ubic.Checked Then
                        Dim cuarto As String = ""
                        Dim estante As String = ""
                        Dim tramo As String = ""
                        If cb_cuarto.Text <> "*" Then
                            cuarto = cb_cuarto.Text + "-"
                        End If
                        If cb_estante.Text <> "*" Then
                            estante = cb_estante.Text + "-"
                        End If
                        If cb_tramo.Text <> "*" Then
                            tramo = cb_tramo.Text
                        End If
                        ubic = cb_almacen.Text + "-" + cuarto + estante + tramo
                    End If

                    Dim rescomp As String = ""
                    DatosMarcaModelo.consulta_compras_fecha_simple(dtpick2.Value, dgvinv)
                    If R_compras.Checked Then
                        Dim v2 As Boolean = False
                        Dim i2 As Integer = 0
                        While i2 < dgvinv.RowCount
                            rescomp = rescomp & dgvinv.Rows(i2).Cells(0).Value & ","
                            i2 = i2 + 1
                            v2 = True
                        End While
                        If (v2 = True) Then
                            If rescomp.Length > 0 Then
                                rescomp = rescomp.Remove(rescomp.Length - 1)
                            End If
                        End If
                    End If

                    Dim resg As String = ""
                    If CheckBox1.Checked Then
                        resg = cb_grupo2.SelectedItem.code
                    End If

                    If R_Vertical.Checked Then
                        If chk_Ubicacion.Checked Then
                            Fu.valores_CatalogoModelos_UBIC(m, chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order,  "", "", resg, rescomp, ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            Fu.Show()
                        Else
                            F.valores_CatalogoModelos(m, chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", "", resg, rescomp, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            F.Show()
                        End If

                    ElseIf R_horizontal.Checked Then
                        If chk_Ubicacion.Checked Then
                            FcU.valores_CatalogoModelos_Corto_UBIC(m, chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", "", resg, rescomp, ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            FcU.Show()
                        Else
                            Fc.valores_CatalogoModelosCorto(m, chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", "", resg, rescomp, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            Fc.Show()
                        End If

                    Else
                        MsgBox("Debe seleccionar si desea el formato en Vertical u Horizontal")
                    End If
                ElseIf rb_grupo.Checked Then
                    Dim Fc As New R_Catalogo_Marca_Modelo_Corto
                    Dim FcU As New R_Catalogo_Marca_Modelo_Corto_Ubic
                    Dim F As New R_Catalogo_Marca_Modelo
                    Dim Fu As New R_Catalogo_Marca_Modelo_Ubic
                    Dim ex As Integer = 0
                    Dim order As String = ""
                    Dim ubic As String = ""
                    If chk_exist.Checked Then
                        ex = 0
                    Else
                        ex = -1
                    End If
                    If rb_Marca.Checked Then
                        order = "M"
                    ElseIf rb_CodFab.Checked Then
                        order = "CF"
                    ElseIf rb_CodInt.Checked Then
                        order = "CI"
                    ElseIf rb_Descripcion.Checked Then
                        order = "D"
                    ElseIf rb_ubic.Checked Then
                        order = "U"
                    End If
                    If F_ubic.Checked Then
                        Dim cuarto As String = ""
                        Dim estante As String = ""
                        Dim tramo As String = ""
                        If cb_cuarto.Text <> "*" Then
                            cuarto = cb_cuarto.Text + "-"
                        End If
                        If cb_estante.Text <> "*" Then
                            estante = cb_estante.Text + "-"
                        End If
                        If cb_tramo.Text <> "*" Then
                            tramo = cb_tramo.Text
                        End If
                        ubic = cb_almacen.Text + "-" + cuarto + estante + tramo
                    End If

                    If R_Vertical.Checked Then
                        If chk_Ubicacion.Checked Then
                            Fu.valores_CatalogoModelos_UBIC("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, cb_grupo.SelectedItem.code, "", "", "", ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            Fu.Show()
                        Else
                            F.valores_CatalogoModelos("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, cb_grupo.SelectedItem.code, "", "", "", chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            F.Show()
                        End If
                    ElseIf R_horizontal.Checked Then
                        If chk_Ubicacion.Checked Then
                            FcU.valores_CatalogoModelos_Corto_UBIC("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, cb_grupo.SelectedItem.code, "", "", "", ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            FcU.Show()
                        Else
                            Fc.valores_CatalogoModelosCorto("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, cb_grupo.SelectedItem.code, "", "", "", chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                            Fc.Show()
                        End If
                    Else
                        MsgBox("Debe seleccionar si desea el formato en Vertical u Horizontal")
                    End If
                ElseIf rb_compra.Checked Then
                    If dgv_c2.Rows.Count > 0 Then
                        Dim Fc As New R_Catalogo_Marca_Modelo_Corto
                        Dim FcU As New R_Catalogo_Marca_Modelo_Corto_Ubic
                        Dim F As New R_Catalogo_Marca_Modelo
                        Dim Fu As New R_Catalogo_Marca_Modelo_Ubic
                        Dim ex As Integer = 0
                        Dim compras As String = ""
                        Dim order As String = ""
                        Dim ubic As String = ""
                        If chk_exist.Checked Then
                            ex = 0
                        Else
                            ex = -1
                        End If
                        If rb_Marca.Checked Then
                            order = "M"
                        ElseIf rb_CodFab.Checked Then
                            order = "CF"
                        ElseIf rb_CodInt.Checked Then
                            order = "CI"
                        ElseIf rb_Descripcion.Checked Then
                            order = "D"
                        ElseIf rb_ubic.Checked Then
                            order = "U"
                        End If

                        Dim v As Boolean = False
                        Dim i As Integer = 0
                        While i < dgv_c2.RowCount()
                            compras = compras & dgv_c2.Rows(i).Cells(2).Value & ","
                            i = i + 1
                            v = True
                        End While
                        If (v = True) Then
                            If compras.Length > 0 Then
                                compras = compras.Remove(compras.Length - 1)
                            End If
                        End If
                        If F_ubic.Checked Then
                            Dim cuarto As String = ""
                            Dim estante As String = ""
                            Dim tramo As String = ""
                            If cb_cuarto.Text <> "*" Then
                                cuarto = cb_cuarto.Text + "-"
                            End If
                            If cb_estante.Text <> "*" Then
                                estante = cb_estante.Text + "-"
                            End If
                            If cb_tramo.Text <> "*" Then
                                tramo = cb_tramo.Text
                            End If
                            ubic = cb_almacen.Text + "-" + cuarto + estante + tramo
                        End If
                        If R_Vertical.Checked Then
                            If chk_Ubicacion.Checked Then
                                Fu.valores_CatalogoModelos_UBIC("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", compras, "", "", ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                                Fu.Show()
                            Else
                                F.valores_CatalogoModelos("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", compras, "", "", chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                                F.Show()
                            End If

                        ElseIf R_horizontal.Checked Then
                            If chk_Ubicacion.Checked Then
                                FcU.valores_CatalogoModelos_Corto_UBIC("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", compras, "", "", ubic, chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                                FcU.Show()
                            Else
                                Fc.valores_CatalogoModelosCorto("", chk_CodProFa.Checked, 1, chk_Descripcion.Checked, chk_Marca.Checked, chk_Modelo.Checked, chk_Precio.Checked, chk_Existencia.Checked, chk_Ubicacion.Checked, chk_MarcaProducto.Checked, ex, chk_empaque.Checked, order, "", compras, "", "", chk_leyenda.Checked, chk_obs.Checked, tb_leyenda.Text, tb_obs.Text)
                                Fc.Show()
                            End If
                        Else
                            MsgBox("Debe seleccionar si desea el formato en Vertical u Horizontal")
                        End If
                    Else
                        MsgBox("Debes seleccionar las compras que deseas imprimir")
                    End If
                End If
            Else
                MsgBox("Debes seleccionar un modo de impresión")

            End If

        ElseIf e.Button Is Me.bt_salir Then
            Me.Close()
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L_personalizado.CheckedChanged
        If L_personalizado.Checked Then
            Me.GroupBox2.Enabled = True
            R_Vertical.Checked = True
        Else
            Me.GroupBox2.Enabled = False
        End If
    End Sub

   
    Private Sub rb_brand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_brand.CheckedChanged

        cb_Marcas.Enabled = True
        lst_Modelo.Enabled = True
        lst_Consultar.Enabled = True
        bt_agregar.Enabled = True
        bt_quitar.Enabled = True

        cb_grupo.Enabled = False
        dgv_c1.Rows.Clear()
        dgv_c2.Rows.Clear()
        dtpick.Enabled = False
        dgv_c1.Enabled = False
        dgv_c2.Enabled = False
        bt_add.Enabled = False
        bt_del.Enabled = False

        L_alfabetico.Enabled = True
        L_modelo.Enabled = True
        L_modelocant.Enabled = True

        GroupBox4.Enabled = True

    End Sub

    Private Sub rb_grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_grupo.CheckedChanged
        cb_Marcas.Enabled = False
        lst_Modelo.Enabled = False
        lst_Consultar.Rows.Clear()
        lst_Consultar.Enabled = False
        lst_Consultar.ClearSelection()
        bt_agregar.Enabled = False
        bt_quitar.Enabled = False

        cb_grupo.Enabled = True
      
        dgv_c1.Enabled = False
        dgv_c2.Enabled = False
        bt_add.Enabled = False
        bt_del.Enabled = False
        dgv_c1.Rows.Clear()
        dgv_c2.Rows.Clear()
        dtpick.Enabled = False

        L_alfabetico.Enabled = False
        L_modelo.Enabled = False
        L_modelocant.Enabled = False
        L_personalizado.Checked = True
        L_alfabetico.Checked = False
        L_modelo.Checked = False
        L_modelocant.Checked = False
        GroupBox4.Enabled = False

        DatosMarcaModelo.Consultar_Grupos(cb_grupo)
        cb_grupo.DroppedDown = True
    End Sub

    Private Sub rb_compra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_compra.CheckedChanged
        cb_Marcas.Enabled = False
        lst_Modelo.Enabled = False
        lst_Consultar.Rows.Clear()
        lst_Consultar.Enabled = False
        bt_agregar.Enabled = False
        bt_quitar.Enabled = False

        cb_grupo.Enabled = False

        dgv_c1.Enabled = True
        dgv_c2.Enabled = True
        bt_add.Enabled = True
        bt_del.Enabled = True
        dtpick.Enabled = True

        L_alfabetico.Enabled = True
        L_modelo.Enabled = True
        L_modelocant.Enabled = True

        L_alfabetico.Enabled = False
        L_modelo.Enabled = False
        L_modelocant.Enabled = False
        L_personalizado.Checked = True
        L_alfabetico.Checked = False
        L_modelo.Checked = False
        L_modelocant.Checked = False
        GroupBox4.Enabled = False

        DatosMarcaModelo.consulta_compras_fecha(dtpick.Value, dgv_c1, dgv_c2)


    End Sub

    Private Sub dtpick_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpick.ValueChanged
        DatosMarcaModelo.consulta_compras_fecha(dtpick.Value, dgv_c1, dgv_c2)
    End Sub

    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click
        If dgv_c1.SelectedRows.Count > 0 Then
            Dim i As Integer = 0
            While i < dgv_c1.SelectedRows.Count
                dgv_c2.Rows.Add(dgv_c1.SelectedRows(i).Cells(0).Value, dgv_c1.SelectedRows(i).Cells(1).Value, dgv_c1.SelectedRows(i).Cells(2).Value)
                i = i + 1
            End While
            If dgv_c1.SelectedRows.Count = dgv_c1.Rows.Count Then
                dgv_c1.Rows.Clear()
            End If
            For Each row As DataGridViewRow In dgv_c1.SelectedRows
                dgv_c1.Rows.Remove(row)
            Next
        Else
            MsgBox("Debes seleccionar la compra que deseas agregar")
        End If
    End Sub

    Private Sub bt_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_del.Click
        If dgv_c2.SelectedRows.Count > 0 Then
            Dim i As Integer = 0
            While i < dgv_c2.SelectedRows.Count
                dgv_c1.Rows.Add(dgv_c2.SelectedRows(i).Cells(0).Value, dgv_c2.SelectedRows(i).Cells(1).Value, dgv_c2.SelectedRows(i).Cells(2).Value)
                i = i + 1
            End While
            If dgv_c2.SelectedRows.Count = dgv_c2.Rows.Count Then
                dgv_c2.Rows.Clear()
            End If
            For Each row As DataGridViewRow In dgv_c2.SelectedRows
                dgv_c2.Rows.Remove(row)
            Next
        Else
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            cb_grupo2.Enabled = True
            DatosMarcaModelo.Consultar_Grupos(cb_grupo2)
            cb_grupo2.DroppedDown = True
        End If
        
    End Sub

    Private Sub chk_Ubicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Ubicacion.CheckedChanged
        If chk_Ubicacion.Checked Then
            Me.rb_ubic.Enabled = True
        Else
            Me.rb_ubic.Enabled = False
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedValueChanged
        F_ubic.Checked = True
        DatosProducto.llenar_cuartos(cb_cuarto, cb_almacen.SelectedValue)

    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedValueChanged
        F_ubic.Checked = True
        DatosProducto.llenar_estantes(cb_estante, cb_cuarto.SelectedValue)

    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedValueChanged
        F_ubic.Checked = True
        DatosProducto.llenar_tramos(cb_tramo, cb_estante.SelectedValue)

    End Sub

    Private Sub F_ubic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F_ubic.CheckedChanged
        If F_ubic.Checked Then
            GroupBox6.Enabled = True
        Else
            GroupBox6.Enabled = False
        End If
    End Sub

    Private Sub dtpick2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpick2.ValueChanged
        If R_compras.Checked = False Then
            R_compras.Checked = True
        End If

        If F_ubic.Checked Then
            F_ubic.Checked = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_obs.CheckedChanged

        If chk_obs.Checked Then
            tb_obs.Enabled = True
            DatosConfiguracion.consulta_obs(tb_obs.Text, 1)
        Else
            tb_obs.Clear()
            tb_obs.Enabled = False
        End If

    End Sub



    Private Sub chk_leyenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_leyenda.CheckedChanged

        If chk_leyenda.Checked Then
            tb_leyenda.Enabled = True
            DatosConfiguracion.consulta_obs(tb_leyenda.Text, 2)
        Else
            tb_leyenda.Clear()
            tb_leyenda.Enabled = False
        End If

    End Sub

End Class