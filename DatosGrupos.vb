Imports System.Data.SqlClient
Public Class DatosGrupos
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub Llenar_DGV_Like(ByVal nom As String, ByVal Tipo As Integer, ByVal DGV As DataGridView)


        Try
            Dgv.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_dgvGruposProductos"
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@Tipo", Tipo)

            dr = command.ExecuteReader

            While dr.Read


                DGV.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("PrecioVenta"), dr("CantidadExistencia"))

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Dgv_Grupo(ByVal Dgv As DataGridView, ByVal s As String, ByVal val As Integer)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvGrupo"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
            dr = command.ExecuteReader()
            While dr.Read()
                Dgv.Rows.Add(dr("CodigoGrupo"), dr("NombreGrupo"))
            End While
            dr.Close()
            Dgv.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message().ToString())
        End Try

    End Sub
    Public Shared Sub lv_grupo(ByRef lv As ListView, ByVal s As String, ByVal val As Integer)
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvGrupo"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            Dim c As Integer = dr("codigoGrupo")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("nombreGrupo"))
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub
    Public Shared Sub Consultar_Grupos(ByVal Dgv As DataGridView, ByVal cod As Integer)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaGrupo"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@Valor", "")
            dr = command.ExecuteReader()

            While dr.Read()
                Dgv.Rows.Add(dr("CodigoGrupo"), dr("NombreGrupo"))
            End While

            dr.Close()
            Dgv.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message().ToString())
        End Try

    End Sub
    Public Shared Sub consulta_grupos(ByVal lv As ListView)
        Dim par As Integer
        par = 0
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaGrupo"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            Dim c As Integer = dr("codigoGrupo")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("nombreGrupo"))
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_grupo(ByRef tbC As String, ByRef tbN As String, ByVal COD As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaGrupo"
        command.Parameters.AddWithValue("@cod", COD)
        command.Parameters.AddWithValue("@Tipo", 0)
        command.Parameters.AddWithValue("@Valor", "")
        dr = command.ExecuteReader()
        dr.Read()
        tbC = dr("codigoGrupo")
        tbN = dr("nombreGrupo")
        dr.Close()
    End Sub

    Public Shared Sub inserta_grupo(ByVal nom As String)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaGrupo"
        command.Parameters.AddWithValue("@nom", nom)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub identidad_Grupo(ByRef tb As TextBox)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadGrupo"
        dr = command.ExecuteReader
        dr.Read()
        tb.Text = dr("Expr1") + 1
        dr.Close()
    End Sub
    Public Shared Sub modifica_grupo(ByVal nom As String, ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaGrupo"
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub elimina_grupo(ByVal cod As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_eliminagrupo"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub consulta_productos(ByRef t As DataTable)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto"
        command.Parameters.AddWithValue("@cod", SqlDbType.Int).Value = 0
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            dRow("Asociado") = False
            dRow("Descripcion") = dr("Nombre")
            dRow("Código") = dr("CodigoInterno")

            dRow("Precio") = dr("PrecioVenta")

            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub

    Public Shared Sub insertar_producto_grupo(ByVal codG As Integer, ByVal codI As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaProducto_Grupo"
        command.Parameters.AddWithValue("@codI", codI)
        command.Parameters.AddWithValue("@codG", codG)
        command.ExecuteNonQuery()
    End Sub


    Public Shared Sub consulta_productos_Grupo(ByRef Dgv As DataGridView, ByVal codG As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto_Grupo2"
        command.Parameters.AddWithValue("@codG", codG)
        dr = command.ExecuteReader()
        While dr.Read()

            Dgv.Rows.Add(True, dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("PrecioVenta"), dr("CantidadExistencia"))

        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_productos_noGrupo(ByRef Dgv As DataGridView, ByVal codG As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto_Grupo4"
        command.Parameters.AddWithValue("@codg", codG)
        dr = command.ExecuteReader()
        While dr.Read()
            Dgv.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("PrecioVenta"), dr("CantidadExistencia"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub elimina_producto_grupo(ByVal l As Collection, ByVal codG As Integer)
        For Each item In l
            Dim int As String = item
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Grupo"
            command.Parameters.AddWithValue("@codG", codG)
            command.Parameters.AddWithValue("@codI", int)
            command.ExecuteNonQuery()
        Next
    End Sub

    Public Shared Sub Eliminar_Productos_Grupo(ByVal codG As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_eliminaProducto_Grupo"
        command.Parameters.AddWithValue("@codG", codG)
        command.ExecuteNonQuery()

    End Sub

End Class
