<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(s))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ti_fabricas = New System.Windows.Forms.Label
        Me.tb_decimales = New System.Windows.Forms.TextBox
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.chk_redondear = New System.Windows.Forms.CheckBox
        Me.rb_proveedor = New System.Windows.Forms.RadioButton
        Me.rb_grupo = New System.Windows.Forms.RadioButton
        Me.rb_marca = New System.Windows.Forms.RadioButton
        Me.tb_proveedor = New System.Windows.Forms.ComboBox
        Me.Chk_Exist = New System.Windows.Forms.CheckBox
        Me.cb_marca = New System.Windows.Forms.ComboBox
        Me.cb_grupo = New System.Windows.Forms.ComboBox
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioNuevoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaProductosVariacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_cantidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Sp_consultaProductosVariacionTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosVariacionTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductosVariacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ti_fabricas)
        Me.GroupBox1.Controls.Add(Me.tb_decimales)
        Me.GroupBox1.Controls.Add(Me.rb_todos)
        Me.GroupBox1.Controls.Add(Me.chk_redondear)
        Me.GroupBox1.Controls.Add(Me.rb_proveedor)
        Me.GroupBox1.Controls.Add(Me.rb_grupo)
        Me.GroupBox1.Controls.Add(Me.rb_marca)
        Me.GroupBox1.Controls.Add(Me.tb_proveedor)
        Me.GroupBox1.Controls.Add(Me.Chk_Exist)
        Me.GroupBox1.Controls.Add(Me.cb_marca)
        Me.GroupBox1.Controls.Add(Me.cb_grupo)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(669, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 14)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "decimales"
        '
        'ti_fabricas
        '
        Me.ti_fabricas.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_fabricas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_fabricas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_fabricas.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_fabricas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_fabricas.Location = New System.Drawing.Point(1, 0)
        Me.ti_fabricas.Name = "ti_fabricas"
        Me.ti_fabricas.Size = New System.Drawing.Size(750, 20)
        Me.ti_fabricas.TabIndex = 82
        Me.ti_fabricas.Text = "Filtros"
        Me.ti_fabricas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_decimales
        '
        Me.tb_decimales.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_decimales.Location = New System.Drawing.Point(636, 68)
        Me.tb_decimales.MaxLength = 7
        Me.tb_decimales.Name = "tb_decimales"
        Me.tb_decimales.Size = New System.Drawing.Size(29, 29)
        Me.tb_decimales.TabIndex = 120
        Me.tb_decimales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Location = New System.Drawing.Point(9, 29)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(132, 18)
        Me.rb_todos.TabIndex = 117
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos los productos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'chk_redondear
        '
        Me.chk_redondear.AutoSize = True
        Me.chk_redondear.Location = New System.Drawing.Point(544, 77)
        Me.chk_redondear.Name = "chk_redondear"
        Me.chk_redondear.Size = New System.Drawing.Size(95, 18)
        Me.chk_redondear.TabIndex = 118
        Me.chk_redondear.Text = "Redondear a "
        Me.chk_redondear.UseVisualStyleBackColor = True
        '
        'rb_proveedor
        '
        Me.rb_proveedor.AutoSize = True
        Me.rb_proveedor.Location = New System.Drawing.Point(525, 29)
        Me.rb_proveedor.Name = "rb_proveedor"
        Me.rb_proveedor.Size = New System.Drawing.Size(79, 18)
        Me.rb_proveedor.TabIndex = 116
        Me.rb_proveedor.TabStop = True
        Me.rb_proveedor.Text = "Proveedor"
        Me.rb_proveedor.UseVisualStyleBackColor = True
        '
        'rb_grupo
        '
        Me.rb_grupo.AutoSize = True
        Me.rb_grupo.Location = New System.Drawing.Point(333, 29)
        Me.rb_grupo.Name = "rb_grupo"
        Me.rb_grupo.Size = New System.Drawing.Size(59, 18)
        Me.rb_grupo.TabIndex = 115
        Me.rb_grupo.TabStop = True
        Me.rb_grupo.Text = "Grupo"
        Me.rb_grupo.UseVisualStyleBackColor = True
        '
        'rb_marca
        '
        Me.rb_marca.AutoSize = True
        Me.rb_marca.Location = New System.Drawing.Point(147, 29)
        Me.rb_marca.Name = "rb_marca"
        Me.rb_marca.Size = New System.Drawing.Size(57, 18)
        Me.rb_marca.TabIndex = 113
        Me.rb_marca.TabStop = True
        Me.rb_marca.Text = "Marca"
        Me.rb_marca.UseVisualStyleBackColor = True
        '
        'tb_proveedor
        '
        Me.tb_proveedor.Enabled = False
        Me.tb_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_proveedor.FormattingEnabled = True
        Me.tb_proveedor.Location = New System.Drawing.Point(607, 28)
        Me.tb_proveedor.Name = "tb_proveedor"
        Me.tb_proveedor.Size = New System.Drawing.Size(121, 22)
        Me.tb_proveedor.TabIndex = 110
        '
        'Chk_Exist
        '
        Me.Chk_Exist.AutoSize = True
        Me.Chk_Exist.Location = New System.Drawing.Point(9, 76)
        Me.Chk_Exist.Name = "Chk_Exist"
        Me.Chk_Exist.Size = New System.Drawing.Size(73, 18)
        Me.Chk_Exist.TabIndex = 101
        Me.Chk_Exist.Text = "Exist. > 0"
        Me.Chk_Exist.UseVisualStyleBackColor = True
        '
        'cb_marca
        '
        Me.cb_marca.Enabled = False
        Me.cb_marca.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(205, 27)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(121, 23)
        Me.cb_marca.TabIndex = 103
        '
        'cb_grupo
        '
        Me.cb_grupo.Enabled = False
        Me.cb_grupo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_grupo.FormattingEnabled = True
        Me.cb_grupo.Location = New System.Drawing.Point(394, 27)
        Me.cb_grupo.Name = "cb_grupo"
        Me.cb_grupo.Size = New System.Drawing.Size(121, 23)
        Me.cb_grupo.TabIndex = 105
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToOrderColumns = True
        Me.DGV_Productos.AllowUserToResizeRows = False
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.PrecioNuevoDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn})
        Me.DGV_Productos.DataSource = Me.SpconsultaProductosVariacionBindingSource
        Me.DGV_Productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.Location = New System.Drawing.Point(13, 223)
        Me.DGV_Productos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Productos.RowTemplate.Height = 19
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(768, 360)
        Me.DGV_Productos.TabIndex = 81
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 232
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "Exist."
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Width = 52
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#,##0.00"
        Me.CostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        Me.CostoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoPromedioDataGridViewTextBoxColumn.Width = 70
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#,##0.00"
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Nuevo"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 70
        '
        'PrecioNuevoDataGridViewTextBoxColumn
        '
        Me.PrecioNuevoDataGridViewTextBoxColumn.DataPropertyName = "PrecioNuevo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0.00"
        Me.PrecioNuevoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioNuevoDataGridViewTextBoxColumn.HeaderText = "Precio Viejo"
        Me.PrecioNuevoDataGridViewTextBoxColumn.Name = "PrecioNuevoDataGridViewTextBoxColumn"
        Me.PrecioNuevoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioNuevoDataGridViewTextBoxColumn.Width = 70
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Visible = False
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoDataGridViewTextBoxColumn.Visible = False
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'SpconsultaProductosVariacionBindingSource
        '
        Me.SpconsultaProductosVariacionBindingSource.DataMember = "sp_consultaProductosVariacion"
        Me.SpconsultaProductosVariacionBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(770, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Productos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(378, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(467, 596)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(289, 596)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Presentar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(722, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 14)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(684, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 14)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 22)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "%"
        '
        'tb_cantidad
        '
        Me.tb_cantidad.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidad.Location = New System.Drawing.Point(168, 28)
        Me.tb_cantidad.MaxLength = 7
        Me.tb_cantidad.Name = "tb_cantidad"
        Me.tb_cantidad.Size = New System.Drawing.Size(64, 29)
        Me.tb_cantidad.TabIndex = 94
        Me.tb_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Variación:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_cantidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 67)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(86, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(159, 20)
        Me.Label22.TabIndex = 119
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(331, 20)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Variación Lineal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Sp_consultaProductosVariacionTableAdapter
        '
        Me.Sp_consultaProductosVariacionTableAdapter.ClearBeforeFill = True
        '
        's
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 628)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "s"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variación lineal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductosVariacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rb_grupo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_marca As System.Windows.Forms.RadioButton
    Friend WithEvents tb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Chk_Exist As System.Windows.Forms.CheckBox
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents cb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents ti_fabricas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GruposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaProductosVariacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosVariacionTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosVariacionTableAdapter
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNuevoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_redondear As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_decimales As System.Windows.Forms.TextBox
End Class
