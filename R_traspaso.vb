Public Class R_traspaso

    Private Sub R_traspaso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_R_traspasos' Puede moverla o quitarla según sea necesario.
        Me.Sp_R_traspasosTableAdapter.Fill(Me.MELDataSet.sp_R_traspasos)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Console.WriteLine(Me.ReportViewer1.Margin.All)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
    End Sub
End Class