Public Class Frm_EvaluacionZonas

    Private Sub Frm_EvaluacionZonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        UserControl41.Chart1.Titles(0).Text = "Distribución de clientes en estados"

        DateTimePicker1.Value = "01/" + Month(Today).ToString + "/" + Year(Today).ToString
        DateTimePicker2.Text = Today

        DateTimePicker3.Text = "01/" + Month(Today).ToString + "/" + (Year(Today) - 1).ToString
        DateTimePicker4.Text = DateAdd(DateInterval.Year, -1, Today)

        tb_porDebajo.Text = 0

        cb_Importanciaclientes.SelectedIndex = 0
        cb_ImportanciaVentas.SelectedIndex = 4

        Button2_Click(bt_evaluar, New EventArgs)

    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluar.Click

        If DateTimePicker1.Value <= DateTimePicker2.Value And DateTimePicker3.Value <= DateTimePicker4.Value Then

            DatosDSS.VentasPorZona(UserControl51.Chart1, DateTimePicker1.Value, DateTimePicker2.Value, DateTimePicker3.Value, DateTimePicker4.Value, DGV_Estados, Label12.Text, Label13.Text, Label4.Text)

            If CInt(tb_porDebajo.Text) <= 100 Then

                DatosDSS.GraficoCircularEstados(UserControl41.Chart1, DGV_Estados, CInt(tb_porDebajo.Text))

            Else

                MsgBox("El valor de agrupación estar entre 0 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_porDebajo.Focus()
                tb_porDebajo.SelectAll()

            End If


            RankingZonas()

        Else

            MsgBox("Períodos no válidos", MsgBoxStyle.Critical, "Error")

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        tb_porDebajo.Enabled = CheckBox1.Checked

        If CheckBox1.Checked Then
            tb_porDebajo.Focus()
            tb_porDebajo.SelectAll()
        Else
            tb_porDebajo.Text = 0
            DatosDSS.VentasPorZona(UserControl51.Chart1, DateTimePicker1.Value, DateTimePicker2.Value, DateTimePicker3.Value, DateTimePicker4.Value, DGV_Estados, Label12.Text, Label13.Text, Label4.Text)
            DatosDSS.GraficoCircularEstados(UserControl41.Chart1, DGV_Estados, CInt(tb_porDebajo.Text))
            RankingZonas()
        End If


    End Sub

    Private Sub tb_porDebajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_porDebajo.GotFocus
        tb_porDebajo.SelectAll()
    End Sub

    Private Sub tb_porcDebajo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_porDebajo.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

            If CInt(tb_porDebajo.Text) <= 100 Then

                DatosDSS.VentasPorZona(UserControl51.Chart1, DateTimePicker1.Value, DateTimePicker2.Value, DateTimePicker3.Value, DateTimePicker4.Value, DGV_Estados, Label12.Text, Label13.Text, Label4.Text)
                DatosDSS.GraficoCircularEstados(UserControl41.Chart1, DGV_Estados, CInt(tb_porDebajo.Text))
                RankingZonas()

            Else

                MsgBox("El valor debe estar entre 0 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_porDebajo.Focus()
                tb_porDebajo.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_porcDebajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_porDebajo.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Public Sub RankingZonas()

        For cont As Integer = 0 To DGV_Estados.RowCount - 1
            DGV_Estados.Rows(cont).Cells(6).Value = 0
        Next

        If DGV_Estados.RowCount > 0 Then

            For i As Integer = 0 To DGV_Estados.RowCount - 1

                For j As Integer = 3 To DGV_Estados.ColumnCount - 1 Step 2

                    If j = 3 Then

                        DGV_Estados(6, i).Value = CDbl(DGV_Estados(6, i).Value) + (((CDbl(DGV_Estados(j, i).Value) * 100) * (cb_Importanciaclientes.SelectedIndex + 1)))

                    ElseIf j = 5 Then

                        DGV_Estados(6, i).Value = CDbl(DGV_Estados(6, i).Value) + (((CDbl(DGV_Estados(j, i).Value) * 100) * (cb_ImportanciaVentas.SelectedIndex + 1)))

                    End If

                Next

            Next

            DGV_Estados.Sort(DGV_Estados.Columns(6), System.ComponentModel.ListSortDirection.Descending)

            Dim Plata As Integer = Premiacion(0, 11, CInt(DGV_Estados.Rows(0).Cells(6).Value))
            Dim Bronce As Integer = Premiacion(Plata, 12, CInt(DGV_Estados.Rows(Plata).Cells(6).Value))
            Dim Demas As Integer = Premiacion(Bronce, 13, CInt(DGV_Estados.Rows(Bronce).Cells(6).Value))

            For cont As Integer = Demas To DGV_Estados.RowCount - 1

                DGV_Estados.Rows(cont).Cells(7).Value = ImageList1.Images(9)

            Next

        End If

        DGV_Estados.ClearSelection()

    End Sub

    Public Function Premiacion(ByVal Desde As Integer, ByVal Medalla As Integer, ByVal Puntuacion As Integer) As Integer

        Dim Retornar As Integer = 0

        While Desde <= DGV_Estados.RowCount - 1

            If CInt(DGV_Estados.Rows(Desde).Cells(6).Value) = Puntuacion Then

                DGV_Estados.Rows(Desde).Cells(7).Value = ImageList1.Images(Medalla)
                Desde = Desde + 1

            Else

                Retornar = Desde
                Desde = DGV_Estados.RowCount

            End If

        End While

        Return Retornar

    End Function

End Class