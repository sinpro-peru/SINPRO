Imports System.Data.SqlClient
Public Class DatosCalculoCostos

    Private Shared conex As SqlConnection
    Private Shared command As SqlCommand
    Private Shared dr As SqlDataReader

    Public Shared Sub inicializar(ByVal con As SqlConnection, ByVal com As SqlCommand)

        conex = con
        command = com
        command.Connection = conex

    End Sub

    Public Shared Sub Dgv_Costos(ByRef dgv As MyDataGridView4, ByVal cod As Integer, ByRef fecha As Date, ByRef prov As String, ByRef flete As String, ByRef otros As String, ByRef tcArancel As String, ByRef tcOtros As String, ByRef margen As String, ByRef cont2 As Integer, ByRef cont3 As Integer, ByRef cont4 As Double, ByRef cont5 As Double, ByRef cont6 As Double, ByRef cont7 As Double, ByRef arancel As Double, ByRef otros2 As Double, ByRef lb_totalP As Label)

        Try

            Dim Negritas As New Font(dgv.Font, FontStyle.Bold)
            Dim style As New DataGridViewCellStyle
            style.ForeColor = Color.Red

            style.Font = Negritas

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodP", cod)

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                command.CommandText = "sp_calculoCostos_BRWME"
            Else
                command.CommandText = "sp_calculoCostos"
            End If

            dr = command.ExecuteReader()
            Dim cont As Integer = 0

            While dr.Read

                dgv.Rows.Add(dr("Status"), CInt(dr("Cantidad")), dr("CodigoProducto"), dr("CodigoProductoF"), dr("Nombre"), dr("Modelo"), CDbl(dr("F.O.B.")), CDbl(dr("FleteySeguro")), CDbl(dr("CIF")), CDbl(dr("ArancelCompra")), CDbl(dr("ArancelBs")), CDbl(dr("Otros").ToString), CDbl(dr("CostoBs")), CDbl(0), CDbl(dr("Actual")), CDbl(dr("MaxPrecio")), CDbl(0), CInt(dr("CantidadExistencia")), CDate(dr("UltimaVta")), CInt(dr("3meses")), CDbl(dr("PrecioVentaFinal")), dr("FechaS"), dr("BackOrder"), CDbl(dr("Sub-Total")), CDbl(dr("FobAnt")), dr("CodigoArancelario"), dr("Marca"))

                If CInt(dgv.Rows(dgv.RowCount - 1).Cells(17).Value) > 0 Then

                    dgv.Rows(dgv.RowCount - 1).Cells(17).Style = style

                End If

                lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(dgv.Rows(cont).Cells(1).Value) * CDbl(dgv.Rows(cont).Cells(12).Value)), "#,##0.00")
                cont2 = cont2 + 1
                cont3 = cont3 + CDbl(dgv.Rows(cont).Cells(1).Value)
                cont4 = cont4 + (CDbl(dgv.Rows(cont).Cells(6).Value) * CDbl(dgv.Rows(cont).Cells(1).Value))
                cont5 = cont5 + ((CDbl(dgv.Rows(cont).Cells(6).Value) + CDbl(dgv.Rows(cont).Cells(7).Value)) * CDbl(dgv.Rows(cont).Cells(1).Value))
                cont6 = cont6 + ((CDbl(dgv.Rows(cont).Cells(8).Value) * CDbl(dgv.Rows(cont).Cells(1).Value)) * CDbl(dr("TCOtros")))
                cont7 = cont7 + ((CDbl(dgv.Rows(cont).Cells(6).Value) * CDbl(dgv.Rows(cont).Cells(1).Value)) * CDbl(dr("TCOtros")))
                arancel = arancel + (CInt(dgv.Rows(cont).Cells(1).Value) * CDbl(dgv.Rows(cont).Cells(10).Value))
                otros2 = otros2 + (CInt(dgv.Rows(cont).Cells(1).Value) * CDbl(dgv.Rows(cont).Cells(11).Value))

                If cont = 0 Then

                    fecha = dr("Fecha")
                    prov = dr("Proveedor")
                    flete = dr("Flete")
                    otros = dr("OtrosGastos")
                    tcArancel = dr("tcAranceles")
                    tcOtros = dr("TCOtros")
                    margen = dr("margen")

                End If

                ''CIF --------------
                dgv.Rows(dgv.RowCount - 1).Cells(8).Value = CDbl(Format(CDbl(dgv.Rows(dgv.RowCount - 1).Cells(6).Value) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(7).Value), "#,##0.00"))
                ''CIF --------------

                ''Aranc. Bs --------------
                If CDbl((CDbl(dgv.Rows(dgv.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(dgv.Rows(dgv.CurrentCell.RowIndex).Cells(8).Value) * tcArancel) = 0 Then
                    dgv.Rows(dgv.CurrentCell.RowIndex).Cells(10).Value = CDbl("0,00")
                Else
                    dgv.Rows(dgv.CurrentCell.RowIndex).Cells(10).Value = CDbl(Format((((CDbl(dgv.Rows(dgv.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(dgv.Rows(dgv.CurrentCell.RowIndex).Cells(8).Value)) * tcArancel), "#,##0.00"))
                End If
                ''Aranc. Bs --------------

                ''Costo Bs --------------
                If ((CDbl(dgv.Rows(dgv.RowCount - 1).Cells(8).Value) * CDbl(tcOtros)) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(10).Value) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(11).Value)) = 0 Then
                    dgv.Rows(dgv.RowCount - 1).Cells(12).Value = CDbl(0)
                Else
                    dgv.Rows(dgv.RowCount - 1).Cells(12).Value = (CDbl(dgv.Rows(dgv.RowCount - 1).Cells(8).Value) * CDbl(tcOtros)) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(10).Value) + (CDbl(dgv.Rows(dgv.RowCount - 1).Cells(11).Value * CDbl(tcOtros)))
                End If
                ''Costo Bs --------------

                ''Precio Bs --------------
                If CDbl((((CDbl(dgv.Rows(dgv.RowCount - 1).Cells(12).Value) * (CDbl(margen) / 100)) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(12).Value)))) = 0 Then
                    dgv.Rows(dgv.RowCount - 1).Cells(13).Value = CDbl(0)
                Else
                    dgv.Rows(dgv.RowCount - 1).Cells(13).Value = CDbl(Format((((CDbl(dgv.Rows(dgv.RowCount - 1).Cells(12).Value) * (CDbl(margen) / 100)) + CDbl(dgv.Rows(dgv.RowCount - 1).Cells(12).Value))), "#,##0.00"))
                End If
                ''Precio Bs --------------

                ''DIF (%) --------------
                dgv.Rows(dgv.RowCount - 1).Cells(16).Value = CDbl(Format(((CDbl(dgv.Rows(dgv.RowCount - 1).Cells(20).Value) - CDbl(dgv.Rows(dgv.RowCount - 1).Cells(14).Value)) / CDbl(dgv.Rows(dgv.RowCount - 1).Cells(14).Value) * 100), "#,##0.00"))
                ''DIF (%) -------------- 

                ''Precio Final Bs. --------------
                dgv.Rows(dgv.RowCount - 1).Cells(20).Value = CDbl(dgv.Rows(dgv.RowCount - 1).Cells(13).Value)
                ''Precio Final Bs. --------------

                dgv.Rows(cont).Cells(20).Value = dr("PrecioVentaFinal")
                dgv.Rows(cont).Cells(7).Value = dr("FleteYSeguro")
                dgv.Rows(cont).Cells(11).Value = dr("Otros")

                cont = cont + 1

            End While

        Catch ex As Exception

            MsgBox("Error cargando el pedido", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Dgv_UltimaCompra(ByRef dgv As DataGridView, ByVal codP As Integer, ByVal CodPro As String)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodP", codP)
            command.Parameters.AddWithValue("@CodPro", CodPro)
            command.CommandText = "sp_Ultima_Compra_Producto"
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Nombre"), dr("Fecha"), dr("Cantidad"), dr("FOB"), dr("Flete"), dr("Otros"), dr("CostoBs"))

            End While

        Catch ex As Exception

            MsgBox("Error cargando última compra", MsgBoxStyle.Critical, "Error")

        Finally

            dgv.ClearSelection()

            dr.Close()

        End Try

    End Sub

    Public Shared Sub Dgv_UltimaCotizacion(ByRef dgv As DataGridView, ByVal codP As Integer, ByVal CodPro As String)

        Try

            dgv.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodP", codP)
            command.Parameters.AddWithValue("@CodPro", CodPro)
            command.CommandText = "sp_Ultimo_Pedido_Producto"
            dr = command.ExecuteReader()

            While dr.Read

                dgv.Rows.Add(dr("Status"), dr("Nombre"), dr("Fecha"), dr("Cantidad"), dr("FOB"))

            End While

        Catch ex As Exception

            MsgBox("Error cargando última cotización", MsgBoxStyle.Critical, "Error")

        Finally

            dgv.ClearSelection()

            dr.Close()

        End Try

    End Sub


    Public Shared Sub ActualizaCostos(ByVal Status As String, ByVal fob As Double, ByVal flete As Double, ByVal otros As Double, ByVal fechaS As Date, ByVal cantidad As Integer, ByVal Pedido As Integer, ByVal Producto As String, ByVal PVF As Double, ByVal aran As Double, ByVal aran2 As Double, ByVal bo As Boolean)

        command.Parameters.Clear()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CodP", Pedido)
        command.Parameters.AddWithValue("@Flete", flete)
        command.Parameters.AddWithValue("@Otros", otros)
        command.Parameters.AddWithValue("@Fecha", fechaS)
        command.Parameters.AddWithValue("@Cant", cantidad)
        command.Parameters.AddWithValue("@Fob", fob)
        command.Parameters.AddWithValue("@Cod", Producto)
        command.Parameters.AddWithValue("@Status", Status)
        command.Parameters.AddWithValue("@PVF", PVF)
        command.Parameters.AddWithValue("@aran", aran)
        command.Parameters.AddWithValue("@aran2", aran2)
        command.Parameters.AddWithValue("@bo", bo)
        command.CommandText = "sp_ActualizaCostos"
        command.ExecuteNonQuery()

    End Sub
    Public Shared Sub ActualizaPedidoProveedor(ByVal flete As Double, ByVal otrosG As Double, ByVal Pedido As Integer, ByVal TCArancel As Double, ByVal TCOtros As Double, ByVal Margen As Double, ByVal aranceles As Double)

        Try

            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodP", Pedido)
            command.Parameters.AddWithValue("@Flete", flete)
            command.Parameters.AddWithValue("@OtrosG", otrosG)
            command.Parameters.AddWithValue("@TCArancel", TCArancel)
            command.Parameters.AddWithValue("@TCOtros", TCOtros)
            command.Parameters.AddWithValue("@Margen", Margen)
            command.Parameters.AddWithValue("@Aranceles", aranceles)
            command.CommandText = "sp_ActualizaPedidoProveedor"
            command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error modificando el pedido", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub


    Public Shared Sub Dgv_Impuestos(ByRef DGV As DataGridView, ByVal codP As Integer, ByVal TC As Double, ByVal IVA As Double, ByRef TotADV As String, ByRef TotTSA As String, ByRef TotTSS As String, ByRef TotIVA As String, ByVal TotalFact As Double, ByVal FleteYSeguro As Double)

        Try

            Dim CodigoA As New Font(DGV.Font, FontStyle.Bold)

            Dim arancel As String = ""
            DGV.Rows.Clear()
            command.Parameters.Clear()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CodP", codP)
            command.CommandText = "sp_totalporCodigoArancelarioPedido"
            dr = command.ExecuteReader()

            Dim porc As Double = 0
            Dim porcF As Double = 0
            Dim ADV As Double = 0
            Dim TSA As Double = 0.005
            Dim TSS As Double = 0.005

            'Totales
            Dim TotalADV As Double = 0
            Dim TotalTSA As Double = 0
            Dim TotalTSS As Double = 0
            Dim TotalIVA As Double = 0

            IVA = IVA / 100

            While dr.Read

                Dim Base As Double = dr("TotalPorCodigo") * TC

                porc = dr("TotalPorCodigo") / TotalFact
                porcF = FleteYSeguro * porc

                Base += porcF

                ADV = dr("Impuesto") / 100

                DGV.Rows.Add(dr("CodigoArancelario").ToString, "", "", Format(Base, "#,##0.00"))

                DGV.Rows(DGV.RowCount - 1).DefaultCellStyle.BackColor = Color.DarkOrange
                DGV.Rows(DGV.RowCount - 1).DefaultCellStyle.Font = CodigoA
                DGV.Rows(DGV.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
                DGV.Rows(DGV.RowCount - 1).Height = 25

                DGV.Rows.Add("ADV", Format(Base, "#,##0.00"), Format((ADV * 100), "#,##0.00").ToString & "%", Format(Base * ADV, "#,##0.00"))
                DGV.Rows.Add("TSA", Format(Base, "#,##0.00"), Format((TSA * 100), "#,##0.00").ToString & "%", Format(Base * TSA, "#,##0.00"))
                DGV.Rows.Add("TSS", Format(Base, "#,##0.00"), Format((TSS * 100), "#,##0.00").ToString & "%", Format(Base * TSS, "#,##0.00"))
                DGV.Rows.Add("IVA", Format(Base, "#,##0.00"), Format((IVA * 100), "#,##0.00").ToString & "%", Format(Base * IVA, "#,##0.00"))
                DGV.Rows.Add("", "", "Total", Format((Base + (Base * ADV) + (Base * TSA) + (Base * TSS)) * IVA, "#,##0.00"))
                DGV.Rows(DGV.RowCount - 1).DefaultCellStyle.Font = CodigoA

                TotalADV = TotalADV + (Base * ADV)
                TotalTSA = TotalTSA + (Base * TSA)
                TotalTSS = TotalTSS + (Base * TSS)
                TotalIVA = TotalIVA + (Base * IVA)

            End While

            TotIVA = Format(TotalIVA, "#,##0.00")
            TotADV = Format(TotalADV, "#,##0.00")
            TotTSS = Format(TotalTSS, "#,##0.00")
            TotTSA = Format(TotalTSA, "#,##0.00")

        Catch ex As Exception

            MsgBox("Error cargando los impuestos", MsgBoxStyle.Critical, "Error")

        Finally

            dr.Close()
            DGV.ClearSelection()

        End Try

    End Sub

End Class