Public Class Frm_Pedidos_Proveedores
    Inherits System.Windows.Forms.Form
    Private Tabla As New DataTable("tablita")
    Private TablaProductos As New DataTable("TablaProductos")
    Dim empezo As Boolean = False
    Dim ya As Boolean = False
    Dim frm As New Frm_AgregarAPedido
    Dim anterior As String = ""
    Dim anterior2 As Integer = 0
    Dim bo As Boolean = False
    Dim sel As Boolean = False
    Dim f17 As Frm_Compras
    Private sw0 As Boolean = False
    Private sw As Boolean = False
    Private sw1 As Boolean = False
    Private l As New Collection
    Private lelim As New Collection
    Private lproductos As New Collection
    Private item As Object
    Private cuantos As Integer
    Private fila As Integer
    Private boton As String = ""
    Private choice As Integer
    Private swC As Boolean = False
    Private Dv As DataView
    Private indice As Integer = 0
    Private swX As Boolean = False
    Private b As Boolean = False
    Private codProveedor As Integer
    Private nomProveedor As String
    Dim hay As Boolean = False
    Dim nacionales As New Collection
    Dim nacionales1 As New Collection
    Dim nacionales2 As New Collection
    ' -- Variables para Excel   
    Dim Obj_Excel As Object
    Dim Obj_Libro As Object
    Dim Obj_Hoja As Object
    ' --------------------------
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_otros As System.Windows.Forms.TextBox
    Friend WithEvents tb_proforma As System.Windows.Forms.TextBox
    Friend WithEvents tb_aranceles As System.Windows.Forms.TextBox
    Friend WithEvents tb_seguro As System.Windows.Forms.TextBox
    Friend WithEvents tb_flete As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Private swa As Boolean = False
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents tb_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DGV As New MyDataGridView3
    Dim texto As String = ""
    Dim enter1 As Boolean = False
    Dim down As Boolean = False
    Dim up As Boolean = False
    Dim entro As Boolean = False
    Dim w As Boolean
    Dim e As Boolean
    Friend WithEvents bt_status As System.Windows.Forms.ToolBarButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Dim selected As Boolean = False
    Public cant As Integer = 0
    Public status As Char = "S"
    Public costo As Double = 0
    Friend WithEvents lbl_CodP As System.Windows.Forms.Label
    Public fecha As Date
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lb_totalP As System.Windows.Forms.Label
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_Calcular As System.Windows.Forms.ToolBarButton
    Friend WithEvents chb_pedidocargado As System.Windows.Forms.CheckBox
    Friend WithEvents bt_reporte As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SpconsultaProductosParaPedidoCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosParaPedidoCompraTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosParaPedidoCompraTableAdapter
    Friend WithEvents lb_proveedor As System.Windows.Forms.ListBox
    Friend WithEvents cb_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents TblFabricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FabricaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
    Friend WithEvents lbl_totalN As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalO As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chk_status As System.Windows.Forms.CheckBox
    Friend WithEvents cb_filtroStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_euros As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lbl_dolares As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UnificarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Public opcion As Boolean


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
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents bt_cargar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pedidos_Proveedores))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_cargar = New System.Windows.Forms.ToolBarButton
        Me.bt_status = New System.Windows.Forms.ToolBarButton
        Me.bt_Calcular = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tb_flete = New System.Windows.Forms.TextBox
        Me.tb_seguro = New System.Windows.Forms.TextBox
        Me.tb_aranceles = New System.Windows.Forms.TextBox
        Me.tb_proforma = New System.Windows.Forms.TextBox
        Me.tb_otros = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_proveedor = New System.Windows.Forms.TextBox
        Me.lb_proveedor = New System.Windows.Forms.ListBox
        Me.TblFabricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.chb_pedidocargado = New System.Windows.Forms.CheckBox
        Me.lbl_CodP = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.tb_obs = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DGV_Pedidos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodProv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UnificarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cb_status = New System.Windows.Forms.ComboBox
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.Cant2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoProductoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaProductosParaPedidoCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.lb_totalP = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaProductosParaPedidoCompraTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosParaPedidoCompraTableAdapter
        Me.Tbl_FabricaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
        Me.lbl_totalN = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lbl_TotalO = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.chk_status = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cb_filtroStatus = New System.Windows.Forms.ComboBox
        Me.lbl_euros = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lbl_dolares = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductosParaPedidoCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 4
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 675)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_cargar, Me.bt_status, Me.bt_Calcular, Me.ToolBarButton1, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(50, 35)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(3, 10)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(410, 69)
        Me.ToolBar1.TabIndex = 86
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'bt_cargar
        '
        Me.bt_cargar.ImageIndex = 3
        Me.bt_cargar.Name = "bt_cargar"
        Me.bt_cargar.Text = "Cargar"
        '
        'bt_status
        '
        Me.bt_status.ImageIndex = 5
        Me.bt_status.Name = "bt_status"
        Me.bt_status.Text = "Status"
        '
        'bt_Calcular
        '
        Me.bt_Calcular.ImageKey = "iconCalculator_3.jpg"
        Me.bt_Calcular.Name = "bt_Calcular"
        Me.bt_Calcular.Text = "Calcular"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 8
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Reporte"
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
        Me.ImageList2.Images.SetKeyName(5, "status.jpg")
        Me.ImageList2.Images.SetKeyName(6, "iconCalculator_3.jpg")
        Me.ImageList2.Images.SetKeyName(7, "excel.png")
        Me.ImageList2.Images.SetKeyName(8, "files funny (11).png")
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(315, 675)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(413, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(605, 23)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Datos del Pedido"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(732, 689)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 14
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(640, 689)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 13
        Me.bt_aceptar.Text = "Aceptar"
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(203, 77)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(198, 25)
        Me.tb_buscarcodigo.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Código Pedido:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 23)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Otros Gastos (%):"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(370, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "(*)Fecha:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "(*)Moneda:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(479, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 22)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.Value = New Date(2009, 11, 10, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 23)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "(*)Proveedor:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(370, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Flete:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(328, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Seguro:"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(370, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Aranceles:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Cód. Fact. P:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 23)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Fecha Fact. P:"
        '
        'tb_flete
        '
        Me.tb_flete.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_flete.Location = New System.Drawing.Point(479, 35)
        Me.tb_flete.MaxLength = 18
        Me.tb_flete.Name = "tb_flete"
        Me.tb_flete.ReadOnly = True
        Me.tb_flete.Size = New System.Drawing.Size(116, 22)
        Me.tb_flete.TabIndex = 4
        '
        'tb_seguro
        '
        Me.tb_seguro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_seguro.Location = New System.Drawing.Point(437, 203)
        Me.tb_seguro.MaxLength = 18
        Me.tb_seguro.Name = "tb_seguro"
        Me.tb_seguro.Size = New System.Drawing.Size(116, 22)
        Me.tb_seguro.TabIndex = 5
        Me.tb_seguro.Visible = False
        '
        'tb_aranceles
        '
        Me.tb_aranceles.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_aranceles.Location = New System.Drawing.Point(479, 59)
        Me.tb_aranceles.MaxLength = 18
        Me.tb_aranceles.Name = "tb_aranceles"
        Me.tb_aranceles.ReadOnly = True
        Me.tb_aranceles.Size = New System.Drawing.Size(116, 22)
        Me.tb_aranceles.TabIndex = 6
        '
        'tb_proforma
        '
        Me.tb_proforma.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_proforma.Location = New System.Drawing.Point(108, 117)
        Me.tb_proforma.MaxLength = 4
        Me.tb_proforma.Name = "tb_proforma"
        Me.tb_proforma.Size = New System.Drawing.Size(97, 22)
        Me.tb_proforma.TabIndex = 10
        '
        'tb_otros
        '
        Me.tb_otros.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_otros.Location = New System.Drawing.Point(479, 83)
        Me.tb_otros.MaxLength = 18
        Me.tb_otros.Name = "tb_otros"
        Me.tb_otros.ReadOnly = True
        Me.tb_otros.Size = New System.Drawing.Size(116, 22)
        Me.tb_otros.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(109, 142)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(97, 22)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(160, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 20)
        Me.Label22.TabIndex = 75
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(160, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 20)
        Me.Label17.TabIndex = 76
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 220)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(148, 16)
        Me.Label24.TabIndex = 80
        Me.Label24.Text = "(*) Datos Requeridos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cb_proveedor)
        Me.GroupBox2.Controls.Add(Me.lb_proveedor)
        Me.GroupBox2.Controls.Add(Me.chb_pedidocargado)
        Me.GroupBox2.Controls.Add(Me.lbl_CodP)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.tb_obs)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lbl_codigo)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.tb_otros)
        Me.GroupBox2.Controls.Add(Me.tb_aranceles)
        Me.GroupBox2.Controls.Add(Me.tb_seguro)
        Me.GroupBox2.Controls.Add(Me.tb_flete)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.tb_proforma)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 196)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        '
        'cb_proveedor
        '
        Me.cb_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_proveedor.Enabled = False
        Me.cb_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.ForeColor = System.Drawing.Color.Black
        Me.cb_proveedor.Location = New System.Drawing.Point(107, 34)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(213, 21)
        Me.cb_proveedor.TabIndex = 10061
        '
        'lb_proveedor
        '
        Me.lb_proveedor.DataSource = Me.TblFabricaBindingSource
        Me.lb_proveedor.DisplayMember = "Nombre"
        Me.lb_proveedor.FormattingEnabled = True
        Me.lb_proveedor.ItemHeight = 15
        Me.lb_proveedor.Location = New System.Drawing.Point(107, 55)
        Me.lb_proveedor.Name = "lb_proveedor"
        Me.lb_proveedor.Size = New System.Drawing.Size(213, 79)
        Me.lb_proveedor.TabIndex = 10062
        Me.lb_proveedor.ValueMember = "CodigoFabrica"
        Me.lb_proveedor.Visible = False
        '
        'TblFabricaBindingSource
        '
        Me.TblFabricaBindingSource.DataMember = "Tbl_Fabrica"
        Me.TblFabricaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chb_pedidocargado
        '
        Me.chb_pedidocargado.AutoSize = True
        Me.chb_pedidocargado.Enabled = False
        Me.chb_pedidocargado.Location = New System.Drawing.Point(9, 205)
        Me.chb_pedidocargado.Name = "chb_pedidocargado"
        Me.chb_pedidocargado.Size = New System.Drawing.Size(121, 19)
        Me.chb_pedidocargado.TabIndex = 90
        Me.chb_pedidocargado.Text = "Pedido Cargado"
        Me.chb_pedidocargado.UseVisualStyleBackColor = True
        Me.chb_pedidocargado.Visible = False
        '
        'lbl_CodP
        '
        Me.lbl_CodP.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodP.Location = New System.Drawing.Point(224, 118)
        Me.lbl_CodP.Name = "lbl_CodP"
        Me.lbl_CodP.Size = New System.Drawing.Size(49, 23)
        Me.lbl_CodP.TabIndex = 89
        Me.lbl_CodP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_CodP.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(364, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 46)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mostrar productos:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(145, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 19)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Todos"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 19)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Del proveedor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'tb_obs
        '
        Me.tb_obs.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obs.Location = New System.Drawing.Point(107, 60)
        Me.tb_obs.MaxLength = 250
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.Size = New System.Drawing.Size(213, 55)
        Me.tb_obs.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 23)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Observaciones:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(105, 11)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(49, 23)
        Me.lbl_codigo.TabIndex = 82
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(479, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(46, 23)
        Me.ComboBox1.TabIndex = 8
        '
        'DGV_Pedidos
        '
        Me.DGV_Pedidos.AllowUserToAddRows = False
        Me.DGV_Pedidos.AllowUserToDeleteRows = False
        Me.DGV_Pedidos.AllowUserToResizeColumns = False
        Me.DGV_Pedidos.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.DGV_Pedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Total2, Me.Mon, Me.CodProv})
        Me.DGV_Pedidos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV_Pedidos.EnableHeadersVisualStyles = False
        Me.DGV_Pedidos.Location = New System.Drawing.Point(10, 141)
        Me.DGV_Pedidos.MultiSelect = False
        Me.DGV_Pedidos.Name = "DGV_Pedidos"
        Me.DGV_Pedidos.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pedidos.Size = New System.Drawing.Size(396, 528)
        Me.DGV_Pedidos.TabIndex = 10001
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 64
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 5.0!)
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 129
        '
        'Total2
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Total2.HeaderText = "Total"
        Me.Total2.Name = "Total2"
        Me.Total2.ReadOnly = True
        '
        'Mon
        '
        Me.Mon.HeaderText = "Moneda"
        Me.Mon.Name = "Mon"
        Me.Mon.Visible = False
        '
        'CodProv
        '
        Me.CodProv.HeaderText = "CodProv"
        Me.CodProv.Name = "CodProv"
        Me.CodProv.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnificarPedidosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 26)
        '
        'UnificarPedidosToolStripMenuItem
        '
        Me.UnificarPedidosToolStripMenuItem.Name = "UnificarPedidosToolStripMenuItem"
        Me.UnificarPedidosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UnificarPedidosToolStripMenuItem.Text = "Unificar pedidos ..."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(605, 23)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Productos Asociados al Pedido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(605, 26)
        Me.Label4.TabIndex = 10002
        Me.Label4.Text = "Productos del proveedor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cb_status)
        Me.GroupBox3.Controls.Add(Me.lb_total)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(413, 466)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 203)
        Me.GroupBox3.TabIndex = 10004
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Window
        Me.Label20.Location = New System.Drawing.Point(6, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 14)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "Filtrar por:"
        '
        'cb_status
        '
        Me.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_status.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Todos", "S", "R", "O", "N"})
        Me.cb_status.Location = New System.Drawing.Point(71, 0)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(57, 21)
        Me.cb_status.TabIndex = 104
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.SystemColors.Window
        Me.lb_total.Location = New System.Drawing.Point(564, 1)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(13, 14)
        Me.lb_total.TabIndex = 103
        Me.lb_total.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(475, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 14)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = "Total Artículos:"
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeColumns = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant2DataGridViewTextBoxColumn, Me.CodigoInternoDataGridViewTextBoxColumn, Me.CodigoFDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CodigoProductoFDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.Marca})
        Me.DGV_Productos.DataSource = Me.SpconsultaProductosParaPedidoCompraBindingSource
        Me.DGV_Productos.Location = New System.Drawing.Point(5, 27)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(595, 207)
        Me.DGV_Productos.TabIndex = 12
        Me.DGV_Productos.Visible = False
        '
        'Cant2DataGridViewTextBoxColumn
        '
        Me.Cant2DataGridViewTextBoxColumn.DataPropertyName = "Cant2"
        Me.Cant2DataGridViewTextBoxColumn.HeaderText = "Cant."
        Me.Cant2DataGridViewTextBoxColumn.Name = "Cant2DataGridViewTextBoxColumn"
        Me.Cant2DataGridViewTextBoxColumn.Width = 50
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 110
        '
        'CodigoFDataGridViewTextBoxColumn
        '
        Me.CodigoFDataGridViewTextBoxColumn.DataPropertyName = "CodigoF"
        Me.CodigoFDataGridViewTextBoxColumn.HeaderText = "Código F."
        Me.CodigoFDataGridViewTextBoxColumn.Name = "CodigoFDataGridViewTextBoxColumn"
        Me.CodigoFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFDataGridViewTextBoxColumn.Width = 110
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 185
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 120
        '
        'CodigoProductoFDataGridViewTextBoxColumn
        '
        Me.CodigoProductoFDataGridViewTextBoxColumn.DataPropertyName = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.HeaderText = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.Name = "CodigoProductoFDataGridViewTextBoxColumn"
        Me.CodigoProductoFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoProductoFDataGridViewTextBoxColumn.Visible = False
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Visible = False
        '
        'SpconsultaProductosParaPedidoCompraBindingSource
        '
        Me.SpconsultaProductosParaPedidoCompraBindingSource.DataMember = "sp_consultaProductosParaPedidoCompra"
        Me.SpconsultaProductosParaPedidoCompraBindingSource.DataSource = Me.MELDataSet
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.DGV_Productos)
        Me.groupbox1.Controls.Add(Me.Label4)
        Me.groupbox1.Location = New System.Drawing.Point(413, 220)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(605, 240)
        Me.groupbox1.TabIndex = 10003
        Me.groupbox1.TabStop = False
        Me.groupbox1.Visible = False
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(10, 76)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(187, 26)
        Me.DomainUpDown1.TabIndex = 10005
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(819, 669)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 23)
        Me.Label19.TabIndex = 10006
        Me.Label19.Text = "Sub-Total:"
        '
        'lb_totalP
        '
        Me.lb_totalP.AutoSize = True
        Me.lb_totalP.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_totalP.Location = New System.Drawing.Point(886, 668)
        Me.lb_totalP.Name = "lb_totalP"
        Me.lb_totalP.Size = New System.Drawing.Size(44, 19)
        Me.lb_totalP.TabIndex = 10007
        Me.lb_totalP.Text = "0,00"
        Me.lb_totalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageKey = "excel.png"
        Me.Button1.ImageList = Me.ImageList2
        Me.Button1.Location = New System.Drawing.Point(418, 673)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 10008
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(471, 695)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(147, 25)
        Me.ProgressBar1.TabIndex = 10009
        Me.ProgressBar1.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(556, 675)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 15)
        Me.Label21.TabIndex = 10010
        Me.Label21.Text = "0,00%"
        Me.Label21.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(477, 675)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 15)
        Me.Label23.TabIndex = 10011
        Me.Label23.Text = "Exportando:"
        Me.Label23.Visible = False
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'Sp_consultaProductosParaPedidoCompraTableAdapter
        '
        Me.Sp_consultaProductosParaPedidoCompraTableAdapter.ClearBeforeFill = True
        '
        'Tbl_FabricaTableAdapter
        '
        Me.Tbl_FabricaTableAdapter.ClearBeforeFill = True
        '
        'lbl_totalN
        '
        Me.lbl_totalN.AutoSize = True
        Me.lbl_totalN.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_totalN.Location = New System.Drawing.Point(886, 686)
        Me.lbl_totalN.Name = "lbl_totalN"
        Me.lbl_totalN.Size = New System.Drawing.Size(44, 19)
        Me.lbl_totalN.TabIndex = 10013
        Me.lbl_totalN.Text = "0,00"
        Me.lbl_totalN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(819, 687)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 23)
        Me.Label26.TabIndex = 10012
        Me.Label26.Text = "(N):"
        '
        'lbl_TotalO
        '
        Me.lbl_TotalO.AutoSize = True
        Me.lbl_TotalO.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_TotalO.Location = New System.Drawing.Point(886, 704)
        Me.lbl_TotalO.Name = "lbl_TotalO"
        Me.lbl_TotalO.Size = New System.Drawing.Size(44, 19)
        Me.lbl_TotalO.TabIndex = 10015
        Me.lbl_TotalO.Text = "0,00"
        Me.lbl_TotalO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(819, 705)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 23)
        Me.Label27.TabIndex = 10014
        Me.Label27.Text = "(O):"
        '
        'chk_status
        '
        Me.chk_status.AutoSize = True
        Me.chk_status.Location = New System.Drawing.Point(3, 5)
        Me.chk_status.Name = "chk_status"
        Me.chk_status.Size = New System.Drawing.Size(124, 19)
        Me.chk_status.TabIndex = 10016
        Me.chk_status.Text = "Filtrar por Status:"
        Me.chk_status.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cb_filtroStatus)
        Me.Panel1.Controls.Add(Me.chk_status)
        Me.Panel1.Location = New System.Drawing.Point(10, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 29)
        Me.Panel1.TabIndex = 10017
        '
        'cb_filtroStatus
        '
        Me.cb_filtroStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_filtroStatus.Enabled = False
        Me.cb_filtroStatus.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.cb_filtroStatus.FormattingEnabled = True
        Me.cb_filtroStatus.Items.AddRange(New Object() {"S", "R", "O", "N"})
        Me.cb_filtroStatus.Location = New System.Drawing.Point(129, 3)
        Me.cb_filtroStatus.Name = "cb_filtroStatus"
        Me.cb_filtroStatus.Size = New System.Drawing.Size(57, 21)
        Me.cb_filtroStatus.TabIndex = 106
        '
        'lbl_euros
        '
        Me.lbl_euros.AutoSize = True
        Me.lbl_euros.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_euros.Location = New System.Drawing.Point(108, 695)
        Me.lbl_euros.Name = "lbl_euros"
        Me.lbl_euros.Size = New System.Drawing.Size(44, 19)
        Me.lbl_euros.TabIndex = 10021
        Me.lbl_euros.Text = "0,00"
        Me.lbl_euros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 695)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 23)
        Me.Label28.TabIndex = 10020
        Me.Label28.Text = "Sub-Total (€):"
        '
        'lbl_dolares
        '
        Me.lbl_dolares.AutoSize = True
        Me.lbl_dolares.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_dolares.Location = New System.Drawing.Point(108, 675)
        Me.lbl_dolares.Name = "lbl_dolares"
        Me.lbl_dolares.Size = New System.Drawing.Size(44, 19)
        Me.lbl_dolares.TabIndex = 10019
        Me.lbl_dolares.Text = "0,00"
        Me.lbl_dolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 675)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 23)
        Me.Label30.TabIndex = 10018
        Me.Label30.Text = "Sub-Total ($):"
        '
        'Frm_Pedidos_Proveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1020, 723)
        Me.Controls.Add(Me.lbl_euros)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbl_dolares)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_Pedidos)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbl_TotalO)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lbl_totalN)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lb_totalP)
        Me.Controls.Add(Me.Label19)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 150)
        Me.MaximizeBox = False
        Me.Name = "Frm_Pedidos_Proveedores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Pedidos Proveedores"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductosParaPedidoCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            ToolBar1.Enabled = True
            DGV_Productos.Visible = False
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            tb_aranceles.ReadOnly = True
            tb_proforma.ReadOnly = True
            tb_aranceles.Clear()
            tb_proforma.Clear()
            tb_flete.Clear()
            tb_obs.Clear()
            tb_otros.Clear()
            tb_seguro.Clear()
            Me.tb_obs.ReadOnly = True
            tb_flete.ReadOnly = True
            tb_otros.ReadOnly = True
            cb_proveedor.Enabled = False
            lb_proveedor.Visible = False
            tb_seguro.ReadOnly = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            ComboBox1.Enabled = False
            DGV_Productos.Visible = False
            DGV.Columns(0).ReadOnly = True
            DGV.Columns(5).ReadOnly = True
            DGV.Columns(6).ReadOnly = True
            DGV.Rows.Clear()
            DGV.ReadOnly = True
            DGV.AllowUserToDeleteRows = False
            ComboBox1.ResetText()
            GroupBox4.Enabled = False
            lbl_codigo.Text = ""
            Me.Close()

        ElseIf e.Button Is Me.bt_cargar Then


            Dim n As Integer = DGV_Pedidos.SelectedRows.Count
            If n > 0 Then
                If chb_pedidocargado.Checked = False Then

                    nacionales.Clear()
                    nacionales1.Clear()
                    nacionales2.Clear()

                    For cont As Integer = 0 To DGV.RowCount - 1
                        If DGV.Rows(cont).Cells(0).Value.ToString.ToUpper = "N" Then
                            hay = True
                            nacionales.Add(DGV.Rows(cont).Cells(2).Value, cont)
                            'nacionales1.Add(DGV.Rows(cont).Cells(1).Value, cont)
                            nacionales2.Add(DGV.Rows(cont).Cells(6).Value, cont)
                        End If
                    Next
                    If hay = True Then
                        Dim frm As New Frm_Cargar_Compras
                        frm.frm = Me
                        frm.Pedido(lbl_codigo.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(5).Value, nacionales, nacionales2, DGV_Pedidos)
                        frm.Show()
                    Else
                        MsgBox("Debe haber productos con status N para poder cargar el pedido", MsgBoxStyle.OkOnly, "Mensaje de Error")

                    End If
                Else
                    MsgBox("Este pedido ya se encuentra registrado", MsgBoxStyle.OkOnly, "Mensaje de Error")
                End If

            Else
                MsgBox("Debe seleccionar el pedido que desea cargar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If

        ElseIf e.Button Is Me.bt_nuevo Then

            boton = "n"
            DGV.Size = New Size(593, 176)
            GroupBox3.Size = New Size(605, 203)
            GroupBox3.Location = New System.Drawing.Point(413, 466)
            DGV.Location = New System.Drawing.Point(5, 27)
            GroupBox3.BringToFront()
            groupbox1.Visible = True
            ToolBar1.Enabled = False
            DGV_Pedidos.ClearSelection()
            DGV_Pedidos.Enabled = False
            bt_aceptar.Visible = True
            tb_aranceles.Text = "0,00"
            tb_flete.Text = "0,00"
            tb_otros.Text = "0,00"
            tb_seguro.Text = "0,00"
            lb_totalP.Text = "0,00"
            bt_cancelar.Visible = True
            tb_aranceles.ReadOnly = False
            tb_proforma.ReadOnly = False
            tb_flete.ReadOnly = False
            tb_otros.ReadOnly = False
            cb_proveedor.Enabled = True
            lb_proveedor.Visible = True
            tb_seguro.ReadOnly = False
            tb_obs.ReadOnly = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            ComboBox1.Enabled = True
            ComboBox1.Text = ""
            DGV_Productos.Visible = True
            DGV.Enabled = True
            DGV.ReadOnly = False
            DGV.Columns(0).ReadOnly = False
            DGV.Columns(5).ReadOnly = False
            DGV.Columns(2).ReadOnly = True
            DGV.Columns(3).ReadOnly = True
            DGV.Columns(4).ReadOnly = True
            DGV.Columns(1).ReadOnly = True
            DGV.Columns(6).ReadOnly = False
            DGV.Columns(7).ReadOnly = True
            DGV.Columns(8).ReadOnly = True
            DGV.Columns(9).ReadOnly = True
            DGV.AllowUserToDeleteRows = True
            GroupBox4.Enabled = True
            'DatosPedidosCompras.consulta_Proveedor(Me.tb_proveedor)
            cb_proveedor.Text = ""
            lb_proveedor.Visible = False
            DatosPedidosCompras.identidad_PedidoCompra(lbl_codigo)
            DomainUpDown1.Items.Clear()
            DomainUpDown1.Items.Add("Codigo Interno")
            DomainUpDown1.Items.Add("Codigo Fábrica")
            DomainUpDown1.Items.Add("Descripción")
            DomainUpDown1.Items.Add("Modelo")
            DomainUpDown1.SelectedIndex = 0
            DomainUpDown1.Text = "Codigo Interno"
            choice = 0
            Label15.Visible = True
            tb_proforma.Visible = True
            DGV.Rows.Clear()
            tb_proforma.Clear()
            tb_obs.Clear()
            TblFabricaBindingSource.RemoveFilter()
            SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '-1))))'"
            cb_proveedor.Focus()
            lb_proveedor.Visible = True
            DGV.AllowUserToDeleteRows = True

        ElseIf e.Button Is Me.bt_modificar Then

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                boton = "m"
                DGV.Size = New Size(593, 176)
                GroupBox3.Size = New Size(605, 203)
                GroupBox3.Location = New System.Drawing.Point(413, 466)
                DGV.Location = New System.Drawing.Point(5, 27)
                GroupBox3.BringToFront()
                groupbox1.Visible = True
                ToolBar1.Enabled = False
                anterior = tb_buscarcodigo.Text
                anterior2 = DomainUpDown1.SelectedIndex
                DGV_Pedidos.Enabled = False
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                tb_aranceles.ReadOnly = False
                tb_proforma.ReadOnly = False
                tb_flete.ReadOnly = False
                tb_otros.ReadOnly = False
                tb_seguro.ReadOnly = False
                tb_obs.ReadOnly = False
                DateTimePicker1.Enabled = True
                DateTimePicker2.Enabled = True
                ComboBox1.Enabled = True
                DGV_Productos.Visible = True
                DGV.Enabled = True
                DGV.ReadOnly = False
                DGV.Columns(0).ReadOnly = False
                DGV.Columns(5).ReadOnly = False
                DGV.Columns(2).ReadOnly = True
                DGV.Columns(3).ReadOnly = True
                DGV.Columns(4).ReadOnly = True
                DGV.Columns(1).ReadOnly = True
                DGV.Columns(6).ReadOnly = False
                DGV.Columns(7).ReadOnly = True
                DGV.AllowUserToDeleteRows = True
                tb_proforma.Visible = True
                Label15.Visible = True
                If tb_proforma.Text <> "" Then
                    DateTimePicker2.Visible = True
                    Label16.Visible = True
                Else
                    DateTimePicker2.Visible = False
                    Label16.Visible = False
                End If
                Me.DomainUpDown1.Items.Clear()
                DomainUpDown1.Items.Add("Codigo Interno")
                DomainUpDown1.Items.Add("Codigo Fábrica")
                DomainUpDown1.Items.Add("Descripción")
                DomainUpDown1.Items.Add("Modelo")
                DomainUpDown1.SelectedIndex = 0
                choice = 0
                'DatosPedidosCompras.Llenar_DGV_Productos_Por_Proveedor(CInt(lbl_CodP.Text), DGV_Productos)

                TblFabricaBindingSource.Filter = "Nombre = '" & cb_proveedor.Text & "'"

                If lb_proveedor.Items.Count > 0 Then
                    lb_proveedor.SelectedIndex = 0
                End If

                lb_proveedor.Visible = True
                cb_proveedor_KeyDown(cb_proveedor, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
                CrearWhere()
                lb_proveedor.Visible = False

                GroupBox4.Enabled = True
                tb_obs.Focus()
                tb_obs.SelectAll()

            Else

                MsgBox("Debe seleccionar el pedido a modificar", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If

        ElseIf e.Button Is Me.bt_eliminar Then

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                If chk_status.Checked Then

                    If cb_filtroStatus.SelectedIndex <> -1 Then

                        Dim resp As Integer = MsgBox("¿Está seguro que desea eliminar todos los productos con status '" & cb_filtroStatus.Text.ToUpper & "' del pedido seleccionado?", MsgBoxStyle.YesNo, "Confirmación")

                        If resp = vbYes Then

                            anterior = tb_buscarcodigo.Text
                            anterior2 = DomainUpDown1.SelectedIndex
                            DatosPedidosCompras.elimina_pedidoCompra(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), 1, cb_filtroStatus.Text)

                            MsgBox("Pedido productos eliminados satisfactoriamente del pedido", MsgBoxStyle.Information, "Confirmación")

                            DomainUpDown1.SelectedIndex = anterior2
                            tb_buscarcodigo.Text = anterior

                            If cb_filtroStatus.Enabled Then
                                DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, "%" & tb_buscarcodigo.Text & "%", DomainUpDown1.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)
                            Else
                                DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, "%" & tb_buscarcodigo.Text & "%", DomainUpDown1.SelectedIndex, "", lbl_dolares.Text, lbl_euros.Text)
                            End If

                            If DGV_Pedidos.Rows.Count > 0 Then
                                DGV_Pedidos.Rows(0).Cells(0).Selected = True
                                DGV_Pedidos_CellClick(DGV_Pedidos, New EventArgs)
                            Else
                                DGV.Rows.Clear()
                                tb_aranceles.Clear()
                                cb_proveedor.Text = ""
                                lb_proveedor.Visible = False
                                tb_obs.Clear()
                                tb_proforma.Clear()
                                tb_flete.Clear()
                                tb_otros.Clear()
                                DateTimePicker1.Value = Today
                                DateTimePicker2.Value = Today
                            End If

                            DGV_Pedidos.ClearSelection()


                        End If

                    Else

                        MsgBox("Debe seleccionar un Status para eliminar", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                Else

                    Dim resp As Integer = MsgBox("¿Está seguro que desea eliminar el pedido Nro. " & DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString & "?", MsgBoxStyle.YesNo, "Confirmar eliminación")

                    If resp = vbYes Then

                        anterior = tb_buscarcodigo.Text
                        anterior2 = DomainUpDown1.SelectedIndex
                        DatosPedidosCompras.elimina_pedidoCompra(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), 0, "")

                        MsgBox("Pedido eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")

                        DomainUpDown1.SelectedIndex = anterior2
                        tb_buscarcodigo.Text = anterior

                        DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, anterior, 0, tb_buscarcodigo.Text, lbl_dolares.Text, lbl_euros.Text)

                        If DGV_Pedidos.Rows.Count > 0 Then
                            DGV_Pedidos.Rows(0).Cells(0).Selected = True
                            DGV_Pedidos_CellClick(DGV_Pedidos, New EventArgs)
                        Else
                            DGV.Rows.Clear()
                            tb_aranceles.Clear()
                            cb_proveedor.Text = ""
                            lb_proveedor.Visible = False
                            tb_obs.Clear()
                            tb_proforma.Clear()
                            tb_flete.Clear()
                            tb_otros.Clear()
                            DateTimePicker1.Value = Today
                            DateTimePicker2.Value = Today
                        End If

                        DGV_Pedidos.ClearSelection()

                    End If

                End If

            Else

                MsgBox("Debe seleccionar el pedido a eliminar", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If



        ElseIf e.Button Is Me.bt_status Then

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                Frm_Status.Recibe(DGV, CInt(lbl_codigo.Text))
                Frm_Status.Show()
                Frm_Status.cb_de.Focus()

            Else

                MsgBox("Debe seleccionar el pedido", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If

        ElseIf e.Button Is Me.bt_Calcular Then

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                Dim fr As New Frm_CalculoCostos

                fr.recibe(CInt(lbl_codigo.Text), ComboBox1.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString(), CInt(cb_proveedor.Tag))
                fr.Show()

            Else

                MsgBox("Debe seleccionar un pedido para calcular su costo", MsgBoxStyle.Critical, "Mensaje de error")

            End If
        ElseIf e.Button Is Me.ToolBarButton1 Then

            TablaProductos.Rows.Clear()
            TablaProductos.Columns.Clear()

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                TablaProductos.Columns.Add(New DataColumn("Codigo"))
                TablaProductos.Columns.Add(New DataColumn("CodigoProductoF"))
                TablaProductos.Columns.Add(New DataColumn("Nombre"))
                TablaProductos.Columns.Add(New DataColumn("CantidadExistencia"))
                TablaProductos.Columns.Add(New DataColumn("CantidadPedido"))
                TablaProductos.Columns.Add(New DataColumn("Ubicación"))
                TablaProductos.Columns.Add(New DataColumn("Cantidad"))
                TablaProductos.Columns.Add(New DataColumn("Modelo"))
                DatosPedidosCompras.consulta_productos_nacionalizados(TablaProductos, CInt(lbl_codigo.Text))

                Dim pn As New R_Productos_Nacionalizados

                pn.valores(TablaProductos, CInt(lbl_codigo.Text), DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString())
                pn.Show()
            Else
                MsgBox("Debe seleccionar el pedido", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If
        End If
    End Sub

    Private Sub Frm_Pedidos_Proveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If DGV_Pedidos.Enabled = False Then

            Dim resp As Integer = MsgBox("Existe un pedido abierto! desea guardar los cambios antes de cerrar?", MsgBoxStyle.YesNo, "SINPRO")

            If resp = vbYes Then

                bt_aceptar_Click(bt_aceptar, New EventArgs)

            End If

        End If

    End Sub



    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Tbl_Fabrica' Puede moverla o quitarla según sea necesario.
            Me.Tbl_FabricaTableAdapter.Fill(Me.MELDataSet.Tbl_Fabrica, 0)

            entro = True
            'Me.DGV_Productos.Columns(0).ReadOnly = False 
            Me.tb_aranceles.ReadOnly = True
            Me.tb_flete.ReadOnly = True
            Me.tb_otros.ReadOnly = True
            Me.tb_proforma.ReadOnly = True
            cb_proveedor.Enabled = False
            lb_proveedor.Visible = False
            Me.tb_seguro.ReadOnly = True
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.tb_obs.ReadOnly = True

            Me.DomainUpDown1.Items.Clear()
            Me.DomainUpDown1.Items.Add("Código Pedido")
            Me.DomainUpDown1.Items.Add("Proveedor")
            Me.DomainUpDown1.SelectedIndex = 1

            DGV.AllowUserToResizeRows = False
            DGV.ReadOnly = True
            DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DGV.Columns.Add("S", "S")
            DGV.Columns.Add("Cod", "Código")
            DGV.Columns.Add("CodF", "Código F.")
            DGV.Columns.Add("Desc", "Descripción")
            DGV.Columns.Add("Modelo", "Modelo")
            DGV.Columns.Add("Cantidad", "Cant.")
            DGV.Columns.Add("Costo", "F.O.B")
            DGV.Columns.Add("Total3", "Total")
            DGV.Columns.Add("FechaS", "Fecha")
            DGV.Columns.Add("Num", "N")
            DGV.Columns.Add("BackOrder", "B/O")
            DGV.Columns.Add("Aran", "Aran")
            DGV.Columns.Add("BOO", "BOO")
            DGV.Columns.Add("Marca", "Marca")

            Me.Controls.Add(DGV)
            Me.GroupBox3.Controls.Add(DGV)

            DGV.Dock = DockStyle.Bottom
            DGV.Size = New Size(593, 421)
            GroupBox3.Size = New Size(605, 450)
            GroupBox3.Location = New System.Drawing.Point(413, 220)
            GroupBox3.BringToFront()
            groupbox1.Visible = False
            DGV.BringToFront()
            DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(2).ReadOnly = True
            DGV.Columns(3).ReadOnly = True
            DGV.Columns(4).ReadOnly = True
            Dim A As New DataGridViewCellStyle()
            A.Format = "N2"
            Dim b As New DataGridViewCellStyle()
            b.Format = "d"

            DGV.Columns(6).DefaultCellStyle = A
            DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(8).DefaultCellStyle = b
            DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(3).ReadOnly = False
            DGV.Columns(5).ReadOnly = False
            DGV.Columns(8).ReadOnly = True
            DGV.Columns(1).ReadOnly = True
            DGV.Columns(9).Visible = False
            DGV.Columns(10).Visible = True
            DGV.Columns(11).Visible = False
            DGV.Columns(12).Visible = False
            DGV.Columns(13).Visible = False

            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.DGV.RowsDefaultCellStyle = DGV_Pedidos.RowsDefaultCellStyle
            Me.DGV.AlternatingRowsDefaultCellStyle = DGV_Pedidos.AlternatingRowsDefaultCellStyle
            Me.DGV.AutoResizeColumns()
            Me.DGV.Columns(0).Width = 18
            Me.DGV.Columns(5).Width = 40
            Me.DGV.Columns(1).Width = 73
            Me.DGV.Columns(2).Width = 90
            Me.DGV.Columns(3).Width = 90
            Me.DGV.Columns(4).Width = 90
            Me.DGV.Columns(6).Width = 48
            Me.DGV.Columns(8).Width = 70
            Me.DGV.Columns(9).Width = 32
            Me.DGV.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.DGV.Columns(10).Width = 35
            Me.DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DGV.Columns(7).ReadOnly = True
            DGV.ScrollBars = ScrollBars.Both
            Me.DGV.RowHeadersVisible = False
            DGV.Enabled = True
            Me.DGV.AllowUserToAddRows = False
            Me.DGV.MultiSelect = False
            DGV_Pedidos.ClearSelection()

            Me.Label2.Text = DGV.RowCount
            DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, "", 0, "", lbl_dolares.Text, lbl_euros.Text)
            'DatosPedidosCompras.consulta_Proveedor(Me.tb_proveedor)
            DGV.Columns(0).ReadOnly = False
            DGV.Columns(5).ReadOnly = False
            DGV.Columns(6).ReadOnly = False

            DatosPedidosCompras.Consulta_Moneda(ComboBox1)
            ComboBox1.ResetText()
            DGV_Pedidos.ClearSelection()

            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today

            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
            Me.empezo = True
            cb_status.SelectedIndex = 0
            Label2.Text = DGV_Pedidos.RowCount
            If w = False Then
                Me.bt_nuevo.Visible = False
                Me.bt_eliminar.Visible = False
                Me.bt_modificar.Visible = False
                Me.bt_cargar.Visible = False
                Me.bt_status.Visible = False
                Me.bt_Calcular.Visible = False
                Me.ToolBarButton1.Visible = False
            End If

        Catch ex As Exception

            MsgBox("Error cargando listado", MsgBoxStyle.Critical, "Ërror")

        End Try

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Private Sub tb_buscarcodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.Enter
        DGV_Productos.ClearSelection()
        tb_buscarcodigo.SelectAll()
    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        If Me.DGV_Pedidos.Enabled = True Then

            Dim s1 As String
            s1 = "%" + Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then

                If cb_filtroStatus.Enabled Then
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, s1, DomainUpDown1.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)
                Else
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, s1, 1, "", lbl_dolares.Text, lbl_euros.Text)
                End If

                Label2.Text = Me.DGV_Pedidos.Rows.Count
                DGV_Pedidos.ClearSelection()
                DGV.Rows.Clear()
                tb_aranceles.Clear()
                tb_proforma.Clear()
                tb_flete.Clear()
                tb_obs.Clear()
                tb_otros.Clear()
                tb_seguro.Clear()
                ComboBox1.Text = ""
                DateTimePicker1.Value = Today
                DateTimePicker2.Value = Today
                ComboBox1.Text = ""
                lbl_codigo.Text = ""
                cb_proveedor.Text = ""
                lb_proveedor.Visible = False

            ElseIf choice = 1 Then

                If cb_filtroStatus.Enabled Then
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, s1, DomainUpDown1.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)
                Else
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, s1, 2, "", lbl_dolares.Text, lbl_euros.Text)
                End If
                Label2.Text = Me.DGV_Pedidos.Rows.Count
                DGV_Pedidos.ClearSelection()
                DGV.Rows.Clear()
                tb_aranceles.Clear()
                tb_proforma.Clear()
                tb_flete.Clear()
                tb_obs.Clear()
                tb_otros.Clear()
                tb_seguro.Clear()
                ComboBox1.Text = ""
                DateTimePicker1.Value = Today
                DateTimePicker2.Value = Today
                ComboBox1.Text = ""
                'tb_proveedor.Items.Clear()
                lbl_codigo.Text = ""
                cb_proveedor.Text = ""

            End If

        Else

            CrearWhere()

        End If


    End Sub

    '------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_aranceles.KeyPress, tb_flete.KeyPress, tb_otros.KeyPress, tb_seguro.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
    End Sub
    Private Sub tb_derecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_proforma.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
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
            Me.Label22.Text = "      Sólo números y (,)"
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
            Me.Label17.Visible = True
            Me.Label17.Text = "Ingrese sólo números"
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label17.Visible = False
        End If
    End Sub

    Private Sub tb_flete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_flete.Leave
        If tb_flete.Text <> "" Then
            tb_flete.Text = Format(CDbl(tb_flete.Text), "#,##0.00")
        End If
    End Sub

    Private Sub tb_aranceles_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_aranceles.Leave
        If tb_aranceles.Text <> "" Then
            tb_aranceles.Text = Format(CDbl(tb_aranceles.Text), "#,##0.00")
        End If
    End Sub

    Private Sub tb_otros_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_otros.Leave
        If tb_otros.Text <> "" Then
            tb_otros.Text = Format(CDbl(tb_otros.Text), "#,##0.00")
        End If
    End Sub

    Private Sub tb_seguro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_seguro.Leave
        If tb_seguro.Text <> "" Then
            tb_seguro.Text = Format(CDbl(tb_seguro.Text), "#,##0.00")
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_aranceles.LostFocus, tb_flete.LostFocus, tb_otros.LostFocus, tb_seguro.LostFocus
        muestra_label(sender, 1)
    End Sub
    Private Sub tb_2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_proforma.LostFocus
        muestra_label2(sender, 1)
    End Sub
    Public Sub nuevo()
        swX = True
    End Sub

    Public Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        ToolBar1.Enabled = True
        cb_proveedor.Enabled = False
        lb_proveedor.Visible = False
        DGV_Productos.Visible = False
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        tb_aranceles.ReadOnly = True
        tb_proforma.ReadOnly = True
        DGV.Size = New Size(593, 421)
        GroupBox3.Size = New Size(605, 450)
        GroupBox3.Location = New System.Drawing.Point(413, 220)
        DGV.Location = New System.Drawing.Point(5, 27)
        GroupBox3.BringToFront()
        groupbox1.Visible = False
        tb_aranceles.Clear()
        tb_proforma.Clear()
        tb_flete.Clear()
        tb_obs.Clear()
        tb_otros.Clear()
        tb_seguro.Clear()
        Me.tb_obs.ReadOnly = True
        tb_flete.ReadOnly = True
        tb_otros.ReadOnly = True
        cb_proveedor.Enabled = False
        lb_proveedor.Visible = False
        lb_totalP.Text = "0,00"
        tb_seguro.ReadOnly = True
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        ComboBox1.Enabled = False
        DGV_Productos.Visible = False
        DGV.Columns(0).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
        DGV.Rows.Clear()
        DGV.ReadOnly = True
        ComboBox1.Text = ""
        'tb_proveedor.Items.Clear()
        'DatosPedidosCompras.Llenar_DGV("", DGV_Productos)
        GroupBox4.Enabled = False
        lbl_codigo.Text = ""
        cb_proveedor.Text = ""
        lb_proveedor.Visible = False
        DGV_Pedidos.ClearSelection()
        DGV_Pedidos.Enabled = True
        Me.DomainUpDown1.Items.Clear()
        lelim.Clear()
        Me.DomainUpDown1.Items.Add("Código Pedido")
        Me.DomainUpDown1.Items.Add("Proveedor")
        Me.DomainUpDown1.SelectedIndex = anterior2
        'Me.DomainUpDown1.Text = "Código Pedido"
        'choice = 0

        tb_buscarcodigo.Text = anterior

        Label16.Visible = True
        DateTimePicker2.Visible = True
        'DGV_Productos.Rows.Clear()
        'CrearWhere()
        RadioButton1.Checked = True
        tb_buscarcodigo.Focus()

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False

        If ComboBox1.Text = "" Or cb_proveedor.Text = "" Then

            MsgBox("Debe llenar todos los campos requeridos", MsgBoxStyle.Information, "Mensaje de error")

        Else

            If DGV.RowCount > 0 Then

                If boton = "n" Then

                    DatosPedidosCompras.inserta_pedidoCompra(CInt(cb_proveedor.Tag), CDbl(tb_flete.Text), CDbl(tb_seguro.Text), CDbl(tb_aranceles.Text), CDbl(tb_otros.Text), DateTimePicker1.Value, ComboBox1.Text, "", tb_proforma.Text, DateTimePicker2.Value, tb_obs.Text)

                    Dim cont As Integer = 0

                    For cont = 0 To DGV.RowCount - 1

                        If DGV.Rows(cont).Cells(10).Value.ToString.ToUpper = "SÍ" Or DGV.Rows(cont).Cells(10).Value.ToString.ToUpper = "SI" Then
                            DatosPedidosCompras.insertar_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 1)

                        Else

                            DatosPedidosCompras.insertar_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 0)

                        End If

                    Next

                    MsgBox("Pedido registrado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    deny = True

                ElseIf boton = "m" Then

                    DatosPedidosCompras.modifica_pedidoCompra(CDbl(tb_flete.Text), CDbl(tb_seguro.Text), CDbl(tb_seguro.Text), CDbl(tb_otros.Text), DateTimePicker1.Value, ComboBox1.Text, "", tb_proforma.Text, DateTimePicker2.Value, CInt(lbl_codigo.Text), tb_obs.Text)

                    Dim cont As Integer = 0

                    For cont = 0 To DGV.RowCount - 1

                        If DGV.Rows(cont).Cells(10).Value.ToString = "Sí" Then

                            If DGV.Rows(cont).Cells(12).Value.ToString = "Sí" Then
                                DatosPedidosCompras.modifica_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 1, 1)
                            Else
                                DatosPedidosCompras.modifica_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 1, 0)
                            End If

                        Else

                            If DGV.Rows(cont).Cells(12).Value.ToString = "Sí" Then
                                DatosPedidosCompras.modifica_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 0, 1)
                            Else
                                DatosPedidosCompras.modifica_producto_pedido(CInt(lbl_codigo.Text), DGV.Rows(cont).Cells(1).Value, CInt(DGV.Rows(cont).Cells(5).Value), CDbl(DGV.Rows(cont).Cells(6).Value), DGV.Rows(cont).Cells(0).Value, CDate(DGV.Rows(cont).Cells(8).Value), 0, 0)
                            End If

                        End If

                    Next

                    For cont3 As Integer = 1 To lelim.Count
                        If lelim(cont3).ToString.Split("/")(1) = "Sí" Then
                            DatosPedidosCompras.elimina_producto_pedido2(lelim(cont3).ToString.Split("/")(0), CInt(lbl_codigo.Text), True)
                        Else
                            DatosPedidosCompras.elimina_producto_pedido2(lelim(cont3).ToString.Split("/")(0), CInt(lbl_codigo.Text), False)
                        End If

                    Next

                    MsgBox("Pedido modificado satisfactoriamente", MsgBoxStyle.Information, "Confirmación")
                    deny = True


                End If


            Else

                MsgBox("El pedido está vacío", MsgBoxStyle.Exclamation, "Mensaje de error")

            End If


        End If

        If deny Then

            tb_aranceles.Clear()
            tb_proforma.Clear()
            tb_flete.Clear()
            tb_obs.Clear()
            tb_otros.Clear()
            tb_seguro.Clear()
            ToolBar1.Enabled = True
            DGV_Productos.Visible = False
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            tb_aranceles.ReadOnly = True
            tb_proforma.ReadOnly = True
            tb_flete.ReadOnly = True
            Me.tb_obs.ReadOnly = True
            DGV.Size = New Size(593, 421)
            GroupBox3.Size = New Size(605, 450)
            GroupBox3.Location = New System.Drawing.Point(413, 220)
            DGV.Location = New System.Drawing.Point(5, 27)
            GroupBox3.BringToFront()
            groupbox1.Visible = False
            lb_totalP.Text = "0,00"
            tb_otros.ReadOnly = True
            cb_proveedor.Enabled = False
            lb_proveedor.Visible = False
            tb_seguro.ReadOnly = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            lelim.Clear()
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            ComboBox1.Enabled = False
            DGV_Productos.Visible = False
            DGV.Columns(0).ReadOnly = True
            DGV.Columns(5).ReadOnly = True
            DGV.Columns(6).ReadOnly = True
            tb_buscarcodigo.Focus()
            DGV.Rows.Clear()
            DGV.ReadOnly = True
            ComboBox1.Text = ""
            cb_proveedor.Text = ""
            lb_proveedor.Visible = False
            'DatosPedidosCompras.Llenar_DGV("", DGV_Productos)
            DGV_Pedidos.Enabled = True
            GroupBox4.Enabled = False
            lbl_codigo.Text = ""
            DGV_Pedidos.ClearSelection()
            Me.DomainUpDown1.Items.Clear()
            Me.DomainUpDown1.Items.Add("Código Pedido")
            Me.DomainUpDown1.Items.Add("Proveedor")
            Me.DomainUpDown1.SelectedIndex = 1
            choice = 0

            If boton = "m" Then

                If cb_filtroStatus.Enabled Then
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, tb_buscarcodigo.Text, cb_filtroStatus.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)
                Else
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, tb_buscarcodigo.Text, 0, "", lbl_dolares.Text, lbl_euros.Text)
                End If

                DomainUpDown1.SelectedIndex = anterior2
                tb_buscarcodigo.Text = anterior

                DGV_Pedidos.ClearSelection()

            Else
                If cb_filtroStatus.Enabled Then
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, tb_buscarcodigo.Text, cb_filtroStatus.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)
                Else
                    DatosPedidosCompras.lv_PedidoCompra(Me.DGV_Pedidos, tb_buscarcodigo.Text, 0, "", lbl_dolares.Text, lbl_euros.Text)
                End If
            End If

            Label16.Visible = True
            DateTimePicker2.Visible = True
            RadioButton1.Checked = True
            tb_buscarcodigo.Focus()

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            If lb_proveedor.SelectedIndex <> -1 Then
                Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", cb_proveedor.Tag.ToString)

                DGV_Productos.ScrollBars = ScrollBars.None
                SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
                DGV_Productos.ScrollBars = ScrollBars.Vertical

                DGV_Productos.ClearSelection()
                'DatosPedidosCompras.Llenar_DGV_Productos_Por_Proveedor(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_Productos)
            Else
                If lbl_CodP.Text <> "" Then

                    Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", CInt(lbl_CodP.Text))
                    DGV_Productos.ScrollBars = ScrollBars.None
                    SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
                    DGV_Productos.ScrollBars = ScrollBars.Vertical
                    DGV_Productos.ClearSelection()

                End If
            End If
            tb_buscarcodigo.Clear()
            'eliminarRepetidos()
            CrearWhere()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            If lb_proveedor.SelectedIndex <> -1 Then
                'DatosPedidosCompras.Llenar_DGV(CStr(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code), DGV_Productos)
                Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", cb_proveedor.Tag.ToString)
                DGV_Productos.ClearSelection()
            Else
                If lbl_CodP.Text <> "" Then

                    'DatosPedidosCompras.Llenar_DGV(lbl_CodP.Text, DGV_Productos)
                    Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", CInt(lbl_CodP.Text))
                    DGV_Productos.ClearSelection()

                End If
            End If
            tb_buscarcodigo.Clear()
            'eliminarRepetidos()
            CrearWhere()
        End If
    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellEndEdit

        Try
            If Not Me.DGV_Productos.CurrentCell.Value Is System.DBNull.Value Then

                If Me.DGV_Productos.CurrentRow.Cells(0).Value = "" Or Me.DGV_Productos.CurrentRow.Cells(0).Value = "0" Then
                    Me.DGV_Productos.CurrentRow.Cells(0).Value = ""
                Else

                    Dim esta As Boolean = False
                    Dim cont As Integer = 0

                    For cont = 0 To DGV.RowCount - 1

                        If DGV.Rows(cont).Cells(2).Value.ToString = DGV_Productos.CurrentRow.Cells(1).Value.ToString Then

                            esta = True

                        End If

                    Next

                    If esta = False Then

                        DGV.Rows.Add("S", DGV_Productos.CurrentRow.Cells(1).Value, DGV_Productos.CurrentRow.Cells(2).Value, DGV_Productos.CurrentRow.Cells(3).Value, DGV_Productos.CurrentRow.Cells(4).Value, DGV_Productos.CurrentRow.Cells(0).Value, Format(CDbl(0), "#,##0.00"), Format(CDbl(0), "#,##0.00"), CDate(DateTimePicker1.Text), 0, "No", "", "", DGV_Productos.CurrentRow.Cells(7).Value.ToString)
                        Dim ubicRow() As Data.DataRow
                        ubicRow = Me.MELDataSet.Tables("Sp_consultaProductosParaPedidoCompra").Select("CodigoInterno = '" & DGV_Productos.CurrentRow.Cells(1).Value & "' and CodigoF = '" & DGV_Productos.CurrentRow.Cells(2).Value & "'")
                        ubicRow(0)("cant2") = ""
                        CrearWhere()
                        sel = True
                    Else
                        MsgBox("El producto ya se encuentra en el pedido", MsgBoxStyle.Exclamation, "Mensaje de error")
                        Me.DGV_Productos.CurrentRow.Cells(0).Value = ""
                    End If
                End If

            End If

            DGV.ClearSelection()
            lb_total.Text = DGV.RowCount

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        If e.ColumnIndex = 2 And Me.w Then
            Dim Modificar As New Frm_ModificaCodigoFabrica

            Dim frm As New Frm_ModificaCodigoFabrica
            Dim f As Boolean = False
            Dim r As Boolean = False

            If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                If DGV.SelectedRows(0).Cells(13).Value.ToString.Contains("Fiat") Then
                    f = True
                ElseIf DGV.SelectedRows(0).Cells(13).Value.ToString.Contains("Renault") Then
                    r = True
                End If

                Modificar.Recibe(cb_proveedor.Text, CInt(cb_proveedor.Tag), DGV.SelectedRows(0).Cells(2).Value.ToString, DGV.SelectedRows(0).Cells(1).Value.ToString, DGV.SelectedRows(0).Cells(3).Value.ToString, 0, f, r, Me)

            Else
                Modificar.Recibe(cb_proveedor.Text, CInt(cb_proveedor.Tag), DGV.SelectedRows(0).Cells(2).Value.ToString, DGV.SelectedRows(0).Cells(1).Value.ToString, DGV.SelectedRows(0).Cells(3).Value.ToString, 0, f, r, Me)
            End If

            Me.Enabled = False
            Modificar.Show()

        ElseIf e.ColumnIndex = 1 Then

            If DGV.SelectedRows.Count > 0 Then

                If Not IsNothing(f17) Then

                    If Not f17.IsDisposed Then

                        f17.WindowState = FormWindowState.Normal
                        f17.BringToFront()
                        f17.cb_buscar.SelectedIndex = 0
                        f17.chk_exacto.Checked = True
                        f17.chk_fr.Checked = True
                        f17.tb_buscarcodigo.Text = DGV.SelectedRows(0).Cells(1).Value

                        If f17.DGV_Productos.RowCount > 0 Then
                            f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                            f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                        End If

                    Else

                        f17 = New Frm_Compras

                        For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                            If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                                f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                                cont = Frm_Principal.frm.Rows.Count
                            End If
                        Next

                        f17.Show()
                        f17.cb_buscar.SelectedIndex = 0
                        f17.chk_exacto.Checked = True
                        f17.chk_fr.Checked = True
                        f17.tb_buscarcodigo.Text = DGV.SelectedRows(0).Cells(1).Value

                        If f17.DGV_Productos.RowCount > 0 Then
                            f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                            f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                        End If

                    End If

                Else

                    f17 = New Frm_Compras

                    For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                        If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                            f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                            cont = Frm_Principal.frm.Rows.Count
                        End If
                    Next

                    f17.Show()
                    f17.cb_buscar.SelectedIndex = 0
                    f17.chk_exacto.Checked = True
                    f17.chk_fr.Checked = True
                    f17.tb_buscarcodigo.Text = DGV.SelectedRows(0).Cells(1).Value

                    If f17.DGV_Productos.RowCount > 0 Then
                        f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                        f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                    End If

                End If

            End If

        End If

    End Sub



    Private Sub DataGridView2_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit

        Dim cont As Integer

        If e.ColumnIndex = 5 Then

            If Not Me.DGV.CurrentCell.Value Is Nothing Then

                If CStr(Me.DGV.CurrentRow.Cells(5).Value) = "" Or Me.DGV.CurrentRow.Cells(5).Value = "0" Then

                    Me.DGV.CurrentRow.Cells(5).Value = cant

                Else

                    Me.DGV.CurrentRow.Cells(5).Value = CInt(Me.DGV.CurrentRow.Cells(5).Value)

                End If

            Else

                Me.DGV.CurrentRow.Cells(5).Value = cant

            End If

            Me.DGV.CurrentRow.Cells(7).Value = Format(CDbl(Me.DGV.CurrentRow.Cells(5).Value) * CDbl(Me.DGV.CurrentRow.Cells(6).Value), "#,##0.00")

            lb_totalP.Text = "0,00"
            If DGV.Rows.Count <> 0 Then
                For cont = 0 To DGV.Rows.Count - 1
                    lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")

                Next

            End If
            If lb_totalP.Text = ",00" Then
                lb_totalP.Text = "0,00"
            End If

        ElseIf e.ColumnIndex = 6 Then

            If Not Me.DGV.CurrentCell.Value Is Nothing Then

                If Me.DGV.CurrentRow.Cells(6).Value.ToString = "" Then

                    Me.DGV.CurrentRow.Cells(6).Value = costo

                Else

                    Try
                        Me.DGV.CurrentRow.Cells(6).Value = Me.DGV.CurrentRow.Cells(6).Value.ToString.Replace(".", ",")
                        Convert.ToDouble(Me.DGV.CurrentRow.Cells(6).Value)
                    Catch ex As Exception
                        Me.DGV.CurrentRow.Cells(6).Value = costo
                    End Try

                    Me.DGV.CurrentRow.Cells(6).Value = Format(CDbl(Me.DGV.CurrentRow.Cells(6).Value), "#,##0.00")
                    If Me.DGV.CurrentRow.Cells(0).Value.ToString.ToUpper = "S" And Me.DGV.CurrentCell.Value <> 0 Then

                        Me.DGV.CurrentRow.Cells(0).Value = "R"
                        Me.DGV.CurrentRow.Cells(8).Value = CDate(Today)

                    ElseIf Me.DGV.CurrentRow.Cells(0).Value.ToString.ToUpper <> "S" And Me.DGV.CurrentCell.Value = 0 Then

                        DGV.CurrentRow.Cells(0).Value = "S"
                        DGV.CurrentRow.Cells(6).Value = Format(CDbl(Me.DGV.CurrentRow.Cells(6).Value), "#,##0.00")
                        DGV.CurrentRow.Cells(8).Value = CDate(Today)

                    End If

                End If

            Else

                Me.DGV.CurrentRow.Cells(6).Value = costo


            End If


            Me.DGV.CurrentRow.Cells(7).Value = Format(CDbl(Me.DGV.CurrentRow.Cells(5).Value) * CDbl(Me.DGV.CurrentRow.Cells(6).Value), "#,##0.00")

            lb_totalP.Text = "0,00"
            If DGV.Rows.Count <> 0 Then
                For cont = 0 To DGV.Rows.Count - 1
                    lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")

                Next

            End If
            If lb_totalP.Text = ",00" Then
                lb_totalP.Text = "0,00"
            End If




        ElseIf e.ColumnIndex = 0 Then

            If Not Me.DGV.CurrentCell.Value = "" Or Not Me.DGV.CurrentCell.Value Is Nothing Then

                If DGV.CurrentRow.Cells(0).Value.ToString.ToUpper <> "S" Then

                    If DGV.CurrentRow.Cells(0).Value.ToString.ToUpper <> status Then

                        DGV.CurrentRow.Cells(0).Value = DGV.CurrentRow.Cells(0).Value.ToString.ToUpper
                        DGV.CurrentRow.Cells(7).Value = CDate(Today)

                    Else

                        DGV.CurrentRow.Cells(0).Value = DGV.CurrentRow.Cells(0).Value.ToString.ToUpper

                    End If

                Else
                    If Not status.ToString.ToUpper = "S" Then

                        DGV.CurrentRow.Cells(6).Value = Format(0, "#,##0.00")
                        DGV.CurrentRow.Cells(0).Value = DGV.CurrentRow.Cells(0).Value.ToString.ToUpper
                        DGV.CurrentRow.Cells(7).Value = CDate(Today)

                    End If


                End If

            Else

                If status <> "" Then

                    DGV.CurrentRow.Cells(0).Value = status

                Else

                    DGV.CurrentRow.Cells(0).Value = "S"

                End If

            End If

        End If

    End Sub


    Public Sub guardaranteriores() Handles DGV.CellBeginEdit

        cant = DGV.CurrentRow.Cells(5).Value
        status = DGV.CurrentRow.Cells(0).Value
        costo = DGV.CurrentRow.Cells(6).Value
        fecha = CDate(DGV.CurrentRow.Cells(8).Value)

    End Sub

    Private Sub DGV_Pedidos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Pedidos.KeyDown
        If e.KeyCode = Keys.F3 Then
            If DGV_Pedidos.SelectedRows.Count > 0 Then

                If ya = False Then
                    frm.producto_pedido2("", "", "", True)
                    frm.Text = "Mover pedido"
                    frm.Panel1.Visible = True
                    frm.Button1.Visible = True
                    frm.Button2.Visible = True
                    frm.bt_agregarCuarto.Visible = False
                    frm.bt_eliminarCuarto.Visible = False
                    frm.rb_todos.Checked = True
                    frm.tb_cantidad.Visible = False
                    frm.lb_producto.Visible = False
                    frm.lb_codigo.Visible = False
                    frm.tipo = 1
                    frm.tb_nuevo.Clear()
                    frm.tb_nuevo.Visible = False
                    frm.cb_filtroStatus.ResetText()
                    frm.lb_cod.Visible = False
                    frm.tb_codfab.Visible = False
                    frm.tb_proveedor.Enabled = True
                    frm.CodigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value)
                    frm.moneda = "$"
                    frm.frm2 = Me
                    frm.TopMost = True
                    ya = True
                    Me.Enabled = False
                    frm.Show()
                Else
                    frm.producto_pedido2("", "", "", True)
                    frm.Text = "Mover pedido"
                    frm.tipo = 1
                    frm.Panel1.Visible = True
                    frm.Button1.Visible = True
                    frm.cb_filtroStatus.ResetText()
                    frm.rb_todos.Checked = True
                    frm.Button2.Visible = True
                    frm.CodigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value)
                    frm.bt_agregarCuarto.Visible = False
                    frm.bt_eliminarCuarto.Visible = False
                    frm.tb_cantidad.Visible = False
                    frm.tb_nuevo.Clear()
                    frm.tb_nuevo.Visible = False
                    frm.lb_cod.Visible = False
                    frm.tb_codfab.Visible = False
                    frm.tb_proveedor.Enabled = True
                    frm.lb_producto.Visible = False
                    frm.lb_codigo.Visible = False
                    frm.frm2 = Me
                    Me.Enabled = False
                    frm.Visible = True
                End If
            Else
                MsgBox("No existe ningún producto o pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
            End If

        End If

    End Sub

    Public Sub DGV_Pedidos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Pedidos.CellClick, DGV_Pedidos.KeyUp

        If DGV_Pedidos.SelectedRows.Count > 0 Then

            'cb_status.SelectedIndex = 0

            DGV.AllowUserToDeleteRows = False
            DGV.Rows.Clear()
            DatosPedidosCompras.consulta_pedidoCompra(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), lbl_codigo.Text, tb_flete.Text, tb_seguro.Text, tb_aranceles.Text, tb_otros.Text, DateTimePicker1.Value, ComboBox1.Text, cb_proveedor.Text, tb_proforma.Text, DateTimePicker2.Value, tb_obs.Text, lbl_CodP, chb_pedidocargado, cb_proveedor.Tag)
            DatosPedidosCompras.consulta_Productos_pedido(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), DGV)

            If cb_filtroStatus.Enabled Then
                cb_status.SelectedIndex = cb_filtroStatus.SelectedIndex + 1
                cb_status_SelectedIndexChanged(cb_status, New EventArgs)
            Else
                lb_total.Text = DGV.Rows.Count
                Total()
            End If

            DGV.ClearSelection()


            If tb_proforma.Text <> "" Then
                DateTimePicker2.Visible = True
                Label16.Visible = True
                tb_proforma.Visible = True
                Label15.Visible = True
            Else
                DateTimePicker2.Visible = False
                Label16.Visible = False
                Label15.Visible = False
                tb_proforma.Visible = False
            End If

        End If

    End Sub

    Private Sub DGV_Pedidos_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_Pedidos.ColumnHeaderMouseClick
        DGV_Pedidos.ClearSelection()
    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(Keys.ControlKey) Then

            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()

        Else

            e.Handled = True

        End If
    End Sub

    Private Sub CellKeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = ","c Then

            If e.KeyChar = "0" And Me.DGV.CurrentRow.Cells(0).Value <> "S" Then
                If Me.DGV.CurrentCell.EditedFormattedValue.ToString = Me.DGV.CurrentCell.Value.ToString Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If

            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CellKeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "S"c OrElse e.KeyChar = "R"c OrElse e.KeyChar = "O"c OrElse e.KeyChar = "F"c OrElse e.KeyChar = "D"c OrElse e.KeyChar = "N"c OrElse e.KeyChar = "s"c OrElse e.KeyChar = "r"c OrElse e.KeyChar = "o"c OrElse e.KeyChar = "f"c OrElse e.KeyChar = "d"c OrElse e.KeyChar = "n"c OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.ControlKey Then
            Me.tb_buscarcodigo.Focus()
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Productos.EditingControlShowing
        If Me.DGV_Productos.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
                RemoveHandler txt.KeyDown, AddressOf txt_KeyDown
                AddHandler txt.KeyDown, AddressOf txt_KeyDown
            End If
        End If
    End Sub

    Private Sub DGV_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        If Me.DGV.CurrentCell.ColumnIndex = 5 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        ElseIf Me.DGV.CurrentCell.ColumnIndex = 6 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress2
                AddHandler txt.KeyPress, AddressOf CellKeyPress2
            End If
        ElseIf Me.DGV.CurrentCell.ColumnIndex = 0 Then

            Dim txt As TextBox = TryCast(e.Control, TextBox)
            txt.MaxLength = 1
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress3
                AddHandler txt.KeyPress, AddressOf CellKeyPress3
            End If
        End If
    End Sub


    Private Sub tb_proforma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proforma.TextChanged
        If tb_proforma.Text <> "" Then
            DateTimePicker2.Visible = True
            Label16.Visible = True

        Else
            DateTimePicker2.Visible = False
            Label16.Visible = False
        End If
    End Sub


    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellClick
        Try
            Me.DGV_Productos.CurrentCell = Me.DGV_Productos(0, e.RowIndex)
            Me.DGV_Productos.BeginEdit(True)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellContentClick2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            'Me.DGV.CurrentCell = Me.DGV(0, e.RowIndex)
            Me.DGV.BeginEdit(True)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_buscar_Key(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then
            If ToolBar1.Enabled = True Then
                If DGV_Pedidos.Rows.Count > 0 Then
                    Me.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                    DGV_Pedidos.Focus()
                End If
            Else
                If DGV_Productos.Rows.Count > 0 Then
                    Me.DGV_Productos.CurrentCell = Me.DGV_Productos.Item(0, 0)
                    Me.DGV_Productos.Rows(0).Cells(0).Selected = True
                    Me.DGV_Productos.BeginEdit(True)
                End If

            End If
        End If

    End Sub

    Private Sub DGV_row(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Productos.SelectionChanged
        If Me.empezo = True Then
            If Not Me.tb_buscarcodigo.Focused Then
                If Me.DGV_Productos.Rows.Count >= 1 Then
                    Me.DGV_Productos.BeginEdit(True)
                End If
            End If
        End If
    End Sub

    Private Sub DGV_Productos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Productos.KeyUp, DGV_Productos.KeyDown

        Try

            If DGV_Productos.CurrentCell.IsInEditMode Then

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    tb_buscarcodigo.Focus()

                End If

            Else

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    tb_buscarcodigo.Focus()
                    tb_buscarcodigo.SelectAll()

                End If

            End If

        Catch ex As Exception

        End Try



    End Sub

    Public Sub eliminarRepetidos()

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0

        For cont = 0 To DGV.RowCount - 1

            While cont2 <= DGV_Productos.RowCount - 1

                If CStr(DGV.Rows(cont).Cells(2).Value) = CStr(DGV_Productos.Rows(cont2).Cells(1).Value) Then

                    DGV_Productos.Rows.RemoveAt(cont2)
                    cont2 = DGV_Productos.RowCount

                Else

                    cont2 = cont2 + 1

                End If

            End While

            cont2 = 0

        Next

    End Sub


    Private Sub DGV_Productos_RowLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Productos.SelectionChanged
        If sel = True Then

            If Not DGV_Productos.CurrentRow Is Nothing Then
                If DGV_Productos.CurrentRow.Index <> 0 And DGV_Productos.CurrentRow.Index <> DGV_Productos.RowCount - 1 Then
                    sel = False
                    DGV_Productos.CurrentCell = DGV_Productos.Rows(DGV_Productos.CurrentRow.Index - 1).Cells(0)
                    DGV_Productos.BeginEdit(True)
                End If
            End If

        End If
    End Sub

    Private Sub DGV_Productos_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGV_Productos.RowsRemoved
        If DGV_Productos.RowCount = 0 Then
            tb_buscarcodigo.Focus()
        End If
    End Sub

    Private Sub DGV_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV.UserDeletingRow
        If boton = "m" Then
            lelim.Add(DGV.CurrentRow.Cells(1).Value.ToString + "/" + DGV.CurrentRow.Cells(12).Value.ToString)
        End If
        CrearWhere()
    End Sub

    Public Sub Total()

        Dim cont As Integer

        lb_total.Text = DGV.Rows.Count
        lb_totalP.Text = "0,00"
        lbl_totalN.Text = "0,00"
        lbl_TotalO.Text = "0,00"
        If DGV.Rows.Count <> 0 Then
            For cont = 0 To DGV.Rows.Count - 1

                lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")

                If DGV.Rows(cont).Cells(0).Value.ToString.ToUpper = "N" Then
                    lbl_totalN.Text = Format(CDbl(lbl_totalN.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")
                End If

                If DGV.Rows(cont).Cells(0).Value.ToString.ToUpper = "O" Then
                    lbl_TotalO.Text = Format(CDbl(lbl_TotalO.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")
                End If

            Next
            If lb_totalP.Text = ",00" Then
                lb_totalP.Text = "0,00"
            End If
        End If
        'End If

        'entro = False

    End Sub


    Private Sub cb_status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_status.SelectedIndexChanged
        Dim cont As Integer
        Dim cont2 As Integer = 0
        If DGV.Rows.Count <> 0 Then

            For cont = 0 To DGV.Rows.Count - 1
                If cb_status.Text <> "Todos" Then
                    If DGV.Rows(cont).Cells(0).Value <> cb_status.Text Then
                        DGV.Rows(cont).Visible = False
                    Else
                        DGV.Rows(cont).Visible = True
                    End If
                Else
                    DGV.Rows(cont).Visible = True
                End If

            Next

            lb_totalP.Text = "0,00"
            lbl_totalN.Text = "0,00"
            lbl_TotalO.Text = "0,00"

            For cont = 0 To DGV.Rows.Count - 1
                If DGV.Rows(cont).Visible = True Then

                    If DGV.Rows(cont).Cells(0).Value.ToString.ToUpper = "N" Then
                        lbl_totalN.Text = Format(CDbl(lbl_totalN.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")
                    End If

                    If DGV.Rows(cont).Cells(0).Value.ToString.ToUpper = "O" Then
                        lbl_TotalO.Text = Format(CDbl(lbl_TotalO.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")
                    End If

                    lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(DGV.Rows(cont).Cells(5).Value) * CDbl(DGV.Rows(cont).Cells(6).Value)), "#,##0.00")
                    cont2 = cont2 + 1
                End If
            Next
            lb_total.Text = cont2
            If lb_totalP.Text = ",00" Then
                lb_totalP.Text = "0,00"
            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Label23.Visible = True
        Label21.Visible = True
        ProgressBar1.Visible = True
        GridAExcel(DGV)
        Label23.Visible = False
        Label21.Visible = False
        ProgressBar1.Visible = False
    End Sub


    Public Sub GridAExcel(ByVal ElGrid As MyDataGridView3)

        If DGV_Pedidos.SelectedRows.Count > 0 Then

            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

            Try

                'Añadimos el Libro al programa, y la hoja al libro
                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()

                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = ElGrid.ColumnCount
                Dim NRow As Integer = ElGrid.RowCount


                'Tituto

                exHoja.Range(exApp.Cells(1, 1), exApp.Cells(1, 4)).Merge(1)
                exHoja.Range(exApp.Cells(2, 1), exApp.Cells(2, 3)).Merge(1)
                exHoja.Range(exApp.Cells(3, 1), exApp.Cells(3, 3)).Merge(1)
                exHoja.Range(exApp.Cells(4, 1), exApp.Cells(4, 4)).Merge(1)
                exHoja.Range(exApp.Cells(6, 1), exApp.Cells(6, 5)).Merge(1)
                exHoja.Range(exApp.Cells(7, 1), exApp.Cells(7, 7)).Merge(1)
                exHoja.Range(exApp.Cells(1, 8), exApp.Cells(1, 9)).Merge(1)

                If My.Settings.Empresa = 2 Then

                    exHoja.Cells.Item(1, 1) = "Importadora Autopartes Global S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29580803-8"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)731.22.82"
                    exHoja.Cells.Item(4, 1) = "Email.: agsaonline@gmail.com"

                ElseIf My.Settings.Empresa = 3 Then

                    exHoja.Cells.Item(1, 1) = "Distribuidora Mil26 S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29469954-5"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)642.11.15"
                    exHoja.Cells.Item(4, 1) = "Email.: distribuidoramil26@gmail.com"

                ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                    exHoja.Cells.Item(1, 1) = "COMERCIALIZADORA BRWME, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-31135455-7"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                    exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

                End If

                exHoja.Cells.Item(6, 1) = "Solicitud de Cotización nro.: " + lbl_codigo.Text
                exHoja.Cells.Item(1, 6) = "Fecha: " + Today.Date
                exHoja.Cells.Item(7, 1) = "Sres.: " + cb_proveedor.Text + ", favor cotizar los siguientes items"
                exHoja.Rows.Item(1).Font.Bold = 1
                exHoja.Rows.Item(1).Font.italic = 1
                exHoja.Rows.Item(1).Font.name = "Arial"
                exHoja.Rows.Item(1).Font.size = 11
                exHoja.Rows.Item(1).HorizontalAlignment = 2
                exHoja.Rows.Item(2).Font.Bold = 1
                exHoja.Rows.Item(2).HorizontalAlignment = 2
                exHoja.Rows.Item(2).Font.name = "Arial"
                exHoja.Rows.Item(2).Font.size = 11
                exHoja.Rows.Item(2).Font.italic = 1
                exHoja.Rows.Item(3).Font.Bold = 1
                exHoja.Rows.Item(3).Font.italic = 1
                exHoja.Rows.Item(3).Font.name = "Arial"
                exHoja.Rows.Item(3).Font.size = 11
                exHoja.Rows.Item(3).HorizontalAlignment = 2
                exHoja.Rows.Item(4).Font.Bold = 1
                exHoja.Rows.Item(4).Font.italic = 1
                exHoja.Rows.Item(4).Font.name = "Arial"
                exHoja.Rows.Item(4).Font.size = 11
                exHoja.Rows.Item(6).HorizontalAlignment = 2
                exHoja.Rows.Item(6).Font.Bold = 1
                exHoja.Rows.Item(6).Font.italic = 1
                exHoja.Rows.Item(6).Font.name = "Arial"
                exHoja.Rows.Item(6).Font.size = 11
                exHoja.Rows.Item(7).HorizontalAlignment = 2
                exHoja.Rows.Item(7).Font.Bold = 1
                exHoja.Rows.Item(7).Font.italic = 1
                exHoja.Rows.Item(7).Font.name = "Arial"
                exHoja.Rows.Item(7).Font.size = 11
                exHoja.Rows.Item(7).HorizontalAlignment = 2


                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                For i As Integer = 1 To NCol
                    If i <> 1 And i <> 8 And i <> 9 And i <> 10 And i <> 11 And i <> 12 And i <> 13 Then

                        'If i = 7 Then
                        '    exHoja.Cells.Item(10, i + 1) = ElGrid.Columns(i - 1).HeaderText.ToString + " (" + ComboBox1.Text + ")"
                        'Else
                        exHoja.Cells.Item(10, i + 1) = ElGrid.Columns(i - 1).HeaderText.ToString
                        'End If

                    End If

                Next

                exHoja.Range(exApp.Cells(11, 7), exApp.Cells(NRow + 10, 7)).Select()
                exApp.Selection.numberformat = "#.##0,00"
                exHoja.Cells(1, 1).select()
                Dim valor As Integer = 11
                Dim acum As Double = 0
                Dim cont As Integer = 0


                For Fila As Integer = 1 To NRow

                    ProgressBar1.Value = (Fila / NRow) * 100
                    Label21.Text = Format(CDbl((Fila / NRow) * 100), "#,##0.00").ToString + "%"

                    If ElGrid.Rows(Fila - 1).Cells(0).Visible Then

                        exHoja.Cells.Item((valor), 3) = ElGrid.Rows(Fila - 1).Cells(1).Value
                        exHoja.Cells.Item((valor), 4) = ElGrid.Rows(Fila - 1).Cells(2).Value
                        exHoja.Cells.Item((valor), 5) = ElGrid.Rows(Fila - 1).Cells(3).Value
                        exHoja.Cells.Item((valor), 6) = ElGrid.Rows(Fila - 1).Cells(4).Value
                        exHoja.Cells.Item(valor, 7).clearFormats()
                        exHoja.Cells.Item((valor), 7) = ElGrid.Rows(Fila - 1).Cells(5).Value
                        exHoja.Cells.Item((valor), 8) = ElGrid.Rows(Fila - 1).Cells(6).Value
                        exHoja.Cells.Item((valor), 8).numberformat = "#.##0,00"

                        acum = acum + (CInt(ElGrid.Rows(Fila - 1).Cells(5).Value) * CDbl(ElGrid.Rows(Fila - 1).Cells(6).Value))

                        exHoja.Columns.Item(3).HorizontalAlignment = 2
                        exHoja.Columns.Item(4).HorizontalAlignment = 2
                        exHoja.Columns.Item(5).HorizontalAlignment = 2
                        exHoja.Columns.Item(6).HorizontalAlignment = 2
                        exHoja.Columns.Item(7).HorizontalAlignment = 3
                        exHoja.Columns.Item(8).HorizontalAlignment = 4

                        exHoja.Rows.Item(Fila + 10).Font.name = "Arial"
                        exHoja.Rows.Item(Fila + 10).Font.size = 9

                        exHoja.Cells(Fila + 11, 7).select()
                        cont = cont + 1
                        valor = valor + 1

                    End If

                Next

                If cont > 0 Then

                    exApp.Visible = True

                    'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto

                    exHoja.Rows.Item(10).font.name = "Arial"
                    exHoja.Rows.Item(10).font.size = 10
                    exHoja.Rows.Item(10).Font.Bold = 1
                    exHoja.Rows.Item(10).HorizontalAlignment = 3

                    exHoja.Range(exApp.Cells(10, 3), exApp.Cells((cont) + 10, 8)).BorderAround()


                    exHoja.Columns.AutoFit()
                    exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

                    exHoja = Nothing
                    exLibro = Nothing
                    exApp = Nothing

                Else

                    exHoja = Nothing
                    exLibro = Nothing
                    exApp = Nothing

                    MsgBox("La lista se encuentra vacia", MsgBoxStyle.Critical, "Error al exportar a Excel")

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
            End Try

        Else

            MsgBox("Debe seleccionar el pedido a exportar", MsgBoxStyle.Exclamation, "Mensaje de error")

        End If

    End Sub

    Public Sub recibedgv(ByVal dgv As DataGridView)
        Me.DGV_Pedidos = dgv
        DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, "", 0, "", lbl_dolares.Text, lbl_euros.Text)
    End Sub


    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If tb_buscarcodigo.Text <> "" Then

            If DomainUpDown1.SelectedIndex = 0 Then

                where = where + "CodigoInterno LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 1 Then

                where = where + "CodigoProductoF LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 2 Then

                where = where + "Nombre LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            ElseIf DomainUpDown1.SelectedIndex = 3 Then

                where = where + "Modelo LIKE '%" & tb_buscarcodigo.Text & "%'" + y
                y = " and "

            End If

        End If

        If DGV_Productos.Visible Then

            If lb_proveedor.SelectedIndex <> -1 And RadioButton1.Checked Then
                If Not cb_proveedor.Tag Is Nothing Then
                    where = where + y + "Proveedor LIKE '%" & cb_proveedor.Tag.ToString & cb_proveedor.Text & "%'"
                    y = " and "
                End If
            End If

            For cont As Integer = 0 To DGV.RowCount - 1

                If cont = 0 Then

                    where = where + y + "CodigoInterno NOT IN ('" & DGV.Rows(cont).Cells(1).Value.ToString & "'"

                Else

                    where = where + ", " + " '" & DGV.Rows(cont).Cells(1).Value.ToString & "'"

                End If

                If cont = DGV.RowCount - 1 Then

                    where = where & ")"

                End If

            Next

        End If

        DGV_Productos.ScrollBars = ScrollBars.None
        Me.SpconsultaProductosParaPedidoCompraBindingSource.Filter = where
        DGV_Productos.ScrollBars = ScrollBars.Vertical

        If DGV_Productos.RowCount > 0 Then
            DGV_Productos.FirstDisplayedScrollingRowIndex = 0
        End If


        DGV_Productos.ClearSelection()

    End Sub

    Private Sub DGV_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DGV.UserDeletedRow
        lb_total.Text = DGV.RowCount
        CrearWhere()
        DGV.Focus()
    End Sub


    '------------------------------------------------------ COMBO PROVEEDOR ----------------------------'

    Private Sub cb_proveedor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_proveedor.MouseClick
        Try
            If lb_proveedor.Visible = False Then
                lb_proveedor.Visible = True
                Me.TblFabricaBindingSource.RemoveFilter()
                lb_proveedor.SelectedValue = cb_proveedor.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cb_proveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_proveedor.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_proveedor.Visible = False Then
                Me.TblFabricaBindingSource.RemoveFilter()
                lb_proveedor.Visible = True
                lb_proveedor.SelectedValue = cb_proveedor.Text
            Else
                If lb_proveedor.Items.Count > 1 Then
                    lb_proveedor.Focus()
                    lb_proveedor.SelectedIndex = lb_proveedor.SelectedIndex + 1
                Else
                    cb_proveedor.SelectionStart = 0
                    cb_proveedor.SelectionLength = cb_proveedor.Text.Length
                    cb_proveedor.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_proveedor.Visible = True Then
                If lb_proveedor.Items.Count > 1 Then
                    lb_proveedor.Focus()
                    lb_proveedor.SelectedIndex = lb_proveedor.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_proveedor.Visible Then
            lb_proveedor.Visible = False
            If lb_proveedor.Items.Count > 0 Then
                cb_proveedor.Text = lb_proveedor.SelectedItem(1).ToString
                cb_proveedor.Tag = lb_proveedor.SelectedItem(0).ToString
                If lb_proveedor.SelectedIndex <> -1 Then
                    Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", cb_proveedor.Tag.ToString)
                    DGV_Productos.ScrollBars = ScrollBars.None
                    SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
                    DGV_Productos.ScrollBars = ScrollBars.Vertical
                    DGV_Productos.ClearSelection()
                End If
                RadioButton1.Checked = True
                lb_proveedor.SelectedIndex = 0
            Else
                cb_proveedor.Text = ""
            End If
            cb_proveedor.SelectionStart = cb_proveedor.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_proveedor.Text.Length <= 1 Or cb_proveedor.SelectedText <> "" Then
                Me.TblFabricaBindingSource.RemoveFilter()
            Else
                DGV_Productos.ScrollBars = ScrollBars.None
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text.Substring(0, cb_proveedor.Text.Length - 1) & "%'"
                DGV_Productos.ScrollBars = ScrollBars.Vertical
            End If
        End If
    End Sub
    Private Sub cb_proveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_proveedor.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_proveedor.SelectedText <> "" Then
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & e.KeyChar & "%'"
            Else
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text & e.KeyChar & "%'"
            End If

            If lb_proveedor.Items.Count = 0 Then
                e.Handled = True
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text & "%'"
            Else
                e.Handled = False
                lb_proveedor.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_proveedor.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_proveedor_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_proveedor.GotFocus
        If cb_proveedor.Text = "- Selecciona -" Then
            cb_proveedor.Text = ""
            Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text & "%'"
            lb_proveedor.Visible = True
        End If
    End Sub
    Public Sub lb_proveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_proveedor.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_proveedor.SelectedIndex = 1 Then
                cb_proveedor.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_proveedor.Visible = False
            cb_proveedor.Text = lb_proveedor.SelectedItem(1).ToString
            cb_proveedor.Tag = lb_proveedor.SelectedItem(0).ToString
            If lb_proveedor.SelectedIndex <> -1 Then
                Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", cb_proveedor.Tag.ToString)

                DGV_Productos.ScrollBars = ScrollBars.None
                SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
                DGV_Productos.ScrollBars = ScrollBars.Vertical

                DGV_Productos.ClearSelection()
            End If
            RadioButton1.Checked = True
            lb_proveedor.SelectedIndex = 0
            cb_proveedor.Focus()
            cb_proveedor.SelectionStart = cb_proveedor.Text.Length
        End If
    End Sub
    Private Sub lb_proveedor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_proveedor.MouseClick
        lb_proveedor.Visible = False
        cb_proveedor.Text = lb_proveedor.SelectedItem(1).ToString
        cb_proveedor.Tag = lb_proveedor.SelectedItem(0).ToString
        If lb_proveedor.SelectedIndex <> -1 Then
            'DatosPedidosCompras.Llenar_DGV_Productos_Por_Proveedor(CInt(cb_proveedor.Tag), DGV_Productos)
            Sp_consultaProductosParaPedidoCompraTableAdapter.Fill(Me.MELDataSet.sp_consultaProductosParaPedidoCompra, "", CInt(cb_proveedor.Tag))
            DGV_Productos.ScrollBars = ScrollBars.None
            SpconsultaProductosParaPedidoCompraBindingSource.Filter = "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
            DGV_Productos.ScrollBars = ScrollBars.Vertical
            DGV_Productos.ClearSelection()
        End If
        RadioButton1.Checked = True
        lb_proveedor.SelectedIndex = 0
        cb_proveedor.Focus()
        cb_proveedor.SelectionStart = cb_proveedor.Text.Length
    End Sub

    '--------------fin combo

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_status.CheckedChanged

        If chk_status.Checked Then
            cb_filtroStatus.Enabled = True
        Else
            cb_filtroStatus.Enabled = False
        End If

        If chk_status.Checked Then

            cb_filtroStatus.DroppedDown = True
            cb_filtroStatus.Focus()

        Else

            cb_filtroStatus.SelectedIndex = 0

            If tb_buscarcodigo.Text = "" Then
                DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, tb_buscarcodigo.Text, 0, "", lbl_dolares.Text, lbl_euros.Text)
            Else
                DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, tb_buscarcodigo.Text, DomainUpDown1.SelectedIndex + 1, "", lbl_dolares.Text, lbl_euros.Text)
            End If


            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()

        End If

        Label2.Text = Me.DGV_Pedidos.Rows.Count
        DGV_Pedidos.ClearSelection()
        DGV.Rows.Clear()
        tb_aranceles.Clear()
        tb_proforma.Clear()
        tb_flete.Clear()
        lb_total.Text = "0,00"
        tb_obs.Clear()
        tb_otros.Clear()
        tb_seguro.Clear()
        ComboBox1.Text = ""
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        ComboBox1.Text = ""
        lbl_codigo.Text = ""
        cb_proveedor.Text = ""
        lb_proveedor.Visible = False

    End Sub

    Private Sub cb_filtroStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_filtroStatus.SelectedIndexChanged

        If chk_status.Checked Then

            If cb_filtroStatus.Text = "Todos" Then

                DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, "%" + tb_buscarcodigo.Text + "%", 0, "", lbl_dolares.Text, lbl_euros.Text)

            Else

                If tb_buscarcodigo.Text <> "" Then

                    DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, "%" + tb_buscarcodigo.Text + "%", DomainUpDown1.SelectedIndex + 4, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)

                Else

                    DatosPedidosCompras.lv_PedidoCompra(DGV_Pedidos, "", 3, cb_filtroStatus.Text, lbl_dolares.Text, lbl_euros.Text)

                End If

            End If

        End If

        Label2.Text = Me.DGV_Pedidos.Rows.Count
        DGV_Pedidos.ClearSelection()
        DGV.Rows.Clear()
        tb_aranceles.Clear()
        tb_proforma.Clear()
        tb_flete.Clear()
        tb_obs.Clear()
        tb_otros.Clear()
        tb_seguro.Clear()
        ComboBox1.Text = ""
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        ComboBox1.Text = ""
        'tb_proveedor.Items.Clear()
        lbl_codigo.Text = ""
        cb_proveedor.Text = ""
        lb_proveedor.Visible = False
        cb_status.SelectedIndex = cb_filtroStatus.SelectedIndex
        Label2.Text = Me.DGV_Pedidos.Rows.Count
        DGV_Pedidos.ClearSelection()

    End Sub


    Private Sub UnificarPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnificarPedidosToolStripMenuItem.Click

        If DGV_Pedidos.SelectedRows.Count > 0 Then

            If DGV.RowCount > 0 Then

                If Not frm Is Nothing Then

                    frm = New Frm_AgregarAPedido
                    frm.Text = "Mover pedido"
                    frm.Panel1.Visible = True
                    frm.Button1.Visible = True
                    frm.Button2.Visible = True
                    frm.bt_agregarCuarto.Visible = False
                    frm.bt_eliminarCuarto.Visible = False
                    frm.rb_todos.Checked = True
                    frm.tb_cantidad.Visible = False
                    frm.lb_producto.Visible = False
                    frm.lb_codigo.Visible = False
                    frm.tipo = 1
                    frm.tb_nuevo.Clear()
                    frm.tb_nuevo.Visible = False
                    frm.cb_filtroStatus.ResetText()
                    frm.lb_cod.Visible = False
                    frm.tb_codfab.Visible = False
                    frm.tb_proveedor.Enabled = True
                    'Label3.Visible = False
                    'frm.pedido = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.rb_todos.Checked = True
                    frm.RadioButton1.Enabled = False
                    frm.tipo = 1
                    frm.CodigoPedido = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.codigo = DGV.Rows(0).Cells(1).Value.ToString
                    frm.moneda = "$"
                    frm.frm2 = Me
                    frm.TopMost = True
                    Me.Enabled = False
                    frm.Show()

                Else

                    frm.Text = "Mover pedido"
                    frm.tipo = 1
                    frm.Panel1.Visible = True
                    frm.Button1.Visible = True
                    frm.cb_filtroStatus.ResetText()
                    frm.rb_todos.Checked = True
                    frm.Button2.Visible = True
                    frm.CodigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value)
                    frm.bt_agregarCuarto.Visible = False
                    frm.bt_eliminarCuarto.Visible = False
                    frm.tb_cantidad.Visible = False
                    frm.tb_nuevo.Clear()
                    frm.tb_nuevo.Visible = False
                    frm.lb_cod.Visible = False
                    frm.tb_codfab.Visible = False
                    frm.tb_proveedor.Enabled = True
                    frm.lb_producto.Visible = False
                    frm.lb_codigo.Visible = False
                    'frm.pedido = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.rb_todos.Checked = True
                    frm.RadioButton1.Enabled = False
                    frm.tipo = 1
                    frm.moneda = "$"
                    frm.CodigoPedido = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.codigo = DGV.Rows(0).Cells(1).Value.ToString
                    frm.frm2 = Me
                    'Label3.Visible = False
                    Me.Enabled = False
                    If Not frm Is Nothing Then
                        frm.Visible = True
                    End If

                End If

            Else

                MsgBox("El pedido no tiene productos asociados", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar un pedido", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub


    Private Sub DGV_Pedidos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_Pedidos.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_Pedidos.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_Productos.ClearSelection()

                    DGV_Pedidos.Rows(hti.RowIndex).Selected = True
                    DGV_Pedidos_CellClick(DGV_Pedidos, New EventArgs)

                End If

            End If

        End If

    End Sub

End Class

