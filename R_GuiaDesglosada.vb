Public Class R_GuiaDesglosada
    Private dgv As DataGridView

    Public Sub valores(ByVal dg As DataGridView)
        dgv = dg
    End Sub

    Private Sub R_GuiaDesglosada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        Dim i As Integer = 0
        While i <= Me.dgv.Rows.Count - 1
            Me.MELDataSet.Table_GuiaDesglosada.Rows.Add(Me.dgv(4, i).Value, Me.dgv(8, i).Value(), Me.dgv(10, i).Value, Me.dgv(7, i).Value, Me.dgv(9, i).Value, Me.dgv(2, i).Value, Me.dgv(5, i).Value, CDbl(Me.dgv(6, i).Value), CInt(Me.dgv(12, i).Value))
            i = i + 1
        End While
        Me.ReportViewer1.RefreshReport()
        MELDataSet.EnforceConstraints = True
    End Sub
End Class