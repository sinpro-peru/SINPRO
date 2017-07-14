Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices

Public Class R_ChequesDev

    Dim CodVend As Integer
    Dim NombreVend As String
    Dim Fecha1 As Date
    Dim Fecha2 As Date
    Dim tipo As Integer = 0

    Private Sub R_ChequesDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

            Dim Params(3) As Microsoft.Reporting.WinForms.ReportParameter

            Params(0) = New Microsoft.Reporting.WinForms.ReportParameter("NombreVendedor", NombreVend)
            Params(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaDesde", Fecha1.ToShortDateString)
            Params(2) = New Microsoft.Reporting.WinForms.ReportParameter("FechaHasta", Fecha2.ToShortDateString)
            If tipo = 0 Or tipo = 3 Then
                Params(3) = New Microsoft.Reporting.WinForms.ReportParameter("NombreReporte", "Reporte de cheques devueltos")
            Else
                Params(3) = New Microsoft.Reporting.WinForms.ReportParameter("NombreReporte", "Reporte de cheques devueltos por reponer")
            End If

            Me.ReportViewer1.LocalReport.SetParameters(Params)
            Me.MELDataSet.EnforceConstraints = False

            Me.Sp_R_ChequesDevTableAdapter.Fill(Me.MELDataSet.sp_R_ChequesDev, tipo, CodVend, Fecha1, Fecha2)

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            Console.WriteLine(Me.ReportViewer1.Margin.All)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Catch ex As Exception

        End Try

    End Sub

    Public Sub recibe(ByVal Cod As Integer, ByVal nom As String, ByVal Fec1 As String, ByVal Fec2 As String, ByVal tip As Integer)

        CodVend = Cod
        NombreVend = nom
        Fecha1 = Fec1
        Fecha2 = Fec2
        tipo = tip

    End Sub

End Class