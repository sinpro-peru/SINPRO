Public Class R_FacturasPagadas
    Private f1 As String
    Private f2 As String

    Public Sub valores_FacturasPagadas(ByVal fe1 As String, ByVal fe2 As String)
        f1 = fe1
        f2 = fe2
    End Sub

    Private Sub R_FacturasPagadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaFacturasPagadas' Puede moverla o quitarla según sea necesario.
        Me.MELDataSet.EnforceConstraints = False
        Me.sp_consultaFacturasPagadasTableAdapter.Fill(Me.MELDataSet.sp_consultaFacturasPagadas, f1, f2)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class