<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Competencia_Productos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Competencia_Productos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_foto = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.tb_archivo = New System.Windows.Forms.TextBox
        Me.lbl_caractec2 = New System.Windows.Forms.Label
        Me.rb_carcter2 = New System.Windows.Forms.TextBox
        Me.lbl_Caracter = New System.Windows.Forms.Label
        Me.tb_caracter = New System.Windows.Forms.TextBox
        Me.rb_csv = New System.Windows.Forms.RadioButton
        Me.rb_txt = New System.Windows.Forms.RadioButton
        Me.rb_excel = New System.Windows.Forms.RadioButton
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_precio = New System.Windows.Forms.ComboBox
        Me.lbl_precio = New System.Windows.Forms.Label
        Me.cb_codOEM = New System.Windows.Forms.ComboBox
        Me.cb_stock = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cb_marca = New System.Windows.Forms.ComboBox
        Me.lbl_marca = New System.Windows.Forms.Label
        Me.cb_codfab = New System.Windows.Forms.ComboBox
        Me.cb_año = New System.Windows.Forms.ComboBox
        Me.cb_modelo = New System.Windows.Forms.ComboBox
        Me.cb_descripcion = New System.Windows.Forms.ComboBox
        Me.cb_cod_imp = New System.Windows.Forms.ComboBox
        Me.bt_cargar = New System.Windows.Forms.Button
        Me.lbl_importador = New System.Windows.Forms.Label
        Me.lbl_año = New System.Windows.Forms.Label
        Me.lbl_codFab = New System.Windows.Forms.Label
        Me.lbl_modelo = New System.Windows.Forms.Label
        Me.lbl_descripcion = New System.Windows.Forms.Label
        Me.lbl_codOEM = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.tb_rif = New System.Windows.Forms.TextBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bt_foto)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.tb_archivo)
        Me.GroupBox2.Controls.Add(Me.lbl_caractec2)
        Me.GroupBox2.Controls.Add(Me.rb_carcter2)
        Me.GroupBox2.Controls.Add(Me.lbl_Caracter)
        Me.GroupBox2.Controls.Add(Me.tb_caracter)
        Me.GroupBox2.Controls.Add(Me.rb_csv)
        Me.GroupBox2.Controls.Add(Me.rb_txt)
        Me.GroupBox2.Controls.Add(Me.rb_excel)
        Me.GroupBox2.Location = New System.Drawing.Point(703, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 190)
        Me.GroupBox2.TabIndex = 10008
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selección de Archivo"
        '
        'bt_foto
        '
        Me.bt_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_foto.Location = New System.Drawing.Point(207, 119)
        Me.bt_foto.Name = "bt_foto"
        Me.bt_foto.Size = New System.Drawing.Size(88, 22)
        Me.bt_foto.TabIndex = 20004
        Me.bt_foto.Text = "Examinar..."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(114, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20003
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tb_archivo
        '
        Me.tb_archivo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_archivo.Location = New System.Drawing.Point(39, 119)
        Me.tb_archivo.Name = "tb_archivo"
        Me.tb_archivo.ReadOnly = True
        Me.tb_archivo.Size = New System.Drawing.Size(162, 22)
        Me.tb_archivo.TabIndex = 20005
        '
        'lbl_caractec2
        '
        Me.lbl_caractec2.AutoSize = True
        Me.lbl_caractec2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.lbl_caractec2.Location = New System.Drawing.Point(95, 55)
        Me.lbl_caractec2.Name = "lbl_caractec2"
        Me.lbl_caractec2.Size = New System.Drawing.Size(59, 15)
        Me.lbl_caractec2.TabIndex = 6
        Me.lbl_caractec2.Text = "Caracter:"
        Me.lbl_caractec2.Visible = False
        '
        'rb_carcter2
        '
        Me.rb_carcter2.Location = New System.Drawing.Point(158, 51)
        Me.rb_carcter2.Name = "rb_carcter2"
        Me.rb_carcter2.Size = New System.Drawing.Size(30, 20)
        Me.rb_carcter2.TabIndex = 5
        Me.rb_carcter2.Visible = False
        '
        'lbl_Caracter
        '
        Me.lbl_Caracter.AutoSize = True
        Me.lbl_Caracter.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.lbl_Caracter.Location = New System.Drawing.Point(95, 91)
        Me.lbl_Caracter.Name = "lbl_Caracter"
        Me.lbl_Caracter.Size = New System.Drawing.Size(59, 15)
        Me.lbl_Caracter.TabIndex = 4
        Me.lbl_Caracter.Text = "Caracter:"
        Me.lbl_Caracter.Visible = False
        '
        'tb_caracter
        '
        Me.tb_caracter.Location = New System.Drawing.Point(158, 89)
        Me.tb_caracter.Name = "tb_caracter"
        Me.tb_caracter.Size = New System.Drawing.Size(30, 20)
        Me.tb_caracter.TabIndex = 3
        Me.tb_caracter.Visible = False
        '
        'rb_csv
        '
        Me.rb_csv.AutoSize = True
        Me.rb_csv.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_csv.Location = New System.Drawing.Point(39, 89)
        Me.rb_csv.Name = "rb_csv"
        Me.rb_csv.Size = New System.Drawing.Size(51, 19)
        Me.rb_csv.TabIndex = 2
        Me.rb_csv.TabStop = True
        Me.rb_csv.Text = "CSV"
        Me.rb_csv.UseVisualStyleBackColor = True
        '
        'rb_txt
        '
        Me.rb_txt.AutoSize = True
        Me.rb_txt.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_txt.Location = New System.Drawing.Point(39, 53)
        Me.rb_txt.Name = "rb_txt"
        Me.rb_txt.Size = New System.Drawing.Size(50, 19)
        Me.rb_txt.TabIndex = 1
        Me.rb_txt.TabStop = True
        Me.rb_txt.Text = "TXT"
        Me.rb_txt.UseVisualStyleBackColor = True
        '
        'rb_excel
        '
        Me.rb_excel.AutoSize = True
        Me.rb_excel.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_excel.Location = New System.Drawing.Point(39, 20)
        Me.rb_excel.Name = "rb_excel"
        Me.rb_excel.Size = New System.Drawing.Size(59, 19)
        Me.rb_excel.TabIndex = 0
        Me.rb_excel.TabStop = True
        Me.rb_excel.Text = "Excel"
        Me.rb_excel.UseVisualStyleBackColor = True
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.EnableHeadersVisualStyles = False
        Me.DGV_Productos.Location = New System.Drawing.Point(8, 58)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(689, 630)
        Me.DGV_Productos.TabIndex = 10006
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_precio)
        Me.GroupBox1.Controls.Add(Me.lbl_precio)
        Me.GroupBox1.Controls.Add(Me.cb_codOEM)
        Me.GroupBox1.Controls.Add(Me.cb_stock)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_marca)
        Me.GroupBox1.Controls.Add(Me.lbl_marca)
        Me.GroupBox1.Controls.Add(Me.cb_codfab)
        Me.GroupBox1.Controls.Add(Me.cb_año)
        Me.GroupBox1.Controls.Add(Me.cb_modelo)
        Me.GroupBox1.Controls.Add(Me.cb_descripcion)
        Me.GroupBox1.Controls.Add(Me.cb_cod_imp)
        Me.GroupBox1.Controls.Add(Me.bt_cargar)
        Me.GroupBox1.Controls.Add(Me.lbl_importador)
        Me.GroupBox1.Controls.Add(Me.lbl_año)
        Me.GroupBox1.Controls.Add(Me.lbl_codFab)
        Me.GroupBox1.Controls.Add(Me.lbl_modelo)
        Me.GroupBox1.Controls.Add(Me.lbl_descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_codOEM)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(703, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 375)
        Me.GroupBox1.TabIndex = 10005
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a Cargar"
        '
        'cb_precio
        '
        Me.cb_precio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_precio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_precio.FormattingEnabled = True
        Me.cb_precio.Location = New System.Drawing.Point(137, 296)
        Me.cb_precio.Name = "cb_precio"
        Me.cb_precio.Size = New System.Drawing.Size(112, 23)
        Me.cb_precio.TabIndex = 122
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(6, 299)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(46, 15)
        Me.lbl_precio.TabIndex = 121
        Me.lbl_precio.Text = "Precio:"
        '
        'cb_codOEM
        '
        Me.cb_codOEM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_codOEM.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_codOEM.FormattingEnabled = True
        Me.cb_codOEM.Location = New System.Drawing.Point(137, 93)
        Me.cb_codOEM.Name = "cb_codOEM"
        Me.cb_codOEM.Size = New System.Drawing.Size(112, 23)
        Me.cb_codOEM.TabIndex = 120
        '
        'cb_stock
        '
        Me.cb_stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_stock.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_stock.FormattingEnabled = True
        Me.cb_stock.Location = New System.Drawing.Point(137, 263)
        Me.cb_stock.Name = "cb_stock"
        Me.cb_stock.Size = New System.Drawing.Size(112, 23)
        Me.cb_stock.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Stock:"
        '
        'cb_marca
        '
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(137, 162)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(112, 23)
        Me.cb_marca.TabIndex = 117
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Location = New System.Drawing.Point(6, 165)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(43, 15)
        Me.lbl_marca.TabIndex = 116
        Me.lbl_marca.Text = "Marca"
        '
        'cb_codfab
        '
        Me.cb_codfab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_codfab.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_codfab.FormattingEnabled = True
        Me.cb_codfab.Location = New System.Drawing.Point(137, 60)
        Me.cb_codfab.Name = "cb_codfab"
        Me.cb_codfab.Size = New System.Drawing.Size(112, 23)
        Me.cb_codfab.TabIndex = 109
        '
        'cb_año
        '
        Me.cb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_año.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_año.FormattingEnabled = True
        Me.cb_año.Location = New System.Drawing.Point(137, 230)
        Me.cb_año.Name = "cb_año"
        Me.cb_año.Size = New System.Drawing.Size(112, 23)
        Me.cb_año.TabIndex = 108
        '
        'cb_modelo
        '
        Me.cb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_modelo.FormattingEnabled = True
        Me.cb_modelo.Location = New System.Drawing.Point(137, 197)
        Me.cb_modelo.Name = "cb_modelo"
        Me.cb_modelo.Size = New System.Drawing.Size(112, 23)
        Me.cb_modelo.TabIndex = 107
        '
        'cb_descripcion
        '
        Me.cb_descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_descripcion.FormattingEnabled = True
        Me.cb_descripcion.Location = New System.Drawing.Point(137, 128)
        Me.cb_descripcion.Name = "cb_descripcion"
        Me.cb_descripcion.Size = New System.Drawing.Size(112, 23)
        Me.cb_descripcion.TabIndex = 106
        '
        'cb_cod_imp
        '
        Me.cb_cod_imp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cod_imp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cod_imp.FormattingEnabled = True
        Me.cb_cod_imp.Location = New System.Drawing.Point(137, 28)
        Me.cb_cod_imp.Name = "cb_cod_imp"
        Me.cb_cod_imp.Size = New System.Drawing.Size(112, 23)
        Me.cb_cod_imp.TabIndex = 87
        '
        'bt_cargar
        '
        Me.bt_cargar.BackColor = System.Drawing.Color.White
        Me.bt_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cargar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cargar.Location = New System.Drawing.Point(114, 340)
        Me.bt_cargar.Name = "bt_cargar"
        Me.bt_cargar.Size = New System.Drawing.Size(75, 29)
        Me.bt_cargar.TabIndex = 86
        Me.bt_cargar.Text = "Cargar"
        Me.bt_cargar.UseVisualStyleBackColor = False
        '
        'lbl_importador
        '
        Me.lbl_importador.AutoSize = True
        Me.lbl_importador.Location = New System.Drawing.Point(6, 31)
        Me.lbl_importador.Name = "lbl_importador"
        Me.lbl_importador.Size = New System.Drawing.Size(107, 15)
        Me.lbl_importador.TabIndex = 81
        Me.lbl_importador.Text = "Cod. Importador:"
        '
        'lbl_año
        '
        Me.lbl_año.AutoSize = True
        Me.lbl_año.Location = New System.Drawing.Point(6, 233)
        Me.lbl_año.Name = "lbl_año"
        Me.lbl_año.Size = New System.Drawing.Size(35, 15)
        Me.lbl_año.TabIndex = 85
        Me.lbl_año.Text = "Año:"
        '
        'lbl_codFab
        '
        Me.lbl_codFab.AutoSize = True
        Me.lbl_codFab.Location = New System.Drawing.Point(6, 63)
        Me.lbl_codFab.Name = "lbl_codFab"
        Me.lbl_codFab.Size = New System.Drawing.Size(83, 15)
        Me.lbl_codFab.TabIndex = 82
        Me.lbl_codFab.Text = "Cod. Fábrica:"
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(6, 200)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(55, 15)
        Me.lbl_modelo.TabIndex = 84
        Me.lbl_modelo.Text = "Modelo:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 131)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(79, 15)
        Me.lbl_descripcion.TabIndex = 83
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'lbl_codOEM
        '
        Me.lbl_codOEM.AutoSize = True
        Me.lbl_codOEM.Location = New System.Drawing.Point(6, 101)
        Me.lbl_codOEM.Name = "lbl_codOEM"
        Me.lbl_codOEM.Size = New System.Drawing.Size(68, 15)
        Me.lbl_codOEM.TabIndex = 115
        Me.lbl_codOEM.Text = "Cod. OEM:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(703, 596)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(308, 92)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10007
        Me.PictureBox3.TabStop = False
        '
        'tb_rif
        '
        Me.tb_rif.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rif.Location = New System.Drawing.Point(35, 13)
        Me.tb_rif.Name = "tb_rif"
        Me.tb_rif.ReadOnly = True
        Me.tb_rif.Size = New System.Drawing.Size(162, 22)
        Me.tb_rif.TabIndex = 20006
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(268, 13)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.ReadOnly = True
        Me.tb_nombre.Size = New System.Drawing.Size(162, 22)
        Me.tb_nombre.TabIndex = 20007
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 15)
        Me.Label1.TabIndex = 20008
        Me.Label1.Text = "Rif:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(203, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 20009
        Me.Label2.Text = "Nombre:"
        '
        'Frm_Competencia_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 707)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_nombre)
        Me.Controls.Add(Me.tb_rif)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Competencia_Productos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Productos Competencia"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_foto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tb_archivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_caractec2 As System.Windows.Forms.Label
    Friend WithEvents rb_carcter2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Caracter As System.Windows.Forms.Label
    Friend WithEvents tb_caracter As System.Windows.Forms.TextBox
    Friend WithEvents rb_csv As System.Windows.Forms.RadioButton
    Friend WithEvents rb_txt As System.Windows.Forms.RadioButton
    Friend WithEvents rb_excel As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_stock As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents cb_codfab As System.Windows.Forms.ComboBox
    Friend WithEvents cb_año As System.Windows.Forms.ComboBox
    Friend WithEvents cb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_descripcion As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cod_imp As System.Windows.Forms.ComboBox
    Friend WithEvents bt_cargar As System.Windows.Forms.Button
    Friend WithEvents lbl_importador As System.Windows.Forms.Label
    Friend WithEvents lbl_año As System.Windows.Forms.Label
    Friend WithEvents lbl_codFab As System.Windows.Forms.Label
    Friend WithEvents lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_codOEM As System.Windows.Forms.Label
    Friend WithEvents cb_codOEM As System.Windows.Forms.ComboBox
    Friend WithEvents cb_precio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents tb_rif As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
