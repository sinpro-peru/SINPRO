<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ajustes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ajustes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Ajustes = New System.Windows.Forms.DataGridView
        Me.CodigoAjusteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplvAjustesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cb_almacenes = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.cb_cuartos = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_conteo = New System.Windows.Forms.RadioButton
        Me.rb_cantidad = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl_MontoT = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_MontoA = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_MontoE = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.tb_Usuario = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Tb_Descripcion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Asociados = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.esta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_Inventario = New Tesis_Nueva.MyDataGridView2
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Sp_lvAjustesTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_lvAjustesTableAdapter
        Me.Sp_ConsultaProductosAjusteInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ConsultaProductosAjusteInvTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaProductosAjusteInvTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DGV_Ajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplvAjustesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Asociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_ConsultaProductosAjusteInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Ajustes
        '
        Me.DGV_Ajustes.AllowUserToAddRows = False
        Me.DGV_Ajustes.AllowUserToDeleteRows = False
        Me.DGV_Ajustes.AllowUserToResizeColumns = False
        Me.DGV_Ajustes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Ajustes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Ajustes.AutoGenerateColumns = False
        Me.DGV_Ajustes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Ajustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ajustes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoAjusteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DGV_Ajustes.DataSource = Me.SplvAjustesBindingSource
        Me.DGV_Ajustes.EnableHeadersVisualStyles = False
        Me.DGV_Ajustes.Location = New System.Drawing.Point(6, 101)
        Me.DGV_Ajustes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_Ajustes.MultiSelect = False
        Me.DGV_Ajustes.Name = "DGV_Ajustes"
        Me.DGV_Ajustes.ReadOnly = True
        Me.DGV_Ajustes.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Ajustes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Ajustes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Ajustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ajustes.Size = New System.Drawing.Size(247, 565)
        Me.DGV_Ajustes.TabIndex = 10014
        '
        'CodigoAjusteDataGridViewTextBoxColumn
        '
        Me.CodigoAjusteDataGridViewTextBoxColumn.DataPropertyName = "CodigoAjuste"
        Me.CodigoAjusteDataGridViewTextBoxColumn.HeaderText = "Cod."
        Me.CodigoAjusteDataGridViewTextBoxColumn.Name = "CodigoAjusteDataGridViewTextBoxColumn"
        Me.CodigoAjusteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoAjusteDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 175
        '
        'SplvAjustesBindingSource
        '
        Me.SplvAjustesBindingSource.DataMember = "sp_lvAjustes"
        Me.SplvAjustesBindingSource.DataSource = Me.MELDataSetBindingSource
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(141, 68)
        Me.tb_buscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(110, 25)
        Me.tb_buscar.TabIndex = 10001
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(438, -66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(759, 25)
        Me.Label6.TabIndex = 10006
        Me.Label6.Text = "Datos del Pedido"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(6, 5)
        Me.ToolBar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(243, 59)
        Me.ToolBar1.TabIndex = 10010
        Me.ToolBar1.Wrappable = False
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
        Me.bt_eliminar.Visible = False
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
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(256, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(774, 22)
        Me.Label3.TabIndex = 10017
        Me.Label3.Text = "Detalles del ajuste"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.Panel2)
        Me.groupbox1.Controls.Add(Me.Panel1)
        Me.groupbox1.Controls.Add(Me.GroupBox4)
        Me.groupbox1.Controls.Add(Me.tb_Usuario)
        Me.groupbox1.Controls.Add(Me.Label11)
        Me.groupbox1.Controls.Add(Me.dtp_fecha)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Tb_Descripcion)
        Me.groupbox1.Controls.Add(Me.Label14)
        Me.groupbox1.Controls.Add(Me.tb_codigo)
        Me.groupbox1.Controls.Add(Me.Label10)
        Me.groupbox1.Location = New System.Drawing.Point(256, 9)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Size = New System.Drawing.Size(774, 151)
        Me.groupbox1.TabIndex = 10018
        Me.groupbox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cb_almacenes)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.cb_cuartos)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Enabled = False
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(4, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 29)
        Me.Panel2.TabIndex = 77
        '
        'cb_almacenes
        '
        Me.cb_almacenes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacenes.DisplayMember = "Nombre"
        Me.cb_almacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacenes.Enabled = False
        Me.cb_almacenes.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_almacenes.FormattingEnabled = True
        Me.cb_almacenes.Location = New System.Drawing.Point(153, 2)
        Me.cb_almacenes.Name = "cb_almacenes"
        Me.cb_almacenes.Size = New System.Drawing.Size(103, 22)
        Me.cb_almacenes.TabIndex = 105
        Me.cb_almacenes.ValueMember = "Id"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(2, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 18)
        Me.CheckBox1.TabIndex = 108
        Me.CheckBox1.Text = "Filtrar por:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cb_cuartos
        '
        Me.cb_cuartos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuartos.Enabled = False
        Me.cb_cuartos.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_cuartos.FormattingEnabled = True
        Me.cb_cuartos.Location = New System.Drawing.Point(319, 2)
        Me.cb_cuartos.Name = "cb_cuartos"
        Me.cb_cuartos.Size = New System.Drawing.Size(103, 22)
        Me.cb_cuartos.TabIndex = 106
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label15.Location = New System.Drawing.Point(258, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "(*)Cuarto:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(81, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "(*)Almacén:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rb_conteo)
        Me.Panel1.Controls.Add(Me.rb_cantidad)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(4, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 27)
        Me.Panel1.TabIndex = 76
        '
        'rb_conteo
        '
        Me.rb_conteo.AutoSize = True
        Me.rb_conteo.Location = New System.Drawing.Point(94, 3)
        Me.rb_conteo.Name = "rb_conteo"
        Me.rb_conteo.Size = New System.Drawing.Size(83, 18)
        Me.rb_conteo.TabIndex = 1
        Me.rb_conteo.TabStop = True
        Me.rb_conteo.Text = "Por conteo"
        Me.rb_conteo.UseVisualStyleBackColor = True
        '
        'rb_cantidad
        '
        Me.rb_cantidad.AutoSize = True
        Me.rb_cantidad.Location = New System.Drawing.Point(3, 4)
        Me.rb_cantidad.Name = "rb_cantidad"
        Me.rb_cantidad.Size = New System.Drawing.Size(92, 18)
        Me.rb_cantidad.TabIndex = 0
        Me.rb_cantidad.TabStop = True
        Me.rb_cantidad.Text = "Por cantidad"
        Me.rb_cantidad.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_MontoT)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lbl_MontoA)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lbl_MontoE)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(563, 13)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(205, 91)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen"
        '
        'lbl_MontoT
        '
        Me.lbl_MontoT.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MontoT.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoT.Location = New System.Drawing.Point(105, 68)
        Me.lbl_MontoT.Name = "lbl_MontoT"
        Me.lbl_MontoT.Size = New System.Drawing.Size(87, 17)
        Me.lbl_MontoT.TabIndex = 115
        Me.lbl_MontoT.Text = "0.00"
        Me.lbl_MontoT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Total Ajuste:"
        '
        'lbl_MontoA
        '
        Me.lbl_MontoA.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoA.ForeColor = System.Drawing.Color.Black
        Me.lbl_MontoA.Location = New System.Drawing.Point(108, 17)
        Me.lbl_MontoA.Name = "lbl_MontoA"
        Me.lbl_MontoA.Size = New System.Drawing.Size(84, 17)
        Me.lbl_MontoA.TabIndex = 113
        Me.lbl_MontoA.Text = "0.00"
        Me.lbl_MontoA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Ajustes Positivos:"
        '
        'lbl_MontoE
        '
        Me.lbl_MontoE.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MontoE.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoE.Location = New System.Drawing.Point(108, 42)
        Me.lbl_MontoE.Name = "lbl_MontoE"
        Me.lbl_MontoE.Size = New System.Drawing.Size(84, 17)
        Me.lbl_MontoE.TabIndex = 112
        Me.lbl_MontoE.Text = "0.00"
        Me.lbl_MontoE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Ajustes Negativos:"
        '
        'tb_Usuario
        '
        Me.tb_Usuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_Usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Usuario.Location = New System.Drawing.Point(85, 41)
        Me.tb_Usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_Usuario.Name = "tb_Usuario"
        Me.tb_Usuario.ReadOnly = True
        Me.tb_Usuario.Size = New System.Drawing.Size(112, 22)
        Me.tb_Usuario.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "(*)Usuario:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(324, 19)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 22)
        Me.dtp_fecha.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(218, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "(*)Fecha:"
        '
        'Tb_Descripcion
        '
        Me.Tb_Descripcion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tb_Descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Descripcion.Location = New System.Drawing.Point(324, 42)
        Me.Tb_Descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tb_Descripcion.Multiline = True
        Me.Tb_Descripcion.Name = "Tb_Descripcion"
        Me.Tb_Descripcion.ReadOnly = True
        Me.Tb_Descripcion.Size = New System.Drawing.Size(231, 61)
        Me.Tb_Descripcion.TabIndex = 69
        Me.Tb_Descripcion.Text = " "
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(218, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 17)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "(*)Descripción:"
        '
        'tb_codigo
        '
        Me.tb_codigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(85, 17)
        Me.tb_codigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(112, 22)
        Me.tb_codigo.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "(*)Código:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(256, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(774, 24)
        Me.Label4.TabIndex = 10020
        Me.Label4.Text = "Productos en Inventario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(696, 681)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10023
        Me.Button1.Text = "Cancelar"
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(610, 681)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 10022
        Me.Button2.Text = "Aceptar"
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 674)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 10025
        Me.Label5.Text = "#"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 674)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 10024
        Me.Label8.Text = "Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DGV_Asociados)
        Me.GroupBox3.Location = New System.Drawing.Point(256, 407)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(774, 259)
        Me.GroupBox3.TabIndex = 10019
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(768, 23)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Productos Asociados al ajuse"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Asociados
        '
        Me.DGV_Asociados.AllowUserToAddRows = False
        Me.DGV_Asociados.AllowUserToResizeColumns = False
        Me.DGV_Asociados.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.DGV_Asociados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Asociados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Asociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Asociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.Precio, Me.esta, Me.SubTotal})
        Me.DGV_Asociados.EnableHeadersVisualStyles = False
        Me.DGV_Asociados.Location = New System.Drawing.Point(4, 25)
        Me.DGV_Asociados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_Asociados.MultiSelect = False
        Me.DGV_Asociados.Name = "DGV_Asociados"
        Me.DGV_Asociados.ReadOnly = True
        Me.DGV_Asociados.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Asociados.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Asociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Asociados.Size = New System.Drawing.Size(764, 230)
        Me.DGV_Asociados.TabIndex = 10001
        '
        'DataGridViewTextBoxColumn18
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn18.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 45
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn19.MaxInputLength = 200
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 173
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 85
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 190
        '
        'DataGridViewTextBoxColumn22
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn22.HeaderText = "Exis."
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 45
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 117
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Ubi."
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 85
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "CodigoTramo"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'Precio
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 60
        '
        'esta
        '
        Me.esta.HeaderText = "esta"
        Me.esta.Name = "esta"
        Me.esta.ReadOnly = True
        Me.esta.Visible = False
        '
        'SubTotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 70
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DGV_Inventario)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 175)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(774, 228)
        Me.GroupBox2.TabIndex = 10021
        Me.GroupBox2.TabStop = False
        '
        'DGV_Inventario
        '
        Me.DGV_Inventario.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Inventario.Location = New System.Drawing.Point(8, 14)
        Me.DGV_Inventario.Name = "DGV_Inventario"
        Me.DGV_Inventario.Size = New System.Drawing.Size(760, 209)
        Me.DGV_Inventario.TabIndex = 0
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Items.AddRange(New Object() {"Código Ajuste", "Usuario", "Código Interno"})
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 69)
        Me.DomainUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(130, 23)
        Me.DomainUpDown1.TabIndex = 10026
        '
        'Sp_lvAjustesTableAdapter
        '
        Me.Sp_lvAjustesTableAdapter.ClearBeforeFill = True
        '
        'Sp_ConsultaProductosAjusteInvBindingSource
        '
        Me.Sp_ConsultaProductosAjusteInvBindingSource.DataMember = "sp_ConsultaProductosAjusteInv"
        Me.Sp_ConsultaProductosAjusteInvBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_ConsultaProductosAjusteInvTableAdapter
        '
        Me.Sp_ConsultaProductosAjusteInvTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Observacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodigoInterno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodigoInterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Exist_"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Exist_"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ubicacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CodigoTramo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CodigoTramo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodigoProductoF"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CodigoProductoF"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cuartoId"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cuartoId"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "almacenId"
        Me.DataGridViewTextBoxColumn11.HeaderText = "almacenId"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PrecioVenta"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PrecioVenta"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(975, 168)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(14, 14)
        Me.lb_total.TabIndex = 10028
        Me.lb_total.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(934, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 14)
        Me.Label17.TabIndex = 10027
        Me.Label17.Text = "Total:"
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.BackColor = System.Drawing.Color.DodgerBlue
        Me.chk_exist.Enabled = False
        Me.chk_exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.chk_exist.ForeColor = System.Drawing.Color.White
        Me.chk_exist.Location = New System.Drawing.Point(263, 164)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(73, 18)
        Me.chk_exist.TabIndex = 109
        Me.chk_exist.Text = "Exist. > 0"
        Me.chk_exist.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "excel.png"
        Me.Button3.Location = New System.Drawing.Point(264, 671)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 36)
        Me.Button3.TabIndex = 10029
        '
        'Frm_Ajustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1033, 724)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chk_exist)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.DGV_Ajustes)
        Me.Controls.Add(Me.tb_buscar)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Ajustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes de inventario"
        CType(Me.DGV_Ajustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplvAjustesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_Asociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Inventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_ConsultaProductosAjusteInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Ajustes As System.Windows.Forms.DataGridView
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tb_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MontoT As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_MontoA As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_MontoE As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Asociados As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_conteo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cantidad As System.Windows.Forms.RadioButton
    Friend WithEvents cb_almacenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cb_cuartos As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SplvAjustesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_lvAjustesTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_lvAjustesTableAdapter
    Friend WithEvents CodigoAjusteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sp_ConsultaProductosAjusteInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_ConsultaProductosAjusteInvTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaProductosAjusteInvTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents esta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DGV_Inventario As Tesis_Nueva.MyDataGridView2
End Class
