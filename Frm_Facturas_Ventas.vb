Imports Microsoft.Reporting.WinForms

Public Class Frm_Facturas_Ventas
    Inherits System.Windows.Forms.Form
    Dim t As Threading.Thread
    Dim antes1 As String = ""
    Dim antes2 As String = ""
    Private sw0 As Boolean = False
    Dim cambio As Boolean = False
    Private CodCliente As String
    Private sw As Boolean = False
    Private sw1 As Boolean = False
    Private item As Object
    Private cuantos As Integer
    Private fila As Integer
    Private boton As String = ""
    Private codF As Integer
    Private choice As Integer
    Private swC As Boolean = False
    Private indice As Integer = 0
    Private ventana As Integer = 0
    Private v1 As Integer
    Private v2 As Integer
    Private er As Boolean = False
    Private wr As Boolean = False
    Private v3 As Integer
    Private v4 As String
    Private f14 As Frm_Pedidos_Clientes
    Private varV As String = ""
    Friend WithEvents DGV_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tb_dias As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents l_facturador As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.Label
    Friend WithEvents tb_pedido As System.Windows.Forms.Label
    Friend WithEvents bt_recibo As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_vendedor As MTGCComboBox
    Friend WithEvents lb_iva As System.Windows.Forms.Label
    Friend WithEvents DGV_TodasLasFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Cb_enviado As System.Windows.Forms.CheckBox
    Friend WithEvents cb_fev As System.Windows.Forms.CheckBox
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_ObsPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Private swff As Boolean = False
    Dim w As Boolean
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpConsultaClienteFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_ConsultaClienteFacturaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaClienteFacturaTableAdapter
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Control As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_imp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_controlInicio As System.Windows.Forms.TextBox
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents bt_express As System.Windows.Forms.Button
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents bt_bultos As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_bultos As System.Windows.Forms.TextBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Facturas_Ventas))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_express = New System.Windows.Forms.Button
        Me.tb_direccion = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.tb_controlInicio = New System.Windows.Forms.TextBox
        Me.tb_imp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_ObsPedido = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.l_facturador = New System.Windows.Forms.Label
        Me.lbl_cliente = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cb_fev = New System.Windows.Forms.CheckBox
        Me.Cb_enviado = New System.Windows.Forms.CheckBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.tb_vendedor = New MTGCComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.Label
        Me.tb_pedido = New System.Windows.Forms.Label
        Me.tb_dias = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.DGV_facturas = New System.Windows.Forms.DataGridView
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label21 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_bultos = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lb_iva = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_recibo = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DGV_TodasLasFacturas = New System.Windows.Forms.DataGridView
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Control = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpConsultaClienteFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Sp_ConsultaClienteFacturaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_ConsultaClienteFacturaTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_TodasLasFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpConsultaClienteFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(356, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(665, 23)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Datos de la Factura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.bt_express)
        Me.GroupBox2.Controls.Add(Me.tb_direccion)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.tb_controlInicio)
        Me.GroupBox2.Controls.Add(Me.tb_imp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tb_ObsPedido)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.l_facturador)
        Me.GroupBox2.Controls.Add(Me.lbl_cliente)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cb_fev)
        Me.GroupBox2.Controls.Add(Me.Cb_enviado)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.tb_vendedor)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.tb_pedido)
        Me.GroupBox2.Controls.Add(Me.tb_dias)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tb_observacion)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.DGV_facturas)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.bt_cancelar)
        Me.GroupBox2.Controls.Add(Me.bt_aceptar)
        Me.GroupBox2.Controls.Add(Me.tb_bultos)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(356, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 653)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'bt_express
        '
        Me.bt_express.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_express.Location = New System.Drawing.Point(289, 627)
        Me.bt_express.Name = "bt_express"
        Me.bt_express.Size = New System.Drawing.Size(75, 23)
        Me.bt_express.TabIndex = 109
        Me.bt_express.Text = "Express"
        Me.bt_express.Visible = False
        '
        'tb_direccion
        '
        Me.tb_direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion.Location = New System.Drawing.Point(90, 93)
        Me.tb_direccion.MaxLength = 250
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.ReadOnly = True
        Me.tb_direccion.Size = New System.Drawing.Size(299, 40)
        Me.tb_direccion.TabIndex = 108
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 18)
        Me.Label25.TabIndex = 107
        Me.Label25.Text = "Dirección:"
        '
        'tb_controlInicio
        '
        Me.tb_controlInicio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_controlInicio.Location = New System.Drawing.Point(97, 16)
        Me.tb_controlInicio.MaxLength = 6
        Me.tb_controlInicio.Name = "tb_controlInicio"
        Me.tb_controlInicio.ReadOnly = True
        Me.tb_controlInicio.Size = New System.Drawing.Size(95, 22)
        Me.tb_controlInicio.TabIndex = 106
        '
        'tb_imp
        '
        Me.tb_imp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_imp.Location = New System.Drawing.Point(305, 16)
        Me.tb_imp.MaxLength = 6
        Me.tb_imp.Name = "tb_imp"
        Me.tb_imp.ReadOnly = True
        Me.tb_imp.Size = New System.Drawing.Size(79, 22)
        Me.tb_imp.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "(*)Nro. Imp:"
        '
        'tb_ObsPedido
        '
        Me.tb_ObsPedido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ObsPedido.Location = New System.Drawing.Point(91, 135)
        Me.tb_ObsPedido.MaxLength = 250
        Me.tb_ObsPedido.Multiline = True
        Me.tb_ObsPedido.Name = "tb_ObsPedido"
        Me.tb_ObsPedido.Size = New System.Drawing.Size(299, 40)
        Me.tb_ObsPedido.TabIndex = 103
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 137)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 18)
        Me.Label28.TabIndex = 102
        Me.Label28.Text = "Obs. Pedido:"
        '
        'l_facturador
        '
        Me.l_facturador.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_facturador.Location = New System.Drawing.Point(262, 40)
        Me.l_facturador.Name = "l_facturador"
        Me.l_facturador.Size = New System.Drawing.Size(150, 22)
        Me.l_facturador.TabIndex = 93
        Me.l_facturador.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(91, 64)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(324, 22)
        Me.lbl_cliente.TabIndex = 101
        Me.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 22)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Cliente:"
        '
        'cb_fev
        '
        Me.cb_fev.AutoSize = True
        Me.cb_fev.Enabled = False
        Me.cb_fev.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_fev.Location = New System.Drawing.Point(134, 221)
        Me.cb_fev.Name = "cb_fev"
        Me.cb_fev.Size = New System.Drawing.Size(210, 19)
        Me.cb_fev.TabIndex = 99
        Me.cb_fev.Text = "Factura Entregada al Vendedor"
        Me.cb_fev.UseVisualStyleBackColor = True
        '
        'Cb_enviado
        '
        Me.Cb_enviado.AutoSize = True
        Me.Cb_enviado.Enabled = False
        Me.Cb_enviado.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_enviado.Location = New System.Drawing.Point(12, 221)
        Me.Cb_enviado.Name = "Cb_enviado"
        Me.Cb_enviado.Size = New System.Drawing.Size(117, 19)
        Me.Cb_enviado.TabIndex = 98
        Me.Cb_enviado.Text = "Pedido Enviado"
        Me.Cb_enviado.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(421, 163)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(234, 27)
        Me.Panel4.TabIndex = 75
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 23)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "N.C. Asociadas"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(118, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 23)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "0,00"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_vendedor
        '
        Me.tb_vendedor.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_vendedor.ColumnNum = 2
        Me.tb_vendedor.ColumnWidth = "100;44"
        Me.tb_vendedor.DisplayMember = "Text"
        Me.tb_vendedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_vendedor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_vendedor.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_vendedor.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_vendedor.DropDownWidth = 164
        Me.tb_vendedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_vendedor.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_vendedor.GridLineHorizontal = False
        Me.tb_vendedor.GridLineVertical = False
        Me.tb_vendedor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_vendedor.Location = New System.Drawing.Point(502, 36)
        Me.tb_vendedor.ManagingFastMouseMoving = True
        Me.tb_vendedor.ManagingFastMouseMovingInterval = 30
        Me.tb_vendedor.Name = "tb_vendedor"
        Me.tb_vendedor.Size = New System.Drawing.Size(153, 23)
        Me.tb_vendedor.TabIndex = 97
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(418, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 18)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "Vendedor:"
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(341, 222)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(78, 22)
        Me.tb_codigo.TabIndex = 95
        Me.tb_codigo.Text = "CodigoFact"
        Me.tb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tb_codigo.Visible = False
        '
        'tb_pedido
        '
        Me.tb_pedido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pedido.Location = New System.Drawing.Point(91, 42)
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.Size = New System.Drawing.Size(80, 22)
        Me.tb_pedido.TabIndex = 94
        Me.tb_pedido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'tb_dias
        '
        Me.tb_dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_dias.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dias.FormattingEnabled = True
        Me.tb_dias.Location = New System.Drawing.Point(502, 62)
        Me.tb_dias.Name = "tb_dias"
        Me.tb_dias.Size = New System.Drawing.Size(51, 23)
        Me.tb_dias.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "(*)Días Créd:"
        '
        'tb_observacion
        '
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(91, 177)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.Size = New System.Drawing.Size(299, 40)
        Me.tb_observacion.TabIndex = 88
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 24)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Observacion:"
        '
        'DGV_facturas
        '
        Me.DGV_facturas.AllowUserToAddRows = False
        Me.DGV_facturas.AllowUserToDeleteRows = False
        Me.DGV_facturas.AllowUserToResizeColumns = False
        Me.DGV_facturas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_facturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.Descripcion, Me.Modelo, Me.Precio, Me.SubTotal, Me.Devolucion})
        Me.DGV_facturas.Location = New System.Drawing.Point(4, 247)
        Me.DGV_facturas.MultiSelect = False
        Me.DGV_facturas.Name = "DGV_facturas"
        Me.DGV_facturas.ReadOnly = True
        Me.DGV_facturas.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_facturas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_facturas.Size = New System.Drawing.Size(656, 377)
        Me.DGV_facturas.TabIndex = 86
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Qty"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 42
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 160
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 140
        '
        'Precio
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 70
        '
        'SubTotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubTotal.HeaderText = "Sub-total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 80
        '
        'Devolucion
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Devolucion.DefaultCellStyle = DataGridViewCellStyle5
        Me.Devolucion.HeaderText = "Dev."
        Me.Devolucion.Name = "Devolucion"
        Me.Devolucion.ReadOnly = True
        Me.Devolucion.Width = 45
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 23)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Nro. Control:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(502, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 22)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(178, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 22)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Facturador:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Fecha:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(421, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 45)
        Me.Panel3.TabIndex = 70
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 23)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Falta:"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(114, 19)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 24)
        Me.Label27.TabIndex = 77
        Me.Label27.Text = "0,00"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 23)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Cancelado:"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(114, -3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 24)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "0,00"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(368, 627)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 12
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(208, 627)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 11
        Me.bt_aceptar.Text = "Aceptar"
        '
        'tb_bultos
        '
        Me.tb_bultos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bultos.Location = New System.Drawing.Point(613, 62)
        Me.tb_bultos.MaxLength = 70
        Me.tb_bultos.Name = "tb_bultos"
        Me.tb_bultos.Size = New System.Drawing.Size(42, 22)
        Me.tb_bultos.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(421, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 28)
        Me.Panel2.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 23)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Monto Total:"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(118, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 23)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "0,00"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lb_iva)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(421, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 42)
        Me.Panel1.TabIndex = 58
        '
        'lb_iva
        '
        Me.lb_iva.BackColor = System.Drawing.Color.Transparent
        Me.lb_iva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_iva.Location = New System.Drawing.Point(45, 20)
        Me.lb_iva.Name = "lb_iva"
        Me.lb_iva.Size = New System.Drawing.Size(64, 23)
        Me.lb_iva.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sub-Total:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(118, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 23)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "0,00"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(118, -2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 23)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "0,00"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "I.V.A."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Nº Pedido:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(566, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Bultos:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(221, 142)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(159, 20)
        Me.Label24.TabIndex = 84
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label24.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(284, 650)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "#"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(187, 73)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(156, 25)
        Me.tb_buscarcodigo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(241, 651)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Total:"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_modificar, Me.bt_recibo, Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(75, 55)
        Me.ToolBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-2, -2)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(343, 65)
        Me.ToolBar1.TabIndex = 65
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 0
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_recibo
        '
        Me.bt_recibo.ImageIndex = 5
        Me.bt_recibo.Name = "bt_recibo"
        Me.bt_recibo.Text = "Bultos"
        '
        'bt_imprimir
        '
        Me.bt_imprimir.ImageIndex = 4
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Text = "Imprimir"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 1
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
        Me.ImageList2.Images.SetKeyName(4, "icono-impresion.gif")
        Me.ImageList2.Images.SetKeyName(5, "box1.png")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'DGV_TodasLasFacturas
        '
        Me.DGV_TodasLasFacturas.AllowUserToAddRows = False
        Me.DGV_TodasLasFacturas.AllowUserToDeleteRows = False
        Me.DGV_TodasLasFacturas.AllowUserToResizeColumns = False
        Me.DGV_TodasLasFacturas.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TodasLasFacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_TodasLasFacturas.AutoGenerateColumns = False
        Me.DGV_TodasLasFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TodasLasFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroFacturaDataGridViewTextBoxColumn, Me.ControlInicioDataGridViewTextBoxColumn, Me.CodigoClienteDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.Control})
        Me.DGV_TodasLasFacturas.DataSource = Me.SpConsultaClienteFacturaBindingSource
        Me.DGV_TodasLasFacturas.Location = New System.Drawing.Point(5, 105)
        Me.DGV_TodasLasFacturas.MultiSelect = False
        Me.DGV_TodasLasFacturas.Name = "DGV_TodasLasFacturas"
        Me.DGV_TodasLasFacturas.ReadOnly = True
        Me.DGV_TodasLasFacturas.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_TodasLasFacturas.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_TodasLasFacturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_TodasLasFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_TodasLasFacturas.Size = New System.Drawing.Size(345, 537)
        Me.DGV_TodasLasFacturas.TabIndex = 98
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'ControlInicioDataGridViewTextBoxColumn
        '
        Me.ControlInicioDataGridViewTextBoxColumn.DataPropertyName = "ControlInicio"
        Me.ControlInicioDataGridViewTextBoxColumn.HeaderText = "Nro."
        Me.ControlInicioDataGridViewTextBoxColumn.Name = "ControlInicioDataGridViewTextBoxColumn"
        Me.ControlInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlInicioDataGridViewTextBoxColumn.Width = 57
        '
        'CodigoClienteDataGridViewTextBoxColumn
        '
        Me.CodigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.Name = "CodigoClienteDataGridViewTextBoxColumn"
        Me.CodigoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClienteDataGridViewTextBoxColumn.Width = 56
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 210
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'Control
        '
        Me.Control.DataPropertyName = "Control"
        Me.Control.HeaderText = "Control"
        Me.Control.Name = "Control"
        Me.Control.ReadOnly = True
        Me.Control.Visible = False
        '
        'SpConsultaClienteFacturaBindingSource
        '
        Me.SpConsultaClienteFacturaBindingSource.DataMember = "sp_ConsultaClienteFactura"
        Me.SpConsultaClienteFacturaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(5, 72)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(171, 26)
        Me.DomainUpDown1.TabIndex = 99
        '
        'Sp_ConsultaClienteFacturaTableAdapter
        '
        Me.Sp_ConsultaClienteFacturaTableAdapter.ClearBeforeFill = True
        '
        'Frm_Facturas_Ventas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 674)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.DGV_TodasLasFacturas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-4, 40)
        Me.MaximizeBox = False
        Me.Name = "Frm_Facturas_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Facturas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DGV_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_TodasLasFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpConsultaClienteFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            If e.Button Is Me.bt_salir Then
                Label16.Text = "0,00"
                Label17.Text = "0,00"
                Label19.Text = "0,00"
                Label20.Text = "0,00"
                Label27.Text = "0,00"
                Label23.Text = "0,00"
                tb_buscarcodigo.Clear()
                tb_codigo.Text = ""
                tb_controlInicio.Text = ""
                tb_dias.ResetText()
                tb_observacion.Clear()
                tb_bultos.Clear()
                tb_pedido.Text = ""
                cb_fev.Checked = False
                cb_fev.Enabled = False

                If swC = True Then
                    swC = False
                    'Frm_Principal.Frm_Ventas.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Ventas.bt_actualizar))
                    'Frm_Principal.Frm_Ventas.refresca_lvfacturas(indice)
                End If
                If swff Then
                    DatosPedidoCliente.consulta_pedidosclientes(f14.DGV_Pedidos, "")
                    f14.Visible = True
                End If
                Me.Close()
            ElseIf e.Button Is Me.bt_imprimir Then
                If DGV_TodasLasFacturas.RowCount > 1 Then
                    Dim ctrl As Integer = 0
                    Dim controlAnt As Integer = DatosFacturas.consultaUltimaFac(CInt(Me.tb_controlInicio.Text), 1, ctrl)
                    If DatosFacturas.FechaValida(DateTimePicker1.Value, controlAnt) Then
                        Dim r_factura As New R_Factura
                        r_factura.valores_Factura(Me.tb_codigo.Text, Me.CodCliente, My.Settings.CodigoFabricaFact)
                        r_factura.Show()
                        'Dim r_guiaCodF As New R_Guia_Codigos_Fabrica
                        'r_guiaCodF.valores_Guia(CInt(Me.tb_pedido.Text), Me.CodCliente)
                        'r_guiaCodF.Show()
                    Else
                        MsgBox("La fecha de la factura no puede ser menor a la de la factura anterior, modifique la factura")
                    End If
                Else
                    Dim r_factura As New R_Factura
                    r_factura.valores_Factura(Me.tb_codigo.Text, Me.CodCliente, My.Settings.CodigoFabricaFact)
                    r_factura.Show()
                End If
            ElseIf e.Button Is Me.bt_modificar Then
                Dim n As Integer
                n = Me.DGV_TodasLasFacturas.SelectedRows.Count
                If n = 1 Then
                    boton = "m"
                    Cb_enviado.Enabled = True
                    varV = Me.tb_vendedor.Text
                    Me.ToolBar1.Enabled = False
                    Me.tb_buscarcodigo.Enabled = False
                    'Me.tb_bultos.ReadOnly = False
                    tb_imp.ReadOnly = False
                    Me.DateTimePicker1.Enabled = True
                    Me.bt_aceptar.Visible = True
                    Me.bt_cancelar.Visible = True
                    Me.DGV_TodasLasFacturas.Enabled = False
                    Me.tb_bultos.ReadOnly = False
                    Me.tb_dias.Enabled = True
                    Me.tb_observacion.ReadOnly = False
                    cb_fev.Enabled = True
                    RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                    'Me.tb_buscarcodigo.Clear()
                    AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                    Me.tb_imp.Focus()
                    Me.tb_imp.SelectAll()
                    Me.tb_vendedor.Enabled = True
                    If My.Settings.Nro_Control_Editable Then
                        tb_controlInicio.ReadOnly = False
                        tb_controlInicio.Focus()
                        tb_controlInicio.SelectAll()
                    End If
                ElseIf n = 0 Then
                    MsgBox("Debe seleccionar la factura que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
                Else
                    MsgBox("Sólo puede modificar una factura a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
                End If
                'Me.DGV_TodasLasFacturas.ClearSelection()
            ElseIf e.Button Is Me.bt_recibo Then

                If tb_bultos.Text = "" Then

                    MsgBox("No existen bultos asociados", MsgBoxStyle.Critical)

                Else

                    If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                        Dim frm As New Frm_impresionBultos_BRWME
                        frm.recibe(DGV_TodasLasFacturas.SelectedRows(0).Cells(1).Value, Me.tb_bultos.Text, DGV_TodasLasFacturas.SelectedRows(0).Cells(4).Value, DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value)
                        frm.Show()

                    Else

                        Dim frm As New Frm_impresionBultos
                        frm.recibe(DGV_TodasLasFacturas.SelectedRows(0).Cells(1).Value, Me.tb_bultos.Text, DGV_TodasLasFacturas.SelectedRows(0).Cells(4).Value, DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value)
                        frm.Show()

                    End If


                End If

            End If
        Catch ex As Exception

        End Try


    End Sub
    Public Sub facturar(ByVal codPed As Integer, ByRef fo As Frm_Pedidos_Clientes, ByVal codC As String, ByVal ven As String, ByVal bultos As String)
        Me.CodCliente = codC
        f14 = fo
        swff = True
        Me.tb_vendedor.Text = ven
        DatosFacturas.consulta_nroImp(Me.tb_imp.Text)
        DatosFacturas.identidad_Factura(Me.tb_codigo.Text)
        DatosFacturas.control_Factura(Me.tb_controlInicio.Text)
        tb_codigo.Text = tb_controlInicio.Text
        Me.tb_pedido.Text = CStr(codPed)
        'Me.tb_controlInicio.Enabled = True
        Me.l_facturador.Text = Frm_Principal.user_l
        Me.tb_bultos.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.tb_bultos.ReadOnly = False
        Me.tb_dias.Enabled = True
        Me.bt_aceptar.Visible = True
        Me.bt_cancelar.Visible = True
        tb_bultos.Text = bultos
        Me.tb_observacion.ReadOnly = False
        Me.tb_vendedor.Enabled = True
        boton = "F"
        DatosFacturas.consulta_productos_pedido(Convert.ToString(codPed), Me.DGV_facturas)
        Me.Label16.Text = CStr(calculasubtotal(Me.DGV_facturas))
        Me.Label16.Text = Format(CDbl(Me.Label16.Text), "#,##0.00")
        Dim iva As Double
        DatosFacturas.consulta_iva(iva)
        Me.lb_iva.Text = Format(iva, "#,##0.00") + "%:"
        Me.Label17.Text = CDbl(Me.Label16.Text) * (iva / 100)
        Me.Label17.Text = Format(CDbl(Me.Label17.Text), "#,##0.00")
        Me.Label19.Text = CStr(CDbl(Me.Label16.Text) + CDbl(Me.Label17.Text))
        Me.Label19.Text = Format(CDbl(Me.Label19.Text), "#,##0.00")
        Me.Label20.Text = 0
        Me.Label27.Text = CDbl(Me.Label19.Text) - CDbl(Me.Label20.Text)
        Me.Label27.Text = Format(CDbl(Me.Label27.Text), "#,##0.00")

        If My.Settings.Nro_Control_Editable Then
            tb_controlInicio.ReadOnly = False
            tb_controlInicio.Focus()
            tb_controlInicio.SelectAll()
        End If

    End Sub
    Public Sub facturar(ByVal codPed As Integer)
        Try

            DatosFacturas.identidad_Factura(Me.tb_codigo.Text)
            Me.tb_pedido.Text = CStr(codPed)
            Me.tb_controlInicio.Enabled = True
            Me.l_facturador.Enabled = True

            Me.tb_bultos.Enabled = True

            Me.DateTimePicker1.Enabled = True
            Me.tb_bultos.ReadOnly = False

            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            boton = "F"

            DatosFacturas.consulta_productos_pedido(Convert.ToString(codPed), Me.DGV_facturas)
            Me.Label16.Text = CStr(calculasubtotal(Me.DGV_facturas))
            Me.Label17.Text = CStr(CDbl(Me.Label16.Text) * 0.15)
            Dim xx As Double = CDbl(Me.Label16.Text) + CDbl(Me.Label17.Text)
            xx = Format(xx, "#0.00")
            Me.Label19.Text = CStr(xx)
            Me.Label20.Text = 0
            Me.Label27.Text = CDbl(Me.Label19.Text) - CDbl(Me.Label20.Text)
            Me.Label27.Text = Format(CDbl(Me.Label27.Text), "#.00")

        Catch ex As Exception



        End Try

    End Sub

    Private Sub limpiacolec(ByRef col As Collection)
        For Each item In col
            col.Remove(1)
        Next
    End Sub
    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Sp_ConsultaClienteFacturaTableAdapter.Fill(Me.MELDataSet.sp_ConsultaClienteFactura, 0)

        Datos.consulta_vendedores(Me.tb_vendedor)
        DatosPedidoCliente.consulta_DiasCred(tb_dias)
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.tb_bultos.ReadOnly = True
        Me.tb_ObsPedido.ReadOnly = True
        Me.DateTimePicker1.Enabled = False
        Me.DGV_TodasLasFacturas.Enabled = True
        Me.tb_dias.Enabled = False
        Me.tb_vendedor.Enabled = False
        Me.tb_observacion.ReadOnly = True
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("NºControl")
        Me.DomainUpDown1.Items.Add("Nombre Cliente")
        'Me.DomainUpDown1.SelectedIndex = 0
        If ventana = 2 Then
            ventana = 0
            'DatosFacturas.consulta_UnaFactura(DGV_TodasLasFacturas, v1, v2, v3, v4)
            SpConsultaClienteFacturaBindingSource.Filter = "Control = " & v2
            DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            DGV_TodasLasFacturas_CellClick()
            Me.DGV_facturas.Focus()
        Else
            'DatosFacturas.consulta_facturas(Me.DGV_TodasLasFacturas)
            Me.DateTimePicker1.Value = Today()
            DGV_TodasLasFacturas.ClearSelection()
        End If

        Label10.Text = Me.DGV_TodasLasFacturas.RowCount
        DomainUpDown1.SelectedIndex = 0
        DatosFacturas.consulta_top_facturas(tb_controlInicio.Text)
        tb_buscarcodigo.Focus()
        If w = False Then
            'Me.bt_recibo.Visible = False
            Me.bt_imprimir.Visible = False
            Me.bt_modificar.Visible = False
        End If
        If wr = False And w = False Then
            'Me.bt_recibo.Visible = False
            Me.bt_imprimir.Visible = False
            Me.bt_modificar.Visible = False
        Else
            Me.bt_recibo.Visible = True
            Me.bt_imprimir.Visible = True
            Me.bt_modificar.Visible = True
        End If

        tb_imp.Visible = My.Settings.Nro_Imp_Visible
        Label5.Visible = My.Settings.Nro_Imp_Visible

        tb_controlInicio.Text = ""

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub
    Public Sub permisosRecibos(ByVal wr1 As Boolean, ByVal er1 As Boolean)
        wr = wr1
        er = er1
    End Sub
    Private Function llenos() As Boolean
        Dim ll As Boolean = False

        If My.Settings.Nro_Imp_Visible Then

            If Me.tb_imp.Text = "" Or Me.tb_dias.Text = "" Then
                ll = True
            Else
                ll = False
            End If

        Else

            If Me.tb_dias.Text = "" Then
                ll = True
            Else
                ll = False
            End If

        End If

        Return ll

    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Try

            Dim deny As Boolean = False
            Dim entrega As Boolean = False
            If cb_fev.Checked = True Then
                entrega = True
            Else
                entrega = False
            End If

            Dim esta As Boolean = False
            If boton = "m" Then

                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*)", MsgBoxStyle.Exclamation, "Advertencia")
                    deny = True
                Else

                    If My.Settings.Nro_Imp_Visible And (tb_imp.Text <> antes1 Or antes1 = "") Then
                        DatosFacturas.consulta_numero_control(CInt(Me.tb_imp.Text), esta)
                    Else
                        If My.Settings.Nro_Control_Editable And (tb_controlInicio.Text <> antes2 Or antes2 = "") Then
                            DatosFacturas.consulta_numero_control(CInt(Me.tb_controlInicio.Text), esta)
                        End If
                    End If


                    If esta = False Then

                        'If esta = False Then

                        If My.Settings.Nro_Imp_Visible Then
                            DatosFacturas.modifica_factura(Me.DateTimePicker1.Value, CInt(Me.tb_controlInicio.Text), Me.l_facturador.Text, Me.tb_bultos.Text, CInt(Me.tb_codigo.Text), Me.tb_observacion.Text, CInt(tb_dias.Text), CInt(tb_pedido.Text), Cb_enviado.Checked, entrega, CInt(tb_imp.Text))
                        Else
                            DatosFacturas.modifica_factura(Me.DateTimePicker1.Value, CInt(Me.tb_controlInicio.Text), Me.l_facturador.Text, Me.tb_bultos.Text, CInt(Me.tb_codigo.Text), Me.tb_observacion.Text, CInt(tb_dias.Text), CInt(tb_pedido.Text), Cb_enviado.Checked, entrega, 0)
                        End If

                        If Not varV = Me.tb_vendedor.Text Then
                            DatosPedidoCliente.modifica_Vendedorpedidocliente(CInt(Me.tb_pedido.Text), CInt(Me.tb_vendedor.SelectedItem.col2))
                        End If

                        MsgBox("La Factura Ha Sido Modificada Exitosamente")

                        Datos.Inserta_Actividad("Modificó la factura nro. " + DGV_TodasLasFacturas.SelectedRows(0).Cells(5).Value.ToString + " del cliente (" + DGV_TodasLasFacturas.SelectedRows(0).Cells(2).Value.ToString + ") " + DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value.ToString)

                        'Else

                        '    MsgBox("El número de control ya se encuentra registrado", MsgBoxStyle.Exclamation, "Advertencia")
                        '    deny = True
                        '    tb_imp.Focus()
                        '    tb_imp.SelectAll()

                        'End If

                    Else

                        MsgBox("El número de control ya se encuentra registrado", MsgBoxStyle.Exclamation, "Advertencia")
                        deny = True
                        tb_imp.Focus()
                        tb_imp.SelectAll()

                    End If

                End If

            ElseIf boton = "F" Then
                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*)")
                    deny = True
                Else

                    If My.Settings.Nro_Imp_Visible Then
                        DatosFacturas.consulta_numero_control(CInt(Me.tb_imp.Text), esta)
                    Else
                        If My.Settings.Nro_Control_Editable Then
                            DatosFacturas.consulta_numero_control(CInt(Me.tb_controlInicio.Text), esta)
                        End If
                    End If

                    If esta = False Then

                        If CInt(tb_bultos.Text) > 0 Then

                            Dim iva As Double

                            DatosFacturas.consulta_iva(iva)
                            DatosFacturas.inserta_Factura(Me.DateTimePicker1.Value, CInt(Me.tb_controlInicio.Text), Me.l_facturador.Text, Me.tb_bultos.Text, CInt(Me.tb_pedido.Text), CDbl(Me.Label20.Text), CDbl(Me.Label16.Text), Me.tb_observacion.Text, iva, CInt(tb_dias.Text), entrega, CInt(tb_imp.Text))
                            DatosFacturas.Elimina_Ubicaciones_Cero(CInt(tb_pedido.Text))

                            Datos.Inserta_Actividad("Creó la factura nro. " + Me.tb_controlInicio.Text + " del cliente (" + CodCliente + ") " + lbl_cliente.Text)

                            Dim response As MsgBoxResult
                            response = MsgBox("El pedido se ha Facturado Exitosamente. ¿Desea imprimir la factura?", MsgBoxStyle.YesNo)
                            If response = MsgBoxResult.Yes Then
                                Dim ctrl As Integer = 0
                                Dim controlAnt As Integer = DatosFacturas.consultaUltimaFac(CInt(Me.tb_controlInicio.Text), 0, ctrl)
                                If DatosFacturas.FechaValida(DateTimePicker1.Value, controlAnt) Then
                                    Dim r_factura As New R_Factura
                                    r_factura.valores_Factura((controlAnt + 1).ToString, Me.CodCliente, My.Settings.CodigoFabricaFact)
                                    'Dim r_guia As New R_Guia_Codigos_Fabrica
                                    'r_guia.valores_Guia(Me.tb_pedido.Text, Me.CodCliente)
                                    'r_guia.Show()
                                    r_factura.Show()
                                Else
                                    MsgBox("La fecha de la factura no puede ser menor a la de la factura anterior, modifique la factura")
                                End If
                            End If

                        Else

                            MsgBox("La factura debe contener al menos un bulto", MsgBoxStyle.Exclamation, "SINPRO")

                        End If


                    Else
                        MsgBox("El número de control ya se encuentra registrado", MsgBoxStyle.Exclamation, "Advertencia")
                        deny = True
                        tb_imp.Focus()
                        tb_imp.SelectAll()
                    End If

                End If
            End If

            If deny = False Then

                Me.tb_bultos.ReadOnly = True
                Me.tb_bultos.Clear()
                Me.tb_controlInicio.Text = ""
                Me.DateTimePicker1.Enabled = False
                Me.bt_aceptar.Visible = False
                Me.bt_cancelar.Visible = False
                Me.bt_express.Visible = False
                Me.DGV_TodasLasFacturas.Enabled = True
                Me.tb_dias.ResetText()
                Me.tb_dias.Enabled = False
                antes1 = ""
                antes2 = ""
                Me.tb_observacion.Clear()
                Me.tb_observacion.ReadOnly = True
                Me.tb_ObsPedido.Clear()
                tb_controlInicio.ReadOnly = True
                Cb_enviado.Enabled = False
                Me.DateTimePicker1.Value = Today()
                Me.ToolBar1.Enabled = True
                Me.DomainUpDown1.Enabled = True
                Me.tb_vendedor.Enabled = False
                Me.tb_vendedor.ResetText()
                Datos.consulta_vendedores(Me.tb_vendedor)
                Me.tb_codigo.Text = ""
                Me.l_facturador.Text = ""
                Me.tb_pedido.Text = ""
                cb_fev.Enabled = False
                boton = ""
                lbl_cliente.Text = ""
                Me.tb_buscarcodigo.Enabled = True
                tb_controlInicio.ReadOnly = False
                tb_imp.Clear()
                tb_imp.ReadOnly = True
                Me.tb_buscarcodigo.Text = ""
                'DatosFacturas.consulta_facturas(Me.DGV_TodasLasFacturas)
                Sp_ConsultaClienteFacturaTableAdapter.Fill(Me.MELDataSet.sp_ConsultaClienteFactura, 0)
                SpConsultaClienteFacturaBindingSource.RemoveFilter()
                DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                DGV_TodasLasFacturas_CellClick()
                Label10.Text = Me.DGV_TodasLasFacturas.RowCount
            End If

        Catch ex As Exception



        End Try
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        If boton = "F" Then
            If swff Then
                f14.Visible = True
                f14.DGV_Pedidos.ClearSelection()
                f14.tb_buscar.Focus()
                f14.tb_buscar.SelectAll()
            End If

            Me.Close()
        Else
            tb_buscarcodigo.Enabled = True
            Me.tb_bultos.ReadOnly = True
            Me.DateTimePicker1.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.tb_controlInicio.Enabled = False
            Me.DGV_TodasLasFacturas.Enabled = True
            Me.ToolBar1.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.tb_dias.ResetText()
            Me.tb_bultos.Clear()
            Me.tb_codigo.Text = ""
            Me.cb_fev.Enabled = False
            Me.l_facturador.Text = ""
            Me.tb_pedido.Text = ""
            antes1 = ""
            antes2 = ""
            Me.tb_ObsPedido.Clear()
            tb_controlInicio.ReadOnly = True
            Me.tb_controlInicio.Text = ""
            Me.DateTimePicker1.Value = DateTime.Now
            boton = ""
            Me.tb_buscarcodigo.Text = ""
            Datos.consulta_vendedores(Me.tb_vendedor)
            'DatosFacturas.consulta_facturas(Me.DGV_TodasLasFacturas)
            tb_imp.Clear()
            tb_imp.ReadOnly = True

            CrearWhere()

            lbl_cliente.Text = ""
            Cb_enviado.Enabled = False
            Label16.Text = "0,00"
            Label17.Text = "0,00"
            Label19.Text = "0,00"
            Label20.Text = "0,00"
            Label27.Text = "0,00"
            Label23.Text = "0,00"
            Me.tb_dias.SelectedIndex = 0
            Me.tb_dias.Enabled = False
            Me.tb_vendedor.Enabled = False
            Me.tb_observacion.ReadOnly = True
            tb_buscarcodigo.Focus()
            DGV_facturas.Rows.Clear()
        End If
    End Sub

    Private Sub AddData(ByVal cped As Integer)
        Try
            DatosFacturas.consulta_productos_factura(CInt(Me.DGV_TodasLasFacturas.SelectedRows(0).Cells(0).Value), Me.DGV_facturas, 3)
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub multiples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, Panel1.Click, Panel2.Click, GroupBox2.Click, tb_bultos.Click, tb_buscarcodigo.Click, Label10.Click, Label11.Click, Label12.Click, Label2.Click, Label5.Click, Label6.Click, Label8.Click, Label9.Click, Label1.Click
    '    Try
    '        Me.DGV_TodasLasFacturas.ClearSelection()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Public Sub devuelvefoco(ByVal cod As Integer)
        Me.DGV_TodasLasFacturas.Focus()
        Me.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
        Me.DGV_TodasLasFacturas.Select()
    End Sub

    Private Function calculasubtotal(ByRef t As DataGridView) As Double
        Dim cont As Integer = 0
        Dim acum As Double = 0
        While cont < t.Rows.Count
            acum = acum + ((t(0, cont).Value) * (t(4, cont).Value))
            cont = cont + 1
        End While
        Return acum
    End Function



    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        Try

            'If Me.DGV_TodasLasFacturas.Enabled = True Then
            '    Dim s1 As String
            '    s1 = Me.tb_buscarcodigo.Text + "%"
            '    If choice = 0 Then
            '        DatosFacturas.DGV_factura(DGV_TodasLasFacturas, s1, 0)
            '        Label10.Text = DGV_TodasLasFacturas.RowCount
            '    ElseIf choice = 1 Then
            '        DatosFacturas.DGV_factura(DGV_TodasLasFacturas, s1, 1)
            '        Label10.Text = DGV_TodasLasFacturas.RowCount
            '    End If
            'End If

            CrearWhere()

        Catch ex As Exception



        End Try

        Me.tb_ObsPedido.Clear()
        Me.tb_observacion.Clear()
        Me.DateTimePicker1.Value = Today
        tb_direccion.Clear()
        Me.tb_controlInicio.Text = ""
        Me.tb_dias.ResetText()
        Me.tb_pedido.Text = ""
        Me.tb_codigo.Text = ""
        Me.l_facturador.Text = ""
        Me.lbl_cliente.Text = ""
        tb_imp.Clear()
        Me.tb_bultos.Clear()
        Me.Label16.Text = "0,00"
        Me.Label17.Text = "0,00"
        Me.Label19.Text = "0,00"
        Me.Label20.Text = "0,00"
        Me.Label23.Text = "0,00"
        Me.Label27.Text = "0,00"
        Me.DGV_facturas.Rows.Clear()

    End Sub
    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub
    Public Sub abreM(ByVal cod As Integer, ByVal ind As Integer)
        Try

            swC = True
            indice = ind
            Dim sw2 As Boolean = False
            Dim cont As Integer = 0
            While (cont <= Me.DGV_TodasLasFacturas.RowCount) And (sw2 = False)
                If CInt(Me.DGV_TodasLasFacturas.Rows(cont).Cells(0).Value) = cod Then
                    sw2 = True
                Else
                    cont = cont + 1
                End If
            End While
            Me.DGV_TodasLasFacturas.Rows(cont).Selected = True
            Dim cod2 As Integer = 0
            'Dim cliente As String
            cod2 = CInt(Me.DGV_TodasLasFacturas.Rows(cont).Cells(0).Value)
            'DatosFacturas.consulta_factura(cod2, Me.tb_codigo.Text, Me.DateTimePicker1.Text, Me.tb_facturador.Text, Me.tb_pedido.Text, Me.tb_bultos.Text, Me.tb_transporte, Me.Label16.Text, Me.Label17.Text, Me.Label18.Text, Me.Label19.Text, Me.Label20.Text, Me.tb_cliente.Text, Me.tb_controlInicio.Text, Me.tb_observacion.Text)

            AddData(cod2)
            Me.Label16.Text = CStr(calculasubtotal(Me.DGV_facturas))
            ' DatosNotaCredito.consulta_nc2(CInt(Me.tb_codigo.Text), Me.Label18.Text)
            ' Me.Label17.Text = CStr((CDbl(Me.Label16.Text) - CDbl(Me.Label18.Text)) * 0.15)
            ' Me.Label19.Text = CStr(CDbl(Me.Label16.Text) + CDbl(Me.Label17.Text) - CDbl(Me.Label18.Text) 

        Catch ex As Exception

        End Try


    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label24.Text = "      Ingrese sólo números"
        End If
    End Sub

    Private Sub tb_bultos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_bultos.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label24.Text = "      Ingrese sólo números"
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label24.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label24.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label24.Visible = False
        End If
    End Sub
    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_bultos.LostFocus
        muestra_label(sender, 1)
    End Sub
    Public Sub cualVentana(ByVal ven As Integer, ByVal codF As Integer, ByVal control As Integer, ByVal codC As Integer, ByVal raz As String)
        ventana = ven
        v1 = codF
        v2 = control
        v3 = codC
        v4 = raz
    End Sub

    Public Sub CeroEnMontos() Handles Label16.TextChanged, Label17.TextChanged, Label19.TextChanged, Label20.TextChanged, Label27.TextChanged

        If Label16.Text = ",00" Then
            Label16.Text = "0,00"
        End If
        If Label17.Text = ",00" Then
            Label17.Text = "0,00"
        End If

        If Label19.Text = ",00" Then
            Label19.Text = "0,00"
        End If
        If Label20.Text = "0" Then
            Label20.Text = "0,00"
        End If
        If Label27.Text = ",00" Then
            Label27.Text = "0,00"
        End If


    End Sub


    Public Sub DGV_TodasLasFacturas_CellClick() Handles DGV_TodasLasFacturas.CellClick, DGV_TodasLasFacturas.KeyDown, DGV_TodasLasFacturas.KeyUp
        Try

            If Not (DGV_TodasLasFacturas.SelectedRows.Count = 0) Then
                Dim cod As Integer = 0
                Dim iva As Double
                Dim stotal As Double
                cod = CInt(Me.DGV_TodasLasFacturas.SelectedRows(0).Cells(0).Value)
                DatosFacturas.consulta_factura(cod, Me.tb_codigo.Text, Me.DateTimePicker1.Text, Me.l_facturador.Text, Me.tb_pedido.Text, Me.tb_bultos.Text, iva, Me.Label20.Text, Me.Label19.Text, Me.tb_controlInicio.Text, Me.tb_observacion.Text, Me.tb_dias.Text, Cb_enviado.Checked, Me.cb_fev.Checked, Me.tb_ObsPedido.Text, tb_imp.Text, tb_direccion.Text)
                Me.lb_iva.Text = Format(iva, "#,##0.00") + "%:"
                AddData(cod)
                DatosFacturas.Saldo_factura(CInt(Me.DGV_TodasLasFacturas.SelectedRows(0).Cells(0).Value), Label20.Text)
                DatosNotaCredito.OtrasNotas(Label23.Text, CInt(tb_controlInicio.Text), -1, 1)
                Me.Label16.Text = CStr(calculasubtotal(Me.DGV_facturas))
                Me.Label16.Text = Format(CDbl(Me.Label16.Text), "#,##0.00")
                stotal = (CDbl(Me.Label16.Text)) * (iva / 100)
                Me.Label17.Text = stotal
                Me.Label17.Text = Format(CDbl(Me.Label17.Text), "#,##0.00")
                Me.Label19.Text = CStr(CDbl(Me.Label16.Text) + CDbl(Me.Label17.Text))
                Me.Label19.Text = Format(CDbl(Me.Label19.Text), "#,##0.00")
                Me.Label27.Text = CDbl(Me.Label19.Text) - (CDbl(Me.Label20.Text) + CDbl(Label23.Text)) + DatosAjusteSaldo.AjustesFactura(CInt(tb_controlInicio.Text))
                Me.Label27.Text = Format(CDbl(Me.Label27.Text), "#,##0.00")
                DatosPedidoCliente.consulta_pedido_vendedor(CInt(Me.tb_pedido.Text), Me.tb_vendedor)
                DGV_facturas.ClearSelection()
                CorregirCeros(DGV_facturas, 5)
                If Not Label23.Text = "0,00" Then
                    Label23.Text = Format(CDbl(Label23.Text), "#,##0.00")
                End If

            End If

        Catch ex As Exception



        Finally

            If DGV_TodasLasFacturas.SelectedRows.Count > 0 Then
                CodCliente = DGV_TodasLasFacturas.SelectedRows(0).Cells(2).Value.ToString
                lbl_cliente.Text = DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value.ToString
            End If

        End Try


    End Sub

    Public Sub CorregirCeros(ByVal DGV As DataGridView, ByVal col As Integer)

        Dim cont As Integer = 0

        For cont = 0 To DGV.RowCount - 1

            If DGV.Rows(cont).Cells(col).Value = 0 Then

                DGV.Rows(cont).Cells(col).Value = ""

            End If

        Next

    End Sub

    Private Sub CeroEnMontos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.TextChanged, Label17.TextChanged, Label19.TextChanged, Label20.TextChanged, Label27.TextChanged

    End Sub

    Private Sub tb_bultos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_bultos.TextChanged
        If Not tb_bultos.Text = "" Then
            If CInt(tb_bultos.Text) = 1 Then
                tb_observacion.Text = "La factura consta de 1 bulto"
            ElseIf CInt(tb_bultos.Text) > 1 Then
                tb_observacion.Text = "La factura consta de " & tb_bultos.Text & " bultos"
            End If
        Else
            tb_observacion.Text = ""
        End If
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DGV_TodasLasFacturas.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                DGV_TodasLasFacturas.Focus()

            End If
        End If

    End Sub

    Public Sub recibe(ByVal c As String)

        lbl_cliente.Text = c

    End Sub


    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DomainUpDown1.SelectedIndex = 0 Then

            where = where + y + "Control LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 1 Then

            where = where + y + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        End If


        Me.SpConsultaClienteFacturaBindingSource.Filter = where
        Label10.Text = DGV_TodasLasFacturas.RowCount
        DGV_TodasLasFacturas.ClearSelection()

    End Sub

    Private Sub tb_imp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_imp.GotFocus
        If tb_imp.ReadOnly = False And antes1 = "" Then
            antes1 = tb_imp.Text
        End If
    End Sub

    Private Sub tb_c_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_controlInicio.GotFocus
        If tb_controlInicio.ReadOnly = False And antes2 = "" Then
            antes2 = tb_controlInicio.Text
        End If
    End Sub

    Private Sub tb_imp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_imp.TextChanged
        If tb_imp.ReadOnly = False Then
            cambio = True
        Else
            cambio = False
        End If
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.DoubleClick

        Dim FRM As New Frm_NotaCredito
        FRM.Show()
        FRM.dud_buscar.SelectedIndex = 1
        FRM.tb_buscarcodigo.Text = tb_controlInicio.Text
        FRM.BringToFront()
        If FRM.Dgv_NotasC.RowCount > 0 Then
            FRM.Dgv_NotasC.Rows(0).Cells(1).Selected = True
            FRM.Dgv_NotasC_CellClick(FRM.Dgv_NotasC, New EventArgs)
        End If
        FRM.tb_buscarcodigo.Enabled = False
        FRM.TopMost = True

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.DoubleClick

        Dim FRM As New Frm_Recibos
        FRM.Show()
        FRM.DomainUpDown1.SelectedIndex = 2
        FRM.tb_buscarcodigo.Text = tb_controlInicio.Text
        FRM.BringToFront()
        FRM.tb_buscarcodigo.Enabled = False
        FRM.TopMost = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_express.Click

        Dim deny As Boolean = False
        Dim esta As Boolean = False
        Dim entrega As Boolean = False

        If cb_fev.Checked = True Then
            entrega = True
        Else
            entrega = False
        End If

        If llenos() Then
            MsgBox("Debe ingresar todos los datos requeridos (*)")
            deny = True
        Else

            If My.Settings.Nro_Imp_Visible Then
                DatosFacturas.consulta_numero_control(CInt(Me.tb_imp.Text), esta)
            Else
                If My.Settings.Nro_Control_Editable Then
                    DatosFacturas.consulta_numero_control(CInt(Me.tb_controlInicio.Text), esta)
                End If
            End If

            If esta = False Then

                If CInt(tb_bultos.Text) > 0 Then

                    Dim iva As Double

                    DatosFacturas.consulta_iva(iva)
                    DatosFacturas.inserta_Factura(Me.DateTimePicker1.Value, CInt(Me.tb_controlInicio.Text), Me.l_facturador.Text, Me.tb_bultos.Text, CInt(Me.tb_pedido.Text), CDbl(Me.Label20.Text), CDbl(Me.Label16.Text), Me.tb_observacion.Text, iva, CInt(tb_dias.Text), entrega, CInt(tb_imp.Text))
                    DatosFacturas.Elimina_Ubicaciones_Cero(CInt(tb_pedido.Text))

                    Datos.Inserta_Actividad("Creó la factura nro. " + Me.tb_controlInicio.Text + " del cliente (" + CodCliente + ") " + lbl_cliente.Text)

                    Dim ctrl As Integer = 0
                    Dim controlAnt As Integer = DatosFacturas.consultaUltimaFac(CInt(Me.tb_controlInicio.Text), 0, ctrl)
                    If DatosFacturas.FechaValida(DateTimePicker1.Value, controlAnt) Then

                        Dim r_factura As New R_Factura
                        r_factura.valores_Factura((controlAnt + 1).ToString, Me.CodCliente, My.Settings.CodigoFabricaFact)

                        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

                        Dim s As LocalReport = New LocalReport

                        If My.Settings.Empresa = 1 Then
                            s.ReportEmbeddedResource = "Tesis_Nueva.Factura-BRWME.rdlc"
                        ElseIf My.Settings.Empresa = 4 Then
                            s.ReportEmbeddedResource = "Tesis_Nueva.Factura-DIST-BRWME.rdlc"
                        Else
                            s.ReportEmbeddedResource = "Tesis_Nueva.Factura.rdlc"
                            Dim misParams(0) As Microsoft.Reporting.WinForms.ReportParameter
                            misParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("CodigoF", My.Settings.CodigoFabricaFact)
                            s.SetParameters(misParams)
                        End If

                        r_factura.Sp_consulta_Productos_FacturaTableAdapter.Fill(r_factura.MELDataSet.sp_consulta_Productos_Factura, (controlAnt + 1).ToString)
                        r_factura.Sp_consultaClienteTableAdapter.Fill(r_factura.MELDataSet.sp_consultaCliente, Me.CodCliente)
                        r_factura.Sp_consultaFacturaTableAdapter.Fill(r_factura.MELDataSet.sp_consultaFactura, (controlAnt + 1).ToString)
                        r_factura.Sp_consultaIVATableAdapter.Fill(r_factura.MELDataSet.sp_consultaIVA)
                        r_factura.Sp_consultaObsTableAdapter.Fill(r_factura.MELDataSet.sp_consultaObs)

                        ReportDataSource1.Name = "MELDataSet_sp_consulta_Productos_Factura"
                        ReportDataSource1.Value = r_factura.Sp_consulta_Productos_FacturaBindingSource
                        ReportDataSource2.Name = "MELDataSet_sp_consultaCliente"
                        ReportDataSource2.Value = r_factura.Sp_consultaClienteBindingSource
                        ReportDataSource3.Name = "MELDataSet_sp_consultaFactura"
                        ReportDataSource3.Value = r_factura.Sp_consultaFacturaBindingSource
                        ReportDataSource4.Name = "MELDataSet_sp_consultaIVA"
                        ReportDataSource4.Value = r_factura.Sp_consultaIVABindingSource
                        ReportDataSource5.Name = "MELDataSet_sp_consultaObs"
                        ReportDataSource5.Value = r_factura.Sp_consultaObsBindingSource

                        s.DataSources.Add(ReportDataSource1)
                        s.DataSources.Add(ReportDataSource2)
                        s.DataSources.Add(ReportDataSource3)
                        s.DataSources.Add(ReportDataSource4)
                        s.DataSources.Add(ReportDataSource5)

                        Export(s)
                        PrintReport(My.Settings.FactPrinter)

                        r_factura.Close()

                    Else
                        deny = True
                        MsgBox("La fecha de la factura no puede ser menor a la de la factura anterior, modifique la factura")
                    End If
                Else

                    MsgBox("La factura debe contener al menos un bulto", MsgBoxStyle.Exclamation, "SINPRO")
                    deny = True

                End If

            Else
                MsgBox("El número de control ya se encuentra registrado", MsgBoxStyle.Exclamation, "Advertencia")
                deny = True
                tb_imp.Focus()
                tb_imp.SelectAll()
            End If

            If deny = False Then

                Me.tb_bultos.ReadOnly = True
                Me.tb_bultos.Clear()
                Me.tb_controlInicio.Text = ""
                Me.DateTimePicker1.Enabled = False
                Me.bt_aceptar.Visible = False
                Me.bt_cancelar.Visible = False
                Me.DGV_TodasLasFacturas.Enabled = True
                Me.tb_dias.ResetText()
                Me.tb_dias.Enabled = False
                antes1 = ""
                antes2 = ""
                Me.tb_observacion.Clear()
                Me.tb_observacion.ReadOnly = True
                Me.tb_ObsPedido.Clear()
                tb_controlInicio.ReadOnly = True
                Cb_enviado.Enabled = False
                Me.DateTimePicker1.Value = Today()
                Me.ToolBar1.Enabled = True
                Me.DomainUpDown1.Enabled = True
                Me.tb_vendedor.Enabled = False
                Me.tb_vendedor.ResetText()
                Datos.consulta_vendedores(Me.tb_vendedor)
                Me.tb_codigo.Text = ""
                Me.l_facturador.Text = ""
                Me.tb_pedido.Text = ""
                cb_fev.Enabled = False
                boton = ""
                lbl_cliente.Text = ""
                Me.tb_buscarcodigo.Enabled = True
                tb_controlInicio.ReadOnly = False
                tb_imp.Clear()
                tb_imp.ReadOnly = True
                Me.tb_buscarcodigo.Text = ""
                'DatosFacturas.consulta_facturas(Me.DGV_TodasLasFacturas)
                Sp_ConsultaClienteFacturaTableAdapter.Fill(Me.MELDataSet.sp_ConsultaClienteFactura, 0)
                SpConsultaClienteFacturaBindingSource.RemoveFilter()
                DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                DGV_TodasLasFacturas_CellClick()
                Label10.Text = Me.DGV_TodasLasFacturas.RowCount
                ToolBar1_ButtonClick(ToolBar1, New ToolBarButtonClickEventArgs(bt_salir))
            End If

        End If

    End Sub
End Class
