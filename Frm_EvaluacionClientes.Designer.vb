<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EvaluacionClientes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EvaluacionClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_client = New System.Windows.Forms.TextBox
        Me.bt_evaluar = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lb_client = New System.Windows.Forms.ListBox
        Me.SpconsultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView
        Me.Fact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.lbl_totalClientes = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lb_totalFact = New System.Windows.Forms.Label
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.chk_group = New System.Windows.Forms.CheckBox
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.lbl_ventas = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lbl_marca = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.DGV_Marcas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Indicadores = New System.Windows.Forms.DataGridView
        Me.PorcInv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PPC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sugerida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Otros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lb_totalPendientes = New System.Windows.Forms.Label
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_pendiente = New System.Windows.Forms.Label
        Me.DGV_Pendiente = New System.Windows.Forms.DataGridView
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.lbl_totalNCPend = New System.Windows.Forms.Label
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbl_NC = New System.Windows.Forms.Label
        Me.DGV_NC = New System.Windows.Forms.DataGridView
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.UserControl11 = New Tesis_Nueva.UserControl1
        Me.Sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pend = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoNC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Indicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Pendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_NC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_client)
        Me.GroupBox1.Controls.Add(Me.bt_evaluar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'cb_client
        '
        Me.cb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_client.Enabled = False
        Me.cb_client.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_client.ForeColor = System.Drawing.Color.Black
        Me.cb_client.Location = New System.Drawing.Point(159, 17)
        Me.cb_client.Name = "cb_client"
        Me.cb_client.Size = New System.Drawing.Size(207, 21)
        Me.cb_client.TabIndex = 20016
        '
        'bt_evaluar
        '
        Me.bt_evaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_evaluar.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_evaluar.Location = New System.Drawing.Point(372, 33)
        Me.bt_evaluar.Name = "bt_evaluar"
        Me.bt_evaluar.Size = New System.Drawing.Size(63, 23)
        Me.bt_evaluar.TabIndex = 15
        Me.bt_evaluar.Text = "Evaluar"
        Me.bt_evaluar.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(227, 52)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(69, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(84, 18)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Por cliente:"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 18)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lb_client
        '
        Me.lb_client.DataSource = Me.SpconsultaClienteBindingSource
        Me.lb_client.DisplayMember = "RazonSocial"
        Me.lb_client.FormattingEnabled = True
        Me.lb_client.ItemHeight = 14
        Me.lb_client.Location = New System.Drawing.Point(171, 44)
        Me.lb_client.Name = "lb_client"
        Me.lb_client.Size = New System.Drawing.Size(207, 74)
        Me.lb_client.TabIndex = 20017
        Me.lb_client.ValueMember = "CodigoCliente"
        Me.lb_client.Visible = False
        '
        'SpconsultaClienteBindingSource
        '
        Me.SpconsultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.SpconsultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.AllowUserToAddRows = False
        Me.DGV_Ventas.AllowUserToDeleteRows = False
        Me.DGV_Ventas.AllowUserToResizeColumns = False
        Me.DGV_Ventas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Ventas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fact, Me.Fecha, Me.Razon, Me.Monto})
        Me.DGV_Ventas.Location = New System.Drawing.Point(6, 44)
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.ReadOnly = True
        Me.DGV_Ventas.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal
        Me.DGV_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ventas.Size = New System.Drawing.Size(437, 153)
        Me.DGV_Ventas.TabIndex = 1
        '
        'Fact
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fact.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fact.HeaderText = "Fact."
        Me.Fact.Name = "Fact"
        Me.Fact.ReadOnly = True
        Me.Fact.Width = 60
        '
        'Fecha
        '
        DataGridViewCellStyle3.Format = "d"
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 90
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razón Social"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 185
        '
        'Monto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0.00"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel16)
        Me.GroupBox2.Controls.Add(Me.Panel10)
        Me.GroupBox2.Controls.Add(Me.Panel17)
        Me.GroupBox2.Controls.Add(Me.chk_group)
        Me.GroupBox2.Controls.Add(Me.Panel11)
        Me.GroupBox2.Controls.Add(Me.Panel8)
        Me.GroupBox2.Controls.Add(Me.Panel9)
        Me.GroupBox2.Controls.Add(Me.DGV_Ventas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 229)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas del cliente"
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.lbl_totalClientes)
        Me.Panel16.Location = New System.Drawing.Point(81, 196)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(43, 20)
        Me.Panel16.TabIndex = 175
        '
        'lbl_totalClientes
        '
        Me.lbl_totalClientes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalClientes.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalClientes.Location = New System.Drawing.Point(2, 2)
        Me.lbl_totalClientes.Name = "lbl_totalClientes"
        Me.lbl_totalClientes.Size = New System.Drawing.Size(38, 15)
        Me.lbl_totalClientes.TabIndex = 159
        Me.lbl_totalClientes.Text = "0"
        Me.lbl_totalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lb_totalFact)
        Me.Panel10.Location = New System.Drawing.Point(194, 196)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(51, 20)
        Me.Panel10.TabIndex = 173
        '
        'lb_totalFact
        '
        Me.lb_totalFact.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalFact.ForeColor = System.Drawing.Color.Black
        Me.lb_totalFact.Location = New System.Drawing.Point(1, 2)
        Me.lb_totalFact.Name = "lb_totalFact"
        Me.lb_totalFact.Size = New System.Drawing.Size(47, 15)
        Me.lb_totalFact.TabIndex = 159
        Me.lb_totalFact.Text = "0"
        Me.lb_totalFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Label13)
        Me.Panel17.Location = New System.Drawing.Point(6, 196)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(76, 20)
        Me.Panel17.TabIndex = 174
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Clientes:"
        '
        'chk_group
        '
        Me.chk_group.AutoSize = True
        Me.chk_group.Location = New System.Drawing.Point(6, 20)
        Me.chk_group.Name = "chk_group"
        Me.chk_group.Size = New System.Drawing.Size(122, 18)
        Me.chk_group.TabIndex = 172
        Me.chk_group.Text = "Totales por cliente"
        Me.chk_group.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Location = New System.Drawing.Point(123, 196)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(72, 20)
        Me.Panel11.TabIndex = 172
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Facturas:"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lbl_ventas)
        Me.Panel8.Location = New System.Drawing.Point(342, 196)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(101, 20)
        Me.Panel8.TabIndex = 171
        '
        'lbl_ventas
        '
        Me.lbl_ventas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ventas.ForeColor = System.Drawing.Color.Black
        Me.lbl_ventas.Location = New System.Drawing.Point(3, 2)
        Me.lbl_ventas.Name = "lbl_ventas"
        Me.lbl_ventas.Size = New System.Drawing.Size(95, 15)
        Me.lbl_ventas.TabIndex = 159
        Me.lbl_ventas.Text = "0,00"
        Me.lbl_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Location = New System.Drawing.Point(244, 196)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(99, 20)
        Me.Panel9.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Total Ventas:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.DGV_Marcas)
        Me.GroupBox3.Location = New System.Drawing.Point(470, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 158)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Participación por marca"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(131, 129)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(119, 20)
        Me.Panel7.TabIndex = 171
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "100%"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_marca)
        Me.Panel5.Location = New System.Drawing.Point(192, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(163, 20)
        Me.Panel5.TabIndex = 171
        '
        'lbl_marca
        '
        Me.lbl_marca.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca.ForeColor = System.Drawing.Color.Black
        Me.lbl_marca.Location = New System.Drawing.Point(58, 2)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(98, 15)
        Me.lbl_marca.TabIndex = 159
        Me.lbl_marca.Text = "0,00"
        Me.lbl_marca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(6, 129)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(127, 20)
        Me.Panel6.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total por marcas:"
        '
        'DGV_Marcas
        '
        Me.DGV_Marcas.AllowUserToAddRows = False
        Me.DGV_Marcas.AllowUserToDeleteRows = False
        Me.DGV_Marcas.AllowUserToResizeColumns = False
        Me.DGV_Marcas.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Marcas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Marcas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Marcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DGV_Marcas.Location = New System.Drawing.Point(6, 20)
        Me.DGV_Marcas.Name = "DGV_Marcas"
        Me.DGV_Marcas.ReadOnly = True
        Me.DGV_Marcas.RowHeadersVisible = False
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Teal
        Me.DGV_Marcas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Marcas.Size = New System.Drawing.Size(349, 110)
        Me.DGV_Marcas.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "#,##0.00%"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "% Participación"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 117
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "#,##0.00"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 85
        '
        'DGV_Indicadores
        '
        Me.DGV_Indicadores.AllowUserToAddRows = False
        Me.DGV_Indicadores.AllowUserToDeleteRows = False
        Me.DGV_Indicadores.AllowUserToResizeColumns = False
        Me.DGV_Indicadores.AllowUserToResizeRows = False
        Me.DGV_Indicadores.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Indicadores.ColumnHeadersHeight = 22
        Me.DGV_Indicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Indicadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PorcInv, Me.PPC, Me.Sugerida, Me.Otros})
        Me.DGV_Indicadores.Location = New System.Drawing.Point(6, 20)
        Me.DGV_Indicadores.MultiSelect = False
        Me.DGV_Indicadores.Name = "DGV_Indicadores"
        Me.DGV_Indicadores.ReadOnly = True
        Me.DGV_Indicadores.RowHeadersVisible = False
        Me.DGV_Indicadores.RowTemplate.Height = 32
        Me.DGV_Indicadores.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Indicadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Indicadores.Size = New System.Drawing.Size(349, 54)
        Me.DGV_Indicadores.TabIndex = 37
        '
        'PorcInv
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PorcInv.DefaultCellStyle = DataGridViewCellStyle10
        Me.PorcInv.HeaderText = "D.P.P."
        Me.PorcInv.Name = "PorcInv"
        Me.PorcInv.ReadOnly = True
        Me.PorcInv.Width = 55
        '
        'PPC
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "#,##0.00"
        Me.PPC.DefaultCellStyle = DataGridViewCellStyle11
        Me.PPC.HeaderText = "P.P.C."
        Me.PPC.Name = "PPC"
        Me.PPC.ReadOnly = True
        Me.PPC.Width = 95
        '
        'Sugerida
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Sugerida.DefaultCellStyle = DataGridViewCellStyle12
        Me.Sugerida.HeaderText = "# Cheques Dev."
        Me.Sugerida.Name = "Sugerida"
        Me.Sugerida.ReadOnly = True
        '
        'Otros
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "n0"
        Me.Otros.DefaultCellStyle = DataGridViewCellStyle13
        Me.Otros.HeaderText = "Cobranza Max."
        Me.Otros.Name = "Otros"
        Me.Otros.ReadOnly = True
        Me.Otros.Width = 95
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGV_Indicadores)
        Me.GroupBox4.Location = New System.Drawing.Point(470, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 89)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Indicadores"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Controls.Add(Me.Panel12)
        Me.GroupBox5.Controls.Add(Me.Panel13)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.DGV_Pendiente)
        Me.GroupBox5.Location = New System.Drawing.Point(470, 423)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(538, 269)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Facturas pendientes"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(304, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 20)
        Me.Panel2.TabIndex = 166
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Pendiente:"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lb_totalPendientes)
        Me.Panel12.Location = New System.Drawing.Point(231, 242)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(74, 20)
        Me.Panel12.TabIndex = 175
        '
        'lb_totalPendientes
        '
        Me.lb_totalPendientes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalPendientes.ForeColor = System.Drawing.Color.Black
        Me.lb_totalPendientes.Location = New System.Drawing.Point(1, 2)
        Me.lb_totalPendientes.Name = "lb_totalPendientes"
        Me.lb_totalPendientes.Size = New System.Drawing.Size(70, 15)
        Me.lb_totalPendientes.TabIndex = 159
        Me.lb_totalPendientes.Text = "0"
        Me.lb_totalPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Label10)
        Me.Panel13.Location = New System.Drawing.Point(145, 242)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(87, 20)
        Me.Panel13.TabIndex = 174
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total Fact.:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_pendiente)
        Me.Panel1.Location = New System.Drawing.Point(423, 242)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 20)
        Me.Panel1.TabIndex = 167
        '
        'lbl_pendiente
        '
        Me.lbl_pendiente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendiente.ForeColor = System.Drawing.Color.Red
        Me.lbl_pendiente.Location = New System.Drawing.Point(6, 2)
        Me.lbl_pendiente.Name = "lbl_pendiente"
        Me.lbl_pendiente.Size = New System.Drawing.Size(101, 15)
        Me.lbl_pendiente.TabIndex = 159
        Me.lbl_pendiente.Text = "0,00"
        Me.lbl_pendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGV_Pendiente
        '
        Me.DGV_Pendiente.AllowUserToAddRows = False
        Me.DGV_Pendiente.AllowUserToDeleteRows = False
        Me.DGV_Pendiente.AllowUserToResizeColumns = False
        Me.DGV_Pendiente.AllowUserToResizeRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Pendiente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_Pendiente.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Pendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pendiente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Venc, Me.Dias, Me.DataGridViewTextBoxColumn6, Me.Pend})
        Me.DGV_Pendiente.Location = New System.Drawing.Point(6, 21)
        Me.DGV_Pendiente.Name = "DGV_Pendiente"
        Me.DGV_Pendiente.ReadOnly = True
        Me.DGV_Pendiente.RowHeadersVisible = False
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Teal
        Me.DGV_Pendiente.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DGV_Pendiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pendiente.Size = New System.Drawing.Size(526, 222)
        Me.DGV_Pendiente.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel20)
        Me.GroupBox6.Controls.Add(Me.Panel18)
        Me.GroupBox6.Controls.Add(Me.Panel21)
        Me.GroupBox6.Controls.Add(Me.Panel15)
        Me.GroupBox6.Controls.Add(Me.Panel19)
        Me.GroupBox6.Controls.Add(Me.Panel14)
        Me.GroupBox6.Controls.Add(Me.Panel3)
        Me.GroupBox6.Controls.Add(Me.DGV_NC)
        Me.GroupBox6.Controls.Add(Me.Panel4)
        Me.GroupBox6.Location = New System.Drawing.Point(470, 261)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(538, 159)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Notas de crédito"
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.Label12)
        Me.Panel20.Location = New System.Drawing.Point(157, 131)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(46, 20)
        Me.Panel20.TabIndex = 176
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(2, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 15)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.lbl_totalNCPend)
        Me.Panel18.Location = New System.Drawing.Point(268, 131)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(101, 20)
        Me.Panel18.TabIndex = 171
        '
        'lbl_totalNCPend
        '
        Me.lbl_totalNCPend.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalNCPend.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalNCPend.Location = New System.Drawing.Point(2, 2)
        Me.lbl_totalNCPend.Name = "lbl_totalNCPend"
        Me.lbl_totalNCPend.Size = New System.Drawing.Size(96, 15)
        Me.lbl_totalNCPend.TabIndex = 159
        Me.lbl_totalNCPend.Text = "0,00"
        Me.lbl_totalNCPend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel21
        '
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.Label15)
        Me.Panel21.Location = New System.Drawing.Point(103, 131)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(55, 20)
        Me.Panel21.TabIndex = 175
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Imp.:"
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.Label7)
        Me.Panel15.Location = New System.Drawing.Point(59, 131)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(46, 20)
        Me.Panel15.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.Label14)
        Me.Panel19.Location = New System.Drawing.Point(202, 131)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(68, 20)
        Me.Panel19.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total P.:"
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Label3)
        Me.Panel14.Location = New System.Drawing.Point(6, 131)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(54, 20)
        Me.Panel14.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Pend.:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl_NC)
        Me.Panel3.Location = New System.Drawing.Point(431, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 20)
        Me.Panel3.TabIndex = 169
        '
        'lbl_NC
        '
        Me.lbl_NC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NC.ForeColor = System.Drawing.Color.Black
        Me.lbl_NC.Location = New System.Drawing.Point(2, 2)
        Me.lbl_NC.Name = "lbl_NC"
        Me.lbl_NC.Size = New System.Drawing.Size(96, 15)
        Me.lbl_NC.TabIndex = 159
        Me.lbl_NC.Text = "0,00"
        Me.lbl_NC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGV_NC
        '
        Me.DGV_NC.AllowUserToAddRows = False
        Me.DGV_NC.AllowUserToDeleteRows = False
        Me.DGV_NC.AllowUserToResizeColumns = False
        Me.DGV_NC.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_NC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DGV_NC.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_NC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_NC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.Fecha1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.TipoNC})
        Me.DGV_NC.Location = New System.Drawing.Point(6, 20)
        Me.DGV_NC.Name = "DGV_NC"
        Me.DGV_NC.ReadOnly = True
        Me.DGV_NC.RowHeadersVisible = False
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Teal
        Me.DGV_NC.RowsDefaultCellStyle = DataGridViewCellStyle27
        Me.DGV_NC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_NC.Size = New System.Drawing.Size(526, 112)
        Me.DGV_NC.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(368, 131)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(64, 20)
        Me.Panel4.TabIndex = 168
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total I.:"
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.Color.DimGray
        Me.UserControl11.Location = New System.Drawing.Point(12, 328)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(449, 364)
        Me.UserControl11.TabIndex = 3
        '
        'Sp_consultaClienteTableAdapter
        '
        Me.Sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fact."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle16.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 163
        '
        'Venc
        '
        DataGridViewCellStyle17.Format = "d"
        Me.Venc.DefaultCellStyle = DataGridViewCellStyle17
        Me.Venc.HeaderText = "Venc."
        Me.Venc.Name = "Venc"
        Me.Venc.ReadOnly = True
        Me.Venc.Width = 75
        '
        'Dias
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "n0"
        Me.Dias.DefaultCellStyle = DataGridViewCellStyle18
        Me.Dias.HeaderText = "Días"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 45
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "#,##0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 73
        '
        'Pend
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle20.Format = "#,##0.00"
        Me.Pend.DefaultCellStyle = DataGridViewCellStyle20
        Me.Pend.HeaderText = "Pendiente"
        Me.Pend.Name = "Pend"
        Me.Pend.ReadOnly = True
        Me.Pend.Width = 90
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn8.HeaderText = "N.C."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fact."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'Fecha1
        '
        DataGridViewCellStyle25.Format = "d"
        Me.Fecha1.DefaultCellStyle = DataGridViewCellStyle25
        Me.Fecha1.HeaderText = "Fecha"
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.ReadOnly = True
        Me.Fecha1.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 189
        '
        'DataGridViewTextBoxColumn11
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "#,##0.00"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn11.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'TipoNC
        '
        Me.TipoNC.HeaderText = "Tipo"
        Me.TipoNC.Name = "TipoNC"
        Me.TipoNC.ReadOnly = True
        Me.TipoNC.Width = 42
        '
        'Frm_EvaluacionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 704)
        Me.Controls.Add(Me.lb_client)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_EvaluacionClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadísticas de ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Indicadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_Pendiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_NC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_evaluar As System.Windows.Forms.Button
    Friend WithEvents DGV_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Marcas As System.Windows.Forms.DataGridView
    Friend WithEvents UserControl11 As Tesis_Nueva.UserControl1
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Pendiente As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Indicadores As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_NC As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_pendiente As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_NC As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lbl_ventas As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PorcInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sugerida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Otros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_group As System.Windows.Forms.CheckBox
    Friend WithEvents lb_client As System.Windows.Forms.ListBox
    Friend WithEvents cb_client As System.Windows.Forms.TextBox
    Friend WithEvents SpconsultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lb_totalFact As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lb_totalPendientes As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents lbl_totalClientes As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents lbl_totalNCPend As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Fact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoNC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
