Imports System.Data.SqlClient
Public Class DatosProducto
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub ultimo_costo(ByVal cod As Integer, ByRef ultc As Double)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductoultimocosto"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        If dr.Read Then
            ultc = dr("costo")
        Else
            ultc = 0
        End If
        dr.Close()
    End Sub

    Public Shared Function verifica_Codigo_Fabrica(ByVal cod As String, ByVal CodF As Integer) As Boolean

        Try
            Dim existe As Boolean = False

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Cod", cod)
            command.Parameters.AddWithValue("@CodF", CodF)
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_verifica_codigo_Fabrica"
            dr = command.ExecuteReader()

            If dr.HasRows Then
                existe = True
            End If

            If existe Then
                MsgBox("Ese código de fábrica ya esta asociado a otro producto del proveedor", MsgBoxStyle.Exclamation, "SINPRO")
            End If

            Return existe

        Catch ex As Exception

            MsgBox("Error verificando código de fábrica", MsgBoxStyle.Exclamation, "SINPRO")

        Finally

            dr.Close()

        End Try

    End Function

    Public Shared Sub lv_Producto(ByRef dg As DataGridView, ByVal s As String, ByVal val As Integer, ByRef sww As Boolean)
        Try
            dg.ClearSelection()
            dg.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvProducto"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
            dr = command.ExecuteReader()
            While dr.Read
                dg.Rows.Add(dr("codigoInterno"), dr("nombre"))
            End While
            dr.Close()
            dg.ClearSelection()
            sww = True
            dr.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub consulta_productos(ByRef dg As DataGridView, ByRef cant As Integer)
        Try
            Dim par As String
            par = "todos"
            dg.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()
            While dr.Read
                cant = cant + 1
                dg.Rows.Add(dr("codigoInterno"), dr("nombre"))
            End While
            dr.Close()
        Catch ex As Exception

            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_arancelarios(ByRef cb As MTGCComboBox)

        Dim par As Integer
        cb.Items.Clear()
        Dim it As MTGCComboBoxItem
        it = New MTGCComboBoxItem("Ninguno", CStr(0) + "%")
        cb.Text = "Ninguno"
        cb.SelectedItem() = it
        cb.Items.Add(it)
        par = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCodigoArancelario"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New MTGCComboBoxItem(CStr(dr("CodigoArancelario")), CStr(dr("impuesto")) + "%"))
        End While

        dr.Close()
    End Sub

    Public Shared Sub consulta_Marca(ByRef cb As ComboBox, ByVal marca As String)
        Dim par As Integer
        cb.Items.Clear()
        par = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Marca", marca)
        command.CommandText = "sp_consultaMarcaLike"
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(CStr(dr("Marca")), dr("Marca")))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_Modelo(ByRef dgv As DataGridView, ByVal modelo As String)
        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaModelo"
        command.Parameters.AddWithValue("@modelo", modelo)
        command.Parameters.AddWithValue("@tipo", 1)
        dr = command.ExecuteReader()
        While dr.Read
            dgv.Rows.Add(dr("Modelo"), dr("Ano"), dr("Motor"), dr("Puertas"), dr("Version"), dr("Observacion"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub consulta_Modelo2(ByRef cb As ComboBox, ByVal marca As String)
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaModelo_distinct"
        command.Parameters.AddWithValue("@marca", marca)
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(CStr(dr("Modelo")), dr("Modelo")))
        End While
        dr.Close()
    End Sub

    Public Shared Sub inserta_producto(ByVal codPto As String, ByVal codA As String, ByVal nom As String, ByVal marP As String, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByRef dgv As DataGridView, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByRef deny As Boolean, ByVal ocu As Boolean, ByVal obs2 As String, ByVal porC As Boolean)

        Try

            Dim j As Integer = 0
            Dim fr As Boolean = False

            If My.Settings.Empresa = 1 Then

                While j < dgv.Rows.Count

                    If dgv.Rows(j).Cells(0).Value = "Fiat" Or dgv.Rows(j).Cells(0).Value = "Renault" Then
                        fr = True
                    End If

                    j = j + 1

                End While

            End If

            command.Parameters.Clear()
            command.CommandText = "sp_insertaProducto"
            command.Parameters.AddWithValue("@codPto", codPto)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@cantE", cantE)
            command.Parameters.AddWithValue("@pre", pre)
            command.Parameters.AddWithValue("@util", util)
            command.Parameters.AddWithValue("@obs2", obs2)
            command.Parameters.AddWithValue("@PorC", porC)

            If My.Settings.Empresa = 1 Then
                command.Parameters.AddWithValue("@ocu", fr)
            Else
                command.Parameters.AddWithValue("@ocu", ocu)
            End If

            If codA = 0 Or codA = "0" Then
                command.Parameters.AddWithValue("@codA", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@codA", codA)
            End If


            If marP = "" Then
                command.Parameters.AddWithValue("@marP", "")
            Else
                command.Parameters.AddWithValue("@marP", marP)
            End If
            If foto = "" Then
                command.Parameters.AddWithValue("@foto", "")
            Else
                command.Parameters.AddWithValue("@foto", foto)
            End If
            If cosP = "" Then
                command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
            Else
                command.Parameters.AddWithValue("@cosP", CDec(cosP))
            End If
            If ABC = "" Then
                command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@ABC", ABC)
            End If
            If cantV = "" Then
                command.Parameters.AddWithValue("@cantV", 0)
            Else
                command.Parameters.AddWithValue("@cantV", CLng(cantV))
            End If
            If OEM = "" Then
                command.Parameters.AddWithValue("@OEM", "")
            Else
                command.Parameters.AddWithValue("@OEM", OEM)
            End If
            If Var1 = "" Then
                command.Parameters.AddWithValue("@Var1", "")
            Else
                command.Parameters.AddWithValue("@Var1", Var1)
            End If
            If Var2 = "" Then
                command.Parameters.AddWithValue("@Var2", "")
            Else
                command.Parameters.AddWithValue("@Var2", Var2)
            End If
            If emp = "" Then
                command.Parameters.AddWithValue("@emp", "")
            Else
                command.Parameters.AddWithValue("@emp", emp)
            End If
            If obs = "" Then
                command.Parameters.AddWithValue("@obs", "")
            Else
                command.Parameters.AddWithValue("@obs", obs)
            End If

            command.ExecuteNonQuery()

            Dim i As Integer = 0
            While i < dgv.Rows.Count
                command.Parameters.Clear()
                command.CommandText = "sp_insertaProducto_Modelo"
                command.Parameters.AddWithValue("@codPto", codPto)
                command.Parameters.AddWithValue("@marca", dgv.Rows(i).Cells(0).Value)
                command.Parameters.AddWithValue("@modelo", dgv.Rows(i).Cells(1).Value)
                command.Parameters.AddWithValue("@ano", dgv.Rows(i).Cells(2).Value)
                command.Parameters.AddWithValue("@motor", dgv.Rows(i).Cells(3).Value)
                command.Parameters.AddWithValue("@puertas", dgv.Rows(i).Cells(4).Value)
                command.Parameters.AddWithValue("@version", dgv.Rows(i).Cells(5).Value)
                command.Parameters.AddWithValue("@imp", i)
                command.ExecuteNonQuery()
                i = i + 1
            End While


            MsgBox("El Producto Ha Sido Registrado Exitosamente")
        Catch ex As Exception

            Try
                command.Parameters.Clear()
                command.CommandText = "sp_consulta_NombreProducto"
                command.Parameters.AddWithValue("@codPto", codPto)
                dr = command.ExecuteReader

                Dim nombre As String = ""

                While dr.Read
                    nombre = dr("Nombre")
                End While

                dr.Close()

                MsgBox("El codigo '" + codPto + "' ya esta registrado como '" + nombre.TrimEnd + "' favor utilizar otro código", MsgBoxStyle.Critical, "Error")
                deny = True
            Catch ex2 As Exception
                dr.Close()
                MsgBox("El codigo '" + codPto + "' ya esta registrado", MsgBoxStyle.Critical, "Error")
            End Try

        End Try


    End Sub

    'Public Shared Sub inserta_producto_BRWME(ByVal codPto As String, ByVal codA As String, ByVal nom As String, ByVal marP As String, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByRef dgv As DataGridView, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByRef deny As Boolean, ByVal ocu As Boolean, ByVal obs2 As String, ByVal porC As Boolean)

    '    If My.Settings.Empresa = 1 Then
    '        inserta_producto_COMER(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '        inserta_producto_DIST(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '        inserta_producto_CONAVE(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '    ElseIf My.Settings.Empresa = 4 Then
    '        inserta_producto_COMER(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '        inserta_producto_DIST(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '    ElseIf My.Settings.Empresa = 6 Then
    '        inserta_producto_COMER(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '        inserta_producto_CONAVE(codPto, codA, nom, marP, foto, cantE, pre, cosP, ABC, cantV, util, dgv, OEM, Var1, Var2, emp, obs, deny, ocu, obs2, porC)
    '    End If

    'End Sub

    'Public Shared Sub inserta_producto_COMER(ByVal codPto As String, ByVal codA As String, ByVal nom As String, ByVal marP As String, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByRef dgv As DataGridView, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByRef deny As Boolean, ByVal ocu As Boolean, ByVal obs2 As String, ByVal porC As Boolean)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_insertaProducto_COMER"
    '        command.Parameters.AddWithValue("@codPto", codPto)
    '        command.Parameters.AddWithValue("@nom", nom)
    '        command.Parameters.AddWithValue("@cantE", cantE)
    '        command.Parameters.AddWithValue("@pre", pre)
    '        command.Parameters.AddWithValue("@util", util)
    '        command.Parameters.AddWithValue("@obs2", obs2)
    '        command.Parameters.AddWithValue("@PorC", porC)
    '        command.Parameters.AddWithValue("@ocu", ocu)


    '        If codA = 0 Or codA = "0" Then
    '            command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@codA", codA)
    '        End If


    '        If marP = "" Then
    '            command.Parameters.AddWithValue("@marP", "")
    '        Else
    '            command.Parameters.AddWithValue("@marP", marP)
    '        End If
    '        If foto = "" Then
    '            command.Parameters.AddWithValue("@foto", "")
    '        Else
    '            command.Parameters.AddWithValue("@foto", foto)
    '        End If
    '        If cosP = "" Then
    '            command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '        Else
    '            command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If cantV = "" Then
    '            command.Parameters.AddWithValue("@cantV", 0)
    '        Else
    '            command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '        End If
    '        If OEM = "" Then
    '            command.Parameters.AddWithValue("@OEM", "")
    '        Else
    '            command.Parameters.AddWithValue("@OEM", OEM)
    '        End If
    '        If Var1 = "" Then
    '            command.Parameters.AddWithValue("@Var1", "")
    '        Else
    '            command.Parameters.AddWithValue("@Var1", Var1)
    '        End If
    '        If Var2 = "" Then
    '            command.Parameters.AddWithValue("@Var2", "")
    '        Else
    '            command.Parameters.AddWithValue("@Var2", Var2)
    '        End If
    '        If emp = "" Then
    '            command.Parameters.AddWithValue("@emp", "")
    '        Else
    '            command.Parameters.AddWithValue("@emp", emp)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", "")
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If

    '        command.ExecuteNonQuery()

    '    Catch ex As Exception

    '        Try
    '            command.Parameters.Clear()
    '            command.CommandText = "sp_consulta_NombreProducto"
    '            command.Parameters.AddWithValue("@codPto", codPto)
    '            dr = command.ExecuteReader

    '            Dim nombre As String = ""

    '            While dr.Read
    '                nombre = dr("Nombre")
    '            End While

    '            dr.Close()

    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en Comercializadora como '" + nombre.TrimEnd + "' favor utilizar otro código", MsgBoxStyle.Critical, "Error")
    '            deny = True
    '        Catch ex2 As Exception
    '            dr.Close()
    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en Comercializadora", MsgBoxStyle.Critical, "Error")
    '        End Try

    '    End Try

    '    'MsgBox("COMER", MsgBoxStyle.OkOnly)

    'End Sub

    'Public Shared Sub inserta_producto_DIST(ByVal codPto As String, ByVal codA As String, ByVal nom As String, ByVal marP As String, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByRef dgv As DataGridView, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByRef deny As Boolean, ByVal ocu As Boolean, ByVal obs2 As String, ByVal porC As Boolean)

    '    Try

    '        Dim j As Integer = 0
    '        Dim r As Boolean = False

    '        While j < dgv.Rows.Count

    '            If dgv.Rows(j).Cells(0).Value = "Renault" Then
    '                r = True
    '            End If

    '            j = j + 1

    '        End While

    '        If r Then

    '            command.Parameters.Clear()
    '            command.CommandText = "sp_insertaProducto_DIST"
    '            command.Parameters.AddWithValue("@codPto", codPto)
    '            command.Parameters.AddWithValue("@nom", nom)
    '            command.Parameters.AddWithValue("@cantE", cantE)
    '            command.Parameters.AddWithValue("@pre", pre)
    '            command.Parameters.AddWithValue("@util", util)
    '            command.Parameters.AddWithValue("@obs2", obs2)
    '            command.Parameters.AddWithValue("@PorC", porC)
    '            command.Parameters.AddWithValue("@ocu", ocu)

    '            If codA = 0 Or codA = "0" Then
    '                command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '            Else
    '                command.Parameters.AddWithValue("@codA", codA)
    '            End If


    '            If marP = "" Then
    '                command.Parameters.AddWithValue("@marP", "")
    '            Else
    '                command.Parameters.AddWithValue("@marP", marP)
    '            End If
    '            If foto = "" Then
    '                command.Parameters.AddWithValue("@foto", "")
    '            Else
    '                command.Parameters.AddWithValue("@foto", foto)
    '            End If
    '            If cosP = "" Then
    '                command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '            Else
    '                command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '            End If
    '            If ABC = "" Then
    '                command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '            Else
    '                command.Parameters.AddWithValue("@ABC", ABC)
    '            End If
    '            If cantV = "" Then
    '                command.Parameters.AddWithValue("@cantV", 0)
    '            Else
    '                command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '            End If
    '            If OEM = "" Then
    '                command.Parameters.AddWithValue("@OEM", "")
    '            Else
    '                command.Parameters.AddWithValue("@OEM", OEM)
    '            End If
    '            If Var1 = "" Then
    '                command.Parameters.AddWithValue("@Var1", "")
    '            Else
    '                command.Parameters.AddWithValue("@Var1", Var1)
    '            End If
    '            If Var2 = "" Then
    '                command.Parameters.AddWithValue("@Var2", "")
    '            Else
    '                command.Parameters.AddWithValue("@Var2", Var2)
    '            End If
    '            If emp = "" Then
    '                command.Parameters.AddWithValue("@emp", "")
    '            Else
    '                command.Parameters.AddWithValue("@emp", emp)
    '            End If
    '            If obs = "" Then
    '                command.Parameters.AddWithValue("@obs", "")
    '            Else
    '                command.Parameters.AddWithValue("@obs", obs)
    '            End If

    '            command.ExecuteNonQuery()

    '        End If

    '    Catch ex As Exception

    '        Try
    '            command.Parameters.Clear()
    '            command.CommandText = "sp_consulta_NombreProducto"
    '            command.Parameters.AddWithValue("@codPto", codPto)
    '            dr = command.ExecuteReader

    '            Dim nombre As String = ""

    '            While dr.Read
    '                nombre = dr("Nombre")
    '            End While

    '            dr.Close()

    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en Distribuidora como '" + nombre.TrimEnd + "' favor utilizar otro código", MsgBoxStyle.Critical, "Error")
    '            deny = True
    '        Catch ex2 As Exception
    '            dr.Close()
    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en Distribuidora", MsgBoxStyle.Critical, "Error")
    '        End Try

    '    End Try

    '    'MsgBox("DIST", MsgBoxStyle.OkOnly)

    'End Sub

    'Public Shared Sub inserta_producto_CONAVE(ByVal codPto As String, ByVal codA As String, ByVal nom As String, ByVal marP As String, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByRef dgv As DataGridView, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByRef deny As Boolean, ByVal ocu As Boolean, ByVal obs2 As String, ByVal porC As Boolean)

    '    Try

    '        Dim j As Integer = 0
    '        Dim f As Boolean = False

    '        While j < dgv.Rows.Count

    '            If dgv.Rows(j).Cells(0).Value = "Fiat" Then
    '                f = True
    '            End If

    '            j = j + 1

    '        End While

    '        If f Then

    '            command.Parameters.Clear()
    '            command.CommandText = "sp_insertaProducto_CONAVE"
    '            command.Parameters.AddWithValue("@codPto", codPto)
    '            command.Parameters.AddWithValue("@nom", nom)
    '            command.Parameters.AddWithValue("@cantE", cantE)
    '            command.Parameters.AddWithValue("@pre", pre)
    '            command.Parameters.AddWithValue("@util", util)
    '            command.Parameters.AddWithValue("@obs2", obs2)
    '            command.Parameters.AddWithValue("@PorC", porC)
    '            command.Parameters.AddWithValue("@ocu", ocu)

    '            If codA = 0 Or codA = "0" Then
    '                command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '            Else
    '                command.Parameters.AddWithValue("@codA", codA)
    '            End If


    '            If marP = "" Then
    '                command.Parameters.AddWithValue("@marP", "")
    '            Else
    '                command.Parameters.AddWithValue("@marP", marP)
    '            End If
    '            If foto = "" Then
    '                command.Parameters.AddWithValue("@foto", "")
    '            Else
    '                command.Parameters.AddWithValue("@foto", foto)
    '            End If
    '            If cosP = "" Then
    '                command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '            Else
    '                command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '            End If
    '            If ABC = "" Then
    '                command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '            Else
    '                command.Parameters.AddWithValue("@ABC", ABC)
    '            End If
    '            If cantV = "" Then
    '                command.Parameters.AddWithValue("@cantV", 0)
    '            Else
    '                command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '            End If
    '            If OEM = "" Then
    '                command.Parameters.AddWithValue("@OEM", "")
    '            Else
    '                command.Parameters.AddWithValue("@OEM", OEM)
    '            End If
    '            If Var1 = "" Then
    '                command.Parameters.AddWithValue("@Var1", "")
    '            Else
    '                command.Parameters.AddWithValue("@Var1", Var1)
    '            End If
    '            If Var2 = "" Then
    '                command.Parameters.AddWithValue("@Var2", "")
    '            Else
    '                command.Parameters.AddWithValue("@Var2", Var2)
    '            End If
    '            If emp = "" Then
    '                command.Parameters.AddWithValue("@emp", "")
    '            Else
    '                command.Parameters.AddWithValue("@emp", emp)
    '            End If
    '            If obs = "" Then
    '                command.Parameters.AddWithValue("@obs", "")
    '            Else
    '                command.Parameters.AddWithValue("@obs", obs)
    '            End If

    '            command.ExecuteNonQuery()

    '        End If

    '    Catch ex As Exception

    '        Try
    '            command.Parameters.Clear()
    '            command.CommandText = "sp_consulta_NombreProducto"
    '            command.Parameters.AddWithValue("@codPto", codPto)
    '            dr = command.ExecuteReader

    '            Dim nombre As String = ""

    '            While dr.Read
    '                nombre = dr("Nombre")
    '            End While

    '            dr.Close()

    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en CONAVE como '" + nombre.TrimEnd + "' favor utilizar otro código", MsgBoxStyle.Critical, "Error")
    '            deny = True
    '        Catch ex2 As Exception
    '            dr.Close()
    '            MsgBox("El codigo '" + codPto + "' ya esta registrado en CONAVE", MsgBoxStyle.Critical, "Error")
    '        End Try

    '    End Try

    '    'MsgBox("CONAVE", MsgBoxStyle.OkOnly)

    'End Sub

    Public Shared Function Busca_Producto(ByVal cod As String) As Boolean

        Try

            Dim esta As Boolean = False
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCodigoInterno"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()

            If dr.HasRows Then
                esta = True
            End If

            Return esta

        Catch ex As Exception
            MsgBox("Error verificando código interno del artículo")
        Finally
            dr.Close()
        End Try

    End Function

    Public Shared Sub consulta_producto(ByVal c As String, ByRef cod As String, ByRef ara As MTGCComboBox, ByRef nom As String, ByRef marP As String, ByRef dgv As DataGridView, ByRef foto As String, ByRef cantE As String, ByRef preV As String, ByRef cosP As String, ByRef ABC As String, ByRef cantV As String, ByRef OEM As String, ByRef Var1 As String, ByRef Var2 As String, ByRef emp As String, ByRef obs As String, ByRef ocu As Boolean, ByRef info As String, ByRef porC As Boolean)
        'Dim codV, codZ As Integer
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProducto"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        dr.Read()
        cod = dr("codigoInterno")
        nom = dr("nombre")
        cantE = dr("cantidadExistencia")
        preV = Format(Math.Round(dr("precioVenta"), 2), "#0.00")
        ocu = dr("oculto")


        If dr("OEM").GetType.ToString = "System.DBNull" Then
            OEM = ""
        Else
            OEM = dr("OEM")
        End If

        If dr("PorComplementar").GetType.ToString = "System.DBNull" Then
            porC = False
        Else
            porC = dr("PorComplementar")
        End If

        If dr("Informacion").GetType.ToString = "System.DBNull" Then
            info = ""
        Else
            info = dr("Informacion")
        End If
        If dr("Variante1").GetType.ToString = "System.DBNull" Then
            Var1 = ""
        Else
            Var1 = dr("Variante1")
        End If
        If dr("Variante2").GetType.ToString = "System.DBNull" Then
            Var2 = ""
        Else
            Var2 = dr("Variante2")
        End If
        If dr("marcaProducto").GetType.ToString = "System.DBNull" Then
            marP = ""
        Else
            marP = dr("marcaProducto")
        End If
        If dr("foto").GetType.ToString = "System.DBNull" Then
            foto = ""
        Else
            foto = dr("foto")
        End If

        If dr("costoPromedio").GetType.ToString = "System.DBNull" Then
            cosP = ""
        Else

            If dr("costoPromedio") = 0 Then
                cosP = ""
            Else
                cosP = Format(dr("costoPromedio"), "#0.00")
            End If

        End If

        If dr("clasificacionABC").GetType.ToString = "System.DBNull" Then
            ABC = ""
        Else
            ABC = dr("clasificacionABC")
        End If
        If dr("CantidadVendida").GetType.ToString = "System.DBNull" Then
            cantV = ""
        Else
            cantV = dr("CantidadVendida")
        End If
        Dim codA As String = ""
        If dr("CodigoArancelario").GetType.ToString = "System.DBNull" Then
            codA = ""
        Else
            codA = dr("codigoArancelario")
        End If
        If dr("Empaque").GetType.ToString = "System.DBNull" Then
            emp = ""
        Else
            emp = dr("Empaque")
        End If
        If dr("Observacion").GetType.ToString = "System.DBNull" Then
            obs = ""
        Else
            obs = dr("Observacion")
        End If



        dr.Close()
        'consulta_arancelarios(ara)

        If codA = "" Then
            ara.Text = "Ninguno"
        Else
            ara.Text = codA
        End If

        dgv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_ProductoModelo"
        command.Parameters.AddWithValue("@codPto", c)
        dr = command.ExecuteReader()
        While dr.Read()
            dgv.Rows.Add(CStr(dr("Marca")), dr("Modelo"), dr("Ano"), dr("Motor"), dr("Puertas"), dr("Version"), dr("Observacion"))
        End While
        dr.Close()
    End Sub

    Public Shared Sub modifica_producto(ByVal codA As String, ByVal nom As String, ByVal marP As String, ByRef dgv As DataGridView, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByVal COD As String, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByVal ocu As Boolean, ByVal obs2 As String, ByVal PorC As Boolean)

        command.Parameters.Clear()
        command.CommandText = "sp_modificaProducto"
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@cantE", cantE)
        command.Parameters.AddWithValue("@pre", pre)
        command.Parameters.AddWithValue("@COD", COD)
        command.Parameters.AddWithValue("@util", util)
        command.Parameters.AddWithValue("@ocu", ocu)
        command.Parameters.AddWithValue("@obs2", obs2)
        command.Parameters.AddWithValue("@PorC", PorC)

        If codA Is Nothing Then
            command.Parameters.AddWithValue("@codA", System.DBNull.Value)
        ElseIf codA.Trim = "" Then
            command.Parameters.AddWithValue("@codA", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@codA", codA)
        End If
        If marP = "" Then
            command.Parameters.AddWithValue("@marP", "")
        Else
            command.Parameters.AddWithValue("@marP", marP)
        End If
        If foto = "" Then
            command.Parameters.AddWithValue("@foto", "")
        Else
            command.Parameters.AddWithValue("@foto", foto)
        End If
        If cosP = "" Then
            command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
        Else
            command.Parameters.AddWithValue("@cosP", CDec(cosP))
        End If
        If ABC = "" Then
            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@ABC", ABC)
        End If
        If cantV = "" Then
            command.Parameters.AddWithValue("@cantV", 0)
        Else
            command.Parameters.AddWithValue("@cantV", CLng(cantV))
        End If
        If OEM = "" Then
            command.Parameters.AddWithValue("@OEM", "")
        Else
            command.Parameters.AddWithValue("@OEM", OEM)
        End If
        If Var1 = "" Then
            command.Parameters.AddWithValue("@Var1", "")
        Else
            command.Parameters.AddWithValue("@Var1", Var1)
        End If
        If Var2 = "" Then
            command.Parameters.AddWithValue("@Var2", "")
        Else
            command.Parameters.AddWithValue("@Var2", Var2)
        End If
        If emp = "" Then
            command.Parameters.AddWithValue("@emp", "")
        Else
            command.Parameters.AddWithValue("@emp", emp)
        End If
        If obs = "" Then
            command.Parameters.AddWithValue("@obs", "")
        Else
            command.Parameters.AddWithValue("@obs", obs)
        End If
        command.ExecuteNonQuery()


        command.Parameters.Clear()
        command.CommandText = "sp_elimina_ProductoModelo"
        command.Parameters.AddWithValue("@codPto", COD)
        command.ExecuteNonQuery()

        Dim i As Integer = 0
        While i < dgv.Rows.Count
            command.Parameters.Clear()
            command.CommandText = "sp_insertaProducto_Modelo"
            command.Parameters.AddWithValue("@codPto", COD)
            command.Parameters.AddWithValue("@marca", dgv.Rows(i).Cells(0).Value)
            command.Parameters.AddWithValue("@modelo", dgv.Rows(i).Cells(1).Value)
            command.Parameters.AddWithValue("@ano", dgv.Rows(i).Cells(2).Value)
            command.Parameters.AddWithValue("@motor", dgv.Rows(i).Cells(3).Value)
            command.Parameters.AddWithValue("@puertas", dgv.Rows(i).Cells(4).Value)
            command.Parameters.AddWithValue("@version", dgv.Rows(i).Cells(5).Value)
            command.Parameters.AddWithValue("@imp", i)
            command.ExecuteNonQuery()
            i = i + 1
        End While

    End Sub

    'Public Shared Sub modifica_producto_BRWME(ByVal codA As String, ByVal nom As String, ByVal marP As String, ByRef dgv As DataGridView, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByVal COD As String, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByVal ocu As Boolean, ByVal obs2 As String, ByVal PorC As Boolean)

    '    modifica_producto_COMER(codA, nom, marP, dgv, foto, cantE, pre, cosP, ABC, cantV, util, COD, OEM, Var1, Var2, emp, obs, ocu, obs2, PorC)
    '    modifica_producto_DIST(codA, nom, marP, dgv, foto, cantE, pre, cosP, ABC, cantV, util, COD, OEM, Var1, Var2, emp, obs, ocu, obs2, PorC)
    '    modifica_producto_CONAVE(codA, nom, marP, dgv, foto, cantE, pre, cosP, ABC, cantV, util, COD, OEM, Var1, Var2, emp, obs, ocu, obs2, PorC)

    'End Sub

    'Public Shared Sub modifica_producto_COMER(ByVal codA As String, ByVal nom As String, ByVal marP As String, ByRef dgv As DataGridView, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByVal COD As String, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByVal ocu As Boolean, ByVal obs2 As String, ByVal PorC As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProducto_COMER"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@cantE", cantE)
    '    command.Parameters.AddWithValue("@pre", pre)
    '    command.Parameters.AddWithValue("@COD", COD)
    '    command.Parameters.AddWithValue("@util", util)
    '    command.Parameters.AddWithValue("@ocu", ocu)
    '    command.Parameters.AddWithValue("@obs2", obs2)
    '    command.Parameters.AddWithValue("@PorC", PorC)

    '    If codA Is Nothing Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    ElseIf codA.Trim = "" Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@codA", codA)
    '    End If
    '    If marP = "" Then
    '        command.Parameters.AddWithValue("@marP", "")
    '    Else
    '        command.Parameters.AddWithValue("@marP", marP)
    '    End If
    '    If foto = "" Then
    '        command.Parameters.AddWithValue("@foto", "")
    '    Else
    '        command.Parameters.AddWithValue("@foto", foto)
    '    End If
    '    If cosP = "" Then
    '        command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '    Else
    '        command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If cantV = "" Then
    '        command.Parameters.AddWithValue("@cantV", 0)
    '    Else
    '        command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '    End If
    '    If OEM = "" Then
    '        command.Parameters.AddWithValue("@OEM", "")
    '    Else
    '        command.Parameters.AddWithValue("@OEM", OEM)
    '    End If
    '    If Var1 = "" Then
    '        command.Parameters.AddWithValue("@Var1", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var1", Var1)
    '    End If
    '    If Var2 = "" Then
    '        command.Parameters.AddWithValue("@Var2", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var2", Var2)
    '    End If
    '    If emp = "" Then
    '        command.Parameters.AddWithValue("@emp", "")
    '    Else
    '        command.Parameters.AddWithValue("@emp", emp)
    '    End If
    '    If obs = "" Then
    '        command.Parameters.AddWithValue("@obs", "")
    '    Else
    '        command.Parameters.AddWithValue("@obs", obs)
    '    End If

    '    command.ExecuteNonQuery()

    '    'MsgBox("COMER", MsgBoxStyle.OkOnly)

    'End Sub

    'Public Shared Sub modifica_producto_DIST(ByVal codA As String, ByVal nom As String, ByVal marP As String, ByRef dgv As DataGridView, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByVal COD As String, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByVal ocu As Boolean, ByVal obs2 As String, ByVal PorC As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProducto_DIST"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@cantE", cantE)
    '    command.Parameters.AddWithValue("@pre", pre)
    '    command.Parameters.AddWithValue("@COD", COD)
    '    command.Parameters.AddWithValue("@util", util)
    '    command.Parameters.AddWithValue("@ocu", ocu)
    '    command.Parameters.AddWithValue("@obs2", obs2)
    '    command.Parameters.AddWithValue("@PorC", PorC)

    '    If codA Is Nothing Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    ElseIf codA.Trim = "" Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@codA", codA)
    '    End If
    '    If marP = "" Then
    '        command.Parameters.AddWithValue("@marP", "")
    '    Else
    '        command.Parameters.AddWithValue("@marP", marP)
    '    End If
    '    If foto = "" Then
    '        command.Parameters.AddWithValue("@foto", "")
    '    Else
    '        command.Parameters.AddWithValue("@foto", foto)
    '    End If
    '    If cosP = "" Then
    '        command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '    Else
    '        command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If cantV = "" Then
    '        command.Parameters.AddWithValue("@cantV", 0)
    '    Else
    '        command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '    End If
    '    If OEM = "" Then
    '        command.Parameters.AddWithValue("@OEM", "")
    '    Else
    '        command.Parameters.AddWithValue("@OEM", OEM)
    '    End If
    '    If Var1 = "" Then
    '        command.Parameters.AddWithValue("@Var1", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var1", Var1)
    '    End If
    '    If Var2 = "" Then
    '        command.Parameters.AddWithValue("@Var2", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var2", Var2)
    '    End If
    '    If emp = "" Then
    '        command.Parameters.AddWithValue("@emp", "")
    '    Else
    '        command.Parameters.AddWithValue("@emp", emp)
    '    End If
    '    If obs = "" Then
    '        command.Parameters.AddWithValue("@obs", "")
    '    Else
    '        command.Parameters.AddWithValue("@obs", obs)
    '    End If

    '    command.ExecuteNonQuery()

    '    'MsgBox("DIST", MsgBoxStyle.OkOnly)

    'End Sub

    'Public Shared Sub modifica_producto_CONAVE(ByVal codA As String, ByVal nom As String, ByVal marP As String, ByRef dgv As DataGridView, ByVal foto As String, ByVal cantE As Integer, ByVal pre As Double, ByVal cosP As String, ByVal ABC As String, ByVal cantV As String, ByVal util As Double, ByVal COD As String, ByVal OEM As String, ByVal Var1 As String, ByVal Var2 As String, ByVal emp As String, ByVal obs As String, ByVal ocu As Boolean, ByVal obs2 As String, ByVal PorC As Boolean)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProducto_CONAVE"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@cantE", cantE)
    '    command.Parameters.AddWithValue("@pre", pre)
    '    command.Parameters.AddWithValue("@COD", COD)
    '    command.Parameters.AddWithValue("@util", util)
    '    command.Parameters.AddWithValue("@ocu", ocu)
    '    command.Parameters.AddWithValue("@obs2", obs2)
    '    command.Parameters.AddWithValue("@PorC", PorC)

    '    If codA Is Nothing Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    ElseIf codA.Trim = "" Then
    '        command.Parameters.AddWithValue("@codA", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@codA", codA)
    '    End If
    '    If marP = "" Then
    '        command.Parameters.AddWithValue("@marP", "")
    '    Else
    '        command.Parameters.AddWithValue("@marP", marP)
    '    End If
    '    If foto = "" Then
    '        command.Parameters.AddWithValue("@foto", "")
    '    Else
    '        command.Parameters.AddWithValue("@foto", foto)
    '    End If
    '    If cosP = "" Then
    '        command.Parameters.AddWithValue("@cosP", SqlDbType.Int).Value = 0
    '    Else
    '        command.Parameters.AddWithValue("@cosP", CDec(cosP))
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If cantV = "" Then
    '        command.Parameters.AddWithValue("@cantV", 0)
    '    Else
    '        command.Parameters.AddWithValue("@cantV", CLng(cantV))
    '    End If
    '    If OEM = "" Then
    '        command.Parameters.AddWithValue("@OEM", "")
    '    Else
    '        command.Parameters.AddWithValue("@OEM", OEM)
    '    End If
    '    If Var1 = "" Then
    '        command.Parameters.AddWithValue("@Var1", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var1", Var1)
    '    End If
    '    If Var2 = "" Then
    '        command.Parameters.AddWithValue("@Var2", "")
    '    Else
    '        command.Parameters.AddWithValue("@Var2", Var2)
    '    End If
    '    If emp = "" Then
    '        command.Parameters.AddWithValue("@emp", "")
    '    Else
    '        command.Parameters.AddWithValue("@emp", emp)
    '    End If
    '    If obs = "" Then
    '        command.Parameters.AddWithValue("@obs", "")
    '    Else
    '        command.Parameters.AddWithValue("@obs", obs)
    '    End If

    '    command.ExecuteNonQuery()

    '    'MsgBox("CONAVE", MsgBoxStyle.OkOnly)

    'End Sub

    Public Shared Sub elimina_producto(ByVal cod As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_eliminaProducto"
            command.Parameters.AddWithValue("@cod", cod)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error Eliminando producto", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Public Shared Sub elimina_producto_BRWME(ByVal cod As String)
    '    Try

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_eliminaProducto_BRWME_C"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.ExecuteNonQuery()

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_eliminaProducto_BRWME_D"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.ExecuteNonQuery()

    '        command.Parameters.Clear()
    '        command.CommandText = "sp_eliminaProducto_CONAVE"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error Eliminando producto", MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Public Shared Sub evalua_eliminaproducto(ByVal cod As String, ByRef n As Integer, ByRef s As String)
        'command.Parameters.Clear()
        'command.CommandText = "sp_consultaProducto_Tramo"
        'command.Parameters.AddWithValue("@cod", cod)
        'dr = command.ExecuteReader
        'If dr.Read Then
        '    n = 2
        'End If
        'dr.Close()

        command.Parameters.Clear()
        command.CommandText = "sp_consultaPedido_Producto_C2"
        command.Parameters.AddWithValue("@codPto", cod)
        dr = command.ExecuteReader
        If dr.Read Then
            n = 1
            s = "No se Puede Eliminar un Producto que se Encuentre en un Pedido de Compra"
        End If
        dr.Close()

        command.Parameters.Clear()
        command.CommandText = "sp_consultaPedido_Producto4"
        command.Parameters.AddWithValue("@codPto", cod)
        dr = command.ExecuteReader
        If dr.Read Then
            If Not dr("Facturado") Then
                n = 1
                s = "No se Puede Eliminar un Producto que se Encuentre en un Pedido de Venta"
            End If
        End If
        dr.Close()
    End Sub

    Public Shared Sub clasificacionABC_Producto(ByRef tipo As Boolean, ByRef porcA As Integer, ByRef porcB As Integer, ByRef porcC As Integer)
        Dim par As Integer = 3
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClasificacionABC"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
            tipo = dr("tipo")
            If (dr("clasificacion") = "A") Then
                porcA = dr("Porcentaje")
            ElseIf (dr("clasificacion") = "B") Then
                porcB = dr("Porcentaje")
            ElseIf (dr("clasificacion") = "C") Then
                porcC = dr("Porcentaje")
            End If
        End While
        dr.Close()
    End Sub

    Public Shared Sub ModificaClasificacionABC_Producto(ByVal porcB As Integer, ByVal porcC As Integer)
        Dim fecha As Date = Date.Now.AddYears(-1)

        Dim col As New Collection

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductosTotalDemandas"
        command.Parameters.AddWithValue("@fec", fecha)
        dr = command.ExecuteReader()
        Dim acum As Double = 0
        While dr.Read
            col.Add(dr("codigoInterno"))
            acum = acum + dr("Porcentaje")
            If (acum < porcC) Then
                col.Add("C")
            ElseIf (acum < (porcC + porcB)) Then
                col.Add("B")
            Else
                col.Add("A")
            End If
        End While
        dr.Close()

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaProductosResetClasificacion"
        command.ExecuteNonQuery()

        Dim cod As Integer = 0
        Dim cla As String

        While Not (col.Count = 0)
            cod = col.Item(1)
            cla = col.Item(2)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProductoClasificacionABC"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@cla", cla)
            command.ExecuteNonQuery()
            col.Remove(1)
            col.Remove(1)
        End While
    End Sub

    Public Shared Sub ModificaClasificacionABC_Producto2(ByVal porcB As Integer, ByVal porcC As Integer)
        Dim fecha As Date = Date.Now.AddYears(-1)

        Dim col As New Collection

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductosTotalCostos"
        dr = command.ExecuteReader()
        Dim acum As Double = 0
        While dr.Read
            col.Add(dr("codigoInterno"))
            acum = acum + Convert.ToDouble(dr("Porcentaje"))
            If (acum < porcC) Then
                col.Add("C")
            ElseIf (acum < (porcC + porcB)) Then
                col.Add("B")
            Else
                col.Add("A")
            End If
        End While
        dr.Close()

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_modificaProductosResetClasificacion"
        command.ExecuteNonQuery()

        Dim cod As String
        Dim cla As String

        While Not (col.Count = 0)
            cod = col.Item(1)
            cla = col.Item(2)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProductoClasificacionABC"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@cla", cla)
            command.ExecuteNonQuery()
            col.Remove(1)
            col.Remove(1)
        End While
    End Sub

    Public Shared Sub ModificaPrecio(ByVal Cod As String, ByVal Precio As Double, ByVal tipo As Integer)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaPrecio"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Precio", Precio)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando precio", MsgBoxStyle.Critical, "Error")


        End Try
    End Sub

    Public Shared Sub ModificaOEM_BRWME(ByVal Cod As String, ByVal OEM As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_oem_BRWME_c"
            command.Parameters.AddWithValue("@CodPro", Cod)
            command.Parameters.AddWithValue("@oem", OEM)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_oem_BRWME_D"
            command.Parameters.AddWithValue("@CodPro", Cod)
            command.Parameters.AddWithValue("@oem", OEM)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_oem_CONAVE"
            command.Parameters.AddWithValue("@CodPro", Cod)
            command.Parameters.AddWithValue("@oem", OEM)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando OEM", MsgBoxStyle.Critical, "Error")


        End Try
    End Sub

    Public Shared Sub ModificaOEM(ByVal Cod As String, ByVal OEM As String)
        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modifica_oem"
            command.Parameters.AddWithValue("@CodPro", Cod)
            command.Parameters.AddWithValue("@oem", OEM)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando OEM", MsgBoxStyle.Critical, "Error")


        End Try
    End Sub

    '------------------ MODULO ADMIN----------------

    Public Shared Sub consulta_productos_eliminados(ByVal DGV As DataGridView)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProductosEliminados"
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("codigoInterno"), dr("nombre"))

        End While
        dr.Close()
    End Sub

    Public Shared Sub restaura_producto(ByVal cod As String)
        command.Parameters.Clear()
        command.CommandText = "sp_restauraProducto"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub lv_ProductoR(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvProductoR"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("codigoInterno"), dr("nombre"), dr("Modelo"))
        End While
        dr.Close()

    End Sub

    Public Shared Sub consulta_codigosInternos(ByRef cb As ComboBoxAutoComplete)
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaCodigosInternos"
        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(dr(0))
        End While
        cb.Items.Add("Nuevo")
        dr.Close()
    End Sub

    Public Shared Sub consulta_numeracion(ByVal nombre As String, ByRef codigo As String)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_UltimoCodigoInterno"
        command.Parameters.AddWithValue("@nombre", nombre)
        dr = command.ExecuteReader()
        If dr.Read() Then
            codigo = dr(0)
        End If
        dr.Close()
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

        Catch ex As Exception

            MsgBox("Error cargando lista de cuartos", MsgBoxStyle.Critical)


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

    Public Shared Sub Llenar_DGV_por_id(ByVal Id As String, ByRef DGV As DataGridView) 'Llena el DGV de las ubicaciones por un Id dado

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaUbicacionProducto"
            command.Parameters.AddWithValue("@Codigo", Id)
            dr = command.ExecuteReader

            While dr.Read

                DGV.Rows.Add(dr("Almacén"), dr("Cuarto"), dr("Estante"), dr("Tramo"), dr("Cantidad"), dr("CodigoTramo"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando las ubicaciones", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub EliminarUbicaciones(ByVal codigo As String)

        Try

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Id", codigo)
            command.CommandText = "sp_eliminaUbicacionesProducto"
            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    Public Shared Sub InsertarUbicaciones(ByVal Producto As String, ByVal Tramo As String, ByVal Cantidad As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaUbicacionProducto"
            command.Parameters.AddWithValue("@CodigoProducto", Producto)
            command.Parameters.AddWithValue("@CodigoTramo", Tramo)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    Public Shared Sub ModificaCodigoInterno(ByVal Cod1 As String, ByVal Cod2 As String)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_ModificaCodigoProducto"
        command.Parameters.AddWithValue("@Cod1", Cod1)
        command.Parameters.AddWithValue("@Cod2", Cod2)

        command.ExecuteNonQuery()


    End Sub


    Public Shared Sub ModificaCodigoInterno_BRWME(ByVal Cod1 As String, ByVal Cod2 As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaCodigoProducto_BRWME_C"
            command.Parameters.AddWithValue("@Cod1", Cod1)
            command.Parameters.AddWithValue("@Cod2", Cod2)

            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaCodigoProducto_BRWME_D"
            command.Parameters.AddWithValue("@Cod1", Cod1)
            command.Parameters.AddWithValue("@Cod2", Cod2)

            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaCodigoProducto_CONAVE"
            command.Parameters.AddWithValue("@Cod1", Cod1)
            command.Parameters.AddWithValue("@Cod2", Cod2)

            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error Modificando codigo interno del producto", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub consulta_codigoProductoF(ByRef codF As DataGridView, ByRef CodI As String)
        Try

            codF.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_codigoProductoF"
            command.Parameters.AddWithValue("@CodI", CodI)
            dr = command.ExecuteReader()
            While dr.Read
                codF.Rows.Add(dr("Nombre"), dr("CodigoProductoF"), dr("Variante1"), dr("Variante2"), dr("CodigoFabrica"))
            End While
            dr.Close()
        Catch ex As Exception

            dr.Close()
        End Try
    End Sub

    Public Shared Sub lv_Proveedor(ByRef prov As DataGridView, ByRef CodF As String)

        Try
            prov.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_Proveedor"
            command.Parameters.AddWithValue("@CodF", CodF)
            dr = command.ExecuteReader()
            While dr.Read
                prov.Rows.Add(dr("Nombre"), dr("CodigoProductoF"), dr("Variante1"), dr("Variante2"))
            End While
            dr.Close()
        Catch ex As Exception

            dr.Close()
        End Try


    End Sub

    Public Shared Sub consulta_proveedores(ByRef cb As ComboBox)
        Dim par As Integer
        cb.Items.Clear()
        par = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedor"
        command.Parameters.AddWithValue("@cod", 0)

        dr = command.ExecuteReader()
        While dr.Read
            cb.Items.Add(New comboItem(CStr(dr("Nombre")), dr("codigoFabrica")))
        End While

        dr.Close()
    End Sub

    Public Shared Sub InsertarProveedores(ByVal CodigoProveedor As Integer, ByVal CodigoProducto As String, ByVal CodigoFabricaProducto As String, ByVal V1 As String, ByVal V2 As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaProducto_Fabrica"
            command.Parameters.AddWithValue("@codI", CodigoProducto)
            command.Parameters.AddWithValue("@codF", CodigoProveedor)
            command.Parameters.AddWithValue("@codPF", CodigoFabricaProducto)
            command.Parameters.AddWithValue("@var1", V1)
            command.Parameters.AddWithValue("@var2", V2)
            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    Public Shared Sub modificaProveedores(ByVal CodigoProducto As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProductoProveedor"
            command.Parameters.AddWithValue("@codI", CodigoProducto)

            command.ExecuteNonQuery()

        Catch ex As Exception



        End Try

    End Sub

    '------------------------------------------ VARIACION LINEAL ------------------------------------------'

    Public Shared Sub consulta_Productos_Variacion(ByRef dgv As DataGridView, ByVal marca As String, ByVal id As Integer, ByVal Tipo As Integer)

        Try
            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProductosVariacion"
            command.Parameters.AddWithValue("@Cod", marca)
            command.Parameters.AddWithValue("@Id", id)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            dr = command.ExecuteReader()

            While dr.Read
                dgv.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), dr("CantidadExistencia"), dr("CostoPromedio"), dr("PrecioVenta"), 0)
            End While

        Catch ex As Exception

            MsgBox("Error cargando lista de productos", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()
            dgv.ClearSelection()

        End Try

    End Sub

    Public Shared Sub ActualizaPreciosVariacion(ByVal CodigoProducto As String, ByVal Precio As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ActualizaPreciosVariacion"
            command.Parameters.AddWithValue("@cod", CodigoProducto)
            command.Parameters.AddWithValue("@Precio", Precio)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error actualizando precio de productos", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Public Shared Sub Table_Catalogo_Fotos(ByRef Dt As DataTable, ByRef ModelIndex As DataTable, ByRef ProductIndex As DataTable, ByRef ultpag As Integer)
        Try
            Dt.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consulta_catalogo_productos_fotos"
            dr = command.ExecuteReader()

            Dim cont As Integer = 1
            Dim pos As Integer = 1
            Dim contFilas As Integer = -1
            Dim Marca As String = ""
            Dim conta As Integer = 0
            Dim contp As Integer = 1
            Dim sw As Boolean = False

            Dim table As New DataTable

            table.Columns.Add("Column1")
            table.Columns.Add("Column2")

            Dim ColCodigo As New Collection
            Dim ColModelo As New Collection

            Dim Vacio As String = ""

            If My.Settings.Empresa = 2 Then
                Vacio = "\\Servidor\agsa\Fotos AGSA\Vacio.jpg"
            End If

            While dr.Read

                If cont = 1 Then

                    If Dt.Rows.Count > 0 Then

                        If dr("Marca").ToString.ToUpper.Trim <> Dt.Rows(contFilas).Item(2).ToString.ToUpper.Trim Then

                            If pos >= 4 And pos <= 6 Then

                                For cont1 As Integer = 0 To 2

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next

                            ElseIf pos >= 7 And pos <= 9 Then


                                For cont1 As Integer = 0 To 1

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next

                            ElseIf pos >= 10 And pos <= 12 Then

                                Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                pos = pos + 1
                                contFilas = contFilas + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                            End If

                        End If

                    End If

                    If pos < 4 Then
                        Marca = dr("Marca")
                    Else
                        Marca = ""
                    End If

                    Dt.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Marca"), dr("Modelo"), dr("DetallesModelo"), dr("Empaque"), dr("MarcaProducto"), dr("Foto"))
                    Dt.Rows(Dt.Rows.Count - 1).Item(24) = Marca
                    contFilas = contFilas + 1

                ElseIf cont = 2 Then

                    If dr("Modelo").ToString.ToUpper.Trim = Dt.Rows(contFilas).Item(3).ToString.ToUpper.Trim Then

                        Dt.Rows(Dt.Rows.Count - 1).Item(8) = dr("CodigoInterno")
                        Dt.Rows(Dt.Rows.Count - 1).Item(9) = dr("Nombre")
                        Dt.Rows(Dt.Rows.Count - 1).Item(10) = dr("Marca")
                        Dt.Rows(Dt.Rows.Count - 1).Item(11) = dr("Modelo")
                        Dt.Rows(Dt.Rows.Count - 1).Item(12) = dr("DetallesModelo")
                        Dt.Rows(Dt.Rows.Count - 1).Item(13) = dr("Empaque")
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = dr("MarcaProducto")
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = dr("Foto")

                    Else

                        If dr("Marca").ToString.ToUpper.Trim <> Dt.Rows(contFilas).Item(2).ToString.ToUpper.Trim Then

                            If pos >= 1 And pos <= 3 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                For cont1 As Integer = 0 To 2

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next


                            ElseIf pos >= 4 And pos <= 6 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                For cont1 As Integer = 0 To 1

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next

                            ElseIf pos >= 7 And pos <= 9 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                contFilas = contFilas + 1
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1


                            ElseIf pos >= 10 And pos <= 12 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                            End If

                        Else

                            Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                            pos = pos + 1
                            Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                            pos = pos + 1

                        End If

                        If pos < 4 Then
                            Marca = dr("Marca")
                        Else
                            Marca = ""
                        End If

                        Dt.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Marca"), dr("Modelo"), dr("DetallesModelo"), dr("Empaque"), dr("MarcaProducto"), dr("Foto"))
                        Dt.Rows(Dt.Rows.Count - 1).Item(24) = Marca
                        contFilas = contFilas + 1
                        cont = 1

                    End If

                ElseIf cont = 3 Then

                    If dr("Modelo").ToString.ToUpper.Trim = Dt.Rows(contFilas).Item(11).ToString.ToUpper.Trim Then

                        Dt.Rows(Dt.Rows.Count - 1).Item(16) = dr("CodigoInterno")
                        Dt.Rows(Dt.Rows.Count - 1).Item(17) = dr("Nombre")
                        Dt.Rows(Dt.Rows.Count - 1).Item(18) = dr("Marca")
                        Dt.Rows(Dt.Rows.Count - 1).Item(19) = dr("Modelo")
                        Dt.Rows(Dt.Rows.Count - 1).Item(20) = dr("DetallesModelo")
                        Dt.Rows(Dt.Rows.Count - 1).Item(21) = dr("Empaque")
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = dr("MarcaProducto")
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = dr("Foto")
                        cont = 0

                    Else

                        If dr("Marca").ToString.ToUpper.Trim <> Dt.Rows(contFilas).Item(10).ToString.ToUpper.Trim Then

                            If pos >= 1 And pos <= 3 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                For cont1 As Integer = 0 To 2

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next

                            ElseIf pos >= 4 And pos <= 6 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                For cont1 As Integer = 0 To 1

                                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                    contFilas = contFilas + 1
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                    pos = pos + 1
                                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                    pos = pos + 1

                                Next

                            ElseIf pos >= 7 And pos <= 9 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                                Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                                contFilas = contFilas + 1
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                                pos = pos + 1
                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1


                            ElseIf pos >= 10 And pos <= 12 Then

                                Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                                Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                                pos = pos + 1

                            End If

                        Else

                            Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                            pos = pos + 1

                        End If

                        If pos < 4 Then
                            Marca = dr("Marca")
                        Else
                            Marca = ""
                        End If

                        Dt.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Marca"), dr("Modelo"), dr("DetallesModelo"), dr("Empaque"), dr("MarcaProducto"), dr("Foto"))
                        Dt.Rows(Dt.Rows.Count - 1).Item(24) = Marca
                        contFilas = contFilas + 1
                        cont = 1

                    End If

                End If

                cont = cont + 1

                If pos > 12 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(24) = dr("Marca")
                    contp = contp + 1
                    sw = True

                End If

                ColCodigo.Add(dr("CodigoInterno").ToString)
                ColCodigo.Add(CInt(contp + Math.Truncate(((conta) / 12))))

                If ColModelo.Count > 0 Then

                    If dr("Modelo").ToString.ToUpper <> ColModelo.Item(ColModelo.Count - 1).ToString.ToUpper Then
                        ColModelo.Add(dr("Marca").ToString)
                        ColModelo.Add(dr("Modelo").ToString)
                        ColModelo.Add(CInt(contp + Math.Truncate(((conta) / 12))))
                    End If

                Else

                    ColModelo.Add(dr("Marca").ToString)
                    ColModelo.Add(dr("Modelo").ToString)
                    ColModelo.Add(CInt(contp + Math.Truncate(((conta) / 12))))

                End If

                ultpag = contp + Math.Truncate(((conta) / 12))

                pos = pos + 1

                If pos > 12 Then

                    pos = pos - 12
                    If sw = False Then
                        contp = contp + 1
                    End If

                End If

                sw = False

            End While

            If cont = 1 Then

                If Dt.Rows.Count > 0 Then

                    If pos >= 4 And pos <= 6 Then

                        For cont1 As Integer = 0 To 2

                            Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                            contFilas = contFilas + 1
                            pos = pos + 1
                            Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                            pos = pos + 1
                            Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                            pos = pos + 1

                        Next

                    ElseIf pos >= 7 And pos <= 9 Then


                        For cont1 As Integer = 0 To 1

                            Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                            contFilas = contFilas + 1
                            pos = pos + 1
                            Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                            pos = pos + 1
                            Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                            Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                            pos = pos + 1

                        Next

                    ElseIf pos >= 10 And pos <= 12 Then

                        Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                        pos = pos + 1
                        contFilas = contFilas + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                        pos = pos + 1

                    End If

                End If

                contFilas = contFilas + 1

            ElseIf cont = 2 Then

                If pos >= 1 And pos <= 3 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    For cont1 As Integer = 0 To 2

                        Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                        contFilas = contFilas + 1
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                        pos = pos + 1

                    Next


                ElseIf pos >= 4 And pos <= 6 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    For cont1 As Integer = 0 To 1

                        Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                        contFilas = contFilas + 1
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                        pos = pos + 1

                    Next

                ElseIf pos >= 7 And pos <= 9 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                    contFilas = contFilas + 1
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1


                ElseIf pos >= 10 And pos <= 12 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                End If

            ElseIf cont = 3 Then

                If pos >= 1 And pos <= 3 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    For cont1 As Integer = 0 To 2

                        Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                        contFilas = contFilas + 1
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                        pos = pos + 1

                    Next

                ElseIf pos >= 4 And pos <= 6 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    For cont1 As Integer = 0 To 1

                        Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                        contFilas = contFilas + 1
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                        pos = pos + 1
                        Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                        Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                        pos = pos + 1

                    Next

                ElseIf pos >= 7 And pos <= 9 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                    Dt.Rows.Add("", "", "", "", "", "", "Vacio", Vacio)
                    contFilas = contFilas + 1
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(15) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(14) = "Vacio"
                    pos = pos + 1
                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1


                ElseIf pos >= 10 And pos <= 12 Then

                    Dt.Rows(Dt.Rows.Count - 1).Item(23) = Vacio
                    Dt.Rows(Dt.Rows.Count - 1).Item(22) = "Vacio"
                    pos = pos + 1

                End If


            End If

            For index As Integer = 3 To ColModelo.Count Step 3

                If index > 3 Then

                    If ModelIndex.Rows(ModelIndex.Rows.Count - 2).Item(3).ToString.ToUpper.Trim <> ColModelo.Item(index - 2).ToString.ToUpper.Trim Then

                        ModelIndex.Rows.Add(ColModelo.Item(index - 2), 1, ColModelo.Item(index), ColModelo.Item(index - 2))
                        ModelIndex.Rows.Add(ColModelo.Item(index - 1), 2, ColModelo.Item(index), ColModelo.Item(index - 2))

                    Else

                        ModelIndex.Rows.Add(ColModelo.Item(index - 1), 2, ColModelo.Item(index), ColModelo.Item(index - 2))

                    End If


                Else

                    ModelIndex.Rows.Add(ColModelo.Item(index - 2), 1, ColModelo.Item(index), ColModelo.Item(index - 2))
                    ModelIndex.Rows.Add(ColModelo.Item(index - 1), 2, ColModelo.Item(index), ColModelo.Item(index - 2))

                End If


            Next

            For index As Integer = 2 To ColCodigo.Count Step 2

                table.Rows.Add(ColCodigo.Item(index - 1), ColCodigo.Item(index))

            Next

            Dim arrRows() As DataRow
            arrRows = table.Select("", "Column1 ASC")


            For i As Integer = 0 To arrRows.Length - 1

                ProductIndex.Rows.Add(arrRows(i).ItemArray(0).ToString, arrRows(i).ItemArray(1).ToString)

            Next

        Catch ex As Exception

            MsgBox("Error cargando catálogo", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    '------------------------------------------ MOVIMIENTO PRODUCTOS ------------------------------------------'

    Public Shared Sub consulta_Movimientos_Productos(ByRef dgv As DataGridView, ByVal Tipo As Boolean, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Meses As Integer, ByVal hasta As Integer, ByRef total As String, ByRef totalbs As String)

        Try

            Dim cont As Integer = 0
            Dim bs As Double = 0

            dgv.Rows.Clear()
            command.Parameters.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_movimiento_Productos"
            command.Parameters.AddWithValue("@meses", Meses)
            command.Parameters.AddWithValue("@FechaDesde", FechaDesde)
            command.Parameters.AddWithValue("@FechaHasta", FechaHasta)
            command.Parameters.AddWithValue("@Hasta", hasta)

            If Tipo = True Then
                command.Parameters.AddWithValue("@Tipo", 1)
            Else
                command.Parameters.AddWithValue("@Tipo", 0)
            End If

            dr = command.ExecuteReader()

            While dr.Read
                dgv.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Marca"), dr("Modelo"), dr("Existencia"), dr("PrecioVenta"), dr("Vendidos"), dr("Promedio"), dr("Meses"), dr("Bs"), dr("Compras"), dr("Compras2"))
                cont = cont + 1
                bs = bs + dr("Bs")
            End While

            total = cont.ToString
            totalbs = Format(bs, "#,##0.00")

        Catch ex As Exception

            MsgBox("Error cargando lista de productos", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()
            dgv.ClearSelection()

        End Try

    End Sub

End Class
