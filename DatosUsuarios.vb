Imports System.Data.SqlClient
Public Class DatosUsuarios
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared dv As New DataView
    Public Shared dt As New DataTable
    Public Shared ds As New DataSet
    Public Shared da As New SqlClient.SqlDataAdapter
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
 

    Public Shared Sub consulta_usuarios(ByVal DGV As DataGridView)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaUsuarios"
        command.Parameters.AddWithValue("@Tipo", 0)
        command.Parameters.AddWithValue("@Nom", "")

        dr = command.ExecuteReader()

        While dr.Read
            DGV.Rows.Add(dr("Login"), dr("nombre"))
        End While

        dr.Close()
    End Sub
    Public Shared Sub consulta_usuario_eliminado(ByVal DGV As DataGridView)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaUsuariosEliminados"
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("Login"), dr("nombre"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_usuario_existe(ByVal l As String, ByRef esta As Boolean)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaUsuario"
        command.Parameters.AddWithValue("@l", l)
        dr = command.ExecuteReader()
        If dr.Read Then
            esta = True
        End If
        dr.Close()

    End Sub


    Public Shared Sub consulta_usuario(ByVal l As String, ByRef sw As Boolean)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaUsuario"
        command.Parameters.AddWithValue("@l", l)
        dr = command.ExecuteReader()
        If dr.Read Then
            sw = True
        End If
        dr.Close()
    End Sub

    Public Shared Sub consulta_usuario_Login(ByRef user As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaUsuario"
        command.Parameters.AddWithValue("@l", user)
        dr = command.ExecuteReader()
        If dr.Read Then
            user = dr("Nombre")
        End If
        dr.Close()
    End Sub

    Public Shared Sub inserta_usuario(ByVal l As String, ByVal p As String, ByVal ci As String, ByVal nom As String, ByVal tlf As String, ByVal email As String, ByVal codT As Integer)


        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaUsuario"
            command.Parameters.AddWithValue("@l", l)
            command.Parameters.AddWithValue("@p", p)
            command.Parameters.AddWithValue("@ci", ci)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@tlf", tlf)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@codT", codT)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Sub elimina_usuario(ByVal l As String)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaUsuario"
        command.Parameters.AddWithValue("@l", l)
        command.ExecuteNonQuery()
    End Sub

    'Public Shared Sub elimina_usuario2_dist(ByVal l As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaUsuario2_dist"
    '    command.Parameters.AddWithValue("@l", l)
    '    command.ExecuteNonQuery()
    'End Sub

    'Public Shared Sub elimina_usuario2_comer(ByVal l As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaUsuario2_comer"
    '    command.Parameters.AddWithValue("@l", l)
    '    command.ExecuteNonQuery()
    'End Sub

    'Public Shared Sub elimina_usuario2_CONAVE(ByVal l As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaUsuario2_CONAVE"
    '    command.Parameters.AddWithValue("@l", l)
    '    command.ExecuteNonQuery()
    'End Sub

    Public Shared Sub elimina_usuario2(ByVal l As String)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaUsuario2"
        command.Parameters.AddWithValue("@l", l)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub modifica_usuario(ByVal l As String, ByVal p As String, ByVal ci As String, ByVal nom As String, ByVal tlf As String, ByVal email As String, ByVal codT As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaUsuario"
        command.Parameters.AddWithValue("@l", l)
        command.Parameters.AddWithValue("@p", p)
        command.Parameters.AddWithValue("@ci", ci)
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@tlf", tlf)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@codT", codT)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub llenarTipos(ByRef cb As ComboBox, ByVal tipo As Boolean)

        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaTipoUsuario"
        command.Parameters.AddWithValue("@Tipo", tipo)
        dr = command.ExecuteReader()

        While dr.Read
            If dr("nombre").ToString.ToUpper <> "nada".ToUpper Then
                cb.Items.Add(New comboItem(CStr(dr("nombre")), CStr(dr("id"))))
            End If
        End While
        dr.Close()
        da.SelectCommand = command
        dt.Clear()
        da.Fill(dt)
    End Sub

    Public Shared Function consulta_TipoUsuario_Nombre(ByVal tipo As Integer) As Integer

        Dim Id As Integer = 0

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaTipoUsuario"
        command.Parameters.AddWithValue("@Tipo", tipo)
        dr = command.ExecuteReader()

        While dr.Read

            Id = dr("id")

        End While

        dr.Close()

        Return Id

    End Function

    'Public Shared Function consulta_TipoUsuario_Nombre_dist(ByVal tipo As Integer) As Integer

    '    Dim Id As Integer = 0

    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_consultaTipoUsuario_dist"
    '    command.Parameters.AddWithValue("@Tipo", tipo)
    '    dr = command.ExecuteReader()

    '    While dr.Read

    '        Id = dr("id")

    '    End While

    '    dr.Close()

    '    Return Id

    'End Function

    'Public Shared Function consulta_TipoUsuario_Nombre_comer(ByVal tipo As Integer) As Integer

    '    Dim Id As Integer = 0

    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_consultaTipoUsuario_comer"
    '    command.Parameters.AddWithValue("@Tipo", tipo)
    '    dr = command.ExecuteReader()

    '    While dr.Read

    '        Id = dr("id")

    '    End While

    '    dr.Close()

    '    Return Id

    'End Function

    'Public Shared Function consulta_TipoUsuario_Nombre_CONAVE(ByVal tipo As Integer) As Integer

    '    Dim Id As Integer = 0

    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_consultaTipoUsuario_CONAVE"
    '    command.Parameters.AddWithValue("@Tipo", tipo)
    '    dr = command.ExecuteReader()

    '    While dr.Read

    '        Id = dr("id")

    '    End While

    '    dr.Close()

    '    Return Id

    'End Function

    Public Shared Sub consulta_datos_usuario(ByVal l As String, ByVal p As TextBox, ByVal ci As TextBox, ByVal nom As TextBox, ByVal tlf As TextBox, ByVal email As TextBox, ByVal cbCod As ComboBox)
        Dim entro As Boolean = False
        Dim cont As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaDatosUsuario"
        command.Parameters.AddWithValue("@l", l)
        dr = command.ExecuteReader()
        While dr.Read
            p.Text = dr("Password").ToString
            ci.Text = dr("Ci").ToString
            nom.Text = dr("Nombre").ToString
            tlf.Text = dr("Telefono").ToString
            email.Text = dr("email").ToString

            For cont = 0 To cbCod.Items.Count - 1
                If cbCod.Items.Item(cont).code.ToString = dr("Tipo").ToString Then

                    cbCod.Text = cbCod.Items.Item(cont).Name.ToString
                    entro = True

                End If

            Next


        End While
        dr.Close()
        If entro = False Then
            cbCod.Text = ""
        End If

        entro = False
    End Sub


    Public Shared Sub consulta_datos_usuario2(ByVal l As String, ByRef nom As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDatosUsuario"
            command.Parameters.AddWithValue("@l", l)
            dr = command.ExecuteReader()
            While dr.Read
                nom = dr("Nombre").ToString
            End While

        Catch ex As Exception

            MsgBox("Error consultando usuario", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub restaura_usuario(ByVal cod As String)
        command.Parameters.Clear()
        command.CommandText = "sp_restauraUsuario"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub modifica_password(ByVal User As String, ByVal Password As String, ByVal tipo As Integer, ByVal ant As String, ByRef detener As Boolean, ByVal nombre As String)

        command.Parameters.Clear()
        command.CommandText = "sp_consultaUsuario2"
        command.Parameters.AddWithValue("@l", User)
        command.Parameters.AddWithValue("@ant", ant)
        dr = command.ExecuteReader

        If Not dr.HasRows Then

            dr.Close()

            elimina_usuario2(ant)

            Dim tipo1 As Integer = consulta_TipoUsuario_Nombre(tipo)

            command.Parameters.Clear()
            command.CommandText = "sp_InsertaUsuario"
            command.Parameters.AddWithValue("@l", User)
            command.Parameters.AddWithValue("@p", Password)
            command.Parameters.AddWithValue("@codT", tipo1)
            command.Parameters.AddWithValue("@ci", "")
            command.Parameters.AddWithValue("@nom", nombre)
            command.Parameters.AddWithValue("@tlf", "")
            command.Parameters.AddWithValue("@email", "")
            command.ExecuteNonQuery()

        Else

            detener = True
            dr.Close()

        End If

    End Sub

    'Public Shared Sub modifica_password_Dist(ByVal User As String, ByVal Password As String, ByVal tipo As Integer, ByVal ant As String, ByRef detener As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_consultaUsuario2_dist"
    '    command.Parameters.AddWithValue("@l", User)
    '    command.Parameters.AddWithValue("@ant", ant)
    '    dr = command.ExecuteReader

    '    If Not dr.HasRows Then

    '        dr.Close()

    '        elimina_usuario2_dist(ant)

    '        Dim tipo1 As Integer = consulta_TipoUsuario_Nombre_dist(tipo)

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_InsertaUsuario_dist"
    '        command.Parameters.AddWithValue("@l", User)
    '        command.Parameters.AddWithValue("@p", Password)
    '        command.Parameters.AddWithValue("@codT", tipo1)
    '        command.Parameters.AddWithValue("@ci", "")
    '        command.Parameters.AddWithValue("@nom", "")
    '        command.Parameters.AddWithValue("@tlf", "")
    '        command.Parameters.AddWithValue("@email", "")
    '        command.ExecuteNonQuery()

    '    Else

    '        detener = True
    '        dr.Close()

    '    End If

    'End Sub

    'Public Shared Sub modifica_password_comer(ByVal User As String, ByVal Password As String, ByVal tipo As Integer, ByVal ant As String, ByRef detener As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_consultaUsuario2_comer"
    '    command.Parameters.AddWithValue("@l", User)
    '    command.Parameters.AddWithValue("@ant", ant)
    '    dr = command.ExecuteReader

    '    If Not dr.HasRows Then

    '        dr.Close()

    '        elimina_usuario2_comer(ant)

    '        Dim tipo1 As Integer = consulta_TipoUsuario_Nombre_comer(tipo)

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_InsertaUsuario_comer"
    '        command.Parameters.AddWithValue("@l", User)
    '        command.Parameters.AddWithValue("@p", Password)
    '        command.Parameters.AddWithValue("@codT", tipo1)
    '        command.Parameters.AddWithValue("@ci", "")
    '        command.Parameters.AddWithValue("@nom", "")
    '        command.Parameters.AddWithValue("@tlf", "")
    '        command.Parameters.AddWithValue("@email", "")
    '        command.ExecuteNonQuery()

    '    Else

    '        detener = True
    '        dr.Close()

    '    End If

    'End Sub

    'Public Shared Sub modifica_password_CONAVE(ByVal User As String, ByVal Password As String, ByVal tipo As Integer, ByVal ant As String, ByRef detener As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_consultaUsuario2_CONAVE"
    '    command.Parameters.AddWithValue("@l", User)
    '    command.Parameters.AddWithValue("@ant", ant)
    '    dr = command.ExecuteReader

    '    If Not dr.HasRows Then

    '        dr.Close()

    '        elimina_usuario2_CONAVE(ant)

    '        Dim tipo1 As Integer = consulta_TipoUsuario_Nombre_CONAVE(tipo)

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_InsertaUsuario_CONAVE"
    '        command.Parameters.AddWithValue("@l", User)
    '        command.Parameters.AddWithValue("@p", Password)
    '        command.Parameters.AddWithValue("@codT", tipo1)
    '        command.Parameters.AddWithValue("@ci", "")
    '        command.Parameters.AddWithValue("@nom", "")
    '        command.Parameters.AddWithValue("@tlf", "")
    '        command.Parameters.AddWithValue("@email", "")
    '        command.ExecuteNonQuery()

    '    Else

    '        detener = True
    '        dr.Close()

    '    End If

    'End Sub

End Class
