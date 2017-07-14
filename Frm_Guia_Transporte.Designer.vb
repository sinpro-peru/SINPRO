<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Guia_Transporte
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Guia_Transporte))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Fac = New System.Windows.Forms.DataGridView
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Raz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bultos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodPed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_elaborada = New System.Windows.Forms.TextBox
        Me.tb_ci = New System.Windows.Forms.TextBox
        Me.tb_aprobada = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Lb_asoc = New System.Windows.Forms.Label
        Me.DGV_Guia = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Flete = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rif = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tlf = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodPedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tb_puntos = New System.Windows.Forms.TextBox
        Me.tb_observ = New System.Windows.Forms.TextBox
        Me.cb_Transportistas = New System.Windows.Forms.ComboBox
        Me.cb_Transporte = New System.Windows.Forms.ComboBox
        Me.SpVerTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Label11 = New System.Windows.Forms.Label
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_VerTransporteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_VerTransporteTableAdapter
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_todas = New System.Windows.Forms.RadioButton
        Me.rb_demas = New System.Windows.Forms.RadioButton
        Me.rb_Capital = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Dd_guia = New System.Windows.Forms.ComboBox
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Lb_fact = New System.Windows.Forms.Label
        Me.Dgv_guias = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Transporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tb_camion = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.lb_total = New System.Windows.Forms.Label
        Me.lb_totalFact = New System.Windows.Forms.Label
        CType(Me.DGV_Fac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Guia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpVerTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv_guias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Fac
        '
        Me.DGV_Fac.AllowUserToAddRows = False
        Me.DGV_Fac.AllowUserToDeleteRows = False
        Me.DGV_Fac.AllowUserToResizeColumns = False
        Me.DGV_Fac.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Fac.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Fac.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Fac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.fac, Me.Factura, Me.CCliente, Me.Raz, Me.Bultos, Me.Monto, Me.CodPed})
        Me.DGV_Fac.Location = New System.Drawing.Point(388, 215)
        Me.DGV_Fac.Name = "DGV_Fac"
        Me.DGV_Fac.ReadOnly = True
        Me.DGV_Fac.RowHeadersVisible = False
        Me.DGV_Fac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Fac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Fac.Size = New System.Drawing.Size(631, 199)
        Me.DGV_Fac.TabIndex = 11
        '
        'Fecha
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 90
        '
        'fac
        '
        Me.fac.HeaderText = "N° Factura"
        Me.fac.Name = "fac"
        Me.fac.ReadOnly = True
        Me.fac.Visible = False
        Me.fac.Width = 88
        '
        'Factura
        '
        Me.Factura.HeaderText = "N° Control"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Factura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Factura.Width = 110
        '
        'CCliente
        '
        Me.CCliente.HeaderText = "Cod. Cliente"
        Me.CCliente.Name = "CCliente"
        Me.CCliente.ReadOnly = True
        '
        'Raz
        '
        Me.Raz.HeaderText = "Razón Social"
        Me.Raz.Name = "Raz"
        Me.Raz.ReadOnly = True
        Me.Raz.Width = 150
        '
        'Bultos
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Bultos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Bultos.HeaderText = "Bultos"
        Me.Bultos.Name = "Bultos"
        Me.Bultos.ReadOnly = True
        Me.Bultos.Width = 55
        '
        'Monto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 95
        '
        'CodPed
        '
        Me.CodPed.HeaderText = "CodPed"
        Me.CodPed.Name = "CodPed"
        Me.CodPed.ReadOnly = True
        Me.CodPed.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transportista:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Camión:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(678, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Elaborada por:"
        '
        'tb_elaborada
        '
        Me.tb_elaborada.Enabled = False
        Me.tb_elaborada.Location = New System.Drawing.Point(767, 59)
        Me.tb_elaborada.Name = "tb_elaborada"
        Me.tb_elaborada.Size = New System.Drawing.Size(137, 21)
        Me.tb_elaborada.TabIndex = 7
        '
        'tb_ci
        '
        Me.tb_ci.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_ci.Enabled = False
        Me.tb_ci.Location = New System.Drawing.Point(480, 90)
        Me.tb_ci.Name = "tb_ci"
        Me.tb_ci.ReadOnly = True
        Me.tb_ci.Size = New System.Drawing.Size(104, 21)
        Me.tb_ci.TabIndex = 4
        '
        'tb_aprobada
        '
        Me.tb_aprobada.Enabled = False
        Me.tb_aprobada.Location = New System.Drawing.Point(767, 34)
        Me.tb_aprobada.Name = "tb_aprobada"
        Me.tb_aprobada.Size = New System.Drawing.Size(137, 21)
        Me.tb_aprobada.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "C.I.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(678, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Aprobada por:"
        '
        'Lb_asoc
        '
        Me.Lb_asoc.BackColor = System.Drawing.Color.DodgerBlue
        Me.Lb_asoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_asoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lb_asoc.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_asoc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lb_asoc.Location = New System.Drawing.Point(388, 451)
        Me.Lb_asoc.Name = "Lb_asoc"
        Me.Lb_asoc.Size = New System.Drawing.Size(631, 23)
        Me.Lb_asoc.TabIndex = 70
        Me.Lb_asoc.Text = "Facturas Asociadas a la Guía"
        Me.Lb_asoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Guia
        '
        Me.DGV_Guia.AllowUserToAddRows = False
        Me.DGV_Guia.AllowUserToResizeColumns = False
        Me.DGV_Guia.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DGV_Guia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Guia.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Guia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Guia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.fact, Me.CodFactura, Me.CodCliente, Me.Razon, Me.DataGridViewTextBoxColumn2, Me.MontoFactura, Me.Flete, Me.Direccion, Me.Rif, Me.Tlf, Me.Ciudad, Me.CodPedido})
        Me.DGV_Guia.Location = New System.Drawing.Point(388, 472)
        Me.DGV_Guia.MultiSelect = False
        Me.DGV_Guia.Name = "DGV_Guia"
        Me.DGV_Guia.RowHeadersVisible = False
        Me.DGV_Guia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Guia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Guia.Size = New System.Drawing.Size(631, 211)
        Me.DGV_Guia.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 82
        '
        'fact
        '
        Me.fact.HeaderText = "N° Factura"
        Me.fact.Name = "fact"
        Me.fact.Visible = False
        Me.fact.Width = 84
        '
        'CodFactura
        '
        Me.CodFactura.HeaderText = "N° Control"
        Me.CodFactura.Name = "CodFactura"
        Me.CodFactura.Width = 91
        '
        'CodCliente
        '
        Me.CodCliente.HeaderText = "Cod. Cliente"
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.Width = 98
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razón Social"
        Me.Razon.Name = "Razon"
        Me.Razon.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bultos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 42
        '
        'MontoFactura
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.MontoFactura.DefaultCellStyle = DataGridViewCellStyle8
        Me.MontoFactura.HeaderText = "Monto"
        Me.MontoFactura.Name = "MontoFactura"
        Me.MontoFactura.Width = 77
        '
        'Flete
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Eras Bold ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Flete.DefaultCellStyle = DataGridViewCellStyle9
        Me.Flete.HeaderText = "Flete"
        Me.Flete.Items.AddRange(New Object() {"Cliente", "Origen"})
        Me.Flete.Name = "Flete"
        Me.Flete.Width = 73
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Visible = False
        '
        'Rif
        '
        Me.Rif.HeaderText = "rif"
        Me.Rif.Name = "Rif"
        Me.Rif.Visible = False
        '
        'Tlf
        '
        Me.Tlf.HeaderText = "Tlf"
        Me.Tlf.Name = "Tlf"
        Me.Tlf.Visible = False
        '
        'Ciudad
        '
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Visible = False
        '
        'CodPedido
        '
        Me.CodPedido.HeaderText = "CodPed"
        Me.CodPedido.Name = "CodPedido"
        Me.CodPedido.Visible = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(727, 687)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 13
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(623, 687)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.Color.White
        Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar.Image = CType(resources.GetObject("bt_agregar.Image"), System.Drawing.Image)
        Me.bt_agregar.Location = New System.Drawing.Point(675, 417)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(53, 30)
        Me.bt_agregar.TabIndex = 10
        Me.bt_agregar.UseVisualStyleBackColor = False
        Me.bt_agregar.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(678, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Ptos. Entrega:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(678, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 14)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Observaciones:"
        '
        'tb_puntos
        '
        Me.tb_puntos.Enabled = False
        Me.tb_puntos.Location = New System.Drawing.Point(767, 86)
        Me.tb_puntos.Name = "tb_puntos"
        Me.tb_puntos.Size = New System.Drawing.Size(100, 21)
        Me.tb_puntos.TabIndex = 8
        '
        'tb_observ
        '
        Me.tb_observ.Enabled = False
        Me.tb_observ.Location = New System.Drawing.Point(766, 112)
        Me.tb_observ.Multiline = True
        Me.tb_observ.Name = "tb_observ"
        Me.tb_observ.Size = New System.Drawing.Size(253, 69)
        Me.tb_observ.TabIndex = 9
        '
        'cb_Transportistas
        '
        Me.cb_Transportistas.DisplayMember = "Nombre"
        Me.cb_Transportistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Transportistas.Enabled = False
        Me.cb_Transportistas.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.cb_Transportistas.FormattingEnabled = True
        Me.cb_Transportistas.Location = New System.Drawing.Point(480, 61)
        Me.cb_Transportistas.Name = "cb_Transportistas"
        Me.cb_Transportistas.Size = New System.Drawing.Size(155, 22)
        Me.cb_Transportistas.TabIndex = 3
        Me.cb_Transportistas.ValueMember = "CodigoPreferencia"
        '
        'cb_Transporte
        '
        Me.cb_Transporte.DisplayMember = "CodigoTransporte"
        Me.cb_Transporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Transporte.Enabled = False
        Me.cb_Transporte.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.cb_Transporte.FormattingEnabled = True
        Me.cb_Transporte.Location = New System.Drawing.Point(480, 33)
        Me.cb_Transporte.Name = "cb_Transporte"
        Me.cb_Transporte.Size = New System.Drawing.Size(155, 22)
        Me.cb_Transporte.TabIndex = 2
        Me.cb_Transporte.ValueMember = "CodigoTransporte"
        '
        'SpVerTransporteBindingSource
        '
        Me.SpVerTransporteBindingSource.DataMember = "sp_VerTransporte"
        Me.SpVerTransporteBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 14)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Transporte:"
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'Sp_VerTransporteTableAdapter
        '
        Me.Sp_VerTransporteTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_todas)
        Me.GroupBox3.Controls.Add(Me.rb_demas)
        Me.GroupBox3.Controls.Add(Me.rb_Capital)
        Me.GroupBox3.Location = New System.Drawing.Point(392, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 42)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ver por regiones:"
        '
        'rb_todas
        '
        Me.rb_todas.AutoSize = True
        Me.rb_todas.Location = New System.Drawing.Point(176, 19)
        Me.rb_todas.Name = "rb_todas"
        Me.rb_todas.Size = New System.Drawing.Size(56, 18)
        Me.rb_todas.TabIndex = 2
        Me.rb_todas.TabStop = True
        Me.rb_todas.Text = "Todas"
        Me.rb_todas.UseVisualStyleBackColor = True
        '
        'rb_demas
        '
        Me.rb_demas.AutoSize = True
        Me.rb_demas.Location = New System.Drawing.Point(69, 19)
        Me.rb_demas.Name = "rb_demas"
        Me.rb_demas.Size = New System.Drawing.Size(109, 18)
        Me.rb_demas.TabIndex = 1
        Me.rb_demas.TabStop = True
        Me.rb_demas.Text = "Demás regiones"
        Me.rb_demas.UseVisualStyleBackColor = True
        '
        'rb_Capital
        '
        Me.rb_Capital.AutoSize = True
        Me.rb_Capital.Location = New System.Drawing.Point(6, 19)
        Me.rb_Capital.Name = "rb_Capital"
        Me.rb_Capital.Size = New System.Drawing.Size(62, 18)
        Me.rb_Capital.TabIndex = 0
        Me.rb_Capital.TabStop = True
        Me.rb_Capital.Text = "Capital"
        Me.rb_Capital.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cod. Guía:"
        '
        'tb_codigo
        '
        Me.tb_codigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_codigo.Location = New System.Drawing.Point(480, 5)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(44, 21)
        Me.tb_codigo.TabIndex = 1
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
        Me.ToolBar1.Location = New System.Drawing.Point(3, 5)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(278, 57)
        Me.ToolBar1.TabIndex = 96
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
        'Dd_guia
        '
        Me.Dd_guia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dd_guia.FormattingEnabled = True
        Me.Dd_guia.Location = New System.Drawing.Point(18, 70)
        Me.Dd_guia.Name = "Dd_guia"
        Me.Dd_guia.Size = New System.Drawing.Size(174, 22)
        Me.Dd_guia.TabIndex = 10003
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(198, 69)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(175, 23)
        Me.tb_buscarcodigo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(3, -1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(358, 24)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Guías"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_fact
        '
        Me.Lb_fact.BackColor = System.Drawing.Color.DodgerBlue
        Me.Lb_fact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_fact.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lb_fact.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_fact.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lb_fact.Location = New System.Drawing.Point(388, 192)
        Me.Lb_fact.Name = "Lb_fact"
        Me.Lb_fact.Size = New System.Drawing.Size(631, 24)
        Me.Lb_fact.TabIndex = 66
        Me.Lb_fact.Text = "Facturas"
        Me.Lb_fact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_guias
        '
        Me.Dgv_guias.AllowUserToAddRows = False
        Me.Dgv_guias.AllowUserToDeleteRows = False
        Me.Dgv_guias.AllowUserToResizeColumns = False
        Me.Dgv_guias.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Dgv_guias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_guias.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_guias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_guias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Transporte})
        Me.Dgv_guias.Location = New System.Drawing.Point(6, 26)
        Me.Dgv_guias.MultiSelect = False
        Me.Dgv_guias.Name = "Dgv_guias"
        Me.Dgv_guias.ReadOnly = True
        Me.Dgv_guias.RowHeadersVisible = False
        Me.Dgv_guias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_guias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_guias.Size = New System.Drawing.Size(349, 547)
        Me.Dgv_guias.TabIndex = 10004
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cod. Guía"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Transporte
        '
        Me.Transporte.HeaderText = "Transporte"
        Me.Transporte.Name = "Transporte"
        Me.Transporte.ReadOnly = True
        Me.Transporte.Width = 230
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_guias)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 587)
        Me.GroupBox1.TabIndex = 10005
        Me.GroupBox1.TabStop = False
        '
        'tb_camion
        '
        Me.tb_camion.DisplayMember = "CodigoTransporte"
        Me.tb_camion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_camion.Enabled = False
        Me.tb_camion.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.tb_camion.FormattingEnabled = True
        Me.tb_camion.Location = New System.Drawing.Point(480, 116)
        Me.tb_camion.Name = "tb_camion"
        Me.tb_camion.Size = New System.Drawing.Size(155, 22)
        Me.tb_camion.TabIndex = 5
        Me.tb_camion.ValueMember = "CodigoTransporte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(678, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 14)
        Me.Label7.TabIndex = 10006
        Me.Label7.Text = "Fecha:"
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(767, 6)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(117, 21)
        Me.dtp1.TabIndex = 10007
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(893, 456)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(83, 14)
        Me.lb_total.TabIndex = 10008
        Me.lb_total.Text = "Total Facturas:"
        '
        'lb_totalFact
        '
        Me.lb_totalFact.AutoSize = True
        Me.lb_totalFact.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_totalFact.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalFact.ForeColor = System.Drawing.Color.White
        Me.lb_totalFact.Location = New System.Drawing.Point(983, 455)
        Me.lb_totalFact.Name = "lb_totalFact"
        Me.lb_totalFact.Size = New System.Drawing.Size(14, 14)
        Me.lb_totalFact.TabIndex = 10009
        Me.lb_totalFact.Text = "#"
        '
        'Frm_Guia_Transporte
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 714)
        Me.Controls.Add(Me.lb_totalFact)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_camion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lb_asoc)
        Me.Controls.Add(Me.Lb_fact)
        Me.Controls.Add(Me.DGV_Guia)
        Me.Controls.Add(Me.DGV_Fac)
        Me.Controls.Add(Me.Dd_guia)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cb_Transporte)
        Me.Controls.Add(Me.cb_Transportistas)
        Me.Controls.Add(Me.tb_observ)
        Me.Controls.Add(Me.tb_puntos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_aprobada)
        Me.Controls.Add(Me.tb_ci)
        Me.Controls.Add(Me.tb_elaborada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(130, 129)
        Me.MaximizeBox = False
        Me.Name = "Frm_Guia_Transporte"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guía de Transporte"
        CType(Me.DGV_Fac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Guia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpVerTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Dgv_guias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Fac As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_elaborada As System.Windows.Forms.TextBox
    Friend WithEvents tb_ci As System.Windows.Forms.TextBox
    Friend WithEvents tb_aprobada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lb_asoc As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents DGV_Guia As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_puntos As System.Windows.Forms.TextBox
    Friend WithEvents tb_observ As System.Windows.Forms.TextBox
    Friend WithEvents cb_Transportistas As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Transporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpVerTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_VerTransporteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_VerTransporteTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_todas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_demas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Capital As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Dd_guia As System.Windows.Forms.ComboBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Lb_fact As System.Windows.Forms.Label
    Friend WithEvents Dgv_guias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Transporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_camion As System.Windows.Forms.ComboBox
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents lb_totalFact As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Raz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bultos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flete As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tlf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodPedido As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
