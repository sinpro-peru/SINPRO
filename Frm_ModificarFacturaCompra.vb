Public Class Frm_ModificarFacturaCompra

    Public CodC As Integer
    Public Prov As String
    Public Fact As String
    Public Dgv_Compras As DataGridView

    Private Sub Frm_ModificarFacturaCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_codCompra.Text = CodC
        lbl_Proveedor.Text = Prov
        tb_factura.Text = Fact
        tb_factura.Focus()
        tb_factura.SelectAll()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        DatosComprasCargadas.modificar_factura_compra(CodC, tb_factura.Text)
        Dgv_Compras.SelectedRows(0).Cells(0).Value = tb_factura.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub tb_factura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_factura.KeyDown
        If e.KeyCode = Keys.Enter Then
            bt_aceptar_Click(bt_aceptar, New EventArgs)
        End If
    End Sub
End Class