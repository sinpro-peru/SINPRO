Imports System.Data.SqlClient

Public Class DatosGastos

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Consulta_Relaciones(ByRef DGV As DataGridView, ByVal nom As String, ByVal Tipo As Integer, ByVal id As Integer, ByVal mes As Integer, ByVal ano As Integer)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaGastos"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@mes", mes)
            command.Parameters.AddWithValue("@ano", ano)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Id"), dr("Fecha"), dr("RealizadoPor"), dr("AprobadoPor"), dr("Observacion"), dr("Cerrado"), dr("Limite"))

            End While

            DGV.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de relaciones", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Consulta_Movimientos_Relaciones(ByRef DGV As DataGridView, ByVal id As Integer)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaGastosMovimientos"
            command.Parameters.AddWithValue("@id", id)

            dr = command.ExecuteReader

            While dr.Read

                If dr("Ingreso").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add(dr("Documento"), dr("Num"), dr("Descripcion"), dr("Fecha"), Format(dr("Egreso"), "#,##0.00"), "", dr("NroMovimiento"))

                ElseIf dr("Egreso").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add(dr("Documento"), dr("Num"), dr("Descripcion"), dr("Fecha"), "", Format(dr("Ingreso"), "#,##0.00"), dr("NroMovimiento"))

                End If

            End While

            DGV.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando los movimientos de la relación", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Function Consulta_Ultima_Relacion() As Integer

        Dim Id As Integer = 0

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaUltimaRelacion"

            dr = command.ExecuteReader

            While dr.Read

                Id = dr("UltimaRelacion")

            End While


        Catch ex As Exception

            MsgBox("Problema consultando Id de la última relación", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

        Return Id

    End Function

    Public Shared Sub Insertar_Relacion(ByVal Id_Tipo As Integer, ByVal Realizado As String, ByVal Aprobado As String, ByVal Fecha As Date, ByVal Obs As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaGasto"
            command.Parameters.AddWithValue("@Id_Tipo", Id_Tipo)
            command.Parameters.AddWithValue("@Realizado", Realizado)
            command.Parameters.AddWithValue("@Aprobado", Aprobado)
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error creando nueva relación", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Eliminar_Movimientos_Relacion(ByVal Id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaMovimientosGasto"
            command.Parameters.AddWithValue("@Id", Id)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando movimientos de la relación", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Insertar_Movimiento_Gasto(ByVal Doc As String, ByVal Num As String, ByVal Desc As String, ByVal Egreso As Double, ByVal Ingreso As Double, ByVal NroMov As String, ByVal Fecha As Date, ByVal Id_Gasto As Integer, ByVal cont As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_InsertaGastoMovimiento"
            command.Parameters.AddWithValue("@Doc", Doc)
            command.Parameters.AddWithValue("@Num", Num)
            command.Parameters.AddWithValue("@Desc", Desc)
            command.Parameters.AddWithValue("@Fecha", Fecha)

            If cont <> 0 Then

                If Egreso = 0 Then
                    command.Parameters.AddWithValue("@Egreso", System.DBNull.Value)
                Else
                    command.Parameters.AddWithValue("@Egreso", Egreso)
                End If

                If Ingreso = 0 Then
                    command.Parameters.AddWithValue("@Ingreso", System.DBNull.Value)
                Else
                    command.Parameters.AddWithValue("@Ingreso", Ingreso)
                End If

            Else

                If Egreso = 0 Then
                    command.Parameters.AddWithValue("@Egreso", System.DBNull.Value)
                Else
                    command.Parameters.AddWithValue("@Egreso", Egreso)
                End If

                command.Parameters.AddWithValue("@Ingreso", Ingreso)

            End If

            command.Parameters.AddWithValue("@NroMov", NroMov)
            command.Parameters.AddWithValue("@Id_Gasto", Id_Gasto)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando los movimientos de la relación", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Cerrar_Relacion(ByVal Id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaGasto"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@Tipo", 1)
            command.Parameters.AddWithValue("@Aprobado", "")
            command.Parameters.AddWithValue("@Obs", "")
            command.Parameters.AddWithValue("@Cerrado", True)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error cerrando relación", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Modificar_Relacion(ByVal Id As Integer, ByVal Aprobado As String, ByVal Obs As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaGasto"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@Aprobado", Aprobado)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.Parameters.AddWithValue("@Cerrado", False)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando relación", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

End Class
