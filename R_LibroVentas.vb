Public Class R_LibroVentas

    Dim FechaInicio As Date = Today
    Dim FechaFin As Date = Today

    Private Sub R_LibroVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'TODO: This line of code loads data into the 'MelDataSet.sp_consultaLogo' table. You can move, or remove it, as needed.
            Me.Sp_consultaLogoTableAdapter.Fill(Me.MelDataSet.sp_consultaLogo)
            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            Dim totalB As Double = 0
            Dim totalI As Double = 0
            Dim total As Double = 0

            DatosFacturas.sp_libroVentas(Me.MelDataSet.Table_Libro_Ventas, FechaInicio, FechaFin, My.Settings.Nro_Imp_Visible, totalB, totalI, total)

            Dim misParams(5) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("NroImpVisible", My.Settings.Nro_Imp_Visible)
            misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", FechaInicio)
            misParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaFin)
            misParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("TotalBase", Format(totalB, "#,##0.00").ToString)
            misParams(4) = New Microsoft.Reporting.WinForms.ReportParameter("TotalImpuesto", Format(totalI, "#,##0.00").ToString)
            misParams(5) = New Microsoft.Reporting.WinForms.ReportParameter("Total", Format(total, "#,##0.00").ToString)
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

    Public Sub recibe(ByVal fecha1 As Date, ByVal fecha2 As Date)

        FechaInicio = fecha1
        FechaFin = fecha2

    End Sub
End Class