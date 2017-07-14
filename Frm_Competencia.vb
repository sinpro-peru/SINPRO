Public Class Frm_Competencia

    Dim b As Integer = 0
    Dim numero As Integer = 0

    Private Sub Frm_Competencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        dd_buscar.Items.Add("Rif")
        dd_buscar.Items.Add("Razón Social")
        dd_buscar.SelectedIndex = 0
        DatosCompetencia.consulta_empresas(DGV_competencia)
        DGV_competencia.ClearSelection()
        tb_buscarcodigo.Focus()


    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is bt_nuevo Then
            b = 0
            ToolBar1.Enabled = False
            tb_rif.Clear()
            tb_telefono.Clear()
            tb_razonsocial.Clear()
            tb_rif.ReadOnly = False
            tb_razonsocial.ReadOnly = False
            tb_telefono.ReadOnly = False
            bt_aceptar.Visible = True
            bt_cancelar.Visible = True
            DGV_Productos.Rows.Clear()
            DGV_competencia.ClearSelection()
            tb_rif.Focus()
            tb_rif.SelectAll()
        ElseIf e.Button Is bt_modificar Then
            b = 1

            If DGV_competencia.SelectedRows.Count > 0 Then
                ToolBar1.Enabled = False
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                tb_razonsocial.ReadOnly = False
                tb_telefono.ReadOnly = False
                DGV_competencia.Enabled = False
                bt_eliminapro.Visible = True
                tb_razonsocial.Focus()
                tb_razonsocial.SelectAll()
            Else
                MsgBox("Debe seleccionar la empresa que desea modificar", MsgBoxStyle.Exclamation, "Advertencia")
            End If


        ElseIf e.Button Is bt_eliminar Then
            If DGV_competencia.SelectedRows.Count > 0 Then

                Dim response As MsgBoxResult

                response = MsgBox("¿Está seguro de eliminar la empresa " & tb_razonsocial.Text & "?", MsgBoxStyle.YesNo, "Confirmar Eliminación")

                If (response = MsgBoxResult.Yes) Then

                    DatosCompetencia.elimina_empresa(DGV_competencia.SelectedRows(0).Cells(0).Value)
                    DatosCompetencia.consulta_empresas(DGV_competencia)
                    tb_rif.Clear()
                    tb_telefono.Clear()
                    tb_razonsocial.Clear()
                    DGV_Productos.Rows.Clear()
                    DGV_competencia.ClearSelection()

                End If

            Else
                MsgBox("Debe seleccionar la empresa que desea eliminar", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        ElseIf e.Button Is bt_agregar1 Then


            bt_agregar_Click(bt_agregar1, New System.EventArgs)

        ElseIf e.Button Is bt_asociar Then

            'Dim frm As New Frm_Asociacion_Producto
            'frm.recibir(tb_rif.Text, tb_razonsocial.Text)
            'frm.Show()

        ElseIf e.Button Is bt_salir Then

            Me.Close()

            End If

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If b = 0 Then
            DatosCompetencia.Inserta_Empresa(tb_rif.Text, tb_razonsocial.Text, tb_telefono.Text)

        ElseIf b = 1 Then
            bt_eliminapro.Visible = False
            DatosCompetencia.modificar_Empresa(tb_rif.Text, tb_razonsocial.Text, tb_telefono.Text)
            DGV_competencia.Enabled = True
        End If

        DatosCompetencia.consulta_empresas(DGV_competencia)
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        tb_rif.ReadOnly = True
        tb_telefono.ReadOnly = True
        tb_razonsocial.ReadOnly = True
        ToolBar1.Enabled = True

        For cont As Integer = 0 To DGV_competencia.RowCount - 1
            If DGV_competencia.Rows(cont).Cells(0).Value.ToString = tb_rif.Text Then
                DGV_competencia.Rows(cont).Selected = True
                DGV_competencia_Click(DGV_competencia, New System.EventArgs)
                cont = DGV_competencia.RowCount
            End If
        Next

    End Sub

    Private Sub DGV_competencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_competencia.Click, DGV_competencia.KeyDown, DGV_competencia.KeyUp
        Try

            tb_rif.Text = DGV_competencia.SelectedRows(0).Cells(0).Value
            tb_razonsocial.Text = DGV_competencia.SelectedRows(0).Cells(1).Value
            tb_telefono.Text = DGV_competencia.SelectedRows(0).Cells(2).Value

            DatosCompetencia.consulta_productos_empresas(DGV_Productos, tb_rif.Text)
            DGV_Productos.ClearSelection()

            dd_buscar.Items.Clear()

            If DGV_Productos.RowCount > 0 Then

                dd_buscar.Items.Add("Rif")
                dd_buscar.Items.Add("Razón Social")
                dd_buscar.Items.Add("Cod.Importación")
                dd_buscar.Items.Add("Cod.Fábrica")
                dd_buscar.Items.Add("Cod.OEM")
                dd_buscar.Items.Add("Descripción")
                dd_buscar.Items.Add("Marca")

            Else

                dd_buscar.Items.Clear()
                dd_buscar.Items.Add("Rif")
                dd_buscar.Items.Add("Razón Social")

            End If

            dd_buscar.SelectedIndex = 0

        Catch ex As Exception

        End Try



    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If tb_rif.Text <> "" Then

            Dim frm As New Frm_Competencia_Productos
            frm.competecia(tb_rif.Text, tb_razonsocial.Text, DGV_competencia.SelectedRows(0).Index, DGV_competencia, DGV_Productos)
            frm.Show()

        Else

            MsgBox("Debe seleccionar una empresa para poder agregarle productos", MsgBoxStyle.Exclamation, "Error")

        End If


    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        tb_rif.ReadOnly = True
        tb_telefono.ReadOnly = True
        tb_razonsocial.ReadOnly = True
        tb_telefono.Clear()
        tb_rif.Clear()
        tb_razonsocial.Clear()
        DGV_competencia.Enabled = True
        bt_eliminapro.Visible = False
        ToolBar1.Enabled = True
        DGV_competencia.ClearSelection()
        DGV_Productos.Rows.Clear()

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown

        If e.KeyData = Keys.Enter Then

            If DGV_competencia.RowCount > 0 Then

                DGV_competencia.Rows(0).Cells(0).Selected = True
                DGV_competencia_Click(DGV_competencia, New System.EventArgs)

            End If

        ElseIf e.KeyData = Keys.Control Then

            dd_buscar.Focus()

        End If

    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If dd_buscar.SelectedIndex <= 1 Then

            If tb_buscarcodigo.Text <> "" Then

                If dd_buscar.SelectedIndex = 0 Then

                    DatosCompetencia.consulta_empresas_like(DGV_competencia, tb_buscarcodigo.Text, "", 0)
                    DGV_competencia.ClearSelection()
                    DGV_Productos.ClearSelection()
                    DGV_Productos.Rows.Clear()
                    bt_cancelar_Click(bt_cancelar, New System.EventArgs)


                ElseIf dd_buscar.SelectedIndex = 1 Then

                    DatosCompetencia.consulta_empresas_like(DGV_competencia, "", tb_buscarcodigo.Text, 1)
                    DGV_competencia.ClearSelection()
                    DGV_Productos.ClearSelection()
                    DGV_Productos.Rows.Clear()
                    bt_cancelar_Click(bt_cancelar, New System.EventArgs)


                End If

            Else

                DatosCompetencia.consulta_empresas(DGV_competencia)
                DGV_competencia.ClearSelection()
                DGV_Productos.ClearSelection()
                DGV_Productos.Rows.Clear()
                bt_cancelar_Click(bt_cancelar, New System.EventArgs)


            End If
           
        Else

            If tb_buscarcodigo.Text <> "" Then

                If dd_buscar.SelectedIndex = 2 Then

                    DatosCompetencia.consulta_productos_like(DGV_Productos, tb_buscarcodigo.Text, "", "", "", "", tb_rif.Text, 2)
                    DGV_Productos.ClearSelection()

                ElseIf dd_buscar.SelectedIndex = 3 Then

                    DatosCompetencia.consulta_productos_like(DGV_Productos, "", tb_buscarcodigo.Text, "", "", "", tb_rif.Text, 3)
                    DGV_Productos.ClearSelection()

                ElseIf dd_buscar.SelectedIndex = 4 Then

                    DatosCompetencia.consulta_productos_like(DGV_Productos, "", "", tb_buscarcodigo.Text, "", "", tb_rif.Text, 4)
                    DGV_Productos.ClearSelection()

                ElseIf dd_buscar.SelectedIndex = 5 Then

                    DatosCompetencia.consulta_productos_like(DGV_Productos, "", "", "", tb_buscarcodigo.Text, "", tb_rif.Text, 5)
                    DGV_Productos.ClearSelection()

                ElseIf dd_buscar.SelectedIndex = 6 Then

                    DatosCompetencia.consulta_productos_like(DGV_Productos, "", "", "", "", tb_buscarcodigo.Text, tb_rif.Text, 6)
                    DGV_Productos.ClearSelection()
                End If

            Else

                DatosCompetencia.consulta_productos_empresas(DGV_Productos, tb_rif.Text)
                DGV_Productos.ClearSelection()

            End If

        End If


    End Sub

    Private Sub dd_buscar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dd_buscar.SelectedIndexChanged

        If dd_buscar.SelectedIndex > 1 Then

            DGV_competencia.Enabled = False

        Else

            DGV_competencia.Enabled = True
        End If
    End Sub

    Private Sub bt_eliminapro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminapro.Click

        If DGV_Productos.SelectedRows.Count > 0 Then
            DatosCompetencia.eliminar_producto_competencia(tb_rif.Text, DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, DGV_Productos.SelectedRows(0).Cells(2).Value)
            DGV_Productos.Rows.RemoveAt(DGV_Productos.CurrentRow.Index)
        Else
            MsgBox("Debe seleccionar el prodcuto que desea eliminar", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub


    Public Sub recibe_num(ByVal num As Integer, ByVal dgvC As DataGridView, ByVal dgvP As DataGridView)
        DGV_competencia = dgvC
        DGV_Productos = dgvP
        numero = num
        DGV_competencia.Rows(numero).Selected = True
        DGV_competencia_Click(DGV_competencia, New System.EventArgs)

    End Sub
End Class