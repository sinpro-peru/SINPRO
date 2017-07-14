Public Class R_Variacion

    Dim dgv As New DataGridView
    Dim total As Integer = 0
    Dim variacion As Double = 0

    Private Sub R_Variacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)


        Dim i As Integer = 0

        While i <= dgv.Rows.Count - 1

            MELDataSet.Table_Productos_Variacion.Rows.Add(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value, dgv.Rows(i).Cells(6).Value, dgv.Rows(i).Cells(5).Value)

            i = i + 1

        End While

        Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams1(0) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Variacion", variacion)
        misParams1(0) = New Microsoft.Reporting.WinForms.ReportParameter("Total", total)
        Me.ReportViewer1.LocalReport.SetParameters(misParams)

        Me.ReportViewer1.LocalReport.SetParameters(misParams1)

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()

    End Sub

    Public Sub recibe(ByVal dgv2 As DataGridView, ByVal Total2 As Integer, ByVal Variacion2 As Double)

        dgv = dgv2
        total = Total2
        variacion = Variacion2

    End Sub
End Class