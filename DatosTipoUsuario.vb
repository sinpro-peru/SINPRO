Imports System.Data.SqlClient
Public Class DatosTipoUsurio
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Private Shared dr2 As SqlDataReader
    Public Shared dv As New DataView
    Public Shared dt As New DataTable
    Public Shared ds As New DataSet
    Public Shared da As New SqlClient.SqlDataAdapter

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub llenarModulos(ByVal cod As Integer, ByVal DGV As DataGridView)
        Dim cont As Integer = 0

        If cod = 0 Then
            DGV.Rows.Clear()
        End If
        For contador As Integer = 0 To DGV.RowCount - 1
            If DGV.Rows(contador).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                DGV.Rows(contador).Cells(5).Value = False
            End If
        Next
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaModulos"
            command.Parameters.AddWithValue("@cod", cod)

            dr = command.ExecuteReader()
            While dr.Read
          
                If cod = 0 Then

                    If dr("Especial") = True Then
                        Dim fila As New DataGridViewRow
                        Dim Nombre As New DataGridViewTextBoxCell
                        Dim Descripcion As New DataGridViewTextBoxCell
                        Dim id As New DataGridViewTextBoxCell
                        Dim idAnterior As New DataGridViewTextBoxCell
                        Dim check As New DataGridViewCheckBoxCell
                        Dim checkE As New DataGridViewCheckBoxCell
                        Dim checkW As New DataGridViewCheckBoxCell
                        check.Value = True
                        Nombre.Value = dr("nombreModulo")
                        Descripcion.Value = dr("Descripcion")
                        id.Value = dr("id")
                        idAnterior.Value = dr("idAnterior")
                        checkE.Value = dr("Especial")
                        checkW.Value = dr("Escribir")
                        fila.Cells.Add(check)
                        fila.Cells.Add(Nombre)
                        fila.Cells.Add(id)
                        fila.Cells.Add(idAnterior)
                        fila.Cells.Add(checkW)
                        fila.Cells.Add(checkE)
                        fila.Cells.Add(Descripcion)
                        DGV.Rows.Add(fila)
                    Else

                        DGV.Rows.Add(False, dr("nombreModulo"), dr("id"), dr("idAnterior"), False, "", dr("Descripcion"))


                    End If
                Else


                
                    If DGV.Rows.Count <> 0 Then
                        For cont = 0 To DGV.Rows.Count - 1

                            If DGV.Rows(cont).Cells(2).Value = CInt(dr("idFrm").ToString) Then
                                DGV.Rows(cont).Cells(0).Value = True
                                DGV.Rows(cont).Cells(4).Value = dr("Escribir")
                                If DGV.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                                    DGV.Rows(cont).Cells(5).Value = dr("Especial")
                                End If

                            End If
                        Next

                    End If
                End If

            End While

        Catch ex As Exception

        End Try

        dr.Close()
    End Sub
    Public Shared Sub modificarTipoUsuario(ByVal cod As Integer, ByVal idF As Integer, ByVal esta As Boolean, ByVal escribir As Boolean, ByVal especial As Boolean, ByVal cont As Integer)
        Dim existe As Boolean = False
        Try

            If esta = True Then
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificarModulos"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@cod", cod)
                command.Parameters.AddWithValue("@id", idF)
                command.Parameters.AddWithValue("@cont", cont)
                command.Parameters.AddWithValue("@escribir", escribir)
                command.Parameters.AddWithValue("@especial", especial)
                command.ExecuteNonQuery()
            End If



        Catch ex As Exception
           
        End Try

        dr.Close()
    End Sub

    Public Shared Sub insertarTipoUsuario(ByVal cod As Integer, ByVal id As Integer, ByVal nom As String, ByVal cont As Integer, ByVal escribir As Boolean, ByVal especial As Boolean)
        Dim existe As Boolean = False

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaTipoUsuario"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@escribir", escribir)
            command.Parameters.AddWithValue("@especial", especial)
            command.Parameters.AddWithValue("@cont", cont)
            dr = command.ExecuteReader()


        Catch ex As Exception


        End Try

        dr.Close()
    End Sub
    Public Shared Sub llenarid(ByVal id As Label)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_llenarIdTipoUsuario"
            dr = command.ExecuteReader()
            While dr.Read
                id.Text = dr("id")
            End While
        Catch ex As Exception

        End Try

        dr.Close()
    End Sub
    Public Shared Sub eliminarTipoUsuario(ByVal cod As Integer, ByVal usuario As Boolean)

        usuario = llenarTipo(cod)

        Try
            If usuario = False Then
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_eliminarTipoUsuario"
                command.Parameters.AddWithValue("@cod", cod)
                dr = command.ExecuteReader()

            End If

        Catch ex As Exception


        End Try

        dr.Close()


        If usuario = False Then
         
            MsgBox("El Tipo de Usuario ha sido eliminado de forma exitosa", MsgBoxStyle.OkOnly)
        Else
            MsgBox("El Tipo de Usuario no puede ser eliminado porque tiene Usuarios asociados", MsgBoxStyle.OkOnly)
        End If








    End Sub

    Public Shared Sub RestaurarTipo(ByVal cod As Integer)
        Dim existe As Boolean = False

        Try


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_RestaurarTipoUsuario"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()


        Catch ex As Exception


        End Try

        dr.Close()
    End Sub
    Public Shared Function llenarTipo(ByVal id As Integer) As Boolean

        Dim esta As Boolean = False


        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTipo"
            command.Parameters.AddWithValue("@id", id)

            dr = command.ExecuteReader()

            While dr.Read

                esta = True

            End While
        Catch

        End Try
        dr.Close()



        Return esta

    End Function


    Public Shared Sub llenarTipoNombre(ByVal id As Integer, ByVal f As DataTable, ByVal tipo As Boolean)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFrm"
            command.Parameters.AddWithValue("@id", id)

            dr = command.ExecuteReader()
            While dr.Read

                f.Rows.Add(dr("nombreModulo"), dr("Escribir"), dr("Especial"))


            End While
        Catch

        End Try
        dr.Close()


    End Sub




End Class
