Public Class R_Eficacia

    Dim total As String = ""
    Dim total2 As String = ""
    Dim total3 As String = ""
    Dim Vendedor As String = ""
    Dim FechaInicio As Date
    Dim FechaFin As Date
    Dim DGV As DataGridView

    Private Sub R_Eficacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaLogo' table. You can move, or remove it, as needed.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        Try

            'TODO: This line of code loads data into the 'MelDataSet.sp_consultaLogo' table. You can move, or remove it, as needed.
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            Dim v2 As Boolean = False
            Dim v3 As Boolean = False
            Dim v4 As Boolean = False
            Dim v5 As Boolean = False
            Dim v6 As Boolean = False


            DatosDSS.Tbl_Eficacia(Me.MELDataSet.Tbl_DGV_Eficacia, DGV, v2, v3, v4, v5, v6)

            Dim misParams(10) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", Vendedor)
            misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", FechaInicio.ToShortDateString)
            misParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaFin.ToShortDateString)
            misParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("TotalBs", Format(CDbl(total), "#,##0.00").ToString)
            misParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("TotalFact", total2)
            misParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("TotalCli", total3)
            misParams(6) = New Microsoft.Reporting.WinForms.ReportParameter("v2", v2)
            misParams(7) = New Microsoft.Reporting.WinForms.ReportParameter("v3", v3)
            misParams(8) = New Microsoft.Reporting.WinForms.ReportParameter("v4", v4)
            misParams(9) = New Microsoft.Reporting.WinForms.ReportParameter("v5", v5)
            misParams(10) = New Microsoft.Reporting.WinForms.ReportParameter("v6", v6)

            Me.ReportViewer1.LocalReport.SetParameters(misParams)

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.Refresh()

        Catch ex As Exception

            MsgBox("Ha ocurrido un error cargando el informe, por favor intente de nuevo", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub


    Public Sub recibe(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal tot As String, ByVal tot2 As String, ByVal tot3 As String, ByVal vend As String, ByVal dgv As DataGridView)

        FechaInicio = Fecha1
        FechaFin = Fecha2
        total = tot
        total2 = tot2
        total3 = tot3
        Vendedor = vend
        Me.DGV = dgv

    End Sub

End Class