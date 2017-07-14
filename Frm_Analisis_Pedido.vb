Public Class Frm_Analisis_Pedido


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then
            Me.Close()
        ElseIf e.Button Is Me.bt_nuevo Then ' Ver Todos
            VerTodo()
        End If

    End Sub

    Private Sub Frm_Analisis_Pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        VerTodo()

    End Sub

    Public Sub VerTodo()

        Try
            DatosAnalisisPedido.Llenar_Pedidos_Por_Vendedor(0, Dgv_PedidosPorVendedor, 0, 0, 0, "")
            lbl_cantPVendedor.Text = Sumar_Col_DGV(Dgv_PedidosPorVendedor, 2)
            lbl_MontoVendedor.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorVendedor, 3)), "#,##0.00")
            cero(lbl_MontoVendedor.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Monto(0, 0, Dgv_pedidosPorMonto, 0, 0, "")
            lbl_PedidoPorMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorMonto, 4)), "#,##0.00")
            cero(lbl_PedidoPorMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Zona(0, 0, Dgv_pedidosPorZona, 0, 0, "")
            lbl_cantPZona.Text = Sumar_Col_DGV(Dgv_pedidosPorZona, 2)
            lbl_MontoZona.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorZona, 3)), "#,##0.00")
            cero(lbl_MontoZona.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Fecha(0, 0, Dgv_pedidosPorFecha, 0, 0, 0)
            lbl_PedidosPorFechaCantP.Text = Sumar_Col_DGV(Dgv_pedidosPorFecha, 1)
            lbl_PedidosPorFechaMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorFecha, 2)), "#,##0.00")
            cero(lbl_PedidosPorFechaMonto.Text)


            DatosAnalisisPedido.Llenar_Pedidos_Por_Almacen(0, Dgv_PedidosPorAlmacen, 0, 0, 0, "")
            lbl_cantItems.Text = Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 1)
            lbl_montoAlmacen.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 2)), "#,##0.00")
            cero(lbl_montoAlmacen.Text)
        Catch ex As Exception

        End Try

    End Sub

    Public Function Sumar_Col_DGV(ByVal DGV As DataGridView, ByVal c As Integer) As Double

        Dim i As Integer

        Dim suma As Double

        For i = 0 To DGV.RowCount - 1
            suma = suma + CDbl(DGV.Rows(i).Cells(c).Value.ToString())
        Next

        Return suma

    End Function

    Private Sub Dgv_PedidosPorVendedor_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles Dgv_PedidosPorVendedor.CellClick, Dgv_PedidosPorVendedor.KeyDown, Dgv_PedidosPorVendedor.KeyUp

        Try

            Dim idVendedor As Integer = 0
            idVendedor = Me.Dgv_PedidosPorVendedor.SelectedRows(0).Cells(0).Value

            DatosAnalisisPedido.Llenar_Pedidos_Por_Monto(1, idVendedor, Dgv_pedidosPorMonto, 0, 0, "")
            lbl_PedidoPorMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorMonto, 4)), "#,##0.00")
            cero(lbl_PedidoPorMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Fecha(1, idVendedor, Dgv_pedidosPorFecha, 0, 0, 0)
            lbl_PedidosPorFechaCantP.Text = Sumar_Col_DGV(Dgv_pedidosPorFecha, 1)
            lbl_PedidosPorFechaMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorFecha, 2)), "#,##0.00")
            cero(lbl_PedidosPorFechaMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Zona(1, idVendedor, Dgv_pedidosPorZona, 0, 0, "")
            lbl_cantPZona.Text = Sumar_Col_DGV(Dgv_pedidosPorZona, 2)
            lbl_MontoZona.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorZona, 3)), "#,##0.00")
            cero(lbl_MontoZona.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Almacen(1, Dgv_PedidosPorAlmacen, 0, idVendedor, 0, "")
            lbl_cantItems.Text = Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 1)
            lbl_montoAlmacen.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 2)), "#,##0.00")
            cero(lbl_montoAlmacen.Text)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv_pedidosPorMonto_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_pedidosPorMonto.CellClick, Dgv_pedidosPorMonto.KeyUp, Dgv_pedidosPorMonto.KeyDown

        Try
            Dim codPed As Integer = 0
            codPed = Me.Dgv_pedidosPorMonto.SelectedRows(0).Cells(0).Value

            DatosAnalisisPedido.Llenar_Pedidos_Por_Vendedor(2, Dgv_PedidosPorVendedor, codPed, 0, 0, "")
            lbl_cantPVendedor.Text = Sumar_Col_DGV(Dgv_PedidosPorVendedor, 2)
            lbl_MontoVendedor.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorVendedor, 3)), "#,##0.00")
            cero(lbl_MontoVendedor.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Fecha(2, 0, Dgv_pedidosPorFecha, codPed, 0, 0)
            lbl_PedidosPorFechaCantP.Text = Sumar_Col_DGV(Dgv_pedidosPorFecha, 1)
            lbl_PedidosPorFechaMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorFecha, 2)), "#,##0.00")
            cero(lbl_PedidosPorFechaMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Zona(2, 0, Dgv_pedidosPorZona, codPed, 0, "")
            lbl_cantPZona.Text = Sumar_Col_DGV(Dgv_pedidosPorZona, 2)
            lbl_MontoZona.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorZona, 3)), "#,##0.00")
            cero(lbl_MontoZona.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Almacen(2, Dgv_PedidosPorAlmacen, 0, 0, codPed, "")
            lbl_cantItems.Text = Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 1)
            lbl_montoAlmacen.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 2)), "#,##0.00")
            cero(lbl_montoAlmacen.Text)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv_PedidosPorAlmacen_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_PedidosPorAlmacen.CellClick, Dgv_PedidosPorAlmacen.KeyDown, Dgv_PedidosPorAlmacen.KeyUp
        Try
            Dim CodAlmacen As Integer = 0
            CodAlmacen = Me.Dgv_PedidosPorAlmacen.SelectedRows(0).Cells(3).Value

            DatosAnalisisPedido.Llenar_Pedidos_Por_Vendedor(4, Dgv_PedidosPorVendedor, 0, 0, CodAlmacen, "")
            lbl_cantPVendedor.Text = Sumar_Col_DGV(Dgv_PedidosPorVendedor, 2)
            lbl_MontoVendedor.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorVendedor, 3)), "#,##0.00")
            cero(lbl_MontoVendedor.Text)



            DatosAnalisisPedido.Llenar_Pedidos_Por_Zona(4, 0, Dgv_pedidosPorZona, 0, CodAlmacen, "")
            lbl_cantPZona.Text = Sumar_Col_DGV(Dgv_pedidosPorZona, 2)
            lbl_MontoZona.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorZona, 3)), "#,##0.00")
            cero(lbl_MontoZona.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Monto(4, 0, Dgv_pedidosPorMonto, 0, CodAlmacen, "")
            lbl_PedidoPorMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorMonto, 4)), "#,##0.00")
            cero(lbl_PedidoPorMonto.Text)




            DatosAnalisisPedido.Llenar_Pedidos_Por_Fecha(4, 0, Dgv_pedidosPorFecha, 0, 0, CodAlmacen)
            lbl_PedidosPorFechaCantP.Text = Sumar_Col_DGV(Dgv_pedidosPorFecha, 1)
            lbl_PedidosPorFechaMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorFecha, 2)), "#,##0.00")
            cero(lbl_PedidosPorFechaMonto.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv_pedidosPorZona_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_pedidosPorZona.CellClick, Dgv_pedidosPorZona.KeyDown, Dgv_pedidosPorZona.KeyUp

        Try

            Dim CodZona As Integer = 0
            CodZona = Me.Dgv_pedidosPorZona.SelectedRows(0).Cells(0).Value

            DatosAnalisisPedido.Llenar_Pedidos_Por_Vendedor(3, Dgv_PedidosPorVendedor, 0, CodZona, 0, "")
            lbl_cantPVendedor.Text = Sumar_Col_DGV(Dgv_PedidosPorVendedor, 2)
            lbl_MontoVendedor.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorVendedor, 3)), "#,##0.00")
            cero(lbl_MontoVendedor.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Monto(3, 0, Dgv_pedidosPorMonto, CodZona, 0, "")
            lbl_PedidoPorMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorMonto, 4)), "#,##0.00")
            cero(lbl_PedidoPorMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Fecha(3, 0, Dgv_pedidosPorFecha, 0, CodZona, 0)
            lbl_PedidosPorFechaCantP.Text = Sumar_Col_DGV(Dgv_pedidosPorFecha, 1)
            lbl_PedidosPorFechaMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorFecha, 2)), "#,##0.00")
            cero(lbl_PedidosPorFechaMonto.Text)

            DatosAnalisisPedido.Llenar_Pedidos_Por_Almacen(3, Dgv_PedidosPorAlmacen, CodZona, 0, 0, "")
            lbl_cantItems.Text = Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 1)
            lbl_montoAlmacen.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 2)), "#,##0.00")
            cero(lbl_montoAlmacen.Text)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv_pedidosPorFecha_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_pedidosPorFecha.CellClick, Dgv_pedidosPorFecha.KeyDown, Dgv_pedidosPorFecha.KeyUp

        Try
            Dim Periodo As String = ""
            Periodo = Me.Dgv_pedidosPorFecha.SelectedRows(0).Cells(0).Value.ToString

            DatosAnalisisPedido.Llenar_Pedidos_Por_Almacen(5, Dgv_PedidosPorAlmacen, 0, 0, 0, Periodo)
            lbl_cantItems.Text = Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 1)
            lbl_montoAlmacen.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorAlmacen, 2)), "#,##0.00")
            cero(lbl_montoAlmacen.Text)


            DatosAnalisisPedido.Llenar_Pedidos_Por_Zona(5, 0, Dgv_pedidosPorZona, 0, 0, Periodo)
            lbl_cantPZona.Text = Sumar_Col_DGV(Dgv_pedidosPorZona, 2)
            lbl_MontoZona.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorZona, 3)), "#,##0.00")
            cero(lbl_MontoZona.Text)


            DatosAnalisisPedido.Llenar_Pedidos_Por_Vendedor(5, Dgv_PedidosPorVendedor, 0, 0, 0, Periodo)
            lbl_cantPVendedor.Text = Sumar_Col_DGV(Dgv_PedidosPorVendedor, 2)
            lbl_MontoVendedor.Text = Format(CDbl(Sumar_Col_DGV(Dgv_PedidosPorVendedor, 3)), "#,##0.00")
            cero(lbl_MontoVendedor.Text)


            DatosAnalisisPedido.Llenar_Pedidos_Por_Monto(5, 0, Dgv_pedidosPorMonto, 0, 0, Periodo)
            lbl_PedidoPorMonto.Text = Format(CDbl(Sumar_Col_DGV(Dgv_pedidosPorMonto, 4)), "#,##0.00")
            cero(lbl_PedidoPorMonto.Text)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub cero(ByRef Text As String)

        If Text = ",00" Then

            Text = "0.00"

        End If

    End Sub

End Class