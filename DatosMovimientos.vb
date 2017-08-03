Imports System.Data.SqlClient
Public Class DatosMovimientos
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Function consulta_Contribuyente(ByVal Cod As Integer) As Boolean

        Dim CE As Boolean = False

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_consultaCliente"
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            While dr.Read
                CE = dr("ContEspecial")
            End While

            Return CE
        Catch ex As Exception
            MsgBox("Error verificando cliente", MsgBoxStyle.Critical, "SINPRO")

        Finally
            dr.Close()
        End Try

    End Function

    Public Shared Sub consulta_bancos(ByRef cb As ComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaBancosCuentas"
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoBanco")))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try


    End Sub
    Public Shared Sub inserta_movimientos(ByVal numDeposito As String, ByVal Fecha As Date, ByVal Banco As String, ByVal Egreso As String, ByVal Ingreso As String, ByRef f As Boolean, ByVal des As String, ByVal oficina As String, ByVal Asociado As Boolean)

        Dim b As Boolean = False

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_movimiento"
            command.Parameters.AddWithValue("@num", numDeposito)

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                command.Parameters.AddWithValue("@fecha", Fecha)
                command.Parameters.AddWithValue("@tipo", 2)
            End If

            dr = command.ExecuteReader
            While dr.Read
                b = True
            End While
            dr.Close()

            If b = False Then
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_inserta_movimientos"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@NumeroDeposito", numDeposito)
                command.Parameters.AddWithValue("@Fecha", Fecha)
                command.Parameters.AddWithValue("@Banco", Banco)
                If Egreso = Nothing Then
                    Egreso = ""
                End If
                If Ingreso = Nothing Then
                    Ingreso = ""
                End If
                If oficina = Nothing Then
                    oficina = ""
                End If
                command.Parameters.AddWithValue("@Egreso", Egreso)
                command.Parameters.AddWithValue("@Ingreso", Ingreso)
                command.Parameters.AddWithValue("@des", des)
                command.Parameters.AddWithValue("@aso", Asociado)
                command.Parameters.AddWithValue("@oficina", oficina)
                command.ExecuteNonQuery()
            End If
            f = False

        Catch ex As Exception
            f = True
        End Try


    End Sub

    Public Shared Sub modifica_movimientos(ByVal numDeposito As String, ByVal Asociado As Boolean, ByVal id_sub As Integer, ByVal tipo As Integer, ByRef esta As Boolean, ByVal fecha As Date)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_movimiento"
            command.Parameters.AddWithValue("@num", numDeposito)

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                command.Parameters.AddWithValue("@fecha", fecha)
                command.Parameters.AddWithValue("@tipo", 2)
            End If

            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modifica_movimiento"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@mov", numDeposito)
                command.Parameters.AddWithValue("@aso", Asociado)
                command.Parameters.AddWithValue("@idcat", id_sub)
                command.Parameters.AddWithValue("@tipo", tipo)

                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                    command.Parameters.AddWithValue("@fecha", fecha)
                End If

                command.ExecuteNonQuery()
                esta = True

            End If

            dr.Close()

        Catch ex As Exception

        End Try


    End Sub


    Public Shared Sub elimina_movimiento(ByVal numDeposito As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaMovimiento"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Mov", numDeposito)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando movimiento", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Public Shared Sub Inserta_movimiento(ByVal numDeposito As String, ByVal banco As Integer, ByVal desc As String, ByVal ingreso As String, ByVal egreso As String, ByVal oficina As String, ByVal fecha As Date, ByVal asociado As Boolean)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaMovimiento"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Mov", numDeposito)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@desc", desc)
            command.Parameters.AddWithValue("@egr", egreso)
            command.Parameters.AddWithValue("@ing", ingreso)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@ofi", oficina)
            command.Parameters.AddWithValue("@aso", asociado)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando movimiento", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Public Shared Function Consulta_Cod_Banco(ByVal Nombre As String) As Integer
        Try

            Dim cod As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCodigoBanco"
            command.Parameters.AddWithValue("@nom", Nombre)
            dr = command.ExecuteReader

            While dr.Read

                cod = dr("Codigo")

            End While

            Return cod

        Catch ex As Exception

            MsgBox("Error consultando codigo del banco", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Function

    '--------------------------Frm_Consulta_Movimientos

    Public Shared Sub Consulta_Movimientos(ByVal tipo As Integer, ByRef DGV As DataGridView, ByVal banco As String, ByVal desde As Date, ByVal hasta As Date, ByRef egresos As String, ByRef ingresos As String)

        Dim egr As Double = 0
        Dim ingr As Double = 0

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_movimientos"
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@FechaD", desde)
            command.Parameters.AddWithValue("@FechaH", hasta)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Banco"), dr("Oficina"), dr("NumeroDeposito"), dr("Descripcion"), dr("Fecha"), dr("Egreso"), dr("Ingreso"), dr("CodigoBanco"))

                If Not dr("Egreso") Is System.DBNull.Value And Trim(dr("Egreso")) <> "" Then
                    egr = egr + CDbl(dr("Egreso"))
                End If

                If Not dr("Ingreso") Is System.DBNull.Value And Trim(dr("Ingreso")) <> "" Then
                    ingr = ingr + CDbl(dr("Ingreso"))
                End If

            End While

            ingresos = Format(ingr, "##,##0.00")
            egresos = Format(egr, "##,##0.00")

        Catch ex As Exception

            MsgBox("Error consultando movimientos", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub


    Public Shared Sub Consulta_Recibos_Factura(ByVal Control As String, ByRef DGV As DataGridView)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaRecibos_Factura"
            command.Parameters.AddWithValue("@Cod", Control)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Ncontrol"), dr("RazonSocial"), dr("Monto"), dr("CodigoRecibo"), dr("CodigoCliente"), dr("NumeroFactura"))

            End While

            DGV.ClearSelection()

        Catch ex As Exception

            MsgBox("Error consultando recibos asociados", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Consulta_Facturas_Cleitnes(ByVal monto As Double, ByRef DGV As DataGridView, ByVal tope As Integer, ByVal valor As Double)
        Try
            'DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_facturas_pendientes"
            command.Parameters.AddWithValue("@monto", monto)
            command.Parameters.AddWithValue("@tipo", tope)
            command.Parameters.AddWithValue("@valor", valor)
            dr = command.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr("control"), dr("CodigoCliente"), dr("Fecha"), dr("RazonSocial"), dr("montoTotal"), dr("MontoPendiente"), dr("NumeroFactura"), 0)
            End While
        Catch ex As Exception
            MsgBox("Error consultando facturas", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.ToString)
        Finally
            dr.Close()
        End Try
    End Sub

    Public Shared Sub Consulta_Facturas_Cleitnes_ret(ByVal monto As Double, ByRef DGV As DataGridView, ByVal ret As Integer, ByVal lim As Double)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_facturas_pendientes"
            command.Parameters.AddWithValue("@monto", monto)
            command.Parameters.AddWithValue("@tipo", ret)
            command.Parameters.AddWithValue("@valor", lim)
            dr = command.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr("control"), dr("CodigoCliente"), dr("Fecha"), dr("RazonSocial"), dr("montoTotal"), dr("MontoPendiente"), dr("NumeroFactura"), 1)
            End While

        Catch ex As Exception
            MsgBox("Error consultando facturas", MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub Consulta_Facturas_Clientes_Top(ByVal monto As Double, ByRef DGV As DataGridView, ByVal tipo As Integer, ByVal valor As Double, ByVal contesp As Boolean)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTopFactPendientes"
            command.Parameters.AddWithValue("@monto", monto)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.Parameters.AddWithValue("@valor", valor)

            If DGV.Columns(7).Visible = False Then
                DGV.Columns(7).Visible = contesp
            End If

            dr = command.ExecuteReader
            While dr.Read

                DGV.Rows.Add(dr("Cuenta").ToString & " Fact.", dr("CodigoCliente"), dr("Fecha"), dr("RazonSocial"), dr("montoTotal"), dr("MontoPendiente"), dr("NumeroFactura"), contesp)

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub


    Public Shared Sub consulta_bancos_depositos(ByRef cb As ComboBox)
        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "SP_bancos_depositos"
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("Banco")))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try
    End Sub

    Public Shared Sub Eliminar_Movimiento(ByVal num As String)
        Try

            command.Parameters.Clear()
            command.CommandText = "sp_eliminar_movimiento"
            command.Parameters.AddWithValue("@num", num)
            command.ExecuteNonQuery()


        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_clientes(ByRef cb As ComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Consulta_Clientes"
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("RazonSocial"), dr("CodigoCliente")))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try


    End Sub

    Public Shared Sub Consulta_cheques_devueltos(ByVal monto As Double, ByRef DGV As DataGridView)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_chequesDevueltos"
            command.Parameters.AddWithValue("@monto", monto)
            dr = command.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr("NControl"), dr("RazonSocial"), dr("Monto"), dr("CodigoRecibo"))
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub


    Public Shared Sub consulta_cheques_pd(ByVal monto As Double, ByRef DGV As DataGridView)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultachequespd"
            command.Parameters.AddWithValue("@monto", monto)
            dr = command.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr("NControl"), dr("CodigoCliente"), dr("RazonSocial"), dr("Monto"), dr("CodigoRecibo"))
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_categoria(ByRef lb As ListBox, ByVal id As Integer, ByVal nom As String, ByVal tipo As Integer)

        Try

            lb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultacategoria"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader

            While dr.Read

                lb.Items.Add(New comboItem(dr("nombre"), dr("id")))

            End While

        Catch ex As Exception

        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_Subcategoria(ByRef lb As ListBox, ByVal id As Integer, ByVal nom As String, ByVal tipo As Integer, Optional ByRef nombre As String = Nothing, Optional ByRef ident As String = Nothing, Optional ByRef obs As String = Nothing)


        Try

            If tipo <> 1 Then
                lb.Items.Clear()
            End If

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSubcategoria"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@tipo", tipo)
            dr = command.ExecuteReader

            While dr.Read

                If tipo <> 1 Then
                    lb.Items.Add(New comboItem(dr("nombre"), dr("id")))
                End If
                nombre = dr("nombre")
                ident = dr("identificacion")
                obs = dr("observacion")

            End While

        Catch ex As Exception

        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub elimina_Subcategoria(ByVal id As Integer, ByRef borrado As Boolean)

        Try

            Dim cuenta As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDepositosSubCategoria"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@Tipo", 0)
            dr = command.ExecuteReader

            While dr.Read

                cuenta = dr("Cuenta")

            End While

            dr.Close()

            If cuenta > 0 Then

                MsgBox("No puede eliminar la sub-categoría ya que tiene depósitos asociados", MsgBoxStyle.Critical, "SINPRO")

            Else

                command.Parameters.Clear()
                command.CommandText = "sp_eliminaSubCategoria"
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()

                borrado = True
                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Sub-Categoría eliminada", ToolTipIcon.Info)

            End If

        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub elimina_categoria(ByVal id As Integer, ByRef borrado As Boolean)

        Try

            Dim cuenta As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDepositosSubCategoria"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@Tipo", 1)
            dr = command.ExecuteReader

            While dr.Read

                cuenta = dr("Cuenta")

            End While

            dr.Close()

            If cuenta > 0 Then

                MsgBox("No puede eliminar la categoría ya que tiene depósitos asociados", MsgBoxStyle.Critical, "SINPRO")

            Else

                command.Parameters.Clear()
                command.CommandText = "sp_eliminaCategoria"
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()

                borrado = True
                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Categoría eliminada", ToolTipIcon.Info)

            End If

        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub Inserta_Categoria(ByVal nom As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertaCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Categoría insertada", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error insertando categoría", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Inserta_Sub_Categoria(ByVal nom As String, ByVal ident As String, ByVal obs As String, ByVal idcat As Integer)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertasubCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ident", ident)
            command.Parameters.AddWithValue("@obs", obs)
            command.Parameters.AddWithValue("@idcat", idcat)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Sub-Categoría insertada", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error insertando Sub-categoría", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Modifica_Sub_Categoria(ByVal nom As String, ByVal ident As String, ByVal obs As String, ByVal idc As Integer, ByVal id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaSubCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ident", ident)
            command.Parameters.AddWithValue("@obs", obs)
            command.Parameters.AddWithValue("@idc", idc)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Sub-Categoría modificada", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error modificando Sub-categoría", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Modifica_Categoria(ByVal nom As String, ByVal id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Categoría modificada", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error modificando categoría", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Consulta_Movimientos_Asociados(ByVal tipo As Integer, ByRef DGV As DataGridView, ByVal banco As String, ByVal desde As Date, ByVal hasta As Date)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_movimientos"
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@FechaD", desde)
            command.Parameters.AddWithValue("@FechaH", hasta)
            dr = command.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr("Banco"), dr("Oficina"), dr("NumeroDeposito"), dr("Descripcion"), dr("Fecha"), dr("Egreso"), dr("Ingreso"), dr("CodigoBanco"))
            End While

            dr.Close()



        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_categorias(ByRef cb As ComboBox, ByVal nom As String, ByVal id As Integer, ByVal Tipo As Integer)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Id", id)
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))

            End While

        Catch ex As Exception

            MsgBox("Error consultando categorias", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()


        End Try


    End Sub

    Public Shared Sub consulta_subcategorias(ByRef cb As ComboBox, ByVal nom As String, ByVal id As Integer, ByVal Tipo As Integer)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaSubCategoria"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Id", id)
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))

            End While


        Catch ex As Exception

            MsgBox("Error consultando sub-categorias", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try


    End Sub

End Class
