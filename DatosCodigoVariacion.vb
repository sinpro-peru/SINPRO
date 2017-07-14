Imports System.Data.SqlClient
Public Class DatosCodigoVariacion
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_codigosVariaciones(ByVal lv As ListView)
        Dim par As String
        par = "todos"
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCodigoVariacion"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        Dim fec As DateTime
        While dr.Read
            fec = dr("fecha")
            Dim c As Integer = 0
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("codigoInternoNuevo"))
            i.SubItems.Add(dr("codigoInternoViejo"))
            i.SubItems.Add(CStr(fec))
            lv.Items.Add(i)
        End While

        dr.Close()
    End Sub
    Public Shared Sub consulta_codigoVariacion(ByVal c As Integer, ByRef tbCN As String, ByRef tbCV As String, ByRef tbF As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCodigoVariacion"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        dr.Read()
        tbCN = dr("codigoInternoNuevo")
        tbCV = dr("codigoInternoViejo")
        tbF = CStr(dr("fecha"))
        dr.Close()
    End Sub
    Public Shared Sub inserta_codigoVariacion(ByVal codN As Integer, ByVal codV As Integer, ByVal fec As DateTime)
        command.Parameters.Clear()

        command.CommandText = "sp_insertaCodigoVariacion"
        command.Parameters.AddWithValue("@codIntN", codN)
        command.Parameters.AddWithValue("@codIntV", codV)
        command.Parameters.AddWithValue("@fec", fec)
        command.ExecuteNonQuery()
        MsgBox("La Variación del Código Ha Sido Registrada Exitosamente")
    End Sub
    Public Shared Sub modifica_codigoVariacion(ByVal fec As DateTime, ByVal codN As Integer, ByVal codV As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaCodigoVariacion"
        command.Parameters.AddWithValue("@fec", fec)
        command.Parameters.AddWithValue("@codIntN", codN)
        command.Parameters.AddWithValue("@COD", codV)
        command.ExecuteNonQuery()
        MsgBox("La Variación Ha Sido Modificada Exitosamente")
    End Sub
    Public Shared Sub elimina_codigoVariacion(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaCodigoVariacion"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub
End Class
