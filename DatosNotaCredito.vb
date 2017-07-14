Imports System.Data.SqlClient
Public Class DatosNotaCredito
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub cantidadesDev(ByVal codF As Integer, ByVal codP As String, ByRef acum As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_sumadevueltos"
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@codP", codP)
        dr = command.ExecuteReader()
        If dr.Read Then
            If dr(0).GetType.ToString = "System.DBNull" Then
                acum = 0
            Else
                acum = dr(0)
            End If
        End If
        dr.Close()
    End Sub

    Public Shared Sub cantidadModif(ByVal codNC As Integer, ByVal codP As Integer, ByRef cantidad As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductos_NC"
        command.Parameters.AddWithValue("@codNC", codNC)
        dr = command.ExecuteReader()
        While dr.Read
            If codP = dr("CodigoProducto") Then
                cantidad = dr("Cantidad")
            End If
        End While
        dr.Close()
    End Sub


    Public Shared Sub consulta_ncs(ByVal lv As ListView, ByVal c As Integer)
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_NC_melissa"
        command.Parameters.AddWithValue("@codF", c)
        dr = command.ExecuteReader()
        While dr.Read
            Dim nc As Integer = dr("CodigoNotaCredito")
            Dim m As Integer = dr("Monto")
            Dim i As New ListViewItem(nc)
            i.SubItems.Add(m)
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub

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

    Public Shared Sub consulta_nc(ByRef dg As DataGridView, ByVal codNC As Integer, ByVal codF As Integer)
        dg.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductos_NC"
        command.Parameters.AddWithValue("@codNC", codNC)
        dr = command.ExecuteReader()
        While dr.Read
            dg.Rows.Add(dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Precio"))
        End While
        dr.Close()
    End Sub

    ''
    Public Shared Sub consulta_FactVentas(ByRef dg As DataGridView, ByVal Tipo As Integer, ByVal Nom As String)

        dg.Rows.Clear()
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@Tipo", Tipo)
        command.Parameters.AddWithValue("@Nom", Nom)
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFactVentas"
        dr = command.ExecuteReader()

        While dr.Read
            dg.Rows.Add(dr("Fecha"), dr("ControlInicio"), dr("RazonSocial"), dr("MontoTotal"), dr("Iva"), dr("NumeroFactura"))
        End While
        dr.Close()

    End Sub




    Public Shared Sub consulta_FactProNC(ByRef dg As DataGridView, ByVal ControlFactura As Integer, ByVal Tipo As Integer)

        dg.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFacturaNC"
        command.Parameters.AddWithValue("@ControlFactura", ControlFactura)
        dr = command.ExecuteReader()

        While dr.Read

            If Tipo = 1 Then
                dg.Rows.Add("", dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"))
            ElseIf Tipo = 2 Then
                dg.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"))
            End If

        End While



        dr.Close()

    End Sub

    Public Shared Sub consulta_nc2(ByVal codF As Integer, ByRef t As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaNotaCredito2"
        command.Parameters.AddWithValue("@codF", codF)
        dr = command.ExecuteReader()
        While dr.Read
            t = CStr(dr("Monto"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_nc3(ByVal codF As Integer, ByRef t As String)
        Dim cuenta As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaNotaCredito2"
        command.Parameters.AddWithValue("@codF", codF)
        dr = command.ExecuteReader()
        While dr.Read
            cuenta = cuenta + 1
        End While
        t = cuenta
        dr.Close()
    End Sub

    Public Shared Sub consulta_productos_factura(ByRef t As DataGridView, ByVal codf As Integer)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductos_Factura2"
        command.Parameters.AddWithValue("@codF", codf)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(0, "", dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), "", dr("Precio"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_productos_factura_sindev(ByVal codNC As Integer, ByVal codF As Integer, ByRef t As DataGridView)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductos_SinDev"
        command.Parameters.AddWithValue("@codNC", codNC)
        command.Parameters.AddWithValue("@codF", codF)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(0, dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Precio"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub insertar_nc(ByVal codF As Integer, ByVal m As Double)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaNotaCredito"
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@mon", m)
        command.Parameters.AddWithValue("@tipo", 1) 'Devolución= 1
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub insertar_nc2(ByVal codF As Integer, ByVal m As Double)
        Dim par As Integer = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaNotaCredito"
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@mon", m)
        command.Parameters.AddWithValue("@tipo", par) 'Descuento= 0
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub insertar_producto_nc(ByVal codNC As Integer, ByVal codPto As String, ByVal c As Integer, ByVal p As Double)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaDevolucion_Producto"
        command.Parameters.AddWithValue("@codNC", codNC)
        command.Parameters.AddWithValue("@codI", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.Parameters.AddWithValue("@pre", p)
        command.ExecuteNonQuery()
    End Sub
    ''
    Public Shared Function insertar_NotaCredito(ByVal Nroimp As Integer, ByVal CodigoFactura As Integer, ByVal Monto As Double, ByVal Tipo As Integer, ByVal Observacion As String, ByVal Fecha As Date, ByVal ajustada As Boolean, ByVal nroControl As Integer, ByVal impOctrl As Boolean, ByVal user As String) As Boolean
        Dim Listo As Boolean = False
        Try
            Dim si As Boolean = False

            If Not Nroimp = 0 Then
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaNroControlNC"
                command.Parameters.AddWithValue("@nro", Nroimp)
                command.Parameters.AddWithValue("@Tipo", 0)
                dr = command.ExecuteReader()
                If dr.Read() Then
                    si = True
                End If
                dr.Close()
            End If

            If Not nroControl = 0 Then
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_consultaNroControlNC"
                command.Parameters.AddWithValue("@nro", nroControl)
                command.Parameters.AddWithValue("@Tipo", 1)
                dr = command.ExecuteReader()
                If dr.Read() Then
                    si = True
                End If
                dr.Close()
            End If

            If si = False Then
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertarNotadeCredito"
                command.Parameters.AddWithValue("@NroControl", nroControl)
                command.Parameters.AddWithValue("@CodigoFactura", CodigoFactura)
                command.Parameters.AddWithValue("@Monto", Monto)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@Observacion", Observacion)
                command.Parameters.AddWithValue("@Fecha", Fecha)
                command.Parameters.AddWithValue("@Ajustada", ajustada)
                command.Parameters.AddWithValue("@NroImp", Nroimp)

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                    command.Parameters.AddWithValue("@user", user)
                End If

                command.ExecuteNonQuery()
                Listo = True
            Else
                Listo = False
                MsgBox("Ya el Nro Control o de correlativo de la Nota de Crédito está registrado.", MsgBoxStyle.Critical)
            End If
            Return Listo
        Catch ex As Exception
            MsgBox("Error insertando la Nota de Crédito", MsgBoxStyle.Critical)
            Return Listo
        End Try

    End Function
    ''
    Public Shared Sub insertar_NotaCreditoProducto(ByVal Codproducto As String, ByVal Cantidad As Integer, ByVal Precio As Double, ByVal CodNotaCredito As Integer, ByVal tipo As Boolean, ByVal obs As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertarNotaCreditoProducto"

            If tipo = 0 Then

                command.Parameters.AddWithValue("@CodNotaCredito", CodNotaCredito)
                command.Parameters.AddWithValue("@CodProducto", Codproducto)
                command.Parameters.AddWithValue("@Cantidad", Cantidad)
                command.Parameters.AddWithValue("@Precio", Precio)
                command.Parameters.AddWithValue("@CantDesc", 0)

                If obs Is Nothing Then
                    obs = ""
                End If

                'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                command.Parameters.AddWithValue("@obs", obs)
                'End If

            Else

                command.Parameters.AddWithValue("@CodNotaCredito", CodNotaCredito)
                command.Parameters.AddWithValue("@CodProducto", Codproducto)
                command.Parameters.AddWithValue("@Cantidad", 0)
                command.Parameters.AddWithValue("@Precio", Precio)
                command.Parameters.AddWithValue("@CantDesc", Cantidad)


                'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                If obs Is Nothing Then
                    obs = ""
                End If
                command.Parameters.AddWithValue("@obs", obs)

                'End If

            End If

            command.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function identidad_NotaCreditoProducto() As Integer
        Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadNC"
        dr = command.ExecuteReader
        dr.Read()
        id = dr("Expr1") + 1
        dr.Close()
        Return id
    End Function

    Public Shared Function identidad_nc() As Integer
        Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadNC"
        dr = command.ExecuteReader
        dr.Read()
        id = dr("Expr1") + 1
        dr.Close()
        Return id
    End Function

    Public Shared Sub elimina_producto_devolucion(ByVal l As Collection, ByVal codNC As Integer)
        For Each item In l
            Dim int As Integer = CInt(item)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaDevolucion_Producto"
            command.Parameters.AddWithValue("@codNC", codNC)
            command.Parameters.AddWithValue("@codP", int)
            command.ExecuteNonQuery()
        Next
    End Sub

    Public Shared Sub actualizar_producto_factura(ByVal codNC As Integer, ByVal codPto As Integer, ByVal c As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaDevolucion_Producto2"
        command.Parameters.AddWithValue("@codNC", codNC)
        command.Parameters.AddWithValue("@codP", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Function modifica_nc(ByVal codNC As Integer, ByVal NroC As Integer, ByVal Obs As String, ByVal Fecha As Date, ByVal NroImp As Integer, ByVal revisar As Boolean, ByVal impOctrl As Boolean, ByVal nrocontrol As Integer, ByVal revisar2 As Boolean, ByRef resp As Integer, ByVal ajustada As Boolean) As Boolean
        Dim Listo As Boolean = False

        Try
            Dim si As Boolean = False

            If revisar Then

                If Not NroImp = 0 Then
                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_consultaNroControlNC"
                    command.Parameters.AddWithValue("@nro", NroImp)
                    command.Parameters.AddWithValue("@Tipo", 0)
                    dr = command.ExecuteReader()
                    If dr.Read() Then
                        si = True
                    End If
                    dr.Close()
                End If

            End If

            If revisar2 Then

                If Not nrocontrol = 0 Then
                    command.Parameters.Clear()
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandText = "sp_consultaNroControlNC"
                    command.Parameters.AddWithValue("@nro", nrocontrol)
                    command.Parameters.AddWithValue("@Tipo", 1)
                    dr = command.ExecuteReader()
                    If dr.Read() Then
                        si = True
                    End If
                    dr.Close()
                End If

            End If

            If si = False Then

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaNotaCredito"
                command.Parameters.AddWithValue("@COD", codNC)
                command.Parameters.AddWithValue("@Fecha", Fecha)
                command.Parameters.AddWithValue("@Obs", Obs)
                command.Parameters.AddWithValue("@NroC", nrocontrol)
                command.Parameters.AddWithValue("@NroImp", NroImp)
                command.ExecuteNonQuery()

                If ajustada Then
                    MsgBox("Nota de crédito modificada satisfactoriamente", MsgBoxStyle.Information)
                ElseIf Not ajustada And nrocontrol <> 0 Then
                    resp = MsgBox("Nota de crédito modificada satisfactoriamente, desea ajustar?", MsgBoxStyle.YesNo)
                End If

                Listo = True

            Else

                Listo = False
                MsgBox("El número de control o de correlativo ya está registrado para otra nota", MsgBoxStyle.Critical)

            End If

            Return Listo

        Catch ex As Exception
            MsgBox("El número de control o de correlativo ya está registrado para otra nota", MsgBoxStyle.Critical)
            Return Listo
        End Try


    End Function

    Public Shared Sub consulta_notaCredito(ByRef dg As DataGridView, ByVal Tipo As Integer, ByVal nom As String)
        Try
            dg.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNotasCredito"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Nom", nom)
            dr = command.ExecuteReader()
            While dr.Read
                dg.Rows.Add(dr("NroControl"), dr("ControlInicio"), dr("Fecha"), dr("RazonSocial"), dr("Monto"), dr("Observacion"), dr("Iva"), dr("Tipo"), dr("CodigoNotaCredito"), dr("MontoTotal"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error cargando lista de notas", MsgBoxStyle.Critical)

            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_NroImpNC(ByVal cod As Integer, ByRef NroImp As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNroImpNC"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()
            While dr.Read
                If dr("NroImp").GetType.ToString = "System.DBNull" Then
                    NroImp = ""
                Else
                    NroImp = dr("NroImp")
                End If
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error cargando correlativio", MsgBoxStyle.Critical)

            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_ProximoControlNC(ByRef control As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaControlNC"
            dr = command.ExecuteReader()
            While dr.Read
                control = dr("Proximo")
            End While
        Catch ex As Exception
            MsgBox("Error cargando el correlativo", MsgBoxStyle.Critical)

            dr.Close()
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_productosnotaCredito(ByRef dg As DataGridView, ByVal Id As Integer, ByVal Tipo As Integer)
        Try
            dg.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaproductosNotasCredito"
            command.Parameters.AddWithValue("@Cod", Id)
            command.Parameters.AddWithValue("@Tipo", Tipo)

            dr = command.ExecuteReader()

            If Tipo = 0 Then
                While dr.Read
                    dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"))
                End While
                dg.Columns(0).Visible = False
            ElseIf Tipo = 1 Then
                While dr.Read
                    dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"))
                End While
                dg.Columns(0).Visible = True
            ElseIf Tipo = 2 Then
                While dr.Read
                    dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("PrecioNota"), dr("Precio"))
                End While
                dg.Columns(0).Visible = True
            ElseIf Tipo = 4 Then
                While dr.Read
                    dg.Rows.Add(dr("Cantidad"), dr("Codigo"), dr("Nombre"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), "")
                End While
            ElseIf Tipo = 5 Then
                While dr.Read
                    dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("PrecioNota"), dr("Precio"))
                End While
                dg.Columns(0).Visible = True
            ElseIf Tipo = 6 Then
                While dr.Read
                    'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                    dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"), dr("Observacion"))
                    'Else
                    'dg.Rows.Add("", dr("Dev"), dr("Cantidad"), dr("CodigoProducto"), dr("Nombre"), dr("Modelo"), dr("Precio"))
                    'End If
                End While
                dg.Columns(0).Visible = False
            ElseIf Tipo = 7 Then
                While dr.Read
                    dg.Rows.Add(dr("Cantidad"), dr("Codigo"), dr("Nombre"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("Exist"), "")
                End While
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("Error cargando lista de notas", MsgBoxStyle.Critical)

            dr.Close()
        End Try

    End Sub

    Public Shared Sub OtrasNotas(ByRef Valor As String, ByVal cod As Integer, ByVal NotaActual As Integer, ByVal Tipo As Integer)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ConsultaOtrasNotasCredito"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodF", cod)
            command.Parameters.AddWithValue("@Me", NotaActual)

            dr = command.ExecuteReader

            dr.Read()

            If dr.HasRows Then
                If dr("TotalNotas").GetType.ToString = "System.DBNull" Then
                    Valor = "0,00"
                Else
                    Valor = dr("TotalNotas")
                End If
            Else
                Valor = "0,00"
            End If

            dr.Close()

        Catch ex As Exception


            dr.Close()

        End Try

    End Sub

    Public Shared Sub elimina_NotaCredito(ByVal codNC As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cod", codNC)
        command.CommandText = "sp_eliminaNotaCredito"
        command.ExecuteNonQuery()
        MsgBox("Nota de crédito eliminada satisfactoriamente", MsgBoxStyle.Information)
    End Sub

    Public Shared Sub consulta_Ajustes(ByVal Tipo As Integer, ByVal Codigo As String, ByRef hay As Boolean)
        Try
            hay = False

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvAjustesPorNc"
            command.Parameters.AddWithValue("@Cod", Codigo)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            dr = command.ExecuteReader

            If dr.HasRows Then

                hay = True

            End If

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try


    End Sub



    Public Shared Sub consulta_notaCredito2(ByVal Tipo As Integer, ByVal nom As String, ByRef numero As Integer)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaNotasCredito"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Nom", nom)
            dr = command.ExecuteReader()
            If dr.Read Then
                numero = dr("CodigoNotaCredito")
            End If
            dr.Close()
        Catch

        End Try
    End Sub



End Class
