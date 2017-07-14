Public Class R_Listado_AlfabeticoFabrica

    Private Sub R_Listado_AlfabeticoFabrica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.DisplayName = "AGSA - Listado actualizado " + Format(Now, "dd-MM-yyyy")

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)


        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consulta_Listado_Alfabetico' Puede moverla o quitarla según sea necesario.
        Try
            Me.MELDataSet.EnforceConstraints = False
            Me.sp_consulta_Listado_AlfabeticoTableAdapter.Fill(Me.MELDataSet.sp_consulta_Listado_Alfabetico, -1, "", "")

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.MELDataSet.EnforceConstraints = True
            MsgBox("La lista o alguno de los campos se ecuentran vacios ", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class