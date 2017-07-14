Imports System.Data.SqlClient
Public Class DatosComisiones
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub inserta_comision(ByVal codV As Integer, ByVal fechaP As Date, ByVal fechaI As Date, ByVal fechaF As Date, ByVal Monto As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaComision"
        command.Parameters.AddWithValue("@codV", codV)
        command.Parameters.AddWithValue("@fechaP", fechaP)
        command.Parameters.AddWithValue("@fechaI", fechaI)
        command.Parameters.AddWithValue("@fechaF", fechaF)
        command.Parameters.AddWithValue("@Monto", Monto)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Modifica_Vendedor_comision(ByVal codV As Integer, ByVal Fact As String)

        Try

            command.Parameters.Clear()
            command.CommandText = "sp_modificaVendedorFactura"
            command.Parameters.AddWithValue("@codV", codV)
            command.Parameters.AddWithValue("@CodF", Fact)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Factura Modificada", ToolTipIcon.Info)

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error Modificando Facruta", ToolTipIcon.Error)

        End Try

    End Sub

    Public Shared Sub inserta_factura_comision(ByVal codC As Integer, ByVal codF As Integer, ByVal codR As Integer, ByVal por As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaFactura_Comision"
        command.Parameters.AddWithValue("@codC", codC)
        command.Parameters.AddWithValue("@codF", codF)
        command.Parameters.AddWithValue("@codR", codR)
        command.Parameters.AddWithValue("@por", por)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_identidadComision(ByRef cod As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadComision"
        dr = command.ExecuteReader()
        dr.Read()
        cod = dr(0) + 1
        dr.Close()
    End Sub
    Public Shared Sub consulta_comisiones_pagadas(ByRef t As DataGridView, ByVal cod As Integer, ByRef sw2 As Boolean, ByRef tot As String, ByRef OcultaCom As Boolean)
        Dim acum As Double = 0.0
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaComisionPagada"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        While dr.Read()

            t.Rows.Add(dr("CodigoComision"), dr("FechaPago"), dr("FechaI"), dr("FechaF"), dr("Monto"))

            If dr("OcultaCom").GetType.ToString = "System.DBNull" Then
                OcultaCom = False
            Else
                OcultaCom = dr("OcultaCom")
            End If

            acum = acum + dr("Monto")

        End While
        tot = FormatNumber(acum, 2)
        dr.Close()
        sw2 = True
    End Sub
    Public Shared Sub consulta_facturas_comisiones_pagadas(ByRef t As DataGridView, ByVal cod As Integer, ByRef total As String, ByVal m As Boolean, ByVal OcultaCom As Boolean)
        Try

            Dim acum As Double = 0
            t.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFacturasComisionPagada"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            While dr.Read()

                If m Then

                    t.Rows.Add(dr("NControl"), dr("controlInicio"), dr("codigoCliente"), dr("razonSocial"), dr("Nombre"), dr("fecha"), dr("fechaD"), dr("dias"), dr("montoTotal"), dr("monto"), dr("porcentaje"), dr("calculo"), dr("CodigoRecibo"), dr("CodigoFactura"))
                    acum = acum + dr("calculo")

                Else

                    If OcultaCom Then

                        t.Rows.Add(dr("NControl"), dr("controlInicio"), dr("codigoCliente"), dr("razonSocial"), dr("Nombre"), dr("fecha"), dr("fechaD"), dr("dias"), dr("montoTotal"), dr("monto"), "#,##", dr("calculo"), dr("CodigoRecibo"), dr("CodigoFactura"))
                        acum = acum + dr("calculo")

                    Else

                        t.Rows.Add(dr("NControl"), dr("controlInicio"), dr("codigoCliente"), dr("razonSocial"), dr("Nombre"), dr("fecha"), dr("fechaD"), dr("dias"), dr("montoTotal"), dr("monto"), dr("porcentaje"), dr("calculo"), dr("CodigoRecibo"), dr("CodigoFactura"))
                        acum = acum + dr("calculo")

                    End If

                End If

            End While

            total = Format(acum, "#,##0.00")

        Catch ex As Exception

            MsgBox("Error consultando detalles de la comisión", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub
    Public Shared Sub elimina_Facturas_Comision(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminafacturas_comision"
        command.Parameters.AddWithValue("@codC", cod)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub modifica_MontoComision(ByVal cod As Integer, ByVal monto As Double)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaMontoComision"
        command.Parameters.AddWithValue("@cod", cod)
        command.Parameters.AddWithValue("@monto", monto)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub elimina_Comision(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaComision"
        command.Parameters.AddWithValue("@codC", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Actualiza_recibo(ByVal cod As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_Actualiza_Recibo_Comision"
            command.Parameters.AddWithValue("@num", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        
    End Sub

End Class
