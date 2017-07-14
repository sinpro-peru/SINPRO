Public Class R_Analisis_Cobranza

    Dim dgv As DataGridView
    Dim total As Label
    Dim MostrarVendedor As Boolean
    Dim Vendedor As String

    Public Sub valores_AnalisisCobranza(ByVal dg As DataGridView, ByVal l As Label, ByVal MostrarV As Boolean, ByVal Vend As String)
        dgv = dg
        total = l
        Vendedor = Vend
        MostrarVendedor = MostrarV
    End Sub

    Private Sub R_Analisis_Cobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)

        Dim misParams(1) As Microsoft.Reporting.WinForms.ReportParameter
        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("MostrarVendedor", MostrarVendedor)
        misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", Vendedor)
        Me.ReportViewer1.LocalReport.SetParameters(misParams)

        'dgv.Sort(dgv.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        Dim i As Integer = 0
        While i < dgv.Rows.Count
            If dgv.Rows(i).Visible Then
                Me.MELDataSet.Table_Analisis_Cobranza.Rows.Add(dgv(0, i).Value.ToString.Substring(0, 10), dgv(1, i).Value, dgv(2, i).Value, dgv(3, i).Value, Format(dgv(4, i).Value, "#,##0.00"), dgv(5, i).Value.ToString.Substring(0, 10), dgv(6, i).Value, dgv(7, i).Value, Format(dgv(8, i).Value, "#,##0.00"), total.Text)
            End If
            i = i + 1
        End While

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class