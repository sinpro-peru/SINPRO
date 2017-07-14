Imports System.Data.SqlClient
Public Class DatosComprasProveedores
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub lv_compras1(ByRef lv As ListView, ByVal s As String, ByVal val As Integer)
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvCompra1"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            Dim c As Integer = dr("codigo")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(CStr(dr("Fecha")))
            If dr("nombre").GetType().ToString = "System.DBNull" Then
                i.SubItems.Add("")
            Else
                i.SubItems.Add(dr("nombre"))
            End If
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub
    'Public Shared Sub consulta_Compras(ByVal lv As ListView)
    '    lv.Items.Clear()
    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_consultaProveedorCompra"
    '    dr = command.ExecuteReader()
    '    While dr.Read
    '        Dim c As Integer = dr("codigo")
    '        Dim i As New ListViewItem(c)
    '        i.SubItems.Add(CStr(dr("Fecha")))

    '        If dr("nombre").GetType().ToString = "System.DBNull" Then
    '            i.SubItems.Add("")
    '        Else
    '            i.SubItems.Add(dr("nombre"))
    '        End If
    '        lv.Items.Add(i)
    '    End While
    '    dr.Close()
    'End Sub
    'Public Shared Sub consulta_status(ByRef cb As MTGCComboBox)
    '    cb.Items.Clear()
    '    command.Parameters.Clear()
    '    command.CommandType = CommandType.StoredProcedure
    '    command.CommandText = "sp_consultaStatus"
    '    dr = command.ExecuteReader()
    '    While dr.Read
    '        cb.Items.Add(New MTGCComboBoxItem(CStr(dr("Status"))))
    '    End While
    '    dr.Close()
    'End Sub
    Public Shared Sub consulta_proveedores(ByRef cb As MTGCComboBox)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedor"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoFabrica"))))
        End While
        dr.Close()
    End Sub
    Public Shared Sub inserta_Compra(ByVal codP As Integer, ByVal fle As Double, ByVal seg As Double, ByVal aran As Double, ByVal otroG As Double, ByVal fec As DateTime, ByVal mon As String, ByVal tipoC As Double, ByVal codFPF As Integer, ByVal fecFPF As DateTime)
        command.Parameters.Clear()
        Dim par As Integer = 0
        command.CommandText = "sp_insertaCompra"
        command.Parameters.AddWithValue("@tipo", par)
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@fle", fle)
        command.Parameters.AddWithValue("@seg", seg)
        command.Parameters.AddWithValue("@aran", aran)
        command.Parameters.AddWithValue("@otroG", otroG)
        command.Parameters.AddWithValue("@fec", fec)
        command.Parameters.AddWithValue("@mon", mon)
        command.Parameters.AddWithValue("@tipoC", tipoC)
        command.Parameters.AddWithValue("@codFPF", codFPF)
        command.Parameters.AddWithValue("@fecFPF", fecFPF)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_Compra(ByVal c As Integer, ByRef cod As String, ByRef sta As String, ByRef fle As String, ByRef seg As String, ByRef aran As String, ByRef otroG As String, ByRef fec As String, ByRef mon As String, ByRef tipoC As String, ByRef pro As MTGCComboBox, ByRef codFPF As String, ByRef fecFPF As String)
        Try

            Dim codP As Integer
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCompra"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()
            dr.Read()
            cod = CStr(dr("codigoCompra"))
            sta = dr("tipo")
            fle = CStr(dr("flete"))
            seg = CStr(dr("seguro"))
            aran = CStr(dr("aranceles"))
            otroG = CStr(dr("otrosGastos"))
            fec = dr("fecha")
            codP = dr("codigoProveedor")
            fecFPF = dr("fechaFacturaProForma")
            If dr("moneda").GetType.ToString = "System.DBNull" Then
                mon = ""
            Else
                mon = dr("moneda")
            End If
            If dr("tipoCambio").GetType.ToString = "System.DBNull" Then
                tipoC = ""
            Else
                tipoC = CStr(dr("tipoCambio"))
            End If
            If dr("codigoFacturaProForma").GetType.ToString = "System.DBNull" Then
                codFPF = ""
            Else
                codFPF = CStr(dr("codigoFacturaProForma"))
            End If
            dr.Close()
            consulta_proveedores(pro)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProveedor2"
            command.Parameters.AddWithValue("@cod", codP)
            dr = command.ExecuteReader()
            dr.Read()
            If dr("eliminado") Then
                Dim it As MTGCComboBoxItem = New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoProveedor")))
                pro.Items.Add(it)
                pro.SelectedItem = it
            End If
            pro.Text = dr("Nombre")
            dr.Close()

        Catch ex As Exception

            dr.Close()

        End Try

    End Sub
    Public Shared Sub modifica_Compra(ByVal sta As String, ByVal codP As Integer, ByVal fle As Double, ByVal seg As Double, ByVal aran As Double, ByVal otroG As Double, ByVal fec As DateTime, ByVal mon As String, ByVal tipoC As String, ByVal codFPF As String, ByVal fecFPF As DateTime, ByVal COD As Integer)
        Dim par As Integer = 0
        command.Parameters.Clear()
        command.CommandText = "sp_modificaCompra"
        command.Parameters.AddWithValue("@tipo", par)
        command.Parameters.AddWithValue("@codP", codP)
        command.Parameters.AddWithValue("@fle", fle)
        command.Parameters.AddWithValue("@seg", seg)
        command.Parameters.AddWithValue("@aran", aran)
        command.Parameters.AddWithValue("@otroG", otroG)
        command.Parameters.AddWithValue("@fec", fec)
        command.Parameters.AddWithValue("@fecFPF", fecFPF)
        command.Parameters.AddWithValue("@COD", COD)



        If mon = "" Then
            command.Parameters.AddWithValue("@mon", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@mon", mon)
        End If
        If tipoC = "" Then
            command.Parameters.AddWithValue("@tipoC", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tipoC", CDec(tipoC))
        End If
        If codFPF = "" Then
            command.Parameters.AddWithValue("@codFPF", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@codFPF", CInt(codFPF))
        End If

        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub elimina_Compra(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaCompra"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub identidad_Compra(ByRef tb As TextBox)
        'Dim id As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadCompra"
        dr = command.ExecuteReader
        dr.Read()
        tb.Text = dr("Expr1") + 1
        dr.Close()
    End Sub

    ''----------------------------------------------------------------------------------------

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
            dRow("Cantidad") = 0
            dRow("Nombre") = dr("Nombre")
            dRow("Código") = dr("CodigoInterno")
            dRow("Costo") = dr("CostoPromedio")
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub

    Public Shared Sub consulta_compra_producto_proveedor(ByVal cod As String, ByRef t As DataTable)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCompra_Produto_CompraMelissa"
        command.Parameters.AddWithValue("@codC", cod)
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            dRow("Asociado") = True
            dRow("Cantidad") = dr("Cantidad")
            dRow("Nombre") = dr("Nombre")
            dRow("Código") = dr("CodigoInterno")
            dRow("Costo") = dr("Costo")
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub


    Public Shared Sub insertar_producto_compra(ByVal codC As Integer, ByVal codPto As String, ByVal c As Integer, ByVal p As Double)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_insertaCompra_Producto"
        command.Parameters.AddWithValue("@codC", codC)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.Parameters.AddWithValue("@cos", p)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub consulta_productos2(ByRef t As DataTable, ByVal codC As Integer)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_Producto_Minus_Compra"
        command.Parameters.AddWithValue("@codC", codC)
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            dRow("Asociado") = False
            dRow("Cantidad") = 0
            dRow("Nombre") = dr("Nombre")
            dRow("Código") = dr("CodigoInterno")
            dRow("Costo") = dr("CostoPromedio")
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub
    Public Shared Sub actualizar_producto_compra(ByVal codC As Integer, ByVal codPto As String, ByVal c As Integer)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaCompra_Producto"
        command.Parameters.AddWithValue("@codC", codC)
        command.Parameters.AddWithValue("@codPto", codPto)
        command.Parameters.AddWithValue("@cant", c)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub elimina_producto_compra(ByVal l As Collection, ByVal codC As Integer)
        For Each item In l
            Dim int As String = item
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaCompra_Producto"
            command.Parameters.AddWithValue("@codC", codC)
            command.Parameters.AddWithValue("@codP", int)
            command.ExecuteNonQuery()
        Next
    End Sub
End Class
