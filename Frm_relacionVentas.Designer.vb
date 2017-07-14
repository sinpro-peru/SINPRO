<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_relacionVentas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Pedidos = New System.Windows.Forms.DataGridView
        Me.ControlInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_relacionFactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.chk_fecha = New System.Windows.Forms.CheckBox
        Me.rb_client = New System.Windows.Forms.RadioButton
        Me.rb_vend = New System.Windows.Forms.RadioButton
        Me.lb_client = New System.Windows.Forms.ListBox
        Me.Sp_consultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_client = New System.Windows.Forms.TextBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Tbl_VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_finalVend = New System.Windows.Forms.TextBox
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.ti_productos = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl_totalFact = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Sp_relacionFactTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_relacionFactTableAdapter
        Me.lb_totalP = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.Tbl_VendedorTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
        Me.Sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_relacionFactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Pedidos
        '
        Me.DGV_Pedidos.AllowUserToAddRows = False
        Me.DGV_Pedidos.AllowUserToDeleteRows = False
        Me.DGV_Pedidos.AllowUserToOrderColumns = True
        Me.DGV_Pedidos.AllowUserToResizeRows = False
        Me.DGV_Pedidos.AutoGenerateColumns = False
        Me.DGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ControlInicioDataGridViewTextBoxColumn, Me.CodigoClienteDataGridViewTextBoxColumn, Me.RazonSocial, Me.FechaDataGridViewTextBoxColumn, Me.MontoTotal, Me.Nombre, Me.NC})
        Me.DGV_Pedidos.DataSource = Me.Sp_relacionFactBindingSource
        Me.DGV_Pedidos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.Location = New System.Drawing.Point(37, 164)
        Me.DGV_Pedidos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Pedidos.MultiSelect = False
        Me.DGV_Pedidos.Name = "DGV_Pedidos"
        Me.DGV_Pedidos.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Pedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Pedidos.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Pedidos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Pedidos.RowTemplate.Height = 19
        Me.DGV_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pedidos.Size = New System.Drawing.Size(752, 330)
        Me.DGV_Pedidos.TabIndex = 85
        '
        'ControlInicioDataGridViewTextBoxColumn
        '
        Me.ControlInicioDataGridViewTextBoxColumn.DataPropertyName = "ControlInicio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ControlInicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ControlInicioDataGridViewTextBoxColumn.HeaderText = "Fact."
        Me.ControlInicioDataGridViewTextBoxColumn.Name = "ControlInicioDataGridViewTextBoxColumn"
        Me.ControlInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlInicioDataGridViewTextBoxColumn.Width = 65
        '
        'CodigoClienteDataGridViewTextBoxColumn
        '
        Me.CodigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodigoClienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.Name = "CodigoClienteDataGridViewTextBoxColumn"
        Me.CodigoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClienteDataGridViewTextBoxColumn.Width = 60
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.HeaderText = "RazonSocial"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Width = 200
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
        '
        'MontoTotal
        '
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.MontoTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoTotal.HeaderText = "Monto"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        Me.MontoTotal.Width = 85
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 160
        '
        'NC
        '
        Me.NC.DataPropertyName = "NC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.NC.DefaultCellStyle = DataGridViewCellStyle5
        Me.NC.HeaderText = "NC"
        Me.NC.Name = "NC"
        Me.NC.ReadOnly = True
        Me.NC.Width = 80
        '
        'Sp_relacionFactBindingSource
        '
        Me.Sp_relacionFactBindingSource.DataMember = "sp_relacionFact"
        Me.Sp_relacionFactBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chk_fecha)
        Me.GroupBox1.Controls.Add(Me.rb_client)
        Me.GroupBox1.Controls.Add(Me.rb_vend)
        Me.GroupBox1.Controls.Add(Me.lb_client)
        Me.GroupBox1.Controls.Add(Me.cb_client)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.txt_finalVend)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 117)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'DTP2
        '
        Me.DTP2.Enabled = False
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(701, 79)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(91, 21)
        Me.DTP2.TabIndex = 20023
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(735, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 14)
        Me.Label10.TabIndex = 20022
        Me.Label10.Text = "y"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(722, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 14)
        Me.Label11.TabIndex = 20021
        Me.Label11.Text = "Entre"
        '
        'chk_fecha
        '
        Me.chk_fecha.AutoSize = True
        Me.chk_fecha.Location = New System.Drawing.Point(634, 14)
        Me.chk_fecha.Name = "chk_fecha"
        Me.chk_fecha.Size = New System.Drawing.Size(60, 18)
        Me.chk_fecha.TabIndex = 20020
        Me.chk_fecha.Text = "Fecha:"
        Me.chk_fecha.UseVisualStyleBackColor = True
        '
        'rb_client
        '
        Me.rb_client.AutoSize = True
        Me.rb_client.Location = New System.Drawing.Point(317, 16)
        Me.rb_client.Name = "rb_client"
        Me.rb_client.Size = New System.Drawing.Size(65, 18)
        Me.rb_client.TabIndex = 20019
        Me.rb_client.TabStop = True
        Me.rb_client.Text = "Cliente:"
        Me.rb_client.UseVisualStyleBackColor = True
        '
        'rb_vend
        '
        Me.rb_vend.AutoSize = True
        Me.rb_vend.Location = New System.Drawing.Point(6, 16)
        Me.rb_vend.Name = "rb_vend"
        Me.rb_vend.Size = New System.Drawing.Size(80, 18)
        Me.rb_vend.TabIndex = 20018
        Me.rb_vend.TabStop = True
        Me.rb_vend.Text = "Vendedor:"
        Me.rb_vend.UseVisualStyleBackColor = True
        '
        'lb_client
        '
        Me.lb_client.DataSource = Me.Sp_consultaClienteBindingSource
        Me.lb_client.DisplayMember = "RazonSocial"
        Me.lb_client.FormattingEnabled = True
        Me.lb_client.ItemHeight = 14
        Me.lb_client.Location = New System.Drawing.Point(385, 32)
        Me.lb_client.Name = "lb_client"
        Me.lb_client.Size = New System.Drawing.Size(232, 74)
        Me.lb_client.TabIndex = 20017
        Me.lb_client.ValueMember = "CodigoCliente"
        Me.lb_client.Visible = False
        '
        'Sp_consultaClienteBindingSource
        '
        Me.Sp_consultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.Sp_consultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'cb_client
        '
        Me.cb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_client.Enabled = False
        Me.cb_client.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_client.ForeColor = System.Drawing.Color.Black
        Me.cb_client.Location = New System.Drawing.Point(385, 13)
        Me.cb_client.Name = "cb_client"
        Me.cb_client.Size = New System.Drawing.Size(232, 21)
        Me.cb_client.TabIndex = 20016
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.Tbl_VendedorBindingSource
        Me.ListBox2.DisplayMember = "Nombre"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(89, 33)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(208, 74)
        Me.ListBox2.TabIndex = 123
        Me.ListBox2.ValueMember = "CodigoVendedor"
        Me.ListBox2.Visible = False
        '
        'Tbl_VendedorBindingSource
        '
        Me.Tbl_VendedorBindingSource.DataMember = "Tbl_Vendedor"
        Me.Tbl_VendedorBindingSource.DataSource = Me.MELDataSet
        '
        'txt_finalVend
        '
        Me.txt_finalVend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_finalVend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_finalVend.Enabled = False
        Me.txt_finalVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_finalVend.ForeColor = System.Drawing.Color.Gray
        Me.txt_finalVend.Location = New System.Drawing.Point(89, 14)
        Me.txt_finalVend.Name = "txt_finalVend"
        Me.txt_finalVend.Size = New System.Drawing.Size(208, 20)
        Me.txt_finalVend.TabIndex = 122
        '
        'DTP1
        '
        Me.DTP1.Enabled = False
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(701, 32)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(91, 21)
        Me.DTP1.TabIndex = 1
        '
        'ti_productos
        '
        Me.ti_productos.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_productos.Location = New System.Drawing.Point(37, 140)
        Me.ti_productos.Name = "ti_productos"
        Me.ti_productos.Size = New System.Drawing.Size(752, 25)
        Me.ti_productos.TabIndex = 84
        Me.ti_productos.Text = "Relación de facturas"
        Me.ti_productos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(379, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 25)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_totalFact
        '
        Me.lbl_totalFact.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_totalFact.ForeColor = System.Drawing.Color.White
        Me.lbl_totalFact.Location = New System.Drawing.Point(736, 146)
        Me.lbl_totalFact.Name = "lbl_totalFact"
        Me.lbl_totalFact.Size = New System.Drawing.Size(47, 14)
        Me.lbl_totalFact.TabIndex = 126
        Me.lbl_totalFact.Text = "0"
        Me.lbl_totalFact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(673, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Total Fact.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sp_relacionFactTableAdapter
        '
        Me.Sp_relacionFactTableAdapter.ClearBeforeFill = True
        '
        'lb_totalP
        '
        Me.lb_totalP.AutoSize = True
        Me.lb_totalP.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalP.ForeColor = System.Drawing.Color.DarkOrange
        Me.lb_totalP.Location = New System.Drawing.Point(665, 498)
        Me.lb_totalP.Name = "lb_totalP"
        Me.lb_totalP.Size = New System.Drawing.Size(44, 19)
        Me.lb_totalP.TabIndex = 128
        Me.lb_totalP.Text = "0,00"
        Me.lb_totalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_total
        '
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.Location = New System.Drawing.Point(599, 501)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(65, 19)
        Me.lb_total.TabIndex = 127
        Me.lb_total.Text = "Total Fac.:"
        '
        'Tbl_VendedorTableAdapter
        '
        Me.Tbl_VendedorTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaClienteTableAdapter
        '
        Me.Sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 14)
        Me.Label2.TabIndex = 20023
        Me.Label2.Text = "y"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(665, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 20025
        Me.Label1.Text = "0,00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(598, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 20024
        Me.Label3.Text = "Total N.C.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(665, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 20027
        Me.Label4.Text = "0,00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(599, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 20026
        Me.Label6.Text = "Total:"
        '
        'Frm_relacionVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 558)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_totalP)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.lbl_totalFact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Pedidos)
        Me.Controls.Add(Me.ti_productos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_relacionVentas"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relación de ventas"
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_relacionFactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ti_productos As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents txt_finalVend As System.Windows.Forms.TextBox
    Friend WithEvents lb_client As System.Windows.Forms.ListBox
    Friend WithEvents cb_client As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chk_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents rb_client As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vend As System.Windows.Forms.RadioButton
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents lbl_totalFact As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sp_relacionFactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_relacionFactTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_relacionFactTableAdapter
    Friend WithEvents lb_totalP As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tbl_VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_VendedorTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
    Friend WithEvents Sp_consultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ControlInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
