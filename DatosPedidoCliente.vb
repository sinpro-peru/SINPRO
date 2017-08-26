Imports System.Data.SqlClient

    Public Class DatosPedidoCliente

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Public Shared dr As SqlDataReader
    Shared item As Object
    Public cambiar As Boolean = True
    Public Shared dv As New DataView
    Public Shared dt As New DataTable
    Public Shared ds As New DataSet
    Public Shared da As New SqlClient.SqlDataAdapter
    Public Shared entrar As Boolean = False


    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    '------------ ya no lo usaremos por que ahora es un dgv
    Public Shared Sub consulta_existencia(ByRef cod As String, ByVal cant As Integer, ByRef sw As Boolean)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        dr.Read()
        If dr("cantidadexistencia") < cant Then
            sw = True
        End If
        dr.Close()
    End Sub
    '------------

    'consultarDiasCred

    Public Shared Sub consulta_DiasCred(ByRef tb As ComboBox)

        tb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_DiasCred"
        dr = command.ExecuteReader()

        While dr.Read()
            tb.Items.Add(dr("Dias"))
        End While
        dr.Close()

    End Sub

    Public Shared Sub alfa_beta_gamma(ByRef a As Double, ByRef b As Double, ByRef g As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_consultaABG"
        dr = command.ExecuteReader()
        If dr.Read() Then
            a = dr("alfa")
            b = dr("beta")
            g = dr("gamma")
        End If
        dr.Close()
    End Sub

    Public Shared Sub primera_fecha(ByVal cod As String, ByRef sw As Boolean)
        command.Parameters.Clear()
        command.CommandText = "sp_primerafecha"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        If dr.Read() Then
            Dim fecha As DateTime = dr(0)
            Dim dif As Long = DateDiff(DateInterval.Month, fecha, Date.Today)
            If dif > 35 Then
                sw = True
            End If
        End If
        dr.Close()
    End Sub

    Public Shared Sub primera_fechaII(ByVal cod As String, ByRef sw As Boolean)
        command.Parameters.Clear()
        command.CommandText = "sp_primerafecha"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        If dr.Read() Then
            Dim fecha As DateTime = dr(0)
            Dim dif As Long = DateDiff(DateInterval.Day, fecha, Date.Today)
            If dif > 175 Then
                sw = True
            End If
        End If
        dr.Close()
    End Sub

    Public Shared Sub demanda_semanal(ByVal cod As String, ByVal f1 As DateTime, ByVal f2 As DateTime, ByRef cant As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaDemandaSemanal"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@f1", f1)
        command.Parameters.AddWithValue("@f2", f2)
        dr = command.ExecuteReader()
        If dr.Read() Then
            cant = dr("cantidad")
        Else
            cant = 0
        End If
        dr.Close()
    End Sub
    Public Shared Sub compras_ano(ByVal f1 As DateTime, ByVal f2 As DateTime, ByRef l As Collection)
        Dim c As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_cuentaCompras"
        command.Parameters.AddWithValue("@f1", f1)
        command.Parameters.AddWithValue("@f2", f2)
        dr = command.ExecuteReader()
        While dr.Read()
            l.Add(dr("tiempo2"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub proveedores_producto(ByVal cod As String, ByRef col As Collection)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedoresProducto"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        While dr.Read()
            col.Add(dr("proveedor"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub cuenta_compras(ByVal codP As Integer, ByVal f1 As DateTime, ByVal f2 As DateTime, ByRef c As Collection)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_tiempo1"
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@f1", f1)
        command.Parameters.AddWithValue("@f2", f2)
        dr = command.ExecuteReader()
        While dr.Read()
            Dim j As Integer = dr("tiempo1")
            c.Add(j)
        End While
        dr.Close()
    End Sub
    Public Shared Sub cuenta_compras2(ByVal codP As Integer, ByVal f1 As DateTime, ByVal f2 As DateTime, ByRef c As Collection)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_tiempo1_2"
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@f1", f1)
        command.Parameters.AddWithValue("@f2", f2)
        dr = command.ExecuteReader()
        While dr.Read()
            Dim j As Integer = dr("tiempo1")
            c.Add(j)
        End While
        dr.Close()
    End Sub
    Public Shared Sub devuelve_n(ByRef valor As Integer, ByVal tipo As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaValor"
        command.Parameters.AddWithValue("@t", tipo)
        dr = command.ExecuteReader()
        dr.Read()
        valor = dr("valor")
        dr.Close()
    End Sub
    Public Shared Sub devuelve_week(ByRef valor As Integer, ByVal tipo As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaValor"
        command.Parameters.AddWithValue("@t", tipo)
        dr = command.ExecuteReader()
        dr.Read()
        valor = dr("valor")
        dr.Close()
    End Sub
    Public Shared Sub devuelve(ByRef valor As Integer, ByVal tipo As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaValor"
        command.Parameters.AddWithValue("@t", tipo)
        dr = command.ExecuteReader()
        dr.Read()
        valor = dr("valor")
        dr.Close()

    End Sub
    Public Shared Sub cantidad_existencia(ByVal c As String, ByRef cant As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        dr.Read()
        cant = dr("cantidadExistencia")
        dr.Close()

    End Sub


    Public Shared Sub DGV_PC(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer, ByRef total As String)

        DGV.Rows.Clear()
        Dim tot As Double = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvPedidoCliente"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then
            While dr.Read
                DGV.Rows.Add(dr("codigoPedido"), CStr(dr("fecha")), dr("CodigoCliente"), dr("razonSocial"), dr("Autorizado"), dr("Zona"), dr("MontoTotal"), "", "", "", dr("ModalidadEnvio"))
                tot = tot + dr("MontoTotal")
            End While
        Else
            While dr.Read
                DGV.Rows.Add(dr("codigoPedido"), CStr(dr("fecha")), dr("CodigoCliente"), dr("razonSocial"), dr("Autorizado"), dr("Zona"), dr("MontoTotal"))
                tot = tot + dr("MontoTotal")
            End While
        End If


        total = Format(tot, "#,##0.00").ToString
        dr.Close()

    End Sub

    Public Shared Sub consulta_pedidosclientes(ByVal DGV As DataGridView, ByRef Total As String)

        Try

            DGV.Rows.Clear()
            Dim tot As Double = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidoCliente3"
            dr = command.ExecuteReader()
            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then
                While dr.Read
                    DGV.Rows.Add(dr("CodigoPedido"), dr("fecha"), dr("Codigo"), dr("razonSocial"), dr("Autorizado"), dr("Zona"), dr("RIF"), dr("MontoTotal"), "", dr("usuario"), dr("modalidadEnvio"))
                    tot = tot + dr("MontoTotal")
                End While
            Else
                While dr.Read
                    DGV.Rows.Add(dr("CodigoPedido"), dr("fecha"), dr("Codigo"), dr("razonSocial"), dr("Autorizado"), dr("Zona"), dr("RIF"), dr("MontoTotal"), "", "", "")
                    tot = tot + dr("MontoTotal")
                End While
            End If


            Total = Format(tot, "#,##0.00").ToString

            dr.Close()

        Catch ex As Exception


            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_pedidosclientesNP(ByVal DGV As DataGridView, ByRef Total As String)

        Try

            DGV.Rows.Clear()
            Dim tot As Double = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidosNoProcesados_SINPRO"
            dr = command.ExecuteReader()
            While dr.Read
                DGV.Rows.Add(dr("CodigoPedido"), dr("fecha"), dr("CodigoCliente"), dr("razonSocial"), "No", dr("Zona"), dr("Observacion"), dr("Monto"), dr("DiasCred"), dr("usuario"), dr("ModalidadEnvio"))
                tot = tot + dr("Monto")
            End While

            Total = Format(tot, "#,##0.00").ToString

            DGV.ClearSelection()
            dr.Close()

        Catch ex As Exception


            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_productospedidoNP(ByVal codp As Integer, ByRef source As BindingSource, ByRef tables As DataTable, ByRef where As String, ByRef frm As Frm_Pedidos_Clientes)

        Try

            Dim cont As Integer = 0
            Dim cont2 As Integer = 0
            Dim Match As Boolean = False
            Dim o As String = ""
            Dim filter As String = ""

            source.Filter = filter
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosPedidoNoProcesado_SINPRO"
            command.Parameters.AddWithValue("@Cod", codp)
            dr = command.ExecuteReader()

            While dr.Read

                cont2 = cont2 + 1

            End While

            dr.Close()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosPedidoNoProcesado_SINPRO"
            command.Parameters.AddWithValue("@Cod", codp)
            dr = command.ExecuteReader()

            Dim cant(cont2 + 1) As Integer
            Dim cod(cont2 + 1) As String

            cont2 = 0

            While dr.Read

                cant(cont2) = CInt(dr("Cantidad"))
                cod(cont2) = dr("CodigoProducto")
                filter = filter + o + "CodigoInterno = '" & dr("CodigoProducto") & "'"
                o = " or "

                cont2 = cont2 + 1

            End While

            cont2 = 0

            dr.Close()

            source.Filter = filter
            where = filter

            cont = 0

            While cont2 < cod.Length - 1

                While cont <= frm.DGV2.RowCount - 1

                    If frm.DGV2.Rows(cont).Cells(1).Value.ToString = cod(cont2) Then

                        Match = True

                        Dim ubicRow() As Data.DataRow
                        ubicRow = tables.Select("CodigoInterno = '" & frm.DGV2.Rows(cont).Cells(1).Value & "'")
                        ubicRow(0)("Nombre") = "(" & cant(cont2).ToString & ") - " & ubicRow(0)("Nombre")

                        If CInt(frm.DGV2.Rows(cont).Cells(4).Value) >= cant(cont2) Then

                            If Not frm.DGV2.Rows(cont).Cells(6).Value Is Nothing Then

                                If frm.DGV2.Rows(cont).Cells(6).Value.ToString <> "Multiples" Then

                                    If frm.DGV2.Rows(cont).Cells(3).Value.ToString <> "Multiples" Then

                                        If frm.DGV2.Rows(cont).Cells(6).Value.ToString <> "" Then

                                            frm.DGV2.ClearSelection()
                                            frm.DGV2.Rows(cont).Cells(0).Selected = True
                                            frm.DGV2.Rows(cont).Cells(0).Value = cant(cont2)
                                            frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                            frm.DGV2.ClearSelection()

                                        End If

                                    Else

                                        If DatosConfiguracion.Consulta_pedidos_express() Then

                                            frm.DGV2.ClearSelection()
                                            frm.DGV2.Rows(cont).Cells(0).Selected = True
                                            frm.DGV2.Rows(cont).Cells(0).Value = cant(cont2)
                                            frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                            frm.f34.Button1_Click(frm.f34.Button1, New EventArgs)
                                            frm.DGV2.ClearSelection()

                                        End If

                                    End If

                                Else

                                    If DatosConfiguracion.Consulta_pedidos_express() Then

                                        frm.DGV2.ClearSelection()
                                        frm.DGV2.Rows(cont).Cells(0).Selected = True
                                        frm.DGV2.Rows(cont).Cells(0).Value = cant(cont2)
                                        frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                        frm.f34.Button1_Click(frm.f34.Button1, New EventArgs)
                                        frm.DGV2.ClearSelection()

                                    End If

                                End If

                            End If

                        Else

                            If CInt(frm.DGV2.Rows(cont).Cells(4).Value) > 0 Then

                                If Not frm.DGV2.Rows(cont).Cells(6).Value Is Nothing Then

                                    If frm.DGV2.Rows(cont).Cells(6).Value.ToString <> "Multiples" Then

                                        If frm.DGV2.Rows(cont).Cells(3).Value.ToString <> "Multiples" Then

                                            If frm.DGV2.Rows(cont).Cells(6).Value.ToString <> "" Then

                                                'Mandas lo que te quedaaaaaaaaaaa

                                                frm.DGV2.ClearSelection()
                                                frm.DGV2.Rows(cont).Cells(0).Selected = True
                                                'frm.DGV2.CurrentCell = frm.DGV2.Rows(cont).Cells(0)
                                                frm.DGV2.Rows(cont).Cells(0).Value = frm.DGV2.Rows(cont).Cells(4).Value
                                                frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                                frm.DGV2.ClearSelection()

                                            End If

                                        Else

                                            If DatosConfiguracion.Consulta_pedidos_express() Then

                                                frm.DGV2.ClearSelection()
                                                frm.DGV2.Rows(cont).Cells(0).Selected = True
                                                frm.DGV2.Rows(cont).Cells(0).Value = frm.DGV2.Rows(cont).Cells(4).Value
                                                frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                                frm.f34.Button1_Click(frm.f34.Button1, New EventArgs)
                                                frm.DGV2.ClearSelection()

                                            End If

                                        End If

                                    Else

                                        If DatosConfiguracion.Consulta_pedidos_express() Then

                                            frm.DGV2.ClearSelection()
                                            frm.DGV2.Rows(cont).Cells(0).Selected = True
                                            frm.DGV2.Rows(cont).Cells(0).Value = frm.DGV2.Rows(cont).Cells(4).Value
                                            frm.DGV_CellEndEdit(frm.DGV2, New DataGridViewCellEventArgs(0, cont))
                                            frm.f34.Button1_Click(frm.f34.Button1, New EventArgs)
                                            frm.DGV2.ClearSelection()

                                        End If

                                    End If

                                End If

                            End If

                        End If

                        cont = frm.DGV2.RowCount

                    Else

                        cont = cont + 1

                    End If


                End While

                cont = 0
                cont2 = cont2 + 1

            End While

            If source.Filter.Trim() = "CantidadExistencia > 0" Or source.Filter.Trim() = "" Then
                source.Filter = "CodigoInterno = '--1'"
            End If

            frm.DGV2.ClearSelection()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub

    Public Shared Sub inserta_pedidocliente(ByVal fecha As DateTime, ByVal codcliente As Integer, ByVal monto As Double, ByVal facturado As Boolean, ByVal vendedor As String, ByVal dias As String, ByVal obs As String, ByVal auto As Boolean, ByVal bultos As String, ByVal nro As Integer, ByVal obsint As String, ByVal usuario As String, ByVal modEnvio As Integer)
        Dim i As Integer = 0
        While i < nro
            command.Parameters.Clear()
            command.CommandText = "sp_insertaPedidoCliente"
            command.Parameters.AddWithValue("@fec", fecha)
            command.Parameters.AddWithValue("@codC", codcliente)
            command.Parameters.AddWithValue("@monT", monto)
            command.Parameters.AddWithValue("@fact", SqlDbType.Int).Value = 0
            command.Parameters.AddWithValue("@ven", vendedor)
            command.Parameters.AddWithValue("@Dias", CInt(dias))
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@auto", auto)
            command.Parameters.AddWithValue("@bultos", bultos)

            If My.Settings.Empresa = 5 Then
                command.Parameters.AddWithValue("@obsInt", obsint)
            ElseIf My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then
                command.Parameters.AddWithValue("@obsInt", obsint)
                command.Parameters.AddWithValue("@user", usuario)
                command.Parameters.AddWithValue("@modEnvio", modEnvio)
            End If

            command.ExecuteNonQuery()
            i = i + 1
        End While
    End Sub
    Public Shared Sub modifica_pedidocliente(ByVal codPed As Integer, ByVal fecha As DateTime, ByVal codcliente As Integer, ByVal monto As Double, ByVal ven As Integer, ByVal dias As String, ByVal obs As String, ByVal ch As CheckBox, ByVal auto As Boolean, ByVal bultos As Integer, ByVal obsint As String, ByVal modEnvio As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_modificaPedidoCliente"
        command.Parameters.AddWithValue("@fec", fecha)
        command.Parameters.AddWithValue("@codC", codcliente)
        command.Parameters.AddWithValue("@monT", monto)
        command.Parameters.AddWithValue("@fact", SqlDbType.Int).Value = 0
        command.Parameters.AddWithValue("@cod", codPed)
        command.Parameters.AddWithValue("@ven", CInt(ven))
        command.Parameters.AddWithValue("@Dias", CInt(dias))
        command.Parameters.AddWithValue("@Obs", obs)
        command.Parameters.AddWithValue("@chk", ch.Checked)
        command.Parameters.AddWithValue("@auto", auto)
        command.Parameters.AddWithValue("@bultos", bultos)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 8 Then
            command.Parameters.AddWithValue("@obsInt", obsint)
        End If

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then
            command.Parameters.AddWithValue("@modEnvio", modEnvio)
        End If

        command.ExecuteNonQuery()

    End Sub


    Public Shared Sub actaliza_precios_pedidos_por_facturar()

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_actualizaPreciosNoProcesados"
            command.ExecuteNonQuery()
            MsgBox("Precios actualizados", MsgBoxStyle.Information, "SINPRO")
        Catch ex As Exception
            MsgBox("Error actualizando precios", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Shared Sub modifica_Vendedorpedidocliente(ByVal codPed As Integer, ByVal ven As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaVendedorPedidoCliente"
        command.Parameters.AddWithValue("@cod", codPed)
        command.Parameters.AddWithValue("@ven", ven)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Autoriza_Pedidocliente(ByVal codPed As Integer, ByVal tipo As Boolean)
        command.Parameters.Clear()
        command.CommandText = "sp_AutorizapedidoCliente"
        command.Parameters.AddWithValue("@cod", codPed)
        command.Parameters.AddWithValue("@tipo", tipo)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Function Tramo(ByVal codPro As String, ByVal t As Integer) As Integer

        Try

            Dim tramoDestino As Integer = 0

            command.Parameters.Clear()
            command.CommandText = "sp_consultaUbicacionPro"
            command.Parameters.AddWithValue("@cod", codPro)
            command.Parameters.AddWithValue("@tramo", t)
            command.Parameters.AddWithValue("@tipo", 0)

            dr = command.ExecuteReader
            If Not dr.HasRows Then

                dr.Close()
                command.Parameters.Clear()
                command.CommandText = "sp_inserta_tramo_producto"
                command.Parameters.AddWithValue("@codP", codPro)
                command.Parameters.AddWithValue("@tramo", t)
                command.Parameters.AddWithValue("@cant", 0)
                command.ExecuteNonQuery()

            End If

            tramoDestino = t

            Return tramoDestino

        Catch ex As Exception
            MsgBox("El producto '" & codPro.ToString & "' no posee ubicación actual, no será devuelto a ninguna ubicación", MsgBoxStyle.Exclamation, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Function

    Public Shared Sub elimina_pedidocliente(ByVal cod As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_eliminaPedidoCliente"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub elimina_pedidoclienteNP(ByVal cod As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_eliminaPedidoClienteNP"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub consulta_cliente(ByRef cb As ComboBox)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCliente"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(dr("RazonSocial"), dr("CodigoCliente")))
        End While
        dr.Close()
    End Sub



    Public Shared Sub consulta_clientelike(ByRef cb As ComboBox, ByVal codigo As String, ByRef texto As String, ByVal tipo As Integer)
        If entrar = False Then
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaClientecombo2"
            command.Parameters.AddWithValue("@cod", codigo)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader()
            While dr.Read
                cb.Items.Add(New comboItem(dr("RazonSocial"), dr("CodigoCliente")))
            End While
            Dim i As Integer = cb.Items.Count
            If cb.Items.Count < 7 Then
                While i < 7
                    cb.Items.Add(New comboItem("", ""))
                    i = i + 1
                End While
            End If
            texto = cb.Text
            dr.Close()

            cb.DroppedDown = True
        End If
    End Sub


    Public Shared Sub consulta_identidadPedido(ByRef cod As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadPedido"
        dr = command.ExecuteReader()
        dr.Read()
        cod = dr(0) + 1
        dr.Close()
    End Sub

    Public Shared Sub IndicadoresCliente(ByVal cod As Integer, ByRef MontoPV As String, ByRef CantPV As String, ByRef MontoV As String, ByRef CantV As String, ByRef LimC As String, ByRef chequesDev As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_indicadoresAutorizacion"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()
            dr.Read()

            LimC = dr(1)
            MontoV = "Bs. " & Format(dr(2), "#,##0.00").ToString
            CantV = dr(3)
            MontoPV = "Bs. " & Format(dr(4), "#,##0.00").ToString
            CantPV = dr(5)
            chequesDev = dr(6)

            dr.Close()

        Catch ex As Exception

            MsgBox("Error consultando indicadores del cliente", MsgBoxStyle.Critical, "SINPRO")

        End Try

    End Sub


    Public Shared Sub consulta_pedido_producto_cliente(ByRef cod As String, ByRef t As DataGridView, ByRef fec As String, ByRef codP As String, ByRef monto As String, ByRef Iva As String, ByRef Total As String, ByRef Telf As String, ByRef Telf2 As String, ByRef Direccion As String, ByRef Dias As String, ByRef obs As String, ByRef ch As CheckBox, ByRef bultos As String, ByRef codC As Integer, ByRef cod2 As Integer, ByRef obsint As String, ByRef contacto As String, ByRef usuario As String)
        codP = CStr(cod)
        Dim montototal As Double = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPedido_Producto_Cliente"
        command.Parameters.AddWithValue("@codPed", cod)
        command.Parameters.AddWithValue("@Tipo", 0)
        dr = command.ExecuteReader()
        t.Rows.Clear()

        While dr.Read()
            t.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("Precio"), dr("SubTotal"), dr("Ubicacion"), dr("CodigoTramo"), True)
            montototal = montototal + CDbl(dr("SubTotal"))
        End While
        dr.Close()

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPedidoCliente"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        dr.Read()
        codC = CInt(dr("CodigoCliente"))
        cod2 = CInt(dr("Vendedor"))
        fec = dr("fecha")
        monto = CStr(Format(montototal, "#,##0.00"))
        Dim vendedor As Integer = (CInt(dr("vendedor")))
        If dr("DiasCred").GetType.ToString = "System.DBNull" Then
            Dias = ""
        Else
            Dias = dr("DiasCred")
        End If

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then

            If dr("ObservacionInterna").GetType.ToString = "System.DBNull" Then
                obsint = ""
            Else
                obsint = dr("ObservacionInterna")
            End If

            If dr("Contacto").GetType.ToString = "System.DBNull" Then
                contacto = ""
            Else
                contacto = dr("Contacto")
            End If

        End If

        If dr("Observacion").GetType.ToString = "System.DBNull" Then
            obs = ""
        Else
            obs = dr("Observacion")
        End If

        If dr("Chequeado").GetType.ToString = "System.DBNull" Then
            ch.Checked = False
        Else
            ch.Checked = dr("Chequeado")
        End If
        If dr("bultos").GetType.ToString = "System.DBNull" Then
            bultos = ""
        Else
            bultos = dr("bultos")
        End If

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 8 Then

            If dr("usuario").GetType.ToString = "System.DBNull" Then
                usuario = ""
            Else
                usuario = dr("usuario")
            End If

        End If

        dr.Close()

        Dim iva2 As New Double
        DatosFacturas.consulta_iva(iva2)
        Iva = CStr(Format(Math.Round(CDbl(monto) * (iva2 / 100), 2), "#,##0.00"))
        Total = CStr(Format(Math.Round(CDbl(monto) + CDbl(Iva), 2), "#,##0.00"))

    End Sub

    Public Shared Sub consulta_productos(ByRef t As DataTable)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto_GranSelect"
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            dRow("Cant.") = ""
            dRow("Código") = dr("CodigoInterno")
            dRow("Nombre") = dr("Nombre")
            dRow("Exis.") = dr("CantidadExistencia")
            dRow("Precio") = dr("PrecioVenta")
            dRow("Modelo") = dr("Modelo")

            If dr("Ubicacion").GetType.ToString = "System.DBNull" Then
                dRow("Ubic.") = ""
            Else
                dRow("Ubic.") = dr("Ubicacion")
            End If
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub

    Public Shared Sub consulta_productos2(ByRef dgv As MyDatagridView, ByVal cod As String, ByVal Tipo As Integer)

        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductoGranSelect2"
        command.Parameters.AddWithValue("@Tipo", Tipo)
        command.Parameters.AddWithValue("@Cod", cod)
        dr = command.ExecuteReader()
        While dr.Read()

            If dr("Ubicacion").GetType.ToString = "System.DBNull" Then

                If dr("CodigoTramo").GetType.ToString = "System.DBNull" Then
                    dgv.Rows.Add("", dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Modelo"), "", "")
                Else
                    dgv.Rows.Add("", dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Modelo"), "", dr("CodigoTramo"))
                End If
            Else
                If dr("CodigoTramo").GetType.ToString = "System.DBNull" Then

                    dgv.Rows.Add("", dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Modelo"), dr("Ubicacion"), "")
                Else
                    dgv.Rows.Add("", dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), dr("PrecioVenta"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"))
                End If

            End If

        End While

        dr.Close()
    End Sub
    Public Shared Sub consulta_producto_modelos(ByVal cod As String, ByRef lb As ListBox)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto_Modelos"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        While dr.Read()
            lb.Items.Add(dr("Modelo") + " " + dr("Ano"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_producto_ubicacion(ByRef dgv As DataGridView, ByVal cod As String, ByVal cant As String)
        Dim colec As New DataGridViewRowCollection(Frm_Principal.Frm_Pedidos_Clientes.DGV_Productos_Pedido)
        colec = Frm_Principal.Frm_Pedidos_Clientes.DGV_Productos_Pedido.Rows
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductoUbicacion"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        Dim ubica As String
        Dim sw As Boolean = False
        Dim cantidad As String = ""
        Dim cantcum As Integer = cant
        Dim i As Integer = 0
        While dr.Read()

            ubica = dr("NombreAlmacen") + "-" + dr("NombreCuarto") + "-" + dr("NombreEstante") + "-" + dr("NombreTramo")
            While i < colec.Count

                If cod = colec.Item(i).Cells(1).Value Then
                    If ubica = colec.Item(0).Cells(6).Value Then

                    End If
                End If
                i = i + 1
            End While
            If sw = False Then
                If cantcum <= dr("Cantidad") Then
                    cantidad = cantcum
                    sw = True
                ElseIf dr("Cantidad") > 0 Then
                    cantidad = dr("Cantidad")
                    cantcum = cantcum - cantidad
                End If

            Else
                cantidad = ""
            End If
            dgv.Rows.Add(ubica, dr("Cantidad"), cantidad, dr("CodigoTramo"))
        End While
        dr.Close()
    End Sub




    Public Shared Sub consulta_productos2(ByRef t As DataTable, ByVal codPed As Integer)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_Producto_Minus_Pedido"
        command.Parameters.AddWithValue("@codPed", codPed)
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            'dRow("Asociado") = False
            dRow("Cant.") = ""
            dRow("Nombre") = dr("Nombre")
            dRow("Código") = dr("CodigoInterno")
            dRow("Precio") = dr("PrecioVenta")
            dRow("Exis.") = dr("CantidadExistencia")
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub

    Public Shared Sub elimina_producto_pedido(ByVal l As Collection, ByVal codP As Integer)
        For Each item In l
            Dim int As Integer = CInt(item)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaPedido_Producto"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@codPto", int)
            command.ExecuteNonQuery()
        Next
    End Sub

    Public Shared Sub Procesar_Pedido_NP(ByVal codP As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_procesaPedidoNP"
            command.Parameters.AddWithValue("@cod", codP)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error marcando pedido como procesado", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Eliminar_Pedidos_NP_Viejos()

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaPedidosNPViejos"
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminado pedidos no procesados viejos", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub elimina_producto_pedido2(ByVal codP As Integer, ByVal codPto As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_eliminaPedido_Producto"
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.ExecuteNonQuery()

    End Sub
    Public Shared Sub elimina_producto_pedido3(ByVal codP As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_eliminaPedido_Producto2"
        command.Parameters.AddWithValue("@cod", codP)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub actualizar_producto_pedido(ByVal codP As Integer, ByVal codPto As String, ByVal c As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaPedido_Producto2"
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub insertar_producto_pedido(ByVal codP As Integer, ByVal codPto As String, ByVal c As Integer, ByVal p As Double, ByVal modelo As String, ByVal ubicacion As Integer, ByVal boton As String)

        Dim tramodestino As Integer = 0

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaPedido_Producto"
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.Parameters.AddWithValue("@pre", p)
        command.Parameters.AddWithValue("@modelo", modelo)
        command.Parameters.AddWithValue("@ubicacion", ubicacion)
        command.ExecuteNonQuery()

        If boton = "m" Then

            command.Parameters.Clear()
            command.CommandText = "sp_consultaUbicacionPro"
            command.Parameters.AddWithValue("@cod", codPto)
            command.Parameters.AddWithValue("@tramo", ubicacion)
            command.Parameters.AddWithValue("@tipo", 0)

            dr = command.ExecuteReader

            If dr.HasRows Then

                'Descontar existencia de los tramos

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_existencia_tramo"
                command.Parameters.AddWithValue("@Tramo", ubicacion)
                command.Parameters.AddWithValue("@CodP", codPto)
                command.Parameters.AddWithValue("@Cant", c)
                command.ExecuteNonQuery()


            Else

                dr.Close()
                command.Parameters.Clear()
                command.CommandText = "sp_consultaUbicacionPro"
                command.Parameters.AddWithValue("@cod", codPto)
                command.Parameters.AddWithValue("@tramo", ubicacion)
                command.Parameters.AddWithValue("@tipo", 1)
                dr = command.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        tramodestino = dr("Tramo")
                    End While
                Else
                    dr.Close()
                End If

                'Descontar existencia de los tramos
                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_existencia_tramo"
                command.Parameters.AddWithValue("@Tramo", tramodestino)
                command.Parameters.AddWithValue("@CodP", codPto)
                command.Parameters.AddWithValue("@Cant", c)
                command.ExecuteNonQuery()

            End If
        Else

            'Descontar existencia de los tramos

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_existencia_tramo"
            command.Parameters.AddWithValue("@Tramo", ubicacion)
            command.Parameters.AddWithValue("@CodP", codPto)
            command.Parameters.AddWithValue("@Cant", c)
            command.ExecuteNonQuery()

        End If

        'Descontar Cantidad Existencia

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_ActualizaExitencia"
        command.Parameters.AddWithValue("@CodP", codPto)
        command.Parameters.AddWithValue("@Cant", c)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub consulta_pedido_vendedor(ByVal cod As Integer, ByRef ven As MTGCComboBox)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPedidoCliente"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        Dim vendedor As Integer = 0
        While dr.Read()
            vendedor = (CInt(dr("vendedor")))
        End While
        dr.Close()

        Dim i As Integer = 0

        While i < ven.Items.Count
            If vendedor = ven.Items.Item(i).Col2 Then
                ven.SelectedIndex = i
                i = ven.Items.Count + 1
            End If
            i = i + 1
        End While
    End Sub

    Public Shared Sub Consulta_Clientes(ByRef Dir As String, ByRef tlf1 As String, ByRef tlf2 As String, ByVal codC As Integer, ByRef labelvisible As Boolean, ByVal cambio As Boolean, ByRef Tb As TextBox)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCliente2"
            command.Parameters.AddWithValue("@cod", codC)
            dr = command.ExecuteReader()
            dr.Read()
            If dr("Telefono1").GetType.ToString = "System.DBNull" Then
                tlf1 = ""
            Else
                tlf1 = dr("Telefono1")
            End If
            If dr("Telefono2").GetType.ToString = "System.DBNull" Then
                tlf2 = ""
            Else
                tlf2 = dr("Telefono2")
            End If
            If dr("Direccion").GetType.ToString = "System.DBNull" Then
                Dir = ""
            Else
                Dir = dr("Direccion")
            End If

            If dr("autorizado") = True Then
                labelvisible = False
            Else
                labelvisible = True
            End If

            If cambio Then
                Tb.Text = dr("Nombre")
                Tb.Tag = dr("CodigoVendedor")
            End If

        Catch ex As Exception

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Retorna_Iva(ByRef iva As Double)

        Try
            DatosFacturas.consulta_iva(iva)
            Format(iva, "#,##0.00")
        Catch ex As Exception
            MsgBox("Error cargando iva", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub llenar_clientes(ByRef cb As ComboBox, ByRef cb2 As ComboBox, ByVal id As Integer)


        Try
            cb.DataSource = Nothing
            cb.Items.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaCliente"
            command.Parameters.AddWithValue("@Cod", id)

            dr = command.ExecuteReader
            While dr.Read
                cb.Items.Add(dr("RazonSocial"))
                cb2.Items.Add(dr("CodigoCliente"))
            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Error cargando lista de clientes", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub llenar_clienteslike(ByRef cb As ComboBox, ByRef cb2 As ComboBox, ByVal id As String)
        'Dim item As String = ""
        'cb.SelectedItem
        'If Not cb.SelectedItem = Nothing Then
        '    item = cb.SelectedText.ToString
        'End If


        Try

            cb.Items.Clear()
            cb2.Items.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaClienteCombo"
            command.Parameters.AddWithValue("@Cod", id)

            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(dr("RazonSocial"))
                cb2.Items.Add(dr("CodigoCliente"))


            End While

            dr.Close()
            'cb.SelectedText = item

        Catch ex As Exception

            MsgBox("Error cargando lista de clientes", MsgBoxStyle.Critical)


        End Try

    End Sub


    Public Shared Sub AumentaExist(ByVal CodP As String, ByVal cant As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AumentaExitencia"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cant", cant)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando los productos del pedido", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Shared Sub AumentaExist2(ByVal CodP As String, ByVal CodT As Integer, ByVal cant As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_AumentaExitencia2"
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@CodT", CodT)
            command.Parameters.AddWithValue("@Cant", cant)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando los productos del pedido", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Shared Sub consulta_pedido_chequeo(ByVal cod As Integer, ByRef dgv As DataGridView, ByRef lbl As Label, ByRef chequeado As Boolean, ByRef obs As TextBox, ByRef bultos As String, ByRef dest As String)


        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodPed", cod)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.CommandText = "sp_consultaPedido_Producto_Cliente"
            dr = command.ExecuteReader

            While dr.Read

                If dr("Chequeado") = False Then

                    dgv.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("CodigoProductoF"), dr("Nombre"), dr("Modelo"))
                    lbl.Text = dr("RazonSocial")

                    If dr("Estado").ToString = "System.DBNull" Then
                        dest = ""
                    Else
                        dest = dr("Estado").ToString
                    End If

                    If dr("Observacion").ToString = "System.DBNull" Then
                        obs.Text = ""
                    Else
                        obs.Text = dr("Observacion").ToString
                    End If
                    If dr("bultos").ToString = "System.DBNull" Then
                        bultos = ""
                    Else
                        bultos = dr("bultos").ToString
                    End If

                End If

                chequeado = dr("Chequeado")

            End While

        Catch ex As Exception

            MsgBox("Error cargando los productos del pedido", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try




    End Sub



    Public Shared Sub modifica_Pedido_Chequeo(ByVal codP As Integer, ByVal obs As String, ByVal bultos As Integer)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_pedido_chequeado"
            command.Parameters.AddWithValue("@cod", codP)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@bultos", bultos)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error editando pedido", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Public Shared Sub actualizar_catidad_producto(ByVal codP As String, ByVal cant As Integer)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaExitencia"
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@cant", cant)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub actualizar_monto_pedido(ByVal codP As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Actualiza_monto_pedido"
            command.Parameters.AddWithValue("@codP", codP)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function MaxArt() As Integer
        Try
            Dim Max As Integer = 0

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMaxArtPed"
            dr = command.ExecuteReader

            While dr.Read

                Max = dr("MaxArt")

            End While

            Return Max

        Catch ex As Exception

            MsgBox("Error consultando máximo de articulos")


        Finally

            dr.Close()

        End Try

    End Function

    Public Shared Function Autorizado(ByVal MontoPedido As Double, ByVal CodigoCliente As Integer) As Boolean

        Try

            Dim Autorization1 As Boolean = False
            Dim Autorization2 As Boolean = False
            Dim Autorization3 As Boolean = False
            Dim Autorization4 As Boolean = False
            Dim Autorization5 As Boolean = False
            Dim ValidarCheque As Boolean = False

            '--------------------------- Comparación de monto máximo de pedido -----------------------------'

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaParametrosAutorizacion"
            dr = command.ExecuteReader()

            While dr.Read

                If MontoPedido <= dr("MontoPedido") Then
                    Autorization1 = True
                    ValidarCheque = dr("ChequesDev")
                End If

            End While

            dr.Close()

            '------------------------ Comparación de montos vencidos y por vencer -------------------------'

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSaldoCliente"
            command.Parameters.AddWithValue("@Cod", CodigoCliente)
            command.Parameters.AddWithValue("@Tipo", 1)
            dr = command.ExecuteReader()

            While dr.Read

                Autorization2 = dr("MontoVencido")

            End While


            dr.Close()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSaldoCliente"
            command.Parameters.AddWithValue("@Cod", CodigoCliente)
            command.Parameters.AddWithValue("@Tipo", 2)
            dr = command.ExecuteReader()

            While dr.Read

                Autorization3 = dr("MontoPendiente")

            End While


            dr.Close()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSaldoCliente"
            command.Parameters.AddWithValue("@Cod", CodigoCliente)
            command.Parameters.AddWithValue("@Tipo", 3)
            dr = command.ExecuteReader()

            While dr.Read

                If dr("LimiteCredito") <> 0 Then
                    If MontoPedido + dr("MontoPendiente") <= dr("LimiteCredito") Then
                        Autorization4 = True
                    End If
                Else
                    Autorization4 = False
                End If


            End While


            dr.Close()

            If ValidarCheque Then

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaNumChequesDev"
                command.Parameters.AddWithValue("@Cod", CodigoCliente)
                dr = command.ExecuteReader()

                While dr.Read

                    If dr("ChequesDev").GetType.ToString <> "System.DBNull" Then

                        If dr("ChequesDev") > 0 Then

                            Autorization5 = False

                        End If

                    Else

                        Autorization5 = True

                    End If


                End While


                dr.Close()

            End If

            If ValidarCheque Then

                If Autorization5 Or (Autorization4 Or (Autorization1 = True And Autorization2 = True And Autorization3 = True)) Then

                    Return True

                Else

                    Return False

                End If

            Else

                If Autorization4 Or (Autorization1 = True And Autorization2 = True And Autorization3 = True) Then

                    Return True

                Else

                    Return False

                End If


            End If


        Catch ex As Exception

            MsgBox("Error consultando parámetros de autorización")

        Finally

            dr.Close()

        End Try

    End Function
    Public Shared Sub modifica_observacion_pedido(ByVal obs As String, ByVal cod As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modifica_observacion_pedido_cliente"
            command.Parameters.AddWithValue("@obs", obs)
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error actualizando la observacion del pedido", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Public Shared Sub Consulta_totales_pedidos(ByRef pedP As String, ByRef clienP As String, ByRef pedNP As String, ByRef clienNP As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTotalPedidos"
            dr = command.ExecuteReader()

            While dr.Read()

                pedP = dr("PedidosP")
                clienP = dr("ClientesP")
                pedNP = dr("PedidosNP")
                clienNP = dr("ClientesNP")

            End While

        Catch ex As Exception

            MsgBox("Error consultando total de pedidos", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_pedido_producto_cliente_tabla(ByRef cod As String, ByRef t As DataTable, ByRef tipo As Integer)


        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPedido_Producto_Cliente"
        command.Parameters.AddWithValue("@codPed", cod)
        command.Parameters.AddWithValue("@Tipo", tipo)
        dr = command.ExecuteReader()
        t.Rows.Clear()

        While dr.Read()
            t.Rows.Add(dr("Ubicacion"), dr("Cantidad"), dr("CodigoProducto"), dr("CodigoProductoF"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("Codigo"), dr("RazonSocial"))
        End While
        dr.Close()
    End Sub


    Public Shared Sub consulta_indicadoresPedido(ByRef MontoTotal As String, ByRef MaxDias As String, ByRef PromedioDias As String, ByRef UltimaFact As String, ByRef OtrosPedidos As String, ByRef MesMaxCompra As String, ByRef MaxCompra As String, ByRef PromedioCompras As String, ByRef CodigoCliente As Integer, ByRef CodigoPedido As Integer, ByVal Tipo As Integer)

        Try

            Dim mes As String = ""
            Dim max As Double = 0
            Dim prom As Double = 0
            Dim total As Double = 0

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaIndicadoresPedidoVenta"
            command.Parameters.AddWithValue("@CodC", CodigoCliente)
            command.Parameters.AddWithValue("@CodP", CodigoPedido)
            command.Parameters.AddWithValue("@Tipo", Tipo)

            dr = command.ExecuteReader()

            While dr.Read

                If Tipo <= 2 Then

                    If dr("MontoTotal").GetType.ToString = "System.DBNull" Then
                        MontoTotal = ""
                    Else
                        MontoTotal = Format(dr("MontoTotal"), "#,##0.00")
                    End If

                    If dr("MaxDias").GetType.ToString = "System.DBNull" Then
                        MaxDias = "0"
                    Else
                        MaxDias = dr("MaxDias")
                    End If

                    If dr("PromedioDias").GetType.ToString = "System.DBNull" Then
                        PromedioDias = "0"
                    Else
                        PromedioDias = dr("PromedioDias")
                    End If

                ElseIf Tipo = 3 Then
                    If dr("UltimaFact").GetType.ToString = "System.DBNull" Then
                        UltimaFact = ""
                    Else
                        UltimaFact = dr("UltimaFact")
                    End If
                ElseIf Tipo = 4 Then
                    If dr("OtrosPedidos").GetType.ToString = "System.DBNull" Then
                        OtrosPedidos = "0,00"
                    Else
                        OtrosPedidos = Format(dr("OtrosPedidos"), "#,##0.00")
                    End If
                ElseIf Tipo = 5 Then

                    If dr("Total") > max Then
                        mes = dr("Mes")
                        max = dr("Total")
                    End If

                    total += dr("total")

                End If

            End While

            prom = total / 12

            MaxCompra = Format(max, "#,##0.00")
            MesMaxCompra = mes
            PromedioCompras = Format(prom, "#,##0.00")

            dr.Close()

        Catch ex As Exception
            MsgBox("Error consultando indicadores", MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
        End Try

    End Sub

End Class
