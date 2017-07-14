Imports Dundas.Charting.WinControl
Imports Dundas.Charting.WinControl.ChartTypes
Imports Dundas.Extensions
Imports System.Drawing

Public Class Frm_EvaluacionVendedores

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then

            DateTimePicker6.Value = Today
            DateTimePicker5.Value = CDate("01/" + Month(Today).ToString + "/" + Year(Today).ToString)
            chk_agrupar.Checked = True
            tb_porcDebajo.Text = 3
            Button2_Click(bt_evaluarRendimiento, New EventArgs)

        ElseIf TabControl1.SelectedIndex = 1 Then

            DatosDSS.consulta_ParametrosDSS(tb_verdeDPC.Text, tb_AmarilloDPC1.Text, tb_AmarilloDPC2.Text, tb_RojoDPC.Text, tb_verdeOtros.Text, tb_amarilloOtros1.Text, tb_amarilloOtros2.Text, tb_rojoOtros.Text)
            lbl_total1.Text = "0,00"
            lbl_total2.Text = "0,00"
            lbl_total3.Text = "0"
            lbl_total4.Text = "0"
            lbl_total5.Text = "0"
            lbl_total6.Text = "0"
            lbl_total7.Text = "0"
            lbl_total8.Text = "0"
            lbl_total9.Text = "0,00"
            lbl_total10.Text = "0,00"
            DateTimePicker1.Focus()

        ElseIf TabControl1.SelectedIndex = 2 Then

            DGV_MesesVend.Columns(1).Visible = False
            DGV_MesesVend.Columns(0).Visible = False

            lbl_mes1.Text = "0,00"
            lbl_mes2.Text = "0,00"
            lbl_mes3.Text = "0,00"
            lbl_mes4.Text = "0,00"
            lbl_mes5.Text = "0,00"
            lbl_mes6.Text = "0,00"

            'TODO: This line of code loads data into the 'MELDataSet.Tbl_Vendedor' table. You can move, or remove it, as needed.
            Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor, "")
            Me.MELDataSet.Tbl_Vendedor.AddTbl_VendedorRow(0, "Todos", "", "", "", "", "", 0, "", "", False, "", False, "")

            txt_finalVend.Text = "          --- Escriba Vendedor ---"
            DGV_MesesVend.Rows.Clear()

            lbl_totalVentas1.Text = "0,00"
            lbl_TotalClient.Text = "0"
            lbl_TotalFact.Text = "0"
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

            Dim cont2 As Integer = DGV_MesesVend.Columns.Count - 1

            While DGV_MesesVend.Columns.Count - 1 > 1

                DGV_MesesVend.Columns.RemoveAt(cont2)
                cont2 = cont2 - 1

            End While

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluarDesempeño.Click
        If DateDiff(DateInterval.Month, DateTimePicker3.Value, DateTimePicker4.Value) >= DateDiff(DateInterval.Month, DateTimePicker1.Value, DateTimePicker2.Value) And DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) > 0 And DateDiff(DateInterval.Day, DateTimePicker3.Value, DateTimePicker4.Value) > 0 Then

            If tb_AmarilloDPC1.Text <> "" And tb_AmarilloDPC2.Text <> "" And tb_amarilloOtros1.Text <> "" And tb_amarilloOtros2.Text <> "" And tb_RojoDPC.Text <> "" And tb_rojoOtros.Text <> "" And tb_verdeDPC.Text <> "" And tb_verdeOtros.Text <> "" Then

                If CInt(tb_amarilloOtros1.Text) > CInt(tb_amarilloOtros2.Text) And CInt(tb_AmarilloDPC2.Text) > CInt(tb_AmarilloDPC1.Text) And CInt(tb_verdeOtros.Text) >= -100 And CInt(tb_verdeOtros.Text) <= 100 And CInt(tb_amarilloOtros1.Text) >= -100 And CInt(tb_amarilloOtros1.Text) <= 100 Then

                    Dim ValoresDPC(4) As Double

                    ValoresDPC(0) = CInt(tb_verdeDPC.Text)
                    ValoresDPC(1) = CInt(tb_AmarilloDPC1.Text)
                    ValoresDPC(2) = CInt(tb_AmarilloDPC2.Text)
                    ValoresDPC(3) = CInt(tb_RojoDPC.Text)

                    Dim ValoresOtros(4) As Double

                    ValoresOtros(0) = CInt(tb_verdeOtros.Text)
                    ValoresOtros(1) = CInt(tb_amarilloOtros1.Text)
                    ValoresOtros(2) = CInt(tb_amarilloOtros2.Text)
                    ValoresOtros(3) = CInt(tb_rojoOtros.Text)

                    DatosDSS.DGV_Semaforo(DGV_Semaforo, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, DateTimePicker3.Value.ToShortDateString, DateTimePicker4.Value.ToShortDateString, ImageList1, ValoresDPC, ValoresOtros)
                    DatosDSS.DGV_DatosSemaforo(DGV_DatosSemaforo, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, DateTimePicker3.Value.ToShortDateString, DateTimePicker4.Value.ToShortDateString)
                    RankingVendedores()

                    totalizar()
                    DGV_DatosSemaforo.ClearSelection()

                Else

                    MsgBox("Parámetros de comparación no válidos", MsgBoxStyle.Exclamation, "Error")

                End If

            Else

                MsgBox("Favor llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "Error")

            End If

        Else

            MsgBox("Fechas de comparación no válidas", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Public Sub RankingVendedores()

        If DGV_Semaforo.RowCount > 0 Then

            For i As Integer = 0 To DGV_Semaforo.RowCount - 1

                For j As Integer = 2 To DGV_Semaforo.RowCount - 2 Step 2

                    If j = 2 Then

                        If rb1_VBs.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 1)

                        ElseIf rb2_VBs.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 2)

                        ElseIf rb3_VBs.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 3)

                        ElseIf rb4_VBs.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 4)

                        ElseIf rb5_VBs.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 5)

                        End If

                    ElseIf j = 4 Then

                        If rb1_NumV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 1)

                        ElseIf rb2_NumV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 2)

                        ElseIf rb1_NumV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 3)

                        ElseIf rb4_NumV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 4)

                        ElseIf rb5_NumV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 5)

                        End If

                    ElseIf j = 6 Then

                        If rb1_NumC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 1)

                        ElseIf rb2_NumC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 2)

                        ElseIf rb3_NumC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 3)

                        ElseIf rb4_NumC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 4)

                        ElseIf rb5_NumC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 5)

                        End If

                    ElseIf j = 8 Then

                        If rb1_DPC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 1)

                        ElseIf rb2_DPC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 2)

                        ElseIf rb3_DPC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 3)

                        ElseIf rb4_DPC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 4)

                        ElseIf rb5_DPC.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 5)

                        End If

                    ElseIf j = 10 Then

                        If rb1_PPV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 1)

                        ElseIf rb2_PPV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 2)

                        ElseIf rb3_PPV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 3)

                        ElseIf rb4_PPV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 4)

                        ElseIf rb5_PPV.Checked Then

                            DGV_Semaforo(11, i).Value = CInt(DGV_Semaforo(11, i).Value) + (CInt(DGV_Semaforo(j, i).Value) * 5)

                        End If


                    End If

                Next

            Next

            For cont2 As Integer = 0 To DGV_Semaforo.RowCount - 1

                DGV_DatosSemaforo.Rows(cont2).Cells(11).Value = CDbl(DGV_Semaforo.Rows(cont2).Cells(11).Value)

            Next

            DGV_Semaforo.Sort(DGV_Semaforo.Columns(11), System.ComponentModel.ListSortDirection.Descending)
            DGV_DatosSemaforo.Sort(DGV_DatosSemaforo.Columns(11), System.ComponentModel.ListSortDirection.Descending)

            Dim Plata As Integer = Premiacion(0, 11, CInt(DGV_Semaforo.Rows(0).Cells(11).Value))
            Dim Bronce As Integer = Premiacion(Plata, 12, CInt(DGV_Semaforo.Rows(Plata).Cells(11).Value))
            Dim Demas As Integer = Premiacion(Bronce, 13, CInt(DGV_Semaforo.Rows(Bronce).Cells(11).Value))

            Dim Plata2 As Integer = Premiacion(0, 11, CInt(DGV_DatosSemaforo.Rows(0).Cells(11).Value))
            Dim Bronce2 As Integer = Premiacion(Plata2, 12, CInt(DGV_DatosSemaforo.Rows(Plata).Cells(11).Value))
            Dim Demas2 As Integer = Premiacion(Bronce2, 13, CInt(DGV_DatosSemaforo.Rows(Bronce).Cells(11).Value))

            For cont As Integer = Demas To DGV_Semaforo.RowCount - 1

                DGV_Semaforo.Rows(cont).Cells(12).Value = ImageList1.Images(9)
                DGV_DatosSemaforo.Rows(cont).Cells(12).Value = ImageList1.Images(9)

            Next

        End If

        DGV_Semaforo.ClearSelection()
        DGV_DatosSemaforo.ClearSelection()

    End Sub

    Public Function Premiacion(ByVal Desde As Integer, ByVal Medalla As Integer, ByVal Puntuacion As Integer) As Integer

        Dim Retornar As Integer = 0

        While Desde <= DGV_Semaforo.RowCount - 1

            If CInt(DGV_Semaforo.Rows(Desde).Cells(11).Value) = Puntuacion Then

                DGV_Semaforo.Rows(Desde).Cells(12).Value = ImageList1.Images(Medalla)
                DGV_DatosSemaforo.Rows(Desde).Cells(12).Value = ImageList1.Images(Medalla)
                Desde = Desde + 1

            Else

                Retornar = Desde
                Desde = DGV_Semaforo.RowCount

            End If

        End While

        Return Retornar

    End Function

    Private Sub tb_verdeDPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_verdeDPC.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            tb_AmarilloDPC1.Text = tb_verdeDPC.Text
            tb_AmarilloDPC1.Focus()
            tb_AmarilloDPC1.SelectAll()
        End If
    End Sub

    Private Sub tb_AmarilloDPC1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_AmarilloDPC1.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            tb_AmarilloDPC2.Focus()
            tb_AmarilloDPC2.SelectAll()
        End If
    End Sub

    Private Sub tb_AmarilloDPC2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_AmarilloDPC2.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then

            If CInt(tb_AmarilloDPC2.Text) > CInt(tb_AmarilloDPC1.Text) Then

                tb_RojoDPC.Text = tb_AmarilloDPC2.Text
                tb_RojoDPC.Focus()
                tb_RojoDPC.SelectAll()

            Else

                MsgBox("El valor debe ser mayor al anterior", MsgBoxStyle.Exclamation, "Error")
                tb_AmarilloDPC2.Focus()
                tb_AmarilloDPC2.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_RojoDPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_RojoDPC.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            tb_verdeOtros.Focus()
            tb_verdeOtros.SelectAll()
        End If
    End Sub

    Private Sub tb_verdeOtros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_verdeOtros.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

            If CInt(tb_verdeOtros.Text) <= 100 And CInt(tb_verdeOtros.Text) >= -100 Then

                tb_amarilloOtros1.Text = tb_verdeOtros.Text
                tb_amarilloOtros1.Focus()
                tb_amarilloOtros1.SelectAll()

            Else

                MsgBox("El valor debe estar entre -100 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_verdeOtros.Focus()
                tb_verdeOtros.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_amarilloOtros1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_amarilloOtros1.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            tb_amarilloOtros2.Focus()
            tb_amarilloOtros2.SelectAll()
        End If
    End Sub

    Private Sub tb_amarilloOtros2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_amarilloOtros2.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

            If CInt(tb_amarilloOtros2.Text) < CInt(tb_amarilloOtros1.Text) And (CInt(tb_amarilloOtros2.Text) >= -100 And CInt(tb_amarilloOtros2.Text) <= 100) Then

                tb_rojoOtros.Text = tb_amarilloOtros2.Text
                tb_rojoOtros.Focus()
                tb_rojoOtros.SelectAll()

            Else

                MsgBox("El valor debe ser menor al anterior y estar entre -100 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_amarilloOtros2.Focus()
                tb_amarilloOtros2.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_rojoOtros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_rojoOtros.KeyDown
        If e.KeyData = Keys.Enter Then
            bt_evaluarDesempeño.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker2.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            DateTimePicker3.Focus()
        End If
    End Sub

    Private Sub DateTimePicker3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker3.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
            DateTimePicker4.Focus()
        End If
    End Sub

    Private Sub DateTimePicker4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker4.KeyDown
        If e.KeyData = Keys.Enter Then
            tb_verdeDPC.Focus()
            tb_verdeDPC.SelectAll()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluarRendimiento.Click

        If DateTimePicker5.Value <= DateTimePicker6.Value Then

            If CInt(tb_porcDebajo.Text) <= 100 Then

                DatosDSS.GraficoCircularVendedores(UserControl31.Chart1, DateTimePicker5.Value, DateTimePicker6.Value, DGV_Vendedores, CInt(tb_porcDebajo.Text), lbl_TotalVentas.Text)
                DatosDSS.consultaFacturasVencidas(DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)

                If DGV_FactVencidas.RowCount > 0 Then

                    DatosDSS.CosultaFactCobradas(UserControl41.Chart1, DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
                    'GraficoCircularDiasCobro(UserControl41.Chart1, DGV_FactVencidas)

                End If

                If DGV_Vendedores.RowCount > 0 Then

                    Dim total As Double = 0

                    For cont As Integer = 0 To DGV_Vendedores.RowCount - 1

                        total = total + CDbl(DGV_Vendedores.Rows(cont).Cells(2).Value)

                    Next

                    If total > 0 Then

                        DGV_Vendedores.Rows(0).Cells(3).Value = Format((CDbl(DGV_Vendedores.Rows(0).Cells(2).Value) / total), "p")
                        DGV_Vendedores.Rows(0).Cells(4).Value = ImageList1.Images(11)

                    Else

                        DGV_Vendedores.Rows(0).Cells(3).Value = Format((0), "p")
                        DGV_Vendedores.Rows(0).Cells(4).Value = ImageList1.Images(9)

                    End If

                    If total > 0 Then

                        DGV_Vendedores.Rows(1).Cells(3).Value = Format((CDbl(DGV_Vendedores.Rows(1).Cells(2).Value) / total), "p")
                        DGV_Vendedores.Rows(1).Cells(4).Value = ImageList1.Images(12)
                    Else

                        DGV_Vendedores.Rows(1).Cells(3).Value = Format((0), "p")
                        DGV_Vendedores.Rows(1).Cells(4).Value = ImageList1.Images(9)

                    End If

                    If total > 0 Then

                        DGV_Vendedores.Rows(2).Cells(3).Value = Format((CDbl(DGV_Vendedores.Rows(2).Cells(2).Value) / total), "p")
                        DGV_Vendedores.Rows(2).Cells(4).Value = ImageList1.Images(13)

                    Else

                        DGV_Vendedores.Rows(2).Cells(3).Value = Format((0), "p")
                        DGV_Vendedores.Rows(2).Cells(4).Value = ImageList1.Images(9)

                    End If

                    For cont As Integer = 3 To DGV_Vendedores.RowCount - 1

                        DGV_Vendedores.Rows(cont).Cells(4).Value = ImageList1.Images(9)

                        If total > 0 Then

                            DGV_Vendedores.Rows(cont).Cells(3).Value = Format((CDbl(DGV_Vendedores.Rows(cont).Cells(2).Value) / total), "p")

                        Else

                            DGV_Vendedores.Rows(cont).Cells(3).Value = Format((0), "p")

                        End If

                    Next

                End If

            Else

                MsgBox("El valor debe estar entre 0 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_porcDebajo.Focus()
                tb_porcDebajo.SelectAll()

            End If

        Else

            MsgBox("Período de evaluación no válido", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Private Sub DGV_Vendedores_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_Vendedores.ColumnHeaderMouseClick
        For cont2 As Integer = 0 To DGV_Vendedores.RowCount - 1

            UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont2).Index)("Exploded") = "false"

        Next

        DGV_Vendedores.ClearSelection()
    End Sub

    Private Sub DGV_Vendedores_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Vendedores.CellClick, DGV_Vendedores.KeyUp

        If DGV_Vendedores.SelectedRows.Count > 0 Then

            DatosDSS.consultaFacturasVencidas(DGV_FactVencidas, CInt(DGV_Vendedores.SelectedRows(0).Cells(0).Value), DateTimePicker5.Value, DateTimePicker6.Value, 1)
            DatosDSS.CosultaFactCobradas(UserControl41.Chart1, DGV_FactVencidas, CInt(DGV_Vendedores.SelectedRows(0).Cells(0).Value), DateTimePicker5.Value, DateTimePicker6.Value, 1)
            'GraficoCircularDiasCobro(UserControl41.Chart1, DGV_FactVencidas)


            If CDbl((DGV_Vendedores.SelectedRows(0).Cells(3).Value).ToString.Trim("%")) > CInt(tb_porcDebajo.Text) Then

                For cont As Integer = 0 To DGV_Vendedores.RowCount - 1

                    UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont).Index)("Exploded") = "false"
                Next

                UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.SelectedRows(0).Index)("Exploded") = "true"

            Else

                Dim primero3 As Integer = 0
                Dim cont As Integer = 0

                For cont2 As Integer = 0 To DGV_Vendedores.RowCount - 1

                    UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont2).Index)("Exploded") = "false"

                Next

                While cont <= DGV_Vendedores.RowCount - 1

                    If CDbl((DGV_Vendedores.Rows(cont).Cells(3).Value).ToString.Trim("%")) <= CInt(tb_porcDebajo.Text) Then

                        primero3 = cont
                        cont = DGV_Vendedores.RowCount

                    Else

                        cont = cont + 1

                    End If

                End While


                UserControl31.Chart1.Series("Series1").Points(primero3)("Exploded") = "true"

            End If

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_agrupar.CheckedChanged
        If chk_agrupar.Checked Then

            tb_porcDebajo.ReadOnly = False
            tb_porcDebajo.Focus()
            tb_porcDebajo.SelectAll()

        Else

            tb_porcDebajo.ReadOnly = True
            tb_porcDebajo.Text = 0

        End If
    End Sub

    Private Sub tb_porcDebajo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_porcDebajo.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

            If CInt(tb_porcDebajo.Text) <= 100 Then

                bt_evaluarRendimiento.Focus()

            Else

                MsgBox("El valor debe estar entre 0 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_porcDebajo.Focus()
                tb_porcDebajo.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_porcDebajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_porcDebajo.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub tb_DPC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_verdeDPC.KeyPress, tb_AmarilloDPC1.KeyPress, tb_AmarilloDPC2.KeyPress, tb_RojoDPC.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub tb_Otros_KeyPress(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_verdeOtros.KeyPress, tb_amarilloOtros1.KeyPress, tb_amarilloOtros2.KeyPress, tb_rojoOtros.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-"c Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub Frm_InfoVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaLogo(PictureBox3)
        DateTimePicker6.Value = Today
        DateTimePicker5.Value = CDate("01/" + Month(Today).ToString + "/" + Year(Today).ToString)
        chk_agrupar.Checked = True
        tb_porcDebajo.Text = 3
        Button2_Click(bt_evaluarRendimiento, New EventArgs)

    End Sub

    Public Sub totalizar()

        Dim cont2 As Integer = 0

        For cont As Integer = 0 To DGV_DatosSemaforo.RowCount - 1

            lbl_total1.Text = Format(CDbl(lbl_total1.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(1).Value), "#,##0.00")
            lbl_total2.Text = Format(CDbl(lbl_total2.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(2).Value), "#,##0.00")
            lbl_total3.Text = CInt(lbl_total3.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(3).Value)
            lbl_total4.Text = CInt(lbl_total4.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(4).Value)
            lbl_total5.Text = CInt(lbl_total5.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(5).Value)
            lbl_total6.Text = CInt(lbl_total6.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(6).Value)
            lbl_total7.Text = CInt(lbl_total7.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(7).Value)
            lbl_total8.Text = CInt(lbl_total8.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(8).Value)
            lbl_total9.Text = Format(CDbl(lbl_total9.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(9).Value), "#,##0.00")
            lbl_total10.Text = Format(CDbl(lbl_total10.Text) + CDbl(DGV_DatosSemaforo.Rows(cont).Cells(10).Value), "#,##0.00")

            cont2 = cont2 + 1

        Next

        lbl_total7.Text = CInt(CInt(lbl_total7.Text) / cont2)
        lbl_total8.Text = CInt(CInt(lbl_total8.Text) / cont2)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Click

        For cont2 As Integer = 0 To DGV_Vendedores.RowCount - 1

            UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont2).Index)("Exploded") = "false"

        Next

        DatosDSS.consultaFacturasVencidas(DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
        DatosDSS.CosultaFactCobradas(UserControl41.Chart1, DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
 
        DGV_Vendedores.ClearSelection()
        DGV_FactVencidas.ClearSelection()

    End Sub

    Private Sub GroupBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox6.Click

        For cont2 As Integer = 0 To DGV_Vendedores.RowCount - 1

            UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont2).Index)("Exploded") = "false"

        Next

        'For cont As Integer = 1 To DGV_Vendedores.ColumnCount - 1

        '    UserControl41.Chart1.Series("Series1").Points(DGV_Vendedores.Columns(cont - 1).Index)("Exploded") = "false"
        'Next

        DatosDSS.consultaFacturasVencidas(DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
        DatosDSS.CosultaFactCobradas(UserControl41.Chart1, DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
        'GraficoCircularDiasCobro(UserControl41.Chart1, DGV_FactVencidas)

        DGV_FactVencidas.ClearSelection()
        DGV_Vendedores.ClearSelection()

    End Sub

    Public Shared Sub GraficoCircularDiasCobro(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByRef dgv As DataGridView)

        Try

            Dim xValues(3) As String
            Dim yValues(3) As Integer
            Dim xValuesVacio(3) As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 4
            Dim acum As Double = 0

            For cont = 0 To xValues.Length - 1

                yValues(cont) = dgv.Rows(0).Cells(cont + 1).Value
                xValuesVacio(cont) = ""

            Next

            If yValues(0) = 0 Then
                xValues(0) = ""
            Else
                xValues(0) = "< 30"
            End If

            If yValues(1) = 0 Then
                xValues(1) = ""
            Else
                xValues(1) = "> 30"
            End If

            If yValues(2) = 0 Then
                xValues(2) = ""
            Else
                xValues(2) = "> 45"
            End If

            If yValues(3) = 0 Then
                xValues(3) = ""
            Else
                xValues(3) = "> 60"
            End If

            'Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = False
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 8pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Series("Series1").LabelFormat = "N0"
            Chart1.Series("Series1").FontAngle = 0
            Chart1.Legends("Default").Enabled = False
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False

            'Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            'series1("CollectedThreshold") = PorcDebajo.ToString

            '' Set the threshold type to be a percentage of the pie
            '' When set to false, this property uses the actual value to determine the collected threshold
            'series1("CollectedThresholdUsePercent") = "true"

            '' Set the label of the collected pie slice
            'series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            '' Set the legend text of the collected pie slice
            'series1("CollectedLegendText") = "Otros"

            '' Set the collected pie slice to be exploded
            ''series1("CollectedSliceExploded") = "true"

            '' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            'series1("CollectedToolTip") = "Otros vendedores"

            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DGV_FactVencidas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_FactVencidas.CellClick

        For cont As Integer = 1 To DGV_Vendedores.ColumnCount - 1

            UserControl41.Chart1.Series("Series1").Points(DGV_Vendedores.Columns(cont - 1).Index)("Exploded") = "false"
        Next

        If DGV_FactVencidas.SelectedRows.Count > 0 And DGV_FactVencidas.CurrentCell.ColumnIndex <> 0 Then

            UserControl41.Chart1.Series("Series1").Points(DGV_FactVencidas.CurrentCell.ColumnIndex - 1)("Exploded") = "true"

        End If

    End Sub

    Private Sub DGV_FactVencidas_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_FactVencidas.CellDoubleClick

        If DGV_FactVencidas.SelectedRows.Count > 0 Then

            Dim frm As New Frm_Analisis_Cobranza
            frm.Show()
            frm.Hide()
            'frm.ch_fecha.Checked = True
            'frm.dtp_de.Value = DateTimePicker5.Value
            'frm.dtp_de_ValueChanged(frm.dtp_de, New EventArgs)
            'frm.dtp_hasta.Value = DateTimePicker6.Value
            'frm.dtp_hasta_ValueChanged(frm.dtp_de, New EventArgs)
            'frm.ch_fecha.Checked = False
            'frm.ch_fecha.Checked = True

            If DGV_FactVencidas.CurrentCell.ColumnIndex = 0 Then

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.ListBox2.Items.Count - 1

                    '    If frm.ListBox2.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                End If

            ElseIf DGV_FactVencidas.CurrentCell.ColumnIndex = 1 Then

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.tb_vendedor.Items.Count - 1

                    '    If frm.tb_vendedor.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                End If

                'For cont As Integer = 0 To frm.DGV_Facturas.RowCount - 1

                '    If CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) >= 30 Then

                '        frm.DGV_Facturas.Rows(cont).Visible = False

                '    End If

                'Next

                If frm.SpanalisisCobranzasBindingSource.Filter = "" Then
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + "Dias < 30"
                Else
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + " and Dias < 30"
                End If


            ElseIf DGV_FactVencidas.CurrentCell.ColumnIndex = 2 Then

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.tb_vendedor.Items.Count - 1

                    '    If frm.tb_vendedor.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))


                End If

                'For cont As Integer = 0 To frm.DGV_Facturas.RowCount - 1

                '    If CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) < 30 Or CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) >= 45 Then

                '        frm.DGV_Facturas.Rows(cont).Visible = False

                '    End If

                'Next

                If frm.SpanalisisCobranzasBindingSource.Filter = "" Then
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + "Dias >= 30 and Dias <= 45"
                Else
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + " and Dias >= 30 and Dias <= 45"
                End If


            ElseIf DGV_FactVencidas.CurrentCell.ColumnIndex = 3 Then

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.tb_vendedor.Items.Count - 1

                    '    If frm.tb_vendedor.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                End If

                'For cont As Integer = 0 To frm.DGV_Facturas.RowCount - 1

                '    If CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) < 45 Or CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) >= 60 Then

                '        frm.DGV_Facturas.Rows(cont).Visible = False

                '    End If

                'Next

                If frm.SpanalisisCobranzasBindingSource.Filter = "" Then
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + "Dias > 45 and Dias <= 60"
                Else
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + " and Dias > 45 and Dias <= 60"
                End If



            ElseIf DGV_FactVencidas.CurrentCell.ColumnIndex = 4 Then

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.tb_vendedor.Items.Count - 1

                    '    If frm.tb_vendedor.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                End If

                'For cont As Integer = 0 To frm.DGV_Facturas.RowCount - 1

                '    If CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) < 60 Then

                '        frm.DGV_Facturas.Rows(cont).Visible = False

                '    End If

                'Next
                If frm.SpanalisisCobranzasBindingSource.Filter = "" Then
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + "Dias > 60 and Dias <= 90"
                Else
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + " and Dias > 60 and Dias <= 90"
                End If


            Else

                If DGV_Vendedores.SelectedRows.Count = 1 Then

                    'For cont As Integer = 0 To frm.tb_vendedor.Items.Count - 1

                    '    If frm.tb_vendedor.Items.Item(cont).Code.ToString = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString Then

                    '        frm.tb_vendedor.SelectedIndex = cont

                    '    End If

                    'Next

                    frm.ch_vendedor.Checked = True
                    frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
                    frm.ListBox2.SelectedValue = DGV_Vendedores.SelectedRows(0).Cells(0).Value.ToString
                    frm.ListBox2_KeyDown(frm.ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                End If

                'For cont As Integer = 0 To frm.DGV_Facturas.RowCount - 1

                '    If CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) < 45 Or CInt(frm.DGV_Facturas.Rows(cont).Cells(6).Value) >= 60 Then

                '        frm.DGV_Facturas.Rows(cont).Visible = False

                '    End If

                'Next
                If frm.SpanalisisCobranzasBindingSource.Filter = "" Then
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + "Dias > 90"
                Else
                    frm.SpanalisisCobranzasBindingSource.Filter = frm.SpanalisisCobranzasBindingSource.Filter + " and Dias > 90"
                End If


            End If

            frm.DGV_Facturas.ClearSelection()

            frm.lb_totalP.Text = Format(CDbl(DGV_FactVencidas.Rows(1).Cells(DGV_FactVencidas.CurrentCell.ColumnIndex).Value), "#,##0.00")

            Dim Count As Object
            Count = frm.MELDataSet.sp_analisisCobranzas.Compute("COUNT(montoPendiente)", frm.SpanalisisCobranzasBindingSource.Filter)
            frm.lbl_totalFact.Text = Count.ToString

            frm.Show()

        End If

    End Sub

    Private Sub DGV_FactVencidas_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_FactVencidas.ColumnHeaderMouseClick
        If DGV_FactVencidas.SelectedRows.Count > 0 Then

            For cont As Integer = 1 To DGV_Vendedores.ColumnCount - 1

                UserControl41.Chart1.Series("Series1").Points(DGV_Vendedores.Columns(cont - 1).Index)("Exploded") = "false"
            Next

        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        For cont2 As Integer = 0 To DGV_Vendedores.RowCount - 1

            UserControl31.Chart1.Series("Series1").Points(DGV_Vendedores.Rows(cont2).Index)("Exploded") = "false"

        Next

        DatosDSS.consultaFacturasVencidas(DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
        DatosDSS.CosultaFactCobradas(UserControl41.Chart1, DGV_FactVencidas, 0, DateTimePicker5.Value, DateTimePicker6.Value, 0)
        'GraficoCircularDiasCobro(UserControl41.Chart1, DGV_FactVencidas)

        'For cont As Integer = 1 To DGV_Vendedores.ColumnCount - 1

        '    UserControl41.Chart1.Series("Series1").Points(DGV_Vendedores.Columns(cont - 1).Index)("Exploded") = "false"
        'Next

        DGV_Vendedores.ClearSelection()
        DGV_FactVencidas.ClearSelection()

    End Sub

    Private Sub DGV_Vendedores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Vendedores.CellDoubleClick

        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then

            Dim frm As New Frm_relacionVentas
            frm.Show()
            frm.chk_fecha.Checked = True
            frm.DTP1.Value = DateTimePicker5.Value
            frm.DTP2.Value = DateTimePicker6.Value
            frm.rb_vend.Checked = True
            frm.txt_finalVend.Text = DGV_Vendedores.SelectedRows(0).Cells(1).Value.ToString
            frm.CrearWhere()
            frm.TopMost = True

        End If

    End Sub

    Private Sub DGV_Semaforo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Semaforo.CellClick
        If DGV_Semaforo.SelectedRows.Count > 0 Then

            DGV_DatosSemaforo.ClearSelection()
            DGV_DatosSemaforo.Rows(DGV_Semaforo.SelectedRows(0).Index).Selected = True
            DGV_DatosSemaforo.FirstDisplayedScrollingRowIndex = DGV_DatosSemaforo.SelectedRows(0).Index

        End If
    End Sub

    Private Sub DGV_DatosSemaforo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_DatosSemaforo.CellClick
        If DGV_DatosSemaforo.SelectedRows.Count > 0 Then

            DGV_Semaforo.ClearSelection()
            DGV_Semaforo.Rows(DGV_DatosSemaforo.SelectedRows(0).Index).Selected = True
            DGV_Semaforo.FirstDisplayedScrollingRowIndex = DGV_Semaforo.SelectedRows(0).Index

        End If
    End Sub

    Private Sub DGV_DatosSemaforo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_DatosSemaforo.CellDoubleClick

        If DGV_DatosSemaforo.SelectedRows.Count > 0 Then

            If e.ColumnIndex = 1 Then

                Dim frm As New Frm_relacionVentas
                frm.Show()
                frm.rb_vend.Checked = True
                frm.txt_finalVend.Text = DGV_DatosSemaforo.SelectedRows(0).Cells(0).Value.ToString
                frm.chk_fecha.Checked = True
                frm.DTP1.Value = DateTimePicker1.Value
                frm.DTP2.Value = DateTimePicker2.Value
                frm.TopMost = True


            ElseIf e.ColumnIndex = 2 Then

                Dim frm As New Frm_relacionVentas
                frm.Show()
                frm.chk_fecha.Checked = True
                frm.DTP1.Value = DateTimePicker3.Value
                frm.DTP2.Value = DateTimePicker4.Value
                frm.rb_vend.Checked = True
                frm.txt_finalVend.Text = DGV_DatosSemaforo.SelectedRows(0).Cells(0).Value.ToString
                frm.CrearWhere()
                frm.TopMost = True

            End If

        End If

    End Sub


    '------------------------------------------------------ COMBO VENDEDOR ------------------------------------------------------'

    Private Sub txt_final_TextChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.TextChanged
        If Me.ListBox2.Visible = True Then
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & txt_finalVend.Text & "%'"
        End If
    End Sub
    Private Sub txt_final_KeyDown2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_finalVend.KeyDown

        If e.KeyData = Keys.Down Then
            Me.ListBox2.Visible = True
            Me.ListBox2.Focus()

            If Me.ListBox2.Items.Count > 1 Then
                Me.ListBox2.SelectedIndex = 1
            End If

        ElseIf e.KeyData = Keys.Enter And Me.ListBox2.Visible Then

            Me.ListBox2.Visible = False
            If Me.ListBox2.Items.Count > 0 Then
                Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
                Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
                Me.Label2.Text = Me.ListBox2.SelectedValue
                Me.ListBox2.SelectedIndex = 0
            Else
                Me.txt_finalVend.Text = ""
            End If

            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length

        End If
    End Sub
    Private Sub txt_final_KeyPress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_finalVend.KeyPress
        Me.ListBox2.Visible = True
    End Sub
    Private Sub txt_final_Focus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.GotFocus
        If Me.txt_finalVend.Text = "          --- Escriba Vendedor ---" Then
            Me.txt_finalVend.Text = ""
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & Me.txt_finalVend.Text & "%'"
            Me.ListBox2.Visible = True
            ListBox2.BringToFront()
        End If
    End Sub
    Public Sub ListBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyData = Keys.Up And Me.ListBox2.SelectedIndex = 0 Then
            Me.txt_finalVend.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            Me.ListBox2.Visible = False
            Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
            Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
            Me.Label2.Text = Me.ListBox2.SelectedValue
            Me.ListBox2.SelectedIndex = 0
            Me.txt_finalVend.Focus()
            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
        End If
    End Sub
    Private Sub ListBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Me.ListBox2.Visible = False
        Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
        Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
        Me.Label2.Text = Me.ListBox2.SelectedValue
        Me.ListBox2.SelectedIndex = 0
        Me.txt_finalVend.Focus()
        Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txt_finalVend.Text <> "" And Me.txt_finalVend.Text <> "          --- Escriba Vendedor ---" And ListBox2.SelectedIndex <> -1 Then

            If DateTimePicker7.Value <= DateTimePicker8.Value Then

                DGV_MesesVend.Columns(0).Visible = True
                DGV_MesesVend.Columns(1).Visible = True

                Dim cont2 As Integer = DGV_MesesVend.Columns.Count - 1
                Dim mes As Integer = 0
                Dim ano As Integer = 0

                While DGV_MesesVend.Columns.Count - 1 > 1

                    DGV_MesesVend.Columns.RemoveAt(cont2)
                    cont2 = cont2 - 1

                End While

                mes = Month(DateTimePicker7.Value)
                ano = Year(DateTimePicker7.Value)

                For cont As Integer = 0 To DateDiff(DateInterval.Month, DateTimePicker7.Value, DateTimePicker8.Value) + 1

                    If cont < DateDiff(DateInterval.Month, DateTimePicker7.Value, DateTimePicker8.Value) + 1 Then

                        DGV_MesesVend.Columns.Add("ColumnaF" & cont.ToString, "F")
                        DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).Width = 22
                        DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                        If mes.ToString.Length = 1 Then
                            DGV_MesesVend.Columns.Add("Columna" & cont.ToString, ("0" & mes.ToString).Substring(0, 2) & " / " & ano.ToString)
                        Else
                            DGV_MesesVend.Columns.Add("Columna" & cont.ToString, (mes.ToString).Substring(0, 2) & " / " & ano.ToString)
                        End If

                        DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).Width = 79

                    Else

                        DGV_MesesVend.Columns.Add("Columna" & cont.ToString, "Total")

                    End If


                    mes = mes + 1

                    If mes > 12 Then
                        mes = mes - 12
                        ano = ano + 1
                    End If

                Next

                DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).DefaultCellStyle.Format = "N2"
                DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DatosDSS.DGV_Eficacia(DGV_MesesVend, DateTimePicker7.Value.ToShortDateString, DateTimePicker8.Value.ToShortDateString, CInt(txt_finalVend.Tag), lbl_totalVentas1.Text, lbl_TotalFact.Text, ProgressBar1)
                DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1).Width = 90
                lbl_TotalClient.Text = DGV_MesesVend.RowCount
                DGV_MesesVend.Sort(DGV_MesesVend.Columns(DGV_MesesVend.ColumnCount - 1), System.ComponentModel.ListSortDirection.Descending)
                lbl_mes1.Text = "0,00"
                lbl_mes2.Text = "0,00"
                lbl_mes3.Text = "0,00"
                lbl_mes4.Text = "0,00"
                lbl_mes5.Text = "0,00"
                lbl_mes6.Text = "0,00"

                For fila As Integer = 0 To DGV_MesesVend.RowCount - 1

                    lbl_mes1.Text = CDbl(lbl_mes1.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(3).Value)

                    If DGV_MesesVend.ColumnCount - 1 > 4 Then
                        lbl_mes2.Text = CDbl(lbl_mes2.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(5).Value)
                        Panel32.Visible = True
                    Else
                        Panel32.Visible = False
                    End If
                    If DGV_MesesVend.ColumnCount - 1 > 6 Then
                        lbl_mes3.Text = CDbl(lbl_mes3.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(7).Value)
                        Panel33.Visible = True
                    Else
                        Panel33.Visible = False
                    End If
                    If DGV_MesesVend.ColumnCount - 1 > 8 Then
                        lbl_mes4.Text = CDbl(lbl_mes4.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(9).Value)
                        Panel34.Visible = True
                    Else
                        Panel34.Visible = False
                    End If
                    If DGV_MesesVend.ColumnCount - 1 > 10 Then
                        lbl_mes5.Text = CDbl(lbl_mes5.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(11).Value)
                        Panel36.Visible = True
                    Else
                        Panel36.Visible = False
                    End If
                    If DGV_MesesVend.ColumnCount - 1 > 12 Then
                        lbl_mes6.Text = CDbl(lbl_mes6.Text) + CDbl(DGV_MesesVend.Rows(fila).Cells(13).Value)
                        Panel35.Visible = True
                    Else
                        Panel35.Visible = False
                    End If

                Next

                lbl_mes1.Text = Format(CDbl(lbl_mes1.Text), "#,##0.00")
                lbl_mes2.Text = Format(CDbl(lbl_mes2.Text), "#,##0.00")
                lbl_mes3.Text = Format(CDbl(lbl_mes3.Text), "#,##0.00")
                lbl_mes4.Text = Format(CDbl(lbl_mes4.Text), "#,##0.00")
                lbl_mes5.Text = Format(CDbl(lbl_mes5.Text), "#,##0.00")
                lbl_mes6.Text = Format(CDbl(lbl_mes6.Text), "#,##0.00")

                ProgressBar1.Visible = False
                DGV_MesesVend.ClearSelection()

            Else

                MsgBox("Período no válido", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar un vendedor", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub ProgressBar1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.VisibleChanged

        If ProgressBar1.Visible Then
            Label50.Visible = True
        Else
            Label50.Visible = False
        End If


    End Sub

    Private Sub DGV_MesesVend_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_MesesVend.CellDoubleClick
        If DGV_MesesVend.SelectedRows.Count > 0 Then

            If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Then

                Dim frm As New Frm_Clientes
                frm.Show()
                frm.DomainUpDown1.SelectedIndex = 1
                frm.tb_buscarcodigo.Text = DGV_MesesVend.SelectedRows(0).Cells(1).Value
                frm.tb_buscarcodigo.ReadOnly = True
                frm.DataGridViewRazon.Rows(0).Cells(1).Selected = True
                frm.DataGridViewRazon_SelectionChanged(frm.DataGridViewRazon, New EventArgs)

            ElseIf e.ColumnIndex Mod 2 <> 0 Then


                Dim frm As New Frm_relacionVentas
                frm.Show()
                frm.rb_vend.Checked = True
                frm.rb_client.Checked = True
                frm.cb_client.Text = DGV_MesesVend.SelectedRows(0).Cells(1).Value
                frm.chk_fecha.Checked = True

                If e.ColumnIndex = 3 Then
                    frm.DTP1.Value = DateTimePicker7.Value
                Else
                    frm.DTP1.Value = "01/" & DGV_MesesVend.Columns(e.ColumnIndex).HeaderText.Trim
                End If

                If e.ColumnIndex = DGV_MesesVend.ColumnCount - 2 Then
                    frm.DTP2.Value = DateTimePicker8.Value
                Else
                    frm.DTP2.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate("01/" & DGV_MesesVend.Columns(e.ColumnIndex).HeaderText.Trim)))
                End If


                frm.TopMost = True

            ElseIf Not e.ColumnIndex = DGV_MesesVend.ColumnCount - 1 Then

                Dim frm As New Frm_relacionVentas
                frm.Show()
                frm.rb_vend.Checked = True
                frm.rb_client.Checked = True
                frm.cb_client.Text = DGV_MesesVend.SelectedRows(0).Cells(1).Value
                frm.chk_fecha.Checked = True

                If e.ColumnIndex = 2 Then
                    frm.DTP1.Value = DateTimePicker7.Value
                Else
                    frm.DTP1.Value = "01/" & DGV_MesesVend.Columns(e.ColumnIndex + 1).HeaderText.Trim
                End If

                If e.ColumnIndex = DGV_MesesVend.ColumnCount - 3 Then
                    frm.DTP2.Value = DateTimePicker8.Value
                Else
                    frm.DTP2.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate("01/" & DGV_MesesVend.Columns(e.ColumnIndex + 1).HeaderText.Trim)))
                End If

                frm.TopMost = True

            Else

                Dim frm As New Frm_relacionVentas
                frm.Show()
                frm.rb_vend.Checked = True
                frm.rb_client.Checked = True
                frm.cb_client.Text = DGV_MesesVend.SelectedRows(0).Cells(1).Value
                frm.chk_fecha.Checked = True

                frm.DTP1.Value = DateTimePicker7.Value
                frm.DTP2.Value = DateTimePicker8.Value

                frm.TopMost = True


            End If

        End If
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click

        If DGV_MesesVend.RowCount > 0 Then

            Dim frm As New R_Eficacia
            frm.recibe(DateTimePicker7.Value, DateTimePicker8.Value, lbl_totalVentas1.Text, lbl_TotalFact.Text, lbl_TotalClient.Text, txt_finalVend.Text, DGV_MesesVend)
            frm.Show()

        Else

            MsgBox("La lista está vacía", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

End Class