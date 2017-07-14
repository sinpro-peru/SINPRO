Imports System.Data.SqlClient
Public Class DatosRecibo
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_recibos(ByVal lv As ListView, ByVal par As Integer, ByRef tc As Double)
        tc = 0
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaRecibo2"
        command.Parameters.AddWithValue("@codF", par)
        dr = command.ExecuteReader()
        Dim fec As DateTime
        While dr.Read
            fec = dr("fecha")
            Dim c As Integer = dr("codigoRecibo")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(CStr(fec))
            i.SubItems.Add(dr("Monto"))
            lv.Items.Add(i)
            tc = tc + dr("Monto")
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_facturas(ByRef t As DataGridView, ByVal c As Integer, ByVal fechaD As Date, ByVal cc As String)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFacturas_Recibo"
        command.Parameters.AddWithValue("@cod", c)
        command.Parameters.AddWithValue("@Tipo", 3)
        dr = command.ExecuteReader()
        While dr.Read()
            If dr("Monto") < 0 Then
                t.Rows.Add(dr("controlInicio"), cc, dr("fecha"), "", dr("MontoTotal"), dr("Monto"), "", dr("codigoFactura"), dr("MontoNC"), dr("Retencion"), dr("Iva"))
                t.Rows(t.Rows.Count - 1).Cells(5).Style.ForeColor = Color.Blue
            Else
                t.Rows.Add(dr("controlInicio"), cc, dr("fecha"), fechaD, dr("MontoTotal"), dr("Monto"), DateDiff(DateInterval.Day, dr("fecha"), fechaD), dr("codigoFactura"), dr("MontoNC"), dr("Retencion"), dr("Iva"))
            End If

        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_recibos_vendedor_pendientes(ByRef t As DataGridView, ByVal ven As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal Par As Boolean, ByRef sw As Boolean, ByRef lb As String, ByRef OcultaCom As Boolean)

        Try

            Dim total As Double = 0
            t.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaReciboVendedorPendiente"
            command.Parameters.AddWithValue("@ven", ven)
            command.Parameters.AddWithValue("@fec1", fecha1)
            command.Parameters.AddWithValue("@fec2", fecha2)
            command.Parameters.AddWithValue("@par", Par)
            dr = command.ExecuteReader()

            While dr.Read()

                t.Rows.Add(dr("codigoRecibo"), dr("NControl"), dr("fechaD"), dr("Monto"), dr("Observacion"))

                If dr("OcultaCom").GetType.ToString = "System.DBNull" Then
                    OcultaCom = False
                Else
                    OcultaCom = dr("OcultaCom")
                End If

                total = total + dr("Monto")
            End While

            lb = FormatNumber(total, 2)
            sw = True

        Catch ex As Exception

            MsgBox("Error consultando recibos pendientes", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub
    Public Shared Sub consulta_recibos_todos(ByVal lv As DataGridView, ByRef cant As Integer, ByVal pd As Boolean)
        Try
            lv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaRecibos"
            command.Parameters.AddWithValue("@tipo", pd)
            dr = command.ExecuteReader()
            While dr.Read
                cant = cant + 1
                lv.Rows.Add(dr("codigoRecibo"), dr("NControl"), dr("codigoCliente"), dr("RazonSocial"), dr("ContEspecial"))
            End While
        Catch ex As Exception

        Finally
            dr.Close()
        End Try
    End Sub


    Public Shared Sub busca_recibos(ByRef lv As DataGridView, ByVal s As String, ByVal val As Integer, ByVal pd As Boolean)
        lv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvrecibo"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        command.Parameters.AddWithValue("@tipo2", pd)
        dr = command.ExecuteReader()
        While dr.Read
            lv.Rows.Add(dr("codigoRecibo"), dr("NControl"), dr("codigoCliente"), dr("RazonSocial"), dr("ContEspecial"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_Recibo(ByVal c As Integer, ByRef tbC As String, ByRef tbM As String, ByRef tbFC As Date, ByRef tbFD As Date, ByRef tbB As MTGCComboBox, ByRef tbCH As String, ByRef TBD As String, ByRef tbO As String, ByRef efec As String, ByRef banco As String, ByRef dev As CheckBox, ByRef porc As String, ByRef fechadev As Date, ByRef pd As CheckBox, ByRef ndepdev As String, ByRef tb_bancodep As MTGCComboBox, ByRef CompRet As String, ByRef CompRecibido As Boolean, ByRef usuario As String)
        Try
            Dim bancodep As Integer
            Dim banco2 As String = ""
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaRecibo"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()
            dr.Read()
            tbC = dr("NControl")

            If dr("Monto") = 0 Then
                tbM = ""
            Else
                tbM = Format(dr("Monto"), "#,##0.00")
            End If


            tbFC = CStr(dr("FechaC"))

            If dr("BancoD").GetType.ToString = "System.DBNull" Then
                bancodep = 0
                banco2 = "Sin informacion"
            Else
                bancodep = dr("BancoD")
            End If


            If dr("ComprobanteRet").GetType.ToString = "System.DBNull" Then
                CompRet = ""
            Else
                CompRet = dr("ComprobanteRet")
            End If

            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then

                If dr("ComprobanteRecibido").GetType.ToString = "System.DBNull" Then
                    CompRecibido = False
                Else
                    CompRecibido = dr("ComprobanteRecibido")
                End If

                If dr("Usuario").GetType.ToString = "System.DBNull" Then
                    usuario = ""
                Else
                    usuario = dr("Usuario")
                End If

            End If

            If bancodep = 0 Then

                Dim cont2 As Integer = 0

                While cont2 < tb_bancodep.Items.Count
                    If tb_bancodep.Items(cont2).col1.ToString.ToUpper = banco2.ToUpper Then
                        tb_bancodep.SelectedIndex = cont2
                        cont2 = tb_bancodep.Items.Count + 1
                    Else
                        cont2 = cont2 + 1
                    End If
                End While

            Else

                Dim cont2 As Integer = 0

                While cont2 < tb_bancodep.Items.Count
                    If tb_bancodep.Items(cont2).col2.ToString = bancodep Then
                        tb_bancodep.SelectedIndex = cont2
                        cont2 = tb_bancodep.Items.Count + 1
                    Else
                        cont2 = cont2 + 1
                    End If
                End While

            End If


            If dr("NDepositoDev").GetType.ToString = "System.DBNull" Then
                ndepdev = ""
            Else
                ndepdev = dr("NDepositoDev")
            End If
            If dr("Retencion").GetType.ToString = "System.DBNull" Then
                porc = ""
            Else
                porc = dr("Retencion")
            End If
            If dr("NDeposito") = "0" Then
                TBD = ""
            Else
                TBD = dr("NDeposito")
            End If

            If dr("Nombre").GetType.ToString = "System.DBNull" Then

                Dim cont As Integer = 0

                While cont < tbB.Items.Count

                    If tbB.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                        tbB.SelectedIndex = cont
                        cont = tbB.Items.Count + 1
                    Else
                        cont = cont + 1
                    End If

                End While

            Else

                Dim cont As Integer = 0

                While cont < tbB.Items.Count

                    If tbB.Items(cont).col1.ToString = dr("Nombre") Then
                        tbB.SelectedIndex = cont
                        cont = tbB.Items.Count + 1
                    Else
                        cont = cont + 1
                    End If

                End While

            End If

            If dr("NCheque").GetType.ToString = "System.DBNull" Then
                tbCH = ""
            Else
                tbCH = dr("NCheque")
            End If
            If dr("FechaD").GetType.ToString = "System.DBNull" Then
                tbFD = ""
            Else
                tbFD = dr("FechaD")
            End If
            If dr("Observacion").GetType.ToString = "System.DBNull" Then
                tbO = ""
            Else
                tbO = dr("Observacion")
            End If
            If CDbl(dr("Efectivo")) = 0 Then
                efec = ""
            Else
                efec = FormatNumber(CDbl(dr("Efectivo")), 2)
            End If
            If dr("Dev") = False Then
                dev.Checked = False
            Else
                dev.Checked = True
                fechadev = dr("FechaDev")
            End If

            If dr("pd") = False Then
                pd.Checked = False
            Else
                pd.Checked = True
            End If

        Catch ex As Exception

        Finally

            dr.Close()

        End Try
    End Sub
    Public Shared Sub identidad_Recibo(ByRef tb As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadRecibo"
        dr = command.ExecuteReader
        dr.Read()
        tb = dr("Expr1")
        dr.Close()
    End Sub
    Public Shared Sub consulta_ReciboPagado(ByRef cod As Integer, ByRef pagado As Boolean)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaReciboPagado"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader
        dr.Read()
        If dr("PagadoComision") = 0 Then
            pagado = False
        Else
            pagado = True
        End If
        dr.Close()
    End Sub

    Public Shared Function consulta_UltimoCodRecibo() As Integer

        Dim codR As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_UltimoCodRecibo"
        dr = command.ExecuteReader
        dr.Read()
        codR = dr("CodigoRecibo")
        dr.Close()

        Return codR

    End Function


    Public Shared Sub inserta_recibo(ByVal control As String, ByVal monto As String, ByVal fec As DateTime, ByVal ndeposito As String, ByVal bancoC As Integer, ByVal cheque As String, ByVal efectivo As String, ByVal bancod As Integer, ByVal fechaD As DateTime, ByVal observacion As String, ByVal Dev As Boolean, ByVal Retencion As Double, ByVal fechadev As DateTime, ByVal pd As Boolean, ByVal depositodev As String, ByVal compRet As String, ByVal tipo As Integer, ByVal compRecibido As Boolean, ByVal usuario As String)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaRecibo"
        If control = "" Then
            command.Parameters.AddWithValue("@cont", "S/N")
        Else
            command.Parameters.AddWithValue("@cont", control)
        End If

        If Not monto = "" Then
            command.Parameters.AddWithValue("@mon", CDbl(monto))
        Else
            command.Parameters.AddWithValue("@mon", 0)
        End If
        If Not ndeposito.ToString = "" Then
            command.Parameters.AddWithValue("@NDep", ndeposito)
        Else
            command.Parameters.AddWithValue("@NDep", 0)
        End If
        command.Parameters.AddWithValue("@fecC", fec.Date)
        command.Parameters.AddWithValue("@banC", bancoC)
        command.Parameters.AddWithValue("@che", cheque)
        command.Parameters.AddWithValue("@CompRet", compRet)
        If Not efectivo = "" Then
            command.Parameters.AddWithValue("@efe", CDbl(efectivo))
        Else
            command.Parameters.AddWithValue("@efe", 0)
        End If
        command.Parameters.AddWithValue("@banD", bancod)
        command.Parameters.AddWithValue("@fecD", fechaD)
        command.Parameters.AddWithValue("@obs", observacion)
        command.Parameters.AddWithValue("@Dev", Dev)
        command.Parameters.AddWithValue("@Ret", Retencion)
        command.Parameters.AddWithValue("@fechaDev", fechadev)
        command.Parameters.AddWithValue("@pd", pd)
        command.Parameters.AddWithValue("@depdev", depositodev)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then
            command.Parameters.AddWithValue("@compReci", compRecibido)
            command.Parameters.AddWithValue("@user", usuario)
        End If

        command.ExecuteNonQuery()

        If tipo = 0 Then
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Recibo registrado satisfactoriamente", ToolTipIcon.Info)
        End If

    End Sub
    Public Shared Sub inserta_Factura_Recibo(ByVal codF As Integer, ByVal codR As Integer, ByVal Monto As Double, ByVal retencion As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaFactura_Recibo"
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@codR", codR)
        command.Parameters.AddWithValue("@Monto", Monto)
        command.Parameters.AddWithValue("@Ret", retencion)
        command.ExecuteNonQuery()
    End Sub


    Public Shared Sub Modifica_Factura_Recibo(ByVal codF As Integer, ByVal codR As Integer, ByVal Monto As Double, ByVal retencion As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_ModificaFactura_Recibo"
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@codR", codR)
        command.Parameters.AddWithValue("@Monto", Monto)
        command.Parameters.AddWithValue("@Ret", retencion)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ConsultaRecibosNCPorMov(ByRef dgv As DataGridView, ByVal dep As String, ByVal banco As Integer, ByVal Monto As Double, ByVal tipo As Integer)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandText = "sp_consultaReciboMov"
            command.Parameters.AddWithValue("@ndep", dep)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@monto", CDbl(Monto))
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("NControl"), dr("RazonSocial"), dr("Monto"), dr("CodigoRecibo"))

            End While

        Catch ex As Exception

            MsgBox("Error consultando recibos por confirmar", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()
            dgv.ClearSelection()

        End Try

    End Sub

    Public Shared Function Confirma_Recibo(ByVal NDep As String, ByVal banco As Integer, ByVal Monto As String, ByVal codR As Integer) As Boolean

        Dim success As Boolean = False

        Try

            Dim fechaMov As Date
            Dim existe As Boolean = False
            Dim Asociado As Boolean = False
            Dim dep As String = ""

            NDep = NDep.ToUpper.Replace("X", "")

            If NDep.Length > 11 Then
                NDep = NDep.Substring(NDep.Length - 11)
            Else
                While NDep.Length < 11
                    NDep = "0" + NDep
                End While
            End If

            command.Parameters.Clear()
            command.CommandText = "sp_consulta_confirmaRecibo"
            command.Parameters.AddWithValue("@ndep", NDep)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@monto", Monto)
            dr = command.ExecuteReader()

            While dr.Read

                existe = True
                Asociado = dr("Asociado")
                dep = dr("NumeroDeposito")
                fechaMov = dr("fecha")

            End While

            dr.Close()

            If existe And Asociado Then

                Dim existe2 As Boolean = False

                command.Parameters.Clear()
                command.CommandText = "sp_consultaReciboMov"
                command.Parameters.AddWithValue("@ndep", dep)
                command.Parameters.AddWithValue("@banco", banco)
                command.Parameters.AddWithValue("@monto", CDbl(Monto))
                command.Parameters.AddWithValue("@tipo", 0)
                dr = command.ExecuteReader()

                While dr.Read

                    existe2 = True

                End While

                dr.Close()

                If existe2 Then
                    MsgBox("Ya existe un recibo asociado a éste num. de depósito", MsgBoxStyle.Exclamation, "SINPRO")
                Else
                    command.Parameters.Clear()
                    command.CommandText = "sp_confirmaRecibo"
                    command.Parameters.AddWithValue("@CodR", codR)
                    command.Parameters.AddWithValue("@ndep", dep)
                    command.Parameters.AddWithValue("@fechaMov", fechaMov)
                    command.ExecuteNonQuery()
                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Recibo confirmado satisfactoriamente", ToolTipIcon.Info)
                    success = True
                End If


            ElseIf existe And Not Asociado Then

                command.Parameters.Clear()
                command.CommandText = "sp_confirmaRecibo"
                command.Parameters.AddWithValue("@CodR", codR)
                command.Parameters.AddWithValue("@ndep", dep)
                command.Parameters.AddWithValue("@fechaMov", fechaMov)
                command.ExecuteNonQuery()

                command.Parameters.Clear()
                command.CommandText = "sp_asocia_movimiento"
                command.Parameters.AddWithValue("@ndep", dep)
                command.Parameters.AddWithValue("@banco", banco)
                command.Parameters.AddWithValue("@monto", Monto)
                command.ExecuteNonQuery()

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Recibo confirmado satisfactoriamente", ToolTipIcon.Info)
                success = True

            ElseIf Not existe Then

                MsgBox("No se puede confirmar este recibo, el nro. de depósito no está registrado", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Catch ex As Exception

            MsgBox("Error confirmando recibo", MsgBoxStyle.Critical, "Error")
            dr.Close()

        End Try

        Return success

    End Function

    Public Shared Sub modifica_recibo(ByVal cod As Integer, ByVal con As String, ByVal monto As String, ByVal fecha As Date, ByVal dep As String, ByVal banco As Integer, ByVal cheque As String, ByVal efec As String, ByVal bancod As Integer, ByVal fechad As Date, ByVal obs As String, ByVal ch As Boolean, ByVal retencion As Double, ByVal fechaDev As Date, ByVal depdev As String, ByVal chpd As Boolean, ByVal compRet As String, ByVal tipo As Integer, ByVal compRecibido As Boolean)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaRecibo"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@con", con)
        command.Parameters.AddWithValue("@CompRet", compRet)
        If monto = "" Then
            command.Parameters.AddWithValue("@monto", 0)
        Else
            command.Parameters.AddWithValue("@monto", CDbl(monto))
        End If
        If efec = "" Then
            command.Parameters.AddWithValue("@efec", 0)
        Else
            command.Parameters.AddWithValue("@efec", CDbl(efec))
        End If

        command.Parameters.AddWithValue("@fecha", fecha)
        command.Parameters.AddWithValue("@dep", dep)
        command.Parameters.AddWithValue("@cheque", cheque)
        command.Parameters.AddWithValue("@fechad", fechad)
        command.Parameters.AddWithValue("@obs", obs)
        command.Parameters.AddWithValue("@bancoC", banco)
        command.Parameters.AddWithValue("@bancod", bancod)
        command.Parameters.AddWithValue("@Dev", ch)
        command.Parameters.AddWithValue("@Ret", retencion)
        command.Parameters.AddWithValue("@fechadev", fechaDev)
        command.Parameters.AddWithValue("@depdev", depdev)
        command.Parameters.AddWithValue("@chpd", chpd)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then
            command.Parameters.AddWithValue("@CompReci", compRecibido)
        End If

        command.ExecuteNonQuery()

        If tipo = 0 Then
            MsgBox("El Recibo Ha Sido Modificado Exitosamente")
        End If

    End Sub
    Public Shared Sub elimina_Recibo(ByVal cod As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaRecibo"
            command.Parameters.AddWithValue("@codR", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando recibo, puede tener comisiones asociadas", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub
    Public Shared Sub elimina_Facturas_Recibo(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminafacturas_recibo"
        command.Parameters.AddWithValue("@codR", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub consulta_clientes(ByVal lv As DataGridView, ByRef cant As Integer)
        Dim par As Integer
        par = 0
        lv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCliente"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            cant = cant + 1
            lv.Rows.Add(0, 0, dr("codigoCliente"), dr("razonSocial"), dr("contEspecial"))
        End While
        lv.ClearSelection()
        dr.Close()
    End Sub

    Public Shared Sub lv_Cliente(ByRef lv As DataGridView, ByVal s As String, ByVal val As Integer, ByVal val2 As Integer)
        If val = 0 Then
            val = 1
        Else
            val = 0
        End If
        lv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvcliente"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        command.Parameters.AddWithValue("@vend", SqlDbType.Int).Value = val2
        dr = command.ExecuteReader()
        While dr.Read
            lv.Rows.Add(0, 0, dr("codigoCliente"), dr("razonSocial"), dr("contEspecial"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_recibos_cliente(ByRef t As DataGridView, ByVal c As Integer)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFacturas_Recibo"
        command.Parameters.AddWithValue("@cod", c)
        command.Parameters.AddWithValue("@Tipo", 1)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(dr("controlInicio"), dr("NControl"), dr("Fecha"), dr("FechaD"), dr("montoTotal"), dr("Monto"), DateDiff(DateInterval.Day, dr("fecha"), dr("fechaD")), dr("CodigoFactura"), dr("MontoNC"), dr("Retencion"), dr("CodigoRecibo"), dr("Ajuste"))
        End While
        dr.Close()
    End Sub


    Public Shared Sub consulta_cliente_R(ByVal c As Integer, ByRef t As DataGridView, ByRef lb_deuda As Label, ByRef lb_favor As Label)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClienteFacturas"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        Dim fecha1 As Date
        Dim fecha2 As Date
        Dim deuda As Double
        Dim favor As Double
        deuda = 0.0
        favor = 0.0
        While dr.Read()

            fecha1 = dr("fecha")
            fecha2 = DateAdd(DateInterval.Day, 15, fecha1)
            If dr("MontoPendiente") < 0 Then
                t.Rows.Add(dr("Control"), fecha1, fecha2, "", dr("MontoTotal"), dr("MontoPendiente"), dr("numeroFactura"), dr("Iva"), dr("MontoNC"))
                t.Rows(t.Rows.Count - 1).Cells(5).Style.ForeColor = Color.Blue
                favor = favor - Math.Round(dr("MontoPendiente"), 2)
            Else
                t.Rows.Add(dr("Control"), fecha1, fecha2, DateDiff(DateInterval.Day, fecha1, Today()), dr("MontoTotal"), dr("MontoPendiente"), dr("numeroFactura"), dr("Iva"), dr("MontoNC"))
                deuda = deuda + Math.Round(dr("MontoPendiente"), 2)
            End If



        End While
        dr.Close()
        lb_deuda.Text = FormatNumber(deuda, 2)
        lb_favor.Text = FormatNumber(favor, 2)
    End Sub

End Class
