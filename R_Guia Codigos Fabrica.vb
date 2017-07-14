Public Class R_Guia_Codigos_Fabrica
    Private cPed As String
    Private cCliente As String




    Public Sub valores_Guia(ByVal codPedido As String, ByVal codCliente As String)
        cPed = codPedido
        cCliente = codCliente
    End Sub

    Private Sub R_Guia_Codigos_Fabrica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaLogo' Puede moverla o quitarla según sea necesario.
        Me.Sp_consultaLogoTableAdapter.Fill(Me.MELDataSet.sp_consultaLogo)
        'TODO: esta línea de código carga datos en la tabla 'Me.MELDataSet.sp_consulta_producto_pedido_guia' Puede moverla o quitarla según sea necesario.
        Me.sp_consulta_producto_pedido_guiaTableAdapter.Fill(Me.MELDataSet.sp_consulta_producto_pedido_guia, cPed)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedidoCliente' Puede moverla o quitarla según sea necesario.
        Me.sp_consultaPedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaPedidoCliente, cPed)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario.
        Me.sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, cCliente)
        Me.ReportViewer1.RefreshReport()
        Console.WriteLine(Me.ReportViewer1.Margin.All)
    End Sub
End Class