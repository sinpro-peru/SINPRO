Imports System.Data.SqlClient
Public Class DatosTransporte
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_transportes(ByVal Dgv As DataGridView)

        Dim par As Integer
        par = 0
        Dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaTransporte"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            Dgv.Rows.Add(dr("codigoTransporte"), dr("nombre"))
        End While
        Dgv.Sort(Dgv.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        dr.Close()

    End Sub

    Public Shared Sub consulta_camion(ByVal Dgv As DataGridView, ByVal CodTrans As Integer)

        Dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCamion"
        command.Parameters.AddWithValue("@CodTrans", CodTrans)
        dr = command.ExecuteReader()

        While dr.Read
            Dgv.Rows.Add(dr("Placa"), dr("Modelo"))
        End While

        dr.Close()

    End Sub

    Public Shared Sub consulta_chofer(ByVal Dgv As DataGridView, ByVal CodTrans As Integer)
        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaChofer"
            command.Parameters.AddWithValue("@CodTrans", CodTrans)
            dr = command.ExecuteReader()

            While dr.Read
                Dgv.Rows.Add(dr("Nombre"), dr("Apellido"), dr("Cedula"))
            End While

            dr.Close()
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Sub consulta_transporte(ByRef tbR As String, ByVal tbC As String, ByRef tbN As String, ByRef tbT As String, ByRef tbD As String, ByRef tbCto As String, ByVal COD As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTransporte"
            command.Parameters.AddWithValue("@cod", COD)
            dr = command.ExecuteReader()
            dr.Read()
            tbC = dr("codigoTransporte")
            tbR = dr("RIF")
            tbN = dr("nombre")
            tbT = CStr(dr("telefono"))
            tbD = CStr(dr("direccion"))
            tbCto = CStr(dr("contacto"))
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub inserta_transporte(ByVal nom As String, ByVal tel As String, ByVal dir As String, ByVal con As String, ByVal rif As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaTransporte"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@telf", tel)
            command.Parameters.AddWithValue("@dir", dir)
            command.Parameters.AddWithValue("@con", con)
            command.Parameters.AddWithValue("@RIF", rif)
            command.ExecuteNonQuery()
            MsgBox("El Transporte Ha Sido Registrado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub inserta_Camion(ByVal Placa As String, ByVal Modelo As String, ByVal codTrans As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaCamion"
            command.Parameters.AddWithValue("@Placa", Placa)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@codTrans", codTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub
    Public Shared Sub inserta_Chofer(ByVal Cedula As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal codTrans As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaChofer"
            command.Parameters.AddWithValue("@Cedula", Cedula)
            command.Parameters.AddWithValue("@Nombre", Nombre)
            command.Parameters.AddWithValue("@Apellido", Apellido)
            command.Parameters.AddWithValue("@codTrans", codTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub
    Public Shared Sub identidad_Transporte(ByRef tb As TextBox)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadTransporte"
            dr = command.ExecuteReader
            dr.Read()
            tb.Text = dr("Expr1") + 1
            dr.Close()
        Catch ex As Exception
        End Try

    End Sub
    Public Shared Sub modifica_transporte(ByVal nom As String, ByVal tel As String, ByVal dir As String, ByVal con As String, ByVal cod As Integer, ByVal rif As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaTransporte"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@telf", tel)
            command.Parameters.AddWithValue("@dir", dir)
            command.Parameters.AddWithValue("@con", con)
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@RIF", rif)
            command.ExecuteNonQuery()
            MsgBox("El Transporte Ha Sido Modificado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub modifica_Camion(ByVal Placa As String, ByVal Modelo As String, ByVal CodTrans As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaCamion"
            command.Parameters.AddWithValue("@Placa", Placa)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@CodTrans", CodTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub modifica_Chofer(ByVal Cedula As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal CodTrans As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaChofer"
            command.Parameters.AddWithValue("@Cedula", Cedula)
            command.Parameters.AddWithValue("@Nombre", Nombre)
            command.Parameters.AddWithValue("@Apellido", Apellido)
            command.Parameters.AddWithValue("@CodTrans", CodTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub elimina_transporte(ByVal cod As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaTransporte"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub elimina_Camion(ByVal Placa As String, ByVal CodTrans As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaCamion"
            command.Parameters.AddWithValue("@Placa", Placa)
            command.Parameters.AddWithValue("@CodTrans", CodTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub elimina_Chofer(ByVal Cedula As Integer, ByVal CodTrans As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaChofer"
            command.Parameters.AddWithValue("@Cedula", Cedula)
            command.Parameters.AddWithValue("@CodTrans", CodTrans)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Sub Dgv_Transporte(ByVal Dgv As DataGridView, ByVal s As String, ByVal Tipo As Integer)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_dgvTransporte"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", Tipo)
            dr = command.ExecuteReader()
            While dr.Read()
                Dgv.Rows.Add(dr("CodigoTransporte"), dr("Nombre"))
            End While
            dr.Close()
            Dgv.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message().ToString())
        End Try

    End Sub

End Class
