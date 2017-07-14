Public Class Frm_ModificarPedido

    Public codigoProducto As String = ""
    Public BO As String = ""
    Public DescProducto As String = ""
    Public cant As Integer = 0
    Public fob As Double = 0
    Public codigoPedido As Integer = 0
    Public frm As New Frm_Compras

    Private Sub Frm_ModificarPedido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm.Enabled = True
        frm.Focus()
        frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
        frm.DGV_Productos.Focus()
    End Sub


    Private Sub Frm_ModificarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        If BO = "Sí" Then

            Button1.Visible = False
            bt_aceptar.Visible = False
            Button2.Visible = True

        ElseIf BO = "No" Then

            Button1.Visible = True
            bt_aceptar.Visible = True
            Button2.Visible = False

        End If

        lb_codigo.Text = codigoProducto
        lb_producto.Text = DescProducto
        tb_cantidad.Focus()
        tb_cantidad.SelectAll()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Try

            If tb_cantidad.Text <> "" Then

                Dim index As Integer = frm.DGV_Productos.SelectedRows(0).Index

                DatosPedidosCompras.insertar_producto_pedido2(codigoPedido, codigoProducto, CInt(tb_cantidad.Text), fob, cant)
                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.Enabled = True
                frm.Focus()
                'frm.DGV_Pedidos.Rows(index).Cells(7).Value = tb_cantidad.Text
                'frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.DGV_Productos.Focus()
                Me.Close()

            Else

                MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
                tb_cantidad.Focus()

            End If

        Catch ex As Exception

            MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
            tb_cantidad.Focus()

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            If tb_cantidad.Text <> "" Then

                DatosPedidosCompras.actualizar_producto_pedido2(codigoPedido, codigoProducto, CInt(tb_cantidad.Text), 0)
                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.Enabled = True
                frm.Focus()
                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.DGV_Productos.Focus()
                Me.Close()

            Else

                MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
                tb_cantidad.Focus()

            End If

        Catch ex As Exception

            MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
            tb_cantidad.Focus()

        End Try

    End Sub

 
    Private Sub tb_cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantidad.KeyDown
        If e.KeyData = Keys.Escape Then

            frm.Enabled = True
            frm.Focus()
            frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
            frm.DGV_Productos.Focus()
            Me.Close()

        ElseIf e.KeyData = Keys.Enter Then

            If Button1.Visible Then
                Button1_Click(Button1, New EventArgs)
            ElseIf Button2.Visible Then
                Button2_Click(Button2, New EventArgs)
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try

            If tb_cantidad.Text <> "" Then

                DatosPedidosCompras.actualizar_producto_pedido2(codigoPedido, codigoProducto, CInt(tb_cantidad.Text), 1)
                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.Enabled = True
                frm.Focus()
                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                frm.DGV_Productos.Focus()
                Me.Close()

            Else

                MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
                tb_cantidad.Focus()

            End If

        Catch ex As Exception

            MsgBox("Debe introducir una cantidad", MsgBoxStyle.Exclamation, "SINPRO")
            tb_cantidad.Focus()

        End Try

    End Sub
End Class