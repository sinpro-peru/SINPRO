<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CatalogoMarcaModelo
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CatalogoMarcaModelo))
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gb_Parametros = New System.Windows.Forms.GroupBox
        Me.L_personalizado = New System.Windows.Forms.RadioButton
        Me.L_modelocant = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.F_ubic = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cb_cuarto = New System.Windows.Forms.ComboBox
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.TableAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cb_grupo2 = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtpick2 = New System.Windows.Forms.DateTimePicker
        Me.R_compras = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.R_horizontal = New System.Windows.Forms.RadioButton
        Me.R_Vertical = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_ubic = New System.Windows.Forms.RadioButton
        Me.rb_Marca = New System.Windows.Forms.RadioButton
        Me.rb_Descripcion = New System.Windows.Forms.RadioButton
        Me.rb_CodInt = New System.Windows.Forms.RadioButton
        Me.rb_CodFab = New System.Windows.Forms.RadioButton
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.chk_CodProFa = New System.Windows.Forms.CheckBox
        Me.chk_empaque = New System.Windows.Forms.CheckBox
        Me.chk_Modelo = New System.Windows.Forms.CheckBox
        Me.chk_MarcaProducto = New System.Windows.Forms.CheckBox
        Me.chk_CodInt = New System.Windows.Forms.CheckBox
        Me.chk_Precio = New System.Windows.Forms.CheckBox
        Me.chk_Ubicacion = New System.Windows.Forms.CheckBox
        Me.chk_Descripcion = New System.Windows.Forms.CheckBox
        Me.chk_Existencia = New System.Windows.Forms.CheckBox
        Me.chk_Marca = New System.Windows.Forms.CheckBox
        Me.L_alfabetico = New System.Windows.Forms.RadioButton
        Me.Button5 = New System.Windows.Forms.Button
        Me.L_modelo = New System.Windows.Forms.RadioButton
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.lst_Modelo = New System.Windows.Forms.ListBox
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgv_c2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtpick = New System.Windows.Forms.DateTimePicker
        Me.bt_del = New System.Windows.Forms.Button
        Me.bt_add = New System.Windows.Forms.Button
        Me.dgv_c1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cb_grupo = New System.Windows.Forms.ComboBox
        Me.rb_compra = New System.Windows.Forms.RadioButton
        Me.rb_grupo = New System.Windows.Forms.RadioButton
        Me.rb_brand = New System.Windows.Forms.RadioButton
        Me.lst_Consultar = New System.Windows.Forms.DataGridView
        Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_quitar = New System.Windows.Forms.Button
        Me.cb_Marcas = New System.Windows.Forms.ComboBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgvinv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaMarcaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
        Me.Cbac_Marcas = New Tesis_Nueva.ComboBoxAutoComplete
        Me.Table_AlmacenTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
        Me.chk_obs = New System.Windows.Forms.CheckBox
        Me.tb_obs = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.chk_leyenda = New System.Windows.Forms.CheckBox
        Me.tb_leyenda = New System.Windows.Forms.TextBox
        Me.gb_Parametros.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lst_Consultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Parametros
        '
        Me.gb_Parametros.BackColor = System.Drawing.Color.White
        Me.gb_Parametros.Controls.Add(Me.L_personalizado)
        Me.gb_Parametros.Controls.Add(Me.L_modelocant)
        Me.gb_Parametros.Controls.Add(Me.GroupBox2)
        Me.gb_Parametros.Controls.Add(Me.L_alfabetico)
        Me.gb_Parametros.Controls.Add(Me.Button5)
        Me.gb_Parametros.Controls.Add(Me.L_modelo)
        Me.gb_Parametros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_Parametros.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Parametros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gb_Parametros.Location = New System.Drawing.Point(424, 3)
        Me.gb_Parametros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Parametros.Name = "gb_Parametros"
        Me.gb_Parametros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Parametros.Size = New System.Drawing.Size(381, 628)
        Me.gb_Parametros.TabIndex = 121
        Me.gb_Parametros.TabStop = False
        Me.gb_Parametros.Text = "Modo de Impresión"
        '
        'L_personalizado
        '
        Me.L_personalizado.AutoSize = True
        Me.L_personalizado.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_personalizado.ForeColor = System.Drawing.Color.Black
        Me.L_personalizado.Location = New System.Drawing.Point(12, 82)
        Me.L_personalizado.Name = "L_personalizado"
        Me.L_personalizado.Size = New System.Drawing.Size(98, 18)
        Me.L_personalizado.TabIndex = 3
        Me.L_personalizado.TabStop = True
        Me.L_personalizado.Text = "Personalizado"
        Me.L_personalizado.UseVisualStyleBackColor = True
        '
        'L_modelocant
        '
        Me.L_modelocant.AutoSize = True
        Me.L_modelocant.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_modelocant.ForeColor = System.Drawing.Color.Black
        Me.L_modelocant.Location = New System.Drawing.Point(12, 40)
        Me.L_modelocant.Name = "L_modelocant"
        Me.L_modelocant.Size = New System.Drawing.Size(157, 18)
        Me.L_modelocant.TabIndex = 122
        Me.L_modelocant.TabStop = True
        Me.L_modelocant.Text = "Listado Modelo Cantidad"
        Me.L_modelocant.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F_ubic)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.chk_Todos)
        Me.GroupBox2.Controls.Add(Me.chk_CodProFa)
        Me.GroupBox2.Controls.Add(Me.chk_empaque)
        Me.GroupBox2.Controls.Add(Me.chk_Modelo)
        Me.GroupBox2.Controls.Add(Me.chk_MarcaProducto)
        Me.GroupBox2.Controls.Add(Me.chk_CodInt)
        Me.GroupBox2.Controls.Add(Me.chk_Precio)
        Me.GroupBox2.Controls.Add(Me.chk_Ubicacion)
        Me.GroupBox2.Controls.Add(Me.chk_Descripcion)
        Me.GroupBox2.Controls.Add(Me.chk_Existencia)
        Me.GroupBox2.Controls.Add(Me.chk_Marca)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(31, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 534)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'F_ubic
        '
        Me.F_ubic.AutoSize = True
        Me.F_ubic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.F_ubic.Location = New System.Drawing.Point(19, 400)
        Me.F_ubic.Name = "F_ubic"
        Me.F_ubic.Size = New System.Drawing.Size(155, 18)
        Me.F_ubic.TabIndex = 31
        Me.F_ubic.Text = "Filtrar por Ubicación"
        Me.F_ubic.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cb_cuarto)
        Me.GroupBox6.Controls.Add(Me.cb_tramo)
        Me.GroupBox6.Controls.Add(Me.cb_almacen)
        Me.GroupBox6.Controls.Add(Me.cb_estante)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(316, 127)
        Me.GroupBox6.TabIndex = 131
        Me.GroupBox6.TabStop = False
        '
        'cb_cuarto
        '
        Me.cb_cuarto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cuarto.FormattingEnabled = True
        Me.cb_cuarto.Location = New System.Drawing.Point(182, 48)
        Me.cb_cuarto.Name = "cb_cuarto"
        Me.cb_cuarto.Size = New System.Drawing.Size(121, 23)
        Me.cb_cuarto.TabIndex = 28
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(182, 98)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(121, 23)
        Me.cb_tramo.TabIndex = 30
        '
        'cb_almacen
        '
        Me.cb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen.DataSource = Me.TableAlmacenBindingSource
        Me.cb_almacen.DisplayMember = "Nombre"
        Me.cb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen.FormattingEnabled = True
        Me.cb_almacen.Location = New System.Drawing.Point(182, 23)
        Me.cb_almacen.Name = "cb_almacen"
        Me.cb_almacen.Size = New System.Drawing.Size(121, 23)
        Me.cb_almacen.TabIndex = 27
        Me.cb_almacen.ValueMember = "Id"
        '
        'TableAlmacenBindingSource
        '
        Me.TableAlmacenBindingSource.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_estante
        '
        Me.cb_estante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_estante.FormattingEnabled = True
        Me.cb_estante.Location = New System.Drawing.Point(182, 73)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(121, 23)
        Me.cb_estante.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tramo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cuarto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Estante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Almacén:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_grupo2)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.dtpick2)
        Me.GroupBox4.Controls.Add(Me.R_compras)
        Me.GroupBox4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(316, 83)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parámetros de Resaltado"
        '
        'cb_grupo2
        '
        Me.cb_grupo2.Enabled = False
        Me.cb_grupo2.FormattingEnabled = True
        Me.cb_grupo2.Location = New System.Drawing.Point(188, 46)
        Me.cb_grupo2.Name = "cb_grupo2"
        Me.cb_grupo2.Size = New System.Drawing.Size(115, 22)
        Me.cb_grupo2.TabIndex = 135
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(15, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(117, 18)
        Me.CheckBox1.TabIndex = 134
        Me.CheckBox1.Text = "Resaltar el grupo:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtpick2
        '
        Me.dtpick2.CalendarFont = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick2.Location = New System.Drawing.Point(188, 21)
        Me.dtpick2.Name = "dtpick2"
        Me.dtpick2.Size = New System.Drawing.Size(115, 21)
        Me.dtpick2.TabIndex = 133
        '
        'R_compras
        '
        Me.R_compras.AutoSize = True
        Me.R_compras.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_compras.ForeColor = System.Drawing.Color.Black
        Me.R_compras.Location = New System.Drawing.Point(15, 24)
        Me.R_compras.Name = "R_compras"
        Me.R_compras.Size = New System.Drawing.Size(169, 18)
        Me.R_compras.TabIndex = 0
        Me.R_compras.Text = "Resaltar las compras desde:"
        Me.R_compras.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.R_horizontal)
        Me.GroupBox5.Controls.Add(Me.R_Vertical)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(316, 44)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Presentación"
        '
        'R_horizontal
        '
        Me.R_horizontal.AutoSize = True
        Me.R_horizontal.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_horizontal.ForeColor = System.Drawing.Color.Black
        Me.R_horizontal.Location = New System.Drawing.Point(186, 19)
        Me.R_horizontal.Name = "R_horizontal"
        Me.R_horizontal.Size = New System.Drawing.Size(80, 18)
        Me.R_horizontal.TabIndex = 1
        Me.R_horizontal.TabStop = True
        Me.R_horizontal.Text = "Horizontal"
        Me.R_horizontal.UseVisualStyleBackColor = True
        '
        'R_Vertical
        '
        Me.R_Vertical.AutoSize = True
        Me.R_Vertical.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_Vertical.ForeColor = System.Drawing.Color.Black
        Me.R_Vertical.Location = New System.Drawing.Point(15, 19)
        Me.R_Vertical.Name = "R_Vertical"
        Me.R_Vertical.Size = New System.Drawing.Size(65, 18)
        Me.R_Vertical.TabIndex = 0
        Me.R_Vertical.TabStop = True
        Me.R_Vertical.Text = "Vertical"
        Me.R_Vertical.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_ubic)
        Me.GroupBox3.Controls.Add(Me.rb_Marca)
        Me.GroupBox3.Controls.Add(Me.rb_Descripcion)
        Me.GroupBox3.Controls.Add(Me.rb_CodInt)
        Me.GroupBox3.Controls.Add(Me.rb_CodFab)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(316, 89)
        Me.GroupBox3.TabIndex = 128
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenar por:"
        '
        'rb_ubic
        '
        Me.rb_ubic.AutoSize = True
        Me.rb_ubic.Enabled = False
        Me.rb_ubic.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ubic.ForeColor = System.Drawing.Color.Black
        Me.rb_ubic.Location = New System.Drawing.Point(15, 67)
        Me.rb_ubic.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_ubic.Name = "rb_ubic"
        Me.rb_ubic.Size = New System.Drawing.Size(79, 18)
        Me.rb_ubic.TabIndex = 1
        Me.rb_ubic.Text = "Ubicación"
        Me.rb_ubic.UseVisualStyleBackColor = True
        '
        'rb_Marca
        '
        Me.rb_Marca.AutoSize = True
        Me.rb_Marca.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Marca.ForeColor = System.Drawing.Color.Black
        Me.rb_Marca.Location = New System.Drawing.Point(186, 44)
        Me.rb_Marca.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_Marca.Name = "rb_Marca"
        Me.rb_Marca.Size = New System.Drawing.Size(57, 18)
        Me.rb_Marca.TabIndex = 0
        Me.rb_Marca.Text = "Marca"
        Me.rb_Marca.UseVisualStyleBackColor = True
        '
        'rb_Descripcion
        '
        Me.rb_Descripcion.AutoSize = True
        Me.rb_Descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Descripcion.ForeColor = System.Drawing.Color.Black
        Me.rb_Descripcion.Location = New System.Drawing.Point(186, 20)
        Me.rb_Descripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_Descripcion.Name = "rb_Descripcion"
        Me.rb_Descripcion.Size = New System.Drawing.Size(88, 18)
        Me.rb_Descripcion.TabIndex = 0
        Me.rb_Descripcion.Text = "Descripción"
        Me.rb_Descripcion.UseVisualStyleBackColor = True
        '
        'rb_CodInt
        '
        Me.rb_CodInt.AutoSize = True
        Me.rb_CodInt.Checked = True
        Me.rb_CodInt.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_CodInt.ForeColor = System.Drawing.Color.Black
        Me.rb_CodInt.Location = New System.Drawing.Point(15, 20)
        Me.rb_CodInt.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_CodInt.Name = "rb_CodInt"
        Me.rb_CodInt.Size = New System.Drawing.Size(73, 18)
        Me.rb_CodInt.TabIndex = 0
        Me.rb_CodInt.TabStop = True
        Me.rb_CodInt.Text = "Cod . Int."
        Me.rb_CodInt.UseVisualStyleBackColor = True
        '
        'rb_CodFab
        '
        Me.rb_CodFab.AutoSize = True
        Me.rb_CodFab.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_CodFab.ForeColor = System.Drawing.Color.Black
        Me.rb_CodFab.Location = New System.Drawing.Point(15, 44)
        Me.rb_CodFab.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_CodFab.Name = "rb_CodFab"
        Me.rb_CodFab.Size = New System.Drawing.Size(75, 18)
        Me.rb_CodFab.TabIndex = 0
        Me.rb_CodFab.Text = "Cod. Fab."
        Me.rb_CodFab.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Todos.ForeColor = System.Drawing.Color.Black
        Me.chk_Todos.Location = New System.Drawing.Point(27, 30)
        Me.chk_Todos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(62, 19)
        Me.chk_Todos.TabIndex = 123
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'chk_CodProFa
        '
        Me.chk_CodProFa.AutoSize = True
        Me.chk_CodProFa.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_CodProFa.ForeColor = System.Drawing.Color.Black
        Me.chk_CodProFa.Location = New System.Drawing.Point(27, 51)
        Me.chk_CodProFa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_CodProFa.Name = "chk_CodProFa"
        Me.chk_CodProFa.Size = New System.Drawing.Size(106, 18)
        Me.chk_CodProFa.TabIndex = 122
        Me.chk_CodProFa.Text = "Código Fábrica"
        Me.chk_CodProFa.UseVisualStyleBackColor = True
        '
        'chk_empaque
        '
        Me.chk_empaque.AutoSize = True
        Me.chk_empaque.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_empaque.ForeColor = System.Drawing.Color.Black
        Me.chk_empaque.Location = New System.Drawing.Point(200, 138)
        Me.chk_empaque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_empaque.Name = "chk_empaque"
        Me.chk_empaque.Size = New System.Drawing.Size(76, 18)
        Me.chk_empaque.TabIndex = 124
        Me.chk_empaque.Text = "Empaque"
        Me.chk_empaque.UseVisualStyleBackColor = True
        '
        'chk_Modelo
        '
        Me.chk_Modelo.AutoSize = True
        Me.chk_Modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Modelo.ForeColor = System.Drawing.Color.Black
        Me.chk_Modelo.Location = New System.Drawing.Point(27, 137)
        Me.chk_Modelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Modelo.Name = "chk_Modelo"
        Me.chk_Modelo.Size = New System.Drawing.Size(66, 18)
        Me.chk_Modelo.TabIndex = 122
        Me.chk_Modelo.Text = "Modelo"
        Me.chk_Modelo.UseVisualStyleBackColor = True
        '
        'chk_MarcaProducto
        '
        Me.chk_MarcaProducto.AutoSize = True
        Me.chk_MarcaProducto.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_MarcaProducto.ForeColor = System.Drawing.Color.Black
        Me.chk_MarcaProducto.Location = New System.Drawing.Point(200, 51)
        Me.chk_MarcaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_MarcaProducto.Name = "chk_MarcaProducto"
        Me.chk_MarcaProducto.Size = New System.Drawing.Size(110, 18)
        Me.chk_MarcaProducto.TabIndex = 123
        Me.chk_MarcaProducto.Text = "Marca Producto"
        Me.chk_MarcaProducto.UseVisualStyleBackColor = True
        '
        'chk_CodInt
        '
        Me.chk_CodInt.AutoSize = True
        Me.chk_CodInt.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_CodInt.ForeColor = System.Drawing.Color.Black
        Me.chk_CodInt.Location = New System.Drawing.Point(27, 74)
        Me.chk_CodInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_CodInt.Name = "chk_CodInt"
        Me.chk_CodInt.Size = New System.Drawing.Size(106, 18)
        Me.chk_CodInt.TabIndex = 122
        Me.chk_CodInt.Text = "Código Interno"
        Me.chk_CodInt.UseVisualStyleBackColor = True
        '
        'chk_Precio
        '
        Me.chk_Precio.AutoSize = True
        Me.chk_Precio.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Precio.ForeColor = System.Drawing.Color.Black
        Me.chk_Precio.Location = New System.Drawing.Point(200, 73)
        Me.chk_Precio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Precio.Name = "chk_Precio"
        Me.chk_Precio.Size = New System.Drawing.Size(59, 18)
        Me.chk_Precio.TabIndex = 122
        Me.chk_Precio.Text = "Precio"
        Me.chk_Precio.UseVisualStyleBackColor = True
        '
        'chk_Ubicacion
        '
        Me.chk_Ubicacion.AutoSize = True
        Me.chk_Ubicacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Ubicacion.ForeColor = System.Drawing.Color.Black
        Me.chk_Ubicacion.Location = New System.Drawing.Point(200, 117)
        Me.chk_Ubicacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Ubicacion.Name = "chk_Ubicacion"
        Me.chk_Ubicacion.Size = New System.Drawing.Size(80, 18)
        Me.chk_Ubicacion.TabIndex = 122
        Me.chk_Ubicacion.Text = "Ubicación"
        Me.chk_Ubicacion.UseVisualStyleBackColor = True
        '
        'chk_Descripcion
        '
        Me.chk_Descripcion.AutoSize = True
        Me.chk_Descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Descripcion.ForeColor = System.Drawing.Color.Black
        Me.chk_Descripcion.Location = New System.Drawing.Point(27, 96)
        Me.chk_Descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Descripcion.Name = "chk_Descripcion"
        Me.chk_Descripcion.Size = New System.Drawing.Size(89, 18)
        Me.chk_Descripcion.TabIndex = 122
        Me.chk_Descripcion.Text = "Descripción"
        Me.chk_Descripcion.UseVisualStyleBackColor = True
        '
        'chk_Existencia
        '
        Me.chk_Existencia.AutoSize = True
        Me.chk_Existencia.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Existencia.ForeColor = System.Drawing.Color.Black
        Me.chk_Existencia.Location = New System.Drawing.Point(200, 95)
        Me.chk_Existencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Existencia.Name = "chk_Existencia"
        Me.chk_Existencia.Size = New System.Drawing.Size(110, 18)
        Me.chk_Existencia.TabIndex = 122
        Me.chk_Existencia.Text = "Cant. Existencia"
        Me.chk_Existencia.UseVisualStyleBackColor = True
        '
        'chk_Marca
        '
        Me.chk_Marca.AutoSize = True
        Me.chk_Marca.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Marca.ForeColor = System.Drawing.Color.Black
        Me.chk_Marca.Location = New System.Drawing.Point(27, 117)
        Me.chk_Marca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_Marca.Name = "chk_Marca"
        Me.chk_Marca.Size = New System.Drawing.Size(108, 18)
        Me.chk_Marca.TabIndex = 122
        Me.chk_Marca.Text = "Marca Vehículo"
        Me.chk_Marca.UseVisualStyleBackColor = True
        '
        'L_alfabetico
        '
        Me.L_alfabetico.AutoSize = True
        Me.L_alfabetico.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_alfabetico.ForeColor = System.Drawing.Color.Black
        Me.L_alfabetico.Location = New System.Drawing.Point(12, 61)
        Me.L_alfabetico.Name = "L_alfabetico"
        Me.L_alfabetico.Size = New System.Drawing.Size(120, 18)
        Me.L_alfabetico.TabIndex = 2
        Me.L_alfabetico.TabStop = True
        Me.L_alfabetico.Text = "Listado Alfabético"
        Me.L_alfabetico.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button5.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(612, 30)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 121
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.Visible = False
        '
        'L_modelo
        '
        Me.L_modelo.AutoSize = True
        Me.L_modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_modelo.ForeColor = System.Drawing.Color.Black
        Me.L_modelo.Location = New System.Drawing.Point(12, 20)
        Me.L_modelo.Name = "L_modelo"
        Me.L_modelo.Size = New System.Drawing.Size(106, 18)
        Me.L_modelo.TabIndex = 0
        Me.L_modelo.TabStop = True
        Me.L_modelo.Text = "Listado Modelo"
        Me.L_modelo.UseVisualStyleBackColor = True
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_exist.ForeColor = System.Drawing.Color.Black
        Me.chk_exist.Location = New System.Drawing.Point(14, 21)
        Me.chk_exist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(98, 18)
        Me.chk_exist.TabIndex = 122
        Me.chk_exist.Text = "Existencia > 0"
        Me.chk_exist.UseVisualStyleBackColor = True
        '
        'lst_Modelo
        '
        Me.lst_Modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Modelo.FormattingEnabled = True
        Me.lst_Modelo.ItemHeight = 14
        Me.lst_Modelo.Location = New System.Drawing.Point(9, 67)
        Me.lst_Modelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Modelo.Name = "lst_Modelo"
        Me.lst_Modelo.Size = New System.Drawing.Size(167, 130)
        Me.lst_Modelo.TabIndex = 122
        '
        'bt_agregar
        '
        Me.bt_agregar.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar.ForeColor = System.Drawing.Color.Black
        Me.bt_agregar.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregar.Location = New System.Drawing.Point(185, 103)
        Me.bt_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(29, 35)
        Me.bt_agregar.TabIndex = 121
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_c2)
        Me.GroupBox1.Controls.Add(Me.dtpick)
        Me.GroupBox1.Controls.Add(Me.bt_del)
        Me.GroupBox1.Controls.Add(Me.bt_add)
        Me.GroupBox1.Controls.Add(Me.dgv_c1)
        Me.GroupBox1.Controls.Add(Me.cb_grupo)
        Me.GroupBox1.Controls.Add(Me.rb_compra)
        Me.GroupBox1.Controls.Add(Me.rb_grupo)
        Me.GroupBox1.Controls.Add(Me.rb_brand)
        Me.GroupBox1.Controls.Add(Me.lst_Consultar)
        Me.GroupBox1.Controls.Add(Me.bt_quitar)
        Me.GroupBox1.Controls.Add(Me.bt_agregar)
        Me.GroupBox1.Controls.Add(Me.lst_Modelo)
        Me.GroupBox1.Controls.Add(Me.cb_Marcas)
        Me.GroupBox1.Controls.Add(Me.chk_exist)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(399, 400)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'dgv_c2
        '
        Me.dgv_c2.AllowUserToAddRows = False
        Me.dgv_c2.AllowUserToDeleteRows = False
        Me.dgv_c2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_c2.ColumnHeadersVisible = False
        Me.dgv_c2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgv_c2.Location = New System.Drawing.Point(223, 270)
        Me.dgv_c2.Name = "dgv_c2"
        Me.dgv_c2.ReadOnly = True
        Me.dgv_c2.RowHeadersVisible = False
        Me.dgv_c2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_c2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_c2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_c2.Size = New System.Drawing.Size(166, 112)
        Me.dgv_c2.TabIndex = 133
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle37.Format = "d"
        DataGridViewCellStyle37.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridViewTextBoxColumn4.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'dtpick
        '
        Me.dtpick.CalendarFont = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick.Location = New System.Drawing.Point(223, 246)
        Me.dtpick.Name = "dtpick"
        Me.dtpick.Size = New System.Drawing.Size(151, 21)
        Me.dtpick.TabIndex = 132
        '
        'bt_del
        '
        Me.bt_del.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_del.ForeColor = System.Drawing.Color.Black
        Me.bt_del.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_del.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_del.Location = New System.Drawing.Point(185, 331)
        Me.bt_del.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(29, 34)
        Me.bt_del.TabIndex = 131
        '
        'bt_add
        '
        Me.bt_add.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.ForeColor = System.Drawing.Color.Black
        Me.bt_add.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_add.Location = New System.Drawing.Point(185, 290)
        Me.bt_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(29, 35)
        Me.bt_add.TabIndex = 130
        '
        'dgv_c1
        '
        Me.dgv_c1.AllowUserToAddRows = False
        Me.dgv_c1.AllowUserToDeleteRows = False
        Me.dgv_c1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_c1.ColumnHeadersVisible = False
        Me.dgv_c1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1})
        Me.dgv_c1.Location = New System.Drawing.Point(10, 269)
        Me.dgv_c1.Name = "dgv_c1"
        Me.dgv_c1.ReadOnly = True
        Me.dgv_c1.RowHeadersVisible = False
        Me.dgv_c1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_c1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_c1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_c1.Size = New System.Drawing.Size(166, 112)
        Me.dgv_c1.TabIndex = 128
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle38.Format = "d"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'cb_grupo
        '
        Me.cb_grupo.FormattingEnabled = True
        Me.cb_grupo.Location = New System.Drawing.Point(223, 218)
        Me.cb_grupo.Name = "cb_grupo"
        Me.cb_grupo.Size = New System.Drawing.Size(151, 22)
        Me.cb_grupo.TabIndex = 127
        '
        'rb_compra
        '
        Me.rb_compra.AutoSize = True
        Me.rb_compra.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_compra.ForeColor = System.Drawing.Color.Black
        Me.rb_compra.Location = New System.Drawing.Point(14, 245)
        Me.rb_compra.Name = "rb_compra"
        Me.rb_compra.Size = New System.Drawing.Size(109, 18)
        Me.rb_compra.TabIndex = 126
        Me.rb_compra.TabStop = True
        Me.rb_compra.Text = "Compras desde:"
        Me.rb_compra.UseVisualStyleBackColor = True
        '
        'rb_grupo
        '
        Me.rb_grupo.AutoSize = True
        Me.rb_grupo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_grupo.ForeColor = System.Drawing.Color.Black
        Me.rb_grupo.Location = New System.Drawing.Point(14, 218)
        Me.rb_grupo.Name = "rb_grupo"
        Me.rb_grupo.Size = New System.Drawing.Size(62, 18)
        Me.rb_grupo.TabIndex = 125
        Me.rb_grupo.TabStop = True
        Me.rb_grupo.Text = "Grupo:"
        Me.rb_grupo.UseVisualStyleBackColor = True
        '
        'rb_brand
        '
        Me.rb_brand.AutoSize = True
        Me.rb_brand.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_brand.ForeColor = System.Drawing.Color.Black
        Me.rb_brand.Location = New System.Drawing.Point(14, 44)
        Me.rb_brand.Name = "rb_brand"
        Me.rb_brand.Size = New System.Drawing.Size(57, 18)
        Me.rb_brand.TabIndex = 124
        Me.rb_brand.TabStop = True
        Me.rb_brand.Text = "Marca"
        Me.rb_brand.UseVisualStyleBackColor = True
        '
        'lst_Consultar
        '
        Me.lst_Consultar.AllowUserToAddRows = False
        Me.lst_Consultar.AllowUserToDeleteRows = False
        Me.lst_Consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lst_Consultar.ColumnHeadersVisible = False
        Me.lst_Consultar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M, Me.t})
        Me.lst_Consultar.Location = New System.Drawing.Point(223, 67)
        Me.lst_Consultar.Name = "lst_Consultar"
        Me.lst_Consultar.ReadOnly = True
        Me.lst_Consultar.RowHeadersVisible = False
        Me.lst_Consultar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.lst_Consultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lst_Consultar.Size = New System.Drawing.Size(166, 130)
        Me.lst_Consultar.TabIndex = 123
        '
        'M
        '
        Me.M.HeaderText = "Column1"
        Me.M.Name = "M"
        Me.M.ReadOnly = True
        '
        't
        '
        Me.t.HeaderText = "Column1"
        Me.t.Name = "t"
        Me.t.ReadOnly = True
        Me.t.Visible = False
        '
        'bt_quitar
        '
        Me.bt_quitar.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_quitar.ForeColor = System.Drawing.Color.Black
        Me.bt_quitar.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_quitar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_quitar.Location = New System.Drawing.Point(185, 142)
        Me.bt_quitar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(29, 34)
        Me.bt_quitar.TabIndex = 121
        '
        'cb_Marcas
        '
        Me.cb_Marcas.FormattingEnabled = True
        Me.cb_Marcas.Location = New System.Drawing.Point(222, 40)
        Me.cb_Marcas.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Marcas.Name = "cb_Marcas"
        Me.cb_Marcas.Size = New System.Drawing.Size(152, 22)
        Me.cb_Marcas.TabIndex = 99
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(11, 5)
        Me.ToolBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(122, 61)
        Me.ToolBar1.TabIndex = 129
        '
        'bt_imprimir
        '
        Me.bt_imprimir.ImageIndex = 6
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Text = "Imprimir"
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
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "Printer.png")
        '
        'dgvinv
        '
        Me.dgvinv.AllowUserToAddRows = False
        Me.dgvinv.AllowUserToDeleteRows = False
        Me.dgvinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinv.ColumnHeadersVisible = False
        Me.dgvinv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvinv.Location = New System.Drawing.Point(252, 3)
        Me.dgvinv.Name = "dgvinv"
        Me.dgvinv.ReadOnly = True
        Me.dgvinv.RowHeadersVisible = False
        Me.dgvinv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvinv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvinv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinv.Size = New System.Drawing.Size(166, 56)
        Me.dgvinv.TabIndex = 134
        Me.dgvinv.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle39.Format = "d"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewTextBoxColumn7.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'SpconsultaMarcaBindingSource
        '
        Me.SpconsultaMarcaBindingSource.DataMember = "sp_consultaMarca"
        Me.SpconsultaMarcaBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaMarcaTableAdapter
        '
        Me.Sp_consultaMarcaTableAdapter.ClearBeforeFill = True
        '
        'Cbac_Marcas
        '
        Me.Cbac_Marcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Marcas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Marcas.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Marcas.FormattingEnabled = True
        Me.Cbac_Marcas.Location = New System.Drawing.Point(76, 32)
        Me.Cbac_Marcas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cbac_Marcas.Name = "Cbac_Marcas"
        Me.Cbac_Marcas.Size = New System.Drawing.Size(172, 27)
        Me.Cbac_Marcas.TabIndex = 115
        '
        'Table_AlmacenTableAdapter
        '
        Me.Table_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'chk_obs
        '
        Me.chk_obs.AutoSize = True
        Me.chk_obs.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_obs.ForeColor = System.Drawing.Color.Black
        Me.chk_obs.Location = New System.Drawing.Point(9, 18)
        Me.chk_obs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_obs.Name = "chk_obs"
        Me.chk_obs.Size = New System.Drawing.Size(138, 19)
        Me.chk_obs.TabIndex = 135
        Me.chk_obs.Text = "Incluir Observación"
        Me.chk_obs.UseVisualStyleBackColor = True
        '
        'tb_obs
        '
        Me.tb_obs.Enabled = False
        Me.tb_obs.Location = New System.Drawing.Point(7, 38)
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.Size = New System.Drawing.Size(386, 40)
        Me.tb_obs.TabIndex = 136
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chk_leyenda)
        Me.GroupBox7.Controls.Add(Me.tb_leyenda)
        Me.GroupBox7.Controls.Add(Me.chk_obs)
        Me.GroupBox7.Controls.Add(Me.tb_obs)
        Me.GroupBox7.Location = New System.Drawing.Point(11, 478)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(399, 153)
        Me.GroupBox7.TabIndex = 137
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Comentarios"
        '
        'chk_leyenda
        '
        Me.chk_leyenda.AutoSize = True
        Me.chk_leyenda.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_leyenda.ForeColor = System.Drawing.Color.Black
        Me.chk_leyenda.Location = New System.Drawing.Point(9, 83)
        Me.chk_leyenda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_leyenda.Name = "chk_leyenda"
        Me.chk_leyenda.Size = New System.Drawing.Size(114, 19)
        Me.chk_leyenda.TabIndex = 137
        Me.chk_leyenda.Text = "Incluir Leyenda"
        Me.chk_leyenda.UseVisualStyleBackColor = True
        '
        'tb_leyenda
        '
        Me.tb_leyenda.Enabled = False
        Me.tb_leyenda.Location = New System.Drawing.Point(7, 103)
        Me.tb_leyenda.Multiline = True
        Me.tb_leyenda.Name = "tb_leyenda"
        Me.tb_leyenda.Size = New System.Drawing.Size(386, 43)
        Me.tb_leyenda.TabIndex = 138
        '
        'Frm_CatalogoMarcaModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 635)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.dgvinv)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_Parametros)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_CatalogoMarcaModelo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo"
        Me.gb_Parametros.ResumeLayout(False)
        Me.gb_Parametros.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lst_Consultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents chk_Descripcion As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CodInt As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CodProFa As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ubicacion As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Existencia As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Marca As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Precio As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Modelo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents lst_Modelo As System.Windows.Forms.ListBox
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbac_Marcas As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents cb_Marcas As System.Windows.Forms.ComboBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaMarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaMarcaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
    Friend WithEvents chk_MarcaProducto As System.Windows.Forms.CheckBox
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Descripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_CodInt As System.Windows.Forms.RadioButton
    Friend WithEvents rb_CodFab As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Marca As System.Windows.Forms.RadioButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents chk_empaque As System.Windows.Forms.CheckBox
    Friend WithEvents L_alfabetico As System.Windows.Forms.RadioButton
    Friend WithEvents L_modelo As System.Windows.Forms.RadioButton
    Friend WithEvents bt_quitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents L_personalizado As System.Windows.Forms.RadioButton
    Friend WithEvents lst_Consultar As System.Windows.Forms.DataGridView
    Friend WithEvents M As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents R_horizontal As System.Windows.Forms.RadioButton
    Friend WithEvents R_Vertical As System.Windows.Forms.RadioButton
    Friend WithEvents rb_grupo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_brand As System.Windows.Forms.RadioButton
    Friend WithEvents L_modelocant As System.Windows.Forms.RadioButton
    Friend WithEvents rb_compra As System.Windows.Forms.RadioButton
    Friend WithEvents cb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents bt_del As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents dgv_c1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpick As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_c2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_compras As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_grupo2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtpick2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvinv As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb_ubic As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_cuarto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents TableAlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_AlmacenTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
    Friend WithEvents F_ubic As System.Windows.Forms.CheckBox
    Friend WithEvents chk_obs As System.Windows.Forms.CheckBox
    Friend WithEvents tb_obs As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_leyenda As System.Windows.Forms.CheckBox
    Friend WithEvents tb_leyenda As System.Windows.Forms.TextBox
End Class
