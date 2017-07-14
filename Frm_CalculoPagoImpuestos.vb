Public Class Frm_CalculoPagoImpuestos

    Private CodigoPedido As Integer = 0
    Private TotalFact As String = ""
    Private FleteYSeguro As String = ""
    Private TasaCambioArancel As String = ""
    Private Iva As String = ""

    Private Sub Frm_CalculoPagoImpuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DatosCalculoCostos.Dgv_Impuestos(DGV_Productos, CodigoPedido, CDbl(TasaCambioArancel), CDbl(Iva), lbl_TotalADV.Text, lbl_TotalTSA.Text, lbl_TotalTSS.Text, lbl_TotalIva.Text, CDbl(TotalFact), CDbl(FleteYSeguro))
        lbl_TotalFact.Text = TotalFact
        lbl_fleteySeg.Text = FleteYSeguro

        lbl_TotalPed.Text = Format(CDbl(TotalFact) + CDbl(FleteYSeguro), "#,##0.00")

    End Sub

    Public Sub Recibe(ByVal CodP As Integer, ByVal TF As String, ByVal FYS As String, ByVal TC As String)

        CodigoPedido = CodP
        TotalFact = TF
        FleteYSeguro = Format(CDbl(FYS), "#,##0.00")
        TasaCambioArancel = TC
        DatosConfiguracion.tb_iva(Iva)

    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
        Me.Close()
    End Sub

    Private Sub DGV_Futuros_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGV_Productos.CellPainting

        If e.RowIndex <> -1 And e.RowIndex <= DGV_Productos.RowCount - 1 Then

            If (DGV_Productos.Rows(e.RowIndex).Cells(1).Value.ToString = "" And DGV_Productos.Rows(e.RowIndex).Cells(2).Value.ToString = "" And DGV_Productos.Rows(e.RowIndex).Cells(3).Value.ToString = "") AndAlso (e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3) Then

                Using gridBrush As Brush = New SolidBrush(Me.DGV_Productos.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)

                        ' Clear cell 
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
                        'Bottom line drawing
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        'top line drawing
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top)
                        'Drawing Right line
                        If e.ColumnIndex = 3 Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
                        End If
                        'Inserting text
                        If e.ColumnIndex = 0 Then
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.White, e.CellBounds.X - (e.CellBounds.X / 2), e.CellBounds.Y + 3)
                        End If

                        e.Handled = True

                    End Using

                End Using

            End If

        End If

    End Sub

End Class