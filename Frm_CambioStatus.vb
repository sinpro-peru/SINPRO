Public Class Frm_CambioStatus

    Public BO As Boolean
    Public frm As Frm_Compras

    Private Sub Frm_CambioStatus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm.Enabled = True
        frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Cb_a.Text <> "" And cb_de.Text <> "" Then

            If RadioButton1.Checked Then
                DatosPedidosCompras.modifica_status2(CInt(lbl_pedido.Text), cb_de.Text, Cb_a.Text, lbl_codProducto.Text, 0, BO)
            Else
                DatosPedidosCompras.modifica_status2(CInt(lbl_pedido.Text), cb_de.Text, Cb_a.Text, lbl_codProducto.Text, 1, BO)
            End If

            Me.Close()

        Else

            MsgBox("Debe seleccionar un Status de origen y uno de destino", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Frm_CambioStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

    End Sub
End Class