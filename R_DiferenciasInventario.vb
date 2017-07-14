Public Class R_DiferenciasInventario

    Public CodI As Integer
    Public Fec As Date

    Private Sub R_DiferenciasInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
        Me.Sp_consultaDiferenciasInventarioTableAdapter.Fill(Me.MELDataSet.sp_consultaDiferenciasInventario, CodI)

        Dim misParams(1) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CodI", CodI)
        misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha", Fec)
        Me.ReportViewer1.LocalReport.SetParameters(misParams)


        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class