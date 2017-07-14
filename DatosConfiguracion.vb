Imports System.Data.SqlClient
Public Class DatosConfiguracion
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub consulta_bancos(ByRef cb As ComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaBancos"
            dr = command.ExecuteReader

            While dr.Read

                cb.Items.Add(New comboItem(dr("Nombre"), dr("Codigo")))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try


    End Sub

    Public Shared Sub Consulta_funciones_activas_web(ByRef pedidos As Boolean, ByRef devoluciones As Boolean, ByRef recibos As Boolean, ByRef listados As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_funciones_activas_web"
            dr = command.ExecuteReader

            While dr.Read

                pedidos = dr("Pedidos")
                devoluciones = dr("Devoluciones")
                recibos = dr("Recibos")
                listados = dr("Listados")

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try

    End Sub

    Public Shared Function Consulta_pedidos_express() As Boolean

        Dim express As Boolean = False

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPedidosExpress"
            dr = command.ExecuteReader

            While dr.Read

                express = dr("Express")

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

        Return express

    End Function

    Public Shared Sub Modifica_pedidos_express(ByVal exp As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaPedidosExpress"
            command.Parameters.AddWithValue("@exp", exp)

            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("Error modificando funciones de la página web", MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Shared Sub Modifica_funciones_activas_web(ByVal pedidos As Boolean, ByVal devoluciones As Boolean, ByVal recibos As Boolean, ByVal listados As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_funciones_activas_web"
            command.Parameters.AddWithValue("@ped", pedidos)
            command.Parameters.AddWithValue("@dev", devoluciones)
            command.Parameters.AddWithValue("@rec", recibos)
            command.Parameters.AddWithValue("@list", listados)

            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("Error modificando funciones de la página web", MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Shared Sub consulta_mensaje_bienvenida(ByRef vend As String, ByRef cli As String, ByRef alm As String, ByRef adm As String, ByRef TitVend As String, ByRef TitCli As String, ByRef TitAlm As String, ByRef TitAdm As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMensajeBienvenida"

            dr = command.ExecuteReader

            While dr.Read

                If dr("Tipo") = "Vendedor" Then
                    vend = dr("ContenidoMensaje")
                    TitVend = dr("TituloMensaje")
                ElseIf dr("Tipo") = "Cliente" Then
                    cli = dr("ContenidoMensaje")
                    TitCli = dr("TituloMensaje")
                ElseIf dr("Tipo") = "Almacen" Then
                    alm = dr("ContenidoMensaje")
                    TitAlm = dr("TituloMensaje")
                ElseIf dr("Tipo") = "Administrador" Then
                    adm = dr("ContenidoMensaje")
                    TitAdm = dr("TituloMensaje")
                End If

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()


        End Try


    End Sub

    Public Shared Sub Modifica_Mensaje_Bienvenida(ByVal Vend As String, ByVal Cli As String, ByVal Alm As String, ByVal Adm As String, ByVal TitV As String, ByVal TitC As String, ByVal TitA As String, ByVal TitAd As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaMensajeBienvenida"
            command.Parameters.AddWithValue("@Tipo", "Cliente")
            command.Parameters.AddWithValue("@Mens", Cli)
            command.Parameters.AddWithValue("@Tit", TitC)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandText = "sp_modificaMensajeBienvenida"
            command.Parameters.AddWithValue("@Tipo", "Vendedor")
            command.Parameters.AddWithValue("@Mens", Vend)
            command.Parameters.AddWithValue("@Tit", TitV)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandText = "sp_modificaMensajeBienvenida"
            command.Parameters.AddWithValue("@Tipo", "Almacen")
            command.Parameters.AddWithValue("@Mens", Alm)
            command.Parameters.AddWithValue("@Tit", TitA)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandText = "sp_modificaMensajeBienvenida"
            command.Parameters.AddWithValue("@Tipo", "Administrador")
            command.Parameters.AddWithValue("@Mens", Adm)
            command.Parameters.AddWithValue("@Tit", TitAd)
            command.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Error modificando observación", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub consulta_iva(ByRef sw As Boolean)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaIVA"
            dr = command.ExecuteReader()
            If dr.Read() Then
                sw = True
            End If
        Catch ex As Exception
            MsgBox("Error cargando el iva", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try


    End Sub


    Public Shared Sub consulta_MontoAjuste(ByRef monto As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMontoAjuste"
            dr = command.ExecuteReader()
            If dr.Read() Then
                monto = dr("MontoAjuste")
            End If
        Catch ex As Exception
            MsgBox("Error cargando el monto", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_obs(ByRef obs As String, ByVal Tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaObs"
            dr = command.ExecuteReader()
            If dr.Read() Then
                If Tipo = 0 Then
                    obs = dr("ObsFactura")
                ElseIf (Tipo = 1) Then
                    obs = dr("ObsReportes")
                Else
                    obs = dr("Leyenda")
                End If

            End If
        Catch ex As Exception
            MsgBox("Error cargando la(s) observación(es)", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub


    Public Shared Sub Modifica_Obs(ByVal ObsF As String, ByVal ObsR As String, ByVal Leyenda As String, ByVal Tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaObs"
            command.Parameters.AddWithValue("@ObsF", ObsF)
            command.Parameters.AddWithValue("@ObsR", ObsR)
            command.Parameters.AddWithValue("@Leyen", Leyenda)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando observación", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub inserta_MontoAjuste(ByVal monto As Double)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaMontoAjuste"
            command.Parameters.AddWithValue("@monto", monto)
            command.ExecuteNonQuery()
            MsgBox("Monto de ajustes automáticos registrado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
        Catch ex As Exception
            MsgBox("Error insertando el monto", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub


    Public Shared Sub tb_iva(ByRef iva As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaIVA"
            dr = command.ExecuteReader()
            If dr.Read() Then
                iva = dr("iva")
            End If
        Catch ex As Exception
            MsgBox("Error cargando el iva", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub inserta_iva(ByVal iva As Double)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaIVA"
            command.Parameters.AddWithValue("@iva", iva)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando el IVA", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub


    Public Shared Sub modifica_iva(ByVal iva As Double)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaIVA"
            command.Parameters.AddWithValue("@iva", iva)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando el IVA", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub Identidad_Pref_Arancelaria(ByRef tb_cod As TextBox)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadArancelaria"
            dr = command.ExecuteReader()
            If dr.Read() Then
                tb_cod.Text = CStr(CInt(dr("Expr1")) + 1)
            End If
        Catch ex As Exception
            MsgBox("Error cargando próxima preferencia", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub
    Public Shared Sub inserta_Pref_Arancelaria(ByVal nombre As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaPrefArancelaria"
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando preferencia", MsgBoxStyle.Critical, "SINPRO")
        End Try
    End Sub

    Public Shared Sub inserta_DiasCred(ByVal Dias As Integer)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaDiasCred"
            command.Parameters.AddWithValue("@Dias", Dias)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando días", MsgBoxStyle.Critical, "SINPRO")
        End Try
    End Sub

    Public Shared Sub modifica_DiasCred(ByVal Cod As Integer, ByVal Dias As Integer)
        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Dias", Dias)
            command.CommandText = "sp_modificaDiasCred"
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando días", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub modifica_Pref_Arancelaria(ByVal Preferencia As String, ByVal Cod As Integer)

        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.CommandText = "sp_modificaPrefArancelaria"
            command.Parameters.AddWithValue("@Preferencia", Preferencia)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando preferencia", MsgBoxStyle.Critical, "SINPRO")
        End Try


    End Sub



    Public Shared Sub consulta_PrefArancelaria(ByRef Dgv As DataGridView)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaPrefArancelaria1"
            dr = command.ExecuteReader()

            While dr.Read()
                Dgv.Rows.Add(dr("CodigoPreferencia"), dr("Nombre"))
            End While

        Catch ex As Exception
            MsgBox("Error cargando preferencias", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_Cuentas(ByRef Dgv As DataGridView)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCuentas"
            dr = command.ExecuteReader()

            While dr.Read()
                Dgv.Rows.Add(dr("Nombre"), dr("Titular"), dr("NroCuenta"), dr("TipoCuenta"), dr("CodigoBanco"))
            End While

        Catch ex As Exception
            MsgBox("Error cargando cuentas", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub


    Public Shared Sub consulta_DiasCred(ByRef Dgv As DataGridView)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_DiasCred"
            dr = command.ExecuteReader()

            While dr.Read()
                Dgv.Rows.Add(dr("Codigo"), dr("Dias"))
            End While
        Catch ex As Exception
            MsgBox("Error cargando días", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
            Dgv.ClearSelection()
        End Try
    End Sub

    Public Shared Sub Eliminar_Preferencia(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminarPreferencia"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando preferencia", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub Eliminar_Cuenta(ByVal cod As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaCuenta"
            command.Parameters.AddWithValue("@Cuenta", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando cuenta", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub Eliminar_DiasCred(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminarDiasCred"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando días", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub inserta_Comision(ByVal DiaI As Integer, ByVal DiaF As Integer, ByVal Comision As Double)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaParametrosComision"
            command.Parameters.AddWithValue("@DiaI", DiaI)
            command.Parameters.AddWithValue("@DiaF", DiaF)
            command.Parameters.AddWithValue("@Comision", Comision)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando comisión", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub inserta_Cuenta(ByVal Titular As String, ByVal NroCuenta As String, ByVal TipoC As String, ByVal Banco As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaCuenta"
            command.Parameters.AddWithValue("@TipoC", TipoC)
            command.Parameters.AddWithValue("@Cuenta", NroCuenta)
            command.Parameters.AddWithValue("@Titular", Titular)
            command.Parameters.AddWithValue("@Banco", Banco)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando cuenta", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub modifica_Cuenta(ByVal Titular As String, ByVal NroCuenta As String, ByVal TipoC As String, ByVal Banco As Integer, ByVal CuentaV As String)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_ModificaCuenta"
            command.Parameters.AddWithValue("@TipoC", TipoC)
            command.Parameters.AddWithValue("@Cuenta", NroCuenta)
            command.Parameters.AddWithValue("@Titular", Titular)
            command.Parameters.AddWithValue("@Banco", Banco)
            command.Parameters.AddWithValue("@CuentaV", CuentaV)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando cuenta", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub
    Public Shared Sub consulta_Comision(ByRef Dgv As DataGridView, ByVal tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ConsultaParametrosComision"
            dr = command.ExecuteReader()
            If tipo = 0 Then
                While dr.Read()
                    Dgv.Rows.Add(dr("Codigo"), dr("DiaInicio"), dr("DiaFinal"), dr("Comision"))
                End While
            ElseIf tipo = 1 Then
                While dr.Read()
                    Dgv.Rows.Add(dr("DiaInicio"), dr("DiaFinal"), dr("Comision"))
                End While
            End If
        Catch ex As Exception
            MsgBox("Error cargando comisiones", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub
    Public Shared Sub modifica_comision(ByVal Cod As Integer, ByVal Inicio As Integer, ByVal Final As Integer, ByVal Comision As Double)

        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@DiaI", Inicio)
            command.Parameters.AddWithValue("@DiaF", Final)
            command.Parameters.AddWithValue("@Comision", Comision)
            command.CommandText = "sp_modificaParametrosComision"
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando comisioón", MsgBoxStyle.Critical, "SINPRO")
        End Try


    End Sub
    Public Shared Sub Eliminar_Comision(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminarParametrosComision"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando comisioón", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub ActualizaParametrosAutorizacion(ByVal MonPed As Double, ByVal MonPedVenc As Double, ByVal MonPedPorV As Double, ByVal ChequesDev As Boolean)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaParametrosAutorizacion"
            dr = command.ExecuteReader()

            If dr.HasRows Then
                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_ActualizaParametrosAutorizacion"
                command.Parameters.AddWithValue("@MFPV", MonPedVenc)
                command.Parameters.AddWithValue("@MFPPV", MonPedPorV)
                command.Parameters.AddWithValue("@MonPed", MonPed)
                command.Parameters.AddWithValue("@ChequesDev", ChequesDev)
                command.ExecuteNonQuery()
            Else
                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_InsertaParametrosAutorizacion"
                command.Parameters.AddWithValue("@MFPV", MonPedVenc)
                command.Parameters.AddWithValue("@MFPPV", MonPedPorV)
                command.Parameters.AddWithValue("@MonPed", MonPed)
                command.Parameters.AddWithValue("@ChequesDev", ChequesDev)
                command.ExecuteNonQuery()
            End If

        Catch ex As Exception

            dr.Close()
            MsgBox("Error registrando parámetros de autorización", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub ConsultaParametrosAutorizacion(ByRef MonPed As String, ByRef MonPedVenc As String, ByRef MonPedPorV As String, ByRef ChequesDev As Boolean)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaParametrosAutorizacion"
            dr = command.ExecuteReader()

            While dr.Read

                If dr("MontoPedido").GetType.ToString = "System.DBNull" Then
                    MonPed = ""
                Else
                    MonPed = Format(dr("MontoPedido"), "#,##0.00").ToString
                End If

                If dr("MFactPorVen").GetType.ToString = "System.DBNull" Then
                    MonPedPorV = ""
                Else
                    MonPedPorV = Format(dr("MFactPorVen"), "#,##0.00").ToString
                End If

                If dr("MFactVen").GetType.ToString = "System.DBNull" Then
                    MonPedVenc = ""
                Else
                    MonPedVenc = Format(dr("MFactVen"), "#,##0.00").ToString
                End If

                If dr("ChequesDev").GetType.ToString = "System.DBNull" Then
                    ChequesDev = False
                Else
                    ChequesDev = dr("ChequesDev")
                End If

            End While

        Catch ex As Exception

            MsgBox("Error consultando los parámetros de autorización", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub
    Public Shared Sub ConsultaMaxArticulos(ByRef MaxArt As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMaxArtPed"
            dr = command.ExecuteReader()

            While dr.Read

                If dr("MaxArt").GetType.ToString = "System.DBNull" Then
                    MaxArt = ""
                Else
                    MaxArt = dr("MaxArt")
                End If


            End While

        Catch ex As Exception

            MsgBox("Error consultando el máximo de artículos", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub


    Public Shared Sub ActualizaMaxArt(ByVal MaxArt As Integer)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaMaxArtPed"
            command.Parameters.AddWithValue("@Max", MaxArt)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error registrando el máximo de articulos", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub ActualizaMontoAsociado(ByVal monto As Integer)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_asociacion_monto"
            command.Parameters.AddWithValue("@monto", monto)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error registrando el máximo de articulos", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub
    Public Shared Sub consulta_montoAsociacion(ByRef monto As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_monto_asociado"
            dr = command.ExecuteReader()

            While dr.Read

                monto = dr("monto")

            End While

        Catch ex As Exception

            MsgBox("Error consultando el de asociación", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_Almacen(ByRef almacen As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_almacen"
            dr = command.ExecuteReader()

            While dr.Read
                If dr("Nombre").ToString.ToUpper = "DBNull".ToUpper Then
                    almacen = ""
                Else
                    almacen = dr("Nombre")
                End If


            End While

        Catch ex As Exception

            MsgBox("Error consultando el almacen predeterminado", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub


    Public Shared Sub llenar_almacenes(ByRef cb As ComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure

            command.CommandText = "sp_consultaAlmacenes"
            dr = command.ExecuteReader

            While dr.Read
                If Not dr("Id").GetType.ToString = "System.DBNull" Then
                    cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))
                End If
            End While
        Catch ex As Exception

            MsgBox("Error cargando lista de almacenes", MsgBoxStyle.Critical)


        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Inserta_almacen(ByVal id As Integer, ByVal nombre As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_inserta_almacen_predeterminado"
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error registrando el almacen predeterminado", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub Inserta_Empresa(ByVal Rif As String, ByVal Razon As String, ByVal Tel1 As String, ByVal Tel2 As String, ByVal Tel3 As String, ByVal Obs As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaEmpresa"
            command.Parameters.AddWithValue("@Rif", Rif)
            command.Parameters.AddWithValue("@Razon", Razon)
            command.Parameters.AddWithValue("@Tel1", Tel1)
            command.Parameters.AddWithValue("@Tel2", Tel2)
            command.Parameters.AddWithValue("@Tel3", Tel3)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Empresa registrada satisfactoriamente", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error registrando empresa", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Modifica_Empresa(ByVal Rif As String, ByVal Razon As String, ByVal Tel1 As String, ByVal Tel2 As String, ByVal Tel3 As String, ByVal Obs As String, ByVal Id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaEmpresa"
            command.Parameters.AddWithValue("@Rif", Rif)
            command.Parameters.AddWithValue("@Razon", Razon)
            command.Parameters.AddWithValue("@Tel1", Tel1)
            command.Parameters.AddWithValue("@Tel2", Tel2)
            command.Parameters.AddWithValue("@Tel3", Tel3)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.Parameters.AddWithValue("@Id", Id)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Empresa modificada satisfactoriamente", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error modificando empresa", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub


    Public Shared Sub Elimina_Empresa(ByVal Id As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaEmpresa"
            command.Parameters.AddWithValue("@Id", Id)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Empresa eliminada satisfactoriamente", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error eliminando empresa", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub Consulta_Empresas(ByRef DGV As DataGridView, ByVal Razon As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaEmpresa"
            command.Parameters.AddWithValue("@Tipo", 1)
            command.Parameters.AddWithValue("@Razon", Razon)
            command.Parameters.AddWithValue("@Id", 0)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Id"), dr("RazonSocial"))

            End While

            DGV.ClearSelection()

        Catch ex As Exception

            MsgBox("Error consultando empresas", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Consulta_Empresa(ByRef Rif As String, ByRef Razon As String, ByRef Tel1 As String, ByRef Tel2 As String, ByRef Tel3 As String, ByRef Obs As String, ByVal Id As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaEmpresa"
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@Razon", "")
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Rif = dr("Rif")
                Razon = dr("RazonSocial")
                Tel1 = dr("Telefono1")
                Tel2 = dr("Telefono2")
                Tel3 = dr("Telefono3")
                Obs = dr("Observacion")

            End While

        Catch ex As Exception

            MsgBox("Error consultando empresa", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Consulta_Id_Empresa(ByRef Id As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMaxEmpresa"
            dr = command.ExecuteReader

            While dr.Read

                Id = dr("Id")

            End While

        Catch ex As Exception

            MsgBox("Error consultando próximo Id", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Consultar_Grupos_Ocultos(ByRef dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaGruposOcultosWeb"
            dr = command.ExecuteReader()

            While dr.Read()
                dgv.Rows.Add(dr("CodigoGrupo"), dr("NombreGrupo"))
            End While

            dgv.ClearSelection()

        Catch ex As Exception
            MsgBox("Error consultando grupos ocultos")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub Consultar_Grupos_No_Ocultos(ByRef dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaGruposNoOcultosWeb"
            dr = command.ExecuteReader()

            While dr.Read()
                dgv.Rows.Add(dr("CodigoGrupo"), dr("NombreGrupo"))
            End While

            dgv.ClearSelection()

        Catch ex As Exception
            MsgBox("Error consultando grupos no ocultos")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub Modificar_Grupos_Ocultos(ByRef dgv As DataGridView)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_EliminaGruposOcultosWeb"
            command.ExecuteNonQuery()

            For i As Integer = 0 To dgv.RowCount - 1

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id", dgv.Rows(i).Cells(0).Value)
                command.CommandText = "sp_InsertaGruposOcultosWeb"
                command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("Error modificando grupos ocultos")
        End Try

    End Sub

    Public Shared Sub Modificar_monto_asociacion(ByVal monto As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaMontoAsociacion"
            command.Parameters.AddWithValue("@monto", monto)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error modificando monto asociación")
        End Try

    End Sub

End Class
