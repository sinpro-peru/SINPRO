Public Class R_ProductosDanados

    Dim Fecha1 As Date
    Dim Fecha2 As Date
    Dim vendedor As String = ""
    Dim codVend As Integer

    Private Sub R_ProductosDanados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
        Me.Sp_consultaProductosDanadosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosDanados, Fecha1, Fecha2, codVend)

        Dim Params(2) As Microsoft.Reporting.WinForms.ReportParameter

        Params(0) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", vendedor)
        Params(1) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha1", Fecha1.ToShortDateString)
        Params(2) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha2", Fecha2.ToShortDateString)

        Me.ReportViewer1.LocalReport.SetParameters(Params)

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Console.WriteLine(Me.ReportViewer1.Margin.All)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
    End Sub

    Public Sub recibe(ByVal fec1 As Date, ByVal fec2 As Date, ByVal v As String, ByVal v2 As Integer)

        Fecha1 = fec1
        Fecha2 = fec2
        vendedor = v
        codVend = v2

    End Sub

End Class