<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AgregarAPedido
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AgregarAPedido))
        Me.lb_producto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_proveedor = New System.Windows.Forms.ComboBox
        Me.DGV_pedido = New System.Windows.Forms.DataGridView
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_cantidad = New System.Windows.Forms.TextBox
        Me.bt_agregarCuarto = New System.Windows.Forms.Button
        Me.bt_eliminarCuarto = New System.Windows.Forms.Button
        Me.ti_fabricas = New System.Windows.Forms.Label
        Me.lb_cod = New System.Windows.Forms.Label
        Me.tb_codfab = New System.Windows.Forms.TextBox
        Me.lb_codigo = New System.Windows.Forms.Label
        Me.lb_cant = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_moneda = New System.Windows.Forms.Label
        Me.tb_nuevo = New System.Windows.Forms.TextBox
        Me.lb_proveedor = New System.Windows.Forms.ListBox
        Me.TblFabricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Tbl_FabricaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cb_filtroStatus = New System.Windows.Forms.ComboBox
        Me.rb_status = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DGV_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_producto
        '
        Me.lb_producto.Font = New System.Drawing.Font("Eras Light ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_producto.Location = New System.Drawing.Point(44, 26)
        Me.lb_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_producto.Name = "lb_producto"
        Me.lb_producto.Size = New System.Drawing.Size(257, 20)
        Me.lb_producto.TabIndex = 0
        Me.lb_producto.Text = "Descripción del artículo"
        Me.lb_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proveedor:"
        '
        'tb_proveedor
        '
        Me.tb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_proveedor.FormattingEnabled = True
        Me.tb_proveedor.Location = New System.Drawing.Point(81, 57)
        Me.tb_proveedor.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_proveedor.Name = "tb_proveedor"
        Me.tb_proveedor.Size = New System.Drawing.Size(113, 23)
        Me.tb_proveedor.TabIndex = 2
        '
        'DGV_pedido
        '
        Me.DGV_pedido.AllowUserToAddRows = False
        Me.DGV_pedido.AllowUserToDeleteRows = False
        Me.DGV_pedido.AllowUserToResizeRows = False
        Me.DGV_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Peso, Me.FechaCreacion})
        Me.DGV_pedido.Location = New System.Drawing.Point(6, 150)
        Me.DGV_pedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_pedido.MultiSelect = False
        Me.DGV_pedido.Name = "DGV_pedido"
        Me.DGV_pedido.ReadOnly = True
        Me.DGV_pedido.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_pedido.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_pedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_pedido.Size = New System.Drawing.Size(337, 156)
        Me.DGV_pedido.TabIndex = 3
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Cod. Pedido"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 115
        '
        'Peso
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle1
        Me.Peso.HeaderText = "F. Mod."
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Width = 95
        '
        'FechaCreacion
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaCreacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaCreacion.HeaderText = "F. Creación"
        Me.FechaCreacion.Name = "FechaCreacion"
        Me.FechaCreacion.ReadOnly = True
        Me.FechaCreacion.Width = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 355)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cant.:"
        Me.Label3.Visible = False
        '
        'tb_cantidad
        '
        Me.tb_cantidad.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_cantidad.Location = New System.Drawing.Point(138, 340)
        Me.tb_cantidad.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_cantidad.Name = "tb_cantidad"
        Me.tb_cantidad.Size = New System.Drawing.Size(87, 44)
        Me.tb_cantidad.TabIndex = 5
        Me.tb_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_agregarCuarto
        '
        Me.bt_agregarCuarto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCuarto.Location = New System.Drawing.Point(245, 344)
        Me.bt_agregarCuarto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.bt_agregarCuarto.Name = "bt_agregarCuarto"
        Me.bt_agregarCuarto.Size = New System.Drawing.Size(35, 40)
        Me.bt_agregarCuarto.TabIndex = 31
        Me.bt_agregarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarCuarto
        '
        Me.bt_eliminarCuarto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_eliminarCuarto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCuarto.Location = New System.Drawing.Point(284, 344)
        Me.bt_eliminarCuarto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.bt_eliminarCuarto.Name = "bt_eliminarCuarto"
        Me.bt_eliminarCuarto.Size = New System.Drawing.Size(35, 40)
        Me.bt_eliminarCuarto.TabIndex = 32
        Me.bt_eliminarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ti_fabricas
        '
        Me.ti_fabricas.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_fabricas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_fabricas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_fabricas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_fabricas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_fabricas.Location = New System.Drawing.Point(6, 125)
        Me.ti_fabricas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ti_fabricas.Name = "ti_fabricas"
        Me.ti_fabricas.Size = New System.Drawing.Size(337, 26)
        Me.ti_fabricas.TabIndex = 33
        Me.ti_fabricas.Text = "Últimos pedidos"
        Me.ti_fabricas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_cod
        '
        Me.lb_cod.AutoSize = True
        Me.lb_cod.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cod.Location = New System.Drawing.Point(111, 96)
        Me.lb_cod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_cod.Name = "lb_cod"
        Me.lb_cod.Size = New System.Drawing.Size(83, 15)
        Me.lb_cod.TabIndex = 36
        Me.lb_cod.Text = "Cod. Fábrica:"
        Me.lb_cod.Visible = False
        '
        'tb_codfab
        '
        Me.tb_codfab.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codfab.Location = New System.Drawing.Point(200, 92)
        Me.tb_codfab.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_codfab.Name = "tb_codfab"
        Me.tb_codfab.Size = New System.Drawing.Size(118, 22)
        Me.tb_codfab.TabIndex = 38
        Me.tb_codfab.Visible = False
        '
        'lb_codigo
        '
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Light ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(44, 4)
        Me.lb_codigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(257, 20)
        Me.lb_codigo.TabIndex = 41
        Me.lb_codigo.Text = "cod"
        Me.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_cant
        '
        Me.lb_cant.AutoSize = True
        Me.lb_cant.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_cant.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cant.ForeColor = System.Drawing.Color.White
        Me.lb_cant.Location = New System.Drawing.Point(307, 132)
        Me.lb_cant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_cant.Name = "lb_cant"
        Me.lb_cant.Size = New System.Drawing.Size(13, 14)
        Me.lb_cant.TabIndex = 42
        Me.lb_cant.Text = "0"
        Me.lb_cant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(247, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Cantidad: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 311)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Moneda:"
        '
        'lbl_moneda
        '
        Me.lbl_moneda.AutoSize = True
        Me.lbl_moneda.Location = New System.Drawing.Point(68, 311)
        Me.lbl_moneda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(21, 15)
        Me.lbl_moneda.TabIndex = 45
        Me.lbl_moneda.Text = "##"
        '
        'tb_nuevo
        '
        Me.tb_nuevo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_nuevo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_nuevo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nuevo.ForeColor = System.Drawing.Color.Black
        Me.tb_nuevo.Location = New System.Drawing.Point(200, 59)
        Me.tb_nuevo.Name = "tb_nuevo"
        Me.tb_nuevo.Size = New System.Drawing.Size(118, 21)
        Me.tb_nuevo.TabIndex = 10063
        Me.tb_nuevo.Visible = False
        '
        'lb_proveedor
        '
        Me.lb_proveedor.DataSource = Me.TblFabricaBindingSource
        Me.lb_proveedor.DisplayMember = "Nombre"
        Me.lb_proveedor.FormattingEnabled = True
        Me.lb_proveedor.ItemHeight = 15
        Me.lb_proveedor.Location = New System.Drawing.Point(200, 80)
        Me.lb_proveedor.Name = "lb_proveedor"
        Me.lb_proveedor.Size = New System.Drawing.Size(118, 79)
        Me.lb_proveedor.TabIndex = 10064
        Me.lb_proveedor.ValueMember = "CodigoFabrica"
        Me.lb_proveedor.Visible = False
        '
        'TblFabricaBindingSource
        '
        Me.TblFabricaBindingSource.DataMember = "Tbl_Fabrica"
        Me.TblFabricaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_FabricaTableAdapter
        '
        Me.Tbl_FabricaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.cb_filtroStatus)
        Me.Panel1.Controls.Add(Me.rb_status)
        Me.Panel1.Controls.Add(Me.rb_todos)
        Me.Panel1.Location = New System.Drawing.Point(12, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 27)
        Me.Panel1.TabIndex = 10065
        Me.Panel1.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(220, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 18)
        Me.RadioButton1.TabIndex = 10067
        Me.RadioButton1.Text = "Sólo producto"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cb_filtroStatus
        '
        Me.cb_filtroStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_filtroStatus.Enabled = False
        Me.cb_filtroStatus.Font = New System.Drawing.Font("Eras Medium ITC", 7.5!)
        Me.cb_filtroStatus.FormattingEnabled = True
        Me.cb_filtroStatus.Items.AddRange(New Object() {"S", "R", "O", "N"})
        Me.cb_filtroStatus.Location = New System.Drawing.Point(157, 2)
        Me.cb_filtroStatus.Name = "cb_filtroStatus"
        Me.cb_filtroStatus.Size = New System.Drawing.Size(57, 21)
        Me.cb_filtroStatus.TabIndex = 10066
        '
        'rb_status
        '
        Me.rb_status.AutoSize = True
        Me.rb_status.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_status.Location = New System.Drawing.Point(78, 3)
        Me.rb_status.Name = "rb_status"
        Me.rb_status.Size = New System.Drawing.Size(73, 18)
        Me.rb_status.TabIndex = 1
        Me.rb_status.Text = "Por status"
        Me.rb_status.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_todos.Location = New System.Drawing.Point(17, 3)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(54, 18)
        Me.rb_todos.TabIndex = 0
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(70, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10066
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(206, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10067
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Frm_AgregarAPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bt_eliminarCuarto
        Me.ClientSize = New System.Drawing.Size(353, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_proveedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_nuevo)
        Me.Controls.Add(Me.lbl_moneda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_cant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.tb_codfab)
        Me.Controls.Add(Me.lb_cod)
        Me.Controls.Add(Me.ti_fabricas)
        Me.Controls.Add(Me.bt_agregarCuarto)
        Me.Controls.Add(Me.bt_eliminarCuarto)
        Me.Controls.Add(Me.tb_cantidad)
        Me.Controls.Add(Me.tb_proveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_producto)
        Me.Controls.Add(Me.DGV_pedido)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(361, 395)
        Me.Name = "Frm_AgregarAPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar a pedido"
        CType(Me.DGV_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_producto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_pedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents bt_agregarCuarto As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarCuarto As System.Windows.Forms.Button
    Friend WithEvents ti_fabricas As System.Windows.Forms.Label
    Friend WithEvents lb_cod As System.Windows.Forms.Label
    Friend WithEvents tb_codfab As System.Windows.Forms.TextBox
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_cant As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_moneda As System.Windows.Forms.Label
    Friend WithEvents tb_nuevo As System.Windows.Forms.TextBox
    Friend WithEvents lb_proveedor As System.Windows.Forms.ListBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents TblFabricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FabricaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_status As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents cb_filtroStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
