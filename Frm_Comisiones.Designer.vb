<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Comisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Comisiones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DGV_comisiones = New System.Windows.Forms.DataGridView
        Me.Recibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BancoD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Base = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.por = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarVendedorFactMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label16 = New System.Windows.Forms.Label
        Me.tb_vendedor = New MTGCComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_fecha1 = New System.Windows.Forms.DateTimePicker
        Me.tb_fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DGV_pagadas = New System.Windows.Forms.DataGridView
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Recibos = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.lb_mes = New System.Windows.Forms.Label
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.lb_codigo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_header = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lb_totalP = New System.Windows.Forms.Label
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.DGV_comisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DGV_pagadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-1, 1)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(352, 65)
        Me.ToolBar1.TabIndex = 1
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
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
        '
        'bt_imprimir
        '
        Me.bt_imprimir.ImageKey = "icono-impresion.gif"
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
        Me.ImageList2.Images.SetKeyName(5, "icono-impresion.gif")
        Me.ImageList2.Images.SetKeyName(6, "ok.gif")
        Me.ImageList2.Images.SetKeyName(7, "box3.png")
        '
        'DGV_comisiones
        '
        Me.DGV_comisiones.AllowUserToAddRows = False
        Me.DGV_comisiones.AllowUserToDeleteRows = False
        Me.DGV_comisiones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_comisiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_comisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Recibo, Me.DataGridViewTextBoxColumn1, Me.CodC, Me.Cliente, Me.BancoD, Me.DataGridViewTextBoxColumn2, Me.FechaDeposito, Me.DataGridViewTextBoxColumn4, Me.Base, Me.MontoDep, Me.por, Me.Comision, Me.codR, Me.codF})
        Me.DGV_comisiones.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV_comisiones.Location = New System.Drawing.Point(6, 333)
        Me.DGV_comisiones.MultiSelect = False
        Me.DGV_comisiones.Name = "DGV_comisiones"
        Me.DGV_comisiones.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_comisiones.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_comisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_comisiones.ShowEditingIcon = False
        Me.DGV_comisiones.Size = New System.Drawing.Size(1015, 347)
        Me.DGV_comisiones.TabIndex = 77
        '
        'Recibo
        '
        Me.Recibo.HeaderText = "Recibo"
        Me.Recibo.Name = "Recibo"
        Me.Recibo.ReadOnly = True
        Me.Recibo.Width = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'CodC
        '
        Me.CodC.HeaderText = "Cod."
        Me.CodC.Name = "CodC"
        Me.CodC.ReadOnly = True
        Me.CodC.Width = 57
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 210
        '
        'BancoD
        '
        Me.BancoD.HeaderText = "Banco D"
        Me.BancoD.Name = "BancoD"
        Me.BancoD.ReadOnly = True
        Me.BancoD.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fact"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'FechaDeposito
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaDeposito.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDeposito.HeaderText = "Dep."
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.ReadOnly = True
        Me.FechaDeposito.Width = 83
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 47
        '
        'Base
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Base.DefaultCellStyle = DataGridViewCellStyle4
        Me.Base.HeaderText = "Base"
        Me.Base.Name = "Base"
        Me.Base.ReadOnly = True
        Me.Base.Width = 80
        '
        'MontoDep
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MontoDep.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoDep.HeaderText = "Monto D"
        Me.MontoDep.Name = "MontoDep"
        Me.MontoDep.ReadOnly = True
        Me.MontoDep.Width = 95
        '
        'por
        '
        Me.por.HeaderText = "%"
        Me.por.Name = "por"
        Me.por.ReadOnly = True
        Me.por.Width = 43
        '
        'Comision
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Comision.DefaultCellStyle = DataGridViewCellStyle6
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        Me.Comision.Width = 83
        '
        'codR
        '
        Me.codR.HeaderText = "codR"
        Me.codR.Name = "codR"
        Me.codR.ReadOnly = True
        Me.codR.Visible = False
        '
        'codF
        '
        Me.codF.HeaderText = "codF"
        Me.codF.Name = "codF"
        Me.codF.ReadOnly = True
        Me.codF.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarVendedorFactMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 26)
        '
        'EditarVendedorFactMenuItem
        '
        Me.EditarVendedorFactMenuItem.Name = "EditarVendedorFactMenuItem"
        Me.EditarVendedorFactMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EditarVendedorFactMenuItem.Text = "Mover a Vendedor ..."
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(6, 311)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1017, 23)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Comisiones"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tb_vendedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_vendedor.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_vendedor.GridLineHorizontal = False
        Me.tb_vendedor.GridLineVertical = False
        Me.tb_vendedor.IntegralHeight = False
        Me.tb_vendedor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_vendedor.Location = New System.Drawing.Point(140, 35)
        Me.tb_vendedor.ManagingFastMouseMoving = True
        Me.tb_vendedor.ManagingFastMouseMovingInterval = 30
        Me.tb_vendedor.MaxDropDownItems = 15
        Me.tb_vendedor.Name = "tb_vendedor"
        Me.tb_vendedor.Size = New System.Drawing.Size(190, 23)
        Me.tb_vendedor.TabIndex = 2
        Me.tb_vendedor.Text = "-Seleccione un Vendedor-"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Vendedor:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(72, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 19)
        Me.RadioButton1.TabIndex = 79
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(72, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton2.TabIndex = 80
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mes Anterior"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(72, 78)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(45, 19)
        Me.RadioButton3.TabIndex = 81
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "De:"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Período:"
        '
        'tb_fecha1
        '
        Me.tb_fecha1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fecha1.Location = New System.Drawing.Point(118, 75)
        Me.tb_fecha1.Name = "tb_fecha1"
        Me.tb_fecha1.Size = New System.Drawing.Size(106, 22)
        Me.tb_fecha1.TabIndex = 83
        '
        'tb_fecha2
        '
        Me.tb_fecha2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fecha2.Location = New System.Drawing.Point(273, 74)
        Me.tb_fecha2.Name = "tb_fecha2"
        Me.tb_fecha2.Size = New System.Drawing.Size(110, 22)
        Me.tb_fecha2.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Hasta:"
        '
        'DGV_pagadas
        '
        Me.DGV_pagadas.AllowUserToAddRows = False
        Me.DGV_pagadas.AllowUserToResizeRows = False
        Me.DGV_pagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_pagadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Fecha, Me.Venc, Me.Dias, Me.Monto})
        Me.DGV_pagadas.Location = New System.Drawing.Point(473, 84)
        Me.DGV_pagadas.Name = "DGV_pagadas"
        Me.DGV_pagadas.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_pagadas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_pagadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_pagadas.ShowEditingIcon = False
        Me.DGV_pagadas.Size = New System.Drawing.Size(545, 192)
        Me.DGV_pagadas.TabIndex = 86
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 65
        '
        'Fecha
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle8
        Me.Fecha.HeaderText = "Fecha Pago"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 120
        '
        'Venc
        '
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Venc.DefaultCellStyle = DataGridViewCellStyle9
        Me.Venc.HeaderText = "Fecha I"
        Me.Venc.Name = "Venc"
        Me.Venc.ReadOnly = True
        Me.Venc.Width = 90
        '
        'Dias
        '
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Dias.DefaultCellStyle = DataGridViewCellStyle10
        Me.Dias.HeaderText = "Fecha F"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 90
        '
        'Monto
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle11
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 90
        '
        'DGV_Recibos
        '
        Me.DGV_Recibos.AllowUserToAddRows = False
        Me.DGV_Recibos.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DGV_Recibos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DGV_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.Observaciones})
        Me.DGV_Recibos.Location = New System.Drawing.Point(472, 84)
        Me.DGV_Recibos.Name = "DGV_Recibos"
        Me.DGV_Recibos.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Recibos.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGV_Recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Recibos.ShowEditingIcon = False
        Me.DGV_Recibos.Size = New System.Drawing.Size(545, 192)
        Me.DGV_Recibos.TabIndex = 87
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Recibo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 68
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha D."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 95
        '
        'DataGridViewTextBoxColumn9
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn9.HeaderText = "Monto D."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 95
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 200
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(180, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lb_mes
        '
        Me.lb_mes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mes.Location = New System.Drawing.Point(170, 49)
        Me.lb_mes.Name = "lb_mes"
        Me.lb_mes.Size = New System.Drawing.Size(130, 23)
        Me.lb_mes.TabIndex = 89
        Me.lb_mes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar.Image = CType(resources.GetObject("bt_agregar.Image"), System.Drawing.Image)
        Me.bt_agregar.Location = New System.Drawing.Point(719, 277)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(53, 33)
        Me.bt_agregar.TabIndex = 90
        Me.bt_agregar.UseVisualStyleBackColor = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(457, 686)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 91
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(544, 686)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 92
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(830, 686)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Total:"
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_total.Location = New System.Drawing.Point(884, 686)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(44, 19)
        Me.lb_total.TabIndex = 94
        Me.lb_total.Text = "0,00"
        Me.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(118, 30)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(50, 15)
        Me.lb_codigo.TabIndex = 95
        Me.lb_codigo.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Código Comisión:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lb_codigo)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lb_mes)
        Me.GroupBox1.Controls.Add(Me.tb_fecha1)
        Me.GroupBox1.Controls.Add(Me.tb_fecha2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 154)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(-2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(411, 23)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Detalle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb_vendedor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 72)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(-2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(411, 23)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Búsqueda"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_header
        '
        Me.lb_header.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_header.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lb_header.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_header.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_header.Location = New System.Drawing.Point(472, 64)
        Me.lb_header.Name = "lb_header"
        Me.lb_header.Size = New System.Drawing.Size(546, 23)
        Me.lb_header.TabIndex = 100
        Me.lb_header.Text = "Comisiones Pagadas"
        Me.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(882, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Total:"
        '
        'lb_totalP
        '
        Me.lb_totalP.AutoSize = True
        Me.lb_totalP.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_totalP.Location = New System.Drawing.Point(934, 285)
        Me.lb_totalP.Name = "lb_totalP"
        Me.lb_totalP.Size = New System.Drawing.Size(44, 19)
        Me.lb_totalP.TabIndex = 102
        Me.lb_totalP.Text = "0,00"
        Me.lb_totalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(9, 18)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(56, 18)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Todas"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(72, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(95, 18)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "Comisión = 0"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(472, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 42)
        Me.GroupBox3.TabIndex = 104
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles impresión"
        '
        'Frm_Comisiones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1028, 714)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lb_totalP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lb_header)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.DGV_comisiones)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.DGV_pagadas)
        Me.Controls.Add(Me.DGV_Recibos)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.Name = "Frm_Comisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Comisiones"
        CType(Me.DGV_comisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DGV_pagadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents DGV_comisiones As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tb_vendedor As MTGCComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV_pagadas As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Recibos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_mes As System.Windows.Forms.Label
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_header As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lb_totalP As System.Windows.Forms.Label
    Friend WithEvents Recibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Base As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents por As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarVendedorFactMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
