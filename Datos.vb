Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class Datos

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub lv_Cliente(ByRef lv As DataGridView, ByVal s As String, ByVal val As Integer, ByVal vend As Integer)
        lv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_lvcliente"
        command.Parameters.AddWithValue("@nom", s)
        command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
        command.Parameters.AddWithValue("@vend", vend)
        dr = command.ExecuteReader()
        While dr.Read

            lv.Rows.Add(dr("codigoCliente"), dr("razonSocial"), dr("contEspecial"))

        End While
        dr.Close()
    End Sub

    Public Shared Sub consultaLogo(ByRef logo As PictureBox)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaLogo"
            dr = command.ExecuteReader()
            While dr.Read

                Dim b() As Byte = dr("Logo")
                Dim Stre As New MemoryStream(b)

                logo.Image = Image.FromStream(Stre)

            End While
        Catch ex As Exception

        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consultaDireccion(ByRef Dir As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaLogo"
            dr = command.ExecuteReader()
            While dr.Read

                Dir = dr("DireccionTexto")

            End While

        Catch ex As Exception
            MsgBox("Error consultando dirección", MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consultaDiasResaltar(ByRef dias As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaDiasResaltar"
            dr = command.ExecuteReader()

            If dr.HasRows Then

                While dr.Read

                    If dr("dias").GetType.ToString = "System.DBNull" Then
                        dias = 0
                    Else
                        dias = dr("Dias")
                    End If

                End While

            Else

                dias = 0

            End If

        Catch ex As Exception
            MsgBox("Error consultando días para resaltar en reporte", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub

    Public Shared Sub ModificaDiasResaltar(ByVal dias As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaDiasResaltar"
            command.Parameters.AddWithValue("@dias", CInt(dias))
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error modificando días para resaltar en reporte", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub

    Public Shared Sub ModificaLogo(ByVal Logo As String, ByVal Dir As String, ByVal DirTxt As String, ByVal Tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaDatosLogo"
            command.Parameters.AddWithValue("@Logo", Logo)
            command.Parameters.AddWithValue("@Dir", Dir)
            command.Parameters.AddWithValue("@DirTxt", DirTxt)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error modificando datos", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try
    End Sub


    Public Shared Function ExisteRif(ByVal rif As String) As Boolean

        Dim existe As Boolean = False

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaRif"
            command.Parameters.AddWithValue("@rif", rif)
            dr = command.ExecuteReader()
            While dr.Read

                existe = True

            End While
            dr.Close()

        Catch ex As Exception
            MsgBox("Error comprobando rif", MsgBoxStyle.Critical, "Error")

        End Try

        Return existe

    End Function

    Public Shared Sub Autoriza_Desautoriza_Cliente(ByVal cod As Integer, ByVal auto As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_autorizaCliente"
            command.Parameters.AddWithValue("@codCli", cod)
            command.Parameters.AddWithValue("@auto", auto)
            command.ExecuteNonQuery()

            If auto Then
                MsgBox("Cliente autorizado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
            Else
                MsgBox("Cliente desautorizado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
            End If

        Catch ex As Exception

            MsgBox("Error durante proceso de autorización/desautorizacón", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub


    'Public Shared Sub Autoriza_Desautoriza_Cliente_dist(ByVal cod As Integer, ByVal auto As Boolean)

    '    Try

    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_autorizaCliente_dist"
    '        command.Parameters.AddWithValue("@codCli", cod)
    '        command.Parameters.AddWithValue("@auto", auto)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception

    '        MsgBox("Error durante proceso de autorización/desautorizacón", MsgBoxStyle.Critical, "Error")


    '    End Try

    'End Sub

    'Public Shared Sub Autoriza_Desautoriza_Cliente_comer(ByVal cod As Integer, ByVal auto As Boolean)

    '    Try

    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_autorizaCliente_comer"
    '        command.Parameters.AddWithValue("@codCli", cod)
    '        command.Parameters.AddWithValue("@auto", auto)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception

    '        MsgBox("Error durante proceso de autorización/desautorizacón", MsgBoxStyle.Critical, "Error")


    '    End Try

    'End Sub

    'Public Shared Sub Autoriza_Desautoriza_Cliente_CONAVE(ByVal cod As Integer, ByVal auto As Boolean)

    '    Try

    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_autorizaCliente_CONAVE"
    '        command.Parameters.AddWithValue("@codCli", cod)
    '        command.Parameters.AddWithValue("@auto", auto)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception

    '        MsgBox("Error durante proceso de autorización/desautorizacón", MsgBoxStyle.Critical, "Error")


    '    End Try

    'End Sub


    Public Shared Sub consulta_Monedas(ByRef lv As DataGridView)
        lv.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaMoneda"
        dr = command.ExecuteReader()
        While dr.Read

            lv.Rows.Add(dr("Moneda"))

        End While

        dr.Close()
    End Sub
    Public Shared Sub Inserta_Moneda(ByVal mon As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaMoneda"
            command.Parameters.AddWithValue("@Mon", mon)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando moneda", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub modifica_Moneda(ByVal mon As String, ByVal ant As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaMoneda"
            command.Parameters.AddWithValue("@Mon", mon)
            command.Parameters.AddWithValue("@Ant", ant)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando moneda", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Sub elimina_Moneda(ByVal mon As String)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaMoneda"
            command.Parameters.AddWithValue("@Mon", mon)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando moneda", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub




    Public Sub vacio(ByRef t As TextBox, ByRef sw As Boolean)
        If t.Text = "" Then
            sw = True
        End If
    End Sub


    Public Shared Sub inserta_cliente(ByVal cod As Integer, ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal fletePago As Boolean, ByVal direccionE As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_insertaCliente"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@razS", razS)
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@fecR", fecR)
            command.Parameters.AddWithValue("@codV", codV)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@est", est)
            command.Parameters.AddWithValue("@aut", aut)
            command.Parameters.AddWithValue("@contE", contE)
            command.Parameters.AddWithValue("@User", user)
            command.Parameters.AddWithValue("@Pass", pass)
            command.Parameters.AddWithValue("@dirE", direccionE)
            command.Parameters.AddWithValue("@FletePago", fletePago)

            If lim = "" Then
                command.Parameters.AddWithValue("@lim", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@lim", CDbl(lim))
            End If

            If ger = "" Then
                command.Parameters.AddWithValue("@ger", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@ger", ger)
            End If
            If dir = "" Then
                command.Parameters.AddWithValue("@dir", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@dir", dir)
            End If
            If telf1 = "" Then
                command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telf1", telf1)
            End If
            If telf2 = "" Then
                command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telf2", telf2)
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
            If ABC = "" Then
                command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@ABC", ABC)
            End If
            If rep = "" Then
                command.Parameters.AddWithValue("@rep", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@rep", rep)
            End If
            If cel = "" Then
                command.Parameters.AddWithValue("@cel", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@cel", cel)
            End If
            If obs = "" Then
                command.Parameters.AddWithValue("@obs", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@obs", obs)
            End If

            command.ExecuteNonQuery()
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Cliente Ha Sido Registrado Exitosamente", ToolTipIcon.Info)

        Catch ex As Exception
            MsgBox(ex)
            MsgBox("Error insertando Cliente")
        End Try

    End Sub

    'Public Shared Sub inserta_cliente_Dist(ByVal cod As Integer, ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_insertaCliente_Dist"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)

    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If
    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox("Error insertando Cliente en Distribuidora")
    '        MsgBox(ex)
    '    End Try

    'End Sub

    'Public Shared Sub inserta_cliente_comer(ByVal cod As Integer, ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_insertaCliente_comer"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)

    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If
    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex)
    '        MsgBox("Error insertando Cliente")
    '    End Try

    'End Sub

    'Public Shared Sub inserta_cliente_CONAVE(ByVal cod As Integer, ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_insertaCliente_CONAVE"
    '        command.Parameters.AddWithValue("@cod", cod)
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)

    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If
    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox("Error insertando Cliente")
    '    End Try

    'End Sub


    Public Shared Sub modifica_cliente(ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal COD As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal CodAnt As Integer, ByVal fletePago As Boolean, ByVal direccionE As String)
        Try
            command.Parameters.Clear()
            command.CommandText = "sp_modificaCliente"
            command.Parameters.AddWithValue("@razS", razS)
            command.Parameters.AddWithValue("@rif", rif)
            command.Parameters.AddWithValue("@fecR", fecR)
            command.Parameters.AddWithValue("@codV", codV)
            command.Parameters.AddWithValue("@zona", zona)
            command.Parameters.AddWithValue("@est", est)
            command.Parameters.AddWithValue("@aut", aut)
            command.Parameters.AddWithValue("@contE", contE)
            command.Parameters.AddWithValue("@COD", COD)
            command.Parameters.AddWithValue("@User", user)
            command.Parameters.AddWithValue("@Pass", pass)
            command.Parameters.AddWithValue("@dirE", direccionE)
            command.Parameters.AddWithValue("@CodAnt", CodAnt)
            command.Parameters.AddWithValue("@FletePago", fletePago)


            If lim = "" Then
                command.Parameters.AddWithValue("@lim", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@lim", CDbl(lim))
            End If

            If ger = "" Then
                command.Parameters.AddWithValue("@ger", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@ger", ger)
            End If

            If dir = "" Then
                command.Parameters.AddWithValue("@dir", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@dir", dir)
            End If
            If telf1 = "" Then
                command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telf1", telf1)
            End If
            If telf2 = "" Then
                command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telf2", telf2)
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
            If ABC = "" Then
                command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@ABC", ABC)
            End If
            If rep = "" Then
                command.Parameters.AddWithValue("@rep", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@rep", rep)
            End If
            If cel = "" Then
                command.Parameters.AddWithValue("@cel", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@cel", cel)
            End If
            If obs = "" Then
                command.Parameters.AddWithValue("@obs", System.DBNull.Value)
            Else
                command.Parameters.AddWithValue("@obs", obs)
            End If
            command.ExecuteNonQuery()
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Cliente Ha Sido Modificado Exitosamente", ToolTipIcon.Info)

        Catch ex As SqlException

        End Try


    End Sub


    'Public Shared Sub modifica_cliente_dist(ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal COD As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal CodAnt As Integer, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_modificaCliente_dist"
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@COD", COD)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@CodAnt", CodAnt)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)


    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If

    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()

    '    Catch ex As SqlException

    '    End Try


    'End Sub

    'Public Shared Sub modifica_cliente_comer(ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal COD As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal CodAnt As Integer, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_modificaCliente_comer"
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@COD", COD)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@CodAnt", CodAnt)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)


    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If

    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()

    '    Catch ex As SqlException

    '    End Try


    'End Sub

    'Public Shared Sub modifica_cliente_CONAVE(ByVal razS As String, ByVal rif As String, ByVal fecR As DateTime, ByVal telf1 As String, ByVal telf2 As String, ByVal fax As String, ByVal email As String, ByVal dir As String, ByVal rep As String, ByVal ger As String, ByVal codV As Integer, ByVal zona As Integer, ByVal est As String, ByVal ABC As String, ByVal aut As Integer, ByVal COD As Integer, ByVal contE As Boolean, ByVal cel As String, ByVal obs As String, ByVal user As String, ByVal pass As String, ByVal lim As String, ByVal CodAnt As Integer, ByVal fletePago As Boolean, ByVal direccionE As String)
    '    Try
    '        command.Parameters.Clear()
    '        command.CommandText = "sp_modificaCliente_CONAVE"
    '        command.Parameters.AddWithValue("@razS", razS)
    '        command.Parameters.AddWithValue("@rif", rif)
    '        command.Parameters.AddWithValue("@fecR", fecR)
    '        command.Parameters.AddWithValue("@codV", codV)
    '        command.Parameters.AddWithValue("@zona", zona)
    '        command.Parameters.AddWithValue("@est", est)
    '        command.Parameters.AddWithValue("@aut", aut)
    '        command.Parameters.AddWithValue("@contE", contE)
    '        command.Parameters.AddWithValue("@COD", COD)
    '        command.Parameters.AddWithValue("@User", user)
    '        command.Parameters.AddWithValue("@Pass", pass)
    '        command.Parameters.AddWithValue("@dirE", direccionE)
    '        command.Parameters.AddWithValue("@CodAnt", CodAnt)
    '        command.Parameters.AddWithValue("@FletePago", fletePago)


    '        If lim = "" Then
    '            command.Parameters.AddWithValue("@lim", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@lim", CDbl(lim))
    '        End If

    '        If ger = "" Then
    '            command.Parameters.AddWithValue("@ger", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ger", ger)
    '        End If

    '        If dir = "" Then
    '            command.Parameters.AddWithValue("@dir", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@dir", dir)
    '        End If
    '        If telf1 = "" Then
    '            command.Parameters.AddWithValue("@telf1", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf1", telf1)
    '        End If
    '        If telf2 = "" Then
    '            command.Parameters.AddWithValue("@telf2", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@telf2", telf2)
    '        End If
    '        If fax = "" Then
    '            command.Parameters.AddWithValue("@fax", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@fax", fax)
    '        End If
    '        If email = "" Then
    '            command.Parameters.AddWithValue("@email", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@email", email)
    '        End If
    '        If ABC = "" Then
    '            command.Parameters.AddWithValue("@ABC", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@ABC", ABC)
    '        End If
    '        If rep = "" Then
    '            command.Parameters.AddWithValue("@rep", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@rep", rep)
    '        End If
    '        If cel = "" Then
    '            command.Parameters.AddWithValue("@cel", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@cel", cel)
    '        End If
    '        If obs = "" Then
    '            command.Parameters.AddWithValue("@obs", System.DBNull.Value)
    '        Else
    '            command.Parameters.AddWithValue("@obs", obs)
    '        End If
    '        command.ExecuteNonQuery()

    '    Catch ex As SqlException

    '    End Try


    'End Sub


    Public Shared Sub elimina_cliente(ByVal cod As Integer)

        command.Parameters.Clear()
        command.CommandText = "sp_eliminaCliente"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()

    End Sub

    'Public Shared Sub elimina_cliente_dist(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaCliente_dist"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub elimina_cliente_comer(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaCliente_comer"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    'Public Shared Sub elimina_cliente_CONAVE(ByVal cod As Integer)

    '    command.Parameters.Clear()
    '    command.CommandText = "sp_eliminaCliente_CONAVE"
    '    command.Parameters.AddWithValue("@cod", cod)
    '    command.ExecuteNonQuery()

    'End Sub

    Public Shared Sub consulta_clientes(ByVal lv As DataGridView, ByRef cant As Integer)
        Try
            Dim par As Integer
            par = 0
            lv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCliente"
            command.Parameters.AddWithValue("@cod", par)
            dr = command.ExecuteReader()
            While dr.Read
                cant = cant + 1

                lv.Rows.Add(dr("codigoCliente"), dr("razonSocial"), dr("contEspecial"))

            End While

        Catch ex As Exception
            MsgBox("Error consultando cliente", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_cliente2(ByVal c As Integer, ByRef cod As String, ByRef raz As String, ByRef rif As String, ByRef fec As String, ByRef tel1 As String, ByRef tel2 As String, ByRef fax As String, ByRef email As String, ByRef dir As String, ByRef rep As String, ByRef ger As String, ByRef ven As MTGCComboBox, ByRef zona As MTGCComboBox, ByRef est As MTGCComboBox, ByRef cla As String, ByRef contE As Boolean, ByRef cel As String, ByRef obs As String, ByRef auto As Boolean, ByRef user As String, ByRef pass As String, ByRef lim As String, ByRef fletePago As Boolean, ByRef DireccionE As String)

        Try

            Dim codV, codZ As Integer
            zona.Items.Clear()
            zona.ResetText()
            est.Items.Clear()
            est.ResetText()

            Dim vende As String = ""
            Dim z As String = ""
            Dim es As String = ""

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCliente"
            command.Parameters.AddWithValue("@cod", c)
            dr = command.ExecuteReader()

            While dr.Read()

                zona.Items.Clear()
                cod = dr("CodigoCliente")
                raz = dr("RazonSocial")
                rif = dr("Rif")
                fec = CStr(dr("FechaRegistro"))
                contE = dr("ContEspecial")
                auto = dr("Autorizado")

                If dr("Email").GetType.ToString = "System.DBNull" Then
                    email = ""
                Else
                    email = dr("Email")
                End If

                If dr("DireccionEntrega").GetType.ToString = "System.DBNull" Then
                    DireccionE = ""
                Else
                    DireccionE = dr("DireccionEntrega")
                End If

                If dr("FletePago").GetType.ToString = "System.DBNull" Then
                    fletePago = False
                Else
                    fletePago = dr("FletePago")
                End If

                If dr("LimiteCredito").GetType.ToString = "System.DBNull" Then
                    lim = "0,00"
                Else
                    lim = Format(dr("LimiteCredito"), "##,##0.00")
                End If

                If dr("Fax").GetType.ToString = "System.DBNull" Then
                    fax = ""
                Else
                    fax = dr("Fax")
                End If
                If dr("Telefono2").GetType.ToString = "System.DBNull" Then
                    tel2 = ""
                Else
                    tel2 = dr("Telefono2")
                End If
                If dr("Telefono1").GetType.ToString = "System.DBNull" Then
                    tel1 = ""
                Else
                    tel1 = dr("Telefono1")
                End If
                If dr("Direccion").GetType.ToString = "System.DBNull" Then
                    dir = ""
                Else
                    dir = dr("Direccion")
                End If
                If dr("Representante").GetType.ToString = "System.DBNull" Then
                    rep = ""
                Else
                    rep = dr("Representante")
                End If
                If dr("Gerente").GetType.ToString = "System.DBNull" Then
                    ger = ""
                Else
                    ger = dr("Gerente")
                End If
                If dr("ClasificacionABC").GetType.ToString = "System.DBNull" Then
                    cla = ""
                Else
                    cla = dr("ClasificacionABC")
                End If
                If dr("Celular").GetType.ToString = "System.DBNull" Then
                    cel = ""
                Else
                    cel = dr("Celular")
                End If
                If dr("Observacion").GetType.ToString = "System.DBNull" Then
                    obs = ""
                Else
                    obs = dr("Observacion")
                End If

                If dr("Nombre").GetType.ToString = "System.DBNull" Then
                    vende = ""
                Else
                    vende = dr("Nombre")
                End If

                If dr("COdigoVendedor").GetType.ToString = "System.DBNull" Then
                    codV = 0
                Else
                    codV = dr("COdigoVendedor")
                End If

                If dr("codZona").GetType.ToString = "System.DBNull" Then
                    codZ = ""
                Else
                    codZ = dr("codZona")
                End If

                If dr("Zona").GetType.ToString = "System.DBNull" Then
                    z = ""
                Else
                    z = dr("Zona")
                End If

                If dr("Estado").GetType.ToString = "System.DBNull" Then
                    es = ""
                Else
                    es = dr("Estado")
                End If

                If dr("User").GetType.ToString = "System.DBNull" Then
                    user = ""
                Else
                    user = dr("User")
                End If
                If dr("Password").GetType.ToString = "System.DBNull" Then
                    pass = ""
                Else
                    pass = dr("Password")
                End If

            End While

            dr.Close()

            'ven.Text = vende

            consulta_vendedores(ven)

            For cont As Integer = 0 To ven.Items.Count - 1

                If ven.Items(cont).col2 = codV Then

                    ven.SelectedIndex = cont

                End If

            Next


            consulta_zonas(zona)

            For cont As Integer = 0 To zona.Items.Count - 1

                If zona.Items(cont).col1 = z Then

                    zona.SelectedIndex = cont

                End If

            Next

            Dim estado As Integer
            If zona.Text = "Capital" Then
                estado = 1
            ElseIf zona.Text = "Centro y Occidente" Then
                estado = 2
            ElseIf zona.Text = "Los Andes" Then
                estado = 3
            ElseIf zona.Text = "Los Llanos" Then
                estado = 0
            ElseIf zona.Text = "Oriente" Then
                estado = 4
            ElseIf zona.Text = "Sur" Then
                estado = 5
            End If
            consulta_Estados(est, estado)

            Dim cont2 As Integer = 0

            While cont2 < est.Items.Count

                If est.Items(cont2).col1 = es Then

                    est.SelectedIndex = cont2
                    cont2 = est.Items.Count + 1

                End If

                cont2 = cont2 + 1

            End While

        Catch ex As Exception

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error consultando datos del cliente", ToolTipIcon.Error)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_cliente3(ByVal c As Integer, ByRef t As DataGridView, ByRef lb_vencido As Label, ByRef lb_porvencer As Label, ByRef lb_total As Label, ByRef lb_afavor As Label)
        t.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClienteFacturas"
        command.Parameters.AddWithValue("@cod", c)
        dr = command.ExecuteReader()
        Dim fecha1 As Date
        Dim fecha2 As Date
        Dim porvencer As Double = 0.0
        Dim vencido As Double = 0.0
        Dim favor As Double = 0.0

        While dr.Read()

            fecha1 = dr("fecha")
            fecha2 = DateAdd(DateInterval.Day, 15, fecha1)
            If dr("MontoPendiente") < 0 Then
                t.Rows.Add(dr("Control"), fecha1, fecha2, "", dr("MontoTotal"), dr("MontoPendiente"), dr("numeroFactura"), dr("Iva"), dr("ChequeDev"))
                t.Rows(t.Rows.Count - 1).Cells(5).Style.ForeColor = Color.Blue

                favor = favor - Math.Round(dr("MontoPendiente"), 2)
            Else
                t.Rows.Add(dr("Control"), fecha1, fecha2, DateDiff(DateInterval.Day, fecha1, Today()), dr("MontoTotal"), dr("MontoPendiente"), dr("numeroFactura"), dr("Iva"), dr("ChequeDev"))
                If DateDiff(DateInterval.Day, fecha1, Today()) > 15 Then
                    vencido = vencido + Math.Round(dr("MontoPendiente"), 2)
                Else
                    porvencer = porvencer + Math.Round(dr("MontoPendiente"), 2)
                End If
            End If
        End While
        dr.Close()
        lb_vencido.Text = FormatNumber(vencido, 2)
        lb_porvencer.Text = FormatNumber(porvencer, 2)
        lb_total.Text = FormatNumber(vencido + porvencer, 2)
        lb_afavor.Text = FormatNumber(favor * -1, 2)
    End Sub


    Public Shared Sub consulta_vendedores(ByRef cb As MTGCComboBox)

        Try

            cb.Items.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaVendedor"
            command.Parameters.AddWithValue("@cod", 0)
            dr = command.ExecuteReader()

            While dr.Read
                cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoVendedor"))))
            End While

        Catch ex As Exception
            MsgBox("Error cargando vendedores", MsgBoxStyle.Critical, "SINPRO")
        Finally
            dr.Close()
        End Try

    End Sub

    Public Shared Sub consulta_zonas(ByRef cb As MTGCComboBox)
        Dim par As Integer
        par = 0
        cb.Items.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaZona"
        command.Parameters.AddWithValue("@cod", par)
        dr = command.ExecuteReader()

        While dr.Read
            cb.Items.Add(New MTGCComboBoxItem(CStr(dr("nombre")), CStr(dr("codigoZona"))))
        End While

        dr.Close()
    End Sub
    Public Shared Sub consulta_Estados(ByRef cb As MTGCComboBox, ByVal n As Integer)
        cb.Items.Clear()
        If n = 0 Then  'llanos
            cb.Items.Add(New MTGCComboBoxItem("Apure"))
            cb.Items.Add(New MTGCComboBoxItem("Barinas"))
            cb.Items.Add(New MTGCComboBoxItem("Guárico"))
        ElseIf n = 1 Then 'capital
            cb.Items.Add(New MTGCComboBoxItem("Distrito Federal"))
            cb.Items.Add(New MTGCComboBoxItem("Miranda"))
            cb.Items.Add(New MTGCComboBoxItem("Vargas"))
        ElseIf n = 2 Then 'centro y occidente
            cb.Items.Add(New MTGCComboBoxItem("Aragua"))
            cb.Items.Add(New MTGCComboBoxItem("Carabobo"))
            cb.Items.Add(New MTGCComboBoxItem("Cojedes"))
            cb.Items.Add(New MTGCComboBoxItem("Falcón"))
            cb.Items.Add(New MTGCComboBoxItem("Lara"))
            cb.Items.Add(New MTGCComboBoxItem("Portuguesa"))
            cb.Items.Add(New MTGCComboBoxItem("Yaracuy"))
            cb.Items.Add(New MTGCComboBoxItem("Zulia"))
        ElseIf n = 3 Then  'los andes
            cb.Items.Add(New MTGCComboBoxItem("Merida"))
            cb.Items.Add(New MTGCComboBoxItem("Tachira"))
            cb.Items.Add(New MTGCComboBoxItem("Trujillo"))
        ElseIf n = 4 Then  'Oriente
            cb.Items.Add(New MTGCComboBoxItem("Anzoategui"))
            cb.Items.Add(New MTGCComboBoxItem("Monagas"))
            cb.Items.Add(New MTGCComboBoxItem("Nueva Esparta"))
            cb.Items.Add(New MTGCComboBoxItem("Sucre"))
        ElseIf n = 5 Then 'sur
            cb.Items.Add(New MTGCComboBoxItem("Amazonas"))
            cb.Items.Add(New MTGCComboBoxItem("Bolívar"))
            cb.Items.Add(New MTGCComboBoxItem("Delta Amacuro"))
        End If
    End Sub
    Public Shared Sub clasificacionABC_Cliente(ByRef porcA As Integer, ByRef porcB As Integer, ByRef porcC As Integer)
        Dim par As Integer = 1
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

    Public Shared Sub ModificaClasificacionABC_Cliente(ByVal porcB As Integer, ByVal porcC As Integer)
        Dim col As New Collection
        Dim fecha As Date = Date.Now.AddYears(-1)
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClientesTotalVentas"
        command.Parameters.AddWithValue("@fec", fecha)
        dr = command.ExecuteReader()
        Dim acum As Double = 0
        While dr.Read
            col.Add(dr("codigoCliente"))
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
        command.CommandText = "sp_modificaClientesResetClasificacion"
        command.ExecuteNonQuery()

        Dim cod As Integer = 0
        Dim cla As String

        While Not (col.Count = 0)
            cod = col.Item(1)
            cla = col.Item(2)
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaClienteClasificacionABC"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@cla", cla)
            command.ExecuteNonQuery()
            col.Remove(1)
            col.Remove(1)
        End While
    End Sub

    '------------------ MODULO ADMIN----------------


    Public Shared Sub consulta_clientes_eliminados(ByVal DGV As DataGridView)

        DGV.Rows.Clear()
        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "sp_consultaClientesEliminados"
        dr = command.ExecuteReader()
        While dr.Read

            DGV.Rows.Add(dr("CodigoCliente"), dr("razonSocial"))


        End While
        dr.Close()



    End Sub


    Public Shared Sub restaura_cliente(ByVal cod As Integer)
        command.Parameters.Clear()
        command.CommandText = "sp_restauraCliente"
        command.Parameters.AddWithValue("@cod", cod)
        command.ExecuteNonQuery()
    End Sub


    Public Shared Sub lv_ClienteR(ByRef DGV As DataGridView, ByVal s As String, ByVal val As Integer)
        Try
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvclienteR"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = val
            dr = command.ExecuteReader()
            While dr.Read
                DGV.Rows.Add(dr("codigoCliente"), dr("razonSocial"))

            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error consultando lista de clientes", MsgBoxStyle.Critical, "SINPRO")
        End Try


    End Sub


    Public Shared Sub consulta_clientes_vendedor(ByVal cod As Integer, ByRef codigo As Integer)
        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaCliente_Vendedor"
            command.Parameters.AddWithValue("@cod", cod)
            dr = command.ExecuteReader()
            If dr.Read() Then
                codigo = dr("codigoCliente")
            Else
                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then
                '    codigo = cod * 100
                'Else
                codigo = cod * 1000
                'End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error consultando el vendedor asociado al cliente", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub RetornaDominio(ByRef Dom As String)

        Dim fic As String = My.Application.Info.DirectoryPath() + "\Dominio.txt"

        Dim texto As String

        Dim sr As New System.IO.StreamReader(fic)
        texto = sr.ReadToEnd()
        sr.Close()

        Console.WriteLine(texto)
        Dom = texto.Trim

    End Sub


    Public Shared Sub LeeTxt(ByRef comen As String, ByVal tipo As Integer)

        Try

            If tipo = 0 Then

                Dim fic As String = "\\SERVER\Brwme  S.A\System\VENDEDOR.TXT"

                Dim texto As String

                Dim sr As New System.IO.StreamReader(fic)
                texto = sr.ReadToEnd()
                sr.Close()

                Console.WriteLine(texto)
                comen = texto.Trim.Replace("&descripcion=", "").Replace("&", "")

            ElseIf tipo = 1 Then

                Dim fic As String = "\\SERVER\Brwme  S.A\System\CLIENTES.TXT"

                Dim texto As String

                Dim sr As New System.IO.StreamReader(fic)
                texto = sr.ReadToEnd()
                sr.Close()

                Console.WriteLine(texto)
                comen = texto.Trim.Replace("&descripcion=", "").Replace("&", "").Replace("titulo=Clientes", "").Replace(Chr(10), "")

            End If

        Catch ex As Exception

            MsgBox("Error leyendo archivos, puede ser que fueran movidos o eliminados o que no tiene acceso a la ruta", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Public Shared Function EscribeTxt(ByVal texto As String, ByVal tipo As Integer) As Boolean

        Dim success As Boolean = True

        Try

            If tipo = 0 Then

                'Pass the file path and the file name to the StreamWriter constructor.
                Dim objStreamWriter As New StreamWriter("\\SERVER\Brwme  S.A\System\VENDEDOR.TXT")

                'Write a line of text.
                objStreamWriter.WriteLine("")

                'Write a second line of text.
                objStreamWriter.WriteLine("&descripcion=" & texto & "&")

                'Close the file.
                objStreamWriter.Close()

            ElseIf tipo = 1 Then

                'Pass the file path and the file name to the StreamWriter constructor.
                Dim objStreamWriter As New StreamWriter("\\SERVER\Brwme  S.A\System\CLIENTES.TXT")

                'Write a line of text.
                objStreamWriter.WriteLine("&titulo=Clientes&")

                'Write a second line of text.
                objStreamWriter.WriteLine("&descripcion=" & texto & "&")

                'Close the file.
                objStreamWriter.Close()

            End If

        Catch ex As Exception

            success = False

        End Try

        Return success

    End Function


    Public Shared Sub ModificaDominio(ByVal Dom As String, ByVal con As Integer)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@tipo", con)
        command.CommandText = "sp_ModificaDominio"
        command.Parameters.AddWithValue("@Cod", Dom)
        command.ExecuteNonQuery()

    End Sub



    Public Shared Sub ModificaEntrega(ByRef numF As Integer, ByVal Valor As Boolean, ByVal tipo As Integer)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_ModificaEntrega"
            command.Parameters.AddWithValue("@numF", numF)
            command.Parameters.AddWithValue("@valor", Valor)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error modificando la entrega de la factura", MsgBoxStyle.Critical, "SINPRO")
        End Try



    End Sub

    Public Shared Sub ModificaEnvioFac(ByRef Vende As Integer, ByVal Apro As String, ByVal Elab As String, ByVal Obs As String, ByVal Env As String, ByVal Fecha As Date, ByVal Id As Integer, ByVal guia As String)


        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_modificaEnvioFac"
            command.Parameters.AddWithValue("@Vende", Vende)
            command.Parameters.AddWithValue("@Apro", Apro)
            command.Parameters.AddWithValue("@Elab", Elab)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.Parameters.AddWithValue("@Envi", Env)
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.Parameters.AddWithValue("@Id", Id)
            command.Parameters.AddWithValue("@NroGuia", guia)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error modificando envio", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub InsertaEnvioFac(ByRef Vende As Integer, ByVal Apro As String, ByVal Elab As String, ByVal Obs As String, ByVal Env As String, ByVal Fecha As Date, ByVal guia As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaEnvioFac"
            command.Parameters.AddWithValue("@Vende", Vende)
            command.Parameters.AddWithValue("@Apro", Apro)
            command.Parameters.AddWithValue("@Elab", Elab)
            command.Parameters.AddWithValue("@Obs", Obs)
            command.Parameters.AddWithValue("@Envi", Env)
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.Parameters.AddWithValue("@NroGuia", guia)
            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                command.Parameters.AddWithValue("@conf", False)
            End If
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando envio", MsgBoxStyle.Critical, "SINPRO")
        End Try
    End Sub

    Public Shared Sub EliminaEnvioFac(ByRef Vende As Integer, ByVal Apro As String, ByVal Elab As String, ByVal Obs As String, ByVal Env As String, ByVal Fecha As Date, ByVal Id As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaEnvioFac"
            command.Parameters.AddWithValue("@Id", Id)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error eliminando envío", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub ConsultaEnvioFac(ByRef Vende As MTGCComboBox, ByRef Apro As String, ByRef Elab As String, ByRef Obs As String, ByRef Env As String, ByRef Fecha As Date, ByRef Id As String, ByRef dgv As DataGridView, ByVal id2 As Integer, ByRef guia As String, ByRef conf As Boolean)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaEnvioFac"
            command.Parameters.AddWithValue("@Id", id2)

            dr = command.ExecuteReader

            While dr.Read

                For cont As Integer = 0 To Vende.Items.Count - 1

                    If CInt(Vende.Items(cont).col2) = CInt(dr("CodigoVendedor")) Then

                        Vende.SelectedIndex = cont

                    End If

                Next

                Apro = dr("Aprobado")

                If Not dr("Nroguia").GetType.ToString = "System.DBNull" Then
                    guia = dr("NroGuia")
                Else
                    guia = ""
                End If

                Elab = dr("Elaborado")

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                    If dr("Confirmada").GetType.ToString = "System.DBNull" Then
                        conf = dr("Confirmada")
                    Else
                        conf = dr("Confirmada")
                    End If

                End If

                Obs = dr("Observaciones")
                Env = dr("Enviado")
                If Not dr("Fecha").GetType.ToString = "System.DBNull" Then
                    Fecha = dr("Fecha")
                End If
                Id = dr("Id").ToString

            End While

            dr.Close()

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaEnvioFac_Fact"
            command.Parameters.AddWithValue("@Id", Id)

            dr = command.ExecuteReader

            While dr.Read

                Dim tipo As String = ""

                If dr("Tipo") = 0 Then
                    tipo = "Fact."
                ElseIf dr("Tipo") = 1 Then
                    tipo = "N.C."
                Else
                    tipo = "C.D."
                End If

                dgv.Rows.Add(tipo, dr("Fecha"), dr("ControlDoc"), dr("CodigoCliente"), dr("RazonSocial"), dr("MontoTotal"), dr("NroDoc"))

            End While

        Catch ex As Exception

            MsgBox("Error consultando relación", MsgBoxStyle.Critical, "SINPRO")


        Finally

            dr.Close()
            dgv.ClearSelection()

        End Try

    End Sub

    Public Shared Sub ConsultaEnviosFac(ByRef dgv As DataGridView, ByRef Tipo As Integer, ByVal Valor As String)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaEnviosFac"
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Valor", Valor)

            dr = command.ExecuteReader

            While dr.Read

                dgv.Rows.Add(dr("Id"), dr("Nombre"))

            End While

        Catch ex As Exception

            MsgBox("Error consultando relaciones", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub identidadEnvio(ByRef id As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_identidadEnvio"

            dr = command.ExecuteReader

            While dr.Read

                id = dr("Expr1").ToString

            End While

        Catch ex As Exception

            MsgBox("Error consultando el correlativo", MsgBoxStyle.Critical, "SINPRO")


        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub InsertaEnvioFac_Fac(ByRef IdEnv As Integer, ByVal IdFac As String, ByVal tipo As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_InsertaEnvioFac_Fac"
            command.Parameters.AddWithValue("@IdEnv", IdEnv)
            command.Parameters.AddWithValue("@ControlDoc", IdFac)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error insertando facturas en la guía", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub

    Public Shared Sub contador(ByRef contador As Integer, ByRef zona As MTGCComboBox, ByVal codz As String)

        For cont As Integer = 0 To zona.Items.Count - 1
            If zona.Items(cont).col1 = codz Then
                contador = cont
            End If

        Next
    End Sub

    Public Shared Sub ConsultaReferenciasCliente(ByRef Emp As String, ByRef Id_Emp As String, ByRef Monto As String, ByRef ChequesDev As String, ByRef FechaI As Date, ByRef Obs As String, ByRef chk As Boolean, _
                                                 ByRef Emp2 As String, ByRef Id_Emp2 As String, ByRef Monto2 As String, ByRef ChequesDev2 As String, ByRef FechaI2 As Date, ByRef Obs2 As String, ByRef chk2 As Boolean, _
                                                 ByRef Emp3 As String, ByRef Id_Emp3 As String, ByRef Monto3 As String, ByRef ChequesDev3 As String, ByRef FechaI3 As Date, ByRef Obs3 As String, ByRef chk3 As Boolean, _
                                                 ByRef Id_C As Integer)

        Try


            Dim cont As Integer = 1
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaReferenciasCliente"
            command.Parameters.AddWithValue("@Id_C", Id_C)
            dr = command.ExecuteReader

            While dr.Read

                If cont = 1 Then

                    Emp = dr("RazonSocial")
                    Id_Emp = dr("Id_Empresa")
                    Monto = dr("MontoCredito")
                    ChequesDev = dr("ChequesDev")
                    FechaI = dr("InicioRelaciones")
                    Obs = dr("Comentario")
                    chk = True

                ElseIf cont = 2 Then

                    Emp2 = dr("RazonSocial")
                    Id_Emp2 = dr("Id_Empresa")
                    Monto2 = dr("MontoCredito")
                    ChequesDev2 = dr("ChequesDev")
                    FechaI2 = dr("InicioRelaciones")
                    Obs2 = dr("Comentario")
                    chk2 = True

                ElseIf cont = 3 Then

                    Emp3 = dr("RazonSocial")
                    Id_Emp3 = dr("Id_Empresa")
                    Monto3 = dr("MontoCredito")
                    ChequesDev3 = dr("ChequesDev")
                    FechaI3 = dr("InicioRelaciones")
                    Obs3 = dr("Comentario")
                    chk3 = True

                End If

                cont = cont + 1


            End While

        Catch ex As Exception

            MsgBox("Error consultando referencias", MsgBoxStyle.Critical, "SINPRO")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub InsertaReferencia(ByVal Id_Cliente As Integer, ByVal Id_Emp As Integer, ByVal Monto As Double, ByVal ChequesDev As Integer, ByVal FechaI As Date, ByVal Obs As String)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_insertaReferencia"
            command.Parameters.AddWithValue("@Id_E", Id_Emp)
            command.Parameters.AddWithValue("@Id_C", Id_Cliente)
            command.Parameters.AddWithValue("@Monto", Monto)
            command.Parameters.AddWithValue("@Inicio", FechaI)
            command.Parameters.AddWithValue("@Cheques", ChequesDev)
            command.Parameters.AddWithValue("@Comen", Obs)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error insertando referencias", MsgBoxStyle.Critical, "SINPRO")
        End Try
    End Sub

    'Public Shared Sub InsertaReferencia_dist(ByVal Id_Cliente As Integer, ByVal Id_Emp As Integer, ByVal Monto As Double, ByVal ChequesDev As Integer, ByVal FechaI As Date, ByVal Obs As String)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_insertaReferencia_dist"
    '        command.Parameters.AddWithValue("@Id_E", Id_Emp)
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.Parameters.AddWithValue("@Monto", Monto)
    '        command.Parameters.AddWithValue("@Inicio", FechaI)
    '        command.Parameters.AddWithValue("@Cheques", ChequesDev)
    '        command.Parameters.AddWithValue("@Comen", Obs)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error insertando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try
    'End Sub

    'Public Shared Sub InsertaReferencia_comer(ByVal Id_Cliente As Integer, ByVal Id_Emp As Integer, ByVal Monto As Double, ByVal ChequesDev As Integer, ByVal FechaI As Date, ByVal Obs As String)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_insertaReferencia_comer"
    '        command.Parameters.AddWithValue("@Id_E", Id_Emp)
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.Parameters.AddWithValue("@Monto", Monto)
    '        command.Parameters.AddWithValue("@Inicio", FechaI)
    '        command.Parameters.AddWithValue("@Cheques", ChequesDev)
    '        command.Parameters.AddWithValue("@Comen", Obs)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error insertando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try
    'End Sub

    'Public Shared Sub InsertaReferencia_CONAVE(ByVal Id_Cliente As Integer, ByVal Id_Emp As Integer, ByVal Monto As Double, ByVal ChequesDev As Integer, ByVal FechaI As Date, ByVal Obs As String)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_insertaReferencia_CONAVE"
    '        command.Parameters.AddWithValue("@Id_E", Id_Emp)
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.Parameters.AddWithValue("@Monto", Monto)
    '        command.Parameters.AddWithValue("@Inicio", FechaI)
    '        command.Parameters.AddWithValue("@Cheques", ChequesDev)
    '        command.Parameters.AddWithValue("@Comen", Obs)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error insertando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try

    'End Sub

    Public Shared Sub EliminaReferenciasCliente(ByVal Id_Cliente As Integer)

        Try
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_eliminaReferenciasCliente"
            command.Parameters.AddWithValue("@Id_C", Id_Cliente)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error eliminando referencias", MsgBoxStyle.Critical, "SINPRO")
        End Try
    End Sub

    'Public Shared Sub EliminaReferenciasCliente_dist(ByVal Id_Cliente As Integer)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_eliminaReferenciasCliente_dist"
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error eliminando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try
    'End Sub

    'Public Shared Sub EliminaReferenciasCliente_comer(ByVal Id_Cliente As Integer)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_eliminaReferenciasCliente_comer"
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error eliminando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try
    'End Sub

    'Public Shared Sub EliminaReferenciasCliente_CONAVE(ByVal Id_Cliente As Integer)

    '    Try
    '        command.Parameters.Clear()
    '        command.CommandType = CommandType.StoredProcedure
    '        command.CommandText = "sp_eliminaReferenciasCliente_CONAVE"
    '        command.Parameters.AddWithValue("@Id_C", Id_Cliente)
    '        command.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox("Error eliminando referencias", MsgBoxStyle.Critical, "SINPRO")
    '    End Try
    'End Sub

    Public Shared Sub Inserta_Actividad(ByVal Actividad As String)

        If My.Settings.Empresa <> 5 Then

            Try
                command.Parameters.Clear()
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "sp_insertaActividad"
                command.Parameters.AddWithValue("@User", My.Settings.UserLogin)
                command.Parameters.AddWithValue("@Fecha", Date.Now)
                command.Parameters.AddWithValue("@Actividad", Actividad)
                command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error insertando actividad en el registro", MsgBoxStyle.Critical, "SINPRO")
            End Try

        End If

    End Sub

End Class
