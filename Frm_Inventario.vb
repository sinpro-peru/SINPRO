Public Class Frm_Inventario

    Dim VarBoton As Integer = 0
    Public User As String = ""
    Dim sw As Boolean = False


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Try

            If e.Button Is Me.bt_salir Then
                VarBoton = 3
                tb_buscar.Clear()
                tb_codigo.Clear()
                Tb_Descripcion.Clear()
                tb_Usuario.Clear()
                Tb_Descripcion.ReadOnly = True
                dtp_fecha.Value = Today
                dtp_fecha.Enabled = False
                Button1.Hide()
                Button2.Hide()
                DGV_Inventarios.ClearSelection()
                Me.Close()

            ElseIf e.Button Is Me.bt_nuevo Then
                VarBoton = 1
                DGV_Inventarios.ClearSelection()
                DatosInventario.ProximoInventario(tb_codigo.Text)
                ToolBar1.Enabled = False
                Panel2.Enabled = True
                DGV_Inventarios.Enabled = False
                Button1.Show()
                Button2.Show()
                Button3.Show()
                Tb_Descripcion.Clear()
                tb_Usuario.Clear()
                tb_Usuario.Text = User
                dtp_fecha.Value = Today
                Tb_Descripcion.Focus()
                Tb_Descripcion.ReadOnly = False
                dtp_fecha.Enabled = True
                DomainUpDown1.Items.Clear()
                DomainUpDown1.Items.Add("Código Producto")
                DomainUpDown1.Items.Add("Descripción")
                DomainUpDown1.Items.Add("Modelo")
                DomainUpDown1.Items.Add("Código Fábrica")

                CheckBox1.Enabled = True
                CheckBox1.Checked = False

                chk_dif.Checked = False

                Dgv_ProductosI.Visible = False
                DGV_Productos.Visible = True

                DomainUpDown1.SelectedIndex = 0

                Sp_consultaProductosParaInventarioBindingSource.Filter = ""

                'TODO: This line of code loads data into the 'MELDataSet.sp_consultaProductosParaInventario' table. You can move, or remove it, as needed.
                Me.Sp_consultaProductosParaInventarioTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaInventario)

                DGV_Productos.ClearSelection()
                DGV_Productos.Columns(5).ReadOnly = False
                DGV_Productos.Columns(7).ReadOnly = False

            ElseIf e.Button Is Me.bt_modificar Then

                If DGV_Inventarios.SelectedRows.Count > 0 Then

                    If DGV_Inventarios.SelectedRows(0).Cells(3).Value = "No" Then

                        VarBoton = 2
                        ToolBar1.Enabled = False
                        Panel2.Enabled = True
                        DGV_Inventarios.Enabled = False
                        Button1.Show()
                        Button2.Show()
                        Button3.Show()
                        'DGV_Productos.ReadOnly = False
                        Tb_Descripcion.Focus()
                        Tb_Descripcion.ReadOnly = False
                        dtp_fecha.Value = Today
                        DomainUpDown1.Items.Clear()
                        DomainUpDown1.Items.Add("Código Producto")
                        DomainUpDown1.Items.Add("Descripción")
                        DomainUpDown1.Items.Add("Modelo")
                        DomainUpDown1.Items.Add("Código Fábrica")

                        CheckBox1.Enabled = True
                        CheckBox1.Checked = False

                        Dgv_ProductosI.Visible = True
                        DGV_Productos.Visible = False

                        DomainUpDown1.SelectedIndex = 0

                        Me.Sp_consultaProductosInvetarioTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosInvetario, DGV_Inventarios.SelectedRows(0).Cells(0).Value, 1)
                        Dgv_ProductosI.ClearSelection()

                        'ConsultarProductos del inventario seleccionado

                        DGV_Productos.ClearSelection()
                        Dgv_ProductosI.Columns(5).ReadOnly = False
                        Dgv_ProductosI.Columns(7).ReadOnly = False

                    Else

                        MsgBox("No puede modificar un conteo que ya ha sido cerrado", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                End If

            ElseIf e.Button Is Me.bt_reporte Then

                If DGV_Inventarios.SelectedRows.Count > 0 Then

                    'Imprimir reporte
                    Dim frm As New R_DiferenciasInventario
                    frm.CodI = CInt(tb_codigo.Text)
                    frm.Fec = dtp_fecha.Value
                    frm.Show()

                End If

            ElseIf e.Button Is Me.bt_eliminar Then

                If DGV_Inventarios.SelectedRows.Count > 0 Then

                    If DGV_Inventarios.SelectedRows(0).Cells(3).Value = "No" Then

                        Dim resp As Integer = MsgBox("Esta seguro que desea cerrar el ajuste? Esto ajustará la existencia de los productos con diferencias", MsgBoxStyle.YesNo, "SINPRO")

                        If resp = vbYes Then

                            Dim Id As Integer = DatosInventario.ProximoAjuste()
                            DatosInventario.Inserta_Ajuste(Today, tb_Usuario.Text, "Ajuste por conteo de inventario")

                            Sp_consultaProductosInvetarioBindingSource.Filter = "Dif <> 0"

                            For i As Integer = 0 To Dgv_ProductosI.RowCount - 1

                                DatosInventario.Inserta_Ajuste_Producto(Id, Dgv_ProductosI.Rows(i).Cells(0).Value, Dgv_ProductosI.Rows(i).Cells(5).Value, Dgv_ProductosI.Rows(i).Cells(7).Value, Dgv_ProductosI.Rows(i).Cells(9).Value, Dgv_ProductosI.Rows(i).Cells(6).Value)

                            Next

                            DatosInventario.Cerrar_Inventario(DGV_Inventarios.SelectedRows(0).Cells(0).Value)
                            DGV_Inventarios.SelectedRows(0).Cells(3).Value = "Sí"

                            Sp_consultaProductosInvetarioBindingSource.Filter = ""

                            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Conteo cerrado satifactoriamente", ToolTipIcon.Info)

                            Dgv_ProductosI.ClearSelection()
                            DGV_Productos.ClearSelection()

                        End If

                    Else

                        MsgBox("Este conteo ya fue cerrado anteriormente", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                Else

                    MsgBox("Debe seleccionar un conteo para ajustar", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

        Catch ex As Exception

            MsgBox("Error cargando numero de ajuste", MsgBoxStyle.Critical)
            MsgBox(ex.ToString())

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'DGV_Productos.ReadOnly = True

        Tb_Descripcion.Clear()
        Tb_Descripcion.ReadOnly = True
        tb_codigo.Clear()
        tb_codigo.ReadOnly = True
        tb_Usuario.Clear()
        dtp_fecha.Value = Today
        ToolBar1.Enabled = True

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        CheckBox1.Checked = False
        CheckBox1.Enabled = False

        DGV_Inventarios.Enabled = True

        Dgv_ProductosI.Visible = True
        DGV_Productos.Visible = False

        DomainUpDown1.Items.Clear()
        DomainUpDown1.Items.Add("Código Inventario")
        DomainUpDown1.Items.Add("Código Interno")
        DomainUpDown1.Items.Add("Descripción")
        DomainUpDown1.Items.Add("Código Fábrica")

        DomainUpDown1.SelectedIndex = 0

        DatosInventario.consulta_inventario(DGV_Inventarios, "", 0)

        Sp_consultaProductosParaInventarioBindingSource.Filter = "CodigoTramo = -1"
        Sp_consultaProductosInvetarioBindingSource.Filter = "CodigoTramo = -1"

        DGV_Productos.Columns(5).ReadOnly = True
        Dgv_ProductosI.Columns(5).ReadOnly = True

        DGV_Productos.Columns(7).ReadOnly = True
        Dgv_ProductosI.Columns(7).ReadOnly = True

        DGV_Inventarios.ClearSelection()

        tb_buscar.Clear()
        tb_buscar.Focus()

    End Sub

    Private Sub DGV_Productos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellClick

        If DGV_Productos.SelectedRows.Count > 0 Then

            'DGV_Productos.SelectedRows(0).Cells(5).Selected = True
            'DGV_Productos.BeginEdit(True)

        End If

    End Sub

    Private Sub DGV_ProductosI_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_ProductosI.CellClick

        If Dgv_ProductosI.SelectedRows.Count > 0 Then

            'Dgv_ProductosI.SelectedRows(0).Cells(5).Selected = True
            'Dgv_ProductosI.BeginEdit(True)

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            cb_almacenes.Enabled = True
            cb_cuartos.Enabled = True
            cb_estante.Enabled = True
            cb_tramo.Enabled = True
            DatosAlmacenes.llenar_almacen(cb_almacenes)
            cb_almacenes.SelectedIndex = 0
        Else
            cb_almacenes.Enabled = False
            cb_cuartos.Enabled = False
            cb_estante.Enabled = False
            cb_tramo.Enabled = False
            cb_almacenes.Items.Clear()
            cb_cuartos.Items.Clear()
            cb_almacenes.ResetText()
            cb_cuartos.ResetText()
            cb_estante.ResetText()
            cb_tramo.ResetText()

            CrearWhere()

        End If

    End Sub

    Private Sub cb_almacenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacenes.SelectedIndexChanged

        If cb_almacenes.SelectedIndex <> -1 Then
            DatosAlmacenes.llenarcuartos(cb_cuartos, cb_cuartos, CInt(Me.cb_almacenes.Items.Item(cb_almacenes.SelectedIndex).code))
        End If

        cb_cuartos.SelectedIndex = -1
        cb_estante.SelectedIndex = -1
        cb_tramo.SelectedIndex = -1
        CrearWhere()

    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If ToolBar1.Enabled Then

            If DomainUpDown1.SelectedIndex = 1 Then

                where = where + y + "CodigoInterno LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 2 Then

                where = where + y + "Nombre LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 3 Then

                where = where + y + "CodigoFabrica LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 0 Then

                If sw = False Then
                    DatosInventario.consulta_inventario(DGV_Inventarios, tb_buscar.Text, 1)
                End If

            End If

            If chk_dif.Checked Then

                where = where + y + "Dif <> 0"
                y = " and "

            End If

            If chk_exist.Checked Then

                where = where + y + "CantidadAnterior <> 0"
                y = " and "

            End If

            Sp_consultaProductosInvetarioBindingSource.Filter = where

        Else

            If DomainUpDown1.SelectedIndex = 0 Then

                where = where + y + "CodigoInterno LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 1 Then

                where = where + y + "Nombre LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 2 Then

                where = where + y + "Modelo LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 3 Then

                where = where + y + "CodigoFabrica LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            End If

            If cb_almacenes.SelectedIndex <> -1 Then

                where = where + y + "CodigoAlmacen = " & Me.cb_almacenes.Items.Item(cb_almacenes.SelectedIndex).code.ToString & ""
                y = " and "

            End If

            If cb_cuartos.SelectedIndex <> -1 Then

                If cb_almacenes.SelectedIndex <> -1 Then

                    where = where + y + "CodigoCuarto = " & Me.cb_cuartos.Items.Item(cb_cuartos.SelectedIndex).code.ToString & ""
                    y = " and "

                End If

            End If

            If cb_estante.SelectedIndex <> -1 Then

                If cb_almacenes.SelectedIndex <> -1 Then

                    where = where + y + "CodigoEstante = " & Me.cb_estante.Items.Item(cb_estante.SelectedIndex).code.ToString & ""
                    y = " and "

                End If

            End If

            If cb_tramo.SelectedIndex <> -1 Then

                If cb_almacenes.SelectedIndex <> -1 Then

                    where = where + y + "CodigoTramo = " & Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code.ToString & ""
                    y = " and "

                End If

            End If

            If chk_dif.Checked Then

                where = where + y + "Dif <> 0"
                y = " and "

            End If

            If DGV_Productos.Visible Then

                If chk_exist.Checked Then

                    where = where + y + "Cantidad <> 0"
                    y = " and "

                End If

            Else

                If chk_exist.Checked Then

                    where = where + y + "CantidadAnterior <> 0"
                    y = " and "

                End If
            End If

            If DGV_Productos.Visible Then
                Sp_consultaProductosParaInventarioBindingSource.Filter = where
            Else
                Sp_consultaProductosInvetarioBindingSource.Filter = where
            End If

        End If

        DGV_Productos.ClearSelection()
        Dgv_ProductosI.ClearSelection()

    End Sub

    Private Sub cb_cuartos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuartos.SelectedIndexChanged

        CrearWhere()
        cb_estante.SelectedIndex = -1
        cb_tramo.SelectedIndex = -1
        If cb_cuartos.SelectedIndex <> -1 Then
            DatosAlmacenes.llenarestantes(cb_estante, cb_estante, CInt(Me.cb_cuartos.Items.Item(cb_cuartos.SelectedIndex).code))
        End If


    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedIndexChanged

        CrearWhere()
        cb_tramo.SelectedIndex = -1
        If cb_estante.SelectedIndex <> -1 Then
            DatosAlmacenes.llenartramos(cb_tramo, cb_tramo, CInt(Me.cb_estante.Items.Item(cb_estante.SelectedIndex).code))
        End If

    End Sub

    Private Sub cb_tramo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tramo.SelectedIndexChanged

        CrearWhere()
        DGV_Productos.ClearSelection()

    End Sub

    Private Sub tb_buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyDown

        If e.KeyCode = Keys.Enter Then

            If ToolBar1.Enabled Then

                If DGV_Inventarios.RowCount > 0 Then

                    DGV_Inventarios.Focus()
                    DGV_Inventarios.Rows(0).Cells(0).Selected = True

                End If

            Else

                If DGV_Productos.Visible Then

                    If DGV_Productos.RowCount > 0 Then

                        If DGV_Productos.SelectedRows.Count > 0 Then

                            DGV_Productos.Focus()
                            DGV_Productos.SelectedRows(0).Cells(5).Selected = True
                            DGV_Productos.BeginEdit(True)

                        Else

                            DGV_Productos.Focus()
                            DGV_Productos.Rows(0).Cells(5).Selected = True
                            DGV_Productos.BeginEdit(True)

                        End If

                    End If

                ElseIf Dgv_ProductosI.Visible Then

                    If Dgv_ProductosI.RowCount > 0 Then

                        If Dgv_ProductosI.SelectedRows.Count > 0 Then

                            Dgv_ProductosI.Focus()
                            Dgv_ProductosI.SelectedRows(0).Cells(5).Selected = True
                            Dgv_ProductosI.BeginEdit(True)

                        Else

                            Dgv_ProductosI.Focus()
                            Dgv_ProductosI.Rows(0).Cells(5).Selected = True
                            Dgv_ProductosI.BeginEdit(True)

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged

        If ToolBar1.Enabled Then

            If DomainUpDown1.SelectedIndex = 0 Then

                DatosInventario.consulta_inventario(DGV_Inventarios, tb_buscar.Text, 1)
                tb_codigo.Clear()
                Tb_Descripcion.Clear()
                tb_Usuario.Clear()
                Sp_consultaProductosInvetarioBindingSource.Filter = "CodigoTramo = -1"

            Else

                CrearWhere()

            End If

        Else

            CrearWhere()

        End If


    End Sub

    Private Sub DGV_Productos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellEndEdit

        If Not DGV_Productos.CurrentCell.Value Is Nothing Then

            If DGV_Productos.CurrentCell.ColumnIndex = 5 Then

                If DGV_Productos.CurrentCell.ColumnIndex = 5 And DGV_Productos.CurrentCell.Value.ToString = "" Then

                    DGV_Productos.CurrentCell.Value = System.DBNull.Value
                    DGV_Productos.CurrentRow.Cells(6).Value = System.DBNull.Value

                Else

                    If DGV_Productos.CurrentRow.Cells(9).Value.ToString = "" And DGV_Productos.CurrentRow.Cells(5).Value.ToString <> DGV_Productos.CurrentRow.Cells(4).Value.ToString Then

                        Dim frm As New Frm_Ubicacion
                        frm.index = DGV_Productos.CurrentRow.Index
                        frm.frm = Me
                        Me.Enabled = False
                        frm.TopMost = True
                        frm.Show()

                    Else

                        DGV_Productos.CurrentRow.Cells(6).Value = CInt(DGV_Productos.CurrentRow.Cells(5).Value) - CInt(DGV_Productos.CurrentRow.Cells(4).Value)

                        If DGV_Productos.CurrentRow.Cells(7).Value = "" Then
                            DGV_Productos.CurrentRow.Cells(7).Value = Tb_Descripcion.Text
                        End If

                    End If

                End If

            ElseIf DGV_Productos.CurrentCell.ColumnIndex = 7 Then

                If DGV_Productos.CurrentCell.Value.ToString = "" Then

                    DGV_Productos.CurrentCell.Value = Tb_Descripcion.Text

                End If


            End If

        End If

    End Sub

    Private Sub Dgv_ProductosI_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_ProductosI.CellEndEdit

        If Not Dgv_ProductosI.CurrentCell.Value Is Nothing Then

            If Dgv_ProductosI.CurrentCell.ColumnIndex = 5 Then

                If Dgv_ProductosI.CurrentCell.Value.ToString = "" Then

                    Dgv_ProductosI.CurrentCell.Value = System.DBNull.Value
                    Dgv_ProductosI.CurrentRow.Cells(6).Value = System.DBNull.Value

                Else

                    If Dgv_ProductosI.CurrentRow.Cells(8).Value.ToString = "" And Dgv_ProductosI.CurrentRow.Cells(5).Value.ToString <> Dgv_ProductosI.CurrentRow.Cells(4).Value.ToString Then

                        Dim frm As New Frm_Ubicacion
                        frm.index = Dgv_ProductosI.CurrentRow.Index
                        frm.frm = Me
                        Me.Enabled = False
                        frm.TopMost = True
                        frm.Show()

                    Else

                        Dgv_ProductosI.CurrentRow.Cells(6).Value = CInt(Dgv_ProductosI.CurrentRow.Cells(5).Value) - CInt(Dgv_ProductosI.CurrentRow.Cells(4).Value)

                        If Dgv_ProductosI.CurrentRow.Cells(7).Value = "" Then
                            Dgv_ProductosI.CurrentRow.Cells(7).Value = Tb_Descripcion.Text
                        End If

                    End If

                End If

            ElseIf Dgv_ProductosI.CurrentCell.ColumnIndex = 7 Then

                If Dgv_ProductosI.CurrentCell.Value.ToString = "" Then

                    Dgv_ProductosI.CurrentCell.Value = Tb_Descripcion.Text

                End If

            End If


        End If

    End Sub

    Private Sub DGV_Productos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Productos.SelectionChanged

        If DGV_Productos.SelectedRows.Count > 0 Then

            DGV_Productos.Focus()
            DGV_Productos.Rows(DGV_Productos.SelectedRows(0).Index).Cells(5).Selected = True
            DGV_Productos.BeginEdit(True)

        End If

    End Sub

    Private Sub DGV_ProductosI_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_ProductosI.SelectionChanged

        If Dgv_ProductosI.SelectedRows.Count > 0 Then

            Dgv_ProductosI.Focus()
            Dgv_ProductosI.Rows(Dgv_ProductosI.SelectedRows(0).Index).Cells(5).Selected = True
            Dgv_ProductosI.BeginEdit(True)

        End If

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And Not (e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CellKeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "-"c OrElse e.KeyChar = "."c OrElse Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DGV_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Productos.EditingControlShowing

        If Me.DGV_Productos.CurrentCell.ColumnIndex = 5 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)

            If txt IsNot Nothing Then

                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress

                RemoveHandler txt.KeyDown, AddressOf txt1_KeyDown
                AddHandler txt.KeyDown, AddressOf txt1_KeyDown

            End If

        ElseIf Me.DGV_Productos.CurrentCell.ColumnIndex = 7 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)

            RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
            AddHandler txt.KeyPress, AddressOf CellKeyPress3

        End If

    End Sub

    Private Sub DGV_ProductosI_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv_ProductosI.EditingControlShowing

        If Me.Dgv_ProductosI.CurrentCell.ColumnIndex = 5 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)

            If txt IsNot Nothing Then

                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress

                RemoveHandler txt.KeyDown, AddressOf txt1_KeyDown
                AddHandler txt.KeyDown, AddressOf txt1_KeyDown

            End If

        ElseIf Me.Dgv_ProductosI.CurrentCell.ColumnIndex = 7 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)

            RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
            AddHandler txt.KeyPress, AddressOf CellKeyPress3

        End If

    End Sub

    Private Sub Frm_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DGV_Productos.Columns(7).ReadOnly = True
        Dgv_ProductosI.Columns(7).ReadOnly = True
        DomainUpDown1.SelectedIndex = 0
        Label5.Text = DGV_Inventarios.RowCount
        DatosInventario.consulta_inventario(DGV_Inventarios, "", 0)

    End Sub

    Private Sub DGV_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Productos.KeyDown, DGV_Productos.KeyUp

        Try

            If DGV_Productos.CurrentRow.Cells(5).IsInEditMode Then

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    DGV_Productos.EndEdit()
                    DGV_Productos.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                ElseIf e.KeyCode = Keys.Shift Or e.KeyCode = Keys.ShiftKey Then

                    DGV_Productos.CurrentRow.Cells(7).Selected = True
                    DGV_Productos.BeginEdit(True)

                Else

                    DGV_Productos.BeginEdit(True)

                End If

            Else

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    DGV_Productos.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                ElseIf e.KeyCode = Keys.Shift Or e.KeyCode = Keys.ShiftKey Then

                    DGV_Productos.CurrentRow.Cells(7).Selected = True
                    DGV_Productos.BeginEdit(True)

                Else

                    DGV_Productos.BeginEdit(True)

                End If

            End If

        Catch ex As Exception
            tb_buscar.Focus()
        End Try


    End Sub


    Private Sub DGV_ProductosI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgv_ProductosI.KeyDown, Dgv_ProductosI.KeyUp

        Try

            If Dgv_ProductosI.CurrentCell.IsInEditMode Then

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    Dgv_ProductosI.EndEdit()
                    Dgv_ProductosI.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                ElseIf e.KeyCode = Keys.Shift Or e.KeyCode = Keys.ShiftKey Then

                    Dgv_ProductosI.CurrentRow.Cells(7).Selected = True
                    Dgv_ProductosI.BeginEdit(True)

                Else

                    Dgv_ProductosI.BeginEdit(True)

                End If

            Else

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    Dgv_ProductosI.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                ElseIf e.KeyCode = Keys.Shift Or e.KeyCode = Keys.ShiftKey Then

                    Dgv_ProductosI.CurrentRow.Cells(7).Selected = True
                    Dgv_ProductosI.BeginEdit(True)

                Else

                    Dgv_ProductosI.BeginEdit(True)

                End If

            End If

        Catch ex As Exception
            tb_buscar.Focus()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim success As Boolean = False

        If Tb_Descripcion.Text.Trim <> "" Then

            Dim index As Integer = 0
            Dim where As String = ""

            If DGV_Productos.Visible Then

                If DGV_Productos.SelectedRows.Count > 0 Then
                    index = DGV_Productos.SelectedRows(0).Index
                End If

                where = Sp_consultaProductosParaInventarioBindingSource.Filter
                Sp_consultaProductosParaInventarioBindingSource.Filter = "Cantidad2 IS NOT NULL"

            Else

                If Dgv_ProductosI.SelectedRows.Count > 0 Then
                    index = Dgv_ProductosI.SelectedRows(0).Index
                End If

                If Dgv_ProductosI.SelectedRows.Count > 0 Then
                    index = Dgv_ProductosI.SelectedRows(0).Index
                End If

                where = Sp_consultaProductosInvetarioBindingSource.Filter
                Sp_consultaProductosInvetarioBindingSource.Filter = "CantidadActual IS NOT NULL"

            End If

            If VarBoton = 1 Then

                DatosInventario.Inserta_Inventario(dtp_fecha.Value, tb_Usuario.Text, Tb_Descripcion.Text)

                For i As Integer = 0 To DGV_Productos.RowCount - 1

                    DatosInventario.insertar_producto_inventario(tb_codigo.Text, DGV_Productos.Rows(i).Cells(0).Value, _
                    DGV_Productos.Rows(i).Cells(4).Value, DGV_Productos.Rows(i).Cells(5).Value, DGV_Productos.Rows(i).Cells(7).Value, _
                    DGV_Productos.Rows(i).Cells(10).Value, DGV_Productos.Rows(i).Cells(14).Value)

                Next

                success = True

            ElseIf VarBoton = 2 Then

                DatosInventario.Modifica_Inventario(dtp_fecha.Value, tb_codigo.Text, Tb_Descripcion.Text)
                DatosInventario.elimina_producto_inventario(CInt(tb_codigo.Text))

                For i As Integer = 0 To Dgv_ProductosI.RowCount - 1

                    DatosInventario.insertar_producto_inventario(tb_codigo.Text, Dgv_ProductosI.Rows(i).Cells(0).Value, _
                    Dgv_ProductosI.Rows(i).Cells(4).Value, Dgv_ProductosI.Rows(i).Cells(5).Value, Dgv_ProductosI.Rows(i).Cells(7).Value, _
                    Dgv_ProductosI.Rows(i).Cells(9).Value, Dgv_ProductosI.Rows(i).Cells(13).Value)

                Next

                success = True

            End If

            If DGV_Productos.Visible Then

                Sp_consultaProductosParaInventarioBindingSource.Filter = where
                DGV_Productos.Rows(index).Cells(5).Selected = True
                DGV_Productos.FirstDisplayedScrollingRowIndex = index
                DGV_Productos.BeginEdit(True)

            Else

                Sp_consultaProductosInvetarioBindingSource.Filter = where
                Dgv_ProductosI.Rows(index).Cells(5).Selected = True
                Dgv_ProductosI.FirstDisplayedScrollingRowIndex = index
                Dgv_ProductosI.BeginEdit(True)

            End If

        Else

            MsgBox("Debe llenar los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

        End If

        If success Then

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Datos guardados", ToolTipIcon.Info)

            Tb_Descripcion.Clear()
            Tb_Descripcion.ReadOnly = True
            tb_codigo.Clear()
            tb_codigo.ReadOnly = True
            tb_Usuario.Clear()
            dtp_fecha.Value = Today
            ToolBar1.Enabled = True

            CheckBox1.Checked = False
            CheckBox1.Enabled = False

            DGV_Inventarios.Enabled = True

            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False

            Dgv_ProductosI.Visible = True
            DGV_Productos.Visible = False

            DGV_Productos.Columns(5).ReadOnly = True
            Dgv_ProductosI.Columns(5).ReadOnly = True
            DGV_Productos.Columns(7).ReadOnly = True
            Dgv_ProductosI.Columns(7).ReadOnly = True

            DomainUpDown1.Items.Clear()
            DomainUpDown1.Items.Add("Código Inventario")
            DomainUpDown1.Items.Add("Código Interno")
            DomainUpDown1.Items.Add("Descripción")
            DomainUpDown1.Items.Add("Código Fábrica")

            DomainUpDown1.SelectedIndex = 0

            Sp_consultaProductosParaInventarioBindingSource.Filter = "CodigoTramo = -1"
            Sp_consultaProductosInvetarioBindingSource.Filter = "CodigoTramo = -1"

            DatosInventario.consulta_inventario(DGV_Inventarios, "", 0)

            tb_buscar.Clear()
            tb_buscar.Focus()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Tb_Descripcion.Text.Trim <> "" Then

            Dim index As Integer = 0
            Dim where As String = ""

            If DGV_Productos.Visible Then

                If DGV_Productos.SelectedRows.Count > 0 Then
                    index = DGV_Productos.SelectedRows(0).Index
                End If

                where = Sp_consultaProductosParaInventarioBindingSource.Filter
                Sp_consultaProductosParaInventarioBindingSource.Filter = "Cantidad2 IS NOT NULL"

            Else

                If Dgv_ProductosI.SelectedRows.Count > 0 Then
                    index = Dgv_ProductosI.SelectedRows(0).Index
                End If

                index = Dgv_ProductosI.SelectedRows(0).Index
                where = Sp_consultaProductosInvetarioBindingSource.Filter
                Sp_consultaProductosInvetarioBindingSource.Filter = "CantidadActual IS NOT NULL"

            End If

            If VarBoton = 1 Then

                DatosInventario.Inserta_Inventario(dtp_fecha.Value, tb_Usuario.Text, Tb_Descripcion.Text)

                For i As Integer = 0 To DGV_Productos.RowCount - 1

                    DatosInventario.insertar_producto_inventario(tb_codigo.Text, DGV_Productos.Rows(i).Cells(0).Value, _
                    DGV_Productos.Rows(i).Cells(4).Value, DGV_Productos.Rows(i).Cells(5).Value, DGV_Productos.Rows(i).Cells(7).Value, _
                    DGV_Productos.Rows(i).Cells(10).Value, DGV_Productos.Rows(i).Cells(14).Value)

                Next

                VarBoton = 2

            ElseIf VarBoton = 2 Then

                DatosInventario.Modifica_Inventario(dtp_fecha.Value, tb_codigo.Text, Tb_Descripcion.Text)
                DatosInventario.elimina_producto_inventario(CInt(tb_codigo.Text))

                If DGV_Productos.Visible Then

                    For i As Integer = 0 To DGV_Productos.RowCount - 1

                        DatosInventario.insertar_producto_inventario(tb_codigo.Text, DGV_Productos.Rows(i).Cells(0).Value, _
                        DGV_Productos.Rows(i).Cells(4).Value, DGV_Productos.Rows(i).Cells(5).Value, DGV_Productos.Rows(i).Cells(7).Value, _
                        DGV_Productos.Rows(i).Cells(10).Value, DGV_Productos.Rows(i).Cells(14).Value)

                    Next

                ElseIf Dgv_ProductosI.Visible Then

                    For i As Integer = 0 To Dgv_ProductosI.RowCount - 1

                        DatosInventario.insertar_producto_inventario(tb_codigo.Text, Dgv_ProductosI.Rows(i).Cells(0).Value, _
                        Dgv_ProductosI.Rows(i).Cells(4).Value, Dgv_ProductosI.Rows(i).Cells(5).Value, Dgv_ProductosI.Rows(i).Cells(7).Value, _
                        Dgv_ProductosI.Rows(i).Cells(9).Value, Dgv_ProductosI.Rows(i).Cells(13).Value)

                    Next

                End If

            End If

            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Datos guardados", ToolTipIcon.Info)

            If DGV_Productos.Visible Then

                Sp_consultaProductosParaInventarioBindingSource.Filter = where
                DGV_Productos.Rows(index).Cells(5).Selected = True
                DGV_Productos.FirstDisplayedScrollingRowIndex = index
                DGV_Productos.BeginEdit(True)

            Else

                Sp_consultaProductosInvetarioBindingSource.Filter = where
                Dgv_ProductosI.Rows(index).Cells(5).Selected = True
                Dgv_ProductosI.FirstDisplayedScrollingRowIndex = index
                Dgv_ProductosI.BeginEdit(True)

            End If

        Else

            MsgBox("Debe llenar los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub chk_dif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dif.CheckedChanged

        sw = True
        CrearWhere()
        sw = False

    End Sub

    Private Sub DGV_Inventarios_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Inventarios.CellClick, DGV_Inventarios.KeyDown, DGV_Inventarios.KeyUp

        If DGV_Inventarios.SelectedRows.Count > 0 Then

            Me.Sp_consultaProductosInvetarioTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosInvetario, DGV_Inventarios.SelectedRows(0).Cells(0).Value, 0)
            Sp_consultaProductosInvetarioBindingSource.Filter = ""

            Tb_Descripcion.Text = DGV_Inventarios.SelectedRows(0).Cells(4).Value
            tb_Usuario.Text = DGV_Inventarios.SelectedRows(0).Cells(2).Value
            tb_codigo.Text = DGV_Inventarios.SelectedRows(0).Cells(0).Value
            dtp_fecha.Value = DGV_Inventarios.SelectedRows(0).Cells(1).Value

            Dgv_ProductosI.Columns(5).ReadOnly = True

            sw = True
            CrearWhere()
            sw = False

            DGV_Inventarios.Focus()

            If DGV_Inventarios.SelectedRows.Count > 0 Then

                DGV_Inventarios.SelectedRows(0).Cells(0).Selected = True

            End If

        End If

    End Sub

    Private Sub txt1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

            If DGV_Productos.Visible Then
                DGV_Productos.EndEdit()
                DGV_Productos.ClearSelection()
            End If

            If Dgv_ProductosI.Visible Then
                Dgv_ProductosI.EndEdit()
                Dgv_ProductosI.ClearSelection()
            End If

            tb_buscar.Focus()
            tb_buscar.SelectAll()

        ElseIf e.KeyCode = Keys.F1 Then

            If DGV_Productos.Visible Then

                If DGV_Productos.CurrentCell.ColumnIndex = 5 Then

                    DGV_Productos.CurrentRow.Cells(7).Selected = True
                    DGV_Productos.BeginEdit(True)

                Else

                    DGV_Productos.CurrentRow.Cells(5).Selected = True
                    DGV_Productos.BeginEdit(True)

                End If

            End If

            If Dgv_ProductosI.Visible Then
                If Dgv_ProductosI.CurrentCell.ColumnIndex = 5 Then

                    Dgv_ProductosI.CurrentRow.Cells(7).Selected = True
                    Dgv_ProductosI.BeginEdit(True)

                Else

                    Dgv_ProductosI.CurrentRow.Cells(5).Selected = True
                    Dgv_ProductosI.BeginEdit(True)

                End If
            End If

        End If

    End Sub

    Private Sub DGV_Inventarios_RowsAdded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Inventarios.RowsAdded, DGV_Inventarios.RowsRemoved

        Label5.Text = DGV_Inventarios.RowCount

    End Sub


    Private Sub chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exist.CheckedChanged
        CrearWhere()
    End Sub

End Class