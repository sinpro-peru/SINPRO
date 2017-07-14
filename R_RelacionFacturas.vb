Public Class R_RelacionFacturas

    Private dgv As DataGridView
    Private elaborada As String
    Private observacion As String
    Private NroRelacion As Integer
    Private vendedor As String

    Public Sub valores_relacionFacturas(ByVal dg As DataGridView, ByVal el As String, ByVal ob As String, ByVal Nro As Integer, ByVal vend As String)
        dgv = dg
        elaborada = el
        observacion = ob
        NroRelacion = Nro
        vendedor = vend
    End Sub
    Private Sub R_RelacionFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        Dim i As Integer = 0
        While i < Me.dgv.Rows.Count
            Me.MELDataSet.Table_RelacionFacturas.Rows.Add(Me.dgv(0, i).Value, Me.dgv(2, i).Value, Me.dgv(4, i).Value, Me.dgv(1, i).Value, CDbl(Me.dgv(5, i).Value))
            i = i + 1
        End While
        Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams1(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams2(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams3(0) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Elaborada", elaborada)
        misParams1(0) = New Microsoft.Reporting.WinForms.ReportParameter("Observaciones", observacion)
        misParams2(0) = New Microsoft.Reporting.WinForms.ReportParameter("Nro", NroRelacion)
        misParams3(0) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", vendedor)
        Me.ReportViewer1.LocalReport.SetParameters(misParams)
        Me.ReportViewer1.LocalReport.SetParameters(misParams1)
        Me.ReportViewer1.LocalReport.SetParameters(misParams2)
        Me.ReportViewer1.LocalReport.SetParameters(misParams3)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class