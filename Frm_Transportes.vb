Public Class Frm_Transportes
    Inherits System.Windows.Forms.Form

    Dim varboton As Integer = 0
    Friend WithEvents tb_RIF As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Private choice As Integer
    Dim w As Boolean = True
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_contacto As System.Windows.Forms.TextBox
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefono As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dgv_Choferes As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv_Camiones As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dgv_Transporte As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gb_cuartos As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Placa As System.Windows.Forms.TextBox
    Friend WithEvents bt_ModificarCamion As System.Windows.Forms.Button
    Friend WithEvents Lbl_Placa As System.Windows.Forms.Label
    Friend WithEvents bt_agregarCamion As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarCamion As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Cedula As System.Windows.Forms.TextBox
    Friend WithEvents bt_modificarChofer As System.Windows.Forms.Button
    Friend WithEvents Lbl_Cedula As System.Windows.Forms.Label
    Friend WithEvents bt_agregarChofer As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarChofer As System.Windows.Forms.Button
    Friend WithEvents tb_Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_ModeloCamion As System.Windows.Forms.Label
    Friend WithEvents tb_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents tb_NombreChofer As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Transportes))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tb_contacto = New System.Windows.Forms.TextBox
        Me.tb_direccion = New System.Windows.Forms.TextBox
        Me.tb_telefono = New System.Windows.Forms.TextBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.tb_RIF = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Dgv_Camiones = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.Dgv_Choferes = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dgv_Transporte = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gb_cuartos = New System.Windows.Forms.GroupBox
        Me.tb_Modelo = New System.Windows.Forms.TextBox
        Me.tb_Placa = New System.Windows.Forms.TextBox
        Me.Lbl_ModeloCamion = New System.Windows.Forms.Label
        Me.bt_ModificarCamion = New System.Windows.Forms.Button
        Me.Lbl_Placa = New System.Windows.Forms.Label
        Me.bt_agregarCamion = New System.Windows.Forms.Button
        Me.bt_eliminarCamion = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tb_Apellido = New System.Windows.Forms.TextBox
        Me.tb_NombreChofer = New System.Windows.Forms.TextBox
        Me.tb_Cedula = New System.Windows.Forms.TextBox
        Me.bt_modificarChofer = New System.Windows.Forms.Button
        Me.Lbl_Apellido = New System.Windows.Forms.Label
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.Lbl_Cedula = New System.Windows.Forms.Label
        Me.bt_agregarChofer = New System.Windows.Forms.Button
        Me.bt_eliminarChofer = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Camiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Choferes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Transporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_cuartos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Datos del Transporte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.tb_contacto)
        Me.GroupBox1.Controls.Add(Me.tb_direccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_telefono)
        Me.GroupBox1.Controls.Add(Me.tb_nombre)
        Me.GroupBox1.Controls.Add(Me.tb_RIF)
        Me.GroupBox1.Controls.Add(Me.tb_codigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(274, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 238)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'tb_contacto
        '
        Me.tb_contacto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contacto.Location = New System.Drawing.Point(83, 182)
        Me.tb_contacto.MaxLength = 20
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.Size = New System.Drawing.Size(95, 22)
        Me.tb_contacto.TabIndex = 6
        '
        'tb_direccion
        '
        Me.tb_direccion.CausesValidation = False
        Me.tb_direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion.Location = New System.Drawing.Point(83, 129)
        Me.tb_direccion.MaxLength = 1000
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(279, 50)
        Me.tb_direccion.TabIndex = 5
        '
        'tb_telefono
        '
        Me.tb_telefono.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono.Location = New System.Drawing.Point(83, 104)
        Me.tb_telefono.MaxLength = 18
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.Size = New System.Drawing.Size(95, 22)
        Me.tb_telefono.TabIndex = 4
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(83, 54)
        Me.tb_nombre.MaxLength = 50
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(280, 22)
        Me.tb_nombre.TabIndex = 3
        '
        'tb_RIF
        '
        Me.tb_RIF.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_RIF.Location = New System.Drawing.Point(83, 79)
        Me.tb_RIF.Name = "tb_RIF"
        Me.tb_RIF.Size = New System.Drawing.Size(95, 22)
        Me.tb_RIF.TabIndex = 2
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(83, 29)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(47, 22)
        Me.tb_codigo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "(*)Contacto:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "(*)Dirección:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "(*)Teléfono:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 23)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "(*)RIF:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(*)Nombre:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "(*)Código:"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ErrorProvider1.SetIconAlignment(Me.Label22, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Label22.Location = New System.Drawing.Point(138, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(152, 20)
        Me.Label22.TabIndex = 47
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label22.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 19)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "(*)Datos requeridos"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(474, 569)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 19
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(393, 569)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 18
        Me.bt_aceptar.Text = "Aceptar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 50)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-2, 5)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(266, 58)
        Me.ToolBar1.TabIndex = 58
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
        Me.ImageList2.Images.SetKeyName(5, "icono-impresion.gif")
        Me.ImageList2.Images.SetKeyName(6, "ok.gif")
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(369, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Camiones"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_Camiones
        '
        Me.Dgv_Camiones.AllowUserToAddRows = False
        Me.Dgv_Camiones.AllowUserToDeleteRows = False
        Me.Dgv_Camiones.AllowUserToResizeColumns = False
        Me.Dgv_Camiones.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Camiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_Camiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Camiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column3})
        Me.Dgv_Camiones.Location = New System.Drawing.Point(6, 30)
        Me.Dgv_Camiones.MultiSelect = False
        Me.Dgv_Camiones.Name = "Dgv_Camiones"
        Me.Dgv_Camiones.ReadOnly = True
        Me.Dgv_Camiones.RowHeadersVisible = False
        Me.Dgv_Camiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Camiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Camiones.Size = New System.Drawing.Size(197, 123)
        Me.Dgv_Camiones.TabIndex = 93
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Modelo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(369, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Choferes"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_Choferes
        '
        Me.Dgv_Choferes.AllowUserToAddRows = False
        Me.Dgv_Choferes.AllowUserToDeleteRows = False
        Me.Dgv_Choferes.AllowUserToResizeColumns = False
        Me.Dgv_Choferes.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Choferes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.Dgv_Choferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Choferes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column4})
        Me.Dgv_Choferes.Location = New System.Drawing.Point(6, 27)
        Me.Dgv_Choferes.MultiSelect = False
        Me.Dgv_Choferes.Name = "Dgv_Choferes"
        Me.Dgv_Choferes.ReadOnly = True
        Me.Dgv_Choferes.RowHeadersVisible = False
        Me.Dgv_Choferes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Choferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Choferes.Size = New System.Drawing.Size(197, 115)
        Me.Dgv_Choferes.TabIndex = 93
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 77
        '
        'Column1
        '
        Me.Column1.HeaderText = "Apellido"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cedula"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Dgv_Transporte
        '
        Me.Dgv_Transporte.AllowUserToAddRows = False
        Me.Dgv_Transporte.AllowUserToDeleteRows = False
        Me.Dgv_Transporte.AllowUserToResizeColumns = False
        Me.Dgv_Transporte.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Transporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv_Transporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Transporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column2})
        Me.Dgv_Transporte.Location = New System.Drawing.Point(8, 114)
        Me.Dgv_Transporte.MultiSelect = False
        Me.Dgv_Transporte.Name = "Dgv_Transporte"
        Me.Dgv_Transporte.ReadOnly = True
        Me.Dgv_Transporte.RowHeadersVisible = False
        Me.Dgv_Transporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Transporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Transporte.Size = New System.Drawing.Size(254, 449)
        Me.Dgv_Transporte.TabIndex = 93
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 175
        '
        'gb_cuartos
        '
        Me.gb_cuartos.BackColor = System.Drawing.Color.White
        Me.gb_cuartos.Controls.Add(Me.tb_Modelo)
        Me.gb_cuartos.Controls.Add(Me.tb_Placa)
        Me.gb_cuartos.Controls.Add(Me.Lbl_ModeloCamion)
        Me.gb_cuartos.Controls.Add(Me.bt_ModificarCamion)
        Me.gb_cuartos.Controls.Add(Me.Lbl_Placa)
        Me.gb_cuartos.Controls.Add(Me.bt_agregarCamion)
        Me.gb_cuartos.Controls.Add(Me.bt_eliminarCamion)
        Me.gb_cuartos.Controls.Add(Me.Dgv_Camiones)
        Me.gb_cuartos.Controls.Add(Me.Label8)
        Me.gb_cuartos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cuartos.Location = New System.Drawing.Point(274, 253)
        Me.gb_cuartos.Name = "gb_cuartos"
        Me.gb_cuartos.Size = New System.Drawing.Size(369, 159)
        Me.gb_cuartos.TabIndex = 10040
        Me.gb_cuartos.TabStop = False
        '
        'tb_Modelo
        '
        Me.tb_Modelo.Enabled = False
        Me.tb_Modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Modelo.Location = New System.Drawing.Point(275, 75)
        Me.tb_Modelo.MaxLength = 20
        Me.tb_Modelo.Name = "tb_Modelo"
        Me.tb_Modelo.Size = New System.Drawing.Size(87, 22)
        Me.tb_Modelo.TabIndex = 8
        '
        'tb_Placa
        '
        Me.tb_Placa.Enabled = False
        Me.tb_Placa.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Placa.Location = New System.Drawing.Point(275, 50)
        Me.tb_Placa.MaxLength = 10
        Me.tb_Placa.Name = "tb_Placa"
        Me.tb_Placa.Size = New System.Drawing.Size(87, 22)
        Me.tb_Placa.TabIndex = 7
        '
        'Lbl_ModeloCamion
        '
        Me.Lbl_ModeloCamion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ModeloCamion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_ModeloCamion.Location = New System.Drawing.Point(223, 78)
        Me.Lbl_ModeloCamion.Name = "Lbl_ModeloCamion"
        Me.Lbl_ModeloCamion.Size = New System.Drawing.Size(54, 20)
        Me.Lbl_ModeloCamion.TabIndex = 10023
        Me.Lbl_ModeloCamion.Text = "Modelo:"
        '
        'bt_ModificarCamion
        '
        Me.bt_ModificarCamion.Enabled = False
        Me.bt_ModificarCamion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_ModificarCamion.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarCamion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarCamion.Location = New System.Drawing.Point(306, 103)
        Me.bt_ModificarCamion.Name = "bt_ModificarCamion"
        Me.bt_ModificarCamion.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarCamion.TabIndex = 10
        Me.bt_ModificarCamion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Lbl_Placa
        '
        Me.Lbl_Placa.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Placa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Placa.Location = New System.Drawing.Point(223, 53)
        Me.Lbl_Placa.Name = "Lbl_Placa"
        Me.Lbl_Placa.Size = New System.Drawing.Size(54, 20)
        Me.Lbl_Placa.TabIndex = 10023
        Me.Lbl_Placa.Text = "Placa:"
        '
        'bt_agregarCamion
        '
        Me.bt_agregarCamion.Enabled = False
        Me.bt_agregarCamion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarCamion.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCamion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCamion.Location = New System.Drawing.Point(275, 103)
        Me.bt_agregarCamion.Name = "bt_agregarCamion"
        Me.bt_agregarCamion.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarCamion.TabIndex = 9
        Me.bt_agregarCamion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarCamion
        '
        Me.bt_eliminarCamion.Enabled = False
        Me.bt_eliminarCamion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarCamion.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCamion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCamion.Location = New System.Drawing.Point(337, 103)
        Me.bt_eliminarCamion.Name = "bt_eliminarCamion"
        Me.bt_eliminarCamion.Size = New System.Drawing.Size(25, 22)
        Me.bt_eliminarCamion.TabIndex = 11
        Me.bt_eliminarCamion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.tb_Apellido)
        Me.GroupBox2.Controls.Add(Me.tb_NombreChofer)
        Me.GroupBox2.Controls.Add(Me.tb_Cedula)
        Me.GroupBox2.Controls.Add(Me.bt_modificarChofer)
        Me.GroupBox2.Controls.Add(Me.Dgv_Choferes)
        Me.GroupBox2.Controls.Add(Me.Lbl_Apellido)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Lbl_Nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Cedula)
        Me.GroupBox2.Controls.Add(Me.bt_agregarChofer)
        Me.GroupBox2.Controls.Add(Me.bt_eliminarChofer)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(274, 415)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 148)
        Me.GroupBox2.TabIndex = 10040
        Me.GroupBox2.TabStop = False
        '
        'tb_Apellido
        '
        Me.tb_Apellido.Enabled = False
        Me.tb_Apellido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Apellido.Location = New System.Drawing.Point(275, 77)
        Me.tb_Apellido.MaxLength = 20
        Me.tb_Apellido.Name = "tb_Apellido"
        Me.tb_Apellido.Size = New System.Drawing.Size(87, 22)
        Me.tb_Apellido.TabIndex = 14
        '
        'tb_NombreChofer
        '
        Me.tb_NombreChofer.Enabled = False
        Me.tb_NombreChofer.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NombreChofer.Location = New System.Drawing.Point(275, 52)
        Me.tb_NombreChofer.MaxLength = 20
        Me.tb_NombreChofer.Name = "tb_NombreChofer"
        Me.tb_NombreChofer.Size = New System.Drawing.Size(87, 22)
        Me.tb_NombreChofer.TabIndex = 13
        '
        'tb_Cedula
        '
        Me.tb_Cedula.Enabled = False
        Me.tb_Cedula.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cedula.Location = New System.Drawing.Point(275, 27)
        Me.tb_Cedula.MaxLength = 20
        Me.tb_Cedula.Name = "tb_Cedula"
        Me.tb_Cedula.Size = New System.Drawing.Size(87, 22)
        Me.tb_Cedula.TabIndex = 12
        '
        'bt_modificarChofer
        '
        Me.bt_modificarChofer.Enabled = False
        Me.bt_modificarChofer.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_modificarChofer.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificarChofer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificarChofer.Location = New System.Drawing.Point(306, 107)
        Me.bt_modificarChofer.Name = "bt_modificarChofer"
        Me.bt_modificarChofer.Size = New System.Drawing.Size(25, 22)
        Me.bt_modificarChofer.TabIndex = 16
        Me.bt_modificarChofer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Lbl_Apellido
        '
        Me.Lbl_Apellido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Apellido.Location = New System.Drawing.Point(221, 80)
        Me.Lbl_Apellido.Name = "Lbl_Apellido"
        Me.Lbl_Apellido.Size = New System.Drawing.Size(71, 20)
        Me.Lbl_Apellido.TabIndex = 10023
        Me.Lbl_Apellido.Text = "Apellido:"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Nombre.Location = New System.Drawing.Point(221, 55)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(71, 20)
        Me.Lbl_Nombre.TabIndex = 10023
        Me.Lbl_Nombre.Text = "Nombre:"
        '
        'Lbl_Cedula
        '
        Me.Lbl_Cedula.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cedula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Cedula.Location = New System.Drawing.Point(221, 30)
        Me.Lbl_Cedula.Name = "Lbl_Cedula"
        Me.Lbl_Cedula.Size = New System.Drawing.Size(54, 20)
        Me.Lbl_Cedula.TabIndex = 10023
        Me.Lbl_Cedula.Text = "Cédula:"
        '
        'bt_agregarChofer
        '
        Me.bt_agregarChofer.Enabled = False
        Me.bt_agregarChofer.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarChofer.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarChofer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarChofer.Location = New System.Drawing.Point(275, 107)
        Me.bt_agregarChofer.Name = "bt_agregarChofer"
        Me.bt_agregarChofer.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarChofer.TabIndex = 15
        Me.bt_agregarChofer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarChofer
        '
        Me.bt_eliminarChofer.Enabled = False
        Me.bt_eliminarChofer.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarChofer.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarChofer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarChofer.Location = New System.Drawing.Point(337, 107)
        Me.bt_eliminarChofer.Name = "bt_eliminarChofer"
        Me.bt_eliminarChofer.Size = New System.Drawing.Size(25, 22)
        Me.bt_eliminarChofer.TabIndex = 17
        Me.bt_eliminarChofer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 566)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 20)
        Me.Label10.TabIndex = 10042
        Me.Label10.Text = "#"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(168, 566)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 10041
        Me.Label11.Text = "Total:"
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(138, 72)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(124, 25)
        Me.tb_buscar.TabIndex = 0
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(8, 72)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(124, 26)
        Me.DomainUpDown1.TabIndex = 10044
        '
        'Frm_Transportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 601)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.tb_buscar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_cuartos)
        Me.Controls.Add(Me.Dgv_Transporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Transportes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Transportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Camiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Choferes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Transporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_cuartos.ResumeLayout(False)
        Me.gb_cuartos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub Estado(ByVal switch As Integer)
        If switch = 1 Then
            tb_NombreChofer.Enabled = True
            tb_Apellido.Enabled = True
            tb_Placa.Enabled = True
            tb_Modelo.Enabled = True
            bt_agregarCamion.Enabled = True
            bt_eliminarCamion.Enabled = True
            bt_ModificarCamion.Enabled = True
            bt_agregarChofer.Enabled = True
            bt_modificarChofer.Enabled = True
            bt_eliminarChofer.Enabled = True
        ElseIf switch = 0 Then
            tb_NombreChofer.Enabled = False
            tb_Apellido.Enabled = False
            tb_Placa.Enabled = False
            tb_Modelo.Enabled = False
            bt_agregarCamion.Enabled = False
            bt_eliminarCamion.Enabled = False
            bt_ModificarCamion.Enabled = False
            bt_agregarChofer.Enabled = False
            bt_modificarChofer.Enabled = False
            bt_eliminarChofer.Enabled = False
        End If
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then
            Me.Close()
        ElseIf e.Button Is Me.bt_nuevo Then
            Dgv_Camiones.Rows.Clear()
            Dgv_Choferes.Rows.Clear()
            Me.tb_RIF.Clear()
            tb_Cedula.Clear()
            tb_NombreChofer.Clear()
            tb_Apellido.Clear()
            tb_Modelo.Clear()
            tb_Placa.Clear()
            tb_RIF.Focus()
            Me.tb_RIF.ReadOnly = False
            varboton = 1
            tb_buscar.Enabled = False
            Me.tb_codigo.Clear()
            Me.tb_contacto.Clear()
            Me.tb_direccion.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            DatosTransporte.identidad_Transporte(Me.tb_codigo)
            Me.ToolBar1.Enabled = False
            Me.Dgv_Transporte.Enabled = False
            Me.tb_codigo.Enabled = False
            Me.tb_contacto.ReadOnly = False
            Me.tb_direccion.ReadOnly = False
            Me.tb_nombre.ReadOnly = False
            Me.tb_telefono.ReadOnly = False
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Dgv_Transporte.ClearSelection()
            tb_Cedula.Enabled = True

            Estado(1)

        ElseIf e.Button Is Me.bt_modificar Then
            varboton = 2
            Dim n As Integer

            n = Dgv_Transporte.SelectedRows.Count

            If n = 1 Then
                Me.ToolBar1.Enabled = False
                Me.Dgv_Transporte.Enabled = False
                Me.tb_codigo.Enabled = False
                Me.tb_contacto.ReadOnly = False
                Me.tb_RIF.ReadOnly = False
                Me.tb_direccion.ReadOnly = False
                Me.tb_nombre.ReadOnly = False
                Me.tb_telefono.ReadOnly = False
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.tb_Cedula.Enabled = True
                tb_buscar.Enabled = False
                tb_Cedula.Clear()
                tb_NombreChofer.Clear()
                tb_Apellido.Clear()
                tb_Modelo.Clear()
                tb_Placa.Clear()
                Dgv_Camiones.ClearSelection()
                Dgv_Choferes.ClearSelection()

                Estado(1)

            ElseIf n = 0 Then
                MsgBox("Debe seleccionar el transporte que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Sólo puede modificar un transporte a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If

            Dgv_Transporte.ClearSelection()

        ElseIf e.Button Is Me.bt_eliminar Then
            tb_Cedula.Clear()
            tb_NombreChofer.Clear()
            tb_Apellido.Clear()
            tb_Modelo.Clear()
            tb_Placa.Clear()
            varboton = 3
            Dim n As Integer
            Dim response As MsgBoxResult

            n = Dgv_Transporte.SelectedRows.Count
            Dim cod As Integer
            If n = 0 Then
                MsgBox("Debe seleccionar el(los) transporte(s) que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            ElseIf n = 1 Then
                response = MsgBox("¿Confirma que desea eliminar el transporte '" + Dgv_Transporte.SelectedRows(0).Cells(1).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then

                    cod = Dgv_Transporte.SelectedRows(0).Cells(0).Value.ToString
                    DatosTransporte.elimina_transporte(cod)
                    MsgBox("El transporte '" + Dgv_Transporte.SelectedRows(0).Cells(1).Value.ToString + "' Ha Sido Eliminado Exitosamente")

                    Dgv_Transporte.Rows.Clear()
                    DatosTransporte.consulta_transportes(Dgv_Transporte)
                    Dgv_Camiones.Rows.Clear()
                    Dgv_Choferes.Rows.Clear()
                End If
            Else
                'response = MsgBox("¿Confirma que desea eliminar estos " + n.ToString + " transportes?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                'If (response = MsgBoxResult.Yes) Then
                '    Dim i As Integer = 0


                '    Dim x As ListViewItem
                '    For Each x In Me.ListView1.Items
                '        If Me.ListView1.Items(i).Selected() Then
                '            cod = CInt(Me.ListView1.Items(i).SubItems(0).Text())
                '            DatosTransporte.elimina_transporte(cod)
                '        End If
                '        i = i + 1
                '    Next

                '    MsgBox("Se han eliminado (" + n.ToString + ") transportes Exitosamente")
                '    'ListView1.Items.Clear()
                '    Dgv_Transporte.Rows.Clear()
                '    DatosTransporte.consulta_transportes(Dgv_Transporte)
                '    Label10.Text = Dgv_Transporte.RowCount
                'End If
            End If
            Me.tb_codigo.Clear()
            Me.tb_contacto.Clear()
            Me.tb_direccion.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()

            Dgv_Transporte.ClearSelection()
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        tb_buscar.Focus()
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0
        Me.tb_codigo.ReadOnly = True
        Me.tb_contacto.ReadOnly = True
        Me.tb_RIF.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.tb_telefono.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        DatosTransporte.consulta_transportes(Me.Dgv_Transporte)
        Dgv_Transporte.ClearSelection()
        Label10.Text = Dgv_Transporte.RowCount.ToString
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

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.ToolBar1.Enabled = True
        Me.Dgv_Transporte.Enabled = True
        Me.tb_codigo.ReadOnly = True
        Me.tb_contacto.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.tb_telefono.ReadOnly = True
        Me.tb_codigo.Clear()
        Me.tb_contacto.Clear()
        Me.tb_direccion.Clear()
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_RIF.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        tb_Cedula.Enabled = False
        tb_Cedula.Clear()
        tb_NombreChofer.Clear()
        tb_Apellido.Clear()
        tb_Modelo.Clear()
        tb_Placa.Clear()
        tb_buscar.Enabled = True


        Dgv_Transporte.ClearSelection()
        Dgv_Camiones.Rows.Clear()
        Dgv_Choferes.Rows.Clear()
        Estado(0)
    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_contacto.Text = "" Or Me.tb_direccion.Text = "" Or Me.tb_nombre.Text = "" Or Me.tb_telefono.Text = "" Or Me.tb_RIF.Text = "" Then
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
                DatosTransporte.inserta_transporte(Me.tb_nombre.Text, Me.tb_telefono.Text, Me.tb_direccion.Text, Me.tb_contacto.Text, Me.tb_RIF.Text)

                Dim ii As Integer

                For ii = 0 To Dgv_Camiones.RowCount - 1

                    DatosTransporte.inserta_Camion(Dgv_Camiones.Rows(ii).Cells(0).Value, Dgv_Camiones.Rows(ii).Cells(1).Value, tb_codigo.Text)

                Next

                Dim k As Integer

                For k = 0 To Dgv_Choferes.RowCount - 1

                    DatosTransporte.inserta_Chofer(Dgv_Choferes.Rows(k).Cells(2).Value, Dgv_Choferes.Rows(k).Cells(0).Value, Dgv_Choferes.Rows(k).Cells(1).Value, tb_codigo.Text)

                Next

                Dgv_Transporte.Rows.Clear()
                DatosTransporte.consulta_transportes(Me.Dgv_Transporte)

            End If

        ElseIf (varboton = 2) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else
                DatosTransporte.modifica_transporte(Me.tb_nombre.Text, Me.tb_telefono.Text, Me.tb_direccion.Text, Me.tb_contacto.Text, CInt(Me.tb_codigo.Text), Me.tb_RIF.Text)
                Dgv_Transporte.Rows.Clear()
                DatosTransporte.consulta_transportes(Me.Dgv_Transporte)
            End If
        End If
        If deny = False Then
            Me.ToolBar1.Enabled = True
            Me.Dgv_Transporte.Enabled = True
            Me.tb_codigo.ReadOnly = True
            Me.tb_contacto.ReadOnly = True
            Me.tb_direccion.ReadOnly = True
            Me.tb_nombre.ReadOnly = True
            Me.tb_telefono.ReadOnly = True
            Me.tb_codigo.Clear()
            Me.tb_contacto.Clear()
            Me.tb_direccion.Clear()
            Me.tb_RIF.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Dgv_Transporte.ClearSelection()
            Dgv_Camiones.Rows.Clear()
            Dgv_Choferes.Rows.Clear()
            tb_buscar.Enabled = True
            Estado(0)

        End If
    End Sub

    Private Sub Dgv_Transporte_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv_Transporte.ColumnHeaderMouseClick

        Dgv_Transporte.ClearSelection()
        Dgv_Camiones.Rows.Clear()
        Dgv_Choferes.Rows.Clear()

    End Sub

    Private Sub Dgv_Transporte_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Transporte.CellClick, Dgv_Transporte.KeyUp, Dgv_Transporte.KeyDown

        Dim n As Integer
        n = Dgv_Transporte.SelectedRows.Count
        If n = 0 Then
            Me.tb_codigo.Clear()
            Me.tb_contacto.Clear()
            Me.tb_direccion.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.tb_RIF.Clear()
        ElseIf n = 1 Then
            Dim cod As Integer = 0
            cod = Dgv_Transporte.SelectedRows(0).Cells(0).Value
            DatosTransporte.consulta_transporte(Me.tb_RIF.Text, Me.tb_codigo.Text, Me.tb_nombre.Text, Me.tb_telefono.Text, Me.tb_direccion.Text, Me.tb_contacto.Text, cod)
            tb_codigo.Text = cod
            DatosTransporte.consulta_camion(Dgv_Camiones, cod)
            DatosTransporte.consulta_chofer(Dgv_Choferes, cod)
            Dgv_Camiones.ClearSelection()
            Dgv_Choferes.ClearSelection()

        End If
    End Sub

    Private Sub bt_agregarCamion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCamion.Click

        If tb_Placa.Text <> "" And tb_Modelo.Text <> "" Then

            If varboton = 1 Then

                Dim a As Boolean = False


                Dim k As Integer

                For k = 0 To Dgv_Camiones.RowCount - 1

                    If Dgv_Camiones.Rows(k).Cells(0).Value.ToString = tb_Placa.Text Then

                        MsgBox("El camión ya está asociado a este transporte", MsgBoxStyle.Critical)
                        a = True

                    End If


                Next

                If a = False Then
                    Dgv_Camiones.Rows.Add(tb_Placa.Text, tb_Modelo.Text)
                End If

            ElseIf varboton = 2 Then

                Try
                    DatosTransporte.inserta_Camion(tb_Placa.Text, tb_Modelo.Text, tb_codigo.Text)
                    Dgv_Camiones.Rows.Add(tb_Placa.Text, tb_Modelo.Text)

                Catch ex As Exception
                    MsgBox("El camión ya fue asociado a otro transporte")
                End Try
            End If

            tb_Placa.Clear()
            tb_Modelo.Clear()

        End If

    End Sub

    Private Sub bt_agregarChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarChofer.Click

        If tb_Apellido.Text <> "" And tb_NombreChofer.Text <> "" And tb_Cedula.Text <> "" Then

            If varboton = 1 Then

                Dim a As Boolean = False


                Dim k As Integer

                For k = 0 To Dgv_Choferes.RowCount - 1

                    If Dgv_Choferes.Rows(k).Cells(2).Value.ToString = tb_Cedula.Text Then

                        MsgBox("El Chofer ya está asociado a este transporte", MsgBoxStyle.Critical)
                        a = True

                    End If

                Next

                If a = False Then
                    Dgv_Choferes.Rows.Add(tb_NombreChofer.Text, tb_Apellido.Text, tb_Cedula.Text)
                End If

            ElseIf varboton = 2 Then
                Try
                    DatosTransporte.inserta_Chofer(tb_Cedula.Text, tb_NombreChofer.Text, tb_Apellido.Text, tb_codigo.Text)
                    Dgv_Choferes.Rows.Add(tb_NombreChofer.Text, tb_Apellido.Text, tb_Cedula.Text)
                Catch ex As Exception
                    MsgBox("El Chofer ya fue asociado a otro transporte")
                End Try

            End If

            tb_Cedula.Clear()
            tb_NombreChofer.Clear()
            tb_Apellido.Clear()

        End If

    End Sub

    Private Sub bt_eliminarCamion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCamion.Click

        If Dgv_Camiones.SelectedRows.Count > 0 Then

            If varboton = 1 Then

                Dgv_Camiones.Rows.Remove(Dgv_Camiones.SelectedRows(0))

            ElseIf varboton = 2 Then

                If MsgBox("Está seguro de eliminar el Camion con Placa: " & Dgv_Camiones.SelectedRows(0).Cells(0).Value & " y Modelo:" & Dgv_Camiones.SelectedRows(0).Cells(1).Value, MsgBoxStyle.YesNo, "Confirmar Eliminación") = MsgBoxResult.Yes Then

                    DatosTransporte.elimina_Camion(Dgv_Camiones.SelectedRows(0).Cells(0).Value, tb_codigo.Text)
                    Dgv_Camiones.Rows.Remove(Dgv_Camiones.SelectedRows(0))
                    tb_Placa.Clear()
                    tb_Modelo.Clear()
                End If

            End If

        End If

    End Sub

    Private Sub bt_eliminarChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarChofer.Click

        Try
            If Dgv_Choferes.SelectedRows.Count > 0 Then

                If varboton = 1 Then

                    Dgv_Choferes.Rows.Remove(Dgv_Choferes.SelectedRows(0))

                ElseIf varboton = 2 Then


                    If MsgBox("Está seguro de eliminar el Chofer " & Dgv_Choferes.SelectedRows(0).Cells(0).Value & " " & Dgv_Choferes.SelectedRows(0).Cells(1).Value, MsgBoxStyle.YesNo, "Confirmar Eliminación") = MsgBoxResult.Yes Then

                        DatosTransporte.elimina_Chofer(Dgv_Choferes.SelectedRows(0).Cells(2).Value, tb_codigo.Text)
                        Dgv_Choferes.Rows.Remove(Dgv_Choferes.SelectedRows(0))
                        tb_Cedula.Clear()
                        tb_NombreChofer.Clear()
                        tb_Apellido.Clear()
                    End If

                End If

                Dgv_Choferes.Rows.Remove(Dgv_Choferes.SelectedRows(0))

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bt_ModificarCamion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarCamion.Click

        If Dgv_Camiones.SelectedRows.Count > 0 And tb_Placa.Text <> "" And tb_Modelo.Text <> "" Then

            If varboton = 1 Then

                Dgv_Camiones.SelectedRows(0).Cells(0).Value = tb_Placa.Text
                Dgv_Camiones.SelectedRows(0).Cells(1).Value = tb_Modelo.Text

            ElseIf varboton = 2 Then

                DatosTransporte.modifica_Camion(tb_Placa.Text, tb_Modelo.Text, tb_codigo.Text)
                Dgv_Camiones.SelectedRows(0).Cells(0).Value = tb_Placa.Text
                Dgv_Camiones.SelectedRows(0).Cells(1).Value = tb_Modelo.Text

            End If

            tb_Modelo.Clear()
            tb_Placa.Clear()
            tb_Placa.Focus()


        End If

    End Sub

    Private Sub bt_modificarChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarChofer.Click


        If Dgv_Choferes.SelectedRows.Count > 0 And tb_nombre.Text <> "" And tb_Apellido.Text <> "" Then

            If varboton = 1 Then

                Dgv_Choferes.SelectedRows(0).Cells(0).Value = tb_nombre.Text
                Dgv_Choferes.SelectedRows(0).Cells(1).Value = tb_Apellido.Text

            ElseIf varboton = 2 Then

                DatosTransporte.modifica_Chofer(tb_Cedula.Text, tb_nombre.Text, tb_Apellido.Text, tb_codigo.Text)
                Dgv_Choferes.SelectedRows(0).Cells(2).Value = tb_Cedula.Text
                Dgv_Choferes.SelectedRows(0).Cells(0).Value = tb_nombre.Text
                Dgv_Choferes.SelectedRows(0).Cells(1).Value = tb_Apellido.Text

            End If

            'Dgv_Choferes.SelectedRows(0).Cells(0).Value = tb_nombre.Text
            'Dgv_Choferes.SelectedRows(0).Cells(1).Value = tb_Apellido.Text
            tb_nombre.Clear()
            tb_Apellido.Clear()
            tb_nombre.Focus()

        End If

    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_telefono.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "." Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Label22.Text = "Ingrese sólo numeros, () y (.)"
        End If

    End Sub

    Private Sub tb_Placa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Placa.KeyPress

        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "-" Or Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If

    End Sub

    Private Sub tb_Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cedula.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Label22.Text = "Ingrese sólo numeros y (.)"
        End If

    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
            Me.Label22.Text = "Ingrese sólo números"
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_telefono.LostFocus
        muestra_label(sender, 1)
    End Sub

    Private Sub Dgv_Camiones_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv_Camiones.ColumnHeaderMouseClick
        Dgv_Camiones.ClearSelection()
    End Sub

    Private Sub Dgv_Camiones_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Camiones.CellClick, Dgv_Camiones.KeyUp, Dgv_Camiones.KeyDown

        Try
            tb_Placa.Text = Dgv_Camiones.SelectedRows(0).Cells(0).Value.ToString
            tb_Modelo.Text = Dgv_Camiones.SelectedRows(0).Cells(1).Value.ToString


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv_Choferes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Choferes.CellClick

        Try

            tb_NombreChofer.Text = Dgv_Choferes.SelectedRows(0).Cells(0).Value.ToString
            tb_Apellido.Text = Dgv_Choferes.SelectedRows(0).Cells(1).Value.ToString
            tb_Cedula.Text = Dgv_Choferes.SelectedRows(0).Cells(2).Value.ToString



        Catch ex As Exception

        End Try


    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged

        Dim s1 As String

        s1 = "%" + Me.tb_buscar.Text + "%"

        tb_codigo.Clear()
        tb_direccion.Clear()
        tb_telefono.Clear()
        tb_direccion.Clear()
        tb_contacto.Clear()
        tb_nombre.Clear()
        Dgv_Choferes.Rows.Clear()
        Dgv_Camiones.Rows.Clear()

        tb_Placa.Clear()
        tb_Modelo.Clear()

        tb_NombreChofer.Clear()
        tb_Cedula.Clear()
        tb_Apellido.Clear()

        If choice = 0 Then

            DatosTransporte.Dgv_Transporte(Me.Dgv_Transporte, s1, 0)
            Label10.Text = Me.Dgv_Transporte.RowCount
        ElseIf choice = 1 Then

            DatosTransporte.Dgv_Transporte(Me.Dgv_Transporte, s1, 1)

            Label10.Text = Me.Dgv_Transporte.RowCount
        End If

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscar.Text = ""
        Me.tb_buscar.Focus()
    End Sub

    Private Sub tb_Cedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Cedula.Leave

        muestra_label(sender, 1)

    End Sub

    Private Sub tb_Placa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Placa.Leave
        muestra_label(sender, 1)
    End Sub

    Private Sub tb_buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyDown
        If Dgv_Transporte.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.Dgv_Transporte.Rows(0).Cells(0).Selected = True
                Dgv_Transporte.Focus()

            End If
        End If

    End Sub


End Class

