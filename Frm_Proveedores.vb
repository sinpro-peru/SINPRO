Public Class Frm_Proveedores
    Inherits System.Windows.Forms.Form
    Private varboton As Integer = 0
    Private anterior As String = ""
    Private anterior2 As Integer = 0
    Private choice As Integer
    Private swC As Boolean = False
    Private indice As Integer = 0
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGV_Proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_var2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tb_var1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bt_agregarCodigo As System.Windows.Forms.Button
    Friend WithEvents DGV_Asociacion As System.Windows.Forms.DataGridView
    Friend WithEvents bt_eliminarCodigo As System.Windows.Forms.Button
    Friend WithEvents tb_codigoFabrica As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codigoFabrica As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_telefonoC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tb_PersonaC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tb_telefonoC As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tb_PersonaC As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_clasificacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_telefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_telefono1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents tb_representante As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cb_preferencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private swX As Boolean = False
    Dim w As Boolean = True
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpConsultaProductosProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_ConsultaProductosProveedoresTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaProductosProveedoresTableAdapter
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Var1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Var2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Dim e As Boolean = True

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
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Proveedores))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGV_Proveedores = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tb_var2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tb_var1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_agregarCodigo = New System.Windows.Forms.Button
        Me.DGV_Asociacion = New System.Windows.Forms.DataGridView
        Me.bt_eliminarCodigo = New System.Windows.Forms.Button
        Me.tb_codigoFabrica = New System.Windows.Forms.TextBox
        Me.lbl_codigoFabrica = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cb_preferencia = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cb_moneda = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_telefonoC2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Tb_PersonaC2 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.tb_telefonoC = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Tb_PersonaC = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tb_clasificacion = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.tb_email = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_fax = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tb_telefono2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_telefono1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tb_direccion = New System.Windows.Forms.TextBox
        Me.tb_representante = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.SpConsultaProductosProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_ConsultaProductosProveedoresTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaProductosProveedoresTableAdapter
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Var2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Var1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoProductoF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Asociacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SpConsultaProductosProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(5, 2)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(344, 65)
        Me.ToolBar1.TabIndex = 11
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
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 692)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total:"
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(189, 72)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(177, 25)
        Me.tb_buscarcodigo.TabIndex = 71
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(382, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(646, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Datos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Proveedores
        '
        Me.DGV_Proveedores.AllowUserToAddRows = False
        Me.DGV_Proveedores.AllowUserToDeleteRows = False
        Me.DGV_Proveedores.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Proveedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Proveedores.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre})
        Me.DGV_Proveedores.EnableHeadersVisualStyles = False
        Me.DGV_Proveedores.Location = New System.Drawing.Point(5, 105)
        Me.DGV_Proveedores.MultiSelect = False
        Me.DGV_Proveedores.Name = "DGV_Proveedores"
        Me.DGV_Proveedores.ReadOnly = True
        Me.DGV_Proveedores.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Proveedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Proveedores.Size = New System.Drawing.Size(371, 579)
        Me.DGV_Proveedores.TabIndex = 10030
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 79.18782!
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 120.8122!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(5, 70)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 23)
        Me.DomainUpDown1.TabIndex = 10031
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.tb_var2)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.tb_var1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.bt_agregarCodigo)
        Me.GroupBox2.Controls.Add(Me.DGV_Asociacion)
        Me.GroupBox2.Controls.Add(Me.bt_eliminarCodigo)
        Me.GroupBox2.Controls.Add(Me.tb_codigoFabrica)
        Me.GroupBox2.Controls.Add(Me.lbl_codigoFabrica)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 346)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        '
        'tb_var2
        '
        Me.tb_var2.BackColor = System.Drawing.SystemColors.Control
        Me.tb_var2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_var2.Location = New System.Drawing.Point(149, 309)
        Me.tb_var2.Name = "tb_var2"
        Me.tb_var2.ReadOnly = True
        Me.tb_var2.Size = New System.Drawing.Size(89, 22)
        Me.tb_var2.TabIndex = 10039
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(71, 309)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 10038
        Me.Label16.Text = "Variante 2:"
        '
        'tb_var1
        '
        Me.tb_var1.BackColor = System.Drawing.SystemColors.Control
        Me.tb_var1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_var1.Location = New System.Drawing.Point(149, 281)
        Me.tb_var1.Name = "tb_var1"
        Me.tb_var1.ReadOnly = True
        Me.tb_var1.Size = New System.Drawing.Size(89, 22)
        Me.tb_var1.TabIndex = 10037
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 10036
        Me.Label7.Text = "Variante 1:"
        '
        'bt_agregarCodigo
        '
        Me.bt_agregarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.bt_agregarCodigo.Enabled = False
        Me.bt_agregarCodigo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarCodigo.Image = Global.Tesis_Nueva.My.Resources.Resources.check_16x16
        Me.bt_agregarCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCodigo.Location = New System.Drawing.Point(512, 293)
        Me.bt_agregarCodigo.Name = "bt_agregarCodigo"
        Me.bt_agregarCodigo.Size = New System.Drawing.Size(25, 21)
        Me.bt_agregarCodigo.TabIndex = 10035
        Me.bt_agregarCodigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_agregarCodigo.UseVisualStyleBackColor = False
        '
        'DGV_Asociacion
        '
        Me.DGV_Asociacion.AllowUserToAddRows = False
        Me.DGV_Asociacion.AllowUserToDeleteRows = False
        Me.DGV_Asociacion.AllowUserToResizeColumns = False
        Me.DGV_Asociacion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Asociacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Asociacion.AutoGenerateColumns = False
        Me.DGV_Asociacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Asociacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Asociacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Asociacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CodigoProductoF, Me.Var1DataGridViewTextBoxColumn, Me.Var2DataGridViewTextBoxColumn, Me.CodigoFabricaDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.Marca})
        Me.DGV_Asociacion.DataSource = Me.SpConsultaProductosProveedoresBindingSource
        Me.DGV_Asociacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Asociacion.EnableHeadersVisualStyles = False
        Me.DGV_Asociacion.Location = New System.Drawing.Point(13, 27)
        Me.DGV_Asociacion.MultiSelect = False
        Me.DGV_Asociacion.Name = "DGV_Asociacion"
        Me.DGV_Asociacion.RowHeadersVisible = False
        Me.DGV_Asociacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Asociacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Asociacion.Size = New System.Drawing.Size(590, 244)
        Me.DGV_Asociacion.TabIndex = 90
        '
        'bt_eliminarCodigo
        '
        Me.bt_eliminarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.bt_eliminarCodigo.Enabled = False
        Me.bt_eliminarCodigo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarCodigo.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCodigo.Location = New System.Drawing.Point(543, 293)
        Me.bt_eliminarCodigo.Name = "bt_eliminarCodigo"
        Me.bt_eliminarCodigo.Size = New System.Drawing.Size(25, 21)
        Me.bt_eliminarCodigo.TabIndex = 10034
        Me.bt_eliminarCodigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_eliminarCodigo.UseVisualStyleBackColor = False
        '
        'tb_codigoFabrica
        '
        Me.tb_codigoFabrica.BackColor = System.Drawing.SystemColors.Control
        Me.tb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigoFabrica.Location = New System.Drawing.Point(363, 294)
        Me.tb_codigoFabrica.Name = "tb_codigoFabrica"
        Me.tb_codigoFabrica.ReadOnly = True
        Me.tb_codigoFabrica.Size = New System.Drawing.Size(130, 22)
        Me.tb_codigoFabrica.TabIndex = 80
        '
        'lbl_codigoFabrica
        '
        Me.lbl_codigoFabrica.BackColor = System.Drawing.Color.Transparent
        Me.lbl_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigoFabrica.Location = New System.Drawing.Point(244, 297)
        Me.lbl_codigoFabrica.Name = "lbl_codigoFabrica"
        Me.lbl_codigoFabrica.Size = New System.Drawing.Size(157, 20)
        Me.lbl_codigoFabrica.TabIndex = 80
        Me.lbl_codigoFabrica.Text = "Código de fábrica:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(379, 672)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 82
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(258, 672)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 81
        Me.bt_aceptar.Text = "Aceptar"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(6, 678)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(167, 20)
        Me.Label22.TabIndex = 73
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(14, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(616, 23)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Asociación de productos"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.GroupBox3)
        Me.groupbox1.Controls.Add(Me.Label15)
        Me.groupbox1.Controls.Add(Me.Label22)
        Me.groupbox1.Controls.Add(Me.bt_aceptar)
        Me.groupbox1.Controls.Add(Me.bt_cancelar)
        Me.groupbox1.Controls.Add(Me.GroupBox2)
        Me.groupbox1.Location = New System.Drawing.Point(382, 12)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(646, 703)
        Me.groupbox1.TabIndex = 16
        Me.groupbox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.cb_preferencia)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.cb_moneda)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tb_telefonoC2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Tb_PersonaC2)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.tb_telefonoC)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.tb_codigo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Tb_PersonaC)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tb_clasificacion)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.tb_email)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tb_fax)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.tb_telefono2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tb_telefono1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tb_nombre)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tb_direccion)
        Me.GroupBox3.Controls.Add(Me.tb_representante)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 270)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        '
        'cb_preferencia
        '
        Me.cb_preferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_preferencia.Enabled = False
        Me.cb_preferencia.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_preferencia.FormattingEnabled = True
        Me.cb_preferencia.Location = New System.Drawing.Point(99, 230)
        Me.cb_preferencia.Name = "cb_preferencia"
        Me.cb_preferencia.Size = New System.Drawing.Size(90, 23)
        Me.cb_preferencia.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 23)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Pref. Aranc."
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(323, 244)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 23)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "(*) ABC:"
        Me.Label21.Visible = False
        '
        'cb_moneda
        '
        Me.cb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_moneda.Enabled = False
        Me.cb_moneda.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_moneda.FormattingEnabled = True
        Me.cb_moneda.Location = New System.Drawing.Point(407, 191)
        Me.cb_moneda.Name = "cb_moneda"
        Me.cb_moneda.Size = New System.Drawing.Size(46, 23)
        Me.cb_moneda.TabIndex = 94
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(289, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Representante:"
        '
        'tb_telefonoC2
        '
        Me.tb_telefonoC2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefonoC2.Location = New System.Drawing.Point(407, 165)
        Me.tb_telefonoC2.MaxLength = 18
        Me.tb_telefonoC2.Name = "tb_telefonoC2"
        Me.tb_telefonoC2.ReadOnly = True
        Me.tb_telefonoC2.Size = New System.Drawing.Size(123, 22)
        Me.tb_telefonoC2.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "(*)Moneda:"
        '
        'Tb_PersonaC2
        '
        Me.Tb_PersonaC2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_PersonaC2.Location = New System.Drawing.Point(407, 140)
        Me.Tb_PersonaC2.MaxLength = 50
        Me.Tb_PersonaC2.Name = "Tb_PersonaC2"
        Me.Tb_PersonaC2.ReadOnly = True
        Me.Tb_PersonaC2.Size = New System.Drawing.Size(191, 22)
        Me.Tb_PersonaC2.TabIndex = 90
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(289, 143)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 23)
        Me.Label25.TabIndex = 91
        Me.Label25.Text = "Pers. Contacto (2):"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(100, 180)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(183, 22)
        Me.TextBox2.TabIndex = 84
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(289, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 23)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Teléfono:"
        '
        'tb_telefonoC
        '
        Me.tb_telefonoC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefonoC.Location = New System.Drawing.Point(407, 115)
        Me.tb_telefonoC.MaxLength = 18
        Me.tb_telefonoC.Name = "tb_telefonoC"
        Me.tb_telefonoC.ReadOnly = True
        Me.tb_telefonoC.Size = New System.Drawing.Size(123, 22)
        Me.tb_telefonoC.TabIndex = 88
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(289, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 23)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Teléfono:"
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(100, 15)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(123, 22)
        Me.tb_codigo.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "(*)Teléfono 1:"
        '
        'Tb_PersonaC
        '
        Me.Tb_PersonaC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_PersonaC.Location = New System.Drawing.Point(407, 90)
        Me.Tb_PersonaC.MaxLength = 50
        Me.Tb_PersonaC.Name = "Tb_PersonaC"
        Me.Tb_PersonaC.ReadOnly = True
        Me.Tb_PersonaC.Size = New System.Drawing.Size(191, 22)
        Me.Tb_PersonaC.TabIndex = 86
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(289, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 23)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Pers. Contacto:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Teléfono 2:"
        '
        'tb_clasificacion
        '
        Me.tb_clasificacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_clasificacion.Location = New System.Drawing.Point(415, 244)
        Me.tb_clasificacion.MaxLength = 1
        Me.tb_clasificacion.Name = "tb_clasificacion"
        Me.tb_clasificacion.Size = New System.Drawing.Size(43, 22)
        Me.tb_clasificacion.TabIndex = 9
        Me.tb_clasificacion.Text = "C"
        Me.tb_clasificacion.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(100, 108)
        Me.TextBox1.MaxLength = 250
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(183, 46)
        Me.TextBox1.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 23)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Página Web:"
        '
        'tb_email
        '
        Me.tb_email.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.Location = New System.Drawing.Point(100, 156)
        Me.tb_email.MaxLength = 50
        Me.tb_email.Name = "tb_email"
        Me.tb_email.ReadOnly = True
        Me.tb_email.Size = New System.Drawing.Size(183, 22)
        Me.tb_email.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 23)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Observación:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Código:"
        '
        'tb_fax
        '
        Me.tb_fax.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fax.Location = New System.Drawing.Point(100, 204)
        Me.tb_fax.MaxLength = 18
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.ReadOnly = True
        Me.tb_fax.Size = New System.Drawing.Size(123, 22)
        Me.tb_fax.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 23)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Dirección:"
        '
        'tb_telefono2
        '
        Me.tb_telefono2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono2.Location = New System.Drawing.Point(407, 40)
        Me.tb_telefono2.MaxLength = 18
        Me.tb_telefono2.Name = "tb_telefono2"
        Me.tb_telefono2.Size = New System.Drawing.Size(123, 22)
        Me.tb_telefono2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "(*)Nombre:"
        '
        'tb_telefono1
        '
        Me.tb_telefono1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono1.Location = New System.Drawing.Point(407, 15)
        Me.tb_telefono1.MaxLength = 18
        Me.tb_telefono1.Name = "tb_telefono1"
        Me.tb_telefono1.Size = New System.Drawing.Size(123, 22)
        Me.tb_telefono1.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 23)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Email:"
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(100, 40)
        Me.tb_nombre.MaxLength = 100
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.ReadOnly = True
        Me.tb_nombre.Size = New System.Drawing.Size(183, 22)
        Me.tb_nombre.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 23)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Fax:"
        '
        'tb_direccion
        '
        Me.tb_direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion.Location = New System.Drawing.Point(100, 64)
        Me.tb_direccion.MaxLength = 100
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.ReadOnly = True
        Me.tb_direccion.Size = New System.Drawing.Size(183, 42)
        Me.tb_direccion.TabIndex = 4
        '
        'tb_representante
        '
        Me.tb_representante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_representante.Location = New System.Drawing.Point(407, 65)
        Me.tb_representante.MaxLength = 50
        Me.tb_representante.Name = "tb_representante"
        Me.tb_representante.Size = New System.Drawing.Size(191, 22)
        Me.tb_representante.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(498, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 23)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "(*) Datos Requeridos"
        '
        'SpConsultaProductosProveedoresBindingSource
        '
        Me.SpConsultaProductosProveedoresBindingSource.DataMember = "sp_ConsultaProductosProveedores"
        Me.SpConsultaProductosProveedoresBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_ConsultaProductosProveedoresTableAdapter
        '
        Me.Sp_ConsultaProductosProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Visible = False
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoFabricaDataGridViewTextBoxColumn
        '
        Me.CodigoFabricaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.HeaderText = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.Name = "CodigoFabricaDataGridViewTextBoxColumn"
        Me.CodigoFabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFabricaDataGridViewTextBoxColumn.Visible = False
        Me.CodigoFabricaDataGridViewTextBoxColumn.Width = 138
        '
        'Var2DataGridViewTextBoxColumn
        '
        Me.Var2DataGridViewTextBoxColumn.DataPropertyName = "Var2"
        Me.Var2DataGridViewTextBoxColumn.HeaderText = "Var2"
        Me.Var2DataGridViewTextBoxColumn.Name = "Var2DataGridViewTextBoxColumn"
        Me.Var2DataGridViewTextBoxColumn.Visible = False
        '
        'Var1DataGridViewTextBoxColumn
        '
        Me.Var1DataGridViewTextBoxColumn.DataPropertyName = "Var1"
        Me.Var1DataGridViewTextBoxColumn.HeaderText = "Var1"
        Me.Var1DataGridViewTextBoxColumn.Name = "Var1DataGridViewTextBoxColumn"
        Me.Var1DataGridViewTextBoxColumn.Visible = False
        '
        'CodigoProductoF
        '
        Me.CodigoProductoF.DataPropertyName = "CodigoProductoF"
        Me.CodigoProductoF.HeaderText = "Codigo Fábrica"
        Me.CodigoProductoF.Name = "CodigoProductoF"
        Me.CodigoProductoF.ReadOnly = True
        Me.CodigoProductoF.Width = 138
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 145
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 172
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo I."
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 115
        '
        'Frm_Proveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 714)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.DGV_Proveedores)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.MaximizeBox = False
        Me.Name = "Frm_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Proveedores"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Asociacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SpConsultaProductosProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_ConsultaProductosProveedores' table. You can move, or remove it, as needed.
        DGV_Asociacion.ClearSelection()
        Me.tb_clasificacion.ReadOnly = True
        DatosPedidosCompras.Consulta_Moneda(cb_moneda)
        Me.tb_codigo.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_email.ReadOnly = True
        Me.tb_fax.ReadOnly = True
        Me.tb_representante.ReadOnly = True
        Me.tb_telefono1.ReadOnly = True
        Me.tb_telefono2.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Dim cant As Integer = 0
        DatosProveedor.consulta_proveedores(DGV_Proveedores)
        Label2.Text = cant
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0
        DGV_Proveedores.ClearSelection()
        Label2.Text = DGV_Proveedores.RowCount
        Me.Sp_ConsultaProductosProveedoresTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosProveedores, -1, 0)
        Me.SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
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

    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            If swC = True Then
                swC = False
                'Frm_Principal.Frm_Compras.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Compras.bt_actualizar))
                'Frm_Principal.Frm_Compras.refresca_lvproveedores(indice)
            End If
            If swX Then
                swX = False
                'Frm_Principal.Frm_Compras.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Compras.bt_actualizar))
            End If
            Me.Close()
        ElseIf e.Button Is Me.bt_nuevo Then
            'DGV_Asociacion.Rows.Clear()
            SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
            DGV_Asociacion.ClearSelection()
            DatosPedidosCompras.Consulta_Moneda(cb_moneda)
            cb_moneda.Text = ""
            cb_moneda.Enabled = True
            varboton = 1
            DomainUpDown1.Items.Add("Modelo")
            DomainUpDown1.Items.Add("Código Fábrica")
            DomainUpDown1.SelectedIndex = 0
            Me.tb_telefono2.Clear()
            Me.tb_telefono1.Clear()
            Me.tb_representante.Clear()
            Me.tb_nombre.Clear()
            Me.tb_fax.Clear()
            Me.tb_email.Clear()
            Me.tb_direccion.Clear()
            Me.tb_codigo.Clear()
            Me.tb_var1.Clear()
            Me.tb_var2.Clear()
            Me.tb_codigoFabrica.Clear()
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
            Me.tb_telefonoC.Clear()
            cb_preferencia.Enabled = True
            DatosProveedor.Consulta_preferencia(cb_preferencia)
            cb_preferencia.Text = ""
            Me.tb_telefonoC2.Clear()
            Me.Tb_PersonaC.Clear()
            Me.Tb_PersonaC2.Clear()
            Me.Tb_PersonaC2.ReadOnly = False
            Me.Tb_PersonaC.ReadOnly = False
            Me.tb_telefonoC2.ReadOnly = False
            Me.tb_telefonoC.ReadOnly = False
            Me.tb_buscarcodigo.Enabled = False
            DatosProveedor.identidad_Proveedor(Me.tb_codigo)
            Me.ToolBar1.Enabled = False
            Me.tb_clasificacion.ReadOnly = False
            Me.tb_codigo.Enabled = False
            Me.tb_direccion.ReadOnly = False
            Me.tb_email.ReadOnly = False
            Me.tb_fax.ReadOnly = False
            Me.tb_representante.ReadOnly = False
            Me.tb_telefono1.ReadOnly = False
            Me.tb_telefono2.ReadOnly = False
            Me.tb_nombre.ReadOnly = False
            Me.TextBox1.ReadOnly = False
            Me.TextBox2.ReadOnly = False
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.DGV_Proveedores.Enabled = False
            DGV_Proveedores.ClearSelection()

        ElseIf e.Button Is Me.bt_modificar Then

            varboton = 2
            Dim n1 As Integer
            n1 = Me.DGV_Proveedores.SelectedRows.Count
            If n1 = 1 Then
                'DatosProveedor.Llenar_DGV(CInt(DGV_Proveedores.SelectedRows(0).Cells(0).Value), DGV_Asociacion)
                'DatosPedidosCompras.Consulta_Moneda(cb_moneda)
                anterior = tb_buscarcodigo.Text
                anterior2 = DomainUpDown1.SelectedIndex
                DGV_Proveedores.Enabled = False
                Sp_ConsultaProductosProveedoresTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosProveedores, CInt(DGV_Proveedores.SelectedRows(0).Cells(0).Value), 0)
                CrearWhere()
                tb_codigoFabrica.ReadOnly = False
                tb_var1.ReadOnly = False
                tb_var2.ReadOnly = False
                bt_agregarCodigo.Enabled = True
                cb_preferencia.Enabled = True
                bt_eliminarCodigo.Enabled = True
                'lbl_codigoFabrica.Enabled = True
                DomainUpDown1.Items.Add("Modelo")
                DomainUpDown1.Items.Add("Código Fábrica")
                DomainUpDown1.SelectedIndex = 0
                'Me.tb_buscarcodigo.Enabled = False
                'Me.DomainUpDown1.Enabled = False
                Me.ToolBar1.Enabled = False
                Me.tb_clasificacion.ReadOnly = False
                Me.tb_codigo.Enabled = False
                Me.tb_direccion.ReadOnly = False
                Me.tb_email.ReadOnly = False
                Me.tb_fax.ReadOnly = False
                Me.Tb_PersonaC2.ReadOnly = False
                Me.Tb_PersonaC.ReadOnly = False
                Me.tb_telefonoC2.ReadOnly = False
                Me.tb_telefonoC.ReadOnly = False
                Me.tb_representante.ReadOnly = False
                cb_moneda.Enabled = True
                Me.tb_telefono1.ReadOnly = False
                Me.tb_telefono2.ReadOnly = False
                Me.TextBox1.ReadOnly = False
                Me.TextBox2.ReadOnly = False
                Me.tb_nombre.ReadOnly = False
                'DGV_Asociacion.Enabled = True
                DGV_Asociacion.ClearSelection()
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                'DGV_Proveedores.Enabled = False
            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el proveedor que desea modificar", MsgBoxStyle.Critical, "Mensaje de Error")
            Else
                MsgBox("Solo puede modificar un proveedor a la vez", MsgBoxStyle.Critical, "Mensaje de Error")
            End If
            DGV_Proveedores.ClearSelection()

        ElseIf e.Button Is Me.bt_eliminar Then

            varboton = 3
            Dim n As Integer
            Dim response As MsgBoxResult
            Dim cod As Integer
            n = Me.DGV_Proveedores.SelectedRows.Count
            If n = 0 Then
                response = MsgBox("Debe seleccionar el proveedor que desea eliminar ", MsgBoxStyle.Critical, "Mensaje de Error")
            ElseIf n = 1 Then
                response = MsgBox("¿Confirma que desea eliminar el proveedor '" + DGV_Proveedores.SelectedRows(0).Cells(1).Value + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    cod = CInt(tb_codigo.Text)
                    Dim nombre As String = tb_nombre.Text

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                    '    DatosProveedor.elimina_proveedor_COMER(cod)
                    '    DatosProveedor.elimina_proveedor_DIST(cod)
                    '    DatosProveedor.elimina_proveedor_CONAVE(cod)

                    'Else
                    DatosProveedor.elimina_proveedor(cod)
                    'End If

                    MsgBox("El proveedor '" + nombre + "' Ha Sido Eliminado Exitosamente")

                    Me.tb_telefonoC.Clear()
                    Me.tb_telefonoC2.Clear()
                    Me.Tb_PersonaC.Clear()
                    Me.Tb_PersonaC2.Clear()
                    Me.tb_representante.Clear()
                    Me.tb_telefono1.Clear()
                    Me.tb_telefono2.Clear()
                    Me.tb_clasificacion.Clear()
                    Me.tb_fax.Clear()
                    Me.tb_nombre.Clear()
                    Me.tb_codigo.Clear()
                    Me.tb_direccion.Clear()
                    Me.tb_email.Clear()
                    Me.TextBox1.Clear()
                    Me.TextBox2.Clear()

                    'DGV_Asociacion.Rows.Clear()
                    SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
                    DGV_Asociacion.ClearSelection()
                    Dim cant As Integer = 0
                    DatosProveedor.consulta_proveedores(DGV_Proveedores)
                    Label2.Text = cant
            End If
            Else
                response = MsgBox("¿Confirma que desea eliminar estos (" + n.ToString + ") proveedores?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    Dim i As Integer = 0
                    Dim x As ListViewItem
                    For Each x In DGV_Proveedores.Rows
                        If DGV_Proveedores.Rows(i).Selected() Then
                            cod = CInt(DGV_Proveedores.Rows(i).Cells(0).Value)
                            DatosProveedor.elimina_proveedor(cod)
                        End If
                        i = i + 1
                    Next
                    MsgBox("Se han eliminado (" + n.ToString + ") proveedores Exitosamente")
                    'DGV_Asociacion.Rows.Clear()
                    SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
                    DGV_Asociacion.ClearSelection()
                    Dim cant As Integer = 0
                    DatosProveedor.consulta_proveedores(DGV_Proveedores)
                    Label2.Text = cant
                End If
            End If
            Me.tb_telefono2.Clear()
            Me.tb_telefono1.Clear()
            Me.tb_representante.Clear()
            Me.tb_nombre.Clear()
            Me.tb_fax.Clear()
            Me.tb_email.Clear()
            Me.tb_direccion.Clear()
            Me.tb_codigo.Clear()
            Me.tb_clasificacion.Clear()
            DGV_Proveedores.ClearSelection()
        End If
    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        DomainUpDown1.Items.RemoveAt(2)
        DomainUpDown1.Items.RemoveAt(2)
        Me.DomainUpDown1.SelectedIndex = 0
        tb_codigoFabrica.Clear()
        tb_var1.Clear()
        tb_var2.Clear()
        bt_eliminarCodigo.Enabled = False
        bt_agregarCodigo.Enabled = False
        'lbl_codigoFabrica.Enabled = False
        tb_codigoFabrica.ReadOnly = True
        tb_var1.ReadOnly = True
        Me.tb_telefonoC.Clear()
        Me.tb_telefonoC2.Clear()
        DatosPedidosCompras.Consulta_Moneda(cb_moneda)
        cb_moneda.Text = ""
        DatosProveedor.Consulta_preferencia(cb_preferencia)
        cb_preferencia.Text = ""
        cb_preferencia.Enabled = False
        cb_moneda.Enabled = False
        Me.Tb_PersonaC.Clear()
        Me.Tb_PersonaC2.Clear()
        Me.Tb_PersonaC2.ReadOnly = True
        Me.Tb_PersonaC.ReadOnly = True
        Me.tb_telefonoC2.ReadOnly = True
        Me.tb_telefonoC.ReadOnly = True
        tb_var2.ReadOnly = True
        Me.tb_buscarcodigo.Enabled = True
        Me.DomainUpDown1.Enabled = True
        Me.ToolBar1.Enabled = True
        Me.tb_clasificacion.Clear()
        Me.tb_codigo.Clear()
        Me.tb_direccion.Clear()
        Me.tb_email.Clear()
        Me.tb_fax.Clear()
        Me.tb_representante.Clear()
        Me.tb_telefono1.Clear()
        Me.tb_telefono2.Clear()
        Me.tb_nombre.Clear()
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        'DGV_Asociacion.Enabled = False
        Me.tb_clasificacion.ReadOnly = True
        Me.tb_codigo.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_email.ReadOnly = True
        Me.tb_fax.ReadOnly = True
        Me.tb_representante.ReadOnly = True
        Me.tb_telefono1.ReadOnly = True
        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True
        Me.tb_telefono2.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.DomainUpDown1.SelectedIndex = anterior2
        Me.tb_buscarcodigo.Text = anterior
        'DGV_Asociacion.Rows.Clear()
        Me.tb_buscarcodigo.Focus()
        DGV_Asociacion.ClearSelection()
        DGV_Proveedores.Enabled = True
        SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
        Me.tb_buscarcodigo.SelectAll()
        'DatosProveedor.consulta_proveedores(DGV_Proveedores)
        'DGV_Proveedores.ClearSelection()

    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_nombre.Text = "" Or Me.tb_telefono1.Text = "" Or Me.cb_moneda.Text = "" Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim deny As Boolean = False
        If (varboton = 1) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else

                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                '    DatosProveedor.inserta_proveedor_COMER(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)
                '    DatosProveedor.inserta_proveedor_DIST(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)
                '    DatosProveedor.inserta_proveedor_CONAVE(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)

                '    If Not cb_preferencia.SelectedIndex = -1 Then
                '        DatosProveedor.inserta_Preferencias_proveedores(CInt(tb_codigo.Text), CInt(cb_preferencia.Items.Item(Me.cb_preferencia.SelectedIndex).Code))
                '    End If

                '    'DGV_Asociacion.Rows.Clear()
                '    SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
                '    DGV_Asociacion.ClearSelection()

                '    MsgBox("El Proveedor Ha Sido Registrado Exitosamente", MsgBoxStyle.Information)

                '    bt_eliminarCodigo.Enabled = False
                '    bt_agregarCodigo.Enabled = False
                '    'lbl_codigoFabrica.Enabled = False
                '    tb_codigoFabrica.ReadOnly = True
                '    tb_var1.ReadOnly = True
                '    tb_var2.ReadOnly = True
                '    tb_codigoFabrica.Clear()
                '    tb_var1.Clear()
                '    tb_var2.Clear()
                '    DomainUpDown1.Items.RemoveAt(2)
                '    DomainUpDown1.Items.RemoveAt(2)
                '    Me.DomainUpDown1.Text = "Código"
                '    deny = False

                'Else

                DatosProveedor.inserta_proveedor(Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)

                If Not cb_preferencia.SelectedIndex = -1 Then
                    DatosProveedor.inserta_Preferencias_proveedores(CInt(tb_codigo.Text), CInt(cb_preferencia.Items.Item(Me.cb_preferencia.SelectedIndex).Code))
                End If

                'DGV_Asociacion.Rows.Clear()
                SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
                DGV_Asociacion.ClearSelection()

                Dim a As Integer = MsgBox("El Proveedor Ha Sido Registrado Exitosamente, desea asociar productos a este proveedor?", MsgBoxStyle.YesNo)
                If a = vbNo Then

                    bt_eliminarCodigo.Enabled = False
                    bt_agregarCodigo.Enabled = False
                    'lbl_codigoFabrica.Enabled = False
                    tb_codigoFabrica.ReadOnly = True
                    tb_var1.ReadOnly = True
                    tb_var2.ReadOnly = True
                    tb_codigoFabrica.Clear()
                    tb_var1.Clear()
                    tb_var2.Clear()
                    DomainUpDown1.Items.RemoveAt(2)
                    DomainUpDown1.Items.RemoveAt(2)
                    Me.DomainUpDown1.Text = "Código"
                    deny = False

                Else

                    Me.tb_buscarcodigo.Enabled = True
                    bt_eliminarCodigo.Enabled = True
                    bt_agregarCodigo.Enabled = True
                    'lbl_codigoFabrica.Enabled = True
                    tb_codigoFabrica.ReadOnly = False
                    tb_var1.ReadOnly = False
                    tb_var2.ReadOnly = False
                    'DGV_Asociacion.Enabled = True
                    'DatosProveedor.Llenar_DGV(CInt(tb_codigo.Text), DGV_Asociacion)
                    Me.Sp_ConsultaProductosProveedoresTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosProveedores, -1, 0)
                    CrearWhere()
                    deny = True
                    varboton = 2

                    'End If

                End If

            End If

        ElseIf (varboton = 2) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else

                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                '    DatosProveedor.modifica_proveedor_COMER(Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.tb_codigo.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)
                '    DatosProveedor.modifica_proveedor_DIST(Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.tb_codigo.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)
                '    DatosProveedor.modifica_proveedor_CONAVE(Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.tb_codigo.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)
                '    MsgBox("El Proveedor Ha Sido Modificado Exitosamente")

                'Else

                DatosProveedor.modifica_proveedor(Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, Me.tb_codigo.Text, Me.TextBox1.Text, Me.TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda.Text)

                'End If

                bt_eliminarCodigo.Enabled = False

                DatosProveedor.elimina_Preferencias_proveedores(CInt(tb_codigo.Text))

                If Not cb_preferencia.SelectedIndex = -1 Then
                    DatosProveedor.inserta_Preferencias_proveedores(CInt(tb_codigo.Text), CInt(cb_preferencia.Items.Item(Me.cb_preferencia.SelectedIndex).Code))
                End If

                bt_agregarCodigo.Enabled = False
                'lbl_codigoFabrica.Enabled = False
                tb_codigoFabrica.ReadOnly = True
                tb_var1.ReadOnly = True
                tb_var2.ReadOnly = True
                tb_codigoFabrica.Clear()
                tb_var1.Clear()
                tb_var2.Clear()
                'DGV_Asociacion.Enabled = False
                DomainUpDown1.Items.RemoveAt(2)
                DomainUpDown1.Items.RemoveAt(2)
                Me.DomainUpDown1.Text = "Código"
                'DGV_Asociacion.Rows.Clear()
        End If

        End If

        If deny = False Then
            Me.tb_buscarcodigo.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.ToolBar1.Enabled = True
            Me.tb_clasificacion.Clear()
            tb_codigoFabrica.Clear()
            tb_var1.Clear()
            DGV_Proveedores.Enabled = True
            tb_var2.Clear()
            Me.tb_codigo.Clear()
            Me.tb_direccion.Clear()
            Me.tb_email.Clear()
            Me.tb_fax.Clear()
            Me.tb_telefonoC.Clear()
            Me.tb_telefonoC2.Clear()
            Me.Tb_PersonaC.Clear()
            DatosPedidosCompras.Consulta_Moneda(cb_moneda)
            cb_moneda.Text = ""
            cb_moneda.Enabled = False
            Me.Tb_PersonaC2.Clear()
            Me.Tb_PersonaC2.ReadOnly = True
            Me.Tb_PersonaC.ReadOnly = True
            Me.tb_telefonoC2.ReadOnly = True
            Me.tb_telefonoC.ReadOnly = True
            Me.tb_representante.Clear()
            Me.tb_telefono1.Clear()
            Me.tb_telefono2.Clear()
            Me.tb_nombre.Clear()
            DatosProveedor.Consulta_preferencia(cb_preferencia)
            cb_preferencia.Text = ""
            cb_preferencia.Enabled = False
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
            Me.tb_clasificacion.ReadOnly = True
            Me.TextBox1.ReadOnly = True
            Me.TextBox2.ReadOnly = True
            Me.tb_codigo.ReadOnly = True
            Me.tb_direccion.ReadOnly = True
            Me.tb_email.ReadOnly = True
            Me.tb_fax.ReadOnly = True
            Me.tb_representante.ReadOnly = True
            Me.tb_telefono1.ReadOnly = True
            Me.tb_telefono2.ReadOnly = True
            Me.tb_nombre.ReadOnly = True
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Sp_ConsultaProductosProveedoresTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosProveedores, -1, 0)
            SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
            DatosProveedor.consulta_proveedores(DGV_Proveedores)
            Me.DomainUpDown1.SelectedIndex = anterior2
            Me.tb_buscarcodigo.Text = anterior
            Me.tb_buscarcodigo.SelectAll()
            DGV_Proveedores.ClearSelection()
            Me.tb_buscarcodigo.Focus()
        End If
    End Sub


    'Private Sub tb_buscarcodigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.Click
    '    DGV_Proveedores.ClearSelection()
    '    DGV_Asociacion.Rows.Clear()
    'End Sub

    Private Sub Form4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        DGV_Proveedores.ClearSelection()
    End Sub

    'Private Sub Form4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, groupbox1.Click, DomainUpDown1.Click, tb_buscarcodigo.Click, tb_clasificacion.Click, tb_codigo.Click, tb_direccion.Click, tb_email.Click, tb_fax.Click, tb_nombre.Click, tb_representante.Click, tb_telefono1.Click, tb_telefono2.Click, Label1.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label2.Click, Label21.Click, Label4.Click, Label5.Click, Label5.Click, Label9.Click, Label3.Click, Label17.Click, TextBox1.Click
    '    If Me.DGV_Proveedores.Enabled = True Then
    '        Me.tb_telefono2.Clear()
    '        Me.tb_telefono1.Clear()
    '        Me.tb_representante.Clear()
    '        Me.tb_nombre.Clear()
    '        Me.tb_fax.Clear()
    '        Me.tb_email.Clear()
    '        Me.tb_direccion.Clear()
    '        Me.tb_codigo.Clear()
    '        Me.tb_clasificacion.Clear()
    '    End If
    '    DGV_Proveedores.ClearSelection()
    'End Sub
    Public Sub DGV_Proveedores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Proveedores.CellClick, DGV_Proveedores.KeyUp, DGV_Proveedores.KeyDown
        If Not (DGV_Proveedores.SelectedRows.Count = 0) Then

            Dim cod As Integer = 0
            cod = CInt(DGV_Proveedores.SelectedRows(0).Cells(0).Value)
            DatosPedidosCompras.Consulta_Moneda(cb_moneda)
            cb_moneda.Text = ""
            DatosProveedor.consulta_proveedor(cod, Me.tb_codigo.Text, Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, TextBox1.Text, TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda)
            Sp_ConsultaProductosProveedoresTableAdapter.Fill(Me.MELDataSet.sp_ConsultaProductosProveedores, CInt(DGV_Proveedores.SelectedRows(0).Cells(0).Value), 1)
            Me.SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor LIKE '%" & DGV_Proveedores.SelectedRows(0).Cells(0).Value.ToString & DGV_Proveedores.SelectedRows(0).Cells(1).Value.ToString & "%'"
            'DatosProveedor.Llenar_DGV_Productos_Por_Proveedor(tb_codigo.Text(), DGV_Asociacion)
            DGV_Asociacion.ClearSelection()
            DatosProveedor.Consulta_preferencia(cb_preferencia)
            cb_preferencia.Text = ""
            DatosProveedor.consultaPreferenciaProveedor(cb_preferencia, CInt(tb_codigo.Text))

        End If
    End Sub
    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If DGV_Proveedores.Enabled = True Then
            Dim s1 As String
            s1 = Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then
                DatosProveedor.lv_Proveedor(DGV_Proveedores, s1, 0)
                'DGV_Asociacion.Rows.Clear()
            ElseIf choice = 1 Then
                DatosProveedor.lv_Proveedor(DGV_Proveedores, s1, 1)
                'DGV_Asociacion.Rows.Clear()
            End If

            DGV_Proveedores.ClearSelection()

            Me.tb_telefonoC.Clear()
            Me.tb_telefonoC2.Clear()
            Me.Tb_PersonaC.Clear()
            Me.Tb_PersonaC2.Clear()
            Me.tb_representante.Clear()
            Me.tb_telefono1.Clear()
            Me.tb_telefono2.Clear()
            Me.tb_clasificacion.Clear()
            Me.tb_fax.Clear()
            Me.tb_nombre.Clear()
            Me.tb_codigo.Clear()
            Me.tb_direccion.Clear()
            Me.tb_email.Clear()
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()

            DatosPedidosCompras.Consulta_Moneda(cb_moneda)
            cb_moneda.Text = ""
            DatosProveedor.Consulta_preferencia(cb_preferencia)
            cb_preferencia.Text = ""

            'DGV_Asociacion.Rows.Clear()
            SpConsultaProductosProveedoresBindingSource.Filter = "Proveedor = '-1'"
            DGV_Asociacion.ClearSelection()

        Else

            'If DomainUpDown1.Text = "Código" Then

            '    If tb_buscarcodigo.Text <> "" Then
            '        DatosProveedor.Llenar_DGV_Like1(tb_buscarcodigo.Text, CInt(tb_codigo.Text), DGV_Asociacion)
            '    Else
            '        DatosProveedor.Llenar_DGV(tb_codigo.Text, DGV_Asociacion)
            '    End If

            'ElseIf DomainUpDown1.Text = "Nombre" Then

            '    If tb_buscarcodigo.Text <> "" Then
            '        DatosProveedor.Llenar_DGV_Like2(tb_buscarcodigo.Text, CInt(tb_codigo.Text), DGV_Asociacion)
            '    Else
            '        DatosProveedor.Llenar_DGV(tb_codigo.Text, DGV_Asociacion)
            '    End If

            'ElseIf DomainUpDown1.Text = "Modelo" Then

            '    If tb_buscarcodigo.Text <> "" Then
            '        DatosProveedor.Llenar_DGV_Like3(tb_buscarcodigo.Text, CInt(tb_codigo.Text), DGV_Asociacion)
            '    Else
            '        DatosProveedor.Llenar_DGV(tb_codigo.Text, DGV_Asociacion)
            '    End If

            'ElseIf DomainUpDown1.Text = "Código Fábrica" Then

            '    If tb_buscarcodigo.Text <> "" Then
            '        DatosProveedor.Llenar_DGV_Like4(tb_buscarcodigo.Text, CInt(tb_codigo.Text), DGV_Asociacion)
            '    Else
            '        DatosProveedor.Llenar_DGV(tb_codigo.Text, DGV_Asociacion)
            '    End If

            'End If

            CrearWhere()

        End If

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged

        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub
    Public Sub abreM(ByVal cod As Integer, ByVal ind As Integer)
        swC = True
        indice = ind
        Dim sw2 As Boolean = False
        Dim cont As Integer = 0
        While (cont <= DGV_Proveedores.Rows.Count) And (sw2 = False)
            If CInt(Me.DGV_Proveedores.Rows(cont).Cells(0).Value) = cod Then
                sw2 = True
            Else
                cont = cont + 1
            End If
        End While
        Me.DGV_Proveedores.Rows(cont).Selected = True
        DatosProveedor.consulta_proveedor(cod, Me.tb_codigo.Text, Me.tb_nombre.Text, Me.tb_telefono1.Text, Me.tb_telefono2.Text, Me.tb_fax.Text, Me.tb_email.Text, Me.tb_representante.Text, Me.tb_direccion.Text, Me.tb_clasificacion.Text, TextBox1.Text, TextBox2.Text, Tb_PersonaC.Text, tb_telefonoC.Text, Tb_PersonaC2.Text, tb_telefonoC2.Text, cb_moneda)
        Me.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Me.bt_modificar))
    End Sub

    '-------------------------- VALIDACIONES
    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = ")" Or e.KeyChar = "(" Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números, () y ."
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width - 110, c.Location.Y + 55)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub
    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        muestra_label(sender, 1)
    End Sub

    Private Sub tb_clasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "a" Or e.KeyChar = "b" Or e.KeyChar = "c" Or Char.IsControl(e.KeyChar) Or e.KeyChar = "A" Or e.KeyChar = "B" Or e.KeyChar = "C" Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
        Me.Label22.Text = "      Ingrese sólo A,B ó C"
    End Sub
    Public Sub nuevo()
        swX = True
    End Sub

    Private Sub DGV_Asociacion_CellClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_Asociacion.CellClick, DGV_Asociacion.KeyDown, DGV_Asociacion.KeyUp

        Try

            If varboton = 2 Then

                tb_codigoFabrica.Text = DGV_Asociacion.SelectedRows(0).Cells(3).Value
                tb_var1.Text = DGV_Asociacion.SelectedRows(0).Cells(4).Value
                tb_var2.Text = DGV_Asociacion.SelectedRows(0).Cells(5).Value

            End If

        Catch ex As Exception

            tb_var1.Text = ""
            tb_var2.Text = ""

        End Try

    End Sub

    Private Sub bt_agregarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCodigo.Click

        If DGV_Asociacion.SelectedRows.Count > 0 Then

            If My.Settings.Empresa = 1 Then

                If DGV_Asociacion.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then

                    DatosProveedor.InsertarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)
                    DatosProveedor.InsertarCodigoFabrica_CONAVE(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)

                ElseIf DGV_Asociacion.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then

                    DatosProveedor.InsertarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)
                    DatosProveedor.InsertarCodigoFabrica_DIST(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)

                Else

                    DatosProveedor.InsertarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)

                End If

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo registrado satisfactoriamente", ToolTipIcon.Info)

            Else

                DatosProveedor.InsertarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text, tb_codigoFabrica.Text, tb_var1.Text, tb_var2.Text)

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo registrado satisfactoriamente", ToolTipIcon.Info)

            End If

            DGV_Asociacion.SelectedRows(0).Cells(3).Value = tb_codigoFabrica.Text
            tb_codigoFabrica.Clear()
            tb_var1.Clear()
            tb_var2.Clear()
            'DGV_Asociacion.Rows.Clear()
            'tb_buscarcodigo.Clear()
            'DatosProveedor.Llenar_DGV(CInt(tb_codigo.Text), DGV_Asociacion)
            DGV_Asociacion.Focus()
            DGV_Asociacion.CurrentRow.Selected = True

        End If

    End Sub

    Private Sub bt_eliminarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCodigo.Click

        If DGV_Asociacion.SelectedRows.Count > 0 Then

            If My.Settings.Empresa = 1 Then

                If DGV_Asociacion.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then

                    DatosProveedor.EliminarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)
                    DatosProveedor.EliminarCodigoFabrica_CONAVE(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)

                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Código Fábrica Eliminado", ToolTipIcon.Info)

                ElseIf DGV_Asociacion.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then

                    DatosProveedor.EliminarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)
                    DatosProveedor.EliminarCodigoFabrica_DIST(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)

                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Código Fábrica Eliminado", ToolTipIcon.Info)

                Else

                    DatosProveedor.EliminarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)

                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo registrado satisfactoriamente", ToolTipIcon.Info)

                End If

            Else

                DatosProveedor.EliminarCodigoFabrica(DGV_Asociacion.SelectedRows(0).Cells(0).Value, tb_codigo.Text)

                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Codigo registrado satisfactoriamente", ToolTipIcon.Info)

            End If

            DGV_Asociacion.SelectedRows(0).Cells(3).Value = ""
            tb_codigoFabrica.Clear()
            tb_var1.Clear()
            tb_var2.Clear()
            tb_buscarcodigo.Clear()
            DGV_Asociacion.Focus()

        End If

    End Sub

    Private Sub DGV_Proveedores_RowsAdded(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Proveedores.RowsAdded, DGV_Proveedores.RowsRemoved
        Label2.Text = DGV_Proveedores.RowCount
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DGV_Proveedores.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then
                If DGV_Proveedores.Enabled = True Then
                    Me.DGV_Proveedores.Rows(0).Cells(0).Selected = True
                    DGV_Proveedores.Focus()
                Else
                    Me.DGV_Asociacion.Rows(0).Cells(0).Selected = True
                    DGV_Asociacion.Focus()
                End If

            End If
        End If


    End Sub

    Public Shared Sub DGV_Productos_Inventario2(ByRef DGV2 As DataGridView)

        Try

            Dim CONT As Integer = 0

            Dim anterior As String = ""

            Dim colec As New Collection
            Dim colec2 As New Collection

            Dim cont4 As Integer = 0
            Dim sw As Boolean = False


            While CONT <= DGV2.RowCount - 1

                If anterior = CStr(DGV2.Rows(CONT).Cells(0).Value) Then

                    cont4 = cont4 + 1
                    If cont4 > 1 Then
                        sw = True
                    End If

                    Dim CeldaModelo As New DataGridViewComboBoxCell
                    Dim CeldaCodF As New DataGridViewTextBoxCell
                    Dim CeldaVar1 As New DataGridViewTextBoxCell
                    Dim CeldaVaR2 As New DataGridViewTextBoxCell
                    Dim CeldaCod As New DataGridViewTextBoxCell
                    Dim CeldaDesc As New DataGridViewTextBoxCell
                    Dim fila As New DataGridViewRow
                    Dim esta As Boolean = False
                    Dim esta2 As Boolean = False



                    For cont5 As Integer = 1 To colec.Count
                        If CStr(DGV2.Rows(CONT - 1).Cells(2).Value).Equals(CStr(colec.Item(cont5)), StringComparison.CurrentCultureIgnoreCase) Then
                            esta = True
                        End If
                        If CStr(DGV2.Rows(CONT).Cells(2).Value).Equals(CStr(colec.Item(cont5)), StringComparison.CurrentCultureIgnoreCase) Then
                            esta2 = True
                        End If
                    Next

                    If esta = False Then
                        colec.Add(DGV2.Rows(CONT - 1).Cells(2).Value.ToString)
                    End If
                    If esta2 = False Then
                        colec.Add(DGV2.Rows(CONT).Cells(2).Value.ToString)
                    End If

                    CeldaCod.Value = DGV2.Rows(CONT).Cells(0).Value
                    fila.Cells.Add(CeldaCod)
                    CeldaCod.ReadOnly = True
                    CeldaDesc.Value = DGV2.Rows(CONT).Cells(1).Value
                    fila.Cells.Add(CeldaDesc)
                    CeldaDesc.ReadOnly = True

                    If sw Then

                        Dim cont3 As Integer = 0

                        For cont3 = 1 To colec.Count

                            CeldaModelo.Items.Add(colec.Item(cont3).ToString)

                        Next

                    Else

                        CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(2).Value)
                        CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(2).Value)

                    End If

                    CeldaModelo.Sorted = True
                    CeldaModelo.Value = CeldaModelo.Items(CeldaModelo.Items.Count - 1)

                    fila.Cells.Add(CeldaModelo)
                    CeldaModelo.ReadOnly = False

                    CeldaCodF.Value = DGV2.Rows(CONT).Cells(3).Value
                    fila.Cells.Add(CeldaCodF)
                    CeldaCodF.ReadOnly = True

                    CeldaVar1.Value = DGV2.Rows(CONT).Cells(4).Value
                    fila.Cells.Add(CeldaVar1)
                    CeldaVar1.ReadOnly = True

                    CeldaVaR2.Value = DGV2.Rows(CONT).Cells(5).Value
                    fila.Cells.Add(CeldaVaR2)
                    CeldaVaR2.ReadOnly = True

                    DGV2.Rows.Add(fila)
                    DGV2.Rows.RemoveAt(CONT)
                    DGV2.Rows.RemoveAt(CONT - 1)
                    DGV2.Sort(DGV2.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                    CONT = CONT - 1

                Else

                    DGV2.Rows(CONT).Cells(2).ReadOnly = True
                    cont4 = 0
                    sw = False
                    colec.Clear()
                    colec2.Clear()

                End If

                anterior = CStr(DGV2.Rows(CONT).Cells(0).Value)

                CONT = CONT + 1

            End While

        Catch ex As Exception

            MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub CrearWhere()

        'Sp_infoGeneralComprasBindingSource.ResetBindings(True)
        Dim where As String = ""
        Dim y As String = ""

        If tb_buscarcodigo.Text <> "" Then

            If DomainUpDown1.SelectedIndex = 0 Then

                where = where + "CodigoInterno LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 1 Then

                where = where + "Descripcion LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 2 Then

                where = where + "Modelo LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 3 Then

                where = where + "CodigoProductoF LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            End If

        End If

        Me.SpConsultaProductosProveedoresBindingSource.Filter = where

        DGV_Asociacion.ClearSelection()

    End Sub
End Class