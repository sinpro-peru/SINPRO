<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Analisis_Cobranza
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Analisis_Cobranza))
        Me.DGV_Facturas = New System.Windows.Forms.DataGridView
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasCredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoPendienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpanalisisCobranzasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_totalFact = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lb_totalP = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_final = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TblClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.TblVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_finalVend = New System.Windows.Forms.TextBox
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_de = New System.Windows.Forms.DateTimePicker
        Me.ch_fecha = New System.Windows.Forms.CheckBox
        Me.ch_cliente = New System.Windows.Forms.CheckBox
        Me.ch_vendedor = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Tbl_ClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_ClienteTableAdapter
        Me.Sp_analisisCobranzasTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_analisisCobranzasTableAdapter
        Me.Tbl_VendedorTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpanalisisCobranzasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToAddRows = False
        Me.DGV_Facturas.AllowUserToDeleteRows = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DGV_Facturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Facturas.AutoGenerateColumns = False
        Me.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.ControlDataGridViewTextBoxColumn, Me.CodigoClienteDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.VencimientoDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.DiasCredDataGridViewTextBoxColumn, Me.MontoPendienteDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.VendedorDataGridViewTextBoxColumn})
        Me.DGV_Facturas.DataSource = Me.SpanalisisCobranzasBindingSource
        Me.DGV_Facturas.Location = New System.Drawing.Point(27, 46)
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.ReadOnly = True
        Me.DGV_Facturas.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Facturas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Facturas.ShowEditingIcon = False
        Me.DGV_Facturas.Size = New System.Drawing.Size(901, 398)
        Me.DGV_Facturas.TabIndex = 99
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 83
        '
        'ControlDataGridViewTextBoxColumn
        '
        Me.ControlDataGridViewTextBoxColumn.DataPropertyName = "control"
        Me.ControlDataGridViewTextBoxColumn.HeaderText = "Fact."
        Me.ControlDataGridViewTextBoxColumn.Name = "ControlDataGridViewTextBoxColumn"
        Me.ControlDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlDataGridViewTextBoxColumn.Width = 65
        '
        'CodigoClienteDataGridViewTextBoxColumn
        '
        Me.CodigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.Name = "CodigoClienteDataGridViewTextBoxColumn"
        Me.CodigoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClienteDataGridViewTextBoxColumn.Width = 50
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 220
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "montoTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#,##0.00"
        Me.MontoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 80
        '
        'VencimientoDataGridViewTextBoxColumn
        '
        Me.VencimientoDataGridViewTextBoxColumn.DataPropertyName = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.Name = "VencimientoDataGridViewTextBoxColumn"
        Me.VencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VencimientoDataGridViewTextBoxColumn.Width = 83
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasDataGridViewTextBoxColumn.Width = 45
        '
        'DiasCredDataGridViewTextBoxColumn
        '
        Me.DiasCredDataGridViewTextBoxColumn.DataPropertyName = "DiasCred"
        Me.DiasCredDataGridViewTextBoxColumn.HeaderText = "Cred."
        Me.DiasCredDataGridViewTextBoxColumn.Name = "DiasCredDataGridViewTextBoxColumn"
        Me.DiasCredDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasCredDataGridViewTextBoxColumn.Width = 40
        '
        'MontoPendienteDataGridViewTextBoxColumn
        '
        Me.MontoPendienteDataGridViewTextBoxColumn.DataPropertyName = "MontoPendiente"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#,##0.00"
        Me.MontoPendienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoPendienteDataGridViewTextBoxColumn.HeaderText = "Pendiente"
        Me.MontoPendienteDataGridViewTextBoxColumn.Name = "MontoPendienteDataGridViewTextBoxColumn"
        Me.MontoPendienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoPendienteDataGridViewTextBoxColumn.Width = 80
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IvaDataGridViewTextBoxColumn.Visible = False
        '
        'VendedorDataGridViewTextBoxColumn
        '
        Me.VendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.Name = "VendedorDataGridViewTextBoxColumn"
        Me.VendedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedorDataGridViewTextBoxColumn.Visible = False
        '
        'SpanalisisCobranzasBindingSource
        '
        Me.SpanalisisCobranzasBindingSource.DataMember = "sp_analisisCobranzas"
        Me.SpanalisisCobranzasBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(27, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(901, 25)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Facturas Pendiente de Pago"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbl_totalFact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DGV_Facturas)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lb_totalP)
        Me.GroupBox1.Controls.Add(Me.lb_total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 534)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'lbl_totalFact
        '
        Me.lbl_totalFact.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_totalFact.ForeColor = System.Drawing.Color.White
        Me.lbl_totalFact.Location = New System.Drawing.Point(873, 24)
        Me.lbl_totalFact.Name = "lbl_totalFact"
        Me.lbl_totalFact.Size = New System.Drawing.Size(47, 14)
        Me.lbl_totalFact.TabIndex = 124
        Me.lbl_totalFact.Text = "0"
        Me.lbl_totalFact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(810, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Total Fact.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 25)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lb_totalP
        '
        Me.lb_totalP.AutoSize = True
        Me.lb_totalP.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalP.ForeColor = System.Drawing.Color.Red
        Me.lb_totalP.Location = New System.Drawing.Point(815, 457)
        Me.lb_totalP.Name = "lb_totalP"
        Me.lb_totalP.Size = New System.Drawing.Size(44, 19)
        Me.lb_totalP.TabIndex = 104
        Me.lb_totalP.Text = "0,00"
        Me.lb_totalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_total
        '
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.Location = New System.Drawing.Point(755, 457)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(65, 25)
        Me.lb_total.TabIndex = 103
        Me.lb_total.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(858, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(858, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_final)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.txt_finalVend)
        Me.GroupBox2.Controls.Add(Me.dtp_hasta)
        Me.GroupBox2.Controls.Add(Me.dtp_de)
        Me.GroupBox2.Controls.Add(Me.ch_fecha)
        Me.GroupBox2.Controls.Add(Me.ch_cliente)
        Me.GroupBox2.Controls.Add(Me.ch_vendedor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(955, 130)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        '
        'txt_final
        '
        Me.txt_final.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_final.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_final.Enabled = False
        Me.txt_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_final.ForeColor = System.Drawing.Color.Gray
        Me.txt_final.Location = New System.Drawing.Point(429, 34)
        Me.txt_final.Name = "txt_final"
        Me.txt_final.Size = New System.Drawing.Size(208, 20)
        Me.txt_final.TabIndex = 117
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TblClienteBindingSource
        Me.ListBox1.DisplayMember = "RazonSocial"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(429, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 60)
        Me.ListBox1.TabIndex = 118
        Me.ListBox1.ValueMember = "CodigoCliente"
        Me.ListBox1.Visible = False
        '
        'TblClienteBindingSource
        '
        Me.TblClienteBindingSource.DataMember = "Tbl_Cliente"
        Me.TblClienteBindingSource.DataSource = Me.MELDataSet
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.TblVendedorBindingSource
        Me.ListBox2.DisplayMember = "Nombre"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(129, 53)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(208, 60)
        Me.ListBox2.TabIndex = 121
        Me.ListBox2.ValueMember = "CodigoVendedor"
        Me.ListBox2.Visible = False
        '
        'TblVendedorBindingSource
        '
        Me.TblVendedorBindingSource.DataMember = "Tbl_Vendedor"
        Me.TblVendedorBindingSource.DataSource = Me.MELDataSet
        '
        'txt_finalVend
        '
        Me.txt_finalVend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_finalVend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_finalVend.Enabled = False
        Me.txt_finalVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_finalVend.ForeColor = System.Drawing.Color.Gray
        Me.txt_finalVend.Location = New System.Drawing.Point(129, 34)
        Me.txt_finalVend.Name = "txt_finalVend"
        Me.txt_finalVend.Size = New System.Drawing.Size(208, 20)
        Me.txt_finalVend.TabIndex = 120
        '
        'dtp_hasta
        '
        Me.dtp_hasta.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_hasta.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_hasta.Location = New System.Drawing.Point(815, 72)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(110, 22)
        Me.dtp_hasta.TabIndex = 114
        Me.dtp_hasta.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'dtp_de
        '
        Me.dtp_de.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_de.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_de.Location = New System.Drawing.Point(815, 30)
        Me.dtp_de.Name = "dtp_de"
        Me.dtp_de.Size = New System.Drawing.Size(110, 22)
        Me.dtp_de.TabIndex = 113
        Me.dtp_de.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'ch_fecha
        '
        Me.ch_fecha.AutoSize = True
        Me.ch_fecha.Location = New System.Drawing.Point(677, 33)
        Me.ch_fecha.Name = "ch_fecha"
        Me.ch_fecha.Size = New System.Drawing.Size(60, 18)
        Me.ch_fecha.TabIndex = 112
        Me.ch_fecha.Text = "Fecha:"
        Me.ch_fecha.UseVisualStyleBackColor = True
        '
        'ch_cliente
        '
        Me.ch_cliente.AutoSize = True
        Me.ch_cliente.Location = New System.Drawing.Point(348, 33)
        Me.ch_cliente.Name = "ch_cliente"
        Me.ch_cliente.Size = New System.Drawing.Size(66, 18)
        Me.ch_cliente.TabIndex = 111
        Me.ch_cliente.Text = "Cliente:"
        Me.ch_cliente.UseVisualStyleBackColor = True
        '
        'ch_vendedor
        '
        Me.ch_vendedor.AutoSize = True
        Me.ch_vendedor.Location = New System.Drawing.Point(42, 33)
        Me.ch_vendedor.Name = "ch_vendedor"
        Me.ch_vendedor.Size = New System.Drawing.Size(81, 18)
        Me.ch_vendedor.TabIndex = 110
        Me.ch_vendedor.Text = "Vendedor:"
        Me.ch_vendedor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(755, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Hasta :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(755, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "De:"
        '
        'Tbl_ClienteTableAdapter
        '
        Me.Tbl_ClienteTableAdapter.ClearBeforeFill = True
        '
        'Sp_analisisCobranzasTableAdapter
        '
        Me.Sp_analisisCobranzasTableAdapter.ClearBeforeFill = True
        '
        'Tbl_VendedorTableAdapter
        '
        Me.Tbl_VendedorTableAdapter.ClearBeforeFill = True
        '
        'Frm_Analisis_Cobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 654)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Analisis_Cobranza"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas por cobrar"
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpanalisisCobranzasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_Facturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_totalP As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ch_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents ch_cliente As System.Windows.Forms.CheckBox
    Friend WithEvents ch_vendedor As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txt_final As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents TblClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_ClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_ClienteTableAdapter
    Friend WithEvents SpanalisisCobranzasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_analisisCobranzasTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_analisisCobranzasTableAdapter
    Friend WithEvents txt_finalVend As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TblVendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_VendedorTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasCredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoPendienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_totalFact As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
