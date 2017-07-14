Public Class Frm_Grupos
    Inherits System.Windows.Forms.Form
    'Private Tabla As New DataTable("tablita")
    Private sw0 As Boolean = False
    Private sw As Boolean = False
    Private sw1 As Boolean = False
    Private l As New Collection
    Private lelim As New Collection
    Private agr As New Collection
    Private eli As New Collection
    Dim cMod As New Collection
    Private item As Object
    Private cuantos As Integer
    Private fila As Integer
    Private boton As String = ""
    Private choice As Integer
    Dim w As Boolean
    Dim e As Boolean
    Friend WithEvents Dgv_Grupos As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv_GruposProductosAsociados As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents rb_ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpconsultaProductosGruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaProductosGruposTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosGruposTableAdapter
    Friend WithEvents CHKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GruposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Grupos))
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.rb_ninguno = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.Dgv_GruposProductosAsociados = New System.Windows.Forms.DataGridView
        Me.CHKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GruposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaProductosGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.Dgv_Grupos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Sp_consultaProductosGruposTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosGruposTableAdapter
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.groupbox1.SuspendLayout()
        CType(Me.Dgv_GruposProductosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductosGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(339, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(555, 23)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Datos del Grupo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb_nombre)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 96)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "(*)Datos requeridos"
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(240, 56)
        Me.tb_nombre.MaxLength = 50
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(114, 22)
        Me.tb_nombre.TabIndex = 3
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(240, 24)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(116, 22)
        Me.tb_codigo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(152, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "(*)Nombre:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(152, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "(*)Código:"
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(169, 82)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(164, 24)
        Me.tb_buscarcodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 674)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(339, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(555, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Productos Asociados al Grupo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 3
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.rb_ninguno)
        Me.groupbox1.Controls.Add(Me.rb_todos)
        Me.groupbox1.Controls.Add(Me.Dgv_GruposProductosAsociados)
        Me.groupbox1.Controls.Add(Me.bt_cancelar)
        Me.groupbox1.Controls.Add(Me.bt_aceptar)
        Me.groupbox1.Location = New System.Drawing.Point(339, 149)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(555, 564)
        Me.groupbox1.TabIndex = 47
        Me.groupbox1.TabStop = False
        '
        'rb_ninguno
        '
        Me.rb_ninguno.AutoSize = True
        Me.rb_ninguno.Location = New System.Drawing.Point(89, 19)
        Me.rb_ninguno.Name = "rb_ninguno"
        Me.rb_ninguno.Size = New System.Drawing.Size(78, 19)
        Me.rb_ninguno.TabIndex = 93
        Me.rb_ninguno.TabStop = True
        Me.rb_ninguno.Text = "Ninguno"
        Me.rb_ninguno.UseVisualStyleBackColor = True
        Me.rb_ninguno.Visible = False
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Location = New System.Drawing.Point(13, 19)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(61, 19)
        Me.rb_todos.TabIndex = 92
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        Me.rb_todos.Visible = False
        '
        'Dgv_GruposProductosAsociados
        '
        Me.Dgv_GruposProductosAsociados.AllowUserToAddRows = False
        Me.Dgv_GruposProductosAsociados.AllowUserToDeleteRows = False
        Me.Dgv_GruposProductosAsociados.AllowUserToResizeColumns = False
        Me.Dgv_GruposProductosAsociados.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_GruposProductosAsociados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.Dgv_GruposProductosAsociados.AutoGenerateColumns = False
        Me.Dgv_GruposProductosAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_GruposProductosAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHKDataGridViewTextBoxColumn, Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.GruposDataGridViewTextBoxColumn, Me.Marca})
        Me.Dgv_GruposProductosAsociados.DataSource = Me.SpconsultaProductosGruposBindingSource
        Me.Dgv_GruposProductosAsociados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Dgv_GruposProductosAsociados.Location = New System.Drawing.Point(10, 44)
        Me.Dgv_GruposProductosAsociados.MultiSelect = False
        Me.Dgv_GruposProductosAsociados.Name = "Dgv_GruposProductosAsociados"
        Me.Dgv_GruposProductosAsociados.RowHeadersVisible = False
        Me.Dgv_GruposProductosAsociados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_GruposProductosAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_GruposProductosAsociados.Size = New System.Drawing.Size(536, 468)
        Me.Dgv_GruposProductosAsociados.TabIndex = 91
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
        Me.CHKDataGridViewTextBoxColumn.Width = 24
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo I."
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 164
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 110
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle17.Format = "#,##0.00"
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 70
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "Cant."
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Width = 47
        '
        'GruposDataGridViewTextBoxColumn
        '
        Me.GruposDataGridViewTextBoxColumn.DataPropertyName = "Grupos"
        Me.GruposDataGridViewTextBoxColumn.HeaderText = "Grupos"
        Me.GruposDataGridViewTextBoxColumn.Name = "GruposDataGridViewTextBoxColumn"
        Me.GruposDataGridViewTextBoxColumn.ReadOnly = True
        Me.GruposDataGridViewTextBoxColumn.Visible = False
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Visible = False
        '
        'SpconsultaProductosGruposBindingSource
        '
        Me.SpconsultaProductosGruposBindingSource.DataMember = "sp_consultaProductosGrupos"
        Me.SpconsultaProductosGruposBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(295, 531)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancelar.TabIndex = 5
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(197, 531)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 4
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 674)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 42
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
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(12, 7)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(309, 65)
        Me.ToolBar1.TabIndex = 43
        '
        'Dgv_Grupos
        '
        Me.Dgv_Grupos.AllowUserToAddRows = False
        Me.Dgv_Grupos.AllowUserToDeleteRows = False
        Me.Dgv_Grupos.AllowUserToResizeColumns = False
        Me.Dgv_Grupos.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Grupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.Dgv_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Dgv_Grupos.Location = New System.Drawing.Point(12, 115)
        Me.Dgv_Grupos.MultiSelect = False
        Me.Dgv_Grupos.Name = "Dgv_Grupos"
        Me.Dgv_Grupos.ReadOnly = True
        Me.Dgv_Grupos.RowHeadersVisible = False
        Me.Dgv_Grupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Grupos.Size = New System.Drawing.Size(321, 556)
        Me.Dgv_Grupos.TabIndex = 91
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.0!)
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(12, 82)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(151, 26)
        Me.DomainUpDown1.TabIndex = 92
        '
        'Sp_consultaProductosGruposTableAdapter
        '
        Me.Sp_consultaProductosGruposTableAdapter.ClearBeforeFill = True
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(833, 141)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(14, 14)
        Me.lb_total.TabIndex = 10030
        Me.lb_total.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(792, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 14)
        Me.Label17.TabIndex = 10029
        Me.Label17.Text = "Total:"
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.BackColor = System.Drawing.Color.DodgerBlue
        Me.chk_exist.Enabled = False
        Me.chk_exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.chk_exist.ForeColor = System.Drawing.Color.White
        Me.chk_exist.Location = New System.Drawing.Point(352, 139)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(73, 18)
        Me.chk_exist.TabIndex = 10031
        Me.chk_exist.Text = "Exist. > 0"
        Me.chk_exist.UseVisualStyleBackColor = False
        '
        'Frm_Grupos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(897, 714)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.chk_exist)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_Grupos)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(50, 150)
        Me.MaximizeBox = False
        Me.Name = "Frm_Grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Grupos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        CType(Me.Dgv_GruposProductosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductosGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Grupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.tb_codigo.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False

        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0

        DatosGrupos.Consultar_Grupos(Dgv_Grupos, 0)
        Label2.Text = Me.Dgv_Grupos.RowCount



        DomainUpDown1.SelectedIndex = 0

        Sp_consultaProductosGruposTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosGrupos, -1)
        CrearWhere()

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

            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then

            Me.DomainUpDown1.Items.Add("Marca")
            Me.DomainUpDown1.Items.Add("Modelo")
            Me.DomainUpDown1.Items.Add("Existencia")
            Me.DomainUpDown1.SelectedIndex = 0
            Dgv_GruposProductosAsociados.Visible = True
            boton = "n"
            Me.tb_codigo.Clear()
            Me.tb_nombre.Clear()
            Me.rb_ninguno.Visible = True
            Me.rb_todos.Visible = True
            Me.tb_codigo.Enabled = False
            chk_exist.Enabled = True 
            Me.tb_nombre.ReadOnly = False
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.ToolBar1.Enabled = False
            DatosGrupos.identidad_Grupo(Me.tb_codigo)
            Dgv_Grupos.ClearSelection()
            Dgv_Grupos.Enabled = False
            'Tabla.Clear()
            'Dgv_GruposProductosAsociados.Rows.Clear()
            'AddData2()
            Sp_consultaProductosGruposTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosGrupos, -1)
            Dgv_GruposProductosAsociados.Columns(0).Visible = True
            CrearWhere()
            limpiacolec(l)

            Me.DomainUpDown1.SelectedIndex = 0
            RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.tb_buscarcodigo.Clear()
            AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.tb_nombre.Focus()


        ElseIf e.Button Is Me.bt_modificar Then

            Me.DomainUpDown1.Items.Add("Marca")
            Me.DomainUpDown1.Items.Add("Modelo")
            Me.DomainUpDown1.Items.Add("Existencia")
            Dim n1 As Integer
            n1 = Dgv_Grupos.SelectedRows.Count

            If n1 = 1 Then

                Dgv_GruposProductosAsociados.Columns(0).Visible = True
                boton = "m"
                Me.Dgv_GruposProductosAsociados.Enabled = True
                Me.tb_codigo.Enabled = False
                chk_exist.Enabled = True
                Me.tb_nombre.ReadOnly = False
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.rb_ninguno.Visible = True
                Me.rb_todos.Visible = True
                Me.Dgv_Grupos.Enabled = False

                Me.ToolBar1.Enabled = False
                'Tabla.Clear()
                'Dgv_GruposProductosAsociados.Rows.Clear()
                'AddData3()
                Sp_consultaProductosGruposTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosGrupos, CInt(Dgv_Grupos.SelectedRows(0).Cells(0).Value))
                SpconsultaProductosGruposBindingSource.Filter = ""
                Me.DomainUpDown1.SelectedIndex = 0
                RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                Me.tb_buscarcodigo.Clear()
                AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                Me.tb_nombre.Focus()
                Dgv_Grupos.Enabled = False


            ElseIf n1 = 0 Then

                MsgBox("Debe seleccionar el grupo que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")

            Else

                MsgBox("Sólo puede modificar un grupo a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")

            End If

            Me.Dgv_Grupos.ClearSelection()

            Dim cc As Integer

            For cc = 0 To Dgv_GruposProductosAsociados.RowCount - 1

                If Dgv_GruposProductosAsociados.Rows(cc).Cells(0).Value = True Then

                    cMod.Add(Dgv_GruposProductosAsociados.Rows(cc).Cells(1).Value)

                End If

            Next

        ElseIf e.Button Is Me.bt_eliminar Then

            Dim n2 As Integer
            Dim cod As Integer
            Dim response As MsgBoxResult

            n2 = Dgv_Grupos.SelectedRows.Count

            If n2 = 0 Then
                MsgBox("Debe seleccionar el grupo que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            ElseIf n2 = 1 Then

                response = MsgBox("¿Confirma que desea eliminar el grupo '" + Dgv_Grupos.SelectedRows(0).Cells(0).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")

                If (response = MsgBoxResult.Yes) Then

                    cod = CInt(Dgv_Grupos.SelectedRows(0).Cells(0).Value)

                    'Dim i As Integer

                    'For i = 0 To Dgv_GruposProductosAsociados.RowCount - 1

                    '    If Dgv_GruposProductosAsociados.Rows(i).Cells(0).Value = True Then

                    DatosGrupos.Eliminar_Productos_Grupo(cod)

                    'End If

                    'Next

                    DatosGrupos.elimina_grupo(cod)

                    MsgBox("El Grupo '" + Dgv_Grupos.SelectedRows(0).Cells(0).Value.ToString + "' Ha Sido Eliminado Exitosamente")

                    Me.Dgv_Grupos.Rows.Clear()
                    DatosGrupos.Consultar_Grupos(Dgv_Grupos, 0)
                    'dg()
                    Label2.Text = Me.Dgv_Grupos.Rows.Count
                    'Tabla.Clear()
                    'Dgv_GruposProductosAsociados.Rows.Clear()
                    CrearWhere()
                    Me.tb_nombre.Clear()
                    Me.tb_codigo.Clear()
                    Me.tb_buscarcodigo.Text = ""
                    Me.tb_buscarcodigo.Focus()

                End If

            Else

                response = MsgBox("¿Confirma que desea eliminar estos (" + n2.ToString + ") grupos?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then

                    Dim i As Integer = 0

                    MsgBox("Se han eliminado (" + n2.ToString + ") Grupos Exitosamente")

                    'Tabla.Clear()
                    Dgv_GruposProductosAsociados.Rows.Clear()
                    Me.tb_nombre.Clear()
                    Me.tb_buscarcodigo.Text = ""
                    Me.tb_buscarcodigo.Focus()

                End If
            End If
        End If


    End Sub

    Private Sub AddData(ByVal codG As Integer)

        DatosGrupos.consulta_productos_Grupo(Dgv_GruposProductosAsociados, codG)

    End Sub

    Private Sub AddData2()

        DatosGrupos.consulta_productos_noGrupo(Dgv_GruposProductosAsociados, 0)
        Dgv_GruposProductosAsociados.Columns(0).Visible = True

    End Sub


    'Public Shared Sub DGV_Productos_Inventario2(ByRef DGV2 As DataGridView)

    '    Try

    '        Dim CONT As Integer = 0

    '        Dim anterior As String = ""

    '        Dim colec As New Collection

    '        Dim cont4 As Integer = 0
    '        Dim sw As Boolean = False


    '        While CONT <= DGV2.RowCount - 1

    '            If anterior = CStr(DGV2.Rows(CONT).Cells(1).Value) Then

    '                cont4 = cont4 + 1
    '                If cont4 > 1 Then
    '                    sw = True
    '                End If

    '                Dim CeldaModelo As New DataGridViewComboBoxCell
    '                Dim CeldaCheck As New DataGridViewCheckBoxCell
    '                Dim CeldaCod As New DataGridViewTextBoxCell
    '                Dim CeldaDesc As New DataGridViewTextBoxCell
    '                Dim CeldaPrecio As New DataGridViewTextBoxCell
    '                Dim CeldaExist As New DataGridViewTextBoxCell
    '                Dim fila As New DataGridViewRow

    '                colec.Add(DGV2.Rows(CONT - 1).Cells(3).Value.ToString)

    '                CeldaCheck.Value = DGV2.Rows(CONT).Cells(0).Value
    '                fila.Cells.Add(CeldaCheck)
    '                CeldaCheck.ReadOnly = False

    '                CeldaCod.Value = DGV2.Rows(CONT).Cells(1).Value
    '                fila.Cells.Add(CeldaCod)
    '                CeldaCod.ReadOnly = True

    '                CeldaDesc.Value = DGV2.Rows(CONT).Cells(2).Value
    '                fila.Cells.Add(CeldaDesc)
    '                CeldaDesc.ReadOnly = True

    '                If sw Then

    '                    Dim cont3 As Integer = 0

    '                    For cont3 = 1 To colec.Count

    '                        CeldaModelo.Items.Add(colec.Item(cont3).ToString)

    '                    Next

    '                    CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(3).Value)

    '                Else

    '                    CeldaModelo.Items.Add(DGV2.Rows(CONT - 1).Cells(3).Value)
    '                    CeldaModelo.Items.Add(DGV2.Rows(CONT).Cells(3).Value)

    '                End If

    '                CeldaModelo.Value = DGV2.Rows(CONT).Cells(3).Value

    '                fila.Cells.Add(CeldaModelo)
    '                CeldaModelo.ReadOnly = False

    '                CeldaPrecio.Value = DGV2.Rows(CONT).Cells(4).Value
    '                fila.Cells.Add(CeldaPrecio)
    '                CeldaPrecio.ReadOnly = True

    '                CeldaExist.Value = DGV2.Rows(CONT).Cells(5).Value
    '                fila.Cells.Add(CeldaExist)
    '                CeldaExist.ReadOnly = False


    '                DGV2.Rows.Add(fila)
    '                DGV2.Rows.RemoveAt(CONT)
    '                DGV2.Rows.RemoveAt(CONT - 1)
    '                DGV2.Sort(DGV2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    '                CONT = CONT - 1

    '            Else

    '                cont4 = 0
    '                sw = False
    '                colec.Clear()
    '                DGV2.Rows(CONT).Cells(3).ReadOnly = True

    '            End If

    '            anterior = CStr(DGV2.Rows(CONT).Cells(1).Value)

    '            CONT = CONT + 1

    '        End While

    '    Catch ex As Exception

    '        MsgBox("Problema cargando la lista de productos", MsgBoxStyle.Critical)
    '        'MsgBox(ex.Message)

    '    End Try

    'End Sub

    'Private Sub AddData3()

    '    DatosGrupos.consulta_productos_Grupo(Dgv_GruposProductosAsociados, Dgv_Grupos.SelectedRows(0).Cells(0).Value)

    '    Dim i As Integer = 0
    '    While i < Tabla.Rows.Count
    '        l.Add(Tabla.Rows(i).Item(2))
    '        Console.WriteLine("Add de BD: " + l.Item(l.Count))
    '        i = i + 1
    '    End While

    '    cuantos = l.Count
    '    Console.WriteLine(cuantos)

    '    DatosGrupos.consulta_productos_noGrupo(Dgv_GruposProductosAsociados, Dgv_Grupos.SelectedRows(0).Cells(0).Value)

    'End Sub

    Private myCheckBoxCol As Integer = 0

    Private Sub limpiacolec(ByRef col As Collection)
        For Each item In col
            col.Remove(1)
        Next
    End Sub

    'Private Sub AddTableStyle()
    '    dview()
    'End Sub
    Public Sub SetEnableValuesfalse(ByVal sender As Object, ByVal e As DataGridEnableEventArgs)
        e.EnableValue = False
    End Sub

    'Private Sub dview()
    '    Dim cm As CurrencyManager
    '    cm = CType(BindingContext(Tabla), CurrencyManager)
    '    Dim Dv As DataView = CType(cm.List, DataView)
    '    Dv.AllowNew = False
    '    Dv.Sort = "Descripcion ASC"
    'End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        Dgv_Grupos.ClearSelection()
        Dgv_Grupos.Enabled = True
        Me.tb_codigo.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.rb_ninguno.Visible = False
        Me.rb_todos.Visible = False
        Me.ToolBar1.Enabled = True
        Me.DomainUpDown1.Enabled = True
        Me.tb_codigo.Text = ""
        Me.tb_nombre.Text = ""
        rb_ninguno.Checked = False
        rb_todos.Checked = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        chk_exist.Checked = False
        chk_exist.Enabled = False
        'Tabla.Clear()
        'Dgv_GruposProductosAsociados.Rows.Clear()

        Dgv_GruposProductosAsociados.Columns(0).Visible = False

        limpiacolec(l)
        limpiacolec(lelim)
        limpiacolec(agr)
        limpiacolec(eli)
        boton = ""

        Me.DomainUpDown1.SelectedItem = 0
        Me.tb_buscarcodigo.Text = ""

        'Dim cm As CurrencyManager
        'cm = CType(BindingContext(Tabla), CurrencyManager)
        'Dv = CType(cm.List, DataView)
        'Dv.RowFilter = ""

        DatosGrupos.Consultar_Grupos(Dgv_Grupos, 0)

        Label2.Text = Dgv_Grupos.RowCount
        Me.tb_buscarcodigo.Focus()
        Dgv_Grupos.Enabled = True
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0
        'For cont2 As Integer = 0 To Tabla.Rows.Count - 1
        '    Tabla.Rows(cont2).Item(0) = False
        'Next
        CrearWhere()
        'dgAG()

    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_nombre.Text = "" Then
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

                DatosGrupos.inserta_grupo(Me.tb_nombre.Text)

                SpconsultaProductosGruposBindingSource.Filter = "CHK = 1"
                Dgv_GruposProductosAsociados.ClearSelection()

                For cont As Integer = 0 To Dgv_GruposProductosAsociados.RowCount - 1

                    If Dgv_GruposProductosAsociados.Rows(cont).Cells(0).Value = 1 Then
                        DatosGrupos.insertar_producto_grupo(CInt(Me.tb_codigo.Text), Dgv_GruposProductosAsociados.Rows(cont).Cells(1).Value)
                    End If

                Next
                limpiacolec(agr)

                MsgBox("El Grupo Ha Sido Registrado Exitosamente")
                Dgv_Grupos.Enabled = True

            End If

        ElseIf boton = "m" Then
            Dgv_Grupos.Enabled = True
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else

                DatosGrupos.modifica_grupo(Me.tb_nombre.Text, CInt(Me.tb_codigo.Text))


                DatosGrupos.Eliminar_Productos_Grupo(CInt(Me.tb_codigo.Text))

                SpconsultaProductosGruposBindingSource.Filter = "CHK = 1"
                Dgv_GruposProductosAsociados.ClearSelection()

                For cont3 As Integer = 0 To Dgv_GruposProductosAsociados.RowCount - 1
                    If Dgv_GruposProductosAsociados.Rows(cont3).Cells(0).Value = 1 Then
                        DatosGrupos.insertar_producto_grupo(CInt(Me.tb_codigo.Text), Dgv_GruposProductosAsociados.Rows(cont3).Cells(1).Value)
                    End If
                Next



                MsgBox("El Grupo Ha Sido Modificado Exitosamente")



            End If

        End If

        If deny = False Then
            Dim cant As Integer = 0

            Me.tb_codigo.ReadOnly = True
            Me.tb_nombre.ReadOnly = True
            Me.rb_ninguno.Visible = False
            Me.rb_todos.Visible = False
            Me.ToolBar1.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.tb_codigo.Text = ""
            Me.tb_nombre.Text = ""
            Sp_consultaProductosGruposTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosGrupos, -1)
            CrearWhere()
            limpiacolec(l)
            limpiacolec(lelim)
            limpiacolec(eli)
            limpiacolec(agr)
            boton = ""
            rb_ninguno.Checked = False
            rb_todos.Checked = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.DomainUpDown1.SelectedItem = 0
            Me.tb_buscarcodigo.Text = ""
            chk_exist.Enabled = False
            DatosGrupos.Consultar_Grupos(Dgv_Grupos, 0)
            Label2.Text = Me.Dgv_Grupos.Rows.Count
            chk_exist.Checked = False
            Dgv_GruposProductosAsociados.Columns(0).Visible = False
            Dgv_Grupos.Enabled = True
            Me.DomainUpDown1.Items.Clear()
            Me.DomainUpDown1.Items.Add("Código")
            Me.DomainUpDown1.Items.Add("Nombre")
            Me.DomainUpDown1.SelectedIndex = 0

        End If
        'dgAG()

    End Sub
    Private Sub modifica_Grupo(ByVal y As Integer)
        Dim i As Integer = 0
        For Each item In agr
            Dim int As String = item
            If i < agr.Count Then
                DatosGrupos.insertar_producto_grupo(y, int)
            End If
            i = i + 1
        Next
    End Sub

    Private Sub Dgv_Grupos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Grupos.CellClick, Dgv_Grupos.KeyUp, Dgv_Grupos.KeyDown
      
        Try

            If Dgv_Grupos.RowCount > 0 Then
                Dim cod As Integer = 0
                cod = CInt(Dgv_Grupos.SelectedRows(0).Cells(0).Value)
                DatosGrupos.consulta_grupo(Me.tb_codigo.Text, Me.tb_nombre.Text, cod)
                Dgv_GruposProductosAsociados.Columns(0).Visible = False
                'Tabla.Clear()
                'Dgv_GruposProductosAsociados.Rows.Clear()
                'AddData(cod)
                'DGV_Productos_Inventario2(Dgv_GruposProductosAsociados)
                'dgAG()
                tb_codigo.Text = Dgv_Grupos.SelectedRows(0).Cells(0).Value
                tb_nombre.Text = Dgv_Grupos.SelectedRows(0).Cells(1).Value
                CrearWhere()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        If Me.Dgv_Grupos.Enabled = True Then

            Dim s1 As String
            s1 = "%" + Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then

                DatosGrupos.Dgv_Grupo(Me.Dgv_Grupos, s1, 0)

            ElseIf choice = 1 Then

                DatosGrupos.Dgv_Grupo(Me.Dgv_Grupos, s1, 1)

            End If

            Label2.Text = Me.Dgv_Grupos.RowCount
            tb_codigo.Clear()
            tb_nombre.Clear()

        End If

        CrearWhere()

        'ElseIf Me.Dgv_GruposProductosAsociados.Enabled = True And (boton = "n" Or boton = "m") Then

        '    If choice = 0 Then
        '        DatosGrupos.Llenar_DGV_Like(tb_buscarcodigo.Text, 0, Dgv_GruposProductosAsociados)
        '    ElseIf choice = 1 Then
        '        DatosGrupos.Llenar_DGV_Like(tb_buscarcodigo.Text, 1, Dgv_GruposProductosAsociados)
        '    ElseIf choice = 2 Then
        '        DatosGrupos.Llenar_DGV_Like(tb_buscarcodigo.Text, 6, Dgv_GruposProductosAsociados)
        '    ElseIf choice = 3 Then
        '        DatosGrupos.Llenar_DGV_Like(tb_buscarcodigo.Text, 5, Dgv_GruposProductosAsociados)
        '    ElseIf choice = 4 Then
        '        DatosGrupos.Llenar_DGV_Like(tb_buscarcodigo.Text, 4, Dgv_GruposProductosAsociados)
        '    End If

        '    'If boton <> "n" Then

        '    'End If

        '    'ComboDgv()

        '    Dim jj As Integer
        '    Dim Item1 As String


        '    For Each Item1 In cMod
        '        For jj = 0 To Dgv_GruposProductosAsociados.RowCount - 1

        '            If Item1 = Dgv_GruposProductosAsociados.Rows(jj).Cells(1).Value Then

        '                Dgv_GruposProductosAsociados.Rows(jj).Cells(0).Value = True

        '            End If

        '        Next
        '    Next


        '    For Each Item1 In eli
        '        For jj = 0 To Dgv_GruposProductosAsociados.RowCount - 1

        '            If Item1 = Dgv_GruposProductosAsociados.Rows(jj).Cells(1).Value Then

        '                Dgv_GruposProductosAsociados.Rows(jj).Cells(0).Value = False

        '            End If

        '        Next
        '    Next

        '    Dim cont As Integer

        '    Dim aa As String

        '    For Each aa In eli

        '        Dim aux As String = aa
        '        cont = 1
        '        For Each item In agr

        '            Dim int As String = item

        '            If int = aux Then

        '                agr.Remove(cont)
        '            Else
        '                cont = cont + 1

        '            End If
        '        Next
        '    Next


        '    Dim j As Integer

        '    For Each item In agr

        '        Dim int As String = item

        '        For j = 0 To Dgv_GruposProductosAsociados.RowCount - 1

        '            If int = Dgv_GruposProductosAsociados.Rows(j).Cells(1).Value Then

        '                Dgv_GruposProductosAsociados.Rows(j).Cells(0).Value = True

        '            End If

        '        Next

        '    Next

        '    DGV_Productos_Inventario2(Dgv_GruposProductosAsociados)
        '    Label9.Text = Me.Dgv_GruposProductosAsociados.RowCount
        '    rb_ninguno.Checked = False
        '    rb_todos.Checked = False

        'End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Private Sub modifica_Grupos(ByVal y As String)
        Dim i As Integer = 1
        For Each item In l
            Dim int As String = item
            If i > cuantos Then
                DatosCodigosArancelarios.insertar_producto_Arancelario(y, int)
            End If
            i = i + 1
        Next
    End Sub

    Private Sub Dgv_GruposProductosAsociados_CellParsing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles Dgv_GruposProductosAsociados.CellParsing

        Try

            If Dgv_GruposProductosAsociados.SelectedRows(0).Cells(0).Value Then

                eli.Add(Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value)
                Dim j As Integer

                For j = 1 To agr.Count

                    If (Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value = agr.Item(j)) Then
                        agr.Remove(Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value)
                    End If

                Next

            Else
                agr.Add(Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value)
                Dim i As Integer

                For i = 1 To eli.Count

                    If (Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value = eli.Item(i)) Then
                        eli.Remove(Dgv_GruposProductosAsociados.SelectedRows(0).Cells(1).Value)
                    End If

                Next

            End If

        Catch ex As Exception


        End Try

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown

        Try

            If e.KeyData = Keys.Enter Then

                If Dgv_Grupos.Enabled Then

                    Me.Dgv_Grupos.Rows(0).Cells(0).Selected = True
                    Dgv_Grupos.Focus()

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub tb_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_buscarcodigo.KeyPress

        If Dgv_Grupos.Enabled = False Then
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

    Private Sub rb_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged

        If rb_todos.Checked = True Then
            If Dgv_GruposProductosAsociados.RowCount > 0 Then
                For cont As Integer = 0 To Dgv_GruposProductosAsociados.RowCount - 1

                    Dgv_GruposProductosAsociados.Rows(cont).Cells(0).Value = True

                Next
            End If
        End If

    End Sub

    Private Sub rb_ninguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_ninguno.CheckedChanged

        If rb_ninguno.Checked = True Then

            If Dgv_GruposProductosAsociados.RowCount > 0 Then

                For cont As Integer = 0 To Dgv_GruposProductosAsociados.RowCount - 1

                    Dgv_GruposProductosAsociados.Rows(cont).Cells(0).Value = False

                Next

            End If

        End If

    End Sub


    Public Sub CrearWhere()

        'Sp_infoGeneralComprasBindingSource.ResetBindings(True)
        Dim where As String = ""
        Dim y As String = ""

        If Dgv_Grupos.Enabled Then

            If Dgv_Grupos.SelectedRows.Count > 0 Then

                where = where + "Grupos LIKE '%" & Dgv_Grupos.SelectedRows(0).Cells(0).Value.ToString & Dgv_Grupos.SelectedRows(0).Cells(1).Value.ToString & "%'" + y
                y = " and "

            Else

                where = where + "Grupos LIKE '%" & "-1" & "%'" + y
                y = " and "

            End If

        Else

            If Dgv_Grupos.SelectedRows.Count > 0 Then

                where = where + "Grupos LIKE '%" & Dgv_Grupos.SelectedRows(0).Cells(0).Value.ToString & Dgv_Grupos.SelectedRows(0).Cells(1).Value.ToString & "%'" + y
                y = " and "

            End If

            If tb_buscarcodigo.Text <> "" Then

                If DomainUpDown1.SelectedIndex = 0 Then

                    where = where + "CodigoInterno LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 1 Then

                    where = where + "Nombre LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 2 Then

                    where = where + "Marca LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 3 Then

                    where = where + "Modelo LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 4 Then

                    where = where + "CantidadExistencia LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                End If

            End If

        End If

        If chk_exist.Checked Then
            where = where + y + "CantidadExistencia > 0"
            y = " and "
        End If

            Me.SpconsultaProductosGruposBindingSource.Filter = where

            If Dgv_GruposProductosAsociados.RowCount > 0 Then
                Dgv_GruposProductosAsociados.FirstDisplayedScrollingRowIndex = 0
        End If

        Me.lb_total.Text = Me.SpconsultaProductosGruposBindingSource.Count

        Dgv_GruposProductosAsociados.ClearSelection()

    End Sub

    Private Sub chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exist.CheckedChanged
        CrearWhere()
    End Sub
End Class