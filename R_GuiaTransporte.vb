Public Class R_GuiaTransporte

    Private codFact As String
    Private ds As DataSet
    Private dgv As DataGridView
    Private transportista As String
    Private camion As String
    Private elaborada As String
    Private cid As String
    Private placa As String
    Private aprobada As String
    Private observacion As String
    Private ptos As String
    Private Nro As Integer
    Public trans As String = ""

    Public Sub valores_GuiaTransporte(ByVal cFact As String, ByVal dg As DataGridView, ByVal tr As String, ByVal ca As String, ByVal el As String, ByVal ci As String, ByVal pl As String, ByVal ap As String, ByVal ob As String, ByVal pt As String, ByVal nroguia As Integer)
        codFact = cFact
        dgv = dg
        transportista = tr
        camion = ca
        elaborada = el
        cid = ci
        placa = pl
        aprobada = ap
        observacion = ob
        ptos = pt
        Nro = nroguia
    End Sub
    Private Sub R_GuiaTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If trans.ToUpper = "TCP CARGA CONSOLIDADA" Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.GuiaTransporte2.rdlc"
            Dim i As Integer = 0
            Dim totrows As Integer = dgv.Rows.Count
            While i < 10
                If totrows > i Then
                    Me.MELDataSet.Table_GuiaTransporte.Rows.Add(Me.dgv(2, i).Value, Me.dgv(4, i).Value, Me.dgv(7, i).Value, Me.dgv(5, i).Value, CDbl(Me.dgv(6, i).Value), Me.dgv(11, i).Value, Me.dgv(12, i).Value)
                Else
                    Me.MELDataSet.Table_GuiaTransporte.Rows.Add(" ", " ", " ", 0, 0, " ", " ")
                End If
                i = i + 1
            End While
        Else
            Dim i As Integer = 0
            While i <= Me.dgv.Rows.Count - 1
                Me.MELDataSet.Table_GuiaTransporte.Rows.Add(Me.dgv(2, i).Value, Me.dgv(4, i).Value, Me.dgv(7, i).Value, Me.dgv(5, i).Value, CDbl(Me.dgv(6, i).Value), Me.dgv(8, i).Value, Me.dgv(12, i).Value)
                i = i + 1
            End While
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.GuiaTransporte.rdlc"
        End If

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
        MELDataSet.EnforceConstraints = False
        Me.sp_consultaFacturaTableAdapter.Fill(Me.MELDataSet.sp_consultaFactura, codFact)
        Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams1(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams2(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams3(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams4(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams5(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams6(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams7(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams8(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim misParams9(0) As Microsoft.Reporting.WinForms.ReportParameter

        misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Transportista", transportista)
        misParams1(0) = New Microsoft.Reporting.WinForms.ReportParameter("Camion", camion)
        misParams2(0) = New Microsoft.Reporting.WinForms.ReportParameter("Elaborada", elaborada)
        misParams3(0) = New Microsoft.Reporting.WinForms.ReportParameter("ci", cid)
        misParams4(0) = New Microsoft.Reporting.WinForms.ReportParameter("Placa", placa)
        misParams5(0) = New Microsoft.Reporting.WinForms.ReportParameter("Aprobada", aprobada)
        misParams6(0) = New Microsoft.Reporting.WinForms.ReportParameter("Observaciones", observacion)
        misParams7(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ptos", ptos)
        misParams8(0) = New Microsoft.Reporting.WinForms.ReportParameter("NroGuia", Nro)
        misParams9(0) = New Microsoft.Reporting.WinForms.ReportParameter("Empresa", My.Settings.Empresa)

        Me.ReportViewer1.LocalReport.SetParameters(misParams)
        Me.ReportViewer1.LocalReport.SetParameters(misParams1)
        Me.ReportViewer1.LocalReport.SetParameters(misParams2)
        Me.ReportViewer1.LocalReport.SetParameters(misParams3)
        Me.ReportViewer1.LocalReport.SetParameters(misParams4)
        Me.ReportViewer1.LocalReport.SetParameters(misParams5)
        Me.ReportViewer1.LocalReport.SetParameters(misParams6)
        Me.ReportViewer1.LocalReport.SetParameters(misParams7)
        Me.ReportViewer1.LocalReport.SetParameters(misParams8)

        If trans.ToUpper = "TCP CARGA CONSOLIDADA" Then
            Me.ReportViewer1.LocalReport.SetParameters(misParams9)
        End If

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class