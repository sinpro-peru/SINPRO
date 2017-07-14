Public Class Frm_Ajustes

    Dim varboton As Integer = 0
    Dim contador As Integer = 0
    Dim eliminados As New DataTable
    Dim sw As Boolean = False
    Dim index As Integer
    'Private WithEvents DGV_Inventario As New MyDataGridView2
    ' Dim tabla As New DataTable
    Dim cant As Integer = 0
    Dim index2 As Integer = 0
    Dim w As Boolean
    Dim e As Boolean
    Dim sel As Boolean = False

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Try

            If e.Button Is Me.bt_salir Then
                varboton = 3
                tb_buscar.Clear()
                tb_codigo.Clear()
                Tb_Descripcion.Clear()
                tb_Usuario.Clear()
                Tb_Descripcion.ReadOnly = True
                dtp_fecha.Value = Today
                dtp_fecha.Enabled = False
                Button1.Hide()
                Button2.Hide()
                'DatosAjustes.DVG_Ajustes(DGV_Ajustes)
                'DGV_Inventario.Rows.Clear()
                DGV_Inventario.Visible = False
                DGV_Asociados.Rows.Clear()
                DGV_Ajustes.ClearSelection()
                Me.Close()

            ElseIf e.Button Is Me.bt_nuevo Then
                varboton = 0
                GroupBox3.Location = New System.Drawing.Point(256, 407)
                GroupBox3.Size = New System.Drawing.Size(774, 259)
                DGV_Asociados.Size = New System.Drawing.Size(764, 230)
                GroupBox3.BringToFront()
                DGV_Ajustes.ClearSelection()
                chk_exist.Enabled = True
                chk_exist.BringToFront()
                DatosAjustes.ProximoAjuste(tb_codigo.Text)
                ToolBar1.Enabled = False
                Panel1.Enabled = True
                Panel2.Enabled = True
                DGV_Ajustes.Enabled = False
                Button1.Show()
                Button2.Show()
                DGV_Asociados.Rows.Clear()
                Tb_Descripcion.Clear()
                DGV_Inventario.ReadOnly = False
                DGV_Asociados.AllowUserToDeleteRows = True
                tb_Usuario.Clear()
                dtp_fecha.Value = Today
                Tb_Descripcion.Focus()
                Tb_Descripcion.ReadOnly = False
                dtp_fecha.Enabled = True
                DomainUpDown1.Items.Clear()
                DomainUpDown1.Items.Add("Código Producto")
                DomainUpDown1.Items.Add("Descripción")
                DomainUpDown1.Items.Add("Modelo")
                DomainUpDown1.Items.Add("Código Fábrica")
                DomainUpDown1.Text = "Código Producto"

                'TODO: This line of code loads data into the 'MELDataSet.sp_ConsultaProductosAjusteInv' table. You can move, or remove it, as needed.
                Me.Sp_ConsultaProductosAjusteInvTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosAjusteInv)
                Me.Sp_ConsultaProductosAjusteInvBindingSource.Filter = ""

                If contador = 0 Then
                    DGV_Inventario.Columns(0).HeaderText = "Cant."
                    DGV_Inventario.Columns(1).HeaderText = "Observación"
                    DGV_Inventario.Columns(2).HeaderText = "Código I."
                    DGV_Inventario.Columns(3).HeaderText = "Descripción"
                    DGV_Inventario.Columns(4).HeaderText = "Exist."
                    DGV_Inventario.Columns(5).HeaderText = "Modelo"
                    DGV_Inventario.Columns(6).HeaderText = "Ubic."
                    DGV_Inventario.Columns(7).HeaderText = "Tramo"
                    DGV_Inventario.Columns(8).HeaderText = "Precio"
                    DGV_Inventario.BackgroundColor = Color.WhiteSmoke
                    DGV_Inventario.Columns(0).Width = 45
                    DGV_Inventario.Columns(1).Width = 168
                    DGV_Inventario.Columns(2).Width = 90
                    DGV_Inventario.Columns(3).Width = 210
                    DGV_Inventario.Columns(4).Width = 45
                    DGV_Inventario.Columns(5).Width = 117
                    DGV_Inventario.Columns(6).Width = 65
                    DGV_Inventario.Columns(7).Width = 100
                    DGV_Inventario.Columns(7).Visible = False
                    DGV_Inventario.Columns(0).ReadOnly = False
                    DGV_Inventario.Columns(1).ReadOnly = False
                    DGV_Inventario.Columns(2).ReadOnly = True
                    DGV_Inventario.Columns(3).ReadOnly = True
                    DGV_Inventario.Columns(4).ReadOnly = True
                    DGV_Inventario.Columns(6).ReadOnly = True
                    DGV_Inventario.Columns(7).ReadOnly = True
                    DGV_Inventario.Columns(7).Visible = False
                    DGV_Inventario.Columns(8).Visible = False
                    DGV_Inventario.Columns(9).Visible = False
                    DGV_Inventario.Columns(10).Visible = False
                    DGV_Inventario.Columns(11).Visible = False
                    contador = 1
                End If
                

                tb_Usuario.Text = Frm_Login.user
                DGV_Inventario.Visible = True
                'DGV_Asociados.Enabled = True
                DGV_Asociados.ReadOnly = True
                DGV_Asociados.AllowUserToDeleteRows = True
                DGV_Inventario.ClearSelection()
                Tb_Descripcion.Focus()

            ElseIf e.Button Is Me.bt_modificar Then
                varboton = 1
                If DGV_Ajustes.SelectedRows.Count = 0 Then
                    MsgBox("Debe seleccionar un ajuste para modificar", MsgBoxStyle.Critical)
                Else


                    ToolBar1.Enabled = False
                    DGV_Ajustes.Enabled = False

                    GroupBox3.Location = New System.Drawing.Point(256, 164)
                    GroupBox3.Size = New System.Drawing.Size(774, 502)
                    DGV_Asociados.Size = New System.Drawing.Size(764, 473)
                    GroupBox3.BringToFront()


                    Button1.Show()
                    Panel1.Enabled = True
                    Panel2.Enabled = True
                    Button2.Show()
                    Tb_Descripcion.ReadOnly = False
                    dtp_fecha.Enabled = True
                    chk_exist.Enabled = True
                    chk_exist.BringToFront()


                    If contador = 0 Then
                        DGV_Inventario.Columns(0).HeaderText = "Cant."
                        DGV_Inventario.Columns(1).HeaderText = "Observación"
                        DGV_Inventario.Columns(2).HeaderText = "Código I."
                        DGV_Inventario.Columns(3).HeaderText = "Descripción"
                        DGV_Inventario.Columns(4).HeaderText = "Exist."
                        DGV_Inventario.Columns(5).HeaderText = "Modelo"
                        DGV_Inventario.Columns(6).HeaderText = "Ubic."
                        DGV_Inventario.Columns(7).HeaderText = "Tramo"
                        DGV_Inventario.Columns(8).HeaderText = "Precio"
                        DGV_Inventario.BackgroundColor = Color.WhiteSmoke
                        DGV_Inventario.Columns(0).Width = 45
                        DGV_Inventario.Columns(1).Width = 168
                        DGV_Inventario.Columns(2).Width = 90
                        DGV_Inventario.Columns(3).Width = 210
                        DGV_Inventario.Columns(4).Width = 45
                        DGV_Inventario.Columns(5).Width = 117
                        DGV_Inventario.Columns(6).Width = 65
                        DGV_Inventario.Columns(7).Width = 100
                        DGV_Inventario.Columns(7).Visible = False
                        DGV_Inventario.Columns(0).ReadOnly = False
                        DGV_Inventario.Columns(1).ReadOnly = False
                        DGV_Inventario.Columns(2).ReadOnly = True
                        DGV_Inventario.Columns(3).ReadOnly = True
                        DGV_Inventario.Columns(4).ReadOnly = True
                        DGV_Inventario.Columns(6).ReadOnly = True
                        DGV_Inventario.Columns(7).ReadOnly = True
                        DGV_Inventario.Columns(7).Visible = False
                        DGV_Inventario.Columns(8).Visible = False
                        DGV_Inventario.Columns(9).Visible = False
                        DGV_Inventario.Columns(10).Visible = False
                        DGV_Inventario.Columns(11).Visible = False
                        contador = 1
                    End If


                    DomainUpDown1.Items.Clear()
                    DomainUpDown1.Items.Add("Código Producto")
                    DomainUpDown1.Items.Add("Descripción")
                    DomainUpDown1.Items.Add("Modelo")
                    DomainUpDown1.Items.Add("Código Fábrica")
                    DomainUpDown1.Text = "Código Producto"
                    DGV_Inventario.Visible = True
                    DGV_Inventario.ReadOnly = True
                    DGV_Asociados.AllowUserToDeleteRows = False
                    DGV_Inventario.ClearSelection()
                    DGV_Asociados.ClearSelection()
                    DGV_Asociados.ReadOnly = True
                    Tb_Descripcion.Focus()
                    Tb_Descripcion.SelectAll()
                    DGV_Inventario.ClearSelection()
                    Tb_Descripcion.Focus()

                End If
            ElseIf e.Button Is Me.bt_eliminar Then

                varboton = 2

                If DGV_Ajustes.SelectedRows.Count = 0 Then

                    MsgBox("Debe seleccionar un ajuste para eliminar", MsgBoxStyle.Critical)

                Else

                    For cont As Integer = 0 To DGV_Asociados.RowCount - 1

                        DatosAjustes.EliminaProductosAjuste2(CInt(tb_codigo.Text), DGV_Asociados.Rows(cont).Cells(2).Value, CInt(DGV_Asociados.Rows(cont).Cells(7).Value), CInt(DGV_Asociados.Rows(cont).Cells(0).Value))

                    Next

                    DatosAjustes.EliminaAjuste(DGV_Ajustes.SelectedRows(0).Cells(0).Value)
                    'DatosAjustes.DVG_Ajustes(DGV_Ajustes)
                    DGV_Asociados.Rows.Clear()
                    DGV_Ajustes.ClearSelection()
                    tb_codigo.Clear()
                    Tb_Descripcion.Clear()
                    tb_Usuario.Clear()

                End If

            End If

        Catch ex As Exception

            MsgBox("Error cargando numero de ajuste", MsgBoxStyle.Critical)
            MsgBox(ex.ToString())

        End Try

    End Sub

    Private Sub Frm_Ajustes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DGV_Inventario.DataSource = Sp_ConsultaProductosAjusteInvBindingSource
        DGV_Inventario.frm = Me

        'TODO: This line of code loads data into the 'MELDataSet.sp_lvAjustes' table. You can move, or remove it, as needed.
        Me.Sp_lvAjustesTableAdapter.Fill(Me.MELDataSet.sp_lvAjustes)
        'TODO: This line of code loads data into the 'MELDataSet.sp_ConsultaProductosAjusteInv' table. You can move, or remove it, as needed.
        Me.Sp_ConsultaProductosAjusteInvTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosAjusteInv)
        lb_total.Text = Sp_ConsultaProductosAjusteInvBindingSource.Count

        eliminados.Columns.Add("Cantidad")
        eliminados.Columns.Add("Codigo")
        eliminados.Columns.Add("CodigoTramo")

        DGV_Inventario.AllowUserToAddRows = False
        DGV_Inventario.AllowUserToDeleteRows = False
        DGV_Inventario.AllowUserToOrderColumns = False
        DGV_Inventario.AllowUserToResizeColumns = False
        DGV_Inventario.AllowUserToResizeRows = False
        DGV_Inventario.MultiSelect = False


        DGV_Inventario.AlternatingRowsDefaultCellStyle = DGV_Ajustes.AlternatingRowsDefaultCellStyle
        DGV_Inventario.RowsDefaultCellStyle = DGV_Ajustes.RowsDefaultCellStyle
        DGV_Inventario.EditMode = DataGridViewEditMode.EditOnEnter
        DGV_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_Inventario.Size = New System.Drawing.Size(757, 200)
        DGV_Inventario.RowHeadersVisible = False
        GroupBox2.Controls.Add(DGV_Inventario)
        DGV_Inventario.Location = New System.Drawing.Point(5, 16)
        DGV_Inventario.Visible = False
        DGV_Inventario.ScrollBars = ScrollBars.Vertical
        DGV_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        DGV_Ajustes.ClearSelection()
        GroupBox3.Location = New System.Drawing.Point(256, 164)
        GroupBox3.Size = New System.Drawing.Size(774, 502)
        DGV_Asociados.Size = New System.Drawing.Size(764, 473)
        GroupBox3.BringToFront()
        DomainUpDown1.SelectedIndex = 0
        rb_cantidad.Checked = True
        DGV_Asociados.AllowUserToDeleteRows = False
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If
    End Sub

    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'DGV_Inventario.Rows.Clear()
        DGV_Inventario.Visible = False
        DGV_Asociados.Rows.Clear()
        tb_codigo.Clear()
        Tb_Descripcion.ReadOnly = True
        Tb_Descripcion.Clear()
        chk_exist.Enabled = False
        tb_Usuario.Clear()
        Button1.Hide()
        eliminados.Rows.Clear()
        DGV_Inventario.ReadOnly = False
        DGV_Asociados.AllowUserToDeleteRows = False
        Button2.Hide()
        ToolBar1.Enabled = True
        DGV_Ajustes.Enabled = True
        GroupBox3.Location = New System.Drawing.Point(256, 164)
        GroupBox3.Size = New System.Drawing.Size(774, 502)
        DGV_Asociados.Size = New System.Drawing.Size(764, 473)
        GroupBox3.BringToFront()
        DomainUpDown1.Items.Clear()
        DomainUpDown1.Items.Add("Código Ajuste")
        DomainUpDown1.Items.Add("Usuario")
        DomainUpDown1.Items.Add("Código Interno")
        DomainUpDown1.Text = "Código Ajuste"
        DGV_Ajustes.ClearSelection()
        dtp_fecha.Value = Today
        dtp_fecha.Enabled = False
        Panel1.Enabled = False
        Panel2.Enabled = False
        DGV_Asociados.AllowUserToDeleteRows = False
        DGV_Asociados.ReadOnly = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim cont2 As Integer = 0
        
        If DGV_Asociados.RowCount > 0 Then

            If varboton = 0 Then

                If tb_codigo.Text = "" Or Tb_Descripcion.Text = "" Then

                    MsgBox("Debe llenar todos los campos obligatorios")

                Else

                    DatosAjustes.Inserta_Ajuste(dtp_fecha.Value, tb_Usuario.Text, Tb_Descripcion.Text)
                    Dim cont As Integer = 0

                    For cont = 0 To DGV_Asociados.RowCount - 1

                        DatosAjustes.InsertaProductoAjuste(CInt(tb_codigo.Text), DGV_Asociados.Rows(cont).Cells(2).Value, DGV_Asociados.Rows(cont).Cells(0).Value, DGV_Asociados.Rows(cont).Cells(1).Value, DGV_Asociados.Rows(cont).Cells(7).Value)

                    Next
                    DGV_Inventario.Visible = False
                    DGV_Asociados.Rows.Clear()
                    tb_codigo.Clear()
                    Tb_Descripcion.Clear()
                    tb_Usuario.Clear()
                    Tb_Descripcion.ReadOnly = True
                    dtp_fecha.Enabled = False
                    Panel1.Enabled = False
                    Panel2.Enabled = False
                    Button1.Hide()
                    Button2.Hide()

                    GroupBox3.Location = New System.Drawing.Point(256, 164)
                    GroupBox3.Size = New System.Drawing.Size(774, 502)
                    DGV_Asociados.Size = New System.Drawing.Size(764, 473)

                    DGV_Inventario.ReadOnly = True
                    DGV_Asociados.AllowUserToDeleteRows = False
                    ToolBar1.Enabled = True
                    DGV_Ajustes.Enabled = True
                    DomainUpDown1.Items.Clear()
                    DomainUpDown1.Items.Add("Código Ajuste")
                    DomainUpDown1.Items.Add("Usuario")
                    DomainUpDown1.Items.Add("Código Interno")
                    DomainUpDown1.Text = "Código Ajuste"
                    DGV_Ajustes.ClearSelection()
                    dtp_fecha.Value = Today
                    chk_exist.Enabled = False
                    dtp_fecha.Enabled = False

                    'DatosAjustes.DVG_Ajustes(DGV_Ajustes)
                    DGV_Asociados.ReadOnly = False
                    tb_buscar.Text = ""

                End If

            ElseIf varboton = 1 Then

                If tb_codigo.Text = "" Or Tb_Descripcion.Text = "" Then

                    MsgBox("Debe llenar todos los campos obligatorios")

                Else

                    Dim cont As Integer = 0


                    DatosAjustes.ModificaAjuste(CInt(tb_codigo.Text), dtp_fecha.Value, Tb_Descripcion.Text)

                    DGV_Inventario.Visible = False
                    DGV_Asociados.Rows.Clear()
                    tb_codigo.Clear()
                    Tb_Descripcion.Clear()
                    tb_Usuario.Clear()
                    Tb_Descripcion.ReadOnly = True
                    dtp_fecha.Enabled = False
                    Button1.Hide()
                    Panel1.Enabled = False
                    Panel2.Enabled = False
                    Button2.Hide()
                    ToolBar1.Enabled = True
                    DGV_Ajustes.Enabled = True
                    DGV_Inventario.ReadOnly = True
                    DGV_Asociados.AllowUserToDeleteRows = False
                    DomainUpDown1.Items.RemoveAt(0)
                    DomainUpDown1.Items.RemoveAt(0)
                    DomainUpDown1.Items.RemoveAt(0)
                    DomainUpDown1.Items.Add("Código Ajuste")
                    DomainUpDown1.Items.Add("Usuario")
                    DomainUpDown1.Items.Add("Código Interno")
                    DomainUpDown1.Text = "Código Ajuste"
                    DGV_Ajustes.ClearSelection()
                    dtp_fecha.Value = Today
                    DGV_Asociados.AllowUserToDeleteRows = False
                    chk_exist.Enabled = False
                    eliminados.Rows.Clear()
                    DGV_Asociados.ReadOnly = False
                    dtp_fecha.Enabled = False
                    tb_buscar.Text = ""

                End If

            End If

        Else

            MsgBox("El ajuste está vacío, favor verificar", MsgBoxStyle.Critical, "SINPRO")

        End If

    End Sub

    Private Sub DGV_Inventario_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DGV_Inventario.CellBeginEdit
        If DGV_Inventario.SelectedRows.Count > 0 Then
            'DGV_Inventario.CurrentRow.Cells(0).Selected = True
            cant = DGV_Inventario.SelectedRows(0).Cells(4).Value
            index2 = DGV_Inventario.SelectedRows(0).Index
        End If
    End Sub

    Private Sub DGV_Inventario_CellEndEdit(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DGV_Inventario.CellEndEdit
        Try
            Dim index1 As Integer = 0

            If DGV_Inventario.SelectedRows.Count > 0 Then
                index1 = DGV_Inventario.SelectedRows(0).Index
            End If

            If e.ColumnIndex = 1 Then
                If Not Me.DGV_Inventario.CurrentCell.Value Is System.DBNull.Value Then
                    If Me.DGV_Inventario.CurrentRow.Cells(0).Value = "" Or Me.DGV_Inventario.CurrentRow.Cells(0).Value = "0" Then
                        If rb_cantidad.Checked Then
                            Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                            Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""
                        Else
                            If CInt(DGV_Inventario.SelectedRows(0).Cells(0).EditedFormattedValue) - (CInt(DGV_Inventario.SelectedRows(0).Cells(4).Value) - CInt(DGV_Inventario.SelectedRows(0).Cells(0).EditedFormattedValue)) <> 0 Then
                                Me.DGV_Asociados.Rows.Add(ObtenerValoresFila(Me.DGV_Inventario.CurrentRow))
                                Me.DGV_Asociados.Rows(DGV_Asociados.RowCount - 1).Cells(9).Value = False

                                CrearWhere()

                                If DGV_Inventario.RowCount = 0 Then
                                    tb_buscar.Focus()
                                    tb_buscar.SelectAll()
                                End If

                                sel = True
                            Else
                                Me.DGV_Inventario.CurrentRow.Cells(4).Value = cant
                                Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                                Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""
                            End If
                        End If
                    ElseIf -(Me.DGV_Inventario.CurrentRow.Cells(0).Value) > Me.DGV_Inventario(4, Me.DGV_Inventario.CurrentRow.Index).Value Then
                        Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                        Me.DGV_Inventario.BeginEdit(True)
                    Else
                        If Me.DGV_Inventario(6, Me.DGV_Inventario.CurrentRow.Index).Value Is System.DBNull.Value Or Me.DGV_Inventario(6, Me.DGV_Inventario.CurrentRow.Index).Value = "" Then
                            Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                            Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""
                            MsgBox("No puede ajustar un artículo que no posee ubicación.", MsgBoxStyle.Critical)
                            sel = True
                        Else

                            If Not revisa(Me.DGV_Inventario(2, Me.DGV_Inventario.CurrentRow.Index).Value, Me.DGV_Inventario(6, Me.DGV_Inventario.CurrentRow.Index).Value) Then
                                DGV_Inventario.CurrentRow.Cells(4).Value = CInt(DGV_Inventario.CurrentRow.Cells(4).Value) + CInt(DGV_Inventario.CurrentRow.Cells(0).Value)
                                Dim cont As Integer = 0

                                If rb_cantidad.Checked Then

                                    Me.DGV_Asociados.Rows.Add(ObtenerValoresFila(Me.DGV_Inventario.CurrentRow))
                                    Me.DGV_Asociados.Rows(DGV_Asociados.RowCount - 1).Cells(9).Value = False

                                    CrearWhere()

                                    If DGV_Inventario.RowCount = 0 Then
                                        tb_buscar.Focus()
                                        tb_buscar.SelectAll()
                                    End If

                                    sel = True

                                Else

                                    If CInt(DGV_Inventario.SelectedRows(0).Cells(0).EditedFormattedValue) - (CInt(DGV_Inventario.SelectedRows(0).Cells(4).Value) - CInt(DGV_Inventario.SelectedRows(0).Cells(0).EditedFormattedValue)) <> 0 Then

                                        Me.DGV_Asociados.Rows.Add(ObtenerValoresFila(Me.DGV_Inventario.CurrentRow))
                                        Me.DGV_Asociados.Rows(DGV_Asociados.RowCount - 1).Cells(9).Value = False

                                        CrearWhere()

                                        If DGV_Inventario.RowCount = 0 Then
                                            tb_buscar.Focus()
                                            tb_buscar.SelectAll()
                                        End If

                                        sel = True

                                    Else

                                        Me.DGV_Inventario.CurrentRow.Cells(4).Value = cant
                                        Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                                        Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""

                                    End If

                                End If

                            Else

                                Me.DGV_Inventario.CurrentRow.Cells(0).Value = ""
                                Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""
                                MsgBox("Ya ha ingresado este artículo a su ajuste. Si desea agregar más elimínelo del ajuste y vuelva a agregarlo.")
                                sel = True
                                Me.DGV_Inventario.BeginEdit(True)

                            End If
                        End If
                    End If
                End If
            Else
            End If

            DGV_Asociados.ClearSelection()

        Catch ex As Exception

        End Try
    End Sub

    Delegate Sub SetRowIndex(ByVal i As Integer)

    'Private Sub dataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
    '    Dim method As New SetRowIndex(AddressOf Mymethod)
    '    Me.DGV_Inventario.BeginInvoke(method, index2)
    'End Sub

    'Private Sub Mymethod(ByVal index As Integer)
    '    'DGV_Inventario.Rows.RemoveAt(index)

    '    If DGV_Inventario.RowCount > 0 Then

    '    Else

    '        If DGV_Inventario.CurrentRow.Index <> 0 Then

    '            DGV_Inventario.CurrentCell = DGV_Inventario.Rows(DGV_Inventario.CurrentRow.Index - 1).Cells(0)
    '            DGV_Inventario.BeginEdit(True)
    '            sel = False

    '        Else

    '            DGV_Inventario.CurrentCell = DGV_Inventario.Rows(DGV_Inventario.CurrentRow.Index).Cells(0)
    '            DGV_Inventario.BeginEdit(True)
    '            sel = False

    '        End If

    '        tb_buscar.Focus()
    '        tb_buscar.SelectAll()

    '    End If
    'End Sub


    'Public Sub eliminarfila(ByVal index As Integer)
    '    DGV_Inventario.Rows.RemoveAt(index)
    'End Sub

    Public Sub corrrigeObs() Handles DGV_Asociados.RowsAdded

        If DGV_Asociados.Rows(DGV_Asociados.RowCount - 1).Cells(1).Value = "" Then

            DGV_Asociados.Rows(DGV_Asociados.RowCount - 1).Cells(1).Value = Tb_Descripcion.Text

        End If

    End Sub

    Function revisa(ByVal cod As String, ByVal ubic As String) As Boolean
        Dim i As Integer = 0
        Dim esta As Boolean = False
        While i <= Me.DGV_Asociados.Rows.Count - 1
            If cod = Me.DGV_Asociados(2, i).Value And Me.DGV_Asociados(6, i).Value = ubic Then
                esta = True
            End If
            i = i + 1
        End While

        Return esta
    End Function

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        Dim Contenido(Me.DGV_Inventario.ColumnCount - 1) As String

        If rb_cantidad.Checked Then
            For Ndx As Integer = 0 To (Contenido.Length - 1)
                Contenido(Ndx) = fila.Cells(Ndx).Value
            Next
        Else

            For Ndx As Integer = 0 To (Contenido.Length - 1)

                If Ndx = 0 Then
                    Contenido(Ndx) = CInt(fila.Cells(0).EditedFormattedValue) - (CInt(fila.Cells(4).Value) - CInt(fila.Cells(0).EditedFormattedValue))
                ElseIf Ndx = 4 Then
                    Contenido(Ndx) = CInt(fila.Cells(0).EditedFormattedValue)
                Else
                    Contenido(Ndx) = fila.Cells(Ndx).Value
                End If

            Next
        End If

        Return Contenido
    End Function

    Private Sub DGV_Ajustes_CellContentClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_Ajustes.CellClick, DGV_Ajustes.KeyDown, DGV_Ajustes.KeyUp
        Try
            tb_codigo.Clear()
            Tb_Descripcion.Clear()
            tb_Usuario.Clear()
            dtp_fecha.Value = Today
            DGV_Asociados.Rows.Clear()
            tb_codigo.Text = DGV_Ajustes.SelectedRows(0).Cells(0).Value
            DatosAjustes.Consulta_Ajuste(DGV_Ajustes.SelectedRows(0).Cells(0).Value, tb_Usuario.Text, Tb_Descripcion.Text, dtp_fecha.Value, DGV_Asociados)
            DGV_Asociados.ClearSelection()
        Catch
            DGV_Ajustes.ClearSelection()
        End Try
    End Sub

    Private Sub tb_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_buscar.KeyPress

        If DGV_Ajustes.Enabled = False Then
            If e.KeyChar <> "'"c And e.KeyChar <> "%"c Then
                e.Handled = False
                'muestra_label(sender, 1)
            Else
                e.Handled = True
                'muestra_label(sender, 0)
                'Me.Label22.Text = "      Ingrese sólo números y (,)"
            End If
        End If

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged
        Try

            If ToolBar1.Enabled Then

                If DomainUpDown1.Text = "Código Ajuste" Then

                    CrearWhere()
                    tb_Usuario.Clear()
                    Tb_Descripcion.Clear()
                    tb_codigo.Clear()
                    dtp_fecha.Value = Today
                    DGV_Asociados.Rows.Clear()
                    lbl_MontoA.Text = "0,00"
                    lbl_MontoE.Text = "0,00"
                    lbl_MontoT.Text = "0,00"

                ElseIf DomainUpDown1.Text = "Usuario" Then

                    CrearWhere()
                    tb_Usuario.Clear()
                    Tb_Descripcion.Clear()
                    tb_codigo.Clear()
                    dtp_fecha.Value = Today
                    DGV_Asociados.Rows.Clear()
                    lbl_MontoA.Text = "0,00"
                    lbl_MontoE.Text = "0,00"
                    lbl_MontoT.Text = "0,00"

                ElseIf DomainUpDown1.Text = "Código Interno" Then

                    If DGV_Ajustes.SelectedRows.Count > 0 Then
                        DatosAjustes.DVG_ProductosAjuste(DGV_Asociados, CInt(DGV_Ajustes.SelectedRows(0).Cells(0).Value), tb_buscar.Text)
                        DGV_Asociados.ClearSelection()
                    End If

                End If

            Else

                sel = False

                CrearWhere()
                DGV_Inventario.ClearSelection()
                DGV_Asociados.ClearSelection()
                sel = True

            End If

        Catch ex As Exception



        End Try
    End Sub

    Public Sub CalcularTotalFilas() Handles DGV_Ajustes.RowsAdded, DGV_Ajustes.RowsRemoved

        Label5.Text = DGV_Ajustes.RowCount

    End Sub

    Public Sub CalcularMontos() Handles DGV_Asociados.RowsAdded, DGV_Asociados.RowsRemoved

        Dim cont As Integer = 0
        Dim MontoA As Double = 0
        Dim MontoE As Double = 0
        Dim MontoT As Double = 0


        For cont = 0 To DGV_Asociados.RowCount - 1

            If DGV_Asociados.Rows(cont).Cells(0).Value > 0 Then

                MontoA = MontoA + CDbl(DGV_Asociados.Rows(cont).Cells(0).Value * DGV_Asociados.Rows(cont).Cells(8).Value)

            Else

                MontoE = MontoE + (CDbl(DGV_Asociados.Rows(cont).Cells(0).Value * DGV_Asociados.Rows(cont).Cells(8).Value))

            End If

        Next

        MontoT = MontoA + MontoE

        lbl_MontoA.Text = Format(MontoA, "#,##0.00")
        lbl_MontoE.Text = Format(MontoE, "#,##0.00")
        lbl_MontoT.Text = Format(MontoT, "#,##0.00")

    End Sub

    Public Sub CeroEnMontos() Handles lbl_MontoA.TextChanged, lbl_MontoE.TextChanged, lbl_MontoT.TextChanged

        If lbl_MontoA.Text = ",00" Then

            lbl_MontoA.Text = "0,00"

        End If

        If lbl_MontoE.Text = ",00" Then

            lbl_MontoE.Text = "0,00"

        End If

        If lbl_MontoT.Text = ",00" Then

            lbl_MontoT.Text = "0,00"

        End If

    End Sub

    Private Sub DGV_Asociados_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV_Asociados.UserDeletingRow
        If varboton = 1 And DGV_Asociados.CurrentRow.Cells(9).Value = True Then

            eliminados.Rows.Add(DGV_Asociados.CurrentRow.Cells(0).Value, DGV_Asociados.CurrentRow.Cells(2).Value, DGV_Asociados.CurrentRow.Cells(7).Value)

        End If

    End Sub

    Public Sub recibe_valor(ByVal v As Boolean)

        If v = True Then

            Try

                If DGV_Inventario.RowCount > 0 Then
                    MsgBox("No hay suficiente cantidad en existencia o la introducida es inválida, favor verificar", MsgBoxStyle.Critical)
                    Me.DGV_Inventario.CurrentRow.Cells(1).Value = ""
                    Me.DGV_Inventario.CurrentRow.Cells(0).Selected = True
                Else
                    tb_buscar.Focus()
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Public Sub EdicionEnCantidad(ByVal v As Boolean)

        If v = True Then

            Me.DGV_Inventario.Rows(DGV_Inventario.CurrentRow.Index).Cells(0).Selected = True
            Me.DGV_Inventario.Rows(DGV_Inventario.CurrentRow.Index).Cells(1).Value = ""

        End If

    End Sub

    Private Sub DGV_Inventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Inventario.KeyDown, DGV_Inventario.KeyUp
        If e.KeyData = Keys.Control Or e.KeyData = Keys.ControlKey Then
            tb_buscar.Focus()
            tb_buscar.SelectAll()
        End If
    End Sub


    Private Sub DGV_Productos_RowLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Inventario.SelectionChanged

        If sel = True Then

            If Not DGV_Inventario.CurrentRow Is Nothing Then

                If DGV_Inventario.CurrentRow.Index <> 0 Then

                    DGV_Inventario.CurrentRow.Cells(0).Selected = True
                    DGV_Inventario.BeginEdit(True)
                    sel = False

                Else

                    DGV_Inventario.CurrentCell = DGV_Inventario.Rows(DGV_Inventario.CurrentRow.Index).Cells(0)
                    DGV_Inventario.BeginEdit(True)
                    sel = False

                End If

            End If

        End If

    End Sub

    Private Sub tb_buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyDown
        If DGV_Ajustes.Enabled Then
            If DGV_Ajustes.Rows.Count > 0 Then
                If e.KeyData = Keys.Enter Then

                    Me.DGV_Ajustes.Rows(0).Cells(0).Selected = True
                    DGV_Ajustes.Focus()

                End If

            End If

        Else

            If DGV_Inventario.Rows.Count > 0 Then

                If e.KeyData = Keys.Enter Then

                    Me.DGV_Inventario.Rows(0).Cells(0).Selected = True
                    DGV_Inventario.CurrentCell = Me.DGV_Inventario.Rows(0).Cells(0)
                    DGV_Inventario.BeginEdit(True)

                End If

            Else

                tb_buscar.Focus()

            End If

        End If

    End Sub

    Private Sub DomainUpDown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        DGV_Asociados.ClearSelection()
        DGV_Inventario.ClearSelection()
        tb_buscar.Clear()
        tb_buscar.Focus()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cb_almacenes.Enabled = True
            cb_cuartos.Enabled = True
            DatosAlmacenes.llenar_almacen(cb_almacenes)
            cb_almacenes.SelectedIndex = 0
        Else
            cb_almacenes.Enabled = False
            cb_cuartos.Enabled = False
            cb_almacenes.Items.Clear()
            cb_cuartos.Items.Clear()
            cb_almacenes.ResetText()
            cb_cuartos.ResetText()
        End If

        tb_buscar_TextChanged(tb_buscar, New System.EventArgs)
        'eliminarRepetidos()
        DGV_Inventario.ClearSelection()
    End Sub

    Private Sub cb_almacenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacenes.SelectedIndexChanged

        DatosAlmacenes.llenarcuartos(cb_cuartos, cb_cuartos, CInt(Me.cb_almacenes.Items.Item(cb_almacenes.SelectedIndex).code))
        CrearWhere()
        DGV_Inventario.ClearSelection()

        'DatosAjustes.DGV_Productos_Inventario8(tb_buscar.Text, 5, DGV_Inventario)
    End Sub

    Private Sub cb_cuartos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuartos.SelectedIndexChanged

        CrearWhere()
        DGV_Inventario.ClearSelection()

    End Sub


    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And Not (e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CellKeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "-"c) And Not (e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CellKeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "-"c) And Not (e.KeyChar = "."c) Or (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Inventario.EditingControlShowing
        If Me.DGV_Inventario.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                If rb_cantidad.Checked Then

                    RemoveHandler txt.KeyPress, AddressOf CellKeyPress2
                    AddHandler txt.KeyPress, AddressOf CellKeyPress2

                Else

                    RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                    AddHandler txt.KeyPress, AddressOf CellKeyPress

                End If
            End If

        ElseIf Me.DGV_Inventario.CurrentCell.ColumnIndex = 1 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)

            RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
            AddHandler txt.KeyPress, AddressOf CellKeyPress3

        End If
    End Sub

    Private Sub rb_conteo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_conteo.CheckedChanged

        If DGV_Inventario.SelectedRows.Count > 0 Then

            DGV_Inventario.SelectedRows(0).Cells(0).Selected = True
            DGV_Inventario.BeginEdit(True)

        End If

    End Sub


    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DGV_Ajustes.Enabled Then

            If DomainUpDown1.SelectedIndex = 0 Then

                where = where + y + "CodigoAjuste LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 1 Then

                where = where + y + "Usuario LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            End If


            Me.SplvAjustesBindingSource.Filter = where
            Label5.Text = DGV_Ajustes.RowCount
            DGV_Ajustes.ClearSelection()

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

                where = where + y + "CodigoProductoF LIKE '%" & tb_buscar.Text & "%'"
                y = " and "

            End If


            If CheckBox1.Checked Then

                If cb_almacenes.SelectedIndex <> -1 Then

                    where = where + y + "AlmacenId = '" & Me.cb_almacenes.Items.Item(cb_almacenes.SelectedIndex).code & "'"
                    y = " and "

                End If

                If cb_cuartos.SelectedIndex <> -1 Then

                    where = where + y + "CuartoId = '" & Me.cb_cuartos.Items.Item(cb_cuartos.SelectedIndex).code & "'"
                    y = " and "

                End If


            End If

            If chk_exist.Checked Then
                where = where + y + "Exist > 0"
                y = " and "
            End If

            For cont As Integer = 0 To DGV_Asociados.RowCount - 1

                where = where + y + "CodigoInterno+Ubicacion <> '" & DGV_Asociados.Rows(cont).Cells(2).Value.ToString & DGV_Asociados.Rows(cont).Cells(6).Value.ToString & "'"
                y = " And "

            Next


            Me.Sp_ConsultaProductosAjusteInvBindingSource.Filter = where
            Me.lb_total.Text = Me.Sp_ConsultaProductosAjusteInvBindingSource.Count
            DGV_Inventario.ClearSelection()

        End If

    End Sub

    Private Sub DGV_Asociados_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGV_Asociados.UserDeletedRow
        Me.Sp_ConsultaProductosAjusteInvTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosAjusteInv)
        CrearWhere()
    End Sub

    Private Sub chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exist.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub DGV_Inventario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Inventario.CellClick
        Try
            If DGV_Inventario.SelectedRows.Count > 0 Then
                DGV_Inventario.SelectedRows(0).Cells(0).Selected = True
                DGV_Inventario.BeginEdit(True)
            End If
        Catch ex As Exception

        End Try
        
    End Sub


    Public Sub GridAExcel(ByVal ElGrid As DataGridView)

        Dim ColVisibles As Integer = 0
        Dim FilasVisibles As Integer = 0

        Dim colCant As Integer = 0
        Dim colFOB As Integer = 0
        Dim colFlete As Integer = 0
        Dim colCIF As Integer = 0
        Dim colAran As Integer = 0
        Dim colOtros As Integer = 0
        Dim colCosto As Integer = 0

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

                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = ElGrid.ColumnCount
                Dim NRow As Integer = ElGrid.RowCount

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

                ElseIf My.Settings.Empresa = 1 Then

                    exHoja.Cells.Item(1, 1) = "Distribuidora BRWME, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29838587-1"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                    exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

                End If

                exHoja.Cells.Item(6, 1) = "Ajuste nro.: " + tb_codigo.Text
                exHoja.Cells.Item(1, 7) = "Fecha: " + dtp_fecha.Value.ToShortDateString
                exHoja.Cells.Item(7, 1) = "Usuario: " + tb_Usuario.Text
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
                exHoja.Rows.Item(6).HorizontalAlignment = 2
                exHoja.Rows.Item(6).Font.Bold = 1
                exHoja.Rows.Item(6).Font.italic = 1
                exHoja.Rows.Item(6).Font.name = "Arial"
                exHoja.Rows.Item(6).Font.size = 11
                exHoja.Rows.Item(7).HorizontalAlignment = 2
                exHoja.Rows.Item(7).Font.Bold = 1
                exHoja.Rows.Item(7).Font.italic = 1
                exHoja.Rows.Item(7).Font.name = "Arial"
                exHoja.Rows.Item(7).Font.size = 11
                exHoja.Rows.Item(7).HorizontalAlignment = 2

                Dim a As Integer = 2

                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                For i As Integer = 1 To NCol

                    If ElGrid.Columns(i - 1).Visible Then

                        If i = 2 Then
                            colCant = a
                        ElseIf i = 7 Then
                            colFOB = a
                        ElseIf i = 8 Then
                            colFlete = a
                        ElseIf i = 9 Then
                            colCIF = a
                        ElseIf i = 11 Then
                            colAran = a
                        ElseIf i = 12 Then
                            colOtros = a
                        ElseIf i = 13 Then
                            colCosto = a
                        End If

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

                        Dim b As Integer = 2

                        For cont5 As Integer = 0 To ElGrid.ColumnCount - 1

                            If ElGrid.Columns(cont5).Visible Then

                                exHoja.Cells.Item((valor), b).ClearFormats()
                                exHoja.Cells.Item((valor), b) = ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                If cont5 = 8 Or cont5 = 10 Then

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).NumberFormat = "#.##0,00"
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 4

                                ElseIf cont5 = 0 Or cont5 = 4 Then

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 3

                                Else

                                    exHoja.Cells.Item((valor), b) = exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).Text()
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                                End If

                                b = b + 1

                            End If

                        Next

                        'acum = acum + (CInt(ElGrid.Rows(Fila - 1).Cells(0).Value) * CDbl(ElGrid.Rows(Fila - 1).Cells(5).Value))

                        cont = cont + 1
                        valor = valor + 1

                    End If

                    exHoja.Cells(Fila + 11, 7).select()

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
                    exHoja.Range(exApp.Cells(10, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).BorderAround() '
                    '                                                                                          '
                    '--------------------------------------- BORDE --------------------------------------------'

                    exApp.Cells.Item((cont) + 11, 10) = Format(CDbl(lbl_MontoA.Text), "#,##0.00")
                    exApp.Cells.Item((cont) + 12, 10) = Format(CDbl(lbl_MontoE.Text), "#,##0.00")
                    exApp.Cells.Item((cont) + 13, 10) = Format(CDbl(lbl_MontoT.Text), "#,##0.00")

                    exApp.Cells.Item((cont) + 11, 9) = "Total P.:"
                    exApp.Cells.Item((cont) + 12, 9) = "Total N.:"
                    exApp.Cells.Item((cont) + 13, 9) = "Total A.:"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 9), exApp.Cells(cont + 11, 10)).BorderAround()
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, 10)).NumberFormat = "#.##0,00"

                    exHoja.Range(exApp.Cells(cont + 12, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 12, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 12, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 12, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 12, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 12, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 12, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 12, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 12, 9), exApp.Cells(cont + 11, 10)).BorderAround()
                    exHoja.Range(exApp.Cells(cont + 12, 2), exApp.Cells(cont + 11, 10)).NumberFormat = "#.##0,00"

                    exHoja.Range(exApp.Cells(cont + 13, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 13, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 13, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 13, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 13, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 13, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 13, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 13, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 13, 9), exApp.Cells(cont + 11, 10)).BorderAround()
                    exHoja.Range(exApp.Cells(cont + 13, 2), exApp.Cells(cont + 11, 6 + 1)).NumberFormat = "#.##0,00"

                    If ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible Then
                        exHoja.Range(exApp.Cells(cont + 11, 3), exApp.Cells(cont + 11, 3)).NumberFormat = "0"
                    ElseIf ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible = False Then
                        exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, 2)).NumberFormat = "0"
                    End If

                End If






                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Size = 10
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Bold = True
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Italic = True
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).BorderAround()


                exHoja.Range(exApp.Cells(11, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(11, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Font.Size = 9

                exHoja.Range(exApp.Cells(10, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Columns.AutoFit()
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
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GridAExcel(DGV_Asociados)
    End Sub

    Private Sub DGV_Inventario_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Inventario.CellDoubleClick

        If DGV_Inventario.SelectedRows.Count > 0 And e.ColumnIndex = 6 Then

            If DGV_Inventario.SelectedRows(0).Cells(6).Value = "" Then

                Dim frm As New Frm_Ubicacion
                frm.frm2 = Me
                Me.Enabled = False
                frm.Show()


            End If

        End If

    End Sub

End Class