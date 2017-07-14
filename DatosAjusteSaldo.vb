Imports System.Data.SqlClient

Public Class DatosAjusteSaldo

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub DGV_Ajustes(ByRef DGV As DataGridView, ByVal Nombre As String, ByVal Tipo As Integer)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Nom", Nombre)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.CommandText = "sp_consultaAjustesSaldos"

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("NumeroAjuste"), dr("ControlInicio"), dr("Fecha"), dr("Cliente"), dr("Monto"), dr("NumeroFactura"))

            End While

        Catch ex As Exception

            MsgBox("Error cargando lista de ajustes", MsgBoxStyle.Critical, "Error")


        Finally

            DGV.ClearSelection()
            dr.Close()

        End Try


    End Sub

    Public Shared Sub Consulta_Ajuste(ByRef CodAjuste As String, ByRef User As String, ByRef ControlFact As String, ByRef CodCliente As String, ByRef NombreCliente As String, ByRef MontoAjuste As String, ByRef FechaAjuste As Date, ByRef ObsAjuste As String, ByRef subtotal As String, ByRef iva As String, ByRef Total As String, ByRef Ajuste As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Nom", CodAjuste)
            command.Parameters.AddWithValue("@Tipo", 5)
            command.CommandText = "sp_consultaAjustesSaldos"

            dr = command.ExecuteReader

            While dr.Read

                CodAjuste = dr("NumeroAjuste")
                FechaAjuste = dr("Fecha")
                User = dr("Usuario")
                CodCliente = dr("CodigoCliente")
                NombreCliente = dr("Cliente")
                MontoAjuste = Format(dr("Monto"), "#,##0.00")
                ControlFact = dr("ControlInicio")
                ObsAjuste = dr("Observacion")
                iva = Format(dr("Iva"), "#,##0.00")
                Total = Format(dr("MontoTotal"), "#,##0.00")
                subtotal = Format(dr("SubTotal"), "#,##0.00")
                Ajuste = Format(dr("Monto"), "#,##0.00")

            End While

        Catch ex As Exception

            MsgBox("Error cargando ajuste", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try


    End Sub

    Public Shared Sub DGV_Facturas(ByRef DGV As DataGridView, ByVal Nombre As String, ByVal Tipo As Integer)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@cod", Nombre)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.CommandText = "sp_consultaFacturasNoAjustadas"

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("NumeroFactura"), dr("ControlInicio"), dr("Fecha"), dr("RazonSocial"), dr("MontoPendiente"), dr("Iva"), dr("CodigoCliente"), dr("MontoTotal"))

            End While

        Catch ex As Exception

            MsgBox("Error cargando lista de facturas", MsgBoxStyle.Critical, "Error")


        Finally

            DGV.ClearSelection()
            dr.Close()

        End Try


    End Sub

    Public Shared Sub consulta_identidadAjuste(ByRef cod As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadAjusteSaldo"
        dr = command.ExecuteReader()
        dr.Read()
        cod = dr(0)
        dr.Close()
    End Sub

    Public Shared Sub consulta_facturas(ByRef t As DataGridView, ByVal c As Integer, ByRef TotalRecibos As String, ByRef TotalNotas As String, ByRef TotalRet As String)

        Try

            t.Rows.Clear()
            Dim total As Double = 0
            Dim totalNC As Double = 0
            Dim totalRet2 As Double = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFacturas_Recibo"
            command.Parameters.AddWithValue("@cod", c)
            command.Parameters.AddWithValue("@Tipo", 2)
            dr = command.ExecuteReader()
            While dr.Read()
                t.Rows.Add(dr("controlInicio"), dr("NControl"), dr("fecha"), dr("FechaD"), dr("MontoTotal"), dr("Monto"), dr("Dias"), dr("codigoFactura"), dr("MontoNC"), dr("Retencion"), dr("Iva"))
                total = total + dr("Monto")
                totalNC = dr("MontoNC")
                totalRet2 = dr("Retencion")
            End While

            TotalRecibos = Format(total, "#,##0.00").ToString
            TotalRet = Format((totalRet2) * -1, "#,##0.00").ToString
            TotalNotas = Format(totalNC, "#,##0.00").ToString

        Catch ex As Exception

            MsgBox("Error cargando lista de recibos", MsgBoxStyle.Critical, "Error")


        Finally

            t.ClearSelection()
            dr.Close()

        End Try
    End Sub

    Public Shared Sub InsertaAjuste(ByVal Fecha As Date, ByVal usuario As String, ByVal fact As Integer, ByVal Monto As Double, ByVal obs As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.Parameters.AddWithValue("@Fact", fact)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Monto", Monto)
            command.Parameters.AddWithValue("@Obs", obs)
            command.CommandText = "sp_InsertaAjusteSaldo"

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando ajuste", MsgBoxStyle.Critical, "Error")


        End Try


    End Sub

    Public Shared Sub ModificaAjuste(ByVal Fecha As Date, ByVal usuario As String, ByVal fact As Integer, ByVal Monto As Double, ByVal cod As Integer, ByVal obs As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.Parameters.AddWithValue("@Fact", fact)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Monto", Monto)
            command.Parameters.AddWithValue("@obs", obs)
            command.Parameters.AddWithValue("@Cod", cod)

            command.CommandText = "sp_modificaAjusteSaldo"

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando ajuste", MsgBoxStyle.Critical, "Error")


        End Try


    End Sub

    Public Shared Sub EliminaAjuste(ByVal cod As Integer)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", cod)
            command.CommandText = "sp_eliminaAjusteSaldo"

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando ajuste", MsgBoxStyle.Critical, "Error")


        End Try


    End Sub

    Public Shared Function AjustesFactura(ByVal cod As Integer) As Double

        Dim monto As Double = 0

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAjustesSaldosFactura"
            command.Parameters.AddWithValue("@Cod", cod)

            dr = command.ExecuteReader

            dr.Read()

            If dr.HasRows Then
                If dr("TotalAjustes").GetType.ToString = "System.DBNull" Then
                    monto = "0,00"
                Else
                    monto = dr("TotalAjustes")
                End If
            Else
                monto = "0,00"
            End If

            dr.Close()

        Catch ex As Exception


            dr.Close()

        End Try

        Return monto

    End Function

End Class