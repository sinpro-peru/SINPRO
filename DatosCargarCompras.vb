Imports System.Data.SqlClient
Public Class DatosCargarCompras
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub consulta_productos(ByRef cb As ComboBox)

        Try
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAlmacenes"
            dr = command.ExecuteReader()
            Dim cont As Integer = 0

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))

            End While


        Catch ex As Exception

            MsgBox("Error cargando ubicaciones", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

        

    End Sub

    Public Shared Sub consulta_costo_promedio(ByVal codP As Integer, ByRef tabla As DataTable)
        Try
            tabla.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_costo_promedio"
            command.Parameters.AddWithValue("@Codp", codP)
            dr = command.ExecuteReader()
            Dim cont As Integer = 0

            While dr.Read

                tabla.Rows.Add(dr("CodigoProducto"), dr("Nombre"), dr("CantidadExistencia"), Format(dr("CostoPromedio"), "#,##0.00"), Format(dr("PrecioVenta"), "#,##0.00"), dr("Cantidad"), 0, Format(dr("PrecioVentaFinal"), "#,##0.00"), dr("Costo"))

            End While


        Catch ex As Exception
            MsgBox(ex)
        Finally
            dr.Close()
        End Try


    End Sub
    Public Shared Sub insertar_compra(ByVal codP As Integer, ByVal numFac As String, ByVal fecha As Date)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaCompra"
            command.Parameters.AddWithValue("@numFac", numFac)
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@fec", fecha)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando la compra", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub actualiza_producto_existencia(ByVal cod As String, ByVal cantidad As Integer, ByVal costP As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_actualizar_datos_productos"
            command.Parameters.AddWithValue("@cant", cantidad)
            command.Parameters.AddWithValue("@costoP", costP)
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error intentando actualizar los datos de la compra", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub
    Public Shared Sub actualiza_producto_precio(ByVal cod As String, ByVal precio As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_actualizar_precio_productos"
            command.Parameters.AddWithValue("@pre", precio)
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox("Error intentando actualizar el precio de la compra con item " & cod, MsgBoxStyle.Critical, "Error")


        End Try

    End Sub
    Public Shared Sub actualizar_cantidad_almacen(ByVal codP As String, ByVal codA As Integer, ByVal cant As Integer)

        Try
            Dim cantidad As Integer = 0
            Dim tramo As Integer = 0
            Dim esta As Boolean = False
            Dim cont As Integer = 0

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_producto_almacen"
            command.Parameters.AddWithValue("@Codp", codP)
            command.Parameters.AddWithValue("@CodA", codA)
            dr = command.ExecuteReader()


            While dr.Read
                If dr("Cantidad").GetType.ToString <> "System.DBNull" And cont = 0 Then
                    cantidad = dr("Cantidad")
                    tramo = dr("CodigoTramo")
                    esta = True
                    cont = cont + 1
                End If
            End While

            dr.Close()

            If esta = False Then
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_cantidad_tramo"
                command.Parameters.AddWithValue("@CodPro", codP)
                command.Parameters.AddWithValue("@CodA", codA)
                command.Parameters.AddWithValue("@CodT", tramo)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@Tipo", 1)
                command.ExecuteNonQuery()
            Else
                cant = cant + cantidad
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_cantidad_tramo"
                command.Parameters.AddWithValue("@CodPro", codP)
                command.Parameters.AddWithValue("@CodA", codA)
                command.Parameters.AddWithValue("@CodT", tramo)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@Tipo", 2)
                command.ExecuteNonQuery()
            End If

        Catch ex As Exception



        Finally

            If Not dr.IsClosed Then
                dr.Close()
            End If

        End Try


    End Sub

    Public Shared Sub consulta_calcula_costo_promedio(ByVal codPto As String, ByVal codPed As String, ByRef cp As Double)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_costo_promedio"
            command.Parameters.AddWithValue("@CodPto", codPto)
            command.Parameters.AddWithValue("@codPed", codPed)
            dr = command.ExecuteReader()

            While dr.Read
                If Not dr("CostoPromedio").GetType.ToString = "System.DBNull" Then
                    cp = CDbl(dr("CostoPromedio"))
                Else
                    cp = 0
                End If
            End While

        Catch ex As Exception
            MsgBox("Error cargando los nuevos costos promedios", MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
        End Try
    End Sub

End Class




