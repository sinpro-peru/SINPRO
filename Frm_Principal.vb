Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class Frm_Principal

    Inherits System.Windows.Forms.Form

    Public Shared f1 As Frm_Adm_Clientes
    Public Shared f2 As Frm_Clientes
    Public Shared f3 As Frm_Adm_Productos
    Public Shared f4 As Frm_Proveedores
    Public Shared f5 As Frm_Productos
    Public Shared f6 As Frm_Adm_Proveedores
    Public Shared f7 As Frm_Adm_Usuarios
    Public Shared f8 As Frm_Ajustes
    Public Shared f9 As Frm_AjusteSaldos
    Public Shared f10 As Frm_AjustesNotas
    Public Shared f11 As Frm_Almacenes
    Public Shared f12 As Frm_Analisis_Cobranza
    Public Shared f13 As Frm_Facturas_Ventas
    Public Shared f14 As Frm_Pedidos_Clientes
    Public Shared f15 As Frm_Analisis_Pedido
    Public Shared f16 As Frm_AnalisisDecision
    Public Shared f17 As Frm_Compras
    Public Shared f18 As Frm_CatalogoMarcaModelo
    Public Shared f19 As Frm_chequeoPedidos
    Public Shared f20 As Frm_ChequesDev
    Public Shared f21 As Frm_Codigos_Arancelarios
    Public Shared f22 As Frm_Comisiones
    Public Shared f23 As Frm_Competencia
    Public Shared f24 As Frm_Comprascargadas
    Public Shared f25 As Frm_Configuracion
    Public Shared f26 As Frm_Consulta_Movimientos
    Public Shared f27 As Frm_EvaluacionProductos
    Public Shared f28 As Frm_EvaluacionVendedores
    Public Shared f29 As Frm_EvaluacionZonas
    Public Shared f30 As Frm_EvaluacionClientes
    Public Shared f31 As Frm_Grupos
    Public Shared f32 As Frm_Marca_Modelo
    Public Shared f33 As Frm_Movimientos
    Public Shared f34 As Frm_NotaCredito
    Public Shared f35 As Frm_Guia_Transporte
    Public Shared f36 As Frm_Parametro_Fecha
    Public Shared f37 As Frm_Pedidos_Clientes
    Public Shared f38 As Frm_Pedidos_Proveedores
    Public Shared f39 As Frm_Recibos
    Public Shared f40 As Frm_Relacion_Facturas
    Public Shared f41 As Frm_TipoUsuario
    Public Shared f42 As Frm_Transportes
    Public Shared f43 As Frm_Traspasos
    Public Shared f44 As s
    Public Shared f45 As Frm_Vendedores
    Public Shared f46 As Frm_CrearMensaje
    Public Shared f47 As Frm_Respuestas
    Public Shared f48 As Frm_MensajesFuturos
    Public Shared f49 As Frm_ListadoClientes
    Public Shared f50 As Frm_Gastos
    Public Shared f51 As Frm_ConciliacionBancaria
    Public Shared f52 As Frm_Movimiento_Productos
    Public Shared f53 As Frm_Inventario
    Public Shared f54 As Frm_Etiquetas_Multiples
    Public Shared f55 As Frm_Actividades
    Public Shared f56 As Frm_Configuracion_Web
    Public Shared f57 As Frm_Configuracion_Pedidos
    Public Shared f58 As Frm_Configuracion_Mail
    Public Shared f59 As Frm_Configuracion_Cobranzas

    Public sw As Boolean = False
    Public Shared user_l As String
    Public Shared user_n As String
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_crearMensaje As System.Windows.Forms.Button
    Friend WithEvents DGV_OtrosAUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Recordatorio As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_UsuarioAOtros As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bt_actualizar As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CódigosArancelariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvenatarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariaciónLinealToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasCargadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjustesDeNotasDeCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjustesDeSaldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsociaciónDeMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChequeDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompetenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManejoDeFacturasEmitidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasDeCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecibosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RInventatrioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChequesDevueltosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesPorDañosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelaciónDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasDeCréditoPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibroDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesEliminadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CódigosEliminadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminTipoDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AGSADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnálisisDeDecisionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnálisisDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnálisisDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnálisisDeVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnálisisDeZonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CrearMensajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarBandejasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sta2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents login2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PosponerTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnDíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnaSemanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SóloÉsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnaHoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodasSusRepeticionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarMensajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FinalizarMensajeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListadoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatálogoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelaciónDeGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConciliaciónBancariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientoProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RGerenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosOcultosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpresiónDeEtiquetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActividadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobranzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorreosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WEBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public frm As New DataTable("frm")

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        'taskbarNotifier1 = New TaskBarNotifier
        'taskbarNotifier1.SetBackgroundBitmap(New Bitmap(MyClass.GetType(), "l.png"), Color.FromArgb(238, 238, 238))
        'taskbarNotifier1.SetCloseBitmap(New Bitmap(MyClass.GetType(), "close.bmp"), Color.FromArgb(255, 0, 255), New Point(260, 15))
        'taskbarNotifier1.TitleRectangle = New Rectangle(170, 15, 100, 25)
        'taskbarNotifier1.TextRectangle = New Rectangle(110, 41, 133, 68)

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
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_clientes As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_proveedores As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_productos As System.Windows.Forms.ToolBarButton
    Friend WithEvents conex As System.Data.SqlClient.SqlConnection
    Friend WithEvents Sqlcommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents bt_compras As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_reportes As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_clientes = New System.Windows.Forms.ToolBarButton
        Me.bt_proveedores = New System.Windows.Forms.ToolBarButton
        Me.bt_productos = New System.Windows.Forms.ToolBarButton
        Me.bt_compras = New System.Windows.Forms.ToolBarButton
        Me.bt_reportes = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_actualizar = New System.Windows.Forms.Button
        Me.bt_crearMensaje = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGV_OtrosAUsuario = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sta2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.login2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FinalizarMensajeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_UsuarioAOtros = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.login = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarMensajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_Recordatorio = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PosponerTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnaHoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnDíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnaSemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SóloÉsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TodasSusRepeticionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.conex = New System.Data.SqlClient.SqlConnection
        Me.Sqlcommand = New System.Data.SqlClient.SqlCommand
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrearMensajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarBandejasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigosArancelariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InfoGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvenatarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VariaciónLinealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidosDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasCargadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidosDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjustesDeNotasDeCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjustesDeSaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsociaciónDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChequeDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompetenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManejoDeFacturasEmitidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasDeCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidosDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarcaModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CatálogoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConciliaciónBancariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RelaciónDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RGerenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosOcultosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RInventatrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChequesDevueltosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevolucionesPorDañosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasDeCréditoPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RelaciónDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImpresiónDeEtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesEliminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigosEliminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminTipoDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AGSADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadísticasDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnálisisDeDecisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnálisisDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnálisisDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnálisisDeVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnálisisDeZonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientoProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CobranzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CorreosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WEBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_OtrosAUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_UsuarioAOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Recordatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_clientes, Me.bt_proveedores, Me.bt_productos, Me.bt_compras, Me.bt_reportes, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(85, 75)
        Me.ToolBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 24)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(85, 689)
        Me.ToolBar1.TabIndex = 0
        '
        'bt_clientes
        '
        Me.bt_clientes.ImageIndex = 7
        Me.bt_clientes.Name = "bt_clientes"
        Me.bt_clientes.Text = "Clientes"
        Me.bt_clientes.ToolTipText = "Gestión de Clientes"
        '
        'bt_proveedores
        '
        Me.bt_proveedores.ImageIndex = 11
        Me.bt_proveedores.Name = "bt_proveedores"
        Me.bt_proveedores.Text = "Proveedores"
        Me.bt_proveedores.ToolTipText = "Gestión de Proveedores"
        '
        'bt_productos
        '
        Me.bt_productos.ImageIndex = 12
        Me.bt_productos.Name = "bt_productos"
        Me.bt_productos.Text = "Inventario"
        Me.bt_productos.ToolTipText = "Gestión de Productos"
        '
        'bt_compras
        '
        Me.bt_compras.ImageIndex = 3
        Me.bt_compras.Name = "bt_compras"
        Me.bt_compras.Text = "Info. General"
        Me.bt_compras.ToolTipText = "Información detallada de los productos"
        '
        'bt_reportes
        '
        Me.bt_reportes.ImageIndex = 9
        Me.bt_reportes.Name = "bt_reportes"
        Me.bt_reportes.Text = "Transporte"
        Me.bt_reportes.ToolTipText = "Guías de transporte"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 6
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        Me.bt_salir.ToolTipText = "Salir del sistema"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "Client-white.png")
        Me.ImageList1.Images.SetKeyName(8, "Client-2-White.png")
        Me.ImageList1.Images.SetKeyName(9, "Transporte-White.png")
        Me.ImageList1.Images.SetKeyName(10, "Supplier-white.png")
        Me.ImageList1.Images.SetKeyName(11, "cargo1.png")
        Me.ImageList1.Images.SetKeyName(12, "box1.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.bt_actualizar)
        Me.Panel1.Controls.Add(Me.bt_crearMensaje)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 689)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(946, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 46)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Futuros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bt_actualizar
        '
        Me.bt_actualizar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_actualizar.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_actualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_actualizar.Location = New System.Drawing.Point(802, 5)
        Me.bt_actualizar.Name = "bt_actualizar"
        Me.bt_actualizar.Size = New System.Drawing.Size(138, 46)
        Me.bt_actualizar.TabIndex = 30
        Me.bt_actualizar.Text = "Actualizar bandejas"
        Me.bt_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bt_crearMensaje
        '
        Me.bt_crearMensaje.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_crearMensaje.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_crearMensaje.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_crearMensaje.Location = New System.Drawing.Point(662, 5)
        Me.bt_crearMensaje.Name = "bt_crearMensaje"
        Me.bt_crearMensaje.Size = New System.Drawing.Size(134, 46)
        Me.bt_crearMensaje.TabIndex = 29
        Me.bt_crearMensaje.Text = "Crear Mensaje"
        Me.bt_crearMensaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_crearMensaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_OtrosAUsuario)
        Me.GroupBox3.Controls.Add(Me.LinkLabel9)
        Me.GroupBox3.Controls.Add(Me.LinkLabel6)
        Me.GroupBox3.Controls.Add(Me.LinkLabel7)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(668, 479)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 203)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mensajes de otros usuarios"
        '
        'DGV_OtrosAUsuario
        '
        Me.DGV_OtrosAUsuario.AllowUserToAddRows = False
        Me.DGV_OtrosAUsuario.AllowUserToDeleteRows = False
        Me.DGV_OtrosAUsuario.AllowUserToResizeColumns = False
        Me.DGV_OtrosAUsuario.AllowUserToResizeRows = False
        Me.DGV_OtrosAUsuario.BackgroundColor = System.Drawing.Color.White
        Me.DGV_OtrosAUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_OtrosAUsuario.ColumnHeadersVisible = False
        Me.DGV_OtrosAUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Fecha2, Me.Destino, Me.DataGridViewTextBoxColumn2, Me.sta2, Me.login2})
        Me.DGV_OtrosAUsuario.ContextMenuStrip = Me.ContextMenuStrip4
        Me.DGV_OtrosAUsuario.GridColor = System.Drawing.Color.White
        Me.DGV_OtrosAUsuario.Location = New System.Drawing.Point(6, 36)
        Me.DGV_OtrosAUsuario.MultiSelect = False
        Me.DGV_OtrosAUsuario.Name = "DGV_OtrosAUsuario"
        Me.DGV_OtrosAUsuario.ReadOnly = True
        Me.DGV_OtrosAUsuario.RowHeadersVisible = False
        Me.DGV_OtrosAUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_OtrosAUsuario.Size = New System.Drawing.Size(332, 161)
        Me.DGV_OtrosAUsuario.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "Fecha"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.ReadOnly = True
        Me.Fecha2.Width = 50
        '
        'Destino
        '
        Me.Destino.HeaderText = "Remitente"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        Me.Destino.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'sta2
        '
        Me.sta2.HeaderText = "sta"
        Me.sta2.Name = "sta2"
        Me.sta2.ReadOnly = True
        Me.sta2.Width = 20
        '
        'login2
        '
        Me.login2.HeaderText = "login2"
        Me.login2.Name = "login2"
        Me.login2.ReadOnly = True
        Me.login2.Visible = False
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalizarMensajeToolStripMenuItem1})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(157, 26)
        '
        'FinalizarMensajeToolStripMenuItem1
        '
        Me.FinalizarMensajeToolStripMenuItem1.Image = Global.Tesis_Nueva.My.Resources.Resources.check_16x16
        Me.FinalizarMensajeToolStripMenuItem1.Name = "FinalizarMensajeToolStripMenuItem1"
        Me.FinalizarMensajeToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.FinalizarMensajeToolStripMenuItem1.Text = "Finalizar Mensaje"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(224, 18)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(52, 15)
        Me.LinkLabel9.TabIndex = 14
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Usuario"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(176, 18)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(42, 15)
        Me.LinkLabel6.TabIndex = 12
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Fecha"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(93, 18)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel7.TabIndex = 11
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Importancia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ordenar por:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV_UsuarioAOtros)
        Me.GroupBox2.Controls.Add(Me.LinkLabel8)
        Me.GroupBox2.Controls.Add(Me.LinkLabel4)
        Me.GroupBox2.Controls.Add(Me.LinkLabel5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(662, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 203)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mensajes a otros usuarios"
        '
        'DGV_UsuarioAOtros
        '
        Me.DGV_UsuarioAOtros.AllowUserToAddRows = False
        Me.DGV_UsuarioAOtros.AllowUserToDeleteRows = False
        Me.DGV_UsuarioAOtros.AllowUserToResizeColumns = False
        Me.DGV_UsuarioAOtros.AllowUserToResizeRows = False
        Me.DGV_UsuarioAOtros.BackgroundColor = System.Drawing.Color.White
        Me.DGV_UsuarioAOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_UsuarioAOtros.ColumnHeadersVisible = False
        Me.DGV_UsuarioAOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Fecha1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.sta, Me.login})
        Me.DGV_UsuarioAOtros.ContextMenuStrip = Me.ContextMenuStrip3
        Me.DGV_UsuarioAOtros.GridColor = System.Drawing.Color.White
        Me.DGV_UsuarioAOtros.Location = New System.Drawing.Point(6, 36)
        Me.DGV_UsuarioAOtros.MultiSelect = False
        Me.DGV_UsuarioAOtros.Name = "DGV_UsuarioAOtros"
        Me.DGV_UsuarioAOtros.ReadOnly = True
        Me.DGV_UsuarioAOtros.RowHeadersVisible = False
        Me.DGV_UsuarioAOtros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_UsuarioAOtros.Size = New System.Drawing.Size(338, 161)
        Me.DGV_UsuarioAOtros.TabIndex = 15
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Fecha1
        '
        Me.Fecha1.HeaderText = "Fecha"
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.ReadOnly = True
        Me.Fecha1.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 73
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 170
        '
        'sta
        '
        Me.sta.HeaderText = "sta"
        Me.sta.Name = "sta"
        Me.sta.ReadOnly = True
        Me.sta.Width = 20
        '
        'login
        '
        Me.login.HeaderText = "login"
        Me.login.Name = "login"
        Me.login.ReadOnly = True
        Me.login.Visible = False
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarMensajeToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(154, 26)
        '
        'EliminarMensajeToolStripMenuItem
        '
        Me.EliminarMensajeToolStripMenuItem.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.EliminarMensajeToolStripMenuItem.Name = "EliminarMensajeToolStripMenuItem"
        Me.EliminarMensajeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EliminarMensajeToolStripMenuItem.Text = "Eliminar Mensaje"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(224, 18)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(52, 15)
        Me.LinkLabel8.TabIndex = 13
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Usuario"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(176, 18)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(42, 15)
        Me.LinkLabel4.TabIndex = 12
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Fecha"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(93, 18)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel5.TabIndex = 11
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Importancia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ordenar por:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_Recordatorio)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 203)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recordatorios"
        '
        'DGV_Recordatorio
        '
        Me.DGV_Recordatorio.AllowUserToAddRows = False
        Me.DGV_Recordatorio.AllowUserToDeleteRows = False
        Me.DGV_Recordatorio.AllowUserToResizeColumns = False
        Me.DGV_Recordatorio.AllowUserToResizeRows = False
        Me.DGV_Recordatorio.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Recordatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Recordatorio.ColumnHeadersVisible = False
        Me.DGV_Recordatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Titulo})
        Me.DGV_Recordatorio.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DGV_Recordatorio.GridColor = System.Drawing.Color.White
        Me.DGV_Recordatorio.Location = New System.Drawing.Point(6, 36)
        Me.DGV_Recordatorio.MultiSelect = False
        Me.DGV_Recordatorio.Name = "DGV_Recordatorio"
        Me.DGV_Recordatorio.ReadOnly = True
        Me.DGV_Recordatorio.RowHeadersVisible = False
        Me.DGV_Recordatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Recordatorio.Size = New System.Drawing.Size(338, 161)
        Me.DGV_Recordatorio.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 50
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        Me.Titulo.ReadOnly = True
        Me.Titulo.Width = 263
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PosponerTareaToolStripMenuItem, Me.EliminarTareaToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(149, 48)
        '
        'PosponerTareaToolStripMenuItem
        '
        Me.PosponerTareaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnaHoraToolStripMenuItem, Me.UnDíaToolStripMenuItem, Me.UnaSemanaToolStripMenuItem, Me.UnMesToolStripMenuItem})
        Me.PosponerTareaToolStripMenuItem.Image = CType(resources.GetObject("PosponerTareaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PosponerTareaToolStripMenuItem.Name = "PosponerTareaToolStripMenuItem"
        Me.PosponerTareaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PosponerTareaToolStripMenuItem.Text = "Posponer tarea"
        '
        'UnaHoraToolStripMenuItem
        '
        Me.UnaHoraToolStripMenuItem.Name = "UnaHoraToolStripMenuItem"
        Me.UnaHoraToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UnaHoraToolStripMenuItem.Text = "Una Hora"
        '
        'UnDíaToolStripMenuItem
        '
        Me.UnDíaToolStripMenuItem.Name = "UnDíaToolStripMenuItem"
        Me.UnDíaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UnDíaToolStripMenuItem.Text = "Un Día"
        '
        'UnaSemanaToolStripMenuItem
        '
        Me.UnaSemanaToolStripMenuItem.Name = "UnaSemanaToolStripMenuItem"
        Me.UnaSemanaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UnaSemanaToolStripMenuItem.Text = "Un Semana"
        '
        'UnMesToolStripMenuItem
        '
        Me.UnMesToolStripMenuItem.Name = "UnMesToolStripMenuItem"
        Me.UnMesToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UnMesToolStripMenuItem.Text = "Un Mes"
        '
        'EliminarTareaToolStripMenuItem
        '
        Me.EliminarTareaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SóloÉsToolStripMenuItem, Me.TodasSusRepeticionesToolStripMenuItem})
        Me.EliminarTareaToolStripMenuItem.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.EliminarTareaToolStripMenuItem.Name = "EliminarTareaToolStripMenuItem"
        Me.EliminarTareaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EliminarTareaToolStripMenuItem.Text = "Eliminar tarea"
        '
        'SóloÉsToolStripMenuItem
        '
        Me.SóloÉsToolStripMenuItem.Name = "SóloÉsToolStripMenuItem"
        Me.SóloÉsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SóloÉsToolStripMenuItem.Text = "Sólo esta tarea"
        '
        'TodasSusRepeticionesToolStripMenuItem
        '
        Me.TodasSusRepeticionesToolStripMenuItem.Name = "TodasSusRepeticionesToolStripMenuItem"
        Me.TodasSusRepeticionesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TodasSusRepeticionesToolStripMenuItem.Text = "Todas sus repeticiones"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(176, 18)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(42, 15)
        Me.LinkLabel3.TabIndex = 12
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Fecha"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(93, 18)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Importancia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ordenar por:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(226, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(350, 111)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1016, 525)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'conex
        '
        Me.conex.ConnectionString = "Data Source=agsaweb.no-ip.biz, 1433; Network Library=DBMSSOCN; Initial Catalog=MI" & _
            "L-26;Integrated Security=SSPI; Trusted_Connection=false; User ID=HugoEstrada; Pa" & _
            "ssword=Hugo16096946"
        Me.conex.FireInfoMessageEventOnUserErrors = False
        '
        'Sqlcommand
        '
        Me.Sqlcommand.CommandType = System.Data.CommandType.StoredProcedure
        Me.Sqlcommand.Connection = Me.conex
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 600000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SINPRO"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearMensajeToolStripMenuItem, Me.ActualizarBandejasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 48)
        '
        'CrearMensajeToolStripMenuItem
        '
        Me.CrearMensajeToolStripMenuItem.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.CrearMensajeToolStripMenuItem.Name = "CrearMensajeToolStripMenuItem"
        Me.CrearMensajeToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CrearMensajeToolStripMenuItem.Text = "Crear Mensaje"
        '
        'ActualizarBandejasToolStripMenuItem
        '
        Me.ActualizarBandejasToolStripMenuItem.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.ActualizarBandejasToolStripMenuItem.Name = "ActualizarBandejasToolStripMenuItem"
        Me.ActualizarBandejasToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ActualizarBandejasToolStripMenuItem.Text = "Actualizar bandejas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem, Me.PedidosDeCompraToolStripMenuItem, Me.VentasToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AdministradorToolStripMenuItem, Me.AGSADToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "Menu  Principal"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustesToolStripMenuItem, Me.CódigosArancelariosToolStripMenuItem, Me.InvToolStripMenuItem, Me.GruposToolStripMenuItem, Me.InfoGeneralToolStripMenuItem, Me.InvenatarioToolStripMenuItem, Me.VariaciónLinealToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'CódigosArancelariosToolStripMenuItem
        '
        Me.CódigosArancelariosToolStripMenuItem.Name = "CódigosArancelariosToolStripMenuItem"
        Me.CódigosArancelariosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CódigosArancelariosToolStripMenuItem.Text = "Códigos Arancelarios"
        '
        'InvToolStripMenuItem
        '
        Me.InvToolStripMenuItem.Name = "InvToolStripMenuItem"
        Me.InvToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.InvToolStripMenuItem.Text = "Conteo de inventario"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'InfoGeneralToolStripMenuItem
        '
        Me.InfoGeneralToolStripMenuItem.Name = "InfoGeneralToolStripMenuItem"
        Me.InfoGeneralToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.InfoGeneralToolStripMenuItem.Text = "Info. General"
        '
        'InvenatarioToolStripMenuItem
        '
        Me.InvenatarioToolStripMenuItem.Name = "InvenatarioToolStripMenuItem"
        Me.InvenatarioToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.InvenatarioToolStripMenuItem.Text = "Inventario"
        '
        'VariaciónLinealToolStripMenuItem
        '
        Me.VariaciónLinealToolStripMenuItem.Name = "VariaciónLinealToolStripMenuItem"
        Me.VariaciónLinealToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.VariaciónLinealToolStripMenuItem.Text = "Variación Lineal"
        '
        'PedidosDeCompraToolStripMenuItem
        '
        Me.PedidosDeCompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasCargadasToolStripMenuItem, Me.PedidosDeComprasToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.PedidosDeCompraToolStripMenuItem.Name = "PedidosDeCompraToolStripMenuItem"
        Me.PedidosDeCompraToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.PedidosDeCompraToolStripMenuItem.Text = "Pedidos de Compra"
        '
        'ComprasCargadasToolStripMenuItem
        '
        Me.ComprasCargadasToolStripMenuItem.Name = "ComprasCargadasToolStripMenuItem"
        Me.ComprasCargadasToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ComprasCargadasToolStripMenuItem.Text = "Compras Cargadas"
        '
        'PedidosDeComprasToolStripMenuItem
        '
        Me.PedidosDeComprasToolStripMenuItem.Name = "PedidosDeComprasToolStripMenuItem"
        Me.PedidosDeComprasToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PedidosDeComprasToolStripMenuItem.Text = "Pedidos de Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustesDeNotasDeCToolStripMenuItem, Me.AjustesDeSaldosToolStripMenuItem, Me.AsociaciónDeMovimientosToolStripMenuItem, Me.ChequeDePedidosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ComisionesToolStripMenuItem, Me.CompetenciaToolStripMenuItem, Me.FacturasPorCobrarToolStripMenuItem, Me.ManejoDeFacturasEmitidadToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.NotasDeCréditoToolStripMenuItem, Me.PedidosDeVentaToolStripMenuItem, Me.RecibosToolStripMenuItem, Me.TransportesToolStripMenuItem, Me.VendedoresToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'AjustesDeNotasDeCToolStripMenuItem
        '
        Me.AjustesDeNotasDeCToolStripMenuItem.Name = "AjustesDeNotasDeCToolStripMenuItem"
        Me.AjustesDeNotasDeCToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AjustesDeNotasDeCToolStripMenuItem.Text = "Ajustes de Notas de C."
        '
        'AjustesDeSaldosToolStripMenuItem
        '
        Me.AjustesDeSaldosToolStripMenuItem.Name = "AjustesDeSaldosToolStripMenuItem"
        Me.AjustesDeSaldosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AjustesDeSaldosToolStripMenuItem.Text = "Ajustes de Saldos"
        '
        'AsociaciónDeMovimientosToolStripMenuItem
        '
        Me.AsociaciónDeMovimientosToolStripMenuItem.Name = "AsociaciónDeMovimientosToolStripMenuItem"
        Me.AsociaciónDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AsociaciónDeMovimientosToolStripMenuItem.Text = "Asociación de Movimientos"
        '
        'ChequeDePedidosToolStripMenuItem
        '
        Me.ChequeDePedidosToolStripMenuItem.Name = "ChequeDePedidosToolStripMenuItem"
        Me.ChequeDePedidosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ChequeDePedidosToolStripMenuItem.Text = "Chequeo de Pedidos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ComisionesToolStripMenuItem
        '
        Me.ComisionesToolStripMenuItem.Name = "ComisionesToolStripMenuItem"
        Me.ComisionesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ComisionesToolStripMenuItem.Text = "Comisiones"
        '
        'CompetenciaToolStripMenuItem
        '
        Me.CompetenciaToolStripMenuItem.Name = "CompetenciaToolStripMenuItem"
        Me.CompetenciaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CompetenciaToolStripMenuItem.Text = "Competencia"
        '
        'FacturasPorCobrarToolStripMenuItem
        '
        Me.FacturasPorCobrarToolStripMenuItem.Name = "FacturasPorCobrarToolStripMenuItem"
        Me.FacturasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.FacturasPorCobrarToolStripMenuItem.Text = "Facturas por cobrar"
        '
        'ManejoDeFacturasEmitidadToolStripMenuItem
        '
        Me.ManejoDeFacturasEmitidadToolStripMenuItem.Name = "ManejoDeFacturasEmitidadToolStripMenuItem"
        Me.ManejoDeFacturasEmitidadToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ManejoDeFacturasEmitidadToolStripMenuItem.Text = "Manejo de Facturas emitidas"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'NotasDeCréditoToolStripMenuItem
        '
        Me.NotasDeCréditoToolStripMenuItem.Name = "NotasDeCréditoToolStripMenuItem"
        Me.NotasDeCréditoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.NotasDeCréditoToolStripMenuItem.Text = "Notas de Crédito"
        '
        'PedidosDeVentaToolStripMenuItem
        '
        Me.PedidosDeVentaToolStripMenuItem.Name = "PedidosDeVentaToolStripMenuItem"
        Me.PedidosDeVentaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.PedidosDeVentaToolStripMenuItem.Text = "Pedidos de Venta"
        '
        'RecibosToolStripMenuItem
        '
        Me.RecibosToolStripMenuItem.Name = "RecibosToolStripMenuItem"
        Me.RecibosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RecibosToolStripMenuItem.Text = "Recibos"
        '
        'TransportesToolStripMenuItem
        '
        Me.TransportesToolStripMenuItem.Name = "TransportesToolStripMenuItem"
        Me.TransportesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TransportesToolStripMenuItem.Text = "Transportes"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadesToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.MarcaModeloToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ActividadesToolStripMenuItem
        '
        Me.ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        Me.ActividadesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ActividadesToolStripMenuItem.Text = "Actividades"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AlmacenesToolStripMenuItem.Text = "Almacenes"
        '
        'MarcaModeloToolStripMenuItem
        '
        Me.MarcaModeloToolStripMenuItem.Name = "MarcaModeloToolStripMenuItem"
        Me.MarcaModeloToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MarcaModeloToolStripMenuItem.Text = "Marca/Modelo"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogoDeProductosToolStripMenuItem, Me.RGastosToolStripMenuItem, Me.RGerenciaToolStripMenuItem, Me.RInventatrioToolStripMenuItem, Me.RVendedoresToolStripMenuItem, Me.RVentasToolStripMenuItem, Me.ImpresiónDeEtiquetasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CatálogoDeProductosToolStripMenuItem
        '
        Me.CatálogoDeProductosToolStripMenuItem.Name = "CatálogoDeProductosToolStripMenuItem"
        Me.CatálogoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CatálogoDeProductosToolStripMenuItem.Text = "Catálogo de Productos"
        '
        'RGastosToolStripMenuItem
        '
        Me.RGastosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConciliaciónBancariaToolStripMenuItem, Me.RelaciónDeGastosToolStripMenuItem})
        Me.RGastosToolStripMenuItem.Name = "RGastosToolStripMenuItem"
        Me.RGastosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RGastosToolStripMenuItem.Text = "R. Gastos"
        '
        'ConciliaciónBancariaToolStripMenuItem
        '
        Me.ConciliaciónBancariaToolStripMenuItem.Name = "ConciliaciónBancariaToolStripMenuItem"
        Me.ConciliaciónBancariaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConciliaciónBancariaToolStripMenuItem.Text = "Conciliación Bancaria"
        '
        'RelaciónDeGastosToolStripMenuItem
        '
        Me.RelaciónDeGastosToolStripMenuItem.Name = "RelaciónDeGastosToolStripMenuItem"
        Me.RelaciónDeGastosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RelaciónDeGastosToolStripMenuItem.Text = "Relación de gastos"
        '
        'RGerenciaToolStripMenuItem
        '
        Me.RGerenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosOcultosToolStripMenuItem})
        Me.RGerenciaToolStripMenuItem.Name = "RGerenciaToolStripMenuItem"
        Me.RGerenciaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RGerenciaToolStripMenuItem.Text = "R. Gerencia"
        '
        'ProductosOcultosToolStripMenuItem
        '
        Me.ProductosOcultosToolStripMenuItem.Name = "ProductosOcultosToolStripMenuItem"
        Me.ProductosOcultosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProductosOcultosToolStripMenuItem.Text = "Productos Ocultos"
        '
        'RInventatrioToolStripMenuItem
        '
        Me.RInventatrioToolStripMenuItem.Name = "RInventatrioToolStripMenuItem"
        Me.RInventatrioToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RInventatrioToolStripMenuItem.Text = "R. Inventario"
        '
        'RVendedoresToolStripMenuItem
        '
        Me.RVendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChequesDevueltosToolStripMenuItem, Me.DevolucionesPorDañosToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.NotasDeCréditoPendientesToolStripMenuItem, Me.RelaciónDeDocumentosToolStripMenuItem})
        Me.RVendedoresToolStripMenuItem.Name = "RVendedoresToolStripMenuItem"
        Me.RVendedoresToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RVendedoresToolStripMenuItem.Text = "R. Vendedores"
        '
        'ChequesDevueltosToolStripMenuItem
        '
        Me.ChequesDevueltosToolStripMenuItem.Name = "ChequesDevueltosToolStripMenuItem"
        Me.ChequesDevueltosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ChequesDevueltosToolStripMenuItem.Text = "Cheques Devueltos"
        '
        'DevolucionesPorDañosToolStripMenuItem
        '
        Me.DevolucionesPorDañosToolStripMenuItem.Name = "DevolucionesPorDañosToolStripMenuItem"
        Me.DevolucionesPorDañosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DevolucionesPorDañosToolStripMenuItem.Text = "Devoluciones por daños"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'NotasDeCréditoPendientesToolStripMenuItem
        '
        Me.NotasDeCréditoPendientesToolStripMenuItem.Name = "NotasDeCréditoPendientesToolStripMenuItem"
        Me.NotasDeCréditoPendientesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.NotasDeCréditoPendientesToolStripMenuItem.Text = "Notas de crédito pendientes"
        '
        'RelaciónDeDocumentosToolStripMenuItem
        '
        Me.RelaciónDeDocumentosToolStripMenuItem.Name = "RelaciónDeDocumentosToolStripMenuItem"
        Me.RelaciónDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.RelaciónDeDocumentosToolStripMenuItem.Text = "Relación de Documentos"
        '
        'RVentasToolStripMenuItem
        '
        Me.RVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibroDeVentasToolStripMenuItem})
        Me.RVentasToolStripMenuItem.Name = "RVentasToolStripMenuItem"
        Me.RVentasToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RVentasToolStripMenuItem.Text = "R. Ventas"
        '
        'LibroDeVentasToolStripMenuItem
        '
        Me.LibroDeVentasToolStripMenuItem.Name = "LibroDeVentasToolStripMenuItem"
        Me.LibroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LibroDeVentasToolStripMenuItem.Text = "Libro de Ventas"
        '
        'ImpresiónDeEtiquetasToolStripMenuItem
        '
        Me.ImpresiónDeEtiquetasToolStripMenuItem.Name = "ImpresiónDeEtiquetasToolStripMenuItem"
        Me.ImpresiónDeEtiquetasToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImpresiónDeEtiquetasToolStripMenuItem.Text = "Impresión de Etiquetas"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesEliminadosToolStripMenuItem, Me.CódigosEliminadosToolStripMenuItem, Me.AdminProveedoresToolStripMenuItem, Me.AdminTipoDeUsuarioToolStripMenuItem, Me.AdminUsuarioToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'ClientesEliminadosToolStripMenuItem
        '
        Me.ClientesEliminadosToolStripMenuItem.Name = "ClientesEliminadosToolStripMenuItem"
        Me.ClientesEliminadosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ClientesEliminadosToolStripMenuItem.Text = "Clientes Eliminados"
        '
        'CódigosEliminadosToolStripMenuItem
        '
        Me.CódigosEliminadosToolStripMenuItem.Name = "CódigosEliminadosToolStripMenuItem"
        Me.CódigosEliminadosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CódigosEliminadosToolStripMenuItem.Text = "Códigos Eliminados"
        '
        'AdminProveedoresToolStripMenuItem
        '
        Me.AdminProveedoresToolStripMenuItem.Name = "AdminProveedoresToolStripMenuItem"
        Me.AdminProveedoresToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AdminProveedoresToolStripMenuItem.Text = "Admin. Proveedores"
        '
        'AdminTipoDeUsuarioToolStripMenuItem
        '
        Me.AdminTipoDeUsuarioToolStripMenuItem.Name = "AdminTipoDeUsuarioToolStripMenuItem"
        Me.AdminTipoDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AdminTipoDeUsuarioToolStripMenuItem.Text = "Admin. Tipo de Usuario"
        '
        'AdminUsuarioToolStripMenuItem
        '
        Me.AdminUsuarioToolStripMenuItem.Name = "AdminUsuarioToolStripMenuItem"
        Me.AdminUsuarioToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AdminUsuarioToolStripMenuItem.Text = "Admin. Usuarios"
        '
        'AGSADToolStripMenuItem
        '
        Me.AGSADToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadísticasDeVentasToolStripMenuItem, Me.AnálisisDeDecisionesToolStripMenuItem, Me.AnálisisDeProductosToolStripMenuItem, Me.AnálisisDePedidosToolStripMenuItem, Me.AnálisisDeVendedoresToolStripMenuItem, Me.AnálisisDeZonasToolStripMenuItem, Me.MovimientoProductosToolStripMenuItem})
        Me.AGSADToolStripMenuItem.Name = "AGSADToolStripMenuItem"
        Me.AGSADToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AGSADToolStripMenuItem.Text = "AG-SAD"
        '
        'EstadísticasDeVentasToolStripMenuItem
        '
        Me.EstadísticasDeVentasToolStripMenuItem.Name = "EstadísticasDeVentasToolStripMenuItem"
        Me.EstadísticasDeVentasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EstadísticasDeVentasToolStripMenuItem.Text = "Estadísticas de ventas"
        '
        'AnálisisDeDecisionesToolStripMenuItem
        '
        Me.AnálisisDeDecisionesToolStripMenuItem.Name = "AnálisisDeDecisionesToolStripMenuItem"
        Me.AnálisisDeDecisionesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnálisisDeDecisionesToolStripMenuItem.Text = "Análisis de decisiones"
        '
        'AnálisisDeProductosToolStripMenuItem
        '
        Me.AnálisisDeProductosToolStripMenuItem.Name = "AnálisisDeProductosToolStripMenuItem"
        Me.AnálisisDeProductosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnálisisDeProductosToolStripMenuItem.Text = "Análisis de productos"
        '
        'AnálisisDePedidosToolStripMenuItem
        '
        Me.AnálisisDePedidosToolStripMenuItem.Name = "AnálisisDePedidosToolStripMenuItem"
        Me.AnálisisDePedidosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnálisisDePedidosToolStripMenuItem.Text = "Análisis de pedidos"
        '
        'AnálisisDeVendedoresToolStripMenuItem
        '
        Me.AnálisisDeVendedoresToolStripMenuItem.Name = "AnálisisDeVendedoresToolStripMenuItem"
        Me.AnálisisDeVendedoresToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnálisisDeVendedoresToolStripMenuItem.Text = "Análisis de vendedores"
        '
        'AnálisisDeZonasToolStripMenuItem
        '
        Me.AnálisisDeZonasToolStripMenuItem.Name = "AnálisisDeZonasToolStripMenuItem"
        Me.AnálisisDeZonasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnálisisDeZonasToolStripMenuItem.Text = "Análisis de zonas"
        '
        'MovimientoProductosToolStripMenuItem
        '
        Me.MovimientoProductosToolStripMenuItem.Name = "MovimientoProductosToolStripMenuItem"
        Me.MovimientoProductosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MovimientoProductosToolStripMenuItem.Text = "Movimiento Productos"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.CobranzasToolStripMenuItem, Me.CorreosToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.WEBToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuración"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'CobranzasToolStripMenuItem
        '
        Me.CobranzasToolStripMenuItem.Name = "CobranzasToolStripMenuItem"
        Me.CobranzasToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CobranzasToolStripMenuItem.Text = "Cobranzas"
        '
        'CorreosToolStripMenuItem
        '
        Me.CorreosToolStripMenuItem.Name = "CorreosToolStripMenuItem"
        Me.CorreosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CorreosToolStripMenuItem.Text = "Correos"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'WEBToolStripMenuItem
        '
        Me.WEBToolStripMenuItem.Name = "WEBToolStripMenuItem"
        Me.WEBToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.WEBToolStripMenuItem.Text = "WEB"
        '
        'Frm_Principal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 713)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1034, 742)
        Me.MinimumSize = New System.Drawing.Size(1034, 742)
        Me.Name = "Frm_Principal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_OtrosAUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_UsuarioAOtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Recordatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Private WithEvents taskbarNotifier1 As TaskBarNotifier

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_clientes Then

            If Not IsNothing(f2) Then

                If Not f2.IsDisposed Then

                    f2.WindowState = FormWindowState.Normal
                    f2.BringToFront()

                Else

                    f2 = New Frm_Clientes

                    For cont As Integer = 0 To frm.Rows.Count - 1
                        If frm.Rows(cont).Item(0).ToString.ToUpper = ("Clientes").ToUpper Then
                            f2.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                            cont = frm.Rows.Count
                        End If
                    Next


                    f2.Show()

                End If

            Else

                f2 = New Frm_Clientes

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Clientes").ToUpper Then
                        f2.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f2.Show()

            End If

        ElseIf e.Button Is Me.bt_proveedores Then

            If Not IsNothing(f4) Then

                If Not f4.IsDisposed Then

                    f4.WindowState = FormWindowState.Normal
                    f4.BringToFront()

                Else

                    f4 = New Frm_Proveedores

                    For cont As Integer = 0 To frm.Rows.Count - 1
                        If frm.Rows(cont).Item(0).ToString.ToUpper = ("Proveedores").ToUpper Then
                            f4.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        End If
                    Next


                    f4.Show()

                End If

            Else

                f4 = New Frm_Proveedores

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Proveedores").ToUpper Then
                        f4.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    End If
                Next

                f4.Show()

            End If

        ElseIf e.Button Is Me.bt_productos Then

            If Not IsNothing(f5) Then

                If Not f5.IsDisposed Then

                    f5.WindowState = FormWindowState.Normal
                    f5.BringToFront()

                Else

                    f5 = New Frm_Productos

                    For cont As Integer = 0 To frm.Rows.Count - 1
                        If frm.Rows(cont).Item(0).ToString.ToUpper = ("Inventario").ToUpper Then
                            f5.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        End If
                    Next


                    f5.Show()

                End If

            Else

                f5 = New Frm_Productos

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Inventario").ToUpper Then
                        f5.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    End If
                Next

                f5.Show()

            End If

        ElseIf e.Button Is Me.bt_compras Then

            If Not IsNothing(f17) Then

                If Not f17.IsDisposed Then

                    f17.WindowState = FormWindowState.Normal
                    f17.BringToFront()

                Else

                    f17 = New Frm_Compras

                    For cont As Integer = 0 To frm.Rows.Count - 1
                        If frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                            f17.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                            cont = frm.Rows.Count
                        End If
                    Next

                    f17.Show()

                End If

            Else

                f17 = New Frm_Compras

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                        f17.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f17.Show()

            End If

        ElseIf e.Button Is Me.bt_reportes Then
            If Not IsNothing(f35) Then

                If Not f35.IsDisposed Then

                    f35.WindowState = FormWindowState.Normal
                    f35.BringToFront()

                Else

                    f35 = New Frm_Guia_Transporte
                    f35.Show()

                End If

            Else

                f35 = New Frm_Guia_Transporte

                f35.Show()

            End If
        ElseIf e.Button Is Me.bt_salir Then
            Me.Close()
        End If
    End Sub

    Private Sub Frm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        NotifyIcon1.Visible = False

    End Sub

    Private Sub Frm_Principal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus, Me.Activated

        Me.TopMost = False

        Dim cont As Integer = 0

        If conex.State = ConnectionState.Broken Or conex.State = ConnectionState.Closed Then

            conex.Open()

        End If

        DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 3, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, cont, Today, Today)

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Dim MiSplashForm As New Frm_Logo
        With MiSplashForm.Timer1
            .Interval = 1000
            .Enabled = True
        End With
        MiSplashForm.ShowDialog(Me)
        MiSplashForm.Dispose()

        Me.Height = 800
        Me.Width = 1280

        Datos.consultaLogo(Me.PictureBox3)

        Dim cont As Integer = 0

        DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 1, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, cont, Today, Today)

        If cont > 0 Then

            If My.Settings.Empresa = 1 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "C. BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "C. BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 2 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 3 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 4 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "D. BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "D. BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            End If

            My.Computer.Audio.Play(My.Resources.ZMensaje, AudioPlayMode.Background)

        End If

        LinkLabel2.Tag = False
        LinkLabel3.Tag = False
        LinkLabel4.Tag = False
        LinkLabel5.Tag = False
        LinkLabel6.Tag = False
        LinkLabel7.Tag = False
        LinkLabel8.Tag = False
        LinkLabel9.Tag = False

    End Sub

    Public Shared Property Frm_Clientes() As Frm_Clientes
        Get
            Return f2
        End Get
        Set(ByVal Value As Frm_Clientes)
            f2 = Value
        End Set
    End Property

    Public Shared Property Frm_Facturas_Ventas() As Frm_Facturas_Ventas
        Get
            Return f13
        End Get
        Set(ByVal Value As Frm_Facturas_Ventas)
            f13 = Value
        End Set
    End Property

    Public Shared Property Frm_Productos() As Frm_Productos
        Get
            Return f5
        End Get
        Set(ByVal Value As Frm_Productos)
            f5 = Value
        End Set
    End Property
    Public Shared Property Frm_Proveedores() As Frm_Proveedores
        Get
            Return f4
        End Get
        Set(ByVal Value As Frm_Proveedores)
            f4 = Value
        End Set
    End Property
    Public Shared Property Frm_Compras() As Frm_Compras
        Get
            Return f17
        End Get
        Set(ByVal Value As Frm_Compras)
            f17 = Value
        End Set
    End Property
    Public Shared Property Frm_Pedidos_Clientes() As Frm_Pedidos_Clientes
        Get
            Return f14
        End Get
        Set(ByVal Value As Frm_Pedidos_Clientes)
            f14 = Value
        End Set
    End Property

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not IsNothing(f17) Then

            If Not f17.IsDisposed Then

                f17.WindowState = FormWindowState.Normal
                f17.BringToFront()

            Else

                f17 = New Frm_Compras
                sw = True
                f17.Show()

            End If

        Else

            f17 = New Frm_Compras
            sw = True
            f17.Show()

        End If


    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r_Lis As New R_Listado_Modelo
        r_Lis.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r_Lis_Alf As New R_Listado_Alfabetico
        r_Lis_Alf.Show()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNothing(f36) Then

            If Not f36.IsDisposed Then

                f36.recibe(0)
                f36.WindowState = FormWindowState.Normal
                f36.BringToFront()

            Else

                f36 = New Frm_Parametro_Fecha
                f36.recibe(0)
                f36.Show()

            End If

        Else

            f36 = New Frm_Parametro_Fecha
            f36.recibe(0)
            f36.Show()

        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_Parametro_Dias.Show()
        Frm_Parametro_Dias.Tipo = 1
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not IsNothing(f36) Then

            If Not f36.IsDisposed Then

                f36.WindowState = FormWindowState.Normal
                f36.BringToFront()

            Else

                f36 = New Frm_Parametro_Fecha
                f36.recibe(0)
                f36.Show()

            End If

        Else

            f36 = New Frm_Parametro_Fecha
            f36.recibe(0)
            f36.Show()

        End If

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Public Sub Cerrar() Handles Me.FormClosed
        End
    End Sub


    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub MenuItem30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Public Sub esconderMenuItem(ByVal tipo As Integer)

        Dim tipo2 As Integer = 0
        Dim nombre As String = ""
        tipo2 = tipo
        Dim colec As New Collection

        frm.Columns.Add(New DataColumn("Nombre"))
        frm.Columns.Add(New DataColumn("Escribir", GetType(Boolean)))
        frm.Columns.Add(New DataColumn("Especial", GetType(Boolean)))

        DatosTipoUsurio.llenarTipoNombre(tipo2, frm, 1)

        'Inventario
        verificar(InventarioToolStripMenuItem, frm)
        verificar(CódigosArancelariosToolStripMenuItem, frm)
        verificar(GruposToolStripMenuItem, frm)
        verificar(InfoGeneralToolStripMenuItem, frm)
        verificar(InvenatarioToolStripMenuItem, frm)
        verificar(AjustesToolStripMenuItem, frm)
        verificar(VariaciónLinealToolStripMenuItem, frm)
        verificar(InvToolStripMenuItem, frm)

        'Compras
        verificar(PedidosDeCompraToolStripMenuItem, frm)
        verificar(ComprasCargadasToolStripMenuItem, frm)
        verificar(PedidosDeComprasToolStripMenuItem, frm)
        verificar(ProveedoresToolStripMenuItem, frm)

        'Ventas
        verificar(VentasToolStripMenuItem, frm)
        verificar(TransportesToolStripMenuItem, frm)
        verificar(VendedoresToolStripMenuItem, frm)
        verificar(PedidosDeVentaToolStripMenuItem, frm)
        verificar(AsociaciónDeMovimientosToolStripMenuItem, frm)
        verificar(ManejoDeFacturasEmitidadToolStripMenuItem, frm)
        verificar(NotasDeCréditoToolStripMenuItem, frm)
        verificar(RecibosToolStripMenuItem, frm)
        verificar(ClientesToolStripMenuItem, frm)
        verificar(ComisionesToolStripMenuItem, frm)
        verificar(AjustesDeNotasDeCToolStripMenuItem, frm)
        verificar(FacturasPorCobrarToolStripMenuItem, frm)
        verificar(AjustesDeSaldosToolStripMenuItem, frm)
        verificar(MovimientosToolStripMenuItem, frm)
        verificar(CompetenciaToolStripMenuItem, frm)
        verificar(ChequeDePedidosToolStripMenuItem, frm)

        'Herramientas
        verificar(HerramientasToolStripMenuItem, frm)
        verificar(AlmacenesToolStripMenuItem, frm)
        verificar(MarcaModeloToolStripMenuItem, frm)

        'Reportes
        verificar(ReportesToolStripMenuItem, frm)
        verificar(RInventatrioToolStripMenuItem, frm)
        verificar(RVendedoresToolStripMenuItem, frm)
        verificar(RVentasToolStripMenuItem, frm)
        verificar(ChequesDevueltosToolStripMenuItem, frm)
        verificar(NotasDeCréditoPendientesToolStripMenuItem, frm)
        verificar(LibroDeVentasToolStripMenuItem, frm)
        verificar(RelaciónDeDocumentosToolStripMenuItem, frm)
        verificar(DevolucionesPorDañosToolStripMenuItem, frm)
        verificar(CatálogoDeProductosToolStripMenuItem, frm)
        verificar(RGastosToolStripMenuItem, frm)
        verificar(ConciliaciónBancariaToolStripMenuItem, frm)
        verificar(RelaciónDeGastosToolStripMenuItem, frm)
        verificar(RGerenciaToolStripMenuItem, frm)
        verificar(ProductosOcultosToolStripMenuItem, frm)

        'Administrador
        verificar(AdministradorToolStripMenuItem, frm)
        verificar(AdminProveedoresToolStripMenuItem, frm)
        verificar(AdminTipoDeUsuarioToolStripMenuItem, frm)
        verificar(AdminUsuarioToolStripMenuItem, frm)
        verificar(CódigosEliminadosToolStripMenuItem, frm)
        verificar(ClientesEliminadosToolStripMenuItem, frm)

        'AG-SAD
        verificar(AGSADToolStripMenuItem, frm)
        verificar(EstadísticasDeVentasToolStripMenuItem, frm)
        verificar(AnálisisDeDecisionesToolStripMenuItem, frm)
        verificar(AnálisisDePedidosToolStripMenuItem, frm)
        verificar(AnálisisDeProductosToolStripMenuItem, frm)
        verificar(AnálisisDeVendedoresToolStripMenuItem, frm)
        verificar(AnálisisDeZonasToolStripMenuItem, frm)
        verificar(MovimientoProductosToolStripMenuItem, frm)

        'Configuración
        verificar(ConfiguracionToolStripMenuItem, frm)
        verificar(GeneralToolStripMenuItem, frm)
        verificar(CorreosToolStripMenuItem, frm)
        verificar(CobranzasToolStripMenuItem, frm)
        verificar(PedidosToolStripMenuItem, frm)
        verificar(WEBToolStripMenuItem, frm)

    End Sub


    Private Sub verificar(ByVal menu As ToolStripMenuItem, ByVal f As DataTable)

        Dim cont As Integer = 0
        Dim esta As Boolean = False

        For cont = 0 To f.Rows.Count - 1

            If f.Rows(cont).Item(0).ToString.ToUpper = menu.Text.ToUpper Then
                esta = True
            End If
        Next

        If esta = True Then

            menu.Visible = True

            If menu.Text = "Clientes" Then
                Me.bt_clientes.Visible = True
            End If

            If menu.Text = "Proveedores" Then
                Me.bt_proveedores.Visible = True
            End If

            If menu.Text = "Info. General" Then
                Me.bt_compras.Visible = True
            End If

            If menu.Text = "Transportes" Then
                Me.bt_reportes.Visible = True
            End If

            If menu.Text = "Inventario" Then
                Me.bt_productos.Visible = True
            End If

        Else

            menu.Visible = False

            If menu.Text = "Clientes" Then
                Me.bt_clientes.Visible = False
            End If

            If menu.Text = "Proveedores" Then
                Me.bt_proveedores.Visible = False
            End If

            If menu.Text = "Info. General" Then
                Me.bt_compras.Visible = False
            End If

            If menu.Text = "Transportes" Then
                Me.bt_reportes.Visible = False
            End If
            If menu.Text = "Inventario" Then
                Me.bt_productos.Visible = False
            End If

        End If

        esta = False

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not IsNothing(f43) Then

            If Not f43.IsDisposed Then

                f43.WindowState = FormWindowState.Normal
                f43.BringToFront()

            Else

                f43 = New Frm_Traspasos
                f43.Show()

            End If

        Else

            f43 = New Frm_Traspasos
            f43.Show()

        End If

    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub mi_catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub bt_crearMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_crearMensaje.Click

        If Not IsNothing(f46) Then

            If Not f46.IsDisposed Then

                f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f46.WindowState = FormWindowState.Normal
                f46.bt_eliminar.Visible = False
                f46.chk_finalizado.Visible = False
                f46.BringToFront()

            Else

                f46 = New Frm_CrearMensaje
                f46.bt_eliminar.Visible = False
                f46.chk_finalizado.Visible = False
                f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f46.Show()

            End If

        Else

            f46 = New Frm_CrearMensaje
            f46.bt_eliminar.Visible = False
            f46.chk_finalizado.Visible = False
            f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f46.Show()

        End If

    End Sub

    Private Sub DGV_Recordatorio_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Recordatorio.CellDoubleClick

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim frm As New Frm_CrearMensaje
            frm.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            frm.id_m = CInt(DGV_Recordatorio.SelectedRows(0).Cells(0).Value)
            frm.Show()

        End If

    End Sub

    Private Sub DGV_UsuarioAOtros_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_UsuarioAOtros.CellDoubleClick

        If DGV_UsuarioAOtros.SelectedRows.Count > 0 Then

            Dim frm As New Frm_Respuestas
            frm.user = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            frm.id_m = CInt(DGV_UsuarioAOtros.SelectedRows(0).Cells(0).Value)
            frm.Show()

        End If

    End Sub


    Private Sub DGV_OtrosAUsuario_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_OtrosAUsuario.CellDoubleClick

        If DGV_OtrosAUsuario.SelectedRows.Count > 0 Then

            Dim frm As New Frm_Respuestas
            frm.user = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            frm.id_m = CInt(DGV_OtrosAUsuario.SelectedRows(0).Cells(0).Value)
            frm.Show()

        End If

    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If LinkLabel3.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 1, 0, Today, Today)
            LinkLabel3.Tag = True

        ElseIf LinkLabel3.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 2, 0, Today, Today)
            LinkLabel3.Tag = False

        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If LinkLabel2.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 3, 0, Today, Today)
            LinkLabel2.Tag = True

        ElseIf LinkLabel2.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 4, 0, Today, Today)
            LinkLabel2.Tag = False

        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        If LinkLabel4.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, 0, Today, Today)
            LinkLabel4.Tag = True

        ElseIf LinkLabel4.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 7, 0, Today, Today)
            LinkLabel4.Tag = False

        End If

    End Sub


    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked

        If LinkLabel5.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 8, 0, Today, Today)
            LinkLabel5.Tag = True

        ElseIf LinkLabel5.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 9, 0, Today, Today)
            LinkLabel5.Tag = False

        End If

    End Sub

    '          -------------------------------------------------

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked

        If LinkLabel6.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, 0, Today, Today)
            LinkLabel6.Tag = True

        ElseIf LinkLabel6.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 14, 0, Today, Today)
            LinkLabel6.Tag = False

        End If

    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked

        If LinkLabel7.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 15, 0, Today, Today)
            LinkLabel7.Tag = True

        ElseIf LinkLabel7.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 16, 0, Today, Today)
            LinkLabel7.Tag = False

        End If

    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked

        If LinkLabel8.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 10, 0, Today, Today)
            LinkLabel8.Tag = True

        ElseIf LinkLabel8.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 11, 0, Today, Today)
            LinkLabel8.Tag = False

        End If

    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked

        If LinkLabel9.Tag = False Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 17, 0, Today, Today)
            LinkLabel9.Tag = True

        ElseIf LinkLabel9.Tag = True Then

            DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 18, 0, Today, Today)
            LinkLabel9.Tag = False

        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim cont As Integer = 0

        DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 3, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, cont, Today, Today)

        If cont > 0 Then

            If My.Settings.Empresa = 1 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 2 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 3 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            End If

            My.Computer.Audio.Play(My.Resources.ZMensaje, AudioPlayMode.Background)

        End If

    End Sub

    Public Sub bt_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_actualizar.Click

        Dim cont As Integer = 0

        If conex.State = ConnectionState.Broken Or conex.State = ConnectionState.Closed Then

            conex.Open()

        End If

        DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 3, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, cont, Today, Today)

        If cont > 0 Then

            If My.Settings.Empresa = 1 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "BRWME: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 2 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 3 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            End If

            My.Computer.Audio.Play(My.Resources.ZMensaje, AudioPlayMode.Background)

        End If

    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then

            Me.BringToFront()
            Me.TopMost = True
            Me.Focus()

        End If

    End Sub

    Private Sub ActualizarBandejasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarBandejasToolStripMenuItem.Click

        Dim cont As Integer = 0

        If conex.State = ConnectionState.Broken Or conex.State = ConnectionState.Closed Then

            conex.Open()

        End If

        DatosMensaje.consulta_Mensajes(DGV_Recordatorio, 0, 3, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_UsuarioAOtros, 0, 6, cont, Today, Today)
        DatosMensaje.consulta_Mensajes(DGV_OtrosAUsuario, 0, 13, cont, Today, Today)

        If cont > 0 Then

            If My.Settings.Empresa = 2 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "AGSA: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            ElseIf My.Settings.Empresa = 3 Then

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada", ToolTipIcon.Info)

                NotifyIcon1.Text = "Mil26: Tiene " & cont.ToString & " mensajes sin leer en sus bandejas de entrada"

            End If

            My.Computer.Audio.Play(My.Resources.ZMensaje, AudioPlayMode.Background)

        End If

    End Sub

    Private Sub CrearMensajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearMensajeToolStripMenuItem.Click

        If Not IsNothing(f46) Then

            If Not f46.IsDisposed Then

                f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f46.WindowState = FormWindowState.Normal
                f46.bt_eliminar.Visible = False
                f46.chk_finalizado.Visible = False
                f46.BringToFront()

            Else

                f46 = New Frm_CrearMensaje
                f46.bt_eliminar.Visible = False
                f46.chk_finalizado.Visible = False
                f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f46.Show()

            End If

        Else

            f46 = New Frm_CrearMensaje
            f46.bt_eliminar.Visible = False
            f46.chk_finalizado.Visible = False
            f46.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f46.Show()

        End If

    End Sub

    Private Sub AjustesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesToolStripMenuItem.Click

        If Not IsNothing(f8) Then

            If Not f8.IsDisposed Then

                f8.WindowState = FormWindowState.Normal
                f8.BringToFront()

            Else

                f8 = New Frm_Ajustes
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Ajustes").ToUpper Then
                        f8.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f8.Show()

            End If

        Else

            f8 = New Frm_Ajustes
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Ajustes").ToUpper Then
                    f8.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f8.Show()

        End If
    End Sub

    Private Sub CódigosArancelariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigosArancelariosToolStripMenuItem.Click

        If Not IsNothing(f21) Then

            If Not f21.IsDisposed Then

                f21.WindowState = FormWindowState.Normal
                f21.BringToFront()

            Else

                f21 = New Frm_Codigos_Arancelarios
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Códigos Arancelarios").ToUpper Then
                        f21.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f21.Show()

            End If

        Else

            f21 = New Frm_Codigos_Arancelarios
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Códigos Arancelarios").ToUpper Then
                    f21.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f21.Show()

        End If
    End Sub

    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click

        If Not IsNothing(f31) Then

            If Not f31.IsDisposed Then

                f31.WindowState = FormWindowState.Normal
                f31.BringToFront()

            Else

                f31 = New Frm_Grupos
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Grupos").ToUpper Then
                        f31.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f31.Show()

            End If

        Else

            f31 = New Frm_Grupos
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Grupos").ToUpper Then
                    f31.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f31.Show()

        End If

    End Sub

    Private Sub InfoGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoGeneralToolStripMenuItem.Click

        If Not IsNothing(f17) Then

            If Not f17.IsDisposed Then

                f17.WindowState = FormWindowState.Normal
                f17.BringToFront()

            Else

                f17 = New Frm_Compras

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                        f17.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f17.Show()

            End If

        Else

            f17 = New Frm_Compras

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                    f17.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next

            f17.Show()

        End If

    End Sub

    Private Sub InvenatarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvenatarioToolStripMenuItem.Click


        If Not IsNothing(f5) Then

            If Not f5.IsDisposed Then

                f5.WindowState = FormWindowState.Normal
                f5.BringToFront()

            Else

                f5 = New Frm_Productos
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Inventario").ToUpper Then
                        f5.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    End If
                Next
                f5.Show()

            End If

        Else

            f5 = New Frm_Productos
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Inventario").ToUpper Then
                    f5.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                End If
            Next
            f5.Show()

        End If

    End Sub

    Private Sub VariaciónLinealToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariaciónLinealToolStripMenuItem.Click

        If Not IsNothing(f44) Then

            If Not f44.IsDisposed Then

                f44.WindowState = FormWindowState.Normal
                f44.BringToFront()

            Else

                f44 = New s
                f44.Show()

            End If

        Else

            f44 = New s
            f44.Show()

        End If
    End Sub

    Private Sub ComprasCargadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasCargadasToolStripMenuItem.Click

        If Not IsNothing(f24) Then

            If Not f24.IsDisposed Then

                f24.WindowState = FormWindowState.Normal
                f24.BringToFront()

            Else

                f24 = New Frm_Comprascargadas
                f24.Show()

            End If

        Else

            f24 = New Frm_Comprascargadas
            f24.Show()

        End If
    End Sub

    Private Sub PedidosDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosDeComprasToolStripMenuItem.Click


        If Not IsNothing(f38) Then

            If Not f38.IsDisposed Then

                f38.WindowState = FormWindowState.Normal
                f38.BringToFront()

            Else

                f38 = New Frm_Pedidos_Proveedores

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Pedidos de Compras").ToUpper Then
                        f38.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f38.Show()

            End If

        Else

            f38 = New Frm_Pedidos_Proveedores

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Pedidos de Compras").ToUpper Then
                    f38.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next

            f38.Show()

        End If

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click

        If Not IsNothing(f4) Then

            If Not f4.IsDisposed Then

                f4.WindowState = FormWindowState.Normal
                f4.BringToFront()

            Else

                f4 = New Frm_Proveedores
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Proveedores").ToUpper Then
                        f4.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f4.Show()

            End If

        Else

            f4 = New Frm_Proveedores
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Proveedores").ToUpper Then
                    f4.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f4.Show()

        End If
    End Sub

    Private Sub AjustesDeSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesDeSaldosToolStripMenuItem.Click

        If Not IsNothing(f9) Then

            If Not f9.IsDisposed Then

                f9.WindowState = FormWindowState.Normal
                f9.BringToFront()

            Else

                f9 = New Frm_AjusteSaldos
                f9.usuario(Frm_Login.user)
                f9.Show()

            End If

        Else

            f9 = New Frm_AjusteSaldos
            f9.usuario(Frm_Login.user)
            f9.Show()

        End If
    End Sub

    Private Sub AsociaciónDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsociaciónDeMovimientosToolStripMenuItem.Click

        If Not IsNothing(f26) Then

            If Not f26.IsDisposed Then

                f26.WindowState = FormWindowState.Normal
                f26.BringToFront()

            Else

                f26 = New Frm_Consulta_Movimientos
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Asociación de Movimientos").ToUpper Then
                        f26.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f26.Show()

            End If

        Else

            f26 = New Frm_Consulta_Movimientos
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Asociación de Movimientos").ToUpper Then
                    f26.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f26.Show()

        End If
    End Sub

    Private Sub ChequeDePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeDePedidosToolStripMenuItem.Click

        If Not IsNothing(f19) Then

            If Not f19.IsDisposed Then

                f19.WindowState = FormWindowState.Normal
                f19.BringToFront()

            Else

                f19 = New Frm_chequeoPedidos
                f19.Show()

            End If

        Else

            f19 = New Frm_chequeoPedidos
            f19.Show()

        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click

        If Not IsNothing(f2) Then

            If Not f2.IsDisposed Then

                f2.WindowState = FormWindowState.Normal
                f2.BringToFront()

            Else

                f2 = New Frm_Clientes
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Clientes").ToUpper Then
                        f2.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f2.Show()

            End If

        Else

            f2 = New Frm_Clientes
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Clientes").ToUpper Then
                    f2.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f2.Show()

        End If
    End Sub

    Private Sub ComisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComisionesToolStripMenuItem.Click

        If Not IsNothing(f22) Then

            If Not f22.IsDisposed Then

                f22.WindowState = FormWindowState.Normal
                f22.BringToFront()

            Else

                f22 = New Frm_Comisiones
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Comisiones").ToUpper Then
                        f22.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f22.Show()

            End If

        Else

            f22 = New Frm_Comisiones
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Comisiones").ToUpper Then
                    f22.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f22.Show()

        End If
    End Sub

    Private Sub CompetenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompetenciaToolStripMenuItem.Click

        If Not IsNothing(f23) Then

            If Not f23.IsDisposed Then

                f23.WindowState = FormWindowState.Normal
                f23.BringToFront()

            Else

                f23 = New Frm_Competencia
                f23.Show()

            End If

        Else

            f23 = New Frm_Competencia
            f23.Show()

        End If
    End Sub

    Private Sub FacturasPorCobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasPorCobrarToolStripMenuItem.Click

        If Not IsNothing(f12) Then

            If Not f12.IsDisposed Then

                f12.WindowState = FormWindowState.Normal
                f12.BringToFront()

            Else

                f12 = New Frm_Analisis_Cobranza
                f12.Show()

            End If

        Else

            f12 = New Frm_Analisis_Cobranza
            f12.Show()

        End If
    End Sub

    Private Sub ManejoDeFacturasEmitidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManejoDeFacturasEmitidadToolStripMenuItem.Click

        If Not IsNothing(f13) Then

            If Not f13.IsDisposed Then

                f13.WindowState = FormWindowState.Normal
                f13.BringToFront()

            Else

                f13 = New Frm_Facturas_Ventas

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Manejo de facturas emitidas").ToUpper Then
                        f13.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f13.Show()

            End If

        Else

            f13 = New Frm_Facturas_Ventas

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Manejo de facturas emitidas").ToUpper Then
                    f13.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f13.Show()

        End If
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosToolStripMenuItem.Click

        If Not IsNothing(f33) Then

            If Not f33.IsDisposed Then

                f33.WindowState = FormWindowState.Normal
                f33.BringToFront()

            Else

                f33 = New Frm_Movimientos
                f33.Show()

            End If

        Else

            f33 = New Frm_Movimientos
            f33.Show()

        End If
    End Sub

    Private Sub NotasDeCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasDeCréditoToolStripMenuItem.Click

        If Not IsNothing(f34) Then

            If Not f34.IsDisposed Then

                f34.WindowState = FormWindowState.Normal
                f34.BringToFront()

            Else
                f34 = New Frm_NotaCredito
                f34.user = user_n

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Notas de crédito").ToUpper Then
                        f34.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f34.Show()

            End If

        Else

            f34 = New Frm_NotaCredito
            f34.user = user_n

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Notas de crédito").ToUpper Then
                    f34.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f34.Show()

        End If
    End Sub

    Private Sub PedidosDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosDeVentaToolStripMenuItem.Click

        If Not IsNothing(f14) Then

            If Not f14.IsDisposed Then

                f14.WindowState = FormWindowState.Normal
                f14.BringToFront()

            Else

                f14 = New Frm_Pedidos_Clientes
                f14.l_user = user_n

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Pedidos de Venta").ToUpper Then
                        f14.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Facturas").ToUpper Then
                        f14.permisosFac(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f14.Show()

            End If

        Else

            f14 = New Frm_Pedidos_Clientes
            f14.l_user = user_n

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Pedidos de Venta").ToUpper Then
                    f14.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Facturas").ToUpper Then
                    f14.permisosFac(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next

            f14.Show()

        End If
    End Sub

    Private Sub RecibosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosToolStripMenuItem.Click

        If Not IsNothing(f39) Then

            If Not f39.IsDisposed Then

                f39.WindowState = FormWindowState.Normal
                f39.BringToFront()

            Else

                f39 = New Frm_Recibos
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Recibos").ToUpper Then
                        f39.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f39.usuario(user_l, user_n)
                f39.Show()

            End If

        Else

            f39 = New Frm_Recibos
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Recibos").ToUpper Then
                    f39.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f39.usuario(user_l, user_n)
            f39.Show()

        End If
    End Sub

    Private Sub TransportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportesToolStripMenuItem.Click

        If Not IsNothing(f42) Then

            If Not f42.IsDisposed Then

                f42.WindowState = FormWindowState.Normal
                f42.BringToFront()

            Else

                f42 = New Frm_Transportes
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Transportes").ToUpper Then
                        f42.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f42.Show()

            End If

        Else

            f42 = New Frm_Transportes
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Transportes").ToUpper Then
                    f42.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f42.Show()

        End If

    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click

        If Not IsNothing(f45) Then

            If Not f45.IsDisposed Then

                f45.WindowState = FormWindowState.Normal
                f45.BringToFront()

            Else

                f45 = New Frm_Vendedores
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Vendedores").ToUpper Then
                        f45.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f45.Show()

            End If

        Else

            f45 = New Frm_Vendedores
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Vendedores").ToUpper Then
                    f45.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f45.Show()

        End If

    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenesToolStripMenuItem.Click


        If Not IsNothing(f11) Then

            If Not f11.IsDisposed Then

                f11.WindowState = FormWindowState.Normal
                f11.BringToFront()

            Else

                f11 = New Frm_Almacenes

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Almacenes").ToUpper Then
                        f11.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f11.user_l = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f11.Show()

            End If

        Else

            f11 = New Frm_Almacenes

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Almacenes").ToUpper Then
                    f11.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f11.user_l = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f11.Show()

        End If

    End Sub


    Private Sub MarcaModeloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaModeloToolStripMenuItem.Click

        If Not IsNothing(f32) Then

            If Not f32.IsDisposed Then

                f32.WindowState = FormWindowState.Normal
                f32.BringToFront()

            Else
                f32 = New Frm_Marca_Modelo
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Marca/Modelo").ToUpper Then
                        f32.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f32.Show()

            End If

        Else

            f32 = New Frm_Marca_Modelo
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Marca/Modelo").ToUpper Then
                    f32.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f32.Show()

        End If
    End Sub

    Private Sub RInventatrioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RInventatrioToolStripMenuItem.Click
        If Not IsNothing(f18) Then

            If Not f18.IsDisposed Then

                f18.WindowState = FormWindowState.Normal
                f18.BringToFront()

            Else

                f18 = New Frm_CatalogoMarcaModelo
                f18.Show()

            End If

        Else

            f18 = New Frm_CatalogoMarcaModelo
            f18.Show()

        End If
    End Sub

    Private Sub ChequesDevueltosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesDevueltosToolStripMenuItem.Click


        If Not IsNothing(f20) Then

            If Not f20.IsDisposed Then

                f20.Text = "Cheques devueltos"
                f20.WindowState = FormWindowState.Normal
                f20.BringToFront()

            Else

                f20 = New Frm_ChequesDev
                f20.Text = "Cheques devueltos"
                f20.Show()

            End If

        Else

            f20 = New Frm_ChequesDev
            f20.Text = "Cheques devueltos"
            f20.Show()

        End If

    End Sub

    Private Sub DevolucionesPorDañosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DevolucionesPorDañosToolStripMenuItem.Click

        If Not IsNothing(f20) Then

            If Not f20.IsDisposed Then

                f20.WindowState = FormWindowState.Normal
                f20.Text = "Devoluciones por daños"
                f20.Tipo = 1
                f20.BringToFront()

            Else

                f20 = New Frm_ChequesDev
                f20.Text = "Devoluciones por daños"
                f20.Tipo = 1
                f20.Show()

            End If

        Else

            f20 = New Frm_ChequesDev
            f20.Text = "Devoluciones por daños"
            f20.Tipo = 1
            f20.Show()

        End If
    End Sub

    Private Sub RelaciónDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelaciónDeDocumentosToolStripMenuItem.Click

        If Not IsNothing(f40) Then

            If Not f40.IsDisposed Then

                f40.WindowState = FormWindowState.Normal
                f40.BringToFront()

            Else

                f40 = New Frm_Relacion_Facturas
                f40.Show()

            End If

        Else

            f40 = New Frm_Relacion_Facturas
            f40.Show()

        End If
    End Sub

    Private Sub NotasDeCréditoPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasDeCréditoPendientesToolStripMenuItem.Click

        If Not IsNothing(f20) Then

            If Not f20.IsDisposed Then

                f20.WindowState = FormWindowState.Normal
                f20.Tipo = 2
                f20.BringToFront()

            Else

                f20 = New Frm_ChequesDev
                f20.Tipo = 2
                f20.Show()

            End If

        Else

            f20 = New Frm_ChequesDev
            f20.Tipo = 2
            f20.Show()

        End If
    End Sub

    Private Sub LibroDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibroDeVentasToolStripMenuItem.Click


        If Not IsNothing(f36) Then

            If Not f36.IsDisposed Then

                f36.recibe(2)
                f36.WindowState = FormWindowState.Normal
                f36.BringToFront()

            Else

                f36 = New Frm_Parametro_Fecha
                f36.recibe(2)
                f36.Show()

            End If

        Else

            f36 = New Frm_Parametro_Fecha
            f36.recibe(2)
            f36.Show()

        End If
    End Sub

    Private Sub ClientesEliminadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesEliminadosToolStripMenuItem.Click


        If Not IsNothing(f1) Then

            If Not f1.IsDisposed Then

                f1.WindowState = FormWindowState.Normal
                f1.BringToFront()

            Else

                f1 = New Frm_Adm_Clientes
                f1.Show()

            End If

        Else

            f1 = New Frm_Adm_Clientes
            f1.Show()

        End If

    End Sub

    Private Sub CódigosEliminadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigosEliminadosToolStripMenuItem.Click


        If Not IsNothing(f3) Then

            If Not f3.IsDisposed Then

                f3.WindowState = FormWindowState.Normal
                f3.BringToFront()

            Else

                f3 = New Frm_Adm_Productos
                f3.Show()

            End If

        Else

            f3 = New Frm_Adm_Productos
            f3.Show()

        End If

    End Sub

    Private Sub AdminProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminProveedoresToolStripMenuItem.Click


        If Not IsNothing(f6) Then

            If Not f6.IsDisposed Then

                f6.WindowState = FormWindowState.Normal
                f6.BringToFront()

            Else

                f6 = New Frm_Adm_Proveedores
                f6.Show()

            End If

        Else

            f6 = New Frm_Adm_Proveedores
            f6.Show()

        End If

    End Sub

    Private Sub AdminTipoDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminTipoDeUsuarioToolStripMenuItem.Click


        If Not IsNothing(f41) Then

            If Not f41.IsDisposed Then

                f41.WindowState = FormWindowState.Normal
                f41.BringToFront()

            Else

                f41 = New Frm_TipoUsuario
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Admin. Tipo de Usuario").ToUpper Then
                        f41.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f41.Show()

            End If

        Else

            f41 = New Frm_TipoUsuario
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Admin. Tipo de Usuario").ToUpper Then
                    f41.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f41.Show()

        End If

    End Sub

    Private Sub AdminUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminUsuarioToolStripMenuItem.Click


        If Not IsNothing(f7) Then

            If Not f7.IsDisposed Then

                f7.WindowState = FormWindowState.Normal
                f7.BringToFront()

            Else

                f7 = New Frm_Adm_Usuarios
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Admin. Usuarios").ToUpper Then
                        f7.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f7.Show()

            End If

        Else

            f7 = New Frm_Adm_Usuarios
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Admin. Usuarios").ToUpper Then
                    f7.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f7.Show()

        End If

    End Sub

    Private Sub EstadísticasDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasDeVentasToolStripMenuItem.Click


        If Not IsNothing(f30) Then

            If Not f30.IsDisposed Then

                f30.WindowState = FormWindowState.Normal
                f30.BringToFront()

            Else

                f30 = New Frm_EvaluacionClientes
                f30.Show()

            End If

        Else

            f30 = New Frm_EvaluacionClientes
            f30.Show()

        End If

    End Sub

    Private Sub AnálisisDeDecisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnálisisDeDecisionesToolStripMenuItem.Click


        If Not IsNothing(f16) Then

            If Not f16.IsDisposed Then

                f16.WindowState = FormWindowState.Normal
                f16.BringToFront()

            Else

                f16 = New Frm_AnalisisDecision
                f16.Show()

            End If

        Else

            f16 = New Frm_AnalisisDecision
            f16.Show()

        End If

    End Sub

    Private Sub AnálisisDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnálisisDeProductosToolStripMenuItem.Click


        If Not IsNothing(f27) Then

            If Not f27.IsDisposed Then

                f27.WindowState = FormWindowState.Normal
                f27.BringToFront()

            Else

                f27 = New Frm_EvaluacionProductos
                f27.Show()

            End If

        Else

            f27 = New Frm_EvaluacionProductos
            f27.Show()

        End If

    End Sub

    Private Sub AnálisisDePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnálisisDePedidosToolStripMenuItem.Click


        If Not IsNothing(f15) Then

            If Not f15.IsDisposed Then

                f15.WindowState = FormWindowState.Normal
                f15.BringToFront()

            Else

                f15 = New Frm_Analisis_Pedido
                f15.Show()

            End If

        Else

            f15 = New Frm_Analisis_Pedido
            f15.Show()

        End If

    End Sub

    Private Sub AnálisisDeVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnálisisDeVendedoresToolStripMenuItem.Click


        If Not IsNothing(f28) Then

            If Not f28.IsDisposed Then

                f28.WindowState = FormWindowState.Normal
                f28.BringToFront()

            Else

                f28 = New Frm_EvaluacionVendedores
                f28.Show()

            End If

        Else

            f28 = New Frm_EvaluacionVendedores
            f28.Show()

        End If

    End Sub

    Private Sub AnálisisDeZonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnálisisDeZonasToolStripMenuItem.Click


        If Not IsNothing(f29) Then

            If Not f29.IsDisposed Then

                f29.WindowState = FormWindowState.Normal
                f29.BringToFront()

            Else

                f29 = New Frm_EvaluacionZonas
                f29.Show()

            End If

        Else

            f29 = New Frm_EvaluacionZonas
            f29.Show()

        End If

    End Sub

    Private Sub AjustesDeNotasDeCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesDeNotasDeCToolStripMenuItem.Click


        If Not IsNothing(f10) Then

            If Not f10.IsDisposed Then

                f10.WindowState = FormWindowState.Normal
                f10.BringToFront()

            Else

                f10 = New Frm_AjustesNotas
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Ajustes de Notas de C.").ToUpper Then
                        f10.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f10.Show()

            End If

        Else

            f10 = New Frm_AjustesNotas
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Ajustes de Notas de C.").ToUpper Then
                    f10.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f10.Show()

        End If

    End Sub

    Private Sub DGV_Recordatorio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_Recordatorio.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_Recordatorio.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_Recordatorio.ClearSelection()

                    DGV_Recordatorio.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub DGV_UsuarioAOtros_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_UsuarioAOtros.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_UsuarioAOtros.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_UsuarioAOtros.ClearSelection()

                    DGV_UsuarioAOtros.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub DGV_OtrosAUsuario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_OtrosAUsuario.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_OtrosAUsuario.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_OtrosAUsuario.ClearSelection()

                    DGV_OtrosAUsuario.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub UnaHoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnaHoraToolStripMenuItem.Click

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim FechaCompleta As New DateTime(Year(Today), Month(Today), CInt(Today.ToShortDateString.Substring(0, 2)), TimeOfDay.Hour, TimeOfDay.Minute, 0, 0)

            FechaCompleta = DateAdd(DateInterval.Hour, 1, FechaCompleta)

            DatosMensaje.Modifica_Mensaje(DGV_Recordatorio.SelectedRows(0).Cells(0).Value, 3, False, False, FechaCompleta, "")

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Tarea pospuesta una hora", ToolTipIcon.Info)

        End If

    End Sub

    Private Sub UnDíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnDíaToolStripMenuItem.Click

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim FechaCompleta As New DateTime(Year(Today), Month(Today), CInt(Today.ToShortDateString.Substring(0, 2)), TimeOfDay.Hour, TimeOfDay.Minute, 0, 0)

            FechaCompleta = DateAdd(DateInterval.Day, 1, FechaCompleta)

            DatosMensaje.Modifica_Mensaje(DGV_Recordatorio.SelectedRows(0).Cells(0).Value, 3, False, False, FechaCompleta, "")

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Tarea pospuesta un día", ToolTipIcon.Info)

        End If

    End Sub

    Private Sub UnaSemanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnaSemanaToolStripMenuItem.Click

        Dim FechaCompleta As New DateTime(Year(Today), Month(Today), CInt(Today.ToShortDateString.Substring(0, 2)), TimeOfDay.Hour, TimeOfDay.Minute, 0, 0)

        FechaCompleta = DateAdd(DateInterval.Day, 7, FechaCompleta)

        DatosMensaje.Modifica_Mensaje(DGV_Recordatorio.SelectedRows(0).Cells(0).Value, 3, False, False, FechaCompleta, "")

        bt_actualizar_Click(bt_actualizar, New EventArgs)

        NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Tarea pospuesta una semana", ToolTipIcon.Info)

    End Sub

    Private Sub UnMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnMesToolStripMenuItem.Click

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim FechaCompleta As New DateTime(Year(Today), Month(Today), CInt(Today.ToShortDateString.Substring(0, 2)), TimeOfDay.Hour, TimeOfDay.Minute, 0, 0)

            FechaCompleta = DateAdd(DateInterval.Month, 1, FechaCompleta)

            DatosMensaje.Modifica_Mensaje(DGV_Recordatorio.SelectedRows(0).Cells(0).Value, 3, False, False, FechaCompleta, "")

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Tarea pospuesta un mes", ToolTipIcon.Info)

        End If

    End Sub

    Private Sub SóloÉsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SóloÉsToolStripMenuItem.Click

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim num As Integer = 0

            num = DGV_Recordatorio.SelectedRows(0).Index

            DatosMensaje.Elimina_Mensaje(DGV_Recordatorio.SelectedRows(0).Cells(0).Value, NotifyIcon1, 1)

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            If DGV_Recordatorio.RowCount > 0 Then

                If Not num > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num).Cells(2).Selected = True

                ElseIf Not num - 1 > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num - 1).Cells(2).Selected = True

                ElseIf Not num + 1 > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num + 1).Cells(2).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub TodasSusRepeticionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodasSusRepeticionesToolStripMenuItem.Click

        If DGV_Recordatorio.SelectedRows.Count > 0 Then

            Dim num As Integer = 0
            DatosMensaje.consulta_Mensaje("", "", "", DGV_Recordatorio.SelectedRows(0).Cells(0).Value, False, num, NotifyIcon1, False)
            DatosMensaje.Elimina_Mensaje(num, NotifyIcon1, 0)

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            If DGV_Recordatorio.RowCount > 0 Then

                If Not num > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num).Cells(2).Selected = True

                ElseIf Not num - 1 > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num - 1).Cells(2).Selected = True

                ElseIf Not num + 1 > DGV_Recordatorio.RowCount - 1 Then

                    DGV_Recordatorio.Rows(num + 1).Cells(2).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub EliminarMensajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarMensajeToolStripMenuItem.Click

        If DGV_UsuarioAOtros.SelectedRows.Count > 0 Then

            Dim num As Integer = 0

            num = DGV_UsuarioAOtros.SelectedRows(0).Index

            DatosMensaje.Elimina_Mensaje(DGV_UsuarioAOtros.SelectedRows(0).Cells(0).Value, NotifyIcon1, 1)

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            If DGV_UsuarioAOtros.RowCount > 0 Then

                If Not num > DGV_UsuarioAOtros.RowCount - 1 Then

                    DGV_UsuarioAOtros.Rows(num).Cells(2).Selected = True

                ElseIf Not num - 1 > DGV_UsuarioAOtros.RowCount - 1 Then

                    DGV_UsuarioAOtros.Rows(num - 1).Cells(2).Selected = True

                ElseIf Not num + 1 > DGV_UsuarioAOtros.RowCount - 1 Then

                    DGV_UsuarioAOtros.Rows(num + 1).Cells(2).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub FinalizarMensajeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarMensajeToolStripMenuItem1.Click

        If DGV_OtrosAUsuario.SelectedRows.Count > 0 Then

            Dim num As Integer = 0

            num = DGV_OtrosAUsuario.SelectedRows(0).Index

            DatosMensaje.Modifica_Mensaje(DGV_OtrosAUsuario.SelectedRows(0).Cells(0).Value, 0, True, True, Today, "")
            DatosMensaje.Modifica_Mensaje(DGV_OtrosAUsuario.SelectedRows(0).Cells(0).Value, 1, True, True, Today, "")

            'Envío de email
            Dim usuarios As Boolean = False
            Dim vendedores As Boolean = False
            Dim clientes As Boolean = False
            Dim categoria As Integer = 1
            Dim sub_categoria As Integer = 3

            DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)

            If (usuarios Or vendedores Or clientes) Then
                DatosCorreos.Crear_Correo(sub_categoria, DGV_OtrosAUsuario.SelectedRows(0).Cells(0).Value)
            End If

            NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Mensaje Finalizado", ToolTipIcon.Info)

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            If DGV_OtrosAUsuario.RowCount > 0 Then

                If Not num > DGV_OtrosAUsuario.RowCount - 1 Then

                    DGV_OtrosAUsuario.Rows(num).Cells(2).Selected = True

                ElseIf Not num - 1 > DGV_OtrosAUsuario.RowCount - 1 Then

                    DGV_OtrosAUsuario.Rows(num - 1).Cells(2).Selected = True

                ElseIf Not num + 1 > DGV_OtrosAUsuario.RowCount - 1 Then

                    DGV_OtrosAUsuario.Rows(num + 1).Cells(2).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub ContextMenuStrip4_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening

        If DGV_OtrosAUsuario.RowCount = 0 Or DGV_OtrosAUsuario.SelectedRows.Count = 0 Then

            FinalizarMensajeToolStripMenuItem1.Visible = False

        Else

            If DGV_OtrosAUsuario.SelectedRows.Count > 0 Then

                If DGV_OtrosAUsuario.SelectedRows(0).DefaultCellStyle.Font Is Nothing Then

                    FinalizarMensajeToolStripMenuItem1.Visible = True

                Else

                    If DGV_OtrosAUsuario.SelectedRows(0).DefaultCellStyle.Font.Strikeout = True Then

                        FinalizarMensajeToolStripMenuItem1.Visible = False

                    Else

                        FinalizarMensajeToolStripMenuItem1.Visible = True

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub ContextMenuStrip3_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening

        If DGV_UsuarioAOtros.RowCount = 0 Or DGV_UsuarioAOtros.SelectedRows.Count = 0 Then

            EliminarMensajeToolStripMenuItem.Visible = False

        Else

            EliminarMensajeToolStripMenuItem.Visible = True

        End If

    End Sub


    Private Sub ContextMenuStrip2_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

        If DGV_Recordatorio.RowCount = 0 Or DGV_Recordatorio.SelectedRows.Count = 0 Then

            PosponerTareaToolStripMenuItem.Visible = False
            EliminarTareaToolStripMenuItem.Visible = False

        Else

            If DGV_Recordatorio.SelectedRows.Count > 0 Then

                If DGV_Recordatorio.SelectedRows(0).DefaultCellStyle.Font Is Nothing Then

                    EliminarTareaToolStripMenuItem.Visible = True

                Else

                    If DGV_Recordatorio.SelectedRows(0).DefaultCellStyle.Font.Strikeout = True Then

                        PosponerTareaToolStripMenuItem.Visible = False
                        EliminarTareaToolStripMenuItem.Visible = True

                    Else

                        PosponerTareaToolStripMenuItem.Visible = True
                        EliminarTareaToolStripMenuItem.Visible = True

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not IsNothing(f48) Then

            If Not f48.IsDisposed Then

                f48.WindowState = FormWindowState.Normal
                f48.user_l = user_l
                f48.BringToFront()

            Else

                f48 = New Frm_MensajesFuturos
                f48.user_l = user_l
                f48.Show()

            End If

        Else

            f48 = New Frm_MensajesFuturos
            f48.user_l = user_l
            f48.Show()

        End If

    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click

        If Not IsNothing(f49) Then

            If Not f49.IsDisposed Then

                f49.WindowState = FormWindowState.Normal
                f49.BringToFront()

            Else

                f49 = New Frm_ListadoClientes
                f49.Show()

            End If

        Else

            f49 = New Frm_ListadoClientes
            f49.Show()

        End If

    End Sub


    Private Sub CatálogoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeProductosToolStripMenuItem.Click

        Dim frm As New R_Catalogo_Productos_Fotos
        frm.Show()

    End Sub

    Private Sub RelaciónDeGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelaciónDeGastosToolStripMenuItem.Click

        If Not IsNothing(f50) Then

            If Not f50.IsDisposed Then

                f50.WindowState = FormWindowState.Normal
                f50.user = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f50.BringToFront()

            Else

                f50 = New Frm_Gastos

                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Relación de Gastos").ToUpper Then
                        f50.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next

                f50.user = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f50.Show()

            End If

        Else

            f50 = New Frm_Gastos

            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Relación de Gastos").ToUpper Then
                    f50.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next

            f50.user = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f50.Show()

        End If

    End Sub

    Private Sub ConciliaciónBancariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConciliaciónBancariaToolStripMenuItem.Click


        If Not IsNothing(f51) Then

            If Not f51.IsDisposed Then

                f51.WindowState = FormWindowState.Normal
                f51.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f51.BringToFront()

            Else

                f51 = New Frm_ConciliacionBancaria
                f51.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f51.Show()

            End If

        Else

            f51 = New Frm_ConciliacionBancaria
            f51.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f51.Show()

        End If

    End Sub

    Private Sub conex_StateChange(ByVal sender As System.Object, ByVal e As System.Data.StateChangeEventArgs) Handles conex.StateChange

        If conex.State = ConnectionState.Broken Or conex.State = ConnectionState.Closed Then

            Try

                conex.Open()
                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Conexión con Base de datos abierta", ToolTipIcon.Info)

            Catch ex As Exception

                NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error abriendo la conexión con la Base de datos", ToolTipIcon.Error)

            End Try

        End If

    End Sub

    Private Sub MovimientoProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoProductosToolStripMenuItem.Click

        If Not IsNothing(f52) Then

            If Not f52.IsDisposed Then

                f52.WindowState = FormWindowState.Normal
                f52.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f52.BringToFront()

            Else

                f52 = New Frm_Movimiento_Productos
                f52.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f52.Show()

            End If

        Else

            f52 = New Frm_Movimiento_Productos
            f52.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f52.Show()

        End If

    End Sub

    Private Sub InvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvToolStripMenuItem.Click

        If Not IsNothing(f53) Then

            If Not f53.IsDisposed Then

                f53.WindowState = FormWindowState.Normal
                f53.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f53.BringToFront()

            Else

                f53 = New Frm_Inventario
                f53.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f53.Show()

            End If

        Else

            f53 = New Frm_Inventario
            f53.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f53.Show()

        End If

    End Sub

    Private Sub ProductosOcultosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosOcultosToolStripMenuItem.Click

        Dim frm As New R_ProductosOcultos
        frm.Show()

    End Sub

    Private Sub ImpresiónDeEtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpresiónDeEtiquetasToolStripMenuItem.Click

        If Not IsNothing(f54) Then

            If Not f54.IsDisposed Then

                f54.WindowState = FormWindowState.Normal
                f54.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f54.BringToFront()

            Else

                f54 = New Frm_Etiquetas_Multiples
                f54.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f54.Show()

            End If

        Else

            f54 = New Frm_Etiquetas_Multiples
            f54.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f54.Show()

        End If

    End Sub

    Private Sub ActividadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActividadesToolStripMenuItem.Click

        If Not IsNothing(f55) Then

            If Not f55.IsDisposed Then

                f55.WindowState = FormWindowState.Normal
                f55.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f55.BringToFront()

            Else

                f55 = New Frm_Actividades
                f55.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f55.Show()

            End If

        Else

            f55 = New Frm_Actividades
            f55.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f55.Show()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click

        If Not IsNothing(f25) Then

            If Not f25.IsDisposed Then

                f25.WindowState = FormWindowState.Normal
                f25.BringToFront()

            Else

                f25 = New Frm_Configuracion
                For cont As Integer = 0 To frm.Rows.Count - 1
                    If frm.Rows(cont).Item(0).ToString.ToUpper = ("Configuración").ToUpper Then
                        f25.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                        cont = frm.Rows.Count
                    End If
                Next
                f25.Show()

            End If

        Else

            f25 = New Frm_Configuracion
            For cont As Integer = 0 To frm.Rows.Count - 1
                If frm.Rows(cont).Item(0).ToString.ToUpper = ("Configuración").ToUpper Then
                    f25.permisos(frm.Rows(cont).Item(1), frm.Rows(cont).Item(2))
                    cont = frm.Rows.Count
                End If
            Next
            f25.Show()

        End If

    End Sub

    Private Sub CobranzasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobranzasToolStripMenuItem.Click
        If Not IsNothing(f59) Then

            If Not f59.IsDisposed Then

                f59.WindowState = FormWindowState.Normal
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f59.BringToFront()

            Else

                f59 = New Frm_Configuracion_Cobranzas
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f59.Show()

            End If

        Else

            f59 = New Frm_Configuracion_Cobranzas
            'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f59.Show()

        End If

    End Sub

    Private Sub CorreosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorreosToolStripMenuItem.Click
        If Not IsNothing(f58) Then

            If Not f58.IsDisposed Then

                f58.WindowState = FormWindowState.Normal
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f58.BringToFront()

            Else

                f58 = New Frm_Configuracion_Mail
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f58.Show()

            End If

        Else

            f58 = New Frm_Configuracion_Mail
            'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f58.Show()

        End If
    End Sub

    Private Sub PedidosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosToolStripMenuItem.Click
        If Not IsNothing(f57) Then

            If Not f57.IsDisposed Then

                f57.WindowState = FormWindowState.Normal
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f57.BringToFront()

            Else

                f57 = New Frm_Configuracion_Pedidos
                'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f57.Show()

            End If

        Else

            f57 = New Frm_Configuracion_Pedidos
            'f57.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f57.Show()

        End If
    End Sub

    Private Sub WEBToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WEBToolStripMenuItem.Click
        If Not IsNothing(f56) Then

            If Not f56.IsDisposed Then

                f56.WindowState = FormWindowState.Normal
                'f56.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f56.BringToFront()

            Else

                f56 = New Frm_Configuracion_Web
                'f56.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
                f56.Show()

            End If

        Else

            f56 = New Frm_Configuracion_Web
            'f56.User = user_l.Substring(0, 1).ToUpper & user_l.Substring(1, user_l.Length - 1).ToLower
            f56.Show()

        End If
    End Sub
End Class
