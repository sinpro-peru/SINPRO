Imports Microsoft.Reporting.WinForms

Public Class Frm_AutorizarPedido

    Dim CodigoPedido As Integer = 0
    Dim CodigoCliente As Integer = 0
    Dim frm As Frm_Pedidos_Clientes

    Private Sub bt_autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_autorizar.Click
        DatosPedidoCliente.Autoriza_Pedidocliente(CodigoPedido, True)
        Datos.Inserta_Actividad("Autorizó el pedido nro. " + CodigoPedido.ToString + " del cliente (" + CodigoCliente.ToString + ") " + lbl_Cliente.Text)
        frm.DGV_Pedidos.SelectedRows(0).Cells(4).Value = "Sí"
        Frm_Principal.NotifyIcon1.ShowBalloonTip(3000, "SINPRO", "Pedido autorizado", ToolTipIcon.Info)
        Me.Close()
    End Sub

    Public Sub recibe(ByVal Cod As Integer, ByVal frm2 As Frm_Pedidos_Clientes, ByVal codC As Integer, ByVal nom As String, ByVal codCli As Integer)
        CodigoPedido = Cod
        frm = frm2
        lbl_Cliente.Text = nom
        lbl_codigo.Text = codC
        CodigoCliente = codCli
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_AutorizarPedido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm.Enabled = True
        frm.Focus()
        frm.DGV_Productos_Pedido.Focus()
        frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)
    End Sub

    Private Sub Frm_AutorizarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        frm.Enabled = False
        DatosPedidoCliente.IndicadoresCliente(CInt(lbl_codigo.Text), lbl_pendiente.Text, lbl_PendienteC.Text, lbl_vencido.Text, _
                                              lbl_vencidoC.Text, lbl_limite.Text, lbl_chequesDev.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub tb_bultos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub bt_express_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_express.Click

        DatosPedidoCliente.Autoriza_Pedidocliente(CodigoPedido, True)
        Datos.Inserta_Actividad("Autorizó el pedido nro. " + CodigoPedido.ToString + " del cliente (" + CodigoCliente.ToString + ") " + lbl_Cliente.Text)
        frm.DGV_Pedidos.SelectedRows(0).Cells(4).Value = "Sí"
        Frm_Principal.NotifyIcon1.ShowBalloonTip(3000, "SINPRO", "Pedido autorizado", ToolTipIcon.Info)

        Dim r_Guia As New R_Guia
        r_Guia.valores_Guia(CodigoPedido, CodigoCliente, 3, True)

        r_Guia.Sp_consultaLogoTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaLogo)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedido_Producto_Cliente' Puede moverla o quitarla según sea necesario.
        r_Guia.MELDataSet.EnforceConstraints = False

        r_Guia.Sp_consultaPedido_Producto_ClienteTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaPedido_Producto_Cliente, CodigoPedido, 3)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedidoCliente' Puede moverla o quitarla según sea necesario.
        r_Guia.sp_consultaPedidoClienteTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaPedidoCliente, CodigoPedido)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario.
        r_Guia.sp_consultaClienteTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaCliente, codigocliente)

        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

        ReportDataSource1.Name = "MELDataSet_sp_consultaPedido_Producto_Cliente"
        ReportDataSource1.Value = r_Guia.sp_consultaPedido_Producto_ClienteBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaPedidoCliente"
        ReportDataSource2.Value = r_Guia.sp_consultaPedidoClienteBindingSource
        ReportDataSource3.Name = "MELDataSet_sp_consultaCliente"
        ReportDataSource3.Value = r_Guia.sp_consultaClienteBindingSource
        ReportDataSource4.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource4.Value = r_Guia.Sp_consultaLogoBindingSource

        Dim s As LocalReport = New LocalReport
        s.ReportEmbeddedResource = "Tesis_Nueva.Guia.rdlc"
        s.DataSources.Add(ReportDataSource1)
        s.DataSources.Add(ReportDataSource2)
        s.DataSources.Add(ReportDataSource3)
        s.DataSources.Add(ReportDataSource4)

        Export(s)
        PrintReport(My.Settings.DocsPrinter)

        r_Guia.Close()

        Me.Close()

    End Sub
End Class