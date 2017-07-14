Imports System.Data.SqlClient
Imports Tesis_Nueva.MELDataSetTableAdapters

Public Class DatosAlmacenes

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand) ' Esteblece los objetos de conexiones y commandos

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Llenar_DGV_por_id(ByVal Id As Integer, ByVal DGV As DataGridView, ByVal TipoDGV As Integer) ' Llena cualquiera de los DGV principales menos Catálogopor un Id dado

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            If TipoDGV = 1 Then
                command.CommandText = "sp_consultaCuarto"
                command.Parameters.AddWithValue("@Almacen", Id)
                dr = command.ExecuteReader

                While dr.Read
                    DGV.Rows.Add(dr("Nombre"), dr("Id"))
                End While

            ElseIf TipoDGV = 2 Then
                command.CommandText = "sp_consultaEstante"
                command.Parameters.AddWithValue("@Cuarto", Id)
                dr = command.ExecuteReader

                While dr.Read
                    DGV.Rows.Add(dr("Nombre"), dr("Id"))
                End While

            ElseIf TipoDGV = 3 Then
                command.CommandText = "sp_consultaTramo"
                command.Parameters.AddWithValue("@Estante", Id)
                dr = command.ExecuteReader

                While dr.Read
                    DGV.Rows.Add(dr("Nombre"), dr("Id"))
                End While

            End If

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando las listas", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    
    Public Shared Sub InsertarAlmacen(ByVal Nombre As String, ByVal Direccion As String)

        Try
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaAlmacen"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Nombre", Nombre)
            command.Parameters.AddWithValue("@Direccion", Direccion)
            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    Public Shared Sub Insertar(ByVal Nombre As String, ByVal Id As Integer, ByVal Tipo As Integer)

        Try
            If Tipo = 1 Then

                command.CommandText = "sp_insertaCuarto"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Cuarto agregado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf Tipo = 2 Then

                command.CommandText = "sp_insertaEstante"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Estante agregado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf Tipo = 3 Then

                command.CommandText = "sp_insertaTramo"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Tramo agregado satisfactoriamente", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox("Error agregando elemento", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub Modificar(ByVal Nombre As String, ByVal Direccion As String, ByVal Id As Integer, ByVal tipo As Integer)

        Try
            command.CommandType = CommandType.StoredProcedure
            If tipo = 1 Then

                command.CommandText = "sp_modificaAlmacen"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Direccion", Direccion)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Almacén modificado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 2 Then

                command.CommandText = "sp_modificaCuarto"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Cuarto modificado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 3 Then

                command.CommandText = "sp_modificaEstante"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Estante modificado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 4 Then

                command.CommandText = "sp_modificaTramo"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Tramo modificado satisfactoriamente", MsgBoxStyle.Information)

            End If

        Catch ex As Exception

            MsgBox("Error modificando elemento", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub Eliminar(ByVal Id As Integer, ByVal tipo As Integer)

        Try
            command.CommandType = CommandType.StoredProcedure
            If tipo = 1 Then

                command.CommandText = "sp_EliminaAlmacen"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Almacén eliminado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 2 Then

                command.CommandText = "sp_eliminaCuarto"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Cuarto eliminado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 3 Then

                command.CommandText = "sp_eliminaEstante"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Estante eliminado satisfactoriamente", MsgBoxStyle.Information)

            ElseIf tipo = 4 Then

                command.CommandText = "sp_eliminaTramo"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                MsgBox("Tramo eliminado satisfactoriamente", MsgBoxStyle.Information)

            End If

        Catch ex As Exception

            MsgBox("Error eliminando elemento", MsgBoxStyle.Critical)


        End Try

    End Sub


    Public Shared Function HayProcutos(ByVal Id As Integer, ByVal tipo As Integer) As Boolean

        Dim Hay As Boolean = False
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Clear()

        If tipo = 4 Then

            command.CommandText = "sp_consultaProductoEnTramo"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            If dr.HasRows Then

                Hay = True

            End If

            dr.Close()

        ElseIf tipo = 3 Then

            command.CommandText = "sp_consultaProductoEnEstante"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            If dr.HasRows Then

                Hay = True

            End If

            dr.Close()

        ElseIf tipo = 2 Then

            command.CommandText = "sp_consultaProductoEnCuarto"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            If dr.HasRows Then

                Hay = True

            End If

            dr.Close()

        ElseIf tipo = 1 Then

            command.CommandText = "sp_consultaProductoEnAlmacen"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            If dr.HasRows Then

                Hay = True

            End If

            dr.Close()

        End If

        Return Hay

    End Function

    Public Shared Function ContarProductosCuarto(ByVal Id As Integer) As String

        Dim Productos As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosCuarto"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Productos = dr("Productos").ToString

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try

        Return Productos

    End Function

    Public Shared Function ContarUnidadesCuarto(ByVal Id As Integer) As String

        Dim Unidades As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosCuarto"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Unidades = dr("Unidades").ToString

            End While

            dr.Close()

            If Unidades = "" Then
                Unidades = "0"
            End If

        Catch ex As Exception
            dr.Close()
        End Try

        Return Unidades

    End Function

    Public Shared Function ContarProductosEstante(ByVal Id As Integer) As String

        Dim Productos As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosEstante"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Productos = dr("Productos").ToString

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try

        Return Productos

    End Function

    Public Shared Function ContarUnidadesEstante(ByVal Id As Integer) As String

        Dim Unidades As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosEstante"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Unidades = dr("Unidades").ToString

            End While

            dr.Close()

            If Unidades = "" Then
                Unidades = "0"
            End If

        Catch ex As Exception
            dr.Close()
        End Try

        Return Unidades

    End Function

    Public Shared Function ContarProductosTramo(ByVal Id As Integer) As String

        Dim Productos As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosTramo"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Productos = dr("Productos").ToString

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try

        Return Productos

    End Function

    Public Shared Function ContarUnidadesTramo(ByVal Id As Integer) As String

        Dim Unidades As String = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_contarProductosTramo"
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader

            While dr.Read

                Unidades = dr("Unidades").ToString

            End While

            dr.Close()

            If Unidades = "" Then
                Unidades = "0"
            End If

        Catch ex As Exception

        End Try

        Return Unidades

    End Function


    Public Shared Sub Busqueda(ByVal Nombre As String, ByVal DGV As DataGridView)

        Try

            DGV.DataSource = Nothing
            DGV.Rows.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAlmacenLike"
            command.Parameters.AddWithValue("@Nombre", Nombre)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Id"), dr.Item("Nombre"), dr.Item("Direccion"))

            End While

            dr.Close()

        Catch ex As Exception



        End Try

    End Sub


    Public Shared Sub CatalogoPorCuarto(ByVal DGV As DataGridView, ByVal Id As Integer)

        Try

            DGV.Rows.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoEnCuarto"
            command.Parameters.AddWithValue("@Id", Id)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Código"), dr.Item("CodigoProductoF"), dr.Item("Descripción"), dr.Item("CantidadExistencia"), dr.Item("Cantidad"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub

    Public Shared Sub CatalogoPorTramo(ByVal DGV As DataGridView, ByVal Id As Integer)

        Try

            DGV.Rows.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoEnTramo"
            command.Parameters.AddWithValue("@Id", Id)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Código"), dr.Item("CodigoProductoF"), dr.Item("Descripción"), dr.Item("CantidadExistencia"), dr.Item("Cantidad"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub


    Public Shared Sub CatalogoPorEstante(ByVal DGV As DataGridView, ByVal Id As Integer, ByVal idC As Integer)

        Try

            DGV.Rows.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoEnEstante"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@IdC", idC)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Código"), dr.Item("CodigoProductoF"), dr.Item("Descripción"), dr.Item("CantidadExistencia"), dr.Item("Cantidad"))

            End While

            dr.Close()

        Catch ex As Exception



            dr.Close()
        End Try

    End Sub

    Public Shared Sub CatalogoPorAlmacen(ByVal DGV As DataGridView, ByVal Id As Integer)

        Try

            DGV.Rows.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoEnAlmacen"
            command.Parameters.AddWithValue("@Id", Id)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Código"), dr.Item("CodigoProductoF"), dr.Item("Descripción"), dr.Item("CantidadExistencia"), dr.Item("Cantidad"))

            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()


        End Try

    End Sub


    Public Shared Sub llenar_cuartos(ByRef cb As ComboBox, ByVal id As Integer)


        Try
            cb.DataSource = Nothing
            cb.Items.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaCuarto"
            command.Parameters.AddWithValue("@Almacen", id)

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            cb.DataSource = ds.Tables(0)
            cb.ValueMember = "Id"
            cb.DisplayMember = "Nombre"

            Dim cont As Integer = 0

        Catch ex As Exception

            MsgBox("Error cargando lista de cuartos", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub llenar_almacen(ByRef cb As ComboBox)



        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure


            command.CommandText = "sp_consultaAlmacenes"
            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))

                'cb.Items.Add(dr.Item("Nombre"))
                'cb2.Items.Add(dr.Item("Id"))
            End While
            dr.Close()
        Catch ex As Exception

            MsgBox("Error cargando lista de almacenes", MsgBoxStyle.Critical)

            dr.Close()
        End Try


    End Sub



    Public Shared Sub llenar_estantes(ByRef cb As ComboBox, ByVal id As Integer)

        Try
            cb.DataSource = Nothing
            cb.Items.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaEstante"
            command.Parameters.AddWithValue("@Cuarto", id)

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            cb.DataSource = ds.Tables(0)
            cb.ValueMember = "Id"
            cb.DisplayMember = "Nombre"

        Catch ex As Exception

            MsgBox("Error cargando lista de estantes", MsgBoxStyle.Critical)


        End Try


    End Sub

    Public Shared Sub llenar_tramos(ByRef cb As ComboBox, ByVal id As Integer)


        Try
            cb.DataSource = Nothing
            cb.Items.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaTramo"
            command.Parameters.AddWithValue("@Estante", id)

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            cb.DataSource = ds.Tables(0)
            cb.ValueMember = "Id"
            cb.DisplayMember = "Nombre"


        Catch ex As Exception

            MsgBox("Error cargando lista de tramos", MsgBoxStyle.Critical)


        End Try


    End Sub

    Public Shared Sub Traspasos_Tramos(ByVal Tramo1 As Integer, ByVal Tramo2 As Integer, ByVal desde As String, ByVal hasta As String)

        Try
            Dim Unidades As Integer = 0
            Dim Productos As Integer = 0
            Dim tipo As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_TraspasosProductos"
            command.Parameters.AddWithValue("@CodA", "")
            command.Parameters.AddWithValue("@CodE", "")
            command.Parameters.AddWithValue("@CodC", "")
            command.Parameters.AddWithValue("@CodT", Tramo1)
            command.Parameters.AddWithValue("@Tramo2", Tramo2)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString <> "System.DBNull" And dr("Productos").GetType.ToString <> "System.DBNull" Then
                    If dr("Cantidad") = 0 Then
                        tipo = 0
                    Else
                        tipo = 1
                        Unidades = dr("Cantidad")
                        Productos = dr("Productos")
                    End If

                End If

            End While

            dr.Close()

            If tipo = 0 Then
                MsgBox("No existen productos en la ubicación seleccionada", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se movieron " & Unidades.ToString & " Unidades de " & Productos.ToString & " Productos desde la ubicación " & desde & " Hasta la ubicacion " & hasta & "", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

            MsgBox("Error realizando el traspaso de ubicaciones", MsgBoxStyle.Critical)

            dr.Close()

        End Try


    End Sub

    Public Shared Sub Traspasos_Estantes(ByVal Tramo2 As Integer, ByVal CodE As Integer, ByVal desde As String, ByVal hasta As String)

        Try

            Dim Unidades As Integer = 0
            Dim Productos As Integer = 0
            Dim tipo As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_TraspasosProductos"
            command.Parameters.AddWithValue("@CodE", CodE)
            command.Parameters.AddWithValue("@CodA", "")
            command.Parameters.AddWithValue("@CodC", "")
            command.Parameters.AddWithValue("@CodT", "")
            command.Parameters.AddWithValue("@Tramo2", Tramo2)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString <> "System.DBNull" And dr("Productos").GetType.ToString <> "System.DBNull" Then
                    If dr("Cantidad") = 0 Then
                        tipo = 0
                    Else
                        tipo = 1
                        Unidades = dr("Cantidad")
                        Productos = dr("Productos")
                    End If

                End If

            End While

            dr.Close()

            If tipo = 0 Then
                MsgBox("No existen productos en la ubicación seleccionada", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se movieron " & Unidades.ToString & " Unidades de " & Productos.ToString & " Productos desde la ubicación " & desde & " Hasta la ubicacion " & hasta & "", MsgBoxStyle.Information)
            End If


        Catch ex As Exception

            MsgBox("Error realizando el traspaso de ubicaciones", MsgBoxStyle.Critical)

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Traspasos_Cuartos(ByVal Tramo2 As Integer, ByVal CodC As Integer, ByVal desde As String, ByVal hasta As String)

        Try
            Dim Unidades As Integer = 0
            Dim Productos As Integer = 0
            Dim tipo As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_TraspasosProductos"
            command.Parameters.AddWithValue("@CodA", "")
            command.Parameters.AddWithValue("@CodE", "")
            command.Parameters.AddWithValue("@CodT", "")
            command.Parameters.AddWithValue("@CodC", CodC)
            command.Parameters.AddWithValue("@Tramo2", Tramo2)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString <> "System.DBNull" And dr("Productos").GetType.ToString <> "System.DBNull" Then
                    If dr("Cantidad") = 0 Then
                        tipo = 0
                    Else
                        tipo = 1

                        Unidades = dr("Cantidad")
                        Productos = dr("Productos")
                    End If

                End If

            End While

            dr.Close()

            If tipo = 0 Then
                MsgBox("No existen productos en la ubicación seleccionada", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se movieron " & Unidades.ToString & " Unidades de " & Productos.ToString & " Productos desde la ubicación " & desde & " Hasta la ubicacion " & hasta & "", MsgBoxStyle.Information)
            End If


        Catch ex As Exception

            MsgBox("Error realizando el traspaso de ubicaciones", MsgBoxStyle.Critical)

            dr.Close()
        End Try

    End Sub


    Public Shared Sub Traspasos_Almacenes(ByVal Tramo2 As Integer, ByVal CodA As Integer, ByVal desde As String, ByVal hasta As String)

        Try
            Dim Unidades As Integer = 0
            Dim Productos As Integer = 0
            Dim tipo As Integer = 0
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_TraspasosProductos"
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodC", "")
            command.Parameters.AddWithValue("@CodE", "")
            command.Parameters.AddWithValue("@CodT", "")
            command.Parameters.AddWithValue("@Tramo2", Tramo2)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString <> "System.DBNull" And dr("Productos").GetType.ToString <> "System.DBNull" Then
                    If dr("Cantidad") = 0 Then
                        tipo = 0
                    Else
                        tipo = 1
                        Unidades = dr("Cantidad")
                        Productos = dr("Productos")
                    End If

                End If

            End While

            dr.Close()

            If tipo = 0 Then
                MsgBox("No existen productos en la ubicación seleccionada", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se movieron " & Unidades.ToString & " Unidades de " & Productos.ToString & " Productos desde la ubicación " & desde & " Hasta la ubicacion " & hasta & "", MsgBoxStyle.Information)
            End If


        Catch ex As Exception

            MsgBox("Error realizando el traspaso de ubicaciones", MsgBoxStyle.Critical)

            dr.Close()

        End Try
    End Sub
    Public Shared Sub Llenar_DGV_UbicacionActual(ByVal DGV As DataGridView, ByVal Id As Integer)
        dr.Close()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductosFabrica"
        command.Parameters.AddWithValue("@IdF", Id)
        dr = command.ExecuteReader()
        DGV.Rows.Clear()

        While dr.Read()
            If CInt(dr("cantidad").ToString) <> 0 Then
                DGV.Rows.Add("", dr("CodigoInterno"), dr("CodigoProductoF"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"))
            End If



        End While
        dr.Close()
    End Sub
    Public Shared Sub InsertarNuevaUbicacion(ByVal codP As String, ByVal tramoAnterior As Integer, ByVal tramoAct As Integer, ByVal cantAct As Integer, ByVal cantfinal As Integer)
        Dim cant_tramoAnterior As Integer = 0
        Dim cant_tramoActual As Integer = 0
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCantidadEnTramo"
            command.Parameters.AddWithValue("@CodigoP", codP)
            command.Parameters.AddWithValue("@tramo", tramoAnterior)
            dr = command.ExecuteReader
            If dr.Read Then
                cant_tramoAnterior = CInt(dr("Cantidad"))
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCantidadEnTramo"
            command.Parameters.AddWithValue("@CodigoP", codP)
            command.Parameters.AddWithValue("@tramo", tramoAct)
            dr = command.ExecuteReader
            If dr.Read Then
                cant_tramoActual = CInt(dr("Cantidad"))
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

        Try

            'Aqui deberia eliminar la ubic si cant = 0
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_actualiza_cantidadTramo"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@codP", codP)
            command.Parameters.AddWithValue("@tramo", tramoAnterior)
            command.Parameters.AddWithValue("@cant", cantfinal)
            command.ExecuteNonQuery()

            If cant_tramoActual <> 0 Then
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_actualiza_cantidadTramo"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@codP", codP)
                command.Parameters.AddWithValue("@tramo", tramoAct)
                command.Parameters.AddWithValue("@cant", cant_tramoActual + cantAct)
                command.ExecuteNonQuery()
            Else
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_inserta_tramo_producto"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@codP", codP)
                command.Parameters.AddWithValue("@tramo", tramoAct)
                command.Parameters.AddWithValue("@cant", cantAct)
                command.ExecuteNonQuery()
            End If

        Catch ex As Exception


            dr.Close()
        End Try


    End Sub

    Public Shared Sub BusquedaProdcutosLike(ByVal nombre As String, ByVal cod As String, ByVal DGV As DataGridView, ByVal idA As Integer, ByVal tip As Integer, ByVal c As Boolean)

        Dim tipoCod As Integer
        Try

            If nombre = "Código" Then
                tipoCod = 0
            ElseIf nombre = "Descripción" Then
                tipoCod = 2
            Else
                tipoCod = 1
            End If

            DGV.ClearSelection()

            DGV.Rows.Clear()


            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosLike"
            command.Parameters.AddWithValue("@CodigoP", cod)
            command.Parameters.AddWithValue("@IdF", idA)
            command.Parameters.AddWithValue("@tipoCod", tipoCod)



            dr = command.ExecuteReader

            While dr.Read
                If c = True Then
                    If CInt(dr("cantidad").ToString) <> 0 Then
                        DGV.Rows.Add("", dr("CodigoInterno"), dr("CodigoProductoF"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"))
                    End If
                Else
                    If CInt(dr("cantidad").ToString) <> 0 Then
                        DGV.Rows.Add(dr("CodigoInterno"), dr("CodigoProductoF"), dr("Nombre"), dr("Cantidad"))
                    End If
                End If


            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub





    Public Shared Sub llenarcuartos(ByRef cb As ComboBox, ByRef cb2 As ComboBox, ByVal id As Integer)



        Try

            cb.Items.Clear()

            cb2.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure


            command.CommandText = "sp_consultaCuarto"
            command.Parameters.AddWithValue("@Almacen", id)
            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))
            End While
            dr.Close()
        Catch ex As Exception

            MsgBox("Error cargando lista de cuartos", MsgBoxStyle.Critical)

            dr.Close()
        End Try


    End Sub

    Public Shared Sub llenarestantes(ByRef cb As ComboBox, ByRef cb2 As ComboBox, ByVal id As Integer)



        Try

            cb.Items.Clear()

            cb2.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure


            command.CommandText = "sp_consultaEstante"
            command.Parameters.AddWithValue("@Cuarto", id)
            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))

            End While
            dr.Close()
        Catch ex As Exception

            MsgBox("Error cargando lista de estantes", MsgBoxStyle.Critical)

            dr.Close()

        End Try


    End Sub
    Public Shared Sub llenartramos(ByRef cb As ComboBox, ByRef cb2 As ComboBox, ByVal id As Integer)



        Try
            cb.DataSource = Nothing
            cb.Items.Clear()
            cb2.DataSource = Nothing
            cb2.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure


            command.CommandText = "sp_consultaTramo"
            command.Parameters.AddWithValue("@Estante", id)
            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(New comboItem(dr("Nombre"), dr("Id")))
            End While
            dr.Close()
        Catch ex As Exception

            MsgBox("Error cargando lista de tramos", MsgBoxStyle.Critical)

            dr.Close()

        End Try


    End Sub
    Public Shared Sub buscar_por_tramo(ByVal codT As Integer, ByVal codA As Integer, ByRef DGV As DataGridView, ByVal codE As Integer, ByVal codC As Integer)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_por_ubicacion"
            command.Parameters.AddWithValue("@CodA", codA)
            command.Parameters.AddWithValue("@CodT", codT)
            command.Parameters.AddWithValue("@CodE", codE)
            command.Parameters.AddWithValue("@CodC", codC)
            dr = command.ExecuteReader

            While dr.Read
                DGV.Rows.Add(dr("CodigoInterno"), dr("CodigoProductoF"), dr("Nombre"), dr("Cantidad"))
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
    Public Shared Sub Busqueda2(ByVal Nombre As Integer, ByVal DGV As DataGridView)

        Try
            DGV.DataSource = Nothing
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAlmacenCodigoLike"
            command.Parameters.AddWithValue("@CodA", Nombre)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Id"), dr.Item("Nombre"), dr.Item("Direccion"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Inserta_Traspaso(ByVal tramoAnt As Integer, ByVal tramoNuevo As Integer, ByVal codProducto As String, ByVal cant As Integer, ByVal user As String)

        Try
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertar_traspaso"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@tramoAnt", tramoAnt)
            command.Parameters.AddWithValue("@tramoNuevo", tramoNuevo)
            command.Parameters.AddWithValue("@codProducto", codProducto)
            command.Parameters.AddWithValue("@cant", cant)
            command.Parameters.AddWithValue("@user", user)
            command.Parameters.AddWithValue("@fecha", Today)
            command.ExecuteNonQuery()
        Catch ex As Exception


            dr.Close()
        End Try


    End Sub

    Public Shared Function ExisteUbicacion(ByVal codT As Integer, ByVal codP As String) As Boolean

        Dim esta As Boolean = False

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaTramoProducto"
            command.Parameters.AddWithValue("@tramo", codT)
            command.Parameters.AddWithValue("@Cod", codP)

            dr = command.ExecuteReader

            If dr.HasRows Then

                esta = True

            End If

        Catch ex As Exception

            MsgBox("Error verificando ubicación", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

        Return esta

    End Function

    Public Shared Sub Elimina_Ubicaciones_Vacias()
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaUbicacionesVacias"
        command.ExecuteNonQuery()
    End Sub

End Class