<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NotaCredito
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NotaCredito))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Dgv_NotasC = New System.Windows.Forms.DataGridView
        Me.NroControlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlInicioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonSocialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoTotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Control2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaNotasCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelDataSet1 = New Tesis_Nueva.MELDataSet
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tb_montodesc = New System.Windows.Forms.TextBox
        Me.tb_porcentaje = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.tb_user = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rb_pendiente = New System.Windows.Forms.RadioButton
        Me.rb_fisica = New System.Windows.Forms.RadioButton
        Me.tb_controlInicio = New System.Windows.Forms.TextBox
        Me.tb_imp = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.chk_ajustada = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tp_devolucion = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_Parcial = New System.Windows.Forms.RadioButton
        Me.rb_Total = New System.Windows.Forms.RadioButton
        Me.Dgv_DevolucionNC = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tp_descuento = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_renglon = New System.Windows.Forms.RadioButton
        Me.rb_porcentaje = New System.Windows.Forms.RadioButton
        Me.rb_monto = New System.Windows.Forms.RadioButton
        Me.Label24 = New System.Windows.Forms.Label
        Me.Dgv_DescuentoNC = New System.Windows.Forms.DataGridView
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioAct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lb_iva = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Dgv_Facturas = New System.Windows.Forms.DataGridView
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Control = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaFactVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.dud_buscar = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Sp_consultaFactVentasTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFactVentasTableAdapter
        Me.Sp_consultaNotasCreditoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNotasCreditoTableAdapter
        CType(Me.Dgv_NotasC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaNotasCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tp_devolucion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv_DevolucionNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_descuento.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv_DescuentoNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaFactVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_NotasC
        '
        Me.Dgv_NotasC.AllowUserToAddRows = False
        Me.Dgv_NotasC.AllowUserToDeleteRows = False
        Me.Dgv_NotasC.AllowUserToResizeColumns = False
        Me.Dgv_NotasC.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_NotasC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_NotasC.AutoGenerateColumns = False
        Me.Dgv_NotasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_NotasC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroControlDataGridViewTextBoxColumn, Me.ControlInicioDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1, Me.RazonSocialDataGridViewTextBoxColumn1, Me.MontoDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn1, Me.TipoDataGridViewCheckBoxColumn, Me.CodigoNotaCreditoDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn1, Me.ControlDataGridViewTextBoxColumn, Me.Control2, Me.Usuario, Me.CodigoCliente})
        Me.Dgv_NotasC.DataSource = Me.SpconsultaNotasCreditoBindingSource
        Me.Dgv_NotasC.Location = New System.Drawing.Point(6, 141)
        Me.Dgv_NotasC.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Dgv_NotasC.MultiSelect = False
        Me.Dgv_NotasC.Name = "Dgv_NotasC"
        Me.Dgv_NotasC.ReadOnly = True
        Me.Dgv_NotasC.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_NotasC.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_NotasC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_NotasC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_NotasC.Size = New System.Drawing.Size(425, 536)
        Me.Dgv_NotasC.TabIndex = 94
        '
        'NroControlDataGridViewTextBoxColumn
        '
        Me.NroControlDataGridViewTextBoxColumn.DataPropertyName = "NroControl"
        Me.NroControlDataGridViewTextBoxColumn.HeaderText = "N.C."
        Me.NroControlDataGridViewTextBoxColumn.Name = "NroControlDataGridViewTextBoxColumn"
        Me.NroControlDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroControlDataGridViewTextBoxColumn.Width = 50
        '
        'ControlInicioDataGridViewTextBoxColumn1
        '
        Me.ControlInicioDataGridViewTextBoxColumn1.DataPropertyName = "ControlInicio"
        Me.ControlInicioDataGridViewTextBoxColumn1.HeaderText = "Fact."
        Me.ControlInicioDataGridViewTextBoxColumn1.Name = "ControlInicioDataGridViewTextBoxColumn1"
        Me.ControlInicioDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ControlInicioDataGridViewTextBoxColumn1.Width = 52
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Width = 75
        '
        'RazonSocialDataGridViewTextBoxColumn1
        '
        Me.RazonSocialDataGridViewTextBoxColumn1.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.RazonSocialDataGridViewTextBoxColumn1.Name = "RazonSocialDataGridViewTextBoxColumn1"
        Me.RazonSocialDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn1.Width = 153
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 70
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionDataGridViewTextBoxColumn.Visible = False
        '
        'IvaDataGridViewTextBoxColumn1
        '
        Me.IvaDataGridViewTextBoxColumn1.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn1.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn1.Name = "IvaDataGridViewTextBoxColumn1"
        Me.IvaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IvaDataGridViewTextBoxColumn1.Visible = False
        '
        'TipoDataGridViewCheckBoxColumn
        '
        Me.TipoDataGridViewCheckBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewCheckBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewCheckBoxColumn.Name = "TipoDataGridViewCheckBoxColumn"
        Me.TipoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.TipoDataGridViewCheckBoxColumn.Visible = False
        '
        'CodigoNotaCreditoDataGridViewTextBoxColumn
        '
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn.DataPropertyName = "CodigoNotaCredito"
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn.HeaderText = "CodigoNotaCredito"
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn.Name = "CodigoNotaCreditoDataGridViewTextBoxColumn"
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoNotaCreditoDataGridViewTextBoxColumn.Visible = False
        '
        'MontoTotalDataGridViewTextBoxColumn1
        '
        Me.MontoTotalDataGridViewTextBoxColumn1.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MontoTotalDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoTotalDataGridViewTextBoxColumn1.HeaderText = "MontoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn1.Name = "MontoTotalDataGridViewTextBoxColumn1"
        Me.MontoTotalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn1.Visible = False
        '
        'ControlDataGridViewTextBoxColumn
        '
        Me.ControlDataGridViewTextBoxColumn.DataPropertyName = "Control"
        Me.ControlDataGridViewTextBoxColumn.HeaderText = "Control"
        Me.ControlDataGridViewTextBoxColumn.Name = "ControlDataGridViewTextBoxColumn"
        Me.ControlDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlDataGridViewTextBoxColumn.Visible = False
        '
        'Control2
        '
        Me.Control2.DataPropertyName = "Control2"
        Me.Control2.HeaderText = "Control2"
        Me.Control2.Name = "Control2"
        Me.Control2.ReadOnly = True
        Me.Control2.Visible = False
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Visible = False
        '
        'CodigoCliente
        '
        Me.CodigoCliente.DataPropertyName = "CodigoCliente"
        Me.CodigoCliente.HeaderText = "CodigoCliente"
        Me.CodigoCliente.Name = "CodigoCliente"
        Me.CodigoCliente.ReadOnly = True
        Me.CodigoCliente.Visible = False
        '
        'SpconsultaNotasCreditoBindingSource
        '
        Me.SpconsultaNotasCreditoBindingSource.DataMember = "sp_consultaNotasCredito"
        Me.SpconsultaNotasCreditoBindingSource.DataSource = Me.MelDataSet1
        '
        'MelDataSet1
        '
        Me.MelDataSet1.DataSetName = "MELDataSet"
        Me.MelDataSet1.EnforceConstraints = False
        Me.MelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(231, 70)
        Me.tb_buscarcodigo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tb_buscarcodigo.MaxLength = 200
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(147, 25)
        Me.tb_buscarcodigo.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 681)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 681)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Total:"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(23, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(345, 64)
        Me.ToolBar1.TabIndex = 66
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
        'bt_imprimir
        '
        Me.bt_imprimir.ImageIndex = 5
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
        Me.ImageList2.Images.SetKeyName(5, "icono-impresion.gif")
        '
        'tb_montodesc
        '
        Me.tb_montodesc.Enabled = False
        Me.tb_montodesc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montodesc.Location = New System.Drawing.Point(289, 20)
        Me.tb_montodesc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tb_montodesc.MaxLength = 6
        Me.tb_montodesc.Name = "tb_montodesc"
        Me.tb_montodesc.Size = New System.Drawing.Size(80, 22)
        Me.tb_montodesc.TabIndex = 67
        '
        'tb_porcentaje
        '
        Me.tb_porcentaje.Enabled = False
        Me.tb_porcentaje.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_porcentaje.Location = New System.Drawing.Point(114, 17)
        Me.tb_porcentaje.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tb_porcentaje.MaxLength = 5
        Me.tb_porcentaje.Name = "tb_porcentaje"
        Me.tb_porcentaje.Size = New System.Drawing.Size(52, 22)
        Me.tb_porcentaje.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(373, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 22)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Bs."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(175, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 10034
        Me.Label3.Text = "%"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(435, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(626, 22)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Datos de la Factura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.tb_user)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.tb_controlInicio)
        Me.GroupBox2.Controls.Add(Me.tb_imp)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.chk_ajustada)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.tb_observacion)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.bt_cancelar)
        Me.GroupBox2.Controls.Add(Me.bt_aceptar)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(435, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 695)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 211)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 17)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "(*) Usuario:"
        '
        'tb_user
        '
        Me.tb_user.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(109, 211)
        Me.tb_user.MaxLength = 6
        Me.tb_user.Name = "tb_user"
        Me.tb_user.ReadOnly = True
        Me.tb_user.Size = New System.Drawing.Size(209, 22)
        Me.tb_user.TabIndex = 108
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.rb_pendiente)
        Me.Panel4.Controls.Add(Me.rb_fisica)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(125, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(156, 27)
        Me.Panel4.TabIndex = 106
        '
        'rb_pendiente
        '
        Me.rb_pendiente.AutoSize = True
        Me.rb_pendiente.Location = New System.Drawing.Point(65, 3)
        Me.rb_pendiente.Name = "rb_pendiente"
        Me.rb_pendiente.Size = New System.Drawing.Size(84, 19)
        Me.rb_pendiente.TabIndex = 106
        Me.rb_pendiente.TabStop = True
        Me.rb_pendiente.Text = "Pendiente"
        Me.rb_pendiente.UseVisualStyleBackColor = True
        '
        'rb_fisica
        '
        Me.rb_fisica.AutoSize = True
        Me.rb_fisica.Location = New System.Drawing.Point(3, 3)
        Me.rb_fisica.Name = "rb_fisica"
        Me.rb_fisica.Size = New System.Drawing.Size(56, 19)
        Me.rb_fisica.TabIndex = 105
        Me.rb_fisica.TabStop = True
        Me.rb_fisica.Text = "Física"
        Me.rb_fisica.UseVisualStyleBackColor = True
        '
        'tb_controlInicio
        '
        Me.tb_controlInicio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_controlInicio.Location = New System.Drawing.Point(109, 67)
        Me.tb_controlInicio.MaxLength = 6
        Me.tb_controlInicio.Name = "tb_controlInicio"
        Me.tb_controlInicio.ReadOnly = True
        Me.tb_controlInicio.Size = New System.Drawing.Size(125, 22)
        Me.tb_controlInicio.TabIndex = 103
        '
        'tb_imp
        '
        Me.tb_imp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_imp.Location = New System.Drawing.Point(109, 93)
        Me.tb_imp.MaxLength = 6
        Me.tb_imp.Name = "tb_imp"
        Me.tb_imp.ReadOnly = True
        Me.tb_imp.Size = New System.Drawing.Size(125, 22)
        Me.tb_imp.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 22)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "(*) N. Imp.:"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Red
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(462, 218)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(159, 20)
        Me.Label26.TabIndex = 85
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Visible = False
        '
        'chk_ajustada
        '
        Me.chk_ajustada.AutoSize = True
        Me.chk_ajustada.Enabled = False
        Me.chk_ajustada.Location = New System.Drawing.Point(384, 219)
        Me.chk_ajustada.Name = "chk_ajustada"
        Me.chk_ajustada.Size = New System.Drawing.Size(109, 19)
        Me.chk_ajustada.TabIndex = 88
        Me.chk_ajustada.Text = "Nota Ajustada"
        Me.chk_ajustada.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(387, 181)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 28)
        Me.Panel3.TabIndex = 70
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Total a cancelar:"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(121, -1)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 24)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "0,00"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_observacion
        '
        Me.tb_observacion.Enabled = False
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(109, 145)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.Size = New System.Drawing.Size(270, 62)
        Me.tb_observacion.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(387, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 89)
        Me.Panel2.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 22)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Total Nota:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(118, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 22)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "0,00"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 66)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 22)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Otras N.C.:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Sub-Total:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(118, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 22)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "0,00"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(118, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 22)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "0,00"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(118, -1)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(102, 22)
        Me.Label28.TabIndex = 71
        Me.Label28.Text = "0,00"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 22)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "I.V.A."
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 38)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "(*) Observacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      impresa:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 22)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "(*) N. Control.:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_devolucion)
        Me.TabControl1.Controls.Add(Me.tp_descuento)
        Me.TabControl1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 244)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(618, 398)
        Me.TabControl1.TabIndex = 99
        '
        'tp_devolucion
        '
        Me.tp_devolucion.BackColor = System.Drawing.Color.White
        Me.tp_devolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tp_devolucion.Controls.Add(Me.GroupBox1)
        Me.tp_devolucion.Controls.Add(Me.Dgv_DevolucionNC)
        Me.tp_devolucion.Font = New System.Drawing.Font("Papyrus", 9.75!)
        Me.tp_devolucion.Location = New System.Drawing.Point(4, 24)
        Me.tp_devolucion.Name = "tp_devolucion"
        Me.tp_devolucion.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_devolucion.Size = New System.Drawing.Size(610, 370)
        Me.tp_devolucion.TabIndex = 0
        Me.tp_devolucion.Text = "Devolución"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Parcial)
        Me.GroupBox1.Controls.Add(Me.rb_Total)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(121, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Tipo:"
        '
        'rb_Parcial
        '
        Me.rb_Parcial.AutoSize = True
        Me.rb_Parcial.Location = New System.Drawing.Point(42, 20)
        Me.rb_Parcial.Name = "rb_Parcial"
        Me.rb_Parcial.Size = New System.Drawing.Size(63, 19)
        Me.rb_Parcial.TabIndex = 0
        Me.rb_Parcial.TabStop = True
        Me.rb_Parcial.Text = "Parcial"
        Me.rb_Parcial.UseVisualStyleBackColor = True
        '
        'rb_Total
        '
        Me.rb_Total.AutoSize = True
        Me.rb_Total.Location = New System.Drawing.Point(221, 20)
        Me.rb_Total.Name = "rb_Total"
        Me.rb_Total.Size = New System.Drawing.Size(54, 19)
        Me.rb_Total.TabIndex = 1
        Me.rb_Total.TabStop = True
        Me.rb_Total.Text = "Total"
        Me.rb_Total.UseVisualStyleBackColor = True
        '
        'Dgv_DevolucionNC
        '
        Me.Dgv_DevolucionNC.AllowUserToAddRows = False
        Me.Dgv_DevolucionNC.AllowUserToDeleteRows = False
        Me.Dgv_DevolucionNC.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Dgv_DevolucionNC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_DevolucionNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_DevolucionNC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column8, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Obs})
        Me.Dgv_DevolucionNC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Dgv_DevolucionNC.Location = New System.Drawing.Point(3, 62)
        Me.Dgv_DevolucionNC.MultiSelect = False
        Me.Dgv_DevolucionNC.Name = "Dgv_DevolucionNC"
        Me.Dgv_DevolucionNC.ReadOnly = True
        Me.Dgv_DevolucionNC.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_DevolucionNC.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_DevolucionNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_DevolucionNC.Size = New System.Drawing.Size(597, 299)
        Me.Dgv_DevolucionNC.TabIndex = 87
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ct"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 35
        '
        'Column8
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column8.HeaderText = "Dv"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 35
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fct."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 37
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 95
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Width = 180
        '
        'tp_descuento
        '
        Me.tp_descuento.BackColor = System.Drawing.Color.White
        Me.tp_descuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tp_descuento.Controls.Add(Me.GroupBox3)
        Me.tp_descuento.Controls.Add(Me.Dgv_DescuentoNC)
        Me.tp_descuento.Location = New System.Drawing.Point(4, 24)
        Me.tp_descuento.Name = "tp_descuento"
        Me.tp_descuento.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_descuento.Size = New System.Drawing.Size(610, 370)
        Me.tp_descuento.TabIndex = 1
        Me.tp_descuento.Text = "Descuento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_renglon)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tb_montodesc)
        Me.GroupBox3.Controls.Add(Me.rb_porcentaje)
        Me.GroupBox3.Controls.Add(Me.rb_monto)
        Me.GroupBox3.Controls.Add(Me.tb_porcentaje)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(544, 52)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione Tipo:"
        '
        'rb_renglon
        '
        Me.rb_renglon.AutoSize = True
        Me.rb_renglon.Location = New System.Drawing.Point(416, 22)
        Me.rb_renglon.Name = "rb_renglon"
        Me.rb_renglon.Size = New System.Drawing.Size(72, 19)
        Me.rb_renglon.TabIndex = 10036
        Me.rb_renglon.TabStop = True
        Me.rb_renglon.Text = "Unitario"
        Me.rb_renglon.UseVisualStyleBackColor = True
        '
        'rb_porcentaje
        '
        Me.rb_porcentaje.AutoSize = True
        Me.rb_porcentaje.Location = New System.Drawing.Point(21, 20)
        Me.rb_porcentaje.Name = "rb_porcentaje"
        Me.rb_porcentaje.Size = New System.Drawing.Size(87, 19)
        Me.rb_porcentaje.TabIndex = 0
        Me.rb_porcentaje.TabStop = True
        Me.rb_porcentaje.Text = "Porcentaje"
        Me.rb_porcentaje.UseVisualStyleBackColor = True
        '
        'rb_monto
        '
        Me.rb_monto.AutoSize = True
        Me.rb_monto.Location = New System.Drawing.Point(221, 20)
        Me.rb_monto.Name = "rb_monto"
        Me.rb_monto.Size = New System.Drawing.Size(64, 19)
        Me.rb_monto.TabIndex = 1
        Me.rb_monto.TabStop = True
        Me.rb_monto.Text = "Monto"
        Me.rb_monto.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Red
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(147, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(194, 20)
        Me.Label24.TabIndex = 10035
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label24.Visible = False
        '
        'Dgv_DescuentoNC
        '
        Me.Dgv_DescuentoNC.AllowUserToAddRows = False
        Me.Dgv_DescuentoNC.AllowUserToDeleteRows = False
        Me.Dgv_DescuentoNC.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_DescuentoNC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.Dgv_DescuentoNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_DescuentoNC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descuento, Me.Column9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.PrecioAct})
        Me.Dgv_DescuentoNC.Location = New System.Drawing.Point(8, 69)
        Me.Dgv_DescuentoNC.MultiSelect = False
        Me.Dgv_DescuentoNC.Name = "Dgv_DescuentoNC"
        Me.Dgv_DescuentoNC.RowHeadersVisible = False
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_DescuentoNC.RowsDefaultCellStyle = DataGridViewCellStyle17
        Me.Dgv_DescuentoNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_DescuentoNC.Size = New System.Drawing.Size(589, 287)
        Me.Dgv_DescuentoNC.TabIndex = 98
        '
        'Descuento
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Descuento.DefaultCellStyle = DataGridViewCellStyle12
        Me.Descuento.HeaderText = "Des(%)"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Width = 55
        '
        'Column9
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N0"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column9.HeaderText = "Dv."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 30
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fct."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 35
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 180
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 85
        '
        'DataGridViewTextBoxColumn14
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "#,##0.00"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn14.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'PrecioAct
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "#,##0.00"
        Me.PrecioAct.DefaultCellStyle = DataGridViewCellStyle16
        Me.PrecioAct.HeaderText = "P.Actual"
        Me.PrecioAct.Name = "PrecioAct"
        Me.PrecioAct.ReadOnly = True
        Me.PrecioAct.Visible = False
        Me.PrecioAct.Width = 72
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 120)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 22)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 22)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "(*) Fecha:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(318, 653)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 27)
        Me.bt_cancelar.TabIndex = 12
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(214, 653)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 27)
        Me.bt_aceptar.TabIndex = 11
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lb_iva)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(387, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 67)
        Me.Panel1.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 22)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Total Factura:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(118, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 22)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "0,00"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_iva
        '
        Me.lb_iva.BackColor = System.Drawing.Color.Transparent
        Me.lb_iva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_iva.Location = New System.Drawing.Point(45, 20)
        Me.lb_iva.Name = "lb_iva"
        Me.lb_iva.Size = New System.Drawing.Size(64, 22)
        Me.lb_iva.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub-Total:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(118, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 22)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "0,00"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(118, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 22)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "0,00"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 22)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "I.V.A."
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 22)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Nº Control F.:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 22)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "##"
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(93, 47)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(78, 22)
        Me.tb_codigo.TabIndex = 95
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(495, 221)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 22)
        Me.Label25.TabIndex = 85
        Me.Label25.Text = "(*)Datos requeridos"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Dgv_Facturas
        '
        Me.Dgv_Facturas.AllowUserToAddRows = False
        Me.Dgv_Facturas.AllowUserToDeleteRows = False
        Me.Dgv_Facturas.AllowUserToResizeColumns = False
        Me.Dgv_Facturas.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Facturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.Dgv_Facturas.AutoGenerateColumns = False
        Me.Dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.ControlInicioDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.Control, Me.DataGridViewTextBoxColumn1})
        Me.Dgv_Facturas.DataSource = Me.SpconsultaFactVentasBindingSource
        Me.Dgv_Facturas.Location = New System.Drawing.Point(6, 109)
        Me.Dgv_Facturas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Dgv_Facturas.MultiSelect = False
        Me.Dgv_Facturas.Name = "Dgv_Facturas"
        Me.Dgv_Facturas.ReadOnly = True
        Me.Dgv_Facturas.RowHeadersVisible = False
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_Facturas.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.Dgv_Facturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Facturas.Size = New System.Drawing.Size(425, 568)
        Me.Dgv_Facturas.TabIndex = 94
        Me.Dgv_Facturas.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
        '
        'ControlInicioDataGridViewTextBoxColumn
        '
        Me.ControlInicioDataGridViewTextBoxColumn.DataPropertyName = "ControlInicio"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ControlInicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.ControlInicioDataGridViewTextBoxColumn.HeaderText = "Fact."
        Me.ControlInicioDataGridViewTextBoxColumn.Name = "ControlInicioDataGridViewTextBoxColumn"
        Me.ControlInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlInicioDataGridViewTextBoxColumn.Width = 60
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 188
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "#,##0.00"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.MontoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 70
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IvaDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'Control
        '
        Me.Control.DataPropertyName = "Control"
        Me.Control.HeaderText = "Control"
        Me.Control.Name = "Control"
        Me.Control.ReadOnly = True
        Me.Control.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'SpconsultaFactVentasBindingSource
        '
        Me.SpconsultaFactVentasBindingSource.DataMember = "sp_consultaFactVentas"
        Me.SpconsultaFactVentasBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dud_buscar
        '
        Me.dud_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dud_buscar.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dud_buscar.FormattingEnabled = True
        Me.dud_buscar.Location = New System.Drawing.Point(6, 68)
        Me.dud_buscar.Name = "dud_buscar"
        Me.dud_buscar.Size = New System.Drawing.Size(215, 26)
        Me.dud_buscar.TabIndex = 10002
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 44)
        Me.GroupBox4.TabIndex = 10003
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtrar"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 18)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "Pendientes por emitir"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(141, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(54, 18)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Todas"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Sp_consultaFactVentasTableAdapter
        '
        Me.Sp_consultaFactVentasTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaNotasCreditoTableAdapter
        '
        Me.Sp_consultaNotasCreditoTableAdapter.ClearBeforeFill = True
        '
        'Frm_NotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 720)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dud_buscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_NotasC)
        Me.Controls.Add(Me.Dgv_Facturas)
        Me.Font = New System.Drawing.Font("Papyrus", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.Name = "Frm_NotaCredito"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Crédito"
        CType(Me.Dgv_NotasC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaNotasCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tp_devolucion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv_DevolucionNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_descuento.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Dgv_DescuentoNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaFactVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_NotasC As System.Windows.Forms.DataGridView
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_montodesc As System.Windows.Forms.TextBox
    Friend WithEvents tb_porcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_codigo As System.Windows.Forms.Label
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_iva As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_devolucion As System.Windows.Forms.TabPage
    Friend WithEvents tp_descuento As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Parcial As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Total As System.Windows.Forms.RadioButton
    Friend WithEvents Dgv_DevolucionNC As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_porcentaje As System.Windows.Forms.RadioButton
    Friend WithEvents rb_monto As System.Windows.Forms.RadioButton
    Friend WithEvents Dgv_DescuentoNC As System.Windows.Forms.DataGridView
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Dgv_Facturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dud_buscar As System.Windows.Forms.ComboBox
    Friend WithEvents rb_renglon As System.Windows.Forms.RadioButton
    Friend WithEvents chk_ajustada As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents SpconsultaFactVentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaFactVentasTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFactVentasTableAdapter
    Friend WithEvents SpconsultaNotasCreditoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaNotasCreditoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNotasCreditoTableAdapter
    Friend WithEvents MelDataSet1 As Tesis_Nueva.MELDataSet
    Friend WithEvents tb_imp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_controlInicio As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rb_pendiente As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fisica As System.Windows.Forms.RadioButton
    Friend WithEvents tb_user As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents NroControlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlInicioDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoNotaCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Control2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Control As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioAct As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
