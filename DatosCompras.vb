Imports System.Data.SqlClient
Imports Dundas.Charting.WinControl
Imports Dundas.Charting.WinControl.ChartTypes
Imports Dundas.Extensions
Imports System.Drawing


Public Class DatosCompras
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub


    Public Shared Sub Llenar_DGV_por_id(ByVal Id As String, ByRef DGV As DataGridView, ByVal tipo As Integer) 'Llena el DGV de las ubicaciones por un Id dado

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaUbicacionProducto2"
            command.Parameters.AddWithValue("@Codigo", Id)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Almacén"), dr("Cuarto"), dr("Estante"), dr("Tramo"), dr("Cantidad"), dr("CodigoTramo"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando las ubicaciones", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub consulta_producto_Obs(ByVal CodPro As String, ByRef obs As String, ByVal tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto3"
            command.Parameters.AddWithValue("@Cod", CodPro)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()
            Dim cont As Integer = 0

            While dr.Read

                If dr("Observacion").GetType.ToString = "System.DBNull" Then

                    obs = ""

                Else

                    obs = dr("Observacion")

                End If

            End While

        Catch ex As Exception


            MsgBox("Error consultando observación del producto", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_producto_oculto(ByRef chk As CheckBox, ByVal CodP As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoOculto"
            command.Parameters.AddWithValue("@CodP", CodP)
            dr = command.ExecuteReader()
            Dim cont As Integer = 0

            While dr.Read

                If Not dr("Oculto").GetType.ToString = "System.DBNull" Then

                    chk.Checked = dr("Oculto")

                Else

                    chk.Checked = False

                End If

            End While

        Catch ex As Exception

            MsgBox("Error consultando visibilidad de producto en listados", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_ultimo_Conteo_Inv(ByVal CodP As String, ByRef fecha As String, ByRef cant As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUltimoConteoInv"
            command.Parameters.AddWithValue("@CodP", CodP)
            dr = command.ExecuteReader()

            Dim cont As Integer = 0

            fecha = ""
            cant = ""

            While dr.Read

                fecha = CDate(dr("Fecha")).ToShortDateString & ":"
                cant = dr("CantidadActual")

            End While

        Catch ex As Exception

            MsgBox("Error consultando último conteo", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub modifica_producto_oculto(ByVal chk As Boolean, ByVal CodP As String, ByVal tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProductoOculto"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Ocu", chk)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error ocultando producto", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub modifica_producto_obs(ByVal obs As String, ByVal CodP As String, ByVal tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProductoObs"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.ExecuteNonQuery()

            MsgBox("Observación modificada", MsgBoxStyle.Information, "SINPRO")

        Catch ex As Exception

            MsgBox("Error modificando producto", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub elimina_pedido_producto_C(ByVal Ped As Integer, ByVal CodP As String, ByVal bo As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Pedido_C"
            command.Parameters.AddWithValue("@CodPed", Ped)
            command.Parameters.AddWithValue("@CodPro", CodP)
            command.Parameters.AddWithValue("@BO", bo)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando producto", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Public Shared Sub consulta_indicadores(ByRef dgv As DataGridView, ByVal Meses As Integer, ByVal CodPro As String)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_IndicadoresCompras"
            command.Parameters.AddWithValue("@Cod", CodPro)
            command.Parameters.AddWithValue("@Meses", Meses)
            dr = command.ExecuteReader()

            If dr.HasRows Then
                While dr.Read

                    dgv.Rows.Add(dr("TotalUnidades"), dr("Consumidos"), dr("Disponibilidad"), dr("Inventario"), dr("Sugerido"), "")

                End While
            Else
                dgv.Rows.Add(0, 0, 0, 0, 0, 0)
            End If

            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Error cargando indicadores", MsgBoxStyle.Critical, "ERROR")


        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub inserta_pedidoCompraProducto(ByVal codPed As Integer, ByVal codPto As Integer, ByVal cant As Integer, ByRef costo As Double)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_InsertaPedido_Producto_C"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", cant)
        command.Parameters.AddWithValue("@cos", costo)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub modifica_pedidoCompraProducto(ByVal codPed As Integer, ByVal codPto As Integer, ByVal cant As Integer, ByRef costo As Double)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaPedido_Producto_C"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", cant)
        command.Parameters.AddWithValue("@cos", costo)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub elimina_pedidoCompraProducto(ByVal codPed As Integer, ByVal codPto As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_eliminaPedido_Producto_C"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub inserta_pedidoClienteProducto(ByVal codPed As Integer, ByVal codPto As String, ByVal cant As Integer, ByRef precio As Double)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_InsertaPedido_Producto"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", cant)
        command.Parameters.AddWithValue("@pre", precio)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub modifica_pedidoClienteProducto(ByVal codPed As Integer, ByVal codPto As Integer, ByVal cant As Integer, ByRef precio As Double)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaPedido_Producto"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", cant)
        command.Parameters.AddWithValue("@pre", precio)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub elimina_pedidoClienteProducto(ByVal codPed As Integer, ByVal codPto As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_eliminaPedido_Producto"
        command.Parameters.AddWithValue("@codP", codPed)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub Llenar_Marcas(ByRef cb As ComboBox, ByVal Tipo As Integer, ByVal Valor As String)

        cb.Items.Clear()

        If Tipo = 0 Then

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMarca"

        ElseIf Tipo = 1 Then

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMarcaLike"
            command.Parameters.AddWithValue("@Marca", Valor)

        End If

        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New comboItem(dr("Marca"), dr("Marca")))
        End While

        If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
            cb.Items.Add(New comboItem("Líneas Varias", "Líneas Varias"))
        End If

        dr.Close()

    End Sub

    Public Shared Sub Llenar_Modelo(ByRef cb As ComboBox, ByVal Tipo As Integer, ByVal Valor As String, ByVal valor2 As String)

        Try

            Dim par As Integer
            par = 0
            cb.Items.Clear()
            command.Parameters.Clear()
            If Tipo = 0 Then

                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaModelo"
                command.Parameters.AddWithValue("@modelo", "")
                command.Parameters.AddWithValue("@Tipo", 0)

            ElseIf Tipo = 1 Then

                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaModelo"
                command.Parameters.AddWithValue("@modelo", Valor)
                command.Parameters.AddWithValue("@Tipo", 2)

            ElseIf Tipo = 2 Then

                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaModelo"
                command.Parameters.AddWithValue("@modelo", Valor)
                command.Parameters.AddWithValue("@Tipo", 3)

            ElseIf Tipo = 3 Then

                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaModelo2"
                command.Parameters.AddWithValue("@modelo", Valor)
                command.Parameters.AddWithValue("@marca", valor2)

            End If

            dr = command.ExecuteReader()

            While dr.Read

                cb.Items.Add(New comboItem(dr("Modelo"), dr("Marca")))

            End While

            dr.Close()



        Catch ex As Exception

            MsgBox("Error cargando la lista de modelos", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.ToString())
            dr.Close()

        End Try

    End Sub

    Public Shared Sub Llenar_Grupos(ByRef cb As ComboBox, ByVal Tipo As Integer, ByVal valor As String)

        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaGrupo"
        If Tipo = 0 Then
            command.Parameters.AddWithValue("@cod", 0)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@valor", "")
        ElseIf Tipo = 1 Then
            command.Parameters.AddWithValue("@cod", 0)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@valor", valor)
        End If
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(dr("nombreGrupo"), dr("CodigoGrupo")))
        End While
        dr.Close()

    End Sub

    Public Shared Sub consulta_pedidos_Producto(ByRef dgv As DataGridView, ByVal Cod As String)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosPedidos"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Status"), dr("Nombre"), dr("Fecha"), dr("FechaStatus"), dr("CodigoPedido"), dr("Moneda"), dr("Costo"), dr("Cantidad"), dr("BackOrder"), Format(dr("CostoBs"), "#,##0.00"))

                If dr("Status") = "N" Then
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.IndianRed
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                ElseIf dr("Status") = "O" Then
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.MediumSeaGreen
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                End If

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try



    End Sub

    Public Shared Sub consulta_pedidos_Producto_brwme(ByRef dgv As DataGridView, ByVal Cod As String)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosPedidos_brwme"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Status"), dr("Nombre"), dr("Fecha"), dr("FechaStatus"), dr("CodigoPedido"), dr("Moneda"), dr("Costo"), dr("Cantidad"), dr("BackOrder"), Format(dr("CostoBs"), "#,##0.00"))

                If dr("Status") = "N" Then
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.IndianRed
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                ElseIf dr("Status") = "O" Then
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.MediumSeaGreen
                    dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                End If

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try



    End Sub

    Public Shared Sub consulta_ajustes_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosAjuste2"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Fecha"), dr("Cantidad"), dr("Observacion"))

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_CodigoArancelario_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)
        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCodigoArancelarioProducto"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("CodigoArancelario"), Format(CDbl(dr("Impuesto")), "#,##0.00").ToString + "%")

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try


    End Sub

    Public Shared Sub consulta_PreferenciaArancelaria_Producto(ByRef dgv As DataGridView, ByVal Cod As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPrefArancelaria"
            command.Parameters.AddWithValue("@CodA", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Nombre"), Format(CDbl(dr("Valor")), "#,##0.00").ToString + "%")

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try


    End Sub

    Public Shared Sub consulta_PreferenciaArancelaria_Producto2(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPrefArancelaria2"
            command.Parameters.AddWithValue("@CodA", Cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Nombre"), Format(CDbl(dr("Valor")), "#,##0.00").ToString + "%")

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try


    End Sub

    Public Shared Sub consulta_compras_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByRef cuenta As String)

        Try
            dgv.Rows.Clear()
            Dim acum As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosCompras"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Cantidad"), dr("NumeroFactura"), dr("Nombre"), dr("CodigoCompra"), dr("Fecha"), dr("TC"), "", "", Format(dr("Costo"), "#,##0.00" + dr("Moneda").ToString), Format(dr("ArancelCompra"), "#,##0.00"), Format(dr("ArancelBs"), "#,##0.00"), Format(dr("FleteYSeguro"), "#,##0.00"), Format(dr("OtrosG"), "#,##0.00"), Format(dr("CostoBs"), "#,##0.00"))
                acum = acum + CInt(dr("Cantidad"))

            End While

            cuenta = acum.ToString

        Catch ex As Exception

            MsgBox("Error consultando compras", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try


    End Sub

    Public Shared Sub consulta_grupos_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaGruposProducto"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("NombreGrupo"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try



    End Sub

    Public Shared Sub consulta_devoluciones_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDevolucionProducto"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                If dr("Ajustada") Then
                    dgv.Rows.Add(dr("Cantidad"), dr("NroControl"), dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), "Sí", dr("CantidadAjustada"), dr("Observacion"))
                Else
                    dgv.Rows.Add(dr("Cantidad"), dr("NroControl"), dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), "No", dr("CantidadAjustada"), dr("Observacion"))
                End If

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_devoluciones_Producto_brwme(ByRef dgv As DataGridView, ByVal Cod As String)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDevolucionProducto_brwme"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                If dr("Ajustada") Then
                    dgv.Rows.Add(dr("Cantidad"), dr("NroControl"), dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), "Sí", dr("CantidadAjustada"), dr("Observacion"))
                Else
                    dgv.Rows.Add(dr("Cantidad"), dr("NroControl"), dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), "No", dr("CantidadAjustada"), dr("Observacion"))
                End If

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_Proveedor_Producto(ByRef dgv As DataGridView, ByVal Cod As String, ByVal tipo As Integer)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoCodigoF"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Nombre"), dr("CodigoProductoF"), dr("Variante1"), dr("Variante2"), dr("codigoFabrica"))

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Productos_Por_Proveedor(ByVal Id As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 11)
            command.Parameters.AddWithValue("@IdF", CInt(Id))
            command.Parameters.AddWithValue("@Id", 0)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Variante1"), dr("Variante2"), dr("Marca"), dr("OEM"), "", "", dr("Foto"))

            End While

            dr.Close()

            DGV.ClearSelection()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Productos_Por_Compra(ByVal Id As Integer, ByVal codP As String, ByVal Tipo As Integer, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@IdF", Id)
            command.Parameters.AddWithValue("@Id", codP)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Variante1"), dr("Variante2"), dr("Marca"), dr("OEM"), "", "", dr("Foto"))

            End While

            dr.Close()

            DGV.ClearSelection()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Productos_Por_pedido(ByVal Id As Integer, ByVal codP As String, ByVal Tipo As Integer, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@IdF", Id)
            command.Parameters.AddWithValue("@Id", codP)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Variante1"), dr("Variante2"), dr("Marca"), dr("OEM"), "", "", dr("Foto"))

            End While

            dr.Close()

            DGV.ClearSelection()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Productos_Por_Grupo(ByVal CodF As String, ByVal CodProD As String, ByVal CodProv As Integer, ByVal Tipo As Integer, ByVal CodG As Integer, ByVal Nom As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosGrupoFabrica"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodF", CodF)
            command.Parameters.AddWithValue("@Codg", CodG)
            command.Parameters.AddWithValue("@Nom", Nom)
            command.Parameters.AddWithValue("@CodProv", CodProv)
            command.Parameters.AddWithValue("@CodProd", CodProD)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Variante1"), dr("Variante2"), dr("Marca"), dr("OEM"), "", "", dr("Foto"))

            End While


        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub VentasPorMes(ByVal Id As String, ByRef Chart As Dundas.Charting.WinControl.Chart, ByVal meses As Integer, ByVal Tipo As Integer, ByVal FechaMin As Date, ByVal FechaMax As Date)

        Try

            Chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            Chart.Palette = ChartColorPalette.Pastel
            Chart.Series("Series1").Type = SeriesChartType.Column
            Chart.Series("Series1").Color = Color.MediumTurquoise
            Chart.Series("Series2").Type = SeriesChartType.StackedColumn
            Chart.Series("Series2").Color = Color.IndianRed

            If Tipo = 0 Or Tipo = 2 Then

                command.CommandText = "sp_ventasPorMes"
                command.Parameters.AddWithValue("@Cod", Id)
                command.Parameters.AddWithValue("@Meses", meses)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@FechaMax", Today)
                command.Parameters.AddWithValue("@FechaMin", Today)

            ElseIf Tipo = 1 Or Tipo = 3 Then

                command.CommandText = "sp_ventasPorMes"
                command.Parameters.AddWithValue("@Cod", Id)
                command.Parameters.AddWithValue("@Meses", meses)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@FechaMax", FechaMax)
                command.Parameters.AddWithValue("@FechaMin", FechaMin)

            End If


            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Chart.DataSource = ds.Tables(0)

            Chart.Series("Series1").ValueMembersY = ds.Tables(0).Columns(1).ToString
            Chart.Series("Series1").ValueMemberX = ds.Tables(0).Columns(0).ToString
            Chart.Series("Series2").ValueMembersY = ds.Tables(0).Columns(2).ToString
            Chart.Series("Series2").ValueMemberX = ds.Tables(0).Columns(0).ToString
            Chart.Series("Series1").XValueIndexed = True
            Chart.Series("Series1")("LabelStyle") = "Center"
            Chart.Series("Series1").FontAngle = 45
            Chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            'Chart.Legends("Default").Enabled = False
            Chart.Series("Series1").YValueType = ChartValueTypes.Int
            Chart.Series("Series2").XValueIndexed = True
            Chart.Series("Series2")("LabelStyle") = "Center"
            Chart.Series("Series2").FontAngle = 45
            Chart.Series("Series2")("ColumnLabelStyle") = "Vertical"
            Chart.Series("Series2").YValueType = ChartValueTypes.Int



        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Dgv_Ventas(ByRef dgv As DataGridView, ByVal Cod As String, ByVal meses As Integer, ByVal Tipo As Integer, ByVal FechaMin As Date, ByVal FechaMax As Date)

        Try
            dgv.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_ventasDetalladasUltimosMeses"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Meses", meses)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@FechaMin", FechaMin)
            command.Parameters.AddWithValue("@FechaMax", FechaMax)

            dr = command.ExecuteReader

            If Tipo = 2 Or Tipo = 3 Then

                While dr.Read

                    dgv.Rows.Add(dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), dr("Cantidad"), dr("Precio"), dr("Dev"), dr("Empresa"))

                End While

            Else

                While dr.Read

                    dgv.Rows.Add(dr("ControlInicio"), dr("RazonSocial"), dr("Fecha"), dr("Cantidad"), dr("Precio"), dr("Dev"), "")

                End While

            End If

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la lista de ventas", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try


    End Sub

    Public Shared Sub PorFacturar(ByRef label1 As String, ByVal Cod As String, ByVal tipo As Integer)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosPorFacturar"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader

            dr.Read()

            If Not dr("Cantidad").GetType.ToString = "System.DBNull" Then

                label1 = dr("Cantidad")

            Else

                label1 = 0

            End If

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la cantidad por facturar del producto", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            label1 = "Error"

        End Try


    End Sub

    Public Shared Sub PorFacturar_brwme(ByRef label1 As String, ByVal Cod As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosPorFacturar_brwme"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader

            dr.Read()

            If Not dr("Cantidad").GetType.ToString = "System.DBNull" Then

                label1 = dr("Cantidad")

            Else

                label1 = 0

            End If

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando la cantidad por facturar del producto", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            label1 = "Error"

        End Try


    End Sub

    '-------------------------------------------Ventana Por Facturar------------------------------------'

    Public Shared Sub PedidosPorFacturar(ByRef Cod As String, ByVal Dgv As DataGridView, ByVal tipo As Integer)

        Try
            Dgv.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaPedidosPorFacturar"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader

            While dr.Read()

                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then
                If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then
                    Dgv.Rows.Add(dr("CodigoPedido"), dr("Fecha"), dr("RazonSocial"), dr("Cantidad"), dr("Empresa"))
                Else
                    Dgv.Rows.Add(dr("CodigoPedido"), dr("Fecha"), dr("RazonSocial"), dr("Cantidad"))
                End If

            End While


            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub



End Class
