Imports System.Data.SqlClient
Public Class DatosAgregarAPedido
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_top_pedido(ByVal cod As Integer, ByVal DGV As DataGridView, ByVal tipo As Integer)
        DGV.ClearSelection()
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_top_Pedido"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@tipo", tipo)
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("CodigoPedido"), dr("FechaMod"), dr("Fecha"))
        End While
        DGV.ClearSelection()
        dr.Close()
    End Sub
    Public Shared Sub consulta_proveedores(ByRef cb As ComboBox, ByVal codigo As String, ByVal tipo As Boolean)

        Dim cont As Integer
        Dim esta As Boolean = False
        If tipo = True Then
            cb.Items.Clear()
        End If

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedorProducto"
        command.Parameters.AddWithValue("@codigo", codigo)
        command.Parameters.AddWithValue("@tipo", tipo)


        dr = command.ExecuteReader()
        While dr.Read
            If tipo = True Then
                cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoFabrica")))
            ElseIf tipo = False Then
                For cont = 0 To cb.Items.Count - 1
                    If cb.Items.Item(cont).ToString.ToUpper = dr("Nombre").ToString.ToUpper Then
                        esta = True
                        cont = cb.Items.Count
                    End If
                Next

                If esta = False Then
                    'cb2.Items.Add(New comboItem(dr("Nombre"), dr("CodigoFabrica")))
                End If

                esta = False
                cont = 0
            End If
        End While


        dr.Close()
    End Sub
    Public Shared Sub actualizarPedido(ByVal codP As String, ByVal codPro As String, ByVal cantidad As Integer)
        Dim esta As Boolean = False
        Dim cant As Integer = 0
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoPedidoCompra"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPro", codPro)


            dr = command.ExecuteReader()
            While dr.Read
                esta = True
                cant = CInt(dr("Cantidad"))
            End While
        Catch ex As Exception

        End Try
        dr.Close()

        If esta = True Then
            Try
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaPedidoCompraProducto"
                command.Parameters.AddWithValue("@codP", codP)
                command.Parameters.AddWithValue("@codPro", codPro)
                command.Parameters.AddWithValue("@cantidad", (cant + cantidad))

                command.ExecuteNonQuery()
            Catch ex As Exception

            End Try

        Else
            Try

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaPedido_Producto_C"
                command.Parameters.AddWithValue("@codP", codP)
                command.Parameters.AddWithValue("@codPto", codPro)
                command.Parameters.AddWithValue("@cant", cantidad)
                command.Parameters.AddWithValue("@cos", 0)
                command.Parameters.AddWithValue("@Status", "S")
                command.Parameters.AddWithValue("@FechaSta", Today)
                command.Parameters.AddWithValue("@BO", 0)
                command.ExecuteNonQuery()

            Catch ex As Exception



            End Try
        End If



    End Sub
    Public Shared Sub insertar_producto_fabrica(ByVal codP As Integer, ByVal codPro As String, ByVal codF As String, ByVal cantidad As Integer, ByVal tipo As Boolean, ByVal codProveedor As Integer, ByVal nuevo As Boolean)

        If nuevo = True Then

            Try

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_insertaProductoCodigoFabrica"
                    command.Parameters.AddWithValue("@codP", codProveedor)
                    command.Parameters.AddWithValue("@codPto", codPro)
                    command.Parameters.AddWithValue("@codF", codF)

                    command.ExecuteNonQuery()

                Else

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_eliminaProducto_Fabrica_BRWME_C"
                    command.Parameters.AddWithValue("CodI", codPro)
                    command.Parameters.AddWithValue("CodF", codProveedor)
                    command.ExecuteNonQuery()

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_eliminaProducto_Fabrica_BRWME_D"
                    command.Parameters.AddWithValue("CodI", codPro)
                    command.Parameters.AddWithValue("CodF", codProveedor)
                    command.ExecuteNonQuery()

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_eliminaProducto_Fabrica_CONAVE"
                    command.Parameters.AddWithValue("CodI", codPro)
                    command.Parameters.AddWithValue("CodF", codProveedor)
                    command.ExecuteNonQuery()

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_insertaProductoCodigoFabrica_BRWME_C"
                    command.Parameters.AddWithValue("@codP", codProveedor)
                    command.Parameters.AddWithValue("@codPto", codPro)
                    command.Parameters.AddWithValue("@codF", codF)
                    command.ExecuteNonQuery()

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_insertaProductoCodigoFabrica_BRWME_D"
                    command.Parameters.AddWithValue("@codP", codProveedor)
                    command.Parameters.AddWithValue("@codPto", codPro)
                    command.Parameters.AddWithValue("@codF", codF)
                    command.ExecuteNonQuery()

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_insertaProductoCodigoFabrica_CONAVE"
                    command.Parameters.AddWithValue("@codP", codProveedor)
                    command.Parameters.AddWithValue("@codPto", codPro)
                    command.Parameters.AddWithValue("@codF", codF)
                    command.ExecuteNonQuery()

                End If

            Catch ex As Exception



            End Try
        End If

        If tipo = False Then

            Try

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaPedidoCompra"

                command.Parameters.AddWithValue("@codP", codProveedor)
                command.Parameters.AddWithValue("@fle", 0)
                command.Parameters.AddWithValue("@seg", 0)
                command.Parameters.AddWithValue("@aran", 0)
                command.Parameters.AddWithValue("@otroG", 0)
                command.Parameters.AddWithValue("@fec", Today)
                command.Parameters.AddWithValue("@mon", "$")
                command.Parameters.AddWithValue("@tipoC", "")
                command.Parameters.AddWithValue("@codFPF", "")
                command.Parameters.AddWithValue("@fecFPF", Today)
                command.Parameters.AddWithValue("Obs", "")
                command.ExecuteNonQuery()

            Catch ex As Exception



            End Try


            Try


                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaPedido_Productos_Compra"
                command.Parameters.AddWithValue("@codPto", codPro)
                command.Parameters.AddWithValue("@cant", cantidad)
                command.Parameters.AddWithValue("@cos", 0)
                command.Parameters.AddWithValue("@Status", "S")
                command.Parameters.AddWithValue("@FechaSta", Today)
                command.ExecuteNonQuery()

            Catch ex As Exception



            End Try
        Else
            Try


                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaPedido_Producto_C"
                command.Parameters.AddWithValue("@codP", codP)
                command.Parameters.AddWithValue("@codPto", codPro)
                command.Parameters.AddWithValue("@cant", cantidad)
                command.Parameters.AddWithValue("@cos", 0)
                command.Parameters.AddWithValue("@Status", "S")
                command.Parameters.AddWithValue("@FechaSta", Today)
                command.Parameters.AddWithValue("@BO", 0)
                command.ExecuteNonQuery()

            Catch ex As Exception



            End Try
        End If

    End Sub

    Public Shared Sub InsertaProductoFabrica(ByVal codProveedor As Integer, ByVal codPro As String, ByVal codF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaProductoCodigoFabrica"
            command.Parameters.AddWithValue("@codP", codProveedor)
            command.Parameters.AddWithValue("@codPto", codPro)
            command.Parameters.AddWithValue("@codF", codF)

            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    Public Shared Sub cantidadProducto(ByRef catn As Label, ByVal cod As Integer, ByVal codPro As String)

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_cantidadProductoPedido"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@codPro", codPro)
            dr = command.ExecuteReader()
            While dr.Read
                catn.Text = dr("Cantidad").ToString
            End While
            dr.Close()



        Catch ex As Exception



        End Try

        dr.Close()

    End Sub

    Public Shared Sub consulta_moneda(ByRef moneda As Label, ByVal codPro As String)

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_moneda"
            command.Parameters.AddWithValue("@cod", codPro)
            dr = command.ExecuteReader()
            While dr.Read
                moneda.Text = dr("Moneda").ToString
            End While
            dr.Close()



        Catch ex As Exception
            dr.Close()


        End Try

    End Sub

    Public Shared Function existe_producto(ByRef cod As String) As Boolean

        Dim existe As Boolean = False

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            While dr.Read()
                existe = True
            End While

        Catch ex As Exception
            MsgBox("Error consultando existencia del producto en Comercializadora", MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
        End Try

        Return existe

    End Function

End Class
