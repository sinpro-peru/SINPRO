Public Class Frm_relacionVentas

    Private Sub Frm_relacionVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.Tbl_Vendedor' table. You can move, or remove it, as needed.
        'Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor)
        Me.Sp_relacionFactTableAdapter.Fill(Me.MELDataSet.sp_relacionFact)
        Me.Sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, 1)
        'Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor)
        DGV_Pedidos.ClearSelection()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP1.ValueChanged, DTP2.ValueChanged

        CrearWhere()

    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        Sp_relacionFactBindingSource.RemoveFilter()

        If chk_fecha.Checked Then
            where = where + y + "Fecha >= '" & DTP1.Value.ToShortDateString & "' AND Fecha <= '" & DTP2.Value.ToShortDateString & "'"
            y = " AND "
        End If

        If rb_vend.Checked Then

            where = where + Sp_relacionFactBindingSource.Filter & y & "Nombre = '" & txt_finalVend.Text & "'"
            y = " AND "

        ElseIf rb_client.Checked Then

            where = where + Sp_relacionFactBindingSource.Filter & y & "RazonSocial = '" & cb_client.Text & "'"
            y = " AND "

        End If

        Sp_relacionFactBindingSource.Filter = where

        Dim Sum As Object
        Sum = Me.MELDataSet.sp_relacionFact.Compute("SUM(MontoTotal)", where)

        Dim Sum2 As Object
        Sum2 = Me.MELDataSet.sp_relacionFact.Compute("SUM(NC)", where)

        If Sum.GetType.ToString = "System.DBNull" Then
            Me.lbl_totalFact.Text = Format(0, "#,##0.00")
        Else
            Me.lbl_totalFact.Text = Format(CDbl(Sum), "#,##0.00")
        End If

        If Sum2.GetType.ToString = "System.DBNull" Then
            Me.Label1.Text = Format(0, "#,##0.00")
        Else
            Me.Label1.Text = Format(CDbl(Sum2), "#,##0.00")
        End If

        If Sum.GetType.ToString = "System.DBNull" Then
            Sum = 0
        End If

        If Sum2.GetType.ToString = "System.DBNull" Then
            Sum2 = 0
        End If

        Me.Label4.Text = Format(CDbl(Sum) - CDbl(Sum2), "#,##0.00")

        Dim Count As Object
        Count = Me.MELDataSet.sp_relacionFact.Compute("COUNT(ControlInicio)", where)
        Me.lbl_totalFact.Text = Count.ToString

        DGV_Pedidos.ClearSelection()

    End Sub


    '------------------------------------------------------ COMBO VENDEDOR ------------------------------------------------------'

    Private Sub txt_final_TextChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.TextChanged
        If Me.ListBox2.Visible = True Then
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & txt_finalVend.Text & "%'"
            'CrearWhere()
            'Else
            '    Me.TblClienteBindingSource.Filter = "RazonSocial LIKE '%%'"
        End If
    End Sub
    Private Sub txt_final_KeyDown2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_finalVend.KeyDown

        If e.KeyData = Keys.Down Then
            Me.ListBox2.Visible = True
            Me.ListBox2.Focus()

            If Me.ListBox2.Items.Count > 1 Then
                Me.ListBox2.SelectedIndex = 1
            End If

        ElseIf e.KeyData = Keys.Enter And Me.ListBox2.Visible Then

            Me.ListBox2.Visible = False
            If Me.ListBox2.Items.Count > 0 Then
                Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(0).ToString
                Me.Label2.Text = Me.ListBox2.SelectedValue
                CrearWhere()
                Me.ListBox2.SelectedIndex = 0
            Else
                Me.txt_finalVend.Text = ""
            End If

            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length

        End If
    End Sub
    Private Sub txt_final_KeyPress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_finalVend.KeyPress
        Me.ListBox2.Visible = True
    End Sub
    Private Sub txt_final_Focus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.GotFocus
        If Me.txt_finalVend.Text = "               --- Escriba Vendedor ---" Then
            Me.txt_finalVend.Text = ""
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & Me.txt_finalVend.Text & "%'"
            Me.ListBox2.Visible = True
        End If
    End Sub
    Public Sub ListBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyData = Keys.Up And Me.ListBox2.SelectedIndex = 0 Then
            Me.txt_finalVend.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            Me.ListBox2.Visible = False
            Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(0).ToString
            Me.Label2.Text = Me.ListBox2.SelectedValue
            CrearWhere()
            Me.ListBox2.SelectedIndex = 0
            Me.txt_finalVend.Focus()
            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
        End If
    End Sub
    Private Sub ListBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Me.ListBox2.Visible = False
        Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(0).ToString
        Me.Label2.Text = Me.ListBox2.SelectedValue
        CrearWhere()
        Me.ListBox2.SelectedIndex = 0
        Me.txt_finalVend.Focus()
        Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------


    'Combo Clientes

    Private Sub cb_client_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_client.MouseClick
        Try
            If lb_client.Visible = False Then
                lb_client.Visible = True
                Me.Sp_consultaClienteBindingSource.RemoveFilter()
                lb_client.SelectedItem = cb_client.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_client.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_client.Visible = False Then
                    Me.Sp_consultaClienteBindingSource.RemoveFilter()
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
                    CrearWhere()
                    'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                Else
                    cb_client.Text = ""
                End If
                cb_client.SelectionStart = cb_client.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_client.Text.Length <= 1 Or cb_client.SelectedText <> "" Then
                    Me.Sp_consultaClienteBindingSource.RemoveFilter()
                Else
                    Me.Sp_consultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text.Substring(0, cb_client.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_client_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_client.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                If Me.cb_client.SelectedText <> "" Then
                    Me.Sp_consultaClienteBindingSource.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.Sp_consultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & e.KeyChar & "%'"
                End If

                If lb_client.Items.Count = 0 Then
                    e.Handled = True
                    Me.Sp_consultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
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

            If cb_client.Text = "               --- Escriba Cliente ---" Then
                cb_client.Text = ""
                Me.Sp_consultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
                lb_client.Visible = True
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
                CrearWhere()
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
            CrearWhere()
            'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
            cb_client.Focus()
            cb_client.SelectionStart = cb_client.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub rb_vend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vend.CheckedChanged
        If rb_vend.Checked Then
            txt_finalVend.Enabled = True
            txt_finalVend.Focus()
        Else
            Me.txt_finalVend.Text = "               --- Escriba Vendedor ---"
            txt_finalVend.Enabled = False
            txt_finalVend.Clear()
        End If
    End Sub

    Private Sub rb_client_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_client.CheckedChanged
        If rb_client.Checked Then
            cb_client.Enabled = True
            cb_client.Focus()
        Else
            Me.cb_client.Text = "               --- Escriba Cliente ---"
            cb_client.Enabled = False
            cb_client.Clear()
        End If
    End Sub

    Private Sub chk_fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fecha.CheckedChanged
        DTP1.Enabled = True
        DTP2.Enabled = True
        DTP1.Focus()
    End Sub

    Private Sub DGV_Pedidos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellDoubleClick
        If e.ColumnIndex = 0 Then

            Dim frm As New Frm_Facturas_Ventas
            frm.Show()
            frm.tb_buscarcodigo.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value
            frm.tb_buscarcodigo.Enabled = False
            frm.SpConsultaClienteFacturaBindingSource.Filter = "ControlInicio = '" & DGV_Pedidos.SelectedRows(0).Cells(0).Value & "'"
            frm.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            frm.DGV_TodasLasFacturas_CellClick()
            frm.TopMost = True

        End If
    End Sub
End Class
