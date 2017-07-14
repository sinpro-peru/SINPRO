Imports System.Data.SqlClient
Public Class DatosVendedores
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
 

    Public Shared Sub lv_vendedor(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvVendedor"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", val)
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("CodigoVendedor"), dr("Nombre"))
        End While
        dr.Close()
    End Sub



    Public Shared Sub consulta_vendedores(ByVal DGV As DataGridView)
        Try
            Dim par As Integer
            par = 0
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedor"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()

            While dr.Read
                DGV.Rows.Add(dr("CodigoVendedor"), dr("Nombre"))
            End While

        Catch ex As Exception
            MsgBox("Error cargando lista de vendedores", MsgBoxStyle.Critical, "SINPRO")

        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_zonas(ByRef cb As MTGCComboBox)

        Try
            Dim par As Integer
            par = 0
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaZona"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()

            While dr.Read
                cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoZona"))))
            End While

        Catch ex As Exception

            MsgBox("Error cargando zonas", MsgBoxStyle.Critical, "SINPRO")


        Finally

            dr.Close()

        End Try

    End Sub
    Public Shared Sub consulta_vendedor(ByVal c As Integer, ByRef cod As String, ByRef nom As String, ByRef ced As String, ByRef tel As String, ByRef cel As String, ByRef email As String, ByRef cuenta As String, ByRef zona As MTGCComboBox, ByRef dirEnvio As String, ByRef banco As MTGCComboBox, ByRef obser As String, ByRef OcultaCom As Boolean, ByRef User As String, ByRef Password As String)
        Dim codZ As Integer
        Dim codB As String

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaVendedor"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        dr.Read()
        cod = CStr(dr("codigoVendedor"))
        nom = dr("nombre")
        ced = CStr(dr("cedula"))
        tel = CStr(dr("telefono"))
        cel = CStr(dr("celular"))
        email = dr("email")
        cuenta = dr("cuenta")
        dirEnvio = dr("dirEnvio")
        codB = dr("banco")
        codZ = dr("zona")
        obser = dr("observaciones")
        User = dr("Login")
        Password = dr("Password")

        If dr("OcultaCom").GetType.ToString = "System.DBNull" Then
            OcultaCom = False
        Else
            OcultaCom = dr("OcultaCom")
        End If

        dr.Close()


        consulta_zonas(zona)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaZona"
        command.Parameters.AddWithValue("@cod", codZ)
        dr = command.ExecuteReader()
        dr.Read()
        zona.Text = dr("Nombre")
        dr.Close()

        DatosBanco.consulta_bancos(banco)

        If codB = "" Then
            banco.Text = ""
        Else
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaBanco"
            command.Parameters.AddWithValue("@cod", CInt(codB))
            dr = command.ExecuteReader()
            dr.Read()
            banco.Text = dr("Nombre")
            dr.Close()
        End If
    End Sub
    Public Shared Sub identidad_vendedor(ByRef tb As TextBox)
        'Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure

        command.CommandText = "sp_identidadVendedor"
        dr = command.ExecuteReader
        dr.Read()
        tb.Text = dr("Expr1") + 1
        dr.Close()
    End Sub
    Public Shared Sub inserta_vendedor(ByVal cod As Integer, ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal obser As String, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedor"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", obser)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()
            'MsgBox("El Vendedor Ha Sido Registrado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub inserta_vendedor_COMER(ByVal cod As Integer, ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal obser As String, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedor_COMER"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", obser)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()
            'MsgBox("El Vendedor Ha Sido Registrado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub inserta_vendedor_DIST(ByVal cod As Integer, ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal obser As String, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedor_DIST"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", obser)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()
            'MsgBox("El Vendedor Ha Sido Registrado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub inserta_vendedor_CONAVE(ByVal cod As Integer, ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal obser As String, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedor_CONAVE"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", obser)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()
            'MsgBox("El Vendedor Ha Sido Registrado Exitosamente")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub modifica_vendedor(ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal Obser As String, ByVal COD As Integer, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaVendedor"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", Obser)
            command.Parameters.AddWithValue("@COD", COD)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error modificando datos del vendedor", ToolTipIcon.Error)

        End Try

    End Sub

    Public Shared Sub modifica_vendedor_COMER(ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal Obser As String, ByVal COD As Integer, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaVendedor_COMER"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", Obser)
            command.Parameters.AddWithValue("@COD", COD)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error modificando datos del vendedor", ToolTipIcon.Error)

        End Try

    End Sub

    Public Shared Sub modifica_vendedor_DIST(ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal Obser As String, ByVal COD As Integer, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaVendedor_DIST"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", Obser)
            command.Parameters.AddWithValue("@COD", COD)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error modificando datos del vendedor", ToolTipIcon.Error)

        End Try

    End Sub

    Public Shared Sub modifica_vendedor_CONAVE(ByVal nom As String, ByVal ced As String, ByVal telf1 As String, ByVal telf2 As String, ByVal cuenta As String, ByVal email As String, ByVal zona As Integer, ByVal banco As String, ByVal dirEnvio As String, ByVal Obser As String, ByVal COD As Integer, ByVal OcultaCom As Boolean, ByVal User As String, ByVal Password As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaVendedor_CONAVE"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@ced", ced)
            command.Parameters.AddWithValue("@telf1", telf1)
            command.Parameters.AddWithValue("@telf2", telf2)
            command.Parameters.AddWithValue("@cuenta", cuenta)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@banco", banco)
            command.Parameters.AddWithValue("@dirEnvio", dirEnvio)
            command.Parameters.AddWithValue("@obser", Obser)
            command.Parameters.AddWithValue("@COD", COD)
            command.Parameters.AddWithValue("@OcultaCom", OcultaCom)

            If User.Trim = "" Then
                command.Parameters.AddWithValue("@usr", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@usr", User)
            End If

            command.ExecuteNonQuery()

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error modificando datos del vendedor", ToolTipIcon.Error)

        End Try

    End Sub

    Public Shared Sub elimina_vendedor(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaVendedor"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_comisiones(ByRef t As DataGridView, ByVal cod As Integer)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaVendedorComision"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(dr("DiaInicial"), dr("DiaFinal"), dr("Comision"), dr("CodigoComision"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub inserta_comision(ByVal cod As Integer, ByVal dia1 As Integer, ByVal dia2 As Integer, ByVal com As Double)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedorComision"
            command.Parameters.AddWithValue("@codV", cod)
            command.Parameters.AddWithValue("@diaI", dia1)
            command.Parameters.AddWithValue("@diaF", dia2)
            command.Parameters.AddWithValue("@com", com)
            command.ExecuteNonQuery()

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error insertando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub inserta_comision_COMER(ByVal cod As Integer, ByVal dia1 As Integer, ByVal dia2 As Integer, ByVal com As Double)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedorComision_COMER"
            command.Parameters.AddWithValue("@codV", cod)
            command.Parameters.AddWithValue("@diaI", dia1)
            command.Parameters.AddWithValue("@diaF", dia2)
            command.Parameters.AddWithValue("@com", com)
            command.ExecuteNonQuery()

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error insertando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub inserta_comision_DIST(ByVal cod As Integer, ByVal dia1 As Integer, ByVal dia2 As Integer, ByVal com As Double)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedorComision_DIST"
            command.Parameters.AddWithValue("@codV", cod)
            command.Parameters.AddWithValue("@diaI", dia1)
            command.Parameters.AddWithValue("@diaF", dia2)
            command.Parameters.AddWithValue("@com", com)
            command.ExecuteNonQuery()

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error insertando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub inserta_comision_CONAVE(ByVal cod As Integer, ByVal dia1 As Integer, ByVal dia2 As Integer, ByVal com As Double)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_insertaVendedorComision_CONAVE"
            command.Parameters.AddWithValue("@codV", cod)
            command.Parameters.AddWithValue("@diaI", dia1)
            command.Parameters.AddWithValue("@diaF", dia2)
            command.Parameters.AddWithValue("@com", com)
            command.ExecuteNonQuery()

        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error insertando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub elimina_comision(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaVendedorComision"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error eliminando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub elimina_comision_COMER(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaVendedorComision_COMER"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error eliminando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub elimina_comision_DIST(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaVendedorComision_DIST"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error eliminando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub elimina_comision_CONAVE(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaVendedorComision_CONAVE"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error eliminando días de comisión del vendedor", ToolTipIcon.Error)
        End Try

    End Sub

    Public Shared Sub modifica_comision(ByVal codc As Integer, ByVal dia1 As Integer, ByVal dia2 As Integer, ByVal com As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaVendedorComision"
        command.Parameters.AddWithValue("@COD", codc)
        command.Parameters.AddWithValue("@diaI", dia1)
        command.Parameters.AddWithValue("@diaF", dia2)
        command.Parameters.AddWithValue("@com", com)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_CalculoComision(ByRef t As DataGridView, ByVal c As Integer, ByRef total As String, ByRef acum As Double)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_ConsultaCalculoComision"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        While dr.Read()
            t.Rows.Add(dr("NControl"), dr("controlInicio"), dr("codigoCliente"), dr("razonSocial"), dr("Nombre"), dr("fecha"), dr("fechaD"), dr("dias"), dr("montoTotal"), dr("monto"), dr("comision"), dr("calculo"), dr("CodigoRecibo"), dr("NumeroFactura"))
            acum = acum + dr("calculo")
        End While
        total = Format(acum, "#,##0.00")
        dr.Close()
    End Sub
    Public Shared Sub consulta_Facturas_vendedor(ByRef t As DataGridView, ByVal c As Integer)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaFacturas_Vendedor"
        command.Parameters.AddWithValue("@codV", c)
        dr = command.ExecuteReader()
        While dr.Read
            t.Rows.Add(dr("Fecha"), dr("NumeroFactura"), dr("controlInicio"), dr("CodigoCliente"), dr("RazonSocial"), dr("montoTotal"))
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_ultimo_codigo(ByRef codigo As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_codigo_vendedor_top"
            dr = command.ExecuteReader()        
            If dr.HasRows Then
                dr.Read()
                codigo = (CInt(dr("CodigoVendedor")) + 1).ToString
            End If
            dr.Close()
        Catch ex As Exception
            codigo = 1
        End Try
        
    End Sub
    Public Shared Sub consulta_codigo_existente(ByRef esta As Boolean, ByVal cod As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_verifica_codigo_vendedor"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        If dr.Read Then
            esta = True
        Else
            esta = False

        End If
        dr.Close()
    End Sub

    Public Shared Sub consulta_Docs_vendedor(ByRef t As DataGridView, ByVal vend As Integer, ByVal tipo As Integer)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaDocsPorEnviar"
        command.Parameters.AddWithValue("@Ven", vend)
        command.Parameters.AddWithValue("@Tipo", Tipo)
        dr = command.ExecuteReader()
        While dr.Read
            If tipo = 0 Then
                t.Rows.Add(dr("Fecha"), dr("ControlDoc"), dr("CodigoCliente"), dr("RazonSocial"), dr("monto"), dr("CodigoDoc"))
            ElseIf tipo = 1 Then
                t.Rows.Add(dr("Fecha"), dr("ControlDoc"), dr("CodigoCliente"), dr("RazonSocial"), dr("monto"), dr("CodigoDoc"))
            ElseIf tipo = 2 Then
                t.Rows.Add(dr("Fecha"), dr("ControlDoc"), dr("CodigoCliente"), dr("RazonSocial"), dr("monto"), dr("CodigoDoc"))
            End If
        End While
        dr.Close()
    End Sub

End Class
