Public Class R_Listado_Modelo_Cantidad
    Private cant As String
    Private modelo As String
    Private Lenyenda_Visible As Boolean = False
    Private Obs_Visible As Boolean = False
    Private Obs As String = ""
    Private Leyenda As String = ""

    Public Sub valores(ByVal ca As String, ByVal mo As String, ByVal lv As Boolean, ByVal ov As Boolean, ByVal leyen As String, ByVal obs As String)
        cant = ca
        modelo = mo
        Lenyenda_Visible = lv
        Obs_Visible = ov
        Me.Obs = obs
        Leyenda = leyen
    End Sub
    Private Sub R_Listado_Modelo_Cantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.DisplayName = "AGSA - Listado actualizado " + Format(Now, "dd-MM-yyyy")

        Dim misParams(3) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Leyenda_Visible", Lenyenda_Visible)
        misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Obs_Visible", Obs_Visible)
        misParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Obs", Obs)
        misParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("Leyenda", Leyenda)

        Me.ReportViewer1.LocalReport.SetParameters(misParams)

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consulta_Listado_Modelo' Puede moverla o quitarla según sea necesario.
        Me.MELDataSet.EnforceConstraints = False
        Me.sp_consulta_Listado_ModeloTableAdapter.Fill(Me.MELDataSet.sp_consulta_Listado_Modelo, modelo, cant)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class