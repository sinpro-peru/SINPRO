Imports System.Data.SqlClient

Public Class DatosComprasCargadas

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub consulta_compras(ByRef dgv As DataGridView, ByRef dolares As String, ByRef euros As String)
        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_compras_cargadas"
            dr = command.ExecuteReader()
            Dim dolar As Double = 0
            Dim euro As Double = 0

            While dr.Read()
                dgv.Rows.Add(dr("NumeroFactura"), dr("Fecha"), dr("Nombre"), dr("CodigoPedido"), dr("CodigoCompra"), Format(dr("Total"), "#,##0.00"), dr("Moneda"))

                If dr("Moneda") = "$" Then
                    dolar = dolar + CDbl(dr("Total"))
                Else
                    euro = euro + CDbl(dr("Total"))
                End If

            End While

            dolares = Format(dolar, "#,##0.00")
            euros = Format(euro, "#,##0.00")


            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub Arancel_Compra(ByVal Pedido As Integer, ByVal Pro As String, ByVal Arancel As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaarancelCompra"
            command.Parameters.AddWithValue("@codP", Pro)
            command.Parameters.AddWithValue("@codPed", Pedido)
            command.Parameters.AddWithValue("@Arancel", Arancel)
            command.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_datos_compra(ByRef dgv As DataGridView, ByRef obs As String, ByRef flete As String, ByRef arancel As String, ByRef otros As String, ByRef moneda As String, ByVal codP As Integer, ByRef TCA As String, ByRef TCO As String, ByRef Margen As String, ByRef TotalArt As String, ByRef TotalUni As String)
        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_datos_compra"
            command.Parameters.AddWithValue("@codP", codP)
            dr = command.ExecuteReader()

            Dim TA As Integer = 0
            Dim TU As Integer = 0

            While dr.Read()
                TA = TA + 1
                TU = TU + dr("Cantidad")
                dgv.Rows.Add(CInt(dr("Cantidad")), dr("CodigoProducto"), dr("CodigoFabrica"), dr("Nombre"), dr("Modelo"), CDbl(dr("Costo")), CDbl(dr("Cantidad") * dr("Costo")), CDbl(dr("FleteProducto")), CDbl(dr("Costo") + CDbl(dr("FleteProducto"))), CDbl(dr("ArancelCompra")), CDbl(dr("ArancelBs")), CDbl(dr("OtrosG")), CDbl(dr("CostoTotal")), CDbl(dr("PrecioVentaFinal")))
                obs = dr("Observacion")
                TCA = Format(dr("TCAranceles"), "#,##0.00").ToString
                Margen = Format(dr("Margen"), "#,##0.00").ToString
                TCO = Format(dr("TCOtros"), "#,##0.00").ToString
                flete = Format(dr("Flete"), "#,##0.00")
                arancel = Format(dr("Aranceles"), "#,##0.00")
                otros = Format(dr("OtrosGastos"), "#,##0.00").ToString + "%"
                moneda = dr("Moneda")
            End While

            TotalArt = TA.ToString
            TotalUni = TU.ToString

            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_Productos_compra(ByRef dgv As DataGridView, ByVal codP As String, ByVal cod As Integer, ByVal Tipo As Integer)
        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosEnCompra"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@codP", codP)
            dr = command.ExecuteReader()

            While dr.Read()
                dgv.Rows.Add(dr("Cantidad"), dr("CodigoProducto"), dr("CodigoFabrica"), dr("Nombre"), dr("Modelo"), Format(dr("Costo"), "#,##0.00"))
            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_compras_like(ByRef dgv As DataGridView, ByVal cod As String, ByVal tipo As Integer, ByRef dolares As String, ByRef euros As String, ByVal fechaI As Date, ByVal fechaF As Date)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_compras_cargadas_like"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.Parameters.AddWithValue("@fechaI", fechaI)
            command.Parameters.AddWithValue("@fechaF", fechaF)
            dr = command.ExecuteReader()
            Dim dolar As Double = 0
            Dim euro As Double = 0

            While dr.Read()
                dgv.Rows.Add(dr("NumeroFactura"), dr("Fecha"), dr("Nombre"), dr("CodigoPedido"), dr("CodigoCompra"), Format(dr("Total"), "#,##0.00"), dr("Moneda"))

                If dr("Moneda") = "$" Then
                    dolar = dolar + CDbl(dr("Total"))
                Else
                    euro = euro + CDbl(dr("Total"))
                End If

            End While

            dolares = Format(dolar, "#,##0.00")
            euros = Format(euro, "#,##0.00")

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Public Shared Sub modificar_factura_compra(ByVal codigocompra As Integer, ByVal fact As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_modifica_factura_compra"
            command.Parameters.AddWithValue("@CodC", codigocompra)
            command.Parameters.AddWithValue("@Fact", fact)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando factura", MsgBoxStyle.Information, "Error")


        End Try


    End Sub

End Class
