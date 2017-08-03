Imports System.Data.SqlClient
Public Class DatosFacturas
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub lv_factura(ByRef lv As ListView, ByVal s As String, ByVal val As Integer)
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvFactura"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            Dim c As Integer = dr("numeroFactura")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("ControlInicio"))
            i.SubItems.Add(dr("CodigoCliente"))
            i.SubItems.Add(dr("RazonSocial"))
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub

    Public Shared Sub Saldo_factura(ByVal Cod As Integer, ByRef Saldo As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSaldoFactura"
            command.Parameters.AddWithValue("@Cod", Cod)
            dr = command.ExecuteReader()

            While dr.Read

                If dr("Cancelado").GetType.ToString = "System.DBNull" Then
                    Saldo = "0,00"
                Else
                    Saldo = Format(CDbl(dr("Cancelado")), "#,##0.00").ToString
                End If

            End While

        Catch ex As Exception

            MsgBox("Error consultando saldo de factura", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()

        End Try

        
    End Sub

    Public Shared Function consultaUltimaFac(ByVal controlActual As Integer, ByVal Tipo As Integer, ByRef control2 As Integer) As Integer

        Try

            Dim control As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUltimaFact"
            command.Parameters.AddWithValue("@cod", controlActual)

            dr = command.ExecuteReader

            While dr.Read

                control = CInt(dr("NumeroFactura"))
                control2 = CInt(dr("ControlInicio"))

            End While


            Return control

        Catch ex As Exception

            MsgBox("Error consultando ultima factura", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()

        End Try

    End Function


    Public Shared Function FechaValida(ByVal fechaFac As Date, ByVal codAnt As Integer) As Boolean

        Try

            Dim bien As Boolean = True
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFactura"
            command.Parameters.AddWithValue("@cod", codAnt)

            dr = command.ExecuteReader

            While dr.Read

                If dr("Fecha").GetType.ToString = "System.DBNull" Then

                    bien = True

                Else

                    If CDate(dr("Fecha")) > fechaFac Then
                        bien = False
                    Else
                        bien = True
                    End If

                End If

            End While

            Return bien

        Catch ex As Exception

            MsgBox("Error verificando fecha", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()

        End Try

    End Function

    Public Shared Sub DGV_factura(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvFactura"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("numeroFactura"), dr("ControlInicio"), dr("CodigoCliente"), dr("RazonSocial"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub identidad_Factura(ByRef tb As String)
        'Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadFactura"
        dr = command.ExecuteReader
        dr.Read()
        tb = dr("Expr1") + 1
        dr.Close()
    End Sub

    Public Shared Sub control_Factura(ByRef tb As String)
        'Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_controlFactura"
        dr = command.ExecuteReader
        dr.Read()
        tb = dr("controlInicio") + 1
        dr.Close()
    End Sub

    Public Shared Sub consulta_facturas(ByRef dgv As DataGridView)
        Dim par As Integer
        par = 0
        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tipo", 0)
        command.CommandText = "sp_consultaClienteFactura"
        dr = command.ExecuteReader()

        While dr.Read
            dgv.Rows.Add(dr("NumeroFactura"), dr("ControlInicio"), dr("CodigoCliente"), dr("RazonSocial"), dr("Estado"))
        End While
        dgv.Sort(dgv.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        dr.Close()
    End Sub

    Public Shared Sub consulta_UnaFactura(ByRef dgv As DataGridView, ByVal codF As Integer, ByVal control As Integer, ByVal codC As Integer, ByVal Razon As String)
        dgv.Rows.Clear()
        dgv.Rows.Add(codF, control, codC, Razon)
    End Sub
    Public Shared Sub consulta_transportes(ByRef cb As MTGCComboBox)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaTransporte"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoTransporte"))))
        End While

        dr.Close()
    End Sub
    Public Shared Sub consulta_iva(ByRef iva As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_consultaIVA"
        dr = command.ExecuteReader()
        If dr.Read() Then
            iva = dr("iva")
        End If
        dr.Close()
    End Sub
    Public Shared Sub consulta_factura(ByVal c As Integer, ByRef num As String, ByRef fec As String, ByRef fac As String, ByRef ped As String, ByRef bultos As String, ByRef iva As Double, ByRef canc As String, ByRef total As String, ByRef conI As String, ByRef obser As String, ByRef dias As String, ByRef opcion As Boolean, ByRef entrega As Boolean, ByRef obsPed As String, ByRef Imp As String, ByRef dir As String)
        'consulta_iva(iva)
        'Dim codT As Integer
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFactura"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()
            While dr.Read()
                num = CStr(dr("NumeroFactura"))
                fec = CStr(dr("Fecha"))
                conI = dr("controlInicio")
                fac = dr("facturador")
                ped = CStr(dr("codigoPedido"))
                bultos = CStr(dr("numeroBultos"))
                canc = dr("MontoCancelado")
                total = dr("MontoTotal")

                If dr("Direccion").GetType.ToString = "System.DBNull" Then
                    dir = ""
                Else
                    dir = dr("Direccion")
                End If

                If dr("NroImp").GetType.ToString = "System.DBNull" Then
                    Imp = ""
                Else
                    Imp = dr("NroImp")
                End If

                If dr("DiasCred").GetType.ToString = "System.DBNull" Then
                    dias = ""
                Else
                    dias = dr("DiasCred")
                End If
                iva = dr("Iva")
                If dr("Observacion").GetType.ToString = "System.DBNull" Then
                    obser = ""
                Else
                    obser = dr("Observacion")
                End If
                If dr("ObservacionPedido").GetType.ToString = "System.DBNull" Then
                    obsPed = ""
                Else
                    obsPed = dr("ObservacionPedido")
                End If
                'If dr("Enviado") = 1 Then
                '    opcion = True
                'Else
                '    opcion = False
                'End If
                opcion = dr("Enviado")
                entrega = dr("Entregada")
            End While
            dr.Close()

        Catch ex As Exception

            MsgBox("Error cargando facura", MsgBoxStyle.Critical)

            dr.Close()

        End Try

    End Sub
    Public Shared Sub inserta_Factura(ByVal fec As DateTime, ByVal conI As Integer, ByVal fac As String, ByVal numB As String, ByVal codP As Integer, ByVal monC As Double, ByVal monT As Double, ByVal obser As String, ByVal iva As Double, ByVal dias As Integer, ByVal entrega As Boolean, ByVal nroImp As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaFactura"
        command.Parameters.AddWithValue("@fec", fec)
        command.Parameters.AddWithValue("@conI", conI)
        command.Parameters.AddWithValue("@fac", fac)
        command.Parameters.AddWithValue("@numB", numB)
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@monC", monC)
        command.Parameters.AddWithValue("@monT", monT)
        command.Parameters.AddWithValue("@obser", obser)
        command.Parameters.AddWithValue("@iva", iva)
        command.Parameters.AddWithValue("@Dias", dias)
        command.Parameters.AddWithValue("@Entrega", entrega)
        command.Parameters.AddWithValue("@NroImp", nroImp)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_factura2(ByRef cb As ComboBox)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFactura"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(dr("numeroFactura"))
        End While

        dr.Close()
    End Sub
    Public Shared Sub modifica_factura(ByVal fec As DateTime, ByVal conI As Integer, ByVal fac As String, ByVal numB As String, ByVal COD As Integer, ByVal obser As String, ByVal dias As Integer, ByVal CodPed As Integer, ByVal enviado As Boolean, ByVal entrega As Boolean, ByVal nroImp As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaFactura"
        command.Parameters.AddWithValue("@fec", fec)
        command.Parameters.AddWithValue("@conI", conI)
        command.Parameters.AddWithValue("@fac", fac)
        command.Parameters.AddWithValue("@numB", numB)
        command.Parameters.AddWithValue("@COD", COD)
        command.Parameters.AddWithValue("@obser", obser)
        command.Parameters.AddWithValue("@Dias", dias)
        command.Parameters.AddWithValue("@CodPed", CodPed)
        command.Parameters.AddWithValue("@Env", enviado)
        command.Parameters.AddWithValue("@Entrega", entrega)
        command.Parameters.AddWithValue("@NroImp", nroImp)
        command.ExecuteNonQuery()

    End Sub
    '----------------------------------------------------------------------------



    Public Shared Sub cantidad_pedida(ByVal cod As String, ByVal num As Integer, ByRef cant As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_cantidadPedida"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@num", num)
        dr = command.ExecuteReader()
        If dr.Read Then
            cant = dr(0)
        Else
            cant = 0
        End If
        dr.Close()
    End Sub


    Public Shared Sub esta(ByVal t As DataTable, ByVal cod As String, ByRef sw As Boolean)
        'Dim item As Object
        'Dim c As Double
        Dim i As Integer = 0
        While i <= t.Rows.Count - 1
            If t.Rows(i).Item("Código") = cod Then
                sw = True
            End If
            i = i + 1
        End While
        t.AcceptChanges()
    End Sub

    Public Shared Sub consulta_productos_factura(ByRef cod As String, ByRef t As DataGridView, ByVal Tipo As Integer)
        Dim cont As Integer = 0
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaproductosNotasCredito"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@Tipo", Tipo)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"), Format(dr("SubTotal"), "#,##0.00"), dr("Dev"))
            cont = cont + 1
        End While
        cont = 0
        dr.Close()

    End Sub
    Public Shared Sub consulta_productos_pedido(ByRef codP As String, ByRef dg As DataGridView)
        dg.Rows.Clear()
        Dim cont As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        'command.CommandText = "sp_consultaPedido_ProductoMelissa"
        command.CommandText = "sp_consultaPedido_Producto_Cliente"
        command.Parameters.AddWithValue("@codPed", codP)
        command.Parameters.AddWithValue("@Tipo", 0)
        dr = command.ExecuteReader()
        While dr.Read()
            dg.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"), "", 0)
            dg.Rows(cont).Cells(5).Value = Format(dr("Cantidad") * dr("Precio"), "#,##0.00")
            cont = cont + 1

            'dg.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Ano"), dr("Precio"), 0)
        End While
        dr.Close()
    End Sub

    Public Shared Sub Elimina_Ubicaciones_Cero(ByVal cod As Integer)
        Try

            Dim c As New Collection

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUbicacionesAeliminar"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            While dr.Read

                c.Add(New comboItem(dr("CodigoProducto"), dr("CodigoTramo")))

            End While

            dr.Close()

            For cont As Integer = 1 To c.Count
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaTramoProductoDiferentes"
                command.Parameters.AddWithValue("@cod", c.Item(cont).name)
                command.Parameters.AddWithValue("@tramo", c.Item(cont).code)
                command.ExecuteNonQuery()
            Next


        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_numero_control(ByVal num As Integer, ByRef esta As Boolean)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_numero_control2"
            command.Parameters.AddWithValue("@num", num)
            dr = command.ExecuteReader()
            If dr.Read() Then
                esta = True
            Else
                esta = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex, "Error consultando Numero de control")
        End Try

    End Sub


    Public Shared Sub consulta_nroImp(ByRef num As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNroImp"
            dr = command.ExecuteReader()

            While dr.Read

                If dr("NroImp").GetType.ToString = "System.DBNull" Then
                    num = ""
                Else
                    num = dr("NroImp")
                End If

            End While

        Catch ex As Exception
            MsgBox(ex, "Error consultando correlativo")
        Finally
            dr.Close()
        End Try

    End Sub




    Public Shared Sub consulta_top_facturas(ByRef codigo As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_consulta_factura_top"
            dr = command.ExecuteReader()
            If dr.Read() Then
                codigo = (CInt(dr("ControlInicio")) + 1).ToString
            End If
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub sp_libroVentas(ByRef table As DataTable, ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal impOcrtl As Boolean, ByRef totalBase As Double, ByRef totalImp As Double, ByRef total As Double)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_libroVentas"
            command.Parameters.AddWithValue("@Fecha1", fecha1)
            command.Parameters.AddWithValue("@Fecha2", fecha2)
            command.Parameters.AddWithValue("@Tipo", impOcrtl)
            dr = command.ExecuteReader()

            While dr.Read

                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

                    If table.Rows.Count > 0 Then

                        If CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString) <> CInt(dr(1).ToString) - 1 And table.Rows(table.Rows.Count - 1).Item(3).ToString = "" And table.Rows(table.Rows.Count - 1).Item(1).ToString <> "0" Then

                            Dim i As Integer = 1

                            While i <= (CInt(dr(1).ToString) - 1) - CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString)
                                table.Rows.Add(table.Rows(table.Rows.Count - 1).Item(0).ToString, CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString) + 1, CInt(table.Rows(table.Rows.Count - 1).Item(2).ToString) + 1, "", "Anulado / Error Numeración", "0", Format(0, "#,##0.00"), Format(0, "#,##0.00"), Format(0, "#,##0.00"))
                            End While

                        End If

                        If Not CInt(table.Rows(table.Rows.Count - 1).Item(2).ToString) = CInt(dr(2).ToString) - 1 Then

                            Dim i As Integer = 1

                            While i <= (CInt(dr(2).ToString) - 1) - CInt(table.Rows(table.Rows.Count - 1).Item(2).ToString)
                                table.Rows.Add(table.Rows(table.Rows.Count - 1).Item(0).ToString, "0", CInt(table.Rows(table.Rows.Count - 1).Item(2).ToString) + 1, "0", "Correlativo Dañado", "0", Format(0, "#,##0.00"), Format(0, "#,##0.00"), Format(0, "#,##0.00"))
                            End While

                        End If

                    End If

                    table.Rows.Add(dr(0).ToString.Substring(0, 10), dr(1), dr(2), dr(3), dr(4), dr(5), Format(dr(6), "#,##0.00"), Format(dr(7), "#,##0.00"), Format(dr(8), "#,##0.00"))

                Else

                    'Esto es lo que coloca los 'Anulado'

                    If table.Rows.Count > 0 Then

                        If CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString) <> CInt(dr(1).ToString) - 1 And table.Rows(table.Rows.Count - 1).Item(3).ToString = "" Then

                            Dim i As Integer = 1

                            While i <= (CInt(dr(1).ToString) - 1) - CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString)
                                table.Rows.Add(table.Rows(table.Rows.Count - 1).Item(0).ToString, CInt(table.Rows(table.Rows.Count - 1).Item(1).ToString) + 1, CInt(table.Rows(table.Rows.Count - 1).Item(2).ToString) + 1, "", "Anulado / Error Numeración", "0", Format(0, "#,##0.00"), Format(0, "#,##0.00"), Format(0, "#,##0.00"))
                            End While

                        End If

                    End If

                    'Fin de lo que coloca los 'Anulado'

                    table.Rows.Add(dr(0).ToString.Substring(0, 10), dr(1), dr(2), dr(3), dr(4), dr(5), Format(dr(6), "#,##0.00"), Format(dr(7), "#,##0.00"), Format(dr(8), "#,##0.00"))

                End If


                    totalBase = totalBase + dr(6)
                    totalImp = totalImp + dr(7)
                    total = total + dr(8)


            End While

        Catch ex As Exception

            MsgBox(ex, "Error consultando libro de ventas")

        Finally

            dr.Close()

        End Try

    End Sub

End Class
