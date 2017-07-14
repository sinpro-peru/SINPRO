Public Class Frm_Cantidad_Etiquetas_Indvidual

    Public CodPro As String
    Public Nombre As String
    Public CodFab As String
    Public Proveedor As String
    Public Marca As String
    Public Modelo As String
    Public precio As Double
    Public cant As Integer

    Private Sub Frm_Cantidad_Etiquetas_Indvidual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lb_codigo.Text = CodPro
        lb_producto.Text = Nombre
        tb_cant.Text = cant.ToString
        tb_cant.Focus()
        tb_cant.SelectAll()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim frm As New R_Etiqueta

        frm.tipo = 1
        frm.CodPro = CodPro
        frm.Nombre = Nombre
        frm.CodFab = CodFab
        frm.Proveedor = Proveedor
        frm.Marca = Marca
        frm.Modelo = Modelo
        frm.precio = precio
        frm.cant = CInt(tb_cant.Text)

        frm.Show()
        Me.Close()

    End Sub

    Private Sub tb_cant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cant.KeyDown
        If e.KeyCode = Keys.Enter Then
            bt_aceptar_Click(bt_aceptar, New EventArgs)
        ElseIf e.KeyCode = Keys.Escape Then
            Button1_Click(Button1, New EventArgs)
        End If
    End Sub

    Private Sub tb_cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cant.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

End Class