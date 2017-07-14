Imports System.Data.SqlClient
Public Class DatosGuiaTransporte
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_facturas_guia(ByVal dg As DataGridView, ByVal Tipo As Integer)
        dg.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tipo", Tipo)
        command.CommandText = "sp_consultaClienteFactura"
        dr = command.ExecuteReader()
        While dr.Read
            If Not dr("Enviado") Then
                dg.Rows.Add(dr("Fecha"), dr("NumeroFactura"), dr("ControlInicio"), dr("CodigoCliente"), dr("RazonSocial"), dr("NumeroBultos"), dr("MontoTotal"), dr("CodigoPedido"))
            End If
        End While
        dg.Sort(dg.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        dr.Close()
    End Sub

    Public Shared Function Consulta_FletePago(ByVal cod As Integer) As String

        Dim Flete As String = ""

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCliente"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            While dr.Read

                If dr("FletePago").GetType.ToString = "System.DBNull" Then

                    Flete = "Cliente"

                Else

                    If dr("FletePago") Then
                        Flete = "Origen"
                    Else
                        Flete = "Cliente"
                    End If

                End If


            End While


        Catch ex As Exception

            MsgBox("Error consultando flete del cliente", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

        Return Flete

    End Function

    Public Shared Sub consulta_camion1(ByRef cb As ComboBox, ByVal codTrans As Integer, ByRef col As Collection)
        Dim cont As Integer = 0
        col.Clear()
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCamion"
        command.Parameters.AddWithValue("@codTrans", codTrans)
        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New comboItem(dr("Modelo") + "  " + dr("Placa"), cont))

            col.Add(dr("Placa"))
            cont = cont + 1
        End While
        dr.Close()

        If cb.Items.Count > 0 Then
            cb.SelectedIndex = 0
        End If

    End Sub
    Public Shared Sub consulta_ChoferesRep(ByRef cb As ComboBox, ByVal codTrans As Integer, ByRef col As Collection)
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaChoferRep"
        command.Parameters.AddWithValue("@codTrans", codTrans)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(dr("Nombre"), dr("Cedula")))
            
            col.Add(dr("Cedula"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_cliente_direccion(ByVal cod As Integer, ByRef direccion As String, ByRef rif As String, ByRef tlf As String, ByRef ciudad As String)

        Dim direccionE As String = ""

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCliente"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        dr.Read()
        direccion = dr("Direccion")
        ciudad = dr("Ciudad")
        rif = dr("Rif")
        If dr("Telefono1").GetType.ToString = "System.DBNull" Then
            tlf = ""
        Else
            tlf = dr("Telefono1")
        End If

        If dr("DireccionEntrega").GetType.ToString = "System.DBNull" Then
            direccionE = ""
        Else
            direccionE = dr("DireccionEntrega")
        End If

        If dr("DireccionEntrega").GetType.ToString <> "System.DBNull" Then

            If direccionE.Trim.ToUpper <> direccion.Trim.ToUpper And direccionE.Trim.ToUpper <> "" Then
                direccion = direccionE
            End If

        End If

        dr.Close()

    End Sub

    Public Shared Sub actualiza_Factura(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaFactura"
            command.Parameters.AddWithValue("@Cod", cod)
            command.Parameters.AddWithValue("@Valor", 1)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error actualizando el estado de las facturas", MsgBoxStyle.Critical, "Mensaje de error")

        End Try


    End Sub

    Public Shared Sub actualiza_Factura2(ByVal cod As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaFactura"
            command.Parameters.AddWithValue("@Cod", cod)
            command.Parameters.AddWithValue("@Valor", 0)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error actualizando el estado de las facturas", MsgBoxStyle.Critical, "Mensaje de error")

        End Try


    End Sub


    Public Shared Function inserta_guia_transporte(ByVal idTransporte As Integer, ByVal idtransportis As Integer, ByVal idCamion As String, ByVal ci As String, ByVal aprobado As String, ByVal elaborado As String, ByVal observacion As String, ByVal dgv As DataGridView, ByVal entrega As String, ByVal guia As Integer, ByVal fecha As Date) As Integer

        Dim cod As Integer = 0

        Try
            Dim cont2 As Integer = 0

            command.Parameters.Clear()
            command.CommandText = "sp_inserta_guia_transporte"
            command.Parameters.AddWithValue("@idTransporte", idTransporte)
            command.Parameters.AddWithValue("@idTransportista ", idtransportis)
            command.Parameters.AddWithValue("@idCamion", idCamion)
            command.Parameters.AddWithValue("@Aprobado ", aprobado)
            command.Parameters.AddWithValue("@Elaborado ", elaborado)
            command.Parameters.AddWithValue("@Observaciones ", observacion)
            command.Parameters.AddWithValue("@Entrega ", entrega)
            command.Parameters.AddWithValue("@ci", ci)
            command.Parameters.AddWithValue("@guia", guia)
            command.Parameters.AddWithValue("@flete", dgv.Rows(cont2).Cells(7).Value)
            command.Parameters.AddWithValue("@fecha", fecha)

            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaUtimaGuiaTransporte"

            dr = command.ExecuteReader()

            If dr.Read Then
                cod = (CInt(dr("id"))).ToString
            End If

            dr.Close()

            For cont As Integer = 0 To dgv.RowCount - 1
                cont2 = cont
                command.Parameters.Clear()
                command.CommandText = "sp_inserta_guia_transporte_fact"
                command.Parameters.AddWithValue("@cod", cod)
                command.Parameters.AddWithValue("@factura", CInt(dgv.Rows(cont).Cells(1).Value))

                If dgv.Rows(cont2).Cells(7).Value.ToString.ToLower = "origen" Then
                    command.Parameters.AddWithValue("@fp", True)
                Else
                    command.Parameters.AddWithValue("@fp", False)
                End If

                command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("Ocurrió un error creando la guía", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.ToString)
        End Try

        Return cod

    End Function

    Public Shared Sub modifica_guia_transporte(ByVal observacion As String, ByVal guia As Integer, ByVal fecha As Date, ByVal Tipo As Integer, ByVal Fact As Integer, ByVal fp As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modifica_guia_transporte"
            command.Parameters.AddWithValue("@Observaciones ", observacion)
            command.Parameters.AddWithValue("@guia", guia)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@fact", Fact)
            If fp.ToLower = "origen" Then
                command.Parameters.AddWithValue("@fp", True)
            Else
                command.Parameters.AddWithValue("@fp", False)
            End If

            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error modificando guia", MsgBoxStyle.Critical, "SINPRO")

        End Try

    End Sub

    Public Shared Sub consulta_codigo(ByRef codigo As String)


        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_codigo_guia_transporte"
        dr = command.ExecuteReader()
        If dr.Read Then
            codigo = (CInt(dr("id")) + 1).ToString

        Else
            codigo = 1

        End If
        dr.Close()
    End Sub
    Public Shared Sub consulta_guías(ByRef DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_guia"
            dr = command.ExecuteReader()

            While dr.Read

                DGV.Rows.Add(dr("id"), dr("Nombre"))

            End While
            dr.Close()


        Catch ex As Exception

        End Try

    End Sub




    Public Shared Sub consulta_datos_guia(ByRef idTransporte As String, ByRef idtransportis As String, ByRef idCamion As String, ByRef ci As String, ByRef aprobado As String, ByRef elaborado As String, ByRef observacion As String, ByRef dgv As DataGridView, ByRef entrega As String, ByRef guia As Integer, ByRef fecha As Date)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_guia_datos"
            command.Parameters.AddWithValue("@cod", guia)
            dr = command.ExecuteReader()

            While dr.Read

                idTransporte = dr("trans")
                idtransportis = dr("NombreApellido")
                idCamion = dr("camion")
                aprobado = dr("Aprobado")
                elaborado = dr("Elaborado")
                observacion = dr("Observaciones")
                entrega = dr("Entrega")
                ci = dr("ci")
                guia = dr("id")
                If Not dr("Fecha").GetType.ToString = "System.DBNull" Then
                    fecha = dr("Fecha")
                End If

                If dr("FletePago") Then
                    dgv.Rows.Add(dr("Fecha"), dr("NumeroFactura"), dr("ControlInicio"), dr("CodigoCliente"), dr("RazonSocial"), dr("Bultos"), dr("MontoTotal"), "Origen", dr("Direccion"), dr("Rif"), dr("Telefono1"), dr("Ciudad"), dr("CodigoPedido"))
                Else
                    dgv.Rows.Add(dr("Fecha"), dr("NumeroFactura"), dr("ControlInicio"), dr("CodigoCliente"), dr("RazonSocial"), dr("Bultos"), dr("MontoTotal"), "Cliente", dr("Direccion"), dr("Rif"), dr("Telefono1"), dr("Ciudad"), dr("CodigoPedido"))
                End If



            End While
            dr.Close()

        Catch ex As Exception

            dr.Close()
        End Try

    End Sub


    Public Shared Sub consulta_guia_like(ByVal nom As String, ByVal DGV As DataGridView, ByVal tipo As Integer)

        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_guia_like"
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@tipo", tipo)
        dr = command.ExecuteReader()
        While dr.Read

            DGV.Rows.Add(dr("id"), dr("Nombre"))

        End While
        dr.Close()

    End Sub

    Public Shared Sub identidad_guia(ByRef cod As String)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadGuiaTransporte"
        dr = command.ExecuteReader()
        While dr.Read

            cod = dr("Expr1")

        End While
        dr.Close()

    End Sub


    Public Shared Sub ver_transporte(ByRef cb As ComboBox)
        Dim cont As Integer = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_VerTransporte"
        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoTransporte")))

        End While
        dr.Close()

    End Sub



    Public Shared Sub consulta_chofer(ByRef cb As ComboBox, ByVal cod As Integer)
        Dim cont As Integer = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_VerTransporte"
        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoTransporte")))

        End While
        dr.Close()

    End Sub
End Class
