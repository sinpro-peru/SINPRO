Public Class R_Etiqueta

    Public CodPro As String
    Public Nombre As String
    Public CodFab As String
    Public Proveedor As String
    Public Marca As String
    Public Modelo As String
    Public precio As Double
    Public cant As Integer
    Public dgv As DataGridView
    Public tipo As Integer

    Private Sub R_Etiqueta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If tipo = 1 Then

                For cont As Integer = 0 To cant - 1
                    Me.MELDataSet.Table_Producto_Etiqueta.Rows.Add(CodPro, Nombre, CodFab, Proveedor, precio, Modelo, Marca, cant)
                Next

            ElseIf tipo = 2 Then

                For cont As Integer = 0 To dgv.RowCount - 1

                    If dgv.Rows(cont).Visible Then

                        If IsNumeric(dgv.Rows(cont).Cells(7).Value) Then

                            If CInt(dgv.Rows(cont).Cells(7).Value) > 0 Then

                                For cont2 As Integer = 0 To CInt(dgv.Rows(cont).Cells(7).Value) - 1
                                    Me.MELDataSet.Table_Producto_Etiqueta.Rows.Add(dgv.Rows(cont).Cells(0).Value, dgv.Rows(cont).Cells(2).Value, dgv.Rows(cont).Cells(1).Value, "", 0, dgv.Rows(cont).Cells(4).Value, dgv.Rows(cont).Cells(3).Value, CInt(dgv.Rows(cont).Cells(7).Value))
                                Next

                            End If

                        End If

                    End If

                Next

            End If

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la impresión, favor intente de nuevo", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End Try

    End Sub

End Class