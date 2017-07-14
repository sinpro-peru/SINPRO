Public Class R_ProductosOcultos

    Private Sub R_ProductosOcultos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.MELDataSet.EnforceConstraints = False

            'TODO: This line of code loads data into the 'MELDataSet.sp_consultaLogo' table. You can move, or remove it, as needed.
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
            'TODO: This line of code loads data into the 'MELDataSet.sp_consultaProductosOcultos' table. You can move, or remove it, as needed.
            Me.Sp_consultaProductosOcultosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosOcultos, My.Settings.Empresa)

            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            'Console.WriteLine(Me.ReportViewer1.Margin.All)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Catch ex As Exception

            MsgBox("Error creando reporte", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

End Class