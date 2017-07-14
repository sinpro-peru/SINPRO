Public Class R_NotaCredito
    Private cod As Integer

    Public Sub valores_nc(ByVal codNC As Integer)
        cod = codNC
    End Sub
    Private Sub R_Nc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If My.Settings.Empresa = 1 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-BRWME.rdlc"

            ElseIf My.Settings.Empresa = 4 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-BRWME-DIST.rdlc"

            ElseIf My.Settings.Empresa = 5 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.NC-DANGER.rdlc"

            ElseIf My.Settings.Empresa = 6 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-CONAVE.rdlc"

            ElseIf My.Settings.Empresa = 7 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-VENPER.rdlc"

            ElseIf My.Settings.Empresa = 3 Then

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc-Mil26.rdlc"
                Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
                misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Cabezera", My.Settings.CabezeraNC)
                Me.ReportViewer1.LocalReport.SetParameters(misParams)

            Else

                ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc.rdlc"
                Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
                misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Cabezera", My.Settings.CabezeraNC)
                Me.ReportViewer1.LocalReport.SetParameters(misParams)

            End If

            Me.Sp_consultaNC_rdlcTableAdapter.Fill(Me.MELDataSet.sp_consultaNC_rdlc, cod)
            Me.Sp_consultaproductosNC_rdlcTableAdapter.Fill(Me.MELDataSet.sp_consultaproductosNC_rdlc, cod)

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox("Ocurrió un error imprimiendo la nota de crédito", MsgBoxStyle.Critical)

        End Try

    End Sub


End Class