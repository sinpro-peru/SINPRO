Public Class R_Guia_Almacenes_Cuartos
    Dim tablita As New DataTable
    Private cPed As String
    Private cCliente As String
    Private tipo As Integer
    Private Ubi As String


    Public Sub valores_Guia(ByVal codPedido As String, ByVal codCliente As String, ByVal Tipo2 As Integer, ByVal ubicacion As String, ByVal tabla As DataTable)
        tablita = tabla
        cPed = codPedido
        cCliente = codCliente
        tipo = Tipo2
        Ubi = ubicacion
    End Sub

    Private Sub R_Guia_Almacenes_Cuartos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)



        For cont As Integer = 0 To tablita.Rows.Count - 1
            Dim anterio As Integer = 0

            anterio = tablita.Rows(cont).Item(7)

            If anterio = tablita.Rows(cont).Item(7) Then
                MELDataSet.Table_Guia_Almacenes_Cuartos.Rows.Add(tablita.Rows(cont).Item(1), tablita.Rows(cont).Item(2), tablita.Rows(cont).Item(3), tablita.Rows(cont).Item(4), tablita.Rows(cont).Item(6), tablita.Rows(cont).Item(5), tablita.Rows(cont).Item(0), tablita.Rows(cont).Item(8))
           
            End If

        Next


        Dim Params(2) As Microsoft.Reporting.WinForms.ReportParameter

        Params(0) = New Microsoft.Reporting.WinForms.ReportParameter("Cod_Cliente", cCliente)
        Params(1) = New Microsoft.Reporting.WinForms.ReportParameter("Cod_Pedido", cPed)
        Params(2) = New Microsoft.Reporting.WinForms.ReportParameter("Direccion", Ubi)
   

        Me.ReportViewer1.LocalReport.SetParameters(Params)

        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Console.WriteLine(Me.ReportViewer1.Margin.All)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

    End Sub
End Class