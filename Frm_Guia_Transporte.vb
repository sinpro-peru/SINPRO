Public Class Frm_Guia_Transporte

    Private c As New Collection
    Private boton As Integer = 0
    Private col As New Collection
    Private eliminados As New Collection
    Private iplaca As Integer = 0
    Dim aca As Boolean = False

    Private Sub Form35_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Dd_guia.Items.Add("Cod.Guía")
        Dd_guia.Items.Add("Transporte")
        Dd_guia.Items.Add("Factura")
        Dd_guia.Items.Add("Cliente")
        Dd_guia.SelectedIndex = 0
        DatosGuiaTransporte.consulta_guías(Dgv_guias)
        Dgv_guias.ClearSelection()
        DGV_Fac.Rows.Clear()
        DGV_Guia.ClearSelection()

        DGV_Guia.Columns(0).ReadOnly = True
        DGV_Guia.Columns(2).ReadOnly = True
        DGV_Guia.Columns(3).ReadOnly = True
        DGV_Guia.Columns(4).ReadOnly = True
        DGV_Guia.Columns(5).ReadOnly = True
        DGV_Guia.Columns(6).ReadOnly = True
        DGV_Guia.Columns(7).ReadOnly = False
        DGV_Guia.AllowUserToDeleteRows = False
        DGV_Guia.AllowUserToAddRows = False

        Me.Lb_asoc.Location = New System.Drawing.Point(388, 192)
        Me.lb_total.Location = New System.Drawing.Point(893, 195)
        Me.lb_totalFact.Location = New System.Drawing.Point(983, 195)
        Me.DGV_Guia.Location = New System.Drawing.Point(388, 210)
        Me.DGV_Guia.Size = New System.Drawing.Size(631, 442)

        tb_buscarcodigo.Focus()

    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click

        If cb_Transporte.SelectedIndex <> -1 Then

            If cb_Transporte.SelectedItem.code = 6 And DGV_Guia.RowCount >= 10 And (My.Settings.Empresa = 2 Or My.Settings.Empresa = 3) Then

                MsgBox("No se pueden asociar más de 10 facturas por guía de TCP")

            Else

                Dim fila As Integer = 0
                Dim cont2 As Boolean = False
                Dim cont As Integer = 0

                While cont < (DGV_Fac.SelectedRows.Count)

                    If Not DGV_Fac.SelectedRows(cont).Cells(5).Value = "" Then

                        If Not estaenDGV(CInt(DGV_Fac.SelectedRows(cont).Cells(1).Value), DGV_Guia) Then

                            Me.DGV_Guia.Rows.Add(ObtenerValoresFila(DGV_Fac.SelectedRows(cont)))

                            DGV_Fac.Rows.Remove(DGV_Fac.SelectedRows(0))

                        Else
                            MsgBox("La factura ya se encuentra en la selección", MsgBoxStyle.Exclamation, "Mensaje de error")
                        End If

                    Else
                        MsgBox("No se puede agregar ninguna factura a la guía de trasporte que no posea bultos asociados.")
                    End If

                    cont = cont + 1

                End While

                lb_totalFact.Text = DGV_Guia.RowCount.ToString

                DGV_Guia.ClearSelection()

            End If

        Else

            MsgBox("Debe seleccionar un transporte", MsgBoxStyle.Exclamation, "SINPRO")

        End If


    End Sub

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()

        Dim direccion As String = ""
        Dim rif As String = ""
        Dim tlf As String = ""
        Dim ciudad As String = ""
        Dim Contenido(Me.DGV_Fac.ColumnCount + 4) As String
        For Ndx As Integer = 0 To (Contenido.Length - 6)
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        DatosGuiaTransporte.consulta_cliente_direccion(Contenido(3), direccion, rif, tlf, ciudad)
        Contenido(8) = direccion
        Contenido(9) = rif
        Contenido(7) = DatosGuiaTransporte.Consulta_FletePago(Contenido(3))
        Contenido(10) = tlf
        Contenido(11) = ciudad
        Contenido(12) = fila.Cells(7).Value
        Return Contenido

    End Function

    Function estaenDGV(ByVal valor As Integer, ByVal dgv As DataGridView) As Boolean
        Dim cont As Integer = 0
        Dim esta As Boolean = False
        For cont = 0 To dgv.RowCount - 1
            If valor = CInt(dgv.Rows(cont).Cells(1).Value) Then
                esta = True
            End If
        Next
        Return esta
    End Function

    Public Sub borrarRepetidos()

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        For cont = 0 To DGV_Guia.RowCount - 1
            For cont2 = 0 To DGV_Fac.RowCount - 1
                If CInt(DGV_Fac.Rows(cont2).Cells(1).Value) = CInt(DGV_Guia.Rows(cont).Cells(1).Value) Then
                    'DGV_Fac.Rows.Remove(DGV_Fac.Rows(cont))
                    'DGV_Fac.Rows.RemoveAt(cont)
                    DGV_Fac.Rows(cont2).Visible = False
                End If

            Next
        Next

    End Sub

    Public Sub RestaurarFact(ByVal valor As Integer)

        Dim cont As Integer = 0
        For cont = 0 To DGV_Fac.RowCount - 1
            If CInt(DGV_Fac.Rows(cont).Cells(1).Value) = valor Then
                DGV_Fac.Rows(cont).Visible = True
            End If
        Next

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.lb_totalFact.Text = 0
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        bt_agregar.Visible = False
        eliminados.Clear()
        cb_Transporte.Enabled = False
        cb_Transporte.Items.Clear()
        cb_Transportistas.Enabled = False
        cb_Transportistas.Items.Clear()
        tb_camion.Enabled = False
        tb_camion.Items.Clear()
        boton = 0
        tb_aprobada.Clear()
        tb_aprobada.Enabled = False
        tb_ci.Clear()
        tb_ci.Enabled = False
        tb_elaborada.Clear()
        tb_elaborada.Enabled = False
        tb_observ.Clear()
        tb_observ.Enabled = False
        tb_puntos.Clear()
        tb_puntos.Enabled = False
        tb_codigo.Clear()
        cb_Transporte.Text = ""
        cb_Transporte.ResetText()
        DGV_Guia.Rows.Clear()
        Dgv_guias.Enabled = True
        DGV_Guia.Columns(7).ReadOnly = True
        DGV_Fac.Rows.Clear()
        Me.Lb_asoc.Location = New System.Drawing.Point(388, 192)
        Me.lb_total.Location = New System.Drawing.Point(893, 195)
        Me.lb_totalFact.Location = New System.Drawing.Point(983, 195)
        Me.DGV_Guia.Location = New System.Drawing.Point(388, 210)
        Me.DGV_Guia.Size = New System.Drawing.Size(631, 442)


        DGV_Guia.AllowUserToDeleteRows = False
        DGV_Guia.AllowUserToAddRows = False
        dtp1.Enabled = False
        dtp1.Value = Today


    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Try
            Dim sw As Boolean = False

            If boton = 1 Then

                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 5 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                    DGV_Guia.Columns(7).ReadOnly = True
                    Dim cont As Integer = 0

                    For cont = 0 To DGV_Guia.RowCount - 1
                        DatosGuiaTransporte.actualiza_Factura(CInt(DGV_Guia.Rows(cont).Cells(1).Value))
                    Next

                    MELDataSet.EnforceConstraints = True
                    Dim r_guia As New R_GuiaTransporte
                    r_guia.valores_GuiaTransporte(Me.DGV_Guia(1, 0).Value, Me.DGV_Guia, Me.cb_Transportistas.Text, Me.tb_camion.Text, Me.tb_elaborada.Text, Me.tb_ci.Text, tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), Me.tb_aprobada.Text, Me.tb_observ.Text, Me.tb_puntos.Text, CInt(tb_codigo.Text))
                    r_guia.trans = cb_Transporte.Text
                    r_guia.Show()
                    r_guia.TopMost = True
                    R_GuiaDesglosada.valores(Me.DGV_Guia)
                    R_GuiaDesglosada.Show()
                    R_GuiaDesglosada.TopMost = True

                    Dim cod As Integer = DatosGuiaTransporte.inserta_guia_transporte(CInt(cb_Transporte.SelectedItem.code), CInt(cb_Transportistas.SelectedItem.code), tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), tb_ci.Text, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, DGV_Guia, tb_puntos.Text, tb_codigo.Text, dtp1.Value)

                    Datos.Inserta_Actividad("Creó la guía de transporte nro. " + cod.ToString)

                Else

                    If cb_Transporte.SelectedItem.code = 6 And DGV_Guia.RowCount > 10 Then

                        MsgBox("No se pueden asociar más de 10 facturas por guía de TCP. Elimina las sobrantes y vuelve a intentarlo.")
                        sw = True
                    Else

                        DGV_Guia.Columns(7).ReadOnly = True
                        Dim cont As Integer = 0
                        For cont = 0 To DGV_Guia.RowCount - 1
                            DatosGuiaTransporte.actualiza_Factura(CInt(DGV_Guia.Rows(cont).Cells(1).Value))
                        Next

                        MELDataSet.EnforceConstraints = True
                        Dim r_guia As New R_GuiaTransporte
                        r_guia.valores_GuiaTransporte(Me.DGV_Guia(1, 0).Value, Me.DGV_Guia, Me.cb_Transportistas.Text, Me.tb_camion.Text, Me.tb_elaborada.Text, Me.tb_ci.Text, tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), Me.tb_aprobada.Text, Me.tb_observ.Text, Me.tb_puntos.Text, CInt(tb_codigo.Text))
                        r_guia.trans = cb_Transporte.Text
                        r_guia.Show()
                        r_guia.TopMost = True
                        R_GuiaDesglosada.valores(Me.DGV_Guia)
                        R_GuiaDesglosada.Show()
                        R_GuiaDesglosada.TopMost = True

                        Dim cod As Integer = DatosGuiaTransporte.inserta_guia_transporte(CInt(cb_Transporte.SelectedItem.code), CInt(cb_Transportistas.SelectedItem.code), tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), tb_ci.Text, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, DGV_Guia, tb_puntos.Text, tb_codigo.Text, dtp1.Value)

                        Datos.Inserta_Actividad("Creó la guía de transporte nro. " + cod.ToString)

                    End If

                End If

            ElseIf boton = 2 Then


                DGV_Guia.Columns(7).ReadOnly = True
                Dim cont As Integer = 0
                For cont = 0 To DGV_Guia.RowCount - 1
                    DatosGuiaTransporte.actualiza_Factura(CInt(DGV_Guia.Rows(cont).Cells(1).Value))
                Next
                For cont = 1 To eliminados.Count
                    DatosGuiaTransporte.actualiza_Factura2(eliminados(cont))
                Next

                DatosGuiaTransporte.modifica_guia_transporte(tb_observ.Text, CInt(tb_codigo.Text), dtp1.Value, 0, 0, 0)

                For cont = 0 To DGV_Guia.RowCount - 1
                    DatosGuiaTransporte.modifica_guia_transporte(tb_observ.Text, CInt(tb_codigo.Text), dtp1.Value, 1, CInt(DGV_Guia.Rows(cont).Cells(1).Value), DGV_Guia.Rows(cont).Cells(7).Value.ToString)
                Next

                Datos.Inserta_Actividad("Modificó la guía de transporte nro. " + tb_codigo.Text)

                MELDataSet.EnforceConstraints = True
                Dim r_guia As New R_GuiaTransporte
                r_guia.valores_GuiaTransporte(Me.DGV_Guia(1, 0).Value, Me.DGV_Guia, Me.cb_Transportistas.Text, Me.tb_camion.Text, Me.tb_elaborada.Text, Me.tb_ci.Text, tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), Me.tb_aprobada.Text, Me.tb_observ.Text, Me.tb_puntos.Text, CInt(tb_codigo.Text))
                r_guia.trans = cb_Transporte.Text
                r_guia.Show()
                R_GuiaDesglosada.valores(Me.DGV_Guia)
                R_GuiaDesglosada.Show()


            End If

            If sw = False Then

                dtp1.Value = Today
                dtp1.Enabled = False
                bt_aceptar.Visible = False
                lb_total.Visible = False
                lb_totalFact.Visible = False
                bt_cancelar.Visible = False
                bt_agregar.Visible = False
                cb_Transporte.Enabled = False
                cb_Transportistas.Enabled = False
                cb_Transporte.Items.Clear()
                cb_Transportistas.Items.Clear()
                tb_camion.Enabled = False
                tb_camion.Items.Clear()
                tb_aprobada.Clear()
                tb_aprobada.Enabled = False
                tb_ci.Clear()
                tb_ci.Enabled = False
                tb_elaborada.Clear()
                tb_elaborada.Enabled = False
                tb_observ.Clear()
                tb_observ.Enabled = False
                tb_puntos.Clear()
                tb_puntos.Enabled = False
                DGV_Guia.Rows.Clear()
                Dgv_guias.Enabled = True
                tb_codigo.Clear()
                eliminados.Clear()
                boton = 0

                DGV_Guia.AllowUserToDeleteRows = False
                DGV_Guia.AllowUserToAddRows = False

                Me.Lb_asoc.Location = New System.Drawing.Point(388, 207)
                Me.DGV_Guia.Location = New System.Drawing.Point(388, 228)
                Me.DGV_Guia.Size = New System.Drawing.Size(631, 442)
                DatosGuiaTransporte.consulta_guías(Dgv_guias)
                Dgv_guias.ClearSelection()
                tb_buscarcodigo.Focus()
            Else

                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                bt_agregar.Visible = True
            End If

        Catch ex As Exception

            MELDataSet.EnforceConstraints = False
            MsgBox("La lista o alguno de los campos se ecuentran vacios ", MsgBoxStyle.Critical)


            bt_aceptar.Visible = True
            bt_cancelar.Visible = True
            bt_agregar.Visible = True
            DGV_Fac.Rows.Clear()
        End Try


    End Sub

    Private Sub cb_Transporte_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Transporte.Leave
        cb_Transporte.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cb_Transporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Transporte.SelectedIndexChanged
        'c collection con los codigos del transporte
        Try
            If aca = False Then
                If cb_Transporte.Items.Count > 0 Then
                    DatosGuiaTransporte.consulta_ChoferesRep(cb_Transportistas, CInt(cb_Transporte.Items(cb_Transporte.SelectedIndex).code), c)
                    DatosGuiaTransporte.consulta_camion1(tb_camion, CInt(cb_Transporte.Items(Me.cb_Transporte.SelectedIndex).code), col)
                    If cb_Transportistas.Items.Count > 0 Then
                        cb_Transportistas.SelectedIndex = 0
                    End If
                    If tb_camion.Items.Count > 0 Then
                        tb_camion.SelectedIndex = 0
                    End If
                    cb_Transportistas.Focus()
                End If
            End If


        Catch ex As Exception

        End Try



    End Sub

    Private Sub cb_Transportistas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Transportistas.SelectedIndexChanged

        Dim i As Integer

        For i = 0 To cb_Transportistas.Items.Count - 1

            If cb_Transportistas.Items(i).ToString = cb_Transportistas.Text Then

                tb_ci.Text = c.Item(i + 1).ToString
                i = cb_Transportistas.Items.Count
            End If
        Next
        If cb_Transportistas.SelectedIndex >= 0 Then
            tb_ci.Text = cb_Transportistas.Items(cb_Transportistas.SelectedIndex).code.ToString
        End If


    End Sub

    Private Sub tb_camion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer

        For i = 0 To tb_camion.Items.Count - 1

            If tb_camion.Items(i).ToString = tb_camion.SelectedItem.ToString Then

                'tb_ci.Text = c.Item(i + 1).ToString
                iplaca = i + 1
                i = cb_Transportistas.Items.Count - 1

            End If
        Next
    End Sub


    Private Sub rb_todas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todas.CheckedChanged, rb_demas.CheckedChanged, rb_Capital.CheckedChanged

        If rb_Capital.Checked Then

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 1)

        ElseIf rb_demas.Checked Then

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 2)

        Else

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)

        End If

        borrarRepetidos()
        DGV_Fac.ClearSelection()

    End Sub

    Private Sub DGV_Guia_UserDeletingRow2(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Guia.RowsRemoved

        If rb_Capital.Checked Then

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 1)

        ElseIf rb_demas.Checked Then

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 2)

        Else

            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)

        End If

        borrarRepetidos()
        DGV_Fac.ClearSelection()

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is bt_nuevo Then
            boton = 1
            aca = True
            Me.Lb_asoc.Location = New System.Drawing.Point(388, 464)
            Me.DGV_Guia.Location = New System.Drawing.Point(388, 490)
            Me.DGV_Guia.Size = New System.Drawing.Size(631, 180)
            Me.lb_totalFact.Text = 0
            Me.lb_total.Location = New System.Drawing.Point(893, 466)
            Me.lb_totalFact.Location = New System.Drawing.Point(983, 466)

            DatosGuiaTransporte.ver_transporte(cb_Transporte)
            DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)

            cb_Transporte.SelectedIndex = -1
            cb_Transportistas.SelectedIndex = -1
            lb_total.Visible = True
            lb_totalFact.Visible = True
            tb_camion.Items.Clear()
            DGV_Fac.ClearSelection()
            bt_aceptar.Visible = True
            dtp1.Enabled = True
            dtp1.Value = Today
            bt_cancelar.Visible = True
            bt_agregar.Visible = True
            cb_Transporte.Enabled = True
            cb_Transportistas.Enabled = True

            tb_aprobada.Clear()
            tb_aprobada.Enabled = True
            tb_ci.Enabled = True
            tb_elaborada.Clear()
            tb_elaborada.Text = Frm_Login.user
            tb_observ.Clear()
            tb_observ.Enabled = True
            tb_puntos.Clear()
            tb_puntos.Enabled = True
            DGV_Guia.Rows.Clear()
            Dgv_guias.Enabled = False
            tb_ci.Clear()
            DGV_Guia.ReadOnly = False
            DGV_Guia.Enabled = True
            DGV_Guia.Columns(0).ReadOnly = True
            DGV_Guia.Columns(2).ReadOnly = True
            DGV_Guia.Columns(3).ReadOnly = True
            DGV_Guia.Columns(4).ReadOnly = True
            DGV_Guia.Columns(5).ReadOnly = True
            DGV_Guia.Columns(6).ReadOnly = True
            DGV_Guia.Columns(7).ReadOnly = False
            DGV_Guia.AllowUserToDeleteRows = True

            DatosGuiaTransporte.identidad_guia(tb_codigo.Text)

            Dgv_guias.ClearSelection()

            'If cb_Transportistas.Items.Count > 0 Then
            '    cb_Transportistas.SelectedIndex = 0
            'End If
            'If tb_camion.Items.Count > 0 Then
            '    tb_camion.SelectedIndex = 0
            'End If

            cb_Transporte.Focus()

        ElseIf e.Button Is bt_modificar Then

            If Dgv_guias.SelectedRows.Count > 0 Then

                boton = 2
                DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)
                DGV_Guia.Columns(0).ReadOnly = True
                DGV_Guia.Columns(2).ReadOnly = True
                DGV_Guia.Columns(3).ReadOnly = True
                DGV_Guia.Columns(4).ReadOnly = True
                DGV_Guia.Columns(5).ReadOnly = True
                DGV_Guia.Columns(6).ReadOnly = True
                DGV_Guia.Columns(7).ReadOnly = False
                DGV_Guia.AllowUserToDeleteRows = True
                'DGV_Guia.AllowUserToAddRows = True
                lb_total.Visible = True
                lb_totalFact.Visible = True
                borrarRepetidos()
                Me.Lb_asoc.Location = New System.Drawing.Point(388, 464)
                Me.DGV_Guia.Location = New System.Drawing.Point(388, 490)
                Me.DGV_Guia.Size = New System.Drawing.Size(631, 180)
                Me.lb_total.Location = New System.Drawing.Point(893, 466)
                Me.lb_totalFact.Location = New System.Drawing.Point(983, 466)
                bt_cancelar.Visible = True
                bt_agregar.Visible = True
                bt_aceptar.Visible = True
                tb_observ.Enabled = True
                dtp1.Enabled = True
                DGV_Guia.ReadOnly = False
                DGV_Guia.Enabled = True

            Else

                MsgBox("Debe seleccionar una guía para modificarla", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        ElseIf e.Button Is bt_imprimir Then
            boton = 3
            If Dgv_guias.SelectedRows.Count > 0 Then

                Dim r_guia As New R_GuiaTransporte
                r_guia.valores_GuiaTransporte(Me.DGV_Guia(1, 0).Value, Me.DGV_Guia, Me.cb_Transportistas.Text, Me.tb_camion.Text, Me.tb_elaborada.Text, Me.tb_ci.Text, tb_camion.Items(tb_camion.SelectedIndex).name.ToString.Split("  ")(2), Me.tb_aprobada.Text, Me.tb_observ.Text, Me.tb_puntos.Text, CInt(tb_codigo.Text))
                r_guia.trans = cb_Transporte.Text

                r_guia.Show()
                R_GuiaDesglosada.valores(Me.DGV_Guia)
                R_GuiaDesglosada.Show()
            Else

                MsgBox("Debe seleccionar la guía que desea imprimir")

            End If

        ElseIf e.Button Is bt_salir Then
            Me.Close()
        End If
        aca = False
    End Sub

    Private Sub Dgv_guias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_guias.CellClick, Dgv_guias.KeyDown, Dgv_guias.KeyUp
        Try
            If Dgv_guias.RowCount > 0 Then
                aca = True
                Dim trans As String = ""
                Dim transportis As String = ""
                Dim camion As String = ""

                DatosGuiaTransporte.consulta_datos_guia(trans, transportis, camion, tb_ci.Text, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, DGV_Guia, tb_puntos.Text, CInt(Dgv_guias.SelectedRows(0).Cells(0).Value), dtp1.Value)


                ' Me.Sp_VerTransporteTableAdapter.Fill(Me.MELDataSet.sp_VerTransporte)
                DatosGuiaTransporte.ver_transporte(cb_Transporte)
                'cb_Transporte_SelectedIndexChanged(cb_Transporte, New System.EventArgs)
                DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)
                cb_Transporte.Update()
                DatosGuiaTransporte.consulta_ChoferesRep(cb_Transportistas, cb_Transporte.SelectedValue(), c)
                DatosGuiaTransporte.consulta_camion1(tb_camion, cb_Transporte.SelectedValue(), col)
                cb_Transporte.Text = trans
                DatosGuiaTransporte.consulta_ChoferesRep(cb_Transportistas, CInt(cb_Transporte.Items(cb_Transporte.SelectedIndex).code), c)
                DatosGuiaTransporte.consulta_camion1(tb_camion, CInt(cb_Transporte.Items(cb_Transporte.SelectedIndex).code), col)
                cb_Transportistas.Focus()
                cb_Transportistas.Text = transportis
                tb_camion.Text = camion
                cb_Transportistas.Text = transportis
                tb_codigo.Text = Dgv_guias.SelectedRows(0).Cells(0).Value
                DGV_Guia.ClearSelection()
                DGV_Fac.Rows.Clear()
                lb_totalFact.Text = DGV_Guia.RowCount.ToString

            End If
        Catch ex As Exception

        End Try
        aca = False

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Dgv_guias.RowCount > 0 Then
                Dgv_guias.Rows(0).Cells(0).Selected = True
                Dgv_guias_Click(Dgv_guias, New System.EventArgs)
                Dgv_guias.Focus()
            End If
        End If
    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Dgv_guias.Enabled = True Then
            If tb_buscarcodigo.Text <> "" Then

                DatosGuiaTransporte.consulta_guia_like(tb_buscarcodigo.Text, Dgv_guias, Dd_guia.SelectedIndex)

            Else

                DatosGuiaTransporte.consulta_guías(Dgv_guias)
                bt_cancelar_Click(bt_cancelar, New System.EventArgs)

            End If

            Dgv_guias.ClearSelection()

        End If



    End Sub

    Private Sub DGV_Guia_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV_Guia.UserDeletingRow
        If boton = 2 Then
            eliminados.Add(DGV_Guia.CurrentRow.Cells(1).Value)
        End If
    End Sub

End Class