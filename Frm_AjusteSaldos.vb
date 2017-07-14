Public Class Frm_AjusteSaldos

    Dim deny As Boolean = False
    Dim enter1 As Boolean = False
    Dim varboton As Integer = 0
    Dim user As String = ""

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_nuevo Then

            varboton = 1

            'DatosAjusteSaldo.DGV_Facturas(DGV_Facturas, "", 0)
            'TODO: This line of code loads data into the 'MELDataSet1.sp_consultaFactNoAjustadas' table. You can move, or remove it, as needed.
            Me.Sp_consultaFactNoAjustadasTableAdapter.Fill(Me.MELDataSet1.sp_consultaFactNoAjustadas)
            DGV_Facturas.Columns(0).Visible = False
            DGV_Facturas.ClearSelection()
            dud_buscar.Items.Clear()
            dud_buscar.Items.Add("Control Factura")
            dud_buscar.Items.Add("Número Factura")
            dud_buscar.Items.Add("Cliente")
            dud_buscar.SelectedIndex = 0
            DatosAjusteSaldo.consulta_identidadAjuste(lbl_numeroAjuste.Text)
            lbl_Usuario.Text = user
            Dgv_Ajustes.Visible = False
            DGV_Facturas.Visible = True
            lbl_codigoCliente.Text = ""
            lbl_controlFact.Text = ""
            lbl_NombreCliente.Text = ""
            ToolBar1.Enabled = False
            tb_observacion.Clear()
            tb_montoAjuste.Clear()
            dtp_fecha.Value = Today
            DGV_Recibos.Rows.Clear()
            lbl_subtotal.Text = "0,00"
            lbl_totalDif.Text = "0,00"
            lbl_totalRet.Text = "0,00"
            lbl_TotalFact.Text = "0,00"
            lbl_TotalAjuste.Text = "0,00"
            lbl_totalRecibos.Text = "0,00"
            bt_aceptar.Visible = True
            bt_cancelar.Visible = True
            gb_filtros.Visible = True
            DGV_Facturas.ClearSelection()

        ElseIf e.Button Is Me.bt_salir Then

            Me.Close()
            varboton = 4

        ElseIf e.Button Is Me.bt_modificar Then

            varboton = 2

            If Dgv_Ajustes.SelectedRows.Count > 0 Then

                tb_montoAjuste.ReadOnly = False
                lbl_Usuario.Text = user
                tb_observacion.ReadOnly = False
                dtp_fecha.Enabled = True
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                tb_observacion.Focus()
                Dgv_Ajustes.Enabled = False
                tb_observacion.SelectAll()

            Else

                MsgBox("Debe seleccionar un ajuste a modificar", MsgBoxStyle.Critical, "Error")

            End If

        ElseIf e.Button Is Me.bt_eliminar Then

            varboton = 3

            If Dgv_Ajustes.SelectedRows.Count > 0 Then

                Dim resp As Integer = MsgBox("Está seguro que desea eliminar el ajuste nro. " + Dgv_Ajustes.SelectedRows(0).Cells(0).Value.ToString + "?", MsgBoxStyle.YesNo, "Confirmación")

                If resp = vbYes Then

                    'Eliminar Ajuste
                    DatosAjusteSaldo.EliminaAjuste(CInt(Dgv_Ajustes.SelectedRows(0).Cells(0).Value))
                    MsgBox("Ajuste eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    Sp_consultaAjustesSaldosTableAdapter.Fill(Me.MELDataSet.sp_consultaAjustesSaldos, 0, "")
                    'DatosAjusteSaldo.DGV_Ajustes(Dgv_Ajustes, "", 0)
                    Dgv_Ajustes.Visible = True
                    DGV_Facturas.Visible = False
                    lbl_codigoCliente.Text = ""
                    lbl_controlFact.Text = ""
                    lbl_NombreCliente.Text = ""
                    ToolBar1.Enabled = False
                    lbl_numeroAjuste.Text = ""
                    lbl_subtotal.Text = "0,00"
                    lbl_totalDif.Text = "0,00"
                    lbl_totalRet.Text = "0,00"
                    lbl_Iva.Text = "0,00"
                    lbl_TotalAjuste.Text = "0,00"
                    ToolBar1.Enabled = True
                    lbl_TotalFact.Text = "0,00"
                    lbl_totalRecibos.Text = "0,00"
                    tb_montoAjuste.Clear()
                    tb_observacion.Clear()
                    dtp_fecha.Value = Today
                    lbl_Usuario.Text = ""
                    tb_montoAjuste.ReadOnly = True
                    tb_observacion.ReadOnly = True
                    dtp_fecha.Enabled = False
                    bt_aceptar.Visible = False
                    bt_cancelar.Visible = False
                    Dgv_Ajustes.ClearSelection()
                    DGV_Facturas.ClearSelection()
                    DGV_Facturas.Enabled = True
                    SpconsultaAjustesSaldosBindingSource.RemoveFilter()
                    tb_buscarcodigo.Clear()
                    tb_buscarcodigo.Focus()


                End If

            Else

                MsgBox("Debe seleccionar un ajuste a eliminar", MsgBoxStyle.Critical, "Error")

            End If

        End If
    End Sub

    Private Sub Frm_AjusteSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet1.sp_consultaFactNoAjustadas' table. You can move, or remove it, as needed.
        Me.Sp_consultaFactNoAjustadasTableAdapter.Fill(Me.MELDataSet1.sp_consultaFactNoAjustadas)

        'DatosAjusteSaldo.DGV_Ajustes(Dgv_Ajustes, "", 0)
        Sp_consultaAjustesSaldosTableAdapter.Fill(Me.MELDataSet.sp_consultaAjustesSaldos, 0, "")
        Dgv_Ajustes.ClearSelection()
        dtp_fecha.Value = Today
        dud_buscar.Items.Add("Número Ajuste")
        dud_buscar.Items.Add("Número Factura")
        dud_buscar.Items.Add("Control Factura")
        dud_buscar.Items.Add("Cliente")
        dud_buscar.SelectedIndex = 0

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        'DatosAjusteSaldo.DGV_Ajustes(Dgv_Ajustes, "", 0)
        Me.SpconsultaAjustesSaldosBindingSource.RemoveFilter()
        Dgv_Ajustes.Visible = True
        DGV_Facturas.Visible = False
        lbl_codigoCliente.Text = ""
        lbl_controlFact.Text = ""
        lbl_NombreCliente.Text = ""
        ToolBar1.Enabled = False
        lbl_numeroAjuste.Text = ""
        lbl_subtotal.Text = "0,00"
        lbl_totalRet.Text = "0,00"
        lbl_totalDif.Text = "0,00"
        lbl_Iva.Text = "0,00"
        lbl_TotalAjuste.Text = "0,00"
        ToolBar1.Enabled = True
        lbl_TotalFact.Text = "0,00"
        lbl_totalRecibos.Text = "0,00"
        tb_montoAjuste.Clear()
        tb_observacion.Clear()
        gb_filtros.Visible = False
        dtp_fecha.Value = Today
        lbl_Usuario.Text = ""
        DGV_Recibos.Rows.Clear()
        tb_montoAjuste.ReadOnly = True
        tb_observacion.ReadOnly = True
        dtp_fecha.Enabled = False
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        Dgv_Ajustes.ClearSelection()
        DGV_Facturas.ClearSelection()
        dud_buscar.Items.Clear()
        dud_buscar.Items.Add("Número Ajuste")
        dud_buscar.Items.Add("Número Factura")
        dud_buscar.Items.Add("Cliente")
        DGV_Facturas.Enabled = True
        Dgv_Ajustes.Enabled = True
        dud_buscar.SelectedIndex = 0
        tb_buscarcodigo.Clear()
        tb_buscarcodigo.Focus()

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If varboton = 1 Then

            Try

                If tb_observacion.Text <> "" And tb_montoAjuste.Text <> "" Then

                    Dim Prueba As Double = CDbl(tb_montoAjuste.Text)

                    'If CDbl(tb_montoAjuste.Text) <= CDbl(lbl_totalDif.Text) Then

                    'Crear Ajuste
                    DatosAjusteSaldo.InsertaAjuste(dtp_fecha.Value, lbl_Usuario.Text, CInt(DGV_Facturas.SelectedRows(0).Cells(0).Value), CDbl(tb_montoAjuste.Text), tb_observacion.Text)
                    MsgBox("Ajuste creado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    deny = True

                    'Else

                    '    MsgBox("El monto del ajuste es mayor a la diferencia", MsgBoxStyle.Exclamation, "Error")
                    '    tb_montoAjuste.Focus()
                    '    tb_montoAjuste.SelectAll()
                    '    deny = False

                Else

                    MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

                End If

            Catch ex As Exception

                MsgBox("El monto del ajuste debe ser un valor numérico", MsgBoxStyle.Exclamation, "Error")
                tb_montoAjuste.Clear()
                tb_montoAjuste.Focus()

            End Try


        ElseIf varboton = 2 Then

            Try

                If tb_observacion.Text <> "" And tb_montoAjuste.Text <> "" Then

                    Dim Prueba As Double = CDbl(tb_montoAjuste.Text)

                    'If CDbl(tb_montoAjuste.Text) <= CDbl(lbl_totalDif.Text) Then

                    'Modificar Ajuste
                    DatosAjusteSaldo.ModificaAjuste(dtp_fecha.Value, lbl_Usuario.Text, CInt(Dgv_Ajustes.SelectedRows(0).Cells(5).Value), CDbl(tb_montoAjuste.Text), CInt(lbl_numeroAjuste.Text), tb_observacion.Text)
                    MsgBox("Ajuste modificado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    deny = True

                    'Else

                    '    MsgBox("El monto del ajuste es mayor a la diferencia", MsgBoxStyle.Exclamation, "Error")
                    '    tb_montoAjuste.Focus()
                    '    tb_montoAjuste.SelectAll()
                    '    deny = False

                    'End If

                Else

                    MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

                End If


            Catch ex As Exception

                MsgBox("El monto del ajuste debe ser un valor numérico", MsgBoxStyle.Exclamation, "Error")
                tb_montoAjuste.Clear()
                tb_montoAjuste.Focus()

            End Try

        End If

        If deny Then

            'DatosAjusteSaldo.DGV_Ajustes(Dgv_Ajustes, "", 0)
            Sp_consultaAjustesSaldosTableAdapter.Fill(Me.MELDataSet.sp_consultaAjustesSaldos, 0, "")
            Dgv_Ajustes.Visible = True
            DGV_Facturas.Visible = False
            lbl_codigoCliente.Text = ""
            lbl_controlFact.Text = ""
            ToolBar1.Enabled = True
            lbl_NombreCliente.Text = ""
            lbl_numeroAjuste.Text = ""
            lbl_subtotal.Text = "0,00"
            lbl_totalRet.Text = "0,00"
            gb_filtros.Visible = False
            lbl_totalDif.Text = "0,00"
            lbl_TotalFact.Text = "0,00"
            lbl_TotalAjuste.Text = "0,00"
            lbl_totalRecibos.Text = "0,00"
            lbl_Iva.Text = "0,00"
            lbl_Usuario.Text = ""
            tb_montoAjuste.ReadOnly = True
            tb_observacion.ReadOnly = True
            tb_montoAjuste.Clear()
            tb_observacion.Clear()
            dtp_fecha.Value = Today
            dtp_fecha.Enabled = False
            bt_aceptar.Visible = False
            Dgv_Ajustes.Enabled = True
            bt_cancelar.Visible = False
            Dgv_Ajustes.ClearSelection()
            DGV_Recibos.Rows.Clear()
            DGV_Facturas.ClearSelection()
            dud_buscar.Items.Clear()
            dud_buscar.Items.Add("Número Ajuste")
            dud_buscar.Items.Add("Número Factura")
            dud_buscar.Items.Add("Cliente")
            dud_buscar.SelectedIndex = 0
            deny = False
            DGV_Facturas.Enabled = True
            ToolBar1.Enabled = True
            tb_buscarcodigo.Clear()
            tb_buscarcodigo.Focus()

        End If


    End Sub

    Private Sub tb_montoAjuste_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_montoAjuste.GotFocus
        tb_montoAjuste.SelectAll()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_montoAjuste.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = ","c Or e.KeyChar = "-"c Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_montoAjuste.KeyDown

        Try
            If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

                'If CDbl(tb_montoAjuste.Text) <= CDbl(lbl_totalDif.Text) Then
                lbl_TotalAjuste.Text = tb_montoAjuste.Text
                lbl_totalDif.Text = Format((CDbl(lbl_TotalFact.Text) - CDbl(lbl_totalRecibos.Text) + CDbl(lbl_NC.Text) + CDbl(lbl_TotalAjuste.Text) + +CDbl(lbl_totalRet.Text)), "#,##0.00")
                bt_aceptar.Focus()

                'Else

                '    MsgBox("El monto del ajuste es mayor a la diferencia", MsgBoxStyle.Exclamation, "Error")
                '    tb_montoAjuste.Focus()
                '    tb_montoAjuste.SelectAll()

                'End If

            End If
        Catch ex As Exception
            MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Critical, "Error")
            lbl_TotalAjuste.Text = "0,00"
            lbl_totalDif.Text = Format((CDbl(lbl_TotalFact.Text) - CDbl(lbl_totalRecibos.Text) + CDbl(lbl_NC.Text) + CDbl(lbl_TotalAjuste.Text) + +CDbl(lbl_totalRet.Text)), "#,##0.00")
            tb_montoAjuste.Clear()
            tb_montoAjuste.Focus()
        End Try

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown

        If e.KeyCode = Keys.Enter Then

            If DGV_Facturas.Visible Then

                If DGV_Facturas.Rows.Count > 0 Then

                    DGV_Facturas.Rows(0).Cells(1).Selected = True
                    DGV_Facturas.Focus()

                End If

            Else

                If Dgv_Ajustes.Rows.Count > 0 Then

                    Dgv_Ajustes.Rows(0).Cells(0).Selected = True
                    Dgv_Ajustes.Focus()

                End If

            End If

        End If

    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        'If DGV_Facturas.Visible Then

        '    If RadioButton1.Checked Then

        '        DatosAjusteSaldo.DGV_Facturas(DGV_Facturas, tb_buscarcodigo.Text, dud_buscar.SelectedIndex + 1)

        '    Else

        '        DatosAjusteSaldo.DGV_Facturas(DGV_Facturas, tb_buscarcodigo.Text, dud_buscar.SelectedIndex + 5)

        '    End If

        'Else

        '    'DatosAjusteSaldo.DGV_Ajustes(Dgv_Ajustes, tb_buscarcodigo.Text, dud_buscar.SelectedIndex + 1)
        '

        'End If

        CrearWhere()

        lbl_codigoCliente.Text = ""
        lbl_controlFact.Text = ""
        lbl_NombreCliente.Text = ""
        'lbl_numeroAjuste.Text = ""
        lbl_subtotal.Text = "0,00"
        lbl_totalDif.Text = "0,00"
        lbl_TotalFact.Text = "0,00"
        lbl_totalRecibos.Text = "0,00"
        lbl_Iva.Text = "0,00"
        'lbl_Usuario.Text = ""
        dtp_fecha.Value = Today
        tb_montoAjuste.Clear()
        DGV_Recibos.Rows.Clear()
        tb_observacion.Clear()
        Dgv_Ajustes.ClearSelection()
        DGV_Facturas.ClearSelection()

        tb_buscarcodigo.Focus()
        tb_buscarcodigo.SelectionStart = tb_buscarcodigo.Text.Length

    End Sub

    Private Sub DGV_Facturas_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Facturas.CellClick, DGV_Facturas.KeyUp, DGV_Facturas.KeyDown
        Try

            lbl_codigoCliente.Text = DGV_Facturas.SelectedRows(0).Cells(6).Value
            lbl_NombreCliente.Text = DGV_Facturas.SelectedRows(0).Cells(3).Value
            lbl_controlFact.Text = DGV_Facturas.SelectedRows(0).Cells(1).Value
            lbl_TotalFact.Text = Format(CDbl(DGV_Facturas.SelectedRows(0).Cells(7).Value), "#,##0.00")
            lbl_subtotal.Text = Format(CDbl(DGV_Facturas.SelectedRows(0).Cells(7).Value) * (1 - (CDbl(DGV_Facturas.SelectedRows(0).Cells(5).Value) / 100)), "#,##0.00")
            lbl_Iva.Text = Format(CDbl(lbl_subtotal.Text) * ((CDbl(DGV_Facturas.SelectedRows(0).Cells(5).Value) / 100)), "#,##0.00")
            DatosAjusteSaldo.consulta_facturas(DGV_Recibos, CInt(DGV_Facturas.SelectedRows(0).Cells(1).Value), lbl_totalRecibos.Text, lbl_NC.Text, lbl_totalRet.Text)
            lbl_totalDif.Text = Format((CDbl(lbl_TotalFact.Text) - CDbl(lbl_totalRecibos.Text) + CDbl(lbl_NC.Text) + CDbl(lbl_TotalAjuste.Text) + CDbl(lbl_totalRet.Text)), "#,##0.00")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_Facturas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Facturas.CellDoubleClick
        tb_montoAjuste.Text = Format((CDbl(lbl_totalDif.Text) * -1), "#,##0.00")
        lbl_TotalAjuste.Text = tb_montoAjuste.Text
        tb_montoAjuste.ReadOnly = False
        tb_observacion.ReadOnly = False
        dtp_fecha.Enabled = True
        DGV_Facturas.Enabled = False
        tb_observacion.Focus()
    End Sub

    Private Sub Dgv_Facturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Facturas.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            DGV_Facturas.ClearSelection()
            Dgv_Ajustes.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
            lbl_codigoCliente.Text = ""
            lbl_controlFact.Text = ""
            lbl_NombreCliente.Text = ""
            lbl_numeroAjuste.Text = ""
            lbl_subtotal.Text = "0,00"
            lbl_totalDif.Text = "0,00"
            lbl_TotalFact.Text = "0,00"
            lbl_totalRecibos.Text = "0,00"
            lbl_Iva.Text = "0,00"
            lbl_Usuario.Text = ""
            dtp_fecha.Value = Today
            tb_montoAjuste.Clear()
            DGV_Recibos.Rows.Clear()
            tb_observacion.Clear()
            Dgv_Ajustes.ClearSelection()
            DGV_Facturas.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()

        ElseIf e.KeyCode = Keys.Enter Then
            enter1 = True
            DGV_Facturas_CellDoubleClick(DGV_Facturas, New DataGridViewCellEventArgs(DGV_Facturas.CurrentCell.ColumnIndex, DGV_Facturas.CurrentCell.RowIndex))
        End If
    End Sub

    Private Sub Dgv_Ajustes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_Ajustes.KeyDown
        If e.KeyCode = Keys.ControlKey Then

            Dgv_Ajustes.ClearSelection()
            lbl_codigoCliente.Text = ""
            lbl_controlFact.Text = ""
            lbl_NombreCliente.Text = ""
            lbl_numeroAjuste.Text = ""
            lbl_subtotal.Text = "0,00"
            lbl_totalDif.Text = "0,00"
            lbl_TotalFact.Text = "0,00"
            lbl_totalRecibos.Text = "0,00"
            lbl_Iva.Text = "0,00"
            lbl_Usuario.Text = ""
            dtp_fecha.Value = Today
            tb_montoAjuste.Clear()
            DGV_Recibos.Rows.Clear()
            tb_observacion.Clear()
            Dgv_Ajustes.ClearSelection()
            DGV_Facturas.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()

        End If
    End Sub

    Private Sub Dgv_Facturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Facturas.SelectionChanged
        If enter1 = True Then
            If Dgv_Facturas.CurrentCell.RowIndex > 0 Then
                Dgv_Facturas.Rows(Dgv_Facturas.CurrentCell.RowIndex - 1).Selected = True
            Else
                DGV_Facturas.Rows(0).Cells(1).Selected = True
            End If
            enter1 = False
        End If
    End Sub

    Public Sub usuario(ByVal U As String)

        user = U

    End Sub

    Private Sub dud_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dud_buscar.SelectedIndexChanged
        tb_buscarcodigo.Focus()
        tb_buscarcodigo.Clear()
        tb_buscarcodigo.SelectAll()
    End Sub

    Private Sub Dgv_Ajustes_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Ajustes.CellClick, Dgv_Ajustes.KeyUp

        Try

            lbl_numeroAjuste.Text = Dgv_Ajustes.SelectedRows(0).Cells(0).Value.ToString
            DatosAjusteSaldo.Consulta_Ajuste(lbl_numeroAjuste.Text, lbl_Usuario.Text, lbl_controlFact.Text, lbl_codigoCliente.Text, lbl_NombreCliente.Text, tb_montoAjuste.Text, dtp_fecha.Value, tb_observacion.Text, lbl_subtotal.Text, lbl_Iva.Text, lbl_TotalFact.Text, lbl_TotalAjuste.Text)
            DatosAjusteSaldo.consulta_facturas(DGV_Recibos, CInt(lbl_controlFact.Text), lbl_totalRecibos.Text, lbl_NC.Text, lbl_totalRet.Text)
            lbl_totalDif.Text = Format((CDbl(lbl_TotalFact.Text) - CDbl(lbl_totalRecibos.Text) + CDbl(lbl_NC.Text) + CDbl(lbl_TotalAjuste.Text) + CDbl(lbl_totalRet.Text)), "#,##0.00")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        'If RadioButton2.Checked Then
        '    If DGV_Facturas.Visible Then

        '        DatosAjusteSaldo.DGV_Facturas(DGV_Facturas, tb_buscarcodigo.Text, dud_buscar.SelectedIndex + 5)

        '    End If

        'Else

        '    If DGV_Facturas.Visible Then

        '        DatosAjusteSaldo.DGV_Facturas(DGV_Facturas, tb_buscarcodigo.Text, dud_buscar.SelectedIndex + 1)
        '    End If

        'End If

        CrearWhere()

        lbl_codigoCliente.Text = ""
        lbl_controlFact.Text = ""
        lbl_NombreCliente.Text = ""
        'lbl_numeroAjuste.Text = ""
        lbl_subtotal.Text = "0,00"
        lbl_totalDif.Text = "0,00"
        lbl_TotalFact.Text = "0,00"
        lbl_totalRecibos.Text = "0,00"
        lbl_Iva.Text = "0,00"
        'lbl_Usuario.Text = ""
        dtp_fecha.Value = Today
        tb_montoAjuste.Clear()
        DGV_Recibos.Rows.Clear()
        tb_observacion.Clear()
        Dgv_Ajustes.ClearSelection()
        DGV_Facturas.ClearSelection()

        tb_buscarcodigo.Focus()
        tb_buscarcodigo.SelectionStart = tb_buscarcodigo.Text.Length
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If Dgv_Ajustes.Visible Then

            If dud_buscar.SelectedIndex = 0 Then

                where = where + y + "NumeroAjuste LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            ElseIf dud_buscar.SelectedIndex = 1 Then

                where = where + y + "NumeroFactura LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            ElseIf dud_buscar.SelectedIndex = 2 Then

                where = where + y + "ControlInicio LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            ElseIf dud_buscar.SelectedIndex = 3 Then

                where = where + y + "Cliente LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            End If


            Me.SpconsultaAjustesSaldosBindingSource.Filter = where
            Dgv_Ajustes.ClearSelection()


        Else

            If dud_buscar.SelectedIndex = 0 Then

                where = where + y + "Ctrl LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            ElseIf dud_buscar.SelectedIndex = 1 Then

                where = where + y + "Fact LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            ElseIf dud_buscar.SelectedIndex = 2 Then

                where = where + y + "Cliente LIKE '%" & tb_buscarcodigo.Text & "%'"
                y = " and "

            End If

            If RadioButton2.Checked Then

                where = where + y + "Recibos <> '0'"

            End If

            Me.SpconsultaFactNoAjustadasBindingSource.Filter = where
            DGV_Facturas.ClearSelection()

        End If

        'dud_buscar.Items.Add("Control Factura")
        'dud_buscar.Items.Add("Número Factura")
        'dud_buscar.Items.Add("Cliente")
        'DGV.Rows.Add(dr("NumeroAjuste"), dr("ControlInicio"), dr("Fecha"), dr("Cliente"), dr("Monto"), dr("NumeroFactura"))

    End Sub


End Class

