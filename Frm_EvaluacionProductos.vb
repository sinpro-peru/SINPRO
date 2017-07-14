Public Class Frm_EvaluacionProductos

    Public enter1 As Boolean = False
    Public down As Boolean = False
    Public up As Boolean = False
    Public selected As Boolean = False
    Public texto As String = ""
    Public unidades As Integer = 0

    Private Sub Frm_EvaluacionProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaProductosEvaluacionDSS' table. You can move, or remove it, as needed.
        Me.Sp_consultaProductosEvaluacionDSSTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosEvaluacionDSS)

        Datos.consultaLogo(PictureBox3)
        Datos.consultaLogo(PictureBox1)
        RadioButton4.Checked = True
        DatosDSS.TotalesInventario(UserControl51.Chart1, 0, 0, "", unidades)
        DatosDSS.GraficoCircularTotalPorMarcas(UserControl41.Chart1, 0)

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
                            Dim cont As Integer = 0
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

    'Private Sub cb_client_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marca.GotFocus

    '    cb_marca.DroppedDown = True
    '    cb_marca.DropDownHeight = 110

    'End Sub

    Private Sub cb_client_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marca.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If cb_marca.SelectedIndex = -1 Then

                cb_marca.Text = cb_marca.SelectedText
                'DatosCompras.Llenar_Marcas(cb_marca, 0, "")

            Else
                cb_marca.Text = cb_marca.SelectedText
                'DatosCompras.Llenar_Marcas(cb_marca, 0, "")

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

            End If

            cb_marca.SelectionStart = Me.cb_marca.Text.Length

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            cb_marca.Enabled = RadioButton1.Checked
            DatosCompras.Llenar_Marcas(cb_marca, 0, "")
            cb_marca.Focus()
        Else
            cb_marca.Text = ""
            cb_marca.Enabled = RadioButton1.Checked
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            tb_proveedor.Enabled = RadioButton2.Checked
            DatosPedidosCompras.consulta_Proveedor(tb_proveedor)
            tb_proveedor.Focus()

        Else
            tb_proveedor.Text = ""
            tb_proveedor.Enabled = RadioButton2.Checked
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            cb_grupo.Enabled = RadioButton3.Checked
            DatosCompras.Llenar_Grupos(cb_grupo, 0, "")
            cb_grupo.Focus()
        Else
            cb_grupo.Text = ""
            cb_grupo.Enabled = RadioButton3.Checked
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
                            Dim cont As Integer = 0
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

    'Private Sub cb_grupo_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grupo.GotFocus

    '    cb_grupo.DroppedDown = True
    '    cb_grupo.DropDownHeight = 110

    'End Sub

    Private Sub cb_grupo_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_grupo.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If cb_grupo.SelectedIndex = -1 Then

                cb_grupo.Text = ""
                'DatosCompras.Llenar_grupos(cb_grupo, 0, "")

            Else
                cb_grupo.Text = cb_grupo.SelectedText
                'DatosCompras.Llenar_grupos(cb_grupo, 0, "")

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

    Private Sub cb_grupo_click2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grupo.SelectionChangeCommitted

        If Not cb_grupo.SelectedIndex = -1 Then

            'If enter1 = True Then

            cb_grupo.Text = cb_grupo.Items.Item(cb_grupo.SelectedIndex).Name
            cb_grupo.SelectionStart = Me.cb_grupo.Text.Length

            '        End If


        End If

    End Sub

    Private Sub tb_proveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_proveedor.Click
        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, "", Me.texto)
    End Sub

    Private Sub tb_proveedor_SelectedIndexC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.TextChanged
        If enter1 = False Then
            If down = False And up = False Then
                If selected = False Then
                    If tb_proveedor.Text <> "" Then
                        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, tb_proveedor.Text, Me.texto)
                        If tb_proveedor.SelectedIndex <> -1 Then
                            Dim cont As Integer = 0
                        End If
                        tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
                        tb_proveedor.Refresh()
                        tb_proveedor.DroppedDown = True
                    Else
                        DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, tb_proveedor.Text, Me.texto)
                        tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
                        tb_proveedor.Refresh()
                        tb_proveedor.DroppedDown = True
                    End If
                    enter1 = True
                End If
            End If

        End If

    End Sub

    'Private Sub tb_proveedor_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.GotFocus

    '    tb_proveedor.DroppedDown = True
    '    tb_proveedor.DropDownHeight = 110

    'End Sub

    Private Sub tb_proveedor_onKeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_proveedor.KeyDown

        Dim cont As Integer = 0

        If e.KeyCode = Keys.Enter Then
            enter1 = True
            If tb_proveedor.SelectedIndex = -1 Then

                tb_proveedor.Text = tb_proveedor.SelectedText
                'DatosCompras.Llenar_grupos(tb_proveedor, 0, "")

            Else
                tb_proveedor.Text = tb_proveedor.SelectedText
                'DatosCompras.Llenar_grupos(tb_proveedor, 0, "")

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
            DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, textoo, Me.texto)
            tb_proveedor.DroppedDown = True
            If tb_proveedor.SelectedIndex = -1 Then
                tb_proveedor.SelectionStart = tb_proveedor.Text.Length
            End If
        Else
            If Not tb_proveedor.SelectedIndex = -1 Then
                Me.tb_proveedor.Text = ""
                DatosPedidosCompras.consulta_ProveedorLike(Me.tb_proveedor, "", Me.texto)
                tb_proveedor.DroppedDown = True
            End If
            enter1 = False
            down = False
            up = False
            selected = False
            tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length
        End If

    End Sub

    Private Sub tb_proveedor_click2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.SelectionChangeCommitted

        If Not tb_proveedor.SelectedIndex = -1 Then

            If enter1 = True Then

                tb_proveedor.Text = tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).Name

            End If

            tb_proveedor.SelectionStart = Me.tb_proveedor.Text.Length

        End If

    End Sub

    Private Sub bt_evaluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluar.Click

        If RadioButton4.Checked Then
            DatosDSS.TotalesInventario(UserControl51.Chart1, 0, 0, "", unidades)
            DatosDSS.GraficoCircularTotalPorMarcas(UserControl41.Chart1, CInt(tb_porDebajo.Text))
            'DatosDSS.MovimientoInventario(UserControl52.Chart1, 0, "", CInt(TextBox3.Text), lentos, Medios, Rapidos, "")
        ElseIf RadioButton1.Checked Then
            DatosDSS.TotalesInventario(UserControl51.Chart1, 1, 0, cb_marca.Text, unidades)
            DatosDSS.GraficoCircularTotalPorMarcas2(UserControl41.Chart1, CInt(tb_porDebajo.Text), cb_marca.Text)
            'DatosDSS.MovimientoInventario(UserControl52.Chart1, 1, cb_marca.Text, CInt(TextBox3.Text), lentos, Medios, Rapidos, cb_marca.Text)
        ElseIf RadioButton3.Checked Then
            DatosDSS.TotalesInventario(UserControl51.Chart1, 2, CInt(cb_grupo.Items.Item(cb_grupo.SelectedIndex).code), cb_grupo.Text, unidades)
            DatosDSS.GraficoCircularTotalPorGrupos(UserControl41.Chart1, CInt(tb_porDebajo.Text), CInt(cb_grupo.Items.Item(cb_grupo.SelectedIndex).code), cb_grupo.Text)
            'DatosDSS.MovimientoInventario(UserControl52.Chart1, 3, cb_grupo.Items.Item(cb_grupo.SelectedIndex).code.ToString, CInt(TextBox3.Text), lentos, Medios, Rapidos, cb_grupo.Text)
        ElseIf RadioButton2.Checked Then
            DatosDSS.TotalesInventario(UserControl51.Chart1, 3, CInt(tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).code), tb_proveedor.Text, unidades)
            DatosDSS.GraficoCircularTotalPorProveedor(UserControl41.Chart1, CInt(tb_porDebajo.Text), CInt(tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).code), tb_proveedor.Text)
            'DatosDSS.MovimientoInventario(UserControl52.Chart1, 2, tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).code.ToString, CInt(TextBox3.Text), lentos, Medios, Rapidos, tb_proveedor.Text)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        tb_porDebajo.Enabled = CheckBox1.Checked

        If CheckBox1.Checked Then
            tb_porDebajo.Focus()
            tb_porDebajo.SelectAll()
        Else
            tb_porDebajo.Text = 0
            If RadioButton4.Checked Then
                DatosDSS.GraficoCircularTotalPorMarcas(UserControl41.Chart1, 0)
            ElseIf RadioButton1.Checked Then
                DatosDSS.GraficoCircularTotalPorMarcas2(UserControl41.Chart1, 0, cb_marca.Text)
            ElseIf RadioButton3.Checked Then
                DatosDSS.GraficoCircularTotalPorGrupos(UserControl41.Chart1, 0, CInt(cb_grupo.Items.Item(cb_grupo.SelectedIndex).code), cb_grupo.Text)
            ElseIf RadioButton2.Checked Then
                DatosDSS.GraficoCircularTotalPorProveedor(UserControl41.Chart1, 0, CInt(tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).code), tb_proveedor.Text)
            End If
        End If


    End Sub

    Private Sub tb_porDebajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_porDebajo.GotFocus
        tb_porDebajo.SelectAll()
    End Sub

    Private Sub tb_porcDebajo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_porDebajo.KeyDown
        If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) Then

            If CInt(tb_porDebajo.Text) <= 100 Then

                If RadioButton4.Checked Then
                    DatosDSS.GraficoCircularTotalPorMarcas(UserControl41.Chart1, CInt(tb_porDebajo.Text))
                ElseIf RadioButton1.Checked Then
                    DatosDSS.GraficoCircularTotalPorMarcas2(UserControl41.Chart1, CInt(tb_porDebajo.Text), cb_marca.Text)
                ElseIf RadioButton3.Checked Then
                    DatosDSS.GraficoCircularTotalPorGrupos(UserControl41.Chart1, CInt(tb_porDebajo.Text), CInt(cb_grupo.Items.Item(cb_grupo.SelectedIndex).code), cb_grupo.Text)
                ElseIf RadioButton2.Checked Then
                    DatosDSS.GraficoCircularTotalPorProveedor(UserControl41.Chart1, CInt(tb_porDebajo.Text), CInt(tb_proveedor.Items.Item(tb_proveedor.SelectedIndex).code), tb_proveedor.Text)
                End If

            Else

                MsgBox("El valor debe estar entre 0 y 100", MsgBoxStyle.Exclamation, "Error")
                tb_porDebajo.Focus()
                tb_porDebajo.SelectAll()

            End If

        End If
    End Sub

    Private Sub tb_porcDebajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_porDebajo.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        Label15.Text = "--"
        Label16.Text = "--"
        Label20.Text = "--"
        Label26.Text = "--"
        UserControl61.Chart1.Series(0).Points.Clear()
        UserControl61.Chart1.Series(1).Points.Clear()

        UserControl61.Chart1.Series(0).LegendText = "Ventas"
        UserControl61.Chart1.Series(1).LegendText = "Existencia"

        'DatosDSS.lv_Producto(DGV_Productos, tb_buscarcodigo.Text, DomainUpDown1.SelectedIndex)
        CrearWhere()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedIndex = 0 Then

            RadioButton4.Checked = True
            DatosDSS.TotalesInventario(UserControl51.Chart1, 0, 0, "", unidades)
            DatosDSS.GraficoCircularTotalPorMarcas(UserControl41.Chart1, 0)

        ElseIf TabControl1.SelectedIndex = 1 Then

            DomainUpDown1.SelectedIndex = 0
            cb_meses.SelectedIndex = 1
            'DatosDSS.lv_Producto(DGV_Productos, "", 0)
            Sp_consultaProductosEvaluacionDSSTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosEvaluacionDSS)
            CrearWhere()
            If DGV_Productos.SelectedRows.Count > 0 Then
                DGV_Productos.Rows(0).Cells(0).Selected = True
                DatosDSS.Indicadores(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label16.Text, Label15.Text, Label20.Text, Label22.Text, Label24.Text, unidades)
            End If

            cb_alfa.SelectedIndex = 6
            Label15.Text = "--"
            Label16.Text = "--"
            Label20.Text = "--"
            Label26.Text = "--"
            UserControl61.Chart1.Series(0).Points.Clear()
            UserControl61.Chart1.Series(1).Points.Clear()

            UserControl61.Chart1.Series(0).LegendText = "Ventas"
            UserControl61.Chart1.Series(1).LegendText = "Existencia"

            DGV_Productos.ClearSelection()
            tb_buscarcodigo.Clear()
            tb_buscarcodigo.Focus()

        End If

    End Sub

    Private Sub DGV_Productos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Productos.CellClick, DGV_Productos.KeyUp, DGV_Productos.KeyDown

        If DGV_Productos.SelectedRows.Count > 0 Then

            DatosDSS.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, UserControl61.Chart1, CInt(cb_meses.Text), CInt(DGV_Productos.SelectedRows(0).Cells(3).Value))
            DatosDSS.Indicadores(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label16.Text, Label15.Text, Label20.Text, Label22.Text, Label24.Text, unidades)
            DatosDSS.Pronostico(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label26.Text, CDbl(cb_alfa.Text))

        End If

    End Sub

    Private Sub cb_meses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_meses.SelectedIndexChanged

        If DGV_Productos.SelectedRows.Count > 0 Then

            DatosDSS.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, UserControl61.Chart1, CInt(cb_meses.Text), CInt(DGV_Productos.SelectedRows(0).Cells(3).Value))
            DatosDSS.Indicadores(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label16.Text, Label15.Text, Label20.Text, Label22.Text, Label24.Text, unidades)
            If cb_alfa.Text = "" Then
                cb_alfa.Text = 0
            End If
            DatosDSS.Pronostico(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label26.Text, CDbl(cb_alfa.Text))

        End If

    End Sub

    Private Sub tb_buscar_Key(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then

            If DGV_Productos.Rows.Count > 0 Then

                Me.DGV_Productos.Rows(0).Cells(0).Selected = True
                DGV_Productos.Focus()
                DatosDSS.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, UserControl61.Chart1, CInt(cb_meses.Text), CInt(DGV_Productos.SelectedRows(0).Cells(3).Value))
                DatosDSS.Indicadores(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label16.Text, Label15.Text, Label20.Text, Label22.Text, Label24.Text, unidades)
                DatosDSS.Pronostico(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label26.Text, CDbl(cb_alfa.Text))

            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_alfa.SelectedIndexChanged
        If DGV_Productos.SelectedRows.Count > 0 Then

            DatosDSS.Pronostico(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, CInt(cb_meses.Text), Label26.Text, CDbl(cb_alfa.Text))

        End If
    End Sub


    Public Sub CrearWhere()

        'Sp_infoGeneralComprasBindingSource.ResetBindings(True)
        Dim where As String = ""
        Dim y As String = ""

        If tb_buscarcodigo.Text <> "" Then

            If DomainUpDown1.SelectedIndex = 0 Then

                where = where + "CodigoInterno LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 2 Then

                where = where + "CodigoFabrica LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 1 Then

                where = where + "Nombre LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 3 Then

                where = where + "Modelo LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            End If

        End If

        Me.SpconsultaProductosEvaluacionDSSBindingSource.Filter = where

        DGV_Productos.ClearSelection()

    End Sub

End Class