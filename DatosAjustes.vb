Imports System.Data.SqlClient
Public Class DatosAjustes

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub DVG_Ajustes(ByVal DGV As DataGridView)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvAjustes"
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoAjuste"), dr("Fecha"), dr("Usuario"), dr("Descripcion"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario(ByRef DGV As MyDataGridView2, ByVal Cod As String, ByVal Tipo As Integer)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)

            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader
            Dim anterior As String = ""
            Dim anterior2 As String = ""

            While dr.Read

                If anterior = dr("CodigoInterno") And anterior2 = dr("Ubicacion") Then

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim celdaCant As New DataGridViewTextBoxCell
                    Dim CeldaObs As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim CeldaExist As New DataGridViewTextBoxCell
                    Dim CeldaUbic As New DataGridViewTextBoxCell
                    Dim CeldaTramo As New DataGridViewTextBoxCell
                    Dim CeldaPrecio As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    celdaCant.Value = ""
                    fila.Cells.Add(celdaCant)
                    celdaCant.ReadOnly = False
                    CeldaObs.Value = ""
                    fila.Cells.Add(CeldaObs)
                    CeldaObs.MaxInputLength = 200
                    CeldaObs.ReadOnly = False
                    CeldaCod.Value = dr("CodigoInterno")
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = dr("Nombre")
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True
                    If dr("Cantidad").GetType.ToString = "System.DBNull" Then
                        CeldaExist.Value = "0"
                    Else
                        CeldaExist.Value = dr("Cantidad")
                    End If
                    fila.Cells.Add(CeldaExist)
                    CeldaExist.ReadOnly = True
                    CeldaModelo.Items.Add(DGV.Rows(DGV.Rows.Count - 1).Cells(5).Value)
                    CeldaModelo.Items.Add(dr("Modelo"))
                    CeldaModelo.Value = DGV.Rows(DGV.Rows.Count - 1).Cells(5).Value
                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False
                    If dr("Ubicacion").GetType.ToString = "System.DBNull" Then
                        CeldaUbic.Value = ""
                    Else
                        CeldaUbic.Value = dr("Ubicacion")
                    End If
                    fila.Cells.Add(CeldaUbic)
                    CeldaUbic.ReadOnly = True
                    CeldaTramo.Value = dr("CodigoTramo")
                    fila.Cells.Add(CeldaTramo)
                    CeldaPrecio.Value = dr("PrecioVenta")
                    fila.Cells.Add(CeldaPrecio)

                    DGV.Rows.RemoveAt(DGV.Rows.Count - 1)
                    DGV.Rows.Add(fila)

                Else

                    Dim tb As New DataGridViewTextBoxColumn
                    tb = DGV.Columns(1)
                    tb.MaxInputLength = 200
                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))
                    DGV.Rows(DGV.RowCount - 1).Cells(0).ReadOnly = False
                    DGV.Rows(DGV.RowCount - 1).Cells(1).ReadOnly = False
                    DGV.Rows(DGV.RowCount - 1).Cells(2).ReadOnly = True
                    DGV.Rows(DGV.RowCount - 1).Cells(3).ReadOnly = True
                    DGV.Rows(DGV.RowCount - 1).Cells(4).ReadOnly = True
                    DGV.Rows(DGV.RowCount - 1).Cells(5).ReadOnly = True
                    DGV.Rows(DGV.RowCount - 1).Cells(6).ReadOnly = True

                End If

                anterior = dr("CodigoInterno")
                anterior2 = dr("Ubicacion")

            End While


            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Inserta_Ajuste(ByVal fecha As Date, ByVal usuario As String, ByVal descripcion As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaAjuste"

            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Descripcion", descripcion)

            command.ExecuteNonQuery()

            MsgBox("Ajuste agregado satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Error insertando el ajuste", MsgBoxStyle.Critical, "ERROR")

        End Try

    End Sub

    Public Shared Sub Consulta_Ajuste(ByVal CodA As Integer, ByRef User As String, ByRef Desc As String, ByRef fecha As Date, ByVal Dgv As DataGridView)

        Try
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaAjuste"
            command.Parameters.AddWithValue("@CodA", CodA)

            dr = command.ExecuteReader

            While dr.Read

                User = dr("Usuario")
                Desc = dr("Descripcion")
                fecha = dr("Fecha")

            End While

            dr.Close()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosEnAjuste"
            command.Parameters.AddWithValue("@CodA", CodA)

            dr = command.ExecuteReader

            Dim anterior As String = ""
            Dim anterior2 As String = ""
            Dim CONT As Integer = 0

            While dr.Read

                Dgv.Rows.Add(dr("Cantidad"), dr("Observacion"), dr("Codigo"), dr("Nombre"), dr("CantE"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), True, dr("SubTotal"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Error cargando datos del ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminaProductosAjuste(ByVal CodA As Integer)

        Try

            command.CommandText = "sp_eliminaAjuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando productos del ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminaProductosAjuste2(ByVal CodA As Integer, ByVal CodP As String, ByVal codT As Integer, ByVal cant As Integer)

        Try

            command.CommandText = "sp_eliminaAjuste_Producto2"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@CodT", codT)
            command.Parameters.AddWithValue("@Cant", cant)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando productos del ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub InsertaProductoAjuste(ByVal CodA As Integer, ByVal CodP As String, ByVal Cantidad As Integer, ByVal obs As String, ByVal Tramo As Integer)

        Try

            command.CommandText = "sp_insertaAjuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Tramo", Tramo)
            command.ExecuteNonQuery()

            command.CommandText = "sp_ModificaCantidadAjuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.ExecuteNonQuery()


            command.CommandText = "sp_ModificaCantidadTramo_Ajuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.Parameters.AddWithValue("@Tramo", Tramo)
            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("Error insertando productos en el ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub InsertaProductoAjuste_Almacen(ByVal CodA As Integer, ByVal CodP As String, ByVal Cantidad As Integer, ByVal obs As String, ByVal Tramo As Integer)

        Try

            command.CommandText = "sp_insertaAjuste_Producto"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Tramo", Tramo)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error insertando productos en el ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminaAjuste(ByVal CodA As Integer)

        Try

            command.CommandText = "sp_eliminaAjuste"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.ExecuteNonQuery()

            MsgBox("Ajuste eliminado satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Error eliminando el ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub ModificaAjuste(ByVal CodA As Integer, ByVal Fecha As Date, ByVal obs As String)

        Try

            command.CommandText = "sp_ModificaAjuste"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@Obs", obs)
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.ExecuteNonQuery()

            MsgBox("Ajsute modificado Satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Error modificando el ajuste", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub ProximoAjuste(ByRef Cod As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ProximoAjuste"
            command.Parameters.Clear()
            dr = command.ExecuteReader

            While dr.Read

                Cod = dr("Prox")

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Public Shared Sub DVG_Ajustes_Like(ByRef DGV As DataGridView, ByVal Cod As String, ByVal Tipo As Integer)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvAjustesLike"
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("CodigoAjuste"), dr("Fecha"), dr("Usuario"), dr("Descripcion"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario2(ByRef DGV As DataTable, ByVal Cod As String, ByVal Tipo As Integer, ByRef DGV2 As MyDataGridView2)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)

            command.CommandText = "sp_ProductosAjuste"
            dr = command.ExecuteReader

            Dim CONT As Integer = 0

            Dim anterior As String = ""
            Dim anterior2 As String = ""
            Dim colec As New Collection
            Dim cont4 As Integer = 0
            Dim sw As Boolean = False
            While dr.Read

                If dr("Cantidad").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("almacenId"), dr("cuartoId"))
                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                Else

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("almacenId"), dr("cuartoId"))
                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                End If

            End While

            DGV2.Rows(CONT).Cells(5).ReadOnly = True

            While CONT < DGV2.RowCount

                If anterior = DGV2.Rows(CONT).Cells(2).Value And anterior2 = DGV2.Rows(CONT).Cells(6).Value Then

                    cont4 = cont4 + 1
                    If cont4 > 1 Then
                        sw = True
                    End If

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim celdaCant As New DataGridViewTextBoxCell
                    Dim CeldaObs As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim CeldaExist As New DataGridViewTextBoxCell
                    Dim CeldaUbic As New DataGridViewTextBoxCell
                    Dim CeldaTramo As New DataGridViewTextBoxCell
                    Dim CeldaPrecio As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    colec.Add(DGV2.Rows(CONT - 1).Cells(5).Value.ToString)
                    celdaCant.Value = ""
                    fila.Cells.Add(celdaCant)
                    celdaCant.ReadOnly = False
                    CeldaObs.Value = ""
                    fila.Cells.Add(CeldaObs)
                    CeldaObs.MaxInputLength = 200
                    CeldaObs.ReadOnly = False
                    CeldaCod.Value = DGV2.Rows(CONT).Cells(2).Value
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = DGV2.Rows(CONT).Cells(3).Value
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True
                    CeldaExist.Value = DGV2.Rows(CONT).Cells(4).Value
                    fila.Cells.Add(CeldaExist)
                    CeldaExist.ReadOnly = True
                    If sw Then

                        Dim cont3 As Integer = 0

                        For cont3 = 1 To colec.Count

                            CeldaModelo.Items.Add(colec.Item(cont3).ToString)

                        Next

                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    Else

                        CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(5).Value)
                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    End If

                    CeldaModelo.Value = DGV2.Rows(CONT).Cells(5).Value

                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False
                    CeldaUbic.Value = DGV2.Rows(CONT).Cells(6).Value

                    fila.Cells.Add(CeldaUbic)
                    CeldaUbic.ReadOnly = True
                    CeldaTramo.Value = DGV2.Rows(CONT).Cells(7).Value
                    fila.Cells.Add(CeldaTramo)
                    CeldaPrecio.Value = DGV2.Rows(CONT).Cells(8).Value
                    fila.Cells.Add(CeldaPrecio)

                    DGV2.Rows.Add(fila)
                    DGV2.Rows.RemoveAt(CONT)
                    DGV2.Rows.RemoveAt(CONT - 1)
                    DGV2.Sort(DGV2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
                    CONT = CONT - 1

                Else

                    cont4 = 0
                    sw = False
                    colec.Clear()

                End If

                anterior = DGV2.Rows(CONT).Cells(2).Value
                anterior2 = DGV2.Rows(CONT).Cells(6).Value

                CONT = CONT + 1

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario3(ByRef DGV As DataTable, ByVal Cod As String, ByVal Tipo As Integer, ByRef DGV2 As MyDataGridView2)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", 4)

            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader

            Dim CONT As Integer = 0

            Dim anterior As String = ""
            Dim anterior2 As String = ""

            Dim colec As New Collection

            Dim cont4 As Integer = 0
            Dim sw As Boolean = False

            While dr.Read

                If dr("Cantidad").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("CodigoProductoF"), dr("almacenId"), dr("cuartoId"))

                Else

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("CodigoProductoF"), dr("almacenId"), dr("cuartoId"))

                End If

            End While

            dr.Close()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", 0)

            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString = "System.DBNull" Then

                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                Else

                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                End If

            End While

            DGV2.Rows(CONT).Cells(5).ReadOnly = True

            While CONT < DGV2.RowCount

                If anterior = DGV2.Rows(CONT).Cells(2).Value And anterior2 = DGV2.Rows(CONT).Cells(6).Value Then

                    cont4 = cont4 + 1
                    If cont4 > 1 Then
                        sw = True
                    End If

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim celdaCant As New DataGridViewTextBoxCell
                    Dim CeldaObs As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim CeldaExist As New DataGridViewTextBoxCell
                    Dim CeldaUbic As New DataGridViewTextBoxCell
                    Dim CeldaTramo As New DataGridViewTextBoxCell
                    Dim CeldaPrecio As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    colec.Add(DGV2.Rows(CONT - 1).Cells(5).Value.ToString)
                    celdaCant.Value = ""
                    fila.Cells.Add(celdaCant)
                    celdaCant.ReadOnly = False
                    CeldaObs.Value = ""
                    fila.Cells.Add(CeldaObs)
                    CeldaObs.MaxInputLength = 200
                    CeldaObs.ReadOnly = False
                    CeldaCod.Value = DGV2.Rows(CONT).Cells(2).Value
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = DGV2.Rows(CONT).Cells(3).Value
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True
                    CeldaExist.Value = DGV2.Rows(CONT).Cells(4).Value
                    fila.Cells.Add(CeldaExist)
                    CeldaExist.ReadOnly = True
                    If sw Then

                        Dim cont3 As Integer = 0

                        For cont3 = 1 To colec.Count

                            CeldaModelo.Items.Add(colec.Item(cont3).ToString)

                        Next

                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    Else

                        CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(5).Value)
                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    End If

                    CeldaModelo.Value = DGV2.Rows(CONT).Cells(5).Value

                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False
                    CeldaUbic.Value = DGV2.Rows(CONT).Cells(6).Value

                    fila.Cells.Add(CeldaUbic)
                    CeldaUbic.ReadOnly = True
                    CeldaTramo.Value = DGV2.Rows(CONT).Cells(7).Value
                    fila.Cells.Add(CeldaTramo)
                    CeldaPrecio.Value = DGV2.Rows(CONT).Cells(8).Value
                    fila.Cells.Add(CeldaPrecio)

                    DGV2.Rows.Add(fila)
                    DGV2.Rows.RemoveAt(CONT)
                    DGV2.Rows.RemoveAt(CONT - 1)
                    DGV2.Sort(DGV2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
                    CONT = CONT - 1

                Else

                    cont4 = 0
                    sw = False
                    colec.Clear()

                End If

                anterior = DGV2.Rows(CONT).Cells(2).Value
                anterior2 = DGV2.Rows(CONT).Cells(6).Value

                CONT = CONT + 1

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario4(ByVal Cod As String, ByVal Tipo As Integer, ByRef DGV2 As MyDataGridView2)

        Try

            DGV2.Rows.Clear()
            Dim CONT As Integer = 0

            Dim anterior As String = ""
            Dim anterior2 As String = ""

            Dim colec As New Collection

            Dim cont4 As Integer = 0
            Dim sw As Boolean = False


            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", 0)

            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString = "System.DBNull" Then

                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                Else

                    DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

                End If

            End While

            DGV2.Rows(CONT).Cells(5).ReadOnly = True

            While CONT < DGV2.RowCount

                If anterior = DGV2.Rows(CONT).Cells(2).Value And anterior2 = DGV2.Rows(CONT).Cells(6).Value Then

                    cont4 = cont4 + 1
                    If cont4 > 1 Then
                        sw = True
                    End If

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim celdaCant As New DataGridViewTextBoxCell
                    Dim CeldaObs As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim CeldaExist As New DataGridViewTextBoxCell
                    Dim CeldaUbic As New DataGridViewTextBoxCell
                    Dim CeldaTramo As New DataGridViewTextBoxCell
                    Dim CeldaPrecio As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    colec.Add(DGV2.Rows(CONT - 1).Cells(5).Value.ToString)
                    celdaCant.Value = ""
                    fila.Cells.Add(celdaCant)
                    celdaCant.ReadOnly = False
                    CeldaObs.Value = ""
                    fila.Cells.Add(CeldaObs)
                    CeldaObs.MaxInputLength = 200
                    CeldaObs.ReadOnly = False
                    CeldaCod.Value = DGV2.Rows(CONT).Cells(2).Value
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = DGV2.Rows(CONT).Cells(3).Value
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True
                    CeldaExist.Value = DGV2.Rows(CONT).Cells(4).Value
                    fila.Cells.Add(CeldaExist)
                    CeldaExist.ReadOnly = True
                    If sw Then

                        Dim cont3 As Integer = 0


                        For cont3 = 1 To colec.Count

                            CeldaModelo.Items.Add(colec.Item(cont3).ToString)

                        Next

                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    Else

                        CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(5).Value)
                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    End If

                    CeldaModelo.Value = DGV2.Rows(CONT).Cells(5).Value

                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False
                    CeldaUbic.Value = DGV2.Rows(CONT).Cells(6).Value

                    fila.Cells.Add(CeldaUbic)
                    CeldaUbic.ReadOnly = True
                    CeldaTramo.Value = DGV2.Rows(CONT).Cells(7).Value
                    fila.Cells.Add(CeldaTramo)
                    CeldaPrecio.Value = DGV2.Rows(CONT).Cells(8).Value
                    fila.Cells.Add(CeldaPrecio)

                    DGV2.Rows.Add(fila)
                    DGV2.Rows.RemoveAt(CONT)
                    DGV2.Rows.RemoveAt(CONT - 1)
                    DGV2.Sort(DGV2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
                    CONT = CONT - 1

                Else

                    cont4 = 0
                    sw = False
                    colec.Clear()

                End If

                anterior = DGV2.Rows(CONT).Cells(2).Value
                anterior2 = DGV2.Rows(CONT).Cells(6).Value

                CONT = CONT + 1

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario5(ByRef DGV As DataTable, ByVal Cod As String)

        Try

            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", 4)
            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader

            While dr.Read

                If dr("Cantidad").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("CodigoProductoF"))

                Else

                    DGV.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), dr("Cantidad"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("CodigoProductoF"))

                End If

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Productos_Inventario8(ByVal Cod As String, ByVal Tipo As Integer, ByRef DGV2 As MyDataGridView2)

        Try

            DGV2.Rows.Clear()

            Dim CONT As Integer = 0
            Dim anterior As String = ""
            Dim anterior2 As String = ""
            Dim colec As New Collection
            Dim cont4 As Integer = 0
            Dim sw As Boolean = False

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.CommandText = "sp_consultaProductosAjuste"
            dr = command.ExecuteReader

            While dr.Read

                DGV2.Rows.Add("", "", dr("CodigoInterno"), dr("Nombre"), 0, dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"), dr("CodigoProductoF"))

                DGV2.Rows(CONT).Cells(5).ReadOnly = True

                If anterior = DGV2.Rows(CONT).Cells(2).Value And anterior2 = DGV2.Rows(CONT).Cells(6).Value Then

                    cont4 = cont4 + 1
                    If cont4 > 1 Then
                        sw = True
                    End If

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim celdaCant As New DataGridViewTextBoxCell
                    Dim CeldaObs As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim CeldaExist As New DataGridViewTextBoxCell
                    Dim CeldaUbic As New DataGridViewTextBoxCell
                    Dim CeldaTramo As New DataGridViewTextBoxCell
                    Dim CeldaPrecio As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    colec.Add(DGV2.Rows(CONT - 1).Cells(5).Value.ToString)
                    celdaCant.Value = ""
                    fila.Cells.Add(celdaCant)
                    celdaCant.ReadOnly = False
                    CeldaObs.Value = ""
                    fila.Cells.Add(CeldaObs)
                    CeldaObs.MaxInputLength = 200
                    CeldaObs.ReadOnly = False
                    CeldaCod.Value = DGV2.Rows(CONT).Cells(2).Value
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = DGV2.Rows(CONT).Cells(3).Value
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True
                    CeldaExist.Value = DGV2.Rows(CONT).Cells(4).Value
                    fila.Cells.Add(CeldaExist)
                    CeldaExist.ReadOnly = True
                    If sw Then

                        Dim cont3 As Integer = 0

                        For cont3 = 1 To colec.Count

                            CeldaModelo.Items.Add(colec.Item(cont3).ToString)

                        Next

                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    Else

                        CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(5).Value)
                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(5).Value)

                    End If

                    CeldaModelo.Value = DGV2.Rows(CONT).Cells(5).Value

                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False
                    CeldaUbic.Value = DGV2.Rows(CONT).Cells(6).Value

                    fila.Cells.Add(CeldaUbic)
                    CeldaUbic.ReadOnly = True
                    CeldaTramo.Value = DGV2.Rows(CONT).Cells(7).Value
                    fila.Cells.Add(CeldaTramo)
                    CeldaPrecio.Value = DGV2.Rows(CONT).Cells(8).Value
                    fila.Cells.Add(CeldaPrecio)

                    DGV2.Rows.Add(fila)
                    DGV2.Rows.RemoveAt(CONT)
                    DGV2.Rows.RemoveAt(CONT - 1)
                    DGV2.Sort(DGV2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
                    CONT = CONT - 1

                Else

                    cont4 = 0
                    sw = False
                    colec.Clear()

                End If

                anterior = DGV2.Rows(CONT).Cells(2).Value
                anterior2 = DGV2.Rows(CONT).Cells(6).Value
                CONT = CONT + 1

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DVG_ProductosAjuste(ByRef DGV As DataGridView, ByVal CodA As Integer, ByVal CodPro As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductoEnAjusteLike"
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodPro", CodPro)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Cantidad"), dr("Observacion"), dr("CodigoProducto"), dr("Nombre"), dr("CantidadExistencia"), dr("Modelo"), dr("Ubicacion"), dr("CodigoTramo"), dr("PrecioVenta"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de ajustes")


        End Try

    End Sub

End Class
