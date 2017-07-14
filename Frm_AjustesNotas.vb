Public Class Frm_AjustesNotas
    Public Nota As Boolean = False
    Dim enter2 As Boolean = False
    Dim varboton As Integer = 0
    Dim w As Boolean
    Dim e As Boolean


    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is bt_salir Then

            varboton = 4

            ToolBar1.Enabled = True
            cb_almacen.SelectedIndex = 0
            cb_cuarto.SelectedIndex = 0
            cb_estante.SelectedIndex = 0
            cb_tramo.SelectedIndex = 0
            gb_Direccion.Enabled = False
            tb_observacion.Enabled = False
            DateTimePicker1.Enabled = False
            lbl_control.Text = ""
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            Dgv_AjustesNotasC.Visible = True
            Dgv_NC.Visible = False
            'DGV_ProductosAjuste.Enabled = False
            DGV_ProductosAjuste.Rows.Clear()
            'DGV_ProductosNota.Enabled = False
            DGV_ProductosNota.Rows.Clear()
            tb_cantidad.Clear()
            tb_buscarcodigo.Clear()
            tb_obs.Clear()
            tb_observacion.Clear()
            Dud_Buscar.Items.Clear()
            Dud_Buscar.Items.Add("Nro. Ajuste")
            Dud_Buscar.Text = "Nro. Ajuste"
            Dgv_AjustesNotasC.Visible = True
            Dgv_NC.Visible = False
            Dgv_NC.Enabled = True
            Dgv_AjustesNotasC.ClearSelection()
            Me.Close()

        ElseIf e.Button Is bt_nuevo Then

            ToolBar1.Enabled = False
            varboton = 1
            DateTimePicker1.Value = Today
            lbl_control.Text = DatosAjustesPorNC.identidad_ajuste
            'bt_aceptar.Visible = True
            'bt_cancelar.Visible = True
            'DGV_ProductosAjuste.Enabled = True
            DGV_ProductosAjuste.Rows.Clear()
            'DGV_ProductosNota.Enabled = True
            'cb_almacen.SelectedIndex = 0
            DGV_ProductosNota.Rows.Clear()
            tb_cantidad.Clear()
            tb_buscarcodigo.Clear()
            tb_obs.Clear()
            tb_observacion.Clear()
            tb_cliente.Text = ""
            DGV_ProductosAjuste.Columns(6).ReadOnly = False
            tb_codcliente.Text = ""
            Label4.Text = ""
            tb_NC.Text = ""
            Dud_Buscar.Items.Clear()
            Dud_Buscar.Items.Add("Nro.Control NC")
            Dud_Buscar.Items.Add("Cliente")
            Dud_Buscar.SelectedIndex = 0
            Dgv_AjustesNotasC.Visible = False
            'DatosAjustesPorNC.consulta_notaCredito(Dgv_NC, 0, "")
            Me.Sp_consultaNotaCreditoNoAjustadaTableAdapter.Fill(Me.MELDataSet.sp_consultaNotaCreditoNoAjustada, 0, "")
            Dgv_NC.Columns(0).Visible = False
            Dgv_NC.Sort(Dgv_NC.Columns(1), System.ComponentModel.ListSortDirection.Descending)
            DGV_ProductosAjuste.Columns(4).HeaderText = "Ubic. Dest."
            Dgv_NC.Visible = True
            Dgv_NC.ClearSelection()
            DGV_ProductosNota.Columns(6).ReadOnly = False
            tb_usuario.Text = Frm_Login.user

            If Dgv_NC.RowCount <= 0 Then
                MsgBox("No hay notas de crédito por ajustar", MsgBoxStyle.Exclamation, "SINPRO")
                bt_cancelar_Click(bt_cancelar, New EventArgs)
            End If

        ElseIf e.Button Is bt_modificar Then

            If Dgv_AjustesNotasC.SelectedRows.Count > 0 Then

                ToolBar1.Enabled = False
                varboton = 2
                tb_observacion.Enabled = True
                DateTimePicker1.Enabled = True
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                tb_usuario.Text = Frm_Login.user
                Dgv_AjustesNotasC.Enabled = False
                'DGV_ProductosAjuste.Enabled = True
                'DGV_ProductosAjuste.ReadOnly = True
                'DGV_ProductosNota.Enabled = True
                'DGV_ProductosNota.ReadOnly = True
                gb_Direccion.Enabled = True
                cb_almacen.SelectedIndex = 0
                DGV_ProductosAjuste.Columns(4).HeaderText = "Ubic. Dest."
                DGV_ProductosNota.Columns(6).ReadOnly = False
                DGV_ProductosAjuste.Columns(6).ReadOnly = False
           

            Else

                MsgBox("Debe seleccionar un ajuste a modificar", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If

        ElseIf e.Button Is bt_imprimir Then

            If Dgv_AjustesNotasC.SelectedRows.Count > 0 Then

                varboton = 3

            Else

                MsgBox("Debe seleccionar un ajuste a imprimir", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If

        End If
    End Sub

    Private Sub Frm_AjustesNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Table_Almacen' Puede moverla o quitarla según sea necesario.
        Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
        Me.Sp_lvAjustesPorNCTableAdapter.Fill(Me.MELDataSet.sp_lvAjustesPorNC, 0, "")
        'DatosAjustesPorNC.Dgv_Ajustes(Dgv_AjustesNotasC, 0, 0)
        'Dgv_AjustesNotasC.Sort(Dgv_AjustesNotasC.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        tb_cantidad.Clear()
        tb_buscarcodigo.Clear()
        tb_obs.Clear()
        tb_observacion.Clear()
        tb_usuario.Text = Frm_Login.user
        Dgv_AjustesNotasC.ClearSelection()
        DGV_ProductosNota.Columns(6).ReadOnly = True
        Dud_Buscar.SelectedIndex = 0
        tb_buscarcodigo.Focus()
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_imprimir.Visible = False
            Me.bt_modificar.Visible = False
        End If

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub cb_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedValueChanged
        DatosProducto.llenar_cuartos(cb_cuarto, CInt(cb_almacen.SelectedValue))
    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedValueChanged
        DatosProducto.llenar_estantes(cb_estante, CInt(cb_cuarto.SelectedValue))
    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedValueChanged
        DatosProducto.llenar_tramos(cb_tramo, CInt(cb_estante.SelectedValue))
    End Sub

    Private Sub Dgv_AjustesNotasC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_AjustesNotasC.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Dgv_AjustesNotasC.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        End If
    End Sub

    Private Sub Dgv_AjustesNotasC_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_AjustesNotasC.CellClick, Dgv_AjustesNotasC.KeyUp
        Try

            lbl_control.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(0).Value
            tb_usuario.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(1).Value
            DateTimePicker1.Value = Dgv_AjustesNotasC.SelectedRows(0).Cells(2).Value
            tb_observacion.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(3).Value
            tb_codcliente.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(4).Value
            tb_cliente.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(5).Value
            Label4.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(7).Value
            tb_NC.Text = Dgv_AjustesNotasC.SelectedRows(0).Cells(8).Value
            DatosAjustesPorNC.consultaAjuste(DGV_ProductosAjuste, DGV_ProductosNota, CInt(Dgv_AjustesNotasC.SelectedRows(0).Cells(0).Value))
            DGV_ProductosAjuste.ClearSelection()

        Catch ex As Exception

        Finally

            DGV_ProductosNota.ClearSelection()

        End Try


    End Sub

    Private Sub Dgv_NotasC_Rows(ByVal sender As System.Object, ByVal e As EventArgs) Handles Dgv_AjustesNotasC.RowsAdded, Dgv_AjustesNotasC.RowsRemoved
        Label2.Text = Dgv_AjustesNotasC.Rows.Count
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        ToolBar1.Enabled = True
        Chk_Todos.Checked = False
        cb_almacen.SelectedIndex = 0
        cb_cuarto.SelectedIndex = 0
        cb_estante.SelectedIndex = 0
        cb_tramo.SelectedIndex = 0
        gb_Direccion.Enabled = False
        tb_observacion.Enabled = False
        DateTimePicker1.Enabled = False
        lbl_control.Text = ""
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        Dgv_AjustesNotasC.Visible = True
        Dgv_NC.Visible = False
        tb_buscarcodigo.Enabled = True
        'DGV_ProductosAjuste.Enabled = False
        DGV_ProductosAjuste.Rows.Clear()
        'DGV_ProductosNota.Enabled = False
        DGV_ProductosAjuste.Columns(6).ReadOnly = True
        DGV_ProductosNota.Rows.Clear()
        tb_cantidad.Clear()
        tb_buscarcodigo.Clear()
        tb_obs.Clear()
        Label4.Text = ""
        tb_cliente.Text = ""
        tb_codcliente.Text = ""
        tb_observacion.Clear()
        CrearWhere()
        Dud_Buscar.Items.Clear()
        Dud_Buscar.Items.Add("Nro. Ajuste")
        Dud_Buscar.Items.Add("Cliente")
        Dud_Buscar.Items.Add("Control NC")
        Dud_Buscar.Items.Add("Control Fact")
        CrearWhere()
        'Dud_Buscar.Text = "Nro. Ajuste"
        Dud_Buscar.SelectedIndex = 0
        Dgv_AjustesNotasC.Visible = True
        Dgv_NC.Visible = False
        Dgv_NC.Enabled = True
        tb_NC.Text = ""
        Dgv_AjustesNotasC.Enabled = True
        Dgv_AjustesNotasC.ClearSelection()
        Dgv_NC.ClearSelection()
        tb_usuario.Text = Frm_Login.user
        DateTimePicker1.Value = Today
        DGV_ProductosNota.Columns(6).ReadOnly = True
        DGV_ProductosAjuste.Columns(4).HeaderText = "Ubic. Actual"

        If Nota Then

            Me.Close()

        End If

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Try

            Dim deny As Boolean = False
            Dim caracteres As Boolean = False

            If My.Settings.Empresa = 2 Then
                If tb_observacion.Text.Trim.Length < 20 Then
                    caracteres = True
                End If
            End If

            If Not caracteres Then

                If varboton = 1 Then

                    DatosAjustesPorNC.InsertaAjustePorNC(CInt(Dgv_NC.SelectedRows(0).Cells(0).Value), tb_observacion.Text, tb_usuario.Text, DateTimePicker1.Value)

                    Dim cont As Integer = 0

                    For cont = 0 To DGV_ProductosAjuste.RowCount - 1

                        DatosAjustesPorNC.InsertaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(6).Value.ToString, True, CInt(DGV_ProductosAjuste.Rows(cont).Cells(0).Value.ToString), CInt(DGV_ProductosAjuste.Rows(cont).Cells(5).Value.ToString))

                    Next

                    For cont = 0 To DGV_ProductosNota.RowCount - 1

                        DatosAjustesPorNC.InsertaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosNota.Rows(cont).Cells(1).Value.ToString, DGV_ProductosNota.Rows(cont).Cells(7).Value.ToString, False, CInt(DGV_ProductosNota.Rows(cont).Cells(0).Value.ToString), 0)

                    Next

                    DatosAjustesPorNC.actualizaAjustadaNC(CInt(Dgv_NC.SelectedRows(0).Cells(0).Value))

                    Datos.Inserta_Actividad("Creó el ajuste nota de crédito nro. " + lbl_control.Text + " de la Nota nro. " + Dgv_NC.SelectedRows(0).Cells(1).Value.ToString + " de la fact nro. " + Dgv_NC.SelectedRows(0).Cells(6).Value.ToString + " del cliente (" + Dgv_NC.SelectedRows(0).Cells(5).Value.ToString + ") " + Dgv_NC.SelectedRows(0).Cells(4).Value.ToString)
                    MsgBox("Ajuste creado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")

                    'deny = False

                ElseIf varboton = 2 Then

                    DatosAjustesPorNC.EliminaProductosAjustePorNC(CInt(lbl_control.Text))

                    Dim cont As Integer = 0

                    For cont = 0 To DGV_ProductosNota.RowCount - 1

                        DatosAjustesPorNC.InsertaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosNota.Rows(cont).Cells(1).Value.ToString, DGV_ProductosNota.Rows(cont).Cells(6).Value.ToString, False, CInt(DGV_ProductosNota.Rows(cont).Cells(0).Value.ToString), 0)

                    Next

                    For cont = 0 To DGV_ProductosAjuste.RowCount - 1

                        If DGV_ProductosAjuste.Rows(cont).Cells(8).Value = False Then

                            If DatosAjustesPorNC.VerificaProductoEnAjuste(CInt(lbl_control.Text), DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString) Then

                                DatosAjustesPorNC.ModificaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(6).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(0).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(5).Value.ToString)

                            Else

                                DatosAjustesPorNC.InsertaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(6).Value.ToString, True, CInt(DGV_ProductosAjuste.Rows(cont).Cells(0).Value.ToString), CInt(DGV_ProductosAjuste.Rows(cont).Cells(5).Value.ToString))

                            End If

                        Else

                            DatosAjustesPorNC.ModificaProductoAjustePorNC(CInt(lbl_control.Text), DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString, DGV_ProductosAjuste.Rows(cont).Cells(6).Value.ToString, 0, DGV_ProductosAjuste.Rows(cont).Cells(5).Value.ToString)

                        End If

                    Next

                    DatosAjustesPorNC.ModificaAjustePorNC(tb_observacion.Text, tb_usuario.Text, DateTimePicker1.Value, CInt(lbl_control.Text))
                    Datos.Inserta_Actividad("Modificó el ajuste nota de crédito nro. " + lbl_control.Text + " de la Nota nro. " + tb_NC.Text + " de la fact nro. " + Label4.Text + " del cliente (" + tb_codcliente.Text + ") " + tb_cliente.Text)

                End If

                If deny = False Then
                    eliminarUbicacion()
                    Chk_Todos.Checked = False
                    ToolBar1.Enabled = True
                    cb_almacen.SelectedIndex = 0
                    cb_cuarto.SelectedIndex = 0
                    cb_estante.SelectedIndex = 0
                    cb_tramo.SelectedIndex = 0
                    gb_Direccion.Enabled = False
                    tb_observacion.Enabled = False
                    DateTimePicker1.Enabled = False
                    lbl_control.Text = ""
                    bt_aceptar.Visible = False
                    bt_cancelar.Visible = False
                    Dgv_AjustesNotasC.Visible = True
                    Dgv_NC.Visible = False
                    'DGV_ProductosAjuste.Enabled = False
                    DGV_ProductosAjuste.Rows.Clear()
                    'DGV_ProductosNota.Enabled = False
                    tb_buscarcodigo.Enabled = True
                    DGV_ProductosNota.Rows.Clear()
                    tb_cantidad.Clear()
                    tb_buscarcodigo.Clear()
                    tb_obs.Clear()
                    tb_observacion.Clear()
                    DGV_ProductosAjuste.Columns(6).ReadOnly = True
                    tb_cliente.Text = ""
                    tb_codcliente.Text = ""
                    Dud_Buscar.Items.Clear()
                    Dud_Buscar.Items.Add("Nro. Ajuste")
                    Dud_Buscar.Items.Add("Cliente")
                    Dud_Buscar.Items.Add("Control NC")
                    Dud_Buscar.Items.Add("Control Fact")
                    Dud_Buscar.Text = "Nro. Ajuste"
                    Dgv_AjustesNotasC.Visible = True
                    Dgv_NC.Visible = False
                    Label4.Text = ""
                    Dgv_NC.Enabled = True
                    Dgv_AjustesNotasC.Enabled = True
                    'DatosAjustesPorNC.Dgv_Ajustes(Dgv_AjustesNotasC, 0, 0)
                    Me.Sp_lvAjustesPorNCTableAdapter.Fill(Me.MELDataSet.sp_lvAjustesPorNC, 0, "")
                    CrearWhere()
                    Dgv_AjustesNotasC.ClearSelection()
                    Dgv_NC.ClearSelection()
                    tb_usuario.Text = Frm_Login.user
                    DGV_ProductosAjuste.Columns(4).HeaderText = "Ubic. Actual"
                    tb_NC.Text = ""
                    DateTimePicker1.Value = Today
                    DGV_ProductosNota.Columns(6).ReadOnly = True
                    tb_buscarcodigo.Focus()

                    If Nota Then

                        Me.Close()

                    End If

                End If

            Else

                MsgBox("Debe asignar al ajuste una observación de al menos 20 caracteres", MsgBoxStyle.Information, "SINPRO")

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bt_agregarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarProducto.Click

        If DGV_ProductosNota.RowCount > 0 Then

            If DGV_ProductosNota.SelectedRows.Count > 0 Then


                If tb_cantidad.Text = "0" Or tb_cantidad.Text = "" Then

                    MsgBox("Debe introducir una cantidad válida", MsgBoxStyle.Exclamation, "Mensaje de error")
                    tb_cantidad.Focus()

                Else

                    If CInt(tb_cantidad.Text) <= CInt(DGV_ProductosNota.SelectedRows(0).Cells(0).Value) Then

                        Dim esta As Boolean = False
                        Dim cont As Integer = 0

                        For cont = 0 To DGV_ProductosAjuste.RowCount - 1

                            If (DGV_ProductosAjuste.Rows(cont).Cells(1).Value.ToString = DGV_ProductosNota.SelectedRows(0).Cells(1).Value.ToString And DGV_ProductosAjuste.Rows(cont).Cells(4).Value.ToString = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text) And DGV_ProductosAjuste.Rows(cont).Cells(8).Value = False Then

                                DGV_ProductosAjuste.Rows(cont).Cells(0).Value = CInt(DGV_ProductosAjuste.Rows(cont).Cells(0).Value) + CInt(tb_cantidad.Text)
                                esta = True

                            End If

                        Next

                        If esta = False Then

                            DGV_ProductosAjuste.Rows.Add(CInt(tb_cantidad.Text), DGV_ProductosNota.SelectedRows(0).Cells(1).Value, DGV_ProductosNota.SelectedRows(0).Cells(2).Value, DGV_ProductosNota.SelectedRows(0).Cells(3).Value, cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text, CInt(cb_tramo.SelectedValue), tb_obs.Text, DGV_ProductosNota.SelectedRows(0).Cells(4).Value.ToString, DGV_ProductosNota.SelectedRows(0).Cells(8).Value, DGV_ProductosNota.SelectedRows(0).Cells(5).Value.ToString, DGV_ProductosNota.SelectedRows(0).Cells(6).Value.ToString)

                        End If

                        DGV_ProductosNota.SelectedRows(0).Cells(0).Value = CInt(DGV_ProductosNota.SelectedRows(0).Cells(0).Value) - CInt(tb_cantidad.Text)
                        If DGV_ProductosNota.SelectedRows(0).Cells(0).Value = 0 Then
                            DGV_ProductosNota.Rows.Remove(DGV_ProductosNota.SelectedRows(0))
                            DGV_ProductosNota_CellClick(DGV_ProductosNota, New EventArgs)
                        End If
                        tb_cantidad.Clear()
                        tb_obs.Clear()
                        DGV_ProductosAjuste.ClearSelection()

                    Else

                        MsgBox("No puede introducir una cantidad mayor a la devuelta", MsgBoxStyle.Exclamation, "Mensaje de error")
                        tb_cantidad.Focus()
                        tb_cantidad.SelectAll()

                    End If

                End If

            Else
                MsgBox("Debe seleccionar un producto a agregar", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If

        Else

            MsgBox("La lista está vacía", MsgBoxStyle.Exclamation, "Mensaje de error")

        End If

    End Sub


    Private Sub tb_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cantidad.KeyPress

        If (sender Is Me.tb_cantidad) Then

            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

                e.Handled = False
                muestra_label(sender, 1)

            Else

                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números"

            End If

        End If

    End Sub


    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.Label22.Location = New System.Drawing.Point(c.Location.X - c.Size.Width, c.Location.Y + 400)
            Me.ErrorProvider1.SetIconAlignment(Label22, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.ErrorProvider1.SetIconPadding(Label22, 2)
            Me.ErrorProvider1.SetError(Label22, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Public Sub Dgv_NC_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_NC.CellClick, Dgv_NC.KeyUp
        Try
            DatosNotaCredito.consulta_productosnotaCredito(DGV_ProductosNota, CInt(Dgv_NC.SelectedRows(0).Cells(0).Value), 7)
            DGV_ProductosNota.Sort(DGV_ProductosNota.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            tb_cliente.Text = Dgv_NC.SelectedRows(0).Cells(4).Value
            tb_codcliente.Text = Dgv_NC.SelectedRows(0).Cells(5).Value
            Label4.Text = Dgv_NC.SelectedRows(0).Cells(6).Value
            tb_NC.Text = Dgv_NC.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        Finally

            DGV_ProductosAjuste.ClearSelection()
            DGV_ProductosNota.ClearSelection()

        End Try


    End Sub

    Public Sub Dgv_Facturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_NC.CellDoubleClick

        Dgv_NC.Enabled = False
        'DatosNotaCredito.consulta_productosnotaCredito(DGV_ProductosNota, CInt(Dgv_NC.SelectedRows(0).Cells(0).Value), 7)
        DGV_ProductosNota.Sort(DGV_ProductosNota.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        tb_cliente.Text = Dgv_NC.SelectedRows(0).Cells(4).Value
        tb_codcliente.Text = Dgv_NC.SelectedRows(0).Cells(5).Value
        Label4.Text = Dgv_NC.SelectedRows(0).Cells(6).Value
        tb_NC.Text = Dgv_NC.SelectedRows(0).Cells(1).Value
        DGV_ProductosAjuste.ClearSelection()
        DGV_ProductosNota.ClearSelection()
        gb_Direccion.Enabled = True
        bt_aceptar.Visible = True
        bt_cancelar.Visible = True
        tb_observacion.Enabled = True
        DateTimePicker1.Enabled = True
        tb_observacion.Focus()
        tb_buscarcodigo.Enabled = False

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then

            If Dgv_AjustesNotasC.Visible Then

                If Dgv_AjustesNotasC.RowCount > 0 Then
                    Me.Dgv_AjustesNotasC.Rows(0).Cells(0).Selected = True
                    Dgv_AjustesNotasC.Focus()
                End If



            ElseIf Dgv_NC.Visible Then

                If Dgv_NC.RowCount > 0 Then
                    Dgv_NC.Rows(0).Cells(1).Selected = True
                    Dgv_NC.Focus()
                End If


            End If

        End If
    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        'If Dud_Buscar.Text = "Nro. Ajuste" Then

        '    DatosAjustesPorNC.Dgv_Ajustes(Dgv_AjustesNotasC, 1, tb_buscarcodigo.Text)
        '    Dgv_AjustesNotasC.ClearSelection()

        'ElseIf Dud_Buscar.Text = "Nro.Control NC" Then

        '    DatosAjustesPorNC.consulta_notaCredito(Dgv_NC, 1, tb_buscarcodigo.Text)
        '    Dgv_NC.ClearSelection()

        'ElseIf Dud_Buscar.Text = "Cliente" Then

        '    If Dgv_NC.Visible Then

        '        DatosAjustesPorNC.consulta_notaCredito(Dgv_NC, 2, tb_buscarcodigo.Text)
        '        Dgv_NC.ClearSelection()

        '    Else

        '        DatosAjustesPorNC.Dgv_Ajustes(Dgv_AjustesNotasC, 3, tb_buscarcodigo.Text)
        '        Dgv_AjustesNotasC.ClearSelection()

        '    End If

        'End If

        CrearWhere()


        DGV_ProductosAjuste.Rows.Clear()
        DGV_ProductosNota.Rows.Clear()
        tb_obs.Clear()
        If Dgv_NC.Visible = False Then
            lbl_control.Text = ""
        End If
        tb_NC.Text = ""
        Label4.Text = ""
        tb_codcliente.Text = ""
        tb_cliente.Text = ""
        DateTimePicker1.Value = Today
        tb_usuario.Text = ""
        tb_observacion.Clear()
        tb_cantidad.Clear()

    End Sub

    Private Sub DGV_ProductosNota_CellClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_ProductosNota.CellClick, DGV_ProductosNota.KeyUp, DGV_ProductosNota.KeyDown

        If gb_Direccion.Enabled Then

            'cb_almacen.SelectedIndex = 0
            'cb_cuarto.SelectedIndex = 0
            'cb_estante.SelectedIndex = 0
            'cb_tramo.SelectedIndex = 0
            tb_cantidad.Clear()
            tb_obs.Clear()

            If DGV_ProductosNota.SelectedRows.Count > 0 Then

                If Not DGV_ProductosNota.SelectedRows(0).Cells(4).Value = "" Then

                    If Not DGV_ProductosNota.SelectedRows(0).Cells(4).Value = " " Then

                        cb_almacen.SelectedIndex = buscar(cb_almacen, DGV_ProductosNota.SelectedRows(0).Cells(4).Value.Split("-")(0))
                        cb_cuarto.SelectedIndex = buscar(cb_cuarto, DGV_ProductosNota.SelectedRows(0).Cells(4).Value.Split("-")(1))
                        cb_estante.SelectedIndex = buscar(cb_estante, DGV_ProductosNota.SelectedRows(0).Cells(4).Value.Split("-")(2))
                        cb_tramo.SelectedIndex = buscar(cb_tramo, DGV_ProductosNota.SelectedRows(0).Cells(4).Value.Split("-")(3))

                    End If

                End If

            End If

        End If

    End Sub


    Public Function buscar(ByRef cb As ComboBox, ByVal nombre As String) As Integer

        Dim pos As Integer = 0
        Dim pos2 As Integer = cb.SelectedIndex


        Dim cont As Integer = 0

        While cont <= cb.Items.Count - 1

            If cb.Text = nombre Then

                pos = cont
                cont = cb.Items.Count

            Else

                cont = cont + 1

                If cont < cb.Items.Count Then
                    cb.SelectedIndex = cont
                End If

            End If

        End While

        If pos = 0 Then
            Return pos2
        Else
            Return pos
        End If

    End Function


    Private Sub bt_eliminarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCuarto.Click

        Dim esta As Boolean = False
        Dim cont As Integer = 0

        If DGV_ProductosAjuste.SelectedRows.Count > 0 Then

            While cont <= DGV_ProductosNota.RowCount - 1

                If DGV_ProductosNota.Rows(cont).Cells(1).Value.ToString = DGV_ProductosAjuste.SelectedRows(0).Cells(1).Value.ToString And DGV_ProductosNota.Rows(cont).Cells(4).Value.ToString = DGV_ProductosAjuste.SelectedRows(0).Cells(7).Value.ToString Then

                    DGV_ProductosNota.Rows(cont).Cells(0).Value = CInt(DGV_ProductosNota.Rows(cont).Cells(0).Value) + CInt(DGV_ProductosAjuste.SelectedRows(0).Cells(0).Value)
                    esta = True
                    cont = DGV_ProductosNota.RowCount

                Else

                    cont = cont + 1

                End If

            End While

            If esta = False And DGV_ProductosAjuste.SelectedRows(0).Cells(8).Value = False Then

                DGV_ProductosNota.Rows.Add(DGV_ProductosAjuste.SelectedRows(0).Cells(0).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(1).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(2).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(3).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(7).Value.ToString, DGV_ProductosAjuste.SelectedRows(0).Cells(5).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(10).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(6).Value, DGV_ProductosAjuste.SelectedRows(0).Cells(8).Value)
                DGV_ProductosNota.Sort(DGV_ProductosNota.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

            End If

            If DGV_ProductosAjuste.SelectedRows(0).Cells(8).Value = False Then

                DGV_ProductosAjuste.Rows.Remove(DGV_ProductosAjuste.SelectedRows(0))

            End If

        Else

            MsgBox("Debe seleccionar un producto a eliminar", MsgBoxStyle.Exclamation, "Mensaje de error")

        End If

    End Sub

    Private Sub Dgv_NC_RowsAdded(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_NC.RowsAdded, Dgv_NC.RowsRemoved

        If Dgv_NC.Visible Then

            Label2.Text = Dgv_NC.RowCount

        End If

    End Sub

    Private Sub Chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Todos.CheckedChanged
        If Chk_Todos.Checked Then

            Dim cont As Integer = 0
            Dim cont2 As Integer = 0
            Dim filas As Integer = 0

            If varboton = 1 Then


                While cont < DGV_ProductosNota.RowCount
                    cont2 = 0
                    For k As Integer = 0 To DGV_ProductosNota.RowCount - 1
                        If DGV_ProductosNota.Rows(k).Cells(4).Value.ToString <> "" Then
                            cont2 = cont2 + 1
                        End If
                    Next
                    If cont2 = 0 Then
                        cont = Dgv_AjustesNotasC.RowCount
                    End If
                    If cont2 <> 0 Then
                        If DGV_ProductosNota.Rows(filas).Cells(4).Value IsNot Nothing Then
                            If DGV_ProductosNota.Rows(filas).Cells(4).Value <> "" Then
                                Dim esta As Boolean = False
                                Dim cont5 As Integer = 0
                                While cont5 <= DGV_ProductosAjuste.RowCount - 1
                                    If DGV_ProductosNota.Rows(filas).Cells(1).Value.ToString = DGV_ProductosAjuste.Rows(cont5).Cells(1).Value.ToString And DGV_ProductosNota.Rows(filas).Cells(4).Value.ToString = DGV_ProductosAjuste.Rows(cont5).Cells(4).Value.ToString Then
                                        esta = True
                                        DGV_ProductosAjuste.Rows(cont5).Cells(0).Value = CInt(DGV_ProductosAjuste.Rows(cont5).Cells(0).Value) + CInt(DGV_ProductosNota.Rows(filas).Cells(0).Value)
                                        cont5 = DGV_ProductosAjuste.RowCount
                                    Else
                                        cont5 = cont5 + 1
                                    End If
                                End While
                                If esta = False Then
                                    DGV_ProductosAjuste.Rows.Add(DGV_ProductosNota.Rows(filas).Cells(0).Value, DGV_ProductosNota.Rows(filas).Cells(1).Value, DGV_ProductosNota.Rows(filas).Cells(2).Value, DGV_ProductosNota.Rows(filas).Cells(3).Value, DGV_ProductosNota.Rows(filas).Cells(4).Value, DGV_ProductosNota.Rows(filas).Cells(5).Value, DGV_ProductosNota.Rows(filas).Cells(7).Value, DGV_ProductosNota.Rows(filas).Cells(4).Value, DGV_ProductosNota.Rows(filas).Cells(8).Value, DGV_ProductosNota.Rows(filas).Cells(7).Value, DGV_ProductosNota.Rows(filas).Cells(6).Value)
                                End If
                                DGV_ProductosNota.Rows.RemoveAt(filas)
                                cont = cont - 1
                            Else
                                filas = filas + 1
                            End If
                        Else
                            filas = filas + 1
                        End If
                    End If
                    cont = cont + 1
                End While

            Else  '------------------------------------Modificar--------------------------------------------


                While cont < DGV_ProductosNota.RowCount
                    cont2 = 0
                    For k As Integer = 0 To DGV_ProductosNota.RowCount - 1
                        If DGV_ProductosNota.Rows(k).Cells(4).Value.ToString <> "" Then
                            cont2 = cont2 + 1
                        End If
                    Next
                    If cont2 = 0 Then
                        cont = Dgv_AjustesNotasC.RowCount
                    End If

                    If cont2 <> 0 Then

                        If DGV_ProductosNota.Rows(filas).Cells(4).Value IsNot Nothing Then

                            If DGV_ProductosNota.Rows(filas).Cells(4).Value <> "" Then

                                Dim esta As Boolean = False
                                Dim cont5 As Integer = 0

                                While cont5 <= DGV_ProductosAjuste.RowCount - 1

                                    If (DGV_ProductosNota.Rows(filas).Cells(1).Value.ToString = DGV_ProductosAjuste.Rows(cont5).Cells(1).Value.ToString And DGV_ProductosNota.Rows(filas).Cells(4).Value.ToString = DGV_ProductosAjuste.Rows(cont5).Cells(4).Value.ToString) And DGV_ProductosAjuste.Rows(cont5).Cells(8).Value = False Then
                                        esta = True
                                        DGV_ProductosAjuste.Rows(cont5).Cells(0).Value = CInt(DGV_ProductosAjuste.Rows(cont5).Cells(0).Value) + CInt(DGV_ProductosNota.Rows(filas).Cells(0).Value)
                                        cont5 = DGV_ProductosAjuste.RowCount
                                    Else
                                        cont5 = cont5 + 1
                                    End If

                                End While

                                If esta = False Then
                                    DGV_ProductosAjuste.Rows.Add(DGV_ProductosNota.Rows(filas).Cells(0).Value, DGV_ProductosNota.Rows(filas).Cells(1).Value, DGV_ProductosNota.Rows(filas).Cells(2).Value, DGV_ProductosNota.Rows(filas).Cells(3).Value, DGV_ProductosNota.Rows(filas).Cells(4).Value, DGV_ProductosNota.Rows(filas).Cells(5).Value, DGV_ProductosNota.Rows(filas).Cells(7).Value, DGV_ProductosNota.Rows(filas).Cells(4).Value, DGV_ProductosNota.Rows(filas).Cells(8).Value, DGV_ProductosNota.Rows(filas).Cells(7).Value, DGV_ProductosNota.Rows(filas).Cells(6).Value)
                                End If

                                DGV_ProductosNota.Rows.RemoveAt(filas)

                            Else

                                filas = filas + 1

                            End If


                        Else

                            filas = filas + 1

                        End If
                    End If
                End While


            End If


        Else

            If varboton = 1 Then
                Dim cont2 As Integer = 0

                While cont2 <= DGV_ProductosAjuste.RowCount - 1

                    Dim esta As Boolean = False
                    Dim cont As Integer = 0
                    Dim valor As Integer = 0

                    While cont <= DGV_ProductosNota.RowCount - 1

                        If DGV_ProductosNota.Rows(cont).Cells(1).Value.ToString = DGV_ProductosAjuste.Rows(0).Cells(1).Value.ToString And DGV_ProductosNota.Rows(cont).Cells(4).Value.ToString = DGV_ProductosAjuste.Rows(0).Cells(7).Value.ToString Then

                            'DGV_ProductosNota.Rows(cont).Cells(0).Value = CInt(DGV_ProductosNota.Rows(cont).Cells(0).Value) + CInt(DGV_ProductosAjuste.Rows(cont2).Cells(0).Value)
                            esta = True
                            valor = cont
                            cont = DGV_ProductosNota.RowCount

                        Else

                            cont = cont + 1

                        End If

                    End While

                    If esta = False Then

                        DGV_ProductosNota.Rows.Add(DGV_ProductosAjuste.Rows(0).Cells(0).Value, DGV_ProductosAjuste.Rows(0).Cells(1).Value, DGV_ProductosAjuste.Rows(0).Cells(2).Value, DGV_ProductosAjuste.Rows(0).Cells(3).Value, DGV_ProductosAjuste.Rows(0).Cells(7).Value.ToString, DGV_ProductosAjuste.Rows(0).Cells(5).Value, DGV_ProductosAjuste.Rows(0).Cells(10).Value, "", False, DGV_ProductosAjuste.Rows(0).Cells(8).Value)
                        DGV_ProductosNota.Sort(DGV_ProductosNota.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

                    Else

                        DGV_ProductosNota.Rows(valor).Cells(0).Value = CInt(DGV_ProductosNota.Rows(valor).Cells(0).Value) + CInt(DGV_ProductosAjuste.Rows(cont2).Cells(0).Value)

                    End If

                    DGV_ProductosAjuste.Rows.RemoveAt(0)

                End While

            Else

                Dim cont3 As Integer = 0

                While cont3 <= DGV_ProductosAjuste.RowCount - 1

                    Dim esta As Boolean = False
                    Dim cont As Integer = 0
                    Dim valor As Integer = 0

                    While cont <= DGV_ProductosNota.RowCount - 1

                        If (DGV_ProductosNota.Rows(cont).Cells(1).Value.ToString = DGV_ProductosAjuste.Rows(cont3).Cells(1).Value.ToString And DGV_ProductosNota.Rows(cont).Cells(4).Value.ToString = DGV_ProductosAjuste.Rows(cont3).Cells(7).Value.ToString) And DGV_ProductosAjuste.Rows(cont3).Cells(8).Value = False Then

                            DGV_ProductosNota.Rows(cont).Cells(0).Value = CInt(DGV_ProductosNota.Rows(cont).Cells(0).Value) + CInt(DGV_ProductosAjuste.SelectedRows(0).Cells(0).Value)
                            esta = True
                            valor = cont
                            cont = DGV_ProductosNota.RowCount

                        Else

                            cont = cont + 1

                        End If

                    End While

                    If esta = False Then

                        If DGV_ProductosAjuste.Rows(cont3).Cells(8).Value = False Then
                            DGV_ProductosNota.Rows.Add(DGV_ProductosAjuste.Rows(cont3).Cells(0).Value, DGV_ProductosAjuste.Rows(cont3).Cells(1).Value, DGV_ProductosAjuste.Rows(cont3).Cells(2).Value, DGV_ProductosAjuste.Rows(cont3).Cells(3).Value, DGV_ProductosAjuste.Rows(cont3).Cells(4).Value.ToString, DGV_ProductosAjuste.Rows(cont3).Cells(5).Value, DGV_ProductosAjuste.Rows(cont3).Cells(6).Value, False)
                            DGV_ProductosNota.Sort(DGV_ProductosNota.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                            DGV_ProductosAjuste.Rows.RemoveAt(cont3)
                            cont3 = cont3 - 1
                        End If

                    Else

                        '                        DGV_ProductosNota.Rows(valor).Cells(0).Value = CInt(DGV_ProductosAjuste.Rows(cont3).Cells(0).Value) + CInt(DGV_ProductosNota.Rows(valor).Cells(0).Value)

                    End If

                    cont3 = cont3 + 1

                End While


            End If



        End If


        DGV_ProductosAjuste.ClearSelection()
        DGV_ProductosNota.ClearSelection()

    End Sub

    Private Sub tb_obs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_obs.KeyDown
        If e.KeyCode = Keys.Enter Then
            tb_cantidad.Focus()
            tb_cantidad.SelectAll()
        End If
    End Sub

    Private Sub tb_cant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            bt_agregarCuarto_Click(bt_agregarProducto, New EventArgs)
        End If
    End Sub

    Public Sub recibe(ByVal b As Boolean)

        Nota = b

    End Sub

    Private Sub Dgv_NC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_NC.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Dgv_NC.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        ElseIf e.KeyCode = Keys.Enter Then
            Dgv_Facturas_CellContentClick(Dgv_NC, New DataGridViewCellEventArgs(Dgv_NC.CurrentCell.ColumnIndex, Dgv_NC.CurrentCell.RowIndex))
            enter2 = True
        End If
    End Sub


    Private Sub eliminarUbicacion()
        For cont2 As Integer = 0 To DGV_ProductosAjuste.RowCount - 1

            If DGV_ProductosAjuste.Rows(cont2).Cells(9).Value IsNot Nothing Then
                If DGV_ProductosAjuste.Rows(cont2).Cells(9).Value.ToString <> "" Then
                    DatosAjustesPorNC.EliminarUbicacionesCero(DGV_ProductosAjuste.Rows(cont2).Cells(1).Value.ToString, CInt(DGV_ProductosAjuste.Rows(cont2).Cells(9).Value))
                End If
            End If

        Next



    End Sub

    Private Sub Dgv_Facturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_NC.SelectionChanged
        If enter2 = True Then
            If Dgv_NC.CurrentCell.RowIndex > 0 Then
                Dgv_NC.Rows(Dgv_NC.CurrentCell.RowIndex - 1).Selected = True
            Else
                Dgv_NC.Rows(0).Cells(1).Selected = True
            End If
            enter2 = False
        End If
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If Dgv_AjustesNotasC.Visible Then

            If tb_buscarcodigo.Text <> "" Then

                If Dud_Buscar.SelectedIndex = 0 Then

                    where = where + "CodigoAjuste LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf Dud_Buscar.SelectedIndex = 1 Then

                    where = where + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf Dud_Buscar.SelectedIndex = 2 Then

                    where = where + "ControlNota LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "


                ElseIf Dud_Buscar.SelectedIndex = 3 Then

                    where = where + "ControlInicio LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "


                End If

            End If

            Me.SplvAjustesPorNCBindingSource.Filter = where
            Dgv_AjustesNotasC.ClearSelection()

        Else

            If tb_buscarcodigo.Text <> "" Then

                If Dud_Buscar.SelectedIndex = 0 Then

                    where = where + "NroControl2 LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf Dud_Buscar.SelectedIndex = 1 Then

                    where = where + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                End If

            End If

            Me.SpconsultaNotaCreditoNoAjustadaBindingSource.Filter = where
            Dgv_NC.ClearSelection()

        End If

    End Sub


End Class