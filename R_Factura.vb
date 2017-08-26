Public Class R_Factura
    Private cFact As String
    Private cCliente As String
    Private CodFab As Boolean

    Public Sub valores_Factura(ByVal codFactura As String, ByVal codCliente As String, ByVal cf As Boolean)
        cFact = codFactura
        cCliente = codCliente
        CodFab = cf
    End Sub
    Private Sub fac(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.PaddingChanged
        Console.WriteLine("padding")
    End Sub


    Private Sub R_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaObs' table. You can move, or remove it, as needed.
        Me.Sp_consultaObsTableAdapter.Fill(Me.MELDataSet.sp_consultaObs)

        If My.Settings.Empresa = 1 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-BRWME.rdlc"
        ElseIf My.Settings.Empresa = 4 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-DIST-BRWME.rdlc"
        ElseIf My.Settings.Empresa = 5 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-DANGER.rdlc"
        ElseIf My.Settings.Empresa = 6 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-CONAVE.rdlc"
        ElseIf My.Settings.Empresa = 7 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-VENPER.rdlc"
        ElseIf My.Settings.Empresa = 8 Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura-PERU.rdlc"
        Else
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura.rdlc"
        End If

        If My.Settings.Empresa = 2 Or My.Settings.Empresa = 3 Or My.Settings.Empresa = 0 Then

            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CodigoF", CodFab)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)

        End If

        Try

            Me.Sp_consultaIVATableAdapter.Fill(Me.MELDataSet.sp_consultaIVA)
            Me.Sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, cCliente)
            Me.Sp_consulta_Productos_FacturaTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_Factura, cFact)
            Me.Sp_consultaFacturaTableAdapter.Fill(Me.MELDataSet.sp_consultaFactura, cFact)
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox("Error cargando la factura", MsgBoxStyle.Critical, "SINPRO")

        End Try
    End Sub

  
End Class