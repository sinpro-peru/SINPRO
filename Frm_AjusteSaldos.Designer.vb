<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AjusteSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AjusteSaldos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dud_buscar = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_montoAjuste = New System.Windows.Forms.TextBox
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl_codigoCliente = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_NombreCliente = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_controlFact = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_Usuario = New System.Windows.Forms.Label
        Me.lbl_numeroAjuste = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_Recibos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Recibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dev = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ret = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codigoRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label26 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_totalRet = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_TotalAjuste = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_NC = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbl_totalDif = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lbl_totalRecibos = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_TotalFact = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_Iva = New System.Windows.Forms.Label
        Me.lbl_subtotal = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Dgv_Ajustes = New System.Windows.Forms.DataGridView
        Me.NumeroAjusteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaAjustesSaldosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DGV_Facturas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoPendienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecibosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaFactNoAjustadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet1 = New Tesis_Nueva.MELDataSet
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.gb_filtros = New System.Windows.Forms.GroupBox
        Me.Sp_consultaAjustesSaldosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaAjustesSaldosTableAdapter
        Me.Sp_consultaFactNoAjustadasTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFactNoAjustadasTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgv_Ajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaAjustesSaldosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaFactNoAjustadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'dud_buscar
        '
        Me.dud_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dud_buscar.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dud_buscar.FormattingEnabled = True
        Me.dud_buscar.Location = New System.Drawing.Point(4, 66)
        Me.dud_buscar.Name = "dud_buscar"
        Me.dud_buscar.Size = New System.Drawing.Size(163, 26)
        Me.dud_buscar.TabIndex = 10008
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(409, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(609, 22)
        Me.Label6.TabIndex = 10006
        Me.Label6.Text = "Datos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(0, 1)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(409, 64)
        Me.ToolBar1.TabIndex = 10003
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
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(174, 67)
        Me.tb_buscarcodigo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tb_buscarcodigo.MaxLength = 200
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(229, 25)
        Me.tb_buscarcodigo.TabIndex = 10004
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.bt_cancelar)
        Me.GroupBox2.Controls.Add(Me.bt_aceptar)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(410, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 565)
        Me.GroupBox2.TabIndex = 10007
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtp_fecha)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.tb_montoAjuste)
        Me.GroupBox5.Controls.Add(Me.tb_observacion)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 377)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(369, 150)
        Me.GroupBox5.TabIndex = 108
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Parámetros del ajuste"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(129, 21)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(108, 22)
        Me.dtp_fecha.TabIndex = 10
        Me.dtp_fecha.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Fecha:"
        '
        'tb_montoAjuste
        '
        Me.tb_montoAjuste.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montoAjuste.Location = New System.Drawing.Point(129, 118)
        Me.tb_montoAjuste.MaxLength = 3000
        Me.tb_montoAjuste.Name = "tb_montoAjuste"
        Me.tb_montoAjuste.ReadOnly = True
        Me.tb_montoAjuste.Size = New System.Drawing.Size(94, 22)
        Me.tb_montoAjuste.TabIndex = 100
        '
        'tb_observacion
        '
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(129, 46)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.ReadOnly = True
        Me.tb_observacion.Size = New System.Drawing.Size(224, 68)
        Me.tb_observacion.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 22)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "(*)Monto ajuste:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 24)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "(*)Observacion:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_codigoCliente)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lbl_NombreCliente)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lbl_controlFact)
        Me.GroupBox4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 99)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(369, 99)
        Me.GroupBox4.TabIndex = 107
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la factura"
        '
        'lbl_codigoCliente
        '
        Me.lbl_codigoCliente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigoCliente.Location = New System.Drawing.Point(93, 47)
        Me.lbl_codigoCliente.Name = "lbl_codigoCliente"
        Me.lbl_codigoCliente.Size = New System.Drawing.Size(109, 22)
        Me.lbl_codigoCliente.TabIndex = 107
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Cod. Cliente:"
        '
        'lbl_NombreCliente
        '
        Me.lbl_NombreCliente.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreCliente.Location = New System.Drawing.Point(86, 71)
        Me.lbl_NombreCliente.Name = "lbl_NombreCliente"
        Me.lbl_NombreCliente.Size = New System.Drawing.Size(267, 22)
        Me.lbl_NombreCliente.TabIndex = 105
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 15)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Nº Control F.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Razón Social:"
        '
        'lbl_controlFact
        '
        Me.lbl_controlFact.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_controlFact.Location = New System.Drawing.Point(93, 24)
        Me.lbl_controlFact.Name = "lbl_controlFact"
        Me.lbl_controlFact.Size = New System.Drawing.Size(69, 22)
        Me.lbl_controlFact.TabIndex = 98
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_Usuario)
        Me.GroupBox3.Controls.Add(Me.lbl_numeroAjuste)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 77)
        Me.GroupBox3.TabIndex = 106
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Ajuste"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(68, 41)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(211, 22)
        Me.lbl_Usuario.TabIndex = 105
        '
        'lbl_numeroAjuste
        '
        Me.lbl_numeroAjuste.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numeroAjuste.Location = New System.Drawing.Point(97, 23)
        Me.lbl_numeroAjuste.Name = "lbl_numeroAjuste"
        Me.lbl_numeroAjuste.Size = New System.Drawing.Size(69, 22)
        Me.lbl_numeroAjuste.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Usuario:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 15)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Nro. Ajuste:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_Recibos)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 165)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recibos Asociados a la factura"
        '
        'DGV_Recibos
        '
        Me.DGV_Recibos.AllowUserToAddRows = False
        Me.DGV_Recibos.AllowUserToDeleteRows = False
        Me.DGV_Recibos.AllowUserToResizeColumns = False
        Me.DGV_Recibos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Recibos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Recibos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Recibo, Me.DataGridViewTextBoxColumn4, Me.FechaDeposito, Me.DataGridViewTextBoxColumn5, Me.MontoDep, Me.DataGridViewTextBoxColumn6, Me.Num, Me.Dev, Me.Ret, Me.codigoRecibo})
        Me.DGV_Recibos.Location = New System.Drawing.Point(6, 21)
        Me.DGV_Recibos.Name = "DGV_Recibos"
        Me.DGV_Recibos.ReadOnly = True
        Me.DGV_Recibos.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Recibos.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Recibos.ShowEditingIcon = False
        Me.DGV_Recibos.Size = New System.Drawing.Size(584, 133)
        Me.DGV_Recibos.TabIndex = 76
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fact."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'Recibo
        '
        Me.Recibo.HeaderText = "Rec."
        Me.Recibo.Name = "Recibo"
        Me.Recibo.ReadOnly = True
        Me.Recibo.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha F"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'FechaDeposito
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaDeposito.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDeposito.HeaderText = "Fecha D"
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.ReadOnly = True
        Me.FechaDeposito.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto F"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 81
        '
        'MontoDep
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MontoDep.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoDep.HeaderText = "Monto D"
        Me.MontoDep.Name = "MontoDep"
        Me.MontoDep.ReadOnly = True
        Me.MontoDep.Width = 84
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 42
        '
        'Num
        '
        Me.Num.HeaderText = "Num"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Visible = False
        '
        'Dev
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Dev.DefaultCellStyle = DataGridViewCellStyle7
        Me.Dev.HeaderText = "NC"
        Me.Dev.Name = "Dev"
        Me.Dev.ReadOnly = True
        Me.Dev.Width = 65
        '
        'Ret
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Ret.DefaultCellStyle = DataGridViewCellStyle8
        Me.Ret.HeaderText = "Ret."
        Me.Ret.Name = "Ret"
        Me.Ret.ReadOnly = True
        Me.Ret.Width = 60
        '
        'codigoRecibo
        '
        Me.codigoRecibo.HeaderText = "codR"
        Me.codigoRecibo.Name = "codigoRecibo"
        Me.codigoRecibo.ReadOnly = True
        Me.codigoRecibo.Visible = False
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Red
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(437, 497)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(159, 20)
        Me.Label26.TabIndex = 85
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lbl_totalRet)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lbl_TotalAjuste)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_NC)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.lbl_totalDif)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.lbl_totalRecibos)
        Me.Panel3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(377, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(224, 105)
        Me.Panel3.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Total retención:"
        '
        'lbl_totalRet
        '
        Me.lbl_totalRet.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalRet.Location = New System.Drawing.Point(115, 40)
        Me.lbl_totalRet.Name = "lbl_totalRet"
        Me.lbl_totalRet.Size = New System.Drawing.Size(102, 22)
        Me.lbl_totalRet.TabIndex = 81
        Me.lbl_totalRet.Text = "0,00"
        Me.lbl_totalRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Total Ajuste:"
        '
        'lbl_TotalAjuste
        '
        Me.lbl_TotalAjuste.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalAjuste.Location = New System.Drawing.Point(115, 60)
        Me.lbl_TotalAjuste.Name = "lbl_TotalAjuste"
        Me.lbl_TotalAjuste.Size = New System.Drawing.Size(102, 22)
        Me.lbl_TotalAjuste.TabIndex = 79
        Me.lbl_TotalAjuste.Text = "0,00"
        Me.lbl_TotalAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Total Notas C.:"
        '
        'lbl_NC
        '
        Me.lbl_NC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NC.Location = New System.Drawing.Point(115, 1)
        Me.lbl_NC.Name = "lbl_NC"
        Me.lbl_NC.Size = New System.Drawing.Size(102, 22)
        Me.lbl_NC.TabIndex = 77
        Me.lbl_NC.Text = "0,00"
        Me.lbl_NC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(3, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Total diferencia:"
        '
        'lbl_totalDif
        '
        Me.lbl_totalDif.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalDif.Location = New System.Drawing.Point(128, 78)
        Me.lbl_totalDif.Name = "lbl_totalDif"
        Me.lbl_totalDif.Size = New System.Drawing.Size(93, 24)
        Me.lbl_totalDif.TabIndex = 75
        Me.lbl_totalDif.Text = "0,00"
        Me.lbl_totalDif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 22)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Total Recibos:"
        '
        'lbl_totalRecibos
        '
        Me.lbl_totalRecibos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalRecibos.Location = New System.Drawing.Point(115, 21)
        Me.lbl_totalRecibos.Name = "lbl_totalRecibos"
        Me.lbl_totalRecibos.Size = New System.Drawing.Size(102, 22)
        Me.lbl_totalRecibos.TabIndex = 71
        Me.lbl_totalRecibos.Text = "0,00"
        Me.lbl_totalRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbl_TotalFact)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lbl_Iva)
        Me.Panel2.Controls.Add(Me.lbl_subtotal)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(377, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 74)
        Me.Panel2.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 22)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Total Factura:"
        '
        'lbl_TotalFact
        '
        Me.lbl_TotalFact.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalFact.Location = New System.Drawing.Point(118, 45)
        Me.lbl_TotalFact.Name = "lbl_TotalFact"
        Me.lbl_TotalFact.Size = New System.Drawing.Size(102, 22)
        Me.lbl_TotalFact.TabIndex = 76
        Me.lbl_TotalFact.Text = "0,00"
        Me.lbl_TotalFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Sub-Total:"
        '
        'lbl_Iva
        '
        Me.lbl_Iva.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Iva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Iva.Location = New System.Drawing.Point(118, 22)
        Me.lbl_Iva.Name = "lbl_Iva"
        Me.lbl_Iva.Size = New System.Drawing.Size(102, 22)
        Me.lbl_Iva.TabIndex = 72
        Me.lbl_Iva.Text = "0,00"
        Me.lbl_Iva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(118, 1)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(102, 22)
        Me.lbl_subtotal.TabIndex = 71
        Me.lbl_subtotal.Text = "0,00"
        Me.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 22)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "I.V.A."
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(360, 533)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 12
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(258, 533)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 11
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(482, 538)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(121, 22)
        Me.Label25.TabIndex = 85
        Me.Label25.Text = "(*)Datos requeridos"
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(5, 204)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(596, 165)
        Me.GroupBox6.TabIndex = 99
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Recibos Asociados a la factura"
        '
        'Dgv_Ajustes
        '
        Me.Dgv_Ajustes.AllowUserToAddRows = False
        Me.Dgv_Ajustes.AllowUserToDeleteRows = False
        Me.Dgv_Ajustes.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Ajustes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_Ajustes.AutoGenerateColumns = False
        Me.Dgv_Ajustes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_Ajustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Ajustes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroAjusteDataGridViewTextBoxColumn, Me.ControlInicioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn})
        Me.Dgv_Ajustes.DataSource = Me.SpconsultaAjustesSaldosBindingSource
        Me.Dgv_Ajustes.Location = New System.Drawing.Point(2, 97)
        Me.Dgv_Ajustes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Dgv_Ajustes.MultiSelect = False
        Me.Dgv_Ajustes.Name = "Dgv_Ajustes"
        Me.Dgv_Ajustes.ReadOnly = True
        Me.Dgv_Ajustes.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_Ajustes.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.Dgv_Ajustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Ajustes.Size = New System.Drawing.Size(401, 478)
        Me.Dgv_Ajustes.TabIndex = 10005
        '
        'NumeroAjusteDataGridViewTextBoxColumn
        '
        Me.NumeroAjusteDataGridViewTextBoxColumn.DataPropertyName = "NumeroAjuste"
        Me.NumeroAjusteDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NumeroAjusteDataGridViewTextBoxColumn.Name = "NumeroAjusteDataGridViewTextBoxColumn"
        Me.NumeroAjusteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroAjusteDataGridViewTextBoxColumn.Width = 30
        '
        'ControlInicioDataGridViewTextBoxColumn
        '
        Me.ControlInicioDataGridViewTextBoxColumn.DataPropertyName = "ControlInicio"
        Me.ControlInicioDataGridViewTextBoxColumn.HeaderText = "Fact."
        Me.ControlInicioDataGridViewTextBoxColumn.Name = "ControlInicioDataGridViewTextBoxColumn"
        Me.ControlInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlInicioDataGridViewTextBoxColumn.Width = 43
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 72
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 175
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 60
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'SpconsultaAjustesSaldosBindingSource
        '
        Me.SpconsultaAjustesSaldosBindingSource.DataMember = "sp_consultaAjustesSaldos"
        Me.SpconsultaAjustesSaldosBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToAddRows = False
        Me.DGV_Facturas.AllowUserToDeleteRows = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Facturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DGV_Facturas.AutoGenerateColumns = False
        Me.DGV_Facturas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.FechaDataGridViewTextBoxColumn1, Me.ClienteDataGridViewTextBoxColumn1, Me.MontoPendienteDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.CodClienteDataGridViewTextBoxColumn, Me.PteDataGridViewTextBoxColumn, Me.RecibosDataGridViewTextBoxColumn})
        Me.DGV_Facturas.DataSource = Me.SpconsultaFactNoAjustadasBindingSource
        Me.DGV_Facturas.Location = New System.Drawing.Point(2, 133)
        Me.DGV_Facturas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DGV_Facturas.MultiSelect = False
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.ReadOnly = True
        Me.DGV_Facturas.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Facturas.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGV_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Facturas.Size = New System.Drawing.Size(401, 442)
        Me.DGV_Facturas.TabIndex = 10009
        Me.DGV_Facturas.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fact"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fact"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ctrl"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ctrl"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 51
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Width = 72
        '
        'ClienteDataGridViewTextBoxColumn1
        '
        Me.ClienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn1.Name = "ClienteDataGridViewTextBoxColumn1"
        Me.ClienteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn1.Width = 195
        '
        'MontoPendienteDataGridViewTextBoxColumn
        '
        Me.MontoPendienteDataGridViewTextBoxColumn.DataPropertyName = "MontoPendiente"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.MontoPendienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.MontoPendienteDataGridViewTextBoxColumn.HeaderText = "Pte."
        Me.MontoPendienteDataGridViewTextBoxColumn.Name = "MontoPendienteDataGridViewTextBoxColumn"
        Me.MontoPendienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoPendienteDataGridViewTextBoxColumn.Width = 60
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IvaDataGridViewTextBoxColumn.Visible = False
        '
        'CodClienteDataGridViewTextBoxColumn
        '
        Me.CodClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.HeaderText = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.Name = "CodClienteDataGridViewTextBoxColumn"
        Me.CodClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodClienteDataGridViewTextBoxColumn.Visible = False
        '
        'PteDataGridViewTextBoxColumn
        '
        Me.PteDataGridViewTextBoxColumn.DataPropertyName = "pte"
        Me.PteDataGridViewTextBoxColumn.HeaderText = "pte"
        Me.PteDataGridViewTextBoxColumn.Name = "PteDataGridViewTextBoxColumn"
        Me.PteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PteDataGridViewTextBoxColumn.Visible = False
        '
        'RecibosDataGridViewTextBoxColumn
        '
        Me.RecibosDataGridViewTextBoxColumn.DataPropertyName = "Recibos"
        Me.RecibosDataGridViewTextBoxColumn.HeaderText = "Recibos"
        Me.RecibosDataGridViewTextBoxColumn.Name = "RecibosDataGridViewTextBoxColumn"
        Me.RecibosDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecibosDataGridViewTextBoxColumn.Visible = False
        '
        'SpconsultaFactNoAjustadasBindingSource
        '
        Me.SpconsultaFactNoAjustadasBindingSource.DataMember = "sp_consultaFactNoAjustadas"
        Me.SpconsultaFactNoAjustadasBindingSource.DataSource = Me.MELDataSet1
        '
        'MELDataSet1
        '
        Me.MELDataSet1.DataSetName = "MELDataSet"
        Me.MELDataSet1.EnforceConstraints = False
        Me.MELDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 18)
        Me.RadioButton1.TabIndex = 10010
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sólo con recibos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(124, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 18)
        Me.RadioButton2.TabIndex = 10011
        Me.RadioButton2.Text = "Todas"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'gb_filtros
        '
        Me.gb_filtros.Controls.Add(Me.RadioButton1)
        Me.gb_filtros.Controls.Add(Me.RadioButton2)
        Me.gb_filtros.Location = New System.Drawing.Point(2, 93)
        Me.gb_filtros.Name = "gb_filtros"
        Me.gb_filtros.Size = New System.Drawing.Size(183, 38)
        Me.gb_filtros.TabIndex = 10012
        Me.gb_filtros.TabStop = False
        Me.gb_filtros.Text = "Filtrar"
        Me.gb_filtros.Visible = False
        '
        'Sp_consultaAjustesSaldosTableAdapter
        '
        Me.Sp_consultaAjustesSaldosTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaFactNoAjustadasTableAdapter
        '
        Me.Sp_consultaFactNoAjustadasTableAdapter.ClearBeforeFill = True
        '
        'Frm_AjusteSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 580)
        Me.Controls.Add(Me.gb_filtros)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dud_buscar)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV_Facturas)
        Me.Controls.Add(Me.Dgv_Ajustes)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_AjusteSaldos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes de saldos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dgv_Ajustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaAjustesSaldosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaFactNoAjustadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_filtros.ResumeLayout(False)
        Me.gb_filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dud_buscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalDif As System.Windows.Forms.Label
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalFact As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_Iva As System.Windows.Forms.Label
    Friend WithEvents lbl_totalRecibos As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbl_controlFact As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Dgv_Ajustes As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents tb_montoAjuste As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_numeroAjuste As System.Windows.Forms.Label
    Friend WithEvents DGV_Recibos As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Facturas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_codigoCliente As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_NC As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalAjuste As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalRet As System.Windows.Forms.Label
    Friend WithEvents gb_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpconsultaAjustesSaldosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaAjustesSaldosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaAjustesSaldosTableAdapter
    Friend WithEvents FactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MELDataSet1 As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaFactNoAjustadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaFactNoAjustadasTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFactNoAjustadasTableAdapter
    Friend WithEvents NumeroAjusteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoPendienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
