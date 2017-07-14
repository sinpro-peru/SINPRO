Imports System.Data.SqlClient

Public Class DatosBanco
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub consulta_bancos(ByRef cb As MTGCComboBox)

        Try
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaBancos"
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigo"))))
            End While
        Catch ex As Exception
            MsgBox("Error cargando zonas", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_bancosCuentas(ByRef cb As MTGCComboBox)

        Try
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaBancosCuentas"
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoBanco"))))
            End While
        Catch ex As Exception
            MsgBox("Error cargando bancos a depositar", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()
        End Try

    End Sub

    Public Shared Sub ver_Bancos(ByVal Dgv As DataGridView)

        Dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaBancos"
        dr = command.ExecuteReader()
        While dr.Read
            Dgv.Rows.Add(dr("Codigo"), dr("Nombre"))
        End While
        dr.Close()
        Dgv.ClearSelection()

    End Sub

    Public Shared Sub ver_Un_Banco(ByVal codBan As String, ByRef cod As String, ByRef nom As String)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaBanco"
        command.Parameters.AddWithValue("@cod", codBan)
        dr = command.ExecuteReader()

        While dr.Read
            cod = dr("Codigo")
            nom = dr("Nombre")
        End While
        dr.Close()

    End Sub

    Public Shared Sub Insertar_Banco(ByVal nom As String)

        command.Parameters.Clear()
        command.CommandText = "sp_insertarBanco"
        command.Parameters.AddWithValue("@nom", nom)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub Eliminar_Banco(ByVal cod As String)

        command.Parameters.Clear()
        command.CommandText = "sp_eliminarBanco"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
        MsgBox("Banco eliminado satisfactoriamente", MsgBoxStyle.Information)

    End Sub

    Public Shared Sub Modificar_Banco(ByVal cod As Integer, ByVal nom As String)

        command.Parameters.Clear()
        command.CommandText = "sp_modificarBanco"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@nom", nom)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub identidad_Banco(ByRef tb As TextBox)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadBanco"
            dr = command.ExecuteReader()
            dr.Read()
            tb.Text = dr("Expr1") + 1
            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message.ToString())
        End Try


    End Sub

End Class
