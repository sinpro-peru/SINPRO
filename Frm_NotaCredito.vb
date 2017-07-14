Public Class Frm_NotaCredito

    Dim Varboton As Integer = 0
    Dim cambio As Boolean = False
    Dim antes1 As String = ""
    Dim antes2 As String = ""
    Dim seleccion As Boolean = False
    Public user As String = ""
    Dim bajar As Boolean = False
    Dim bajar2 As Boolean = False
    Dim enter1 As Boolean = False
    Dim w As Boolean
    Dim e As Boolean

    Private Sub Frm_NotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DateTimePicker1.Text = Today
        dud_buscar.Items.Add("Nro. Control Nota de Crédito")
        dud_buscar.Items.Add("Nro. Control Factura")
        dud_buscar.Items.Add("Cliente")
        tb_buscarcodigo.Clear()
        'DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 0, "")
        rb_Parcial.Checked = True
        rb_porcentaje.Checked = True
        Dgv_NotasC.ClearSelection()
        dud_buscar.SelectedIndex = 0
        ToolBar1.Enabled = True
        GroupBox1.Enabled = False
        GroupBox3.Enabled = False
        seleccion = True
        Dgv_DevolucionNC.ReadOnly = True
        ' Dgv_DescuentoNC.Enabled = False
        Dgv_DescuentoNC.Columns(0).ReadOnly = True
        Dgv_DescuentoNC.Rows.Clear()
        Dgv_DevolucionNC.Rows.Clear()
        Dgv_DevolucionNC.Columns(5).Width = 150
        Dgv_NotasC.ClearSelection()
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
            Me.bt_imprimir.Visible = False
        End If

        If Not My.Settings.Nro_Imp_Visible Then
            tb_imp.Visible = False
            Label13.Visible = False
            DateTimePicker1.Location = New System.Drawing.Point(109, 93)
            Label5.Location = New System.Drawing.Point(7, 96)
            Label22.Location = New System.Drawing.Point(7, 125)
            tb_observacion.Location = New System.Drawing.Point(109, 120)
            tb_user.Location = New System.Drawing.Point(109, 188)
            Label27.Location = New System.Drawing.Point(6, 191)
        End If

        Sp_consultaNotasCreditoTableAdapter.Fill(Me.MelDataSet1.sp_consultaNotasCredito, 0, "")
        CrearWhere()
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then

            rb_Parcial.Checked = True
            rb_porcentaje.Checked = True
            GroupBox1.Enabled = False
            GroupBox3.Enabled = False
            Dgv_DescuentoNC.Columns(0).ReadOnly = False
            seleccion = True
            Dgv_DevolucionNC.Columns(0).Visible = False
            Dgv_DevolucionNC.ReadOnly = True
            tb_controlInicio.Enabled = False
            tb_observacion.Enabled = False
            DateTimePicker1.Enabled = False
            ToolBar1.Enabled = True
            Dgv_NotasC.Enabled = True
            tb_controlInicio.Text = ""
            DateTimePicker1.Value = Today
            tb_observacion.Clear()
            tb_montodesc.Clear()
            tb_porcentaje.Clear()
            tb_buscarcodigo.Clear()
            Dgv_DevolucionNC.Columns(5).Width = 140
            Dgv_DevolucionNC.Columns(4).Width = 150
            Label16.Text = "0,00"
            Label17.Text = "0,00"
            Label19.Text = "0,00"
            Label28.Text = "0,00"
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
            Label30.Text = "0,00"
            TabControl1.SelectedIndex = 0
            Dgv_Facturas.Visible = False
            Dgv_NotasC.Visible = True
            'Dgv_Facturas.Rows.Clear()
            Dgv_Facturas.Enabled = True
            Dgv_DescuentoNC.Rows.Clear()
            Dgv_DevolucionNC.Rows.Clear()
            'DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 0, "")
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            Dgv_NotasC.ClearSelection()
            dud_buscar.Items.Clear()
            dud_buscar.Items.Add("Nro. Control Nota de Crédito")
            dud_buscar.Items.Add("Nro. Control Factura")
            dud_buscar.Items.Add("Cliente")
            dud_buscar.SelectedIndex = 0
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
            tb_buscarcodigo.Focus()
            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then

            Varboton = 1

            'Dgv_DescuentoNC.Columns(0).ReadOnly = False
            seleccion = True
            Dgv_Facturas.Enabled = True
            TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
            Dgv_DevolucionNC.Rows.Clear()
            ' Dgv_DescuentoNC.Enabled = True
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
            seleccion = False
            rb_pendiente.Checked = False
            rb_fisica.Checked = False

            Dgv_DevolucionNC.ReadOnly = False
            Dgv_DevolucionNC.Columns(1).ReadOnly = True
            Dgv_DevolucionNC.Columns(2).ReadOnly = True
            Dgv_DevolucionNC.Columns(3).ReadOnly = True
            Dgv_DevolucionNC.Columns(4).ReadOnly = True
            Dgv_DevolucionNC.Columns(5).ReadOnly = True
            Dgv_DevolucionNC.Columns(6).ReadOnly = True
            Dgv_DevolucionNC.Columns(7).ReadOnly = False
            tb_controlInicio.Text = ""
            tb_imp.Text = ""
            DateTimePicker1.Value = Today
            tb_observacion.Clear()
            Label16.Text = "0,00"
            Label17.Text = "0,00"
            Label19.Text = "0,00"
            Label28.Text = "0,00"
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
            Label30.Text = "0,00"
            tb_user.Text = user
            ToolBar1.Enabled = False
            Dgv_NotasC.ClearSelection()
            Dgv_NotasC.Enabled = False
            tb_montodesc.Clear()
            tb_porcentaje.Clear()
            Label4.Text = "##"
            Dgv_NotasC.Columns(0).Visible = True
            'Dgv_NotasC.Rows.Clear()
            'DatosNotaCredito.consulta_FactVentas(Dgv_Facturas, 0, "")
            Sp_consultaFactVentasTableAdapter.Fill(Me.MELDataSet.sp_consultaFactVentas, 0, "")
            Dgv_Facturas.Visible = True
            Dgv_NotasC.Visible = False
            dud_buscar.Items.Clear()
            dud_buscar.Items.Add("Cliente")
            dud_buscar.Items.Add("Nro. Control Factura")
            dud_buscar.SelectedIndex = 1
            Dgv_Facturas.ClearSelection()
            GroupBox4.Visible = False
            tb_buscarcodigo.Focus()

        ElseIf e.Button Is Me.bt_modificar Then

            If Dgv_NotasC.SelectedRows.Count > 0 Then
                Varboton = 2

                If Dgv_NotasC.SelectedRows(0).Cells(0).Value = 0 Then
                    rb_pendiente.Checked = True
                Else
                    rb_fisica.Checked = True
                End If

                If rb_fisica.Checked Then
                    Panel4.Enabled = False
                Else
                    Panel4.Enabled = True
                End If

                GroupBox1.Enabled = False
                GroupBox3.Enabled = False
                antes1 = tb_imp.Text
                antes2 = tb_controlInicio.Text
                tb_controlInicio.Enabled = True
                tb_observacion.Enabled = True
                DateTimePicker1.Enabled = True
                ToolBar1.Enabled = False
                Dgv_NotasC.Enabled = False
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                Dgv_Facturas.Enabled = False
                Dgv_DevolucionNC.ReadOnly = True

                If My.Settings.Nro_Imp_Visible Then
                    tb_imp.ReadOnly = False
                End If
                If My.Settings.Nro_Control_Editable Then
                    tb_controlInicio.ReadOnly = False
                End If

            Else

                MsgBox("Debe seleccionar una nota para modificar", MsgBoxStyle.Critical)

            End If



        ElseIf e.Button Is Me.bt_eliminar Then

            Varboton = 3
            If Dgv_NotasC.SelectedRows.Count > 0 Then

                Dim resp As Integer = MsgBox("Está seguro que desea eliminar la nota de crédito con Nro. De control " & Dgv_NotasC.SelectedRows(0).Cells(0).Value & "?", MsgBoxStyle.YesNo)

                If resp = vbYes Then

                    Dim hay As Boolean = False


                    DatosNotaCredito.consulta_Ajustes(2, Dgv_NotasC.SelectedRows(0).Cells(8).Value.ToString, hay)



                    If hay = False Then
                        DatosNotaCredito.elimina_NotaCredito(Dgv_NotasC.SelectedRows(0).Cells(8).Value)
                        Datos.Inserta_Actividad("Eliminó la nota de crédito nro. " + tb_controlInicio.Text + " de la fact. " + Dgv_NotasC.SelectedRows(0).Cells(1).Value.ToString + " del cliente (" + Dgv_NotasC.SelectedRows(0).Cells(13).Value.ToString + ") " + Dgv_NotasC.SelectedRows(0).Cells(3).Value.ToString)
                        Sp_consultaNotasCreditoTableAdapter.Fill(Me.MelDataSet1.sp_consultaNotasCredito, 0, "")
                        CrearWhere()
                        tb_controlInicio.Text = ""
                        DateTimePicker1.Value = Today
                        tb_observacion.Clear()
                        Label4.Text = "##"
                        Label16.Text = "0,00"
                        Label17.Text = "0,00"
                        Label19.Text = "0,00"
                        Label28.Text = "0,00"
                        Label18.Text = "0,00"
                        Label12.Text = "0,00"
                        Label20.Text = "0,00"
                        Label30.Text = "0,00"
                    Else
                        MsgBox("Esta nota de crédito tiene un ajuste. No puede ser eliminada", MsgBoxStyle.Exclamation)
                    End If


                End If

            Else

                MsgBox("Debe seleccionar una nota para eliminar", MsgBoxStyle.Exclamation)

            End If


        ElseIf e.Button Is Me.bt_imprimir Then

            If Dgv_NotasC.SelectedRows.Count > 0 Then

                If Dgv_NotasC.SelectedRows(0).Cells(7).Value = 0 Then

                    Dim nc As New R_NotaCredito_Desc
                    nc.valores_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value)
                    nc.Show()

                Else

                    Dim nc As New R_NotaCredito
                    nc.valores_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value)
                    nc.Show()

                End If

                Varboton = 4

            Else

                MsgBox("Debe seleccionar una nota para imprimir", MsgBoxStyle.Exclamation)

            End If




        End If
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Label4.Text = ""
        tb_user.Clear()
        Dgv_DescuentoNC.Columns(0).ReadOnly = True
        rb_Parcial.Checked = True
        rb_porcentaje.Checked = True
        GroupBox1.Enabled = False
        GroupBox3.Enabled = False
        'Dgv_DescuentoNC.Enabled = False
        rb_fisica.Checked = False
        rb_pendiente.Checked = False
        antes1 = ""
        antes2 = ""
        seleccion = True
        Dgv_DevolucionNC.ReadOnly = True
        tb_controlInicio.Enabled = False
        tb_observacion.Enabled = False
        Panel4.Enabled = False
        DateTimePicker1.Enabled = False
        ToolBar1.Enabled = True
        Dgv_NotasC.Enabled = True
        tb_controlInicio.Text = ""
        DateTimePicker1.Value = Today
        Dgv_DevolucionNC.Columns(0).Visible = False
        GroupBox4.Visible = True
        tb_imp.Clear()
        tb_imp.ReadOnly = True
        tb_controlInicio.ReadOnly = True
        tb_observacion.Clear()
        Label16.Text = "0,00"
        Label17.Text = "0,00"
        Label19.Text = "0,00"
        Label28.Text = "0,00"
        Label18.Text = "0,00"
        Label12.Text = "0,00"
        Label20.Text = "0,00"
        Label30.Text = "0,00"
        tb_montodesc.Clear()
        tb_porcentaje.Clear()
        TabControl1.SelectedIndex = 0
        Dgv_Facturas.Visible = False
        Dgv_NotasC.Visible = True
        Dgv_NotasC.ClearSelection()
        Dgv_Facturas.Enabled = True
        Dgv_DescuentoNC.Rows.Clear()
        Dgv_DevolucionNC.Rows.Clear()
        bt_aceptar.Visible = False
        Dgv_DevolucionNC.Columns(5).Width = 140
        Dgv_DevolucionNC.Columns(4).Width = 150
        bt_cancelar.Visible = False
        Dud_Buscar.Items.Clear()
        dud_buscar.Items.Add("Nro. Control Nota de Crédito")
        dud_buscar.Items.Add("Nro. Control Factura")
        dud_buscar.Items.Add("Cliente")
        dud_buscar.SelectedIndex = 0
        'DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 0, "")
        CrearWhere()
        Dgv_NotasC.ClearSelection()
        tb_buscarcodigo.Focus()

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False
        Dim resp As Integer = 0
        Dim cod As Integer = 0
        Dim entro As Boolean = False
        Dim caracteres As Boolean = False

        For cont As Integer = 0 To Dgv_DescuentoNC.RowCount - 1
            If Dgv_DescuentoNC.Rows(cont).Cells(0).Value.ToString <> "" Then
                entro = True
                cont = Dgv_DescuentoNC.RowCount
            End If
        Next

        If My.Settings.Empresa = 2 Then
            If tb_observacion.Text.Trim.Length < 20 Then
                caracteres = True
            End If
        End If

        If (rb_fisica.Checked Or rb_pendiente.Checked) Then

            If Not caracteres Then

                If tb_imp.Text.Trim = "" Then
                    tb_imp.Text = "0"
                End If

                If tb_controlInicio.Text.Trim = "" Then
                    tb_controlInicio.Text = "0"
                End If

                If Label28.Text = "0,00" Then
                    MsgBox("No se puede registrar una nota de crédito vacía", MsgBoxStyle.Critical)
                Else

                    If tb_observacion.Text = "" Then

                        If tb_imp.Text = "" Or tb_imp.Text = "0" Or tb_controlInicio.Text = "" Or tb_controlInicio.Text = "0" Then
                            tb_observacion.Text = "Pendiente por emitir"
                        End If

                    End If

                    If TabControl1.SelectedIndex = 1 And (tb_montodesc.Text = "" And tb_porcentaje.Text = "" And entro = False) And Varboton = 1 Then


                        MsgBox("Debe llenar todos los campos obligatorios", MsgBoxStyle.Critical)

                    ElseIf TabControl1.SelectedIndex = 0 Then

                        If Varboton = 1 Then

                            If Label28.Text = "" Or Label30.Text = "" Or Label16.Text = "" Then
                                If Label28.Text = "" Then
                                    Label28.Text = "0,00"

                                ElseIf Label30.Text = "" Then
                                    Label30.Text = "0,00"
                                ElseIf Label16.Text = "" Then

                                    Label16.Text = "0,00"
                                End If
                            End If



                            If Convert.ToDouble(Format(CDbl(Label28.Text) + CDbl(Label18.Text) + CDbl(Label30.Text), "#,##0.00")) <= CDbl(Label19.Text) Then
                                '' inserto la nota de credito cuando es una devolucion (0) 

                                Dim variable As Boolean = My.Settings.Nro_Imp_Visible

                                If tb_imp.Text = "0" Then
                                    tb_controlInicio.Text = "0"
                                End If

                                If tb_controlInicio.Text = "0" Then
                                    tb_imp.Text = "0"
                                End If

                                If Not DatosNotaCredito.insertar_NotaCredito(CInt(tb_imp.Text), Dgv_Facturas.SelectedRows(0).Cells(5).Value, Label28.Text, 1, tb_observacion.Text, DateTimePicker1.Value, False, CInt(tb_controlInicio.Text), variable, tb_user.Text) Then
                                    deny = False
                                    tb_imp.Focus()
                                    tb_imp.SelectAll()
                                Else

                                    Dim id As Integer

                                    id = DatosNotaCredito.identidad_nc() - 1

                                    Dim i As Integer

                                    For i = 0 To Dgv_DevolucionNC.RowCount - 1

                                        If Dgv_DevolucionNC.Rows(i).Cells(0).Value.ToString <> "" Then

                                            ' insertar en nota de NotaCredito_Producto

                                            DatosNotaCredito.insertar_NotaCreditoProducto(Dgv_DevolucionNC.Rows(i).Cells(3).Value, Dgv_DevolucionNC.Rows(i).Cells(0).Value, Dgv_DevolucionNC.Rows(i).Cells(6).Value, id, 0, Dgv_DevolucionNC.Rows(i).Cells(7).Value)

                                        End If

                                    Next


                                    If (My.Settings.Nro_Imp_Visible And (tb_imp.Text = "0" Or tb_imp.Text.Trim = "")) Or (My.Settings.Nro_Control_Editable And (tb_controlInicio.Text = "0" Or tb_controlInicio.Text.Trim = "")) Then
                                        resp = MsgBox("Nota de crédito registrada satisfactoriamente", MsgBoxStyle.Information)
                                    Else
                                        resp = MsgBox("Nota de crédito registrada satisfactoriamente, desea ajustar?", MsgBoxStyle.YesNo)
                                    End If

                                    Datos.Inserta_Actividad("Creó la nota de crédito nro. " + tb_controlInicio.Text + " de la fact. " + Dgv_Facturas.SelectedRows(0).Cells(1).Value.ToString + " del cliente (" + Dgv_Facturas.SelectedRows(0).Cells(7).Value.ToString + ") " + Dgv_Facturas.SelectedRows(0).Cells(2).Value.ToString)

                                    If resp = vbYes Then

                                        cod = CInt(tb_controlInicio.Text)
                                        deny = True

                                    Else

                                        deny = True

                                    End If

                                End If

                            Else

                                MsgBox("Los montos no concuerdan, favor revisar", MsgBoxStyle.Exclamation)
                                deny = False

                            End If



                        ElseIf Varboton = 2 Then

                            Dim variable As Boolean = My.Settings.Nro_Imp_Visible
                            Dim variable2 As Boolean = My.Settings.Nro_Control_Editable

                            If variable Then

                                If variable2 Then
                                    If antes2 = tb_controlInicio.Text And antes1 = tb_imp.Text Then
                                        cambio = False
                                    End If

                                Else

                                    If antes1 = tb_imp.Text Then
                                        cambio = False
                                    End If

                                End If

                            Else

                                If antes2 = tb_controlInicio.Text Then
                                    cambio = False
                                End If

                            End If

                            If tb_imp.Text = "0" Then
                                tb_controlInicio.Text = "0"
                            End If

                            If tb_controlInicio.Text = "0" Then
                                tb_imp.Text = "0"
                            End If

                            If DatosNotaCredito.modifica_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value, CInt(tb_imp.Text), tb_observacion.Text, DateTimePicker1.Value, CInt(tb_imp.Text), (Not antes1 = tb_imp.Text), variable, CInt(tb_controlInicio.Text), (Not antes2 = tb_controlInicio.Text), resp, chk_ajustada.Checked) Then
                                Datos.Inserta_Actividad("Modificó la nota de crédito nro. " + Dgv_NotasC.SelectedRows(0).Cells(0).Value.ToString + " de la fact. " + Dgv_NotasC.SelectedRows(0).Cells(1).Value.ToString + " del cliente (" + Dgv_NotasC.SelectedRows(0).Cells(13).Value.ToString + ") " + Dgv_NotasC.SelectedRows(0).Cells(3).Value.ToString)
                                cod = tb_controlInicio.Text
                                deny = True
                            Else
                                deny = False
                                tb_imp.Focus()
                                tb_imp.SelectAll()
                            End If


                        End If


                    Else
                        'insertar la nota de Credito cuando es un descuento (1)


                        If Varboton = 1 Then

                            If rb_porcentaje.Checked = True Then
                                If Label16.Text = "" Then
                                    Label16.Text = "0,00"
                                End If
                                If tb_porcentaje.Text = "" Then
                                    tb_porcentaje.Text = "0"
                                End If

                                Dim montoNC As New Double
                                montoNC = CDbl(Label16.Text) * (CDbl(tb_porcentaje.Text) / 100)

                                Dim variable As Boolean = My.Settings.Nro_Imp_Visible

                                If tb_imp.Text = "0" Then
                                    tb_controlInicio.Text = "0"
                                End If

                                If tb_controlInicio.Text = "0" Then
                                    tb_imp.Text = "0"
                                End If

                                If Not DatosNotaCredito.insertar_NotaCredito(CInt(tb_imp.Text), Dgv_Facturas.SelectedRows(0).Cells(5).Value, Label28.Text, 0, tb_observacion.Text, DateTimePicker1.Value, False, CInt(tb_controlInicio.Text), variable, tb_user.Text) Then
                                    deny = False
                                    tb_imp.Focus()
                                    tb_imp.SelectAll()

                                Else
                                    Datos.Inserta_Actividad("Creó la nota de crédito nro. " + tb_controlInicio.Text + " de la fact. " + Dgv_Facturas.SelectedRows(0).Cells(1).Value.ToString + " del cliente (" + Dgv_Facturas.SelectedRows(0).Cells(7).Value.ToString + ") " + Dgv_Facturas.SelectedRows(0).Cells(2).Value.ToString)
                                    MsgBox("Nota de crédito registrada satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                                    deny = True
                                End If

                            ElseIf rb_monto.Checked = True Then

                                Dim variable As Boolean = My.Settings.Nro_Imp_Visible

                                If tb_imp.Text = "0" Then
                                    tb_controlInicio.Text = "0"
                                End If

                                If tb_controlInicio.Text = "0" Then
                                    tb_imp.Text = "0"
                                End If

                                If Not DatosNotaCredito.insertar_NotaCredito(CInt(tb_imp.Text), Dgv_Facturas.SelectedRows(0).Cells(5).Value, Label28.Text, 0, tb_observacion.Text, DateTimePicker1.Value, False, CInt(tb_controlInicio.Text), variable, tb_user.Text) Then

                                    'resp = MsgBox("Desea imprimir la nota de crédito", MsgBoxStyle.YesNo)

                                    'If resp = vbYes Then
                                    '    Dim nc As New R_NotaCredito
                                    '    nc.valores_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value)
                                    '    nc.Show()
                                    '    Varboton = 4

                                    'End If

                                    deny = False
                                    tb_imp.Focus()
                                    tb_imp.SelectAll()

                                Else
                                    Datos.Inserta_Actividad("Creó la nota de crédito nro. " + tb_controlInicio.Text + " de la fact. " + Dgv_Facturas.SelectedRows(0).Cells(1).Value.ToString + " del cliente (" + Dgv_Facturas.SelectedRows(0).Cells(7).Value.ToString + ") " + Dgv_Facturas.SelectedRows(0).Cells(2).Value.ToString)
                                    MsgBox("Nota de crédito registrada satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                                    deny = True
                                End If



                            ElseIf rb_renglon.Checked = True Then

                                Dim id As Integer
                                id = DatosNotaCredito.identidad_nc() '- 1
                                Dim insertado As Boolean = False

                                Dim variable As Boolean = My.Settings.Nro_Imp_Visible

                                If tb_imp.Text = "0" Then
                                    tb_controlInicio.Text = "0"
                                End If

                                If tb_controlInicio.Text = "0" Then
                                    tb_imp.Text = "0"
                                End If

                                insertado = DatosNotaCredito.insertar_NotaCredito(CInt(tb_imp.Text), Dgv_Facturas.SelectedRows(0).Cells(5).Value, Label28.Text, 0, tb_observacion.Text, DateTimePicker1.Value, False, CInt(tb_controlInicio.Text), variable, tb_user.Text)

                                Dim cant As Integer = 0
                                For i As Integer = 0 To Dgv_DescuentoNC.RowCount - 1
                                    If Dgv_DescuentoNC.Rows(i).Cells(1).Value.ToString = "" Then
                                        cant = Dgv_DescuentoNC.Rows(i).Cells(2).Value
                                    Else
                                        cant = CInt(Dgv_DescuentoNC.Rows(i).Cells(2).Value) - CInt(Dgv_DescuentoNC.Rows(i).Cells(1).Value)
                                    End If

                                    If Dgv_DescuentoNC.Rows(i).Cells(0).Value IsNot Nothing Then
                                        If Dgv_DescuentoNC.Rows(i).Cells(0).Value.ToString <> "" Then

                                            DatosNotaCredito.insertar_NotaCreditoProducto(Dgv_DescuentoNC.Rows(i).Cells(3).Value, cant, Dgv_DescuentoNC.Rows(i).Cells(6).Value, id, 1, "")

                                        End If

                                    End If

                                Next
                                MsgBox("Nota de Crédito insertada satisfactoriamente", MsgBoxStyle.Information, "Confirmación")

                                'resp = MsgBox("Desea imprimir la nota de crédito", MsgBoxStyle.YesNo)

                                'If resp = vbYes Then
                                '    Dim nc As New R_NotaCredito
                                '    nc.valores_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value)
                                '    nc.Show()
                                '    Varboton = 4

                                'End If

                                deny = True
                            End If

                        ElseIf Varboton = 2 Then

                            Dim variable As Boolean = My.Settings.Nro_Imp_Visible
                            Dim variable2 As Boolean = My.Settings.Nro_Control_Editable

                            If variable Then

                                If variable2 Then
                                    If antes2 = tb_controlInicio.Text And antes1 = tb_imp.Text Then
                                        cambio = False
                                    End If

                                Else

                                    If antes1 = tb_imp.Text Then
                                        cambio = False
                                    End If

                                End If

                            Else

                                If antes2 = tb_controlInicio.Text Then
                                    cambio = False
                                End If

                            End If

                            If tb_imp.Text = "0" Then
                                tb_controlInicio.Text = "0"
                            End If

                            If tb_controlInicio.Text = "0" Then
                                tb_imp.Text = "0"
                            End If

                            If DatosNotaCredito.modifica_nc(Dgv_NotasC.SelectedRows(0).Cells(8).Value, CInt(tb_imp.Text), tb_observacion.Text, DateTimePicker1.Value, CInt(tb_imp.Text), (Not antes1 = tb_imp.Text), variable, CInt(tb_controlInicio.Text), (Not antes2 = tb_controlInicio.Text), resp, chk_ajustada.Checked) Then
                                cod = tb_controlInicio.Text
                                deny = True
                            Else
                                deny = False
                                tb_imp.Focus()
                                tb_imp.SelectAll()
                            End If

                        End If


                    End If

                End If

            Else

                MsgBox("Debe colocar una observación de al menos 20 caracteres", MsgBoxStyle.Exclamation, "SINPRO")

            End If


        Else

            MsgBox("Debe seleccionar un tipo de nota de crédito", MsgBoxStyle.Exclamation, "SINPRO")

        End If

        If deny Then
            rb_Parcial.Checked = True
            rb_porcentaje.Checked = True
            GroupBox1.Enabled = False
            GroupBox3.Enabled = False
            'Dgv_DescuentoNC.Enabled = False
            GroupBox4.Visible = True
            Dgv_DescuentoNC.Columns(0).ReadOnly = False
            seleccion = True
            Dgv_DevolucionNC.Columns(0).Visible = False
            Dgv_DevolucionNC.ReadOnly = True
            tb_controlInicio.Enabled = False
            tb_observacion.Enabled = False
            DateTimePicker1.Enabled = False
            ToolBar1.Enabled = True
            rb_fisica.Checked = False
            rb_pendiente.Checked = False
            Dgv_NotasC.Enabled = True
            tb_controlInicio.Text = ""
            tb_imp.Clear()
            tb_imp.ReadOnly = True
            tb_user.Clear()
            DateTimePicker1.Value = Today
            tb_observacion.Clear()
            tb_montodesc.Clear()
            tb_porcentaje.Clear()
            Panel4.Enabled = False
            tb_buscarcodigo.Clear()
            Dgv_DevolucionNC.Columns(5).Width = 140
            Dgv_DevolucionNC.Columns(4).Width = 150
            Label16.Text = "0,00"
            Label17.Text = "0,00"
            Label19.Text = "0,00"
            Label28.Text = "0,00"
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
            antes1 = ""
            antes2 = ""
            TabControl1.SelectedIndex = 0
            Dgv_Facturas.Visible = False
            Dgv_NotasC.Visible = True
            'Dgv_Facturas.Rows.Clear()
            tb_controlInicio.ReadOnly = True
            Dgv_Facturas.Enabled = True
            Dgv_DescuentoNC.Rows.Clear()
            Dgv_DevolucionNC.Rows.Clear()
            'DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 0, "")
            Sp_consultaNotasCreditoTableAdapter.Fill(Me.MelDataSet1.sp_consultaNotasCredito, 0, "")
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            Dgv_NotasC.ClearSelection()
            dud_buscar.Items.Clear()
            dud_buscar.Items.Add("Nro. Control Nota de Crédito")
            dud_buscar.Items.Add("Nro. Control Factura")
            dud_buscar.Items.Add("Cliente")
            dud_buscar.SelectedIndex = 0
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
            tb_buscarcodigo.Focus()

            If resp = vbYes Then

                Dim fr As New Frm_AjustesNotas
                fr.Show()
                fr.ToolBar1_ButtonClick(fr.bt_nuevo, New ToolBarButtonClickEventArgs(fr.bt_nuevo))
                'DatosAjustesPorNC.consulta_notaCredito(fr.Dgv_NC, 1, cod)
                fr.SpconsultaNotaCreditoNoAjustadaBindingSource.Filter = "CodigoNotaCredito = '" & cod & "'"
                fr.tb_buscarcodigo.Enabled = False
                fr.recibe(True)
                fr.tb_observacion.Focus()
                fr.Dgv_NC.Enabled = True
                fr.tb_buscarcodigo.Text = cod
                fr.tb_NC.Text = cod
                fr.Dgv_NC.Rows(0).Cells(1).Selected = True
                'fr.Dgv_Facturas_CellContentClick(fr.Dgv_NC, New DataGridViewCellEventArgs(0, 0))
                fr.Dgv_NC_CellClick(fr.Dgv_NC, New DataGridViewCellEventArgs(0, 0))
                fr.Dgv_Facturas_CellContentClick(fr.Dgv_NC, New DataGridViewCellEventArgs(0, 0))
            End If

        End If

    End Sub


    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_porcentaje.CheckedChanged
        If rb_porcentaje.Checked Then
            tb_porcentaje.Enabled = True
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
        Else
            tb_porcentaje.Enabled = False
            tb_porcentaje.Clear()
        End If
        Dgv_DescuentoNC.ClearSelection()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_monto.CheckedChanged
        If rb_monto.Checked Then
            tb_montodesc.Enabled = True
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
        Else
            tb_montodesc.Enabled = False
            tb_montodesc.Clear()
        End If
        Dgv_DescuentoNC.ClearSelection()
    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_control_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label26.Text = "      Ingrese sólo números"
        End If
    End Sub

    Private Sub tb_bultos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_porcentaje.KeyPress, tb_montodesc.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then
            e.Handled = False
            muestra_label2(sender, 1)
        Else
            e.Handled = True
            muestra_label2(sender, 0)
            Me.Label24.Text = "      Ingrese sólo números y (,)"
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label26.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label26.Visible = True
            Label26.BringToFront()
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label26.Visible = False
        End If
    End Sub

    Public Sub muestra_label2(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label24.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label24.Visible = True
            Label24.BringToFront()

        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label24.Visible = False
        End If
    End Sub

    Private Sub Dgv_Facturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_Facturas.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Dgv_Facturas.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        ElseIf e.KeyCode = Keys.Enter Then
            enter1 = True
            Dgv_Facturas_CellDoubleClick(Dgv_Facturas, New DataGridViewCellEventArgs(Dgv_Facturas.CurrentCell.ColumnIndex, Dgv_Facturas.CurrentCell.RowIndex))
        End If
    End Sub

    Private Sub Dgv_Facturas_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_Facturas.CellClick, Dgv_Facturas.KeyUp

        If Dgv_Facturas.SelectedRows.Count > 0 Then

            Dgv_DevolucionNC.Columns(0).Visible = True
            Dgv_DevolucionNC.Columns(0).ReadOnly = True
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
            'Dgv_DescuentoNC.ReadOnly = True
            Label4.Text = Dgv_Facturas.SelectedRows(0).Cells(1).Value.ToString
            DateTimePicker1.Text = Today
            'Dgv_Facturas.Enabled = False

            Label16.Text = Format(Dgv_Facturas.SelectedRows(0).Cells(3).Value, "#,##0.00")

            Label17.Text = Format(((CDbl(Dgv_Facturas.SelectedRows(0).Cells(3).Value.ToString) * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100))), "#,##0.00")
            Label19.Text = Format((CDbl(Label16.Text) + CDbl(Label17.Text)), "#,##0.00")

            DatosNotaCredito.consulta_productosnotaCredito(Dgv_DevolucionNC, Dgv_Facturas.SelectedRows(0).Cells(5).Value, 1)
            DatosNotaCredito.consulta_productosnotaCredito(Dgv_DescuentoNC, Dgv_Facturas.SelectedRows(0).Cells(5).Value, 2)
            DatosNotaCredito.OtrasNotas(Label30.Text, Dgv_Facturas.SelectedRows(0).Cells(1).Value, 0, 0)
            If Label30.Text = ",00" Then
                Label30.Text = "0,00"
            Else
                Dim MONTO As Double = CDbl(Label30.Text)
                Label30.Text = Format(MONTO, "#,##0.00")
            End If
            Dgv_DevolucionNC.Columns(5).Width = 105
            Dgv_DevolucionNC.Columns(4).Width = 140
            CorregirCeros(Dgv_DescuentoNC, 1)
            CorregirCeros(Dgv_DevolucionNC, 1)
            Dgv_DevolucionNC.ClearSelection()
            Dgv_Facturas.Focus()
            Dgv_DescuentoNC.ClearSelection()

        End If

    End Sub

    Private Sub Dgv_Facturas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Facturas.CellDoubleClick

        rb_pendiente.Checked = False
        rb_fisica.Checked = False
        tb_controlInicio.Enabled = True
        tb_observacion.Enabled = True
        DateTimePicker1.Enabled = True
        TabControl1.Enabled = True
        GroupBox1.Enabled = True
        GroupBox3.Enabled = True
        Dgv_DevolucionNC.Columns(0).ReadOnly = False
        Dgv_DevolucionNC.Columns(7).ReadOnly = False
        Dgv_DevolucionNC.ClearSelection()
        Dgv_Facturas.Enabled = False
        bt_aceptar.Visible = True
        bt_cancelar.Visible = True
        'tb_imp.ReadOnly = False
        'tb_imp.Focus()
        Panel4.Enabled = True

        'tb_imp.SelectAll()
        Dgv_DescuentoNC.ClearSelection()

        tb_observacion.Focus()
        tb_observacion.Select()

    End Sub

    Private Sub Dgv_DevolucionNC_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_DevolucionNC.CellClick

        If seleccion = False Then

            If e.ColumnIndex = 0 Or e.ColumnIndex <> 7 Then
                If Dgv_DevolucionNC.CurrentRow.Cells(0).Visible Then
                    Dgv_DevolucionNC.CurrentRow.Cells(0).Selected = True
                End If
            Else
                Dgv_DevolucionNC.CurrentRow.Cells(7).Selected = True
            End If

        End If

    End Sub



    Private Sub Dgv_DevolucionNC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_DevolucionNC.CellEndEdit

        Try

            If e.ColumnIndex <> 0 Then
                bajar = True
            Else
                bajar = False
            End If


            If Dgv_DevolucionNC.CurrentCell.ColumnIndex = 0 Then

                If Dgv_DevolucionNC.CurrentRow.Cells(0).Value = "" Or Dgv_DevolucionNC.CurrentRow.Cells(0).Value Is Nothing Then

                    Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""

                Else

                    If CInt(Dgv_DevolucionNC.CurrentCell.Value) = 0 Then

                        Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""

                    Else

                        If Dgv_DevolucionNC.CurrentRow.Cells(0).Value <> "" And CStr(Dgv_DevolucionNC.CurrentRow.Cells(1).Value) <> "" Then

                            If Not CInt(Dgv_DevolucionNC.CurrentRow.Cells(0).Value) < 0 Then

                                If Dgv_DevolucionNC.CurrentRow.Cells(0).Value + Dgv_DevolucionNC.CurrentRow.Cells(1).Value > Dgv_DevolucionNC.CurrentRow.Cells(2).Value Then

                                    MsgBox("No puede devolver una cantidad mayor a la facturada", MsgBoxStyle.Critical)
                                    Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""
                                    bajar = False

                                End If

                            Else

                                MsgBox("No puede introducir cantidades negativas", MsgBoxStyle.Critical)
                                Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""


                            End If

                        ElseIf Dgv_DevolucionNC.CurrentRow.Cells(0).Value <> "" And CStr(Dgv_DevolucionNC.CurrentRow.Cells(1).Value) = "" Then

                            If Not CInt(Dgv_DevolucionNC.CurrentRow.Cells(0).Value) < 0 Then

                                If Dgv_DevolucionNC.CurrentRow.Cells(0).Value > Dgv_DevolucionNC.CurrentRow.Cells(2).Value Then

                                    MsgBox("No puede devolver una cantidad mayor a la facturada", MsgBoxStyle.Critical)
                                    Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""
                                    bajar = False

                                End If

                            Else

                                MsgBox("No puede introducir cantidades negativas", MsgBoxStyle.Critical)
                                Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""

                            End If

                        End If

                    End If


                End If

                calcularMontoNC()
            End If



        Catch ex As Exception

            Dgv_DevolucionNC.CurrentRow.Cells(0).Value = ""

        End Try

    End Sub



    Private Sub rb_Total_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Total.CheckedChanged

        If rb_Total.Checked = True Then

            Dim i As Integer

            For i = 0 To Dgv_DevolucionNC.RowCount - 1

                If Not Dgv_DevolucionNC.Rows(i).Cells(1).Value Is Nothing Then

                    If Dgv_DevolucionNC.Rows(i).Cells(1).Value.ToString.Trim <> "" Then

                        Dgv_DevolucionNC.Rows(i).Cells(0).Value = Dgv_DevolucionNC.Rows(i).Cells(2).Value - Dgv_DevolucionNC.Rows(i).Cells(1).Value

                    Else

                        Dgv_DevolucionNC.Rows(i).Cells(0).Value = Dgv_DevolucionNC.Rows(i).Cells(2).Value

                    End If

                Else

                    Dgv_DevolucionNC.Rows(i).Cells(0).Value = Dgv_DevolucionNC.Rows(i).Cells(2).Value

                End If

            Next

            calcularMontoNC()
            Label20.Text = Format(CDbl(Label19.Text) - CDbl(Label30.Text) - CDbl(Label12.Text), "#,##0.00")


        End If


    End Sub

    Public Sub calcularMontoNC()

        Dim i As Integer

        Dim suma As Double = 0.0

        For i = 0 To Dgv_DevolucionNC.RowCount - 1

            If Dgv_DevolucionNC.Rows(i).Cells(0).Value.ToString <> "" Then

                If Dgv_DevolucionNC.Rows(i).Cells(0).Value > 0 Then

                    suma = suma + ((CDbl(Dgv_DevolucionNC.Rows(i).Cells(0).Value) * (CDbl(Dgv_DevolucionNC.Rows(i).Cells(6).Value))))

                End If

            End If

        Next

        Label28.Text = Format(suma, "#,##0.00")
        Try
            If Dgv_Facturas.SelectedRows(0).Cells(4).Value.ToString <> "" Then
                Label18.Text = Format(suma * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100), "#,##0.00")
                Label12.Text = Format(suma + (suma * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100)), "#,##0.00")
            Else
                Label18.Text = "0,00"
                Label12.Text = "0,00"
            End If

            Label20.Text = Format(CDbl(Label19.Text) - (CDbl(Label12.Text) + CDbl(Label30.Text)), "#,##0.00")
        Catch
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
        End Try

    End Sub

    Private Sub rb_Parcial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Parcial.CheckedChanged

        If rb_Parcial.Checked = True Then

            Dim i As Integer

            For i = 0 To Dgv_DevolucionNC.RowCount - 1

                Dgv_DevolucionNC.Rows(i).Cells(0).Value = ""
            Next

            Label28.Text = "0,00"
            Label12.Text = "0,00"
            Label18.Text = "0,00"
            If Label30.Text = ",00" Then
                Label30.Text = "0,00"
            End If
            Label20.Text = Format(CDbl(Label19.Text) - CDbl(Label30.Text), "#,##0.00")

        End If

    End Sub

    Public Sub Dgv_NotasC_CellClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Dgv_NotasC.CellClick, Dgv_NotasC.KeyUp, Dgv_NotasC.KeyDown

        Try

            Label4.Text = Dgv_NotasC.SelectedRows(0).Cells(1).Value

            If Dgv_NotasC.SelectedRows(0).Cells(0).Value = 0 Then
                rb_pendiente.Checked = True
            Else
                rb_fisica.Checked = True
            End If

            tb_controlInicio.Text = Dgv_NotasC.SelectedRows(0).Cells(0).Value
            DateTimePicker1.Value = Dgv_NotasC.SelectedRows(0).Cells(2).Value
            Label28.Text = Dgv_NotasC.SelectedRows(0).Cells(4).Value

            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                tb_user.Text = Dgv_NotasC.SelectedRows(0).Cells(12).Value
            End If

            tb_observacion.Text = Dgv_NotasC.SelectedRows(0).Cells(5).Value
            DatosNotaCredito.consulta_NroImpNC(Dgv_NotasC.SelectedRows(0).Cells(8).Value, tb_imp.Text)
            DatosNotaCredito.consulta_productosnotaCredito(Dgv_DevolucionNC, Dgv_NotasC.SelectedRows(0).Cells(8).Value, 6)
            DatosNotaCredito.OtrasNotas(Label30.Text, Dgv_NotasC.SelectedRows(0).Cells(1).Value, Dgv_NotasC.SelectedRows(0).Cells(0).Value, 1)
            Dim Otras As Double = CDbl(Label30.Text)
            Label16.Text = Format(Dgv_NotasC.SelectedRows(0).Cells(9).Value, "#,##0.00")
            Label17.Text = Format(Dgv_NotasC.SelectedRows(0).Cells(9).Value * (Dgv_NotasC.SelectedRows(0).Cells(6).Value / 100), "#,##0.00")
            Label19.Text = Format(CDbl(Label16.Text) + CDbl(Label17.Text), "#,##0.00")
            Label30.Text = Format(Otras, "#,##0.00")
            Dgv_DevolucionNC.ClearSelection()
            Label18.Text = Format((CDbl(Dgv_NotasC.SelectedRows(0).Cells(6).Value) / 100) * (CDbl(Label28.Text)), "#,##0.00")
            Otras = CDbl(Label18.Text)
            Label18.Text = Format(Otras, "#,##0.00")
            Label12.Text = Format(CDbl(Label28.Text) + CDbl(Label18.Text), "#,##0.00")
            Otras = CDbl(Label12.Text)
            Label12.Text = Format(Otras, "#,##0.00")
            Otras = CDbl(Label28.Text)
            Label28.Text = Format(Otras, "#,##0.00")
            tb_montodesc.Text = Format(Dgv_NotasC.SelectedRows(0).Cells(4).Value, "#,##0.00")
            Label20.Text = Format(CDbl(Label19.Text) - (CDbl(Label12.Text) + CDbl(Label30.Text)), "#,##0.00")

            If Dgv_NotasC.SelectedRows(0).Cells(7).Value = 0 Then

                TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
                DatosNotaCredito.consulta_productosnotaCredito(Dgv_DescuentoNC, Dgv_NotasC.SelectedRows(0).Cells(0).Value, 5)
                CorregirCeros(Dgv_DescuentoNC, 1)

            Else

                TabControl1.SelectedTab = TabControl1.TabPages.Item(0)

            End If

            Dim esta As Boolean = False
            If Dgv_DescuentoNC.RowCount > 0 Then

                For cont As Integer = 0 To Dgv_DescuentoNC.RowCount - 1
                    If CDbl(Dgv_DescuentoNC.Rows(cont).Cells(6).Value) <> CDbl(Dgv_DescuentoNC.Rows(cont).Cells(7).Value) Then

                        Dgv_DescuentoNC.Rows(cont).Cells(0).Value = Format(((CDbl(Dgv_DescuentoNC.Rows(cont).Cells(7).Value) - CDbl(Dgv_DescuentoNC.Rows(cont).Cells(6).Value)) * 100) / CDbl(Dgv_DescuentoNC.Rows(cont).Cells(7).Value), "#,##0.00")
                        esta = True

                    Else

                        Dgv_DescuentoNC.Rows(cont).Cells(0).Value = ""

                    End If

                Next

            End If

            If esta = True Then
                rb_renglon.Checked = True
            Else
                rb_porcentaje.Checked = True
            End If

            tb_porcentaje.Text = Format((CDbl(Dgv_NotasC.SelectedRows(0).Cells(4).Value) / (CDbl(Dgv_NotasC.SelectedRows(0).Cells(9).Value)) * 100), "#,##0.00")

            Dim hay As Boolean = False


            DatosNotaCredito.consulta_Ajustes(2, Dgv_NotasC.SelectedRows(0).Cells(8).Value.ToString, hay)
            If hay = True Then
                chk_ajustada.Checked = True
            Else
                chk_ajustada.Checked = False
            End If

        Catch ex As Exception

        Finally

            Dgv_DescuentoNC.Columns(0).ReadOnly = True
            Dgv_NotasC.Focus()
            Dgv_DescuentoNC.ClearSelection()

        End Try

    End Sub

    Public Function Monto(ByVal dgv As DataGridView, ByVal col As Integer) As Double

        Dim mont As New Double

        Dim i As Integer

        For i = 0 To dgv.RowCount - 1

            mont = mont + dgv.Rows(i).Cells(col).Value

        Next

        Return mont

    End Function

    Private Sub tb_porcentaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_porcentaje.TextChanged

        If Not Dgv_NotasC.Visible = True Then
            If tb_porcentaje.Text <> "" Then

                calcularMontoNC2(CDbl(tb_porcentaje.Text), 2)

                If Not CDbl(tb_porcentaje.Text) > 100.0 Or CDbl(tb_porcentaje.Text) < 0.0 Then

                    If CDbl((tb_porcentaje.Text) / 100) * CDbl(Label19.Text) + CDbl(Label30.Text) > CDbl(Label19.Text) Then

                        MsgBox("No puede realizar un descuento por más del monto facturado", MsgBoxStyle.Critical)
                        tb_porcentaje.Clear()

                    Else

                        calcularMontoNC2(CDbl(tb_porcentaje.Text), 2)

                    End If


                Else

                    MsgBox("El porcentaje introducido es inválido", MsgBoxStyle.Critical)
                    tb_porcentaje.Clear()

                End If



            Else

                Label28.Text = "0,00"
                Label18.Text = "0,00"
                Label12.Text = "0,00"
                Label20.Text = Format(CDbl(Label19.Text) - CDbl(Label30.Text), "#,##0.00")

            End If

        End If


    End Sub

    Private Sub tb_montodesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_montodesc.TextChanged

        If Not Dgv_NotasC.Visible = True Then
            If tb_montodesc.Text <> "" Then

                calcularMontoNC2(CDbl(tb_montodesc.Text), 1)

                If (CDbl(tb_montodesc.Text) + CDbl(Label18.Text)) + CDbl(Label30.Text) > CDbl(Label19.Text) Then

                    MsgBox("No puede realizar un descuento por más del monto facturado", MsgBoxStyle.Critical)
                    tb_montodesc.Clear()

                Else

                    calcularMontoNC2(CDbl(tb_montodesc.Text), 1)

                End If

            Else
                Label28.Text = "0,00"
                Label18.Text = "0,00"
                Label12.Text = "0,00"
                Label20.Text = Format(CDbl(Label19.Text) - CDbl(Label30.Text), "#,##0.00")
            End If


        End If

    End Sub


    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        'If Dgv_NotasC.Visible Then

        '    If dud_buscar.Text = "Nro. Control Nota de Crédito" Then

        '        DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 1, tb_buscarcodigo.Text)
        '        Dgv_NotasC.ClearSelection()

        '    ElseIf dud_buscar.Text = "Nro. Control Factura" Then

        '        DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 2, tb_buscarcodigo.Text)
        '        Dgv_NotasC.ClearSelection()

        '    ElseIf dud_buscar.Text = "Cliente" Then

        '        DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 3, tb_buscarcodigo.Text)
        '        Dgv_NotasC.ClearSelection()

        '    End If

        'Else

        '    If dud_buscar.Text = "Nro. Control Factura" Then

        '        'DatosNotaCredito.consulta_FactVentas(Dgv_Facturas, 1, tb_buscarcodigo.Text)
        '        'Dgv_Facturas.ClearSelection()
        '        CrearWhere()

        '    ElseIf dud_buscar.Text = "Cliente" Then

        '        'DatosNotaCredito.consulta_FactVentas(Dgv_Facturas, 2, tb_buscarcodigo.Text)
        '        'Dgv_Facturas.ClearSelection()
        '        CrearWhere()

        '    End If

        'End If

        'If RadioButton3.Checked Then
        '    eliminarPendientes(False)
        'End If
        tb_user.Clear()
        CrearWhere()

    End Sub

    Public Sub CorregirCeros(ByVal DGV As DataGridView, ByVal col As Integer)

        Dim cont As Integer = 0

        For cont = 0 To DGV.RowCount - 1

            If DGV.Rows(cont).Cells(col).Value = 0 Then

                DGV.Rows(cont).Cells(col).Value = ""

            End If

        Next

    End Sub


    Private Sub Label30_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label30.TextChanged
        If Label30.Text = ",00" Then
            Label30.Text = "0,00"
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If Dgv_NotasC.Enabled = False And Dgv_NotasC.Visible = False Then
            Label28.Text = "0,00"
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
            tb_montodesc.Clear()
            tb_porcentaje.Clear()
            rb_porcentaje.Checked = True
            rb_Parcial.Checked = True
            Dgv_DevolucionNC.ClearSelection()
            Dgv_DescuentoNC.ClearSelection()
            Dgv_DescuentoNC.Columns(0).ReadOnly = True
        End If

    End Sub

    Public Sub calcularMontoNC2(ByVal suma As Double, ByVal Tipo As Integer)

        If Tipo = 1 Then

            If Dgv_Facturas.SelectedRows.Count = 1 Then

                Label28.Text = Format(suma, "#,##0.00")
                Label18.Text = Format(suma * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100), "#,##0.00")
                Label12.Text = Format(CDbl(Label28.Text) + (CDbl(Label18.Text)), "#,##0.00")
                Label20.Text = Format(CDbl(Label19.Text) - (CDbl(Label12.Text) + CDbl(Label30.Text)), "#,##0.00")

            End If

        ElseIf Tipo = 2 Then

            If Dgv_Facturas.SelectedRows.Count = 1 Then

                Dim iva As String = ""
                DatosConfiguracion.tb_iva(iva)

                Dim ivap As Double = 1 + (Double.Parse(iva) / 100)

                Label28.Text = Format(((suma / 100) * ((CDbl(Label19.Text) - CDbl(Label30.Text)) / ivap)), "#,##0.00")
                Label18.Text = Format(CDbl(Label28.Text) * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100), "#,##0.00")
                Label12.Text = Format(CDbl(Label28.Text) + (CDbl(Label18.Text)), "#,##0.00")
                Label20.Text = Format(CDbl(Label19.Text) - (CDbl(Label12.Text) + CDbl(Label30.Text)), "#,##0.00")

            End If

        End If

    End Sub


    Private Sub Label20_Text(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.TextChanged

        If Label20.Text = ",00" Then
            Label20.Text = "0,00"
        End If

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CellKeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = False
    End Sub

    Private Sub CellKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv_DevolucionNC.EditingControlShowing
        Dim txt As TextBox = TryCast(e.Control, TextBox)

        If Me.Dgv_DevolucionNC.CurrentCell.ColumnIndex = 0 Then

            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
                RemoveHandler txt.KeyDown, AddressOf CellKeyDown
                AddHandler txt.KeyDown, AddressOf CellKeyDown
            End If

        Else

            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
                AddHandler txt.KeyPress, AddressOf CellKeyPress3
            End If

        End If
    End Sub

    Private Sub Label18_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label18.TextChanged

        If Label18.Text = ",00" Then
            Label18.Text = "0,00"
        End If

    End Sub


    Private Sub Label28_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label28.TextChanged

        If Label28.Text = ",00" Then
            Label28.Text = "0,00"
        End If

    End Sub


    Private Sub Label12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.TextChanged

        If Label12.Text = ",00" Then
            Label12.Text = "0,00"
        End If

    End Sub

    Private Sub Dgv_DevolucionNC_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_DevolucionNC.SelectionChanged

        Try

            If Dgv_DevolucionNC.Rows(0).Cells(0).ReadOnly = False Then

                If bajar = False Then

                    If Dgv_DevolucionNC.CurrentRow.Index = 0 Then

                        If Dgv_DevolucionNC.CurrentCell.ColumnIndex = 0 Then
                            Dgv_DevolucionNC.Rows(0).Cells(7).Selected = True
                        Else
                            Dgv_DevolucionNC.Rows(0).Cells(0).Selected = True
                        End If

                        Dgv_DevolucionNC.BeginEdit(True)

                    Else

                        If Dgv_DevolucionNC.CurrentCell.ColumnIndex = 0 Then
                            Dgv_DevolucionNC.Rows(Dgv_DevolucionNC.CurrentRow.Index - 1).Cells(7).Selected = True
                        Else
                            Dgv_DevolucionNC.Rows(Dgv_DevolucionNC.CurrentRow.Index - 1).Cells(0).Selected = True
                        End If

                        Dgv_DevolucionNC.BeginEdit(True)

                    End If

                Else

                    If Dgv_DevolucionNC.CurrentCell.ColumnIndex = 0 Then
                        Dgv_DevolucionNC.CurrentRow.Cells(7).Selected = True
                    Else
                        Dgv_DevolucionNC.CurrentRow.Cells(0).Selected = True
                    End If

                    Dgv_DevolucionNC.BeginEdit(True)

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then
            If Dgv_NotasC.Visible Then
                If Dgv_NotasC.Rows.Count > 0 Then
                    Dgv_NotasC.Rows(0).Cells(0).Selected = True
                    Dgv_NotasC.Focus()
                End If
            ElseIf Dgv_Facturas.Visible Then
                If Dgv_Facturas.Rows.Count > 0 Then
                    Dgv_Facturas.Rows(0).Cells(0).Selected = True
                    Dgv_Facturas.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub dud_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dud_buscar.SelectedIndexChanged
        tb_buscarcodigo.Clear()
        tb_buscarcodigo.Focus()
    End Sub

    Private Sub Dgv_DescuentoNC_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_DescuentoNC.CellClick
        Try
            Me.Dgv_DescuentoNC.CurrentCell = Me.Dgv_DescuentoNC(0, e.RowIndex)
            Me.Dgv_DescuentoNC.BeginEdit(True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CellKeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = ","c) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv_DescuentoNC.EditingControlShowing
        If Me.Dgv_DescuentoNC.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress2
                AddHandler txt.KeyPress, AddressOf CellKeyPress2
            End If
        End If
    End Sub

    Private Sub Dgv_DescuentoNC_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_DescuentoNC.CellEndEdit
        Try
            bajar2 = True
            If Dgv_DescuentoNC.CurrentCell.Value IsNot Nothing Then
                If Dgv_DescuentoNC.CurrentCell.Value <> "" Then


                    Convert.ToDouble(Dgv_DescuentoNC.CurrentCell.Value)

                    If CDbl(Dgv_DescuentoNC.CurrentCell.Value) < 0 Or CDbl(Dgv_DescuentoNC.CurrentCell.Value) > 100 Then

                        MsgBox("El valor no puede ser menor al 0 ni mayor al 100%", MsgBoxStyle.Critical, "Error!")
                        bajar2 = False
                        Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(0).Value = ""

                    Else

                        Dgv_DescuentoNC.CurrentCell.Value = Format(CDbl(Dgv_DescuentoNC.CurrentCell.Value), "#,##0.00")
                        If Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
                            Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(6).Value = (CDbl(Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(7).Value) - (CDbl(Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(7).Value) * (CDbl(Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(0).Value) / 100)))
                        End If
                        calcularTotalNC()

                    End If
                End If

            End If

        Catch ex As Exception

            MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Critical, "Error!")
            bajar2 = False
            Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index).Cells(0).Value = ""
        End Try
    End Sub

    Private Sub Dgv_DescuentoNC_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_DescuentoNC.SelectionChanged
        Try

            If Dgv_DescuentoNC.SelectedRows.Count > 0 Then

                If bajar2 = False Then
                    If Dgv_DescuentoNC.CurrentRow.Index = 0 Then

                        Dgv_DescuentoNC.Rows(0).Cells(0).Selected = True
                        Dgv_DescuentoNC.BeginEdit(True)

                    Else

                        Dgv_DescuentoNC.Focus()
                        Dgv_DescuentoNC.Rows(Dgv_DescuentoNC.CurrentRow.Index - 1).Cells(0).Selected = True
                        Dgv_DescuentoNC.BeginEdit(True)

                    End If
                Else

                    Dgv_DescuentoNC.BeginEdit(True)

                End If

            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub Dgv_Facturas_RowsRemoved(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_Facturas.RowsRemoved, Dgv_Facturas.RowsAdded, Dgv_Facturas.VisibleChanged

        If Dgv_Facturas.Visible Then

            Label2.Text = Dgv_Facturas.RowCount

        End If

    End Sub


    Private Sub Dgv_NotasC_RowsRemoved(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_NotasC.RowsRemoved, Dgv_NotasC.RowsAdded, Dgv_NotasC.VisibleChanged

        If Dgv_NotasC.Visible Then

            Label2.Text = Dgv_NotasC.RowCount

        End If

    End Sub

    Public Sub calcularTotalNC()

        Try
            If Dgv_Facturas.Visible = True Then


                Dim total As Double = 0

                For cont As Integer = 0 To Dgv_DescuentoNC.RowCount - 1

                    If Dgv_DescuentoNC.Rows(cont).Cells(0).Value.ToString <> "" Then

                        Dim a As Double = CDbl(Dgv_DescuentoNC.Rows(cont).Cells(0).Value)

                        If Dgv_DescuentoNC.Rows(cont).Cells(1).Value.ToString <> "" Then

                            total = total + (((CInt(Dgv_DescuentoNC.Rows(cont).Cells(2).Value) - CInt(Dgv_DescuentoNC.Rows(cont).Cells(1).Value)) * CDbl(Dgv_DescuentoNC.Rows(cont).Cells(7).Value)) - ((CInt(Dgv_DescuentoNC.Rows(cont).Cells(2).Value) - CInt(Dgv_DescuentoNC.Rows(cont).Cells(1).Value)) * CDbl(Dgv_DescuentoNC.Rows(cont).Cells(6).EditedFormattedValue)))

                        Else

                            total = total + (((CInt(Dgv_DescuentoNC.Rows(cont).Cells(2).Value) * CDbl(Dgv_DescuentoNC.Rows(cont).Cells(7).Value)) - ((CInt(Dgv_DescuentoNC.Rows(cont).Cells(2).Value)) * CDbl(Dgv_DescuentoNC.Rows(cont).Cells(6).EditedFormattedValue))))

                        End If

                    End If

                Next

                Label28.Text = Format(total, "#,##0.00")

                If Dgv_Facturas.SelectedRows(0).Cells(4).Value.ToString <> "" Then
                    Label18.Text = Format(total * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100), "#,##0.00")
                    Label12.Text = Format(total + (total * (CDbl(Dgv_Facturas.SelectedRows(0).Cells(4).Value) / 100)), "#,##0.00")
                Else
                    Label18.Text = "0,00"
                    Label12.Text = "0,00"
                End If

                Label20.Text = Format(CDbl(Label19.Text) - (CDbl(Label12.Text) + CDbl(Label30.Text)), "#,##0.00")
            End If

        Catch ex As Exception
            Label18.Text = "0,00"
            Label12.Text = "0,00"
        End Try

    End Sub

    Private Sub rb_renglon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_renglon.CheckedChanged
        If rb_renglon.Checked = True Then
            Dgv_DescuentoNC.Columns(0).ReadOnly = False
            Dgv_DescuentoNC_CellClick(Dgv_DescuentoNC, New DataGridViewCellEventArgs(0, 0))
            Dgv_DescuentoNC.Columns(7).Visible = True
        Else
            Dgv_DescuentoNC.Columns(7).Visible = False
        End If
    End Sub

    Private Sub Dgv_Facturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Facturas.SelectionChanged
        If enter1 = True Then
            If Dgv_Facturas.Rows.Count > 0 Then
                If Dgv_Facturas.CurrentCell.RowIndex > 0 Then
                    Dgv_Facturas.Rows(Dgv_Facturas.CurrentCell.RowIndex - 1).Selected = True
                Else
                    Dgv_Facturas.Rows(0).Cells(0).Selected = True
                End If
                enter1 = False
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        'If RadioButton3.Checked Then
        '    eliminarPendientes(False)
        'Else
        '    If tb_buscarcodigo.Text <> "" Then
        '        tb_buscarcodigo_TextChanged(tb_buscarcodigo, New EventArgs)
        '    Else
        '        DatosNotaCredito.consulta_notaCredito(Dgv_NotasC, 0, "")
        '    End If
        'End If
        'Dgv_NotasC.ClearSelection()
        CrearWhere()
    End Sub

    Public Sub eliminarPendientes(ByVal tipo As Boolean)
        Dim cont As Integer = 0

        If tipo Then

            While cont <= Dgv_NotasC.RowCount - 1

                If CInt(Dgv_NotasC.Rows(cont).Cells(0).Value) = 0 Then

                    Dgv_NotasC.Rows.RemoveAt(cont)
                    cont = cont - 1

                End If

                cont = cont + 1

            End While

        Else


            While cont <= Dgv_NotasC.RowCount - 1

                If CInt(Dgv_NotasC.Rows(cont).Cells(0).Value) <> 0 Then

                    Dgv_NotasC.Rows.RemoveAt(cont)
                    cont = cont - 1

                End If

                cont = cont + 1

            End While

        End If
    End Sub

    Public Sub CrearWhere()

        tb_user.Clear()

        Dim where As String = ""
        Dim y As String = ""

        If Dgv_Facturas.Visible Then

            If tb_buscarcodigo.Text <> "" Then

                If dud_buscar.SelectedIndex = 0 Then

                    where = where + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf dud_buscar.SelectedIndex = 1 Then

                    where = where + "Control LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                End If

            End If

            Me.SpconsultaFactVentasBindingSource.Filter = where
            Dgv_Facturas.ClearSelection()

        Else

            If tb_buscarcodigo.Text <> "" Then

                If dud_buscar.SelectedIndex = 0 Then

                    where = where + "Control2 LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf dud_buscar.SelectedIndex = 1 Then

                    where = where + "Control LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf dud_buscar.SelectedIndex = 2 Then

                    where = where + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                End If

            End If

            If RadioButton3.Checked Then
                where = where + y + "NroControl = 0"
            End If

            Me.SpconsultaNotasCreditoBindingSource.Filter = where

            seleccion = True
            TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
            Dgv_DevolucionNC.Rows.Clear()
            seleccion = False
            tb_controlInicio.Text = ""
            tb_imp.Text = ""
            DateTimePicker1.Value = Today
            tb_observacion.Clear()
            Label16.Text = "0,00"
            Label17.Text = "0,00"
            Label19.Text = "0,00"
            Label28.Text = "0,00"
            Label18.Text = "0,00"
            Label12.Text = "0,00"
            Label20.Text = "0,00"
            Label30.Text = "0,00"
            Dgv_NotasC.ClearSelection()
            tb_montodesc.Clear()
            tb_porcentaje.Clear()
            Label4.Text = "##"

            Dgv_NotasC.ClearSelection()

        End If

    End Sub

    Private Sub tb_imp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_imp.GotFocus
        If Varboton = 2 And cambio = False Then
            antes1 = tb_imp.Text
        End If
    End Sub


    Private Sub tb_imp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_imp.TextChanged
        If My.Settings.Nro_Imp_Visible Then

            If tb_imp.ReadOnly = False Then
                cambio = True
            Else
                cambio = False
            End If

        End If
    End Sub

    Private Sub tb_controlInicio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_controlInicio.GotFocus
        If Varboton = 2 And cambio = False Then
            antes2 = tb_controlInicio.Text
        End If
    End Sub

    Private Sub tb_controlInicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_controlInicio.TextChanged

        If My.Settings.Nro_Control_Editable Then

            If tb_controlInicio.ReadOnly = False Then
                cambio = True
            Else
                cambio = False
            End If

        End If

    End Sub

    Private Sub rb_fisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fisica.CheckedChanged

        If Varboton = 1 Or Varboton = 2 Then

            If rb_fisica.Checked Then

                If tb_controlInicio.Text = "0" Or tb_controlInicio.Text.Trim = "" Then
                    DatosNotaCredito.consulta_ProximoControlNC(tb_controlInicio.Text)
                End If

                If tb_imp.Text = "0" Or tb_imp.Text.Trim = "" Then
                    DatosFacturas.consulta_nroImp(tb_imp.Text)
                End If

                If My.Settings.Nro_Control_Editable Then
                    tb_controlInicio.ReadOnly = False
                End If

                tb_imp.ReadOnly = False

            End If

            DateTimePicker1.Value = Today

        End If

    End Sub

    Private Sub rb_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pendiente.CheckedChanged
        If Varboton = 1 Or Varboton = 2 Then
            If rb_pendiente.Checked Then
                tb_controlInicio.Text = "0"
                tb_imp.Text = "0"
                tb_controlInicio.ReadOnly = True
                tb_imp.ReadOnly = True
            End If
            DateTimePicker1.Value = Today
        End If
    End Sub

End Class