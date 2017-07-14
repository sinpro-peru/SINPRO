Public Class R_GuiaBultos

    Private codFact As String
    Private totalBultos As Integer
    Private destino As String
    Private cliente As String
    Private inicio As Integer

    Public Sub valores_Guia(ByVal codF As String, ByVal totalB As Integer, ByVal dest As String, ByVal nom As String, ByVal ini As Integer)
        codFact = codF
        totalBultos = totalB
        destino = dest
        cliente = nom
        inicio = ini
    End Sub
    Private Sub R_GuiaBultos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 0 Then

            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.GuiaBultos-BRWME.rdlc"

            Dim i As Integer = 1 - (inicio - 1)

            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Inicio", inicio)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)

            While i <= totalBultos
                If i <= 0 Then
                    Me.MELDataSet.Table_GuiaBultos.Rows.Add(cliente, codFact, destino, 1, totalBultos)
                Else
                    Me.MELDataSet.Table_GuiaBultos.Rows.Add(cliente, codFact, destino, i, totalBultos)
                End If
                i = i + 2
            End While

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()

        Else

            If My.Settings.Empresa = 3 Then
                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.GuiaBultos-Mil26.rdlc"
            Else
                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.GuiaBultos.rdlc"
            End If

            Dim i As Integer = 1 - (inicio - 1)

            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Inicio", inicio)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)

            While i <= totalBultos
                If i <= 0 Then
                    Me.MELDataSet.Table_GuiaBultos.Rows.Add(cliente, codFact, destino, 1, totalBultos)
                Else
                    Me.MELDataSet.Table_GuiaBultos.Rows.Add(cliente, codFact, destino, i, totalBultos)
                End If
                i = i + 4
            End While

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()

        End If

    End Sub
End Class