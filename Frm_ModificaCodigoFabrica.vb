Public Class Frm_ModificaCodigoFabrica

    Dim Prov As String = ""
    Dim CodProv As Integer = 0
    Dim CodProF As String = ""
    Dim tipo As Integer = 0
    Dim CodProd As String = ""
    Dim Descripcion As String = ""
    Dim PedidoCompra As Frm_Pedidos_Proveedores
    Dim CalculoCostos As Frm_CalculoCostos
    Dim InfoGeneral As Frm_Compras
    Dim columna As Integer = 0
    Dim Fiat As Boolean
    Dim Renault As Boolean

    Public Sub Recibe(ByVal Proveedor As String, ByVal CodProveedor As Integer, ByVal CodProductoF As String, ByVal cp As String, ByVal desc As String, ByVal tip As Integer, ByVal f As Boolean, ByVal r As Boolean, Optional ByRef frm As Frm_Pedidos_Proveedores = Nothing, Optional ByRef frm2 As Frm_CalculoCostos = Nothing, Optional ByRef frm3 As Frm_Compras = Nothing)

        Prov = Proveedor
        CodProv = CodProveedor
        CodProF = CodProductoF
        CodProd = cp
        Descripcion = desc
        PedidoCompra = frm
        CalculoCostos = frm2
        InfoGeneral = frm3
        tipo = tip
        Fiat = f
        Renault = r

    End Sub

    Private Sub Frm_ModificaCodigoFabrica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not PedidoCompra Is Nothing Then

            PedidoCompra.Enabled = True
            PedidoCompra.DGV.CurrentCell.Selected = True
            PedidoCompra.DGV.Focus()

        ElseIf Not CalculoCostos Is Nothing Then

            CalculoCostos.Enabled = True
            CalculoCostos.Dgv_Costos.CurrentCell.Selected = True
            CalculoCostos.Dgv_Costos.Focus()

        Else

            InfoGeneral.Enabled = True
            InfoGeneral.DGV_Productos.CurrentCell.Selected = True
            InfoGeneral.DGV_Productos_CellContentClick(InfoGeneral.DGV_Productos, New EventArgs)
            InfoGeneral.DGV_Productos.Focus()

        End If
    End Sub

    Private Sub Frm_ModificaCodigoFabrica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        lbl_Proveedor.Text = Prov
        lbl_CodigoProv.Text = CodProv.ToString
        tb_codigoFabrica.Text = CodProF
        lbl_desc.Text = Descripcion
        lbl_codProd.Text = CodProd
        tb_codigoFabrica.Focus()
        tb_codigoFabrica.SelectAll()

    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tipo = 0 Then
            If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                If Fiat Then
                    DatosProveedor.InsertarCodigoFabrica2(lbl_codProd.Text, CInt(lbl_CodigoProv.Text), tb_codigoFabrica.Text, 2)
                ElseIf Renault Then
                    DatosProveedor.InsertarCodigoFabrica2(lbl_codProd.Text, CInt(lbl_CodigoProv.Text), tb_codigoFabrica.Text, 1)
                Else
                    DatosProveedor.InsertarCodigoFabrica2(lbl_codProd.Text, CInt(lbl_CodigoProv.Text), tb_codigoFabrica.Text, 0)
                End If

            Else
                DatosProveedor.InsertarCodigoFabrica2(lbl_codProd.Text, CInt(lbl_CodigoProv.Text), tb_codigoFabrica.Text, 0)
            End If
        Else
            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                DatosProducto.ModificaOEM(lbl_codProd.Text, tb_codigoFabrica.Text)
            Else
                DatosProducto.ModificaOEM_BRWME(lbl_codProd.Text, tb_codigoFabrica.Text)
            End If


            InfoGeneral.DGV_Productos.SelectedRows(0).Cells(5).Value = tb_codigoFabrica.Text
        End If


        If Not PedidoCompra Is Nothing Then

            PedidoCompra.DGV.SelectedRows(0).Cells(2).Value = tb_codigoFabrica.Text
            PedidoCompra.Enabled = True
            PedidoCompra.DGV.Focus()
            PedidoCompra.Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(PedidoCompra.MELDataSet.sp_consultaProductosParaPedidoCompra, PedidoCompra.tb_buscarcodigo.Text, PedidoCompra.cb_proveedor.Tag.ToString)

        ElseIf Not CalculoCostos Is Nothing Then

            CalculoCostos.Dgv_Costos.SelectedRows(0).Cells(3).Value = tb_codigoFabrica.Text
            CalculoCostos.Enabled = True
            CalculoCostos.Dgv_Costos.Focus()

        End If

        Me.Close()

    End Sub

    Private Sub tb_codigoFabrica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_codigoFabrica.KeyDown
        If e.KeyData = Keys.Enter Then
            Button1_Click(bt_aceptar, New EventArgs)
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class