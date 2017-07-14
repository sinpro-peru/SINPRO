Public Class Frm_ListadoClientes

    Dim Down As Boolean = False
    Dim Up As Boolean = False
    Dim Enter1 As Boolean = False
    Dim selected As Boolean = False
    Dim texto As String = ""
    Public vende As String = ""
    Public tipo As Integer
    Public factura As String = ""
    Public comi As Frm_Comisiones

    Private Sub rb_vendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vendedor.CheckedChanged

        If rb_vendedor.Checked Then

            txt_finalVend.Enabled = True
            txt_finalVend.Focus()
            ListBox2.Visible = True

        Else

            txt_finalVend.Enabled = False
            txt_finalVend.Text = ""
            txt_finalVend.ResetText()
            ListBox2.Visible = False

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If tipo = 0 Then

            If rb_todos.Checked Then

                Dim frm As New R_ListadoClientes
                frm.valores(0, "Todos", 5)
                frm.Show()

            Else

                If txt_finalVend.Text <> "" Then

                    Dim frm As New R_ListadoClientes
                    frm.valores(CInt(txt_finalVend.Tag), txt_finalVend.Text, 4)
                    frm.Show()

                Else

                    MsgBox("Debe seleccionar un vendedor", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

        ElseIf tipo = 1 Then

            If txt_finalVend.Text <> "" Then

                If txt_finalVend.Text.ToUpper.Trim <> vende.ToUpper.Trim Then

                    DatosComisiones.Modifica_Vendedor_comision(CInt(txt_finalVend.Tag), factura)

                    Dim index As Integer = comi.DGV_comisiones.SelectedRows(0).Index

                    comi.DGV_comisiones.Rows.RemoveAt(index)

                    If comi.DGV_comisiones.RowCount > 0 Then

                        If index >= comi.DGV_comisiones.RowCount - 1 Then

                            comi.DGV_comisiones.Rows(comi.DGV_comisiones.RowCount - 1).Cells(1).Selected = True

                        Else

                            comi.DGV_comisiones.Rows(index).Cells(1).Selected = True

                        End If

                        comi.DGV_comisiones.Focus()
                        comi.DGV_comisiones.Select()

                    End If


                    comi.Enabled = True
                    Me.Close()

                Else

                    MsgBox("Debe seleccionar un vendedor diferente", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            Else

                MsgBox("Debe seleccionar un vendedor", MsgBoxStyle.Exclamation, "SINPRO")

            End If



        End If

    End Sub

    Private Sub Frm_ListadoClientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not comi Is Nothing Then
            comi.Enabled = True
        End If
    End Sub

    Private Sub Frm_ListadoClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MELDataSet.Tbl_Vendedor' table. You can move, or remove it, as needed.
        Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor, 0)

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        If tipo = 1 Then

            comi.Enabled = False
            rb_todos.Visible = False
            rb_vendedor.Visible = False
            Me.txt_finalVend.Text = "               --- Escriba Vendedor ---"
            Panel2.Size = New System.Drawing.Size(320, 43)
            Button1.Location = New System.Drawing.Point(120, 61)
            Me.Size = New System.Drawing.Size(351, 132)

        End If

    End Sub

    '------------------------------------------------------ COMBO VENDEDOR ------------------------------------------------------'

    Private Sub txt_final_TextChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.TextChanged
        If Me.ListBox2.Visible = True Then
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & txt_finalVend.Text & "%'"
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
                Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
                Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
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
        If e.KeyData = Keys.Enter Then
            Me.ListBox2.Visible = False
            Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
            Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
            Me.ListBox2.SelectedIndex = 0
            Me.txt_finalVend.Focus()
            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
        End If
    End Sub
    Private Sub ListBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Me.ListBox2.Visible = False
        Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
        Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
        Me.ListBox2.SelectedIndex = 0
        Me.txt_finalVend.Focus()
        Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
    End Sub

End Class