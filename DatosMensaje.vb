Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class DatosMensaje

    Private Shared User As String = ""
    Private Shared conex As SqlConnection
    Private Shared conex2 As New SqlConnection(My.Settings.MELPRUEBAConnectionString)
    Private Shared command As SqlCommand
    Private Shared command2 As New SqlCommand()
    Private Shared dr As SqlDataReader
    Private Shared dr2 As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand, ByVal User1 As String)
        conex = con
        command = com
        command.Connection = conex
        User = User1
        command2.Connection = conex2
        conex2.Open()
    End Sub

    Public Shared Sub consulta_Mensajes(ByRef dgv As DataGridView, ByVal id As Integer, ByVal Tipo As Integer, ByRef Nuevos As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date)

        Try

            Dim Unread As New Font(dgv.Font, FontStyle.Bold)
            Dim Finished As New Font(dgv.Font, FontStyle.Strikeout)
            Dim cont As Integer = 0

            If conex2.State = ConnectionState.Broken Or conex2.State = ConnectionState.Closed Then

                conex2.Open()

            End If

            dgv.Rows.Clear()
            command2.Parameters.Clear()
            command2.CommandType = CommandType.StoredProcedure
            command2.CommandText = "sp_consultaMensaje"
            command2.Parameters.AddWithValue("@id", id)
            command2.Parameters.AddWithValue("@tipo", Tipo)
            command2.Parameters.AddWithValue("@usr", User)
            command2.Parameters.AddWithValue("@fecha1", fecha1)
            command2.Parameters.AddWithValue("@fecha2", fecha2)
            dr2 = command2.ExecuteReader()
            While dr2.Read

                If Tipo <= 4 Then

                    dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Titulo"))

                    If dr2("Leido") = False Then

                        Nuevos = Nuevos + 1
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                    End If

                    If dr2("Finalizado") Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Finished

                    End If

                    If dr2("Importancia") = 2 Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red

                    End If


                ElseIf Tipo >= 5 And Tipo <= 11 Then

                    If CInt(dr2("Respuestas")) > 0 Then

                        If dr2("Leido") Then
                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Destino"), "(" & (CInt(dr2("Respuestas")) + 1).ToString & ") " & dr2("Titulo").ToString, "L", dr2("IdUser"))
                        Else
                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Destino"), "(" & (CInt(dr2("Respuestas")) + 1).ToString & ") " & dr2("Titulo").ToString, "E", dr2("IdUser"))
                        End If

                    Else

                        If dr2("Leido") Then
                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Destino"), dr2("Titulo").ToString, "L", dr2("IdUser"))
                        Else
                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Destino"), dr2("Titulo").ToString, "E", dr2("IdUser"))
                        End If

                    End If

                    If dr2("Importancia") = 2 Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red

                    End If

                    If dr2("Leido") = False And dr2("UltimoRemitente").ToString.ToUpper <> User.ToUpper Then

                        Nuevos = Nuevos + 1
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                    End If

                    If dr2("Finalizado") Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Finished

                    End If

                ElseIf Tipo >= 12 And Tipo <= 18 Then

                    If CInt(dr2("Respuestas")) > 0 Then

                        If dr2("Leido") Then

                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Remitente"), "(" & (CInt(dr2("Respuestas")) + 1).ToString & ") " & dr2("Titulo").ToString, "L", dr2("IdUser"))

                        Else

                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Remitente"), "(" & (CInt(dr2("Respuestas")) + 1).ToString & ") " & dr2("Titulo").ToString, "E", dr2("IdUser"))

                        End If

                    Else

                        If dr2("Leido") Then

                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Remitente"), dr2("Titulo").ToString, "L", dr2("IdUser"))

                        Else

                            dgv.Rows.Add(dr2("Id"), CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5), dr2("Remitente"), dr2("Titulo").ToString, "E", dr2("IdUser"))

                        End If

                    End If

                    If dr2("Importancia") = 2 Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red

                    End If

                    If dr2("Leido") = False And dr2("UltimoRemitente").ToString.ToUpper <> User.ToUpper Then

                        Nuevos = Nuevos + 1
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                    End If

                    If dr2("Finalizado") Then

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Finished

                    End If

                ElseIf Tipo = 21 Or Tipo = 22 Then

                    If cont > 0 Then

                        If Month(CDate(dr2("Fecha")).ToShortDateString) <> Month(CDate(dgv.Rows(dgv.RowCount - 1).Cells(2).Value)) Then

                            dgv.Rows.Add(0, "M", "", "", MonthName(Month(dr2("Fecha"))).ToString.Substring(0, 1).ToUpper & MonthName(Month(dr2("Fecha"))).ToString.Substring(1, MonthName(Month(dr2("Fecha"))).ToString.Length - 1) & " " & Year(dr2("Fecha")), "", "")
                            dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.DarkOrange
                            dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                            dgv.Rows(dgv.RowCount - 1).Height = 25
                            dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                        End If

                        If dr2("Remitente").ToString.ToUpper = dr2("Destino").ToString.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "R", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Remi"), dr2("Titulo").ToString, dr2("Remitente"), dr2("Importancia"))

                        ElseIf dr2("Remitente").ToString.ToUpper = User.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "M.E.", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Dest"), dr2("Titulo").ToString, dr2("Destino"), dr2("Importancia"))

                        ElseIf dr2("Destino").ToString.ToUpper = User.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "M.R.", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Remi"), dr2("Titulo").ToString, dr2("Destino"), dr2("Importancia"))

                        End If

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                        If dr2("Importancia") = 2 Then

                            dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red

                        End If

                    Else

                        dgv.Rows.Add(0, "", "", "", MonthName(Month(dr2("Fecha"))).ToString.Substring(0, 1).ToUpper & MonthName(Month(dr2("Fecha"))).ToString.Substring(1, MonthName(Month(dr2("Fecha"))).ToString.Length - 1) & " " & Year(dr2("Fecha")), "", "")
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.BackColor = Color.DarkOrange
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                        dgv.Rows(dgv.RowCount - 1).Height = 25
                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread


                        If dr2("Remitente").ToString.ToUpper = dr2("Destino").ToString.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "R", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Remi"), dr2("Titulo").ToString, dr2("Remitente"), dr2("Importancia"))

                        ElseIf dr2("Remitente").ToString.ToUpper = User.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "M.E.", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Dest"), dr2("Titulo").ToString, dr2("Destino"), dr2("Importancia"))

                        ElseIf dr2("Destino").ToString.ToUpper = User.ToUpper Then

                            dgv.Rows.Add(dr2("Id"), "M.R.", CDate(dr2("Fecha")).ToShortDateString.Substring(0, 5) & CDate(dr2("Fecha")).ToShortDateString.Substring(5, 5).Replace("/20", "/"), dr2("Remi"), dr2("Titulo").ToString, dr2("Destino"), dr2("Importancia"))

                        End If

                        dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.Font = Unread

                        If dr2("Importancia") = 2 Then

                            dgv.Rows(dgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red

                        End If


                    End If

                    cont = cont + 1

                End If

            End While

        Catch ex As Exception

            If Tipo = 0 Then
                MsgBox("Error cargando recordatorios")
                MsgBox(ex.ToString)
            End If

        Finally

            dgv.ClearSelection()
            dr2.Close()

        End Try

    End Sub

    Public Shared Sub consulta_Mensaje(ByRef titulo As String, ByRef body As String, ByRef remi As String, ByVal id As Integer, ByRef finalizado As Boolean, ByRef rep As Integer, ByRef nt As NotifyIcon, ByRef elim As Boolean, Optional ByRef cb As ComboBox = Nothing, Optional ByRef dtp As DateTimePicker = Nothing, Optional ByRef hora As String = "", Optional ByRef min As String = "", Optional ByRef ampm As String = "", Optional ByRef Importancia As ComboBox = Nothing)

        Try

            Dim cont As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMensaje"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@tipo", 19)
            command.Parameters.AddWithValue("@fecha1", Today)
            command.Parameters.AddWithValue("@fecha2", Today)
            command.Parameters.AddWithValue("@usr", User)
            dr = command.ExecuteReader()

            If dr.HasRows Then

                While dr.Read

                    titulo = dr("Titulo")
                    body = dr("Cuerpo")
                    remi = dr("Remitente")
                    rep = dr("id_rep")
                    finalizado = dr("Finalizado")

                    If Not cb Is Nothing Then

                        While cont < cb.Items.Count

                            If cb.Items(cont)(0) = dr("Destino") Then

                                cb.SelectedIndex = cont
                                cont = cb.Items.Count

                            Else

                                cont = cont + 1

                            End If

                        End While

                    End If

                    If Not dtp Is Nothing Then

                        dtp.Value = dr("Fecha")

                        hora = Hour(dr("Fecha"))
                        min = Minute(dr("Fecha"))

                        ampm = dr("Fecha").ToString.Substring(dr("Fecha").ToString.Length - 4, 4).ToUpper

                        Dim imp As Integer = dr("Importancia")

                        If imp = 1 Then
                            Importancia.Text = "Normal"
                        ElseIf imp = 2 Then
                            Importancia.Text = "Urgente"
                        End If

                    End If

                End While

            Else

                elim = True
                nt.ShowBalloonTip(5000, "SINPRO", "El mensaje fue eliminado", ToolTipIcon.Error)

            End If

        Catch ex As Exception

            MsgBox("Error cargando mensaje original", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_Mensaje_Repeticiones(ByVal id As Integer, ByRef num1 As Integer, ByRef num2 As Integer, ByRef fecha As Date)

        Try

            Dim cont As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMensaje"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@tipo", 20)
            command.Parameters.AddWithValue("@fecha1", Today)
            command.Parameters.AddWithValue("@fecha2", Today)
            command.Parameters.AddWithValue("@usr", User)
            dr = command.ExecuteReader()

            While dr.Read

                num1 = dr("DIF")
                num2 = dr("rep")
                fecha = dr("Fecha")

            End While

        Catch ex As Exception

            MsgBox("Error repeticiones", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_Respuestas_Mensaje(ByRef dgv As DataGridView, ByVal id_m As Integer)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaRespuestas_Mensaje"
            command.Parameters.AddWithValue("@id", id_m)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Usuario"), dr("Fecha"), dr("Cuerpo"), dr("Login"))
                dgv.Rows(dgv.RowCount - 1).ReadOnly = True

            End While

        Catch ex As Exception
            MsgBox("Error consultando respuestas", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
            dgv.ClearSelection()
        End Try

    End Sub

    Public Shared Sub consulta_identidad_Mensaje(ByRef ident As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaIdentidad_Mensaje"
            dr = command.ExecuteReader()

            While dr.Read

                ident = dr("id_Rep")

            End While

        Catch ex As Exception
            MsgBox("Error código del mensaje", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Function Inserta_Mensaje(ByVal remi As String, ByVal dest As String, ByVal titulo As String, ByVal cuerpo As String, ByVal fecha As DateTime, ByVal impor As Integer, ByVal id_rep As Integer) As Integer

        Dim Id As Integer = 0

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaMensaje"
            command.Parameters.AddWithValue("@rem", remi)
            command.Parameters.AddWithValue("@Dest", dest)
            command.Parameters.AddWithValue("@tit", titulo)
            command.Parameters.AddWithValue("@cue", cuerpo)
            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@imp", impor)
            command.Parameters.AddWithValue("@fin", False)
            command.Parameters.AddWithValue("@lei", False)
            command.Parameters.AddWithValue("@id_rep", id_rep)
            id = command.ExecuteScalar()

        Catch ex As Exception
            MsgBox("Error enviando mensaje", MsgBoxStyle.Critical, "SINPRO")
        End Try

        Return Id

    End Function

    Public Shared Function Inserta_Respuesta(ByVal id_m As Integer, ByVal remi As String, ByVal cuerpo As String, ByVal fecha As DateTime) As Integer

        Dim id As Integer = 0

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaRespuesta"
            command.Parameters.AddWithValue("@Id_m", id_m)
            command.Parameters.AddWithValue("@usr", remi)
            command.Parameters.AddWithValue("@cue", cuerpo)
            command.Parameters.AddWithValue("@Fecha", fecha)
            id  = command.ExecuteScalar()

        Catch ex As Exception
            MsgBox("Error enviando mensaje", MsgBoxStyle.Critical, "SINPRO")
        End Try

        Return id

    End Function

    Public Shared Sub Modifica_Mensaje(ByVal id As Integer, ByVal Tipo As Integer, ByVal leido As Boolean, ByVal finalizado As Boolean, ByVal fecha As DateTime, ByVal body As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaMensaje"
            command.Parameters.AddWithValue("@Id", id)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@lei", leido)
            command.Parameters.AddWithValue("@fin", finalizado)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@body", body)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando mensaje", MsgBoxStyle.Critical, "SINPRO")

        End Try
    End Sub

    Public Shared Sub Elimina_Mensaje(ByVal id As Integer, ByRef nt1 As NotifyIcon, ByVal tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaMensaje"
            command.Parameters.AddWithValue("@Id", id)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.ExecuteNonQuery()

            nt1.ShowBalloonTip(5000, "SINPRO", "Mensaje Eliminado", ToolTipIcon.Info)

        Catch ex As Exception
            MsgBox("Error enviando mensaje", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub Elimina_Respuesta(ByVal id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaRespuesta"
            command.Parameters.AddWithValue("@Id", id)
            command.ExecuteNonQuery()

            MsgBox("Respuesta eliminada satisfactoriamente", MsgBoxStyle.Critical, "SINPRO")

        Catch ex As Exception
            MsgBox("Error enviando mensaje", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub

End Class
