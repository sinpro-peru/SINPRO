<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Relacion_Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Relacion_Facturas))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Docs = New System.Windows.Forms.DataGridView
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Raz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_elaborada = New System.Windows.Forms.TextBox
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.rb_chequesDev = New System.Windows.Forms.RadioButton
        Me.rb_NC = New System.Windows.Forms.RadioButton
        Me.rb_fact = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_asociacion = New System.Windows.Forms.GroupBox
        Me.DGV_relacion = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.tb_observ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_vendedor = New MTGCComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dgv_relaciones = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Transporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.Dd_relacion = New System.Windows.Forms.ComboBox
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_aprobada = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_enviada = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_guia = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chk_confirmada = New System.Windows.Forms.CheckBox
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_Docs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        Me.lb_asociacion.SuspendLayout()
        CType(Me.DGV_relacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv_relaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Docs
        '
        Me.DGV_Docs.AllowUserToAddRows = False
        Me.DGV_Docs.AllowUserToDeleteRows = False
        Me.DGV_Docs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Docs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Docs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Docs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Factura, Me.CCliente, Me.Raz, Me.Monto, Me.CodigoDoc})
        Me.DGV_Docs.Location = New System.Drawing.Point(5, 26)
        Me.DGV_Docs.Name = "DGV_Docs"
        Me.DGV_Docs.RowHeadersVisible = False
        Me.DGV_Docs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Docs.Size = New System.Drawing.Size(662, 202)
        Me.DGV_Docs.TabIndex = 9
        '
        'Fecha
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 75
        '
        'Factura
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Factura.DefaultCellStyle = DataGridViewCellStyle3
        Me.Factura.HeaderText = "N° Doc."
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Factura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Factura.Width = 110
        '
        'CCliente
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CCliente.DefaultCellStyle = DataGridViewCellStyle4
        Me.CCliente.HeaderText = "Cliente"
        Me.CCliente.Name = "CCliente"
        Me.CCliente.ReadOnly = True
        '
        'Raz
        '
        Me.Raz.HeaderText = "Razón Social"
        Me.Raz.Name = "Raz"
        Me.Raz.ReadOnly = True
        Me.Raz.Width = 268
        '
        'Monto
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle5
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 86
        '
        'CodigoDoc
        '
        Me.CodigoDoc.HeaderText = "Column1"
        Me.CodigoDoc.Name = "CodigoDoc"
        Me.CodigoDoc.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(*)Elaborada por:"
        '
        'tb_elaborada
        '
        Me.tb_elaborada.Location = New System.Drawing.Point(448, 78)
        Me.tb_elaborada.Name = "tb_elaborada"
        Me.tb_elaborada.ReadOnly = True
        Me.tb_elaborada.Size = New System.Drawing.Size(190, 21)
        Me.tb_elaborada.TabIndex = 3
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.rb_chequesDev)
        Me.groupbox1.Controls.Add(Me.rb_NC)
        Me.groupbox1.Controls.Add(Me.rb_fact)
        Me.groupbox1.Controls.Add(Me.DGV_Docs)
        Me.groupbox1.Controls.Add(Me.Label7)
        Me.groupbox1.Location = New System.Drawing.Point(345, 163)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(671, 232)
        Me.groupbox1.TabIndex = 68
        Me.groupbox1.TabStop = False
        '
        'rb_chequesDev
        '
        Me.rb_chequesDev.AutoSize = True
        Me.rb_chequesDev.BackColor = System.Drawing.Color.DodgerBlue
        Me.rb_chequesDev.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_chequesDev.ForeColor = System.Drawing.Color.White
        Me.rb_chequesDev.Location = New System.Drawing.Point(112, 2)
        Me.rb_chequesDev.Name = "rb_chequesDev"
        Me.rb_chequesDev.Size = New System.Drawing.Size(92, 18)
        Me.rb_chequesDev.TabIndex = 69
        Me.rb_chequesDev.Text = "Cheques Dev."
        Me.rb_chequesDev.UseVisualStyleBackColor = False
        '
        'rb_NC
        '
        Me.rb_NC.AutoSize = True
        Me.rb_NC.BackColor = System.Drawing.Color.DodgerBlue
        Me.rb_NC.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_NC.ForeColor = System.Drawing.Color.White
        Me.rb_NC.Location = New System.Drawing.Point(62, 2)
        Me.rb_NC.Name = "rb_NC"
        Me.rb_NC.Size = New System.Drawing.Size(44, 18)
        Me.rb_NC.TabIndex = 68
        Me.rb_NC.Text = "N.C."
        Me.rb_NC.UseVisualStyleBackColor = False
        '
        'rb_fact
        '
        Me.rb_fact.AutoSize = True
        Me.rb_fact.BackColor = System.Drawing.Color.DodgerBlue
        Me.rb_fact.Checked = True
        Me.rb_fact.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_fact.ForeColor = System.Drawing.Color.White
        Me.rb_fact.Location = New System.Drawing.Point(8, 2)
        Me.rb_fact.Name = "rb_fact"
        Me.rb_fact.Size = New System.Drawing.Size(48, 18)
        Me.rb_fact.TabIndex = 67
        Me.rb_fact.TabStop = True
        Me.rb_fact.Text = "Fact."
        Me.rb_fact.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(-1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(672, 23)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Documentos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_asociacion
        '
        Me.lb_asociacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb_asociacion.Controls.Add(Me.DGV_relacion)
        Me.lb_asociacion.Controls.Add(Me.Label8)
        Me.lb_asociacion.Location = New System.Drawing.Point(345, 437)
        Me.lb_asociacion.Name = "lb_asociacion"
        Me.lb_asociacion.Size = New System.Drawing.Size(669, 230)
        Me.lb_asociacion.TabIndex = 69
        Me.lb_asociacion.TabStop = False
        '
        'DGV_relacion
        '
        Me.DGV_relacion.AllowUserToAddRows = False
        Me.DGV_relacion.AllowUserToDeleteRows = False
        Me.DGV_relacion.AllowUserToOrderColumns = True
        Me.DGV_relacion.AllowUserToResizeRows = False
        Me.DGV_relacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_relacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.DataGridViewTextBoxColumn1, Me.CodFactura, Me.CodCliente, Me.Razon, Me.MontoFactura, Me.Cod})
        Me.DGV_relacion.Location = New System.Drawing.Point(5, 26)
        Me.DGV_relacion.Name = "DGV_relacion"
        Me.DGV_relacion.RowHeadersVisible = False
        Me.DGV_relacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_relacion.Size = New System.Drawing.Size(660, 198)
        Me.DGV_relacion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(670, 23)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Documentos Asociados a la Relación"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(699, 679)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 13
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(595, 679)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.Color.White
        Me.bt_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar.Image = CType(resources.GetObject("bt_agregar.Image"), System.Drawing.Image)
        Me.bt_agregar.Location = New System.Drawing.Point(653, 403)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(53, 27)
        Me.bt_agregar.TabIndex = 10
        Me.bt_agregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(655, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 14)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Observ.:"
        '
        'tb_observ
        '
        Me.tb_observ.Location = New System.Drawing.Point(747, 76)
        Me.tb_observ.Multiline = True
        Me.tb_observ.Name = "tb_observ"
        Me.tb_observ.ReadOnly = True
        Me.tb_observ.Size = New System.Drawing.Size(272, 53)
        Me.tb_observ.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 14)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "(*)Vendedor:"
        '
        'tb_vendedor
        '
        Me.tb_vendedor.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_vendedor.ColumnNum = 2
        Me.tb_vendedor.ColumnWidth = "145;30"
        Me.tb_vendedor.DisplayMember = "Text"
        Me.tb_vendedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_vendedor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_vendedor.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_vendedor.DropDownHeight = 130
        Me.tb_vendedor.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_vendedor.DropDownWidth = 199
        Me.tb_vendedor.Enabled = False
        Me.tb_vendedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_vendedor.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_vendedor.GridLineHorizontal = False
        Me.tb_vendedor.GridLineVertical = False
        Me.tb_vendedor.IntegralHeight = False
        Me.tb_vendedor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_vendedor.Location = New System.Drawing.Point(448, 46)
        Me.tb_vendedor.ManagingFastMouseMoving = True
        Me.tb_vendedor.ManagingFastMouseMovingInterval = 30
        Me.tb_vendedor.MaxDropDownItems = 15
        Me.tb_vendedor.Name = "tb_vendedor"
        Me.tb_vendedor.Size = New System.Drawing.Size(190, 23)
        Me.tb_vendedor.TabIndex = 2
        Me.tb_vendedor.Text = "-Seleccione un Vendedor-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv_relaciones)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 600)
        Me.GroupBox3.TabIndex = 10009
        Me.GroupBox3.TabStop = False
        '
        'Dgv_relaciones
        '
        Me.Dgv_relaciones.AllowUserToAddRows = False
        Me.Dgv_relaciones.AllowUserToDeleteRows = False
        Me.Dgv_relaciones.AllowUserToResizeColumns = False
        Me.Dgv_relaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Dgv_relaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_relaciones.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Dgv_relaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_relaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Transporte})
        Me.Dgv_relaciones.Location = New System.Drawing.Point(6, 26)
        Me.Dgv_relaciones.MultiSelect = False
        Me.Dgv_relaciones.Name = "Dgv_relaciones"
        Me.Dgv_relaciones.ReadOnly = True
        Me.Dgv_relaciones.RowHeadersVisible = False
        Me.Dgv_relaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_relaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_relaciones.Size = New System.Drawing.Size(313, 568)
        Me.Dgv_relaciones.TabIndex = 10004
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cod. Relacion"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 105
        '
        'Transporte
        '
        Me.Transporte.HeaderText = "Vendedor"
        Me.Transporte.Name = "Transporte"
        Me.Transporte.ReadOnly = True
        Me.Transporte.Width = 185
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(0, -1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(325, 24)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Relaciones"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dd_relacion
        '
        Me.Dd_relacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dd_relacion.FormattingEnabled = True
        Me.Dd_relacion.Location = New System.Drawing.Point(3, 74)
        Me.Dd_relacion.Name = "Dd_relacion"
        Me.Dd_relacion.Size = New System.Drawing.Size(174, 22)
        Me.Dd_relacion.TabIndex = 10008
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(183, 73)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(145, 23)
        Me.tb_buscarcodigo.TabIndex = 1
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(5, 6)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(278, 57)
        Me.ToolBar1.TabIndex = 10006
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_imprimir
        '
        Me.bt_imprimir.ImageIndex = 6
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Text = "Imprimir"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 4
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "Printer.png")
        '
        'tb_codigo
        '
        Me.tb_codigo.Location = New System.Drawing.Point(448, 17)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(44, 21)
        Me.tb_codigo.TabIndex = 10010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 10011
        Me.Label5.Text = "Cod. Guía:"
        '
        'tb_aprobada
        '
        Me.tb_aprobada.Location = New System.Drawing.Point(448, 103)
        Me.tb_aprobada.Name = "tb_aprobada"
        Me.tb_aprobada.ReadOnly = True
        Me.tb_aprobada.Size = New System.Drawing.Size(190, 21)
        Me.tb_aprobada.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 14)
        Me.Label2.TabIndex = 10012
        Me.Label2.Text = "(*)Aprobada por:"
        '
        'tb_enviada
        '
        Me.tb_enviada.Location = New System.Drawing.Point(749, 46)
        Me.tb_enviada.Name = "tb_enviada"
        Me.tb_enviada.ReadOnly = True
        Me.tb_enviada.Size = New System.Drawing.Size(137, 21)
        Me.tb_enviada.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 10014
        Me.Label4.Text = "(*)Enviado por:"
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(749, 17)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(117, 21)
        Me.dtp1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(655, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 10016
        Me.Label6.Text = "Fecha:"
        '
        'tb_guia
        '
        Me.tb_guia.Location = New System.Drawing.Point(448, 129)
        Me.tb_guia.Name = "tb_guia"
        Me.tb_guia.ReadOnly = True
        Me.tb_guia.Size = New System.Drawing.Size(190, 21)
        Me.tb_guia.TabIndex = 10017
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 10018
        Me.Label9.Text = "Nro. De Guía:"
        '
        'chk_confirmada
        '
        Me.chk_confirmada.AutoSize = True
        Me.chk_confirmada.Enabled = False
        Me.chk_confirmada.Location = New System.Drawing.Point(747, 135)
        Me.chk_confirmada.Name = "chk_confirmada"
        Me.chk_confirmada.Size = New System.Drawing.Size(144, 18)
        Me.chk_confirmada.TabIndex = 10019
        Me.chk_confirmada.Text = "Recepción confirmada"
        Me.chk_confirmada.UseVisualStyleBackColor = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Doc."
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'CodFactura
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodFactura.DefaultCellStyle = DataGridViewCellStyle7
        Me.CodFactura.HeaderText = "N° Control"
        Me.CodFactura.Name = "CodFactura"
        Me.CodFactura.ReadOnly = True
        Me.CodFactura.Width = 105
        '
        'CodCliente
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodCliente.DefaultCellStyle = DataGridViewCellStyle8
        Me.CodCliente.HeaderText = "Cod. Cliente"
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.ReadOnly = True
        Me.CodCliente.Width = 95
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razón Social"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 237
        '
        'MontoFactura
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.MontoFactura.DefaultCellStyle = DataGridViewCellStyle9
        Me.MontoFactura.HeaderText = "Monto"
        Me.MontoFactura.Name = "MontoFactura"
        Me.MontoFactura.ReadOnly = True
        Me.MontoFactura.Width = 75
        '
        'Cod
        '
        Me.Cod.HeaderText = "Column1"
        Me.Cod.Name = "Cod"
        Me.Cod.Visible = False
        '
        'Frm_Relacion_Facturas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 714)
        Me.Controls.Add(Me.chk_confirmada)
        Me.Controls.Add(Me.tb_guia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_enviada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_aprobada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Dd_relacion)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.tb_vendedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_observ)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.lb_asociacion)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.tb_elaborada)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(130, 129)
        Me.MaximizeBox = False
        Me.Name = "Frm_Relacion_Facturas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relación Facturas"
        CType(Me.DGV_Docs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.lb_asociacion.ResumeLayout(False)
        CType(Me.DGV_relacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv_relaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Docs As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_elaborada As System.Windows.Forms.TextBox
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_asociacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents DGV_relacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_observ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_vendedor As MTGCComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv_relaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Dd_relacion As System.Windows.Forms.ComboBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_aprobada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_enviada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Transporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb_chequesDev As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NC As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fact As System.Windows.Forms.RadioButton
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Raz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents chk_confirmada As System.Windows.Forms.CheckBox
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
