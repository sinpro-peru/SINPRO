Public Class R_Cargar_Compra
    Dim dt As DataTable
    Dim codP As String
    Dim Prov As String

    Public Sub valores(ByVal d As DataTable, ByVal p As String, ByVal pro As String)
        dt = d
        codP = p
        Prov = pro
    End Sub
    Private Sub R_Cargar_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        Dim i As Integer = 0
        While i < dt.Rows.Count
            Me.MELDataSet.Table_Cargar_Compra.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3), dt.Rows(i).Item(4), dt.Rows(i).Item(6), dt.Rows(i).Item(7), dt.Rows(i).Item(5), Prov, codP)
            i = i + 1
        End While
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class