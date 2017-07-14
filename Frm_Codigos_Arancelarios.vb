Public Class Frm_Codigos_Arancelarios
    Inherits System.Windows.Forms.Form
    'Private Tabla As New DataTable("tablita")
    Private sw0 As Boolean = False
    Private switch As Boolean = False
    Private sw As Boolean = False
    Private sw1 As Boolean = False
    Private l As New Collection
    Private lelim As New Collection
    Private item As Object
    Private codigos As New Collection
    Private cuantos As Integer
    Private fila As Integer
    Private boton As String = ""
    Private choice As Integer
    Private codigo2 As String = ""
    Private escrito As Boolean = False
    Public w As Boolean
    Public e As Boolean
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_ImpuestoP As System.Windows.Forms.TextBox
    Friend WithEvents cb_Preferencias As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Preferencias As System.Windows.Forms.DataGridView
    Friend WithEvents gb_Preferencias As System.Windows.Forms.GroupBox
    Friend WithEvents bt_agregarP As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarP As System.Windows.Forms.Button
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaPreferenciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaPreferenciasTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaPreferenciasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Dgv_CodArancelario As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents rb_ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SpconsultaProductosCodArancelariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosCodArancelariosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosCodArancelariosTableAdapter
    Friend WithEvents CHKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoArancelario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bt_modificarP As System.Windows.Forms.Button
    Friend WithEvents Sp_consultaCodigoArancelarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaCodigoArancelarioTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigoArancelarioTableAdapter
    Friend WithEvents CodigoArancelarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private Dv As DataView

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_impuesto As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Codigos_Arancelarios))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.tb_impuesto = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gb_Preferencias = New System.Windows.Forms.GroupBox
        Me.bt_modificarP = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.bt_agregarP = New System.Windows.Forms.Button
        Me.bt_eliminarP = New System.Windows.Forms.Button
        Me.cb_Preferencias = New System.Windows.Forms.ComboBox
        Me.SpconsultaPreferenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.DGV_Preferencias = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tb_ImpuestoP = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.rb_ninguno = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CHKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoArancelario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaProductosCodArancelariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Sp_consultaPreferenciasTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaPreferenciasTableAdapter
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Dgv_CodArancelario = New System.Windows.Forms.DataGridView
        Me.CodigoArancelarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_consultaCodigoArancelarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Sp_consultaProductosCodArancelariosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosCodArancelariosTableAdapter
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Sp_consultaCodigoArancelarioTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigoArancelarioTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.gb_Preferencias.SuspendLayout()
        CType(Me.SpconsultaPreferenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Preferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductosCodArancelariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_CodArancelario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaCodigoArancelarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 689)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 689)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Total:"
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Divider = False
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(5, 6)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(332, 65)
        Me.ToolBar1.TabIndex = 29
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 3
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        '
        'tb_impuesto
        '
        Me.tb_impuesto.Enabled = False
        Me.tb_impuesto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.tb_impuesto.Location = New System.Drawing.Point(458, 22)
        Me.tb_impuesto.MaxLength = 6
        Me.tb_impuesto.Name = "tb_impuesto"
        Me.tb_impuesto.Size = New System.Drawing.Size(49, 22)
        Me.tb_impuesto.TabIndex = 3
        '
        'tb_codigo
        '
        Me.tb_codigo.Enabled = False
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.tb_codigo.Location = New System.Drawing.Point(119, 23)
        Me.tb_codigo.MaxLength = 15
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(116, 22)
        Me.tb_codigo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(380, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "(*)Impuesto:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(42, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "(*)Código:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(355, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(543, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Datos del Código Arancelario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.tb_impuesto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.gb_Preferencias)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 202)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(372, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(152, 23)
        Me.Label22.TabIndex = 47
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label22.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(505, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 23)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "%"
        '
        'gb_Preferencias
        '
        Me.gb_Preferencias.Controls.Add(Me.bt_modificarP)
        Me.gb_Preferencias.Controls.Add(Me.Label11)
        Me.gb_Preferencias.Controls.Add(Me.bt_agregarP)
        Me.gb_Preferencias.Controls.Add(Me.bt_eliminarP)
        Me.gb_Preferencias.Controls.Add(Me.cb_Preferencias)
        Me.gb_Preferencias.Controls.Add(Me.DGV_Preferencias)
        Me.gb_Preferencias.Controls.Add(Me.tb_ImpuestoP)
        Me.gb_Preferencias.Controls.Add(Me.Label8)
        Me.gb_Preferencias.Controls.Add(Me.Label9)
        Me.gb_Preferencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_Preferencias.Location = New System.Drawing.Point(16, 47)
        Me.gb_Preferencias.Name = "gb_Preferencias"
        Me.gb_Preferencias.Size = New System.Drawing.Size(508, 125)
        Me.gb_Preferencias.TabIndex = 70
        Me.gb_Preferencias.TabStop = False
        Me.gb_Preferencias.Text = "Preferencias"
        '
        'bt_modificarP
        '
        Me.bt_modificarP.Enabled = False
        Me.bt_modificarP.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificarP.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificarP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificarP.Location = New System.Drawing.Point(145, 94)
        Me.bt_modificarP.Name = "bt_modificarP"
        Me.bt_modificarP.Size = New System.Drawing.Size(25, 25)
        Me.bt_modificarP.TabIndex = 10035
        Me.bt_modificarP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(215, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 23)
        Me.Label11.TabIndex = 10034
        Me.Label11.Text = "%"
        '
        'bt_agregarP
        '
        Me.bt_agregarP.Enabled = False
        Me.bt_agregarP.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarP.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarP.Location = New System.Drawing.Point(113, 94)
        Me.bt_agregarP.Name = "bt_agregarP"
        Me.bt_agregarP.Size = New System.Drawing.Size(25, 25)
        Me.bt_agregarP.TabIndex = 10032
        Me.bt_agregarP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarP
        '
        Me.bt_eliminarP.Enabled = False
        Me.bt_eliminarP.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarP.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarP.Location = New System.Drawing.Point(176, 94)
        Me.bt_eliminarP.Name = "bt_eliminarP"
        Me.bt_eliminarP.Size = New System.Drawing.Size(25, 25)
        Me.bt_eliminarP.TabIndex = 10033
        Me.bt_eliminarP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_Preferencias
        '
        Me.cb_Preferencias.DataSource = Me.SpconsultaPreferenciasBindingSource
        Me.cb_Preferencias.DisplayMember = "Nombre"
        Me.cb_Preferencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Preferencias.Enabled = False
        Me.cb_Preferencias.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.cb_Preferencias.FormattingEnabled = True
        Me.cb_Preferencias.Location = New System.Drawing.Point(113, 35)
        Me.cb_Preferencias.Name = "cb_Preferencias"
        Me.cb_Preferencias.Size = New System.Drawing.Size(121, 23)
        Me.cb_Preferencias.TabIndex = 66
        Me.cb_Preferencias.ValueMember = "CodigoPreferencia"
        '
        'SpconsultaPreferenciasBindingSource
        '
        Me.SpconsultaPreferenciasBindingSource.DataMember = "sp_consultaPreferencias"
        Me.SpconsultaPreferenciasBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGV_Preferencias
        '
        Me.DGV_Preferencias.AllowUserToAddRows = False
        Me.DGV_Preferencias.AllowUserToDeleteRows = False
        Me.DGV_Preferencias.AllowUserToOrderColumns = True
        Me.DGV_Preferencias.AllowUserToResizeColumns = False
        Me.DGV_Preferencias.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Preferencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Preferencias.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Preferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Preferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Id})
        Me.DGV_Preferencias.Location = New System.Drawing.Point(291, 15)
        Me.DGV_Preferencias.MultiSelect = False
        Me.DGV_Preferencias.Name = "DGV_Preferencias"
        Me.DGV_Preferencias.RowHeadersVisible = False
        Me.DGV_Preferencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Preferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Preferencias.Size = New System.Drawing.Size(210, 101)
        Me.DGV_Preferencias.TabIndex = 65
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Preferencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'tb_ImpuestoP
        '
        Me.tb_ImpuestoP.Enabled = False
        Me.tb_ImpuestoP.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.tb_ImpuestoP.Location = New System.Drawing.Point(113, 65)
        Me.tb_ImpuestoP.MaxLength = 6
        Me.tb_ImpuestoP.Name = "tb_ImpuestoP"
        Me.tb_ImpuestoP.Size = New System.Drawing.Size(100, 22)
        Me.tb_ImpuestoP.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(28, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 23)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Preferencia:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(28, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 23)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "(*)Impuesto:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "(*)Datos requeridos"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(183, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 22)
        Me.TextBox1.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.rb_ninguno)
        Me.groupbox1.Controls.Add(Me.rb_todos)
        Me.groupbox1.Controls.Add(Me.DataGridView1)
        Me.groupbox1.Location = New System.Drawing.Point(355, 220)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(543, 458)
        Me.groupbox1.TabIndex = 33
        Me.groupbox1.TabStop = False
        '
        'rb_ninguno
        '
        Me.rb_ninguno.AutoSize = True
        Me.rb_ninguno.Location = New System.Drawing.Point(83, 21)
        Me.rb_ninguno.Name = "rb_ninguno"
        Me.rb_ninguno.Size = New System.Drawing.Size(78, 19)
        Me.rb_ninguno.TabIndex = 66
        Me.rb_ninguno.TabStop = True
        Me.rb_ninguno.Text = "Ninguno"
        Me.rb_ninguno.UseVisualStyleBackColor = True
        Me.rb_ninguno.Visible = False
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Location = New System.Drawing.Point(16, 21)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(61, 19)
        Me.rb_todos.TabIndex = 65
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        Me.rb_todos.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHKDataGridViewTextBoxColumn, Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.CodigoArancelario})
        Me.DataGridView1.DataSource = Me.SpconsultaProductosCodArancelariosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 46)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(508, 400)
        Me.DataGridView1.TabIndex = 64
        '
        'CHKDataGridViewTextBoxColumn
        '
        Me.CHKDataGridViewTextBoxColumn.DataPropertyName = "CHK"
        Me.CHKDataGridViewTextBoxColumn.FalseValue = "0"
        Me.CHKDataGridViewTextBoxColumn.HeaderText = ""
        Me.CHKDataGridViewTextBoxColumn.Name = "CHKDataGridViewTextBoxColumn"
        Me.CHKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHKDataGridViewTextBoxColumn.Visible = False
        Me.CHKDataGridViewTextBoxColumn.Width = 25
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo I."
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 120
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 365
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Visible = False
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoArancelario
        '
        Me.CodigoArancelario.DataPropertyName = "CodigoArancelario"
        Me.CodigoArancelario.HeaderText = "CodigoArancelario"
        Me.CodigoArancelario.Name = "CodigoArancelario"
        Me.CodigoArancelario.ReadOnly = True
        Me.CodigoArancelario.Visible = False
        '
        'SpconsultaProductosCodArancelariosBindingSource
        '
        Me.SpconsultaProductosCodArancelariosBindingSource.DataMember = "sp_consultaProductosCodArancelarios"
        Me.SpconsultaProductosCodArancelariosBindingSource.DataSource = Me.MELDataSet
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(355, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(543, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Productos Asociados al Código Arancelario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sp_consultaPreferenciasTableAdapter
        '
        Me.Sp_consultaPreferenciasTableAdapter.ClearBeforeFill = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(661, 687)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 65
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(545, 687)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 64
        Me.bt_aceptar.Text = "Aceptar"
        '
        'Dgv_CodArancelario
        '
        Me.Dgv_CodArancelario.AllowUserToAddRows = False
        Me.Dgv_CodArancelario.AllowUserToDeleteRows = False
        Me.Dgv_CodArancelario.AllowUserToResizeColumns = False
        Me.Dgv_CodArancelario.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_CodArancelario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_CodArancelario.AutoGenerateColumns = False
        Me.Dgv_CodArancelario.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_CodArancelario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_CodArancelario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoArancelarioDataGridViewTextBoxColumn, Me.ImpuestoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.Dgv_CodArancelario.DataSource = Me.Sp_consultaCodigoArancelarioBindingSource
        Me.Dgv_CodArancelario.Location = New System.Drawing.Point(5, 107)
        Me.Dgv_CodArancelario.MultiSelect = False
        Me.Dgv_CodArancelario.Name = "Dgv_CodArancelario"
        Me.Dgv_CodArancelario.ReadOnly = True
        Me.Dgv_CodArancelario.RowHeadersVisible = False
        Me.Dgv_CodArancelario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_CodArancelario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_CodArancelario.Size = New System.Drawing.Size(344, 571)
        Me.Dgv_CodArancelario.TabIndex = 92
        '
        'CodigoArancelarioDataGridViewTextBoxColumn
        '
        Me.CodigoArancelarioDataGridViewTextBoxColumn.DataPropertyName = "CodigoArancelario"
        Me.CodigoArancelarioDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoArancelarioDataGridViewTextBoxColumn.Name = "CodigoArancelarioDataGridViewTextBoxColumn"
        Me.CodigoArancelarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoArancelarioDataGridViewTextBoxColumn.Width = 85
        '
        'ImpuestoDataGridViewTextBoxColumn
        '
        Me.ImpuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto"
        Me.ImpuestoDataGridViewTextBoxColumn.HeaderText = "Imp."
        Me.ImpuestoDataGridViewTextBoxColumn.Name = "ImpuestoDataGridViewTextBoxColumn"
        Me.ImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 188
        '
        'Sp_consultaCodigoArancelarioBindingSource
        '
        Me.Sp_consultaCodigoArancelarioBindingSource.DataMember = "sp_consultaCodigoArancelario"
        Me.Sp_consultaCodigoArancelarioBindingSource.DataSource = Me.MELDataSet
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(5, 74)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 23)
        Me.DomainUpDown1.TabIndex = 93
        '
        'Sp_consultaProductosCodArancelariosTableAdapter
        '
        Me.Sp_consultaProductosCodArancelariosTableAdapter.ClearBeforeFill = True
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Total.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.Location = New System.Drawing.Point(863, 216)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(14, 14)
        Me.lbl_Total.TabIndex = 97
        Me.lbl_Total.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(826, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 14)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Total:"
        '
        'Sp_consultaCodigoArancelarioTableAdapter
        '
        Me.Sp_consultaCodigoArancelarioTableAdapter.ClearBeforeFill = True
        '
        'Frm_Codigos_Arancelarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 732)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Dgv_CodArancelario)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.groupbox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 150)
        Me.MaximizeBox = False
        Me.Name = "Frm_Codigos_Arancelarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Códigos Arancelarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gb_Preferencias.ResumeLayout(False)
        Me.gb_Preferencias.PerformLayout()
        CType(Me.SpconsultaPreferenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Preferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductosCodArancelariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_CodArancelario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaCodigoArancelarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False

        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Descripción")
        Me.DomainUpDown1.SelectedIndex = 0

        limpiacolec(l)
        limpiacolec(lelim)

        Dim cant As Integer = 0
        'DatosCodigosArancelarios.consulta_codigosArancelarios(Me.Dgv_CodArancelario)
        Sp_consultaCodigoArancelarioTableAdapter.Fill(Me.MELDataSet.sp_consultaCodigoArancelario, "0")
        Sp_consultaProductosCodArancelariosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosCodArancelarios)
        SpconsultaProductosCodArancelariosBindingSource.Filter = "CodigoArancelario = '-1'"
        Dim Count As Object
        Count = Me.MELDataSet.sp_consultaProductosCodArancelarios.Compute("COUNT(Nombre)", SpconsultaProductosCodArancelariosBindingSource.Filter)
        Me.lbl_Total.Text = Count.ToString

        'Tabla.Columns.Add(New DataColumn("Asociado", GetType(Boolean)))
        'Tabla.Columns.Add(New DataColumn("Descripcion"))
        'Tabla.Columns.Add(New DataColumn("Codigo"))
        'AddTableStyle()
        Label2.Text = Dgv_CodArancelario.RowCount
        Dgv_CodArancelario.ClearSelection()
        DomainUpDown1.SelectedIndex = 0
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If

    End Sub

    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then
            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then
            boton = "n"
            tb_ImpuestoP.Clear()
            Me.cb_Preferencias.DataSource = Me.SpconsultaPreferenciasBindingSource
            Me.cb_Preferencias.DisplayMember = "Descripción"
            Me.Sp_consultaPreferenciasTableAdapter.Fill(Me.MELDataSet.sp_consultaPreferencias)

            If cb_Preferencias.Items.Count > 0 Then
                cb_Preferencias.SelectedIndex = 0
            End If
            cb_Preferencias.Enabled = True
            tb_ImpuestoP.Enabled = True
            bt_agregarP.Enabled = True
            Me.bt_modificarP.Enabled = True
            rb_todos.Visible = True
            rb_ninguno.Visible = True
            bt_eliminarP.Enabled = True
            Me.DataGridView1.Enabled = True
            Me.tb_codigo.Clear()
            Me.tb_impuesto.Clear()

            'Tabla.Clear()
            'AddData2()
            limpiacolec(l)
            DGV_Preferencias.ClearSelection()
            DGV_Preferencias.Rows.Clear()
            Me.tb_codigo.Enabled = True
            Me.tb_impuesto.Enabled = True
            Me.ToolBar1.Enabled = False
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.Dgv_CodArancelario.Enabled = False
            'DataGridView1.ClearSelection()
            'Me.DomainUpDown1.Items.Add("Descripción")
            Me.DomainUpDown1.SelectedIndex = 0
            RemoveHandler TextBox1.TextChanged, AddressOf tb_buscar_TextChanged
            Me.TextBox1.Clear()
            AddHandler TextBox1.TextChanged, AddressOf tb_buscar_TextChanged
            'DatosCodigosArancelarios.Llenar_DGV_Arancelarios("0", 3, DataGridView1, Tabla)
            'DataGridView1.Sort(Codigo, System.ComponentModel.ListSortDirection.Ascending)
            DataGridView1.Columns(0).Visible = True
            rb_ninguno.Checked = False
            rb_todos.Checked = False
            TextBox1.Clear()

            Dgv_CodArancelario.ClearSelection()

            Sp_consultaProductosCodArancelariosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosCodArancelarios)
            CrearWhere()

            Me.tb_codigo.Focus()
            Dgv_CodArancelario.ClearSelection()

        ElseIf e.Button Is Me.bt_modificar Then
            codigo2 = tb_codigo.Text
            Dim n1 As Integer
            n1 = Dgv_CodArancelario.SelectedRows.Count
            If n1 = 1 Then
                boton = "m"
                tb_ImpuestoP.Clear()
                If cb_Preferencias.Items.Count > 0 Then
                    cb_Preferencias.SelectedIndex = 0
                End If
                rb_ninguno.Checked = False
                rb_todos.Checked = False

                Me.bt_modificarP.Enabled = True
                Me.cb_Preferencias.DataSource = Me.SpconsultaPreferenciasBindingSource
                Me.cb_Preferencias.DisplayMember = "Descripción"
                Me.Sp_consultaPreferenciasTableAdapter.Fill(Me.MELDataSet.sp_consultaPreferencias)
                cb_Preferencias.Enabled = True
                tb_ImpuestoP.Enabled = True
                bt_agregarP.Enabled = True
                bt_eliminarP.Enabled = True
                Me.DataGridView1.Enabled = True
                Me.ToolBar1.Enabled = False
                Me.tb_codigo.Enabled = True
                rb_todos.Visible = True
                rb_ninguno.Visible = True
                DGV_Preferencias.ClearSelection()
                Me.tb_impuesto.Enabled = True
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.Dgv_CodArancelario.Enabled = False
                Sp_consultaProductosCodArancelariosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosCodArancelarios)
                switch = True
                CrearWhere()
                switch = False
                DataGridView1.Columns(0).Visible = True
                Me.DomainUpDown1.SelectedIndex = 0
                RemoveHandler TextBox1.TextChanged, AddressOf tb_buscar_TextChanged
                Me.TextBox1.Clear()
                AddHandler TextBox1.TextChanged, AddressOf tb_buscar_TextChanged
                Me.tb_impuesto.Focus()
                'DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el código arancelario que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Soló puede modificar un código a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then

            boton = "e"
            Dim n2 As Integer
            Dim cod As String
            Dim response As MsgBoxResult
            n2 = Me.Dgv_CodArancelario.SelectedRows.Count
            If n2 = 0 Then
                response = MsgBox("Debe seleccionar el código arancelario que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            ElseIf n2 = 1 Then
                response = MsgBox("¿Confirma que desea eliminar el código arancelario '" + Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    cod = Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString
                    DatosCodigosArancelarios.elimina_codigoArancelario(cod)
                    MsgBox("El Código Arancelario '" + Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString + "' Ha Sido Eliminado Exitosamente")
                    Me.Sp_consultaPreferenciasTableAdapter.Fill(Me.MELDataSet.sp_consultaPreferencias)
                    tb_ImpuestoP.Clear()
                    If cb_Preferencias.Items.Count > 0 Then
                        cb_Preferencias.SelectedIndex = 0
                    End If

                    'DataGridView1.Rows.Clear()
                    Sp_consultaProductosCodArancelariosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosCodArancelarios)
                    CrearWhere()

                    DGV_Preferencias.Rows.Clear()
                    tb_codigo.Clear()
                    tb_impuesto.Clear()
                    tb_ImpuestoP.Clear()
                End If
            Else
                response = MsgBox("¿Confirma que desea eliminar estos (" + n2.ToString + ") Códigos Arancelarios?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then

                    Dim i As Integer = 0

                    For i = 0 To Dgv_CodArancelario.RowCount - 1

                        If Dgv_CodArancelario.SelectedRows.Count > 0 Then
                            cod = Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString
                            DatosCodigosArancelarios.elimina_codigoArancelario(cod)
                        End If

                    Next

                    MsgBox("Se han eliminado (" + n2.ToString + ") Códigos Arancelarios Exitosamente")

                    Dgv_CodArancelario.Rows.Clear()
                    tb_codigo.Clear()
                    tb_impuesto.Clear()
                    tb_ImpuestoP.Clear()
                End If
            End If
            Dim cant As Integer = 0

            DatosCodigosArancelarios.consulta_codigosArancelarios(Me.Dgv_CodArancelario)
            Label2.Text = Dgv_CodArancelario.RowCount
            'Tabla.Clear()

            Me.Dgv_CodArancelario.ClearSelection()

        End If

    End Sub
    'Private Sub AddData(ByVal codG As Integer)
    '    DatosCodigosArancelarios.consulta_productos_Arancelario(Tabla, Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString)
    'End Sub
    'Private Sub AddData2()
    '    DatosCodigosArancelarios.consulta_productos_noArancelario(Tabla)
    'End Sub
    'Private Sub AddData3()
    '    DatosCodigosArancelarios.consulta_productos_Arancelario(Tabla, Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString)
    '    Dim i As Integer = 0
    '    While i < Tabla.Rows.Count
    '        l.Add(Tabla.Rows(i).Item(2))
    '        Console.WriteLine("Add de BD: " + l.Item(l.Count))
    '        i = i + 1
    '    End While
    '    cuantos = l.Count
    '    Console.WriteLine(cuantos)
    '    DatosCodigosArancelarios.consulta_productos_noArancelario(Tabla)
    'End Sub

    Private myCheckBoxCol As Integer = 0

    Public Sub Agrega_Elimina_elementos() Handles DataGridView1.CellParsing

        Try

            If DataGridView1.SelectedRows(0).Cells(0).Value Then

                lelim.Add(DataGridView1.SelectedRows(0).Cells(1).Value, DataGridView1.SelectedRows(0).Cells(1).Value)
                l.Remove(DataGridView1.SelectedRows(0).Cells(1).Value)

            Else

                l.Add(DataGridView1.SelectedRows(0).Cells(1).Value, DataGridView1.SelectedRows(0).Cells(1).Value)
                lelim.Remove(DataGridView1.SelectedRows(0).Cells(1).Value)

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub limpiacolec(ByRef col As Collection)
        For Each item In col
            col.Remove(1)
        Next
    End Sub
    'Private Sub AddTableStyle()
    '    Dim dgt As DataGridTableStyle = New DataGridTableStyle
    '    dgt.MappingName = "Tablita"
    '    dgt.SelectionBackColor = System.Drawing.Color.DarkTurquoise

    '    Dim ch As New DataGridBoolColumn
    '    ch.MappingName = "Asociado"
    '    ch.HeaderText = ""
    '    ch.Width = 0
    '    ch.AllowNull = False
    '    dgt.GridColumnStyles.Add(ch)

    '    Dim nom As DataGridEnableTextBoxColumn
    '    nom = New DataGridEnableTextBoxColumn(1)
    '    nom.HeaderText = "Descripción"
    '    nom.MappingName = "Descripción"
    '    nom.Width = 300
    '    AddHandler nom.CheckCellEnabled, New DataGridEnableTextBoxColumn.EnableCellEventHandler(AddressOf SetEnableValuesfalse)
    '    dgt.GridColumnStyles.Add(nom)

    '    Dim cod As DataGridEnableTextBoxColumn
    '    cod = New DataGridEnableTextBoxColumn(2)
    '    cod.HeaderText = "Código"
    '    cod.MappingName = "Código"
    '    cod.Width = 140
    '    AddHandler cod.CheckCellEnabled, New DataGridEnableTextBoxColumn.EnableCellEventHandler(AddressOf SetEnableValuesfalse)
    '    dgt.GridColumnStyles.Add(cod)

    'End Sub
    Public Sub SetEnableValuesfalse(ByVal sender As Object, ByVal e As DataGridEnableEventArgs)
        e.EnableValue = False
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.tb_codigo.Enabled = False
        Me.tb_impuesto.Enabled = False
        Me.Dgv_CodArancelario.Enabled = True
        DGV_Preferencias.Rows.Clear()
        Me.ToolBar1.Enabled = True
        Me.TextBox1.Enabled = True
        Me.tb_codigo.Clear()
        Me.tb_impuesto.Clear()
        Me.Dgv_CodArancelario.ClearSelection()
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        'Tabla.Clear()
        limpiacolec(l)
        limpiacolec(lelim)
        tb_ImpuestoP.Clear()
        If cb_Preferencias.Items.Count > 0 Then
            cb_Preferencias.SelectedIndex = 0
        End If

        boton = ""
        cb_Preferencias.Enabled = False
        tb_ImpuestoP.Enabled = False
        bt_agregarP.Enabled = False
        bt_eliminarP.Enabled = False
        Me.DomainUpDown1.Focus()
        Me.bt_modificarP.Enabled = False
        Me.rb_ninguno.Visible = False
        Me.rb_todos.Visible = False
        Me.DomainUpDown1.SelectedIndex = 0
        Me.DomainUpDown1.Select()
        Me.TextBox1.Text = ""
        SpconsultaProductosCodArancelariosBindingSource.Filter = "CodigoArancelario = '-1'"
        Dim Count As Object
        Count = Me.MELDataSet.sp_consultaProductosCodArancelarios.Compute("COUNT(Nombre)", SpconsultaProductosCodArancelariosBindingSource.Filter)
        Me.lbl_Total.Text = Count.ToString
        Dim cant As Integer = 0
        tb_buscar_TextChanged(TextBox1, New EventArgs)
        DataGridView1.Columns(0).Visible = False
        Dgv_CodArancelario.ClearSelection()

    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_codigo.Text = "" Or Me.tb_impuesto.Text = "" Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim deny As Boolean = False
        If boton = "n" Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else
                'CrearWhere()
                'If DataGridView1.Rows.Count = 0 Then
                '    MsgBox("No hay productos disponibles sin código arancelario asignado. No se creará el nuevo código arancelario.")
                'Else
                Dim u As Boolean = False
                DatosCodigosArancelarios.chequea_CA(Me.tb_codigo.Text, u)
                If u = False Then

                    Try

                        Dim i As Long
                        i = CLng(tb_codigo.Text)

                        Dim s As String = ""
                        s = tb_codigo.Text
                        DatosCodigosArancelarios.inserta_codigoArancelario(CDbl(Me.tb_impuesto.Text), s)
                        MsgBox("El Código Arancelario Ha Sido Registrado Exitosamente")

                        For cont2 As Integer = 0 To DataGridView1.RowCount - 1
                            If DataGridView1.Rows(cont2).Cells(0).Value = 1 Then
                                DatosCodigosArancelarios.insertar_producto_Arancelario(Me.tb_codigo.Text, DataGridView1.Rows(cont2).Cells(1).Value.ToString)
                            End If
                        Next

                        Dim cont As Integer = 0

                        For cont = 0 To DGV_Preferencias.RowCount - 1

                            DatosCodigosArancelarios.InsertaPreferencias(tb_codigo.Text, DGV_Preferencias.Rows(cont).Cells(2).Value, CDbl(DGV_Preferencias.Rows(cont).Cells(1).Value))

                        Next

                        DGV_Preferencias.Rows.Clear()

                    Catch ex As Exception
                        MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Critical)
                        deny = True
                    End Try

                Else
                    MsgBox("El Código Arancelario " + Me.tb_codigo.Text + " no se puede registrar, ya existe.")
                    deny = True
                End If
                'End If
            End If
        ElseIf boton = "m" Then

            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True

            Else
                Try
                    Dim st As String = ""
                    st = tb_codigo.Text
                    DatosCodigosArancelarios.modifica_codigoArancelario(CDbl(Me.tb_impuesto.Text), Me.tb_codigo.Text, codigo2)

                    DatosCodigosArancelarios.elimina_producto_Arancelario(tb_codigo.Text)

                    For cont2 As Integer = 0 To DataGridView1.RowCount - 1
                        If DataGridView1.Rows(cont2).Cells(0).Value = 1 Then
                            DatosCodigosArancelarios.insertar_producto_Arancelario(Me.tb_codigo.Text, DataGridView1.Rows(cont2).Cells(1).Value.ToString)

                        End If
                    Next

                    Dim cont As Integer = 0

                    DatosCodigosArancelarios.EliminaPreferencias(tb_codigo.Text)

                    For cont = 0 To DGV_Preferencias.RowCount - 1

                        DatosCodigosArancelarios.InsertaPreferencias(tb_codigo.Text, DGV_Preferencias.Rows(cont).Cells(2).Value, CDbl(DGV_Preferencias.Rows(cont).Cells(1).Value))

                    Next



                    MsgBox("El Código Arancelario Ha Sido Modificado Exitosamente")
                    deny = False
                    DGV_Preferencias.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Debe introducir un valor numérico", MsgBoxStyle.Critical)
                    deny = True
                End Try


            End If
        End If
        If deny = False Then
            DatosCodigosArancelarios.consulta_codigosArancelarios(Me.Dgv_CodArancelario)
            Label2.Text = Dgv_CodArancelario.RowCount
            Me.tb_codigo.Enabled = False
            Me.tb_impuesto.Enabled = False
            Me.Dgv_CodArancelario.Enabled = True
            Me.ToolBar1.Enabled = True
            Me.TextBox1.Enabled = True
            rb_todos.Visible = False
            rb_ninguno.Visible = False
            Me.tb_codigo.Text = ""
            cb_Preferencias.Enabled = False
            Me.bt_modificarP.Enabled = False
            tb_ImpuestoP.Enabled = False
            bt_agregarP.Enabled = False
            bt_eliminarP.Enabled = False
            Me.tb_impuesto.Text = ""
            Me.Dgv_CodArancelario.ClearSelection()
            'Tabla.Clear()
            limpiacolec(l)
            tb_ImpuestoP.Clear()
            If cb_Preferencias.Items.Count > 0 Then
                cb_Preferencias.SelectedIndex = 0
            End If
            Me.rb_ninguno.Visible = False
            Me.rb_todos.Visible = False
            limpiacolec(lelim)
            boton = ""
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.DomainUpDown1.Focus()
            Me.DomainUpDown1.SelectedIndex = 0
            Me.DomainUpDown1.Select()
            Me.TextBox1.Text = ""
            Dim c As Integer = 0
            DataGridView1.Columns(0).Visible = False
            Sp_consultaProductosCodArancelariosTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosCodArancelarios)
            SpconsultaProductosCodArancelariosBindingSource.Filter = "CodigoArancelario = '-1'"
            Dim Count As Object
            Count = Me.MELDataSet.sp_consultaProductosCodArancelarios.Compute("COUNT(Nombre)", SpconsultaProductosCodArancelariosBindingSource.Filter)
            Me.lbl_Total.Text = Count.ToString
            tb_buscar_TextChanged(TextBox1, New EventArgs)
        End If

        Dgv_CodArancelario.ClearSelection()

    End Sub
    Private Sub modifica_Arancelario(ByVal y As String)
        Dim i As Integer = 1
        For Each item In l
            Dim int As String = item
            If i > cuantos Then
                DatosCodigosArancelarios.insertar_producto_Arancelario(y, int)
            End If
            i = i + 1
        Next
    End Sub

    Private Sub Form7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, Label6.Click, Label4.Click, Label5.Click, GroupBox2.Click, groupbox1.Click
        If Me.Dgv_CodArancelario.Enabled = True Then
            Me.tb_codigo.Clear()
            Me.tb_impuesto.Clear()
        End If

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim text As String = TextBox1.Text
        text = text.Replace(",", ".")

        If Me.Dgv_CodArancelario.Enabled = True Then

            Dim s1 As String
            s1 = "%" + text + "%"

            If choice = 0 Then
                Sp_consultaCodigoArancelarioBindingSource.Filter = "CodigoArancelario LIKE '" + s1 + "'"
            ElseIf choice = 1 Then
                Sp_consultaCodigoArancelarioBindingSource.Filter = "descripcion LIKE '" + s1 + "'"
            End If


            Dim Count2 As Object = Me.MELDataSet.sp_consultaCodigoArancelario.Compute("COUNT(CodigoArancelario)", Sp_consultaCodigoArancelarioBindingSource.Filter)
            Label2.Text = Count2.ToString
            Dgv_CodArancelario.ClearSelection()
            SpconsultaProductosCodArancelariosBindingSource.Filter = "CodigoArancelario = '-1'"
            Dim Count As Object
            Count = Me.MELDataSet.sp_consultaProductosCodArancelarios.Compute("COUNT(Nombre)", SpconsultaProductosCodArancelariosBindingSource.Filter)
            Me.lbl_Total.Text = Count.ToString
            DGV_Preferencias.Rows.Clear()
            tb_impuesto.Clear()
            tb_codigo.Clear()

        Else

            CrearWhere()

        End If

        rb_ninguno.Checked = False
        rb_todos.Checked = False

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.TextBox1.Text = ""
        Me.TextBox1.Focus()
    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_impuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_impuesto.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números o (,)"
        End If
    End Sub

    Private Sub tb_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_codigo.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números o (.)"
        End If
    End Sub

    Private Sub tb_ImpuestoP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_ImpuestoP.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números o (,)"
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then

            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 45, c.Location.Y + 45)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True


        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_impuesto.LostFocus
        muestra_label(sender, 1)
    End Sub

    Private Sub tb_codigo_enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_codigo.Enter
        codigo2 = tb_codigo.Text
    End Sub

    Private Sub bt_agregarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarP.Click
        Try
            If Not cb_Preferencias.SelectedItem Is Nothing Then
                If Not Buscar_Elemento_En_DGV(cb_Preferencias.Text, DGV_Preferencias, 0) Then
                    DGV_Preferencias.Rows.Add(cb_Preferencias.Text, tb_ImpuestoP.Text, cb_Preferencias.SelectedValue)
                    tb_ImpuestoP.Clear()
                    If cb_Preferencias.Items.Count > 0 Then
                        cb_Preferencias.SelectedIndex = 0
                    End If

                Else
                    MsgBox("Esta preferencia ya está agregada", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe seleccionar una preferencia", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("La lista está vacía", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function Buscar_Elemento_En_DGV(ByVal Nombre As String, ByVal DGV As DataGridView, ByVal tipo As Integer) As Boolean

        Try

            Dim Cont As Integer = 0
            Dim retorno As Boolean = False

            If DGV.Rows(0).Cells(tipo).Value.ToString.ToUpper = Nombre.ToUpper Then
                retorno = True
            End If

            For Cont = 0 To DGV.Rows.Count - 1

                If DGV.Rows(Cont).Cells(tipo).Value.ToString.ToUpper = Nombre.ToUpper Then
                    retorno = True
                End If

            Next

            Return retorno

        Catch ex As Exception


        End Try

    End Function

    Private Sub bt_eliminarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarP.Click
        Try
            DGV_Preferencias.Rows.Remove(DGV_Preferencias.SelectedRows(0))
            tb_ImpuestoP.Clear()
            If cb_Preferencias.Items.Count > 0 Then
                cb_Preferencias.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("La lista está vacía", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub Dgv_CodArancelario_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_CodArancelario.CellClick, Dgv_CodArancelario.KeyUp, Dgv_CodArancelario.KeyDown
        Try
            If (Dgv_CodArancelario.RowCount > 0) Then
                Dim cod As String = ""
                cod = Me.Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString
                DatosCodigosArancelarios.consulta_codigoArancelario(cod, Me.tb_codigo.Text, Me.tb_impuesto.Text)
                CrearWhere()
                'DatosCodigosArancelarios.Llenar_DGV_Arancelarios(Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString, 1, DataGridView1, Tabla)
                DatosCodigosArancelarios.Llenar_DGV_Preferencias(Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString, DGV_Preferencias)
                DataGridView1.Columns(0).Visible = False
                DGV_Preferencias.ClearSelection()
                'DataGridView1.ClearSelection()
                'AddData(cod)
            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If Dgv_CodArancelario.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.Dgv_CodArancelario.Rows(0).Cells(0).Selected = True
                Dgv_CodArancelario.Focus()

            End If

        End If


    End Sub

    Private Sub tb_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Dgv_CodArancelario.Enabled = False Then
            If e.KeyChar <> "'"c And e.KeyChar <> "%"c Then
                e.Handled = False
                'muestra_label(sender, 1)
            Else
                e.Handled = True
                'muestra_label(sender, 0)
                'Me.Label22.Text = "      Ingrese sólo números y (,)"
            End If
        End If



    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged
        If rb_todos.Checked = True Then
            For cont1 As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(cont1).Cells(0).Value = True


                'For cont2 As Integer = 0 To Tabla.Rows.Count - 1
                '    If Tabla.Rows(cont2).Item(2).ToString = DataGridView1.Rows(cont1).Cells(1).Value.ToString Then
                '        Tabla.Rows(cont2).Item(0) = DataGridView1.Rows(cont1).Cells(0).Value
                '    End If
                'Next


            Next
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_ninguno.CheckedChanged
        If rb_ninguno.Checked = True Then

            For cont1 As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(cont1).Cells(0).Value = False

                'For cont2 As Integer = 0 To Tabla.Rows.Count - 1
                '    If Tabla.Rows(cont2).Item(2).ToString = DataGridView1.Rows(cont1).Cells(1).Value.ToString Then
                '        Tabla.Rows(cont2).Item(0) = DataGridView1.Rows(cont1).Cells(0).Value
                '    End If
                'Next

            Next
        End If


    End Sub




    Public Sub llena(ByRef dgv2 As DataGridView, ByVal dgv As DataView)

        dgv2.Rows.Clear()
        Dim anterior As String = ""
        Dim anterior2 As String = ""
        Dim CONT As Integer = 0
        Dim cont4 As Integer = 0
        Dim sw2 As Boolean = False
        Dim colec As New Collection


        For CONT = 0 To dgv.Count - 1

            dgv2.Rows.Add(dgv.Item(CONT).Row(0), dgv.Item(CONT).Row(2), dgv.Item(CONT).Row(1))

        Next

        CONT = 0


    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        If e.ColumnIndex = 0 Then

            If DataGridView1.SelectedRows.Count > 0 Then

                If DataGridView1.SelectedRows(0).Cells(0).EditedFormattedValue() = False Then

                    '    For cont2 As Integer = 0 To Tabla.Rows.Count - 1
                    '        If Tabla.Rows(cont2).Item(2).ToString = DataGridView1.SelectedRows(0).Cells(1).Value.ToString Then
                    '            Tabla.Rows(cont2).Item(0) = True
                    '            cont2 = Tabla.Rows.Count
                    '        End If
                    '    Next

                    'Else

                    '    For cont2 As Integer = 0 To Tabla.Rows.Count - 1
                    '        If Tabla.Rows(cont2).Item(2).ToString = DataGridView1.SelectedRows(0).Cells(1).Value.ToString Then
                    '            Tabla.Rows(cont2).Item(0) = False
                    '            cont2 = Tabla.Rows.Count
                    '        End If
                    '    Next

                End If

            End If

        End If

    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If Dgv_CodArancelario.Enabled Then

            If Dgv_CodArancelario.SelectedRows.Count > 0 Then

                where = where + "CodigoArancelario = '" & Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString & "'" + y
                y = " and "

            Else

                where = where + "CodigoArancelario = '%" & "'-1'" & "%'" + y
                y = " and "

            End If

        Else

            If Dgv_CodArancelario.SelectedRows.Count > 0 Then

                where = where + "CodigoArancelario = '" & Dgv_CodArancelario.SelectedRows(0).Cells(0).Value.ToString & "'" + y
                y = " and "

                If boton = "m" Then
                    where = where + " OR CodigoArancelario = ''"
                    y = " and "
                End If

            Else

                where = where + "CodigoArancelario = ''" + y
                y = " and "

            End If

            If TextBox1.Text <> "" And switch = False Then

                If DomainUpDown1.SelectedIndex = 0 Then

                    where = where + y + "CodigoInterno LIKE '%" & TextBox1.Text & "%'"
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 1 Then

                    where = where + y + "Nombre LIKE '%" & TextBox1.Text & "%'"
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 2 Then

                    where = where + y + "Marca LIKE '%" & TextBox1.Text & "%'"
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 3 Then

                    where = where + y + "Modelo LIKE '%" & TextBox1.Text & "%'"
                    y = " and "

                End If

            End If

        End If

        Me.SpconsultaProductosCodArancelariosBindingSource.Filter = where

        If DataGridView1.RowCount > 0 Then
            DataGridView1.FirstDisplayedScrollingRowIndex = 0
        End If

        DataGridView1.ClearSelection()

        Dim Count As Object
        Count = Me.MELDataSet.sp_consultaProductosCodArancelarios.Compute("COUNT(Nombre)", where)
        Me.lbl_Total.Text = Count.ToString

    End Sub


    Private Sub DGV_Preferencias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Preferencias.CellClick

        If DGV_Preferencias.SelectedRows.Count > 0 And (boton = "n" Or boton = "m") Then
            cb_Preferencias.Text = DGV_Preferencias.SelectedRows(0).Cells(0).Value
            tb_ImpuestoP.Text = DGV_Preferencias.SelectedRows(0).Cells(1).Value
        End If

    End Sub

    Private Sub tb_modificarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarP.Click
        If DGV_Preferencias.SelectedRows.Count > 0 Then

            If tb_ImpuestoP.Text <> "" Then
                If DGV_Preferencias.SelectedRows(0).Cells(0).Value = cb_Preferencias.Text Then

                    DGV_Preferencias.SelectedRows(0).Cells(1).Value = tb_ImpuestoP.Text

                End If
            Else

                MsgBox("Debe ingresar el impuesto", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else
            MsgBox("Debe seleccionar una preferencia para modificar", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

End Class


