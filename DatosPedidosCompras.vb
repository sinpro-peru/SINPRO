Imports System.Data.SqlClient
Public Class DatosPedidosCompras
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Private Shared entrar As Boolean = False

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub lv_PedidoCompra(ByRef dgv As DataGridView, ByVal s As String, ByVal val As Integer, ByVal status As String, ByRef dolares As String, ByRef euros As String)

        Try

            dolares = "0"
            euros = "0"
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvPedidoProveedor"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", val)
            command.Parameters.AddWithValue("@status", status)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Codigo"), dr("Fecha"), dr("Nombre"), Format(dr("Total"), "#,##0.00"), dr("Moneda"), dr("CodigoFabrica"))

                If dr("Moneda").ToString = "$" Then

                    dolares = CDbl(dolares) + dr("Total")

                Else

                    euros = CDbl(euros) + dr("Total")

                End If

            End While

            dolares = Format(CDbl(dolares), "#,##0.00")
            euros = Format(CDbl(euros), "#,##0.00")

        Catch ex As Exception
            MsgBox("Error actualizando pedidos", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub identidad_Compra(ByRef cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadCompra"
            dr = command.ExecuteReader
            dr.Read()
            cod = dr("Expr1")
        Catch ex As Exception
            MsgBox("Error consultando el correlativo", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub cargarcompra(ByVal codP As Integer)

        Try

            Dim cod As Integer
            Dim flete As Double
            Dim seguro As Double
            Dim aranceles As Double
            Dim otros As Double
            Dim fecha As DateTime
            Dim moneda As String = ""
            Dim cambio As String = ""
            Dim codfac As String = ""
            Dim fecfac As DateTime
            Dim fechaO As Date
            Dim t1 As Integer
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidoCompra"
            command.Parameters.AddWithValue("@cod", codP)
            dr = command.ExecuteReader()
            While dr.Read
                cod = dr("CodigoProveedor")
                flete = dr("Flete")
                seguro = dr("Seguro")
                aranceles = dr("Aranceles")
                otros = dr("OtrosGastos")
                fecha = dr("Fecha")
                fecfac = dr("FechaFacturaProForma")
                fechaO = dr("FechaO")
                t1 = dr("Tiempo1")

                If dr("Moneda").GetType.ToString = "System.DBNull" Then
                    moneda = ""
                Else
                    moneda = dr("Moneda")
                End If

                If dr("TipoCambio").GetType.ToString = "System.DBNull" Then
                    cambio = ""
                Else
                    cambio = dr("TipoCambio")
                End If
                If dr("CodigoFacturaProForma").GetType.ToString = "System.DBNull" Then
                    codfac = ""
                Else
                    codfac = dr("CodigoFacturaProForma")
                End If

            End While
            dr.Close()

            Dim fec As Date = Date.Now
            Dim t2 As Integer = DateDiff(DateInterval.Day, fechaO, fec)

            Dim i As Integer = 1
            command.Parameters.Clear()
            command.CommandText = "sp_insertaCompra"
            command.Parameters.AddWithValue("@tipo", i)
            command.Parameters.AddWithValue("@codP", cod)
            command.Parameters.AddWithValue("@fle", flete)
            command.Parameters.AddWithValue("@seg", seguro)
            command.Parameters.AddWithValue("@aran", aranceles)
            command.Parameters.AddWithValue("@otroG", otros)
            command.Parameters.AddWithValue("@fec", fecha)
            command.Parameters.AddWithValue("@fecFPF", fecfac)
            command.Parameters.AddWithValue("@t1", t1)
            command.Parameters.AddWithValue("@t2", t2)
            If moneda = "" Then
                command.Parameters.AddWithValue("@mon", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@mon", moneda)
            End If

            If cambio = "" Then
                command.Parameters.AddWithValue("@tipoC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@tipoC", CDbl(cambio))
            End If

            If codfac = "" Then
                command.Parameters.AddWithValue("@codFPF", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@codFPF", CInt(codfac))
            End If
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error cargando compra", MsgBoxStyle.Critical, "SINPRO")

            If Not dr.IsClosed Then
                dr.Close()
            End If

        End Try

    End Sub
    Public Shared Sub cargarcompra_producto(ByVal codP As Integer, ByRef l As Collection)

        Try

            Dim codPto As String
            Dim cant As Integer
            Dim costo As Double
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedido_Producto_C"
            command.Parameters.AddWithValue("@codP", codP)
            dr = command.ExecuteReader()
            While dr.Read
                codPto = dr("CodigoProducto")
                cant = dr("Cantidad")
                costo = dr("Costo")
                l.Add(codPto)
                l.Add(cant)
                l.Add(costo)
            End While

        Catch ex As Exception
            MsgBox("Error cargando productos de la compra", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try


    End Sub
    Public Shared Sub cargarcompra_producto2(ByVal l As Collection, ByVal codC As Integer)
        'Dim codPto As Integer
        'Dim cant As Integer
        'Dim costo As Double
        Dim i As Integer = 1
        While i < l.Count
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaCompra_Producto"
            command.Parameters.AddWithValue("@codC", codC)
            command.Parameters.AddWithValue("@codPto", l.Item(i))
            command.Parameters.AddWithValue("@cant", l.Item(i + 1))
            command.Parameters.AddWithValue("@cos", l.Item(i + 2))
            command.ExecuteNonQuery()
            i = i + 3
        End While
    End Sub

    Public Shared Sub consulta_status(ByRef cb As MTGCComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaStatus"
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New MTGCComboBoxItem(CStr(dr("Status"))))
            End While

        Catch ex As Exception
            MsgBox("Error consultando status", MsgBoxStyle.Critical, "SINRPO")
        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub consulta_Status2(ByRef cb As MTGCComboBox, ByVal s As String)
        If s = "S " Then
            cb.Items.Add(New MTGCComboBoxItem("S"))
            cb.Items.Add(New MTGCComboBoxItem("SR"))
            cb.Items.Add(New MTGCComboBoxItem("C"))
        ElseIf s = "SR" Then
            cb.Items.Add(New MTGCComboBoxItem("SR"))
            cb.Items.Add(New MTGCComboBoxItem("C"))
        ElseIf s = "C " Then
            cb.Items.Add(New MTGCComboBoxItem("C"))
            cb.Items.Add(New MTGCComboBoxItem("CR"))
            cb.Items.Add(New MTGCComboBoxItem("O"))
        ElseIf s = "CR" Then
            cb.Items.Add(New MTGCComboBoxItem("CR"))
            cb.Items.Add(New MTGCComboBoxItem("O"))
        ElseIf s = "O " Then
            cb.Items.Add(New MTGCComboBoxItem("O"))
            cb.Items.Add(New MTGCComboBoxItem("N"))
        ElseIf s = "N " Then
            cb.Items.Add(New MTGCComboBoxItem("N"))
        End If
    End Sub
    Public Shared Sub consulta_proveedores(ByRef cb As ComboBox)

        Try
            Dim par As Integer
            par = 0
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProveedor"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New comboItem(CStr(dr("nombre")), CInt(dr("codigoFabrica"))))
            End While
        Catch ex As Exception
            MsgBox("Error cargando proveedores", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub inserta_pedidoCompra(ByVal codP As Integer, ByVal fle As Double, ByVal seg As Double, ByVal aran As Double, ByVal otroG As Double, ByVal fec As Date, ByVal mon As String, ByVal tipoC As String, ByVal codFPF As String, ByVal fecFPF As Date, ByVal obs As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaPedidoCompra"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@fle", fle)
            command.Parameters.AddWithValue("@seg", seg)
            command.Parameters.AddWithValue("@aran", aran)
            command.Parameters.AddWithValue("@otroG", otroG)
            command.Parameters.AddWithValue("@fec", fec)
            command.Parameters.AddWithValue("@fecFPF", fecFPF)
            command.Parameters.AddWithValue("@Obs", obs)

            If mon = "" Then
                command.Parameters.AddWithValue("@mon", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@mon", mon)
            End If
            If tipoC = "" Then
                command.Parameters.AddWithValue("@tipoC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@tipoC", CDec(tipoC))
            End If
            If codFPF = "" Then
                command.Parameters.AddWithValue("@codFPF", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@codFPF", CInt(codFPF))
            End If
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando el producto '" + codP + "'", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub inserta_pedidoCompra_D(ByVal codP As Integer, ByVal obs As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaPedidoCompra_Dist"
            command.Parameters.AddWithValue("@codAnt", codP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error insertando el producto '" + codP + "'", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub inserta_pedidoCompra_CONAVE(ByVal codP As Integer, ByVal obs As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaPedidoCompra_CONAVE"
            command.Parameters.AddWithValue("@codAnt", codP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error insertando el producto '" + codP + "'", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub


    Public Shared Sub Mueve_ProductosPedidoCompra(ByVal codP As Integer, ByVal ant As Integer, ByVal Status As String, ByVal Tipo As Integer, ByVal Proveedor As Integer, ByVal CodPro As String)

        Try

            command.Parameters.Clear()

            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                command.CommandText = "sp_mueveProductosPedidoCompra"
            Else
                command.CommandText = "sp_mueveProductosPedidoCompra_BRWME"
            End If

            command.Parameters.AddWithValue("@codPed", codP)
            command.Parameters.AddWithValue("@codAnt", ant)
            command.Parameters.AddWithValue("@Sta", Status)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Prov", Proveedor)
            command.Parameters.AddWithValue("@CodPro", CodPro)
            command.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub Mueve_ProductosPedidoCompra_D(ByVal codP As Integer, ByVal ant As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_mueveProductosPedidoCompra_Dist"
        command.Parameters.AddWithValue("@codPed", codP)
        command.Parameters.AddWithValue("@codAnt", ant)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub Mueve_ProductosPedidoCompra_CONAVE(ByVal codP As Integer, ByVal ant As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_mueveProductosPedidoCompra_CONAVE"
        command.Parameters.AddWithValue("@codPed", codP)
        command.Parameters.AddWithValue("@codAnt", ant)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub consulta_pedidoCompra(ByVal c As Integer, ByRef cod As String, ByRef fle As String, ByRef seg As String, ByRef aran As String, ByRef otroG As String, ByRef fec As Date, ByRef mon As String, ByRef pro As String, ByRef codFPF As String, ByRef fecFPF As Date, ByRef obs As String, ByRef CodP2 As Label, ByRef pedidoC As CheckBox, ByRef codProv As Integer)
        Try
            Dim codP As Integer
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidoCompra"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()

            While dr.Read()

                cod = CStr(dr("codigoPedido"))
                codProv = CStr(dr("codigoProveedor"))

                If dr("Flete").GetType.ToString = "System.DBNull" Then
                    fle = "0,00"
                Else
                    fle = CStr(Format(dr("flete"), "#,##0.00"))
                End If

                If dr("Seguro").GetType.ToString = "System.DBNull" Then
                    seg = "0,00"
                Else
                    seg = CStr(Format(dr("seguro"), "#,##0.00"))
                End If

                If dr("aranceles").GetType.ToString = "System.DBNull" Then
                    aran = "0,00"
                Else
                    aran = CStr(Format(dr("aranceles"), "#,##0.00"))
                End If

                If dr("otrosGastos").GetType.ToString = "System.DBNull" Then
                    otroG = "0,00"
                Else
                    otroG = CStr(Format(dr("otrosGastos"), "#,##0.00"))
                End If

                If dr("Fecha").GetType.ToString = "System.DBNull" Then
                    fec = Today
                Else
                    fec = dr("fecha")
                End If

                If dr("fechaFacturaProForma").GetType.ToString = "System.DBNull" Then
                    fecFPF = Today
                Else
                    fecFPF = dr("fechaFacturaProForma")
                End If

                If dr("codigoProveedor").GetType.ToString = "System.DBNull" Then
                    codP = 0
                Else
                    codP = dr("codigoProveedor")
                End If

                If dr("Observacion").GetType.ToString = "System.DBNull" Then
                    obs = ""
                Else
                    obs = dr("Observacion")
                End If

                CodP2.Text = codP

                If dr("moneda").GetType.ToString = "System.DBNull" Then
                    mon = ""
                Else
                    mon = dr("moneda")
                End If
                If dr("codigoFacturaProForma").GetType.ToString = "System.DBNull" Then
                    codFPF = ""
                Else
                    codFPF = CStr(dr("codigoFacturaProForma"))
                End If

                pedidoC.Checked = dr("Facturado")

                Dim a As String = dr("NombreF").ToString

                pro = a

            End While

        Catch ex As Exception
            MsgBox("Error consultando el pedido", MsgBoxStyle.Critical, "SINRPO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_UltimopedidoCompra(ByRef Cod As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUltimoPedidoCompra"
            dr = command.ExecuteReader()

            While dr.Read
                Cod = CStr(CInt(dr("codigoPedido")))
            End While

        Catch ex As Exception
            MsgBox("Error consultando el pedido", MsgBoxStyle.Critical, "SINRPO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_UltimopedidoCompra_D(ByRef Cod As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUltimoPedidoCompra_Dist"
            dr = command.ExecuteReader()

            While dr.Read
                Cod = CStr(CInt(dr("codigoPedido")))
            End While

        Catch ex As Exception
            MsgBox("Error consultando el pedido", MsgBoxStyle.Critical, "SINRPO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_UltimopedidoCompra_CONAVE(ByRef Cod As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUltimoPedidoCompra_CONAVE"
            dr = command.ExecuteReader()

            While dr.Read
                Cod = CStr(CInt(dr("codigoPedido")))
            End While

        Catch ex As Exception
            MsgBox("Error consultando el pedido", MsgBoxStyle.Critical, "SINRPO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub modifica_pedidoCompra(ByVal fle As Double, ByVal seg As Double, ByVal aran As Double, ByVal otroG As Double, ByVal fec As DateTime, ByVal mon As String, ByVal tipoC As String, ByVal codFPF As String, ByVal fecFPF As DateTime, ByVal COD As Integer, ByVal obs As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaPedidoCompra"
            command.Parameters.AddWithValue("@fle", fle)
            command.Parameters.AddWithValue("@seg", seg)
            command.Parameters.AddWithValue("@aran", aran)
            command.Parameters.AddWithValue("@otroG", otroG)
            command.Parameters.AddWithValue("@fec", fec)
            command.Parameters.AddWithValue("@fecFPF", fecFPF)
            command.Parameters.AddWithValue("@obs", obs)
            command.Parameters.AddWithValue("@COD", COD)

            If mon = "" Then
                command.Parameters.AddWithValue("@mon", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@mon", mon)
            End If
            If tipoC = "" Then
                command.Parameters.AddWithValue("@tipoC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@tipoC", CDec(tipoC))
            End If
            If codFPF = "" Then
                command.Parameters.AddWithValue("@codFPF", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@codFPF", CInt(codFPF))
            End If
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando el pedido", MsgBoxStyle.Critical, "SINPRO")
        End Try


    End Sub


    Public Shared Sub modifica_Fob(ByVal CodP As Integer, ByVal CodPto As String, ByVal bo As Boolean, ByVal fob As Double, ByVal precioAnt As Double)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaFOB"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@CodPto", CodPto)
            command.Parameters.AddWithValue("@BO", bo)
            command.Parameters.AddWithValue("@FOB", fob)
            command.Parameters.AddWithValue("@Ant", precioAnt)
            command.ExecuteNonQuery()

            MsgBox("F.O.B. Modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        Catch ex As Exception

            MsgBox("Error modificando el pedido", MsgBoxStyle.Critical, "SINPRO")

        End Try


    End Sub



    Public Shared Sub elimina_pedidoCompra(ByVal cod As Integer, ByVal tipo As Integer, ByVal status As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_eliminaPedidoCompra"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.Parameters.AddWithValue("@Status", status)
            command.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Error eliminando pedido", MsgBoxStyle.Critical, "SINPRO")
        End Try



    End Sub
    Public Shared Sub identidad_PedidoCompra(ByRef tb As Label)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadPedidoCompra"
            dr = command.ExecuteReader
            dr.Read()
            tb.Text = dr("Expr1") + 1
        Catch ex As Exception
            MsgBox("Error consultando el correlativo", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

        
    End Sub

    '----------------------------------------------------------------------------------------

    Public Shared Sub consulta_productos(ByRef t As DataTable)

        Try
            Dim dRow As DataRow
            Dim par As String
            par = "todos"
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()
            While dr.Read()
                dRow = t.NewRow()
                dRow("Asociado") = False
                dRow("Cantidad") = 0
                dRow("Nombre") = dr("Nombre")
                dRow("Código") = dr("CodigoInterno")
                dRow("Costo") = 0
                dRow("Existencia") = dr("cantidadexistencia")
                t.Rows.Add(dRow)
            End While
            t.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error consultando lista de productos", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub
    Public Shared Sub ultimo_costo(ByVal cod As String, ByRef ultimo As Double)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoUltimoCosto"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()
            If dr.Read Then
                ultimo = dr(0)
            Else
                ultimo = 0
            End If
        Catch ex As Exception
            MsgBox("Error consultando último costo del producto '" + cod + "'")
        Finally
            dr.Close()
        End Try
        

    End Sub

    Public Shared Sub consulta_pedido_producto_proveedor(ByVal cod As String, ByRef t As DataTable)
        Try
            Dim dRow As DataRow
            Dim prod As New Collection
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedido_Produto_CompraMelissa"
            command.Parameters.AddWithValue("@codP", cod)
            dr = command.ExecuteReader()
            While dr.Read()
                dRow = t.NewRow()
                dRow("Asociado") = True
                dRow("Cantidad") = dr("Cantidad")
                dRow("Nombre") = dr("Nombre")
                dRow("Código") = dr("CodigoInterno")
                dRow("Costo") = dr("Costo")
                dRow("Existencia") = dr("cantidadexistencia")
                t.Rows.Add(dRow)
                prod.Add(dr("CodigoInterno"))
            End While
            t.AcceptChanges()
            dr.Close()
            Dim item As Object
            Dim ultimo As Double
            For Each item In prod
                ultimo_costo(item, ultimo)
                Dim i As Integer = 0
                While i <= t.Rows.Count - 1
                    If t.Rows(i).Item("Código") = item Then
                        t.Rows(i).Item("Último") = ultimo
                    End If
                    i = i + 1
                End While
            Next
            t.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error modificando último costo", MsgBoxStyle.Critical, "SINPTRO")
        Finally
            If Not dr.IsClosed Then
                dr.Close()
            End If
        End Try

    End Sub


    Public Shared Sub insertar_producto_pedido(ByVal codP As Integer, ByVal codPto As String, ByVal c As Integer, ByVal p As Double, ByVal status As String, ByVal fechaS As Date, ByVal BO As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaPedido_Producto_C"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPto", codPto)
            command.Parameters.AddWithValue("@cant", c)
            command.Parameters.AddWithValue("@cos", p)
            command.Parameters.AddWithValue("@Status", status)
            command.Parameters.AddWithValue("@FechaSta", fechaS)
            command.Parameters.AddWithValue("@BO", BO)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando productos en pedido", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub modifica_producto_pedido(ByVal codP As Integer, ByVal codPto As String, ByVal c As Integer, ByVal p As Double, ByVal status As String, ByVal fechaS As Date, ByVal BO As Boolean, ByVal bo2 As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaPedido_ProductoC"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPto", codPto)
            command.Parameters.AddWithValue("@cant", c)
            command.Parameters.AddWithValue("@cos", p)
            command.Parameters.AddWithValue("@Status", status)
            command.Parameters.AddWithValue("@FechaSta", fechaS)
            command.Parameters.AddWithValue("@BO", BO)
            command.Parameters.AddWithValue("@BO2", bo2)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando productos en pedido", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub
    Public Shared Sub consulta_productos2(ByRef t As DataTable, ByVal codPed As Integer)

        Try
            Dim dRow As DataRow
            Dim prod As New Collection
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_Producto_Minus_Pedido_Proveedor"
            command.Parameters.AddWithValue("@codP", codPed)
            dr = command.ExecuteReader()
            While dr.Read()
                dRow = t.NewRow()
                dRow("Asociado") = False
                dRow("Cantidad") = 0
                dRow("Nombre") = dr("Nombre")
                dRow("Código") = dr("CodigoInterno")
                dRow("Costo") = 0
                dRow("Existencia") = dr("CantidadExistencia")
                t.Rows.Add(dRow)
                prod.Add(dr("CodigoInterno"))
            End While
            t.AcceptChanges()
            dr.Close()

            Dim item As Object
            Dim ultimo As Double

            For Each item In prod
                ultimo_costo(item, ultimo)
                Dim i As Integer = 0
                While i <= t.Rows.Count - 1
                    If t.Rows(i).Item("Código") = item Then
                        t.Rows(i).Item("Último") = ultimo
                    End If
                    i = i + 1
                End While
            Next
            t.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error modificando último costo", MsgBoxStyle.Critical, "SINPTRO")
        Finally
            If Not dr.IsClosed Then
                dr.Close()
            End If
        End Try


    End Sub
    Public Shared Sub actualizar_producto_pedido(ByVal codP As Integer, ByVal codPto As String, ByVal c As Integer, ByVal cos As Double)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaPedido_Producto_C2"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPto", codPto)
            command.Parameters.AddWithValue("@cant", c)
            command.Parameters.AddWithValue("@costo", cos)
            command.Parameters.AddWithValue("@flete", 0)
            command.Parameters.AddWithValue("@otros", 0)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando pedido", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub
    Public Shared Sub elimina_producto_pedido(ByVal codP As Integer)

        Try
            Dim int As String = item
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaPedido_Producto_C"
            command.Parameters.AddWithValue("@codP", codP)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando el producto '" + codP + "' del pedido", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub elimina_producto_pedido2(ByVal codPto As String, ByVal codP As Integer, ByVal bo As Boolean)

        Try
            Dim int As String = item
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaPedido_Producto_C3"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPto", codPto)
            command.Parameters.AddWithValue("@BO", bo)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando productos del pedido", MsgBoxStyle.Critical, "SINRPO")
        End Try


    End Sub

    Public Shared Sub modifica_status(ByVal codP As Integer, ByVal Viejo As String, ByVal Nuevo As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_statusPedidoCompra"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@Viejo", Viejo)
            command.Parameters.AddWithValue("@Nuevo", Nuevo)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando el status de los productos", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub modifica_status2(ByVal codPed As Integer, ByVal Viejo As String, ByVal Nuevo As String, ByVal CodPro As String, ByVal Tipo As Integer, ByVal bo As Boolean)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaStatus"
            command.Parameters.AddWithValue("@codPed", codPed)
            command.Parameters.AddWithValue("@de", Viejo)
            command.Parameters.AddWithValue("@a", Nuevo)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@BO", bo)
            command.Parameters.AddWithValue("@codPro", CodPro)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando el status de los productos", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub modifica_fecha(ByVal cod As Integer)

        Try
            Dim fecha As Date = Date.Now

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaPedidoCompraFechaO"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@fec", fecha)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando fecha", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub
    Public Shared Sub Obtiene_FechaO(ByRef fec As Date, ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidoCompraFechaO"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader
            dr.Read()
            fec = dr("fecha")
        Catch ex As Exception
            MsgBox("Error consultando fecha", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    'Public Shared Sub modifica_tiempo1(ByVal t1 As Integer, ByVal cod As Integer)
    '    Dim fecha As Date = Date.Now
    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_modificaPedidoCompraTiempo1"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.Parameters.AddWithValue("@t1", t1)
    '    command.Parameters.AddWithValue("@fec", fecha)
    '    command.ExecuteNonQuery()
    'End Sub

    Public Shared Sub consulta_Proveedor(ByRef cb As ComboBox)

        Try
            Dim par As Integer
            par = 0
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProveedor"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()
            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoFabrica")))

            End While

        Catch ex As Exception

            MsgBox("Error cargando lista de proveedores", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_ProveedorLike(ByRef cb As ComboBox, ByVal codigo As String, ByRef texto As String)

        If entrar = False Then

            Try

                cb.Items.Clear()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaProveedorCombo"
                command.Parameters.AddWithValue("@cod", codigo)
                dr = command.ExecuteReader()

                While dr.Read

                    cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoFabrica")))

                End While
                texto = cb.Text

            Catch ex As Exception
                MsgBox("Error cargando lista de proveedores", MsgBoxStyle.Critical, "SINPRO")
            Finally
                dr.Close()
            End Try

        End If

    End Sub


    Public Shared Sub Llenar_DGV_Productos_Por_Proveedor(ByVal Id As String, ByVal DGV As DataGridView)

        Try
            'DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 2)
            command.Parameters.AddWithValue("@IdF", CInt(Id))
            command.Parameters.AddWithValue("@Id", 0)
            dr = command.ExecuteReader
            Dim anterior As String = ""
            Dim CodFab As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
                End If



                If anterior = dr("CodigoInterno") Then


                    Dim celdac As New DataGridViewComboBoxCell
                    Dim celdat As New DataGridViewTextBoxCell
                    Dim celdaN As New DataGridViewTextBoxCell
                    Dim celdacant As New DataGridViewTextBoxCell
                    Dim celdaCF As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    celdacant.Value = ""
                    fila.Cells.Add(celdacant)
                    celdat.Value = dr("CodigoInterno")
                    fila.Cells.Add(celdat)
                    celdaCF.Value = CodFab
                    fila.Cells.Add(celdaCF)
                    celdaN.Value = dr("Nombre")
                    fila.Cells.Add(celdaN)
                    celdac.Items.Add(DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value)
                    celdac.Items.Add(dr("Modelo"))
                    celdac.Value = DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value
                    celdac.ReadOnly = False
                    fila.Cells.Add(celdac)
                    DGV.Rows.RemoveAt(DGV.Rows.Count - 1)
                    fila.Cells(4).ReadOnly = False
                    DGV.Rows.Add(fila)

                Else

                    DGV.Rows.Add("", dr("CodigoInterno"), CodFab, dr("Nombre"), dr("Modelo"))
                    DGV.Rows(DGV.RowCount - 1).Cells(4).ReadOnly = True

                End If

                anterior = dr("CodigoInterno")

            End While

            DGV.Columns(0).ReadOnly = False

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub


    Public Shared Sub Llenar_DGV(ByVal Id As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 1)
            command.Parameters.AddWithValue("@IdF", Id)
            command.Parameters.AddWithValue("@Id", "")
            dr = command.ExecuteReader
            Dim anterior As String = ""
            Dim CodFab As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
                End If



                If anterior = dr("CodigoInterno") Then


                    Dim celdac As New DataGridViewComboBoxCell
                    Dim celdat As New DataGridViewTextBoxCell
                    Dim celdaN As New DataGridViewTextBoxCell
                    Dim celdacant As New DataGridViewTextBoxCell
                    Dim celdaCF As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    celdacant.Value = ""
                    fila.Cells.Add(celdacant)
                    celdat.Value = dr("CodigoInterno")
                    fila.Cells.Add(celdat)
                    celdaCF.Value = CodFab
                    fila.Cells.Add(celdaCF)
                    celdaN.Value = dr("Nombre")
                    fila.Cells.Add(celdaN)
                    celdac.Items.Add(DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value)
                    celdac.Items.Add(dr("Modelo"))
                    celdac.Value = DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value
                    celdac.ReadOnly = False
                    fila.Cells.Add(celdac)
                    DGV.Rows.RemoveAt(DGV.Rows.Count - 1)
                    fila.Cells(4).ReadOnly = False
                    DGV.Rows.Add(fila)

                Else

                    DGV.Rows.Add("", dr("CodigoInterno"), CodFab, dr("Nombre"), dr("Modelo"))
                    DGV.Rows(DGV.RowCount - 1).Cells(4).ReadOnly = True

                End If

                anterior = dr("CodigoInterno")

            End While

            DGV.Columns(0).ReadOnly = False



        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub


    Public Shared Sub Consulta_Moneda(ByRef cb As ComboBox)

        Try
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMoneda"
            dr = command.ExecuteReader()

            While dr.Read

                cb.Items.Add(New comboItem(dr("Moneda"), ""))

            End While

        Catch ex As Exception
            MsgBox("Error cargando monedas", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_Productos_pedido(ByVal cod As Integer, ByRef dgv As MyDataGridView3)

        Try

            If Not dr.IsClosed Then
                dr.Close()
            End If

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure

            If My.Settings.Empresa = 1 Then
                command.CommandText = "sp_consultaProductosPedidoCompra_BRWME"
            Else
                command.CommandText = "sp_consultaProductosPedidoCompra"
            End If

            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            While dr.Read()
                dgv.Rows.Add(dr("Status"), dr("Codigo"), dr("CodigoProductoF"), dr("Nombre"), dr("Modelo"), dr("Cantidad"), dr("Costo"), Format(CDbl(dr("Costo")) * CInt(dr("Cantidad")), "#,##0.00"), dr("Fecha"), dr("Status1"), dr("Backorder"), dr("Arancel"), dr("Backorder"), dr("Marca"))
            End While

        Catch ex As Exception
            MsgBox("Error cargando productos", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub insertar_producto_pedido2(ByVal codigoPedido As Integer, ByVal codigoProducto As String, ByVal cant1 As Integer, ByVal costo As Double, ByVal cant2 As Integer)

        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaBackorderProducto"
            command.Parameters.AddWithValue("@codP", codigoPedido)
            command.Parameters.AddWithValue("@codPro", codigoProducto)
            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.CommandText = "sp_insertaPCompraConBackorder"
                command.Parameters.AddWithValue("@codP", codigoPedido)
                command.Parameters.AddWithValue("@codPto", codigoProducto)
                command.Parameters.AddWithValue("@cant2", cant2)
                command.Parameters.AddWithValue("@cant", cant1)
                command.Parameters.AddWithValue("@cos", costo)
                command.Parameters.AddWithValue("@Status", "O")
                command.Parameters.AddWithValue("@FechaSta", Today)
                command.Parameters.AddWithValue("@Tipo", 1)
                command.ExecuteNonQuery()


            Else

                dr.Close()

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.CommandText = "sp_insertaPCompraConBackorder"
                command.Parameters.AddWithValue("@codP", codigoPedido)
                command.Parameters.AddWithValue("@codPto", codigoProducto)
                command.Parameters.AddWithValue("@cant2", cant2)
                command.Parameters.AddWithValue("@cant", cant1)
                command.Parameters.AddWithValue("@cos", costo)
                command.Parameters.AddWithValue("@Status", "O")
                command.Parameters.AddWithValue("@FechaSta", Today)
                command.Parameters.AddWithValue("@Tipo", 0)
                command.ExecuteNonQuery()

            End If

            'MsgBox("Cantidad modificada satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        Catch ex As Exception

            MsgBox("Error modificando cantidad", MsgBoxStyle.Critical, "Error")


        Finally

            If Not dr.IsClosed Then
                dr.Close()
            End If

        End Try

    End Sub


    Public Shared Sub actualizar_producto_pedido2(ByVal codigoPedido As Integer, ByVal codigoProducto As String, ByVal cant2 As Integer, ByVal Tipo As Integer)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_modificaPedido_Producto_C3"
            command.Parameters.AddWithValue("@codP", codigoPedido)
            command.Parameters.AddWithValue("@codPto", codigoProducto)
            command.Parameters.AddWithValue("@cant", cant2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.ExecuteNonQuery()
            'MsgBox("Cantidad modificada satisfactoriamente", MsgBoxStyle.Information, "SINPRO")


        Catch ex As Exception

            MsgBox("Error modificando cantidad", MsgBoxStyle.Information, "Error")


        End Try


    End Sub

    Public Shared Sub modificar_factura_compra(ByVal codigocompra As Integer, ByVal fact As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_modificaPedido_Producto_C3"
            command.Parameters.AddWithValue("@CodC", codigocompra)
            command.Parameters.AddWithValue("@Fact", fact)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando factura", MsgBoxStyle.Information, "Error")


        End Try


    End Sub


    Public Shared Sub Llenar_DGV_Productos_Por_Proveedor_Like(ByVal Id As String, ByVal DGV As DataGridView, ByVal IdF As Integer, ByVal Tipo As Integer)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@IdF", IdF)
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader
            Dim anterior As String = ""
            Dim CodFab As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
                End If



                If anterior = dr("CodigoInterno") Then


                    Dim celdac As New DataGridViewComboBoxCell
                    Dim celdat As New DataGridViewTextBoxCell
                    Dim celdaN As New DataGridViewTextBoxCell
                    Dim celdacant As New DataGridViewTextBoxCell
                    Dim celdaCF As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    celdacant.Value = ""
                    fila.Cells.Add(celdacant)
                    celdat.Value = dr("CodigoInterno")
                    fila.Cells.Add(celdat)
                    celdaCF.Value = CodFab
                    fila.Cells.Add(celdaCF)
                    celdaN.Value = dr("Nombre")
                    fila.Cells.Add(celdaN)
                    celdac.Items.Add(DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value)
                    celdac.Items.Add(dr("Modelo"))
                    celdac.Value = DGV.Rows(DGV.Rows.Count - 1).Cells(4).Value
                    celdac.ReadOnly = False
                    fila.Cells.Add(celdac)
                    DGV.Rows.RemoveAt(DGV.Rows.Count - 1)
                    fila.Cells(4).ReadOnly = False
                    DGV.Rows.Add(fila)

                Else

                    DGV.Rows.Add("", dr("CodigoInterno"), CodFab, dr("Nombre"), dr("Modelo"))
                    DGV.Rows(DGV.RowCount - 1).Cells(4).ReadOnly = True

                End If

                anterior = dr("CodigoInterno")

            End While

            DGV.Columns(0).ReadOnly = False

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub consulta_productos_nacionalizados(ByRef dt As DataTable, ByVal codP As Integer)

        Try
            dt.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                command.CommandText = "sp_consulta_productos_nacionalizados_BRWME"
            Else
                command.CommandText = "sp_consulta_productos_nacionalizados"
            End If
            command.Parameters.AddWithValue("@CodP", codP)
            dr = command.ExecuteReader()
            While dr.Read
                dt.Rows.Add(dr("CodigoProducto"), dr("CodigoProductoF"), dr("Nombre"), dr("CantidadExistencia"), dr("CantidadPedido"), dr("Ubicacion"), dr("Cantidad"), dr("Modelo"))
            End While
        Catch ex As Exception
            MsgBox("Error consultando productos nacionalizados", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
        
    End Sub



End Class
