Public Class R_NotaCredito_Desc
    Private cod As Integer
    Public Sub valores_nc(ByVal codNC As Integer)
        cod = codNC
    End Sub
    Private Sub R_NotaCredito_Desc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Empresa = 1 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc Descuento-BRWME.rdlc"
        ElseIf My.Settings.Empresa = 0 Or My.Settings.Empresa = 4 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-Descuento-BRWME-DIST.rdlc"
        ElseIf My.Settings.Empresa = 6 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-Descuento-CONAVE.rdlc"
        ElseIf My.Settings.Empresa = 7 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-Descuento-VENPER.rdlc"
        Else
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc Descuento.rdlc"
            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Cabezera", My.Settings.CabezeraNC)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)
        End If

        Me.Sp_consultaNC_rdlcTableAdapter.Fill(Me.MELDataSet.sp_consultaNC_rdlc, cod)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class