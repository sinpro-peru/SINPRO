Public Class Frm_ModificarPrecio

    Public codigoProducto As String = ""
    Public DescProducto As String = ""
    Public tipo As Integer = 0
    Public Precio As Double = 0
    Public bo As Boolean = False
    Public pedido As Integer = 0
    Public precioAnt As Double = 0
    Public Fiat As Boolean = False
    Public Renault As Boolean
    Private frm As Frm_Compras

    Public Sub recibe(ByRef frm2 As Frm_Compras)
        frm = frm2
    End Sub

    Private Sub Frm_ModificarPrecio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.frm.Enabled = True
        frm.Focus()
        frm.DGV_Productos.Focus()
    End Sub


    Private Sub Frm_ModificarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        If tipo = 0 Then
            lb_codigo.Text = codigoProducto
            lb_producto.Text = DescProducto
            precioAnt = Precio
            tb_precio.Text = Precio.ToString
            tb_precio.Focus()
            tb_precio.SelectAll()
        Else
            Label3.Text = "F.O.B.:"
            lb_codigo.Text = codigoProducto
            lb_producto.Text = DescProducto
            lbl_pedido.Text = pedido
            lbl_pedido.Visible = True
            Label1.Visible = True
            precioAnt = Precio
            tb_precio.Text = Precio.ToString
            tb_precio.Focus()
            tb_precio.SelectAll()
        End If

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tipo = 0 Then

            'If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then
            '    If Renault Then
            '        DatosProducto.ModificaPrecio(lb_codigo.Text, CDbl(tb_precio.Text), 1)
            '    ElseIf Fiat Then
            '        DatosProducto.ModificaPrecio(lb_codigo.Text, CDbl(tb_precio.Text), 2)
            '    Else
            '        DatosProducto.ModificaPrecio(lb_codigo.Text, CDbl(tb_precio.Text), 0)
            '    End If
            'Else
            DatosProducto.ModificaPrecio(lb_codigo.Text, CDbl(tb_precio.Text), 0)
            'End If

            frm.DGV_Productos.SelectedRows(0).Cells(4).Value = tb_precio.Text
        Else
            DatosPedidosCompras.modifica_Fob(CInt(lbl_pedido.Text), lb_codigo.Text, bo, CDbl(tb_precio.Text), precioAnt)
            frm.DGV_Pedidos.SelectedRows(0).Cells(6).Value = Format(CDbl(tb_precio.Text), "#,##0.00")
        End If

        'frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
        frm.Focus()
        frm.DGV_Productos.Focus()
        frm.Enabled = True
        Me.Close()

    End Sub

    Private Sub tb_cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_precio.KeyDown
        If e.KeyData = Keys.Escape Then
            frm.Focus()
            frm.DGV_Productos.Focus()
            frm.Enabled = True
            Me.Close()
        ElseIf e.KeyData = Keys.Enter Then
            tb_precio.Text = tb_precio.Text.Replace(".", ",")
            bt_aceptar_Click(bt_aceptar, New EventArgs)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm.Focus()
        frm.DGV_Productos.Focus()
        frm.Enabled = True
        Me.Close()
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_precio.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub


End Class