Public Class Frm_CalculoCostos

    Public pedido As Integer = 0
    Public frm As Frm_AsignacionFlete
    Public cont As Integer = 0
    Public listo As Boolean = False
    Public Shared columna As Boolean = False
    Public cant As Integer = 0
    Public fob2 As Double = 0
    Public Aranceles2 As Double = 0
    Public otrosg As Double = 0
    Public precioFinal2 As Double = 0
    Public sta As Char = "S"
    Public choice As Integer = 0
    Public fecha As Date
    Public prov As String
    Public codProv As Integer = 0
    Dim entre As Boolean = False

    Private Sub Frm_CalculoCostos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        ReCalcular()

    End Sub

    Private Sub Frm_CalculoCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim cont3 As Integer = 0
        Dim cont4 As Double = 0
        Dim cont5 As Double = 0
        Dim cont6 As Double = 0
        Dim cont7 As Double = 0
        Dim arancel As Double = 0
        Dim otros As Double = 0

        lb_totalP.Text = "0,00"

        DatosCalculoCostos.Dgv_Costos(Dgv_Costos, pedido, fecha, prov, tb_flete.Text, tb_otros.Text, tb_tcAranc.Text, tb_tcCosto.Text, tb_Margen.Text, cont2, cont3, cont4, cont5, cont6, cont7, arancel, otros, lb_totalP)
        Dgv_Costos.ClearSelection()
        cb_mesesGrafico.SelectedIndex = 0
        cb_status.SelectedIndex = 0
        tb_flete.Focus()
        tb_flete.Select()
        lbl_TotalArt.Text = Dgv_Costos.RowCount
        RadioButton1.Checked = True
        a.Visible = False
        lbl_grafico.Visible = True
        Dgv_Costos.frm = Me

        Label13.Text = "Sub-Total F.O.B. (" + Label6.Text + "): "
        Label11.Text = "Sub-Total C.I.F. (" + Label6.Text + "): "
        lbl_TotalArt.Text = cont2.ToString
        lbl_TotalUni.Text = cont3.ToString
        lbl_TotalFOB.Text = Format(cont4, "#,##0.00")
        lbl_TotalFOBs.Text = Format(cont7, "#,##0.00")
        lbl_TotalCIF.Text = Format(cont5, "#,##0.00")
        lbl_TotalCIFBs.Text = Format(cont6, "#,##0.00")
        Lbl_totalA.Text = Format(arancel, "#,##0.00")

        If tb_tcCosto.Text <> "" Then
            lbl_totalO.Text = Format(otros * CDbl(tb_tcCosto.Text), "#,##0.00")
        Else
            lbl_totalO.Text = Format(otros * 0, "#,##0.00")
        End If

        If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
            Dgv_Costos.Columns(25).Visible = True
            Dgv_Costos.Columns(25).ReadOnly = True
        End If

        listo = True

    End Sub


    Public Sub recibe(ByVal pedido2 As Integer, ByVal Moneda As String, ByVal Proveedor As String, ByVal codProv As Integer)

        pedido = pedido2
        Label6.Text = Moneda
        lbl_Proveedor.Text = Proveedor
        lbl_Pedido.Text = pedido2
        lbl_codprov.Text = codProv

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_unit.Click

        If tb_flete.Text = "" Or tb_otros.Text = "" Then

            MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Critical, "Error")

            If tb_flete.Text = "" Then
                tb_flete.Focus()
            Else
                tb_otros.Focus()
            End If

        Else

            If cb_status.Text = "Todos" Then

                Dim a As Integer = MsgBox("Está seguro de que desea distribuir el flete y otros gastos entre todos estados de la orden?", MsgBoxStyle.YesNo, "Confirmación")

                If a = vbYes Then

                    tb_tcAranc.Focus()
                    tb_tcAranc.SelectAll()

                    If cont = 0 Then
                        Dim fr As New Frm_AsignacionFlete
                        fr.recibe(pedido, CDbl(tb_flete.Text.Replace(".", "")), CDbl(tb_otros.Text.Replace(".", "")), Dgv_Costos, cb_status.Text)
                        fr.Focus()
                        fr.Show()
                        cont = 1
                        Me.frm = fr
                        frm.frm = Me
                    Else
                        frm.recibe(pedido, CDbl(tb_flete.Text.Replace(".", "")), CDbl(tb_otros.Text.Replace(".", "")), Dgv_Costos, cb_status.Text)
                        frm.Visible = True
                    End If



                End If

            Else

                tb_tcAranc.Focus()
                tb_tcAranc.SelectAll()

                If cont = 0 Then
                    Dim fr As New Frm_AsignacionFlete
                    fr.recibe(pedido, CDbl(tb_flete.Text.Replace(".", "")), CDbl(tb_otros.Text.Replace(".", "")), Dgv_Costos, cb_status.Text)
                    fr.Focus()
                    fr.Show()
                    cont = 1
                    Me.frm = fr
                    frm.frm = Me
                Else
                    frm.recibe(pedido, CDbl(tb_flete.Text.Replace(".", "")), CDbl(tb_otros.Text.Replace(".", "")), Dgv_Costos, cb_status.Text)
                    frm.Visible = True
                End If

            End If

        End If
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Public Sub Dgv_Costos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_Costos.CellClick, Dgv_Costos.KeyDown, Dgv_Costos.KeyUp
        If Dgv_Costos.SelectedRows.Count > 0 Then
            Try

                If Dgv_Costos.CurrentCell.ReadOnly Then
                    Dgv_Costos.Rows(Dgv_Costos.SelectedRows(0).Index).Cells(6).Selected = True
                End If

                Me.Dgv_Costos.BeginEdit(True)

                If RadioButton1.Checked Then
                    DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
                    DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)

                    If My.Settings.Empresa = 1 Then
                        DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                        DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                        DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If

                Else
                    If My.Settings.Empresa = 1 Then
                        DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                        DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                        DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
                    DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
                End If

                If DGV_Ventas.RowCount > 0 Then
                    DGV_Ventas.ClearSelection()
                    a.Visible = True
                    lbl_grafico.Visible = False
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If

                DGV_Ventas.ClearSelection()
                Dgv_UltimaCompra.ClearSelection()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Chk_ColumnaFija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_ColumnaFija.CheckedChanged

        If Chk_ColumnaFija.Checked Then
            columna = True
        Else
            columna = False
        End If

        Try

            If Dgv_Costos.SelectedRows.Count > 0 Then
                Dgv_Costos.Focus()
                Me.Dgv_Costos.BeginEdit(True)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_flete_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_flete.Click
        tb_flete.SelectAll()
    End Sub

    Private Sub tb_otros_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_otros.Click
        tb_otros.SelectAll()
    End Sub

    Private Sub tb_flete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_flete.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Not tb_flete.Text.Contains(",") And Not tb_flete.Text.Contains(".") Then

                tb_flete.Text = tb_flete.Text.Replace(".", ",")

            End If

            tb_otros.Focus()
            tb_otros.SelectAll()

        End If

    End Sub

    Private Sub tb_flete_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tb_flete.Leave

        If Not tb_flete.Text.Contains(",") And Not tb_flete.Text.Contains(".") Then
            tb_flete.Text = tb_flete.Text.Replace(".", ",")
        End If

    End Sub

    Private Sub tb_otros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_otros.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Not tb_otros.Text.Contains(",") And Not tb_otros.Text.Contains(".") Then
                tb_otros.Text = tb_otros.Text.Replace(".", ",")
            End If

            bt_unit.Focus()

        End If

    End Sub

    Private Sub tb_otros_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tb_otros.Leave

        If Not tb_otros.Text.Contains(",") And Not tb_otros.Text.Contains(".") Then
            tb_otros.Text = tb_otros.Text.Replace(".", ",")
        End If

    End Sub

    Private Sub tb_Margen_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Margen.Click

        tb_Margen.Focus()
        tb_Margen.SelectAll()

    End Sub

    Private Sub tb_tcAranc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_tcAranc.Click

        tb_tcAranc.Focus()
        tb_tcAranc.SelectAll()

    End Sub

    Private Sub tb_tcCosto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_tcCosto.Click

        tb_tcCosto.Focus()
        tb_tcCosto.SelectAll()

    End Sub


    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_flete.KeyPress, tb_otros.KeyPress, tb_tcCosto.KeyPress, tb_Margen.KeyPress, tb_tcAranc.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or Not (e.KeyChar = ".") Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números y (,)"
            Me.Label22.BringToFront()
        End If

    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)

        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If

    End Sub

    Private Sub Dgv_Costos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Costos.CellEndEdit

        If Not Dgv_Costos.CurrentCell.Value Is Nothing Then

            If Dgv_Costos.CurrentCell.ColumnIndex = 0 Then

                Dgv_Costos.CurrentRow.Cells(0).Value = Dgv_Costos.CurrentRow.Cells(0).Value.ToString.ToUpper

            End If

            If Dgv_Costos.CurrentCell.ColumnIndex <> 1 Then

                Try

                    If Dgv_Costos.CurrentCell.ColumnIndex <> 0 Then

                        If Not Dgv_Costos.CurrentCell.Value.ToString.Contains(",") And Not Dgv_Costos.CurrentCell.Value.ToString.Contains(".") Then

                            Dgv_Costos.CurrentCell.Value = Dgv_Costos.CurrentCell.Value.ToString.Replace(".", ",")

                        End If

                    End If

                    If Dgv_Costos.CurrentCell.ColumnIndex = 6 Then

                        If Dgv_Costos.CurrentCell.Value = "" Then

                            Dgv_Costos.CurrentCell.Value = fob2

                        Else

                            If tb_tcAranc.Text <> "" And tb_tcCosto.Text <> "" And tb_Margen.Text <> "" Then

                                ''CIF --------------
                                Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value = CDbl(Format(CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(6).Value) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(7).Value), "#,##0.00"))
                                ''CIF --------------

                                ''Aranc. Bs --------------
                                If CDbl((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcAranc.Text)) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value)) * CDbl(tb_tcAranc.Text)), "#,##0.00"))
                                End If
                                ''Aranc. Bs --------------

                                ''Costo Bs --------------
                                If ((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value)) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = (CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + (CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value * CDbl(tb_tcCosto.Text)))
                                End If
                                ''Costo Bs --------------

                                ''Precio Bs --------------
                                If CDbl((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value)))) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value))), "#,##0.00"))
                                End If
                                ''Precio Bs --------------

                                ''DIF (%) --------------
                                Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(16).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value) - CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) / CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) * 100), "#,##0.00"))
                                ''DIF (%) -------------- 

                                If fob2 <> Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(6).Value Then
                                    ''Precio Final Bs. --------------
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value = CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value)
                                    ''Precio Final Bs. --------------
                                End If

                            Else

                                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Critical, "Error")

                                If tb_Margen.Text = "" Then

                                    tb_Margen.Focus()

                                ElseIf tb_tcAranc.Text = "" Then

                                    tb_tcAranc.Focus()

                                ElseIf tb_tcCosto.Text = "" Then

                                    tb_tcCosto.Focus()

                                End If

                            End If

                        End If

                        If fob2 = 0 Then

                            Dgv_Costos.CurrentRow.Cells(0).Value = "R"
                            Dgv_Costos.CurrentRow.Cells(21).Value = Today

                        End If

                        If CDbl(Dgv_Costos.CurrentCell.Value) = 0 And Dgv_Costos.CurrentRow.Cells(0).Value <> "S" Then

                            Dgv_Costos.CurrentRow.Cells(0).Value = "S"
                            Dgv_Costos.CurrentRow.Cells(7).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(10).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(11).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(12).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(13).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(16).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(20).Value = CDbl(0)
                            Dgv_Costos.CurrentRow.Cells(21).Value = Today

                        End If


                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 9 Then

                        If Dgv_Costos.CurrentCell.Value = "" Then

                            Dgv_Costos.CurrentCell.Value = Aranceles2

                        Else

                            If tb_tcAranc.Text <> "" And tb_tcCosto.Text <> "" And tb_Margen.Text <> "" Then

                                ''Aranc. Bs --------------
                                If CDbl((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcAranc.Text)) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value)) * CDbl(tb_tcAranc.Text)), "#,##0.00"))
                                End If
                                ''Aranc. Bs --------------

                                ''Costo Bs --------------
                                If ((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value)) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = CDbl((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + (CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value * CDbl(tb_tcCosto.Text))))
                                End If
                                ''Costo Bs --------------

                                ''Precio Bs --------------
                                If CDbl((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value)))) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value))), "#,##0.00"))
                                End If
                                ''Precio Bs --------------

                                ''DIF (%) --------------
                                Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(16).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value) - CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) / CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) * 100), "#,##0.00"))
                                ''DIF (%) -------------- 

                                If Aranceles2 <> Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(9).Value Then
                                    ''Precio Final Bs. --------------
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value = CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value)
                                    ''Precio Final Bs. --------------
                                End If



                            Else

                                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Critical, "Error")

                                If tb_Margen.Text = "" Then

                                    tb_Margen.Focus()

                                ElseIf tb_tcAranc.Text = "" Then

                                    tb_tcAranc.Focus()

                                ElseIf tb_tcCosto.Text = "" Then

                                    tb_tcCosto.Focus()

                                End If


                            End If

                        End If


                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 11 Then

                        If Dgv_Costos.CurrentCell.Value = "" Then

                            Dgv_Costos.CurrentCell.Value = otrosg

                        Else

                            If tb_tcAranc.Text <> "" And tb_tcCosto.Text <> "" And tb_Margen.Text <> "" Then

                                ''Costo Bs --------------
                                If ((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value)) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value = (CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(10).Value) + (CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value * CDbl(tb_tcCosto.Text)))
                                End If
                                ''Costo Bs --------------

                                ''Precio Bs --------------
                                If CDbl((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value)))) = 0 Then
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl("0,00")
                                Else
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(12).Value))), "#,##0.00"))
                                End If
                                ''Precio Bs --------------

                                ''DIF (%) --------------
                                Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(16).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value) - CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) / CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) * 100), "#,##0.00"))
                                ''DIF (%) -------------- 

                                If otrosg <> Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(11).Value Then
                                    ''Precio Final Bs. --------------
                                    Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value = CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(13).Value)
                                    ''Precio Final Bs. --------------
                                End If



                            Else

                                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Critical, "Error")

                                If tb_Margen.Text = "" Then

                                    tb_Margen.Focus()

                                ElseIf tb_tcAranc.Text = "" Then

                                    tb_tcAranc.Focus()

                                ElseIf tb_tcCosto.Text = "" Then

                                    tb_tcCosto.Focus()

                                End If


                            End If

                        End If

                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 20 Then

                        If IsNumeric(Dgv_Costos.CurrentCell.Value) Then

                            If CDbl(Dgv_Costos.CurrentCell.Value) < CDbl(Dgv_Costos.CurrentRow.Cells(12).Value) Then

                                MsgBox("No puede introducir un precio final menor al costo del producto", MsgBoxStyle.Exclamation, "SINPRO")
                                Dgv_Costos.CurrentCell.Value = precioFinal2

                            End If

                            ''DIF (%) --------------
                            Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(16).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value) - CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) / CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) * 100), "#,##0.00"))
                            ''DIF (%) -------------- 

                        Else

                            If Dgv_Costos.CurrentCell.Value = "" Then

                                Dgv_Costos.CurrentCell.Value = precioFinal2

                            Else
                                MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Exclamation, "SINPRO")
                                Dgv_Costos.CurrentCell.Value = precioFinal2
                            End If

                        End If

                    End If

                    If Dgv_Costos.CurrentCell.ColumnIndex <> 0 Then
                        Dgv_Costos.CurrentCell.Value = CDbl(Dgv_Costos.CurrentCell.Value)
                    End If

                Catch ex As Exception

                    If Dgv_Costos.CurrentCell.ColumnIndex = 6 Then
                        Dgv_Costos.CurrentCell.Value = fob2
                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 9 Then
                        Dgv_Costos.CurrentCell.Value = Aranceles2
                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 11 Then
                        Dgv_Costos.CurrentCell.Value = otrosg
                    ElseIf Dgv_Costos.CurrentCell.ColumnIndex = 20 Then
                        Dgv_Costos.CurrentCell.Value = precioFinal2
                    End If

                End Try

            Else

                Try

                    If Dgv_Costos.CurrentCell.Value.ToString = "" Then
                        Dgv_Costos.CurrentCell.Value = cant
                    End If

                    If Not IsNumeric(Dgv_Costos.CurrentCell.Value.ToString) Then
                        Dgv_Costos.CurrentCell.Value = cant
                    End If

                    Dgv_Costos.CurrentCell.Value = CInt(Dgv_Costos.CurrentCell.Value)

                Catch ex As Exception
                    Dgv_Costos.CurrentCell.Value = cant
                End Try

            End If

            DGV_Ventas.ClearSelection()
            calcularTotales()

        End If

    End Sub

    Private Sub Dgv_Costos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv_Costos.EditingControlShowing

        If Me.Dgv_Costos.CurrentCell.ColumnIndex = 1 Or Me.Dgv_Costos.CurrentCell.ColumnIndex = 6 Or Me.Dgv_Costos.CurrentCell.ColumnIndex = 7 Or Me.Dgv_Costos.CurrentCell.ColumnIndex = 11 Or Me.Dgv_Costos.CurrentCell.ColumnIndex = 20 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        ElseIf Me.Dgv_Costos.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            txt.MaxLength = 1
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
                AddHandler txt.KeyPress, AddressOf CellKeyPress3
            End If
        End If

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Public Sub cb_status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_status.SelectedIndexChanged

        Dim cont As Integer
        Dim cont2 As Integer = 0
        choice = cb_status.SelectedIndex

        If Dgv_Costos.Rows.Count <> 0 Then

            For cont = 0 To Dgv_Costos.Rows.Count - 1
                If cb_status.Text <> "Todos" Then
                    If Dgv_Costos.Rows(cont).Cells(0).Value <> cb_status.Text Then
                        Dgv_Costos.Rows(cont).Visible = False
                    Else
                        Dgv_Costos.Rows(cont).Visible = True
                    End If
                Else
                    Dgv_Costos.Rows(cont).Visible = True
                End If

            Next

            calcularTotales()

        End If

    End Sub

    Public Sub calcularTotales()
        Try
            Dim cont As Integer = 0
            Dim cont2 As Integer = 0
            Dim cont3 As Integer = 0
            Dim cont4 As Double = 0
            Dim cont5 As Double = 0
            Dim cont6 As Double = 0
            Dim cont7 As Double = 0
            Dim arancel As Double = 0
            Dim otros As Double = 0

            lb_totalP.Text = "0,00"

            For cont = 0 To Dgv_Costos.Rows.Count - 1
                If Dgv_Costos.Rows(cont).Visible Then

                    lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(Dgv_Costos.Rows(cont).Cells(1).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(12).Value)), "#,##0.00")
                    cont2 = cont2 + 1
                    cont3 = cont3 + CInt(Dgv_Costos.Rows(cont).Cells(1).Value)
                    cont4 = cont4 + (CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(1).Value))
                    cont5 = cont5 + ((CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) + CDbl(Dgv_Costos.Rows(cont).Cells(7).Value)) * CDbl(Dgv_Costos.Rows(cont).Cells(1).Value))
                    cont6 = cont6 + ((CDbl(Dgv_Costos.Rows(cont).Cells(8).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(1).Value)) * CDbl(tb_tcCosto.Text))
                    cont7 = cont7 + ((CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(1).Value)) * CDbl(tb_tcCosto.Text))
                    arancel = arancel + (CInt(Dgv_Costos.Rows(cont).Cells(1).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(10).Value))
                    otros = otros + (CInt(Dgv_Costos.Rows(cont).Cells(1).Value) * CDbl(Dgv_Costos.Rows(cont).Cells(11).Value))

                End If

            Next

            Label13.Text = "Sub-Total F.O.B. (" + Label6.Text + "): "
            Label11.Text = "Sub-Total C.I.F. (" + Label6.Text + "): "
            lbl_TotalArt.Text = cont2.ToString
            lbl_TotalUni.Text = cont3.ToString
            lbl_TotalFOB.Text = Format(cont4, "#,##0.00")
            lbl_TotalFOBs.Text = Format(cont7, "#,##0.00")
            lbl_TotalCIF.Text = Format(cont5, "#,##0.00")
            lbl_TotalCIFBs.Text = Format(cont6, "#,##0.00")
            Lbl_totalA.Text = Format(arancel, "#,##0.00")
            If tb_tcCosto.Text <> "" Then
                lbl_totalO.Text = Format(otros * CDbl(tb_tcCosto.Text), "#,##0.00")
            Else
                lbl_totalO.Text = Format(otros * 0, "#,##0.00")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_tcCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_tcCosto.KeyDown

        Try

            If e.KeyCode = Keys.Enter Then

                tb_tcCosto.Text = tb_tcCosto.Text.Replace(".", ",")

                If tb_tcCosto.Text = "" Then
                    tb_tcCosto.Text = "0,00"
                End If

                ReCalcular()

                tb_Margen.Focus()
                tb_Margen.SelectAll()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_tcCosto_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tb_tcCosto.Leave

        Try

            tb_tcCosto.Text = tb_tcCosto.Text.Replace(".", ",")

            If tb_tcCosto.Text = "" Then
                tb_tcCosto.Text = "0,00"
            End If

            ReCalcular()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_tcAranc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_tcAranc.KeyDown

        Try

            If e.KeyCode = Keys.Enter Then

                tb_tcAranc.Text = tb_tcAranc.Text.Replace(".", ",")

                If tb_tcAranc.Text = "" Then
                    tb_tcAranc.Text = "0,00"
                End If

                ReCalcular()

                tb_tcCosto.Focus()
                tb_tcCosto.SelectAll()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_tcAranc_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tb_tcAranc.Leave

        Try

            tb_tcAranc.Text = tb_tcAranc.Text.Replace(".", ",")

            If tb_tcAranc.Text = "" Then
                tb_tcAranc.Text = "0,00"
            End If

            ReCalcular()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_Margen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_Margen.KeyDown

        Try

            If e.KeyCode = Keys.Enter Then

                tb_Margen.Text = tb_Margen.Text.Replace(".", ",")

                If tb_Margen.Text = "" Then
                    tb_Margen.Text = "0,00"
                End If

                ReCalcular()

                Dgv_Costos.Focus()
                Dgv_Costos.Rows(0).Cells(6).Selected = True

                Dgv_Costos_CellClick(Dgv_Costos, New EventArgs)

                If DGV_Ventas.RowCount > 0 Then
                    DGV_Ventas.ClearSelection()
                    a.Visible = True
                    lbl_grafico.Visible = False
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If

                Me.Dgv_Costos.BeginEdit(True)

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_Margen_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tb_Margen.Leave

        Try

            tb_Margen.Text = tb_Margen.Text.Replace(".", ",")

            If tb_Margen.Text = "" Then
                tb_Margen.Text = "0,00"
            End If

            ReCalcular()

            Dgv_Costos_CellClick(Dgv_Costos, New EventArgs)

            If DGV_Ventas.RowCount > 0 Then
                DGV_Ventas.ClearSelection()
                a.Visible = True
                lbl_grafico.Visible = False
            Else
                a.Visible = False
                lbl_grafico.Visible = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub guardaranteriores(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Dgv_Costos.CellBeginEdit

        cant = CInt(Dgv_Costos.CurrentRow.Cells(1).Value)
        fob2 = CDbl(Dgv_Costos.CurrentRow.Cells(6).Value)
        otrosg = CDbl(Dgv_Costos.CurrentRow.Cells(11).Value)
        Aranceles2 = CDbl(Dgv_Costos.CurrentRow.Cells(9).Value)
        precioFinal2 = CDbl(Dgv_Costos.CurrentRow.Cells(20).Value)
        sta = CChar(Dgv_Costos.CurrentRow.Cells(0).Value)

    End Sub


    Public Sub ReCalcular()
        Try
            Dim cont As Integer = 0


            For cont = 0 To Dgv_Costos.RowCount - 1

                If Dgv_Costos.Rows(cont).Visible Then

                    ''CIF --------------
                    Dgv_Costos.Rows(cont).Cells(8).Value = CDbl(Format(CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) + CDbl(Dgv_Costos.Rows(cont).Cells(7).Value), "#,##0.00"))
                    ''CIF --------------

                    ''Aranc. Bs --------------
                    If CDbl((CDbl(Dgv_Costos.Rows(cont).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) * CDbl(tb_tcAranc.Text)) = 0 Then
                        Dgv_Costos.Rows(cont).Cells(10).Value = CDbl("0,00")
                    Else
                        Dgv_Costos.Rows(cont).Cells(10).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(cont).Cells(9).Value) / 100) * CDbl(Dgv_Costos.Rows(cont).Cells(8).Value)) * CDbl(tb_tcAranc.Text)), "#,##0.00"))
                    End If
                    ''Aranc. Bs --------------

                    ''Otros g. ---------------
                    If tb_otros.Text <> "" Then

                        If CDbl((CDbl(tb_otros.Text) / 100) * CDbl(Dgv_Costos.Rows(cont).Cells(8).Value)) = 0 Then
                            Dgv_Costos.Rows(cont).Cells(11).Value = CDbl(0)
                        Else
                            Dgv_Costos.Rows(cont).Cells(11).Value = CDbl((CDbl(tb_otros.Text) / 100) * CDbl(Dgv_Costos.Rows(cont).Cells(8).Value))
                        End If

                    End If
                    ''Otros g. ---------------

                    ''Costo Bs --------------
                    Dgv_Costos.Rows(cont).Cells(12).Value = (CDbl(Dgv_Costos.Rows(cont).Cells(8).Value) * CDbl(tb_tcCosto.Text)) + CDbl(Dgv_Costos.Rows(cont).Cells(10).Value) + (CDbl(Dgv_Costos.Rows(cont).Cells(11).Value * CDbl(tb_tcCosto.Text)))
                    ''Costo Bs --------------

                    ''Precio Bs --------------
                    If CDbl((((CDbl(Dgv_Costos.Rows(cont).Cells(12).Value) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(cont).Cells(12).Value)))) = 0 Then
                        Dgv_Costos.Rows(cont).Cells(13).Value = CDbl("0,00")
                    Else
                        Dgv_Costos.Rows(cont).Cells(13).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(cont).Cells(12).Value.ToString) * (CDbl(tb_Margen.Text) / 100)) + CDbl(Dgv_Costos.Rows(cont).Cells(12).Value.ToString))), "#,##0.00"))
                    End If
                    ''Precio Bs --------------

                    ''DIF (%) --------------
                    If CDbl(Dgv_Costos.Rows(cont).Cells(6).Value) = 0 Then
                        Dgv_Costos.Rows(cont).Cells(16).Value = CDbl("0,00")
                    Else
                        Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(16).Value = CDbl(Format((((CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(20).Value) - CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) / CDbl(Dgv_Costos.Rows(Dgv_Costos.CurrentCell.RowIndex).Cells(14).Value)) * 100), "#,##0.00"))
                    End If
                    ''DIF (%) -------------- 

                    ''Precio Final Bs. --------------
                    Dgv_Costos.Rows(cont).Cells(20).Value = CDbl(Dgv_Costos.Rows(cont).Cells(13).Value)
                    ''Precio Final Bs. --------------

                End If

            Next

            calcularTotales()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub focoAceptar(ByVal frm As Frm_CalculoCostos)
        frm.bt_aceptar.Focus()
    End Sub

    Public Sub AplicarFlitro(ByVal frm As Frm_CalculoCostos, ByVal ch As Integer)
        frm.cb_status.SelectedIndex = ch
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim cont As Integer = 0

        Try

            For cont = 0 To Dgv_Costos.RowCount - 1
                DatosCalculoCostos.ActualizaCostos(CStr(Dgv_Costos.Rows(cont).Cells(0).Value), CDbl(Dgv_Costos.Rows(cont).Cells(6).Value), CDbl(Dgv_Costos.Rows(cont).Cells(7).Value), CDbl(Dgv_Costos.Rows(cont).Cells(11).Value), CDate(Dgv_Costos.Rows(cont).Cells(21).Value), CInt(Dgv_Costos.Rows(cont).Cells(1).Value), pedido, Dgv_Costos.Rows(cont).Cells(2).Value, CDbl(Dgv_Costos.Rows(cont).Cells(20).Value), CDbl(Dgv_Costos.Rows(cont).Cells(10).Value), CDbl(Dgv_Costos.Rows(cont).Cells(9).Value), CBool(Dgv_Costos.Rows(cont).Cells(22).Value))
            Next

            DatosCalculoCostos.ActualizaPedidoProveedor(CDbl(tb_flete.Text), CDbl(tb_otros.Text), CInt(lbl_Pedido.Text), CDbl(tb_tcAranc.Text), CDbl(tb_tcCosto.Text), CDbl(tb_Margen.Text), CDbl(Lbl_totalA.Text))

            MsgBox("Costos actualizados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Me.Close()

        Catch ex As Exception

            MsgBox("Error actualizando los costos del pedido", MsgBoxStyle.Critical, "Error")


        End Try

    End Sub

    Private Sub cb_mesesGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_mesesGrafico.SelectedIndexChanged

        If cb_mesesGrafico.SelectedIndex <> -1 Then

            If Dgv_Costos.SelectedRows.Count > 0 Then

                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.SelectedRows(0).Cells(2).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                If DGV_Ventas.RowCount > 0 Then
                    DatosCompras.VentasPorMes(Dgv_Costos.SelectedRows(0).Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                    DGV_Ventas.ClearSelection()
                    a.Visible = True
                    lbl_grafico.Visible = False
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If

                DGV_Ventas.ClearSelection()
                Dgv_Costos.Focus()
                Dgv_Costos.Select()

            End If

        End If

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        If Not CDate(DateTimePicker1.Value.ToShortDateString) > CDate(DateTimePicker2.Value.ToShortDateString) Or Not CDate(DateTimePicker1.Value.ToShortDateString) > Today Then

            If Dgv_Costos.SelectedRows.Count > 0 Then
                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.SelectedRows(0).Cells(2).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                If DGV_Ventas.RowCount > 0 Then
                    DatosCompras.VentasPorMes(Dgv_Costos.SelectedRows(0).Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If
            End If

            DGV_Ventas.ClearSelection()

        Else

            a.Visible = False
            lbl_grafico.Visible = True
            DGV_Ventas.Rows.Clear()

        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

        If Not CDate(DateTimePicker2.Value.ToShortDateString) < CDate(DateTimePicker1.Value.ToShortDateString) And Not CDate(DateTimePicker2.Value.ToShortDateString) > Today Then

            If Dgv_Costos.SelectedRows.Count > 0 Then

                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.SelectedRows(0).Cells(2).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                If DGV_Ventas.RowCount > 0 Then
                    DatosCompras.VentasPorMes(Dgv_Costos.SelectedRows(0).Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else

                    a.Visible = False
                    lbl_grafico.Visible = True
                End If

                DGV_Ventas.ClearSelection()

            End If

        Else

            DateTimePicker2.Value = Today
            MsgBox("Período de fechas no válido", MsgBoxStyle.Exclamation, "SINPRO")
            a.Visible = False
            lbl_grafico.Visible = True
            DGV_Ventas.Rows.Clear()

        End If


    End Sub

    Private Sub DGV_Ventas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Ventas.CellDoubleClick
        Try

            If e.ColumnIndex = 0 And DGV_Ventas.SelectedRows.Count > 0 Then
                Frm_Facturas_Ventas.Show()
                Frm_Facturas_Ventas.SpConsultaClienteFacturaBindingSource.Filter = "Control = '" & DGV_Ventas.SelectedRows(0).Cells(0).Value & "'"
                Frm_Facturas_Ventas.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                Frm_Facturas_Ventas.DGV_TodasLasFacturas_CellClick()
                Frm_Facturas_Ventas.tb_buscarcodigo.Enabled = False
            End If

        Catch ex As Exception

            MsgBox("Error")

        End Try

    End Sub

    Public Sub totalDevueltos() Handles DGV_Ventas.RowsAdded, DGV_Ventas.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Ventas.RowCount - 1

            If DGV_Ventas.Rows(cont).Cells(5).Value = "" Then

                acum = acum + 0

            Else

                acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(5).Value)

            End If


        Next

        Label12.Text = acum

    End Sub

    Public Sub totalVendidos() Handles DGV_Ventas.RowsAdded, DGV_Ventas.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Ventas.RowCount - 1

            acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(3).Value)

        Next

        Label17.Text = acum

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            If Dgv_Costos.SelectedRows.Count > 0 Then
                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.SelectedRows(0).Cells(2).Value, 0, 1, DateTimePicker1.Value, DateTimePicker2.Value)
                If DGV_Ventas.RowCount > 0 Then
                    DatosCompras.VentasPorMes(Dgv_Costos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True

                End If

                DGV_Ventas.ClearSelection()
                DateTimePicker1.Focus()

            End If
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            cb_mesesGrafico.Enabled = True
            If Dgv_Costos.SelectedRows.Count > 0 Then
                DGV_Ventas.ClearSelection()
                cb_mesesGrafico.Focus()

            End If
        Else
            cb_mesesGrafico.Enabled = False
        End If
    End Sub

    Private Sub CellKeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "S"c OrElse e.KeyChar = "R"c OrElse e.KeyChar = "O"c OrElse e.KeyChar = "F"c OrElse e.KeyChar = "D"c OrElse e.KeyChar = "N"c OrElse e.KeyChar = "s"c OrElse e.KeyChar = "r"c OrElse e.KeyChar = "o"c OrElse e.KeyChar = "f"c OrElse e.KeyChar = "d"c OrElse e.KeyChar = "n"c OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click

        Dim cont As Integer = 0

        Try

            For cont = 0 To Dgv_Costos.RowCount - 1
                DatosCalculoCostos.ActualizaCostos(CStr(Dgv_Costos.Rows(cont).Cells(0).Value), CDbl(Dgv_Costos.Rows(cont).Cells(6).Value), CDbl(Dgv_Costos.Rows(cont).Cells(7).Value), CDbl(Dgv_Costos.Rows(cont).Cells(11).Value), CDate(Dgv_Costos.Rows(cont).Cells(21).Value), CInt(Dgv_Costos.Rows(cont).Cells(1).Value), pedido, Dgv_Costos.Rows(cont).Cells(2).Value, CDbl(Dgv_Costos.Rows(cont).Cells(20).Value), CDbl(Dgv_Costos.Rows(cont).Cells(10).Value), CDbl(Dgv_Costos.Rows(cont).Cells(9).Value), CBool(Dgv_Costos.Rows(cont).Cells(22).Value))
            Next

            DatosCalculoCostos.ActualizaPedidoProveedor(CDbl(tb_flete.Text), CDbl(tb_otros.Text), CInt(lbl_Pedido.Text), CDbl(tb_tcAranc.Text), CDbl(tb_tcCosto.Text), CDbl(tb_Margen.Text), CDbl(Lbl_totalA.Text))

            MsgBox("Costos actualizados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Dgv_Costos.Focus()
            Dgv_Costos.CurrentCell.Selected = True
            Dgv_Costos.BeginEdit(True)

        Catch ex As Exception

            MsgBox("Error actualizando los costos del pedido", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_OcultarColumnas.CheckedChanged

        If My.Settings.Empresa = 1 Then

            Dgv_Costos.Columns(8).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(9).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(11).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(15).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(16).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(18).Visible = Not chk_OcultarColumnas.Checked

        Else

            Dgv_Costos.Columns(3).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(7).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(8).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(9).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(10).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(11).Visible = Not chk_OcultarColumnas.Checked
            Dgv_Costos.Columns(19).Visible = Not chk_OcultarColumnas.Checked

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_costoBs.CheckedChanged
        If chk_costoBs.Checked Then
            Dgv_UltimaCompra.ScrollBars = ScrollBars.Both
        Else
            Dgv_UltimaCompra.ScrollBars = ScrollBars.Vertical
        End If
        Dgv_UltimaCompra.Columns(6).Visible = chk_costoBs.Checked
    End Sub

    Private Sub Dgv_Costos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Costos.CellDoubleClick
        If e.ColumnIndex = 3 Then

            Dim Modificar As New Frm_ModificaCodigoFabrica
            Dim f As Boolean = False
            Dim r As Boolean = False

            If My.Settings.Empresa = 1 Then

                If Dgv_Costos.SelectedRows(0).Cells(26).Value.ToString.Contains("Fiat") Then
                    f = True
                ElseIf Dgv_Costos.SelectedRows(0).Cells(26).Value.ToString.Contains("Renault") Then
                    r = True
                End If

                Modificar.Recibe(lbl_Proveedor.Text, CInt(lbl_codprov.Text), Dgv_Costos.SelectedRows(0).Cells(3).Value.ToString, Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString, Dgv_Costos.SelectedRows(0).Cells(4).Value.ToString, 0, f, r, , Me, )

            Else
                Modificar.Recibe(lbl_Proveedor.Text, CInt(lbl_codprov.Text), Dgv_Costos.SelectedRows(0).Cells(3).Value.ToString, Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString, Dgv_Costos.SelectedRows(0).Cells(4).Value.ToString, 0, f, r, , Me, )
            End If

            Me.Enabled = False
            Modificar.Show()
        End If
    End Sub

    'Private Sub Dgv_Costos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_Costos.KeyUp
    '    If Dgv_Costos.CurrentCell.RowIndex = 1 And e.KeyCode = Keys.Enter Then

    '        If Dgv_Costos.CurrentCell.RowIndex = 5 Then
    '            If RadioButton1.Checked Then
    '                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
    '                DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
    '                DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '                DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '            Else
    '                DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
    '                DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
    '                DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '                DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '            End If

    '            If DGV_Ventas.RowCount > 0 Then
    '                DGV_Ventas.ClearSelection()
    '                a.Visible = True
    '                lbl_grafico.Visible = False
    '            Else
    '                a.Visible = False
    '                lbl_grafico.Visible = True
    '            End If
    '        End If

    '    End If
    'End Sub


    'Public Sub Dgv_Costos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_Costos.KeyDown
    '    If Dgv_Costos.SelectedRows.Count > 0 Then

    '        If RadioButton1.Checked Then
    '            DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
    '            DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
    '            DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '            DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '        Else
    '            DatosCompras.Dgv_Ventas(DGV_Ventas, Dgv_Costos.CurrentRow.Cells(2).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
    '            DatosCompras.VentasPorMes(Dgv_Costos.CurrentRow.Cells(2).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
    '            DatosCalculoCostos.Dgv_UltimaCompra(Dgv_UltimaCompra, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '            DatosCalculoCostos.Dgv_UltimaCotizacion(DGV_UltimaCotización, CInt(lbl_Pedido.Text), Dgv_Costos.SelectedRows(0).Cells(2).Value.ToString)
    '        End If

    '        If DGV_Ventas.RowCount > 0 Then
    '            DGV_Ventas.ClearSelection()
    '            a.Visible = True
    '            lbl_grafico.Visible = False
    '        Else
    '            a.Visible = False
    '            lbl_grafico.Visible = True
    '        End If
    '    End If

    'End Sub

    Private Sub bt_impuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_impuestos.Click

        Dim frm As New Frm_CalculoPagoImpuestos
        frm.Recibe(pedido, lbl_TotalFOB.Text, (CDbl(lbl_TotalCIF.Text) - CDbl(lbl_TotalFOB.Text)).ToString, tb_tcAranc.Text)
        frm.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim frm As New Frm_ExportarAExcel
        frm.dgv = Dgv_Costos
        frm.recibe(lbl_Pedido.Text, Dgv_Costos, lbl_Proveedor.Text, fecha, Label6.Text, "", lbl_TotalFOB.Text, lbl_TotalFOBs.Text, lbl_TotalCIF.Text, lbl_TotalCIFBs.Text, lbl_totalO.Text, Lbl_totalA.Text, lbl_TotalArt.Text, cb_status.Text)
        frm.TopMost = True
        frm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ActualizarPrecios.Click

        Dim resp As Integer = MsgBox("Está seguro que desea modificar los precios de los productos en esta compra a pesar de no darles entrada?", MsgBoxStyle.YesNo, "Confirmación")

        If resp = vbYes Then

            For i As Integer = 0 To Dgv_Costos.RowCount - 1

                If Dgv_Costos.Rows(i).Visible Then

                    DatosProducto.ModificaPrecio(Dgv_Costos.Rows(i).Cells(2).Value.ToString, CDbl(Dgv_Costos.Rows(i).Cells(20).Value), 0)

                End If

            Next

        End If

        MsgBox("Precios modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

    End Sub

End Class