Public Class Frm_Cargar_Compras
    Dim codProveedor As String
    Private TablaCosto As New DataTable("CostoPromedio")
    Dim ya As Boolean = False
    Public frm As Frm_Pedidos_Proveedores
    Private DGV_Pedidos As New DataGridView

    Private Sub Frm_Cargar_Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        dtp_fecha.Text = Today
        tb_CodFac.Focus()
        DatosCargarCompras.consulta_productos(cb_almacen)
        If cb_almacen.Items.Count > 0 Then
            cb_almacen.SelectedIndex = 0
        End If

    End Sub


    Public Sub Pedido(ByVal codPedido As String, ByVal proveedor As String, ByVal codProv As String, ByVal n As Collection, ByVal n2 As Collection, ByVal dgvp As DataGridView)

        lbl_codPedido.Text = codPedido
        lbl_proveedor.Text = proveedor
        DGV_Pedidos = frm.DGV_Pedidos
        codProveedor = codProv

        TablaCosto.Columns.Add(New DataColumn("CodigoProducto"))
        TablaCosto.Columns.Add(New DataColumn("Nombre"))
        TablaCosto.Columns.Add(New DataColumn("CantidadExistencia"))
        TablaCosto.Columns.Add(New DataColumn("CostoPromedioActual"))
        TablaCosto.Columns.Add(New DataColumn("PrecioVentaActual"))
        TablaCosto.Columns.Add(New DataColumn("CantidadPedida"))
        TablaCosto.Columns.Add(New DataColumn("CostoPromedioNuevo"))
        TablaCosto.Columns.Add(New DataColumn("PrecioVentaNuevo"))
        TablaCosto.Columns.Add(New DataColumn("Costo"))

        Dim cp As Double = 0
        DatosCargarCompras.consulta_costo_promedio(CInt(codPedido), TablaCosto)

        For cont As Integer = 0 To TablaCosto.Rows.Count - 1
            cp = 0
            DatosCargarCompras.consulta_calcula_costo_promedio(TablaCosto.Rows(cont).Item(0).ToString, CInt(codPedido), cp)
            TablaCosto.Rows(cont).Item(6) = cp
        Next

    End Sub

    Private Sub btn_presentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_presentar.Click

        Dim frm As New R_Cargar_Compra
        frm.valores(TablaCosto, lbl_codPedido.Text, lbl_proveedor.Text)
        frm.Show()

    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        If ya = False Then
            Dim resp As Integer
            If ch_precios.Checked Then
                resp = MsgBox("¿Está seguro que desea cargar el pedido Nro. " & lbl_codPedido.Text & "? Y que desea cargar en la BD los precios de los productos de esta importación?", MsgBoxStyle.YesNo, "Confirmar de carga")
            Else
                resp = MsgBox("¿Está seguro que desea cargar el pedido Nro. " & lbl_codPedido.Text & "?", MsgBoxStyle.YesNo, "Confirmar de carga")
            End If


            If resp = vbYes Then

                DatosCargarCompras.insertar_compra(CInt(lbl_codPedido.Text), tb_CodFac.Text, dtp_fecha.Text)
                For cont As Integer = 0 To TablaCosto.Rows.Count - 1
                    DatosCargarCompras.actualiza_producto_existencia(TablaCosto.Rows(cont).Item(0).ToString, (CInt(TablaCosto.Rows(cont).Item(2)) + CInt(TablaCosto.Rows(cont).Item(5))), CDbl(TablaCosto.Rows(cont).Item(6)))
                    DatosCargarCompras.actualizar_cantidad_almacen(TablaCosto.Rows(cont).Item(0).ToString, cb_almacen.Items.Item(Me.cb_almacen.SelectedIndex).Code, CInt(TablaCosto.Rows(cont).Item(5)))
                    If ch_precios.Checked Then
                        DatosCargarCompras.actualiza_producto_precio(TablaCosto.Rows(cont).Item(0).ToString, CDbl(TablaCosto.Rows(cont).Item(7).ToString))
                    End If
                Next

                For cont As Integer = 0 To frm.DGV.RowCount - 1

                    DatosComprasCargadas.Arancel_Compra(CInt(lbl_codPedido.Text), frm.DGV.Rows(cont).Cells(2).Value.ToString, CDbl(frm.DGV.Rows(cont).Cells(11).Value))

                Next

                Dim resp2 As Integer = MsgBox("Desea colocar los productos con BackOrder en un nuevo pedido?", MsgBoxStyle.YesNo, "SINPRO")

                If resp2 = vbYes Then

                    Dim NuevoPedido As String = ""
                    'Insertar el pedido nuevo
                    DatosPedidosCompras.inserta_pedidoCompra(codProveedor, 0, 0, 0, 0, Today, "$", 0, "", Today, "Pedido automático generado con el BackOrder del pedido " & lbl_codPedido.Text)
                    'Buscar el último codigo de pedido
                    DatosPedidosCompras.consulta_UltimopedidoCompra(NuevoPedido)
                    'Mover BackOrder
                    DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CInt(lbl_codPedido.Text), "O", 0, 0, "")

                End If

                'Crear Pedido Distribuidora

                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then

                '    Dim resp3 As Integer = MsgBox("Desea crear un pedido con los productos de Fiat y Renault en CONAVE y Distribuidora BRWME respectivamente?", MsgBoxStyle.YesNo, "SINPRO")

                '    If resp3 = vbYes Then

                '        Dim NuevoPedido As String = ""
                '        'Insertar el pedido nuevo
                '        DatosPedidosCompras.inserta_pedidoCompra_D(CInt(lbl_codPedido.Text), "Pedido automático generado con los productos Renault del pedido " & lbl_codPedido.Text & " de Comercializadora BRWME")
                '        'Buscar el último codigo de pedido
                '        DatosPedidosCompras.consulta_UltimopedidoCompra_D(NuevoPedido)
                '        'Mover Productos
                '        DatosPedidosCompras.Mueve_ProductosPedidoCompra_D(CInt(NuevoPedido), CInt(lbl_codPedido.Text))

                '        Dim NuevoPedido2 As String = ""
                '        'Insertar el pedido nuevo
                '        DatosPedidosCompras.inserta_pedidoCompra_CONAVE(CInt(lbl_codPedido.Text), "Pedido automático generado con los productos Fiat del pedido " & lbl_codPedido.Text & " de Comercializadora BRWME")
                '        'Buscar el último codigo de pedido
                '        DatosPedidosCompras.consulta_UltimopedidoCompra_CONAVE(NuevoPedido2)
                '        'Mover Productos
                '        DatosPedidosCompras.Mueve_ProductosPedidoCompra_CONAVE(CInt(NuevoPedido2), CInt(lbl_codPedido.Text))

                '    End If

                'End If

                MsgBox("Su compra ha sido cargada satisfactoriamente", MsgBoxStyle.Information, "Información")
                ya = True

                DatosPedidosCompras.lv_PedidoCompra(frm.DGV_Pedidos, "", 0, "", "", "")
                frm.chb_pedidocargado.Checked = True
                frm.bt_cancelar_Click(frm.bt_cancelar, New EventArgs)
                Me.Close()
            End If
        Else
            MsgBox("Ya esta compra se encuentra cargada", MsgBoxStyle.Critical, "Error")
        End If

        tb_CodFac.Clear()
        dtp_fecha.Value = Today

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click

        dtp_fecha.Value = Today
        tb_CodFac.Clear()
        tb_CodFac.Focus()
        Me.Close()

    End Sub


    Public Sub recibe(ByVal frm1 As Frm_Pedidos_Proveedores)

        frm = frm1

    End Sub


End Class