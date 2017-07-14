Public Class Frm_Status

    Dim dgv2 As New MyDataGridView3
    Dim valor2 As Integer = 0

    Public Sub Recibe(ByRef dgv As MyDataGridView3, ByVal codigo As Integer)

        dgv2 = dgv
        valor2 = codigo

    End Sub


    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Cb_a.SelectedIndex <> -1 Or cb_de.SelectedIndex <> -1 Then

            'If Cb_a.SelectedIndex + 1 > cb_de.SelectedIndex Then

            Dim cont2 As Integer = 0
            Dim cont As Integer = 0

            DatosPedidosCompras.modifica_status(valor2, cb_de.Text, Cb_a.Text)

            For cont = 0 To dgv2.RowCount - 1

                If dgv2.Rows(cont).Cells(0).Value = cb_de.Text Then

                    dgv2.Rows(cont).Cells(0).Value = Cb_a.Text
                    dgv2.Rows(cont).Cells(7).Value = CDate(Today)

                    If Cb_a.Text = "S" Then
                        dgv2.Rows(cont).Cells(6).Value = "0,00"
                    End If

                    cont2 = cont2 + 1

                End If

            Next



            If cont2 = 0 Then

                MsgBox("No se realizaron cambios en el pedido", MsgBoxStyle.Information, "Confirmación")

            Else

                MsgBox("Se realizaron " & cont2 & " cambios en el pedido", MsgBoxStyle.Information, "Confirmación")

            End If

            Me.Close()

            'Else

            '    MsgBox("Solo puede cambiar a un status superior al actual", MsgBoxStyle.Exclamation, "Mensaje de error")

            'End If

        Else

            MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Information, "Mensaje de error")

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Cb_a.Text = ""
        cb_de.Text = ""
        Me.Close()

    End Sub

    Private Sub Frm_Status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text
    End Sub
End Class