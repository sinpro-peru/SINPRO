Public Class Frm_Gastos

    Dim buscar As Boolean = False
    Public user As String = ""
    Public w As Boolean
    Public e As Boolean

    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub Frm_Gastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

            'TODO: This line of code loads data into the 'MELDataSet.sp_consultaTipoGasto' table. You can move, or remove it, as needed.
            Me.Sp_consultaTipoGastoTableAdapter.Fill(Me.MELDataSet.sp_consultaTipoGasto)

            If Not Me.e Then
                Me.MELDataSet.sp_consultaTipoGasto.Rows.RemoveAt(1)
            End If

            buscar = True
            cb_tipo_SelectedIndexChanged(cb_tipo, New EventArgs)
            buscar = False
            LlenarComboAnos()
            DatosUsuarios.consulta_usuario_Login(user)
            cb_mes.SelectedIndex = 0
            buscar = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then

            buscar = False
            Me.Close()

        ElseIf e.Button Is Me.bt_modificar Then

            If Dgv_relaciones.SelectedRows.Count > 0 Then

                If Dgv_relaciones.SelectedRows(0).Cells(5).Value = False Then

                    Habilitar_Desabilitar_Controles(True)
                    tb_aprobada.Focus()

                Else

                    MsgBox("La relación seleccionada ya está cerrada", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            Else

                MsgBox("Debe seleccionar una relación para modificar", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        ElseIf e.Button Is Me.bt_cerrar Then

            If Dgv_relaciones.SelectedRows.Count > 0 Then

                If Dgv_relaciones.SelectedRows(0).Cells(5).Value = False Then

                    Dim mes As Integer = Month(CDate(Dgv_relaciones.SelectedRows(0).Cells(1).Value)) + 1

                    If mes > 12 Then
                        mes = 1
                    End If

                    Dim Fecha As Date = CDate(("01/" & mes.ToString & "/" & Year(DateAdd(DateInterval.Month, 1, CDate(Dgv_relaciones.SelectedRows(0).Cells(1).Value)))))

                    DatosGastos.Cerrar_Relacion(Dgv_relaciones.SelectedRows(0).Cells(0).Value)
                    DatosGastos.Insertar_Relacion(CInt(cb_tipo.SelectedItem(0)), user, "", Fecha, "")
                    Dim UltimaRelacion As Integer = DatosGastos.Consulta_Ultima_Relacion()
                    DatosGastos.Insertar_Movimiento_Gasto("--", "--", "Sobrante Mes Anterior", 0, CDbl(lb_disponible.Text), "", Fecha, UltimaRelacion, 0)
                    cb_tipo_SelectedIndexChanged(cb_tipo, New EventArgs)

                Else

                    MsgBox("La relación seleccionada ya está cerrada", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

        End If

    End Sub

    Private Sub Habilitar_Desabilitar_Controles(ByVal Valor As Boolean)

        tb_aprobada.ReadOnly = Not Valor
        tb_Documento.ReadOnly = Not Valor
        tb_observ.ReadOnly = Not Valor
        dtp2.Enabled = Valor
        tb_descripcion.ReadOnly = Not Valor
        tb_numeroDoc.ReadOnly = Not Valor
        tb_monto.ReadOnly = Not Valor
        Dgv_relaciones.Enabled = Not Valor
        cb_tipo.Enabled = Not Valor
        cb_ano.Enabled = Not Valor
        cb_mes.Enabled = Not Valor
        bt_agregarMov.Visible = Valor
        bt_eliminarMov.Visible = Valor
        bt_aceptar.Visible = Valor
        bt_cancelar.Visible = Valor

    End Sub

    Private Sub LimpiarFormularios()

        tb_codigo.Clear()
        tb_elaborada.Clear()
        tb_aprobada.Clear()
        dtp1.Value = Today
        tb_Documento.Clear()
        tb_observ.Clear()
        dtp2.Value = Today
        tb_descripcion.Clear()
        tb_numeroDoc.Clear()
        tb_monto.Clear()
        DGV_Movimientos.Rows.Clear()
        lb_limite.Text = "0,00"

    End Sub

    Private Sub LlenarComboAnos()

        cb_ano.Items.Clear()

        For cont As Integer = 0 To 2

            cb_ano.Items.Add(Year(Today) - cont)

        Next

        cb_ano.SelectedIndex = 0

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False

        If tb_codigo.Text <> "" And tb_elaborada.Text <> "" Then

            If CDbl(lb_disponible.Text) >= 0 Then

                If DGV_Movimientos.RowCount > 0 Then

                    DatosGastos.Eliminar_Movimientos_Relacion(CInt(tb_codigo.Text))

                    For cont As Integer = 0 To DGV_Movimientos.RowCount - 1

                        If DGV_Movimientos.Rows(cont).Cells(4).Value = "" Then

                            DatosGastos.Insertar_Movimiento_Gasto(DGV_Movimientos.Rows(cont).Cells(0).Value.ToString, DGV_Movimientos.Rows(cont).Cells(1).Value.ToString, _
                                          DGV_Movimientos.Rows(cont).Cells(2).Value.ToString, 0, _
                                          DGV_Movimientos.Rows(cont).Cells(5).Value, DGV_Movimientos.Rows(cont).Cells(6).Value.ToString, _
                                          DGV_Movimientos.Rows(cont).Cells(3).Value.ToString, CInt(tb_codigo.Text), cont)

                        Else

                            DatosGastos.Insertar_Movimiento_Gasto(DGV_Movimientos.Rows(cont).Cells(0).Value.ToString, DGV_Movimientos.Rows(cont).Cells(1).Value.ToString, _
                                          DGV_Movimientos.Rows(cont).Cells(2).Value.ToString, DGV_Movimientos.Rows(cont).Cells(4).Value, _
                                          0, DGV_Movimientos.Rows(cont).Cells(6).Value.ToString, _
                                          DGV_Movimientos.Rows(cont).Cells(3).Value.ToString, CInt(tb_codigo.Text), cont)


                        End If

                    Next

                    DatosGastos.Modificar_Relacion(CInt(tb_codigo.Text), tb_aprobada.Text, tb_observ.Text)
                    deny = True

                Else

                    MsgBox("La relación debe tener al menos un movimiento", MsgBoxStyle.Exclamation, "SINPRO")
                    tb_Documento.Focus()

                End If

            Else

                MsgBox("El monto disponible no puede ser negativo", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe llenar los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

        End If

        If deny Then

            Habilitar_Desabilitar_Controles(False)
            cb_tipo_SelectedIndexChanged(cb_tipo, New EventArgs)
            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Relación modificada", ToolTipIcon.Info)

        End If

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        LimpiarFormularios()
        Habilitar_Desabilitar_Controles(False)
        Dgv_relaciones.ClearSelection()

    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged

        LimpiarFormularios()

        If buscar Then

            If cb_ano.SelectedIndex <> -1 And cb_mes.SelectedIndex <> -1 Then

                cb_ano_SelectedIndexChanged(cb_ano, New EventArgs)

            ElseIf cb_tipo.SelectedIndex <> -1 Then

                DatosGastos.Consulta_Relaciones(Dgv_relaciones, "", 0, CInt(cb_tipo.SelectedItem(0).ToString), 0, 0)

            End If

        End If

    End Sub

    Private Sub cb_mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_mes.SelectedIndexChanged

        If cb_ano.SelectedIndex <> -1 And cb_mes.SelectedIndex <> -1 And cb_tipo.SelectedIndex <> -1 Then

            If buscar Then

                If cb_mes.SelectedIndex = 0 Then

                    DatosGastos.Consulta_Relaciones(Dgv_relaciones, "", 0, CInt(cb_tipo.SelectedItem(0).ToString), cb_mes.SelectedIndex, CInt(cb_ano.Text))

                Else

                    DatosGastos.Consulta_Relaciones(Dgv_relaciones, "", 2, CInt(cb_tipo.SelectedItem(0).ToString), cb_mes.SelectedIndex, CInt(cb_ano.Text))

                End If

            End If

        End If

    End Sub

    Private Sub DGV_Relaciones_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_relaciones.CellClick, Dgv_relaciones.KeyDown, Dgv_relaciones.KeyUp

        If Dgv_relaciones.SelectedRows.Count > 0 Then

            tb_codigo.Text = Dgv_relaciones.SelectedRows(0).Cells(0).Value.ToString
            dtp1.Value = Dgv_relaciones.SelectedRows(0).Cells(1).Value.ToString
            tb_elaborada.Text = Dgv_relaciones.SelectedRows(0).Cells(2).Value.ToString
            tb_aprobada.Text = Dgv_relaciones.SelectedRows(0).Cells(3).Value.ToString
            tb_observ.Text = Dgv_relaciones.SelectedRows(0).Cells(4).Value.ToString
            chk_cerrada.Checked = Dgv_relaciones.SelectedRows(0).Cells(5).Value.ToString
            lb_limite.Text = Format(Dgv_relaciones.SelectedRows(0).Cells(6).Value, "#,##0.00")

            DatosGastos.Consulta_Movimientos_Relaciones(DGV_Movimientos, CInt(Dgv_relaciones.SelectedRows(0).Cells(0).Value))

        End If

    End Sub

    Private Sub bt_agregarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarMov.Click

        If tb_Documento.Text.Trim <> "" And tb_descripcion.Text.Trim <> "" And tb_monto.Text.Trim <> "" And tb_numeroDoc.Text.Trim <> "" Then

            If IsNumeric(tb_monto.Text) Then

                If CDbl(lb_disponible.Text) + CDbl(tb_monto.Text) >= 0 Then

                    If CDbl(tb_monto.Text) < 0 Then

                        DGV_Movimientos.Rows.Add(tb_Documento.Text, tb_numeroDoc.Text, tb_descripcion.Text, dtp2.Value, Format(CDbl(tb_monto.Text.Replace("-", "")), "#,##0.00"), "", "")

                    Else

                        DGV_Movimientos.Rows.Add(tb_Documento.Text, tb_numeroDoc.Text, tb_descripcion.Text, dtp2.Value, "", Format(CDbl(tb_monto.Text), "#,##0.00"), "")

                    End If

                    tb_descripcion.Clear()
                    tb_Documento.Clear()
                    tb_monto.Clear()
                    tb_numeroDoc.Clear()
                    DGV_Movimientos.ClearSelection()
                    tb_Documento.Focus()

                Else

                    MsgBox("No puede exceder el monto disponible", MsgBoxStyle.Exclamation, "SINPRO")
                    tb_monto.Focus()
                    tb_monto.SelectAll()

                End If

            Else

                MsgBox("Debe introducir un valor numérico en el monto", MsgBoxStyle.Exclamation, "SINPRO")
                tb_monto.Clear()
                tb_monto.Focus()

            End If

        Else

            MsgBox("Debe llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")
            tb_Documento.Focus()

        End If

    End Sub

    Private Sub cb_ano_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_ano.SelectedIndexChanged

        If cb_ano.SelectedIndex <> -1 And cb_mes.SelectedIndex <> -1 Then

            If buscar Then

                If cb_mes.SelectedIndex = 0 Then

                    DatosGastos.Consulta_Relaciones(Dgv_relaciones, "", 3, CInt(cb_tipo.SelectedItem(0).ToString), cb_mes.SelectedIndex, CInt(cb_ano.Text))

                Else

                    DatosGastos.Consulta_Relaciones(Dgv_relaciones, "", 2, CInt(cb_tipo.SelectedItem(0).ToString), cb_mes.SelectedIndex, CInt(cb_ano.Text))

                End If

            End If

        End If

    End Sub

    Private Sub tb_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_monto.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_monto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_monto.Leave

        tb_monto.Text = tb_monto.Text.Replace(".", ",")

    End Sub

    Private Sub bt_eliminarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarMov.Click

        If DGV_Movimientos.SelectedRows.Count > 0 Then

            If DGV_Movimientos.SelectedRows(0).Cells(2).Value.ToString.ToUpper <> "SOBRANTE MES ANTERIOR" Then

                DGV_Movimientos.Rows.RemoveAt(DGV_Movimientos.SelectedRows(0).Index)

            Else

                MsgBox("No puede eliminar este movimiento", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        End If

    End Sub

    Private Sub DGV_Movimientos_RowsAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Movimientos.RowsAdded, DGV_Movimientos.RowsRemoved

        Dim Egresos As Double = 0
        Dim Ingresos As Double = 0

        For cont As Integer = 0 To DGV_Movimientos.RowCount - 1

            If DGV_Movimientos.Rows(cont).Cells(4).Value <> "" Then

                Egresos = Egresos + CDbl(DGV_Movimientos.Rows(cont).Cells(4).Value)

            Else

                Ingresos = Ingresos + CDbl(DGV_Movimientos.Rows(cont).Cells(5).Value)

            End If

        Next

        lbl_egresos.Text = Format(Egresos, "#,##0.00")
        lb_disponible.Text = Format(Ingresos - Egresos, "#,##0.00")

    End Sub

End Class