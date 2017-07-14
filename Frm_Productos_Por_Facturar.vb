Public Class Frm_Productos_Por_Facturar
    Dim cod As String
    Dim desc As String
    Dim Fiat As Boolean
    Dim Renault As Boolean


    Private Sub Frm_Productos_Por_Facturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        lbl_codigo.Text = cod
        lbl_producto.Text = desc

        If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
            DatosCompras.PedidosPorFacturar(cod, DGV_Pedidos, 1)
        Else
            DatosCompras.PedidosPorFacturar(cod, DGV_Pedidos, 0)
        End If

        DGV_Pedidos.ClearSelection()

    End Sub

    Public Sub recibe(ByVal codigo As String, ByVal descripcion As String, ByVal f As Boolean, ByVal r As Boolean)

        cod = codigo
        desc = descripcion
        Fiat = f
        Renault = r

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub DGV_Pedidos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellDoubleClick

        If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

            If e.ColumnIndex = 0 Then

                If DGV_Pedidos.SelectedRows(0).Cells(4).Value <> My.Settings.Empresa Then

                    MsgBox("No puede visualizar los detalles de este pedido, pertenecen a otra compañía", MsgBoxStyle.Exclamation, "SINPRO")

                Else

                    Dim frm As New Frm_Pedidos_Clientes
                    frm.Show()
                    frm.DomainUpDown1.SelectedIndex = 0
                    frm.tb_buscar.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString
                    frm.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                    frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)

                End If

            End If


        Else

            If e.ColumnIndex = 0 Then

                Dim frm As New Frm_Pedidos_Clientes
                frm.Show()
                frm.DomainUpDown1.SelectedIndex = 0
                frm.tb_buscar.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString
                frm.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)

            End If

        End If

    End Sub
End Class