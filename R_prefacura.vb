Public Class R_prefacura

    Dim cod As Integer
    Dim subto As Double
    Dim total As Double
    Dim iva As Double
    Dim CodCliente As Integer, RIF As String, RazonSocial As String, Direccion As String, telefono As String


    Public Sub recibe(ByVal codigo As Integer, ByVal subt As Double, ByVal tota As Double, ByVal i As Double, ByVal CodCliente2 As Integer, ByVal RIF2 As String, ByVal RazonSocial2 As String, ByVal Direccion2 As String, ByVal telefono2 As String)

        cod = codigo
        subto = subt
        total = tota
        iva = i
        CodCliente = CodCliente2
        RIF = RIF2
        telefono = telefono2
        Direccion = Direccion2
        RazonSocial = RazonSocial2

    End Sub

    Private Sub R_prefacura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.ReportViewer1.LocalReport.EnableExternalImages = True
            Me.ReportViewer1.LocalReport.DisplayName = "AGSA - Prefactura " + RazonSocial + " (" + cod.ToString + ")"

            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

            Dim Params(7) As Microsoft.Reporting.WinForms.ReportParameter

            Params(0) = New Microsoft.Reporting.WinForms.ReportParameter("subtotal", Format(subto, "#,##0.00"))
            Params(1) = New Microsoft.Reporting.WinForms.ReportParameter("total", Format(total, "#,##0.00"))
            Params(2) = New Microsoft.Reporting.WinForms.ReportParameter("iva", Format(iva, "#,##0.00"))
            Params(3) = New Microsoft.Reporting.WinForms.ReportParameter("CodCliente", CodCliente)
            Params(4) = New Microsoft.Reporting.WinForms.ReportParameter("RazonSocial", RazonSocial)
            Params(5) = New Microsoft.Reporting.WinForms.ReportParameter("Direccion", Direccion)
            Params(6) = New Microsoft.Reporting.WinForms.ReportParameter("Telefono", telefono)
            Params(7) = New Microsoft.Reporting.WinForms.ReportParameter("RIF", RIF)
            Me.ReportViewer1.LocalReport.SetParameters(Params)

            Me.Sp_prefacturaTableAdapter.Fill(Me.MELDataSet.sp_prefactura, cod)
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            Console.WriteLine(Me.ReportViewer1.Margin.All)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5, "Error", "Ocurrió un error generando el reporte", ToolTipIcon.Error)
        End Try

    End Sub

End Class