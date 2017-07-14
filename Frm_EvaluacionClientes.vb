Public Class Frm_EvaluacionClientes

    Public down As Boolean = False
    Public up As Boolean = False
    Public Selected As Boolean = False
    Public enter1 As Boolean = False
    Dim texto As String = ""

    Private Sub Frm_EvaluacionClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click, GroupBox1.GotFocus
        DGV_Indicadores.ClearSelection()
        DGV_Marcas.ClearSelection()
        DGV_NC.ClearSelection()
        DGV_Pendiente.ClearSelection()
        DGV_Ventas.ClearSelection()
    End Sub


    Private Sub Frm_EvaluacionClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario
        Me.Sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, 0)
        DateTimePicker1.Value = CDate("01/" & Month(Today).ToString & "/" & Year(Today).ToString)
        bt_evaluar_Click(bt_evaluar, New EventArgs)

    End Sub

    Private Sub bt_evaluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluar.Click

        If DateTimePicker1.Value <= DateTimePicker2.Value Then

            If RadioButton1.Checked Then

                DatosDSS.DGV_VentasMarcasCliente(DGV_Marcas, DateTimePicker1.Value, DateTimePicker2.Value, 0, 0, lbl_marca.Text)
                DatosDSS.DGV_NotasCliente(DGV_NC, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, lbl_NC.Text, lbl_totalNCPend.Text, Label7.Text, Label12.Text)
                DatosDSS.DGV_CobranzasCliente(DGV_Pendiente, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, lbl_pendiente.Text)
                lb_totalPendientes.Text = DGV_Pendiente.RowCount
                If chk_group.Checked Then

                    DatosDSS.DGV_VentasCliente(DGV_Ventas, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 3, 0, lbl_ventas.Text, lbl_totalClientes.Text)
                    Dim acum As Integer = 0

                    For cont As Integer = 0 To DGV_Ventas.RowCount - 1

                        acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(0).Value.ToString.Split(" ")(0))

                    Next

                    lb_totalFact.Text = acum.ToString

                Else
                    DatosDSS.DGV_VentasCliente(DGV_Ventas, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, lbl_ventas.Text, lbl_totalClientes.Text)
                    lb_totalFact.Text = DGV_Ventas.RowCount
                End If

                DatosDSS.VentasPorMesCliente(UserControl11.Chart1, 0, 0, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, DateDiff(DateInterval.Month, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) + 1)
                If DGV_Pendiente.RowCount > 0 Then
                    If DGV_Ventas.RowCount > 0 Then
                        DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, CInt(DGV_Pendiente.Rows(0).Cells(3).Value), CDbl(lbl_ventas.Text) / DGV_Ventas.RowCount)
                    Else
                        DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, CInt(DGV_Pendiente.Rows(0).Cells(3).Value), 0)
                    End If
                Else
                    If DGV_Ventas.RowCount > 0 Then
                        DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, 0, CDbl(lbl_ventas.Text) / DGV_Ventas.RowCount)
                    Else
                        DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, 0, 0)
                    End If
                End If

            Else

                If lb_client.SelectedIndex <> -1 Then

                    If DateTimePicker2.Value >= DateTimePicker1.Value Then

                        DatosDSS.DGV_VentasMarcasCliente(DGV_Marcas, DateTimePicker1.Value, DateTimePicker2.Value, 1, CInt(Me.cb_client.Tag), lbl_marca.Text)
                        DatosDSS.DGV_NotasCliente(DGV_NC, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), lbl_NC.Text, lbl_totalNCPend.Text, Label7.Text, Label12.Text)
                        DatosDSS.DGV_CobranzasCliente(DGV_Pendiente, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), lbl_pendiente.Text)
                        DatosDSS.DGV_VentasCliente(DGV_Ventas, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), lbl_ventas.Text, lbl_totalClientes.Text)
                        DatosDSS.VentasPorMesCliente(UserControl11.Chart1, 1, CInt(Me.cb_client.Tag), DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, DateDiff(DateInterval.Month, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) + 1)
                        If DGV_Pendiente.RowCount > 0 Then
                            If DGV_Ventas.RowCount > 0 Then
                                DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), CInt(DGV_Pendiente.Rows(0).Cells(3).Value), CDbl(lbl_ventas.Text) / DGV_Ventas.RowCount)
                            Else
                                DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), CInt(DGV_Pendiente.Rows(0).Cells(3).Value), 0)
                            End If
                        Else
                            If DGV_Ventas.RowCount > 0 Then
                                DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), 0, CDbl(lbl_ventas.Text) / DGV_Ventas.RowCount)
                            Else
                                DatosDSS.DGV_Indicadores(DGV_Indicadores, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1, CInt(Me.cb_client.Tag), 0, 0)
                            End If
                        End If

                    Else

                        MsgBox("Fechas no válidad", MsgBoxStyle.Exclamation, "Error")

                    End If

                Else

                    MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation, "Error")
                    cb_client.Focus()

                End If
            End If

            Label7.Text = DGV_NC.RowCount

        Else

            MsgBox("Período de fechas no válido", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then

            If DGV_Ventas.SelectedRows.Count > 0 Then

                cb_client.Enabled = True
                lb_client.Visible = True
                cb_client.Text = DGV_Ventas.SelectedRows(0).Cells(2).Value.ToString
                SpconsultaClienteBindingSource.Filter = "RazonSocial = '" & cb_client.Text & "'"
                lb_client.SelectedIndex = 0
                lb_client_KeyDown(lb_client, New KeyEventArgs(Keys.Enter))
                lb_client.Visible = False
                bt_evaluar_Click(bt_evaluar, New EventArgs)

            Else

                cb_client.Enabled = True
                cb_client.Focus()
                lb_client.Visible = True

            End If

        Else
            cb_client.Text = ""
            cb_client.Enabled = False
            lb_client.Visible = False
        End If
    End Sub

    Private Sub chk_group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_group.CheckedChanged
        If DGV_Ventas.RowCount > 0 Then
            If chk_group.Checked Then

                DatosDSS.DGV_VentasCliente(DGV_Ventas, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 3, 0, lbl_ventas.Text, lbl_totalClientes.Text)
                Dim acum As Integer = 0

                For cont As Integer = 0 To DGV_Ventas.RowCount - 1

                    acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(0).Value.ToString.Split(" ")(0))

                Next

                lb_totalFact.Text = acum.ToString
                lbl_totalClientes.Text = DGV_Ventas.RowCount


            Else
                DatosDSS.DGV_VentasCliente(DGV_Ventas, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0, 0, lbl_ventas.Text, lbl_totalClientes.Text)
                lb_totalFact.Text = DGV_Ventas.RowCount
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        chk_group.Visible = RadioButton1.Checked
        If RadioButton1.Checked = False Then
            chk_group.Checked = False
        End If
    End Sub

    Private Sub DGV_Ventas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Ventas.CellDoubleClick

        If e.ColumnIndex = 0 And chk_group.Checked = False Then
            Dim F13 As New Frm_Facturas_Ventas
            F13.cualVentana(2, Me.DGV_Ventas.SelectedRows(0).Cells(0).Value, Me.DGV_Ventas.SelectedRows(0).Cells(0).Value, 0, Me.DGV_Ventas.SelectedRows(0).Cells(2).Value)
            F13.Show()
            F13.tb_buscarcodigo.Enabled = False
        End If
    End Sub

    Private Sub DGV_Pendiente_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pendiente.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim F13 As New Frm_Facturas_Ventas
            F13.cualVentana(2, Me.DGV_Pendiente.SelectedRows(0).Cells(0).Value, Me.DGV_Pendiente.SelectedRows(0).Cells(0).Value, 0, Me.DGV_Pendiente.SelectedRows(0).Cells(2).Value)
            F13.Show()
            F13.tb_buscarcodigo.Enabled = False
        End If
    End Sub

    Private Sub cb_client_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_client.MouseClick
        Try
            If lb_client.Visible = False Then
                lb_client.Visible = True
                Me.SpconsultaClienteBindingSource.RemoveFilter()
                lb_client.SelectedItem = cb_client.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_client.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_client.Visible = False Then
                    Me.SpconsultaClienteBindingSource.RemoveFilter()
                    lb_client.Visible = True
                    lb_client.SelectedValue = cb_client.Text
                Else
                    If lb_client.Items.Count > 1 Then
                        lb_client.Focus()
                        lb_client.SelectedIndex = lb_client.SelectedIndex + 1
                    Else
                        cb_client.SelectionStart = 0
                        cb_client.SelectionLength = cb_client.Text.Length
                        cb_client.Focus()
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
                    cb_client.Text = lb_client.SelectedItem(1).ToString
                    cb_client.Tag = lb_client.SelectedItem(0).ToString
                    'DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, Me.tb_vendedor, True)
                    'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                Else
                    cb_client.Text = ""
                End If
                cb_client.SelectionStart = cb_client.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_client.Text.Length <= 1 Or cb_client.SelectedText <> "" Then
                    Me.SpconsultaClienteBindingSource.RemoveFilter()
                Else
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text.Substring(0, cb_client.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_client_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_client.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                If Me.cb_client.SelectedText <> "" Then
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & e.KeyChar & "%'"
                End If

                If lb_client.Items.Count = 0 Then
                    e.Handled = True
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
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

    Private Sub cb_client_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_client.GotFocus
        Try
            If cb_client.Text = "- Selecciona -" Or cb_client.Text = "" Then
                cb_client.Text = ""
                Me.SpconsultaClienteBindingSource.RemoveFilter()
                lb_client.Visible = True
            Else
                Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_client.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_client.SelectedIndex = 1 Then
                    cb_client.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_client.Visible = False
                'lb_client.SelectedIndex = 0
                cb_client.Text = lb_client.SelectedItem(1).ToString
                cb_client.Tag = lb_client.SelectedItem(0).ToString
                'FillDGV()
                'DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, Me.tb_vendedor, cambio)
                'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                cb_client.Focus()
                cb_client.SelectionStart = cb_client.Text.Length
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_client_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_client.MouseClick
        Try
            lb_client.Visible = False
            'lb_client.SelectedIndex = 0
            cb_client.Text = lb_client.SelectedItem(1).ToString
            cb_client.Tag = lb_client.SelectedItem(0).ToString
            'DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, Me.tb_vendedor, True)
            'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
            cb_client.Focus()
            cb_client.SelectionStart = cb_client.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

End Class