Public Class R_Comision

    Public dgv As DataGridView
    Public vendedor As String = ""
    Public tipo As Integer = 0
    Public fecha1 As Date
    Public fecha2 As Date
    Public OcultaCom As Boolean = False

    Public Sub recibe(ByVal vende As String, ByVal fec1 As Date, ByVal fec2 As Date, ByVal dgv2 As DataGridView)

        dgv = dgv2
        vendedor = vende
        fecha1 = fec1.ToShortDateString
        fecha2 = fec2.ToShortDateString

    End Sub

    Private Sub R_Comision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            Dim i As Integer = 0
            Dim TOTAL As Double = 0

            While i <= dgv.Rows.Count - 1

                If tipo = 0 Then

                    If OcultaCom = False Then

                        MELDataSet.Table_DetallesComisionPagada.Rows.Add(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value, dgv.Rows(i).Cells(4).Value, _
                        CDate(dgv.Rows(i).Cells(5).Value).ToShortDateString, CDate(dgv.Rows(i).Cells(6).Value).ToShortDateString, dgv.Rows(i).Cells(7).Value, _
                        Format(dgv.Rows(i).Cells(8).Value, "#,##0.00"), Format(dgv.Rows(i).Cells(9).Value, "#,##0.00"), Format(CDbl(dgv.Rows(i).Cells(10).Value), "#,##0.00"), Format(CDbl(dgv.Rows(i).Cells(11).Value), "#,##0.00"))

                    Else

                        MELDataSet.Table_DetallesComisionPagada.Rows.Add(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value, dgv.Rows(i).Cells(4).Value, _
                        CDate(dgv.Rows(i).Cells(5).Value).ToShortDateString, CDate(dgv.Rows(i).Cells(6).Value).ToShortDateString, dgv.Rows(i).Cells(7).Value, _
                        Format(dgv.Rows(i).Cells(8).Value, "#,##0.00"), Format(dgv.Rows(i).Cells(9).Value, "#,##0.00"), "#,##", Format(CDbl(dgv.Rows(i).Cells(11).Value), "#,##0.00"))

                    End If

                    TOTAL = TOTAL + CDbl(dgv.Rows(i).Cells(11).Value)

                ElseIf tipo = 1 Then

                    If CDbl(dgv.Rows(i).Cells(11).Value) = 0 Then

                        If OcultaCom = False Then

                            MELDataSet.Table_DetallesComisionPagada.Rows.Add(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value, dgv.Rows(i).Cells(4).Value, _
                            CDate(dgv.Rows(i).Cells(5).Value).ToShortDateString, CDate(dgv.Rows(i).Cells(6).Value).ToShortDateString, dgv.Rows(i).Cells(7).Value, _
                            Format(dgv.Rows(i).Cells(8).Value, "#,##0.00"), Format(dgv.Rows(i).Cells(9).Value, "#,##0.00"), Format(CDbl(dgv.Rows(i).Cells(10).Value), "#,##0.00"), Format(CDbl(dgv.Rows(i).Cells(11).Value), "#,##0.00"))

                        Else

                            MELDataSet.Table_DetallesComisionPagada.Rows.Add(dgv.Rows(i).Cells(0).Value, dgv.Rows(i).Cells(1).Value, dgv.Rows(i).Cells(2).Value, dgv.Rows(i).Cells(3).Value, dgv.Rows(i).Cells(4).Value, _
                            CDate(dgv.Rows(i).Cells(5).Value).ToShortDateString, CDate(dgv.Rows(i).Cells(6).Value).ToShortDateString, dgv.Rows(i).Cells(7).Value, _
                            Format(dgv.Rows(i).Cells(8).Value, "#,##0.00"), Format(dgv.Rows(i).Cells(9).Value, "#,##0.00"), "#,##", Format(CDbl(dgv.Rows(i).Cells(11).Value), "#,##0.00"))

                        End If

                        TOTAL = TOTAL + CDbl(dgv.Rows(i).Cells(11).Value)

                    End If

                End If

                i = i + 1

            End While

            Dim misParams(3) As Microsoft.Reporting.WinForms.ReportParameter
            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Vendedor", vendedor)
            misParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha1", fecha1)
            misParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha2", fecha2)
            misParams(3) = New Microsoft.Reporting.WinForms.ReportParameter("Total", Format(TOTAL, "#,##0.00").ToString)

            If tipo = 1 Then
                Me.Text = "Detalles comisiones no pagadas"
            End If

            Me.ReportViewer1.LocalReport.SetParameters(misParams)

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox("Ha ocurrido un error cargando el informe, por favor intente de nuevo", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub
End Class