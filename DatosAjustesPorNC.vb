Imports System.Data.SqlClient

Public Class DatosAjustesPorNC

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Dgv_Ajustes(ByRef DGV As DataGridView, ByVal Tipo As Integer, ByVal Codigo As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvAjustesPorNc"
            command.Parameters.AddWithValue("@Cod", Codigo)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoAjuste"), dr("Usuario"), dr("Fecha"), dr("Observacion"), dr("CodigoCliente"), dr("RazonSocial"), dr("CodigoNota"), dr("ControlInicio"), dr("ControlNota"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try


    End Sub

    Public Shared Sub EliminaAjustePorNC(ByVal codigo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_EliminaAjustePorNC"
            command.Parameters.AddWithValue("@Cod", codigo)
            command.ExecuteNonQuery()
            MsgBox("Ajuste eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")

        Catch ex As Exception

            MsgBox("Error eliminando el ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub


    Public Shared Sub InsertaAjustePorNC(ByVal codigo As Integer, ByVal obs As String, ByVal user As String, ByVal fecha As Date)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_InsertaAjustePorNC"
            command.Parameters.AddWithValue("@CodN", codigo)
            command.Parameters.AddWithValue("@User", user)
            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Obs", obs)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando el ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub

    Public Shared Sub ModificaAjustePorNC(ByVal obs As String, ByVal user As String, ByVal fecha As Date, ByVal CodAjuste As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaAjustePorNC"
            command.Parameters.AddWithValue("@CodA", CodAjuste)
            command.Parameters.AddWithValue("@User", user)
            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Obs", obs)
            command.ExecuteNonQuery()

            MsgBox("Ajuste modificado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")

        Catch ex As Exception

            MsgBox("Error modificando el ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub

    Public Shared Sub InsertaProductoAjustePorNC(ByVal codigoA As Integer, ByVal codigoP As String, ByVal obs As String, ByVal Tipo As Boolean, ByVal cantidad As Integer, ByVal Tramo As Integer)

        Try

            If obs Is System.DBNull.Value Then
                obs = ""
            End If

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaAjustePorNC_Producto"
            command.Parameters.AddWithValue("@CodA", codigoA)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodP", codigoP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.ExecuteNonQuery()


            If Tipo = True Then

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaTramoProducto"
                command.Parameters.AddWithValue("@Cod", codigoP)
                command.Parameters.AddWithValue("@tramo", Tramo)
                dr = command.ExecuteReader

                dr.Read()

                If dr.HasRows Then

                    dr.Close()
                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_modifica_existencia_AjusteNC"
                    command.Parameters.AddWithValue("@CodP", codigoP)
                    command.Parameters.AddWithValue("@Tramo", Tramo)
                    command.Parameters.AddWithValue("@Cant", cantidad)
                    command.Parameters.AddWithValue("@Tipo", 0)
                    command.ExecuteNonQuery()

                Else

                    dr.Close()
                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_modifica_existencia_AjusteNC"
                    command.Parameters.AddWithValue("@CodP", codigoP)
                    command.Parameters.AddWithValue("@Tramo", Tramo)
                    command.Parameters.AddWithValue("@Cant", cantidad)
                    command.Parameters.AddWithValue("@Tipo", 1)
                    command.ExecuteNonQuery()

                End If

            End If



        Catch ex As Exception

            MsgBox("Error insertando los productos en el ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub

    Public Shared Sub EliminaProductosAjustePorNC(ByVal codigoA As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaAjustePorNC_Producto"
            command.Parameters.AddWithValue("@CodA", codigoA)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando los productos del ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub

    Public Shared Function identidad_ajuste() As Integer

        Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadAjustePorNC"
        dr = command.ExecuteReader
        dr.Read()
        id = dr("Expr1") + 1
        dr.Close()
        Return id

    End Function

    Public Shared Sub consulta_notaCredito(ByVal Dgv As DataGridView, ByVal Tipo As Integer, ByVal Cod As String)

        Try

            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNotaCreditoNoAjustada"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            dr = command.ExecuteReader

            While dr.Read

                Dgv.Rows.Add(dr("CodigoNotaCredito"), dr("NroControl"), dr("Fecha"), dr("Monto"), dr("RazonSocial"), dr("CodigoCliente"), dr("ControlInicio"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try

    End Sub


    Public Shared Sub consultaProductosnotaCredito(ByVal Dgv As DataGridView, ByVal Cod As String)

        Try

            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNotaCreditoNoAjustada"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader

            While dr.Read

                Dgv.Rows.Add(dr("CodigoNotaCredito"), dr("Fecha"), dr("Monto"), dr("Observacion"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try

    End Sub

    Public Shared Sub actualizaAjustadaNC(ByVal codigo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_actualizaAjustada_NC"
            command.Parameters.AddWithValue("@CodNC", codigo)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error actualizando nota de crédito", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub


    Public Shared Sub consultaAjuste(ByRef DGV As DataGridView, ByRef DGV2 As DataGridView, ByVal Codigo As Integer)

        Try

            DGV.Rows.Clear()
            DGV2.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAjustePorNC"
            command.Parameters.AddWithValue("@Cod", Codigo)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Tipo") Then

                    DGV.Rows.Add(dr("Cantidad"), dr("Codigo"), dr("Nombre"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("Observacion"), "", dr("Tipo"))

                Else

                    DGV2.Rows.Add(dr("Cantidad"), dr("Codigo"), dr("Nombre"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("CantidadExistencia"), dr("Observacion"), dr("Tipo"))

                End If

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de productos", MsgBoxStyle.Critical, "Mensaje de error")


        End Try


    End Sub

    Public Shared Function VerificaProductoEnAjuste(ByVal CodA As Integer, ByVal CodP As String) As Boolean

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUnProductoAjusteNC"
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            dr = command.ExecuteReader

            dr.Read()

            If dr.HasRows Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            MsgBox("Error verificando existencia. Descripcion del error: " & ex.ToString & vbCrLf, MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try





    End Function

    Public Shared Sub ModificaProductoAjustePorNC(ByVal codigoA As Integer, ByVal codigoP As String, ByVal obs As String, ByVal cantidad As Integer, ByVal Tramo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaAjustePorNC_Producto"
            command.Parameters.AddWithValue("@CodA", codigoA)
            command.Parameters.AddWithValue("@CodP", codigoP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@CodT", Tramo)
            command.ExecuteNonQuery()



        Catch ex As Exception

            MsgBox("Error modificando los productos en el ajuste", MsgBoxStyle.Critical, "Mensaje de error")


        End Try

    End Sub



    Public Shared Sub EliminarUbicacionesCero(ByVal cod As String, ByVal tramo As Integer)
        Dim cant As Integer = 0
        Dim num As Integer = 0

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTramoProducto2"
            command.Parameters.AddWithValue("@Cod", cod)
            command.Parameters.AddWithValue("@tramo", tramo)
            command.Parameters.AddWithValue("@Tipo", 1)
            dr = command.ExecuteReader
            If dr.Read() Then
                num = dr("numeroTramo")
            End If
            dr.Close()

            If num > 1 Then


                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaTramoProducto2"
                command.Parameters.AddWithValue("@Cod", cod)
                command.Parameters.AddWithValue("@tramo", tramo)
                command.Parameters.AddWithValue("@Tipo", 2)
                dr = command.ExecuteReader
                If dr.Read() Then
                    cant = dr("Cantidad")
                End If
                dr.Close()

                If cant = 0 Then

                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_eliminaProducto_Tramo"
                    command.Parameters.AddWithValue("@Cod", cod)
                    command.Parameters.AddWithValue("@tramo", tramo)
                    command.ExecuteNonQuery()

                End If

            End If

        Catch ex As Exception

        End Try


    End Sub

End Class