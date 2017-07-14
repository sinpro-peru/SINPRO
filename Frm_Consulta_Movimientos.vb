Public Class Frm_Consulta_Movimientos
    Dim numdepositado As String = ""
    Dim user As String = ""
    Dim tipo As Boolean = False
    Dim w As Boolean = False
    Dim e3 As Boolean = False
    Public f39 As Frm_Recibos
    Public down As Boolean = False
    Public up As Boolean = False
    Public Selected As Boolean = False
    Public enter1 As Boolean = False
    Dim texto As String = ""
    Public Sub usuario(ByVal U As String)
        user = U
    End Sub
    Private Sub Frm_Consulta_Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaClienteCombo3' table. You can move, or remove it, as needed.
        Me.Sp_consultaClienteCombo3TableAdapter.Fill(Me.MELDataSet.sp_consultaClienteCombo3)

        DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        dgv_movimientos.ClearSelection()
        If e3 = True Then
            bt_eliminar.Visible = True
        Else
            bt_eliminar.Visible = False
        End If
        rb_automatica.Checked = True

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e3 = e1
    End Sub


    Private Sub rb_banco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_banco.CheckedChanged

        If rb_banco.Checked = True Then
            DatosMovimientos.consulta_bancos_depositos(cb_bancos)
            cb_bancos.Enabled = True
            If cb_bancos.Items.Count > 0 Then
                cb_bancos.SelectedIndex = 0
            End If

            If dgv_movimientos.RowCount > 0 Then
                dgv_movimientos.Rows(0).Cells(0).Selected = True
            End If
        Else
            cb_bancos.Enabled = False
            cb_bancos.Items.Clear()
            If rb_fecha.Checked = False Then
                DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            Else
                DatosMovimientos.Consulta_Movimientos(2, dgv_movimientos, "", dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            End If
        End If

    End Sub

    Private Sub rb_fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fecha.CheckedChanged

        If rb_fecha.Checked = True Then
            dtp_desde.Enabled = True
            dtp_hasta.Enabled = True
            If rb_banco.Checked = False Then
                DatosMovimientos.Consulta_Movimientos(2, dgv_movimientos, "", dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            Else
                DatosMovimientos.Consulta_Movimientos(3, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            End If
            If dgv_movimientos.RowCount > 0 Then
                dgv_movimientos.Rows(0).Cells(0).Selected = True
            End If
        Else
            dtp_desde.Enabled = False
            dtp_hasta.Enabled = False
            dtp_desde.Value = Today
            dtp_hasta.Value = Today
            If rb_banco.Checked = False Then
                DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            Else
                DatosMovimientos.Consulta_Movimientos(1, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
            End If

        End If

    End Sub

    Private Sub cb_bancos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_bancos.SelectedIndexChanged

        If rb_fecha.Checked = False Then
            DatosMovimientos.Consulta_Movimientos(1, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        Else
            DatosMovimientos.Consulta_Movimientos(3, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        End If

    End Sub

    Public Sub DGV_Moviemitos_selection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_movimientos.CellClick, dgv_movimientos.KeyUp, dgv_movimientos.KeyDown
        dgv_mov_selectionchanged()
    End Sub

    Public Sub dgv_mov_selectionchanged()

        If TabControl1.SelectedIndex = 0 Then

            Dgv_cheques.Rows.Clear()

            If dgv_movimientos.SelectedRows.Count > 0 Then

                If rb_automatica.Checked = True Then

                    Dgv_factura.Rows.Clear()

                    If Not DGV_chpd Is Nothing Then
                        DGV_chpd.Rows.Clear()
                    End If

                    Dgv_factura.Columns(7).Visible = False
                    Dim rows As Integer = 0

                    If dgv_movimientos.SelectedRows(0).Cells(6).Value.ToString.Trim <> "" Then

                        If tb_limite.Text.Trim = "" Then
                            tb_limite.Text = 0
                        End If

                        If CheckBox1.Checked = True Then
                            DatosMovimientos.Consulta_Facturas_Cleitnes(CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), Dgv_factura, 1, CDbl(tb_limite.Text))
                        Else
                            DatosMovimientos.Consulta_Facturas_Cleitnes(CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), Dgv_factura, 0, 0)
                        End If

                        rows = Dgv_factura.Rows.Count

                        If ch_ret.Checked = True And tb_ret.Text <> "" Then

                            Dim ivaa As String = ""
                            DatosConfiguracion.tb_iva(ivaa)

                            Dim iva2 As Double = 0
                            iva2 = CDbl(ivaa / 100)
                            Dim sinret As Double = 0
                            Dim ret As Double = 0

                            ret = CDbl(tb_ret.Text)

                            sinret = Math.Round((CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value) * (1 + iva2)) / (1 + (iva2 * (1 - ret / 100))), 2)

                            If CheckBox1.Checked = True Then
                                DatosMovimientos.Consulta_Facturas_Cleitnes_ret(sinret, Dgv_factura, 1, CDbl(tb_limite.Text))
                            Else
                                DatosMovimientos.Consulta_Facturas_Cleitnes_ret(sinret, Dgv_factura, 0, 0)
                            End If

                            If rows < Dgv_factura.Rows.Count Then
                                Dgv_factura.Columns(7).Visible = True
                            End If

                        End If

                        If chk_top.Checked = True Then

                            If ComboBox1.SelectedIndex <> -1 And ComboBox1.Enabled = True And dgv_movimientos.SelectedRows.Count = 1 Then

                                If ch_ret.Checked = True Then

                                    Dim ivaa As String = ""
                                    DatosConfiguracion.tb_iva(ivaa)

                                    Dim iva2 As Double = 0
                                    iva2 = CDbl(ivaa / 100)
                                    Dim sinret As Double = 0
                                    Dim ret As Double = 0

                                    If tb_ret.Text = "" Then
                                        ret = 0
                                    Else
                                        ret = CDbl(tb_ret.Text)
                                    End If

                                    sinret = Math.Round((CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value) * (1 + iva2)) / (1 + (iva2 * (1 - ret / 100))), 2)

                                    DatosMovimientos.Consulta_Facturas_Clientes_Top(sinret, Dgv_factura, CInt(ComboBox1.SelectedItem), CDbl(tb_limite.Text), True)

                                Else
                                    DatosMovimientos.Consulta_Facturas_Clientes_Top(CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), Dgv_factura, CInt(ComboBox1.SelectedItem), CDbl(tb_limite.Text), False)
                                End If

                            End If

                        End If

                        DatosMovimientos.consulta_cheques_pd(CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), DGV_chpd)

                        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                            DatosRecibo.ConsultaRecibosNCPorMov(DGV_RecibosNoConfirmados, dgv_movimientos.SelectedRows(0).Cells(2).Value, CInt(dgv_movimientos.SelectedRows(0).Cells(7).Value), CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), 1)
                        End If


                    End If

                End If

                If dgv_movimientos.SelectedRows(0).Cells(5).Value.ToString.Trim <> "" And dgv_movimientos.SelectedRows(0).Cells(5).Value.ToString.Trim <> "0,00" Then

                    If rb_autoCHD.Checked Then
                        DatosMovimientos.Consulta_cheques_devueltos(CDbl(dgv_movimientos.SelectedRows(0).Cells(5).Value), Dgv_cheques)
                    Else
                        Dgv_cheques.Rows.Clear()
                    End If

                End If

            End If

            Dgv_factura.ClearSelection()

        End If

    End Sub

    Private Sub rb_automatica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_automatica.CheckedChanged
        If rb_automatica.Checked = True Then
            rb_manual.Checked = False
            CheckBox1.Checked = True
            If dgv_movimientos.SelectedRows.Count > 0 Then
                dgv_mov_selectionchanged()
            End If
            lb_client.Visible = False
        Else
            rb_manual.Checked = True
        End If

    End Sub

    Private Sub dtp_desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_desde.ValueChanged
        If rb_banco.Checked = False Then
            DatosMovimientos.Consulta_Movimientos(2, dgv_movimientos, "", dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        Else
            DatosMovimientos.Consulta_Movimientos(3, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        End If
    End Sub

    Private Sub dtp_hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_hasta.ValueChanged
        If rb_banco.Checked = False Then
            DatosMovimientos.Consulta_Movimientos(2, dgv_movimientos, "", dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        Else
            DatosMovimientos.Consulta_Movimientos(3, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        End If
    End Sub

    Private Sub rb_manual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_manual.CheckedChanged
        If rb_manual.Checked = True Then
            cb_cliente.Enabled = True
            rb_automatica.Checked = False
            Dgv_factura.Rows.Clear()
            rb_razon.Checked = True
            Dgv_factura.ClearSelection()
            Panel3.Enabled = True
            ch_ret.Checked = False
            cb_cliente.Focus()
            lb_client.Visible = True
            lb_client.BringToFront()
        Else
            rb_automatica.Checked = True
            Panel3.Enabled = False
            cb_cliente.Enabled = False
            cb_cliente.Clear()
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If DGV_RecibosNoConfirmados.RowCount = 0 Then

            If dgv_movimientos.SelectedRows.Count > 0 Then
                If Dgv_factura.SelectedRows.Count > 0 Then
                    If Dgv_factura.Columns(7).Visible = True And Dgv_factura.SelectedRows(0).Cells(7).Value = 1 Then

                        If DatosMovimientos.consulta_Contribuyente(Dgv_factura.SelectedRows(0).Cells(1).Value) Then

                            If Not IsNothing(f39) Then

                                MsgBox("Ya existe una ventana de recibos abierta, ciérrela para poder continuar", MsgBoxStyle.Exclamation, "SINPRO")

                            Else

                                f39 = New Frm_Recibos
                                For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                                    If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Recibos").ToUpper Then
                                        f39.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                                        cont = Frm_Principal.frm.Rows.Count
                                    End If
                                Next

                                f39.Show()
                                f39.frm1 = Me
                                f39.TopMost = True

                                tipo = False
                                Dim rete As Double
                                If Me.tb_ret.Text = "" Then
                                    rete = 0
                                Else
                                    rete = CDbl(Me.tb_ret.Text)
                                End If

                                f39.movimientos(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, Dgv_factura.SelectedRows(0).Cells(1).Value, CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, Dgv_factura.SelectedRows(0).Cells(3).Value, Dgv_factura.SelectedRows(0).Cells(0).Value, Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, Dgv_factura.SelectedRows(0).Cells(7).Value, rete, user)

                                If ComboBox1.Enabled Then

                                    If f39.DGV_Fact.RowCount > 0 Then

                                        f39.DGV_Fact.Rows(0).Cells(0).Selected = True
                                        For a As Integer = 0 To CInt(ComboBox1.Text)
                                            f39.DGV_Fact_CellDoubleClick(f39.DGV_Fact, New DataGridViewCellEventArgs(0, 0))
                                        Next
                                        f39.DGV_Recibos.ClearSelection()

                                    End If

                                End If

                            End If

                        Else

                            MsgBox("Este cliente no es contribuyente especial", MsgBoxStyle.Exclamation, "SINPRO")

                        End If

                    Else

                        Dim frm As New Frm_Recibos
                        frm.Show()
                        tipo = False
                        Dim rete As Double
                        rete = 0
                        frm.movimientos(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, Dgv_factura.SelectedRows(0).Cells(1).Value, CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, Dgv_factura.SelectedRows(0).Cells(3).Value, Dgv_factura.SelectedRows(0).Cells(0).Value, Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, False, rete, user)
                        If ComboBox1.Enabled Then
                            frm.DGV_Fact.Rows(0).Cells(0).Selected = True
                            For a As Integer = 0 To CInt(ComboBox1.Text) - 1
                                frm.DGV_Fact_CellDoubleClick(frm.DGV_Fact, New DataGridViewCellEventArgs(0, 0))
                            Next
                            frm.DGV_Recibos.ClearSelection()
                        End If

                    End If

                ElseIf DGV_chpd.SelectedRows.Count > 0 Then
                    Dim frm As New Frm_Recibos
                    frm.Show()
                    tipo = False
                    Dim rete As Double
                    If Me.tb_ret.Text = "" Then
                        rete = 0
                    Else
                        rete = CDbl(Me.tb_ret.Text)
                    End If
                    frm.movimientos_chpd(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, DGV_chpd.SelectedRows(0).Cells(1).Value, CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, DGV_chpd.SelectedRows(0).Cells(2).Value, DGV_chpd.SelectedRows(0).Cells(4).Value, Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, False, rete, Me.DGV_chpd)
                Else
                    MsgBox("Debe seleccionar el cliente que desea asociar", MsgBoxStyle.Critical, "SINPRO")
                End If
            Else
                MsgBox("Debe seleccionar el deposito que desea asociar", MsgBoxStyle.Critical, "SINPRO")
            End If

        Else

            MsgBox("Existe un recibo por confirmar asociado a este movimiento", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Public Sub filaBorrar(ByVal numeroDeposito As String, ByVal dgv As DataGridView, ByVal dgvf As DataGridView, ByVal linea As Integer, ByVal cd As String, ByVal td As Date, ByVal th As Date, ByVal tipoA As Boolean, ByVal dgvchpd As DataGridView, ByVal fecha As Date)
        numdepositado = numeroDeposito
        dgv_movimientos = dgv
        DGV_chpd = dgvchpd

        Dim esta As Boolean = False

        DatosMovimientos.modifica_movimientos(numeroDeposito, 1, 0, 0, esta, fecha)

        If rb_banco.Checked = True Then
            rb_banco_CheckedChanged(rb_banco, New System.EventArgs)
        ElseIf rb_fecha.Checked = True Then
            rb_fecha_CheckedChanged(rb_fecha, New System.EventArgs)
        Else
            DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
        End If
        dgv_movimientos.ClearSelection()
        dgv_movimientos.Refresh()
        If linea = Me.dgv_movimientos.Rows.Count Then
            linea = linea - 1
        End If
        If tipoA = False Then
            Dgv_factura = dgvf
        End If
        dgv_movimientos.CurrentCell = dgv.Rows(linea).Cells(1)
        dgv_movimientos.Rows(linea).Selected = True
        Me.rb_automatica.Checked = True
        dgv_mov_selectionchanged()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgv_movimientos.SelectedRows.Count > 0 Then

            If cb_cliente.Text <> "" Then

                If Not IsNothing(f39) Then

                    MsgBox("Ya existe una ventana de recibos abierta, ciérrela para poder continuar", MsgBoxStyle.Exclamation, "SINPRO")

                Else

                    f39 = New Frm_Recibos
                    For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                        If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Recibos").ToUpper Then
                            f39.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                            cont = Frm_Principal.frm.Rows.Count
                        End If
                    Next

                    f39.Show()
                    f39.frm1 = Me
                    f39.TopMost = True

                    tipo = True
                    If dgv_movimientos.SelectedRows(0).Cells(6).Value = "" Then
                        f39.movimientos(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, cb_cliente.Tag, CDbl(0), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, cb_cliente.Text, "", Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, False, 0, user)
                    Else
                        f39.movimientos(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, cb_cliente.Tag, CDbl(dgv_movimientos.SelectedRows(0).Cells(6).Value), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, cb_cliente.Text, "", Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, False, 0, user)
                    End If

                End If

            Else
                MsgBox("Debe seleccionar el cliente que desea asociar", MsgBoxStyle.Critical, "SINPRO")
                cb_cliente.Focus()
            End If

        Else
            MsgBox("Debe seleccionar el deposito que desea asociar", MsgBoxStyle.Critical, "SINPRO")
        End If
    End Sub

    Private Sub bt_chequesdev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_chequesdev.Click

        If Dgv_cheques.SelectedRows.Count > 0 Then

            If dgv_movimientos.SelectedRows(0).Cells(5).Value.ToString <> "" Then

                If rb_autoCHD.Checked Then

                    Dim frm As New Frm_Recibos
                    frm.Show()
                    frm.devueltos(Dgv_cheques.SelectedRows(0).Cells(3).Value.ToString, dgv_movimientos, Dgv_cheques, dgv_movimientos.SelectedRows(0).Cells(4).Value.ToString, Me.Dgv_factura, dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, Dgv_cheques.SelectedRows(0).Cells(0).Value.ToString)

                Else

                    If CDbl(Dgv_cheques.SelectedRows(0).Cells(2).Value) >= CDbl(dgv_movimientos.SelectedRows(0).Cells(5).Value) Then

                        Dim contribuyente As Boolean = DatosMovimientos.consulta_Contribuyente(Dgv_cheques.SelectedRows(0).Cells(4).Value)

                        Dim rete As Double
                        If Me.tb_ret.Text = "" Then
                            rete = 0
                        Else
                            rete = CDbl(Me.tb_ret.Text)
                        End If

                        Dim frm As New Frm_Recibos
                        frm.Show()
                        frm.TopMost = True

                        frm.Cheque_Dev_Desglosado(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, Dgv_cheques.SelectedRows(0).Cells(4).Value, CDbl(dgv_movimientos.SelectedRows(0).Cells(5).Value), CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value), dgv_movimientos.SelectedRows(0).Cells(0).Value, Dgv_cheques.SelectedRows(0).Cells(1).Value, Dgv_cheques.SelectedRows(0).Cells(5).Value, Me.dgv_movimientos, Me.Dgv_factura, Me.dgv_movimientos.SelectedRows(0).Index, tipo, cb_bancos.Text, dtp_desde.Value, dtp_hasta.Value, rb_fecha.Checked, rb_banco.Checked, contribuyente, rete, user, Dgv_cheques.SelectedRows(0).Cells(3).Value.ToString)

                    Else

                        MsgBox("El monto del recibo es menor al monto de la devolución", MsgBoxStyle.Critical, "Error")

                    End If

                    'Modificar recibo y colocar el monto adecuado y crear uno nuevo con el monto del CHD como cheque DEV.

                End If

            Else

                MsgBox("Debe seleccionar un egreso", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar el deposito que desea asociar", MsgBoxStyle.Critical, "SINPRO")

        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If dgv_movimientos.SelectedRows.Count > 0 Then

            Dim resp As Integer = MsgBox("Esta seguro de eliminar este movimiento?", MsgBoxStyle.YesNo, "Confirmación")

            If resp = vbYes Then

                Dim valor As Integer = dgv_movimientos.SelectedRows(0).Index
                DatosMovimientos.Eliminar_Movimiento(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString)
                dgv_movimientos.Rows.RemoveAt(valor)
                If valor = dgv_movimientos.Rows.Count Then
                    If dgv_movimientos.SelectedRows.Count > 0 Then
                        dgv_movimientos.Rows(valor - 1).Selected = True
                    End If
                Else
                    If dgv_movimientos.SelectedRows.Count > 0 Then
                        dgv_movimientos.Rows(valor).Selected = True
                    End If
                End If

            End If

        Else
            MsgBox("Debe seleccionar el deposito que desea eliminar", MsgBoxStyle.Critical, "SINPRO")
        End If

    End Sub

    Private Sub ch_ret_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_ret.CheckedChanged
        If ch_ret.Checked = True Then
            rb_automatica.Checked = True
            tb_ret.ReadOnly = False
            tb_ret.Focus()
            tb_ret.SelectAll()
        Else
            tb_ret.Clear()
            tb_ret.ReadOnly = True
            Dgv_factura.Columns(7).Visible = False
            If dgv_movimientos.SelectedRows.Count > 0 Then
                dgv_mov_selectionchanged()
            End If
        End If
    End Sub

    Private Sub tb_ret_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_ret.KeyDown
        If e.KeyData = Keys.Enter Then

            Try

                If tb_ret.Text = "" Then
                    ch_ret.Checked = False
                Else

                    If CDbl(tb_ret.Text) < 0 Or CDbl(tb_ret.Text) > 100 Then
                        MsgBox("La retención es un porcentaje, debe estar entre 0 y 100%", MsgBoxStyle.Exclamation, "SINPRO")
                        tb_ret.Focus()
                        tb_ret.SelectAll()
                    Else
                        If dgv_movimientos.SelectedRows.Count > 0 Then
                            dgv_mov_selectionchanged()
                        End If
                    End If

                    dgv_movimientos.Focus()
                    dgv_movimientos.Select()

                End If

            Catch ex As Exception

                MsgBox("La retención debe ser un valor numérico", MsgBoxStyle.Exclamation, "SINPRO")
                tb_ret.Clear()
                tb_ret.Focus()

            End Try


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DatosConfiguracion.consulta_montoAsociacion(tb_limite.Text)
            rb_automatica.Checked = True
        Else
            tb_limite.Text = "0"
            tb_limite.ReadOnly = True
        End If
        If dgv_movimientos.SelectedRows.Count > 0 Then
            dgv_mov_selectionchanged()
        End If

    End Sub

    Private Sub DGV_chpd_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_chpd.SelectionChanged
        If DGV_chpd.SelectedRows.Count > 0 Then
            Dgv_factura.ClearSelection()
        End If
    End Sub

    Private Sub Dgv_factura_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_factura.SelectionChanged
        If Dgv_factura.SelectedRows.Count > 0 Then
            If Not DGV_chpd Is Nothing Then
                DGV_chpd.ClearSelection()
            End If
        End If
    End Sub


    'Private Sub cb_cliente_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cliente.GotFocus
    '    Me.cb_cliente.DroppedDown = True
    'End Sub

    'Private Sub cb_cliente_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_cliente.KeyDown
    '    DatosPedidoCliente.entrar = False
    '    If e.KeyCode = Keys.Enter Then
    '        enter1 = True
    '        If Me.cb_cliente.SelectedIndex = -1 Then
    '            Me.cb_cliente.SelectedIndex = 0
    '        Else
    '            Me.cb_cliente.Text = Me.cb_cliente.SelectedText
    '        End If
    '    ElseIf e.KeyCode = Keys.Down Then
    '        down = True
    '    ElseIf e.KeyCode = Keys.Up Then
    '        up = True
    '    Else
    '        enter1 = False
    '        down = False
    '        up = False
    '        selected = False
    '        If Me.cb_cliente.SelectedIndex = -1 Then
    '            Me.cb_cliente.SelectionStart = Me.texto.Length
    '        Else
    '            Me.cb_cliente.SelectionStart = 0
    '        End If
    '    End If
    'End Sub

    'Private Sub cb_cliente_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cliente.SelectionChangeCommitted
    '    If Not Me.cb_cliente.SelectedIndex = -1 Then
    '        enter1 = True
    '        Me.cb_cliente.Text = Me.cb_cliente.Items.Item(Me.cb_cliente.SelectedIndex).Name
    '        cb_cliente.DroppedDown = False
    '    End If
    'End Sub

    'Private Sub cb_cliente_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cliente.TextChanged
    '    If enter1 = False Then
    '        If down = False And up = False Then
    '            If selected = False Then
    '                If cb_cliente.Text <> "" Then

    '                    If rb_cod.Checked Then
    '                        DatosPedidoCliente.consulta_clientelike(cb_cliente, cb_cliente.Text, texto, 1)
    '                    Else
    '                        DatosPedidoCliente.consulta_clientelike(cb_cliente, cb_cliente.Text, texto, 0)
    '                    End If

    '                    Me.cb_cliente.SelectionStart = Me.texto.Length
    '                Else
    '                    If rb_cod.Checked Then
    '                        DatosPedidoCliente.consulta_clientelike(cb_cliente, "", texto, 1)
    '                    Else
    '                        DatosPedidoCliente.consulta_clientelike(cb_cliente, "", texto, 0)
    '                    End If
    '                    If Me.cb_cliente.SelectedIndex = -1 Then
    '                        Me.cb_cliente.SelectionStart = Me.texto.Length
    '                    Else
    '                        Me.cb_cliente.SelectionStart = 0
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    '    cb_cliente.DroppedDown = True
    'End Sub

    Private Sub tb_limite_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_limite.KeyDown
        If e.KeyData = Keys.Enter Then
            If dgv_movimientos.SelectedRows.Count > 0 Then
                dgv_mov_selectionchanged()
            End If
            tb_limite.SelectAll()
        End If
    End Sub

    Private Sub tb_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_limite.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub tb_RET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_ret.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub chk_top_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_top.CheckedChanged

        If rb_automatica.Checked Then
            ComboBox1.Enabled = chk_top.Checked
            If chk_top.Checked = False Then
                ComboBox1.Items.Clear()
                dgv_mov_selectionchanged()
            Else
                If ComboBox1.Items.Count = 0 Then
                    ComboBox1.Items.Add("2")
                    ComboBox1.Items.Add("3")
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dgv_mov_selectionchanged()
    End Sub

    Private Sub cb_client_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_cliente.MouseClick
        Try
            If lb_client.Visible = False Then
                lb_client.Visible = True
                Me.Sp_consultaClienteCombo3BindingSource.RemoveFilter()
                lb_client.SelectedItem = cb_cliente.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_cliente.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_client.Visible = False Then
                    Me.Sp_consultaClienteCombo3BindingSource.RemoveFilter()
                    lb_client.Visible = True
                    lb_client.SelectedValue = cb_cliente.Text
                Else
                    If lb_client.Items.Count > 1 Then
                        lb_client.Focus()
                        lb_client.SelectedIndex = lb_client.SelectedIndex + 1
                    Else
                        cb_cliente.SelectionStart = 0
                        cb_cliente.SelectionLength = cb_cliente.Text.Length
                        cb_cliente.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_client.Visible = True Then
                    If lb_client.Items.Count > 1 Then
                        lb_client.Focus()
                        lb_client.SelectedIndex = lb_client.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_client.Visible Then
                lb_client.Visible = False
                If lb_client.Items.Count > 0 Then
                    'lb_client.SelectedIndex = 0
                    cb_cliente.Text = lb_client.SelectedItem(1).ToString
                    cb_cliente.Tag = lb_client.SelectedItem(0).ToString
                    'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                Else
                    cb_cliente.Text = ""
                End If
                cb_cliente.SelectionStart = cb_cliente.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_cliente.Text.Length <= 1 Or cb_cliente.SelectedText <> "" Then
                    Me.Sp_consultaClienteCombo3BindingSource.RemoveFilter()
                Else
                    Me.Sp_consultaClienteCombo3BindingSource.Filter = "razonsocial like '%" & cb_cliente.Text.Substring(0, cb_cliente.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_client_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_cliente.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "."c Then

                If Me.cb_cliente.SelectedText <> "" Then

                    If rb_cod.Checked Then
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "CodigoCliente like '" & e.KeyChar & "%'"
                    Else
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                    End If

                Else
                    If rb_cod.Checked Then
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "CodigoCliente like '" & cb_cliente.Text & e.KeyChar & "%'"
                    Else
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "razonsocial like '%" & cb_cliente.Text & e.KeyChar & "%'"
                    End If

                End If

                If lb_client.Items.Count = 0 Then
                    e.Handled = True
                    If rb_cod.Checked Then
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "CodigoCliente like '" & cb_cliente.Text & "%'"
                    Else
                        Me.Sp_consultaClienteCombo3BindingSource.Filter = "razonsocial like '%" & cb_cliente.Text & "%'"
                    End If

                Else
                    e.Handled = False
                    lb_client.Visible = True
                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                lb_client.Visible = True
            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_client_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cliente.GotFocus
        Try
            If cb_cliente.Text = "- Selecciona -" Then
                cb_cliente.Text = ""
                If rb_cod.Checked Then
                    Me.Sp_consultaClienteCombo3BindingSource.Filter = "CodigoCliente like '" & cb_cliente.Text & "%'"
                Else
                    Me.Sp_consultaClienteCombo3BindingSource.Filter = "razonsocial like '%" & cb_cliente.Text & "%'"
                End If

                lb_client.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_client.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_client.SelectedIndex = 1 Then
                    cb_cliente.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_client.Visible = False
                'lb_client.SelectedIndex = 0
                cb_cliente.Text = lb_client.SelectedItem(1).ToString
                cb_cliente.Tag = lb_client.SelectedItem(0).ToString
                'FillDGV()
                'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                cb_cliente.Focus()
                cb_cliente.SelectionStart = cb_cliente.Text.Length
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_client_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_client.MouseClick
        Try
            lb_client.Visible = False
            'lb_client.SelectedIndex = 0
            cb_cliente.Text = lb_client.SelectedItem(1).ToString
            cb_cliente.Tag = lb_client.SelectedItem(0).ToString
            'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
            cb_cliente.Focus()
            cb_cliente.SelectionStart = cb_cliente.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    Private Sub rb_razon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_razon.CheckedChanged
        cb_cliente.Focus()
        cb_cliente.SelectAll()
        lb_client.Visible = True
    End Sub

    Private Sub rb_cod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cod.CheckedChanged
        cb_cliente.Focus()
        cb_cliente.SelectAll()
        lb_client.Visible = True
    End Sub

    Private Sub DesglosarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesglosarToolStripMenuItem.Click

        If dgv_movimientos.SelectedRows(0).Cells(6).Value.ToString <> "" Then

            Dim frm As New Frm_DesglosarMov
            frm.Banco = dgv_movimientos.SelectedRows(0).Cells(0).Value.ToString
            frm.Oficina = dgv_movimientos.SelectedRows(0).Cells(1).Value.ToString
            frm.FechaMov = CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value.ToString)
            frm.desc = dgv_movimientos.SelectedRows(0).Cells(3).Value.ToString
            frm.Mov = dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString
            frm.Monto = dgv_movimientos.SelectedRows(0).Cells(6).Value.ToString
            frm.Show()
            frm.TopMost = True
            frm.frm = Me
            Me.Enabled = False

        Else

            MsgBox("No puede desglosar un egreso", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub dgv_movimientos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_movimientos.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not dgv_movimientos.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    dgv_movimientos.ClearSelection()

                    dgv_movimientos.Rows(hti.RowIndex).Selected = True
                    DGV_Moviemitos_selection(dgv_movimientos, New EventArgs)

                End If

            End If

        End If

    End Sub

    Private Sub rb_manualCHD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_manualCHD.CheckedChanged

        If rb_manualCHD.Checked Then

            tb_fact.ReadOnly = False
            tb_fact.Clear()
            tb_fact.Focus()

        Else

            tb_fact.ReadOnly = True
            tb_fact.Clear()

        End If

        If dgv_movimientos.SelectedRows.Count > 0 Then

            dgv_mov_selectionchanged()

        End If

    End Sub

    Private Sub tb_fact_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_fact.KeyDown

        If e.KeyCode = Keys.Enter Then

            If tb_fact.Text <> "" Then

                DatosMovimientos.Consulta_Recibos_Factura(tb_fact.Text, Dgv_cheques)

            End If

        End If

    End Sub

    Private Sub tb_fact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_fact.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarSubCategoria.Click
        If lb_categoria.SelectedItems.Count > 0 Then

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            bt_asociarEgreso.Enabled = False

            bt_agregarCategoria.Enabled = False

            lb_Subcategoria.ClearSelected()

            tb_nombreS.ReadOnly = False
            tb_identS.ReadOnly = False
            tb_obsS.ReadOnly = False
            bt_agregarS.Visible = True

            tb_nombreS.Focus()


        Else

            MsgBox("Debe seleccionar una categoría para asociarla", MsgBoxStyle.Exclamation, "SINPRO")

        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedIndex = 1 Then

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()
            bt_agregarS.Visible = False
            bt_agregarCat.Visible = False
            tb_nombreC.Clear()

            tb_busquedaS.Clear()
            tb_busquedaC.Clear()

            bt_agregarCategoria.Enabled = True
            bt_agregarSubCategoria.Enabled = False
            bt_asociarEgreso.Enabled = False

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True
            tb_nombreC.ReadOnly = True

            DatosMovimientos.consulta_categoria(lb_categoria, 0, "", 0)

            lb_Subcategoria.Items.Clear()

            tb_busquedaC.Focus()

        End If

    End Sub

    Private Sub tb_busquedaC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_busquedaC.KeyDown

        If e.KeyCode = Keys.Enter Then

            If lb_categoria.Items.Count > 0 Then

                lb_categoria.SelectedIndex = 0
                lb_categoria.Focus()
                lb_categoria.Select()

            End If

        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_busquedaC.TextChanged
        tb_nombreC.Clear()
        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()
        lb_Subcategoria.Items.Clear()
        DatosMovimientos.consulta_categoria(lb_categoria, 0, tb_busquedaC.Text, 2)
    End Sub

    Private Sub lb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_categoria.SelectedIndexChanged

        If lb_categoria.SelectedItems.Count > 0 Then

            tb_nombreC.Text = lb_categoria.SelectedItem.name.ToString
            tb_nombreC.ReadOnly = True
            bt_agregarCat.Visible = False

            bt_agregarCategoria.Enabled = True
            bt_asociarEgreso.Enabled = True

            bt_agregarCategoria.Enabled = True
            bt_agregarSubCategoria.Enabled = True
            bt_asociarEgreso.Enabled = False

            tb_nombreS.Clear()
            tb_identS.Clear()

            tb_obsS.Clear()

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)

        End If

    End Sub

    Private Sub lb_Subcategoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lb_Subcategoria.SelectedIndexChanged

        If lb_Subcategoria.SelectedItems.Count > 0 Then

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True
            bt_agregarS.Visible = False
            bt_asociarEgreso.Enabled = True
            bt_agregarCategoria.Enabled = True
            bt_agregarCategoria.Enabled = False

            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_Subcategoria.SelectedItem.code.ToString), tb_busquedaS.Text, 1, tb_nombreS.Text, tb_identS.Text, tb_obsS.Text)

        End If

    End Sub

    Private Sub tb_busquedaS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_busquedaS.KeyDown

        If e.KeyCode = Keys.Enter Then

            If lb_Subcategoria.Items.Count > 0 Then

                lb_Subcategoria.SelectedIndex = 0
                lb_Subcategoria.Focus()
                lb_Subcategoria.Select()

            End If

        End If

    End Sub

    Private Sub tb_busquedaS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_busquedaS.TextChanged

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        If lb_categoria.SelectedItems.Count > 0 Then
            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)
        End If

        bt_asociarEgreso.Enabled = False

    End Sub

    Private Sub bt_agregarCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCategoria.Click

        tb_nombreC.ReadOnly = False
        tb_nombreC.Clear()
        bt_agregarCat.Visible = True

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        bt_agregarCategoria.Enabled = False
        bt_agregarSubCategoria.Enabled = False
        bt_asociarEgreso.Enabled = False

        tb_nombreC.Focus()
        lb_categoria.ClearSelected()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asociarEgreso.Click

        If dgv_movimientos.SelectedRows.Count > 0 Then

            If dgv_movimientos.SelectedRows(0).Cells(5).Value.ToString.Trim <> "" Then

                If lb_Subcategoria.SelectedItems.Count > 0 Then

                    DatosMovimientos.modifica_movimientos(dgv_movimientos.SelectedRows(0).Cells(2).Value.ToString, True, CInt(lb_Subcategoria.SelectedItem.code.ToString), 1, 0, CDate(dgv_movimientos.SelectedRows(0).Cells(4).Value.ToString))

                    Dim index As Integer = 0

                    If dgv_movimientos.SelectedRows.Count > 0 Then

                        index = dgv_movimientos.SelectedRows(0).Index

                    End If

                    DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)

                    dgv_movimientos.Focus()
                    dgv_movimientos.Rows(index).Cells(0).Selected = True
                    dgv_movimientos.FirstDisplayedScrollingRowIndex = index

                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Movimiento Asociado satisfactoriamente", ToolTipIcon.Info)

                Else

                    MsgBox("Debe seleccionar una sub-categoría para asociar el movimiento", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            Else

                MsgBox("El movimiento a asociar debe ser un egreso", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar un movimiento", MsgBoxStyle.Exclamation, "SINPRO")

        End If
    End Sub

    Private Sub bt_agregarCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCat.Click

        If tb_nombreC.Text.Trim <> "" Then

            DatosMovimientos.Inserta_Categoria(tb_nombreC.Text)
            DatosMovimientos.consulta_categoria(lb_categoria, 0, "", 0)

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()

            bt_agregarCategoria.Enabled = True
            bt_agregarSubCategoria.Enabled = False
            bt_asociarEgreso.Enabled = False

            bt_agregarCat.Visible = False
            bt_agregarS.Visible = False

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

        Else

            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub bt_agregarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarS.Click

        If lb_categoria.SelectedItems.Count > 0 Then

            If tb_nombreS.Text.Trim <> "" And tb_identS.Text.Trim <> "" Then

                DatosMovimientos.Inserta_Sub_Categoria(tb_nombreS.Text, tb_identS.Text, tb_obsS.Text, CInt(lb_categoria.SelectedItem.code.ToString))
                DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)

                bt_agregarCategoria.Enabled = True
                bt_agregarSubCategoria.Enabled = True
                bt_asociarEgreso.Enabled = False

                tb_nombreS.Clear()
                tb_identS.Clear()
                tb_obsS.Clear()

                tb_nombreS.ReadOnly = True
                tb_identS.ReadOnly = True
                tb_obsS.ReadOnly = True

            Else

                MsgBox("Debe llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar una categoría para asociar", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try

            Dim index As Integer = 0

            If dgv_movimientos.SelectedRows.Count > 0 Then

                index = dgv_movimientos.SelectedRows(0).Index

            End If

            If cb_bancos.SelectedIndex <> -1 Then

                If rb_fecha.Checked = False Then
                    DatosMovimientos.Consulta_Movimientos(1, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
                Else
                    DatosMovimientos.Consulta_Movimientos(3, dgv_movimientos, CStr(cb_bancos.SelectedItem.code), dtp_desde.Value.Date, dtp_hasta.Value.Date, lbl_TotalEgresos.Text, lb_totalIngresos.Text)
                End If

            Else

                DatosMovimientos.Consulta_Movimientos(0, dgv_movimientos, "", Today, Today, lbl_TotalEgresos.Text, lb_totalIngresos.Text)

            End If

            dgv_movimientos.Focus()
            dgv_movimientos.Rows(index).Cells(0).Selected = True
            dgv_movimientos.FirstDisplayedScrollingRowIndex = index

            DGV_RecibosNoConfirmados.Rows.Clear()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Actualización exitosa", ToolTipIcon.Info)

        Catch ex As Exception


        End Try

    End Sub

    Private Sub bt_asociarRecibosNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asociarRecibosNC.Click

        If DGV_RecibosNoConfirmados.SelectedRows.Count > 0 Then

            f39 = New Frm_Recibos

            For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Recibos").ToUpper Then
                    f39.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                    cont = Frm_Principal.frm.Rows.Count
                End If
            Next

            f39.Show()

            f39.rb_pendientes.Checked = True
            f39.tb_buscarcodigo.Text = DGV_RecibosNoConfirmados.SelectedRows(0).Cells(0).Value.ToString
            f39.CrearWhere()
            f39.tb_buscarcodigo.Enabled = False
            f39.varBoton = 10
            f39.tb_buscarcodigo_KeyDown(f39.tb_buscarcodigo, New KeyEventArgs(Keys.Enter))
            f39.DGV_R_Selectedindex()

            f39.frm1 = Me
            f39.TopMost = True

        Else

            MsgBox("Debe seleccionar un recibo para asociar el movimiento", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

End Class