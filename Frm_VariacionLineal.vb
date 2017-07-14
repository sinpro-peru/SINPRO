Public Class s

    Dim enter1 As Boolean = False
    Dim down As Boolean = False
    Dim up As Boolean = False
    Dim selected As Boolean = False

    Public Sub contarfilas()

        'Dim cont As Integer = 0
        'Dim filas As Integer = 0

        'For cont = 0 To DGV_Productos.RowCount - 1
        '    If DGV_Productos.Rows(cont).Visible Then
        '        filas = filas + 1
        '    End If
        'Next

        'Label11.Text = filas

        Label11.Text = DGV_Productos.RowCount

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        rb_todos.Checked = True
        rb_todos_CheckedChanged(rb_todos, New EventArgs)
        tb_cantidad.Clear()
        Chk_Exist.Checked = False
        chk_redondear.Checked = False
        tb_decimales.Clear()
        'Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If DGV_Productos.RowCount > 0 Then

            If tb_cantidad.Text <> "" Then

                Dim Resp As Integer = 0

                If rb_todos.Checked Then

                    If Chk_Exist.Checked Then

                        Resp = MsgBox("Está seguro de aplicar la variación a todos los productos con existencia positiva? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    Else

                        Resp = MsgBox("Está seguro de aplicar la variación a todos los productos? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    End If

                ElseIf rb_marca.Checked Then

                    If Chk_Exist.Checked Then

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos de la marca '" + cb_marca.Text + "' con existencia positiva? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    Else

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos de la marca '" + cb_marca.Text + "'? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    End If

                ElseIf rb_proveedor.Checked Then

                    If Chk_Exist.Checked Then

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos del proveedor '" + tb_proveedor.Text + "' con existencia positiva? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    Else

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos del proveedor '" + tb_proveedor.Text + "'? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    End If

                ElseIf rb_grupo.Checked Then

                    If Chk_Exist.Checked Then

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos del grupo '" + cb_grupo.Text + "' con existencia positiva? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    Else

                        Resp = MsgBox("Está seguro de aplicar la variación a los productos del grupo '" + cb_grupo.Text + "'? " + Label11.Text + " Artículos sufrirán un ajuste del " + tb_cantidad.Text + "% de su precio", MsgBoxStyle.YesNo, "Confirmación")

                    End If



                End If

                If Resp = vbYes Then


                    For cont As Integer = 0 To DGV_Productos.RowCount - 1

                        DatosProducto.ActualizaPreciosVariacion(DGV_Productos.Rows(cont).Cells(0).Value, DGV_Productos.Rows(cont).Cells(5).Value)

                    Next

                    MsgBox("Precios actualizados satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    rb_todos.Checked = True
                    rb_todos_CheckedChanged(rb_todos, New EventArgs)
                    tb_cantidad.Clear()
                    Chk_Exist.Checked = False
                    'Me.Close()

                End If

            Else

                MsgBox("Debe llenar el campo del porcentaje de variación", MsgBoxStyle.Exclamation, "Error")

            End If

        Else

            MsgBox("No existen productos en la lista", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Private Sub rb_marca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_marca.CheckedChanged
        If rb_marca.Checked Then
            cb_marca.Enabled = True
            DatosCompras.Llenar_Marcas(cb_marca, 0, "")
            cb_marca.Focus()
        Else
            'DGV_Productos.Rows.Clear()
            cb_marca.Items.Clear()
            cb_marca.Text = ""
            cb_marca.Enabled = False
        End If
        tb_cantidad.Clear()
    End Sub


    Private Sub rb_grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_grupo.CheckedChanged
        If rb_grupo.Checked Then
            cb_grupo.Enabled = True
            DatosCompras.Llenar_Grupos(cb_grupo, 0, "")
            cb_grupo.Focus()
        Else
            'DGV_Productos.Rows.Clear()
            cb_grupo.Items.Clear()
            cb_grupo.Text = ""
            cb_grupo.Enabled = False
        End If
        tb_cantidad.Clear()
    End Sub

    Private Sub rb_proveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_proveedor.CheckedChanged
        If rb_proveedor.Checked Then
            tb_proveedor.Enabled = True
            DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, Me.tb_proveedor.Text, "")
            tb_proveedor.Focus()
        Else
            'DGV_Productos.Rows.Clear()
            tb_proveedor.Items.Clear()
            tb_proveedor.Text = ""
            tb_proveedor.Enabled = False
        End If
        tb_cantidad.Clear()
    End Sub


    Private Sub cb_marca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.Click
        DatosCompras.Llenar_Marcas(cb_marca, 0, "")
    End Sub


    Private Sub cb_client_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marca.TextChanged
        If enter1 = False Then
            If down = False And up = False Then
                If selected = False Then
                    If cb_marca.Text <> "" Then
                        DatosCompras.Llenar_Marcas(cb_marca, 1, cb_marca.Text)

                        If cb_marca.SelectedIndex <> -1 Then

                            '------------------------- Llenar DGV ---------------------------------'
                            'DatosProducto.consulta_Productos_Variacion(DGV_Productos, cb_marca.Text, 0, 3)
                            'If Chk_Exist.Checked Then
                            '    FiltrarExistencia(0)
                            'Else
                            '    FiltrarExistencia(1)
                            'End If
                            CrearWhere()

                        End If

                        cb_marca.SelectionStart = Me.cb_marca.Text.Length
                        cb_marca.Refresh()
                        cb_marca.DroppedDown = True

                    Else

                        DatosCompras.Llenar_Marcas(cb_marca, 0, "")
                        cb_marca.SelectionStart = Me.cb_marca.Text.Length
                        cb_marca.Refresh()
                        cb_marca.DroppedDown = True

                    End If

                    enter1 = True

                End If

            End If

        End If

    End Sub


    Private Sub cb_client_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marca.GotFocus

        cb_marca.DroppedDown = True
        cb_marca.DropDownHeight = 110

    End Sub

    Private Sub cb_client_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marca.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If cb_marca.SelectedIndex = -1 Then

                cb_marca.Text = ""
                'DGV_Productos.Rows.Clear()
                CrearWhere()

                contarfilas()

            Else

                CrearWhere()
                cb_marca.Text = cb_marca.SelectedText

            End If
        ElseIf e.KeyCode = Keys.Down Then
            down = True
        ElseIf e.KeyCode = Keys.Up Then
            up = True
        ElseIf e.KeyCode = Keys.Back Then
            Dim textoo As String
            If cb_marca.Text.Length = 0 Then
                textoo = ""
            Else
                textoo = cb_marca.Text.Substring(0, cb_marca.Text.Length - 1)
            End If
            DatosCompras.Llenar_Marcas(cb_marca, 1, textoo)
            cb_marca.DroppedDown = True
            If cb_marca.SelectedIndex = -1 Then
                cb_marca.SelectionStart = cb_marca.Text.Length
            End If
        Else
            If Not cb_marca.SelectedIndex = -1 Then
                Me.cb_marca.Text = ""
                DatosCompras.Llenar_Marcas(cb_marca, 1, "")
                cb_marca.DroppedDown = True
            End If
            enter1 = False
            down = False
            up = False
            selected = False
            cb_marca.SelectionStart = Me.cb_marca.Text.Length
        End If

    End Sub

    Private Sub cb_client_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marca.SelectionChangeCommitted

        If Not cb_marca.SelectedIndex = -1 Then

            If enter1 = True Then

                cb_marca.Text = cb_marca.Items.Item(cb_marca.SelectedIndex).Name

                'DatosProducto.consulta_Productos_Variacion(DGV_Productos, cb_marca.Text, 0, 3)
                'If Chk_Exist.Checked = True Then
                '    FiltrarExistencia(0)
                'Else
                '    FiltrarExistencia(1)
                'End If
                CrearWhere()

                cb_marca.SelectionStart = Me.cb_marca.Text.Length

            Else

                enter1 = True
                cb_marca.Text = cb_marca.Items.Item(cb_marca.SelectedIndex).Name
                'DatosProducto.consulta_Productos_Variacion(DGV_Productos, cb_marca.Text, 0, 3)
                'If Chk_Exist.Checked = True Then
                '    FiltrarExistencia(0)
                'Else
                '    FiltrarExistencia(1)
                'End If
                CrearWhere()


            End If

            contarfilas()

        End If

    End Sub

    Private Sub cb_grupo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_grupo.Click
        DatosCompras.Llenar_Grupos(cb_grupo, 0, "")
    End Sub


    Private Sub cb_grupo_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grupo.TextChanged
        If enter1 = False Then
            If down = False And up = False Then
                If selected = False Then
                    If cb_grupo.Text <> "" Then
                        DatosCompras.Llenar_Grupos(cb_grupo, 1, cb_grupo.Text)
                        If cb_grupo.SelectedIndex <> -1 Then

                            '------------------------- Llenar DGV ---------------------------------'
                            'DatosProducto.consulta_Productos_Variacion(DGV_Productos, "", CInt(cb_grupo.Items.Item(Me.cb_grupo.SelectedIndex).Code), 1)
                            'If Chk_Exist.Checked = True Then
                            '    FiltrarExistencia(0)
                            'Else
                            '    FiltrarExistencia(1)
                            'End If
                            CrearWhere()

                        End If

                        cb_grupo.SelectionStart = Me.cb_grupo.Text.Length
                        cb_grupo.Refresh()
                        cb_grupo.DroppedDown = True

                    Else

                        DatosCompras.Llenar_Grupos(cb_grupo, 0, "")
                        cb_grupo.SelectionStart = Me.cb_grupo.Text.Length
                        cb_grupo.Refresh()
                        cb_grupo.DroppedDown = True

                    End If

                    enter1 = True

                End If

            End If

        End If

    End Sub


    Private Sub cb_grupo_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grupo.GotFocus

        cb_grupo.DroppedDown = True
        cb_grupo.DropDownHeight = 110

    End Sub

    Private Sub cb_grupo_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_grupo.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If cb_grupo.SelectedIndex = -1 Then

                cb_grupo.Text = ""
                CrearWhere()
                'DGV_Productos.Rows.Clear()

                'contarfilas()

            Else

                cb_grupo.Text = cb_grupo.SelectedText

            End If
        ElseIf e.KeyCode = Keys.Down Then
            down = True
        ElseIf e.KeyCode = Keys.Up Then
            up = True
        ElseIf e.KeyCode = Keys.Back Then
            Dim textoo As String
            If cb_grupo.Text.Length = 0 Then
                textoo = ""
            Else
                textoo = cb_grupo.Text.Substring(0, cb_grupo.Text.Length - 1)
            End If
            DatosCompras.Llenar_Grupos(cb_grupo, 1, textoo)
            cb_grupo.DroppedDown = True
            If cb_grupo.SelectedIndex = -1 Then
                cb_grupo.SelectionStart = cb_grupo.Text.Length
            End If
        Else
            If Not cb_grupo.SelectedIndex = -1 Then
                Me.cb_grupo.Text = ""
                DatosCompras.Llenar_Grupos(cb_grupo, 1, "")
                cb_grupo.DroppedDown = True
            End If
            enter1 = False
            down = False
            up = False
            selected = False
            cb_grupo.SelectionStart = Me.cb_grupo.Text.Length
        End If

    End Sub

    Private Sub cb_Grupo_clic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grupo.SelectionChangeCommitted

        If Not cb_grupo.SelectedIndex = -1 Then

            If enter1 = True Then

                cb_grupo.Text = cb_grupo.Items.Item(cb_grupo.SelectedIndex).Name
                CrearWhere()
                'DatosProducto.consulta_Productos_Variacion(DGV_Productos, "", CInt(cb_grupo.Items.Item(Me.cb_grupo.SelectedIndex).Code), 1)
                'If Chk_Exist.Checked = True Then
                '    FiltrarExistencia(0)
                'Else
                '    FiltrarExistencia(1)
                'End If

                cb_grupo.SelectionStart = Me.cb_grupo.Text.Length

            Else

                enter1 = True
                cb_grupo.Text = cb_grupo.Items.Item(cb_grupo.SelectedIndex).Name
                CrearWhere()
                'DatosProducto.consulta_Productos_Variacion(DGV_Productos, "", CInt(cb_grupo.Items.Item(Me.cb_grupo.SelectedIndex).Code), 1)
                'If Chk_Exist.Checked = True Then
                '    FiltrarExistencia(0)
                'Else
                '    FiltrarExistencia(1)
                'End If


            End If

            'contarfilas()

        End If

    End Sub



    Private Sub cb_proveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_proveedor.Click
        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, "", "")
    End Sub


    Private Sub cb_proveedor_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.TextChanged
        If enter1 = False Then
            If down = False And up = False Then
                If selected = False Then
                    If tb_proveedor.Text <> "" Then

                        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, Me.tb_proveedor.Text, "")

                        If tb_proveedor.SelectedIndex <> -1 Then

                            '------------------------- Llenar DGV ---------------------------------'
                            'DatosProducto.consulta_Productos_Variacion(DGV_Productos, "", CInt(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code), 2)
                            'If Chk_Exist.Checked = True Then
                            '    FiltrarExistencia(0)
                            'Else
                            '    FiltrarExistencia(1)
                            'End If
                            CrearWhere()

                        End If

                        tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
                        tb_proveedor.Refresh()
                        tb_proveedor.DroppedDown = True

                    Else

                        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, "", "")
                        tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
                        tb_proveedor.Refresh()
                        tb_proveedor.DroppedDown = True

                    End If

                    enter1 = True

                End If

            End If

        End If

    End Sub


    Private Sub cb_proveedor_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.GotFocus

        tb_proveedor.DroppedDown = True
        tb_proveedor.DropDownHeight = 110

    End Sub

    Private Sub cb_proveedor_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_proveedor.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If tb_proveedor.SelectedIndex = -1 Then

                tb_proveedor.Text = ""
                CrearWhere()

            Else

                tb_proveedor.Text = tb_proveedor.SelectedText

            End If
        ElseIf e.KeyCode = Keys.Down Then
            down = True
        ElseIf e.KeyCode = Keys.Up Then
            up = True
        ElseIf e.KeyCode = Keys.Back Then
            Dim textoo As String
            If tb_proveedor.Text.Length = 0 Then
                textoo = ""
            Else
                textoo = tb_proveedor.Text.Substring(0, tb_proveedor.Text.Length - 1)
            End If
            DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, textoo, "")
            tb_proveedor.DroppedDown = True
            If tb_proveedor.SelectedIndex = -1 Then
                tb_proveedor.SelectionStart = tb_proveedor.Text.Length
            End If
        Else
            If Not tb_proveedor.SelectedIndex = -1 Then
                Me.tb_proveedor.Text = ""
                DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, Me.tb_proveedor.Text, "")
                tb_proveedor.DroppedDown = True
            End If
            enter1 = False
            down = False
            up = False
            selected = False
            tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
        End If

    End Sub

    Private Sub tb_proveedor_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.SelectionChangeCommitted

        If Not tb_proveedor.SelectedIndex = -1 Then

            If enter1 = True Then

                tb_proveedor.Text = tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).Name

                CrearWhere()

                tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length

            Else

                enter1 = True
                tb_proveedor.Text = tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).Name

                'DatosProducto.consulta_Productos_Variacion(DGV_Productos, "", CInt(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code), 2)
                'If Chk_Exist.Checked = True Then
                '    FiltrarExistencia(0)
                'Else
                '    FiltrarExistencia(1)
                'End If

                CrearWhere()
            End If
        End If
    End Sub

    Private Sub tb_cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantidad.KeyDown

        If e.KeyCode = Keys.Enter Then

            'DGV_Productos.ReadOnly = False

            For cont As Integer = 0 To DGV_Productos.RowCount - 1

                If chk_redondear.Checked Then

                    Dim a As Integer = 0
                    Dim total As Double = CDbl(DGV_Productos.Rows(cont).Cells(6).Value) + (CDbl(DGV_Productos.Rows(cont).Cells(6).Value) * (CDbl(tb_cantidad.Text) / 100))

                    If tb_decimales.Text <> "" Then
                        a = CInt(tb_decimales.Text)
                    End If

                    DGV_Productos.Rows(cont).Cells(5).Value = Math.Round(total, a, MidpointRounding.AwayFromZero)

                Else

                    DGV_Productos.Rows(cont).Cells(5).Value = CDbl(DGV_Productos.Rows(cont).Cells(6).Value) + (CDbl(DGV_Productos.Rows(cont).Cells(6).Value) * (CDbl(tb_cantidad.Text) / 100))

                End If


            Next

        End If

        'DGV_Productos.ReadOnly = True

    End Sub


    Private Sub tb_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cantidad.KeyPress

        If (sender Is Me.tb_cantidad) Then

            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ","c And Not tb_cantidad.Text.Contains(",") And tb_cantidad.Text <> "") Or (e.KeyChar = "-"c And Not tb_cantidad.Text.Contains("-") And tb_cantidad.Text = "") Then

                e.Handled = False
                muestra_label(sender, 1)

            Else

                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números y (,)"

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

    Private Sub Frm_VariacionLineal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaProductosVariacion' table. You can move, or remove it, as needed.
        Me.Sp_consultaProductosVariacionTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosVariacion)
        rb_todos.Checked = True
        contarfilas()
    End Sub

    Private Sub rb_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged

        If rb_todos.Checked Then
            CrearWhere()
        End If

    End Sub

    Private Sub Chk_Exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Exist.CheckedChanged

        CrearWhere()

    End Sub

    Private Sub tb_cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cantidad.TextChanged

        If tb_cantidad.Text <> "" And tb_cantidad.Text <> "-" Then

            If CDbl(tb_cantidad.Text) < -100 Or CDbl(tb_cantidad.Text) > 100 Then

                MsgBox("Debe introducir un valor válido", MsgBoxStyle.Exclamation, "Error")
                tb_cantidad.Clear()

            End If

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If tb_cantidad.Text <> "" Then

            If DGV_Productos.RowCount > 0 Then

                Dim frm As New R_Variacion
                frm.recibe(DGV_Productos, CInt(Label11.Text), CDbl(tb_cantidad.Text))
                frm.Show()

            Else

                MsgBox("La lista de productos está vacía", MsgBoxStyle.Exclamation, "Error")

            End If

        Else

            MsgBox("El campo variación se encuentra vacío", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If Chk_Exist.Checked Then

            where = where + y + "CantidadExistencia > 0 "
            y = " and "
        End If

        If rb_marca.Checked And cb_marca.SelectedIndex <> -1 Then
            where = where + y + "Marca LIKE '%" & cb_marca.Items.Item(Me.cb_marca.SelectedIndex).name & "%'"
            y = " and "
        End If

        If rb_grupo.Checked And cb_grupo.SelectedIndex <> -1 Then
            where = where + y + "Grupo LIKE '%" & cb_grupo.Items.Item(Me.cb_grupo.SelectedIndex).code & cb_grupo.Items.Item(Me.cb_grupo.SelectedIndex).name & "%'"
            y = " and "
        End If

        If rb_proveedor.Checked And tb_proveedor.SelectedIndex <> -1 Then
            where = where + y + "Proveedor LIKE '%" & tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).code & tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).name & "%'"
            y = " and "
        End If

        Me.SpconsultaProductosVariacionBindingSource.Filter = where
        Label11.Text = DGV_Productos.RowCount
        DGV_Productos.ClearSelection()

    End Sub

    Private Sub chk_redondear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_redondear.CheckedChanged
        If chk_redondear.Checked = False Then
            tb_decimales.Clear()
        End If
    End Sub

End Class