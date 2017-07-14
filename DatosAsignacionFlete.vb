Imports System.Data.SqlClient
Public Class DatosAsignacionFlete

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Dgv_Pesos(ByRef dgv As DataGridView, ByVal cod As Integer, ByVal Tipo As String)

        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CodP", cod)
        command.Parameters.AddWithValue("@Tipo", Tipo)
        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
        '    command.CommandText = "sp_consultaRenglonesCompra_Brwme"
        'Else
        command.CommandText = "sp_consultaRenglonesCompra"
        'End If

        dr = command.ExecuteReader()
        While dr.Read
            dgv.Rows.Add(dr("Nombre"), "")
        End While
        dr.Close()

    End Sub

End Class

