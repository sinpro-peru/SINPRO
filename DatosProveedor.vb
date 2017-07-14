Imports System.Data.SqlClient
Public Class DatosProveedor
    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader
    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub
    Public Shared Sub lv_Proveedor(ByRef lv As ListView, ByVal s As String, ByVal val As Integer)
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvProveedor"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            Dim c As Integer = dr("codigoFabrica")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("nombre"))
            lv.Items.Add(i)
        End While
        dr.Close()
    End Sub
    Public Shared Sub consulta_proveedores(ByVal lv As ListView, ByRef cant As Integer)
        Dim par As Integer
        par = 0
        lv.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedor"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            cant = cant + 1
            Dim c As Integer = dr("codigoFabrica")
            Dim i As New ListViewItem(c)
            i.SubItems.Add(dr("nombre"))
            lv.Items.Add(i)
        End While

        dr.Close()
    End Sub

    Public Shared Sub consulta_proveedores(ByRef DGV As DataGridView)
        Dim par As Integer
        par = 0
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedor"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            DGV.Rows.Add(dr("codigoFabrica"), dr("Nombre"))
        End While

        dr.Close()
    End Sub

    Public Shared Sub consulta_PreferenciasDeproveedores(ByRef DGV As DataGridView, ByVal idF As Integer)

        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPreferenciasDeProveedor"
        command.Parameters.AddWithValue("@codF", idF)
        dr = command.ExecuteReader()

        Dim cont As Integer = 0
        Dim ant As String = ""
        Dim ant2 As String = ""

        While dr.Read

            If cont = 0 Then

                DGV.Rows.Add(dr("CodigoArancelario"), dr("Nombre"), dr("Valor"), dr("Productos"), dr("CodigoPreferencia"))

                ant = DGV.Rows(cont).Cells(0).Value.ToString
                ant2 = DGV.Rows(cont).Cells(1).Value.ToString
                cont = cont + 1

            Else

                If ant = dr("CodigoArancelario").ToString And ant2 = dr("Nombre").ToString Then

                    DGV.Rows(cont - 1).Cells(3).Value = dr("Productos").ToString & " / " & DGV.Rows(cont - 1).Cells(3).Value.ToString

                Else

                    DGV.Rows.Add(dr("CodigoArancelario"), dr("Nombre"), dr("Valor"), dr("Productos"), dr("CodigoPreferencia"))

                    ant = DGV.Rows(cont).Cells(0).Value.ToString
                    ant2 = DGV.Rows(cont).Cells(1).Value.ToString
                    cont = cont + 1

                End If

            End If

        End While

        dr.Close()
        DGV.ClearSelection()
    End Sub

    Public Shared Sub consulta_Preferencias_proveedores(ByRef DGV As DataGridView, ByVal Idf As Integer)
        Dim par As Integer
        par = 0
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consulta_Preferencias_Prov"
        command.Parameters.AddWithValue("@codF", Idf)
        dr = command.ExecuteReader()

        Dim cont As Integer = 0
        Dim ant As String = ""
        Dim ant2 As String = ""

        While dr.Read

            If cont = 0 Then

                DGV.Rows.Add(dr("CodigoArancelario"), dr("Nombre"), dr("Valor"), dr("Productos"), dr("CodigoPreferencia"))

                ant = DGV.Rows(cont).Cells(0).Value.ToString
                ant2 = DGV.Rows(cont).Cells(1).Value.ToString
                cont = cont + 1

            Else

                If ant = dr("CodigoArancelario").ToString And ant2 = dr("Nombre").ToString Then

                    DGV.Rows(cont - 1).Cells(3).Value = dr("Productos").ToString & " / " & DGV.Rows(cont - 1).Cells(3).Value.ToString

                Else

                    DGV.Rows.Add(dr("CodigoArancelario"), dr("Nombre"), dr("Valor"), dr("Productos"), dr("CodigoPreferencia"))

                    ant = DGV.Rows(cont).Cells(0).Value.ToString
                    ant2 = DGV.Rows(cont).Cells(1).Value.ToString
                    cont = cont + 1

                End If

            End If

        End While

        dr.Close()
        DGV.ClearSelection()

    End Sub
    Public Shared Sub elimina_Preferencias_proveedores(ByVal Idf As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_elimina_Preferencias_Prov"
            command.Parameters.AddWithValue("@codF", Idf)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando las preferencias anteriores del proveedor", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Public Shared Sub inserta_Preferencias_proveedores(ByVal Idf As Integer, ByVal IdPref As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_inserta_Preferencias_Prov"
            command.Parameters.AddWithValue("@codF", Idf)
            command.Parameters.AddWithValue("@codPref", IdPref)
            'command.Parameters.AddWithValue("@Imp", 0)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando las preferencias del proveedor", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Public Shared Sub consulta_proveedor(ByVal cod As Integer, ByRef c As String, ByRef nom As String, ByRef tel1 As String, ByRef tel2 As String, ByRef fax As String, ByRef email As String, ByRef rep As String, ByRef dir As String, ByRef cla As String, ByRef obs As String, ByRef web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByRef tc2 As String, ByRef cb As ComboBox)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedor"
        command.Parameters.AddWithValue("@cod", cod)
        dr = command.ExecuteReader()
        dr.Read()
        c = dr("codigoFabrica")
        nom = dr("nombre")
        tel1 = CStr(dr("telefono1"))

        If dr("telefono2").GetType.ToString = "System.DBNull" Then
            tel2 = ""
        Else
            tel2 = CStr(dr("telefono2"))
        End If
        If dr("fax").GetType.ToString = "System.DBNull" Then
            fax = ""
        Else
            fax = CStr(dr("fax"))
        End If
        cb.Text = dr("Moneda").ToString
        If dr("email").GetType.ToString = "System.DBNull" Then
            email = ""
        Else
            email = dr("email")
        End If
        If dr("representanteLegal").GetType.ToString = "System.DBNull" Then
            rep = ""
        Else
            rep = dr("representanteLegal")
        End If
        If dr("direccion").GetType.ToString = "System.DBNull" Then
            dir = ""
        Else
            dir = dr("direccion")
        End If
        If dr("clasificacionABC").GetType.ToString = "System.DBNull" Then
            cla = ""
        Else
            cla = dr("clasificacionABC")
        End If
        If dr("Observacion").GetType.ToString = "System.DBNull" Then
            obs = ""
        Else
            obs = dr("Observacion")
        End If
        If dr("PaginaWeb").GetType.ToString = "System.DBNull" Then
            web = ""
        Else
            web = dr("PaginaWeb")
        End If
        If dr("PersonaContacto").GetType.ToString = "System.DBNull" Then
            pc = ""
        Else
            pc = dr("PersonaContacto")
        End If
        If dr("TelefonoContacto").GetType.ToString = "System.DBNull" Then
            tc = ""
        Else
            tc = dr("TelefonoContacto")
        End If
        If dr("PersonaContacto2").GetType.ToString = "System.DBNull" Then
            pc2 = ""
        Else
            pc2 = dr("PersonaContacto2")
        End If
        If dr("TelefonoContacto2").GetType.ToString = "System.DBNull" Then
            tc2 = ""
        Else
            tc2 = dr("TelefonoContacto2")
        End If

        dr.Close()
    End Sub
    Public Shared Sub inserta_proveedor(ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)
        command.Parameters.Clear()
        command.CommandText = "sp_insertaProveedor"
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@tel1", tel1)
        command.Parameters.AddWithValue("@Mon", mon)

        If tel2 = "" Then
            command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tel2", tel2)
        End If
        If fax = "" Then
            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@fax", fax)
        End If

        If email = "" Then
            command.Parameters.AddWithValue("@email", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@email", email)
        End If
        If rep = "" Then
            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@rep", rep)
        End If
        If dir = "" Then
            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@dir", dir)
        End If
        If ABC = "" Then
            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@ABC", ABC)
        End If
        If Web = "" Then
            command.Parameters.AddWithValue("@Web", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@Web", Web)
        End If
        If Obs = "" Then
            command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@Obs", Obs)
        End If
        If pc = "" Then
            command.Parameters.AddWithValue("@pc", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@pc", pc)
        End If
        If pc2 = "" Then
            command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@pc2", pc2)
        End If
        If tc = "" Then
            command.Parameters.AddWithValue("@tc", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tc", tc)
        End If
        If tc2 = "" Then
            command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tc2", tc2)
        End If
        command.ExecuteNonQuery()
    End Sub


    'Public Shared Sub inserta_proveedor_COMER(ByVal cod As Integer, ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_insertaProveedor_COMER"
    '    command.Parameters.AddWithValue("@id", cod)
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@Mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If
    '    command.ExecuteNonQuery()
    'End Sub

    'Public Shared Sub inserta_proveedor_DIST(ByVal cod As Integer, ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_insertaProveedor_DIST"
    '    command.Parameters.AddWithValue("@id", cod)
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@Mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If
    '    command.ExecuteNonQuery()
    'End Sub

    'Public Shared Sub inserta_proveedor_CONAVE(ByVal cod As Integer, ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)
    '    command.Parameters.Clear()
    '    command.CommandText = "sp_insertaProveedor_CONAVE"
    '    command.Parameters.AddWithValue("@id", cod)
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@Mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If
    '    command.ExecuteNonQuery()
    'End Sub

    Public Shared Sub identidad_Proveedor(ByRef tb As TextBox)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_identidadProveedor"
        dr = command.ExecuteReader
        dr.Read()
        tb.Text = dr("Expr1") + 1
        dr.Close()
    End Sub

    Public Shared Sub modifica_proveedor(ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal cod As Integer, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)

        command.Parameters.Clear()
        command.CommandText = "sp_modificaProveedor"
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@tel1", tel1)
        command.Parameters.AddWithValue("@COD", cod)
        command.Parameters.AddWithValue("@mon", mon)

        If tel2 = "" Then
            command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tel2", tel2)
        End If
        If fax = "" Then
            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@fax", fax)
        End If

        If email = "" Then
            command.Parameters.AddWithValue("@email", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@email", email)
        End If
        If rep = "" Then
            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@rep", rep)
        End If
        If dir = "" Then
            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@dir", dir)
        End If
        If ABC = "" Then
            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@ABC", ABC)
        End If
        If Web = "" Then
            command.Parameters.AddWithValue("@Web", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@Web", Web)
        End If
        If Obs = "" Then
            command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@Obs", Obs)
        End If
        If pc = "" Then
            command.Parameters.AddWithValue("@pc", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@pc", pc)
        End If
        If pc2 = "" Then
            command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@pc2", pc2)
        End If
        If tc = "" Then
            command.Parameters.AddWithValue("@tc", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tc", tc)
        End If
        If tc2 = "" Then
            command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
        Else
            command.Parameters.AddWithValue("@tc2", tc2)
        End If

        command.ExecuteNonQuery()
        MsgBox("El Proveedor Ha Sido Modificado Exitosamente")

    End Sub


    'Public Shared Sub modifica_proveedor_COMER(ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal cod As Integer, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProveedor_COMER"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@COD", cod)
    '    command.Parameters.AddWithValue("@mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If

    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub modifica_proveedor_DIST(ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal cod As Integer, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProveedor_DIST"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@COD", cod)
    '    command.Parameters.AddWithValue("@mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If

    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub modifica_proveedor_CONAVE(ByVal nom As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal email As String, ByVal rep As String, ByVal dir As String, ByVal ABC As String, ByVal cod As Integer, ByVal Obs As String, ByVal Web As String, ByRef pc As String, ByRef tc As String, ByRef pc2 As String, ByVal tc2 As String, ByVal mon As String)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_modificaProveedor_CONAVE"
    '    command.Parameters.AddWithValue("@nom", nom)
    '    command.Parameters.AddWithValue("@tel1", tel1)
    '    command.Parameters.AddWithValue("@COD", cod)
    '    command.Parameters.AddWithValue("@mon", mon)

    '    If tel2 = "" Then
    '        command.Parameters.AddWithValue("@tel2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tel2", tel2)
    '    End If
    '    If fax = "" Then
    '        command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@fax", fax)
    '    End If

    '    If email = "" Then
    '        command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@email", email)
    '    End If
    '    If rep = "" Then
    '        command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@rep", rep)
    '    End If
    '    If dir = "" Then
    '        command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@dir", dir)
    '    End If
    '    If ABC = "" Then
    '        command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@ABC", ABC)
    '    End If
    '    If Web = "" Then
    '        command.Parameters.AddWithValue("@Web", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Web", Web)
    '    End If
    '    If Obs = "" Then
    '        command.Parameters.AddWithValue("@Obs", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@Obs", Obs)
    '    End If
    '    If pc = "" Then
    '        command.Parameters.AddWithValue("@pc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc", pc)
    '    End If
    '    If pc2 = "" Then
    '        command.Parameters.AddWithValue("@pc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@pc2", pc2)
    '    End If
    '    If tc = "" Then
    '        command.Parameters.AddWithValue("@tc", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc", tc)
    '    End If
    '    If tc2 = "" Then
    '        command.Parameters.AddWithValue("@tc2", System.DBNull.Value)
    '    Else
    '        command.Parameters.AddWithValue("@tc2", tc2)
    '    End If

    '    command.ExecuteNonQuery()

    'End Sub

    Public Shared Sub elimina_proveedor(ByVal cod As Integer)

        'Dim col As New Collection
        'Dim it As Object

        command.Parameters.Clear()
        command.CommandText = "sp_eliminaProveedor"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()

        'command.Parameters.Clear()
        'command.CommandText = "sp_ConsultaPedidosProveedor"
        'command.Parameters.AddWithValue("@cod", cod)
        'dr = command.ExecuteReader
        'While dr.Read
        '    Dim n As Integer = CInt(dr("codigoPedido"))
        '    col.Add(n)
        'End While
        'dr.Close()

        'For Each it In col
        '    Dim c As Integer = it
        '    command.Parameters.Clear()
        '    command.CommandText = "sp_eliminaPedido_Producto_C2"
        '    command.Parameters.AddWithValue("@codP", c)
        '    command.ExecuteNonQuery()
        'Next

        'command.Parameters.Clear()
        'command.CommandText = "sp_eliminaPedidosProveedor"
        'command.Parameters.AddWithValue("@cod", cod)
        'command.ExecuteNonQuery()

    End Sub


    'Public Shared Sub elimina_proveedor_COMER(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaProveedor_COMER"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub elimina_proveedor_DIST(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaProveedor_DIST"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub elimina_proveedor_CONAVE(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaProveedor_CONAVE"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    Public Shared Sub clasificacionABC_Proveedor(ByRef porcA As Integer, ByRef porcB As Integer, ByRef porcC As Integer)
        Dim par As Integer = 2
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClasificacionABC"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()
        While dr.Read
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
    Public Shared Sub ModificaClasificacionABC_Proveedor(ByVal porcB As Integer, ByVal porcC As Integer)
        Dim fecha As Date = Date.Now.AddYears(-1)
        Dim totalC As Double = 0
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_metodoTotalCompras"
        command.Parameters.AddWithValue("@fec", fecha)
        dr = command.ExecuteReader()
        While dr.Read
            totalC = totalC + dr("total")
        End While
        dr.Close()

        Dim col As New Collection

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedoresTotalCompras"
        command.Parameters.AddWithValue("@total", totalC)
        command.Parameters.AddWithValue("@fec", fecha)
        dr = command.ExecuteReader()
        Dim acum As Double = 0
        While dr.Read
            col.Add(dr("codigoProveedor"))
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
        command.CommandText = "sp_modificaProveedoresResetClasificacion"
        command.ExecuteNonQuery()

        Dim cod As Integer = 0
        Dim cla As String

        While Not (col.Count = 0)
            cod = col.Item(1)
            cla = col.Item(2)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaProveedorClasificacionABC"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@cla", cla)
            command.ExecuteNonQuery()
            col.Remove(1)
            col.Remove(1)
        End While
    End Sub

    Public Shared Sub lv_Proveedor(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvProveedor"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("codigoFabrica"), dr("Nombre"))
        End While
        dr.Close()
    End Sub

    '------------------ MODULO ADMIN----------------


    Public Shared Sub consulta_proveedores_eliminados(ByVal DGV As DataGridView)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaProveedoresEliminados"
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("codigoFabrica"), dr("nombre"))
        End While
        dr.Close()



    End Sub



    Public Shared Sub restaura_proveedor(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_restauraProveedor"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub



    Public Shared Sub lv_ProveedorR(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvProveedorR"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        dr = command.ExecuteReader()
        While dr.Read
            DGV.Rows.Add(dr("codigoFabrica"), dr("nombre"))
        End While
        dr.Close()
    End Sub


    Public Shared Sub Llenar_DGV(ByVal Id As String, ByVal DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 1)
            command.Parameters.AddWithValue("@IdF", Id)
            command.Parameters.AddWithValue("@Id", "")
            dr = command.ExecuteReader
            Dim anterior As String = ""
            Dim CodFab As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
                End If



                If anterior = dr("CodigoInterno") Then


                    Dim celdac As New DataGridViewComboBoxCell
                    Dim celdat As New DataGridViewTextBoxCell
                    Dim celdaN As New DataGridViewTextBoxCell
                    Dim celdav1 As New DataGridViewTextBoxCell
                    Dim celdav2 As New DataGridViewTextBoxCell
                    Dim celdaCF As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow

                    celdat.Value = dr("CodigoInterno")
                    fila.Cells.Add(celdat)
                    celdaN.Value = dr("Nombre")
                    fila.Cells.Add(celdaN)
                    celdac.Items.Add(DGV.Rows(DGV.Rows.Count - 1).Cells(2).Value)
                    celdac.Items.Add(dr("Modelo"))
                    celdac.Value = DGV.Rows(DGV.Rows.Count - 1).Cells(2).Value
                    celdac.ReadOnly = False
                    fila.Cells.Add(celdac)
                    celdaCF.Value = CodFab
                    fila.Cells.Add(celdaCF)
                    DGV.Rows.RemoveAt(DGV.Rows.Count - 1)
                    If dr("Variante1").GetType.ToString = "System.DBNull" Then
                        celdav1.Value = ""
                    Else
                        celdav1.Value = dr("Variante1")
                    End If
                    fila.Cells.Add(celdav1)
                    If dr("Variante2").GetType.ToString = "System.DBNull" Then
                        celdav2.Value = ""
                    Else
                        celdav2.Value = dr("Variante2")
                    End If
                    fila.Cells.Add(celdav2)
                    DGV.Rows.Add(fila)

                Else

                    Dim var1 As String = ""
                    Dim var2 As String = ""
                    If dr("Variante1").GetType.ToString = "System.DBNull" Then
                        var1 = ""
                    Else
                        var1 = dr("Variante1")
                    End If
                    If dr("Variante2").GetType.ToString = "System.DBNull" Then
                        var2 = ""
                    Else
                        var2 = dr("Variante2")
                    End If
                    DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, var1, var2)
                    DGV.Rows(DGV.RowCount - 1).Cells(2).ReadOnly = True

                End If

                anterior = dr("CodigoInterno")

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub


    Public Shared Sub InsertarCodigoFabrica(ByVal Codigo1 As String, ByVal Codigo2 As String, ByVal CodigoF As Integer, ByVal CodigoPF As String, ByVal var1 As String, ByVal var2 As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto_Fabrica3"
            command.Parameters.AddWithValue("@codI", Codigo1)
            command.Parameters.AddWithValue("@codF", CodigoF)

            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaProducto_Fabrica"
                command.Parameters.AddWithValue("@codI", Codigo1)
                command.Parameters.AddWithValue("@codI2", Codigo2)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()

            Else

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaProducto_Fabrica"
                command.Parameters.AddWithValue("@codi", Codigo1)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()

            End If

        Catch ex As Exception

            MsgBox("Error registrando el código de fábrica", MsgBoxStyle.Critical)


        End Try



    End Sub

    Public Shared Sub InsertarCodigoFabrica_CONAVE(ByVal Codigo1 As String, ByVal Codigo2 As String, ByVal CodigoF As Integer, ByVal CodigoPF As String, ByVal var1 As String, ByVal var2 As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto_Fabrica3_CONAVE"
            command.Parameters.AddWithValue("@codI", Codigo1)
            command.Parameters.AddWithValue("@codF", CodigoF)

            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaProducto_Fabrica_CONAVE"
                command.Parameters.AddWithValue("@codI", Codigo1)
                command.Parameters.AddWithValue("@codI2", Codigo2)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()               

            Else

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaProducto_Fabrica_CONAVE"
                command.Parameters.AddWithValue("@codi", Codigo1)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()

            End If


        Catch ex As Exception

            MsgBox("Error registrando el código de fábrica", MsgBoxStyle.Critical)


        End Try



    End Sub

    Public Shared Sub InsertarCodigoFabrica_DIST(ByVal Codigo1 As String, ByVal Codigo2 As String, ByVal CodigoF As Integer, ByVal CodigoPF As String, ByVal var1 As String, ByVal var2 As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto_Fabrica3_DIST"
            command.Parameters.AddWithValue("@codI", Codigo1)
            command.Parameters.AddWithValue("@codF", CodigoF)

            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaProducto_Fabrica_DIST"
                command.Parameters.AddWithValue("@codI", Codigo1)
                command.Parameters.AddWithValue("@codI2", Codigo2)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()

            Else

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaProducto_Fabrica_DIST"
                command.Parameters.AddWithValue("@codi", Codigo1)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", var1)
                command.Parameters.AddWithValue("@var2", var2)
                command.ExecuteNonQuery()

            End If


        Catch ex As Exception

            MsgBox("Error registrando el código de fábrica", MsgBoxStyle.Critical)


        End Try



    End Sub


    Public Shared Sub InsertarCodigoFabrica2(ByVal Codigo1 As String, ByVal CodigoF As Integer, ByVal CodigoPF As String, ByVal tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaProducto_Fabrica4"
            command.Parameters.AddWithValue("@codI", Codigo1)
            command.Parameters.AddWithValue("@codF", CodigoF)
            command.Parameters.AddWithValue("@tipo", tipo)

            dr = command.ExecuteReader

            If dr.HasRows Then

                dr.Close()

                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_modificaProducto_Fabrica3"
                command.Parameters.AddWithValue("@codI", Codigo1)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@tipo", tipo)
                command.ExecuteNonQuery()
                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo moficado satisfactoriamente", ToolTipIcon.Info)

            Else

                dr.Close()
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaProducto_Fabrica2"
                command.Parameters.AddWithValue("@codi", Codigo1)
                command.Parameters.AddWithValue("@codF", CodigoF)
                command.Parameters.AddWithValue("@codPF", CodigoPF)
                command.Parameters.AddWithValue("@var1", "")
                command.Parameters.AddWithValue("@Var2", "")
                command.Parameters.AddWithValue("@tipo", tipo)
                command.ExecuteNonQuery()
                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo registrado satisfactoriamente", ToolTipIcon.Info)

            End If


        Catch ex As Exception

            MsgBox("Error registrando/modificando el código de fábrica", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminarCodigoFabrica(ByVal CodigoI As String, ByVal CodigoF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox("Error eliminando el código de fábrica", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminarCodigoFabrica_CONAVE(ByVal CodigoI As String, ByVal CodigoF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica_CONAVE"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando el código de fábrica", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminarCodigoFabrica_DIST(ByVal CodigoI As String, ByVal CodigoF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica_BRWME_D"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error eliminando el código de fábrica", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub EliminarCodigoFabrica_BRWME(ByVal CodigoI As String, ByVal CodigoF As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica_BRWME_C"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica_BRWME_D"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaProducto_Fabrica_CONAVE"
            command.Parameters.AddWithValue("CodI", CodigoI)
            command.Parameters.AddWithValue("CodF", CodigoF)
            command.ExecuteNonQuery()

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Código Fábrica Eliminado", ToolTipIcon.Info)

        Catch ex As Exception

            MsgBox("Error eliminando el código de fábrica", MsgBoxStyle.Critical)


        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Productos_Por_Proveedor(ByVal Id As String, ByRef DGV As DataGridView)

        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 2)
            command.Parameters.AddWithValue("@IdF", CInt(Id))
            command.Parameters.AddWithValue("@Id", 0)
            dr = command.ExecuteReader
            Dim CodFab As String = ""
            Dim Var1 As String = ""
            Dim Var2 As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
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
                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, Var1, Var2)

            End While

            dr.Close()

            Frm_Proveedores.DGV_Productos_Inventario2(DGV)

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Like1(ByVal Id As String, ByVal IdF As Integer, ByVal DGV As DataGridView)


        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@IdF", IdF)
            command.Parameters.AddWithValue("@Tipo", 3)
            dr = command.ExecuteReader
            Dim CodFab As String = ""
            Dim Var1 As String = ""
            Dim Var2 As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
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
                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, Var1, Var2)

            End While

            dr.Close()

            Frm_Proveedores.DGV_Productos_Inventario2(DGV)

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Like2(ByVal Id As String, ByVal IdF As Integer, ByVal DGV As DataGridView)


        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Tipo", 4)
            command.Parameters.AddWithValue("@IdF", IdF)
            command.Parameters.AddWithValue("@Id", Id)
            dr = command.ExecuteReader
            Dim CodFab As String = ""
            Dim Var1 As String = ""
            Dim Var2 As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
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
                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, Var1, Var2)

            End While

            dr.Close()

            Frm_Proveedores.DGV_Productos_Inventario2(DGV)

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try
    End Sub

    Public Shared Sub Llenar_DGV_Like3(ByVal Id As String, ByVal IdF As Integer, ByVal DGV As DataGridView)


        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@IdF", IdF)
            command.Parameters.AddWithValue("@Tipo", 5)
            dr = command.ExecuteReader
            Dim CodFab As String = ""
            Dim Var1 As String = ""
            Dim Var2 As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
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
                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, Var1, Var2)

            End While

            dr.Close()

            Frm_Proveedores.DGV_Productos_Inventario2(DGV)

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Llenar_DGV_Like4(ByVal Id As String, ByVal IdF As Integer, ByVal DGV As DataGridView)


        Try
            DGV.Rows.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_consultaProductosConCodigoFabrica"
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@IdF", IdF)
            command.Parameters.AddWithValue("@Tipo", 6)
            dr = command.ExecuteReader
            Dim CodFab As String = ""
            Dim Var1 As String = ""
            Dim Var2 As String = ""

            While dr.Read

                If dr("CodigoProductoF").GetType.ToString = "System.DBNull" Then

                    CodFab = ""

                Else
                    CodFab = dr("CodigoProductoF")
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
                DGV.Rows.Add(dr("CodigoInterno"), dr("Nombre"), dr("Modelo"), CodFab, Var1, Var2)

            End While

            dr.Close()

            Frm_Proveedores.DGV_Productos_Inventario2(DGV)

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try
    End Sub


    Public Shared Sub Consulta_preferencia(ByRef cb As ComboBox)


        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaPrefArancelaria1"
        dr = command.ExecuteReader()

        While dr.Read

            cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoPreferencia")))

        End While

        dr.Close()

    End Sub

    Public Shared Sub consultaPreferenciaProveedor(ByRef cb As ComboBox, ByVal cod As Integer)

        Try

            Dim vacio As Boolean = False
            cb.Text = ""
            command.Parameters.Clear()
            command.CommandText = "sp_consultaPrefArancelariaProv"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader

            While dr.Read

                If Not dr("Nombre").GetType.ToString = "System.DBNull" Then
                    'cb.Items.Add(New comboItem(dr("Nombre"), dr("CodigoPreferencia")))
                    cb.Text = dr("Nombre")
                Else
                    vacio = True
                End If

            End While

            dr.Close()

            If vacio Then
                Consulta_preferencia(cb)
                cb.ResetText()
            End If

        Catch ex As Exception

            MsgBox("Error cargando moneda del proveedor", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub

End Class
