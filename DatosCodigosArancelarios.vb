Imports System.Data.SqlClient
Public Class DatosCodigosArancelarios
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Shared item As Object
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub lv_Arancelario(ByRef Dgv As DataGridView, ByVal s As String, ByVal val As Integer)
        Dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvArancelario"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            Dgv.Rows.Add(dr("codigoArancelario"), dr("Impuesto"), dr("descripcion"))
        End While
        dr.Close()
    End Sub
    ''
    Public Shared Sub consulta_codigosArancelarios(ByRef Dgv As DataGridView)
        Try
            Dim par As Integer
            par = 0
            Dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCodigoArancelario"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()

            While dr.Read
                Dgv.Rows.Add(dr("codigoArancelario"), dr("impuesto"), dr("Descripcion"))
            End While

            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub
    Public Shared Sub consulta_codigoArancelario(ByVal c As String, ByRef tbC As String, ByRef tbI As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCodigoArancelario"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()
            dr.Read()
            tbC = dr("codigoArancelario")
            tbI = CStr(dr(("impuesto")))
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            dr.Close()
        End Try

    End Sub

    Public Shared Sub chequea_CA(ByVal c As String, ByRef sw As Boolean)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCodigoArancelario"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        If dr.Read() Then
            sw = True
        End If
        dr.Close()
    End Sub
    Public Shared Sub inserta_codigoArancelario(ByVal imp As Double, ByVal cod As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaCodigoArancelario"
            command.Parameters.AddWithValue("@imp", imp)
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando el Código Arancelario", MsgBoxStyle.Critical)
            MsgBox(ex.Message().ToString)
        End Try

    End Sub

    Public Shared Sub modifica_codigoArancelario(ByVal imp As Double, ByVal COD As String, ByVal Cod2 As String)
        command.Parameters.Clear()
        command.CommandText = "sp_modificaCodigoArancelario"
        command.Parameters.AddWithValue("@imp", imp)
        command.Parameters.AddWithValue("@COD", COD)
        command.Parameters.AddWithValue("@Cod2", Cod2)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub elimina_codigoArancelario(ByVal cod As String)
        command.Parameters.Clear()
        command.CommandText = "sp_eliminaCodigoArancelario"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub consulta_productos_Arancelario(ByRef t As DataTable, ByVal codA As String)
        Try
            Dim dRow As DataRow
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto_Arancelario"
            command.Parameters.AddWithValue("@codC", codA)
            dr = command.ExecuteReader()
            While dr.Read()
                dRow = t.NewRow()
                dRow("Asociado") = True
                dRow("Nombre") = dr("Nombre")
                dRow("Código") = dr("CodigoInterno")
                t.Rows.Add(dRow)
            End While
            t.AcceptChanges()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub
    Public Shared Sub consulta_productos_noArancelario(ByRef t As DataTable)
        Dim dRow As DataRow
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto_noArancelario"
        dr = command.ExecuteReader()
        While dr.Read()
            dRow = t.NewRow()
            dRow("Asociado") = False
            dRow("Descripcion") = dr("Nombre")
            dRow("Codigo") = dr("CodigoInterno")
            t.Rows.Add(dRow)
        End While
        t.AcceptChanges()
        dr.Close()
    End Sub
    Public Shared Sub insertar_producto_Arancelario(ByVal codA As String, ByVal codI As String)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaProducto_Arancelario"
        command.Parameters.AddWithValue("@codI", codI)
        command.Parameters.AddWithValue("@codA", codA)
        command.Parameters.AddWithValue("@Tipo", 0)
        command.ExecuteNonQuery()
    End Sub
    Public Shared Sub elimina_producto_Arancelario(ByVal codigo As String)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaProducto_Arancelario"
        command.Parameters.AddWithValue("@codI", "")
        command.Parameters.AddWithValue("@codA", codigo)
        command.Parameters.AddWithValue("@Tipo", 2)
        command.ExecuteNonQuery()

    End Sub

    Public Shared Sub Llenar_DGV_Arancelarios(ByVal cod As String, ByVal tipo As Integer, ByVal dgv As DataGridView, ByRef tabla As DataTable)

        Try
            dgv.Rows.Clear()
            tabla.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            If tipo = 1 Then
                command.CommandText = "sp_consultaProducto_Arancelario"
                command.Parameters.AddWithValue("@codc", cod)
                dr = command.ExecuteReader

                While dr.Read
                    dgv.Rows.Add(True, dr("CodigoInterno"), dr("Nombre"))
                    tabla.Rows.Add(True, dr("Nombre"), dr("CodigoInterno"))
                End While

            ElseIf tipo = 2 Then

                command.CommandText = "sp_consultaProducto_Arancelario"
                command.Parameters.AddWithValue("@codc", cod)
                dr = command.ExecuteReader

                While dr.Read
                    dgv.Rows.Add(True, dr("CodigoInterno"), dr("Nombre"))
                    tabla.Rows.Add(True, dr("Nombre"), dr("CodigoInterno"))
                End While

                dr.Close()

                command.CommandText = "sp_consultaProducto_noArancelario"
                command.Parameters.Clear()
                dr = command.ExecuteReader

                While dr.Read

                    If dr("CodigoArancelario").GetType.ToString = "System.DBNull" Then

                        dgv.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"))
                        tabla.Rows.Add(False, dr("Nombre"), dr("CodigoInterno"))

                    Else

                        If dr("CodigoArancelario") = "0" Then

                            dgv.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"))
                            tabla.Rows.Add(False, dr("Nombre"), dr("CodigoInterno"))
                        End If

                        If dr("CodigoArancelario") = cod Then

                            dgv.Rows.Add(True, dr("CodigoInterno"), dr("Nombre"))
                            tabla.Rows.Add(True, dr("Nombre"), dr("CodigoInterno"))

                        End If

                    End If

                End While
            ElseIf tipo = 3 Then

                command.CommandText = "sp_consultaProducto_noArancelario"
                dr = command.ExecuteReader

                While dr.Read
                    dgv.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"))
                    tabla.Rows.Add(False, dr("Nombre"), dr("CodigoInterno"))
                End While

                dr.Close()

            End If

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando las listas", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try


    End Sub


    Public Shared Sub Llenar_DGV_Like(ByVal CodI As String, ByVal Tipo As Integer, ByVal CodA As String, ByVal DGV As DataGridView)


        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_ConsultaCodArancelarioLike"
            command.Parameters.AddWithValue("@CodI", CodI)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@CodA", CodA)
            dr = command.ExecuteReader

            While dr.Read

                If dr("CodigoArancelario").GetType.ToString = "System.DBNull" Then

                    DGV.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"))

                Else

                    If dr("CodigoArancelario") = "0" Then

                        DGV.Rows.Add(False, dr("CodigoInterno"), dr("Nombre"))

                    End If

                    If dr("CodigoArancelario") = CodA Then

                        DGV.Rows.Add(True, dr("CodigoInterno"), dr("Nombre"))

                    End If

                End If

            End While

            dr.Close()

        Catch ex As Exception
            dr.Close()
            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub EliminaPreferencias(ByVal CodA As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaPreferencia_CodigoArancelario"
            command.Parameters.AddWithValue("@CodA", CodA)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando las preferencias arancelarias", MsgBoxStyle.Critical)


        End Try
    End Sub

    Public Shared Sub InsertaPreferencias(ByVal CodA As String, ByVal CodP As String, ByVal Valor As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaPreferencia_CodigoArancelario"
            command.Parameters.AddWithValue("@CodA", CodA)
            command.Parameters.AddWithValue("@CodP", CodP)
            command.Parameters.AddWithValue("@Valor", Valor)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando las preferencias arancelarias", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Preferencias(ByVal cod As String, ByRef dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaPrefArancelaria"
            command.Parameters.AddWithValue("@codA", cod)
            dr = command.ExecuteReader

            While dr.Read
                dgv.Rows.Add(dr("Nombre"), dr("Valor"), dr("CodigoPreferencia"))
            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de preferencias", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            dr.Close()

        End Try

    End Sub

End Class
