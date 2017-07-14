Imports System.Net.Mail

Public Class Frm_CrearMensaje

    Public User As String = ""
    Public id_m As Integer = 0
    Public futuro As Boolean = False
    Dim sw As Boolean = False

    Private Sub Frm_CrearMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaUsuarios' table. You can move, or remove it, as needed.
        Me.Sp_consultaUsuariosTableAdapter.Fill(Me.MELDataSet.sp_consultaUsuarios, 0, "")

        If id_m <> 0 Then

            chk_finalizado.Visible = True
            bt_eliminar.Visible = True

            Dim num As Integer = 0
            Dim dif As Integer = 0
            Dim c As Integer = 0
            Dim rep As Integer = 0
            Dim fecha As Date = Today

            If futuro Then

                chk_finalizado.Visible = False
                DatosMensaje.Modifica_Mensaje(id_m, 0, False, False, Today, "")
                DatosMensaje.Modifica_Mensaje(id_m, 1, False, False, Today, "")

            End If

            DatosMensaje.consulta_Mensaje(tb_titulo.Text, tb_mensaje.Text, "", id_m, chk_finalizado.Checked, num, Frm_Principal.NotifyIcon1, False, cb_usuario, dtp_fecha, tb_hora.Text, tb_minutos.Text, cb_AM_PM.Text, cb_importancia)
            DatosMensaje.consulta_Mensaje_Repeticiones(num, dif, c, fecha)

            If chk_finalizado.Checked Then
                bt_enviar.Text = "Cerrar"
            End If

            If c <> 0 Then
                rep = dif / c
            End If

            If rep <> 0 Then

                If rep = 1 Then

                    Label10.Text = "Esta tarea se repite por los próximos " & c.ToString & " día(s), hasta el día " & fecha.ToShortDateString
                    Label10.Visible = True

                ElseIf rep = 7 Then

                    Label10.Text = "Esta tarea se repite por las próximas " & c.ToString & " semana(s), hasta el día " & fecha.ToShortDateString
                    Label10.Visible = True

                ElseIf rep > 27 And rep < 32 Then

                    Label10.Text = "Esta tarea se repite por los próximos " & c.ToString & " mese(s), hasta el día " & fecha.ToShortDateString
                    Label10.Visible = True

                ElseIf rep >= 360 Then

                    Label10.Visible = True
                    Label10.Text = "Esta tarea se repite por los próximos " & c.ToString & " año(s), hasta el día " & fecha.ToShortDateString

                End If

            End If

            If CInt(tb_hora.Text) > 12 Then

                tb_hora.Text = CInt(tb_hora.Text) - 12

            End If

            sw = True
            DatosMensaje.Modifica_Mensaje(id_m, 0, True, False, Today, "")
            bt_enviar.Text = "Modificar"
            chk_repetir.Visible = False
            cb_frecuencia.Visible = False
            cb_tope.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            chk_repetir.Checked = False
            cb_usuario.Enabled = False
            tb_titulo.ReadOnly = True
            cb_importancia.Enabled = False

        Else

            tb_hora.Text = TimeOfDay.Hour.ToString

            If CInt(tb_hora.Text) > 12 Then

                tb_hora.Text = CInt(tb_hora.Text) - 12

            End If

            tb_minutos.Text = TimeOfDay.Minute.ToString
            cb_AM_PM.Text = Date.Now.ToString.Substring(20, 4).ToUpper

            cb_importancia.Text = "Normal"

            chk_repetir.Visible = True
            cb_frecuencia.Visible = True
            cb_tope.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            cb_usuario.Enabled = True
            tb_titulo.ReadOnly = False
            cb_importancia.Enabled = True

        End If

    End Sub

    Private Sub bt_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_enviar.Click

        If bt_enviar.Text = "Cerrar" Then

            Me.Close()

        End If

        Dim FechaCompleta As DateTime = Today

        If tb_mensaje.Text.Trim = "" Then

            tb_mensaje.Text = tb_titulo.Text

        End If

        If cb_usuario.SelectedIndex <> -1 And cb_importancia.SelectedIndex <> -1 And tb_hora.Text.Trim <> "" And tb_minutos.Text.Trim <> "" And cb_AM_PM.SelectedIndex <> -1 And tb_titulo.Text.Trim <> "" And tb_mensaje.Text.Trim <> "" Then

            If cb_AM_PM.Text = "A.M." Then

                If tb_hora.Text = "12" Then

                    FechaCompleta = New DateTime(Year(dtp_fecha.Value), Month(dtp_fecha.Value), dtp_fecha.Value.ToShortDateString.Substring(0, 2), 0, CInt(tb_minutos.Text), 0)

                Else

                    FechaCompleta = New DateTime(Year(dtp_fecha.Value), Month(dtp_fecha.Value), dtp_fecha.Value.ToShortDateString.Substring(0, 2), CInt(tb_hora.Text), CInt(tb_minutos.Text), 0)

                End If

            Else

                If tb_hora.Text = 12 Then
                    FechaCompleta = New DateTime(Year(dtp_fecha.Value), Month(dtp_fecha.Value), dtp_fecha.Value.ToShortDateString.Substring(0, 2), CInt(tb_hora.Text), CInt(tb_minutos.Text), 0)
                Else
                    FechaCompleta = New DateTime(Year(dtp_fecha.Value), Month(dtp_fecha.Value), dtp_fecha.Value.ToShortDateString.Substring(0, 2), CInt(tb_hora.Text) + 12, CInt(tb_minutos.Text), 0)
                End If


            End If

            Dim Importacia As Integer = 0

            If cb_importancia.Text = "Normal" Then

                Importacia = 1

            ElseIf cb_importancia.Text = "Urgente" Then

                Importacia = 2

            End If

            Dim num As Integer = 0

            DatosMensaje.consulta_identidad_Mensaje(num)

            If chk_repetir.Checked Then

                If cb_frecuencia.Text <> "" And cb_tope.Text <> "" Then

                    If cb_frecuencia.Text = "Diaria" Then

                        For cont As Integer = 0 To CInt(cb_tope.Text)

                            If cont < CInt(cb_tope.Text) Then

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text, DateAdd(DateInterval.Day, cont, FechaCompleta), Importacia, num)

                            Else

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text & ". Última repetición", DateAdd(DateInterval.Day, cont, FechaCompleta), Importacia, num)

                            End If

                        Next

                    ElseIf cb_frecuencia.Text = "Semanal" Then

                        For cont As Integer = 0 To (CInt(cb_tope.Text) * 7) Step 7

                            If cont < (CInt(cb_tope.Text) * 7) Then

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text, DateAdd(DateInterval.Day, cont, FechaCompleta), Importacia, num)

                            Else

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text & ". Última repetición", DateAdd(DateInterval.Day, cont, FechaCompleta), Importacia, num)

                            End If

                        Next

                    ElseIf cb_frecuencia.Text = "Mensual" Then

                        For cont As Integer = 0 To CInt(cb_tope.Text)

                            If cont < CInt(cb_tope.Text) Then

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text, DateAdd(DateInterval.Month, cont, FechaCompleta), Importacia, num)

                            Else

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text & ". Última repetición", DateAdd(DateInterval.Month, cont, FechaCompleta), Importacia, num)

                            End If

                        Next



                    ElseIf cb_frecuencia.Text = "Anual" Then

                        For cont As Integer = 0 To CInt(cb_tope.Text)

                            If cont < CInt(cb_tope.Text) Then

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text, DateAdd(DateInterval.Year, cont, FechaCompleta), Importacia, num)

                            Else

                                DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text & ". Última repetición", DateAdd(DateInterval.Year, cont, FechaCompleta), Importacia, num)

                            End If

                        Next



                    End If

                Else

                    MsgBox("Debe llenar todos los datos del mensaje", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            Else

                If bt_enviar.Text = "Modificar" Then

                    If futuro Then

                        DatosMensaje.Modifica_Mensaje(id_m, 0, False, False, FechaCompleta, tb_mensaje.Text)
                        DatosMensaje.Modifica_Mensaje(id_m, 1, False, False, FechaCompleta, tb_mensaje.Text)

                    Else

                        DatosMensaje.Modifica_Mensaje(id_m, 2, True, chk_finalizado.Checked, FechaCompleta, tb_mensaje.Text)

                    End If

                Else

                    DatosMensaje.Inserta_Mensaje(User, cb_usuario.SelectedItem(0), tb_titulo.Text, tb_mensaje.Text, FechaCompleta, Importacia, num)

                End If

            End If

            'Envío de email
            Dim usuarios As Boolean = False
            Dim vendedores As Boolean = False
            Dim clientes As Boolean = False
            Dim categoria As Integer = 1
            Dim sub_categoria As Integer = 1

            DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)

            If (usuarios Or vendedores Or clientes) Then
                DatosCorreos.Crear_Correo(sub_categoria, num)
            End If

            Me.Close()

        Else

            MsgBox("Debe llenar todos los datos del mensaje", MsgBoxStyle.Exclamation, "SINPRO")

        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click

        If Label10.Visible Then

            Dim respo As Integer = MsgBox("¿Está seguro que desea eliminar esta tarea junto a todas sus repeticiones?", MsgBoxStyle.YesNo, "SINPRO")

            If respo = vbYes Then

                DatosMensaje.Elimina_Mensaje(id_m, Frm_Principal.NotifyIcon1, 0)

            End If

        Else

            DatosMensaje.Elimina_Mensaje(id_m, Frm_Principal.NotifyIcon1, 1)

        End If

        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_repetir.CheckedChanged

        cb_frecuencia.Enabled = chk_repetir.Checked
        cb_tope.Enabled = chk_repetir.Checked

        If chk_repetir.Checked = False Then

            cb_frecuencia.Text = ""
            cb_tope.ResetText()

        End If

    End Sub

    Private Sub cb_frecuencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_frecuencia.SelectedIndexChanged

        If cb_frecuencia.Text = "Diaria" Then

            Label12.Text = "días"

        ElseIf cb_frecuencia.Text = "Semanal" Then

            Label12.Text = "semanas"

        ElseIf cb_frecuencia.Text = "Mensual" Then

            Label12.Text = "meses"

        ElseIf cb_frecuencia.Text = "Anual" Then

            Label12.Text = "años"

        Else

            Label12.Text = "días"

        End If

    End Sub

    Private Sub tb_hora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_hora.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub tb_minutos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_minutos.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub


    Private Sub tb_hora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_hora.TextChanged

        If sw Then

            If tb_hora.Text <> "" Then

                If CInt(tb_hora.Text) > 12 Then

                    tb_hora.Text = tb_hora.Text.Substring(0, tb_hora.Text.Length - 1)
                    tb_hora.SelectionStart = tb_hora.Text.Length


                End If

            End If

        End If

    End Sub

    Private Sub tb_minutos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_minutos.TextChanged

        If tb_minutos.Text <> "" Then

            If CInt(tb_minutos.Text) > 60 Then

                tb_minutos.Text = tb_minutos.Text.Substring(0, tb_minutos.Text.Length - 1)
                tb_minutos.SelectionStart = tb_minutos.Text.Length

            End If

        End If

    End Sub

End Class