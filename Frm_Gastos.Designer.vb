<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Gastos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Gastos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cb_tipo = New System.Windows.Forms.ComboBox
        Me.SpconsultaTipoGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Dgv_relaciones = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RealizadoPor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AprobadoPor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cerrado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Limite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.cb_mes = New System.Windows.Forms.ComboBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_cerrar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tb_observ = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lb_asociacion = New System.Windows.Forms.GroupBox
        Me.DGV_Movimientos = New System.Windows.Forms.DataGridView
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Egreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.tb_elaborada = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chk_cerrada = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tb_monto = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_descripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_numeroDoc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_Documento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.tb_aprobada = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_egresos = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lb_disponible = New System.Windows.Forms.Label
        Me.lb_limite = New System.Windows.Forms.Label
        Me.bt_agregarMov = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_eliminarMov = New System.Windows.Forms.Button
        Me.Sp_consultaTipoGastoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaTipoGastoTableAdapter
        Me.cb_ano = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.SpconsultaTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_relaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lb_asociacion.SuspendLayout()
        CType(Me.DGV_Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(554, 25)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(102, 20)
        Me.dtp1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10039
        Me.Label6.Text = "Fecha:"
        '
        'tb_codigo
        '
        Me.tb_codigo.Location = New System.Drawing.Point(103, 25)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(44, 20)
        Me.tb_codigo.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 10036
        Me.Label5.Text = "Cod. Relación:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cb_tipo)
        Me.GroupBox3.Controls.Add(Me.Dgv_relaciones)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(330, 608)
        Me.GroupBox3.TabIndex = 10034
        Me.GroupBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 10037
        Me.Label13.Text = "Tipo Relación:"
        '
        'cb_tipo
        '
        Me.cb_tipo.DataSource = Me.SpconsultaTipoGastoBindingSource
        Me.cb_tipo.DisplayMember = "Nombre"
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Location = New System.Drawing.Point(93, 14)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(174, 21)
        Me.cb_tipo.TabIndex = 4
        Me.cb_tipo.ValueMember = "ID"
        '
        'SpconsultaTipoGastoBindingSource
        '
        Me.SpconsultaTipoGastoBindingSource.DataMember = "sp_consultaTipoGasto"
        Me.SpconsultaTipoGastoBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dgv_relaciones
        '
        Me.Dgv_relaciones.AllowUserToAddRows = False
        Me.Dgv_relaciones.AllowUserToDeleteRows = False
        Me.Dgv_relaciones.AllowUserToResizeColumns = False
        Me.Dgv_relaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Dgv_relaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_relaciones.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Dgv_relaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_relaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Fecha1, Me.RealizadoPor, Me.AprobadoPor, Me.Observacion, Me.Cerrado, Me.Limite})
        Me.Dgv_relaciones.Location = New System.Drawing.Point(6, 67)
        Me.Dgv_relaciones.MultiSelect = False
        Me.Dgv_relaciones.Name = "Dgv_relaciones"
        Me.Dgv_relaciones.ReadOnly = True
        Me.Dgv_relaciones.RowHeadersVisible = False
        Me.Dgv_relaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_relaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_relaciones.Size = New System.Drawing.Size(313, 535)
        Me.Dgv_relaciones.TabIndex = 10004
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Id"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        Me.Codigo.Width = 105
        '
        'Fecha1
        '
        DataGridViewCellStyle2.Format = "d"
        Me.Fecha1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha1.HeaderText = "Fecha"
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.ReadOnly = True
        Me.Fecha1.Width = 80
        '
        'RealizadoPor
        '
        Me.RealizadoPor.HeaderText = "Realizado Por"
        Me.RealizadoPor.Name = "RealizadoPor"
        Me.RealizadoPor.ReadOnly = True
        Me.RealizadoPor.Width = 210
        '
        'AprobadoPor
        '
        Me.AprobadoPor.HeaderText = "Aprobado"
        Me.AprobadoPor.Name = "AprobadoPor"
        Me.AprobadoPor.ReadOnly = True
        Me.AprobadoPor.Visible = False
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Visible = False
        Me.Observacion.Width = 120
        '
        'Cerrado
        '
        Me.Cerrado.HeaderText = "Cerrado"
        Me.Cerrado.Name = "Cerrado"
        Me.Cerrado.ReadOnly = True
        Me.Cerrado.Visible = False
        '
        'Limite
        '
        Me.Limite.HeaderText = "Limite"
        Me.Limite.Name = "Limite"
        Me.Limite.ReadOnly = True
        Me.Limite.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(6, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(314, 24)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Relaciones"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_mes
        '
        Me.cb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Items.AddRange(New Object() {"Todas", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cb_mes.Location = New System.Drawing.Point(48, 68)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(123, 21)
        Me.cb_mes.TabIndex = 1
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_modificar, Me.bt_imprimir, Me.bt_cerrar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(6, 4)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(323, 57)
        Me.ToolBar1.TabIndex = 60
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_imprimir
        '
        Me.bt_imprimir.ImageIndex = 6
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Text = "Imprimir"
        '
        'bt_cerrar
        '
        Me.bt_cerrar.ImageIndex = 7
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Text = "Cierre"
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
        Me.ImageList2.Images.SetKeyName(7, "ok.png")
        '
        'tb_observ
        '
        Me.tb_observ.Location = New System.Drawing.Point(103, 98)
        Me.tb_observ.Multiline = True
        Me.tb_observ.Name = "tb_observ"
        Me.tb_observ.ReadOnly = True
        Me.tb_observ.Size = New System.Drawing.Size(272, 53)
        Me.tb_observ.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 10030
        Me.Label10.Text = "Observ.:"
        '
        'lb_asociacion
        '
        Me.lb_asociacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb_asociacion.Controls.Add(Me.DGV_Movimientos)
        Me.lb_asociacion.Controls.Add(Me.Label8)
        Me.lb_asociacion.Location = New System.Drawing.Point(343, 298)
        Me.lb_asociacion.Name = "lb_asociacion"
        Me.lb_asociacion.Size = New System.Drawing.Size(669, 368)
        Me.lb_asociacion.TabIndex = 32
        Me.lb_asociacion.TabStop = False
        '
        'DGV_Movimientos
        '
        Me.DGV_Movimientos.AllowUserToAddRows = False
        Me.DGV_Movimientos.AllowUserToDeleteRows = False
        Me.DGV_Movimientos.AllowUserToOrderColumns = True
        Me.DGV_Movimientos.AllowUserToResizeRows = False
        Me.DGV_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Documento, Me.Numero, Me.Descripcion, Me.Fecha, Me.Egreso, Me.Ingreso, Me.NroMov})
        Me.DGV_Movimientos.Location = New System.Drawing.Point(5, 26)
        Me.DGV_Movimientos.MultiSelect = False
        Me.DGV_Movimientos.Name = "DGV_Movimientos"
        Me.DGV_Movimientos.ReadOnly = True
        Me.DGV_Movimientos.RowHeadersVisible = False
        Me.DGV_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Movimientos.Size = New System.Drawing.Size(660, 336)
        Me.DGV_Movimientos.TabIndex = 32
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        Me.Documento.Width = 115
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 180
        '
        'Fecha
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 80
        '
        'Egreso
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Egreso.DefaultCellStyle = DataGridViewCellStyle4
        Me.Egreso.HeaderText = "Egreso"
        Me.Egreso.Name = "Egreso"
        Me.Egreso.ReadOnly = True
        Me.Egreso.Width = 80
        '
        'Ingreso
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Ingreso.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ingreso.HeaderText = "Ingreso"
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.ReadOnly = True
        Me.Ingreso.Width = 80
        '
        'NroMov
        '
        Me.NroMov.HeaderText = "NroMov"
        Me.NroMov.Name = "NroMov"
        Me.NroMov.ReadOnly = True
        Me.NroMov.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(670, 23)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Documentos Asociados a la Relación"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_elaborada
        '
        Me.tb_elaborada.Location = New System.Drawing.Point(103, 50)
        Me.tb_elaborada.Name = "tb_elaborada"
        Me.tb_elaborada.ReadOnly = True
        Me.tb_elaborada.Size = New System.Drawing.Size(190, 20)
        Me.tb_elaborada.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10026
        Me.Label3.Text = "(*) Elaborada por:"
        '
        'chk_cerrada
        '
        Me.chk_cerrada.AutoSize = True
        Me.chk_cerrada.Enabled = False
        Me.chk_cerrada.Location = New System.Drawing.Point(550, 141)
        Me.chk_cerrada.Name = "chk_cerrada"
        Me.chk_cerrada.Size = New System.Drawing.Size(108, 17)
        Me.chk_cerrada.TabIndex = 50
        Me.chk_cerrada.Text = "Relación Cerrada"
        Me.chk_cerrada.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tb_monto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_numeroDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_Documento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 114)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles Movimientos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 10046
        Me.Label9.Text = "( +/- )"
        '
        'tb_monto
        '
        Me.tb_monto.Location = New System.Drawing.Point(343, 80)
        Me.tb_monto.Name = "tb_monto"
        Me.tb_monto.ReadOnly = True
        Me.tb_monto.Size = New System.Drawing.Size(95, 20)
        Me.tb_monto.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 10043
        Me.Label11.Text = "(*) Monto:"
        '
        'dtp2
        '
        Me.dtp2.Enabled = False
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(103, 25)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(101, 20)
        Me.dtp2.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 10041
        Me.Label7.Text = "Fecha:"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.Location = New System.Drawing.Point(343, 22)
        Me.tb_descripcion.Multiline = True
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.ReadOnly = True
        Me.tb_descripcion.Size = New System.Drawing.Size(183, 53)
        Me.tb_descripcion.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 10032
        Me.Label4.Text = "(*) Descripción:"
        '
        'tb_numeroDoc
        '
        Me.tb_numeroDoc.Location = New System.Drawing.Point(103, 76)
        Me.tb_numeroDoc.Name = "tb_numeroDoc"
        Me.tb_numeroDoc.ReadOnly = True
        Me.tb_numeroDoc.Size = New System.Drawing.Size(137, 20)
        Me.tb_numeroDoc.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10030
        Me.Label2.Text = "(*) Número:"
        '
        'tb_Documento
        '
        Me.tb_Documento.Location = New System.Drawing.Point(103, 50)
        Me.tb_Documento.Name = "tb_Documento"
        Me.tb_Documento.ReadOnly = True
        Me.tb_Documento.Size = New System.Drawing.Size(137, 20)
        Me.tb_Documento.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 10028
        Me.Label1.Text = "(*) Documento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tb_aprobada)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.chk_cerrada)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tb_elaborada)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtp1)
        Me.GroupBox2.Controls.Add(Me.tb_observ)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 165)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la relación"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 10045
        Me.Label18.Text = "Aprobada por:"
        '
        'tb_aprobada
        '
        Me.tb_aprobada.Location = New System.Drawing.Point(103, 74)
        Me.tb_aprobada.Name = "tb_aprobada"
        Me.tb_aprobada.ReadOnly = True
        Me.tb_aprobada.Size = New System.Drawing.Size(190, 20)
        Me.tb_aprobada.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_egresos)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lb_disponible)
        Me.Panel1.Controls.Add(Me.lb_limite)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(489, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(169, 65)
        Me.Panel1.TabIndex = 10043
        '
        'lbl_egresos
        '
        Me.lbl_egresos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_egresos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_egresos.Location = New System.Drawing.Point(66, 19)
        Me.lbl_egresos.Name = "lbl_egresos"
        Me.lbl_egresos.Size = New System.Drawing.Size(100, 23)
        Me.lbl_egresos.TabIndex = 72
        Me.lbl_egresos.Text = "0.00"
        Me.lbl_egresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 23)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "Disponible"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Limite"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 23)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Egresos"
        '
        'lb_disponible
        '
        Me.lb_disponible.BackColor = System.Drawing.Color.Transparent
        Me.lb_disponible.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_disponible.Location = New System.Drawing.Point(74, 39)
        Me.lb_disponible.Name = "lb_disponible"
        Me.lb_disponible.Size = New System.Drawing.Size(92, 23)
        Me.lb_disponible.TabIndex = 109
        Me.lb_disponible.Text = "0.00"
        Me.lb_disponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_limite
        '
        Me.lb_limite.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_limite.ForeColor = System.Drawing.Color.Black
        Me.lb_limite.Location = New System.Drawing.Point(66, 3)
        Me.lb_limite.Name = "lb_limite"
        Me.lb_limite.Size = New System.Drawing.Size(100, 23)
        Me.lb_limite.TabIndex = 107
        Me.lb_limite.Text = "0.00"
        Me.lb_limite.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bt_agregarMov
        '
        Me.bt_agregarMov.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarMov.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarMov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarMov.Location = New System.Drawing.Point(897, 227)
        Me.bt_agregarMov.Name = "bt_agregarMov"
        Me.bt_agregarMov.Size = New System.Drawing.Size(34, 27)
        Me.bt_agregarMov.TabIndex = 30
        Me.bt_agregarMov.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_agregarMov.Visible = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(720, 672)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 34
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(616, 672)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 33
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
        '
        'bt_eliminarMov
        '
        Me.bt_eliminarMov.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminarMov.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarMov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarMov.Location = New System.Drawing.Point(937, 227)
        Me.bt_eliminarMov.Name = "bt_eliminarMov"
        Me.bt_eliminarMov.Size = New System.Drawing.Size(34, 29)
        Me.bt_eliminarMov.TabIndex = 31
        Me.bt_eliminarMov.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_eliminarMov.Visible = False
        '
        'Sp_consultaTipoGastoTableAdapter
        '
        Me.Sp_consultaTipoGastoTableAdapter.ClearBeforeFill = True
        '
        'cb_ano
        '
        Me.cb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ano.FormattingEnabled = True
        Me.cb_ano.Location = New System.Drawing.Point(215, 68)
        Me.cb_ano.Name = "cb_ano"
        Me.cb_ano.Size = New System.Drawing.Size(81, 21)
        Me.cb_ano.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 10038
        Me.Label16.Text = "Mes:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(180, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 13)
        Me.Label19.TabIndex = 10049
        Me.Label19.Text = "Año:"
        '
        'Frm_Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cb_ano)
        Me.Controls.Add(Me.bt_eliminarMov)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_agregarMov)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cb_mes)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.lb_asociacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Gastos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Gastos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SpconsultaTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_relaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lb_asociacion.ResumeLayout(False)
        CType(Me.DGV_Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv_relaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_observ As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lb_asociacion As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_elaborada As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents chk_cerrada As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Documento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_numeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_agregarMov As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarMov As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_limite As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_egresos As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents bt_cerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lb_disponible As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tb_aprobada As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaTipoGastoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaTipoGastoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaTipoGastoTableAdapter
    Friend WithEvents cb_ano As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RealizadoPor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AprobadoPor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cerrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Limite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Egreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroMov As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
