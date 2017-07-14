Imports System.Math

Public Class Frm_AnalisisDecision

    Dim Estado As String = ""
    Dim Ventas As String = ""
    Dim clientes As String = ""


    Private Sub Frm_DecisionZonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaLogo(PictureBox3)
        Label3.Text = ""
        Label2.Text = ""
        TextBox1.Focus()

    End Sub

    Public Sub recibe(ByVal est As String, ByVal client As String, ByVal vent As String)

        Estado = est
        Ventas = vent
        clientes = client

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            If TextBox1.Text <> "" Then

                If CInt(TextBox1.Text) > 1 Then

                    DGV_Apoyo.Rows.Clear()

                    For cont As Integer = 0 To CInt(TextBox1.Text) - 1

                        DGV_Apoyo.Rows.Add("Alternativa " + CStr(cont + 1), "", "", "", "", "", 0, 0, 0, 0, 0, 0, 0)

                    Next

                    DGV_Apoyo.ClearSelection()
                    GroupBox2.Visible = False
                    TextBox2.Focus()

                Else

                    MsgBox("Este parámetro de ser mayor a 1", MsgBoxStyle.Critical, "Error")
                    TextBox1.Clear()
                    TextBox1.Focus()

                End If

            Else

                MsgBox("No puede dejar vació este parámetro", MsgBoxStyle.Critical, "Error")
                TextBox1.Focus()

            End If

        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown

        If e.KeyCode = Keys.Enter Then

            If TextBox2.Text <> "" Then

                If CDbl(TextBox2.Text) <= 1 And CDbl(TextBox2.Text) >= 0 Then

                    GroupBox2.Visible = False
                    DGV_Apoyo(0, 0).Selected = True
                    DGV_Apoyo.BeginEdit(True)

                Else

                    MsgBox("Este parámetro de estar entre 0 y 1", MsgBoxStyle.Critical, "Error")
                    TextBox2.Clear()
                    TextBox2.Focus()

                End If

            Else

                MsgBox("No puede dejar vació este parámetro", MsgBoxStyle.Critical, "Error")
                TextBox2.Focus()

            End If

        End If

    End Sub

    Private Sub bt_evaluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluar.Click

        Try

            If TextBox1.Text <> "" Then

                If TextBox2.Text <> "" Then

                    Dim max As Integer = DGV_Apoyo(1, 0).Value
                    Dim Min As Integer = DGV_Apoyo(1, 0).Value

                    For i As Integer = 0 To DGV_Apoyo.RowCount - 1

                        max = DGV_Apoyo(1, i).Value
                        Min = DGV_Apoyo(1, i).Value

                        For j As Integer = 1 To DGV_Apoyo.ColumnCount - 4

                            If j < DGV_Apoyo.ColumnCount - 7 Then

                                If Min > CDbl(DGV_Apoyo(j, i).Value) Then

                                    Min = CDbl(DGV_Apoyo(j, i).Value)

                                End If

                                If max < CDbl(DGV_Apoyo(j, i).Value) Then

                                    max = CDbl(DGV_Apoyo(j, i).Value)

                                End If

                                DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value = CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value) + CDbl(DGV_Apoyo(j, i).Value)

                            ElseIf j = DGV_Apoyo.ColumnCount - 5 Then

                                DGV_Apoyo(j, i).Value = CDbl(DGV_Apoyo(j, i).Value)

                            ElseIf j = DGV_Apoyo.ColumnCount - 6 Then

                                DGV_Apoyo(j, i).Value = max

                            ElseIf j = DGV_Apoyo.ColumnCount - 7 Then

                                DGV_Apoyo(j, i).Value = Min

                            End If

                            DGV_Apoyo(DGV_Apoyo.ColumnCount - 5, i).Value = (max * CDbl(TextBox2.Text)) + (Min * (1 - CDbl(TextBox2.Text)))

                        Next


                        DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value = CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value) / ((DGV_Apoyo.ColumnCount - 3) - (DGV_Apoyo.ColumnCount - 8))

                        DGV_Apoyo(DGV_Apoyo.ColumnCount - 3, i).Value = max - Min

                        DGV_Apoyo(DGV_Apoyo.ColumnCount - 2, i).Value = CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value) + ((CDbl(TextBox2.Text) * CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value)) - ((1 - CDbl(TextBox2.Text)) * CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 3, i).Value)))

                        DGV_Apoyo(DGV_Apoyo.ColumnCount - 1, i).Value = CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value) + ((CDbl(TextBox2.Text) * CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 4, i).Value)) + ((1 - CDbl(TextBox2.Text)) * CDbl(DGV_Apoyo(DGV_Apoyo.ColumnCount - 3, i).Value)))

                    Next



                    '--------------------------------------- SAVAGE ----------------------------------'

                    Dim Arrepentimientos(CInt(TextBox1.Text) - 1, 5) As Double
                    Dim pos5 As Double = 0
                    Dim maxx As Double = 0
                    max = DGV_Apoyo(1, 0).Value

                    For i2 As Integer = 1 To DGV_Apoyo.ColumnCount - 8

                        max = DGV_Apoyo(i2, 0).Value

                        For j2 As Integer = 0 To DGV_Apoyo.RowCount - 1

                            If max < CDbl(DGV_Apoyo(i2, j2).Value) Then

                                max = CDbl(DGV_Apoyo(i2, j2).Value)

                            End If

                        Next

                        For k As Integer = 0 To DGV_Apoyo.RowCount - 1

                            Arrepentimientos(k, i2) = Math.Abs(CDbl(DGV_Apoyo(i2, k).Value) - max)
                            'maxx = Arrepentimientos(i2, k)

                        Next

                    Next

                    For i3 As Integer = 0 To CInt(TextBox1.Text) - 1

                        maxx = Arrepentimientos(i3, 0)

                        For j3 As Integer = 0 To 4

                            If maxx < Arrepentimientos(i3, j3) Then

                                maxx = Arrepentimientos(i3, j3)

                            End If

                        Next

                        Arrepentimientos(i3, 5) = maxx

                    Next

                    Dim minArrep As Double = Arrepentimientos(0, 5)

                    For k As Integer = 0 To DGV_Apoyo.RowCount - 1

                        If minArrep > Arrepentimientos(k, 5) Then
                            minArrep = Arrepentimientos(k, 5)
                            pos5 = k
                        End If

                    Next


                    '---------------------------------------- SAVAGE ----------------------------------'


                    Dim max2 As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 5).Value)
                    Dim pos As Integer = 0

                    Dim max3 As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 4).Value)
                    Dim pos2 As Double = 0

                    Dim MaxMax As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 6).Value)
                    Dim pos3 As Double = 0

                    Dim maxMin As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 7).Value)
                    Dim pos4 As Double = 0

                    Dim EMax As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 2).Value)
                    Dim pos6 As Double = 0

                    Dim EMin As Double = CDbl(DGV_Apoyo.Rows(0).Cells(DGV_Apoyo.ColumnCount - 1).Value)
                    Dim pos7 As Double = 0

                    For i As Integer = 0 To DGV_Apoyo.RowCount - 1

                        If max2 < CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 5).Value) Then

                            pos = i
                            max2 = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 5).Value)

                        End If

                        If max3 < CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 4).Value) Then

                            pos2 = i
                            max3 = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 4).Value)

                        End If

                        If MaxMax < CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 6).Value) Then

                            pos3 = i
                            MaxMax = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 6).Value)

                        End If

                        If maxMin < CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 7).Value) Then

                            pos4 = i
                            maxMin = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 7).Value)

                        End If

                        If EMax < CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 2).Value) Then

                            pos6 = i
                            EMax = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 2).Value)

                        End If

                        If EMin > CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 1).Value) Then

                            pos7 = i
                            EMin = CDbl(DGV_Apoyo.Rows(i).Cells(DGV_Apoyo.ColumnCount - 1).Value)

                        End If

                    Next

                    DGV_Apoyo.Columns(DGV_Apoyo.ColumnCount - 6).Visible = True
                    DGV_Apoyo.Columns(DGV_Apoyo.ColumnCount - 5).Visible = True
                    DGV_Apoyo.Columns(DGV_Apoyo.ColumnCount - 4).Visible = True

                    Label3.Text = "Opción recomendada (Método de Hurwicz): " + CStr(DGV_Apoyo.Rows(pos).Cells(0).Value)
                    Label2.Text = "Opción recomendada (Método de Laplace): " + CStr(DGV_Apoyo.Rows(pos2).Cells(0).Value)
                    Label8.Text = "Opción recomendada (Método de MaxiMax): " + CStr(DGV_Apoyo.Rows(pos3).Cells(0).Value)
                    Label9.Text = "Opción recomendada (Método de Wald): " + CStr(DGV_Apoyo.Rows(pos4).Cells(0).Value)
                    Label10.Text = "Opción recomendada (Método de Savage): " + CStr(DGV_Apoyo.Rows(pos5).Cells(0).Value)
                    Label12.Text = "Opción recomendada (Método de EMA: Maximización): " + CStr(DGV_Apoyo.Rows(pos6).Cells(0).Value)
                    Label11.Text = "Opción recomendada (Método de EMA: Minimización): " + CStr(DGV_Apoyo.Rows(pos7).Cells(0).Value)

                    GroupBox2.Visible = True

                Else

                    MsgBox("El parámetro 'α' es obligatorio para este cálculo, favor llenar", MsgBoxStyle.Critical, "Error")

                End If

            Else

                MsgBox("Debe introducir el número de alternativas", MsgBoxStyle.Critical, "Error")

            End If

        Catch ex As Exception

            MsgBox("No pueden haber pagos vaciós, favor revisar", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = ","c Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        GroupBox2.Visible = False

        If Me.DGV_Apoyo.CurrentCell.ColumnIndex = 1 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 2 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 3 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 4 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 5 Then

            If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "-") OrElse e.KeyChar = "," And (Not e.KeyChar = ".") Then
                e.Handled = False
            Else
                e.Handled = True

            End If

        End If

    End Sub

    Private Sub DGV_Apoyo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Apoyo.CellEndEdit

        Try

            If Me.DGV_Apoyo.CurrentCell.ColumnIndex = 1 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 2 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 3 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 4 Or Me.DGV_Apoyo.CurrentCell.ColumnIndex = 5 Then

                If DGV_Apoyo.CurrentCell.Value <> "" Then

                    DGV_Apoyo.CurrentCell.Value = Format(CDbl(DGV_Apoyo.CurrentCell.Value), "#,##0.00")

                Else

                    DGV_Apoyo.CurrentCell.Value = Format(0, "#,##0.00")

                End If

            End If

        Catch ex As Exception

            MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Exclamation, "Error")
            DGV_Apoyo.CurrentCell.Value = Format(0, "#,##0.00")

        End Try

    End Sub

    Private Sub Dgv_Apoyo_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Apoyo.EditingControlShowing
        Dim txt As TextBox = TryCast(e.Control, TextBox)
        If txt IsNot Nothing Then
            RemoveHandler txt.KeyPress, AddressOf CellKeyPress
            AddHandler txt.KeyPress, AddressOf CellKeyPress
        End If
    End Sub

End Class