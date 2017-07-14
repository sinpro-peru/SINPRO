Public Class Frm_MensajesFuturos

    Public user_l As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 21, 0, Today, Today)

    End Sub

    Private Sub bt_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_enviar.Click

        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 22, 0, DateTimePicker1.Value, DateTimePicker2.Value)
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = DateAdd(DateInterval.Month, 3, Today)


        Else

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 21, 0, DateTimePicker1.Value, DateTimePicker2.Value)
            DateTimePicker1.Enabled = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Enabled = False
            DateTimePicker2.Value = DateAdd(DateInterval.Month, 3, Today)

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        If DateTimePicker1.Enabled Then

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 22, 0, DateTimePicker1.Value, DateTimePicker2.Value)

        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

        If DateTimePicker2.Enabled Then

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 22, 0, DateTimePicker1.Value, DateTimePicker2.Value)

        End If

    End Sub

    Private Sub DGV_Futuros_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Futuros.CellDoubleClick

        If DGV_Futuros.SelectedRows.Count > 0 Then

            If DGV_Futuros.SelectedRows(0).Cells(0).Value = 0 Then

                Dim index As Integer = DGV_Futuros.SelectedRows(0).Index

                DGV_Futuros.Rows(index).Selected = False
                DGV_Futuros.Rows(index + 1).Cells(2).Selected = True

            Else

                If DGV_Futuros.SelectedRows(0).Cells(1).Value.ToString = "R" Then

                    Dim frm As New Frm_CrearMensaje
                    frm.futuro = True
                    frm.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                    frm.id_m = CInt(DGV_Futuros.SelectedRows(0).Cells(0).Value)
                    frm.Show()

                ElseIf DGV_Futuros.SelectedRows(0).Cells(1).Value.ToString = "M.E." Then

                    Dim frm As New Frm_CrearMensaje
                    frm.futuro = True
                    frm.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                    frm.id_m = CInt(DGV_Futuros.SelectedRows(0).Cells(0).Value)
                    frm.Show()

                End If

            End If

        End If

    End Sub

    Private Sub Frm_MensajesFuturos_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.GotFocus

        Dim index As Integer = 0
        Dim selected As Boolean = False

        If DGV_Futuros.SelectedRows.Count > 0 Then

            selected = True
            index = DGV_Futuros.SelectedRows(0).Index

        End If

        If DateTimePicker1.Enabled Then

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 22, 0, DateTimePicker1.Value, DateTimePicker2.Value)

        Else

            DatosMensaje.consulta_Mensajes(DGV_Futuros, 0, 21, 0, DateTimePicker1.Value, DateTimePicker2.Value)

        End If

        If selected Then

            DGV_Futuros.FirstDisplayedScrollingRowIndex = index
            DGV_Futuros.Rows(index).Cells(2).Selected = True

        End If



    End Sub

    Private Sub DGV_Futuros_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGV_Futuros.CellPainting

        If e.RowIndex <> -1 And e.RowIndex <= DGV_Futuros.RowCount - 1 Then

            If DGV_Futuros.Rows(e.RowIndex).Cells(0).Value.ToString = "0" AndAlso (e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5) Then

                Using gridBrush As Brush = New SolidBrush(Me.DGV_Futuros.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)

                        ' Clear cell 
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
                        'Bottom line drawing
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        'top line drawing
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top)
                        'Drawing Right line
                        If e.ColumnIndex = 5 Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
                        End If
                        'Inserting text
                        If e.ColumnIndex = 4 Then
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.White, e.CellBounds.X - (e.CellBounds.X / 4), e.CellBounds.Y + 5)
                        End If

                        e.Handled = True

                    End Using

                End Using

            End If

        End If

    End Sub

    Private Sub DGV_Futuros_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Futuros.CellClick

        If DGV_Futuros.SelectedRows(0).Cells(0).Value = 0 Then

            Dim index As Integer = DGV_Futuros.SelectedRows(0).Index

            DGV_Futuros.Rows(index).Selected = False
            DGV_Futuros.Rows(index + 1).Cells(2).Selected = True

        End If

    End Sub

End Class