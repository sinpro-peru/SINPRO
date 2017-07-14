Public Class Frm_ChequesDev

    Dim Down As Boolean = False
    Dim Up As Boolean = False
    Dim Enter1 As Boolean = False
    Dim selected As Boolean = False
    Dim texto As String = ""
    Public Tipo As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cb_vendedor.SelectedIndex = -1 And rb_vendedor.Checked Then

            MsgBox("Debe seleccionar un vendedor", MsgBoxStyle.Exclamation, "Error")
            cb_vendedor.Focus()

        Else

            If rb_todos.Checked Then

                If Tipo = 0 Then

                    If RadioButton1.Checked Then
                        Dim frm As New R_ChequesDev
                        frm.recibe(0, "Todos los vendedores", DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 3)
                        frm.Text = "Reporte de cheques devueltos: Todos los vendedores"
                        frm.Show()
                    Else
                        Dim frm As New R_ChequesDev
                        frm.recibe(0, "Todos los vendedores", DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 4)
                        frm.Text = "Reporte de cheques devueltos por reponer: Todos los vendedores"
                        frm.Show()
                    End If

                ElseIf Tipo = 1 Then

                    Dim frm As New R_ProductosDanados
                    frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, "Todos los vendedores", 0)
                    frm.Show()
                    Me.Close()

                Else

                    Dim frm As New R_NC_Pendientes
                    frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, "Todos los vendedores", 0)
                    frm.Show()
                    Me.Close()

                End If

            ElseIf rb_vendedor.Checked Then

                If Tipo = 0 Then

                    If RadioButton1.Checked Then
                        Dim frm As New R_ChequesDev
                        frm.recibe(Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).code, cb_vendedor.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 1)
                        frm.Text = "Reporte de cheques devueltos: " + cb_vendedor.Text
                        frm.Show()
                    Else
                        Dim frm As New R_ChequesDev
                        frm.recibe(Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).code, cb_vendedor.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, 0)
                        frm.Text = "Reporte de cheques devueltos por reponer: " + cb_vendedor.Text
                        frm.Show()
                    End If

                ElseIf Tipo = 1 Then

                    Dim frm As New R_ProductosDanados
                    frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).name, Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).code)
                    frm.Show()
                    Me.Close()

                Else

                    Dim frm As New R_NC_Pendientes
                    frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).name, Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).code)
                    frm.Show()
                    Me.Close()

                End If

            End If
            End If

    End Sub

    Private Sub Frm_ChequesDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        If Tipo <> 0 Then
            Panel1.Visible = False
        End If

        DateTimePicker1.Value = "01/" + CStr(Month(DateAdd(DateInterval.Month, -1, Today))) + "/" + CStr(Year(DateAdd(DateInterval.Month, -1, Today)))
        DatosAnalisisCobranza.consulta_vendedores2(cb_vendedor)

    End Sub

    Private Sub cb_vendedor_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_vendedor.GotFocus
        If cb_vendedor.Enabled Then
            Me.cb_vendedor.DroppedDown = True
        End If
    End Sub

    Private Sub cb_vendedor_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_vendedor.KeyDown
        If cb_vendedor.Enabled Then
            DatosPedidoCliente.entrar = False
            If e.KeyCode = Keys.Enter Then
                Enter1 = True
                If Me.cb_vendedor.SelectedIndex = -1 Then
                    Me.cb_vendedor.SelectedIndex = 0
                Else
                    Me.cb_vendedor.Text = Me.cb_vendedor.SelectedText
                End If
            ElseIf e.KeyCode = Keys.Down Then
                Down = True
            ElseIf e.KeyCode = Keys.Up Then
                Up = True
            Else
                Enter1 = False
                Down = False
                Up = False
                selected = False
                If Me.cb_vendedor.SelectedIndex = -1 Then
                    Me.cb_vendedor.SelectionStart = Me.texto.Length
                Else
                    Me.cb_vendedor.SelectionStart = 0
                End If
            End If
        End If
    End Sub

    Private Sub cb_vendedor_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_vendedor.SelectionChangeCommitted
        If cb_vendedor.Enabled Then
            If Not Me.cb_vendedor.SelectedIndex = -1 Then
                Enter1 = True
                Me.cb_vendedor.Text = Me.cb_vendedor.Items.Item(Me.cb_vendedor.SelectedIndex).Name
                cb_vendedor.DroppedDown = False
            End If
        End If
    End Sub

    Private Sub cb_vendedor_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_vendedor.TextChanged
        If cb_vendedor.Enabled Then
            If Enter1 = False Then
                If Down = False And Up = False Then
                    If selected = False Then
                        If cb_vendedor.Text <> "" Then
                            DatosAnalisisCobranza.consulta_VendedorLike2(cb_vendedor, cb_vendedor.Text, texto)
                            Me.cb_vendedor.SelectionStart = Me.texto.Length
                        Else
                            DatosAnalisisCobranza.consulta_vendedores2(cb_vendedor)
                            If Me.cb_vendedor.SelectedIndex = -1 Then
                                Me.cb_vendedor.SelectionStart = Me.texto.Length
                            Else
                                Me.cb_vendedor.SelectionStart = 0
                            End If
                        End If
                    End If
                End If
            End If
            cb_vendedor.DroppedDown = True
        End If
    End Sub

    Private Sub rb_vendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vendedor.CheckedChanged
        cb_vendedor.Enabled = rb_vendedor.Checked
        If cb_vendedor.Enabled = False Then
            cb_vendedor.ResetText()
            cb_vendedor.Text = ""
            cb_vendedor.DroppedDown = False
        Else
            cb_vendedor.Focus()
        End If
    End Sub

End Class