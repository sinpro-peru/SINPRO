Imports System.Data.SqlClient
Imports Dundas.Charting.WinControl
Imports Dundas.Charting.WinControl.ChartTypes
Imports Dundas.Extensions
Imports System.Drawing
Imports System.Collections.Specialized
Imports System.Text.RegularExpressions


Public Class DatosCorreos
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub Consultar_Config_Correos(ByRef DGV As DataGridView)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

            Try
                DGV.Rows.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.CommandText = "sp_consultaConfigCorreos"
                dr = command.ExecuteReader

                While dr.Read

                    Dim col0 As New DataGridViewTextBoxCell
                    Dim col1 As New DataGridViewTextBoxCell
                    Dim col2 As New DataGridViewComboBoxCell
                    Dim col3 As New DataGridViewComboBoxCell
                    Dim col4 As New DataGridViewComboBoxCell

                    col0.Value = dr("Id")
                    col1.Value = dr("Nombre")

                    col2.Items.Add("Sí")
                    col2.Items.Add("No")

                    If dr("Usuarios") Then
                        col2.Value = "Sí"
                    Else
                        col2.Value = "No"
                    End If

                    col3.Items.Add("Sí")
                    col3.Items.Add("No")

                    If dr("Clientes") Then
                        col3.Value = "Sí"
                    Else
                        col3.Value = "No"
                    End If

                    col4.Items.Add("Sí")
                    col4.Items.Add("No")

                    If dr("Vendedores") Then
                        col4.Value = "Sí"
                    Else
                        col4.Value = "No"
                    End If

                    Dim row As New DataGridViewRow

                    row.Cells.Add(col0)
                    row.Cells.Add(col1)
                    row.Cells.Add(col2)
                    row.Cells.Add(col3)
                    row.Cells.Add(col4)

                    DGV.Rows.Add(row)

                End While

            Catch ex As Exception

                MsgBox("Ha ocurrido un error consultando la configuración del envío de correos", MsgBoxStyle.Critical)

            Finally

                DGV.ClearSelection()
                dr.Close()

            End Try

        End If

    End Sub

    Public Shared Sub Consultar_Config_Correos(ByRef usuarios As Boolean, ByRef vendedores As Boolean, ByRef clientes As Boolean, ByVal tipo As Integer)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

            Try
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.CommandText = "sp_consultaConfigCorreos"
                dr = command.ExecuteReader

                While dr.Read

                    If dr("Id") = tipo Then

                        usuarios = dr("usuarios")
                        vendedores = dr("vendedores")
                        clientes = dr("clientes")

                    End If

                End While

            Catch ex As Exception

                MsgBox("Ha ocurrido un error consultando la configuración del envío de correos", MsgBoxStyle.Critical)

            Finally

                dr.Close()

            End Try

        End If

    End Sub

    Public Shared Sub Modificar_Config_Correos(ByRef DGV As DataGridView)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then

            Try

                For i As Integer = 0 To DGV.RowCount - 1

                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Clear()

                    command.CommandText = "sp_modificaConfigCorreos"
                    command.Parameters.AddWithValue("@cat", DGV.Rows(i).Cells(0).Value)
                    command.Parameters.AddWithValue("@usuarios", IIf(DGV.Rows(i).Cells(2).Value = "Sí", True, False))
                    command.Parameters.AddWithValue("@client", IIf(DGV.Rows(i).Cells(3).Value = "Sí", True, False))
                    command.Parameters.AddWithValue("@vend", IIf(DGV.Rows(i).Cells(4).Value = "Sí", True, False))
                    command.ExecuteNonQuery()

                    dr.Close()

                Next

            Catch ex As Exception

                MsgBox("Ha ocurrido un error modificando la configuración del envío de correos", MsgBoxStyle.Critical)

            End Try

        End If

    End Sub

    Public Shared Sub Crear_Correo(ByVal id_sub_categoria As Integer, ByVal id_objeto As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaCorreo"
            command.Parameters.AddWithValue("@id_s", id_sub_categoria)
            command.Parameters.AddWithValue("@id_o", id_objeto)
            command.ExecuteNonQuery()

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Ocurrió un error guardando correo en cola de envíos", ToolTipIcon.Error)
        End Try

    End Sub

End Class
