Public Class R_Guia
    Private cPed As String
    Private cCliente As String
    Private tipo As Integer
    Private express As Boolean

    Public Sub valores_Guia(ByVal codPedido As String, ByVal codCliente As String, ByVal Tipo2 As Integer, ByVal exp As Boolean)
        cPed = codPedido
        cCliente = codCliente
        tipo = Tipo2
        express = exp
    End Sub

    Private Sub R_Guia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedido_Producto_Cliente' Puede moverla o quitarla según sea necesario.
        MELDataSet.EnforceConstraints = False
        Me.Sp_consultaPedido_Producto_ClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaPedido_Producto_Cliente, cPed, tipo)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedidoCliente' Puede moverla o quitarla según sea necesario.
        Me.sp_consultaPedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaPedidoCliente, cPed)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario.
        Me.sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, cCliente)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Console.WriteLine(Me.ReportViewer1.Margin.All)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
    End Sub

    Private Sub sp_consultaClienteBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sp_consultaClienteBindingSource.CurrentChanged

    End Sub
End Class