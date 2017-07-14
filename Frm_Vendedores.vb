Public Class Frm_Vendedores
    Inherits System.Windows.Forms.Form
    Dim varboton As Integer = 0
    Private sw0 As Boolean = False
    Private user1 As String = ""
    Private sw As Boolean = False
    Private sw1 As Boolean = False
    Private sw2 As Boolean = False
    Private item As Object
    Private cuantos As Integer
    Private fila As Integer
    Friend WithEvents tb_banco As MTGCComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DGV_comision As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv_Vendedores As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Private choice As Integer
    Dim w As Boolean
    Friend WithEvents DiaI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_ocultaCom As System.Windows.Forms.CheckBox
    Friend WithEvents tb_password As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tb_user As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Dim e As Boolean


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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_cedula As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefono As System.Windows.Forms.TextBox
    Friend WithEvents tb_celular As System.Windows.Forms.TextBox
    Friend WithEvents tb_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents tb_obser As System.Windows.Forms.TextBox
    Friend WithEvents tb_dirEnvio As System.Windows.Forms.TextBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents tb_zona As MTGCComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Vendedores))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_ocultaCom = New System.Windows.Forms.CheckBox
        Me.tb_banco = New MTGCComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tb_zona = New MTGCComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_cuenta = New System.Windows.Forms.TextBox
        Me.tb_celular = New System.Windows.Forms.TextBox
        Me.tb_email = New System.Windows.Forms.TextBox
        Me.tb_telefono = New System.Windows.Forms.TextBox
        Me.tb_cedula = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_dirEnvio = New System.Windows.Forms.TextBox
        Me.tb_obser = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.DGV_comision = New System.Windows.Forms.DataGridView
        Me.DiaI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiaF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Dgv_Vendedores = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.tb_user = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tb_password = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.groupbox1.SuspendLayout()
        CType(Me.DGV_comision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(382, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(522, 23)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Comisiones Asociadas al Vendedor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.tb_password)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tb_user)
        Me.GroupBox2.Controls.Add(Me.chk_ocultaCom)
        Me.GroupBox2.Controls.Add(Me.tb_banco)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.tb_zona)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tb_cuenta)
        Me.GroupBox2.Controls.Add(Me.tb_celular)
        Me.GroupBox2.Controls.Add(Me.tb_email)
        Me.GroupBox2.Controls.Add(Me.tb_telefono)
        Me.GroupBox2.Controls.Add(Me.tb_cedula)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb_nombre)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tb_dirEnvio)
        Me.GroupBox2.Controls.Add(Me.tb_obser)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 266)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'chk_ocultaCom
        '
        Me.chk_ocultaCom.AutoSize = True
        Me.chk_ocultaCom.Enabled = False
        Me.chk_ocultaCom.Location = New System.Drawing.Point(13, 241)
        Me.chk_ocultaCom.Name = "chk_ocultaCom"
        Me.chk_ocultaCom.Size = New System.Drawing.Size(139, 19)
        Me.chk_ocultaCom.TabIndex = 63
        Me.chk_ocultaCom.Text = "Ocultar % Comisión"
        Me.chk_ocultaCom.UseVisualStyleBackColor = True
        '
        'tb_banco
        '
        Me.tb_banco.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_banco.ColumnNum = 2
        Me.tb_banco.ColumnWidth = "135;20"
        Me.tb_banco.DisplayMember = "Text"
        Me.tb_banco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_banco.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_banco.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_banco.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_banco.DropDownWidth = 175
        Me.tb_banco.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_banco.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_banco.GridLineHorizontal = False
        Me.tb_banco.GridLineVertical = False
        Me.tb_banco.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_banco.Location = New System.Drawing.Point(335, 45)
        Me.tb_banco.ManagingFastMouseMoving = True
        Me.tb_banco.ManagingFastMouseMovingInterval = 30
        Me.tb_banco.Name = "tb_banco"
        Me.tb_banco.Size = New System.Drawing.Size(181, 23)
        Me.tb_banco.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(165, 241)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 20)
        Me.Label22.TabIndex = 58
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(389, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 20)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "(*)Datos requeridos"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Red
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(170, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 20)
        Me.Label15.TabIndex = 59
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.Visible = False
        '
        'tb_zona
        '
        Me.tb_zona.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_zona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_zona.ColumnNum = 1
        Me.tb_zona.ColumnWidth = "121"
        Me.tb_zona.DisplayMember = "Text"
        Me.tb_zona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_zona.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_zona.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_zona.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_zona.DropDownWidth = 141
        Me.tb_zona.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_zona.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_zona.GridLineHorizontal = False
        Me.tb_zona.GridLineVertical = False
        Me.tb_zona.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_zona.Location = New System.Drawing.Point(86, 141)
        Me.tb_zona.ManagingFastMouseMoving = True
        Me.tb_zona.ManagingFastMouseMovingInterval = 30
        Me.tb_zona.Name = "tb_zona"
        Me.tb_zona.Size = New System.Drawing.Size(174, 23)
        Me.tb_zona.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 23)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "(*)Celular:"
        '
        'tb_cuenta
        '
        Me.tb_cuenta.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cuenta.Location = New System.Drawing.Point(335, 70)
        Me.tb_cuenta.MaxLength = 30
        Me.tb_cuenta.Name = "tb_cuenta"
        Me.tb_cuenta.Size = New System.Drawing.Size(181, 22)
        Me.tb_cuenta.TabIndex = 9
        '
        'tb_celular
        '
        Me.tb_celular.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_celular.Location = New System.Drawing.Point(86, 117)
        Me.tb_celular.MaxLength = 18
        Me.tb_celular.Name = "tb_celular"
        Me.tb_celular.Size = New System.Drawing.Size(174, 22)
        Me.tb_celular.TabIndex = 4
        '
        'tb_email
        '
        Me.tb_email.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.Location = New System.Drawing.Point(335, 21)
        Me.tb_email.MaxLength = 50
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(181, 22)
        Me.tb_email.TabIndex = 7
        '
        'tb_telefono
        '
        Me.tb_telefono.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono.Location = New System.Drawing.Point(86, 93)
        Me.tb_telefono.MaxLength = 18
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.Size = New System.Drawing.Size(174, 22)
        Me.tb_telefono.TabIndex = 4
        '
        'tb_cedula
        '
        Me.tb_cedula.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cedula.Location = New System.Drawing.Point(86, 69)
        Me.tb_cedula.MaxLength = 10
        Me.tb_cedula.Name = "tb_cedula"
        Me.tb_cedula.Size = New System.Drawing.Size(174, 22)
        Me.tb_cedula.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "(*)Zona:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "(*)Teléfono:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 29)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "(*)Cédula:"
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(86, 45)
        Me.tb_nombre.MaxLength = 20
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(174, 22)
        Me.tb_nombre.TabIndex = 2
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(86, 21)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(174, 22)
        Me.tb_codigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "(*)Nombre:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "(*)Código:"
        '
        'tb_dirEnvio
        '
        Me.tb_dirEnvio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dirEnvio.Location = New System.Drawing.Point(86, 166)
        Me.tb_dirEnvio.MaxLength = 200
        Me.tb_dirEnvio.Multiline = True
        Me.tb_dirEnvio.Name = "tb_dirEnvio"
        Me.tb_dirEnvio.Size = New System.Drawing.Size(430, 46)
        Me.tb_dirEnvio.TabIndex = 11
        '
        'tb_obser
        '
        Me.tb_obser.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obser.Location = New System.Drawing.Point(335, 94)
        Me.tb_obser.MaxLength = 250
        Me.tb_obser.Multiline = True
        Me.tb_obser.Name = "tb_obser"
        Me.tb_obser.Size = New System.Drawing.Size(181, 70)
        Me.tb_obser.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(278, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Obser.:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 23)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Dir. Envío:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(278, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Banco:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(278, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 23)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(278, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Cuenta:"
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
        Me.groupbox1.Controls.Add(Me.DGV_comision)
        Me.groupbox1.Location = New System.Drawing.Point(382, 297)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(522, 220)
        Me.groupbox1.TabIndex = 58
        Me.groupbox1.TabStop = False
        '
        'DGV_comision
        '
        Me.DGV_comision.AllowUserToAddRows = False
        Me.DGV_comision.AllowUserToDeleteRows = False
        Me.DGV_comision.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_comision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_comision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiaI, Me.DiaF, Me.Comision})
        Me.DGV_comision.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_comision.Location = New System.Drawing.Point(6, 13)
        Me.DGV_comision.Name = "DGV_comision"
        Me.DGV_comision.ReadOnly = True
        Me.DGV_comision.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_comision.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_comision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_comision.Size = New System.Drawing.Size(510, 202)
        Me.DGV_comision.TabIndex = 87
        '
        'DiaI
        '
        Me.DiaI.HeaderText = "Dia Inicial"
        Me.DiaI.Name = "DiaI"
        Me.DiaI.ReadOnly = True
        Me.DiaI.Width = 130
        '
        'DiaF
        '
        Me.DiaF.HeaderText = "Día Final"
        Me.DiaF.Name = "DiaF"
        Me.DiaF.ReadOnly = True
        Me.DiaF.Width = 130
        '
        'Comision
        '
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        Me.Comision.Width = 130
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(645, 522)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 13
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(552, 522)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
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
        Me.Label1.Location = New System.Drawing.Point(254, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 53
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
        Me.ToolBar1.Location = New System.Drawing.Point(-2, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(352, 65)
        Me.ToolBar1.TabIndex = 54
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(382, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(522, 23)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Datos del Vendedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(202, 64)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(146, 25)
        Me.tb_buscarcodigo.TabIndex = 63
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Dgv_Vendedores
        '
        Me.Dgv_Vendedores.AllowUserToAddRows = False
        Me.Dgv_Vendedores.AllowUserToDeleteRows = False
        Me.Dgv_Vendedores.AllowUserToResizeColumns = False
        Me.Dgv_Vendedores.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Vendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Vendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15})
        Me.Dgv_Vendedores.Location = New System.Drawing.Point(24, 98)
        Me.Dgv_Vendedores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dgv_Vendedores.MultiSelect = False
        Me.Dgv_Vendedores.Name = "Dgv_Vendedores"
        Me.Dgv_Vendedores.ReadOnly = True
        Me.Dgv_Vendedores.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_Vendedores.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_Vendedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Vendedores.Size = New System.Drawing.Size(325, 419)
        Me.Dgv_Vendedores.TabIndex = 95
        '
        'DataGridViewTextBoxColumn16
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn16.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 75
        '
        'DataGridViewTextBoxColumn15
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nombre del vendedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 230
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(24, 64)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 26)
        Me.DomainUpDown1.TabIndex = 96
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Usuario:"
        '
        'tb_user
        '
        Me.tb_user.Enabled = False
        Me.tb_user.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(86, 214)
        Me.tb_user.MaxLength = 18
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(174, 22)
        Me.tb_user.TabIndex = 64
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(267, 217)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 23)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Password:"
        '
        'tb_password
        '
        Me.tb_password.Enabled = False
        Me.tb_password.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(335, 214)
        Me.tb_password.MaxLength = 18
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(181, 22)
        Me.tb_password.TabIndex = 66
        Me.tb_password.UseSystemPasswordChar = True
        '
        'Frm_Vendedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(914, 552)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Dgv_Vendedores)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(50, 150)
        Me.MaximizeBox = False
        Me.Name = "Frm_Vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Vendedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupbox1.ResumeLayout(False)
        CType(Me.DGV_comision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.tb_codigo.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.tb_cuenta.ReadOnly = True
        Me.tb_cedula.ReadOnly = True
        Me.tb_celular.ReadOnly = True
        Me.tb_dirEnvio.ReadOnly = True
        Me.tb_email.ReadOnly = True
        Me.tb_telefono.ReadOnly = True
        Me.tb_obser.ReadOnly = True
        Me.tb_zona.Enabled = False
        Me.tb_banco.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0
        DatosVendedores.consulta_vendedores(Dgv_Vendedores)
        Label2.Text = Me.Dgv_Vendedores.RowCount
        DatosVendedores.consulta_zonas(Me.tb_zona)
        DatosBanco.consulta_bancos(Me.tb_banco)
        Dgv_Vendedores.ClearSelection()
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.chk_ocultaCom.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Public Sub ponerporcentaje()
        Try
            Dim i As Integer = 0

            For i = 0 To DGV_comision.RowCount - 1

                DGV_comision.Rows(i).Cells(2).Value = DGV_comision.Rows(i).Cells(2).Value.ToString & "%"

            Next
        Catch ex As Exception

        End Try


    End Sub

    Public Sub quitarporcentaje()

        Try
            Dim i As Integer = 0

            For i = 0 To DGV_comision.RowCount - 1

                DGV_comision.Rows(i).Cells(2).Value = DGV_comision.Rows(i).Cells(2).Value.ToString.Replace("%", "")

            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            Me.Close()
        ElseIf e.Button Is Me.bt_nuevo Then
            Me.DGV_comision.Rows.Clear()
            DatosConfiguracion.consulta_Comision(DGV_comision, 1)
            ponerporcentaje()
            varboton = 1
            chk_ocultaCom.Enabled = True
            user1 = ""
            Me.tb_zona.ResetText()
            Me.tb_banco.ResetText()
            Me.tb_zona.Items.Clear()
            Me.tb_banco.Items.Clear()
            Me.DGV_comision.AllowUserToAddRows = True
            Me.DGV_comision.ReadOnly = False
            Me.chk_ocultaCom.Checked = False
            Me.tb_obser.Clear()
            Me.tb_telefono.Clear()
            Me.tb_nombre.Clear()
            Me.tb_email.Clear()
            tb_user.Clear()
            tb_user.Enabled = True
            tb_password.Clear()
            tb_password.Enabled = True
            Me.tb_dirEnvio.Clear()
            Me.tb_codigo.Clear()
            Me.tb_celular.Clear()
            Me.tb_cedula.Clear()
            Me.tb_cuenta.Clear()
            DatosVendedores.consulta_ultimo_codigo(tb_codigo.Text)
            DatosVendedores.consulta_zonas(Me.tb_zona)
            DatosBanco.consulta_bancos(Me.tb_banco)
            Me.ToolBar1.Enabled = False
            Me.DomainUpDown1.Enabled = False
            Me.tb_buscarcodigo.Enabled = False
            Me.Dgv_Vendedores.Enabled = False
            Me.tb_codigo.Enabled = True
            Me.tb_codigo.ReadOnly = False
            Me.tb_nombre.ReadOnly = False
            Me.tb_cuenta.ReadOnly = False
            Me.tb_cedula.ReadOnly = False
            Me.tb_celular.ReadOnly = False
            Me.tb_dirEnvio.ReadOnly = False
            Me.tb_email.ReadOnly = False
            Me.tb_telefono.ReadOnly = False
            Me.tb_obser.ReadOnly = False
            Me.tb_zona.Enabled = True
            Me.tb_banco.Enabled = True
            'Me.DGV_comision.Columns(2).ReadOnly = False
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Dgv_Vendedores.Enabled = False

            'Me.DGV_comision.Rows.Add(1, 30, 5)
            'Me.DGV_comision.Rows.Add(31, 36, CDbl(4.5))
            'Me.DGV_comision.Rows.Add(37, 41, 4)
            'Me.DGV_comision.Rows.Add(42, 46, CDbl(3.5))
            'Me.DGV_comision.Rows.Add(47, 51, 3)
            'Me.DGV_comision.Rows.Add(52, 56, CDbl(2.5))
            'Me.DGV_comision.Rows.Add(57, 9999, 0)
            'Me.DGV_comision.ClearSelection()
            Dgv_Vendedores.ClearSelection()
            Dgv_Vendedores.Enabled = False
            Me.DomainUpDown1.SelectedIndex = 1
            RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.tb_buscarcodigo.Clear()
            AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            sw2 = True
            Me.tb_codigo.Focus()
            sw2 = False

        ElseIf e.Button Is Me.bt_modificar Then
            quitarporcentaje()
            varboton = 2
            Dim n1 As Integer
            n1 = Me.Dgv_Vendedores.SelectedRows.Count
            If n1 = 1 Then
                user1 = tb_user.Text
                Me.ToolBar1.Enabled = False
                Me.DomainUpDown1.Enabled = False
                Me.tb_buscarcodigo.Enabled = False
                Me.Dgv_Vendedores.Enabled = False
                Me.tb_codigo.ReadOnly = True
                Me.DGV_comision.AllowUserToAddRows = True
                chk_ocultaCom.Enabled = True
                Me.DGV_comision.ReadOnly = False
                Me.tb_nombre.ReadOnly = False
                Me.tb_cuenta.ReadOnly = False
                tb_user.Enabled = True
                tb_password.Enabled = True
                Dgv_Vendedores.Enabled = False
                Me.tb_cedula.ReadOnly = False
                Me.tb_celular.ReadOnly = False
                Me.tb_dirEnvio.ReadOnly = False
                Me.tb_email.ReadOnly = False
                Me.tb_telefono.ReadOnly = False
                Me.tb_obser.ReadOnly = False
                Me.tb_zona.Enabled = True
                Me.tb_banco.Enabled = True
                Me.DGV_comision.Columns(2).ReadOnly = False
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.Dgv_Vendedores.Enabled = False
                Me.DomainUpDown1.SelectedIndex = 1
                RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                Me.tb_buscarcodigo.Clear()
                AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                Me.tb_nombre.Focus()
            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el vendedor que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Sólo puede modificar un vendedor a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            varboton = 3
            If Me.Dgv_Vendedores.SelectedRows.Count = 0 Then
                MsgBox("Debe seleccionar el vendedor que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                Dim response As MsgBoxResult
                response = MsgBox("¿Confirma que desea eliminar este vendedor " & Dgv_Vendedores.SelectedRows(0).Cells(1).Value & "?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    Dim i As Integer = 0
                    DatosVendedores.elimina_vendedor(CInt(Me.Dgv_Vendedores.SelectedRows(0).Cells(0).Value))
                    user1 = ""
                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Vendedor Ha Sido eliminado Exitosamente", ToolTipIcon.Info)
                End If

                Me.tb_codigo.Clear()
                Me.tb_cuenta.Clear()
                Me.tb_cedula.Clear()
                Me.tb_celular.Clear()
                Me.tb_dirEnvio.Clear()
                Me.tb_email.Clear()
                Me.tb_nombre.Clear()
                Me.tb_telefono.Clear()
                Me.tb_obser.Clear()
                Me.tb_zona.ResetText()
                Me.tb_banco.ResetText()
                Dgv_Vendedores.Rows.Clear()
                DatosVendedores.consulta_vendedores(Me.Dgv_Vendedores)
                Label2.Text = Me.Dgv_Vendedores.RowCount
                Dgv_Vendedores.ClearSelection()
            End If
        End If
    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        sw2 = True
        Me.tb_codigo.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        chk_ocultaCom.Enabled = False
        Me.tb_cuenta.ReadOnly = True
        Me.tb_cedula.ReadOnly = True
        Me.tb_celular.ReadOnly = True
        Me.tb_dirEnvio.ReadOnly = True
        user1 = ""
        Me.tb_email.ReadOnly = True
        Me.tb_telefono.ReadOnly = True
        Me.tb_obser.ReadOnly = True
        Me.tb_zona.Enabled = False
        Me.tb_banco.Enabled = False
        Me.DGV_comision.Columns(2).ReadOnly = True
        Me.Dgv_Vendedores.Enabled = True
        Me.tb_codigo.Clear()
        Me.tb_cuenta.Clear()
        Me.tb_cedula.Clear()
        Dgv_Vendedores.Enabled = True
        Me.tb_celular.Clear()
        Me.tb_dirEnvio.Clear()
        Me.tb_email.Clear()
        tb_user.Clear()
        tb_user.Enabled = False
        tb_password.Clear()
        tb_password.Enabled = False
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_obser.Clear()
        Me.tb_zona.ResetText()
        Me.tb_banco.ResetText()
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.ToolBar1.Enabled = True
        Me.DomainUpDown1.Enabled = True
        Me.tb_buscarcodigo.Enabled = True
        Me.DGV_comision.AllowUserToAddRows = False
        Me.DGV_comision.ReadOnly = True
        Me.Dgv_Vendedores.Enabled = True
        varboton = 0
        Me.DomainUpDown1.SelectedItem = 1
        Me.tb_buscarcodigo.Text = ""
        tb_buscar_TextChanged(tb_buscarcodigo, New System.EventArgs)
        Me.tb_buscarcodigo.Focus()
        Me.DGV_comision.Rows.Clear()
        Dgv_Vendedores.ClearSelection()
        sw2 = False
    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_nombre.Text = "" Or Me.tb_cedula.Text = "" Or Me.tb_telefono.Text = "" Or Me.tb_celular.Text = "" Or Me.tb_zona.Text = "" Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function

    Private Function revisa_0() As Boolean
        Dim bool As Boolean = False
        Dim cont As Integer = 0
        While cont < Me.DGV_comision.Rows.Count - 1
            Dim c1 As Integer = Me.DGV_comision.Rows(cont).Cells(0).Value
            Dim c2 As Integer = Me.DGV_comision.Rows(cont).Cells(1).Value
            If c1 > c2 Then
                bool = True
            End If
            cont = cont + 1
        End While
        Return bool
    End Function

    Private Function revisa_vacio() As Boolean
        Dim bool As Boolean = False
        Dim cont As Integer = 0
        While cont < Me.DGV_comision.Rows.Count - 1
            If CStr(Me.DGV_comision.Rows(cont).Cells(0).Value) = "" Or CStr(Me.DGV_comision.Rows(cont).Cells(1).Value) = "" Or CStr(Me.DGV_comision.Rows(cont).Cells(2).Value) = "" Then
                bool = True
            End If
            cont = cont + 1
        End While
        Return bool
    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim hay As Boolean = False
        Dim usuario As Boolean = False

        quitarporcentaje()

        Dim deny As Boolean = False

        If varboton = 1 Then

            If llenos() Then

                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True

            Else

                DatosVendedores.consulta_codigo_existente(hay, CInt(tb_codigo.Text))
                DatosUsuarios.consulta_usuario_existe(tb_user.Text, usuario)

                If hay = False Then

                    If usuario = False Then

                        Dim varBanco As String

                        If Me.tb_banco.SelectedItem Is Nothing Then
                            varBanco = ""
                        Else
                            varBanco = Me.tb_banco.SelectedItem.Col2
                        End If

                        If revisa_vacio() Then

                            MsgBox("Debe ingresar todos los datos de la comisión.", MsgBoxStyle.Critical)
                            deny = True

                        Else

                            If revisa_0() Then
                                MsgBox("No se permite registrar una comisión donde el día inicial sea menor que el final.")
                                deny = True
                            Else

                                If tb_user.Text.Trim <> "" And tb_password.Text.Trim <> "" Then

                                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                                    '    DatosUsuarios.modifica_password_Dist(tb_user.Text, tb_password.Text, 2, user1, False)
                                    '    DatosUsuarios.modifica_password_comer(tb_user.Text, tb_password.Text, 2, user1, False)
                                    '    DatosUsuarios.modifica_password_CONAVE(tb_user.Text, tb_password.Text, 2, user1, False)

                                    'Else

                                    DatosUsuarios.modifica_password(tb_user.Text, tb_password.Text, 2, user1, False, tb_nombre.Text)

                                    'End If

                                End If

                                'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Then

                                '    DatosVendedores.inserta_vendedor_COMER(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                                '    DatosVendedores.inserta_vendedor_DIST(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                                '    DatosVendedores.inserta_vendedor_CONAVE(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                                '    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Vendedor Ha Sido Registrado Exitosamente", ToolTipIcon.Info)

                                'Else

                                DatosVendedores.inserta_vendedor(CInt(Me.tb_codigo.Text), Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)

                                'End If


                                'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Then

                                '    Dim resp As Integer = MsgBox("Desea replicar comisiones en las demás compañías?", MsgBoxStyle.YesNo, "Comisiones")

                                '    If resp = vbYes Then

                                '        If Me.DGV_comision.Rows.Count > 0 Then

                                '            Dim i As Integer = 0

                                '            While i < Me.DGV_comision.Rows.Count - 1
                                '                DatosVendedores.inserta_comision_COMER(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                '                DatosVendedores.inserta_comision_DIST(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                '                DatosVendedores.inserta_comision_CONAVE(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                '                i = i + 1
                                '            End While

                                '        End If

                                '    Else

                                '        If Me.DGV_comision.Rows.Count > 0 Then
                                '            Dim i As Integer = 0
                                '            While i < Me.DGV_comision.Rows.Count - 1
                                '                DatosVendedores.inserta_comision(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                '                i = i + 1
                                '            End While
                                '        End If

                                '    End If

                                'Else

                                If Me.DGV_comision.Rows.Count > 0 Then
                                    Dim i As Integer = 0
                                    While i < Me.DGV_comision.Rows.Count - 1
                                        DatosVendedores.inserta_comision(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                        i = i + 1
                                    End While
                                End If

                                'End If

                                Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Vendedor Ha Sido Registrado Exitosamente", ToolTipIcon.Info)

                            End If

                        End If

                    Else

                        MsgBox("El usuario ya se encuentra registrado", MsgBoxStyle.Critical)
                        deny = True
                        tb_user.Focus()
                        tb_user.SelectAll()

                    End If

                Else

                    MsgBox("El código del vendedor ya se encuentra registrado", MsgBoxStyle.Critical)
                    deny = True
                    tb_codigo.Focus()
                    tb_codigo.SelectAll()

                End If

            End If

        ElseIf varboton = 2 Then

            If llenos() Then

                MsgBox("Debe ingresar todos los datos requeridos (*)", MsgBoxStyle.Critical)
                deny = True

            Else

                Dim varBanco As String

                If Me.tb_banco.SelectedItem Is Nothing Then
                    varBanco = ""
                Else
                    varBanco = Me.tb_banco.SelectedItem.Col2
                End If

                If revisa_vacio() Then

                    MsgBox("Debe ingresar todos los datos de la comisión.")
                    deny = True

                Else

                    If revisa_0() Then

                        MsgBox("No se permite registrar una comisión donde el día inicial sea menor que el final.")
                        deny = True

                    Else

                        Dim detener As Boolean = False

                        If tb_user.Text.Trim <> "" And tb_password.Text.Trim <> "" Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                            '    DatosUsuarios.modifica_password_Dist(tb_user.Text, tb_password.Text, 2, user1, False)
                            '    DatosUsuarios.modifica_password_comer(tb_user.Text, tb_password.Text, 2, user1, False)
                            '    DatosUsuarios.modifica_password_CONAVE(tb_user.Text, tb_password.Text, 2, user1, False)

                            'Else

                            DatosUsuarios.modifica_password(tb_user.Text, tb_password.Text, 2, user1, False, tb_nombre.Text)

                            'End If

                        End If

                        If detener = False Then

                            'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Then

                            '    DatosVendedores.modifica_vendedor_COMER(Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, CInt(Me.tb_codigo.Text), chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                            '    DatosVendedores.modifica_vendedor_DIST(Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, CInt(Me.tb_codigo.Text), chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                            '    DatosVendedores.modifica_vendedor_CONAVE(Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, CInt(Me.tb_codigo.Text), chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
                            '    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Vendedor Ha Sido Registrado Exitosamente", ToolTipIcon.Info)

                            'Else

                            DatosVendedores.modifica_vendedor(Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_cuenta.Text, Me.tb_email.Text, tb_zona.SelectedItem.Col2, varBanco, Me.tb_dirEnvio.Text, Me.tb_obser.Text, CInt(Me.tb_codigo.Text), chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)

                            'End If


                            'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Then

                            '    Dim resp As Integer = MsgBox("Desea replicar comisiones en las demás compañías?", MsgBoxStyle.YesNo, "Comisiones")

                            '    If resp = vbYes Then

                            '        If Me.DGV_comision.Rows.Count > 0 Then
                            '            DatosVendedores.elimina_comision_COMER(CInt(Me.tb_codigo.Text))
                            '            DatosVendedores.elimina_comision_DIST(CInt(Me.tb_codigo.Text))
                            '            DatosVendedores.elimina_comision_CONAVE(CInt(Me.tb_codigo.Text))
                            '            Dim i As Integer = 0
                            '            While i < Me.DGV_comision.Rows.Count - 1
                            '                DatosVendedores.inserta_comision_COMER(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                            '                DatosVendedores.inserta_comision_DIST(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                            '                DatosVendedores.inserta_comision_CONAVE(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                            '                i = i + 1
                            '            End While
                            '        End If

                            '    Else

                            'If Me.DGV_comision.Rows.Count > 0 Then

                            '    DatosVendedores.elimina_comision(CInt(Me.tb_codigo.Text))

                            '    Dim i As Integer = 0

                            '    While i < Me.DGV_comision.Rows.Count - 1
                            '        DatosVendedores.inserta_comision(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                            '        i = i + 1
                            '    End While

                            'End If

                            'End If

                            'Else

                            If Me.DGV_comision.Rows.Count > 0 Then

                                DatosVendedores.elimina_comision(CInt(Me.tb_codigo.Text))

                                Dim i As Integer = 0

                                While i < Me.DGV_comision.Rows.Count - 1
                                    DatosVendedores.inserta_comision(CInt(Me.tb_codigo.Text), Me.DGV_comision.Rows(i).Cells(0).Value, Me.DGV_comision.Rows(i).Cells(1).Value, Me.DGV_comision.Rows(i).Cells(2).Value)
                                    i = i + 1
                                End While

                            End If

                            'End If

                            Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Vendedor Ha Sido Modificado Exitosamente", ToolTipIcon.Info)

                        Else

                            MsgBox("El usuario ya se encuentra registrado", MsgBoxStyle.Critical)
                            deny = True
                            tb_codigo.Focus()
                            tb_codigo.SelectAll()

                    End If

                End If
            End If

        End If

        End If

        If deny = False Then

            sw2 = True
            Me.DGV_comision.Rows.Clear()
            Me.tb_codigo.ReadOnly = True
            Me.tb_nombre.ReadOnly = True
            Me.tb_cuenta.ReadOnly = True
            Me.tb_cedula.ReadOnly = True
            Me.tb_celular.ReadOnly = True
            Me.tb_dirEnvio.ReadOnly = True
            Me.tb_email.ReadOnly = True
            Me.tb_telefono.ReadOnly = True
            Me.tb_obser.ReadOnly = True
            user1 = ""
            Me.tb_zona.Enabled = False
            Me.tb_banco.Enabled = False
            Me.DGV_comision.Columns(2).ReadOnly = True
            Me.Dgv_Vendedores.Enabled = True
            Me.tb_codigo.Clear()
            Me.tb_cuenta.Clear()
            Me.tb_cedula.Clear()
            Me.DGV_comision.AllowUserToAddRows = False
            Me.DGV_comision.ReadOnly = True
            Me.tb_celular.Clear()
            Me.tb_dirEnvio.Clear()
            Me.tb_email.Clear()
            tb_user.Clear()
            Dgv_Vendedores.Enabled = True
            tb_user.Enabled = False
            tb_password.Clear()
            tb_password.Enabled = False
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.tb_obser.Clear()
            chk_ocultaCom.Enabled = False
            Me.tb_zona.ResetText()
            Me.tb_banco.ResetText()
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.ToolBar1.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.tb_buscarcodigo.Enabled = True
            Me.Dgv_Vendedores.Enabled = True
            varboton = 0
            Me.DomainUpDown1.SelectedItem = 1
            Me.tb_buscarcodigo.Text = ""
            DatosVendedores.consulta_vendedores(Me.Dgv_Vendedores)
            Dgv_Vendedores.ClearSelection()
            Label2.Text = Me.Dgv_Vendedores.RowCount
            Dgv_Vendedores.ClearSelection()
            Me.tb_buscarcodigo.Focus()
            sw2 = False
        End If

    End Sub

    Private Sub Form11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, Label1.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click, DomainUpDown1.Click, groupbox1.Click, GroupBox2.Click
        If Me.Dgv_Vendedores.Enabled = True Then
            Me.tb_zona.ResetText()
            Me.tb_zona.Items.Clear()
            Me.tb_banco.ResetText()
            Me.tb_banco.Items.Clear()
            Me.tb_obser.Clear()
            Me.tb_telefono.Clear()
            Me.tb_nombre.Clear()
            Me.tb_email.Clear()
            Me.tb_dirEnvio.Clear()
            Me.tb_codigo.Clear()
            Me.tb_celular.Clear()
            Me.tb_cedula.Clear()
            Me.tb_cuenta.Clear()
        End If
        Me.Dgv_Vendedores.ClearSelection()

    End Sub


    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Me.Dgv_Vendedores.Enabled = True Then
            Dim s1 As String
            s1 = Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then
                DatosVendedores.lv_vendedor(Me.Dgv_Vendedores, s1, 0)
                Label2.Text = Me.Dgv_Vendedores.RowCount
                Dgv_Vendedores.ClearSelection()
            ElseIf choice = 1 Then
                s1 = "%" + s1
                DatosVendedores.lv_vendedor(Me.Dgv_Vendedores, s1, 1)
                Label2.Text = Me.Dgv_Vendedores.RowCount
                Dgv_Vendedores.ClearSelection()
            End If
            Me.tb_codigo.Clear()
            Me.tb_cuenta.Clear()
            Me.tb_cedula.Clear()
            Me.tb_celular.Clear()
            Me.tb_dirEnvio.Clear()
            Me.tb_email.Clear()
            Me.chk_ocultaCom.Checked = False
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.tb_obser.Clear()
            DGV_comision.Rows.Clear()

        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged

        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_telefono.KeyPress, tb_celular.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "(" Or e.KeyChar = ")" Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
    End Sub
    Private Sub tb_ced_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cedula.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
    End Sub

    Private Sub tb_derecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-" Then
            e.Handled = False
            muestra_label2(sender, 1)
        Else
            e.Handled = True
            muestra_label2(sender, 0)
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
            Me.Label22.Text = "      Ingrese sólo números"
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub
    Public Sub muestra_label2(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label15.Visible = True
            Me.Label15.Text = "Sólo números y (,)"
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label15.Visible = False
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_cedula.LostFocus, tb_celular.LostFocus, tb_telefono.LostFocus
        muestra_label(sender, 1)
    End Sub
    Private Sub tb_2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_cuenta.LostFocus, tb_dirEnvio.LostFocus
        muestra_label2(sender, 1)
    End Sub

    Private Sub DGV_comision_CellContentClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_comision.KeyDown, DGV_comision.KeyUp, DGV_comision.CellClick
        Try
            DGV_comision.CurrentRow.Cells(2).Selected = True
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Verificar() Handles DGV_comision.CellEndEdit
        Try

            If sw2 = False Then

                If varboton = 2 Then
                    If Convert.ToString(DGV_comision.CurrentRow.Cells(2).Value) = "" Then
                        DGV_comision.CurrentRow.Cells(2).Value = 0
                    Else
                        Convert.ToDouble(DGV_comision.CurrentRow.Cells(2).Value.ToString.Replace("%", ""))
                    End If
                Else
                    If Not DGV_comision.CurrentRow.Cells(2).Value = "" Then
                        Convert.ToDouble(DGV_comision.CurrentRow.Cells(2).Value.ToString.Replace("%", ""))
                    Else
                        DGV_comision.CurrentRow.Cells(2).Value = "0"
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Introduzca solo números", MsgBoxStyle.Critical)
            DGV_comision.CurrentRow.Cells(2).Value = ""
        End Try
    End Sub

    Private Sub Dgv_Vendedores_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_Vendedores.CellClick, Dgv_Vendedores.KeyDown, Dgv_Vendedores.KeyUp
        If Not (Dgv_Vendedores.SelectedRows.Count = 0) Then
            Dim cod As Integer = 0
            cod = CInt(Dgv_Vendedores.SelectedRows(0).Cells(0).Value)
            DatosVendedores.consulta_vendedor(cod, Me.tb_codigo.Text, Me.tb_nombre.Text, Me.tb_cedula.Text, Me.tb_telefono.Text, Me.tb_celular.Text, Me.tb_email.Text, Me.tb_cuenta.Text, Me.tb_zona, Me.tb_dirEnvio.Text, Me.tb_banco, Me.tb_obser.Text, chk_ocultaCom.Checked, tb_user.Text, tb_password.Text)
            DatosVendedores.consulta_comisiones(Me.DGV_comision, cod)
        End If
        ponerporcentaje()
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown

        If Dgv_Vendedores.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.Dgv_Vendedores.Rows(0).Cells(0).Selected = True
                Dgv_Vendedores.Focus()

            End If
        End If


    End Sub



End Class
