Imports System.Data.SqlClient
Imports Dundas.Charting.WinControl
Imports Dundas.Charting.WinControl.ChartTypes
Imports Dundas.Extensions
Imports System.Drawing

Public Class DatosDSS

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)
        conex = con
        command = com
        command.Connection = conex
    End Sub

    Public Shared Sub DGV_Semaforo(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Fecha3 As Date, ByVal Fecha4 As Date, ByVal Im As ImageList, ByVal DPC() As Double, ByVal Otros() As Double)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_datosVendedores"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Fecha3", Fecha3)
            command.Parameters.AddWithValue("@Fecha4", Fecha4)

            Dim total As Double = 0
            Dim totalPromedio As Double = 0
            Dim totalVentas As Integer = 0
            Dim promedioVentas As Integer = 0
            Dim clientes As Integer = 0
            Dim promedioClientes As Integer = 0
            Dim totalppv As Double = 0
            Dim promedioppv As Double = 0
            dr = command.ExecuteReader

            While dr.Read

                total = total + dr("VentasBs")
                totalPromedio = totalPromedio + dr("PromedioVentasBs")
                totalVentas = totalVentas + dr("#Ventas")
                promedioVentas = promedioVentas + dr("#PromedioVentas")
                clientes = clientes + dr("#Clientes")
                promedioClientes = promedioClientes + dr("#PromedioClientes")
                totalppv = totalppv + dr("PPV")
                promedioppv = promedioppv + dr("PromedioPPV")

            End While

            dr.Close()

            dr = command.ExecuteReader

            Dim cont As Integer = 0

            While dr.Read

                '------------------------------------------------------------------------------------------'
                '                                    COLUMNA VENTAS BS                                     '
                '------------------------------------------------------------------------------------------'


                If dr("PromedioVentasBs") <> 0 And total > 0 Then

                    If dr("VentasBs") / total >= (dr("PromedioVentasBs") / totalPromedio) * ((Otros(0) / 100) + 1) Then

                        '-------------------------------------- Verde -------------------------------------'


                        If ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) >= (5 / 100) Then

                            ' ---------------------------- Verde Arriba --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(6), 9, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < (5 / 100) And ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) >= -(5 / 100) Then

                            ' ---------------------------- Verde solo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(3), 8, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < -(5 / 100) Then

                            ' ---------------------------- Verde abajo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(0), 7, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        End If

                    ElseIf dr("VentasBs") / total < (dr("PromedioVentasBs") / totalPromedio) * ((Otros(1) / 100) + 1) And dr("VentasBs") / total >= (dr("PromedioVentasBs") / totalPromedio) * ((Otros(2) / 100) + 1) Then


                        '-------------------------------------- Amarillo -------------------------------------'

                        If ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) >= (5 / 100) Then

                            ' ---------------------------- Amarillo Arriba --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(8), 6, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < (5 / 100) And ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) >= -(5 / 100) Then

                            ' ---------------------------- Amarillo solo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(5), 5, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < -(5 / 100) Then

                            ' ---------------------------- Amarillo abajo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(2), 4, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        End If

                    ElseIf dr("VentasBs") / total < (dr("PromedioVentasBs") / totalPromedio) * ((Otros(3) / 100) + 1) Then


                        '-------------------------------------- Rojo -------------------------------------'

                        If ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) > (5 / 100) Then

                            ' ---------------------------- Rojo Arriba --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(7), 3, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < (5 / 100) And ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) >= -(5 / 100) Then

                            ' ---------------------------- Rojo solo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(4), 2, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        ElseIf ((dr("VentasBs") / dr("PromedioVentasBs")) - 1) < -(5 / 100) Then

                            ' ---------------------------- Rojo abajo --------------------------------'

                            dgv.Rows.Add(dr("Nombre"), Im.Images(1), 1, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                        End If

                    Else

                        ' ---------------------------- Nothing --------------------------------'

                        dgv.Rows.Add(dr("Nombre"), Im.Images(9), 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                    End If

                Else

                    ' ---------------------------- Nothing --------------------------------'

                    dgv.Rows.Add(dr("Nombre"), Im.Images(9), 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, 0)

                End If


                '------------------------------------------------------------------------------------------'
                '                                     COLUMNA #Ventas                                      '
                '------------------------------------------------------------------------------------------'

                If dr("#PromedioVentas") <> 0 And totalVentas > 0 Then

                    If dr("#Ventas") / totalVentas >= (dr("#PromedioVentas") / promedioVentas) * ((Otros(0) / 100) + 1) Then

                        '-------------------------------------- Verde -------------------------------------'

                        If (dr("#Ventas") >= dr("#promedioVentas") * ((5 / 100) + 1)) Then

                            ' ---------------------------- Verde Arriba --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(6)

                            dgv.Rows(cont).Cells(4).Value = 9

                        ElseIf dr("#Ventas") < (dr("#promedioVentas") * ((5 / 100) + 1)) And dr("#Ventas") >= (dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Verde solo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(3)

                            dgv.Rows(cont).Cells(4).Value = 8

                        ElseIf (dr("#Ventas") < dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Verde abajo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(0)

                            dgv.Rows(cont).Cells(4).Value = 7

                        End If

                    ElseIf dr("#Ventas") / totalVentas < (dr("#PromedioVentas") / promedioVentas) * ((Otros(1) / 100) + 1) And dr("#Ventas") / totalVentas >= (dr("#PromedioVentas") / promedioVentas) * ((Otros(2) / 100) + 1) Then


                        '-------------------------------------- Amarillo -------------------------------------'

                        If ((dr("#Ventas")) >= dr("#promedioVentas")) * ((5 / 100) + 1) Then

                            ' ---------------------------- Amarillo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(8)

                            dgv.Rows(cont).Cells(4).Value = 6

                        ElseIf dr("#Ventas") < (dr("#promedioVentas") * ((5 / 100) + 1)) And dr("#Ventas") >= (dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Amarillo solo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(5)

                            dgv.Rows(cont).Cells(4).Value = 5

                        ElseIf (dr("#Ventas") < dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Amarillo abajo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(2)

                            dgv.Rows(cont).Cells(4).Value = 4

                        End If

                    ElseIf dr("#Ventas") / totalVentas < (dr("#PromedioVentas") / promedioVentas) * ((Otros(3) / 100) + 1) Then


                        '-------------------------------------- Rojo -------------------------------------'

                        If (dr("#Ventas") >= dr("#promedioVentas") * ((5 / 100) + 1)) Then

                            ' ---------------------------- Rojo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(7)

                            dgv.Rows(cont).Cells(4).Value = 3

                        ElseIf dr("#Ventas") < (dr("#promedioVentas") * ((5 / 100) + 1)) And dr("#Ventas") >= (dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Rojo solo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(4)

                            dgv.Rows(cont).Cells(4).Value = 2


                        ElseIf (dr("#Ventas") < dr("#promedioVentas") * ((-5 / 100) + 1)) Then

                            ' ---------------------------- Rojo abajo --------------------------------'

                            dgv.Rows(cont).Cells(3).Value = Im.Images(1)

                            dgv.Rows(cont).Cells(4).Value = 1

                        Else

                            ' ---------------------------- Nothing --------------------------------'


                            dgv.Rows(cont).Cells(3).Value = Im.Images(9)

                            dgv.Rows(cont).Cells(4).Value = 0

                        End If

                    End If

                Else

                    ' ---------------------------- Nothing --------------------------------'


                    dgv.Rows(cont).Cells(3).Value = Im.Images(9)

                    dgv.Rows(cont).Cells(4).Value = 0


                End If


                '------------------------------------------------------------------------------------------'
                '                                     COLUMNA #Clientes                                    '
                '------------------------------------------------------------------------------------------'

                If dr("#promedioClientes") <> 0 And clientes > 0 Then

                    If dr("#Clientes") / clientes >= (dr("#promedioClientes") / promedioClientes) * ((Otros(0) / 100) + 1) Then

                        '-------------------------------------- Verde -------------------------------------'

                        If dr("#Clientes") > dr("#promedioClientes") * ((5 / 100) + 1) Then

                            ' ---------------------------- Verde Arriba --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(6)

                            dgv.Rows(cont).Cells(6).Value = 9

                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((5 / 100) + 1) And dr("#Clientes") >= dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Verde solo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(5)

                            dgv.Rows(cont).Cells(6).Value = 8

                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Verde abajo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(0)

                            dgv.Rows(cont).Cells(6).Value = 7

                        End If

                    ElseIf dr("#Clientes") / clientes < (dr("#promedioClientes") / promedioClientes) * ((Otros(1) / 100) + 1) And dr("VentasBs") / clientes >= (dr("#promedioClientes") / promedioClientes) * ((Otros(2) / 100) + 1) Then


                        '-------------------------------------- Amarillo -------------------------------------'

                        If dr("#Clientes") > dr("#promedioClientes") * ((5 / 100) + 1) Then

                            ' ---------------------------- Amarillo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(8)

                            dgv.Rows(cont).Cells(6).Value = 6

                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((5 / 100) + 1) And dr("#Clientes") >= dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Amarillo solo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(5)

                            dgv.Rows(cont).Cells(6).Value = 5

                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Amarillo abajo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(2)

                            dgv.Rows(cont).Cells(6).Value = 4

                        End If

                    ElseIf dr("#Clientes") / clientes < (dr("#promedioClientes") / promedioClientes) * ((Otros(3) / 100) + 1) Then


                        '-------------------------------------- Rojo -------------------------------------'

                        If dr("#Clientes") > dr("#promedioClientes") * ((5 / 100) + 1) Then

                            ' ---------------------------- Rojo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(7)

                            dgv.Rows(cont).Cells(6).Value = 3

                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((5 / 100) + 1) And dr("#Clientes") >= dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Rojo solo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(6)

                            dgv.Rows(cont).Cells(6).Value = 2


                        ElseIf dr("#Clientes") < dr("#promedioClientes") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Rojo abajo --------------------------------'

                            dgv.Rows(cont).Cells(5).Value = Im.Images(1)

                            dgv.Rows(cont).Cells(6).Value = 1

                        Else

                            ' ---------------------------- Nothing --------------------------------'


                            dgv.Rows(cont).Cells(5).Value = Im.Images(9)

                            dgv.Rows(cont).Cells(6).Value = 0



                        End If

                    End If

                Else

                    ' ---------------------------- Nothing --------------------------------'


                    dgv.Rows(cont).Cells(5).Value = Im.Images(9)

                    dgv.Rows(cont).Cells(6).Value = 0


                End If



                '------------------------------------------------------------------------------------------'
                '                                     COLUMNA D.P.C.                                       '
                '------------------------------------------------------------------------------------------'

                If dr("DPCPeriodoAnt") <> 0 And dr("DPC") <> 0 Then

                    If dr("DPC") <= DPC(0) Then

                        '-------------------------------------- Verde -------------------------------------'

                        If dr("DPC") < dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Verde Arriba --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(6)

                            dgv.Rows(cont).Cells(8).Value = 9

                        ElseIf dr("DPC") = dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Verde solo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(3)

                            dgv.Rows(cont).Cells(8).Value = 8

                        ElseIf dr("DPC") > dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Verde abajo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(0)

                            dgv.Rows(cont).Cells(8).Value = 7

                        End If

                    ElseIf dr("DPC") > DPC(1) And dr("DPC") <= DPC(2) Then


                        '-------------------------------------- Amarillo -------------------------------------'

                        If dr("DPC") < dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Amarillo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(8)

                            dgv.Rows(cont).Cells(8).Value = 6

                        ElseIf dr("DPC") = dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Amarillo solo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(5)

                            dgv.Rows(cont).Cells(8).Value = 5

                        ElseIf dr("DPC") > dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Amarillo abajo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(2)

                            dgv.Rows(cont).Cells(8).Value = 4

                        End If

                    ElseIf dr("DPC") > DPC(3) Then


                        '-------------------------------------- Rojo -------------------------------------'

                        If dr("DPC") < dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Rojo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(7)

                            dgv.Rows(cont).Cells(8).Value = 3

                        ElseIf dr("DPC") = dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Rojo solo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(4)

                            dgv.Rows(cont).Cells(8).Value = 2


                        ElseIf dr("DPC") > dr("DPCPeriodoAnt") Then

                            ' ---------------------------- Rojo abajo --------------------------------'

                            dgv.Rows(cont).Cells(7).Value = Im.Images(1)

                            dgv.Rows(cont).Cells(8).Value = 1


                        Else

                            ' ---------------------------- Nothing --------------------------------'


                            dgv.Rows(cont).Cells(7).Value = Im.Images(9)

                            dgv.Rows(cont).Cells(8).Value = 0

                        End If

                    End If

                Else

                    ' ---------------------------- Nothing --------------------------------'


                    dgv.Rows(cont).Cells(7).Value = Im.Images(9)

                    dgv.Rows(cont).Cells(8).Value = 0

                    'dgv.Rows.Add(dr("Nombre"), Im.Images(9), 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0, System.DBNull.Value, 0)

                End If


                '------------------------------------------------------------------------------------------'
                '                                     COLUMNA P.P.V.                                       '
                '------------------------------------------------------------------------------------------'

                If dr("PromedioPPV") <> 0 And clientes > 0 Then

                    If dr("PPV") / clientes >= (dr("PromedioPPV") / promedioClientes) * ((Otros(0) / 100) + 1) Then

                        '-------------------------------------- Verde -------------------------------------'

                        If dr("PPV") >= dr("PromedioPPV") * ((5 / 100) + 1) Then

                            ' ---------------------------- Verde Arriba --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(6)

                            dgv.Rows(cont).Cells(10).Value = 9

                        ElseIf dr("PPV") < dr("PromedioPPV") * ((5 / 100) + 1) And dr("PPV") >= dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Verde solo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(3)

                            dgv.Rows(cont).Cells(10).Value = 8

                        ElseIf dr("PPV") < dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Verde abajo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(0)

                            dgv.Rows(cont).Cells(10).Value = 7

                        End If

                    ElseIf dr("PPV") / clientes < (dr("PromedioPPV") / promedioClientes) * ((Otros(1) / 100) + 1) And dr("VentasBs") / clientes >= (dr("PromedioPPV") / promedioClientes) * ((Otros(2) / 100) + 1) Then


                        '-------------------------------------- Amarillo -------------------------------------'

                        If dr("PPV") >= dr("PromedioPPV") * ((5 / 100) + 1) Then

                            ' ---------------------------- Amarillo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(8)

                            dgv.Rows(cont).Cells(10).Value = 6

                        ElseIf dr("PPV") < dr("PromedioPPV") * ((5 / 100) + 1) And dr("PPV") >= dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Amarillo solo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(5)

                            dgv.Rows(cont).Cells(10).Value = 5

                        ElseIf dr("PPV") < dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Amarillo abajo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(2)

                            dgv.Rows(cont).Cells(10).Value = 4

                        End If

                    ElseIf dr("PPV") / clientes < (dr("PromedioPPV") / promedioClientes) * ((Otros(3) / 100) + 1) Then


                        '-------------------------------------- Rojo -------------------------------------'

                        If dr("PPV") >= dr("PromedioPPV") * ((5 / 100) + 1) Then

                            ' ---------------------------- Rojo Arriba --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(7)

                            dgv.Rows(cont).Cells(10).Value = 3

                        ElseIf dr("PPV") < dr("PromedioPPV") * ((5 / 100) + 1) And dr("PPV") >= dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Rojo solo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(4)

                            dgv.Rows(cont).Cells(10).Value = 2


                        ElseIf dr("PPV") < dr("PromedioPPV") * ((-5 / 100) + 1) Then

                            ' ---------------------------- Rojo abajo --------------------------------'

                            dgv.Rows(cont).Cells(9).Value = Im.Images(1)

                            dgv.Rows(cont).Cells(10).Value = 1


                        Else

                            ' ---------------------------- Nothing --------------------------------'


                            dgv.Rows(cont).Cells(9).Value = Im.Images(9)

                            dgv.Rows(cont).Cells(10).Value = 0

                        End If

                    End If

                Else

                    ' ---------------------------- Nothing --------------------------------'


                    dgv.Rows(cont).Cells(9).Value = Im.Images(9)

                    dgv.Rows(cont).Cells(10).Value = 0


                End If

                cont = cont + 1

            End While

            dgv.ClearSelection()

        Catch ex As Exception



        Finally

            dr.Close()

        End Try


    End Sub

    Public Shared Sub DGV_DatosSemaforo(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Fecha3 As Date, ByVal Fecha4 As Date)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_datosVendedores"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Fecha3", Fecha3)
            command.Parameters.AddWithValue("@Fecha4", Fecha4)

            dr = command.ExecuteReader

            While dr.Read

                dgv.Rows.Add(dr("Nombre"), dr("VentasBs"), dr("VentasBsAnt"), dr("#Ventas"), dr("#VentasAnt"), dr("#Clientes"), dr("#ClientesAnt"), dr("DPC"), dr("DPCPeriodoAnt"), dr("PPV"), dr("PPVAnt"))

            End While

        Catch ex As Exception

            MsgBox("Error cargando los datos del semáforo", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub ComparacionVendedores(ByRef dgv As DataGridView, ByRef Chart As Dundas.Charting.WinControl.Chart)

        Try

            Chart.Series.Clear()
            Chart.Palette = ChartColorPalette.SemiTransparent


            Chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_datosVendedores"
            command.Parameters.AddWithValue("@Fecha1", Today)
            command.Parameters.AddWithValue("@Fecha2", Today)

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            dgv.DataSource = ds.Tables(0)

            Dim textSeries As New Series
            textSeries.Type = SeriesChartType.Column
            Dim cont3 As Integer = 0
            While cont3 < dgv.Rows.Count - 1
                textSeries.Points.AddY(0)
                textSeries.Points(cont3).AxisLabel = dgv.Rows(cont3).Cells(0).Value
                textSeries.BorderColor = Color.DimGray
                textSeries.BorderStyle = ChartDashStyle.Solid
                textSeries.BorderWidth = 1
                textSeries("CellWidth") = "200"
                cont3 = cont3 + 1
            End While


            Chart.DataSource = ds.Tables(0)

            While cont < ds.Tables(0).Columns.Count - 1

                If cont = 0 Then
                    Chart.Series.Add(textSeries)
                Else
                    Chart.Series.Add("Series" + (cont + 1).ToString)
                    Chart.Series("Series" + (cont + 1).ToString).Type = SeriesChartType.Column
                    Chart.Series("Series" + (cont + 1).ToString).ValueMembersY = ds.Tables(0).Columns(cont).ToString
                    Chart.Series("Series" + (cont + 1).ToString).ValueMemberX = ds.Tables(0).Columns(5).ToString
                    Chart.Series("Series" + (cont + 1).ToString).BorderColor = Color.DimGray
                    Chart.Series("Series" + (cont + 1).ToString).BorderStyle = ChartDashStyle.Solid
                    Chart.Series("Series" + (cont + 1).ToString).BorderWidth = 1


                End If


                cont = cont + 1

            End While

            Chart.Legends.Clear()


            cont = 0

            Dim registry As ChartTypeRegistry = DirectCast(Chart.GetService(GetType(ChartTypeRegistry)), ChartTypeRegistry)


            registry.Register("Scorecard", GetType(Dundas.Extensions.Scorecard))


            While cont < ds.Tables(0).Columns.Count - 1

                Chart.Series(cont).ChartType = "Scorecard"
                Chart.Series(cont).Font = New System.Drawing.Font("Trebuchet MS", 8)
                Chart.Series(cont)("LabelsAutoFit") = False
                cont = cont + 1

            End While




        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub GraficoCircularVendedores(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByVal FechaMin As Date, ByVal FechaMax As Date, ByRef dgv As DataGridView, ByVal PorcDebajo As Integer, ByRef TotalVentas As String)

        Try

            dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0
            Dim totalVentas2 As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_totalVendedores"
            dr = command.ExecuteReader

            While dr.Read

                total = CInt(dr("TotalVendedores"))

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            command.CommandText = "sp_ventasPorVendedor"
            command.Parameters.AddWithValue("@Fecha1", FechaMin)
            command.Parameters.AddWithValue("@Fecha2", FechaMax)
            dr = command.ExecuteReader

            While dr.Read


                dgv.Rows.Add(dr("CodigoVendedor"), dr("Nombre"), dr("Monto"))

                yValues(cont) = dr("Monto")
                xValues(cont) = dr("Nombre")
                xValuesVacio(cont) = ""
                totalVentas2 = totalVentas2 + dr("Monto")

                acum = acum + dr("Monto")

                cont = cont + 1

            End While

            If acum > 0 Then

                For cont2 As Integer = 0 To cont

                    yValues(cont2) = (yValues(cont2) / acum) * 100

                    If yValues(cont2) < PorcDebajo Then

                        totalOtros = totalOtros + yValues(cont2)

                    End If


                Next

            End If

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 8pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 3 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros vendedores"

            TotalVentas = Format(totalVentas2, "#,##0.00")
            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub consulta_ParametrosDSS(ByRef VerdeDPC As String, ByRef AmarilloDPC1 As String, ByRef AmarilloDPC2 As String, ByRef RojoDPC As String, ByRef VerdeOtros As String, ByRef AmarilloOtros1 As String, ByRef AmarilloOtros2 As String, ByRef RojoOtros As String)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaParametrosDiasVendedores"

            dr = command.ExecuteReader

            While dr.Read

                VerdeDPC = dr("VerdeDPC")
                AmarilloDPC1 = dr("AmarilloDPC1")
                AmarilloDPC2 = dr("AmarilloDPC2")
                RojoDPC = dr("RojoDPC")

                VerdeOtros = dr("VerdeOtros")
                AmarilloOtros2 = dr("AmarilloOtros1")
                AmarilloOtros1 = dr("AmarilloOtros2")
                RojoOtros = dr("RojoOtros")

            End While

        Catch ex As Exception

            MsgBox("Error cargando los parámetros del modelo", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try



    End Sub

    Public Shared Sub consultaFacturasVencidas(ByRef DGV As DataGridView, ByVal Vendedor As Integer, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer)

        Try
            DGV.Rows.Clear()

            Dim totalFact As Integer = 0
            Dim Total30 As Integer = 0
            Dim Total45 As Integer = 0
            Dim Total60 As Integer = 0
            Dim Total90 As Integer = 0
            Dim totalOtros As Integer = 0

            Dim totalFactBs As Double = 0
            Dim Total30Bs As Double = 0
            Dim Total45Bs As Double = 0
            Dim Total60Bs As Double = 0
            Dim Total90Bs As Double = 0
            Dim totalOtrosBs As Double = 0

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Vendedor)
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFacturasVencidas"

            dr = command.ExecuteReader

            While dr.Read

                totalFact = totalFact + 1
                totalFactBs = totalFactBs + dr("MontoPendiente")


                If dr("Días Vencimiento") > 90 Then

                    Total90 = Total90 + 1
                    Total90Bs = Total90Bs + dr("MontoPendiente")

                ElseIf dr("Días Vencimiento") > 60 And dr("Días Vencimiento") <= 90 Then

                    Total60 = Total60 + 1
                    Total60Bs = Total60Bs + dr("MontoPendiente")

                ElseIf dr("Días Vencimiento") > 45 And dr("Días Vencimiento") <= 60 Then

                    Total45 = Total45 + 1
                    Total45Bs = Total45Bs + dr("MontoPendiente")

                ElseIf dr("Días Vencimiento") >= 30 And dr("Días Vencimiento") <= 45 Then

                    Total30 = Total30 + 1
                    Total30Bs = Total30Bs + dr("MontoPendiente")

                ElseIf dr("Días Vencimiento") < 30 Then

                    totalOtros = totalOtros + 1
                    totalOtrosBs = totalOtrosBs + dr("MontoPendiente")

                End If

            End While

            DGV.Rows.Add(totalFact, totalOtros, Total30, Total45, Total60, Total90)
            DGV.Rows.Add(Format(totalFactBs, "#,##0.00"), Format(totalOtrosBs, "#,##0.00"), Format(Total30Bs, "#,##0.00"), Format(Total45Bs, "#,##0.00"), Format(Total60Bs, "#,##0.00"), Format(Total90Bs, "#,##0.00"))


        Catch ex As Exception

            MsgBox("Error cargando facturas", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()
            DGV.ClearSelection()

        End Try

    End Sub

    Public Shared Sub CosultaFactCobradas(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByRef dgv As DataGridView, ByVal Vendedor As Integer, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer)

        Try

            Dim xValues(4) As String
            Dim yValues(4) As Integer
            Dim xValuesVacio(4) As String

            Dim totalFact As Integer = 0
            Dim Total30 As Integer = 0
            Dim Total45 As Integer = 0
            Dim Total60 As Integer = 0
            Dim Total90 As Integer = 0
            Dim totalOtros As Integer = 0

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Vendedor)
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_consultaFacturasCobradas"

            dr = command.ExecuteReader

            While dr.Read

                totalFact = totalFact + 1

                If dr("Días Pago") > 90 Then

                    Total90 = Total90 + 1

                ElseIf dr("Días Pago") > 60 And dr("Días Pago") <= 90 Then

                    Total60 = Total60 + 1

                ElseIf dr("Días Pago") > 45 And dr("Días Pago") <= 60 Then

                    Total45 = Total45 + 1

                ElseIf dr("Días Pago") >= 30 And dr("Días Pago") <= 45 Then

                    Total30 = Total30 + 1

                ElseIf dr("Días Pago") < 30 Then

                    totalOtros = totalOtros + 1

                End If

            End While

            yValues(0) = totalOtros
            xValuesVacio(0) = ""
            yValues(1) = Total30
            xValuesVacio(1) = ""
            yValues(2) = Total45
            xValuesVacio(2) = ""
            yValues(3) = Total60
            xValuesVacio(3) = ""
            yValues(4) = Total90
            xValuesVacio(4) = ""

            Chart1.DataSource = Nothing

            If yValues(0) = 0 Then
                xValues(0) = ""
            Else
                xValues(0) = "< 30"
            End If

            If yValues(1) = 0 Then
                xValues(1) = ""
            Else
                xValues(1) = "> 30"
            End If

            If yValues(2) = 0 Then
                xValues(2) = ""
            Else
                xValues(2) = "> 45"
            End If

            If yValues(3) = 0 Then
                xValues(3) = ""
            Else
                xValues(3) = "> 60"
            End If

            If yValues(4) = 0 Then
                xValues(4) = ""
            Else
                xValues(4) = "> 90"
            End If

            Chart1.Series("Series1").ShowLabelAsValue = False
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 8pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Series("Series1").LabelFormat = "N0"
            Chart1.Series("Series1").FontAngle = 0
            Chart1.Legends("Default").Enabled = False
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)
            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub VentasPorZona(ByRef Chart As Dundas.Charting.WinControl.Chart, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal FechaDesde2 As Date, ByVal FechaHasta2 As Date, ByRef Dgv As DataGridView, ByRef lb12 As String, ByRef lb13 As String, ByRef lb14 As String)

        Try

            Dgv.Rows.Clear()
            Chart.Series(0).Points.Clear()
            Chart.Series(1).Points.Clear()

            Chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_ventasPorEstado"
            command.Parameters.AddWithValue("@FechaDesde", FechaDesde)
            command.Parameters.AddWithValue("@FechaHasta", FechaHasta)
            command.Parameters.AddWithValue("@FechaDesde2", FechaDesde2)
            command.Parameters.AddWithValue("@FechaHasta2", FechaHasta2)

            dr = command.ExecuteReader

            Dim total As Double = 0
            Dim totalCli As Integer = 0
            Dim totalAnt As Double = 0

            While dr.Read

                Dgv.Rows.Add(dr("Nombre"), dr("Clientes"), dr("Cartera"), 0, dr("Total"), 0, 0)

                total = total + dr("Total")
                totalCli = totalCli + dr("Clientes")
                totalAnt = totalAnt + dr("TotalAnt")

                Chart.Series(0).Points.AddXY(dr("Nombre"), dr("Total"))
                Chart.Series(1).Points.AddXY(dr("Nombre"), dr("TotalAnt"))

            End While

            lb13 = Format(CDbl(total.ToString), "#,##0.00")
            lb14 = Format(CDbl(totalAnt.ToString), "#,##0.00")
            lb12 = totalCli.ToString

            If total > 0 Then

                For cont2 As Integer = 0 To Dgv.RowCount - 1

                    Dgv.Rows(cont2).Cells(5).Value = (Dgv.Rows(cont2).Cells(4).Value / total)

                Next

            End If

            Chart.ChartAreas("Default").AxisX.Interval = 1

            Chart.ChartAreas("Default").AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount
            Chart.ChartAreas("Default").AxisX.IntervalType = DateTimeIntervalType.NotSet
            Chart.ChartAreas("Default").AxisY.LabelsAutoFit = True
            Chart.ChartAreas("Default").AxisX.LabelsAutoFit = True
            Chart.Series("Series1")("LabelStyle") = "Center"
            Chart.Series("Series1").FontAngle = 45
            Chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            Chart.Series("Series1").YValueType = ChartValueTypes.Double
            Chart.Series("Series2").XValueIndexed = True
            Chart.Series("Series2")("LabelStyle") = "Center"
            Chart.Series("Series2").FontAngle = 45
            Chart.Series("Series2")("ColumnLabelStyle") = "Vertical"
            Chart.Series("Series2").YValueType = ChartValueTypes.Double

            'Dgv.Sort(Dgv.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            Dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub GraficoCircularEstados(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByRef dgv As DataGridView, ByVal PorcDebajo As Integer)

        Try

            'dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_CuentaClientesEstados"
            dr = command.ExecuteReader

            While dr.Read

                total = total + dr("Estado")
                cont = cont + 1

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            dgv.Sort(dgv.Columns(1), System.ComponentModel.ListSortDirection.Descending)

            For cont3 As Integer = 0 To dgv.RowCount - 1

                yValues(cont3) = dgv.Rows(cont3).Cells(1).Value
                xValues(cont3) = dgv.Rows(cont3).Cells(0).Value
                xValuesVacio(cont3) = ""

                acum = acum + dgv.Rows(cont3).Cells(1).Value


            Next

            For cont2 As Integer = 0 To cont

                yValues(cont2) = (yValues(cont2) / acum) * 100

                If cont2 < cont Then

                    dgv.Rows(cont2).Cells(3).Value = dgv.Rows(cont2).Cells(1).Value / acum

                End If

                If yValues(cont2) < PorcDebajo Then

                    totalOtros = totalOtros + yValues(cont2)

                End If


            Next

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            'Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            'If PorcDebajo <> 0 Then
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 5 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            'Else
            'Chart1.Series("Series1").Points.DataBindXY(xValuesVacio, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False
            'End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros"

            ' Set the collected pie slice to be exploded
            'series1("CollectedSliceExploded") = "true"

            ' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros vendedores"

            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            'dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub TotalesInventario(ByRef chart As Dundas.Charting.WinControl.Chart, ByVal Tipo As Integer, ByVal Codigo As Integer, ByVal texto As String, ByRef Uni As Integer)

        Try
            chart.Series(0).Points.Clear()
            chart.Series(1).Points.Clear()


            chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_totalesinventario"
            command.Parameters.AddWithValue("@tipo", 1)
            dr = command.ExecuteReader

            While dr.Read

                If dr("TotalUnidades").GetType.ToString = "System.DBNull" Or dr("TotalInventario").GetType.ToString = "System.DBNull" Or dr("TotalCostoInventario").GetType.ToString = "System.DBNull" Then

                Else

                    chart.Series(0).Points.AddXY("Precio", dr("TotalInventario"))
                    chart.Series(0).Points.AddXY("Costo", dr("TotalCostoInventario"))
                    Uni = dr("TotalUnidades")

                End If

            End While

            chart.Titles(0).Text = "Totales Inventario"

            dr.Close()

            If Tipo = 1 Then

                'If My.Settings.Empresa = 1 Then
                '    command.CommandText = "sp_totalesPorMarca_comer"
                'ElseIf My.Settings.Empresa = 4 Then
                '    command.CommandText = "sp_totalesPorMarca_dist"
                'Else
                command.CommandText = "sp_totalesPorMarca"
                'End If
                command.Parameters.Clear()

                command.Parameters.AddWithValue("@Marca", texto)

                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

                    If texto = "Líneas Varias" Then
                        command.Parameters.AddWithValue("@Tipo", 2)
                    Else
                        command.Parameters.AddWithValue("@Tipo", 1)
                    End If

                Else

                    command.Parameters.AddWithValue("@Tipo", 1)

                End If

                dr = command.ExecuteReader


                While dr.Read

                    If cont = 1 Then

                        If dr("TotalVentas").GetType.ToString = "System.DBNull" Or dr("TotalCosto").GetType.ToString = "System.DBNull" Then


                        Else

                            chart.Series(1).Points.AddXY("Precio (Marca)", dr("TotalVentas"))
                            chart.Series(1).Points.AddXY("Costo (Marca)", dr("TotalCosto"))

                        End If

                    End If

                    cont = cont + 1

                End While

            End If

            If Tipo = 2 Then

                'If My.Settings.Empresa = 1 Then
                '    command.CommandText = "sp_totalesPorGrupo_comer"
                'ElseIf My.Settings.Empresa = 4 Then
                '    command.CommandText = "sp_totalesPorGrupo_dist"
                'Else
                command.CommandText = "sp_totalesPorGrupo"
                'End If

                command.Parameters.Clear()
                command.Parameters.AddWithValue("@Grupo", Codigo)
                dr = command.ExecuteReader

                While dr.Read

                    If cont = 1 Then

                        If dr("TotalVentas").GetType.ToString = "System.DBNull" Or dr("TotalCosto").GetType.ToString = "System.DBNull" Then


                        Else

                            chart.Series(1).Points.AddXY("Precio (Grupo)", dr("TotalVentas"))
                            chart.Series(1).Points.AddXY("Costo (Grupo)", dr("TotalCosto"))

                        End If

                    End If

                    cont = cont + 1

                End While

            End If


            If Tipo = 3 Then

                'If My.Settings.Empresa = 1 Then
                '    command.CommandText = "sp_totalesPorProveedor_comer"
                'ElseIf My.Settings.Empresa = 4 Then
                '    command.CommandText = "sp_totalesPorProveedor_dist"
                'Else
                command.CommandText = "sp_totalesPorProveedor"
                'End If

                command.Parameters.Clear()
                command.Parameters.AddWithValue("@CodPro", Codigo)
                dr = command.ExecuteReader

                While dr.Read

                    If dr("Proveedor") = Codigo Then

                        If dr("TotalVentas").GetType.ToString = "System.DBNull" Or dr("TotalCosto").GetType.ToString = "System.DBNull" Then


                        Else

                            chart.Series(1).Points.AddXY("Precio (Proveedor)", dr("TotalVentas"))
                            chart.Series(1).Points.AddXY("Costo (Proveedor)", dr("TotalCosto"))

                        End If

                    End If

                    cont = cont + 1

                End While

            End If

            cont = 0

            chart.ChartAreas("Default").AxisX.Interval = 1
            chart.ChartAreas("Default").AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount
            chart.ChartAreas("Default").AxisX.IntervalType = DateTimeIntervalType.NotSet
            chart.ChartAreas("Default").AxisY.LabelsAutoFit = True
            chart.ChartAreas("Default").AxisX.LabelsAutoFit = True
            chart.Series("Series1")("LabelStyle") = "Center"
            chart.Series("Series1").FontAngle = 0
            chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            chart.Series("Series1").YValueType = ChartValueTypes.Double
            chart.Series(1).Enabled = False

            If Tipo <> 0 Then
                chart.Series(1).Enabled = True
                chart.Series("Series2").XValueIndexed = True
                chart.Series("Series2")("LabelStyle") = "Center"
                chart.Series("Series2").FontAngle = 0
                chart.Series("Series2")("ColumnLabelStyle") = "Vertical"
                chart.Series("Series2").YValueType = ChartValueTypes.Double
                chart.Series(1).ShowLabelAsValue = True
                chart.Series(1).LegendText = texto
            End If

            chart.Series(0).LegendText = "Total Inventario"
            chart.Series(0).ShowLabelAsValue = True

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub MovimientoInventario(ByRef chart As Dundas.Charting.WinControl.Chart, ByVal Tipo As Integer, ByVal texto As String, ByVal weeks As Integer, ByVal Lentos() As Integer, ByVal Medios() As Integer, ByVal Rapidos() As Integer, ByVal nombre As String)

        Try
            chart.Series(0).Points.Clear()
            chart.Series(1).Points.Clear()

            chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_movimientoProductos"
            command.Parameters.AddWithValue("@Weeks", weeks)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@Cod", texto)
            dr = command.ExecuteReader

            chart.Series(0).LabelFormat = "N0"
            chart.Series(1).LabelFormat = "N0"

            chart.ChartAreas(0).AxisY.LabelStyle.Format = "N0"

            Dim Lento As Integer = 0
            Dim medio As Integer = 0
            Dim rapido As Integer = 0

            While dr.Read

                If Lentos(0) <= dr("Vendidos") And dr("Vendidos") <= Lentos(1) Then

                    Lento = Lento + 1

                ElseIf Medios(0) <= dr("Vendidos") And dr("Vendidos") <= Medios(1) Then

                    medio = medio + 1

                ElseIf dr("Vendidos") >= Rapidos(1) Then

                    rapido = rapido + 1

                End If

            End While


            dr.Close()

            For cont = 0 To 2

                If cont = 0 Then
                    chart.Series(0).Points.AddXY("Mov. Lento", Lento)
                ElseIf cont = 1 Then
                    chart.Series(0).Points.AddXY("Mov. Medio", medio)
                Else
                    chart.Series(0).Points.AddXY("Mpv. Rápido", rapido)
                End If

            Next

            cont = 0

            If Tipo = 1 Then

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()

                command.CommandText = "sp_movimientoProductos"
                command.Parameters.AddWithValue("@Weeks", weeks)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@Cod", texto)
                dr = command.ExecuteReader

                Lento = 0
                medio = 0
                rapido = 0

                While dr.Read

                    If Lentos(0) <= dr("Vendidos") And dr("Vendidos") <= Lentos(1) Then

                        Lento = Lento + 1

                    ElseIf Medios(0) <= dr("Vendidos") And dr("Vendidos") <= Medios(1) Then

                        medio = medio + 1

                    ElseIf dr("Vendidos") >= Rapidos(1) Then

                        rapido = rapido + 1

                    End If

                End While

                dr.Close()

                For cont = 0 To 2

                    If cont = 0 Then
                        chart.Series(1).Points.AddXY("Mov. Lento", Lento)
                    ElseIf cont = 1 Then
                        chart.Series(1).Points.AddXY("Mov. Medio", medio)
                    Else
                        chart.Series(1).Points.AddXY("Mpv. Rápido", rapido)
                    End If

                Next

            End If

            cont = 0

            If Tipo = 2 Then

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()

                command.CommandText = "sp_movimientoProductos"
                command.Parameters.AddWithValue("@Weeks", weeks)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@Cod", texto)
                dr = command.ExecuteReader

                Lento = 0
                medio = 0
                rapido = 0

                While dr.Read

                    If Lentos(0) <= dr("Vendidos") And dr("Vendidos") <= Lentos(1) Then

                        Lento = Lento + 1

                    ElseIf Medios(0) <= dr("Vendidos") And dr("Vendidos") <= Medios(1) Then

                        medio = medio + 1

                    ElseIf dr("Vendidos") >= Rapidos(1) Then

                        rapido = rapido + 1

                    End If

                End While


                dr.Close()

                For cont = 0 To 2

                    If cont = 0 Then
                        chart.Series(1).Points.AddXY("Mov. Lento", Lento)
                    ElseIf cont = 1 Then
                        chart.Series(1).Points.AddXY("Mov. Medio", medio)
                    Else
                        chart.Series(1).Points.AddXY("Mpv. Rápido", rapido)
                    End If

                Next

            End If

            cont = 0

            If Tipo = 3 Then

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()

                command.CommandText = "sp_movimientoProductos"
                command.Parameters.AddWithValue("@Weeks", weeks)
                command.Parameters.AddWithValue("@Tipo", Tipo)
                command.Parameters.AddWithValue("@Cod", texto)
                dr = command.ExecuteReader

                Lento = 0
                medio = 0
                rapido = 0

                While dr.Read

                    If Lentos(0) <= dr("Vendidos") And dr("Vendidos") <= Lentos(1) Then

                        Lento = Lento + 1

                    ElseIf Medios(0) <= dr("Vendidos") And dr("Vendidos") <= Medios(1) Then

                        medio = medio + 1

                    ElseIf dr("Vendidos") >= Rapidos(1) Then

                        rapido = rapido + 1

                    End If

                End While


                dr.Close()

                For cont = 0 To 2

                    If cont = 0 Then
                        chart.Series(1).Points.AddXY("Mov. Lento", Lento)
                    ElseIf cont = 1 Then
                        chart.Series(1).Points.AddXY("Mov. Medio", medio)
                    Else
                        chart.Series(1).Points.AddXY("Mpv. Rápido", rapido)
                    End If

                Next

            End If

            cont = 0

            chart.ChartAreas("Default").AxisX.Interval = 1
            chart.ChartAreas("Default").AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount
            chart.ChartAreas("Default").AxisX.IntervalType = DateTimeIntervalType.NotSet
            chart.ChartAreas("Default").AxisY.LabelsAutoFit = True
            chart.ChartAreas("Default").AxisX.LabelsAutoFit = True
            chart.Series("Series1")("LabelStyle") = "Center"
            chart.Series("Series1").FontAngle = 0
            chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            chart.Series("Series1").YValueType = ChartValueTypes.Double
            chart.Series(1).Enabled = False

            If Tipo <> 0 Then
                chart.Series(1).Enabled = True
                chart.Series("Series2").XValueIndexed = True
                chart.Series("Series2")("LabelStyle") = "Center"
                chart.Series("Series2").FontAngle = 0
                chart.Series("Series2")("ColumnLabelStyle") = "Vertical"
                chart.Series("Series2").YValueType = ChartValueTypes.Double
                chart.Series(1).ShowLabelAsValue = True
                chart.Series(1).LegendText = nombre
            End If

            chart.Series(0).LegendText = "Total Inventario"
            chart.Series(0).ShowLabelAsValue = True

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub GraficoCircularTotalPorMarcas(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByVal PorcDebajo As Integer)

        Try

            'dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            'If My.Settings.Empresa <> 1 Then
            command.CommandText = "sp_totalesPorMarca"
            'Else
            'command.CommandText = "sp_totalesPorMarca_comer"
            'End If

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Marca", "")
            command.Parameters.AddWithValue("@Tipo", 0)
            dr = command.ExecuteReader

            While dr.Read

                total = total + 1

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            'If My.Settings.Empresa <> 1 Then
            '    command.CommandText = "sp_totalesPorMarca"
            'Else
            command.CommandText = "sp_totalesPorMarca_comer"
            'End If

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Marca", "")
            command.Parameters.AddWithValue("@Tipo", 0)
            dr = command.ExecuteReader

            While dr.Read

                If dr("Marca").GetType.ToString = "System.DBNull" Then

                Else

                    yValues(cont) = dr("Total")
                    xValues(cont) = dr("Marca")
                    xValuesVacio(cont) = ""

                    acum = acum + dr("Total")

                    cont = cont + 1

                End If
            End While

            For cont2 As Integer = 0 To cont

                yValues(cont2) = (yValues(cont2) / acum) * 100

                If yValues(cont2) < PorcDebajo Then

                    totalOtros = totalOtros + yValues(cont2)

                End If


            Next

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            'Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Titles(0).Text = "Totales por marcas"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            'If PorcDebajo <> 0 Then
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 5 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            'Else
            'Chart1.Series("Series1").Points.DataBindXY(xValuesVacio, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False
            'End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros"

            ' Set the collected pie slice to be exploded
            'series1("CollectedSliceExploded") = "true"

            ' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros"

            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            'dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub GraficoCircularTotalPorMarcas2(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByVal PorcDebajo As Integer, ByVal marca As String)

        Try

            'dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            'If My.Settings.Empresa <> 1 Then
            command.CommandText = "sp_totalesPorMarca"
            'Else
            '    command.CommandText = "sp_totalesPorMarca_comer"
            'End If

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Marca", marca)

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

                If marca = "Líneas Varias" Then
                    command.Parameters.AddWithValue("@Tipo", 2)
                Else
                    command.Parameters.AddWithValue("@Tipo", 1)
                End If

            Else

                command.Parameters.AddWithValue("@Tipo", 1)

            End If


            dr = command.ExecuteReader

            While dr.Read

                total = total + 1

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            'If My.Settings.Empresa <> 1 Then
            command.CommandText = "sp_totalesPorMarca"
            'Else
            '    command.CommandText = "sp_totalesPorMarca_comer"
            'End If

            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Marca", marca)

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

                If marca = "Líneas Varias" Then
                    command.Parameters.AddWithValue("@Tipo", 2)
                Else
                    command.Parameters.AddWithValue("@Tipo", 1)
                End If

            Else

                command.Parameters.AddWithValue("@Tipo", 1)

            End If

            dr = command.ExecuteReader

            While dr.Read

                yValues(cont) = dr("TotalVentas")
                If cont = 1 Then
                    xValues(cont) = marca
                Else
                    xValues(cont) = "Otras marcas"
                End If

                xValuesVacio(cont) = ""

                acum = acum + dr("TotalVentas")

                cont = cont + 1

            End While

            For cont2 As Integer = 0 To cont

                yValues(cont2) = (yValues(cont2) / acum) * 100

                If yValues(cont2) < PorcDebajo Then

                    totalOtros = totalOtros + yValues(cont2)

                End If


            Next

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            'Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Titles(0).Text = "Totales por marcas"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            'If PorcDebajo <> 0 Then
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 5 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            'Else
            'Chart1.Series("Series1").Points.DataBindXY(xValuesVacio, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False
            'End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros Productos"

            ' Set the collected pie slice to be exploded
            'series1("CollectedSliceExploded") = "true"

            ' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros"

            Chart1.Titles(0).Text = "Marca '" + marca + "' Vs. Total"

            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            'dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub GraficoCircularTotalPorGrupos(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByVal PorcDebajo As Integer, ByVal grupo As Integer, ByVal NombreGrupo As String)

        Try

            'dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_totalesPorGrupo"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Grupo", grupo)
            dr = command.ExecuteReader

            While dr.Read

                total = total + 1

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            command.CommandText = "sp_totalesPorGrupo"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Grupo", grupo)
            dr = command.ExecuteReader

            While dr.Read

                yValues(cont) = dr("TotalVentas")
                If cont = 1 Then
                    xValues(cont) = NombreGrupo
                Else
                    xValues(cont) = "Otros productos"
                End If

                xValuesVacio(cont) = ""

                acum = acum + dr("TotalVentas")

                cont = cont + 1

            End While

            For cont2 As Integer = 0 To cont

                yValues(cont2) = (yValues(cont2) / acum) * 100

                If yValues(cont2) < PorcDebajo Then

                    totalOtros = totalOtros + yValues(cont2)

                End If


            Next

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            'Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Titles(0).Text = "Totales por marcas"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            'If PorcDebajo <> 0 Then
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 5 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            'Else
            'Chart1.Series("Series1").Points.DataBindXY(xValuesVacio, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False
            'End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros Productos"

            ' Set the collected pie slice to be exploded
            'series1("CollectedSliceExploded") = "true"

            ' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros"

            Chart1.Titles(0).Text = "Grupo '" + NombreGrupo + "' Vs. Total"

            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            'dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub GraficoCircularTotalPorProveedor(ByRef Chart1 As Dundas.Charting.WinControl.Chart, ByVal PorcDebajo As Integer, ByVal Proveedor As Integer, ByVal NombreProveedor As String)

        Try

            'dgv.Rows.Clear()

            Dim xValues() As String
            Dim yValues() As Double
            Dim xValuesVacio() As String


            Chart1.DataSource = Nothing
            Dim cont As Integer = 0
            Dim total As Integer = 0
            Dim acum As Double = 0
            Dim totalOtros As Double = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            If My.Settings.Empresa = 1 Then
                command.CommandText = "sp_totalesPorProveedor_comer"
            Else
                command.CommandText = "sp_totalesPorProveedor"
            End If
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodPro", Proveedor)
            dr = command.ExecuteReader

            While dr.Read

                total = total + 1

            End While

            ReDim xValues(total)
            ReDim yValues(total)
            ReDim xValuesVacio(total)

            dr.Close()

            If My.Settings.Empresa = 1 Then
                command.CommandText = "sp_totalesPorProveedor_comer"
            Else
                command.CommandText = "sp_totalesPorProveedor"
            End If
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@CodPro", Proveedor)
            dr = command.ExecuteReader

            While dr.Read

                yValues(cont) = dr("TotalVentas")
                If cont = 0 Then
                    xValues(cont) = NombreProveedor
                Else
                    xValues(cont) = "Otros Productos"
                End If

                xValuesVacio(cont) = ""

                acum = acum + dr("TotalVentas")

                cont = cont + 1

            End While

            For cont2 As Integer = 0 To cont

                yValues(cont2) = (yValues(cont2) / acum) * 100

                If yValues(cont2) < PorcDebajo Then

                    totalOtros = totalOtros + yValues(cont2)

                End If


            Next

            Chart1.Palette = ChartColorPalette.Vegas
            Chart1.Series("Series1").ShowLabelAsValue = True
            Chart1.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart1.Series("Series1").SmartLabels.Enabled = True
            'Chart1.Series("Series1").SmartLabels.MarkerOverlapping = False
            'Chart1.Series("Series1").SmartLabels.HideOverlapped = True
            Chart1.Series("Series1").XValueIndexed = True
            Chart1.Series("Series1")("LabelStyle") = "Center"
            Chart1.Titles(0).Text = "Totales por marcas"
            Chart1.Series("Series1").LabelFormat = "P"
            Chart1.Series("Series1").FontAngle = -15
            'If PorcDebajo <> 0 Then
            Chart1.Series("Series1").Points.DataBindXY(xValues, yValues)

            If PorcDebajo = 0 Then

                For cont2 As Integer = 0 To cont - 1

                    If yValues(cont2) < 5 Then

                        Chart1.Series("Series1").Points(cont2).AxisLabel = ""
                        Chart1.Series("Series1").Points(cont2).LegendText = xValues(cont2)
                        Chart1.Series("Series1").Points(cont2).ShowLabelAsValue = False

                    End If

                Next

            End If

            'Else
            'Chart1.Series("Series1").Points.DataBindXY(xValuesVacio, yValues)
            'Chart1.Series("Series1").SmartLabels.Enabled = False
            'Chart1.Series("Series1").ShowLabelAsValue = False
            'End If

            Chart1.Series("Series1")("PieLabelStyle") = "Inside"
            Chart1.Series("Series1")("PieDrawingStyle") = "SoftEdge"

            Dim series1 As Series = Chart1.Series(0)

            'If PorcDebajo <> 0 Then

            ' Set the threshold under which all points will be collected
            series1("CollectedThreshold") = PorcDebajo.ToString

            ' Set the threshold type to be a percentage of the pie
            ' When set to false, this property uses the actual value to determine the collected threshold
            series1("CollectedThresholdUsePercent") = "true"

            ' Set the label of the collected pie slice
            series1("CollectedLabel") = "       " + (Format(totalOtros, "#,##0.00")).ToString + " %"

            ' Set the legend text of the collected pie slice
            series1("CollectedLegendText") = "Otros Productos"

            ' Set the collected pie slice to be exploded
            'series1("CollectedSliceExploded") = "true"

            ' Set the color of the collected pie slice
            'series1("CollectedColor") = "Green"

            ' Set the tooltip of the collected pie slice
            series1("CollectedToolTip") = "Otros"


            Chart1.Titles(0).Text = "Proveedor '" + NombreProveedor + "' Vs. Total"
            'Else

            'series1("CollectedThresholdUsePercent") = "false"

            'End If

            'dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub lv_Producto(ByRef dg As DataGridView, ByVal s As String, ByVal Tipo As Integer)
        Try

            dg.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_lvProducto"
            command.Parameters.AddWithValue("@nom", s)
            command.Parameters.AddWithValue("@tipo", Tipo)
            dr = command.ExecuteReader()
            While dr.Read
                dg.Rows.Add(dr("codigoInterno"), dr("nombre"), dr("Modelo"), dr("CantidadExistencia"))
            End While

        Catch ex As Exception

            MsgBox("Error cargando lista de productos", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()
            dg.ClearSelection()

        End Try

    End Sub

    Public Shared Sub VentasPorMes(ByVal Id As String, ByRef Chart As Dundas.Charting.WinControl.Chart, ByVal meses As Integer, ByVal Exist As Integer)

        Try

            Chart.Series(0).Points.Clear()
            Chart.Series(1).Points.Clear()

            Dim Ventas As Integer = 0
            Dim Compras As Integer = 0
            Dim AJustes As Integer = 0
            Dim dt As New DataTable

            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            Chart.Palette = ChartColorPalette.Pastel
            Chart.Series("Series1").Type = SeriesChartType.Line
            Chart.Series("Series1").Color = Color.DodgerBlue
            Chart.Series("Series2").Type = SeriesChartType.Line
            Chart.Series("Series2").Color = Color.Firebrick
            Chart.Series(1).Enabled = True

            dt.Columns.Add("Mes")
            dt.Columns.Add("Ventas")
            dt.Columns.Add("Compras")
            dt.Columns.Add("AjustesNC")
            dt.Columns.Add("Ajustes")
            dt.Columns.Add("Exist")

            command.CommandText = "sp_ventasPorMes"
            command.Parameters.AddWithValue("@Cod", Id)
            command.Parameters.AddWithValue("@Meses", meses)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@FechaMin", Today)
            command.Parameters.AddWithValue("@FechaMax", Today)

            dr = command.ExecuteReader

            While dr.Read

                dt.Rows.Add(dr("Mes"), dr("Cantidad"), 0, 0, 0, Exist)

            End While

            dr.Close()

            command.Parameters.Clear()
            command.CommandText = "sp_ComprasPorMes"
            command.Parameters.AddWithValue("@Cod", Id)
            command.Parameters.AddWithValue("@Meses", meses)

            dr = command.ExecuteReader

            While dr.Read

                dt.Rows(cont).Item(2) = dr("Compras")

                cont = cont + 1

            End While

            dr.Close()

            cont = 0

            command.Parameters.Clear()
            command.CommandText = "sp_AjustesPorMes"
            command.Parameters.AddWithValue("@Cod", Id)
            command.Parameters.AddWithValue("@Meses", meses)
            command.Parameters.AddWithValue("@Tipo", 0)

            dr = command.ExecuteReader

            While dr.Read

                dt.Rows(cont).Item(3) = dr("Ajustes")

                cont = cont + 1

            End While

            dr.Close()

            cont = 0

            command.Parameters.Clear()
            command.CommandText = "sp_AjustesPorMes2"
            command.Parameters.AddWithValue("@Cod", Id)
            command.Parameters.AddWithValue("@Meses", meses)

            dr = command.ExecuteReader

            While dr.Read

                dt.Rows(cont).Item(3) = dr("Ajustes")

                cont = cont + 1

            End While

            dr.Close()

            cont = 0

            Dim total As Integer = 0

            For cont = 0 To dt.Rows.Count - 1

                If cont = 0 Then
                    total = total + (CInt(dt.Rows(cont).Item(5)) + CInt(dt.Rows(cont).Item(1)) - CInt(dt.Rows(cont).Item(2)) - CInt(dt.Rows(cont).Item(3)) - CInt(dt.Rows(cont).Item(4)))
                Else
                    total = total + (CInt(dt.Rows(cont).Item(1)) - CInt(dt.Rows(cont).Item(2)) - CInt(dt.Rows(cont).Item(3)) - CInt(dt.Rows(cont).Item(4)))
                End If


            Next

            For cont = 0 To dt.Rows.Count - 1

                total = total - (CInt(dt.Rows(cont).Item(1)) - CInt(dt.Rows(cont).Item(2)) - CInt(dt.Rows(cont).Item(3)) - CInt(dt.Rows(cont).Item(4)))

                Chart.Series(0).Points.AddXY(CStr(dt.Rows(cont).Item(0)), CInt(dt.Rows(cont).Item(1)))

                Chart.Series(1).Points.AddXY(CStr(dt.Rows(cont).Item(0)), total)


            Next

            Chart.Series(0).LabelFormat = "N0"

            Chart.ChartAreas(0).AxisY.LabelStyle.Format = "N0"

            Chart.ChartAreas(0).AxisY.Margin = False
            Chart.ChartAreas(0).AxisX.Margin = False

            Chart.Series(0).ShowLabelAsValue = True

            Chart.Series(0).LegendText = "Ventas"
            Chart.Series(1).LegendText = "Existencia"

            Chart.Series("Series1").XValueIndexed = True
            Chart.Series("Series1")("LabelAppearance") = "Eras Medium ITC, 9pt"
            Chart.Series("Series1").FontAngle = 45
            Chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            Chart.Legends("Default").Enabled = True
            Chart.Series("Series1").YValueType = ChartValueTypes.Int
            Chart.Series("Series2").XValueIndexed = True
            'Chart.Series("Series2")("LabelStyle") = "Center"
            Chart.Series("Series2").FontAngle = 45
            Chart.Series("Series2")("ColumnLabelStyle") = "Vertical"
            Chart.Series("Series2").YValueType = ChartValueTypes.Int

            Chart.Titles(0).Text = "Ventas últimos " + meses.ToString + " Meses"

            Chart.Series(0).ShowInLegend = True
            Chart.Series(1).ShowInLegend = True



        Catch ex As Exception

            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Indicadores(ByVal Cod As String, ByVal Meses As Integer, ByRef Texto As String, ByRef Texto3 As String, ByRef Texto4 As String, ByRef MargenPromedio As String, ByRef rotacion As String, ByVal TotalInventario As Integer)

        Try

            Dim totalVentasBs As Double = 0
            Dim TotalUnidades As Integer = 0
            Dim TotalCostoBs As Double = 0
            Dim TotalCostoBsProducto As Double = 0
            Dim totalVentasBsProducto As Double = 0
            Dim TotalUnidadesProducto As Integer = 0
            Dim TotalAjustesProducto As Integer = 0

            command.Parameters.Clear()
            command.CommandText = "sp_TotalVentasPorPeriodo"
            command.Parameters.AddWithValue("@Meses", Meses)

            dr = command.ExecuteReader

            While dr.Read

                If dr("Unidades").GetType.ToString = "System.DBNull" Then
                    TotalUnidades = 0
                Else
                    TotalUnidades = dr("Unidades")
                End If

                If dr("VentasBs").GetType.ToString = "System.DBNull" Then
                    totalVentasBs = 0
                Else
                    totalVentasBs = dr("VentasBs")
                End If

                If dr("CostoBs").GetType.ToString = "System.DBNull" Then
                    TotalCostoBs = 0
                Else
                    TotalCostoBs = dr("CostoBs")
                End If

            End While

            dr.Close()

            command.Parameters.Clear()
            command.CommandText = "sp_TotalVentasPorPeriodoProducto"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Meses", Meses)

            dr = command.ExecuteReader

            While dr.Read

                If dr("Unidades").GetType.ToString = "System.DBNull" Then
                    TotalUnidadesProducto = 0
                Else
                    TotalUnidadesProducto = dr("Unidades")
                End If

                If dr("VentasBs").GetType.ToString = "System.DBNull" Then
                    totalVentasBsProducto = 0
                Else
                    totalVentasBsProducto = dr("VentasBs")
                End If

                If dr("CostoBs").GetType.ToString = "System.DBNull" Then
                    TotalCostoBsProducto = 0
                Else
                    TotalCostoBsProducto = dr("CostoBs")
                End If

            End While

            dr.Close()

            command.Parameters.Clear()
            command.CommandText = "sp_AjustesPorMes"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Meses", Meses)
            command.Parameters.AddWithValue("@Tipo", 1)

            dr = command.ExecuteReader

            While dr.Read

                If dr("Ajustes").GetType.ToString = "System.DBNull" Then
                    TotalAjustesProducto = 0
                Else
                    TotalAjustesProducto = TotalAjustesProducto + dr("Ajustes")
                End If

            End While


            'Indice de Comercialidad del producto

            If TotalUnidades = 0 Then
                Texto = "--"
            Else
                Texto = Format((TotalUnidadesProducto / TotalUnidades), "#,##0.00%").ToString
            End If

            'Indice de Rentabilidad del Producto

            If TotalCostoBsProducto = 0 Then
                Texto3 = "0,00%"
            Else
                If totalVentasBs = 0 Then
                    Texto3 = "--"
                Else
                    If TotalCostoBs = 0 Then
                        Texto3 = "--"
                    Else
                        Texto3 = Format(((((totalVentasBsProducto / TotalCostoBsProducto) - 1) * (TotalUnidadesProducto)) / (((totalVentasBs / TotalCostoBs) - 1) * (TotalUnidades))), "#,##0.00%").ToString
                    End If

                End If

            End If

            'Indice de Calidad del Producto

            If TotalUnidadesProducto = 0 Then
                Texto4 = "--"
            Else
                Texto4 = Format(1 - (TotalAjustesProducto / TotalUnidadesProducto), "#,##0.00%").ToString
            End If

            'Margen Promedio

            If TotalCostoBs = 0 Then
                MargenPromedio = "--"
            Else
                MargenPromedio = Format(((totalVentasBs / TotalCostoBs) - 1), "#,##0.00%").ToString
            End If

            'Rotación de inventario

            If TotalInventario = 0 Then
                rotacion = "--"
            Else
                rotacion = Format((TotalUnidades / TotalInventario), "#,##0.0000").ToString
            End If

        Catch ex As Exception



        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Pronostico(ByVal Cod As String, ByVal Meses As Integer, ByRef Pronostico As String, ByVal Alfa As Double)

        Try

            Dim dt As New DataTable

            dt.Columns.Add("Fecha")
            dt.Columns.Add("Cantidad")

            command.Parameters.Clear()
            command.CommandText = "sp_VentasPorMes"
            command.Parameters.AddWithValue("@Cod", Cod)
            command.Parameters.AddWithValue("@Meses", Meses)
            command.Parameters.AddWithValue("@Tipo", 0)
            command.Parameters.AddWithValue("@FechaMin", Today)
            command.Parameters.AddWithValue("@FechaMax", Today)

            dr = command.ExecuteReader

            While dr.Read

                dt.Rows.Add(dr("Mes"), dr("Cantidad"))

            End While

            Dim prono As Double = 0
            Dim prono2 As Double = 0
            Dim Promedio As Double = 0
            Dim cont2 As Integer = 0

            For cont As Integer = dt.Rows.Count - 1 To 0 Step -1

                'Ft+1 =  α*xt +  (1-α)*Ft(Puede ser el promedio)

                If cont2 = 0 Then

                    prono = (Alfa) * CInt(dt.Rows(cont).Item(1))
                    'prono2 = (Alfa) * CInt(dt.Rows(cont).Item(1))

                End If

                Promedio = Promedio + CInt(dt.Rows(cont).Item(1))

                'prono2 = prono2 + ((Alfa) * Math.Pow((1 - (Alfa)), cont2) * CInt(dt.Rows(cont).Item(1)))

                cont2 = cont2 + 1

            Next

            Promedio = Promedio / Meses

            prono = prono + ((1 - (Alfa)) * Promedio)

            Pronostico = CInt(prono).ToString



        Catch ex As Exception



        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_VentasCliente(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer, ByVal Cod As Integer, ByRef lbl As String, ByRef lbl2 As String)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_ventasCliente"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            lbl = "0,00"
            lbl2 = "0"

            While dr.Read

                lbl = CDbl(lbl) + CDbl(dr("MontoTotal"))

                If Tipo = 3 Then
                    dgv.Rows.Add(dr("Cuenta").ToString + " Fact.", dr("Fecha"), dr("RazonSocial"), dr("MontoTotal"))
                Else
                    dgv.Rows.Add(dr("ControlInicio"), dr("Fecha"), dr("RazonSocial"), dr("MontoTotal"))
                End If

            End While

            lbl = Format(CDbl(lbl), "#,##0.00").ToString

            dr.Close()

            If Tipo = 0 Or Tipo = 1 Then

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.CommandText = "sp_ventasCliente"
                command.Parameters.AddWithValue("@Fecha1", Fecha1)
                command.Parameters.AddWithValue("@Fecha2", Fecha2)
                command.Parameters.AddWithValue("@Tipo", 4)
                command.Parameters.AddWithValue("@Cod", Cod)

                dr = command.ExecuteReader

                While dr.Read

                    lbl2 = dr("Clientes").ToString

                End While

            End If

        Catch ex As Exception

            MsgBox("Error cargando lista de ventas", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_NotasCliente(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer, ByVal Cod As Integer, ByRef lbl As String, ByRef lbl2 As String, ByRef pend As String, ByRef imp As String)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_NotasCliente"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            lbl = "0,00"
            lbl2 = "0,00"
            pend = "0"
            imp = "0"

            While dr.Read


                If dr("Tipo") = 0 Then
                    dgv.Rows.Add(dr("NroControl"), dr("ControlInicio"), dr("Fecha"), dr("RazonSocial"), dr("Monto"), "Desc.")
                Else
                    dgv.Rows.Add(dr("NroControl"), dr("ControlInicio"), dr("Fecha"), dr("RazonSocial"), dr("Monto"), "Dev.")
                End If

                If dr("NroControl") = 0 Then
                    lbl2 = CDbl(lbl2) + CDbl(dr("Monto"))
                    pend = CInt(pend) + 1
                Else
                    lbl = CDbl(lbl) + CDbl(dr("Monto"))
                    imp = CInt(imp) + 1
                End If

            End While

            lbl = Format(CDbl(lbl), "#,##0.00").ToString
            lbl2 = Format(CDbl(lbl2), "#,##0.00").ToString

        Catch ex As Exception

            MsgBox("Error cargando lista de notas de crédito", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Indicadores(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer, ByVal Cod As Integer, ByVal MaxCobranza As Integer, ByVal PPC As Double)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_indicadoresCliente"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            While dr.Read

                dgv.Rows.Add(dr("DPP"), PPC, dr("ChequesDev"), MaxCobranza)

            End While

        Catch ex As Exception

            MsgBox("Error cargando indicadores", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_VentasMarcasCliente(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer, ByVal Cod As Integer, ByRef lbl As String)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaVentasPorMarca"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            Dim total As Double = 0

            While dr.Read

                total = total + dr("Total")

            End While

            dr.Close()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaVentasPorMarca"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            While dr.Read

                dgv.Rows.Add(dr("Marca"), (dr("Total") / total), dr("Total"))

            End While

            lbl = Format(total, "#,##0.00").ToString

        Catch ex As Exception

            MsgBox("Error cargando lista de ventas por marca", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_CobranzasCliente(ByRef dgv As DataGridView, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Tipo As Integer, ByVal Cod As Integer, ByRef lbl As String)

        Try
            dgv.Rows.Clear()

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaClienteFacturas2"
            command.Parameters.AddWithValue("@Fecha1", Fecha1)
            command.Parameters.AddWithValue("@Fecha2", Fecha2)
            command.Parameters.AddWithValue("@Tipo", Tipo)
            command.Parameters.AddWithValue("@Cod", Cod)

            dr = command.ExecuteReader

            lbl = "0,00"

            While dr.Read

                lbl = CDbl(lbl) + CDbl(dr("MontoPendiente"))

                dgv.Rows.Add(dr("Control"), dr("RazonSocial"), DateAdd(DateInterval.Day, CInt(dr("DiasCred")), CDate(dr("Fecha"))), DateDiff(DateInterval.Day, dr("fecha"), Today.Date), dr("MontoTotal"), dr("MontoPendiente"))

            End While

            lbl = Format(CDbl(lbl), "#,##0.00").ToString

        Catch ex As Exception

            MsgBox("Error cargando lista de facturas pendientes", MsgBoxStyle.Exclamation, "Error")

        Finally

            dgv.ClearSelection()
            dr.Close()

        End Try

    End Sub

    Public Shared Sub VentasPorMesCliente(ByRef Chart As Dundas.Charting.WinControl.Chart, ByVal tipo As Integer, ByVal cod As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal meses As Integer)

        Try


            Chart.Series(0).Points.Clear()
            Chart.Series(1).Points.Clear()
            Chart.DataSource = Nothing
            Dim cont As Integer = 0

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()

            command.CommandText = "sp_VentasPorMesCliente"
            command.Parameters.AddWithValue("@cod", cod)
            command.Parameters.AddWithValue("@meses", meses)
            command.Parameters.AddWithValue("@Tipo", tipo)
            command.Parameters.AddWithValue("@FechaMax", fecha2)
            command.Parameters.AddWithValue("@FechaMin", fecha1)

            dr = command.ExecuteReader

            Dim total As Double = 0

            While dr.Read

                Chart.Series(0).Points.AddXY(dr("Mes"), dr("Ventas"))

            End While


            Chart.ChartAreas("Default").AxisX.Interval = 1

            Chart.ChartAreas("Default").AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount
            Chart.ChartAreas("Default").AxisX.IntervalType = DateTimeIntervalType.NotSet
            Chart.ChartAreas("Default").AxisY.Title = "Ventas(Bs)"
            Chart.ChartAreas("Default").AxisY.LabelsAutoFit = True
            Chart.ChartAreas("Default").AxisX.LabelsAutoFit = True
            Chart.Text = "Ventas por mes"
            Chart.Series("Series1")("LabelStyle") = "Center"
            Chart.Series("Series1").LabelFormat = "#,##0.00"
            Chart.Series("Series1")("LabelApereance") = "Eras Medium ITC, 7pt"
            Chart.Series("Series1")("ColumnLabelStyle") = "Vertical"
            Chart.Series("Series1").YValueType = ChartValueTypes.Double
            Chart.Series("Series2").Enabled = False
            Chart.Series("Series1").FontAngle = 90

        Catch ex As Exception

            Chart.Series(0).Points.Clear()
            MsgBox("Problema cargando el gráfico", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub DGV_Eficacia(ByRef dgv As DataGridView, ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal cod As Integer, ByRef Total As String, ByRef Total2 As String, ByRef PB As ProgressBar)

        Try

            Dim cuenta As Integer = 0
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_consultaClientesPorVendedor"
            command.CommandText = "sp_ventasPorMesVendedor"
            command.Parameters.AddWithValue("@FechaMin", fecha1)
            command.Parameters.AddWithValue("@FechaMax", fecha2)
            command.Parameters.AddWithValue("@Cod", cod)
            dr = command.ExecuteReader

            While dr.Read

                cuenta = cuenta + 1

            End While

            dr.Close()

            Total = "0"
            Total2 = "0"
            dgv.Rows.Clear()
            PB.Minimum = 0
            PB.Value = 0
            PB.Visible = True

            Dim TotalColumna As Double = 0
            Dim salto As Integer = 3
            Dim fila As Integer = 0
            Dim dif As Integer = DateDiff(DateInterval.Month, fecha1, fecha2)
            PB.Maximum = cuenta
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Clear()
            command.CommandText = "sp_ventasPorMesVendedor"
            command.Parameters.AddWithValue("@FechaMin", fecha1)
            command.Parameters.AddWithValue("@FechaMax", fecha2)
            command.Parameters.AddWithValue("@Cod", cod)

            For cont As Integer = 0 To dif

                dr = command.ExecuteReader
                fila = 0

                While dr.Read

                    If cont = 0 Then

                        If dr("Mes") = dgv.Columns(3).HeaderText.Replace("20", "") Then

                            dgv.Rows.Add(dr("CodigoCliente"), dr("RazonSocial"), dr("Facturas"), Format(dr("Ventas"), "#,##0.00").ToString)
                            Total = CDbl(Total) + dr("Ventas")
                            Total2 = CInt(Total2) + dr("Facturas")
                            PB.Value = PB.Value + 1
                            dgv.Rows(dgv.RowCount - 1).Cells(dgv.ColumnCount - 1).Value = CDbl(dgv.Rows(dgv.RowCount - 1).Cells(dgv.ColumnCount - 1).Value) + dr("Ventas")

                        End If

                    Else

                        If dr("Mes") = dgv.Columns(cont + salto).HeaderText.Replace("20", "") Then

                            dgv.Rows(fila).Cells(cont + salto - 1).Value = dr("Facturas")
                            dgv.Rows(fila).Cells(cont + salto).Value = Format(dr("Ventas"), "#,##0.00").ToString
                            dgv.Rows(fila).Cells(dgv.ColumnCount - 1).Value = CDbl(dgv.Rows(fila).Cells(dgv.ColumnCount - 1).Value) + dr("Ventas")
                            fila = fila + 1
                            Total = CDbl(Total) + dr("Ventas")
                            Total2 = CInt(Total2) + dr("Facturas")
                            PB.Value = PB.Value + 1

                        End If

                    End If

                End While

                dr.Close()
                salto = salto + 1

            Next

            For cont2 As Integer = 0 To dgv.RowCount - 1
                If dgv.Rows(cont2).Cells(dgv.ColumnCount - 1).Value = 0 Then
                    dgv.Rows(cont2).DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            Next

            Total = Format(CDbl(Total), "#,##0.00")
            dgv.ClearSelection()

        Catch ex As Exception

            MsgBox("Error consultando ventas", MsgBoxStyle.Critical, "Error")


        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Tbl_Eficacia(ByRef Tbl As DataTable, ByRef dgv As DataGridView, Byref v2 As Boolean, Byref v3 As Boolean, Byref v4 As Boolean, Byref v5 As Boolean, ByRef v6 As Boolean)

        Try

            Dim saltoPares As Integer = 0
            Dim saltoImpares As Integer = 0
            Tbl.Rows.Clear()

            For i As Integer = 0 To dgv.RowCount - 1

                saltoPares = 0
                saltoImpares = 0

                For j As Integer = 0 To dgv.ColumnCount - 1

                    If j = 0 Then

                        Tbl.Rows.Add(dgv(j, i).Value)

                    ElseIf (j = 4 And dgv.ColumnCount - 1 <> 4) Or (j = 6 And dgv.ColumnCount - 1 <> 6) Or (j = 8 And dgv.ColumnCount - 1 <> 8) Or (j = 10 And dgv.ColumnCount - 1 <> 10) Or (j = 12 And dgv.ColumnCount - 1 <> 12) Then

                        Tbl.Rows(i).Item(j + saltoPares) = CInt(dgv(j, i).Value)

                        If j = 4 Then
                            v2 = True
                        ElseIf j = 6 Then
                            v3 = True
                        ElseIf j = 8 Then
                            v4 = True
                        ElseIf j = 10 Then
                            v5 = True
                        ElseIf j = 12 Then
                            v6 = True
                        End If

                        Tbl.Rows(i).Item(j + saltoPares + 1) = True

                        saltoPares = saltoPares + 1

                    ElseIf (j = 5 And dgv.ColumnCount - 1 <> 5) Or (j = 7 And dgv.ColumnCount - 1 <> 7) Or (j = 9 And dgv.ColumnCount - 1 <> 9) Or (j = 11 And dgv.ColumnCount - 1 <> 11) Or (j = 13 And dgv.ColumnCount - 1 <> 13) Then

                        Tbl.Rows(i).Item(j + saltoImpares) = dgv(j, i).Value

                        saltoImpares = saltoImpares + 1

                    ElseIf j = 1 Or j = 2 Or j = 3 Then

                        Tbl.Rows(i).Item(j) = dgv(j, i).Value

                    ElseIf j = dgv.ColumnCount - 1 Then

                        Tbl.Rows(i).Item(Tbl.Columns.Count - 1) = Format(dgv(j, i).Value, "#,##0.00")

                    End If

                Next

            Next

        Catch ex As Exception

            MsgBox("Error creando reporte", MsgBoxStyle.Critical, "Error")

        Finally



        End Try

    End Sub

End Class