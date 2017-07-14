Public Class R_ListadoClientes
    Private CodVend As Integer = 0
    Private Vendedor As String = ""
    Private Tipo As Integer = 0

    Public Sub valores(ByVal CodV As Integer, ByVal nom As String, ByVal tipo2 As Integer)
        CodVend = CodV
        Vendedor = nom
        tipo = tipo2
    End Sub

    Private Sub R_Catalogo_Marca_Modelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ReportViewer1.LocalReport.EnableExternalImages = True
            MELDataSet.EnforceConstraints = False
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
            Me.Sp_lvclienteTableAdapter.Fill(Me.MELDataSet.sp_lvcliente, "", Tipo, CodVend)

            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", Vendedor)
            Me.ReportViewer1.LocalReport.SetParameters(misParams)
            Me.ReportViewer1.ZoomPercent = 100
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

End Class