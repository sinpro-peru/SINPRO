Imports System.Net.Mail

Public Class Frm_Respuestas

    Public user As String
    Public id_m As Integer
    Public persona As String
    Dim cont As Integer = 0
    Dim sw As Boolean = False

    Private Sub Frm_Respuestas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Dim rep As Integer = 0

        Dim cerrar As Boolean = False

        DatosMensaje.consulta_Mensaje(tb_titulo.Text, tb_mensaje.Text, tb_remitente.Text, id_m, chk_finalizado.Checked, 0, Frm_Principal.NotifyIcon1, cerrar)

        cont = cont + 1

        sw = True

        DatosMensaje.consulta_Respuestas_Mensaje(DGV_Respuestas, id_m)

        If user.ToUpper = tb_remitente.Text.ToUpper Then

            bt_eliminar.Visible = True
            chk_finalizado.Visible = False

        Else

            chk_finalizado.Visible = True
            bt_eliminar.Visible = False

        End If

        If DGV_Respuestas.RowCount > 0 Then

            If DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(3).Value.ToString.ToUpper <> user.ToUpper Then

                DatosMensaje.Modifica_Mensaje(id_m, 0, True, chk_finalizado.Checked, Today, "")

            End If

        Else

            If user.ToUpper <> tb_remitente.Text.ToUpper Then

                DatosMensaje.Modifica_Mensaje(id_m, 0, True, chk_finalizado.Checked, Today, "")

            End If


        End If

        DatosUsuarios.consulta_datos_usuario2(user, persona)


        If chk_finalizado.Checked And chk_finalizado.Visible Then

            bt_enviar.Text = "Cerrar"

            If DGV_Respuestas.RowCount > 0 Then
                DGV_Respuestas.Rows.RemoveAt(DGV_Respuestas.RowCount - 1)
            End If


        Else

            bt_enviar.Text = "Enviar"
            DGV_Respuestas.Rows.Add(persona, New DateTime(Year(Today), Month(Today), Today.ToShortDateString.Substring(0, 2), TimeOfDay.Hour, TimeOfDay.Minute, 0), "", user)
            DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(0).ReadOnly = True
            DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(1).ReadOnly = True
            DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(2).ReadOnly = False

        End If

        If DGV_Respuestas.RowCount > 0 Then
            DGV_Respuestas.FirstDisplayedScrollingRowIndex = DGV_Respuestas.RowCount - 1
        End If

        DatosUsuarios.consulta_datos_usuario2(tb_remitente.Text, tb_remitente.Text)
        DGV_Respuestas.ClearSelection()

        If cerrar Then

            Me.Close()
            Frm_Principal.bt_actualizar_Click(Frm_Principal.bt_actualizar, New EventArgs)

        End If

    End Sub

    Private Sub bt_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_enviar.Click

        If bt_enviar.Text = "Cerrar" Then

            DatosMensaje.Modifica_Mensaje(id_m, 1, True, chk_finalizado.Checked, Today, "")

            If chk_finalizado.Checked Then

                'Envío de email
                Dim usuarios As Boolean = False
                Dim vendedores As Boolean = False
                Dim clientes As Boolean = False
                Dim categoria As Integer = 1
                Dim sub_categoria As Integer = 3

                DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)

                If (usuarios Or vendedores Or clientes) Then
                    DatosCorreos.Crear_Correo(sub_categoria, id_m)
                End If

            End If

            Me.Close()

        Else

            If DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(2).Value.ToString.Trim <> "" Then

                Dim num As Integer = DatosMensaje.Inserta_Respuesta(id_m, DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(3).Value, DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(2).Value, DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(1).Value)

                'Envío de email
                Dim usuarios As Boolean = False
                Dim vendedores As Boolean = False
                Dim clientes As Boolean = False
                Dim categoria As Integer = 1
                Dim sub_categoria As Integer = 2

                DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)

                If (usuarios Or vendedores Or clientes) Then
                    DatosCorreos.Crear_Correo(sub_categoria, num)
                End If

            End If

            DatosMensaje.Modifica_Mensaje(id_m, 0, False, False, Today, "")
            DatosMensaje.Modifica_Mensaje(id_m, 1, True, False, Today, "")

            If DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(2).Value.ToString.Trim <> "" Then

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Repuesta enviada", ToolTipIcon.Info)

            Else

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mensaje Modificado", ToolTipIcon.Info)

            End If

            Me.Close()

        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click

        DatosMensaje.Elimina_Mensaje(id_m, Frm_Principal.NotifyIcon1, 1)
        Me.Close()

    End Sub

    Private Sub chk_finalizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_finalizado.CheckedChanged

        If cont > 0 Then

            If chk_finalizado.Visible Then

                If chk_finalizado.Checked Then

                    bt_enviar.Text = "Cerrar"

                    If DGV_Respuestas.RowCount > 0 Then
                        DGV_Respuestas.Rows.RemoveAt(DGV_Respuestas.RowCount - 1)
                    End If

                Else

                    bt_enviar.Text = "Enviar"
                    DGV_Respuestas.Rows.Add(persona, New DateTime(Year(Today), Month(Today), Today.ToShortDateString.Substring(0, 2), TimeOfDay.Hour, TimeOfDay.Minute, 0), "", user)
                    DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(0).ReadOnly = True
                    DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(1).ReadOnly = True
                    DGV_Respuestas.Rows(DGV_Respuestas.RowCount - 1).Cells(2).ReadOnly = False
                    DGV_Respuestas.FirstDisplayedScrollingRowIndex = DGV_Respuestas.RowCount - 1
                    DGV_Respuestas.ClearSelection()

                End If

            End If

        End If

    End Sub

End Class