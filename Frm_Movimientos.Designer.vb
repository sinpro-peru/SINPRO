<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Movimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Movimientos))
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_numdeposito = New System.Windows.Forms.Label
        Me.Egresos = New System.Windows.Forms.Label
        Me.Ingresos = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tb_oficina = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_descripcion = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cb_f3 = New System.Windows.Forms.ComboBox
        Me.cb_f2 = New System.Windows.Forms.ComboBox
        Me.cb_f1 = New System.Windows.Forms.ComboBox
        Me.cb_fecha = New System.Windows.Forms.ComboBox
        Me.cb_ingreso = New System.Windows.Forms.ComboBox
        Me.cb_egreso = New System.Windows.Forms.ComboBox
        Me.cb_numerodep = New System.Windows.Forms.ComboBox
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DGV_Movimientos = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_banco = New System.Windows.Forms.ComboBox
        Me.lbl_Banco = New System.Windows.Forms.Label
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(6, 29)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(45, 15)
        Me.lbl_fecha.TabIndex = 82
        Me.lbl_fecha.Text = "Fecha:"
        '
        'lbl_numdeposito
        '
        Me.lbl_numdeposito.AutoSize = True
        Me.lbl_numdeposito.Location = New System.Drawing.Point(6, 103)
        Me.lbl_numdeposito.Name = "lbl_numdeposito"
        Me.lbl_numdeposito.Size = New System.Drawing.Size(98, 15)
        Me.lbl_numdeposito.TabIndex = 83
        Me.lbl_numdeposito.Text = "Num. Deposito:"
        '
        'Egresos
        '
        Me.Egresos.AutoSize = True
        Me.Egresos.Location = New System.Drawing.Point(6, 178)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Size = New System.Drawing.Size(55, 15)
        Me.Egresos.TabIndex = 84
        Me.Egresos.Text = "Egresos:"
        '
        'Ingresos
        '
        Me.Ingresos.AutoSize = True
        Me.Ingresos.Location = New System.Drawing.Point(6, 214)
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.Size = New System.Drawing.Size(59, 15)
        Me.Ingresos.TabIndex = 85
        Me.Ingresos.Text = "Ingresos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_oficina)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tb_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cb_f3)
        Me.GroupBox1.Controls.Add(Me.cb_f2)
        Me.GroupBox1.Controls.Add(Me.cb_f1)
        Me.GroupBox1.Controls.Add(Me.cb_fecha)
        Me.GroupBox1.Controls.Add(Me.cb_ingreso)
        Me.GroupBox1.Controls.Add(Me.cb_egreso)
        Me.GroupBox1.Controls.Add(Me.cb_numerodep)
        Me.GroupBox1.Controls.Add(Me.bt_aceptar)
        Me.GroupBox1.Controls.Add(Me.Ingresos)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GroupBox1.Controls.Add(Me.Egresos)
        Me.GroupBox1.Controls.Add(Me.lbl_numdeposito)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(704, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 321)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Movimiento"
        '
        'tb_oficina
        '
        Me.tb_oficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_oficina.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_oficina.FormattingEnabled = True
        Me.tb_oficina.Location = New System.Drawing.Point(102, 245)
        Me.tb_oficina.Name = "tb_oficina"
        Me.tb_oficina.Size = New System.Drawing.Size(112, 23)
        Me.tb_oficina.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Oficina:"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descripcion.FormattingEnabled = True
        Me.tb_descripcion.Location = New System.Drawing.Point(102, 137)
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(112, 23)
        Me.tb_descripcion.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Descripción:"
        '
        'cb_f3
        '
        Me.cb_f3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_f3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_f3.FormattingEnabled = True
        Me.cb_f3.Items.AddRange(New Object() {"dd", "mm", "aaaa"})
        Me.cb_f3.Location = New System.Drawing.Point(238, 67)
        Me.cb_f3.Name = "cb_f3"
        Me.cb_f3.Size = New System.Drawing.Size(52, 23)
        Me.cb_f3.TabIndex = 112
        '
        'cb_f2
        '
        Me.cb_f2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_f2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_f2.FormattingEnabled = True
        Me.cb_f2.Items.AddRange(New Object() {"dd", "mm", "aaaa"})
        Me.cb_f2.Location = New System.Drawing.Point(173, 66)
        Me.cb_f2.Name = "cb_f2"
        Me.cb_f2.Size = New System.Drawing.Size(52, 23)
        Me.cb_f2.TabIndex = 111
        '
        'cb_f1
        '
        Me.cb_f1.AutoCompleteCustomSource.AddRange(New String() {"dd", "mm", "aaaa"})
        Me.cb_f1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_f1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_f1.FormattingEnabled = True
        Me.cb_f1.Items.AddRange(New Object() {"dd", "mm", "aaaa"})
        Me.cb_f1.Location = New System.Drawing.Point(102, 67)
        Me.cb_f1.Name = "cb_f1"
        Me.cb_f1.Size = New System.Drawing.Size(52, 23)
        Me.cb_f1.TabIndex = 110
        '
        'cb_fecha
        '
        Me.cb_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_fecha.FormattingEnabled = True
        Me.cb_fecha.Location = New System.Drawing.Point(102, 26)
        Me.cb_fecha.Name = "cb_fecha"
        Me.cb_fecha.Size = New System.Drawing.Size(112, 23)
        Me.cb_fecha.TabIndex = 109
        '
        'cb_ingreso
        '
        Me.cb_ingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ingreso.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ingreso.FormattingEnabled = True
        Me.cb_ingreso.Location = New System.Drawing.Point(102, 211)
        Me.cb_ingreso.Name = "cb_ingreso"
        Me.cb_ingreso.Size = New System.Drawing.Size(112, 23)
        Me.cb_ingreso.TabIndex = 108
        '
        'cb_egreso
        '
        Me.cb_egreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_egreso.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_egreso.FormattingEnabled = True
        Me.cb_egreso.Location = New System.Drawing.Point(102, 175)
        Me.cb_egreso.Name = "cb_egreso"
        Me.cb_egreso.Size = New System.Drawing.Size(112, 23)
        Me.cb_egreso.TabIndex = 107
        '
        'cb_numerodep
        '
        Me.cb_numerodep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_numerodep.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_numerodep.FormattingEnabled = True
        Me.cb_numerodep.Location = New System.Drawing.Point(102, 100)
        Me.cb_numerodep.Name = "cb_numerodep"
        Me.cb_numerodep.Size = New System.Drawing.Size(112, 23)
        Me.cb_numerodep.TabIndex = 106
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(129, 286)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 29)
        Me.bt_aceptar.TabIndex = 86
        Me.bt_aceptar.Text = "Cargar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Formato Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 15)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "/"
        '
        'DGV_Movimientos
        '
        Me.DGV_Movimientos.AllowUserToAddRows = False
        Me.DGV_Movimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Movimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Movimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Movimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Movimientos.EnableHeadersVisualStyles = False
        Me.DGV_Movimientos.Location = New System.Drawing.Point(12, 23)
        Me.DGV_Movimientos.MultiSelect = False
        Me.DGV_Movimientos.Name = "DGV_Movimientos"
        Me.DGV_Movimientos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Movimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Movimientos.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DGV_Movimientos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Movimientos.Size = New System.Drawing.Size(689, 669)
        Me.DGV_Movimientos.TabIndex = 10002
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_banco)
        Me.GroupBox2.Controls.Add(Me.lbl_Banco)
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
        Me.GroupBox2.Location = New System.Drawing.Point(707, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 244)
        Me.GroupBox2.TabIndex = 10004
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selección de Archivo"
        '
        'cb_banco
        '
        Me.cb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_banco.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_banco.FormattingEnabled = True
        Me.cb_banco.Location = New System.Drawing.Point(89, 164)
        Me.cb_banco.Name = "cb_banco"
        Me.cb_banco.Size = New System.Drawing.Size(173, 23)
        Me.cb_banco.TabIndex = 20007
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(38, 168)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Banco.TabIndex = 20006
        Me.lbl_Banco.Text = "Banco:"
        '
        'bt_foto
        '
        Me.bt_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_foto.Location = New System.Drawing.Point(207, 122)
        Me.bt_foto.Name = "bt_foto"
        Me.bt_foto.Size = New System.Drawing.Size(88, 22)
        Me.bt_foto.TabIndex = 20004
        Me.bt_foto.Text = "Examinar..."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(126, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20003
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tb_archivo
        '
        Me.tb_archivo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_archivo.Location = New System.Drawing.Point(39, 122)
        Me.tb_archivo.Name = "tb_archivo"
        Me.tb_archivo.ReadOnly = True
        Me.tb_archivo.Size = New System.Drawing.Size(162, 22)
        Me.tb_archivo.TabIndex = 20005
        '
        'lbl_caractec2
        '
        Me.lbl_caractec2.AutoSize = True
        Me.lbl_caractec2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.lbl_caractec2.Location = New System.Drawing.Point(95, 58)
        Me.lbl_caractec2.Name = "lbl_caractec2"
        Me.lbl_caractec2.Size = New System.Drawing.Size(59, 15)
        Me.lbl_caractec2.TabIndex = 6
        Me.lbl_caractec2.Text = "Caracter:"
        Me.lbl_caractec2.Visible = False
        '
        'rb_carcter2
        '
        Me.rb_carcter2.Location = New System.Drawing.Point(158, 54)
        Me.rb_carcter2.Name = "rb_carcter2"
        Me.rb_carcter2.Size = New System.Drawing.Size(30, 20)
        Me.rb_carcter2.TabIndex = 5
        Me.rb_carcter2.Visible = False
        '
        'lbl_Caracter
        '
        Me.lbl_Caracter.AutoSize = True
        Me.lbl_Caracter.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.lbl_Caracter.Location = New System.Drawing.Point(95, 94)
        Me.lbl_Caracter.Name = "lbl_Caracter"
        Me.lbl_Caracter.Size = New System.Drawing.Size(59, 15)
        Me.lbl_Caracter.TabIndex = 4
        Me.lbl_Caracter.Text = "Caracter:"
        Me.lbl_Caracter.Visible = False
        '
        'tb_caracter
        '
        Me.tb_caracter.Location = New System.Drawing.Point(158, 92)
        Me.tb_caracter.Name = "tb_caracter"
        Me.tb_caracter.Size = New System.Drawing.Size(30, 20)
        Me.tb_caracter.TabIndex = 3
        Me.tb_caracter.Visible = False
        '
        'rb_csv
        '
        Me.rb_csv.AutoSize = True
        Me.rb_csv.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_csv.Location = New System.Drawing.Point(39, 92)
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
        Me.rb_txt.Location = New System.Drawing.Point(39, 56)
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
        Me.rb_excel.Location = New System.Drawing.Point(39, 23)
        Me.rb_excel.Name = "rb_excel"
        Me.rb_excel.Size = New System.Drawing.Size(59, 19)
        Me.rb_excel.TabIndex = 0
        Me.rb_excel.TabStop = True
        Me.rb_excel.Text = "Excel"
        Me.rb_excel.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Tesis_Nueva.My.Resources.Resources.logo1
        Me.PictureBox3.Location = New System.Drawing.Point(707, 600)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(308, 92)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10003
        Me.PictureBox3.TabStop = False
        '
        'Frm_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 707)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DGV_Movimientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Movimientos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_numdeposito As System.Windows.Forms.Label
    Friend WithEvents Egresos As System.Windows.Forms.Label
    Friend WithEvents Ingresos As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents cb_ingreso As System.Windows.Forms.ComboBox
    Friend WithEvents cb_egreso As System.Windows.Forms.ComboBox
    Friend WithEvents cb_numerodep As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents cb_fecha As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_caractec2 As System.Windows.Forms.Label
    Friend WithEvents rb_carcter2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Caracter As System.Windows.Forms.Label
    Friend WithEvents tb_caracter As System.Windows.Forms.TextBox
    Friend WithEvents rb_csv As System.Windows.Forms.RadioButton
    Friend WithEvents rb_txt As System.Windows.Forms.RadioButton
    Friend WithEvents rb_excel As System.Windows.Forms.RadioButton
    Friend WithEvents bt_foto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tb_archivo As System.Windows.Forms.TextBox
    Friend WithEvents cb_f1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_f3 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_f2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_descripcion As System.Windows.Forms.ComboBox
    Friend WithEvents tb_oficina As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
End Class
