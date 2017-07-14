<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EvaluacionProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EvaluacionProductos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.bt_evaluar = New System.Windows.Forms.Button
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.cb_grupo = New System.Windows.Forms.ComboBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.tb_proveedor = New System.Windows.Forms.ComboBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.cb_marca = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.tb_porDebajo = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.UserControl51 = New Tesis_Nueva.UserControl5
        Me.UserControl41 = New Tesis_Nueva.UserControl4
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.cb_alfa = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.cb_meses = New System.Windows.Forms.ComboBox
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaProductosEvaluacionDSSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.UserControl61 = New Tesis_Nueva.UserControl6
        Me.Sp_consultaProductosEvaluacionDSSTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosEvaluacionDSSTableAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductosEvaluacionDSSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_evaluar)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.cb_grupo)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.tb_proveedor)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.cb_marca)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de evaluación"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(624, 532)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(371, 136)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 168
        Me.PictureBox3.TabStop = False
        '
        'bt_evaluar
        '
        Me.bt_evaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_evaluar.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_evaluar.Location = New System.Drawing.Point(105, 139)
        Me.bt_evaluar.Name = "bt_evaluar"
        Me.bt_evaluar.Size = New System.Drawing.Size(63, 23)
        Me.bt_evaluar.TabIndex = 26
        Me.bt_evaluar.Text = "Evaluar"
        Me.bt_evaluar.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 103)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 18)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Totales"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'cb_grupo
        '
        Me.cb_grupo.Enabled = False
        Me.cb_grupo.FormattingEnabled = True
        Me.cb_grupo.Location = New System.Drawing.Point(87, 80)
        Me.cb_grupo.Name = "cb_grupo"
        Me.cb_grupo.Size = New System.Drawing.Size(163, 22)
        Me.cb_grupo.TabIndex = 5
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 80)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(59, 18)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Grupo"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'tb_proveedor
        '
        Me.tb_proveedor.Enabled = False
        Me.tb_proveedor.FormattingEnabled = True
        Me.tb_proveedor.Location = New System.Drawing.Point(87, 55)
        Me.tb_proveedor.Name = "tb_proveedor"
        Me.tb_proveedor.Size = New System.Drawing.Size(163, 22)
        Me.tb_proveedor.TabIndex = 3
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 18)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Proveedor"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'cb_marca
        '
        Me.cb_marca.Enabled = False
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(87, 31)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(163, 22)
        Me.cb_marca.TabIndex = 150
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 18)
        Me.RadioButton1.TabIndex = 1000
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Marca"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(272, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 14)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "% del total de productos"
        '
        'tb_porDebajo
        '
        Me.tb_porDebajo.Enabled = False
        Me.tb_porDebajo.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_porDebajo.Location = New System.Drawing.Point(237, 3)
        Me.tb_porDebajo.Name = "tb_porDebajo"
        Me.tb_porDebajo.Size = New System.Drawing.Size(32, 20)
        Me.tb_porDebajo.TabIndex = 170
        Me.tb_porDebajo.Text = "0"
        Me.tb_porDebajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(238, 18)
        Me.CheckBox1.TabIndex = 169
        Me.CheckBox1.Text = "Agrupar los estados que tengas menos del "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1014, 706)
        Me.TabControl1.TabIndex = 1001
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.UserControl51)
        Me.TabPage1.Controls.Add(Me.UserControl41)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1006, 679)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UserControl51
        '
        Me.UserControl51.BackColor = System.Drawing.SystemColors.Control
        Me.UserControl51.Location = New System.Drawing.Point(624, 195)
        Me.UserControl51.Name = "UserControl51"
        Me.UserControl51.Size = New System.Drawing.Size(371, 320)
        Me.UserControl51.TabIndex = 0
        '
        'UserControl41
        '
        Me.UserControl41.Location = New System.Drawing.Point(15, 198)
        Me.UserControl41.Name = "UserControl41"
        Me.UserControl41.Size = New System.Drawing.Size(588, 426)
        Me.UserControl41.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.DomainUpDown1)
        Me.TabPage2.Controls.Add(Me.tb_buscarcodigo)
        Me.TabPage2.Controls.Add(Me.DGV_Productos)
        Me.TabPage2.Controls.Add(Me.UserControl61)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1006, 679)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Indicadores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(785, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10011
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.cb_alfa)
        Me.Panel2.Location = New System.Drawing.Point(520, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 51)
        Me.Panel2.TabIndex = 10008
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 15)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Pronóstico"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 15)
        Me.Label28.TabIndex = 10009
        Me.Label28.Text = "de ventas"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(149, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(12, 15)
        Me.Label30.TabIndex = 10008
        Me.Label30.Text = ")"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(167, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 15)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "0"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(82, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(26, 15)
        Me.Label29.TabIndex = 10010
        Me.Label29.Text = "(α="
        '
        'cb_alfa
        '
        Me.cb_alfa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_alfa.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.cb_alfa.FormattingEnabled = True
        Me.cb_alfa.Items.AddRange(New Object() {"0", "0,1", "0,2", "0,3", "0,4", "0,5", "0,6", "0,7", "0,8", "0,9", "1"})
        Me.cb_alfa.Location = New System.Drawing.Point(108, 15)
        Me.cb_alfa.Name = "cb_alfa"
        Me.cb_alfa.Size = New System.Drawing.Size(41, 22)
        Me.cb_alfa.TabIndex = 10007
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(421, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(249, 79)
        Me.GroupBox3.TabIndex = 10010
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Indicadores de Inventario"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(180, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 15)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "0,00"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 15)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Indice de rotación:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(180, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 15)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "0,00"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(170, 15)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Ganancia promedio (%):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(421, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 101)
        Me.GroupBox2.TabIndex = 10009
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Indicadores de productos"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(215, 74)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(238, 15)
        Me.Label38.TabIndex = 21
        Me.Label38.Text = "(Valor Esperado: Mayor a 85,00% )"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(215, 49)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(222, 15)
        Me.Label35.TabIndex = 18
        Me.Label35.Text = "(Valor Esperado: Mayor a 0,5% )"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(215, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(222, 15)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "(Valor Esperado: Mayor a 0,5% )"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(132, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 15)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "0,00"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 15)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "% De Calidad:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(153, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "0,00"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 15)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "% De Comercialidad:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(153, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "0,00"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "% De contribución:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cb_meses)
        Me.Panel1.Location = New System.Drawing.Point(739, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 43)
        Me.Panel1.TabIndex = 10007
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 14)
        Me.Label13.TabIndex = 10006
        Me.Label13.Text = "Meses:"
        '
        'cb_meses
        '
        Me.cb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_meses.FormattingEnabled = True
        Me.cb_meses.Items.AddRange(New Object() {"3", "6", "9", "12"})
        Me.cb_meses.Location = New System.Drawing.Point(59, 10)
        Me.cb_meses.Name = "cb_meses"
        Me.cb_meses.Size = New System.Drawing.Size(52, 22)
        Me.cb_meses.TabIndex = 10005
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Items.AddRange(New Object() {"Código Interno", "Descrpción", "Código Fábrica", "Modelo"})
        Me.DomainUpDown1.Location = New System.Drawing.Point(9, 16)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(126, 22)
        Me.DomainUpDown1.TabIndex = 10003
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(141, 16)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(155, 23)
        Me.tb_buscarcodigo.TabIndex = 10002
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeColumns = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.CodigoFabricaDataGridViewTextBoxColumn})
        Me.DGV_Productos.DataSource = Me.SpconsultaProductosEvaluacionDSSBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Productos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Productos.Location = New System.Drawing.Point(9, 44)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        Me.DGV_Productos.RowHeadersVisible = False
        Me.DGV_Productos.RowTemplate.Height = 26
        Me.DGV_Productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(406, 622)
        Me.DGV_Productos.TabIndex = 10
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Código I."
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 80
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 170
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 95
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "Exist."
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Width = 40
        '
        'CodigoFabricaDataGridViewTextBoxColumn
        '
        Me.CodigoFabricaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.HeaderText = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.Name = "CodigoFabricaDataGridViewTextBoxColumn"
        Me.CodigoFabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFabricaDataGridViewTextBoxColumn.Visible = False
        '
        'SpconsultaProductosEvaluacionDSSBindingSource
        '
        Me.SpconsultaProductosEvaluacionDSSBindingSource.DataMember = "sp_consultaProductosEvaluacionDSS"
        Me.SpconsultaProductosEvaluacionDSSBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserControl61
        '
        Me.UserControl61.Location = New System.Drawing.Point(428, 275)
        Me.UserControl61.Name = "UserControl61"
        Me.UserControl61.Size = New System.Drawing.Size(567, 398)
        Me.UserControl61.TabIndex = 10008
        '
        'Sp_consultaProductosEvaluacionDSSTableAdapter
        '
        Me.Sp_consultaProductosEvaluacionDSSTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.tb_porDebajo)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(96, 630)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 27)
        Me.Panel3.TabIndex = 172
        '
        'Frm_EvaluacionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 704)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_EvaluacionProductos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductosEvaluacionDSSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserControl51 As Tesis_Nueva.UserControl5
    Friend WithEvents UserControl41 As Tesis_Nueva.UserControl4
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents tb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents bt_evaluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_porDebajo As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_meses As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UserControl61 As Tesis_Nueva.UserControl6
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cb_alfa As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaProductosEvaluacionDSSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosEvaluacionDSSTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosEvaluacionDSSTableAdapter
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
