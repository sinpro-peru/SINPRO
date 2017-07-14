Imports System.Data.SqlClient

Public Class DatosAnalisisCobranza
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Public Shared dr As SqlDataReader
    Public Shared dv As New DataView
    Public Shared dt As New DataTable
    Public Shared ds As New DataSet
    Public Shared da As New SqlClient.SqlDataAdapter
    Shared item As Object
    Public Shared entrar As Boolean

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub



    Public Shared Sub ConsultaFacturasVendedor(ByVal cod As Integer, ByRef DGV As DataGridView, ByRef lb As Label)

        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaVendedorFacturas"
        command.Parameters.AddWithValue("@cod", CInt(cod))
        dr = command.ExecuteReader()
        Dim fecha1 As Date
        Dim fecha2 As Date
        Dim deuda As Double
        Dim favor As Double
        deuda = 0.0
        favor = 0.0
        entrar = True
        While dr.Read()
            'If dr("MontoPendiente") <= -2 Then
            '    favor = favor + dr("MontoPendiente")
            'ElseIf dr("MontoPendiente") >= 2 Then
            fecha1 = dr("fecha")
            fecha2 = DateAdd(DateInterval.Day, 15, fecha1)
            DGV.Rows.Add(fecha1, dr("control"), dr("CodigoCliente"), dr("RazonSocial"), CDbl(dr("montoTotal")), fecha2, DateDiff(DateInterval.Day, fecha1, Today()), dr("DiasCred"), CDbl(dr("MontoPendiente")), dr("numeroFactura"), dr("Iva"))
            deuda = deuda + Math.Round(dr("MontoPendiente"), 2)
            'End If
        End While
        lb.Text = Format(Math.Round(deuda, 2), "#,##0.00")
        dr.Close()
    End Sub
    Public Shared Sub consulta_cliente(ByVal cod As Integer, ByRef DGV As DataGridView, ByRef lb As Label)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClienteFacturas"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        Dim fecha1 As Date
        Dim fecha2 As Date
        Dim deuda As Double
        Dim favor As Double
        deuda = 0.0
        favor = 0.0
        While dr.Read()
            'If dr("MontoPendiente") <= -2 Then
            '    favor = favor + dr("MontoPendiente")
            'ElseIf dr("MontoPendiente") >= 2 Then
            fecha1 = dr("fecha")
            fecha2 = DateAdd(DateInterval.Day, 15, fecha1)
            DGV.Rows.Add(fecha1, dr("control"), "", "", Format(Math.Round(dr("montoTotal"), 2), "#,##0.00"), fecha2, DateDiff(DateInterval.Day, fecha1, Today()), dr("DiasCred"), Format(Math.Round(dr("MontoPendiente"), 2), "#,##0.00"), dr("numeroFactura"), dr("Iva"))
            deuda = deuda + Math.Round(dr("MontoPendiente"), 2)
            lb.Text = Format(Math.Round(deuda, 2), "#,##0.00")

            'End If
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_clienteVendedor(ByRef cb As ComboBox, ByVal tipo As Boolean, ByVal cod As Integer)

        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClientesVendedor"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()

       
        cb.Items.Add(New comboItem("Todos", ""))

        While dr.Read
            cb.Items.Add(New comboItem(CStr(dr("razonSocial")), CStr(dr("codigoCliente"))))
        End While
        dr.Close()
        da.SelectCommand = command
        dt.Clear()
        da.Fill(dt)
    End Sub



    Public Shared Sub consulta_vendedores(ByRef cb As ComboBox)
        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedorPendiente"
            dr = command.ExecuteReader()
            cb.Items.Add(New comboItem("Todos", "0"))
            While dr.Read()
                cb.Items.Add(New comboItem(CStr(dr("Nombre")), CStr(dr("CodigoVendedor"))))
            End While

            dr.Close()
        Catch ex As Exception

        End Try

    End Sub



    Public Shared Sub consulta_vendedores2(ByRef cb As ComboBox)
        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedorPendiente"
            dr = command.ExecuteReader()
            While dr.Read()
                cb.Items.Add(New comboItem(CStr(dr("Nombre")), CStr(dr("CodigoVendedor"))))
            End While

            dr.Close()
        Catch ex As Exception

        End Try

    End Sub


    Public Shared Sub consulta_clienteCombo(ByRef cb As ComboBox, ByVal tipo As Boolean)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClientePendiente"
        dr = command.ExecuteReader()

        If tipo = True Then
            cb.Items.Add(New comboItem("Todos", "0"))
        End If


        While dr.Read
            cb.Items.Add(New comboItem(CStr(dr("razonSocial")), CStr(dr("codigoCliente"))))
        End While
        dr.Close()
        da.SelectCommand = command
        dt.Clear()
        da.Fill(dt)
    End Sub
    Public Shared Sub consulta_clientelike3(ByRef cb As ComboBox, ByVal codigo As String, ByRef texto As String, ByVal codV As Integer)

        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClienteCombo"
        command.Parameters.AddWithValue("@cod", codigo)
        command.Parameters.AddWithValue("@codV", codV)
        dr = command.ExecuteReader()
        cb.Items.Add(New comboItem("Todos", ""))
        While dr.Read
            cb.Items.Add(New comboItem(dr("RazonSocial"), dr("CodigoCliente")))
        End While
        texto = cb.Text
        dr.Close()

    End Sub
    

    Public Shared Sub consulta_VendedorLike(ByRef cb As ComboBox, ByVal codigo As String, ByRef texto As String)

        If entrar = False Then

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedorCombo"
            command.Parameters.AddWithValue("@cod", codigo)
            dr = command.ExecuteReader()
            cb.Items.Add(New comboItem("Todos", ""))
            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoVendedor")))
            End While
            texto = cb.Text
            dr.Close()

        End If

    End Sub


    Public Shared Sub consulta_VendedorLike2(ByRef cb As ComboBox, ByVal codigo As String, ByRef texto As String)

        If entrar = False Then

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedorCombo"
            command.Parameters.AddWithValue("@cod", codigo)
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoVendedor")))
            End While
            texto = cb.Text
            dr.Close()

        End If

    End Sub


End Class