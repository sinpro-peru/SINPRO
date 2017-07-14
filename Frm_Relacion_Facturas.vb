Public Class Frm_Relacion_Facturas

    Dim boton As Integer = 0
    Dim aca As Boolean = False
    Dim elim As New Collection
    Dim sw As Boolean = False

    Private Sub Form39_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        lb_asociacion.Location = New System.Drawing.Point(345, 156)
        lb_asociacion.Size = New System.Drawing.Size(671, 511)
        DGV_relacion.Size = New System.Drawing.Size(662, 479)
        Dd_relacion.Items.Add("Nro. Relación")
        Dd_relacion.Items.Add("Nro. Documento")
        Dd_relacion.Items.Add("Cliente")
        Dd_relacion.SelectedIndex = 0
        lb_asociacion.BringToFront()
        Label8.BringToFront()
        Datos.ConsultaEnviosFac(Dgv_relaciones, 0, "")
        Datos.consulta_vendedores(Me.tb_vendedor)

        If My.Settings.Empresa = 1 Then
            Me.Text = "BRWME: " & Me.Text
        ElseIf My.Settings.Empresa = 2 Then
            Me.Text = "AGSA: " & Me.Text
        ElseIf My.Settings.Empresa = 3 Then
            Me.Text = "Mil 26: " & Me.Text
        End If

    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click
        Dim row As DataGridViewRow
        For Each row In Me.DGV_Docs.SelectedRows
            Me.DGV_relacion.Rows.Add(ObtenerValoresFila(row))
            Me.DGV_Docs.Rows.Remove(row)
            Me.DGV_relacion.ClearSelection()
        Next
    End Sub

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        Dim Contenido(Me.DGV_Docs.ColumnCount) As String

        If rb_fact.Checked Then
            Contenido(0) = "Fact."
        ElseIf rb_NC.Checked Then
            Contenido(0) = "N.C."
        Else
            Contenido(0) = "C.D."
        End If

        For Ndx As Integer = 0 To (Contenido.Length - 2)
            Contenido(Ndx + 1) = fila.Cells(Ndx).Value
        Next
        Contenido(5) = Format(CDbl(Contenido(5)), "#,##0.00")
        Return Contenido
    End Function


    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        ToolBar1.Enabled = True
        lb_asociacion.Location = New System.Drawing.Point(345, 156)
        lb_asociacion.Size = New System.Drawing.Size(671, 511)
        DGV_relacion.Size = New System.Drawing.Size(662, 479)
        lb_asociacion.BringToFront()
        Label8.BringToFront()
        boton = 0
        For cont As Integer = 1 To elim.Count
            Dim tipo As Integer = 5
            If elim(cont).ToString.Split("/")(1) = "Fact." Then
                tipo = 0
            ElseIf elim(cont).ToString.Split("/")(1) = "N.C." Then
                tipo = 1
            Else
                tipo = 2
            End If

            Datos.ModificaEntrega(CInt(elim(cont).ToString.Split("/")(0)), True, tipo)

        Next
        elim.Clear()
        DGV_Docs.Rows.Clear()
        DGV_relacion.Rows.Clear()
        sw = False
        tb_vendedor.Text = "-Seleccione un Vendedor-"
        bt_aceptar.Visible = False
        chk_confirmada.Visible = True
        dtp1.Enabled = False
        tb_guia.ReadOnly = True
        tb_enviada.Clear()
        dtp1.Value = Today
        tb_guia.Clear()
        bt_cancelar.Visible = False
        tb_codigo.Clear()
        bt_agregar.Visible = False
        tb_aprobada.Clear()
        tb_aprobada.ReadOnly = True
        tb_enviada.Clear()
        tb_elaborada.Clear()
        tb_elaborada.ReadOnly = True
        tb_observ.Clear()
        tb_observ.ReadOnly = True
        Dgv_relaciones.Enabled = True
        DGV_relacion.ReadOnly = True
        DGV_relacion.AllowUserToDeleteRows = False
        Dgv_relaciones.ClearSelection()
        tb_enviada.ReadOnly = True
        tb_aprobada.ReadOnly = True
        tb_vendedor.Enabled = False

    End Sub


    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False

        If tb_elaborada.Text <> "" And tb_enviada.Text <> "" And tb_vendedor.SelectedIndex <> -1 And tb_aprobada.Text <> "" Then

            If DGV_relacion.RowCount > 0 Then

                If boton = 1 Then

                    Dim r_rfact As New R_RelacionFacturas
                    Dim cont As Integer = 0

                    Datos.InsertaEnvioFac(Me.tb_vendedor.SelectedItem.col2, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, tb_enviada.Text, dtp1.Value, tb_guia.Text)

                    For cont = 0 To DGV_relacion.Rows.Count - 1

                        Dim tipo As Integer = 5

                        If DGV_relacion.Rows(cont).Cells(0).Value.ToString = "Fact." Then
                            tipo = 0
                        ElseIf DGV_relacion.Rows(cont).Cells(0).Value.ToString = "N.C." Then
                            tipo = 1
                        Else
                            tipo = 2
                        End If

                        Datos.ModificaEntrega(CInt(DGV_relacion.Rows(cont).Cells(6).Value), True, tipo)
                        Datos.InsertaEnvioFac_Fac(CInt(tb_codigo.Text), DGV_relacion.Rows(cont).Cells(2).Value.ToString, tipo)

                    Next

                    Datos.Inserta_Actividad("Creó la relación de documentos nro. " + tb_codigo.Text)

                    r_rfact.valores_relacionFacturas(Me.DGV_relacion, Me.tb_elaborada.Text, Me.tb_observ.Text, CInt(tb_codigo.Text), Me.tb_vendedor.SelectedItem.col1)
                    r_rfact.Show()

                ElseIf boton = 2 Then

                    Datos.ModificaEnvioFac(Me.tb_vendedor.SelectedItem.col2, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, tb_enviada.Text, dtp1.Value, CInt(tb_codigo.Text), tb_guia.Text)

                    For cont As Integer = 0 To DGV_relacion.Rows.Count - 1

                        Dim tipo As Integer = 5

                        If DGV_relacion.Rows(cont).Cells(0).Value.ToString = "Fact." Then
                            tipo = 0
                        ElseIf DGV_relacion.Rows(cont).Cells(0).Value.ToString = "N.C." Then
                            tipo = 1
                        Else
                            tipo = 2
                        End If

                        Datos.ModificaEntrega(CInt(DGV_relacion.Rows(cont).Cells(6).Value), True, tipo)
                        Datos.InsertaEnvioFac_Fac(CInt(tb_codigo.Text), DGV_relacion.Rows(cont).Cells(2).Value.ToString, tipo)

                    Next
                    For cont As Integer = 1 To elim.Count

                        Dim tipo As Integer = 5
                        If elim(cont).ToString.Split("/")(1) = "Fact." Then
                            tipo = 0
                        ElseIf elim(cont).ToString.Split("/")(1) = "N.C." Then
                            tipo = 1
                        Else
                            tipo = 2
                        End If

                        Datos.ModificaEntrega(CInt(elim(cont).ToString.Split("/")(0)), False, tipo)
                    Next

                    Datos.Inserta_Actividad("Modificó la relación de documentos nro. " + tb_codigo.Text)

                    MsgBox("Relación modificada satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

                End If

            Else

                MsgBox("No puede existir una relación vaciá, favor verificar", MsgBoxStyle.Exclamation, "SINPRO")
                deny = True

            End If

        Else

            MsgBox("Debe ingrsar todos los datos obligatorios")
            deny = True

        End If

        If deny = False Then

            ToolBar1.Enabled = True
            lb_asociacion.Location = New System.Drawing.Point(345, 156)
            lb_asociacion.Size = New System.Drawing.Size(671, 511)
            DGV_relacion.Size = New System.Drawing.Size(662, 479)
            lb_asociacion.BringToFront()
            Label8.BringToFront()
            boton = 0
            DGV_Docs.Rows.Clear()
            tb_enviada.Clear()
            Datos.consulta_vendedores(Me.tb_vendedor)
            DGV_relacion.Rows.Clear()
            bt_aceptar.Visible = False
            chk_confirmada.Visible = True
            dtp1.Enabled = False
            tb_guia.ReadOnly = True
            tb_guia.Clear()
            dtp1.Value = Today
            elim.Clear()
            tb_vendedor.Text = "-Seleccione un Vendedor-"
            bt_cancelar.Visible = False
            bt_agregar.Visible = False
            tb_aprobada.Clear()
            tb_enviada.Clear()
            tb_aprobada.ReadOnly = True
            tb_elaborada.Clear()
            Datos.ConsultaEnviosFac(Dgv_relaciones, 0, "")
            tb_elaborada.ReadOnly = True
            tb_observ.Clear()
            tb_observ.ReadOnly = True
            Dgv_relaciones.Enabled = True
            DGV_relacion.ReadOnly = True
            DGV_relacion.AllowUserToDeleteRows = False
            Dgv_relaciones.ClearSelection()
            tb_codigo.Clear()
            tb_enviada.ReadOnly = True
            tb_aprobada.ReadOnly = True
            sw = False
            tb_vendedor.Enabled = False

        End If

    End Sub

    Private Sub tb_vendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_vendedor.SelectedIndexChanged
        If sw Then
            If rb_fact.Checked Then
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 0)
            ElseIf rb_NC.Checked Then
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 1)
            Else
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 2)
            End If
            DGV_Docs.ClearSelection()
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is bt_nuevo Then
            boton = 1
            aca = True
            sw = True
            rb_fact.Checked = True
            Me.lb_asociacion.Location = New System.Drawing.Point(345, 437)
            Me.lb_asociacion.Size = New System.Drawing.Size(669, 230)
            Me.DGV_relacion.Size = New System.Drawing.Size(660, 198)

            Datos.identidadEnvio(tb_codigo.Text)
            Datos.consulta_vendedores(Me.tb_vendedor)

            chk_confirmada.Checked = False
            elim.Clear()
            tb_vendedor.Update()
            DGV_Docs.ClearSelection()
            bt_aceptar.Visible = True
            dtp1.Enabled = True
            dtp1.Value = Today
            tb_guia.ReadOnly = False
            bt_cancelar.Visible = True
            bt_agregar.Visible = True
            tb_enviada.Clear()
            tb_guia.Clear()
            tb_aprobada.Clear()
            tb_aprobada.ReadOnly = False
            tb_elaborada.Clear()
            chk_confirmada.Visible = False
            tb_elaborada.Text = Frm_Login.user
            tb_observ.Clear()
            tb_observ.ReadOnly = False
            DGV_relacion.Rows.Clear()
            Dgv_relaciones.Enabled = False
            DGV_relacion.ReadOnly = False
            DGV_relacion.Enabled = True
            Dgv_relaciones.ClearSelection()
            dtp1.Enabled = True
            tb_enviada.ReadOnly = False
            tb_aprobada.ReadOnly = False
            DGV_relacion.AllowUserToDeleteRows = True

            ToolBar1.Enabled = False

            tb_vendedor.Enabled = True
            tb_vendedor.DroppedDown = True
            tb_vendedor.Focus()

        ElseIf e.Button Is bt_modificar Then

            If Dgv_relaciones.SelectedRows.Count > 0 Then

                boton = 2
                'DatosGuiaTransporte.consulta_facturas_guia(Me.DGV_Fac, 0)
                elim.Clear()
                borrarRepetidos()
                Me.lb_asociacion.Location = New System.Drawing.Point(345, 437)
                Me.lb_asociacion.Size = New System.Drawing.Size(669, 230)
                Me.DGV_relacion.Size = New System.Drawing.Size(660, 198)
                tb_vendedor_SelectedIndexChanged(tb_vendedor, New EventArgs)
                sw = True
                tb_guia.ReadOnly = False
                tb_vendedor_SelectedIndexChanged(tb_vendedor, New EventArgs)
                bt_cancelar.Visible = True
                DGV_relacion.AllowUserToDeleteRows = True
                bt_agregar.Visible = True
                bt_aceptar.Visible = True
                tb_observ.ReadOnly = False
                ToolBar1.Enabled = False
                dtp1.Enabled = True
                DGV_relacion.ReadOnly = False
                DGV_relacion.Enabled = True
                rb_fact.Checked = True

            Else

                MsgBox("Debe seleccionar una relación para modificarla", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        ElseIf e.Button Is bt_imprimir Then

            boton = 3

            If Dgv_relaciones.SelectedRows.Count > 0 Then

                Dim r_rfact As New R_RelacionFacturas
                Dim cont As Integer = 0

                r_rfact.valores_relacionFacturas(Me.DGV_relacion, Me.tb_elaborada.Text, Me.tb_observ.Text, CInt(tb_codigo.Text), Me.tb_vendedor.SelectedItem.col1)
                r_rfact.Show()

            Else

                MsgBox("Debe seleccionar la relación que desea imprimir")

            End If

        ElseIf e.Button Is bt_salir Then
            Me.Close()
        End If
        aca = False
    End Sub


    Public Sub borrarRepetidos()

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0

        For cont = 0 To DGV_relacion.RowCount - 1

            For cont2 = 0 To DGV_Docs.RowCount - 1

                If DGV_relacion.Rows(cont).Cells(2).Value.ToString <> "S/N" Then

                    If DGV_Docs.Rows(cont2).Cells(1).Value.ToString = DGV_relacion.Rows(cont).Cells(2).Value.ToString Then

                        DGV_Docs.Rows(cont2).Visible = False

                    End If

                Else

                    If DGV_Docs.Rows(cont2).Cells(1).Value.ToString = DGV_relacion.Rows(cont).Cells(2).Value.ToString And DGV_Docs.Rows(cont2).Cells(4).Value.ToString = DGV_relacion.Rows(cont).Cells(5).Value.ToString Then

                        DGV_Docs.Rows(cont2).Visible = False

                    End If

                End If

            Next

        Next

    End Sub


    Private Sub DGV_relacion_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV_relacion.UserDeletingRow
        If boton = 2 Then
            elim.Add(DGV_relacion.CurrentRow.Cells(6).Value.ToString + "/" + DGV_relacion.CurrentRow.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then
            If Dgv_relaciones.RowCount > 0 Then
                Dgv_relaciones.Focus()
                Dgv_relaciones.Rows(0).Cells(0).Selected = True
                Dgv_relaciones_CellClick(Dgv_relaciones, New EventArgs)
            End If
        End If
    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        DGV_relacion.Rows.Clear()
        tb_aprobada.Clear()
        tb_codigo.Clear()
        tb_guia.Clear()
        tb_elaborada.Clear()
        tb_enviada.Clear()
        tb_observ.Clear()
        tb_vendedor.Text = "-Seleccione un Vendedor-"
        Datos.ConsultaEnviosFac(Dgv_relaciones, Dd_relacion.SelectedIndex + 1, tb_buscarcodigo.Text)
        Dgv_relaciones.ClearSelection()
    End Sub

    Private Sub Dgv_relaciones_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_relaciones.KeyDown, Dgv_relaciones.KeyUp, Dgv_relaciones.CellClick

        If Dgv_relaciones.SelectedRows.Count > 0 Then
            sw = False
            Datos.ConsultaEnvioFac(tb_vendedor, tb_aprobada.Text, tb_elaborada.Text, tb_observ.Text, tb_enviada.Text, dtp1.Value, tb_codigo.Text, DGV_relacion, CInt(Dgv_relaciones.SelectedRows(0).Cells(0).Value), tb_guia.Text, chk_confirmada.Checked)
            sw = True
        End If

    End Sub

    Private Sub Dd_relacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dd_relacion.SelectedIndexChanged
        tb_buscarcodigo.Clear()
        tb_buscarcodigo_TextChanged(tb_buscarcodigo, New EventArgs)
        tb_buscarcodigo.Focus()
    End Sub

    Private Sub DGV_relacion_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGV_relacion.UserDeletedRow

        For cont As Integer = 1 To elim.Count

            Dim tipo As Integer = 5
            If elim(cont).ToString.Split("/")(1) = "Fact." Then
                tipo = 0
            ElseIf elim(cont).ToString.Split("/")(1) = "N.C." Then
                tipo = 1
            Else
                tipo = 2
            End If

            Datos.ModificaEntrega(CInt(elim(cont).ToString.Split("/")(0)), False, tipo)

        Next

        If rb_fact.Checked Then
            DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 0)
        ElseIf rb_NC.Checked Then
            DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 1)
        Else
            DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 2)
        End If
        borrarRepetidos()
    End Sub

    Private Sub Dgv_relaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_relaciones.KeyDown, Dgv_relaciones.KeyUp
        If e.KeyData = Keys.Control Or e.KeyData = Keys.ControlKey Then
            tb_aprobada.Clear()
            tb_codigo.Clear()
            tb_elaborada.Clear()
            tb_enviada.Clear()
            tb_observ.Clear()
            dtp1.Value = Today
            tb_vendedor.Text = "-Seleccione un Vendedor-"
            DGV_relacion.Rows.Clear()
            Dgv_relaciones.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        Else
        End If
    End Sub

    Private Sub rb_fact_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fact.CheckedChanged, rb_NC.CheckedChanged, rb_chequesDev.CheckedChanged

        If tb_vendedor.SelectedIndex <> -1 Then

            If rb_fact.Checked Then
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 0)
            ElseIf rb_NC.Checked Then
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 1)
            Else
                DatosVendedores.consulta_Docs_vendedor(DGV_Docs, Me.tb_vendedor.SelectedItem.col2, 2)
            End If

            borrarRepetidos()

            DGV_Docs.ClearSelection()

        End If

    End Sub
End Class