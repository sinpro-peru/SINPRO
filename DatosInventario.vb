Imports System.Data.SqlClient
Public Class DatosInventario

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub ProximoInventario(ByRef Cod As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadInvetario"
            command.Parameters.Clear()
            dr = command.ExecuteReader

            While dr.Read

                Cod = CInt(dr("Id")) + 1

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub insertar_producto_inventario(ByVal codI As Integer, ByVal codP As String, ByVal cantAnt As Integer, ByVal cantAct As Integer, ByVal obs As String, ByVal tramo As Integer, ByVal precio As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaInventario_Producto"
            command.Parameters.AddWithValue("@codI", codI)
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@cantAnt", cantAnt)
            command.Parameters.AddWithValue("@cantAct", cantAct)
            command.Parameters.AddWithValue("@obs", obs)

            If tramo = 0 Then
                command.Parameters.AddWithValue("@codT", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@codT", tramo)
            End If

            command.Parameters.AddWithValue("@precio", precio)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try



    End Sub

    Public Shared Sub elimina_producto_inventario(ByVal codI As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_elimina_Inventario_Producto"
            command.Parameters.AddWithValue("@codI", codI)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try



    End Sub

    Public Shared Sub consulta_inventario(ByRef dgv As DataGridView, ByVal val As String, ByVal tipo As Integer)

        Try

            dgv.Rows.Clear()

            command.Parameters.Clear()
            command.CommandText = "sp_consulta_Inventario"
            command.Parameters.AddWithValue("@val", val)
            command.Parameters.AddWithValue("@tipo", tipo)

            dr = command.ExecuteReader

            While dr.Read

                If tipo = 3 Then



                Else

                    dgv.Rows.Add(dr("CodigoInv"), dr("Fecha"), dr("Realizado"), dr("Ajustado"), dr("Observacion"))

                End If

            End While

            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Error consultando inventarios", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Inserta_Ajuste(ByVal fecha As Date, ByVal usuario As String, ByVal descripcion As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaAjuste"

            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Descripcion", descripcion)

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando el ajuste", MsgBoxStyle.Critical, "ERROR")

        End Try

    End Sub

    Public Shared Function Inserta_Inventario(ByVal fecha As Date, ByVal usuario As String, ByVal descripcion As String) As Boolean

        Dim success As Boolean = False

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaInventario"

            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Realizado", usuario)
            command.Parameters.AddWithValue("@Obs", descripcion)

            command.ExecuteNonQuery()

            success = True

        Catch ex As Exception

            MsgBox("Error insertando el conteo de inventario", MsgBoxStyle.Critical, "ERROR")

        End Try

        Return success

    End Function

    Public Shared Function Modifica_Inventario(ByVal fecha As Date, ByVal cod As String, ByVal descripcion As String) As Boolean

        Dim success As Boolean = False

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaInventario"

            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Obs", descripcion)
            command.Parameters.AddWithValue("@CodI", cod)

            command.ExecuteNonQuery()

            success = True

        Catch ex As Exception

            MsgBox("Error modificando el conteo de inventario", MsgBoxStyle.Critical, "ERROR")

        End Try

        Return success

    End Function

    Public Shared Sub Cerrar_Inventario(ByVal cod As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_cerrarInventario"
            command.Parameters.AddWithValue("@CodI", cod)

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error cerrando el conteo de inventario", MsgBoxStyle.Critical, "ERROR")

        End Try

    End Sub

    Public Shared Function ProximoAjuste() As Integer

        Dim id As Integer = 0

        Try

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ProximoAjuste"
            command.Parameters.Clear()
            dr = command.ExecuteReader

            While dr.Read

                id = dr("Prox")

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try

        Return id

    End Function


    Public Shared Sub Inserta_Ajuste_Producto(ByVal CodA As Integer, ByVal CodP As String, ByVal CantAct As Integer, ByVal obs As String, ByVal Tramo As Integer, ByVal dif As Integer)

        Try

            command.CommandText = "sp_insertaAjuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cantidad", dif)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Tramo", Tramo)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandText = "sp_consultaUbicacionPro"
            command.Parameters.AddWithValue("@cod", CodP)
            command.Parameters.AddWithValue("@tramo", Tramo)
            command.Parameters.AddWithValue("@tipo", 0)

            dr = command.ExecuteReader

            If dr.HasRows Then

                'Modificar existencia de los tramos

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_existencia_tramo2"
                command.Parameters.AddWithValue("@Tramo", Tramo)
                command.Parameters.AddWithValue("@CodP", CodP)
                command.Parameters.AddWithValue("@Cant", dif)
                command.ExecuteNonQuery()


            Else

                'Crear existencia de los tramos

                dr.Close()

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaUbicacionProducto"
                command.Parameters.AddWithValue("@CodigoTramo", Tramo)
                command.Parameters.AddWithValue("@CodigoProducto", CodP)
                command.Parameters.AddWithValue("@Cantidad", cantAct)
                command.ExecuteNonQuery()

            End If

            'Descontar Cantidad Existencia

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaExitencia2"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cant", dif)
            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("Error insertando productos en el ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

End Class
