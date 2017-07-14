Public Class R_Catalogo_Productos_Fotos

    Public Leyenda As String = "El nombre de las marcas se utiliza exclusivamente con el propósito de indicar el modelo al que aplica la pieza."
    Public UltimaPag As Integer = 0

    Private Sub R_Catalogo_Productos_Fotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaLogo' table. You can move, or remove it, as needed.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        DatosProducto.Table_Catalogo_Fotos(Me.MELDataSet.Table_Catalogo_Productos_Fotos, Me.MELDataSet.Table_indice_Modelos, Me.MELDataSet.Table_indice_Productos, UltimaPag)
        Dim misParams(1) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Leyenda", Leyenda)
        misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("UltimaPag", UltimaPag)

        Me.ReportViewer1.LocalReport.SetParameters(misParams)

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.Refresh()
        Me.ReportViewer1.Refresh()

    End Sub
End Class