Imports System.Data.SqlClient
Imports Tesis_Nueva.MELDataSetTableAdapters

Public Class DatosAnalisisPedido

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand) ' Esteblece los objetos de conexiones y commandos

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Llenar_Pedidos_Por_Vendedor(ByVal Tipo As Integer, ByVal DGV As DataGridView, ByVal CodPed As Integer, ByVal CodZona As Integer, ByVal CodAlmacen As Integer, ByVal Periodo As String)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodPed", CodPed)
            command.Parameters.AddWithValue("@CodZona", CodZona)
            command.Parameters.AddWithValue("@CodAlmacen", CodAlmacen)
            command.Parameters.AddWithValue("@Periodo", Periodo)

            command.CommandText = "sp_PedidosPorVendedor"

            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("CodigoVendedor"), dr("Nombre"), dr("CantP"), dr("Monto"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message().ToString())
        End Try

    End Sub

    Public Shared Sub Llenar_Pedidos_Por_Monto(ByVal Tipo As Integer, ByVal idVendedor As Integer, ByVal DGV As DataGridView, ByVal CodZona As Integer, ByVal CodAlmacen As Integer, ByVal Periodo As String)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@idVendedor", idVendedor)
            command.Parameters.AddWithValue("@CodZona", CodZona)
            command.Parameters.AddWithValue("@CodAlmacen", CodAlmacen)
            command.Parameters.AddWithValue("@Periodo", Periodo)
            command.CommandText = "sp_PedidosPorMonto"

            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("CodigoPedido"), FormatDateTime(dr("Fecha"), DateFormat.ShortDate), dr("CodigoCliente"), dr("RazonSocial"), dr("MontoTotal"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub Llenar_Pedidos_Por_Fecha(ByVal Tipo As Integer, ByVal idVendedor As Integer, ByVal DGV As DataGridView, ByVal CodPed As Integer, ByVal CodZona As Integer, ByVal CodAlmacen As Integer)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@idVendedor", idVendedor)
            command.Parameters.AddWithValue("@CodPed", CodPed)
            command.Parameters.AddWithValue("@CodZona", CodZona)
            command.Parameters.AddWithValue("@CodAlmacen", CodAlmacen)
            command.CommandText = "sp_PedidosPorFecha"

            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("Periodo"), dr("CantP"), dr("Monto"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub Llenar_Pedidos_Por_Zona(ByVal Tipo As Integer, ByVal idVendedor As Integer, ByVal DGV As DataGridView, ByVal CodPed As Integer, ByVal CodAlmacen As Integer, ByVal Periodo As String)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@idVendedor", idVendedor)
            command.Parameters.AddWithValue("@CodPed", CodPed)
            command.Parameters.AddWithValue("@CodAlmacen", CodAlmacen)
            command.Parameters.AddWithValue("@Periodo", Periodo)
            command.CommandText = "sp_PedidosPorZona"

            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("CodigoZona"), dr("Nombre"), dr("CantP"), dr("Monto"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub Llenar_Pedidos_Por_Almacen(ByVal Tipo As Integer, ByVal DGV As DataGridView, ByVal CodZona As Integer, ByVal idVendedor As Integer, ByVal CodPed As Integer, ByVal Periodo As String)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodZona", CodZona)
            command.Parameters.AddWithValue("@CodPed", CodPed)
            command.Parameters.AddWithValue("@idVendedor", idVendedor)
            command.Parameters.AddWithValue("@Periodo", Periodo)
            command.CommandText = "sp_PedidosPorAlmacen"

            dr = command.ExecuteReader()

            If Tipo = 0 Then
                While dr.Read()
                    DGV.Rows.Add(dr("Nombre"), dr("CantP"), dr("Monto"), dr("Id"))
                End While
            Else
                While dr.Read()
                    DGV.Rows.Add(dr("Nombre"), dr("CantP"), dr("Monto"))
                End While
            End If

            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

End Class
