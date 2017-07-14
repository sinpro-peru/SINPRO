<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Marca_Modelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Marca_Modelo))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Marcas = New System.Windows.Forms.DataGridView
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_reporte = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.DGV_MarcaModelo = New System.Windows.Forms.DataGridView
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ano = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Motor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Puertas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblLogo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.bt_foto = New System.Windows.Forms.Button
        Me.bt_LimpiarLogo = New System.Windows.Forms.Button
        Me.tb_foto = New System.Windows.Forms.TextBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.gb_catalogo = New System.Windows.Forms.GroupBox
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_regresar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.DGV_MarcaCatalogo = New System.Windows.Forms.DataGridView
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaCatalogo2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Bt_ModificarModelo = New System.Windows.Forms.Button
        Me.bt_EliminarModelo = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.bt_LimpiarFoto = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Cbac_Ano = New Tesis_Nueva.ComboBoxAutoComplete
        Me.Cbac_Version = New Tesis_Nueva.ComboBoxAutoComplete
        Me.LblModelo = New System.Windows.Forms.Label
        Me.Cbac_Puertas = New Tesis_Nueva.ComboBoxAutoComplete
        Me.LblAno = New System.Windows.Forms.Label
        Me.Cbac_Motor = New Tesis_Nueva.ComboBoxAutoComplete
        Me.LblMotor = New System.Windows.Forms.Label
        Me.LblPuertas = New System.Windows.Forms.Label
        Me.Cbac_Modelo = New Tesis_Nueva.ComboBoxAutoComplete
        Me.LblVersion = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.LblObs = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Tb_Obs = New System.Windows.Forms.RichTextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.Bt_FinalizarModelo = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MELDataSet3 = New Tesis_Nueva.MELDataSet3
        Me.SpconsultaMarcaLikeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaMarcaLikeTableAdapter = New Tesis_Nueva.MELDataSet3TableAdapters.sp_consultaMarcaLikeTableAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DomainUpDown2 = New System.Windows.Forms.ComboBox
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaMarcaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
        Me.Sp_consultaCatalogo2TableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogo2TableAdapter
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        CType(Me.DGV_MarcaModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_catalogo.SuspendLayout()
        CType(Me.DGV_MarcaCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaCatalogo2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaMarcaLikeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(-361, -77)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.ReadOnly = True
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 22)
        Me.DomainUpDown1.TabIndex = 10007
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-64, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 10003
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(-16, -150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(679, 23)
        Me.Label3.TabIndex = 10004
        Me.Label3.Text = "Datos del Producto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(-173, -74)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(149, 22)
        Me.tb_buscarcodigo.TabIndex = 10006
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-120, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 10001
        Me.Label1.Text = "Total:"
        '
        'DGV_Marcas
        '
        Me.DGV_Marcas.AllowUserToAddRows = False
        Me.DGV_Marcas.AllowUserToDeleteRows = False
        Me.DGV_Marcas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Marcas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Marcas.AutoGenerateColumns = False
        Me.DGV_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Marcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarcaDataGridViewTextBoxColumn})
        Me.DGV_Marcas.DataSource = Me.SpconsultaMarcaBindingSource
        Me.DGV_Marcas.EnableHeadersVisualStyles = False
        Me.DGV_Marcas.Location = New System.Drawing.Point(12, 110)
        Me.DGV_Marcas.MultiSelect = False
        Me.DGV_Marcas.Name = "DGV_Marcas"
        Me.DGV_Marcas.ReadOnly = True
        Me.DGV_Marcas.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Marcas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Marcas.Size = New System.Drawing.Size(338, 429)
        Me.DGV_Marcas.TabIndex = 10011
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpconsultaMarcaBindingSource
        '
        Me.SpconsultaMarcaBindingSource.DataMember = "sp_consultaMarca"
        Me.SpconsultaMarcaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_reporte, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(10, -5)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(338, 65)
        Me.ToolBar1.TabIndex = 10009
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
        'bt_reporte
        '
        Me.bt_reporte.ImageIndex = 4
        Me.bt_reporte.Name = "bt_reporte"
        Me.bt_reporte.Text = "Catálogo"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 3
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
        Me.ImageList2.Images.SetKeyName(4, "Report.png")
        '
        'groupbox1
        '
        Me.groupbox1.AutoSize = True
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.Label22)
        Me.groupbox1.Controls.Add(Me.DGV_MarcaModelo)
        Me.groupbox1.Controls.Add(Me.LblLogo)
        Me.groupbox1.Controls.Add(Me.Panel1)
        Me.groupbox1.Controls.Add(Me.bt_foto)
        Me.groupbox1.Controls.Add(Me.bt_LimpiarLogo)
        Me.groupbox1.Controls.Add(Me.tb_foto)
        Me.groupbox1.Controls.Add(Me.tb_nombre)
        Me.groupbox1.Controls.Add(Me.Lbl_Nombre)
        Me.groupbox1.Controls.Add(Me.gb_catalogo)
        Me.groupbox1.Controls.Add(Me.GroupBox2)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Label8)
        Me.groupbox1.Location = New System.Drawing.Point(356, 16)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(679, 583)
        Me.groupbox1.TabIndex = 10010
        Me.groupbox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(9, 527)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 26)
        Me.Label22.TabIndex = 74
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label22.Visible = False
        '
        'DGV_MarcaModelo
        '
        Me.DGV_MarcaModelo.AllowUserToAddRows = False
        Me.DGV_MarcaModelo.AllowUserToDeleteRows = False
        Me.DGV_MarcaModelo.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_MarcaModelo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_MarcaModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MarcaModelo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modelo, Me.Ano, Me.Motor, Me.Puertas, Me.Version, Me.Observacion})
        Me.DGV_MarcaModelo.EnableHeadersVisualStyles = False
        Me.DGV_MarcaModelo.Location = New System.Drawing.Point(6, 38)
        Me.DGV_MarcaModelo.Name = "DGV_MarcaModelo"
        Me.DGV_MarcaModelo.ReadOnly = True
        Me.DGV_MarcaModelo.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_MarcaModelo.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_MarcaModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_MarcaModelo.Size = New System.Drawing.Size(504, 147)
        Me.DGV_MarcaModelo.TabIndex = 10012
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'Ano
        '
        Me.Ano.HeaderText = "Año"
        Me.Ano.Name = "Ano"
        Me.Ano.ReadOnly = True
        Me.Ano.Width = 49
        '
        'Motor
        '
        Me.Motor.HeaderText = "Motor"
        Me.Motor.Name = "Motor"
        Me.Motor.ReadOnly = True
        Me.Motor.Width = 50
        '
        'Puertas
        '
        Me.Puertas.HeaderText = "Puertas"
        Me.Puertas.Name = "Puertas"
        Me.Puertas.ReadOnly = True
        Me.Puertas.Width = 55
        '
        'Version
        '
        Me.Version.HeaderText = "Versión"
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.Width = 80
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 145
        '
        'LblLogo
        '
        Me.LblLogo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblLogo.Location = New System.Drawing.Point(436, 15)
        Me.LblLogo.Name = "LblLogo"
        Me.LblLogo.Size = New System.Drawing.Size(43, 20)
        Me.LblLogo.TabIndex = 94
        Me.LblLogo.Text = "Logo:"
        Me.LblLogo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(515, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 150)
        Me.Panel1.TabIndex = 75
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bt_foto
        '
        Me.bt_foto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_foto.Image = CType(resources.GetObject("bt_foto.Image"), System.Drawing.Image)
        Me.bt_foto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_foto.Location = New System.Drawing.Point(485, 15)
        Me.bt_foto.Name = "bt_foto"
        Me.bt_foto.Size = New System.Drawing.Size(25, 22)
        Me.bt_foto.TabIndex = 25
        Me.bt_foto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_foto.Visible = False
        '
        'bt_LimpiarLogo
        '
        Me.bt_LimpiarLogo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_LimpiarLogo.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_LimpiarLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_LimpiarLogo.Location = New System.Drawing.Point(645, 16)
        Me.bt_LimpiarLogo.Name = "bt_LimpiarLogo"
        Me.bt_LimpiarLogo.Size = New System.Drawing.Size(25, 21)
        Me.bt_LimpiarLogo.TabIndex = 121
        Me.bt_LimpiarLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_LimpiarLogo.Visible = False
        '
        'tb_foto
        '
        Me.tb_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_foto.Location = New System.Drawing.Point(518, 15)
        Me.tb_foto.Name = "tb_foto"
        Me.tb_foto.ReadOnly = True
        Me.tb_foto.Size = New System.Drawing.Size(121, 22)
        Me.tb_foto.TabIndex = 12
        Me.tb_foto.Visible = False
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(82, 13)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(157, 22)
        Me.tb_nombre.TabIndex = 2
        Me.tb_nombre.Visible = False
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Nombre.Location = New System.Drawing.Point(3, 15)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Nombre.TabIndex = 1
        Me.Lbl_Nombre.Text = "(*) Nombre:"
        Me.Lbl_Nombre.Visible = False
        '
        'gb_catalogo
        '
        Me.gb_catalogo.BackColor = System.Drawing.Color.DodgerBlue
        Me.gb_catalogo.Controls.Add(Me.chk_exist)
        Me.gb_catalogo.Controls.Add(Me.Label7)
        Me.gb_catalogo.Controls.Add(Me.bt_regresar)
        Me.gb_catalogo.Controls.Add(Me.Label6)
        Me.gb_catalogo.Controls.Add(Me.DGV_MarcaCatalogo)
        Me.gb_catalogo.Location = New System.Drawing.Point(9, 202)
        Me.gb_catalogo.Name = "gb_catalogo"
        Me.gb_catalogo.Size = New System.Drawing.Size(650, 326)
        Me.gb_catalogo.TabIndex = 120
        Me.gb_catalogo.TabStop = False
        Me.gb_catalogo.Text = "Catálogo de Productos"
        Me.gb_catalogo.Visible = False
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.Location = New System.Drawing.Point(548, 17)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(74, 19)
        Me.chk_exist.TabIndex = 10017
        Me.chk_exist.Text = "Exist. > 0"
        Me.chk_exist.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(594, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 23)
        Me.Label7.TabIndex = 10016
        Me.Label7.Text = "#"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_regresar
        '
        Me.bt_regresar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_regresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_regresar.Location = New System.Drawing.Point(562, 296)
        Me.bt_regresar.Name = "bt_regresar"
        Me.bt_regresar.Size = New System.Drawing.Size(75, 23)
        Me.bt_regresar.TabIndex = 125
        Me.bt_regresar.Text = "Regresar"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(544, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 23)
        Me.Label6.TabIndex = 10015
        Me.Label6.Text = "Total:"
        '
        'DGV_MarcaCatalogo
        '
        Me.DGV_MarcaCatalogo.AllowUserToAddRows = False
        Me.DGV_MarcaCatalogo.AllowUserToDeleteRows = False
        Me.DGV_MarcaCatalogo.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_MarcaCatalogo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_MarcaCatalogo.AutoGenerateColumns = False
        Me.DGV_MarcaCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MarcaCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModeloDataGridViewTextBoxColumn, Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn1})
        Me.DGV_MarcaCatalogo.DataSource = Me.SpconsultaCatalogo2BindingSource
        Me.DGV_MarcaCatalogo.EnableHeadersVisualStyles = False
        Me.DGV_MarcaCatalogo.Location = New System.Drawing.Point(6, 40)
        Me.DGV_MarcaCatalogo.Name = "DGV_MarcaCatalogo"
        Me.DGV_MarcaCatalogo.ReadOnly = True
        Me.DGV_MarcaCatalogo.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_MarcaCatalogo.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_MarcaCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_MarcaCatalogo.Size = New System.Drawing.Size(638, 232)
        Me.DGV_MarcaCatalogo.TabIndex = 10012
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 130
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
        Me.NombreDataGridViewTextBoxColumn.Width = 193
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "Exist."
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Width = 50
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "#,##0.00"
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 65
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "#,##0.00"
        Me.CostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo P."
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        Me.CostoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoPromedioDataGridViewTextBoxColumn.Width = 80
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn1.Visible = False
        '
        'SpconsultaCatalogo2BindingSource
        '
        Me.SpconsultaCatalogo2BindingSource.DataMember = "sp_consultaCatalogo2"
        Me.SpconsultaCatalogo2BindingSource.DataSource = Me.MELDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Bt_ModificarModelo)
        Me.GroupBox2.Controls.Add(Me.bt_EliminarModelo)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.bt_LimpiarFoto)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Cbac_Ano)
        Me.GroupBox2.Controls.Add(Me.Cbac_Version)
        Me.GroupBox2.Controls.Add(Me.LblModelo)
        Me.GroupBox2.Controls.Add(Me.Cbac_Puertas)
        Me.GroupBox2.Controls.Add(Me.LblAno)
        Me.GroupBox2.Controls.Add(Me.Cbac_Motor)
        Me.GroupBox2.Controls.Add(Me.LblMotor)
        Me.GroupBox2.Controls.Add(Me.LblPuertas)
        Me.GroupBox2.Controls.Add(Me.Cbac_Modelo)
        Me.GroupBox2.Controls.Add(Me.LblVersion)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.LblObs)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Tb_Obs)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(9, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(650, 342)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar/Modificar Modelos"
        '
        'Bt_ModificarModelo
        '
        Me.Bt_ModificarModelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_ModificarModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_ModificarModelo.Location = New System.Drawing.Point(282, 289)
        Me.Bt_ModificarModelo.Name = "Bt_ModificarModelo"
        Me.Bt_ModificarModelo.Size = New System.Drawing.Size(75, 23)
        Me.Bt_ModificarModelo.TabIndex = 126
        Me.Bt_ModificarModelo.Text = "Modificar"
        Me.Bt_ModificarModelo.Visible = False
        '
        'bt_EliminarModelo
        '
        Me.bt_EliminarModelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_EliminarModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_EliminarModelo.Location = New System.Drawing.Point(194, 289)
        Me.bt_EliminarModelo.Name = "bt_EliminarModelo"
        Me.bt_EliminarModelo.Size = New System.Drawing.Size(75, 23)
        Me.bt_EliminarModelo.TabIndex = 124
        Me.bt_EliminarModelo.Text = "Eliminar"
        Me.bt_EliminarModelo.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(106, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Agregar"
        Me.Button2.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(377, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 20)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Foto:"
        Me.Label11.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(391, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 177)
        Me.Panel2.TabIndex = 122
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(57, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 131)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'bt_LimpiarFoto
        '
        Me.bt_LimpiarFoto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_LimpiarFoto.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_LimpiarFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_LimpiarFoto.Location = New System.Drawing.Point(612, 29)
        Me.bt_LimpiarFoto.Name = "bt_LimpiarFoto"
        Me.bt_LimpiarFoto.Size = New System.Drawing.Size(25, 21)
        Me.bt_LimpiarFoto.TabIndex = 121
        Me.bt_LimpiarFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_LimpiarFoto.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(426, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 121
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(459, 28)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(147, 22)
        Me.TextBox7.TabIndex = 120
        Me.TextBox7.Visible = False
        '
        'Cbac_Ano
        '
        Me.Cbac_Ano.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Ano.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Ano.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Ano.FormattingEnabled = True
        Me.Cbac_Ano.Location = New System.Drawing.Point(92, 60)
        Me.Cbac_Ano.Name = "Cbac_Ano"
        Me.Cbac_Ano.Size = New System.Drawing.Size(130, 23)
        Me.Cbac_Ano.TabIndex = 116
        '
        'Cbac_Version
        '
        Me.Cbac_Version.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Version.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Version.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Version.FormattingEnabled = True
        Me.Cbac_Version.Location = New System.Drawing.Point(92, 156)
        Me.Cbac_Version.Name = "Cbac_Version"
        Me.Cbac_Version.Size = New System.Drawing.Size(130, 23)
        Me.Cbac_Version.TabIndex = 119
        '
        'LblModelo
        '
        Me.LblModelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblModelo.Location = New System.Drawing.Point(6, 28)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(80, 23)
        Me.LblModelo.TabIndex = 98
        Me.LblModelo.Text = "(*) Modelo:"
        '
        'Cbac_Puertas
        '
        Me.Cbac_Puertas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Puertas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Puertas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Puertas.FormattingEnabled = True
        Me.Cbac_Puertas.Location = New System.Drawing.Point(92, 124)
        Me.Cbac_Puertas.Name = "Cbac_Puertas"
        Me.Cbac_Puertas.Size = New System.Drawing.Size(130, 23)
        Me.Cbac_Puertas.TabIndex = 118
        '
        'LblAno
        '
        Me.LblAno.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAno.Location = New System.Drawing.Point(6, 60)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(54, 23)
        Me.LblAno.TabIndex = 100
        Me.LblAno.Text = "(*) Año:"
        '
        'Cbac_Motor
        '
        Me.Cbac_Motor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Motor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Motor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Motor.FormattingEnabled = True
        Me.Cbac_Motor.Location = New System.Drawing.Point(92, 92)
        Me.Cbac_Motor.Name = "Cbac_Motor"
        Me.Cbac_Motor.Size = New System.Drawing.Size(130, 23)
        Me.Cbac_Motor.TabIndex = 117
        '
        'LblMotor
        '
        Me.LblMotor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMotor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblMotor.Location = New System.Drawing.Point(6, 92)
        Me.LblMotor.Name = "LblMotor"
        Me.LblMotor.Size = New System.Drawing.Size(72, 23)
        Me.LblMotor.TabIndex = 102
        Me.LblMotor.Text = "(*) Motor:"
        '
        'LblPuertas
        '
        Me.LblPuertas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuertas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPuertas.Location = New System.Drawing.Point(6, 124)
        Me.LblPuertas.Name = "LblPuertas"
        Me.LblPuertas.Size = New System.Drawing.Size(80, 23)
        Me.LblPuertas.TabIndex = 104
        Me.LblPuertas.Text = "(*) Puertas:"
        '
        'Cbac_Modelo
        '
        Me.Cbac_Modelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbac_Modelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbac_Modelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbac_Modelo.FormattingEnabled = True
        Me.Cbac_Modelo.Location = New System.Drawing.Point(92, 28)
        Me.Cbac_Modelo.Name = "Cbac_Modelo"
        Me.Cbac_Modelo.Size = New System.Drawing.Size(130, 23)
        Me.Cbac_Modelo.TabIndex = 115
        '
        'LblVersion
        '
        Me.LblVersion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVersion.Location = New System.Drawing.Point(6, 156)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(80, 23)
        Me.LblVersion.TabIndex = 106
        Me.LblVersion.Text = "(*) Versión:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(228, 156)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(118, 22)
        Me.TextBox6.TabIndex = 114
        Me.TextBox6.Visible = False
        '
        'LblObs
        '
        Me.LblObs.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblObs.Location = New System.Drawing.Point(6, 188)
        Me.LblObs.Name = "LblObs"
        Me.LblObs.Size = New System.Drawing.Size(54, 23)
        Me.LblObs.TabIndex = 108
        Me.LblObs.Text = "Obs:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(228, 124)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(118, 22)
        Me.TextBox5.TabIndex = 113
        Me.TextBox5.Visible = False
        '
        'Tb_Obs
        '
        Me.Tb_Obs.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Obs.Location = New System.Drawing.Point(92, 188)
        Me.Tb_Obs.Name = "Tb_Obs"
        Me.Tb_Obs.Size = New System.Drawing.Size(254, 51)
        Me.Tb_Obs.TabIndex = 109
        Me.Tb_Obs.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(228, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(118, 22)
        Me.TextBox4.TabIndex = 112
        Me.TextBox4.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(228, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 22)
        Me.TextBox2.TabIndex = 110
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(228, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(118, 22)
        Me.TextBox3.TabIndex = 111
        Me.TextBox3.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(454, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 23)
        Me.Label9.TabIndex = 10016
        Me.Label9.Text = "#"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(407, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 23)
        Me.Label8.TabIndex = 10015
        Me.Label8.Text = "Total:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_cancelar.Location = New System.Drawing.Point(841, 518)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 129
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        Me.bt_cancelar.Visible = False
        '
        'Bt_FinalizarModelo
        '
        Me.Bt_FinalizarModelo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_FinalizarModelo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_FinalizarModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_FinalizarModelo.Location = New System.Drawing.Point(741, 518)
        Me.Bt_FinalizarModelo.Name = "Bt_FinalizarModelo"
        Me.Bt_FinalizarModelo.Size = New System.Drawing.Size(75, 23)
        Me.Bt_FinalizarModelo.TabIndex = 128
        Me.Bt_FinalizarModelo.Text = "Aceptar"
        Me.Bt_FinalizarModelo.UseVisualStyleBackColor = False
        Me.Bt_FinalizarModelo.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(356, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(679, 23)
        Me.Label17.TabIndex = 10012
        Me.Label17.Text = "Datos del Producto"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(201, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 25)
        Me.TextBox1.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos de Imágenes|*.jpg"
        Me.OpenFileDialog1.Title = "Explorador de Archivos"
        '
        'MELDataSet3
        '
        Me.MELDataSet3.DataSetName = "MELDataSet3"
        Me.MELDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpconsultaMarcaLikeBindingSource
        '
        Me.SpconsultaMarcaLikeBindingSource.DataMember = "sp_consultaMarcaLike"
        Me.SpconsultaMarcaLikeBindingSource.DataSource = Me.MELDataSet3
        '
        'Sp_consultaMarcaLikeTableAdapter
        '
        Me.Sp_consultaMarcaLikeTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(256, 548)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 10015
        Me.Label4.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(303, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 23)
        Me.Label5.TabIndex = 10016
        Me.Label5.Text = "#"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown2.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown2.FormattingEnabled = True
        Me.DomainUpDown2.Items.AddRange(New Object() {"Marca"})
        Me.DomainUpDown2.Location = New System.Drawing.Point(12, 73)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(172, 26)
        Me.DomainUpDown2.TabIndex = 10017
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'Sp_consultaMarcaTableAdapter
        '
        Me.Sp_consultaMarcaTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaCatalogo2TableAdapter
        '
        Me.Sp_consultaCatalogo2TableAdapter.ClearBeforeFill = True
        '
        'Frm_Marca_Modelo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 578)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.DomainUpDown2)
        Me.Controls.Add(Me.Bt_FinalizarModelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DGV_Marcas)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.MaximizeBox = False
        Me.Name = "Frm_Marca_Modelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas y Modelos"
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        CType(Me.DGV_MarcaModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_catalogo.ResumeLayout(False)
        Me.gb_catalogo.PerformLayout()
        CType(Me.DGV_MarcaCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaCatalogo2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaMarcaLikeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_Marcas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bt_foto As System.Windows.Forms.Button
    Friend WithEvents tb_foto As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents LblLogo As System.Windows.Forms.Label
    Friend WithEvents LblObs As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents LblPuertas As System.Windows.Forms.Label
    Friend WithEvents LblMotor As System.Windows.Forms.Label
    Friend WithEvents LblAno As System.Windows.Forms.Label
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Obs As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbac_Ano As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents Cbac_Version As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents Cbac_Puertas As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents Cbac_Motor As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents Cbac_Modelo As Tesis_Nueva.ComboBoxAutoComplete
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents bt_EliminarModelo As System.Windows.Forms.Button
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaMarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaMarcaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
    Friend WithEvents DGV_MarcaModelo As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Bt_ModificarModelo As System.Windows.Forms.Button
    Friend WithEvents MELDataSet3 As Tesis_Nueva.MELDataSet3
    Friend WithEvents SpconsultaMarcaLikeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaMarcaLikeTableAdapter As Tesis_Nueva.MELDataSet3TableAdapters.sp_consultaMarcaLikeTableAdapter
    Friend WithEvents gb_catalogo As System.Windows.Forms.GroupBox
    Friend WithEvents bt_regresar As System.Windows.Forms.Button
    Friend WithEvents bt_LimpiarFoto As System.Windows.Forms.Button
    Friend WithEvents bt_LimpiarLogo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_reporte As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGV_MarcaCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Puertas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainUpDown2 As System.Windows.Forms.ComboBox
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents Bt_FinalizarModelo As System.Windows.Forms.Button
    Friend WithEvents SpconsultaCatalogo2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaCatalogo2TableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogo2TableAdapter
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
End Class
