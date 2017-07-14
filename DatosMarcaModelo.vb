Imports System.Data.SqlClient
Imports Tesis_Nueva.MELDataSetTableAdapters

Public Class DatosMarcaModelo
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub llenarModelos(ByVal D As String, ByVal DGV As DataGridView)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Marca", D)
            command.CommandText = "sp_ConsultaModeloMarca"

            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("Modelo"), dr("Ano"), dr("Motor"), dr("Puertas"), dr("Version"), dr("Observacion"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub llenarComboAno(ByVal cb As ComboBoxAutoComplete)

        Try
            cb.Items.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaAno_distinct" ' crear el stored procedure

            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("Ano"))
            End While
            dr.Close()
            cb.Items.Add("Nuevo")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub llenarComboModelos(ByVal D As String, ByVal cb As ComboBoxAutoComplete)
        Try
            cb.Items.Clear()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Marca", D)
            command.CommandText = "sp_consultaModelo_distinct"

            dr = command.ExecuteReader()
            While dr.Read()
                cb.Items.Add(dr("Modelo"))
            End While
            dr.Close()
            cb.Items.Add("Nuevo")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub llenarComboMotor(ByVal cb As ComboBoxAutoComplete)

        Try
            cb.Items.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaMotor_distinct" ' crear el stored procedure

            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("Motor"))
            End While
            dr.Close()
            cb.Items.Add("Nuevo")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub llenarComboPuertas(ByVal cb As ComboBoxAutoComplete)
        Try
            cb.Items.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaPuertas_distinct" ' crear el stored procedure

            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("Puertas"))
            End While
            dr.Close()
            cb.Items.Add("Nuevo")
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Sub llenarComboVersion(ByVal cb As ComboBoxAutoComplete)

        Try
            cb.Items.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaVersion_distinct" ' crear el stored procedure

            dr = command.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("Version"))
            End While
            dr.Close()
            cb.Items.Add("Nuevo")
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Function Revisar(ByVal d As DataGridView, ByVal s As String) As Boolean

        Dim c As Integer
        Dim esta As Boolean

        For c = 0 To d.RowCount - 1
            If s.ToUpper = d.Item(0, c).Value.ToString.ToUpper Then
                esta = True
                c = d.RowCount - 1
            Else
                esta = False
            End If
        Next

        If esta Then
            MsgBox("La marca ya existe", MsgBoxStyle.Critical)
        Else
            'MsgBox("NO EXISTE")
        End If

        Return esta

    End Function

    Public Shared Sub InsertaMarca(ByVal Marca As String, ByVal DireccionLogo As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@DireccionLogo", DireccionLogo)
            command.CommandText = "sp_InsertaMarca"
            command.ExecuteNonQuery()
            MsgBox("La marca de Vehículo fue registrada satisfactoriamente", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function SelccionarMarcaDGV(ByVal d As DataGridView, ByVal S As String) As Integer

        Dim c As Integer
        Dim a As Integer

        For c = 0 To d.RowCount - 1
            If S.ToUpper = d.Item(0, c).Value.ToString.ToUpper Then
                a = c
                c = d.RowCount - 1
            End If
        Next

        Return a

    End Function


    Public Shared Sub InsertaModelo(ByVal Marca As String, ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String, ByVal Observ As String, ByVal DireccionFoto As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_InsertaModelo"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Ano", Ano)
            command.Parameters.AddWithValue("@Puertas", Puertas)
            command.Parameters.AddWithValue("@Motor", Motor)
            command.Parameters.AddWithValue("@Version", Version)
            command.Parameters.AddWithValue("@Observacion", Observ)
            command.Parameters.AddWithValue("@DireccionFoto", DireccionFoto)
            command.ExecuteNonQuery()
            MsgBox("Modelo agregado Satisfactoriamente.")
        Catch ex As Exception
            MsgBox("El modelo ya existe", MsgBoxStyle.Information)
        End Try


    End Sub

    Public Shared Function DevolverVectorModelo(ByVal Marca As String, ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String, ByVal Observ As String) As String()

        Dim vector(7) As String

        vector(0) = Marca
        vector(1) = Modelo
        vector(2) = Ano
        vector(3) = Puertas
        vector(4) = Motor
        vector(5) = Version
        vector(6) = Observ


        Return vector

    End Function

    Public Shared Sub ModificaModelo(ByVal V As String(), ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String, ByVal Observ As String, ByVal DireccionFoto As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaModelo"
            command.Parameters.AddWithValue("@Modelo1", V(1))
            command.Parameters.AddWithValue("@Ano1", V(2))
            command.Parameters.AddWithValue("@Puertas1", V(3))
            command.Parameters.AddWithValue("@Motor1", V(4))
            command.Parameters.AddWithValue("@Version1", V(5))
            command.Parameters.AddWithValue("@Observacion1", V(6))
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Ano", Ano)
            command.Parameters.AddWithValue("@Puertas", Puertas)
            command.Parameters.AddWithValue("@Motor", Motor)
            command.Parameters.AddWithValue("@Version", Version)
            command.Parameters.AddWithValue("@Observacion", Observ)
            command.Parameters.AddWithValue("@DireccionFoto", DireccionFoto)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try


    End Sub

    Public Shared Sub modificaNombreMarca(ByVal Marca As String, ByVal NuevoNombre As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaNombreMarca"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@NuevoNombre", NuevoNombre)
            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub



    Public Shared Function LlenarFoto(ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String) As String
        Dim Foto As String
        Foto = ""
        Try


            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_ConsultaFotoModelo"
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Ano", Ano)
            command.Parameters.AddWithValue("@Puertas", Puertas)
            command.Parameters.AddWithValue("@Motor", Motor)
            command.Parameters.AddWithValue("@Version", Version)

            dr = command.ExecuteReader
            While dr.Read
                Foto = dr.Item("DireccionFoto").ToString
            End While
            dr.Close()

        Catch ex As Exception

        End Try

        Return Foto

    End Function

    Public Shared Sub ModificaMarca(ByVal Marca As String, ByVal DireccionLogo As String, ByVal marca2 As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaMarca"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@Marca2", marca2)
            command.Parameters.AddWithValue("@DireccionLogo", DireccionLogo)
            command.ExecuteNonQuery()
            MsgBox("Marca modificada satisfactoriamente.")
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function LlenarLogo(ByVal Marca As String) As String

        Dim Logo As String
        Logo = ""

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaLogoMarca"
            command.Parameters.AddWithValue("@Marca", Marca)


            dr = command.ExecuteReader
            If Not dr Is System.DBNull.Value Then

                dr.Read()
                Logo = dr.Item("DireccionLogo").ToString

            End If

            dr.Close()
        Catch ex As Exception
        End Try

        Return Logo

    End Function

    Public Shared Sub BuscarPorMarca(ByVal Marca As String, ByVal DGV As DataGridView)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMarcaLike"
            command.Parameters.AddWithValue("@Marca", Marca)

            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr.Item("Marca").ToString)

            End While
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub EliminarMarca(ByVal Marca As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaMarca"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.ExecuteNonQuery()
            MsgBox("Marca eliminada satisfactoriamente", MsgBoxStyle.Information)
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub EliminarModelo(ByVal Marca As String, ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaModeloEliminar"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Ano", Ano)
            command.Parameters.AddWithValue("@Puertas", Puertas)
            command.Parameters.AddWithValue("@Motor", Motor)
            command.Parameters.AddWithValue("@Version", Version)

            dr = command.ExecuteReader
            If dr.Read() Then
                MsgBox("No se puede eliminar el Modelo, posee productos asociados", MsgBoxStyle.Critical)
            Else
                dr.Close()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_eliminaModelo"
                command.ExecuteNonQuery()
                MsgBox("Modelo eliminado satisfactoriamente", MsgBoxStyle.Information)
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Debe seleccionar una marca", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Shared Sub ConsultaCatalogo(ByVal Marca As String, ByVal Modelo As String, ByVal Ano As String, ByVal Puertas As String, ByVal Motor As String, ByVal Version As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCatalogo"
            command.Parameters.AddWithValue("@Marca", Marca)
            command.Parameters.AddWithValue("@Modelo", Modelo)
            command.Parameters.AddWithValue("@Ano", Ano)
            command.Parameters.AddWithValue("@Puertas", Puertas)
            command.Parameters.AddWithValue("@Motor", Motor)
            command.Parameters.AddWithValue("@Version", Version)

            dr = command.ExecuteReader
            While dr.Read

                DGV.Rows.Add(Modelo + " " + Ano + " " + Puertas + " " + Version, dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), Convert.ToDecimal(dr("PrecioVenta")), Convert.ToDecimal(dr("CostoPromedio")))

            End While
            dr.Close()
        Catch ex As Exception

        End Try


    End Sub


    Public Shared Sub ConsultaCatalogoMarca(ByVal Marca As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCatalogoMarca"
            command.Parameters.AddWithValue("@Marca", Marca)
            dr = command.ExecuteReader
            While dr.Read

                DGV.Rows.Add(dr("Modelo"), dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), Convert.ToDecimal(dr("PrecioVenta")), Convert.ToDecimal(dr("CostoPromedio")))

            End While
            dr.Close()
        Catch ex As Exception

        End Try


    End Sub



    Public Shared Sub llenarComboMarcas(ByVal cb As ComboBox)

        Try

            cb.Items.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaMarca" ' crear el stored procedure


            dr = command.ExecuteReader
            cb.Items.Add("Todas")

            While dr.Read

                cb.Items.Add(dr.Item("Marca"))

            End While

            dr.Close()

        Catch ex As Exception


        End Try

    End Sub

    Public Shared Sub llenarListModelo(ByVal Marca As String, ByVal list As ListBox, ByVal dgv As DataGridView)

        Try
            Dim i As Integer = 0
            Dim sw As Boolean = False
            list.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaModelo_distinct" ' crear el stored procedure
            command.Parameters.AddWithValue("@Marca", Marca)

            dr = command.ExecuteReader
            list.Items.Add("Todas")

            While dr.Read
                sw = False
                i = 0
                While i < dgv.RowCount
                    If dgv.Rows(i).Cells(0).Value = dr.Item("Modelo") Then
                        i = dgv.RowCount
                        sw = True
                    End If
                    i = i + 1
                End While
                If sw = False Then
                    list.Items.Add(dr.Item("Modelo"))
                End If

            End While

            dr.Close()



        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub LLenarData(ByVal Marca As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCatalogoMarca"
            command.Parameters.AddWithValue("@Marca", Marca)
            dr = command.ExecuteReader
            While dr.Read

                DGV.Rows.Add(dr("Modelo"), dr("CodigoInterno"), dr("Nombre"), dr("CantidadExistencia"), Convert.ToDecimal(dr("PrecioVenta")), Convert.ToDecimal(dr("CostoPromedio")))

            End While
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub
    ''Verificar una marca en la BD

    Public Shared Function VerificarMarca(ByVal Marca As String) As Boolean
        Dim esta As Boolean = False

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaMarcaEliminar"
            command.Parameters.AddWithValue("@Marca", Marca)

            dr = command.ExecuteReader
            If dr.Read() Then
                esta = True
                'MsgBox("La Marca si existe")
            End If

            dr.Close()

        Catch ex As Exception
            'MsgBox("Debe seleccionar una marca", MsgBoxStyle.Critical)
        End Try

        Return esta

    End Function


    Public Shared Sub Consultar_Grupos(ByRef cb As ComboBox)

        Try
            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaGrupo"
            command.Parameters.AddWithValue("@cod", 0)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@Valor", "")
            dr = command.ExecuteReader()
            While dr.Read()
                cb.Items.Add(New comboItem(dr("NombreGrupo"), CStr(dr("CodigoGrupo"))))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message().ToString())
        End Try

    End Sub

    Public Shared Sub consulta_compras_fecha(ByVal D As Date, ByVal DGV As DataGridView, ByVal dgv2 As DataGridView)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@fecha", D)
            command.CommandText = "sp_consulta_comprasfecha"
            dr = command.ExecuteReader()
            Dim i As Integer = 0
            Dim sw As Boolean
            While dr.Read()
                i = 0
                sw = False
                While i < dgv2.Rows.Count
                    If dgv2.Rows(i).Cells(2).Value = dr("cod") Then
                        sw = True
                    End If
                    i = i + 1
                End While
                If sw = False Then
                    DGV.Rows.Add(dr("Nombre"), dr("Fecha"), dr("cod"))
                End If
               

            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_compras_fecha_simple(ByVal D As Date, ByVal DGV As DataGridView)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@fecha", D)
            command.CommandText = "sp_consulta_comprasfecha"
            dr = command.ExecuteReader()
            While dr.Read()
                DGV.Rows.Add(dr("cod"))
            End While
            dr.Close()
            DGV.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

End Class
