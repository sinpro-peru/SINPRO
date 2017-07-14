Imports System.Data.SqlClient
Public Class DatosExportarAExcel

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Dgv_Exportar(ByRef dgv As DataGridView, ByVal cod As Integer, ByVal Tipo As String)

        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CodP", cod)
        command.Parameters.AddWithValue("@Tipo", Tipo)
        command.CommandText = "sp_consultaRenglonesCompra"
        dr = command.ExecuteReader()
        While dr.Read
            dgv.Rows.Add(False, dr("Nombre"))
        End While
        dr.Close()

    End Sub

End Class