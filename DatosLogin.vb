Imports System.Data.SqlClient
Public Class DatosLogin
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub verifica(ByVal l As String, ByVal p As String, ByRef sw As Boolean, ByRef tipo As Integer, ByRef eliminado As Boolean, ByRef user As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_verificaUsuario"
            command.Parameters.AddWithValue("@login", l)
            command.Parameters.AddWithValue("@password", p)
            dr = command.ExecuteReader()
            If dr.Read Then
                eliminado = dr("eliminado")
                If eliminado = True Then
                    sw = False
                ElseIf eliminado = False Then
                    sw = True
                End If
                tipo = dr("Tipo")
                user = dr("Nombre")

                My.Settings.UserName = dr("Nombre")
                My.Settings.UserLogin = l

            End If
            dr.Close()
        Catch ex As Exception

        Finally

        End Try

    End Sub
    Public Shared Sub RetornaDominio(ByRef Dom As String, ByVal con As Integer)


        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@tipo", con)
        command.CommandText = "sp_consulta_Dominio"
        dr = command.ExecuteReader
        dr.Read()

        Dom = dr("Dominio")

        dr.Close()

    End Sub


End Class
