Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms

Public Class Frm_Imprimir_Pedido_Cliente

    Dim codigo As String
    Dim codigocliente As Integer
    Dim ubi As String
    Dim tablita As New DataTable
    Dim tabla As New DataTable
    Dim subt As Double
    Dim total As Double
    Dim iva As Double
    Dim CodCliente As Integer, RIF As String, RazonSocial As String, Direccion As String, telefono As String

    Private Sub ch_cuarto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_cuarto.CheckedChanged
        If ch_cuarto.Checked = True Then
            ch_todo.Checked = False
            ch_almacen.Checked = False
        End If
    End Sub
    Private Sub ch_almacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_almacen.CheckedChanged
        If ch_almacen.Checked = True Then
            ch_todo.Checked = False
            ch_cuarto.Checked = False
        End If
    End Sub
    Private Sub ch_todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_todo.CheckedChanged
        If ch_todo.Checked = True Then
            ch_almacen.Checked = False
            ch_cuarto.Checked = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_valesalida.CheckedChanged
        ch_almacen.Visible = True
        ch_cuarto.Visible = True
        ch_todo.Visible = True
        ch_todo.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_prefactura.CheckedChanged
        ch_todo.Checked = False
        ch_almacen.Checked = False
        ch_cuarto.Checked = False
        ch_almacen.Visible = False
        ch_cuarto.Visible = False
        ch_todo.Visible = False
    End Sub

    Private Sub Frm_Imprimir_Pedido_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        rb_prefactura.Checked = False
        rb_valesalida.Checked = True
        ch_todo.Checked = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        rb_prefactura.Checked = False
        rb_valesalida.Checked = False
        ch_almacen.Checked = False
        ch_cuarto.Checked = False
        ch_todo.Checked = False
        ch_almacen.Visible = False
        ch_cuarto.Visible = False
        ch_todo.Visible = False
        Me.Close()
    End Sub

    Public Sub recibePedido(ByVal cod As String, ByVal codCliente3 As Integer, ByVal ubicacion As String, ByVal s As Double, ByVal t As Double, ByVal i As Double, ByVal CodCliente2 As Integer, ByVal RIF2 As String, ByVal RazonSocial2 As String, ByVal Direccion2 As String, ByVal telefono2 As String)

        codigo = cod
        codigocliente = codCliente3
        ubi = ubicacion
        subt = s
        total = t
        iva = i
        CodCliente = CodCliente2
        RIF = RIF2
        telefono = telefono2
        Direccion = Direccion2
        RazonSocial = RazonSocial2

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ch_todo.Checked = True Then
            Dim r_Guia As New R_Guia
            r_Guia.valores_Guia(codigo, codigocliente, 3, False)
            r_Guia.Show()
        ElseIf ch_almacen.Checked = True Or ch_cuarto.Checked = True Then

            tablita.Columns.Clear()
            tabla.Columns.Clear()
            tablita.Columns.Add("Ubicacion")
            tablita.Columns.Add("Cantidad")
            tablita.Columns.Add("CodAgsa")
            tablita.Columns.Add("CodF")
            tablita.Columns.Add("Nombre")
            tablita.Columns.Add("Modelo")
            tablita.Columns.Add("Existencia")
            tablita.Columns.Add("Codigo")
            tablita.Columns.Add("Razon")

            If ch_almacen.Checked = True Then
                DatosPedidoCliente.consulta_pedido_producto_cliente_tabla(codigo, tablita, 1)
            Else
                DatosPedidoCliente.consulta_pedido_producto_cliente_tabla(codigo, tablita, 2)
            End If

            tabla.Columns.Add("Ubicacion")
            tabla.Columns.Add("Cantidad")
            tabla.Columns.Add("CodAgsa")
            tabla.Columns.Add("CodF")
            tabla.Columns.Add("Nombre")
            tabla.Columns.Add("Modelo")
            tabla.Columns.Add("Existencia")
            tabla.Columns.Add("Codigo")
            tabla.Columns.Add("Razon")

            Dim anterior As Integer = 0
            Dim cont As Integer = 0
            Dim cont2 As Integer = 0

            anterior = tablita.Rows(cont).Item(7)

            While tablita.Rows.Count > 0
                cont = 0
                anterior = tablita.Rows(cont).Item(7)
                While cont < tablita.Rows.Count

                    If anterior = tablita.Rows(cont).Item(7) Then
                        tabla.Rows.Add(tablita.Rows(cont).Item(0), tablita.Rows(cont).Item(1), tablita.Rows(cont).Item(2), tablita.Rows(cont).Item(3), tablita.Rows(cont).Item(4), tablita.Rows(cont).Item(5), tablita.Rows(cont).Item(6), tablita.Rows(cont).Item(7), tablita.Rows(cont).Item(8))
                        tablita.Rows.RemoveAt(cont)

                    Else
                        cont = tablita.Rows.Count
                    End If


                End While
                Dim frm As New R_Guia_Almacenes_Cuartos
                frm.valores_Guia(codigo, codigocliente, 0, ubi, tabla)
                frm.Show()
                tabla.Rows.Clear()
            End While

        End If

        If rb_prefactura.Checked = True Then

            Dim frm As New R_prefacura
            frm.recibe(codigo, subt, total, iva, CodCliente, RIF, RazonSocial, Direccion, telefono)
            frm.Show()

        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim r_Guia As New R_Guia
        r_Guia.valores_Guia(codigo, codigocliente, 3, True)

        r_Guia.Sp_consultaLogoTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaLogo)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedido_Producto_Cliente' Puede moverla o quitarla según sea necesario.
        r_Guia.MELDataSet.EnforceConstraints = False

        r_Guia.Sp_consultaPedido_Producto_ClienteTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaPedido_Producto_Cliente, codigo, 3)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaPedidoCliente' Puede moverla o quitarla según sea necesario.
        r_Guia.sp_consultaPedidoClienteTableAdapter.Fill(r_Guia.MELDataSet.sp_consultaPedidoCliente, codigo)
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