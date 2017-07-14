Imports System.Data.SqlClient
Public Class DatosCompetencia

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader


    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub Inserta_Empresa(ByVal rif As String, ByVal razon As String, ByVal telefono As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_inserta_empresa"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@RazonSocial", razon)
            command.Parameters.AddWithValue("@Telefono", telefono)
            command.ExecuteNonQuery()

            MsgBox("Empresa agregada satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception


        End Try

    End Sub


    Public Shared Sub consulta_empresas(ByRef DGV As DataGridView)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_empresas"
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("rif"), dr("RazonSocial"), dr("Telefono"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de empresas")


        End Try

    End Sub


    Public Shared Sub elimina_empresa(ByVal rif As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_elimina_empresa"
            command.Parameters.AddWithValue("@rif", rif)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Problema cargando eliminando empresas")
        End Try

    End Sub

    Public Shared Sub Inserta_productos_competencia(ByVal rif As String, ByVal codim As String, ByVal codFab As String, ByVal codOEM As String, ByVal Descripcion As String, ByVal Marca As String, ByVal Modelo As String, ByVal Año As String, ByVal Stock As String, ByVal precio As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_inserta_producto_competencia"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@codImportador", codim)
            command.Parameters.AddWithValue("@codFabrica", codFab)
            command.Parameters.AddWithValue("@codOEM", codOEM)
            command.Parameters.AddWithValue("@Descripción", Descripcion)
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Año", Año)
            command.Parameters.AddWithValue("@stock", Stock)
            command.Parameters.AddWithValue("@Precio", precio)
            command.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_productos_empresas(ByRef DGV As DataGridView, ByVal rif As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_productos_competencia"
            command.Parameters.AddWithValue("@rif", rif)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("codImportador"), dr("codFabrica"), dr("CodOEM"), dr("Descripción"), dr("Marca"), dr("Modelo"), dr("Año"), dr("Stock"), dr("Precio"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de productos de la competencia")


        End Try

    End Sub

    Public Shared Sub consulta_empresas_like(ByRef DGV As DataGridView, ByVal rif As String, ByVal nombre As String, ByVal tipo As Integer)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_empresa_like"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.Parameters.AddWithValue("@codInt", "0")
            command.Parameters.AddWithValue("@codImportador", "")
            command.Parameters.AddWithValue("@codFabrica", "")
            command.Parameters.AddWithValue("@codOEM", "")
            command.Parameters.AddWithValue("@Descripción", "")
            command.Parameters.AddWithValue("@Marca", "")
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("rif"), dr("RazonSocial"), dr("Telefono"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de empresas en el like")


        End Try

    End Sub



    Public Shared Sub consulta_productos_like(ByRef DGV As DataGridView, ByVal imp As String, ByVal fab As String, ByVal OEM As String, ByVal descripcion As String, ByVal marca As String, ByVal rif As String, ByVal tipo As Integer)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_empresa_like"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@nombre", "")
            command.Parameters.AddWithValue("@tipo", tipo)
            command.Parameters.AddWithValue("@codImportador", imp)
            command.Parameters.AddWithValue("@codFabrica", fab)
            command.Parameters.AddWithValue("@codInt", "0")
            command.Parameters.AddWithValue("@codOEM", OEM)
            command.Parameters.AddWithValue("@Descripción", descripcion)
            command.Parameters.AddWithValue("@Marca", marca)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("codImportador"), dr("codFabrica"), dr("CodOEM"), dr("Descripción"), dr("Marca"), dr("Modelo"), dr("Año"), dr("Stock"), dr("Precio"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de empresas en el like")


        End Try

    End Sub



    Public Shared Sub modificar_Empresa(ByVal rif As String, ByVal razon As String, ByVal telefono As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_competencia"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@RazonSocial", razon)
            command.Parameters.AddWithValue("@Telefono", telefono)
            command.ExecuteNonQuery()

            MsgBox("Empresa modificada satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception


        End Try

    End Sub



    Public Shared Sub eliminar_producto_competencia(ByVal rif As String, ByVal codim As String, ByVal codFab As String, ByVal codOEM As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminar_producto_competencia"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@codImportador", codim)
            command.Parameters.AddWithValue("@codFabrica", codFab)
            command.Parameters.AddWithValue("@codOEM", codOEM)
            command.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub




    '-------------------------------ASOCIACION DE PRODCTOS----------------------------------'


    Public Shared Sub consulta_productos_no_asociados(ByRef DGV As DataGridView, ByVal rif As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_productos_no_asociados"
            command.Parameters.AddWithValue("@rif", rif)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("codImportador"), dr("codFabrica"), dr("CodOEM"), dr("Descripción"), dr("Marca"), dr("Modelo"), dr("Año"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de productos no asociados")


        End Try

    End Sub

    Public Shared Sub consulta_productos_asociacion_automatica(ByRef DGV As DataGridView, ByVal rif As String)

        Try

            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_productos_asociacion_automatica"
            command.Parameters.AddWithValue("@rif", rif)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("codImportador"), dr("codFabrica"), dr("CodOEM"), dr("Descripción"), dr("Marca"), dr("Modelo"), dr("Año"), dr("CodigoInterno"), dr("Nombre"))

            End While

            dr.Close()

        Catch ex As Exception

            dr.Close()
            MsgBox("Problema cargando lista de productos no asociados")


        End Try

    End Sub

    Public Shared Sub Inserta_producto_Competencia_Producto(ByVal CodI As String, ByVal rif As String, ByVal codImp As String, ByVal CodOEM As String, ByVal codF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_inserta_Producto_Competencia_Producto"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@codI", CodI)
            command.Parameters.AddWithValue("@codImp", codImp)
            command.Parameters.AddWithValue("@codOEM", CodOEM)
            command.Parameters.AddWithValue("@codF", codF)
            command.ExecuteNonQuery()

        Catch ex As Exception

            dr.Close()
            MsgBox("Error asociando productos", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub Modifica_producto_Competencia_Producto(ByVal CodI As String, ByVal rif As String, ByVal codImp As String, ByVal CodOEM As String, ByVal codF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_Producto_Competencia_Producto"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@codI", CodI)
            command.Parameters.AddWithValue("@codImp", codImp)
            command.Parameters.AddWithValue("@codOEM", CodOEM)
            command.Parameters.AddWithValue("@codF", codF)
            command.ExecuteNonQuery()

        Catch ex As Exception

            dr.Close()
            MsgBox("Error actualizando asociasion de productos", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub elimina_producto_Competencia_Producto(ByVal rif As String, ByVal codF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_elimina_Producto_Competencia_Producto"
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@codF", codF)
            command.ExecuteNonQuery()

        Catch ex As Exception

            dr.Close()
            MsgBox("Error desasociando producto", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

End Class