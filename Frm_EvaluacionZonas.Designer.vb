<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EvaluacionZonas
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EvaluacionZonas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Estados = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cb_ImportanciaVentas = New System.Windows.Forms.ComboBox
        Me.cb_Importanciaclientes = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.bt_evaluar = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.tb_porDebajo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CodigoVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VClient = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoBs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Puntuacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pos = New System.Windows.Forms.DataGridViewImageColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.UserControl41 = New Tesis_Nueva.UserControl4
        Me.UserControl51 = New Tesis_Nueva.UserControl5
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(121, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 50)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período de evaluación"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(227, 18)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(58, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde:"
        '
        'DGV_Estados
        '
        Me.DGV_Estados.AllowUserToAddRows = False
        Me.DGV_Estados.AllowUserToDeleteRows = False
        Me.DGV_Estados.AllowUserToResizeColumns = False
        Me.DGV_Estados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Estados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Estados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Estados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Estados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoVendedor, Me.VClient, Me.Nombre, Me.MontoBs, Me.Porcentaje, Me.P, Me.Puntuacion, Me.Pos})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Estados.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Estados.Location = New System.Drawing.Point(4, 39)
        Me.DGV_Estados.Name = "DGV_Estados"
        Me.DGV_Estados.ReadOnly = True
        Me.DGV_Estados.RowHeadersVisible = False
        Me.DGV_Estados.RowTemplate.Height = 26
        Me.DGV_Estados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Estados.Size = New System.Drawing.Size(525, 128)
        Me.DGV_Estados.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DGV_Estados)
        Me.GroupBox3.Controls.Add(Me.cb_ImportanciaVentas)
        Me.GroupBox3.Controls.Add(Me.cb_Importanciaclientes)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(473, 507)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 191)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información desglosada"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Bold ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 14)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "##"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Bold ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "##"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Eras Bold ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "###"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 14)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Clientes V.:"
        '
        'cb_ImportanciaVentas
        '
        Me.cb_ImportanciaVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ImportanciaVentas.Font = New System.Drawing.Font("Eras Medium ITC", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ImportanciaVentas.FormattingEnabled = True
        Me.cb_ImportanciaVentas.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_ImportanciaVentas.Location = New System.Drawing.Point(408, 16)
        Me.cb_ImportanciaVentas.Name = "cb_ImportanciaVentas"
        Me.cb_ImportanciaVentas.Size = New System.Drawing.Size(43, 19)
        Me.cb_ImportanciaVentas.TabIndex = 11
        '
        'cb_Importanciaclientes
        '
        Me.cb_Importanciaclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Importanciaclientes.Font = New System.Drawing.Font("Eras Medium ITC", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Importanciaclientes.FormattingEnabled = True
        Me.cb_Importanciaclientes.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_Importanciaclientes.Location = New System.Drawing.Point(248, 16)
        Me.cb_Importanciaclientes.Name = "cb_Importanciaclientes"
        Me.cb_Importanciaclientes.Size = New System.Drawing.Size(43, 19)
        Me.cb_Importanciaclientes.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Importancia:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(475, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 50)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período de comparación"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(69, 18)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker3.TabIndex = 15
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(238, 18)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker4.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Desde:"
        '
        'bt_evaluar
        '
        Me.bt_evaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_evaluar.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_evaluar.Location = New System.Drawing.Point(842, 21)
        Me.bt_evaluar.Name = "bt_evaluar"
        Me.bt_evaluar.Size = New System.Drawing.Size(63, 23)
        Me.bt_evaluar.TabIndex = 14
        Me.bt_evaluar.Text = "Evaluar"
        Me.bt_evaluar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(558, 469)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(238, 18)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Agrupar los estados que tengas menos del "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'tb_porDebajo
        '
        Me.tb_porDebajo.Enabled = False
        Me.tb_porDebajo.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_porDebajo.Location = New System.Drawing.Point(792, 467)
        Me.tb_porDebajo.Name = "tb_porDebajo"
        Me.tb_porDebajo.Size = New System.Drawing.Size(32, 20)
        Me.tb_porDebajo.TabIndex = 16
        Me.tb_porDebajo.Text = "0"
        Me.tb_porDebajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(827, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 14)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "% del total de clientes"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Down-Green.png")
        Me.ImageList1.Images.SetKeyName(1, "Down-Red.png")
        Me.ImageList1.Images.SetKeyName(2, "Down-Yellow.png")
        Me.ImageList1.Images.SetKeyName(3, "Equal-Green2.png")
        Me.ImageList1.Images.SetKeyName(4, "Equal-Red2.png")
        Me.ImageList1.Images.SetKeyName(5, "Equal-Yellow2.png")
        Me.ImageList1.Images.SetKeyName(6, "Up-Green.png")
        Me.ImageList1.Images.SetKeyName(7, "Up-Red.png")
        Me.ImageList1.Images.SetKeyName(8, "Up-Yellow.png")
        Me.ImageList1.Images.SetKeyName(9, "Nothing.png")
        Me.ImageList1.Images.SetKeyName(10, "2317513336_3caa9690e5.jpg")
        Me.ImageList1.Images.SetKeyName(11, "Gold-Medal.png")
        Me.ImageList1.Images.SetKeyName(12, "Silver-Medal.png")
        Me.ImageList1.Images.SetKeyName(13, "Bronze-Medal.png")
        '
        'CodigoVendedor
        '
        Me.CodigoVendedor.HeaderText = "Estado"
        Me.CodigoVendedor.Name = "CodigoVendedor"
        Me.CodigoVendedor.ReadOnly = True
        Me.CodigoVendedor.Width = 105
        '
        'VClient
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VClient.DefaultCellStyle = DataGridViewCellStyle3
        Me.VClient.HeaderText = "Ctes. V."
        Me.VClient.Name = "VClient"
        Me.VClient.ReadOnly = True
        Me.VClient.Width = 70
        '
        'Nombre
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nombre.HeaderText = "Ctes. T."
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 68
        '
        'MontoBs
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "p"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MontoBs.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoBs.HeaderText = "%"
        Me.MontoBs.Name = "MontoBs"
        Me.MontoBs.ReadOnly = True
        Me.MontoBs.Width = 60
        '
        'Porcentaje
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "#,##0.00"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Porcentaje.DefaultCellStyle = DataGridViewCellStyle6
        Me.Porcentaje.HeaderText = "Ventas (Bs.)"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.ReadOnly = True
        '
        'P
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "p"
        Me.P.DefaultCellStyle = DataGridViewCellStyle7
        Me.P.HeaderText = "%"
        Me.P.Name = "P"
        Me.P.ReadOnly = True
        Me.P.Width = 60
        '
        'Puntuacion
        '
        Me.Puntuacion.HeaderText = "Puntuacion"
        Me.Puntuacion.Name = "Puntuacion"
        Me.Puntuacion.ReadOnly = True
        Me.Puntuacion.Visible = False
        '
        'Pos
        '
        Me.Pos.HeaderText = "Pos"
        Me.Pos.Name = "Pos"
        Me.Pos.ReadOnly = True
        Me.Pos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Pos.Width = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total ventas eva.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total ventas comp.:"
        '
        'UserControl41
        '
        Me.UserControl41.Location = New System.Drawing.Point(477, 62)
        Me.UserControl41.Name = "UserControl41"
        Me.UserControl41.Size = New System.Drawing.Size(527, 440)
        Me.UserControl41.TabIndex = 8
        '
        'UserControl51
        '
        Me.UserControl51.BackColor = System.Drawing.SystemColors.Control
        Me.UserControl51.Location = New System.Drawing.Point(8, 61)
        Me.UserControl51.Name = "UserControl51"
        Me.UserControl51.Size = New System.Drawing.Size(462, 639)
        Me.UserControl51.TabIndex = 0
        '
        'Frm_EvaluacionZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 704)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_porDebajo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.bt_evaluar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UserControl41)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UserControl51)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_EvaluacionZonas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de zonas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserControl51 As Tesis_Nueva.UserControl5
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserControl41 As Tesis_Nueva.UserControl4
    Friend WithEvents DGV_Estados As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_evaluar As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents tb_porDebajo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_ImportanciaVentas As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Importanciaclientes As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CodigoVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VClient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoBs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Puntuacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pos As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
