Option Strict Off
Option Explicit On

Imports System.Net.Mail

Public Class Frm_Pedidos_Clientes
    Inherits System.Windows.Forms.Form

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

    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Public WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaProductoGranSelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProducto_GranSelectTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProducto_GranSelectTableAdapter
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_iva As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tb_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_iva As System.Windows.Forms.Label
    Friend WithEvents Tb_Tlf1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_dias As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DGV_Pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents tb_monto As System.Windows.Forms.Label
    Friend WithEvents Tb_Tlf2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gb_inventario As System.Windows.Forms.GroupBox
    Friend WithEvents gb_productos_pedido As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Productos_Pedido As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_Inventario As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents DGV2 As Tesis_Nueva.MyDatagridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_obs As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.Label
    Friend WithEvents chk_chequeado As System.Windows.Forms.CheckBox
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_autorizado As System.Windows.Forms.CheckBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_facturar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_autorizar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Chk_Exist As System.Windows.Forms.CheckBox
    Friend WithEvents tb_bultos As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sp_consulta_Productos_PedidoClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consulta_Productos_PedidoClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Productos_PedidoClienteTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rb_cargados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents lb_client As System.Windows.Forms.ListBox
    Friend WithEvents cb_client As System.Windows.Forms.TextBox
    Friend WithEvents SpconsultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Friend WithEvents lbl_TotalP As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Tbl_VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_VendedorTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents txt_finalVend As System.Windows.Forms.TextBox
    Friend WithEvents lbl_detalles As System.Windows.Forms.Label
    Friend WithEvents lbl_PF As System.Windows.Forms.Label
    Friend WithEvents lbl_PorFacturar As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents esta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tb_obsInt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_clienNoPro As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbl_clienPro As System.Windows.Forms.Label
    Friend WithEvents lbl_pedNoPro As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_pedPro As System.Windows.Forms.Label
    Friend WithEvents tb_contacto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents tb_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cb_modalidadEnvio As System.Windows.Forms.ComboBox
    Friend WithEvents SpVerTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_VerTransporteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_VerTransporteTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasCred As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modEnvio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_maxPendiente As System.Windows.Forms.Label
    Friend WithEvents lbl_promedioPendiente As System.Windows.Forms.Label
    Friend WithEvents lbl_totalPendiente As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lbl_maxVencido As System.Windows.Forms.Label
    Friend WithEvents lbl_promedioVencido As System.Windows.Forms.Label
    Friend WithEvents lbl_totalVencido As System.Windows.Forms.Label
    Friend WithEvents lbl_maxPagado As System.Windows.Forms.Label
    Friend WithEvents lbl_promedioPagado As System.Windows.Forms.Label
    Friend WithEvents lbl_totalPagado As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_datosPedido As System.Windows.Forms.TabPage
    Friend WithEvents tp_indicadoresPedido As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lbl_ultimaFact As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalPedido As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lbl_otrosPedidos As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lbl_mesMaxCompra As System.Windows.Forms.Label
    Friend WithEvents lbl_maxCompra As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lbl_promedioCompras As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Public MultUbi As Boolean = False
    'Friend WithEvents bt_status As System.Windows.Forms.ToolBarButton
    'Friend WithEvents bt_Calcular As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pedidos_Clientes))
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.cb_modalidadEnvio = New System.Windows.Forms.ComboBox
        Me.SpVerTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.tb_usuario = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.tb_contacto = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.tb_obsInt = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Tbl_VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_finalVend = New System.Windows.Forms.TextBox
        Me.lb_client = New System.Windows.Forms.ListBox
        Me.SpconsultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_client = New System.Windows.Forms.TextBox
        Me.tb_bultos = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.chk_autorizado = New System.Windows.Forms.CheckBox
        Me.chk_chequeado = New System.Windows.Forms.CheckBox
        Me.tb_codigo = New System.Windows.Forms.Label
        Me.tb_obs = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_dias = New System.Windows.Forms.ComboBox
        Me.Tb_Tlf1 = New System.Windows.Forms.TextBox
        Me.Tb_Direccion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tb_monto = New System.Windows.Forms.Label
        Me.lb_iva = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_iva = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Tb_Tlf2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.DGV_Pedidos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rif = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasCred = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.modEnvio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gb_inventario = New System.Windows.Forms.GroupBox
        Me.DGV2 = New Tesis_Nueva.MyDatagridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoProductoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_consulta_Productos_PedidoClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Inventario = New System.Windows.Forms.Label
        Me.lbl_detalles = New System.Windows.Forms.Label
        Me.lbl_PF = New System.Windows.Forms.Label
        Me.lbl_PorFacturar = New System.Windows.Forms.Label
        Me.gb_productos_pedido = New System.Windows.Forms.GroupBox
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Productos_Pedido = New System.Windows.Forms.DataGridView
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ubicación = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.esta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_Pedido = New System.Windows.Forms.Label
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_facturar = New System.Windows.Forms.ToolBarButton
        Me.bt_autorizar = New System.Windows.Forms.ToolBarButton
        Me.bt_imprimir = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Chk_Exist = New System.Windows.Forms.CheckBox
        Me.SpconsultaProductoGranSelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaProducto_GranSelectTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProducto_GranSelectTableAdapter
        Me.Sp_consulta_Productos_PedidoClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Productos_PedidoClienteTableAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rb_cargados = New System.Windows.Forms.RadioButton
        Me.rb_pendientes = New System.Windows.Forms.RadioButton
        Me.Sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.lbl_TotalP = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Tbl_VendedorTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lbl_clienNoPro = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lbl_clienPro = New System.Windows.Forms.Label
        Me.lbl_pedNoPro = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lbl_pedPro = New System.Windows.Forms.Label
        Me.Sp_VerTransporteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_VerTransporteTableAdapter
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lbl_maxPendiente = New System.Windows.Forms.Label
        Me.lbl_promedioPendiente = New System.Windows.Forms.Label
        Me.lbl_totalPendiente = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl_maxVencido = New System.Windows.Forms.Label
        Me.lbl_promedioVencido = New System.Windows.Forms.Label
        Me.lbl_totalVencido = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_maxPagado = New System.Windows.Forms.Label
        Me.lbl_promedioPagado = New System.Windows.Forms.Label
        Me.lbl_totalPagado = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tp_datosPedido = New System.Windows.Forms.TabPage
        Me.tp_indicadoresPedido = New System.Windows.Forms.TabPage
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.lbl_mesMaxCompra = New System.Windows.Forms.Label
        Me.lbl_maxCompra = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.lbl_promedioCompras = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.lbl_totalPedido = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lbl_otrosPedidos = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.lbl_ultimaFact = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        CType(Me.SpVerTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_inventario.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consulta_Productos_PedidoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_productos_pedido.SuspendLayout()
        CType(Me.DGV_Productos_Pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductoGranSelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tp_datosPedido.SuspendLayout()
        Me.tp_indicadoresPedido.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(182, 53)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(188, 25)
        Me.tb_buscar.TabIndex = 4
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(708, 673)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 6
        Me.bt_cancelar.Text = "Cancelar"
        '
        'cb_modalidadEnvio
        '
        Me.cb_modalidadEnvio.DataSource = Me.SpVerTransporteBindingSource
        Me.cb_modalidadEnvio.DisplayMember = "Nombre"
        Me.cb_modalidadEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_modalidadEnvio.Enabled = False
        Me.cb_modalidadEnvio.FormattingEnabled = True
        Me.cb_modalidadEnvio.Location = New System.Drawing.Point(431, 182)
        Me.cb_modalidadEnvio.Name = "cb_modalidadEnvio"
        Me.cb_modalidadEnvio.Size = New System.Drawing.Size(173, 23)
        Me.cb_modalidadEnvio.TabIndex = 10060
        Me.cb_modalidadEnvio.ValueMember = "CodigoTransporte"
        '
        'SpVerTransporteBindingSource
        '
        Me.SpVerTransporteBindingSource.DataMember = "sp_VerTransporte"
        Me.SpVerTransporteBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_usuario
        '
        Me.tb_usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usuario.Location = New System.Drawing.Point(307, 183)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.ReadOnly = True
        Me.tb_usuario.Size = New System.Drawing.Size(114, 21)
        Me.tb_usuario.TabIndex = 20023
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(246, 185)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 17)
        Me.Label24.TabIndex = 20024
        Me.Label24.Text = "Usuario:"
        '
        'tb_contacto
        '
        Me.tb_contacto.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contacto.Location = New System.Drawing.Point(54, 183)
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.ReadOnly = True
        Me.tb_contacto.Size = New System.Drawing.Size(186, 21)
        Me.tb_contacto.TabIndex = 20021
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 23)
        Me.Label20.TabIndex = 20020
        Me.Label20.Text = "Int.:"
        '
        'tb_obsInt
        '
        Me.tb_obsInt.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obsInt.Location = New System.Drawing.Point(53, 141)
        Me.tb_obsInt.MaxLength = 250
        Me.tb_obsInt.Multiline = True
        Me.tb_obsInt.Name = "tb_obsInt"
        Me.tb_obsInt.ReadOnly = True
        Me.tb_obsInt.Size = New System.Drawing.Size(367, 39)
        Me.tb_obsInt.TabIndex = 20019
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 23)
        Me.Label19.TabIndex = 20018
        Me.Label19.Text = "Observ."
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.Tbl_VendedorBindingSource
        Me.ListBox2.DisplayMember = "nombre"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(508, 46)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(127, 64)
        Me.ListBox2.TabIndex = 20017
        Me.ListBox2.ValueMember = "CodigoVendedor"
        Me.ListBox2.Visible = False
        '
        'Tbl_VendedorBindingSource
        '
        Me.Tbl_VendedorBindingSource.DataMember = "Tbl_Vendedor"
        Me.Tbl_VendedorBindingSource.DataSource = Me.MELDataSet
        '
        'txt_finalVend
        '
        Me.txt_finalVend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_finalVend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_finalVend.Enabled = False
        Me.txt_finalVend.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_finalVend.ForeColor = System.Drawing.Color.Black
        Me.txt_finalVend.Location = New System.Drawing.Point(508, 28)
        Me.txt_finalVend.Name = "txt_finalVend"
        Me.txt_finalVend.Size = New System.Drawing.Size(127, 21)
        Me.txt_finalVend.TabIndex = 20016
        '
        'lb_client
        '
        Me.lb_client.DataSource = Me.SpconsultaClienteBindingSource
        Me.lb_client.DisplayMember = "RazonSocial"
        Me.lb_client.FormattingEnabled = True
        Me.lb_client.ItemHeight = 15
        Me.lb_client.Location = New System.Drawing.Point(189, 22)
        Me.lb_client.Name = "lb_client"
        Me.lb_client.Size = New System.Drawing.Size(232, 79)
        Me.lb_client.TabIndex = 20015
        Me.lb_client.ValueMember = "CodigoCliente"
        Me.lb_client.Visible = False
        '
        'SpconsultaClienteBindingSource
        '
        Me.SpconsultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.SpconsultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'cb_client
        '
        Me.cb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_client.Enabled = False
        Me.cb_client.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_client.ForeColor = System.Drawing.Color.Black
        Me.cb_client.Location = New System.Drawing.Point(189, 4)
        Me.cb_client.Name = "cb_client"
        Me.cb_client.Size = New System.Drawing.Size(232, 21)
        Me.cb_client.TabIndex = 20014
        '
        'tb_bultos
        '
        Me.tb_bultos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bultos.Location = New System.Drawing.Point(585, 135)
        Me.tb_bultos.Name = "tb_bultos"
        Me.tb_bultos.ReadOnly = True
        Me.tb_bultos.Size = New System.Drawing.Size(45, 21)
        Me.tb_bultos.TabIndex = 108
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(534, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 19)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Bultos:"
        '
        'chk_autorizado
        '
        Me.chk_autorizado.AutoSize = True
        Me.chk_autorizado.Enabled = False
        Me.chk_autorizado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_autorizado.Location = New System.Drawing.Point(428, 134)
        Me.chk_autorizado.Name = "chk_autorizado"
        Me.chk_autorizado.Size = New System.Drawing.Size(89, 20)
        Me.chk_autorizado.TabIndex = 104
        Me.chk_autorizado.Text = "Autorizado"
        Me.chk_autorizado.UseVisualStyleBackColor = True
        '
        'chk_chequeado
        '
        Me.chk_chequeado.AutoSize = True
        Me.chk_chequeado.Enabled = False
        Me.chk_chequeado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_chequeado.Location = New System.Drawing.Point(428, 160)
        Me.chk_chequeado.Name = "chk_chequeado"
        Me.chk_chequeado.Size = New System.Drawing.Size(92, 20)
        Me.chk_chequeado.TabIndex = 103
        Me.chk_chequeado.Text = "Chequeado"
        Me.chk_chequeado.UseVisualStyleBackColor = True
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(51, 5)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(73, 23)
        Me.tb_codigo.TabIndex = 99
        '
        'tb_obs
        '
        Me.tb_obs.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obs.Location = New System.Drawing.Point(54, 94)
        Me.tb_obs.MaxLength = 250
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.ReadOnly = True
        Me.tb_obs.Size = New System.Drawing.Size(367, 45)
        Me.tb_obs.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Observ.:"
        '
        'tb_dias
        '
        Me.tb_dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_dias.Enabled = False
        Me.tb_dias.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dias.FormattingEnabled = True
        Me.tb_dias.Location = New System.Drawing.Point(377, 29)
        Me.tb_dias.Name = "tb_dias"
        Me.tb_dias.Size = New System.Drawing.Size(43, 22)
        Me.tb_dias.TabIndex = 92
        '
        'Tb_Tlf1
        '
        Me.Tb_Tlf1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Tlf1.Location = New System.Drawing.Point(55, 30)
        Me.Tb_Tlf1.Name = "Tb_Tlf1"
        Me.Tb_Tlf1.ReadOnly = True
        Me.Tb_Tlf1.Size = New System.Drawing.Size(115, 21)
        Me.Tb_Tlf1.TabIndex = 64
        '
        'Tb_Direccion
        '
        Me.Tb_Direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Direccion.Location = New System.Drawing.Point(54, 55)
        Me.Tb_Direccion.Multiline = True
        Me.Tb_Direccion.Name = "Tb_Direccion"
        Me.Tb_Direccion.ReadOnly = True
        Me.Tb_Direccion.Size = New System.Drawing.Size(367, 37)
        Me.Tb_Direccion.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 23)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Direc.:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lbl_Total)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(431, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 30)
        Me.Panel2.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 23)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Monto Total:"
        '
        'lbl_Total
        '
        Me.lbl_Total.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(95, 0)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(100, 23)
        Me.lbl_Total.TabIndex = 74
        Me.lbl_Total.Text = "0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tb_monto)
        Me.Panel1.Controls.Add(Me.lb_iva)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbl_iva)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(431, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 42)
        Me.Panel1.TabIndex = 60
        '
        'tb_monto
        '
        Me.tb_monto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_monto.ForeColor = System.Drawing.Color.Black
        Me.tb_monto.Location = New System.Drawing.Point(75, 1)
        Me.tb_monto.Name = "tb_monto"
        Me.tb_monto.Size = New System.Drawing.Size(119, 23)
        Me.tb_monto.TabIndex = 107
        Me.tb_monto.Text = "0.00"
        Me.tb_monto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lb_iva
        '
        Me.lb_iva.BackColor = System.Drawing.Color.Transparent
        Me.lb_iva.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_iva.Location = New System.Drawing.Point(45, 20)
        Me.lb_iva.Name = "lb_iva"
        Me.lb_iva.Size = New System.Drawing.Size(60, 23)
        Me.lb_iva.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sub-Total:"
        '
        'lbl_iva
        '
        Me.lbl_iva.BackColor = System.Drawing.Color.Transparent
        Me.lbl_iva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iva.Location = New System.Drawing.Point(78, 18)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(116, 23)
        Me.lbl_iva.TabIndex = 72
        Me.lbl_iva.Text = "0.00"
        Me.lbl_iva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 23)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "I.V.A."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 23)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "(*)Vendedor:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(508, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(426, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 23)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "(*)Fecha:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(341, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 24)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Cred:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Telf. 1:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Código:"
        '
        'Tb_Tlf2
        '
        Me.Tb_Tlf2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Tlf2.Location = New System.Drawing.Point(220, 30)
        Me.Tb_Tlf2.Name = "Tb_Tlf2"
        Me.Tb_Tlf2.ReadOnly = True
        Me.Tb_Tlf2.Size = New System.Drawing.Size(112, 21)
        Me.Tb_Tlf2.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "(*)Cliente:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Telf. 2:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 186)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 17)
        Me.Label22.TabIndex = 20022
        Me.Label22.Text = "Contact:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(393, 677)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(191, 15)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "ALERTA: Cliente bloqueado"
        Me.Label17.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(607, 673)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 5
        Me.bt_aceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Total Pedidos:"
        '
        'DGV_Pedidos
        '
        Me.DGV_Pedidos.AllowUserToAddRows = False
        Me.DGV_Pedidos.AllowUserToDeleteRows = False
        Me.DGV_Pedidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Pedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Pedidos.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Autor, Me.DataGridViewTextBoxColumn5, Me.rif, Me.Monto, Me.DiasCred, Me.usuario, Me.modEnvio})
        Me.DGV_Pedidos.EnableHeadersVisualStyles = False
        Me.DGV_Pedidos.Location = New System.Drawing.Point(3, 131)
        Me.DGV_Pedidos.MultiSelect = False
        Me.DGV_Pedidos.Name = "DGV_Pedidos"
        Me.DGV_Pedidos.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Pedidos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pedidos.Size = New System.Drawing.Size(370, 528)
        Me.DGV_Pedidos.TabIndex = 10000
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 5.0!)
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 73
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 49
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 157
        '
        'Autor
        '
        Me.Autor.HeaderText = "A"
        Me.Autor.Name = "Autor"
        Me.Autor.ReadOnly = True
        Me.Autor.Width = 24
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 7.0!)
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Z"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 20
        '
        'rif
        '
        Me.rif.HeaderText = "rif"
        Me.rif.Name = "rif"
        Me.rif.Visible = False
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Visible = False
        '
        'DiasCred
        '
        Me.DiasCred.HeaderText = "DiasCred"
        Me.DiasCred.Name = "DiasCred"
        Me.DiasCred.Visible = False
        '
        'usuario
        '
        Me.usuario.HeaderText = "usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.Visible = False
        '
        'modEnvio
        '
        Me.modEnvio.HeaderText = "modEnvio"
        Me.modEnvio.Name = "modEnvio"
        Me.modEnvio.Visible = False
        '
        'gb_inventario
        '
        Me.gb_inventario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gb_inventario.Controls.Add(Me.DGV2)
        Me.gb_inventario.Controls.Add(Me.lbl_Inventario)
        Me.gb_inventario.Location = New System.Drawing.Point(376, 244)
        Me.gb_inventario.Name = "gb_inventario"
        Me.gb_inventario.Size = New System.Drawing.Size(650, 210)
        Me.gb_inventario.TabIndex = 67
        Me.gb_inventario.TabStop = False
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AllowUserToResizeRows = False
        Me.DGV2.AutoGenerateColumns = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CodigoTramoDataGridViewTextBoxColumn, Me.Modelo2DataGridViewTextBoxColumn, Me.CodigoProductoFDataGridViewTextBoxColumn})
        Me.DGV2.DataSource = Me.Sp_consulta_Productos_PedidoClienteBindingSource
        Me.DGV2.Location = New System.Drawing.Point(5, 27)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV2.Size = New System.Drawing.Size(636, 180)
        Me.DGV2.TabIndex = 0
        Me.DGV2.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoTramoDataGridViewTextBoxColumn
        '
        Me.CodigoTramoDataGridViewTextBoxColumn.DataPropertyName = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn.HeaderText = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn.Name = "CodigoTramoDataGridViewTextBoxColumn"
        Me.CodigoTramoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Modelo2DataGridViewTextBoxColumn
        '
        Me.Modelo2DataGridViewTextBoxColumn.DataPropertyName = "Modelo2"
        Me.Modelo2DataGridViewTextBoxColumn.HeaderText = "Modelo2"
        Me.Modelo2DataGridViewTextBoxColumn.Name = "Modelo2DataGridViewTextBoxColumn"
        Me.Modelo2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoProductoFDataGridViewTextBoxColumn
        '
        Me.CodigoProductoFDataGridViewTextBoxColumn.DataPropertyName = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.HeaderText = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.Name = "CodigoProductoFDataGridViewTextBoxColumn"
        Me.CodigoProductoFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Sp_consulta_Productos_PedidoClienteBindingSource
        '
        Me.Sp_consulta_Productos_PedidoClienteBindingSource.DataMember = "sp_consulta_Productos_PedidoCliente"
        Me.Sp_consulta_Productos_PedidoClienteBindingSource.DataSource = Me.MELDataSet
        '
        'lbl_Inventario
        '
        Me.lbl_Inventario.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Inventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Inventario.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Inventario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Inventario.Location = New System.Drawing.Point(0, 1)
        Me.lbl_Inventario.Name = "lbl_Inventario"
        Me.lbl_Inventario.Size = New System.Drawing.Size(650, 21)
        Me.lbl_Inventario.TabIndex = 66
        Me.lbl_Inventario.Text = "Productos en Inventario"
        Me.lbl_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_detalles
        '
        Me.lbl_detalles.AutoSize = True
        Me.lbl_detalles.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_detalles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_detalles.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!, System.Drawing.FontStyle.Underline)
        Me.lbl_detalles.ForeColor = System.Drawing.Color.White
        Me.lbl_detalles.Location = New System.Drawing.Point(524, 246)
        Me.lbl_detalles.Name = "lbl_detalles"
        Me.lbl_detalles.Size = New System.Drawing.Size(41, 14)
        Me.lbl_detalles.TabIndex = 98
        Me.lbl_detalles.Text = "Detalle"
        Me.lbl_detalles.Visible = False
        '
        'lbl_PF
        '
        Me.lbl_PF.AutoSize = True
        Me.lbl_PF.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_PF.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PF.ForeColor = System.Drawing.Color.White
        Me.lbl_PF.Location = New System.Drawing.Point(382, 246)
        Me.lbl_PF.Name = "lbl_PF"
        Me.lbl_PF.Size = New System.Drawing.Size(97, 17)
        Me.lbl_PF.TabIndex = 88
        Me.lbl_PF.Text = "Por facturar:"
        Me.lbl_PF.Visible = False
        '
        'lbl_PorFacturar
        '
        Me.lbl_PorFacturar.AutoSize = True
        Me.lbl_PorFacturar.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_PorFacturar.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PorFacturar.ForeColor = System.Drawing.Color.White
        Me.lbl_PorFacturar.Location = New System.Drawing.Point(492, 246)
        Me.lbl_PorFacturar.Name = "lbl_PorFacturar"
        Me.lbl_PorFacturar.Size = New System.Drawing.Size(26, 17)
        Me.lbl_PorFacturar.TabIndex = 89
        Me.lbl_PorFacturar.Text = "##"
        Me.lbl_PorFacturar.Visible = False
        '
        'gb_productos_pedido
        '
        Me.gb_productos_pedido.BackColor = System.Drawing.Color.SteelBlue
        Me.gb_productos_pedido.Controls.Add(Me.lb_total)
        Me.gb_productos_pedido.Controls.Add(Me.Label1)
        Me.gb_productos_pedido.Controls.Add(Me.DGV_Productos_Pedido)
        Me.gb_productos_pedido.Controls.Add(Me.lbl_Pedido)
        Me.gb_productos_pedido.Location = New System.Drawing.Point(375, 244)
        Me.gb_productos_pedido.Name = "gb_productos_pedido"
        Me.gb_productos_pedido.Size = New System.Drawing.Size(651, 422)
        Me.gb_productos_pedido.TabIndex = 100
        Me.gb_productos_pedido.TabStop = False
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lb_total.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.SystemColors.Window
        Me.lb_total.Location = New System.Drawing.Point(615, 6)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(13, 14)
        Me.lb_total.TabIndex = 10001
        Me.lb_total.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(526, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 10000
        Me.Label1.Text = "Total Artículos:"
        '
        'DGV_Productos_Pedido
        '
        Me.DGV_Productos_Pedido.AllowUserToAddRows = False
        Me.DGV_Productos_Pedido.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Productos_Pedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Productos_Pedido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGV_Productos_Pedido.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV_Productos_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos_Pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.Descripción, Me.Modelo, Me.Existencia, Me.Precio, Me.SubT, Me.Ubicación, Me.CodigoTramo, Me.esta})
        Me.DGV_Productos_Pedido.EnableHeadersVisualStyles = False
        Me.DGV_Productos_Pedido.Location = New System.Drawing.Point(5, 27)
        Me.DGV_Productos_Pedido.MultiSelect = False
        Me.DGV_Productos_Pedido.Name = "DGV_Productos_Pedido"
        Me.DGV_Productos_Pedido.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos_Pedido.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_Productos_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos_Pedido.Size = New System.Drawing.Size(639, 388)
        Me.DGV_Productos_Pedido.TabIndex = 9999
        '
        'Cantidad
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 40
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 85
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        Me.Descripción.Width = 175
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 75
        '
        'Existencia
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Existencia.DefaultCellStyle = DataGridViewCellStyle11
        Me.Existencia.HeaderText = "Exis."
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 40
        '
        'Precio
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "#,##0.00"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle12
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 53
        '
        'SubT
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "#,##0.00"
        Me.SubT.DefaultCellStyle = DataGridViewCellStyle13
        Me.SubT.HeaderText = "SubTotal"
        Me.SubT.Name = "SubT"
        Me.SubT.ReadOnly = True
        Me.SubT.Width = 65
        '
        'Ubicación
        '
        Me.Ubicación.HeaderText = "Ubi."
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        Me.Ubicación.Width = 85
        '
        'CodigoTramo
        '
        Me.CodigoTramo.HeaderText = "CodigoTramo"
        Me.CodigoTramo.Name = "CodigoTramo"
        Me.CodigoTramo.ReadOnly = True
        Me.CodigoTramo.Visible = False
        '
        'esta
        '
        Me.esta.HeaderText = "esta"
        Me.esta.Name = "esta"
        Me.esta.Visible = False
        '
        'lbl_Pedido
        '
        Me.lbl_Pedido.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Pedido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pedido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Pedido.Location = New System.Drawing.Point(0, 2)
        Me.lbl_Pedido.Name = "lbl_Pedido"
        Me.lbl_Pedido.Size = New System.Drawing.Size(651, 23)
        Me.lbl_Pedido.TabIndex = 101
        Me.lbl_Pedido.Text = "Productos Asociados al Pedido"
        Me.lbl_Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(3, 52)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(173, 23)
        Me.DomainUpDown1.TabIndex = 10006
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_facturar, Me.bt_autorizar, Me.bt_imprimir, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(24, 24)
        Me.ToolBar1.Divider = False
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-1, 4)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(378, 52)
        Me.ToolBar1.TabIndex = 10010
        Me.ToolBar1.Wrappable = False
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
        'bt_facturar
        '
        Me.bt_facturar.ImageIndex = 3
        Me.bt_facturar.Name = "bt_facturar"
        Me.bt_facturar.Text = "Facturar"
        '
        'bt_autorizar
        '
        Me.bt_autorizar.ImageIndex = 6
        Me.bt_autorizar.Name = "bt_autorizar"
        Me.bt_autorizar.Text = "Autorizar"
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
        Me.ImageList2.Images.SetKeyName(6, "ok.gif")
        Me.ImageList2.Images.SetKeyName(7, "box3.png")
        '
        'Chk_Exist
        '
        Me.Chk_Exist.AutoSize = True
        Me.Chk_Exist.BackColor = System.Drawing.Color.DodgerBlue
        Me.Chk_Exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Exist.ForeColor = System.Drawing.Color.White
        Me.Chk_Exist.Location = New System.Drawing.Point(944, 246)
        Me.Chk_Exist.Name = "Chk_Exist"
        Me.Chk_Exist.Size = New System.Drawing.Size(73, 18)
        Me.Chk_Exist.TabIndex = 10053
        Me.Chk_Exist.Text = "Exist. > 0"
        Me.Chk_Exist.UseVisualStyleBackColor = False
        Me.Chk_Exist.Visible = False
        '
        'SpconsultaProductoGranSelectBindingSource
        '
        Me.SpconsultaProductoGranSelectBindingSource.DataMember = "sp_consultaProducto_GranSelect"
        Me.SpconsultaProductoGranSelectBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaProducto_GranSelectTableAdapter
        '
        Me.Sp_consultaProducto_GranSelectTableAdapter.ClearBeforeFill = True
        '
        'Sp_consulta_Productos_PedidoClienteTableAdapter
        '
        Me.Sp_consulta_Productos_PedidoClienteTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rb_cargados)
        Me.Panel3.Controls.Add(Me.rb_pendientes)
        Me.Panel3.Location = New System.Drawing.Point(5, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 28)
        Me.Panel3.TabIndex = 10054
        '
        'rb_cargados
        '
        Me.rb_cargados.AutoSize = True
        Me.rb_cargados.Checked = True
        Me.rb_cargados.Location = New System.Drawing.Point(168, 5)
        Me.rb_cargados.Name = "rb_cargados"
        Me.rb_cargados.Size = New System.Drawing.Size(81, 19)
        Me.rb_cargados.TabIndex = 10056
        Me.rb_cargados.TabStop = True
        Me.rb_cargados.Text = "Cargados"
        Me.rb_cargados.UseVisualStyleBackColor = True
        '
        'rb_pendientes
        '
        Me.rb_pendientes.AutoSize = True
        Me.rb_pendientes.Location = New System.Drawing.Point(8, 5)
        Me.rb_pendientes.Name = "rb_pendientes"
        Me.rb_pendientes.Size = New System.Drawing.Size(154, 19)
        Me.rb_pendientes.TabIndex = 10055
        Me.rb_pendientes.Text = "Pendientes por cargar"
        Me.rb_pendientes.UseVisualStyleBackColor = True
        '
        'Sp_consultaClienteTableAdapter
        '
        Me.Sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'lbl_TotalP
        '
        Me.lbl_TotalP.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_TotalP.Location = New System.Drawing.Point(91, 25)
        Me.lbl_TotalP.Name = "lbl_TotalP"
        Me.lbl_TotalP.Size = New System.Drawing.Size(122, 19)
        Me.lbl_TotalP.TabIndex = 10056
        Me.lbl_TotalP.Text = "0,00"
        Me.lbl_TotalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 28)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 16)
        Me.Label30.TabIndex = 10055
        Me.Label30.Text = "Monto Total:"
        '
        'Tbl_VendedorTableAdapter
        '
        Me.Tbl_VendedorTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(267, 88)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 15)
        Me.LinkLabel1.TabIndex = 10057
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Por Monto"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.lbl_TotalP)
        Me.Panel4.Location = New System.Drawing.Point(3, 665)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 53)
        Me.Panel4.TabIndex = 10058
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_clienNoPro)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.lbl_clienPro)
        Me.Panel5.Controls.Add(Me.lbl_pedNoPro)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.lbl_pedPro)
        Me.Panel5.Location = New System.Drawing.Point(3, 665)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(365, 53)
        Me.Panel5.TabIndex = 10059
        '
        'lbl_clienNoPro
        '
        Me.lbl_clienNoPro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienNoPro.Location = New System.Drawing.Point(272, 29)
        Me.lbl_clienNoPro.Name = "lbl_clienNoPro"
        Me.lbl_clienNoPro.Size = New System.Drawing.Size(40, 16)
        Me.lbl_clienNoPro.TabIndex = 79
        Me.lbl_clienNoPro.Text = "#"
        Me.lbl_clienNoPro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(196, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 16)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Clientes:"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(196, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 16)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "Clientes:"
        '
        'lbl_clienPro
        '
        Me.lbl_clienPro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienPro.Location = New System.Drawing.Point(272, 6)
        Me.lbl_clienPro.Name = "lbl_clienPro"
        Me.lbl_clienPro.Size = New System.Drawing.Size(40, 16)
        Me.lbl_clienPro.TabIndex = 77
        Me.lbl_clienPro.Text = "#"
        Me.lbl_clienPro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_pedNoPro
        '
        Me.lbl_pedNoPro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedNoPro.Location = New System.Drawing.Point(123, 29)
        Me.lbl_pedNoPro.Name = "lbl_pedNoPro"
        Me.lbl_pedNoPro.Size = New System.Drawing.Size(40, 16)
        Me.lbl_pedNoPro.TabIndex = 75
        Me.lbl_pedNoPro.Text = "#"
        Me.lbl_pedNoPro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 16)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Pedidos No Pro.:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Pedidos Pro.:"
        '
        'lbl_pedPro
        '
        Me.lbl_pedPro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedPro.Location = New System.Drawing.Point(123, 6)
        Me.lbl_pedPro.Name = "lbl_pedPro"
        Me.lbl_pedPro.Size = New System.Drawing.Size(40, 16)
        Me.lbl_pedPro.TabIndex = 73
        Me.lbl_pedPro.Text = "#"
        Me.lbl_pedPro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Sp_VerTransporteTableAdapter
        '
        Me.Sp_VerTransporteTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(267, 106)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(109, 15)
        Me.LinkLabel2.TabIndex = 10060
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Actualizar Precios"
        Me.LinkLabel2.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_maxPendiente)
        Me.GroupBox5.Controls.Add(Me.lbl_promedioPendiente)
        Me.GroupBox5.Controls.Add(Me.lbl_totalPendiente)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Location = New System.Drawing.Point(434, 35)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(197, 114)
        Me.GroupBox5.TabIndex = 10064
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Facturas Por Vencer"
        '
        'lbl_maxPendiente
        '
        Me.lbl_maxPendiente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maxPendiente.Location = New System.Drawing.Point(94, 88)
        Me.lbl_maxPendiente.Name = "lbl_maxPendiente"
        Me.lbl_maxPendiente.Size = New System.Drawing.Size(91, 16)
        Me.lbl_maxPendiente.TabIndex = 81
        Me.lbl_maxPendiente.Text = "#"
        Me.lbl_maxPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_promedioPendiente
        '
        Me.lbl_promedioPendiente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_promedioPendiente.Location = New System.Drawing.Point(94, 59)
        Me.lbl_promedioPendiente.Name = "lbl_promedioPendiente"
        Me.lbl_promedioPendiente.Size = New System.Drawing.Size(91, 16)
        Me.lbl_promedioPendiente.TabIndex = 80
        Me.lbl_promedioPendiente.Text = "#"
        Me.lbl_promedioPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_totalPendiente
        '
        Me.lbl_totalPendiente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPendiente.Location = New System.Drawing.Point(94, 30)
        Me.lbl_totalPendiente.Name = "lbl_totalPendiente"
        Me.lbl_totalPendiente.Size = New System.Drawing.Size(91, 16)
        Me.lbl_totalPendiente.TabIndex = 79
        Me.lbl_totalPendiente.Text = "#"
        Me.lbl_totalPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(10, 59)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 16)
        Me.Label34.TabIndex = 75
        Me.Label34.Text = "Prom. Días:"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(10, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 16)
        Me.Label35.TabIndex = 74
        Me.Label35.Text = "Max. Días:"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 16)
        Me.Label36.TabIndex = 73
        Me.Label36.Text = "Monto Total:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_maxVencido)
        Me.GroupBox4.Controls.Add(Me.lbl_promedioVencido)
        Me.GroupBox4.Controls.Add(Me.lbl_totalVencido)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Location = New System.Drawing.Point(220, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(195, 113)
        Me.GroupBox4.TabIndex = 10063
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facturas Vencidas"
        '
        'lbl_maxVencido
        '
        Me.lbl_maxVencido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maxVencido.Location = New System.Drawing.Point(96, 87)
        Me.lbl_maxVencido.Name = "lbl_maxVencido"
        Me.lbl_maxVencido.Size = New System.Drawing.Size(90, 16)
        Me.lbl_maxVencido.TabIndex = 81
        Me.lbl_maxVencido.Text = "#"
        Me.lbl_maxVencido.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_promedioVencido
        '
        Me.lbl_promedioVencido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_promedioVencido.Location = New System.Drawing.Point(96, 58)
        Me.lbl_promedioVencido.Name = "lbl_promedioVencido"
        Me.lbl_promedioVencido.Size = New System.Drawing.Size(90, 16)
        Me.lbl_promedioVencido.TabIndex = 80
        Me.lbl_promedioVencido.Text = "#"
        Me.lbl_promedioVencido.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_totalVencido
        '
        Me.lbl_totalVencido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalVencido.Location = New System.Drawing.Point(95, 29)
        Me.lbl_totalVencido.Name = "lbl_totalVencido"
        Me.lbl_totalVencido.Size = New System.Drawing.Size(90, 16)
        Me.lbl_totalVencido.TabIndex = 79
        Me.lbl_totalVencido.Text = "#"
        Me.lbl_totalVencido.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(10, 58)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(102, 16)
        Me.Label31.TabIndex = 75
        Me.Label31.Text = "Prom. Días:"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(10, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 74
        Me.Label32.Text = "Max. Días:"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(10, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 73
        Me.Label33.Text = "Monto Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_maxPagado)
        Me.GroupBox3.Controls.Add(Me.lbl_promedioPagado)
        Me.GroupBox3.Controls.Add(Me.lbl_totalPagado)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 114)
        Me.GroupBox3.TabIndex = 10062
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturas Pagadas"
        '
        'lbl_maxPagado
        '
        Me.lbl_maxPagado.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maxPagado.Location = New System.Drawing.Point(91, 88)
        Me.lbl_maxPagado.Name = "lbl_maxPagado"
        Me.lbl_maxPagado.Size = New System.Drawing.Size(89, 16)
        Me.lbl_maxPagado.TabIndex = 78
        Me.lbl_maxPagado.Text = "#"
        Me.lbl_maxPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_promedioPagado
        '
        Me.lbl_promedioPagado.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_promedioPagado.Location = New System.Drawing.Point(91, 59)
        Me.lbl_promedioPagado.Name = "lbl_promedioPagado"
        Me.lbl_promedioPagado.Size = New System.Drawing.Size(89, 16)
        Me.lbl_promedioPagado.TabIndex = 77
        Me.lbl_promedioPagado.Text = "#"
        Me.lbl_promedioPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_totalPagado
        '
        Me.lbl_totalPagado.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPagado.Location = New System.Drawing.Point(91, 30)
        Me.lbl_totalPagado.Name = "lbl_totalPagado"
        Me.lbl_totalPagado.Size = New System.Drawing.Size(89, 16)
        Me.lbl_totalPagado.TabIndex = 76
        Me.lbl_totalPagado.Text = "#"
        Me.lbl_totalPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(10, 59)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(102, 16)
        Me.Label29.TabIndex = 75
        Me.Label29.Text = "Prom. Días:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 74
        Me.Label28.Text = "Max. Días:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "Monto Total:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_datosPedido)
        Me.TabControl1.Controls.Add(Me.tp_indicadoresPedido)
        Me.TabControl1.Location = New System.Drawing.Point(374, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(650, 235)
        Me.TabControl1.TabIndex = 10062
        '
        'tp_datosPedido
        '
        Me.tp_datosPedido.BackColor = System.Drawing.Color.White
        Me.tp_datosPedido.Controls.Add(Me.lb_client)
        Me.tp_datosPedido.Controls.Add(Me.cb_client)
        Me.tp_datosPedido.Controls.Add(Me.cb_modalidadEnvio)
        Me.tp_datosPedido.Controls.Add(Me.tb_usuario)
        Me.tp_datosPedido.Controls.Add(Me.Label24)
        Me.tp_datosPedido.Controls.Add(Me.tb_contacto)
        Me.tp_datosPedido.Controls.Add(Me.Label4)
        Me.tp_datosPedido.Controls.Add(Me.Tb_Tlf2)
        Me.tp_datosPedido.Controls.Add(Me.tb_obsInt)
        Me.tp_datosPedido.Controls.Add(Me.Label15)
        Me.tp_datosPedido.Controls.Add(Me.ListBox2)
        Me.tp_datosPedido.Controls.Add(Me.Label10)
        Me.tp_datosPedido.Controls.Add(Me.txt_finalVend)
        Me.tp_datosPedido.Controls.Add(Me.DateTimePicker1)
        Me.tp_datosPedido.Controls.Add(Me.Label8)
        Me.tp_datosPedido.Controls.Add(Me.Panel1)
        Me.tp_datosPedido.Controls.Add(Me.tb_bultos)
        Me.tp_datosPedido.Controls.Add(Me.Panel2)
        Me.tp_datosPedido.Controls.Add(Me.Label16)
        Me.tp_datosPedido.Controls.Add(Me.chk_autorizado)
        Me.tp_datosPedido.Controls.Add(Me.Tb_Direccion)
        Me.tp_datosPedido.Controls.Add(Me.chk_chequeado)
        Me.tp_datosPedido.Controls.Add(Me.Tb_Tlf1)
        Me.tp_datosPedido.Controls.Add(Me.tb_codigo)
        Me.tp_datosPedido.Controls.Add(Me.tb_dias)
        Me.tp_datosPedido.Controls.Add(Me.tb_obs)
        Me.tp_datosPedido.Controls.Add(Me.Label3)
        Me.tp_datosPedido.Controls.Add(Me.Label14)
        Me.tp_datosPedido.Controls.Add(Me.Label22)
        Me.tp_datosPedido.Controls.Add(Me.Label20)
        Me.tp_datosPedido.Controls.Add(Me.Label19)
        Me.tp_datosPedido.Controls.Add(Me.Label5)
        Me.tp_datosPedido.Controls.Add(Me.Label9)
        Me.tp_datosPedido.Controls.Add(Me.Label18)
        Me.tp_datosPedido.Location = New System.Drawing.Point(4, 24)
        Me.tp_datosPedido.Name = "tp_datosPedido"
        Me.tp_datosPedido.Size = New System.Drawing.Size(642, 207)
        Me.tp_datosPedido.TabIndex = 0
        Me.tp_datosPedido.Text = "Datos del pedido"
        Me.tp_datosPedido.UseVisualStyleBackColor = True
        '
        'tp_indicadoresPedido
        '
        Me.tp_indicadoresPedido.AllowDrop = True
        Me.tp_indicadoresPedido.BackColor = System.Drawing.Color.White
        Me.tp_indicadoresPedido.Controls.Add(Me.Label39)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label44)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_mesMaxCompra)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_maxCompra)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label40)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_promedioCompras)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label43)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_totalPedido)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label41)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_otrosPedidos)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label6)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label38)
        Me.tp_indicadoresPedido.Controls.Add(Me.GroupBox5)
        Me.tp_indicadoresPedido.Controls.Add(Me.GroupBox3)
        Me.tp_indicadoresPedido.Controls.Add(Me.GroupBox4)
        Me.tp_indicadoresPedido.Controls.Add(Me.lbl_ultimaFact)
        Me.tp_indicadoresPedido.Controls.Add(Me.Label37)
        Me.tp_indicadoresPedido.Location = New System.Drawing.Point(4, 24)
        Me.tp_indicadoresPedido.Name = "tp_indicadoresPedido"
        Me.tp_indicadoresPedido.Size = New System.Drawing.Size(642, 207)
        Me.tp_indicadoresPedido.TabIndex = 1
        Me.tp_indicadoresPedido.Text = "Indicadores del cliente"
        Me.tp_indicadoresPedido.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(423, 12)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(207, 16)
        Me.Label39.TabIndex = 10078
        Me.Label39.Text = "Todos los montos incluyen el IVA"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(487, 183)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(54, 16)
        Me.Label44.TabIndex = 10077
        Me.Label44.Text = "Monto:"
        '
        'lbl_mesMaxCompra
        '
        Me.lbl_mesMaxCompra.AutoSize = True
        Me.lbl_mesMaxCompra.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mesMaxCompra.Location = New System.Drawing.Point(440, 182)
        Me.lbl_mesMaxCompra.Name = "lbl_mesMaxCompra"
        Me.lbl_mesMaxCompra.Size = New System.Drawing.Size(46, 16)
        Me.lbl_mesMaxCompra.TabIndex = 10076
        Me.lbl_mesMaxCompra.Text = "06/12"
        Me.lbl_mesMaxCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_maxCompra
        '
        Me.lbl_maxCompra.AutoSize = True
        Me.lbl_maxCompra.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maxCompra.Location = New System.Drawing.Point(547, 183)
        Me.lbl_maxCompra.Name = "lbl_maxCompra"
        Me.lbl_maxCompra.Size = New System.Drawing.Size(78, 16)
        Me.lbl_maxCompra.TabIndex = 10075
        Me.lbl_maxCompra.Text = "###.###,00"
        Me.lbl_maxCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(327, 182)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(121, 16)
        Me.Label40.TabIndex = 10074
        Me.Label40.Text = "Max. compra, mes:"
        '
        'lbl_promedioCompras
        '
        Me.lbl_promedioCompras.AutoSize = True
        Me.lbl_promedioCompras.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_promedioCompras.Location = New System.Drawing.Point(547, 159)
        Me.lbl_promedioCompras.Name = "lbl_promedioCompras"
        Me.lbl_promedioCompras.Size = New System.Drawing.Size(78, 16)
        Me.lbl_promedioCompras.TabIndex = 10073
        Me.lbl_promedioCompras.Text = "###.###,00"
        Me.lbl_promedioCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(327, 160)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(232, 16)
        Me.Label43.TabIndex = 10072
        Me.Label43.Text = "Promedio compras mensuales:"
        '
        'lbl_totalPedido
        '
        Me.lbl_totalPedido.AutoSize = True
        Me.lbl_totalPedido.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPedido.Location = New System.Drawing.Point(157, 182)
        Me.lbl_totalPedido.Name = "lbl_totalPedido"
        Me.lbl_totalPedido.Size = New System.Drawing.Size(78, 16)
        Me.lbl_totalPedido.TabIndex = 10071
        Me.lbl_totalPedido.Text = "###.###,00"
        Me.lbl_totalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(10, 183)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(149, 16)
        Me.Label41.TabIndex = 10070
        Me.Label41.Text = "Total para este pedido:"
        '
        'lbl_otrosPedidos
        '
        Me.lbl_otrosPedidos.AutoSize = True
        Me.lbl_otrosPedidos.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_otrosPedidos.Location = New System.Drawing.Point(157, 160)
        Me.lbl_otrosPedidos.Name = "lbl_otrosPedidos"
        Me.lbl_otrosPedidos.Size = New System.Drawing.Size(78, 16)
        Me.lbl_otrosPedidos.TabIndex = 10069
        Me.lbl_otrosPedidos.Text = "###.###,00"
        Me.lbl_otrosPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 16)
        Me.Label6.TabIndex = 10068
        Me.Label6.Text = "Total otros pedidos:"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(198, 13)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(44, 16)
        Me.Label38.TabIndex = 10067
        Me.Label38.Text = "días"
        '
        'lbl_ultimaFact
        '
        Me.lbl_ultimaFact.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ultimaFact.Location = New System.Drawing.Point(157, 13)
        Me.lbl_ultimaFact.Name = "lbl_ultimaFact"
        Me.lbl_ultimaFact.Size = New System.Drawing.Size(35, 16)
        Me.lbl_ultimaFact.TabIndex = 10066
        Me.lbl_ultimaFact.Text = "#"
        Me.lbl_ultimaFact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(10, 13)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(166, 16)
        Me.Label37.TabIndex = 10065
        Me.Label37.Text = "Última facturación hace"
        '
        'Frm_Pedidos_Clientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 722)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.gb_productos_pedido)
        Me.Controls.Add(Me.lbl_detalles)
        Me.Controls.Add(Me.lbl_PF)
        Me.Controls.Add(Me.lbl_PorFacturar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.DGV_Pedidos)
        Me.Controls.Add(Me.tb_buscar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Chk_Exist)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.gb_inventario)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Pedidos_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Pedidos Cliente"
        CType(Me.SpVerTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_inventario.ResumeLayout(False)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consulta_Productos_PedidoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_productos_pedido.ResumeLayout(False)
        Me.gb_productos_pedido.PerformLayout()
        CType(Me.DGV_Productos_Pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductoGranSelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tp_datosPedido.ResumeLayout(False)
        Me.tp_datosPedido.PerformLayout()
        Me.tp_indicadoresPedido.ResumeLayout(False)
        Me.tp_indicadoresPedido.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim w As Boolean = True
    Dim ubicRow2() As Data.DataRow
    Dim listo As Boolean = False
    Public f17 As Frm_Compras
    Dim j As Boolean = True
    Dim wf As Boolean = True
    Dim jf As Boolean = True
    Dim ubicacion As String = ""
    Dim ubicacion2 As String = ""
    Dim cambio As Boolean = True
    Dim where2 As String = ""
    Dim where3 As String = ""
    Dim archivo As String = ""
    Public f34 As New Frm_Mult_Mod_Ubi
    Dim empezo As Boolean = False
    Dim roww As Integer = 0
    Private sw0 As Boolean = False
    Private sw As Boolean = False
    Dim tocar As Boolean = False
    Private sw1 As Boolean = False
    Private l As New Collection
    Dim l1 As New Collection
    Private lelim As New Collection
    Private item As Object
    Private cuantos As Integer
    Public eliminados As New DataTable
    Private fila As Integer
    Private boton As String = ""
    Private codigoPedido As Integer
    Private choice As Integer
    Private swC As Boolean = False
    Private indice As Integer = 0
    Private swX As Boolean = False
    Private ventana As New Collection
    Dim iva As Double
    Dim Varboton As Integer = 0
    Dim texto As String = ""
    Dim enter1 As Boolean = False
    Dim down As Boolean = False
    Dim up As Boolean = False
    Dim selected As Boolean = False
    Dim sel As Boolean = False
    Dim modificamonto As Double = 0
    Public l_user As String

    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_salir Then
            Varboton = 0
            If swC = True Then
                swC = False
            End If
            If swX Then
                swX = False
            End If
            If Not ventana.Count = 0 Then
                Dim f1 As New Frm_Principal
            End If
            Me.Close()
        ElseIf e.Button Is Me.bt_imprimir Then

            If chk_autorizado.Checked Then

                If DGV_Pedidos.SelectedRows.Count > 0 Then

                    If tb_obs.Text <> "" Or tb_obsInt.Text <> "" Then

                        Dim resp As Integer = MsgBox("El pedido tiene las siguientes observaciones:" + Environment.NewLine + Environment.NewLine + tb_obs.Text + Environment.NewLine + tb_obsInt.Text + Environment.NewLine + Environment.NewLine + "Desea continuar?", MsgBoxStyle.YesNo, "Confirmar")

                        If resp = vbYes Then
                            Varboton = 5
                            Dim frm As New Frm_Imprimir_Pedido_Cliente
                            frm.recibePedido(DGV_Pedidos.SelectedRows(0).Cells(0).Value, CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value), "", CDbl(tb_monto.Text), CDbl(lbl_Total.Text), CDbl(lbl_iva.Text), CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString), DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString, DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString, Tb_Direccion.Text, Tb_Tlf1.Text)
                            frm.Show()
                        End If

                    Else

                        Varboton = 5
                        Dim frm As New Frm_Imprimir_Pedido_Cliente
                        frm.recibePedido(DGV_Pedidos.SelectedRows(0).Cells(0).Value, CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value), "", CDbl(tb_monto.Text), CDbl(lbl_Total.Text), CDbl(lbl_iva.Text), CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString), DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString, DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString, Tb_Direccion.Text, Tb_Tlf1.Text)
                        frm.Show()

                    End If

                Else
                    MsgBox("Debe Seleccionar un pedido para imprimir", MsgBoxStyle.Exclamation, "Mensaje de Error")
                End If

            Else
                MsgBox("No puede imprimir la guía si el pedido no se encuentra autorizado para ello", MsgBoxStyle.Exclamation, "Mensaje de Error")


            End If

        ElseIf e.Button Is Me.bt_facturar Then
            Varboton = 4
            If Me.DGV_Pedidos.SelectedRows.Count = 1 Then
                If chk_autorizado.Checked Then
                    If chk_chequeado.Checked = True Then

                        If tb_obs.Text <> "" Or tb_obsInt.Text <> "" Then

                            Dim resp As Integer = MsgBox("El pedido tiene las siguientes observaciones:" + Environment.NewLine + Environment.NewLine + tb_obs.Text + Environment.NewLine + tb_obsInt.Text + Environment.NewLine + Environment.NewLine + "Desea continuar?", MsgBoxStyle.YesNo, "Confirmar")

                            If resp = vbYes Then
                                Dim f13 As New Frm_Facturas_Ventas
                                f13.recibe(cb_client.Text)
                                f13.permisosRecibos(wf, jf)
                                Me.Visible = False
                                f13.Show()
                                f13.tb_buscarcodigo.Enabled = False
                                f13.tb_imp.Enabled = True
                                f13.Cb_enviado.Visible = False
                                f13.tb_direccion.Text = Me.Tb_Direccion.Text
                                'f13.tb_imp.ReadOnly = False
                                f13.DGV_TodasLasFacturas.Enabled = False
                                f13.SpConsultaClienteFacturaBindingSource.Filter = "ControlInicio = -1"
                                f13.facturar(CInt(Me.tb_codigo.Text), Me, CInt(cb_client.Tag), Me.txt_finalVend.Text, tb_bultos.Text)
                                f13.tb_dias.Text = tb_dias.Text
                                f13.DGV_facturas.Columns(5).Visible = False
                                f13.cb_fev.Visible = False
                                f13.ToolBar1.Enabled = False
                                f13.Label10.Text = "1"
                                f13.l_facturador.Text = Frm_Login.user
                                f13.tb_ObsPedido.Text = Me.tb_obs.Text
                                f13.DGV_facturas.ClearSelection()
                                f13.bt_express.Visible = True
                                Me.cb_client.Enabled = False
                                Me.DateTimePicker1.Enabled = False
                                Me.bt_aceptar.Visible = False
                                Me.bt_cancelar.Visible = False
                                Me.DGV_Pedidos.Enabled = True
                                Me.ToolBar1.Enabled = True
                                If tocar = False Then
                                    tocar = True
                                    Me.cb_client.Text = ""
                                    tocar = False
                                Else
                                    Me.cb_client.Text = ""
                                End If
                                Me.tb_obs.Clear()
                                Me.txt_finalVend.Clear()
                                Me.tb_codigo.Text = ""
                                lbl_iva.Text = "0.00"
                                lbl_Total.Text = "0.00"
                                tb_monto.Text = "0.00"
                                DGV_Productos_Pedido.Rows.Clear()
                                Tb_Direccion.Clear()
                                Tb_Tlf1.Clear()
                                Tb_Tlf2.Clear()
                                tb_dias.Text = ""
                                DGV_Pedidos.ClearSelection()
                                Me.DateTimePicker1.Value = DateTime.Now
                                boton = ""
                                Me.DomainUpDown1.SelectedIndex = 0
                                Me.tb_buscar.Text = ""
                                DatosPedidoCliente.consulta_pedidosclientes(DGV_Pedidos, lbl_TotalP.Text)
                                Label2.Text = Me.DGV_Pedidos.RowCount
                            End If

                        Else

                            Dim f13 As New Frm_Facturas_Ventas
                            f13.recibe(cb_client.Text)
                            f13.permisosRecibos(wf, jf)
                            Me.Visible = False
                            f13.Show()
                            f13.tb_buscarcodigo.Enabled = False
                            f13.tb_imp.Enabled = True
                            f13.Cb_enviado.Visible = False
                            f13.tb_direccion.Text = Me.Tb_Direccion.Text
                            'f13.tb_imp.ReadOnly = False
                            f13.DGV_TodasLasFacturas.Enabled = False
                            f13.SpConsultaClienteFacturaBindingSource.Filter = "ControlInicio = -1"
                            f13.facturar(CInt(Me.tb_codigo.Text), Me, CInt(cb_client.Tag), Me.txt_finalVend.Text, tb_bultos.Text)
                            f13.tb_dias.Text = tb_dias.Text
                            f13.DGV_facturas.Columns(5).Visible = False
                            f13.cb_fev.Visible = False
                            f13.ToolBar1.Enabled = False
                            f13.Label10.Text = "1"
                            f13.l_facturador.Text = Frm_Login.user
                            f13.tb_ObsPedido.Text = Me.tb_obs.Text
                            f13.DGV_facturas.ClearSelection()
                            f13.bt_express.Visible = True
                            Me.cb_client.Enabled = False
                            Me.DateTimePicker1.Enabled = False
                            Me.bt_aceptar.Visible = False
                            Me.bt_cancelar.Visible = False
                            Me.DGV_Pedidos.Enabled = True
                            Me.ToolBar1.Enabled = True
                            If tocar = False Then
                                tocar = True
                                Me.cb_client.Text = ""
                                tocar = False
                            Else
                                Me.cb_client.Text = ""
                            End If
                            Me.tb_obs.Clear()
                            Me.txt_finalVend.Clear()
                            Me.tb_codigo.Text = ""
                            lbl_iva.Text = "0.00"
                            lbl_Total.Text = "0.00"
                            tb_monto.Text = "0.00"
                            DGV_Productos_Pedido.Rows.Clear()
                            Tb_Direccion.Clear()
                            Tb_Tlf1.Clear()
                            Tb_Tlf2.Clear()
                            tb_dias.Text = ""
                            DGV_Pedidos.ClearSelection()
                            Me.DateTimePicker1.Value = DateTime.Now
                            boton = ""
                            Me.DomainUpDown1.SelectedIndex = 0
                            Me.tb_buscar.Text = ""
                            DatosPedidoCliente.consulta_pedidosclientes(DGV_Pedidos, lbl_TotalP.Text)
                            Label2.Text = Me.DGV_Pedidos.RowCount

                        End If

                    Else
                        MsgBox("No se puede facturar si el pedido no se encuentra chequeado", MsgBoxStyle.Exclamation, "Mensaje de Error")
                    End If
                Else
                    MsgBox("No se puede facturar si el pedido no se encuentra autorizado para ello", MsgBoxStyle.Exclamation, "Mensaje de Error")
                End If


            ElseIf Me.DGV_Pedidos.SelectedRows.Count = 0 Then
                MsgBox("Debe Seleccionar un pedido para facturar", MsgBoxStyle.Exclamation, "Mensaje de Error")
            Else
                MsgBox("Sólo Puede Facturar un pedido a la vez", MsgBoxStyle.Exclamation, "Mensaje de Error")

            End If
        ElseIf e.Button Is Me.bt_nuevo Then
            Varboton = 1
            Panel3.Enabled = False

            Label5.Visible = False
            tb_codigo.Visible = False

            lbl_PorFacturar.Visible = True
            lbl_PF.Visible = True
            lbl_detalles.Visible = True
            Chk_Exist.Visible = True

            txt_finalVend.Enabled = True

            lbl_totalPagado.Text = "0,00"
            lbl_maxPagado.Text = "0"
            lbl_promedioPagado.Text = "0"

            lbl_totalPendiente.Text = "0,00"
            lbl_maxPendiente.Text = "0"
            lbl_promedioPendiente.Text = "0"

            lbl_totalVencido.Text = "0,00"
            lbl_maxVencido.Text = "0"
            lbl_promedioVencido.Text = "0"

            tb_obsInt.Clear()

            Me.DomainUpDown1.Items.RemoveAt(0)
            Me.DomainUpDown1.Items.RemoveAt(0)
            Me.DomainUpDown1.Items.RemoveAt(0)
            Me.DomainUpDown1.Items.RemoveAt(0)
            Me.DomainUpDown1.Items.Add("Código Producto")
            Me.DomainUpDown1.Items.Add("Descripción")
            Me.DomainUpDown1.Items.Add("Modelo")
            Me.DomainUpDown1.Items.Add("Código Fábrica")
            DateTimePicker1.Value = Today
            DGV_Productos_Pedido.AllowUserToDeleteRows = True
            chk_autorizado.Checked = False
            Me.chk_chequeado.Visible = False
            Me.chk_autorizado.Visible = False
            tb_obsInt.ReadOnly = True
            txt_finalVend.Clear()
            Me.tb_obs.Clear()
            tb_contacto.Clear()
            cb_modalidadEnvio.Enabled = True
            cb_modalidadEnvio.SelectedValue = 0

            boton = "n"
            Label1.Visible = True
            lb_total.Visible = True
            Label1.BringToFront()
            lb_total.BringToFront()
            tb_obs.ReadOnly = False
            tb_obsInt.ReadOnly = False
            DatosPedidoCliente.consulta_DiasCred(tb_dias)
            tb_dias.SelectedIndex = 1
            lb_total.Text = "0"
            Me.tb_dias.Enabled = True
            If Not rb_pendientes.Checked Then
                DGV_Pedidos.ClearSelection()
            End If
            Me.DGV_Productos_Pedido.Rows.Clear()
            Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)

            Me.DGV_Productos_Pedido.Enabled = True
            'Me.cb_client.Items.Clear()
            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario
            Me.Sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, 1)
            Me.SpconsultaClienteBindingSource.RemoveFilter()
            lb_client.Visible = True

            Me.cb_client.Text = ""
            Me.tb_monto.ResetText()
            tb_bultos.Clear()
            tb_bultos.ReadOnly = False
            tb_dias.Text = ""
            Tb_Tlf1.Clear()
            Tb_Tlf2.Clear()
            Tb_Direccion.Clear()
            Me.ToolBar1.Enabled = False
            Me.DGV_Pedidos.Enabled = False
            Me.cb_client.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.bt_aceptar.Visible = True
            Me.tb_usuario.Text = l_user
            lbl_iva.Text = "0.00"
            lbl_Total.Text = "0.00"
            tb_monto.Text = "0.00"
            Me.bt_cancelar.Visible = True
            Chk_Exist.Checked = True
            DatosPedidoCliente.consulta_identidadPedido(Me.tb_codigo.Text)
            RemoveHandler tb_buscar.TextChanged, AddressOf tb_buscar_TextChanged
            AddHandler tb_buscar.TextChanged, AddressOf tb_buscar_TextChanged
            DGV_Productos_Pedido.Height = 185
            gb_productos_pedido.Height = 216
            lbl_Inventario.Visible = True
            gb_productos_pedido.Location = New System.Drawing.Point(376, 455)
            gb_productos_pedido.Controls.Add(DGV_Productos_Pedido)
            DGV_Productos_Pedido.Location = New System.Drawing.Point(5, 27)
            DGV_Productos_Pedido.Visible = True
            DGV_Productos_Pedido.BringToFront()
            lbl_Inventario.BringToFront()
            gb_inventario.Visible = True
            If Not rb_pendientes.Checked Then
                tb_buscar.Enabled = False
                Me.DGV2.Visible = True
                Me.DomainUpDown1.SelectedIndex = 0
                DGV2.Columns(0).ReadOnly = Label17.Visible
                DGV2.ClearSelection()
                lbl_PorFacturar.Text = "0"
            End If

            If tocar = True Then
                tocar = False
                'DatosPedidoCliente.consulta_cliente(cb_client)
                cb_client.Focus()
                tocar = True
            Else
                'DatosPedidoCliente.consulta_cliente(cb_client)
                If Not rb_pendientes.Checked Then
                    cb_client.Focus()
                End If
            End If

            'TabControl1.Enabled = True

            CrearWhere()

            tb_buscar.Enabled = True
            'cb_client.DropDownHeight = 110
            Me.DGV2.Visible = True
        ElseIf e.Button Is Me.bt_modificar Then
            Varboton = 2
            If rb_pendientes.Checked = False Then

                Dim n As Integer
                n = Me.DGV_Pedidos.SelectedRows.Count
                If n = 1 Then
                    boton = "m"
                    'TabControl1.Enabled = True
                    lbl_PorFacturar.Visible = True
                    lbl_PF.Visible = True
                    lbl_detalles.Visible = True
                    Chk_Exist.Visible = True

                    Me.tb_dias.Enabled = True
                    Me.DGV2.Visible = True

                    Me.tb_obsInt.ReadOnly = False

                    txt_finalVend.Enabled = True
                    Me.DGV_Productos_Pedido.Enabled = True
                    DGV_Productos_Pedido.ClearSelection()
                    Me.ToolBar1.Enabled = False
                    Panel3.Enabled = False
                    Me.cb_client.Enabled = True
                    Me.DateTimePicker1.Enabled = True
                    Me.bt_aceptar.Visible = True
                    chk_autorizado.Visible = False
                    cb_modalidadEnvio.Enabled = True
                    Me.chk_chequeado.Visible = True
                    tb_bultos.ReadOnly = False
                    Me.chk_chequeado.Enabled = True
                    DGV_Productos_Pedido.Height = 189
                    gb_productos_pedido.Height = 221
                    'bt_aceptar.Location = New System.Drawing.Point(636, 672)
                    'bt_cancelar.Location = New System.Drawing.Point(725, 672)
                    'ToolBar1.Location = New System.Drawing.Point(3, 9)
                    Me.bt_cancelar.Visible = True
                    Label1.Visible = True
                    lb_total.Visible = True
                    Label1.BringToFront()
                    lb_total.BringToFront()
                    Me.DGV_Pedidos.Enabled = False
                    DomainUpDown1.Items.Clear()
                    DGV_Productos_Pedido.Height = 189
                    gb_productos_pedido.Location = New System.Drawing.Point(376, 445)
                    gb_productos_pedido.Controls.Add(DGV_Productos_Pedido)
                    DGV_Productos_Pedido.Location = New System.Drawing.Point(5, 27)
                    DGV_Productos_Pedido.Visible = True
                    DGV_Productos_Pedido.BringToFront()
                    lbl_Inventario.BringToFront()
                    gb_inventario.Visible = True
                    Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)
                    lbl_Inventario.Visible = True
                    DomainUpDown1.Items.Add("Código Producto")
                    DomainUpDown1.Items.Add("Descripción")
                    DomainUpDown1.Items.Add("Modelo")
                    Me.DomainUpDown1.Items.Add("Código Fábrica")
                    Me.DomainUpDown1.SelectedIndex = 0
                    RemoveHandler tb_buscar.TextChanged, AddressOf tb_buscar_TextChanged
                    Me.tb_buscar.Clear()
                    AddHandler tb_buscar.TextChanged, AddressOf tb_buscar_TextChanged
                    'DatosPedidoCliente.consulta_productos2(DGV2, "", 0)
                    CrearWhere()
                    Chk_Exist.Checked = True
                    'eliminarRepetidos()
                    'Chk_Exist.Enabled = True
                    'Chk_Exist.Checked = False
                    DGV_Productos_Pedido.AllowUserToDeleteRows = True
                    'Chk_Exist.Checked = True
                    'Chk_Exist.Visible = True
                    Chk_Exist.BringToFront()
                    DGV2.ClearSelection()
                    tb_obs.ReadOnly = False
                    'tb_obs.Focus()
                    DGV2.Columns(0).ReadOnly = Label17.Visible
                    'lb_client_MouseClick(lb_client, New EventArgs)
                    tb_obs.Focus()
                    tb_obs.SelectAll()
                    Me.modificamonto = CDbl(Me.lb_total.Text)
                ElseIf n = 0 Then
                    MsgBox("Debe seleccionar el pedido que desea modificar", MsgBoxStyle.Exclamation, "Mensaje de Error")
                Else
                    MsgBox("Sólo puede modificar un producto a la vez", MsgBoxStyle.Exclamation, "Mensaje de Error")
                End If

            Else

                MsgBox("No puede modificar un pedido no registrado", MsgBoxStyle.Exclamation, "SINPRO")

            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            Varboton = 3
            Dim npedido As Integer

            Dim response As MsgBoxResult
            npedido = Me.DGV_Pedidos.SelectedRows.Count

            If npedido = 0 Then
                MsgBox("Debe seleccionar el pedido que desea eliminar ", MsgBoxStyle.Exclamation, "Mensaje de Error")
            Else
                If npedido = 1 Then
                    response = MsgBox("¿Confirma que desea eliminar el pedido '" + CStr(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value) + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                    If (response = MsgBoxResult.Yes) Then

                        If rb_cargados.Checked Then

                            For cont As Integer = 0 To DGV_Productos_Pedido.RowCount - 1

                                DatosPedidoCliente.AumentaExist(DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString, CInt(DGV_Productos_Pedido.Rows(cont).Cells(0).Value.ToString))
                                DatosPedidoCliente.AumentaExist2(DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString, DatosPedidoCliente.Tramo(DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString, CInt(DGV_Productos_Pedido.Rows(cont).Cells(8).Value.ToString)), CInt(DGV_Productos_Pedido.Rows(cont).Cells(0).Value.ToString))

                            Next

                            DatosPedidoCliente.elimina_pedidocliente(CInt(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value))
                            Datos.Inserta_Actividad("Eliminó el pedido procesado nro. " + Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)

                        ElseIf rb_pendientes.Checked Then

                            DatosPedidoCliente.elimina_pedidoclienteNP(CInt(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value))
                            Datos.Inserta_Actividad("Eliminó el pedido no procesado nro. " + Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)

                        End If

                        Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Pedido '" + CStr(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value) + "' Ha Sido Eliminado Exitosamente", ToolTipIcon.Info)

                        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                            DatosPedidoCliente.Consulta_totales_pedidos(lbl_pedPro.Text, lbl_clienPro.Text, lbl_pedNoPro.Text, lbl_clienNoPro.Text)
                        End If

                        Me.Sp_consultaProducto_GranSelectTableAdapter.Fill(Me.MELDataSet.sp_consultaProducto_GranSelect)
                        Me.txt_finalVend.Clear()
                        Me.DateTimePicker1.Enabled = False
                        Me.bt_aceptar.Visible = False
                        Me.bt_cancelar.Visible = False
                        Me.DGV_Pedidos.Enabled = True
                        Me.ToolBar1.Enabled = True
                        Me.DGV_Pedidos.Enabled = True
                        If tocar = False Then
                            tocar = True
                            Me.cb_client.Enabled = False
                            Me.cb_client.Text = ""
                            tocar = False
                        Else
                            Me.cb_client.Enabled = False
                            Me.cb_client.Text = ""
                        End If

                        Tb_Tlf1.Clear()
                        Tb_Tlf2.Clear()
                        Tb_Direccion.Clear()
                        tb_obs.Clear()
                        tb_bultos.Clear()
                        tb_dias.ResetText()
                        lb_total.Text = "0"
                        Me.tb_codigo.Text = ""
                        Me.DateTimePicker1.Value = DateTime.Now
                        Me.DGV_Productos_Pedido.Rows.Clear()
                        Label2.Text = Me.DGV_Pedidos.RowCount
                        boton = ""
                        Me.DomainUpDown1.SelectedIndex = 0
                        Me.tb_buscar.Text = ""

                        If rb_cargados.Checked Then
                            DatosPedidoCliente.consulta_pedidosclientes(DGV_Pedidos, lbl_TotalP.Text)
                        Else
                            DatosPedidoCliente.consulta_pedidosclientesNP(DGV_Pedidos, lbl_TotalP.Text)
                        End If

                        rb_cargados_CheckedChanged(rb_pendientes, New EventArgs)

                        DGV_Pedidos.ClearSelection()

                    End If
                End If
            End If
        ElseIf e.Button Is Me.bt_autorizar Then

            If DGV_Pedidos.SelectedRows.Count > 0 Then

                If Label17.Visible Then

                    MsgBox("No puede autorizar el pedido si el cliente está bloqueado", MsgBoxStyle.Critical, "SINPRO")

                Else

                    If chk_autorizado.Checked = True Then

                        DatosPedidoCliente.Autoriza_Pedidocliente(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), False)
                        chk_autorizado.Checked = False
                        Datos.Inserta_Actividad("Desautorizó el pedido nro. " + tb_codigo.Text + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)
                        Frm_Principal.NotifyIcon1.ShowBalloonTip(3000, "SINPRO", "Pedido no autorizado", ToolTipIcon.Info)
                        DGV_Pedidos.SelectedRows(0).Cells(4).Value = "No"

                    ElseIf chk_autorizado.Checked = False Then

                        Dim Frm As New Frm_AutorizarPedido
                        Frm.recibe(CInt(tb_codigo.Text), Me, CInt(cb_client.Tag), cb_client.Text, CInt(cb_client.Tag))
                        Frm.Show()

                    End If

                End If

            Else

                DGV_Pedidos_CellClick(DGV_Pedidos, New EventArgs)
                MsgBox("Debe seleccionar un pedido para autorizar su facturación", MsgBoxStyle.Exclamation, "SINPRO")

            End If
        End If
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'MELDataSet.sp_VerTransporte' table. You can move, or remove it, as needed.
        Me.Sp_VerTransporteTableAdapter.Fill(Me.MELDataSet.sp_VerTransporte)

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Try

            MELDataSet.EnforceConstraints = False
            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consultaCliente' Puede moverla o quitarla según sea necesario
            Me.Sp_consultaClienteTableAdapter.Fill(Me.MELDataSet.sp_consultaCliente, 1)
            'TODO: This line of code loads data into the 'MELDataSet.Tbl_Vendedor' table. You can move, or remove it, as needed.
            Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor, 0)
            'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_Productos_PedidoCliente' table. You can move, or remove it, as needed.
            Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)

        Catch ex As Exception

        End Try

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then

            Label2.Visible = False
            Label7.Visible = False
            Label30.Visible = False
            lbl_TotalP.Visible = False
            Panel5.Visible = True
            Panel4.Visible = False

            DatosPedidoCliente.Consulta_totales_pedidos(lbl_pedPro.Text, lbl_clienPro.Text, lbl_pedNoPro.Text, lbl_clienNoPro.Text)

        Else

            cb_modalidadEnvio.Visible = False
            Panel5.Visible = False
            Panel4.Visible = True

        End If

        'TabControl1.Enabled = False

        Me.DGV2.ReadOnly = False
        Me.DGV2.Columns(0).Width = 45
        Me.DGV2.Columns(0).ReadOnly = False
        Me.DGV2.Columns(1).HeaderText = "Codigo"
        Me.DGV2.Columns(1).Width = 85
        Me.DGV2.Columns(1).ReadOnly = True
        Me.DGV2.Columns(2).HeaderText = "Descripción"
        Me.DGV2.Columns(2).Width = 185
        Me.DGV2.Columns(2).ReadOnly = True
        Me.DGV2.Columns(3).HeaderText = "Modelo"
        Me.DGV2.Columns(3).Width = 105
        Me.DGV2.Columns(3).ReadOnly = True
        Me.DGV2.Columns(4).HeaderText = "Exist."
        Me.DGV2.Columns(4).Width = 50
        Me.DGV2.Columns(4).ReadOnly = True
        Me.DGV2.Columns(5).HeaderText = "Precio"
        Me.DGV2.Columns(5).Width = 55
        Me.DGV2.Columns(5).ReadOnly = True
        Me.DGV2.Columns(5).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DGV2.Columns(5).DefaultCellStyle.Format = "#,##0.00"
        Me.DGV2.Columns(6).HeaderText = "Ubicación"
        Me.DGV2.Columns(6).Width = 90
        Me.DGV2.Columns(6).ReadOnly = True
        Me.DGV2.Columns(7).HeaderText = "CodigoTramo"
        Me.DGV2.Columns(7).Visible = False
        Me.DGV2.Columns(7).ReadOnly = True
        Me.DGV2.Columns(8).Visible = False
        Me.DGV2.Columns(9).Visible = False
        DatosPedidoCliente.consulta_DiasCred(tb_dias)
        DGV_Pedidos.ClearSelection()
        gb_inventario.Visible = False
        MELDataSet.EnforceConstraints = False
        Me.DateTimePicker1.Enabled = False
        Me.bt_aceptar.Visible = False
        DGV2.MultiSelect = False
        Me.bt_cancelar.Visible = False
        Me.DGV_Pedidos.Enabled = True
        gb_inventario.Visible = False
        DatosPedidoCliente.consulta_pedidosclientes(Me.DGV_Pedidos, lbl_TotalP.Text)
        Label2.Text = DGV_Pedidos.RowCount
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código Pedido")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.Items.Add("Código Cliente")
        Me.DomainUpDown1.Items.Add("Zona")

        eliminados.Columns.Add("Cantidad")
        eliminados.Columns.Add("Codigo")
        eliminados.Columns.Add("Descripcion")
        eliminados.Columns.Add("Modelo")
        eliminados.Columns.Add("Exist")
        eliminados.Columns.Add("Precio")
        eliminados.Columns.Add("Ubi")
        eliminados.Columns.Add("Tramo")
        eliminados.Columns.Add("Esta")


        Me.DomainUpDown1.SelectedIndex = 0

        DGV_Pedidos.ClearSelection()
        DatosPedidoCliente.Retorna_Iva(iva)
        Me.empezo = True

        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
            Me.bt_facturar.Visible = False
            Me.Panel3.Visible = False
        End If

        If j = False Then
            Me.bt_autorizar.Visible = False
            LinkLabel1.Visible = False
        End If

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        j = e1
    End Sub
    Public Sub permisosFac(ByVal wf1 As Boolean, ByVal ef1 As Boolean)
        wf = wf1
        jf = ef1
    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

            If Me.cb_client.Text = "" Or Me.txt_finalVend.Tag Is Nothing Or tb_dias.Text = "" Or cb_modalidadEnvio.SelectedValue = 0 Or cb_modalidadEnvio.SelectedIndex = -1 Then
                ll = True
            Else
                ll = False
            End If

        Else

            If Me.cb_client.Text = "" Or Me.txt_finalVend.Tag Is Nothing Or tb_dias.Text = "" Then
                ll = True
            Else
                ll = False
            End If

        End If

        Return ll

    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim deny As Boolean = False
        If llenos() Then
            MsgBox("Debe ingresar todos los datos requeridos (*)")
            deny = True
        End If
        If deny = False Then
            If boton = "m" Then
                If Me.DGV_Productos_Pedido.Rows.Count = 0 Then
                    MsgBox("El pedido no se modificará porque no puede quedar sin productos asociados. Elimine el pedido completo.")
                    deny = True
                Else
                    For cont2 As Integer = 0 To DGV_Productos_Pedido.RowCount - 1
                        If DGV_Productos_Pedido.Rows(cont2).Cells(9).Value = True Then
                            DatosPedidoCliente.AumentaExist(DGV_Productos_Pedido.Rows(cont2).Cells(1).Value.ToString, CInt(DGV_Productos_Pedido.Rows(cont2).Cells(0).Value.ToString))
                            DatosPedidoCliente.AumentaExist2(DGV_Productos_Pedido.Rows(cont2).Cells(1).Value.ToString, DatosPedidoCliente.Tramo(DGV_Productos_Pedido.Rows(cont2).Cells(1).Value.ToString, CInt(DGV_Productos_Pedido.Rows(cont2).Cells(8).Value.ToString)), CInt(DGV_Productos_Pedido.Rows(cont2).Cells(0).Value.ToString))
                        End If
                    Next

                    For cont2 As Integer = 0 To eliminados.Rows.Count - 1
                        If CBool(eliminados.Rows(cont2).Item(8)) = True Then
                            DatosPedidoCliente.AumentaExist(eliminados.Rows(cont2).Item(1).ToString, CInt(eliminados.Rows(cont2).Item(0)))
                            DatosPedidoCliente.AumentaExist2(eliminados.Rows(cont2).Item(1).ToString, DatosPedidoCliente.Tramo(eliminados.Rows(cont2).Item(1).ToString, eliminados.Rows(cont2).Item(7).ToString), CInt(eliminados.Rows(cont2).Item(0)))
                        End If
                    Next

                    DatosPedidoCliente.elimina_producto_pedido3(codigoPedido)

                    Dim i As Integer = 0

                    While i < Me.DGV_Productos_Pedido.Rows.Count
                        DatosPedidoCliente.insertar_producto_pedido(CInt(Me.tb_codigo.Text), Me.DGV_Productos_Pedido(1, i).Value, Me.DGV_Productos_Pedido(0, i).Value, Me.DGV_Productos_Pedido(5, i).Value, Me.DGV_Productos_Pedido(3, i).Value, CInt(Me.DGV_Productos_Pedido(8, i).Value), boton)
                        i = i + 1
                    End While
                    Dim autoriza As Boolean = False

                    If DatosPedidoCliente.Autorizado(CDbl(tb_monto.Text), CInt(cb_client.Tag)) = False Then
                        If modificamonto = CDbl(lb_total.Text) Then
                            autoriza = chk_autorizado.Checked
                        Else
                            autoriza = False
                        End If

                    Else
                        autoriza = True
                    End If

                    If tb_bultos.Text <> "" Then
                        DatosPedidoCliente.modifica_pedidocliente(CInt(Me.tb_codigo.Text), Me.DateTimePicker1.Value, CInt(cb_client.Tag), CDbl(Me.tb_monto.Text), Me.txt_finalVend.Tag, tb_dias.Text, tb_obs.Text, chk_chequeado, autoriza, CInt(tb_bultos.Text), tb_obsInt.Text, cb_modalidadEnvio.SelectedValue)
                    Else
                        DatosPedidoCliente.modifica_pedidocliente(CInt(Me.tb_codigo.Text), Me.DateTimePicker1.Value, CInt(cb_client.Tag), CDbl(Me.tb_monto.Text), Me.txt_finalVend.Tag, tb_dias.Text, tb_obs.Text, chk_chequeado, autoriza, 0, tb_obsInt.Text, cb_modalidadEnvio.SelectedValue)
                    End If

                    Datos.Inserta_Actividad("Modificó el pedido nro. " + tb_codigo.Text + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)

                    MsgBox("El Pedido del Cliente Ha Sido Modificado Exitosamente", MsgBoxStyle.Information, "Mensaje de confirmación")

                    deny = False
                End If
            Else
                If DGV_Productos_Pedido.RowCount > 0 Then

                    DatosPedidoCliente.consulta_identidadPedido(Me.tb_codigo.Text)

                    Dim max As Integer = DatosPedidoCliente.MaxArt
                    Dim nro_pedidos As Integer = 0
                    'Dim nro_pedidos2 As Double = 0

                    If DGV_Productos_Pedido.RowCount > max Then
                        nro_pedidos = CInt(0.5 + (DGV_Productos_Pedido.RowCount / max))
                    Else
                        nro_pedidos = 1
                    End If

                    Dim row As Integer = 0
                    If tb_bultos.Text <> "" Then
                        DatosPedidoCliente.inserta_pedidocliente(Me.DateTimePicker1.Value, CInt(cb_client.Tag), CDbl(Me.tb_monto.Text), False, Me.txt_finalVend.Tag, tb_dias.Text, tb_obs.Text, DatosPedidoCliente.Autorizado(CDbl(tb_monto.Text), CInt(cb_client.Tag)), CInt(tb_bultos.Text), nro_pedidos, tb_obsInt.Text, tb_usuario.Text, cb_modalidadEnvio.SelectedValue)
                    Else
                        DatosPedidoCliente.inserta_pedidocliente(Me.DateTimePicker1.Value, CInt(cb_client.Tag), CDbl(Me.tb_monto.Text), False, Me.txt_finalVend.Tag, tb_dias.Text, tb_obs.Text, DatosPedidoCliente.Autorizado(CDbl(tb_monto.Text), CInt(cb_client.Tag)), 0, nro_pedidos, tb_obsInt.Text, tb_usuario.Text, cb_modalidadEnvio.SelectedValue)
                    End If


                    'Envío de email
                    Dim usuarios As Boolean = False
                    Dim vendedores As Boolean = False
                    Dim clientes As Boolean = False
                    Dim categoria As Integer = 2
                    Dim sub_categoria As Integer = 4

                    DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)


                    Dim rowp As Integer = 0
                    Dim i As Integer = 0

                    While i < nro_pedidos

                        If (vendedores Or clientes) Then
                            DatosCorreos.Crear_Correo(sub_categoria, CInt(Me.tb_codigo.Text) + i)
                        End If

                        row = 0

                        While (row < max) And (rowp < Me.DGV_Productos_Pedido.Rows.Count)
                            DatosPedidoCliente.insertar_producto_pedido(CInt(Me.tb_codigo.Text) + i, Me.DGV_Productos_Pedido(1, rowp).Value, Me.DGV_Productos_Pedido(0, rowp).Value, Me.DGV_Productos_Pedido(5, rowp).Value, Me.DGV_Productos_Pedido(3, rowp).Value, CInt(Me.DGV_Productos_Pedido(8, rowp).Value), boton)
                            rowp = rowp + 1
                            row = row + 1
                        End While

                        DatosPedidoCliente.actualizar_monto_pedido(CInt(Me.tb_codigo.Text) + i)
                        i = i + 1

                    End While
                    'End If

                    If boton = "p" Then
                        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 Then
                            DatosPedidoCliente.Procesar_Pedido_NP(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value))
                            DatosPedidoCliente.Eliminar_Pedidos_NP_Viejos()
                            Datos.Inserta_Actividad("Procesó el pedido nro. " + DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)
                        End If
                    End If

                    i = 0

                    While i < nro_pedidos
                        Datos.Inserta_Actividad("Creo el pedido nro. " + (CInt(Me.tb_codigo.Text) + i).ToString + " del cliente (" + cb_client.Tag.ToString + ") " + cb_client.Text)
                        i = i + 1
                    End While

                    MsgBox("El Pedido del Cliente Ha Sido Registrado Exitosamente", MsgBoxStyle.Information, "Mensaje de confirmación")

                    deny = False
                Else
                    MsgBox("No puede insertar un pedido vacío", MsgBoxStyle.Information, "Error")
                    deny = True
                End If
            End If

            If deny = False Then
                Me.cb_client.Text = ""
                Me.tb_dias.Items.Clear()
                DatosPedidoCliente.consulta_DiasCred(tb_dias)
                Me.cb_client.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Me.bt_aceptar.Visible = False
                Me.tb_dias.Enabled = False
                Me.bt_cancelar.Visible = False
                lb_total.Text = "0"
                Me.DGV_Pedidos.Enabled = True
                tb_usuario.Clear()
                cb_modalidadEnvio.Enabled = False

                tb_obsInt.ReadOnly = True
                tb_obsInt.Clear()

                Me.ToolBar1.Enabled = True
                Me.bt_nuevo.Enabled = rb_cargados.Checked
                Me.bt_modificar.Enabled = rb_cargados.Checked
                Me.bt_imprimir.Enabled = rb_cargados.Checked
                Me.bt_autorizar.Enabled = rb_cargados.Checked
                Me.bt_facturar.Enabled = rb_cargados.Checked

                Me.DGV_Pedidos.Enabled = True
                Me.tb_codigo.Text = ""
                Me.eliminados.Rows.Clear()
                tb_contacto.Clear()
                Me.tb_monto.ResetText()
                Me.chk_chequeado.Enabled = False
                Label5.Visible = True
                tb_codigo.Visible = True
                lbl_PorFacturar.Visible = False
                lbl_PF.Visible = False
                lbl_detalles.Visible = False
                Chk_Exist.Visible = False
                Me.chk_chequeado.Visible = True
                Panel3.Enabled = True
                Me.chk_chequeado.Checked = False
                tb_bultos.Clear()
                tb_bultos.ReadOnly = True
                tb_obs.ReadOnly = True
                Me.chk_autorizado.Visible = True
                Tb_Tlf1.Clear()
                Tb_Tlf2.Clear()
                txt_finalVend.Clear()
                txt_finalVend.Enabled = False
                Tb_Direccion.Clear()
                gb_inventario.Visible = False
                DGV_Productos_Pedido.Height = 388
                gb_productos_pedido.Height = 422
                lbl_Pedido.Location = New System.Drawing.Point(0, 3)
                lbl_Pedido.Visible = True
                lbl_Inventario.Visible = False
                lbl_Pedido.BringToFront()
                lbl_Total.BringToFront()
                gb_productos_pedido.Location = New System.Drawing.Point(375, 244)
                gb_productos_pedido.Controls.Add(DGV_Productos_Pedido)
                DGV_Productos_Pedido.Location = New System.Drawing.Point(5, 27)
                DGV_Productos_Pedido.Visible = True
                DGV_Productos_Pedido.BringToFront()
                Label1.BringToFront()
                lb_total.BringToFront()
                Me.DateTimePicker1.Value = DateTime.Now
                DomainUpDown1.Items.Clear()
                Me.DomainUpDown1.Items.Add("Código Pedido")
                Me.DomainUpDown1.Items.Add("Nombre")
                Me.DomainUpDown1.Items.Add("Código Cliente")
                Me.DomainUpDown1.Items.Add("Zona")
                tb_obs.Clear()
                Me.DomainUpDown1.SelectedIndex = 0
                Me.DGV_Productos_Pedido.Rows.Clear()
                chk_autorizado.Checked = False
                Label2.Text = Me.DGV_Pedidos.RowCount
                lb_client.Visible = False
                Me.DGV2.Visible = False
                DGV_Pedidos.ClearSelection()
                Varboton = 0
                Label17.Visible = False
                If boton = "m" Then

                    If Me.tb_buscar.Text <> "" Then

                        tb_buscar_TextChanged(tb_buscar, New EventArgs)

                    End If
                Else

                    Me.tb_buscar.Text = ""

                End If

                If boton = "p" Then

                    If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                        If rb_pendientes.Checked Then
                            tb_buscar.Enabled = False
                        End If

                        Try
                            My.Computer.FileSystem.MoveFile(ubicacion2, ubicacion2.Replace(ubicacion, "\\SERVER\Pedidos Online\Cargados\"))
                        Catch ex As Exception
                            MsgBox("Error moviendo los pedidos pendientes", MsgBoxStyle.Critical, "Error")
                        End Try

                        Try
                            LeerArchivos()
                            DGV_Pedidos.Sort(DGV_Pedidos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
                            DGV_Pedidos.ClearSelection()
                        Catch ex As Exception
                            MsgBox("Error leyendo los pedidos pendientes", MsgBoxStyle.Critical, "Error")
                        End Try

                    End If

                    DatosPedidoCliente.consulta_pedidosclientesNP(Me.DGV_Pedidos, lbl_TotalP.Text)

                Else

                    DatosPedidoCliente.consulta_pedidosclientes(Me.DGV_Pedidos, lbl_TotalP.Text)

                End If

                rb_cargados_CheckedChanged(rb_pendientes, New EventArgs)
                Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then
                    DatosPedidoCliente.Consulta_totales_pedidos(lbl_pedPro.Text, lbl_clienPro.Text, lbl_pedNoPro.Text, lbl_clienNoPro.Text)

                    'If rb_cargados.Checked Then
                    '    TabControl1.SelectedIndex = 0
                    '    TabControl1.TabPages.Remove(tp_indicadoresPedido)
                    '    TabControl1.Refresh()
                    'End If

                End If

                boton = ""
                tb_buscar.Focus()
                tb_buscar.SelectAll()
            End If
        End If
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Tb_Tlf1.Clear()
        Tb_Tlf2.Clear()
        Tb_Direccion.Clear()
        tb_contacto.Clear()

        tb_dias.Text = ""
        Me.DGV_Productos_Pedido.Rows.Clear()
        Me.cb_client.Text = ""
        Me.tb_obsInt.ReadOnly = True

        tb_obsInt.Clear()
        Me.tb_dias.Items.Clear()
        DatosPedidoCliente.consulta_DiasCred(tb_dias)
        Me.cb_client.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.bt_aceptar.Visible = False
        tb_usuario.Clear()
        tb_bultos.Clear()
        tb_bultos.ReadOnly = True
        Me.bt_cancelar.Visible = False
        gb_inventario.Visible = False
        DGV_Productos_Pedido.Height = 388
        Panel3.Enabled = True
        lb_total.Text = "0"
        Me.ListBox2.Visible = False
        DGV2.ReadOnly = False
        Label5.Visible = True
        tb_codigo.Visible = True
        txt_finalVend.Clear()
        txt_finalVend.Enabled = False
        gb_productos_pedido.Height = 422
        gb_productos_pedido.Location = New System.Drawing.Point(375, 244)
        gb_productos_pedido.Controls.Add(DGV_Productos_Pedido)
        lbl_PorFacturar.Visible = False
        lbl_PF.Visible = False
        lbl_detalles.Visible = False
        Chk_Exist.Visible = False
        DGV_Productos_Pedido.Location = New System.Drawing.Point(5, 27)
        DGV_Productos_Pedido.Visible = True
        DGV_Productos_Pedido.BringToFront()
        lbl_Pedido.BringToFront()
        lbl_Pedido.Location = New System.Drawing.Point(0, 3)
        lbl_Pedido.Visible = True
        lbl_Inventario.Visible = False
        lbl_Pedido.BringToFront()
        lbl_Total.BringToFront()
        Label1.BringToFront()
        cb_modalidadEnvio.Enabled = False
        lbl_PorFacturar.Visible = False
        lbl_PF.Visible = False
        lbl_detalles.Visible = False
        lb_client.Visible = False
        Me.chk_autorizado.Visible = True
        Me.tb_dias.Enabled = False
        Me.DGV_Pedidos.Enabled = True
        Me.ToolBar1.Enabled = True
        Me.bt_nuevo.Enabled = rb_cargados.Checked
        Me.bt_modificar.Enabled = rb_cargados.Checked
        Me.bt_imprimir.Enabled = rb_cargados.Checked
        Me.bt_autorizar.Enabled = rb_cargados.Checked
        Me.bt_facturar.Enabled = rb_cargados.Checked
        Me.tb_codigo.Text = ""
        tb_obs.ReadOnly = True
        Me.tb_monto.ResetText()
        Me.DateTimePicker1.Value = DateTime.Now
        Me.chk_chequeado.Enabled = False
        Me.chk_chequeado.Visible = True
        Me.chk_chequeado.Checked = False
        chk_autorizado.Checked = False
        Me.tb_buscar.Clear()
        Me.DGV2.Visible = False
        tb_obs.Clear()
        DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código Pedido")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.Items.Add("Código Cliente")
        Me.DomainUpDown1.Items.Add("Zona")
        Me.DomainUpDown1.SelectedIndex = 0
        boton = ""
        Label2.Text = Me.DGV_Pedidos.RowCount
        eliminados.Rows.Clear()
        DGV_Pedidos.ClearSelection()
        Varboton = 0
        lb_total.BringToFront()
        Label1.BringToFront()
        tb_buscar.Focus()
        If rb_pendientes.Checked Then
            tb_buscar.Enabled = False
        End If
        tb_monto.Text = "0,00"
        Label17.Visible = False
        rb_pendientes_CheckedChanged(rb_pendientes, New EventArgs)

        Sp_consulta_Productos_PedidoClienteBindingSource.RemoveFilter()

        tb_buscar.Focus()
    End Sub

    Private Sub multiples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.Click
        tb_buscar.SelectAll()
    End Sub

    Private Sub AddData(ByVal cped As Integer)
        Dim COD As Integer = 0
        Dim cod2 As Integer = 0
        DatosPedidoCliente.consulta_pedido_producto_cliente(cped, Me.DGV_Productos_Pedido, Me.DateTimePicker1.Text, Me.tb_codigo.Text, Me.tb_monto.Text, lbl_iva.Text, lbl_Total.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, Tb_Direccion.Text, tb_dias.Text, tb_obs.Text, chk_chequeado, tb_bultos.Text, COD, cod2, tb_obsInt.Text, tb_contacto.Text, tb_usuario.Text)

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then
            cb_modalidadEnvio.SelectedValue = DGV_Pedidos.SelectedRows(0).Cells(10).Value
        End If

        Tbl_VendedorBindingSource.Filter = "CodigoVendedor = " & cod2
        If ListBox2.Items.Count > 0 Then
            ListBox2.SelectedIndex = 0
            ListBox2_KeyDown(ListBox2, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        End If

        SpconsultaClienteBindingSource.Filter = "CodigoCliente = " & COD
        lb_client.SelectedIndex = 0
        cambio = False
        lb_client_KeyDown(lb_client, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        cambio = True

        'DatosPedidoCliente.consulta_pedido_producto_cliente(cped, Me.DGV_Productos_Pedido, Me.DateTimePicker1.Text, Me.tb_codigo.Text, Me.tb_monto.Text, Me.tb_vendedor, lbl_iva.Text, lbl_Total.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, Tb_Direccion.Text, tb_dias.Text, tb_obs.Text, chk_chequeado, tb_bultos.Text, tb_vendedor, COD)

    End Sub

    Private Sub rellenal()
        Dim cont As Integer = 0
        While cont < Me.DGV_Productos_Pedido.Rows.Count
            If Not Me.DGV_Productos_Pedido(0, cont).Value = "" And Not Me.DGV_Productos_Pedido(0, cont).Value = "0" Then
                l.Add(Me.DGV_Productos_Pedido(0, cont).Value)
            End If
            cont = cont + 1
        End While
    End Sub

    Public Function GetSelectedRows(ByVal dg As DataGrid) As Collection
        Dim al As New Collection
        Dim cm As CurrencyManager = Me.BindingContext(dg.DataSource, dg.DataMember)
        Dim dv As DataView = CType(cm.List, DataView)
        Dim i As Integer
        For i = 0 To dv.Count - 1
            If dg.IsSelected(i) Then
                al.Add(dg.Item(i, 3))
            End If
        Next
        Return al
    End Function

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged
        If Me.DGV_Pedidos.Enabled = True Then
            Dim s1 As String
            s1 = "%" + Me.tb_buscar.Text + "%"

            If rb_cargados.Checked Then

                If choice = 0 Then
                    DatosPedidoCliente.DGV_PC(Me.DGV_Pedidos, s1, 0, lbl_TotalP.Text)
                    Label2.Text = Me.DGV_Pedidos.RowCount
                ElseIf choice = 1 Then
                    DatosPedidoCliente.DGV_PC(Me.DGV_Pedidos, s1, 1, lbl_TotalP.Text)
                    Label2.Text = Me.DGV_Pedidos.RowCount
                ElseIf choice = 2 Then
                    DatosPedidoCliente.DGV_PC(Me.DGV_Pedidos, s1, 2, lbl_TotalP.Text)
                    Label2.Text = Me.DGV_Pedidos.RowCount
                ElseIf choice = 3 Then
                    DatosPedidoCliente.DGV_PC(Me.DGV_Pedidos, s1, 3, lbl_TotalP.Text)
                    Label2.Text = Me.DGV_Pedidos.RowCount
                End If

            Else


            End If

            DGV_Pedidos.ClearSelection()
            If Me.DGV_Pedidos.Enabled = True Then
                Me.tb_monto.ResetText()
                Me.tb_codigo.Text = ""
                Me.cb_client.Text = ""
                lbl_PorFacturar.Text = "0"
                'Me.cb_client.Items.Clear()
                Me.tb_obs.Clear()
                Me.DateTimePicker1.Value = DateTime.Now
                Me.DGV_Productos_Pedido.Rows.Clear()
                Label2.Text = Me.DGV_Pedidos.RowCount
                tb_dias.Text = ""
                Tb_Direccion.Clear()
                tb_bultos.Clear()
                chk_chequeado.Checked = False
                tb_usuario.Clear()
                Tb_Tlf1.Clear()
                Me.cb_modalidadEnvio.SelectedValue = 0
                Tb_Tlf2.Clear()
                txt_finalVend.Clear()
                chk_autorizado.Checked = False
                lbl_Total.Text = "0,00"
                tb_monto.Text = "0,00"
                lbl_iva.Text = "0,00"
                Me.DateTimePicker1.Value = DateTime.Now

                lbl_totalPagado.Text = "0,00"
                lbl_maxPagado.Text = "0"
                lbl_promedioPagado.Text = "0"

                lbl_totalPendiente.Text = "0,00"
                lbl_maxPendiente.Text = "0"
                lbl_promedioPendiente.Text = "0"

                lbl_totalVencido.Text = "0,00"
                lbl_maxVencido.Text = "0"
                lbl_promedioVencido.Text = "0"

            End If

        Else

            CrearWhere()
            DGV2.ClearSelection()
            DGV_Productos_Pedido.ClearSelection()

        End If

    End Sub

    Private Sub tb_buscar_Key(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyDown
        If e.KeyData = Keys.Enter Then

            tb_buscar.Text = tb_buscar.Text.Replace("'", "-")

            If ToolBar1.Enabled = True Then

                If DGV_Pedidos.Rows.Count > 0 Then

                    Me.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                    DGV_Pedidos.Focus()

                Else

                    tb_buscar.SelectAll()

                End If

            Else

                If DGV2.Rows.Count > 0 Then

                    Me.DGV2.CurrentCell = Me.DGV2.Item(0, 0)
                    Me.DGV2.Rows(0).Cells(0).Selected = True
                    Me.DGV2.BeginEdit(True)

                    If DGV2.RowCount > 0 Then

                        If DGV2.SelectedRows.Count > 0 Then

                            If Not DGV2.SelectedRows(0).Cells(1).Value Is Nothing Then

                                If DGV2.SelectedRows(0).Cells(1).Value.ToString.Trim <> "" Then
                                    DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV2.SelectedRows(0).Cells(1).Value, 0)
                                End If

                            Else

                                lbl_PorFacturar.Text = "0"

                            End If

                        Else

                            lbl_PorFacturar.Text = "0"

                        End If

                    End If

                Else

                    tb_buscar.SelectAll()

                End If

            End If
        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscar.Text = ""
        Me.tb_buscar.Focus()
    End Sub

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        Dim Contenido(Me.DGV2.ColumnCount - 1) As String

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0

        While cont <= Contenido.Length - 1

            If cont <> 6 And cont <> 9 And cont <> 5 Then
                Contenido(cont) = fila.Cells(cont2).Value
            ElseIf cont = 5 Then
                Contenido(cont) = Format(CDbl(fila.Cells(5).Value), "#,##0.00")
            ElseIf cont = 9 Then
                Contenido(cont) = False
            ElseIf cont = 6 Then
                Contenido(cont) = Format(CInt(fila.Cells(0).Value) * CDbl(fila.Cells(5).Value), "#,##0.00")
                cont2 = cont2 - 1
            End If

            cont = cont + 1
            cont2 = cont2 + 1

        End While

        If rb_pendientes.Checked Then
            DGV2.CurrentRow.Cells(0).Value = ""
        End If

        Return Contenido
    End Function

    Sub ObtenerValoresF34(ByVal Modelo As String, ByVal ubic As DataGridView, ByVal row As Integer)
        Dim swi As Boolean
        Dim i As Integer = 0
        While i < ubic.Rows.Count
            If Not (ubic(2, i).Value = "" Or ubic(2, i).Value = "0") Then
                swi = False
                revisa(swi, Me.DGV2.CurrentRow.Cells(1).Value, Modelo, ubic(0, i).Value)
                If swi = True Then
                    MsgBox("Ya ha ingresado este artículo a su pedido. Si desea agregar más elimínelo del pedido y vuelva a agregarlo.")
                    i = ubic.Rows.Count + 1
                Else
                    Me.DGV_Productos_Pedido.Rows.Add(ubic(2, i).Value, Me.DGV2(1, row).Value, Me.DGV2(2, row).Value, Modelo, Me.DGV2(4, row).Value, ubic(1, i).Value, ubic(0, i).Value, ubic(3, i).Value)
                    Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(3).Value = CInt(Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(3).Value) - CInt(DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(0).Value)
                End If
            End If
            i = i + 1
        End While
    End Sub

    Sub ObtenerValoresFila(ByVal Modelo As String, ByVal ubic As DataGridView, ByVal row As Integer, ByVal cant As Integer)
        Dim swi As Boolean
        MultUbi = True
        listo = True
        If ubic.RowCount = 1 Then
            MultUbi = False
        End If
        Dim i As Integer = 0
        While i < ubic.Rows.Count
            If Not (ubic(2, i).Value = "" Or ubic(2, i).Value = "0") Then
                swi = False
                revisa(swi, Me.DGV2.CurrentRow.Cells(1).Value, Modelo, ubic(0, i).Value)
                If swi = True Then
                    MsgBox("Ya ha ingresado este artículo a su pedido. Si desea agregar más elimínelo del pedido y vuelva a agregarlo.")
                    i = ubic.Rows.Count + 1
                Else

                    If ubic.RowCount > i + 1 Then

                        If ubic.Rows(i + 1).Cells(2).Value.ToString = "" Then

                            listo = False

                        End If

                    End If

                    If i = ubic.RowCount - 1 Then
                        listo = False
                    End If


                    ubicRow2 = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & Me.DGV2(1, row).Value & "'")
                    Dim valor As String = ubicRow2(0)("Nombre").ToString
                    ubicRow2(0)("Nombre") = ubicRow2(0)("Nombre").ToString.Replace("(" & cant.ToString & ") - ", "")

                    Me.DGV_Productos_Pedido.Rows.Add(ubic(2, i).Value, Me.DGV2(1, row).Value, Me.DGV2(2, row).Value, Modelo, ubic(1, i).Value, Me.DGV2(5, row).Value, 0, ubic(0, i).Value, ubic(3, i).Value, False)
                    Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(4).Value = CInt(Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(4).Value) - CInt(DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(0).Value)
                    Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(6).Value = Format(CInt(Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(0).Value) * CInt(DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(5).Value), "#,##0.00")
                    'Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(1).Value = Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(1).Value.ToString.Replace("(" & cant.ToString & ") - ", "")

                    ubicRow2(0)("Nombre") = valor

                End If
                If i >= ubic.RowCount - 2 Then
                    MultUbi = False
                End If
            Else
                MultUbi = False
            End If
            i = i + 1
        End While

        'If rb_pendientes.Checked Then
        CrearWhere()
        'End If

    End Sub

    Sub revisa(ByRef sw As Boolean, ByVal cod As String, ByVal modelo As String, ByVal ubic As String)
        Dim i As Integer = 0
        While i <= Me.DGV_Productos_Pedido.Rows.Count - 1
            If cod = Me.DGV_Productos_Pedido(1, i).Value And Me.DGV_Productos_Pedido(7, i).Value = ubic And Me.DGV_Productos_Pedido(3, i).Value = modelo Then
                sw = True
            End If
            i = i + 1
        End While
    End Sub
    Public Sub recibevalor()
        Me.tb_buscar.Focus()
    End Sub


    Public Sub DGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV2.CellEndEdit

        Try

            Dim bool As Boolean = False
            If Not Me.DGV2.CurrentCell.Value Is System.DBNull.Value Then
                If Me.DGV_Productos_Pedido.Rows.Count >= DatosPedidoCliente.MaxArt And Not DGV2.CurrentRow.Cells(0).Value Is Nothing And rb_cargados.Checked = True Then
                    If DGV2.CurrentRow.Cells(0).Value.ToString <> "" Then
                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                        MsgBox("No se puede hacer un pedido de más de " + DatosPedidoCliente.MaxArt.ToString + " Items. Guarda éste y continúa en otro nuevo.")
                    End If
                Else
                    If CStr(Me.DGV2.CurrentRow.Cells(0).Value) = "" Or CStr(Me.DGV2.CurrentRow.Cells(0).Value) = "0" Then
                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                    ElseIf Me.DGV2.CurrentRow.Cells(0).Value > Me.DGV2(4, Me.DGV2.CurrentRow.Index).Value Then
                        MsgBox("No hay suficiente cantidad. Coloque una cantidad menor.")
                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                        Me.DGV2.BeginEdit(True)
                    Else
                        If Me.DGV2(6, Me.DGV2.CurrentRow.Index).Value Is System.DBNull.Value Or Me.DGV2(6, Me.DGV2.CurrentRow.Index).Value.ToString = "" Then
                            MsgBox("No puedes pedir un artículo que no posee ubicación.")
                            Me.DGV2.CurrentRow.Cells(0).Value = ""
                            Me.DGV2.BeginEdit(True)
                        Else
                            If Not Me.DGV2.CurrentRow.Cells(3).Value.ToString = "" Then 'DGV2(5, Me.DGV2.CurrentRow.Index).Value = ""
                                If Me.DGV2.CurrentRow.Cells(3).Value.ToString = "Multiples" Or Me.DGV2(6, Me.DGV2.CurrentRow.Index).Value = "Multiples" Then
                                    If Me.DGV2(3, Me.DGV2.CurrentRow.Index).Value = "Multiples" And Me.DGV2(6, Me.DGV2.CurrentRow.Index).Value = "Multiples" Then
                                        f34 = New Frm_Mult_Mod_Ubi
                                        f34.Show()
                                        f34.TopMost = True
                                        Me.Enabled = False
                                        f34.valores(Me.DGV2(1, Me.DGV2.CurrentRow.Index).Value, Me.DGV2(0, Me.DGV2.CurrentRow.Index).Value, Me.DGV2.CurrentRow.Index, Me, CInt(Me.DGV2.CurrentRow.Cells(0).Value))
                                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                                    ElseIf Me.DGV2(3, Me.DGV2.CurrentRow.Index).Value = "Multiples" Then
                                        DGV_Productos_Pedido.ClearSelection()
                                        f34 = New Frm_Mult_Mod_Ubi
                                        f34.Show()
                                        f34.TopMost = True
                                        Me.Enabled = False
                                        f34.valores(Me.DGV2(1, Me.DGV2.CurrentRow.Index).Value, Me.DGV2(0, Me.DGV2.CurrentRow.Index).Value, Me.DGV2.CurrentRow.Index, Me, CInt(Me.DGV2.CurrentRow.Cells(0).Value))
                                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                                    Else
                                        f34 = New Frm_Mult_Mod_Ubi
                                        f34.Show()
                                        f34.TopMost = True
                                        Me.Enabled = False
                                        f34.valores(Me.DGV2(1, Me.DGV2.CurrentRow.Index).Value, Me.DGV2(0, Me.DGV2.CurrentRow.Index).Value, Me.DGV2.CurrentRow.Index, Me, CInt(Me.DGV2.CurrentRow.Cells(0).Value))
                                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                                    End If
                                Else
                                    bool = False
                                    revisa(bool, Me.DGV2(1, Me.DGV2.CurrentRow.Index).Value, Me.DGV2(5, Me.DGV2.CurrentRow.Index).Value, Me.DGV2(6, Me.DGV2.CurrentRow.Index).Value)
                                    If bool = False Then

                                        ubicRow2 = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV2.CurrentRow.Cells(1).Value & "'")
                                        ubicRow2(0)("Nombre") = ubicRow2(0)("Nombre").ToString.Replace("(" & DGV2.CurrentRow.Cells(0).Value.ToString & ") - ", "")

                                        Me.DGV_Productos_Pedido.Rows.Add(ObtenerValoresFila(Me.DGV2.CurrentRow))
                                        Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(4).Value = CInt(Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(4).Value) - CInt(DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(0).Value)
                                        Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(1).Value = Me.DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(1).Value.ToString.Replace("(" & DGV_Productos_Pedido.Rows(DGV_Productos_Pedido.RowCount - 1).Cells(0).Value.ToString & ") - ", "")
                                        Me.DGV_Productos_Pedido.Rows(Me.DGV_Productos_Pedido.Rows.Count - 1).Cells(9).Value = False
                                        DGV_Productos_Pedido.ClearSelection()
                                        sel = True
                                    Else
                                        MsgBox("Ya ha ingresado este artículo a su pedido. Si desea agregar más elimínelo del pedido y vuelva a agregarlo.")
                                        Me.DGV2.CurrentRow.Cells(0).Value = ""
                                        Me.DGV2.BeginEdit(True)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If DGV2.RowCount > 0 Then

                If DGV2.SelectedRows.Count > 0 Then

                    If Not DGV2.SelectedRows(0).Cells(1).Value Is Nothing Then

                        If DGV2.SelectedRows(0).Cells(1).Value.ToString.Trim <> "" Then
                            DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV2.SelectedRows(0).Cells(1).Value, 0)
                        End If

                    Else

                        lbl_PorFacturar.Text = "0"

                    End If

                Else

                    lbl_PorFacturar.Text = "0"

                End If

            End If

            DGV_Productos_Pedido.ClearSelection()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_Productos_Pedido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos_Pedido.CellDoubleClick

        If e.ColumnIndex = 1 Then

            If DGV_Productos_Pedido.SelectedRows.Count > 0 Then

                If Not IsNothing(f17) Then

                    If Not f17.IsDisposed Then

                        f17.WindowState = FormWindowState.Normal
                        f17.BringToFront()
                        f17.cb_buscar.SelectedIndex = 0
                        f17.chk_exacto.Checked = True
                        f17.chk_fr.Checked = True
                        f17.tb_buscarcodigo.Text = DGV_Productos_Pedido.SelectedRows(0).Cells(1).Value
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
                        f17.tb_buscarcodigo.Text = DGV_Productos_Pedido.SelectedRows(0).Cells(1).Value
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
                    f17.tb_buscarcodigo.Text = DGV_Productos_Pedido.SelectedRows(0).Cells(1).Value
                    If f17.DGV_Productos.RowCount > 0 Then
                        f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                        f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                    End If

                End If

            End If

        End If

    End Sub


    Public Sub DataGridView2_RowsAdded(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_Productos_Pedido.RowsAdded
        Try

            Dim monto As Double
            Dim MontoIva As Double
            Dim i As Integer = 0
            While i < Me.DGV_Productos_Pedido.Rows.Count
                If Me.DGV_Productos_Pedido(6, i).Value = 0 Then
                    monto = monto + (Me.DGV_Productos_Pedido(0, i).Value * Me.DGV_Productos_Pedido(5, i).Value)
                Else
                    monto = monto + Me.DGV_Productos_Pedido(6, i).Value
                End If

                MontoIva = monto * (iva / 100)
                i = i + 1
            End While
            If DGV_Productos_Pedido.Rows.Count = 0 Then
                tb_monto.Text = "00.00"
                lbl_iva.Text = "0.00"
                lbl_Total.Text = "0.00"
            Else
                Me.tb_monto.Text = Format(monto, "#,##0.00")
                lbl_iva.Text = Format(MontoIva, "#,##0.00")
                lbl_Total.Text = Format(MontoIva + monto, "#,##0.00")
                lbl_totalPedido.Text = lbl_Total.Text
            End If

            lb_total.Text = DGV_Productos_Pedido.RowCount

            If rb_pendientes.Checked Then

                If Not listo Then

                    If where2.Contains("CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "' or ") Then
                        where2 = where2.Replace("CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "' or ", "")
                    End If

                    If where2.Contains(" or CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "' ") Then
                        where2 = where2.Replace(" or CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "' ", "")
                    End If

                    If where2.Contains(" or CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "'") Then
                        where2 = where2.Replace(" or CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "'", "")
                    End If

                    If where2.Contains("CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "'") Then
                        where2 = where2.Replace("CodigoInterno = '" & Me.DGV2.CurrentRow.Cells(1).Value.ToString & "'", "")
                    End If

                    Dim cont As Integer = 0

                    If boton = "p" Then

                        While cont <= eliminados.Rows.Count - 1

                            If eliminados.Rows(cont).Item(1).ToString = Me.DGV2.CurrentRow.Cells(1).Value.ToString Then

                                eliminados.Rows(cont).Delete()
                                cont = cont - 1

                            End If

                            cont = cont + 1

                        End While

                    End If

                    If where2.Contains(" AND ()") Then
                        where2 = where2.Replace(" AND ()", "")
                    End If

                    DGV_Productos_Pedido.ScrollBars = ScrollBars.None
                    Me.Sp_consulta_Productos_PedidoClienteBindingSource.Filter = where2
                    DGV_Productos_Pedido.ScrollBars = ScrollBars.Vertical

                End If

            End If

            If tocar = False Then
                If DGV2.RowCount > 0 Then
                    roww = DGV2.CurrentRow.Index
                    If DGV2.CurrentRow.Cells(6).Value.ToString <> "Multiples" Then
                        CrearWhere()
                    End If
                    DGV2.ClearSelection()
                    DGV2.Rows(roww).Selected = True
                    DGV2.CurrentCell = DGV2.Rows(roww).Cells(0)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView2_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGV_Productos_Pedido.RowsRemoved
        Try

            Dim monto As Double
            Dim MontoIva As Double
            Dim i As Integer = 0
            While i < Me.DGV_Productos_Pedido.Rows.Count
                monto = monto + Me.DGV_Productos_Pedido(6, i).Value
                MontoIva = monto * (iva / 100)
                i = i + 1
            End While
            If DGV_Productos_Pedido.Rows.Count = 0 Then
                tb_monto.Text = "0.00"
                lbl_iva.Text = "0.00"
                lbl_Total.Text = "0.00"
            Else
                Me.tb_monto.Text = Format(monto, "#,##0.00")
                lbl_iva.Text = Format(MontoIva, "#,##0.00")
                lbl_Total.Text = Format(MontoIva + monto, "#,##0.00")
            End If

            lb_total.Text = DGV_Productos_Pedido.RowCount.ToString
            lbl_totalPedido.Text = lbl_Total.Text

            CrearWhere()

            DGV2.ClearSelection()
            lbl_PorFacturar.Text = "0"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_row2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV2.EditingControlShowing
        If Me.empezo = True Then
            If Not Me.tb_buscar.Focused Then
                If Me.DGV2.Rows.Count > 1 Then
                    Me.DGV2.BeginEdit(True)
                End If
            End If
        End If
    End Sub

    Public Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV2.CellClick
        Try
            Me.DGV2.CurrentCell = Me.DGV2(0, e.RowIndex)
            Me.DGV2.BeginEdit(True)

            If DGV2.SelectedRows.Count > 0 Then
                DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV2.SelectedRows(0).Cells(1).Value, 0)
            End If

        Catch ex As Exception

        End Try

    End Sub

    'Esto se usa en el Frm_Ventas todavia no se para que

    Public Sub abreM(ByVal cod As Integer, ByVal ind As Integer)
        swC = True
        indice = ind
        Dim sw2 As Boolean = False
        Dim cont As Integer = 0
        While (cont <= Me.DGV_Pedidos.RowCount) And (sw2 = False)
            If CInt(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value) = cod Then
                sw2 = True
            Else
                cont = cont + 1
            End If
        End While
        Me.DGV_Pedidos.Rows(cont).Selected = True
        Dim index As Integer = CInt(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value)
        AddData(index)
        codigoPedido = index
        Me.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Me.bt_modificar))
    End Sub

    Public Sub nuevo()
        swX = True
    End Sub

    Private Sub DGV_Pedidos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellDoubleClick

        If rb_pendientes.Checked Then

            If DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToLower <> "no tiene" And DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToLower.Trim <> "" Then

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                    ToolBar1_ButtonClick(Me.ToolBar1, New System.Windows.Forms.ToolBarButtonClickEventArgs(bt_nuevo))
                    'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_Productos_PedidoCliente' table. You can move, or remove it, as needed.
                    Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)
                    cb_client.Text = DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString()
                    cb_client.Tag = CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value)
                    tb_obs.Text = DGV_Pedidos.SelectedRows(0).Cells(6).Value
                    tb_dias.Text = DGV_Pedidos.SelectedRows(0).Cells(8).Value
                    tb_usuario.Text = DGV_Pedidos.SelectedRows(0).Cells(9).Value

                    cb_modalidadEnvio.SelectedValue = DGV_Pedidos.SelectedRows(0).Cells(10).Value

                    lb_client.Visible = False
                    DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value), Label17.Visible, True, txt_finalVend)

                    ListBox2.Visible = False
                    boton = "p"

                    DatosPedidoCliente.consulta_productospedidoNP(CInt(DGV_Pedidos.SelectedRows(0).Cells(0).Value), Sp_consulta_Productos_PedidoClienteBindingSource, Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente"), where2, Me)

                    DGV2.ClearSelection()
                    Me.DGV2.Visible = True
                    Me.DomainUpDown1.SelectedIndex = 0
                    'DGV2.Columns(0).ReadOnly = Label17.Visible
                    cb_client.Enabled = False
                    lb_client.Visible = False

                    Sp_consulta_Productos_PedidoClienteBindingSource.Sort = "CantidadExistencia DESC"

                    TabControl1.SelectedIndex = 0

                    If DGV2.RowCount > 0 Then
                        DGV2.Rows(0).Cells(0).Selected = True
                        DGV2.FirstDisplayedScrollingRowIndex = 0
                        DGV2.Focus()
                        DGV2.BeginEdit(True)
                    End If

                Else

                    ToolBar1_ButtonClick(Me.ToolBar1, New System.Windows.Forms.ToolBarButtonClickEventArgs(bt_nuevo))
                    'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_Productos_PedidoCliente' table. You can move, or remove it, as needed.
                    Me.Sp_consulta_Productos_PedidoClienteTableAdapter.Fill(Me.MELDataSet.sp_consulta_Productos_PedidoCliente)
                    cb_client.Text = DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString()
                    cb_client.Tag = CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value)
                    lb_client.Visible = False
                    DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(DGV_Pedidos.SelectedRows(0).Cells(2).Value), Label17.Visible, True, txt_finalVend)

                    'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 0)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 1)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 2)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 3)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 4)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, CInt(tb_codigo.Text), 5)
                    'End If

                    ListBox2.Visible = False
                    'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString, 2)))
                    boton = "p"
                    LeerCSV(";")
                    DGV2.ClearSelection()
                    Me.DGV2.Visible = True
                    Me.DomainUpDown1.SelectedIndex = 0
                    'DGV2.Columns(0).ReadOnly = Label17.Visible
                    cb_client.Enabled = False
                    lb_client.Visible = False
                    If DGV2.RowCount > 0 Then
                        DGV2.Rows(0).Cells(0).Selected = True
                        DGV2.FirstDisplayedScrollingRowIndex = 0
                        DGV2.Focus()
                        DGV2.BeginEdit(True)

                    End If

                End If

            Else

                MsgBox("Debe registrar primero el cliente", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            If (e.ColumnIndex = 2 Or e.ColumnIndex = 3) And DGV_Pedidos.SelectedRows.Count > 0 Then

                Dim frm As New Frm_Clientes
                frm.Show()
                frm.DomainUpDown1.SelectedIndex = 1
                frm.tb_buscarcodigo.Text = DGV_Pedidos.SelectedRows(0).Cells(3).Value
                frm.tb_buscarcodigo.Enabled = False

                If frm.DataGridViewRazon.RowCount > 0 Then

                    frm.DataGridViewRazon.Rows(0).Cells(0).Selected = True
                    frm.DataGridViewRazon_SelectionChanged(frm.DataGridViewRazon, New EventArgs)
                    frm.TopMost = True

                End If


            End If


        End If

    End Sub

    Public Sub DGV_Pedidos_CellClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Pedidos.CellClick, DGV_Pedidos.KeyDown, DGV_Pedidos.KeyUp
        tocar = True
        lb_total.Text = "0"
        If Me.DGV_Pedidos.SelectedRows.Count > 0 And rb_pendientes.Checked = False Then
            Me.DGV_Productos_Pedido.Rows.Clear()
            Dim index As Integer = CInt(Me.DGV_Pedidos.SelectedRows(0).Cells(0).Value)
            AddData(index)
            codigoPedido = index
            If DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString = "Sí" Then
                chk_autorizado.Checked = True
            Else
                chk_autorizado.Checked = False
            End If
            DGV_Productos_Pedido.ClearSelection()
            'lb_client_(lb_client, New EventArgs)
        End If
        tocar = False
        DGV_Productos_Pedido.AllowUserToDeleteRows = False

        If DGV_Pedidos.SelectedRows.Count > 0 And TabControl1.SelectedTab Is tp_indicadoresPedido Then

            lbl_maxPagado.Text = "0"
            lbl_maxPendiente.Text = "0"
            lbl_maxVencido.Text = "0"

            lbl_totalPagado.Text = "0,00"
            lbl_totalPendiente.Text = "0,00"
            lbl_totalVencido.Text = "0,00"

            lbl_promedioPagado.Text = "0"
            lbl_promedioPendiente.Text = "0"
            lbl_promedioVencido.Text = "0"

            lbl_otrosPedidos.Text = "0,00"
            lbl_ultimaFact.Text = "0"
            lbl_totalPedido.Text = "0,00"

            lbl_maxCompra.Text = "0,00"
            lbl_mesMaxCompra.Text = ""
            lbl_promedioCompras.Text = "0,00"

            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 0)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 1)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 2)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 3)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 4)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 5)
            lbl_totalPedido.Text = Format(DGV_Pedidos.SelectedRows(0).Cells(7).Value * (1 + (iva / 100)), "#,##0.00")
        End If

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV2.EditingControlShowing
        If Me.DGV2.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        End If
    End Sub

    Private Sub DGV2_RowLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV2.SelectionChanged
        If sel = True Then

            If Not DGV2.CurrentRow Is Nothing Then
                If DGV2.CurrentRow.Index <> 0 Then
                    sel = False
                    DGV2.CurrentCell = DGV2.Rows(DGV2.CurrentRow.Index - 1).Cells(0)
                    DGV2.BeginEdit(True)
                Else
                    sel = False
                    DGV2.CurrentCell = DGV2.Rows(0).Cells(0)
                    DGV2.BeginEdit(True)
                End If
            End If

        End If

    End Sub

    'Private Sub DGV_row(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV2.SelectionChanged
    '    If Me.empezo = True Then
    '        If Not Me.tb_buscar.Focused Then
    '            If Me.DGV2.Rows.Count >= 1 Then
    '                Me.DGV2.BeginEdit(True)
    '                If DGV2.SelectedRows.Count > 0 Then
    '                    DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV2.SelectedRows(0).Cells(1).Value, 0)
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub



    Public Sub DGV2_Key(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV2.KeyDown, DGV2.KeyUp

        Try

            If DGV2.CurrentCell.IsInEditMode Then

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    DGV2.EndEdit()
                    DGV2.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                Else

                    DGV2.BeginEdit(True)

                End If

            Else

                If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then

                    DGV2.ClearSelection()
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()

                Else

                    DGV2.BeginEdit(True)

                End If

            End If

        Catch ex As Exception
            tb_buscar.Focus()
        End Try



    End Sub

    Private Sub tb_buscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscar.GotFocus
        tb_buscar.SelectAll()
    End Sub

    Private Sub DGV_Productos_Pedido_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV_Productos_Pedido.UserDeletingRow

        If (boton = "m" And DGV_Productos_Pedido.CurrentRow.Cells(9).Value = True) Then

            eliminados.Rows.Add(DGV_Productos_Pedido.CurrentRow.Cells(0).Value, DGV_Productos_Pedido.CurrentRow.Cells(1).Value, DGV_Productos_Pedido.CurrentRow.Cells(2).Value, DGV_Productos_Pedido.CurrentRow.Cells(3).Value, DGV_Productos_Pedido.CurrentRow.Cells(4).Value, DGV_Productos_Pedido.CurrentRow.Cells(6).Value, DGV_Productos_Pedido.CurrentRow.Cells(7).Value, DGV_Productos_Pedido.CurrentRow.Cells(8).Value, DGV_Productos_Pedido.CurrentRow.Cells(9).Value)

        End If

        If boton = "p" Then

            eliminados.Rows.Add(DGV_Productos_Pedido.CurrentRow.Cells(0).Value, DGV_Productos_Pedido.CurrentRow.Cells(1).Value, "(" + DGV_Productos_Pedido.CurrentRow.Cells(0).Value.ToString + ")-" + DGV_Productos_Pedido.CurrentRow.Cells(2).Value.ToString, DGV_Productos_Pedido.CurrentRow.Cells(3).Value, DGV_Productos_Pedido.CurrentRow.Cells(4).Value, DGV_Productos_Pedido.CurrentRow.Cells(6).Value, DGV_Productos_Pedido.CurrentRow.Cells(7).Value, DGV_Productos_Pedido.CurrentRow.Cells(8).Value, DGV_Productos_Pedido.CurrentRow.Cells(9).Value)

            ubicRow2 = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV_Productos_Pedido.CurrentRow.Cells(1).Value & "'")
            If Not ubicRow2(0)("Nombre").ToString.StartsWith("(") Then
                ubicRow2(0)("Nombre") = "(" & DGV_Productos_Pedido.CurrentRow.Cells(0).Value.ToString & ") - " & ubicRow2(0)("Nombre").ToString.Replace("(" & DGV_Productos_Pedido.CurrentRow.Cells(0).Value.ToString & ") - ", "")
            End If

        End If

        If DGV2.RowCount > 0 Then
            roww = DGV2.CurrentRow.Index
        Else
            roww = 0
        End If

        CrearWhere()

    End Sub

    Private Sub Chk_Exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Exist.CheckedChanged

        CrearWhere()
        lbl_PorFacturar.Text = "0"

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.VisibleChanged

        If DGV2.ColumnCount > 0 Then
            DGV2.Columns(0).ReadOnly = Label17.Visible
        End If

        Dim num As Integer = 0

        If Label17.Visible = True Then
            num = 1
        End If

        DGV_Productos_Pedido.AllowUserToDeleteRows = 1 - num

    End Sub


    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If rb_cargados.Checked Then

            If tb_buscar.Text <> "" Then

                If DomainUpDown1.SelectedIndex = 0 Then

                    where = where + "CodigoInterno LIKE '%" & tb_buscar.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 1 Then

                    where = where + "Nombre LIKE '%" & tb_buscar.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 2 Then

                    where = where + "Modelo2 LIKE '%" & tb_buscar.Text & "%'" + y
                    y = " and "

                ElseIf DomainUpDown1.SelectedIndex = 3 Then

                    where = where + "CodigoProductoF LIKE '%" & tb_buscar.Text & "%'" + y
                    y = " and "

                End If

            End If

            If Chk_Exist.Checked Then

                where = where + y + "CantidadExistencia > 0"
                y = " and "

            End If

            For cont As Integer = 0 To DGV_Productos_Pedido.RowCount - 1

                If cont = 0 Then

                    If DGV_Productos_Pedido.RowCount - 1 = 0 Then

                        where = where + y + "CodigoInterno NOT IN ('" & DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString & "')"

                    Else

                        where = where + y + "CodigoInterno NOT IN ('" & DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString & "'"

                    End If

                ElseIf cont = DGV_Productos_Pedido.RowCount - 1 Then

                    where = where + ", '" & DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString & "')"

                Else

                    where = where + ", " + " '" & DGV_Productos_Pedido.Rows(cont).Cells(1).Value.ToString & "'"

                End If

                y = " and "

            Next

            DGV_Productos_Pedido.ScrollBars = ScrollBars.None
            Me.Sp_consulta_Productos_PedidoClienteBindingSource.Filter = where
            DGV_Productos_Pedido.ScrollBars = ScrollBars.Vertical

            If DGV2.RowCount > 0 Then
                DGV2.FirstDisplayedScrollingRowIndex = 0
            End If

        Else

            where = where2

            where = where.TrimStart.TrimEnd

            If where <> "" Then

                For cont2 As Integer = 0 To eliminados.Rows.Count - 1
                    where = where + " or CodigoInterno = '" + eliminados.Rows(cont2).Item(1).ToString + "'"
                Next

                If where.Contains(" AND ()") Then
                    where = where.Replace(" AND ()", "")
                End If

            End If

            If where.Trim() = "CantidadExistencia > 0" Or where.Trim() = "" Then
                where = "CodigoInterno = '--1'"
            End If

            DGV_Productos_Pedido.ScrollBars = ScrollBars.None
            Me.Sp_consulta_Productos_PedidoClienteBindingSource.Filter = where
            where2 = where
            DGV_Productos_Pedido.ScrollBars = ScrollBars.Vertical

        End If

        DGV2.ClearSelection()

    End Sub

    Private Sub LeerArchivos()

        Try

            DGV_Pedidos.Rows.Clear()

            Dim c() As String
            Dim fileReader As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            Dim cantidad As Integer = 0
            ubicacion = "\\SERVER\Pedidos Online\Pendientes\"
            'ubicacion = "\\DEVSERVER\Users\Public\Test\"
            fileReader = My.Computer.FileSystem.GetFiles(ubicacion)

            If My.Settings.Empresa = 1 Then

                For cont As Integer = 0 To fileReader.Count - 1

                    c = Split(fileReader(cont), "_")

                    If c(3).Replace(".csv", "") = "C" Then
                        DGV_Pedidos.Rows.Add(c(0).ToString.Replace(ubicacion, ""), Today(), c(1), c(2).ToString, "No", 1)
                    End If

                Next

            ElseIf My.Settings.Empresa = 4 Then

                For cont As Integer = 0 To fileReader.Count - 1

                    c = Split(fileReader(cont), "_")

                    If c(3).Replace(".csv", "") = "D" Then
                        DGV_Pedidos.Rows.Add(c(0).ToString.Replace(ubicacion, ""), Today(), c(1), c(2).ToString, "No", 1)
                    End If

                Next

            ElseIf My.Settings.Empresa = 6 Then

                For cont As Integer = 0 To fileReader.Count - 1

                    c = Split(fileReader(cont), "_")

                    If c(3).Replace(".csv", "") = "CO" Then
                        DGV_Pedidos.Rows.Add(c(0).ToString.Replace(ubicacion, ""), Today(), c(1), c(2).ToString, "No", 1)
                    End If

                Next

            ElseIf My.Settings.Empresa = 7 Then

                For cont As Integer = 0 To fileReader.Count - 1

                    c = Split(fileReader(cont), "_")

                    If c(3).Replace(".csv", "") = "VP" Then
                        DGV_Pedidos.Rows.Add(c(0).ToString.Replace(ubicacion, ""), Today(), c(1), c(2).ToString, "No", 1)
                    End If

                Next

            End If

            DGV_Pedidos.ClearSelection()

        Catch ex As Exception
            'MsgBox("Error leyendo archivos pendientes", MsgBoxStyle.Critical, "Error")
            'MsgBox(ex.ToString)
        End Try

    End Sub


    '-------------------------------------------------------------------------------------------------------

    Private Sub LeerCSV(ByVal caracter As String)


        Try

            'Ejemplo: 5_1004_REPUESTOS FIALIDER, C.A._C.csv O Ejemplo: 5_1004_REPUESTOS FIALIDER, C.A.D.csv

            DGV_Productos_Pedido.Rows.Clear()
            Dim a As Boolean = False
            Dim b As Boolean = False
            Dim Match As Boolean = False
            Dim SinExst As String = ""
            Dim SinUbi As String = ""
            Dim SinExst2 As String = ""
            Dim cont As Integer = 0
            Dim o As String = ""
            Dim y As String = ""
            where2 = ""
            Dim coma As String = ""
            Dim coma2 As String = ""
            Dim coma3 As String = ""
            Dim len As Integer = 0
            Dim c() As String
            Dim fileReader As String
            Dim cantidad As Integer = 0

            If My.Settings.Empresa = 1 Then

                ubicacion2 = ubicacion & DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString & "_" & DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToUpper _
                & "_" & DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString & "_C.csv"

            ElseIf My.Settings.Empresa = 4 Then

                ubicacion2 = ubicacion & DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString & "_" & DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToUpper _
                & "_" & DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString & "_D.csv"

            ElseIf My.Settings.Empresa = 6 Then

                ubicacion2 = ubicacion & DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString & "_" & DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToUpper _
                & "_" & DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString & "_CO.csv"

            ElseIf My.Settings.Empresa = 7 Then

                ubicacion2 = ubicacion & DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString & "_" & DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString.ToUpper _
                & "_" & DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString & "_VP.csv"

            End If


            fileReader = My.Computer.FileSystem.ReadAllText(ubicacion2)

            c = Split(fileReader, Chr(10))

            Dim i As Integer = 0
            Dim cols As Integer
            Dim f As Integer = c.Length / 2

            If c(f).LastIndexOf(caracter(0)) = c(f).Length - 1 Then
                cols = c(f).Split(caracter).Length - 1
            Else
                cols = c(f).Split(caracter).Length
            End If

            Dim obs As String = ""

            where2 = where2 + "CantidadExistencia > 0 AND ("

            While i < c.Length

                If b = False Then
                    If Trim(c(i).Split(caracter)(0).ToString) <> "" Then
                        If c(i).Split(caracter)(0).ToString.ToUpper.Replace(Chr(10), "").Replace(Chr(13), "") = "OBSERVACIONES:" Then
                            b = True
                        Else
                            where2 = where2 + o + "CodigoInterno = '" & c(i).Split(caracter)(0) & "'"
                            o = " or "
                        End If
                    End If

                Else

                    obs = obs + c(i).Split(caracter)(0).ToString

                End If

                i = i + 1
            End While

            tb_obs.Text = obs

            where2 = where2.Replace("or CodigoInterno = ''", "")
            where2 = where2 + ")"
            where3 = where2

            DGV_Productos_Pedido.ScrollBars = ScrollBars.None
            Sp_consulta_Productos_PedidoClienteBindingSource.Filter = where2
            DGV_Productos_Pedido.ScrollBars = ScrollBars.Vertical
            DGV_Productos_Pedido.ClearSelection()

            i = 0

            If Not Label17.Visible Then

                While i < c.Length

                    If c(i).Split(caracter)(0).ToString.ToUpper <> "" Then

                        If c(i).Split(caracter)(0).ToString.ToUpper <> "OBSERVACIONES:" Then

                            cont = 0

                            While cont <= DGV2.RowCount - 1

                                If DGV2.Rows(cont).Cells(1).Value.ToString = c(i).Split(caracter)(0).ToString Then

                                    Match = True

                                    If CInt(DGV2.Rows(cont).Cells(4).Value) >= CInt(c(i).Split(caracter)(5)) Then

                                        If Not DGV2.Rows(cont).Cells(6).Value Is Nothing Then

                                            If DGV2.Rows(cont).Cells(6).Value.ToString <> "Multiples" Then

                                                If DGV2.Rows(cont).Cells(3).Value.ToString <> "Multiples" Then

                                                    If DGV2.Rows(cont).Cells(6).Value.ToString <> "" Then

                                                        DGV2.ClearSelection()
                                                        DGV2.Rows(cont).Cells(0).Selected = True
                                                        DGV2.Rows(cont).Cells(0).Value = c(i).Split(caracter)(5).ToString
                                                        DGV_CellEndEdit(DGV2, New DataGridViewCellEventArgs(0, cont))

                                                    Else

                                                        SinUbi = SinUbi + coma + DGV2.Rows(cont).Cells(1).Value.ToString
                                                        coma = ", "

                                                    End If

                                                Else

                                                    Dim ubicRow() As Data.DataRow
                                                    ubicRow = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV2.Rows(cont).Cells(1).Value & "'")
                                                    ubicRow(0)("Nombre") = "(" & c(i).Split(caracter)(5).ToString & ") - " & ubicRow(0)("Nombre")

                                                End If

                                            Else

                                                Dim ubicRow() As Data.DataRow
                                                ubicRow = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV2.Rows(cont).Cells(1).Value & "'")
                                                ubicRow(0)("Nombre") = "(" & c(i).Split(caracter)(5).ToString & ") - " & ubicRow(0)("Nombre")

                                            End If

                                        End If

                                    Else

                                        If Not DGV2.Rows(cont).Cells(6).Value Is Nothing Then

                                            If DGV2.Rows(cont).Cells(6).Value.ToString <> "Multiples" Then

                                                If DGV2.Rows(cont).Cells(3).Value.ToString <> "Multiples" Then

                                                    If DGV2.Rows(cont).Cells(6).Value.ToString <> "" Then

                                                        DGV2.ClearSelection()
                                                        DGV2.Rows(cont).Cells(0).Selected = True
                                                        DGV2.Rows(cont).Cells(0).Value = DGV2.Rows(cont).Cells(4).Value
                                                        DGV_CellEndEdit(DGV2, New DataGridViewCellEventArgs(0, cont))
                                                        'Mandas lo que te quedaaaaaaaaaaa
                                                    Else

                                                        SinUbi = SinUbi + coma + DGV2.Rows(cont).Cells(1).Value.ToString
                                                        coma = ", "

                                                    End If

                                                Else

                                                    Dim ubicRow() As Data.DataRow
                                                    ubicRow = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV2.Rows(cont).Cells(1).Value & "'")
                                                    ubicRow(0)("Nombre") = "(" & c(i).Split(caracter)(5).ToString & ") - " & ubicRow(0)("Nombre")

                                                End If

                                            Else
                                                'DGV2.Rows(cont).Cells(0).Value = c(i).Split(caracter)(5).ToString
                                                Dim ubicRow() As Data.DataRow
                                                ubicRow = Me.MELDataSet.Tables("Sp_consulta_Productos_PedidoCliente").Select("CodigoInterno = '" & DGV2.Rows(cont).Cells(1).Value & "'")
                                                ubicRow(0)("Nombre") = "(" & c(i).Split(caracter)(5).ToString & ") - " & ubicRow(0)("Nombre")

                                            End If

                                        End If

                                    End If

                                    cont = DGV2.RowCount

                                Else

                                    cont = cont + 1

                                End If

                            End While

                        End If

                    End If

                    If Match = False Then

                        If a = False Then

                            If c(i).Split(caracter)(0).ToString.ToUpper <> "OBSERVACIONES:" Then

                                If c(i).Split(caracter)(0).ToString.ToUpper <> "" Then

                                    SinExst2 = SinExst2 + coma + c(i).Split(caracter)(0).ToString
                                    coma = ", "

                                Else

                                    a = True

                                End If

                            Else

                                a = True

                            End If

                        End If

                    End If



                    Match = False

                    i = i + 1

                End While

                DGV2.Columns(0).ReadOnly = False

            Else

                DGV2.ClearSelection()
                DGV2.Columns(0).ReadOnly = True
                MsgBox("El cliente se encuentra bloqueado, debe desbloquearlo para crear un pedido", MsgBoxStyle.Exclamation, "SINPRO")

            End If

            'If where2.StartsWith("or") Then
            '    where2 = where2.Substring(2, where2.Length - 2)
            'End If
            'Sp_consulta_Productos_PedidoClienteBindingSource.Filter = where2

            If SinExst2 <> "" Then
                If SinExst2 <> ",  " Then
                    MsgBox("Los artículos ('" & SinExst2.Substring(2, SinExst2.Length - 3) & "') poseen existencia cero (0) y no podrán ser agregados al pedido", MsgBoxStyle.Exclamation, "SINPRO")
                End If
            End If

        Catch ex As Exception

            MsgBox("Error cargando el pedido, favor revisar antes de cargar de nuevo", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub


    Private Sub rb_pendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pendientes.CheckedChanged

        If rb_pendientes.Checked Then

            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                Me.lbl_TotalP.Text = "0,00"

                DatosPedidoCliente.consulta_pedidosclientesNP(DGV_Pedidos, lbl_TotalP.Text)

                Me.bt_nuevo.Enabled = False
                Me.bt_modificar.Enabled = False
                Me.bt_imprimir.Enabled = False
                Me.bt_autorizar.Enabled = False
                Me.bt_facturar.Enabled = False
                Me.cb_modalidadEnvio.SelectedValue = 0

                'TabControl1.Enabled = True

            Else

                LeerArchivos()
                DGV_Pedidos.Sort(DGV_Pedidos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
                DGV_Pedidos.ClearSelection()
                DGV2.Columns(0).ReadOnly = False
                'Me.ToolBar1.Enabled = False

                Me.bt_nuevo.Enabled = False
                Me.bt_modificar.Enabled = False
                Me.bt_imprimir.Enabled = False
                Me.bt_autorizar.Enabled = False
                Me.bt_facturar.Enabled = False

                DGV_Productos_Pedido.Rows.Clear()
                tb_obs.Clear()
                lb_client.Visible = False
                cb_client.Text = ""
                tb_obsInt.Clear()
                tb_usuario.Clear()
                tb_bultos.Clear()
                chk_chequeado.Checked = False
                tb_codigo.Text = ""
                Tb_Direccion.Clear()
                Tb_Tlf1.Clear()
                Tb_Tlf2.Clear()
                txt_finalVend.Clear()
                tb_monto.Text = "0,00"
                lb_iva.Text = "0,00"
                lb_total.Text = "0,00"
                lbl_TotalP.Text = ""

            End If

        Else

            'TabControl1.Enabled = False

        End If

        If Me.DGV_Pedidos.Enabled = True Then
            Me.tb_monto.ResetText()
            Me.tb_codigo.Text = ""
            Me.cb_client.Text = ""
            lbl_PorFacturar.Text = "0"
            'Me.cb_client.Items.Clear()
            Me.tb_obs.Clear()
            Me.DateTimePicker1.Value = DateTime.Now
            Me.DGV_Productos_Pedido.Rows.Clear()
            Label2.Text = Me.DGV_Pedidos.RowCount
            tb_dias.Text = ""
            Tb_Direccion.Clear()
            Tb_Tlf1.Clear()
            Tb_Tlf2.Clear()
            tb_contacto.Clear()
            tb_usuario.Clear()
            txt_finalVend.Clear()
            chk_autorizado.Checked = False
            lbl_Total.Text = "0,00"
            tb_monto.Text = "0,00"
            lbl_iva.Text = "0,00"
            Me.DateTimePicker1.Value = DateTime.Now
        End If

        Label2.Text = DGV_Pedidos.RowCount
        tb_buscar.Enabled = rb_cargados.Checked

    End Sub

    Private Sub rb_cargados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cargados.CheckedChanged

        tb_buscar.Enabled = rb_cargados.Checked

        lbl_maxPagado.Text = "0"
        lbl_maxPendiente.Text = "0"
        lbl_maxVencido.Text = "0"

        lbl_totalPagado.Text = "0,00"
        lbl_totalPendiente.Text = "0,00"
        lbl_totalVencido.Text = "0,00"

        lbl_promedioPagado.Text = "0"
        lbl_promedioPendiente.Text = "0"
        lbl_promedioVencido.Text = "0"

        lbl_otrosPedidos.Text = "0,00"
        lbl_ultimaFact.Text = "0"
        lbl_totalPedido.Text = "0,00"

        lbl_maxCompra.Text = "0,00"
        lbl_mesMaxCompra.Text = ""
        lbl_promedioCompras.Text = "0,00"

        If rb_cargados.Checked Then

            Me.lbl_TotalP.Text = "0,00"
            DatosPedidoCliente.consulta_pedidosclientes(Me.DGV_Pedidos, lbl_TotalP.Text)
            DGV_Pedidos.ClearSelection()

            Me.cb_modalidadEnvio.SelectedValue = 0
            Me.bt_nuevo.Enabled = True
            Me.bt_modificar.Enabled = True
            tb_bultos.Clear()
            chk_chequeado.Checked = False
            Me.bt_imprimir.Enabled = True
            Me.bt_autorizar.Enabled = True
            Me.bt_facturar.Enabled = True

        End If

        If Me.DGV_Pedidos.Enabled = True Then
            Me.tb_monto.ResetText()
            Me.tb_codigo.Text = ""
            Me.cb_client.Text = ""
            lbl_PorFacturar.Text = "0"
            'Me.cb_client.Items.Clear()
            Me.tb_obs.Clear()
            Me.DateTimePicker1.Value = DateTime.Now
            Me.DGV_Productos_Pedido.Rows.Clear()
            Label2.Text = Me.DGV_Pedidos.RowCount
            tb_dias.Text = ""
            Tb_Direccion.Clear()
            tb_obsInt.Clear()
            tb_contacto.Clear()
            tb_usuario.Clear()
            Tb_Tlf1.Clear()
            Tb_Tlf2.Clear()
            txt_finalVend.Clear()
            chk_autorizado.Checked = False
            lbl_Total.Text = "0,00"
            tb_monto.Text = "0,00"
            lbl_iva.Text = "0,00"
            Me.DateTimePicker1.Value = DateTime.Now
        End If

    End Sub

    'Combo Clientes

    Private Sub cb_client_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_client.MouseClick
        Try
            If lb_client.Visible = False Then
                lb_client.Visible = True
                Me.SpconsultaClienteBindingSource.RemoveFilter()
                lb_client.SelectedItem = cb_client.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_client.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_client.Visible = False Then
                    Me.SpconsultaClienteBindingSource.RemoveFilter()
                    lb_client.Visible = True
                    lb_client.SelectedValue = cb_client.Text
                Else
                    If lb_client.Items.Count > 1 Then
                        lb_client.Focus()
                        lb_client.SelectedIndex = lb_client.SelectedIndex + 1
                    Else
                        cb_client.SelectionStart = 0
                        cb_client.SelectionLength = cb_client.Text.Length
                        cb_client.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_client.Visible = True Then
                    If lb_client.Items.Count > 1 Then
                        lb_client.Focus()
                        lb_client.SelectedIndex = lb_client.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_client.Visible Then
                lb_client.Visible = False
                If lb_client.Items.Count > 0 Then
                    'lb_client.SelectedIndex = 0
                    cb_client.Text = lb_client.SelectedItem(1).ToString
                    cb_client.Tag = lb_client.SelectedItem(0).ToString
                    DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, True, txt_finalVend)

                    'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                    '    lbl_maxPagado.Text = "0"
                    '    lbl_maxPendiente.Text = "0"
                    '    lbl_maxVencido.Text = "0"

                    '    lbl_totalPagado.Text = "0,00"
                    '    lbl_totalPendiente.Text = "0,00"
                    '    lbl_totalVencido.Text = "0,00"

                    '    lbl_promedioPagado.Text = "0"
                    '    lbl_promedioPendiente.Text = "0"
                    '    lbl_promedioVencido.Text = "0"

                    '    lbl_otrosPedidos.Text = "0,00"
                    '    lbl_ultimaFact.Text = "0"
                    '    lbl_totalPedido.Text = "0,00"

                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 0)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 1)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 2)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 3)
                    '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 4)
                    'End If

                    ListBox2.Visible = False
                    'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                Else
                    cb_client.Text = ""
                End If
                cb_client.SelectionStart = cb_client.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_client.Text.Length <= 1 Or cb_client.SelectedText <> "" Then
                    Me.SpconsultaClienteBindingSource.RemoveFilter()
                Else
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text.Substring(0, cb_client.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_client_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_client.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "."c Then
                If Me.cb_client.SelectedText <> "" Then
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & e.KeyChar & "%'"
                End If

                If lb_client.Items.Count = 0 Then
                    e.Handled = True
                    Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
                Else
                    e.Handled = False
                    lb_client.Visible = True
                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                lb_client.Visible = True
            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_client_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_client.GotFocus
        Try
            If cb_client.Text = "- Selecciona -" Then
                cb_client.Text = ""
                Me.SpconsultaClienteBindingSource.Filter = "razonsocial like '%" & cb_client.Text & "%'"
                lb_client.Visible = True
                lb_client.BringToFront()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_client.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_client.SelectedIndex = 1 Then
                    cb_client.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_client.Visible = False
                'lb_client.SelectedIndex = 0
                cb_client.Text = lb_client.SelectedItem(1).ToString
                cb_client.Tag = lb_client.SelectedItem(0).ToString
                'FillDGV()
                DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, cambio, txt_finalVend)

                'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

                '    lbl_maxPagado.Text = "0"
                '    lbl_maxPendiente.Text = "0"
                '    lbl_maxVencido.Text = "0"

                '    lbl_totalPagado.Text = "0,00"
                '    lbl_totalPendiente.Text = "0,00"
                '    lbl_totalVencido.Text = "0,00"

                '    lbl_promedioPagado.Text = "0"
                '    lbl_promedioPendiente.Text = "0"
                '    lbl_promedioVencido.Text = "0"

                '    lbl_otrosPedidos.Text = "0,00"
                '    lbl_ultimaFact.Text = "0"
                '    lbl_totalPedido.Text = "0,00"

                '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 0)
                '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 1)
                '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 2)
                '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 3)
                '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 4)
                'End If

                ListBox2.Visible = False
                'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
                cb_client.Focus()
                cb_client.SelectionStart = cb_client.Text.Length
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub
    Private Sub lb_client_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_client.MouseClick
        Try
            lb_client.Visible = False
            'lb_client.SelectedIndex = 0
            cb_client.Text = lb_client.SelectedItem(1).ToString
            cb_client.Tag = lb_client.SelectedItem(0).ToString
            DatosPedidoCliente.Consulta_Clientes(Tb_Direccion.Text, Tb_Tlf1.Text, Tb_Tlf2.Text, CInt(cb_client.Tag), Label17.Visible, True, txt_finalVend)

            'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 5 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

            '    lbl_maxPagado.Text = "0"
            '    lbl_maxPendiente.Text = "0"
            '    lbl_maxVencido.Text = "0"

            '    lbl_totalPagado.Text = "0,00"
            '    lbl_totalPendiente.Text = "0,00"
            '    lbl_totalVencido.Text = "0,00"

            '    lbl_promedioPagado.Text = "0"
            '    lbl_promedioPendiente.Text = "0"
            '    lbl_promedioVencido.Text = "0"

            '    lbl_otrosPedidos.Text = "0,00"
            '    lbl_ultimaFact.Text = "0"
            '    lbl_totalPedido.Text = "0,00"

            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 0)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 1)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 2)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 3)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, 0, 4)
            'End If

            ListBox2.Visible = False
            'Me.tb_vendedor.Text = nombre_vendedor(CInt(Microsoft.VisualBasic.Left(Me.cb_client.Tag.ToString, 2)))
            cb_client.Focus()
            cb_client.SelectionStart = cb_client.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    Private Sub DGV_Pedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub tb_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_buscar.KeyPress
        If Not e.KeyChar = "*"c Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    '------------------------------------------------------ COMBO VENDEDOR ------------------------------------------------------'

    Private Sub txt_finalVend_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_finalVend.MouseClick

        Try
            If ListBox2.Visible = False Then
                ListBox2.Visible = True
                Me.Tbl_VendedorBindingSource.RemoveFilter()
                ListBox2.SelectedItem = txt_finalVend.Text
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_final_TextChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.TextChanged
        If Me.ListBox2.Visible = True Then
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & txt_finalVend.Text & "%'"
        End If
    End Sub
    Private Sub txt_final_KeyDown2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_finalVend.KeyDown

        If e.KeyData = Keys.Down Then
            Me.ListBox2.Visible = True
            Me.ListBox2.Focus()

            If Me.ListBox2.Items.Count > 1 Then
                Me.ListBox2.SelectedIndex = 1
            End If

        ElseIf e.KeyData = Keys.Enter And Me.ListBox2.Visible Then

            Me.ListBox2.Visible = False
            If Me.ListBox2.Items.Count > 0 Then
                Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(0).ToString
                Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(1).ToString
                Me.ListBox2.SelectedIndex = 0
            Else
                Me.txt_finalVend.Text = ""
            End If

            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length

        End If
    End Sub
    Private Sub txt_final_KeyPress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_finalVend.KeyPress
        Me.ListBox2.Visible = True
    End Sub
    Private Sub txt_final_Focus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.GotFocus
        If Me.txt_finalVend.Text = "          --- Escriba Vendedor ---" Then
            Me.txt_finalVend.Text = ""
            Me.Tbl_VendedorBindingSource.Filter = "Nombre  LIKE '%" & Me.txt_finalVend.Text & "%'"
            Me.ListBox2.Visible = True
            ListBox2.BringToFront()
        End If
    End Sub
    Public Sub ListBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyData = Keys.Up And Me.ListBox2.SelectedIndex = 0 Then
            Me.txt_finalVend.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            Me.ListBox2.Visible = False
            Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
            Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
            Me.ListBox2.SelectedIndex = 0
            Me.txt_finalVend.Focus()
            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
        End If
    End Sub
    Private Sub ListBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Me.ListBox2.Visible = False
        Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
        Me.txt_finalVend.Tag = Me.ListBox2.SelectedItem(0).ToString
        Me.ListBox2.SelectedIndex = 0
        Me.txt_finalVend.Focus()
        Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DGV2.SelectedRows.Count > 0 Then
            Dim frm As New Frm_Productos_Por_Facturar
            frm.recibe(DGV2.SelectedRows(0).Cells(1).Value, DGV2.SelectedRows(0).Cells(2).Value, False, False)
            frm.Show()
        Else
            MsgBox("No existe ningún producto seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

    Private Sub DGV_row2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV2.EditingControlShowing

    End Sub

    Private Sub lbl_PorFacturar_Text_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_PorFacturar.TextChanged

        If IsNumeric(lbl_PorFacturar.Text) Then

            If CInt(lbl_PorFacturar.Text) > 0 Then

                lbl_PorFacturar.ForeColor = Color.Red
                lbl_PF.ForeColor = Color.Red

            Else

                lbl_PorFacturar.ForeColor = Color.White
                lbl_PF.ForeColor = Color.White

            End If

        End If

    End Sub

    Private Sub lbl_detalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_detalles.Click

        If DGV2.SelectedRows.Count > 0 Then
            Dim frm As New Frm_Productos_Por_Facturar
            frm.recibe(DGV2.SelectedRows(0).Cells(1).Value, DGV2.SelectedRows(0).Cells(2).Value, False, False)
            frm.Show()
        Else
            MsgBox("No existe ningún producto seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DGV_Pedidos.Sort(DGV_Pedidos.Columns(7), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        DatosPedidoCliente.actaliza_precios_pedidos_por_facturar()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        lbl_maxPagado.Text = "0"
        lbl_maxPendiente.Text = "0"
        lbl_maxVencido.Text = "0"

        lbl_totalPagado.Text = "0,00"
        lbl_totalPendiente.Text = "0,00"
        lbl_totalVencido.Text = "0,00"

        lbl_promedioPagado.Text = "0"
        lbl_promedioPendiente.Text = "0"
        lbl_promedioVencido.Text = "0"

        lbl_otrosPedidos.Text = "0,00"
        lbl_ultimaFact.Text = "0"
        lbl_totalPedido.Text = "0,00"

        lbl_maxCompra.Text = "0,00"
        lbl_mesMaxCompra.Text = ""
        lbl_promedioCompras.Text = "0,00"

        If DGV_Pedidos.SelectedRows.Count > 0 And TabControl1.SelectedTab Is tp_indicadoresPedido Then
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 0)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 1)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 2)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 3)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 4)
            DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, DGV_Pedidos.SelectedRows(0).Cells(2).Value, DGV_Pedidos.SelectedRows(0).Cells(0).Value, 5)
            lbl_totalPedido.Text = lbl_Total.Text

            'Else Then
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 0)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalVencido.Text, lbl_maxVencido.Text, lbl_promedioVencido.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 1)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPendiente.Text, lbl_maxPendiente.Text, lbl_promedioPendiente.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 2)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 3)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 4)
            '    DatosPedidoCliente.consulta_indicadoresPedido(lbl_totalPagado.Text, lbl_maxPagado.Text, lbl_promedioPagado.Text, lbl_ultimaFact.Text, lbl_otrosPedidos.Text, lbl_mesMaxCompra.Text, lbl_maxCompra.Text, lbl_promedioCompras.Text, CInt(cb_client.Tag), 0, 5)
            '    lbl_totalPedido.Text = lbl_Total.Text
        End If

    End Sub
End Class
