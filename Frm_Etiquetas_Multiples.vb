Public Class Frm_Etiquetas_Multiples

    Public User As String

    Private Sub Frm_Etiquetas_Multiples_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_ubicacion_productos' table. You can move, or remove it, as needed.
        Me.Sp_consulta_ubicacion_productosTableAdapter.Fill(Me.MELDataSet.sp_consulta_ubicacion_productos)
        DomainUpDown1.SelectedIndex = 0
        DGV_Productos.ClearSelection()

        tb_buscar.Focus()
        tb_buscar.SelectAll()

    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DomainUpDown1.SelectedIndex = 0 Then

            where = where + y + "CodigoProducto LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 1 Then

            where = where + y + "Nombre LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 2 Then

            where = where + y + "codigoF LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 3 Then

            where = where + y + "Marca LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 4 Then

            where = where + y + "Modelo LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        End If

        If chk_exist.Checked Then

            where = where + y + "aqui2 > 0"
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

        Sp_consulta_ubicacion_productosBindingSource.Filter = where
        DGV_Productos.ClearSelection()

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

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged
        CrearWhere()
    End Sub

    Private Sub DomainUpDown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        tb_buscar.Focus()
        tb_buscar.SelectAll()
        CrearWhere()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim frm As New R_Etiqueta

        frm.tipo = 2
        frm.dgv = DGV_Productos

        frm.Show()
        Me.Close()

    End Sub

    Private Sub chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exist.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DGV_Productos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellClick
        If DGV_Productos.SelectedRows.Count > 0 Then
            DGV_Productos.SelectedRows(0).Cells(7).Selected = True
            DGV_Productos.BeginEdit(True)
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Productos.EditingControlShowing
        If Me.DGV_Productos.CurrentCell.ColumnIndex = 7 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        End If
    End Sub

    Private Sub DGV_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Productos.KeyDown
        If e.KeyCode = Keys.Enter Then
            DGV_Productos.SelectedRows(0).Cells(7).Selected = True
            DGV_Productos.BeginEdit(True)
        End If
    End Sub

    Private Sub DGV_Productos_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGV_Productos.Scroll
        If DGV_Productos.SelectedRows.Count > 0 Then
            DGV_Productos.SelectedRows(0).Cells(7).Selected = True
            DGV_Productos.BeginEdit(True)
        End If
    End Sub

End Class
