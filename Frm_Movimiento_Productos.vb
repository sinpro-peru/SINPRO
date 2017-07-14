Public Class Frm_Movimiento_Productos

    Public User As String = ""
    Public f17 As Frm_Compras
    Public TotalBs As Double = 0
    Public TotalArt As Integer = 0

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_evaluar.Click

        If DateTimePicker1.Value < DateTimePicker2.Value Then

            If tb_meses.Text.Trim <> "" And tb_hasta.Text.Trim <> "" Then

                Me.Sp_movimiento_ProductosTableAdapter.Fill(Me.MELDataSet.sp_movimiento_Productos, CInt(tb_meses.Text), DateTimePicker1.Value, DateTimePicker2.Value, 0, CInt(tb_hasta.Text))

                Dim count As Object
                count = Me.MELDataSet.sp_movimiento_Productos.Compute("COUNT(CodigoInterno)", "")

                If count.GetType.ToString = "System.DBNull" Then
                    TotalArt = 0
                Else
                    TotalArt = CDbl(count)
                End If

                Dim sum As Object
                sum = Me.MELDataSet.sp_movimiento_Productos.Compute("SUM(Bs)", "")

                If sum.GetType.ToString = "System.DBNull" Then
                    TotalBs = 0
                Else
                    TotalBs = CDbl(sum)
                End If

                lbl_PorcArt.Text = "100,00%"
                lbl_porcBs.Text = "100,00%"
                lbl_totalArt.Text = count.ToString
                lbl_totalBs.Text = Format(TotalBs, "#,##0.00")

                CrearWhere()

            Else

                MsgBox("Debe llenar los todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else
            MsgBox("Perído de fechas no válido", MsgBoxStyle.Exclamation, "SINPRO")
        End If

        Dgv_Movimiento.ClearSelection()

    End Sub

    Private Sub tb_meses_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_meses.GotFocus
        tb_meses.SelectAll()
    End Sub

    Private Sub tb_meses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_meses.KeyPress

        If (sender Is Me.tb_meses) Then

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

    Private Sub Frm_Movimiento_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Empresa = 1 Then
            chk_fr.Visible = True
        End If

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DateTimePicker1.Value = DateAdd(DateInterval.Month, -3, Today)
        DateTimePicker2.Value = Today
        tb_meses.Text = 3
        tb_hasta.Text = 3

        Me.Tbl_ModeloTableAdapter.Fill(Me.MELDataSet.Tbl_Modelo, "", 0)
        cb_model.Text = "- Selecciona -"
        Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
        cb_marc.Text = "- Selecciona -"

    End Sub


    Private Sub DGV_Movimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Movimiento.CellDoubleClick

        If e.ColumnIndex = 0 Then

            If Dgv_Movimiento.SelectedRows.Count > 0 Then

                If Not IsNothing(Frm_Principal.f17) Then

                    If Not Frm_Principal.f17.IsDisposed Then

                        Frm_Principal.f17.WindowState = FormWindowState.Normal
                        Frm_Principal.f17.BringToFront()
                        Frm_Principal.f17.cb_buscar.SelectedIndex = 0
                        Frm_Principal.f17.chk_exacto.Checked = True
                        Frm_Principal.f17.tb_buscarcodigo.Text = Dgv_Movimiento.SelectedRows(0).Cells(0).Value
                        Frm_Principal.f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                        Frm_Principal.f17.DGV_Productos_CellContentClick(Frm_Principal.f17.DGV_Productos, New EventArgs)

                    Else

                        Frm_Principal.f17 = New Frm_Compras

                        For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                            If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                                Frm_Principal.f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                                cont = Frm_Principal.frm.Rows.Count
                            End If
                        Next

                        Frm_Principal.f17.Show()
                        Frm_Principal.f17.cb_buscar.SelectedIndex = 0
                        Frm_Principal.f17.chk_exacto.Checked = True
                        Frm_Principal.f17.tb_buscarcodigo.Text = Dgv_Movimiento.SelectedRows(0).Cells(0).Value
                        Frm_Principal.f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                        Frm_Principal.f17.DGV_Productos_CellContentClick(Frm_Principal.f17.DGV_Productos, New EventArgs)

                    End If

                Else

                    Frm_Principal.f17 = New Frm_Compras

                    For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                        If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                            Frm_Principal.f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                            cont = Frm_Principal.frm.Rows.Count
                        End If
                    Next

                    Frm_Principal.f17.Show()
                    Frm_Principal.f17.cb_buscar.SelectedIndex = 0
                    Frm_Principal.f17.chk_exacto.Checked = True
                    Frm_Principal.f17.tb_buscarcodigo.Text = Dgv_Movimiento.SelectedRows(0).Cells(0).Value
                    Frm_Principal.f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                    Frm_Principal.f17.DGV_Productos_CellContentClick(Frm_Principal.f17.DGV_Productos, New EventArgs)

                End If

            End If

        End If

    End Sub

    Private Sub tb_hasta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_hasta.GotFocus
        tb_hasta.SelectAll()
    End Sub

    Public Sub GridAExcel(ByVal ElGrid As DataGridView)

        Dim ColVisibles As Integer = 0
        Dim FilasVisibles As Integer = 0

        'Creamos las variables
        Dim total As Double = 0
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            If ElGrid.RowCount > 0 Then

                'Añadimos el Libro al programa, y la hoja al libro
                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()

                'ProgressBar1.Minimum = 0

                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = ElGrid.ColumnCount
                Dim NRow As Integer = ElGrid.RowCount

                'ProgressBar1.Maximum = NRow

                'Tituto

                exHoja.Range(exApp.Cells(1, 1), exApp.Cells(1, 6)).Merge(1)
                exHoja.Range(exApp.Cells(2, 1), exApp.Cells(2, 6)).Merge(1)
                exHoja.Range(exApp.Cells(3, 1), exApp.Cells(3, 6)).Merge(1)
                exHoja.Range(exApp.Cells(4, 1), exApp.Cells(4, 6)).Merge(1)
                exHoja.Range(exApp.Cells(6, 1), exApp.Cells(6, 5)).Merge(1)
                exHoja.Range(exApp.Cells(7, 1), exApp.Cells(7, 8)).Merge(1)
                exHoja.Range(exApp.Cells(1, 7), exApp.Cells(1, 9)).Merge(1)

                If My.Settings.Empresa = 2 Then

                    exHoja.Cells.Item(1, 1) = "Importadora Autopartes Global S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29580803-8"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)731.22.82"
                    exHoja.Cells.Item(4, 1) = "Email.: agsaonline@gmail.com"

                ElseIf My.Settings.Empresa = 3 Then

                    exHoja.Cells.Item(1, 1) = "Importadora Mil-26 S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29469954-5"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)642.11.15"
                    exHoja.Cells.Item(4, 1) = "Email.: distribuidoramil26@gmail.com"

                ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                    exHoja.Cells.Item(1, 1) = "Comercializadora BRWME, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-31135455-7"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                    exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

                End If

                exHoja.Rows.Item(1).Font.Bold = 1
                exHoja.Rows.Item(1).Font.italic = 1
                exHoja.Rows.Item(1).Font.name = "Arial"
                exHoja.Rows.Item(1).Font.size = 11
                exHoja.Rows.Item(1).HorizontalAlignment = 2
                exHoja.Rows.Item(2).Font.Bold = 1
                exHoja.Rows.Item(2).HorizontalAlignment = 2
                exHoja.Rows.Item(2).Font.name = "Arial"
                exHoja.Rows.Item(2).Font.size = 11
                exHoja.Rows.Item(2).Font.italic = 1
                exHoja.Rows.Item(3).Font.Bold = 1
                exHoja.Rows.Item(3).Font.italic = 1
                exHoja.Rows.Item(3).Font.name = "Arial"
                exHoja.Rows.Item(3).Font.size = 11
                exHoja.Rows.Item(3).HorizontalAlignment = 2
                exHoja.Rows.Item(4).Font.Bold = 1
                exHoja.Rows.Item(4).Font.italic = 1
                exHoja.Rows.Item(4).Font.name = "Arial"
                exHoja.Rows.Item(4).Font.size = 11

                Dim a As Integer = 1

                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                For i As Integer = 1 To NCol

                    If ElGrid.Columns(i - 1).Visible Then

                        exHoja.Cells.Item(10, a) = ElGrid.Columns(i - 1).HeaderText.ToString
                        ColVisibles = ColVisibles + 1
                        a = a + 1

                    End If

                Next

                exHoja.Range(exApp.Cells(11, 7), exApp.Cells(NRow + 10, 7)).Select()
                exApp.Selection.numberformat = "#.##0,00"
                exHoja.Cells(1, 1).select()
                Dim cont As Integer = 0
                Dim valor As Integer = 11
                Dim acum As Double = 0
                Dim acumFlete As Double = 0

                For Fila As Integer = 1 To NRow

                    If ElGrid.Rows(Fila - 1).Visible Then

                        FilasVisibles = FilasVisibles + 1

                        Dim b As Integer = 1

                        For cont5 As Integer = 0 To ElGrid.ColumnCount - 1

                            If ElGrid.Columns(cont5).Visible Then

                                exHoja.Cells.Item((valor), b).ClearFormats()
                                exHoja.Cells.Item((valor), b) = ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                If cont5 = 4 Or cont5 = 5 Or cont5 = 6 Or cont5 = 7 Or cont5 = 8 Or cont5 = 9 Then

                                    If cont5 = 6 Or cont5 = 7 Or cont5 = 8 Or cont5 = 9 Then
                                        exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).NumberFormat = "#.##0,00"
                                    End If

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 4

                                ElseIf cont5 = 0 Then

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                                Else

                                    exHoja.Cells.Item((valor), b) = exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).Text()
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                                End If

                                b = b + 1

                            End If

                        Next

                        cont = cont + 1
                        valor = valor + 1

                    End If

                    exHoja.Cells(Fila + 11, 7).select()

                    'ProgressBar1.Value = ProgressBar1.Value + 1

                Next

                If cont > 0 Then

                    exApp.Visible = True

                    'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                    exHoja.Rows.Item(10).font.name = "Arial"
                    exHoja.Rows.Item(10).font.size = 10
                    exHoja.Rows.Item(10).Font.Bold = 1
                    exHoja.Rows.Item(10).HorizontalAlignment = 3


                    '--------------------------------------- BORDE --------------------------------------------'
                    '                                                                                          '
                    exHoja.Range(exApp.Cells(10, 1), exApp.Cells((cont) + 10, ColVisibles)).BorderAround() '
                    '                                                                                          '
                    '--------------------------------------- BORDE --------------------------------------------'

                    exApp.Cells.Item((cont) + 11, 9) = "Total"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, ColVisibles)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, ColVisibles)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, ColVisibles)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, ColVisibles)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 8), exApp.Cells(cont + 11, 9)).BorderAround()
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 7)).NumberFormat = "#.##0,00"

                    exHoja.Cells.Item(cont + 11, 10) = lbl_totalBs.Text

                    If ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible Then
                        exHoja.Range(exApp.Cells(cont + 11, 3), exApp.Cells(cont + 11, 3)).NumberFormat = "0"
                    ElseIf ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible = False Then
                        exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, 2)).NumberFormat = "0"
                    End If

                End If

                exHoja.Range(exApp.Cells(10, 1), exApp.Cells(10, ColVisibles)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(10, 1), exApp.Cells(10, ColVisibles)).Font.Size = 10
                exHoja.Range(exApp.Cells(10, 1), exApp.Cells(10, ColVisibles)).Font.Bold = True
                exHoja.Range(exApp.Cells(10, 1), exApp.Cells(10, ColVisibles)).Font.Italic = True
                exHoja.Range(exApp.Cells(10, 1), exApp.Cells(10, ColVisibles)).BorderAround()


                exHoja.Range(exApp.Cells(11, 1), exApp.Cells((cont) + 10, ColVisibles)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(11, 1), exApp.Cells((cont) + 10, ColVisibles)).Font.Size = 9

                exHoja.Range(exApp.Cells(10, 2), exApp.Cells((cont) + 10, ColVisibles)).Columns.AutoFit()
                exHoja.Columns.AutoFit()
                exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

                'Aplicación visible
                exApp.Application.Visible = True

                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing


            Else

                exApp.Quit()
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
                MsgBox("La lista se encuentra vacia", MsgBoxStyle.Critical, "Error al exportar a Excel")

            End If

        Catch ex As Exception
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'ProgressBar1.Value = 0
        'Panel1.Visible = True
        GridAExcel(Dgv_Movimiento)
        'Panel1.Visible = False
    End Sub

    '------------------------------------------------------ COMBO MARCA ----------------------------'

    Private Sub cb_marc_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_marc.MouseClick
        If lb_marca.Visible = False Then
            lb_marca.Visible = True
            Me.SpconsultaMarcaBindingSource.RemoveFilter()
            lb_marca.SelectedValue = cb_marc.Text
        End If
    End Sub
    Private Sub cb_marc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marc.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_marca.Visible = False Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
                lb_marca.Visible = True
                lb_marca.SelectedValue = cb_marc.Text
            Else
                If lb_marca.Items.Count > 1 Then
                    lb_marca.Focus()
                    lb_marca.SelectedIndex = lb_marca.SelectedIndex + 1
                Else
                    cb_marc.SelectionStart = 0
                    cb_marc.SelectionLength = cb_marc.Text.Length
                    cb_marc.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_marca.Visible = True Then
                If lb_marca.Items.Count > 1 Then
                    lb_marca.Focus()
                    lb_marca.SelectedIndex = lb_marca.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_marca.Visible Then
            lb_marca.Visible = False
            If lb_marca.Items.Count > 0 Then
                cb_marc.Text = lb_marca.SelectedItem(0).ToString
                CrearWhere()
                lb_marca.SelectedIndex = 0
            Else
                cb_marc.Text = ""
            End If
            cb_marc.SelectionStart = cb_marc.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_marc.Text.Length <= 1 Or cb_marc.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text.Substring(0, cb_marc.Text.Length - 1) & "%'"
            End If
        End If
    End Sub
    Private Sub cb_marc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_marc.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_marc.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & e.KeyChar & "%'"
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text & e.KeyChar & "%'"
            End If

            If lb_marca.Items.Count = 0 Then
                e.Handled = True
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text & "%'"
            Else
                e.Handled = False
                lb_marca.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_marca.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_marc_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marc.GotFocus
        If cb_marc.Text = "- Selecciona -" Then
            cb_marc.Text = ""
            Me.SpconsultaMarcaBindingSource.Filter = "Marca  LIKE '%" & cb_marc.Text & "%'"
            lb_marca.Visible = True
        End If
    End Sub
    Public Sub lb_marca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_marca.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_marca.SelectedIndex = 1 Then
                cb_marc.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_marca.Visible = False
            cb_marc.Text = lb_marca.SelectedItem(0).ToString
            CrearWhere()
            lb_marca.SelectedIndex = 0
            cb_marc.Focus()
            cb_marc.SelectionStart = cb_marc.Text.Length
        End If
    End Sub
    Private Sub lb_marca_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_marca.MouseClick
        lb_marca.Visible = False
        cb_marc.Text = lb_marca.SelectedItem(0).ToString
        CrearWhere()
        lb_marca.SelectedIndex = 0
        cb_marc.Focus()
        cb_marc.SelectionStart = cb_marc.Text.Length
    End Sub

    '--------------fin combo


    '------------------------------------------------------ COMBO MODELO -------------------------'

    Private Sub cb_model_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_model.MouseClick
        If lb_modelo.Visible = False Then
            lb_modelo.Visible = True
            Me.TblModeloBindingSource.RemoveFilter()
            If cb_marc.Text = "- Selecciona -" Then
                Me.TblModeloBindingSource.RemoveFilter()
            Else
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
            End If


            lb_modelo.SelectedValue = cb_model.Text
        End If
    End Sub
    Private Sub cb_model_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_model.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_modelo.Visible = False Then
                Me.TblModeloBindingSource.RemoveFilter()
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                lb_modelo.Visible = True
                lb_modelo.SelectedValue = cb_model.Text
            Else
                If lb_modelo.Items.Count > 1 Then
                    lb_modelo.Focus()
                    lb_modelo.SelectedIndex = lb_modelo.SelectedIndex + 1
                Else
                    cb_model.SelectionStart = 0
                    cb_model.SelectionLength = cb_model.Text.Length
                    cb_model.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_modelo.Visible = True Then
                If lb_modelo.Items.Count > 1 Then
                    lb_modelo.Focus()
                    lb_modelo.SelectedIndex = lb_modelo.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_modelo.Visible Then
            lb_modelo.Visible = False
            If lb_modelo.Items.Count > 0 Then
                cb_model.Text = lb_modelo.SelectedItem(0).ToString
                cb_model.Tag = lb_modelo.SelectedItem(1).ToString
                CrearWhere()
                If Chk_Marca.Checked Then
                    cb_marc.Enabled = False
                End If
                lb_modelo.SelectedIndex = 0
            Else
                cb_model.Text = ""
            End If
            cb_model.SelectionStart = cb_model.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_model.Text.Length <= 1 Or cb_model.SelectedText <> "" Then
                If cb_marc.Text = "- Selecciona -" Then
                    Me.TblModeloBindingSource.RemoveFilter()
                Else
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                End If
            Else
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text.Substring(0, cb_model.Text.Length - 1) & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text.Substring(0, cb_model.Text.Length - 1) & "%'"
                End If

            End If
        End If
    End Sub
    Private Sub cb_model_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_model.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_model.SelectedText <> "" Then
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & e.KeyChar & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & e.KeyChar & "%'"
                End If
            Else
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & e.KeyChar & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text & e.KeyChar & "%'"
                End If
            End If
            If lb_modelo.Items.Count = 0 Then
                e.Handled = True
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text & "%'"
                End If
            Else
                e.Handled = False
                lb_modelo.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_modelo.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_model_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_model.GotFocus
        If cb_model.Text = "- Selecciona -" Then
            cb_model.Text = ""
            If Chk_Marca.Checked Then
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo  LIKE '%" & cb_model.Text & "%'"
            Else
                Me.TblModeloBindingSource.Filter = "Modelo  LIKE '%" & cb_model.Text & "%'"
            End If
            lb_modelo.Visible = True
        End If
    End Sub
    Public Sub lb_modelo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_modelo.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_modelo.SelectedIndex = 1 Then
                cb_model.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_modelo.Visible = False
            cb_model.Text = lb_modelo.SelectedItem(0).ToString
            cb_model.Tag = lb_modelo.SelectedItem(1).ToString
            CrearWhere()
            If Chk_Marca.Checked Then
                cb_marc.Enabled = False
            End If
            lb_modelo.SelectedIndex = 0
            cb_model.Focus()
            cb_model.SelectionStart = cb_model.Text.Length
        End If
    End Sub
    Private Sub lb_modelo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_modelo.MouseClick
        lb_modelo.Visible = False
        cb_model.Text = lb_modelo.SelectedItem(0).ToString
        cb_model.Tag = lb_modelo.SelectedItem(1).ToString
        CrearWhere()
        If Chk_Marca.Checked Then
            cb_marc.Enabled = False
        End If
        lb_modelo.SelectedIndex = 0
        cb_model.Focus()
        cb_model.SelectionStart = cb_model.Text.Length
    End Sub

    '--------------fin combo

    Private Sub Chk_Marca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Marca.CheckedChanged
        If Chk_Marca.Checked Then
            If Chk_Modelo.Checked Then
                If cb_model.Text <> "" Then
                    cb_marc.Text = cb_model.Tag
                End If
            Else
                cb_marc.Enabled = True
                cb_marc.Focus()
            End If
        Else
            cb_marc.Enabled = False
            cb_marc.Text = "- Selecciona -"
            lb_marca.Visible = False
            CrearWhere()
        End If
    End Sub

    Private Sub Chk_Modelo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Modelo.CheckedChanged
        If Chk_Modelo.Checked Then
            cb_model.Enabled = True
            cb_model.Focus()
        Else
            cb_model.Enabled = False
            cb_model.Text = "- Selecciona -"
            lb_modelo.Visible = False
            CrearWhere()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bs.CheckedChanged

        If chk_bs.Checked Then

            tb_bs.Enabled = True
            tb_bs.Clear()
            tb_bs.Focus()

        Else

            tb_bs.Enabled = False
            tb_bs.Clear()
            CrearWhere()

        End If

    End Sub

    Private Sub chk_top_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_top.CheckedChanged

        If chk_top.Checked Then

            tb_top.Enabled = True
            tb_top.Clear()
            tb_top.Focus()

        Else

            tb_top.Enabled = False
            tb_top.Clear()
            CrearWhere()

        End If

    End Sub

    Private Sub tb_top_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_top.KeyDown

        If e.KeyCode = Keys.Enter Then
            CrearWhere()
        End If

    End Sub

    Private Sub tb_top_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_top.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'muestra_label(sender, 1)
        Else
            e.Handled = True
            'muestra_label(sender, 0)
            'Me.Label22.Text = "      Ingrese sólo números"
        End If

    End Sub

    Private Sub tb_bs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_bs.KeyDown

        If e.KeyCode = Keys.Enter Then

            CrearWhere()

        End If

    End Sub

    Private Sub tb_bs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_bs.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
            'muestra_label(sender, 1)
        Else
            e.Handled = True
            'muestra_label(sender, 0)
            'Me.Label22.Text = "      Ingrese sólo números"
        End If

    End Sub

    Private Sub tb_bs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_bs.LostFocus
        tb_bs.Text = tb_bs.Text.Replace(".", ",")
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""
        Dim top As Boolean = False
        Dim art As Integer = 0
        Dim bs As Double = 0
        Dim count As Object
        Dim sum As Object

        If Chk_Marca.Checked And cb_marc.Text <> "" Then
            where = where + y + "Marca LIKE '%" & cb_marc.Text & "%'"
            y = " and "
        End If

        If Chk_Modelo.Checked And cb_model.Text <> "" Then
            where = where + y + "(substring(Modelo,1," & cb_model.Text.Length + 1 & ") = '" & cb_model.Text & " ' or Modelo LIKE '%/ " & cb_model.Text & "%')"
            y = " and "
        End If

        If chk_bs.Checked And chk_bs.Text <> "" Then
            where = where + y + "Bs > " & tb_bs.Text
            y = " and "
        End If

        If chk_fr.Checked = False And chk_fr.Visible Then
            where = where + y + "Marca NOT LIKE '%Fiat%' AND Marca NOT LIKE '%Renault%'"
            y = " and "
        End If

        Sp_movimiento_ProductosBindingSource.Filter = where


        If chk_top.Checked And tb_top.Text <> "" Then

            Me.Dgv_Movimiento.CurrentCell = Nothing

            For cont As Integer = 0 To Dgv_Movimiento.RowCount - 1

                If cont < CInt(tb_top.Text) Then

                    Dgv_Movimiento.Rows(cont).Visible = True
                    art = art + 1
                    bs = bs + CDbl(Dgv_Movimiento.Rows(cont).Cells(9).Value)

                Else

                    Dgv_Movimiento.Rows(cont).Visible = False

                End If

            Next

            Dgv_Movimiento.Columns(10).Visible = False
            Dgv_Movimiento.Columns(11).Visible = False
            top = True

        Else

            For cont As Integer = 0 To Dgv_Movimiento.RowCount - 1

                Dgv_Movimiento.Rows(cont).Visible = True

            Next

        End If

        If top = False Then

            count = Me.MELDataSet.sp_movimiento_Productos.Compute("COUNT(CodigoInterno)", where)

            If count.GetType.ToString = "System.DBNull" Then
                art = 0
            Else
                art = CDbl(count)
            End If

            sum = Me.MELDataSet.sp_movimiento_Productos.Compute("SUM(Bs)", where)

            If sum.GetType.ToString = "System.DBNull" Then
                bs = 0
            Else
                bs = CDbl(sum)
            End If

        End If

        

        lbl_PorcArt.Text = Format(((art / TotalArt)), "#,##0.00%")
        lbl_porcBs.Text = Format(((bs / TotalBs)), "#,##0.00%")
        lbl_totalArt.Text = art.ToString
        lbl_totalBs.Text = Format(bs, "#,##0.00")

        Dgv_Movimiento.ClearSelection()

    End Sub

    Private Sub chk_fr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fr.CheckedChanged
        CrearWhere()
    End Sub
End Class