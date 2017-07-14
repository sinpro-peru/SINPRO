Public Class Frm_DesglosarMov

    Dim sel As Boolean = False
    Public Mov As String = ""
    Public Banco As String = ""
    Public CodBanco As Integer = 0
    Public FechaMov As Date
    Public Oficina As String = ""
    Public desc As String = ""
    Public Monto As String = ""
    Public frm As Frm_Consulta_Movimientos

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If lbl_total.Text = lbl_monto.Text Then

            DatosMovimientos.elimina_movimiento(lbl_mov.Text)

            Dim index As Integer = frm.dgv_movimientos.SelectedRows(0).Index

            For cont As Integer = 0 To DGV_Desglose.RowCount - 1

                DatosMovimientos.Inserta_movimiento(Mov & "-" & (cont + 1).ToString, DatosMovimientos.Consulta_Cod_Banco(Banco), _
                                                    desc, DGV_Desglose.Rows(cont).Cells(1).Value, "", Oficina, FechaMov, 0)

            Next

            DatosMovimientos.Consulta_Movimientos(0, frm.dgv_movimientos, "", Today, Today, frm.lbl_TotalEgresos.Text, frm.lb_totalIngresos.Text)

            frm.dgv_movimientos.Rows(index).Cells(0).Selected = True
            frm.dgv_movimientos.FirstDisplayedScrollingRowIndex = index

            Me.Close()

        Else

            MsgBox("Los montos no concuerdan", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub Frm_DesglosarMov_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frm.Enabled = True
        frm.dgv_movimientos.Focus()
        frm.dgv_movimientos.Select()
        frm.dgv_movimientos.SelectedRows(0).Cells(0).Selected = True

    End Sub

    Private Sub Frm_DesglosarMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.Size = New System.Drawing.Size(289, 240)
        Me.GroupBox3.Visible = False
        Me.bt_cancelar.Location = New System.Drawing.Point(149, 160)
        Me.bt_aceptar.Location = New System.Drawing.Point(34, 160)
        Me.lbl_banco.Text = Banco
        Me.lbl_mov.Text = Mov
        Me.lbl_monto.Text = Format(CDbl(Monto), "#,##0.00")

    End Sub

    Private Sub tb_cantDesglose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantDesglose.KeyDown
        If e.KeyCode = Keys.Enter Then

            If tb_cantDesglose.Text <> "" And tb_cantDesglose.Text > 1 Then

                Me.DGV_Desglose.Rows.Clear()
                Me.Size = New System.Drawing.Size(289, 428)
                Me.bt_cancelar.Location = New System.Drawing.Point(149, 354)
                Me.bt_aceptar.Location = New System.Drawing.Point(34, 354)
                Me.GroupBox3.Visible = True
                lbl_total.Text = "0,00"

                For cont As Integer = 1 To CInt(tb_cantDesglose.Text)

                    DGV_Desglose.Rows.Add("Monto " & (cont).ToString, "0,00")

                Next

                DGV_Desglose.Focus()
                DGV_Desglose.Rows(0).Selected = True
                DGV_Desglose_CellClick(DGV_Desglose, New DataGridViewCellEventArgs(1, 0))

            Else

                MsgBox("Introduzca una cantidad válida", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        End If

    End Sub

    Private Sub DGV_Desglose_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Desglose.CellClick

        Try

            If DGV_Desglose.SelectedRows.Count > 0 Then

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(1, e.RowIndex)
                Me.DGV_Desglose.BeginEdit(True)

            End If

        Catch ex As Exception

            MsgBox("Error", MsgBoxStyle.Critical, "SINPRO")

        End Try

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ","c Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Desglose.EditingControlShowing

        If Me.DGV_Desglose.CurrentCell.ColumnIndex = 1 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        End If

    End Sub

    Private Sub DGV_Desglose_Parsing(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Desglose.CellParsing

        Try

            DGV_Desglose.CurrentCell.Value = DGV_Desglose.CurrentCell.Value.ToString.Replace(".", ",")

            If IsNumeric(DGV_Desglose.CurrentCell.Value) Then

                If CDbl(DGV_Desglose.CurrentCell.Value) > 0 Then

                    DGV_Desglose.CurrentCell.Value = Format(CDbl(DGV_Desglose.CurrentCell.Value), "#,##0.00")

                Else

                    Me.DGV_Desglose.CurrentCell.Value = "0,00"

                End If
            Else

                Me.DGV_Desglose.CurrentCell.Value = "0,00"
                'Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex - 1)
                'Me.DGV_Desglose.BeginEdit(True)

            End If

            sel = True

        Catch ex As Exception


        End Try

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub DGV_Desglose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Desglose.KeyDown

        If e.KeyCode = Keys.Enter Then

            If DGV_Desglose.CurrentCell.RowIndex = DGV_Desglose.RowCount - 1 Then

                bt_aceptar.Focus()

            Else

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex + 1)
                Me.DGV_Desglose.BeginEdit(True)

            End If

        ElseIf e.KeyCode = Keys.Down Then

            If Not DGV_Desglose.CurrentCell.RowIndex = DGV_Desglose.RowCount - 1 Then

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex + 1)

            Else

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(1, DGV_Desglose.RowCount - 1)

            End If

            DGV_Desglose_CellClick(DGV_Desglose, New DataGridViewCellEventArgs(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex))

        ElseIf e.KeyCode = Keys.Up Then

            If Not DGV_Desglose.CurrentCell.RowIndex = 0 Then

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex - 1)

            Else

                Me.DGV_Desglose.CurrentCell = Me.DGV_Desglose(1, 0)

            End If

            DGV_Desglose_CellClick(DGV_Desglose, New DataGridViewCellEventArgs(DGV_Desglose.CurrentCell.ColumnIndex, DGV_Desglose.CurrentCell.RowIndex))

        End If

    End Sub

    Private Sub DGV_Desglose_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Desglose.SelectionChanged

        If sel = True Then

            If Not DGV_Desglose.CurrentRow Is Nothing Then
                sel = False
                DGV_Desglose.CurrentCell = DGV_Desglose.Rows(DGV_Desglose.CurrentRow.Index).Cells(1)
                DGV_Desglose.BeginEdit(True)
            End If

        End If

    End Sub

    Private Sub DGV_Desglose_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Desglose.CellEndEdit

        Try

            If IsNumeric(DGV_Desglose.CurrentCell.Value) Then
                DGV_Desglose.CurrentCell.Value = DGV_Desglose.CurrentCell.Value.ToString.Replace(".", ",")
                DGV_Desglose.CurrentCell.Value = Format(CDbl(DGV_Desglose.CurrentCell.Value), "#,##0.00")
            End If


            lbl_total.Text = "0,00"

            For cont As Integer = 0 To DGV_Desglose.RowCount - 1

                lbl_total.Text = Format(CDbl(lbl_total.Text) + CDbl(DGV_Desglose.Rows(cont).Cells(1).Value), "#,##0.00")

            Next

        Catch ex As Exception

            MsgBox("Introduzca un valor correcto", MsgBoxStyle.Critical, "Error")
            DGV_Desglose.CurrentCell.Value = "0,00"

        End Try

    End Sub
End Class