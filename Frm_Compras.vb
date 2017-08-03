Imports Dundas.Charting.WinControl

Public Class Frm_Compras
    Inherits System.Windows.Forms.Form
    Dim ya As Boolean = False
    Dim act As Boolean = False
    Dim ind As Integer
    Dim indice As Integer = -1
    Dim produc As Boolean = False
    Dim status As String = ""
    Dim order As System.ComponentModel.ListSortDirection
    Dim compras As Boolean = False
    Dim nroPedido As Integer = 0
    Dim pedidos As Boolean = False
    Dim e As Boolean = False
    Dim w As Boolean = False
    Dim nrocompra As Integer = 0
    Dim primera As Boolean = False
    Dim codigoPedido As Integer = 0
    Dim codigoProveedor As Integer = 0
    Dim consulta As Boolean = False
    Dim parametroCantidad As Integer = 0
    Dim ultimoChequeado As Integer = 0
    Dim entro As Boolean = False
    Public productoscompras As DataGridView
    Dim Dv As DataView
    Dim frm As New Frm_AgregarAPedido
    Shadows deactivate As Boolean = False
    Private lproductos As New Collection
    Private item As Object
    Private codPed As Integer
    Public enter1 As Boolean = False
    Public down As Boolean = False
    Public up As Boolean = False
    Public selected As Boolean = False
    Private choice As Integer
    Dim texto As String = ""
    Dim marcab As Boolean = True
    Dim modelob As Boolean = True
    Dim proveedorb As Boolean = False
    Dim grupob As Boolean = False
    Dim entreb As Boolean = False
    Dim otra As Boolean = False
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGV_Compras As System.Windows.Forms.DataGridView
    Friend WithEvents Chk_ExistEntre As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Exist As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Modelo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Marca As System.Windows.Forms.CheckBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DGV_Pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_PorFacturar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_Grupos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGV_Arancelarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV_Direccion As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGV_Ajustes As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cb_buscar As System.Windows.Forms.ComboBox
    Friend WithEvents Chk_Proveedor As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DGV_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_grafico As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cb_mesesGrafico As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents AgregarAPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DGV_Devoluciones As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DGV_Indicadores As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Indicador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sugerida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Otros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents DataGridView10 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView11 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents DataGridView12 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView13 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents DataGridView14 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents chk_oculto As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Sp_infoGeneralTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_infoGeneralTableAdapter
    Friend WithEvents SpinfoGeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_infoGeneralComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_infoGeneralComprasTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_infoGeneralComprasTableAdapter
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents lb_marca As System.Windows.Forms.ListBox
    Friend WithEvents cb_marc As System.Windows.Forms.TextBox
    Friend WithEvents SpconsultaMarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaMarcaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
    Friend WithEvents lb_modelo As System.Windows.Forms.ListBox
    Friend WithEvents cb_model As System.Windows.Forms.TextBox
    Friend WithEvents TblModeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_ModeloTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_ModeloTableAdapter
    Friend WithEvents lb_grupo As System.Windows.Forms.ListBox
    Friend WithEvents cb_grup As System.Windows.Forms.TextBox
    Friend WithEvents TblGrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_GrupoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_GrupoTableAdapter
    Friend WithEvents lb_proveedor As System.Windows.Forms.ListBox
    Friend WithEvents cb_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents TblFabricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FabricaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
    Friend WithEvents a As Tesis_Nueva.UserControl1
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_actualizar As System.Windows.Forms.Button
    Friend WithEvents chk_POculto As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents tb_compra As System.Windows.Forms.TextBox
    Friend WithEvents chk_compra As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_F_Productos As System.Windows.Forms.Label
    Friend WithEvents lbl_F_Pedidos As System.Windows.Forms.Label
    Friend WithEvents gb_funciones As System.Windows.Forms.GroupBox
    Friend WithEvents gb_obs As System.Windows.Forms.GroupBox
    Friend WithEvents tb_obs As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_exacto As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_totalUniC As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalUniPro As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents EliminarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_cantI As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaI As System.Windows.Forms.Label
    Friend WithEvents chk_fr As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Var1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Var2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OcultoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PorComplementarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoBs2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuarto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodNc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ajust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAjustada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_etiquetas As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vari1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vari2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_marca2 As System.Windows.Forms.ListBox
    Friend WithEvents cb_marc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Ped As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Euro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Arancel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArancelBs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtrosG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoBs As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart
    Private choice1 As Integer

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

    Private components As System.ComponentModel.IContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ti_productos As System.Windows.Forms.Label
    Friend WithEvents ti_pedidos As System.Windows.Forms.Label
    Friend WithEvents ti_compras As System.Windows.Forms.Label
    Friend WithEvents ti_fabricas As System.Windows.Forms.Label
    Friend WithEvents ti_grupos As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Compras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle82 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle81 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle86 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle83 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle84 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle85 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle88 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle89 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle87 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle90 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle91 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ti_productos = New System.Windows.Forms.Label
        Me.ti_pedidos = New System.Windows.Forms.Label
        Me.ti_compras = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.gb_obs = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tb_obs = New System.Windows.Forms.TextBox
        Me.lbl_info = New System.Windows.Forms.Label
        Me.chk_oculto = New System.Windows.Forms.CheckBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DGV_Ajustes = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.DGV_Direccion = New System.Windows.Forms.DataGridView
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuarto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Devoluciones = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodNc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ajust = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAjustada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGV_Arancelarios = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Grupos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ti_fabricas = New System.Windows.Forms.Label
        Me.DGV_Proveedor = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vari1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vari2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ti_grupos = New System.Windows.Forms.Label
        Me.gb_funciones = New System.Windows.Forms.GroupBox
        Me.lbl_F_Pedidos = New System.Windows.Forms.Label
        Me.lbl_F_Productos = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lbl_cantI = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_mesesGrafico = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_fechaI = New System.Windows.Forms.Label
        Me.lbl_grafico = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView
        Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dev = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.a = New Tesis_Nueva.UserControl1
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_PorFacturar = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Var1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Var2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OcultoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PorComplementarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarAPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpinfoGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.DGV_Compras = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Chk_Proveedor = New System.Windows.Forms.CheckBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Chk_ExistEntre = New System.Windows.Forms.CheckBox
        Me.Chk_Exist = New System.Windows.Forms.CheckBox
        Me.Chk_Grupo = New System.Windows.Forms.CheckBox
        Me.Chk_Modelo = New System.Windows.Forms.CheckBox
        Me.Chk_Marca = New System.Windows.Forms.CheckBox
        Me.DGV_Pedidos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoBs2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cb_buscar = New System.Windows.Forms.ComboBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.DGV_Indicadores = New System.Windows.Forms.DataGridView
        Me.Indicador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcInv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sugerida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Otros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label24 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label28 = New System.Windows.Forms.Label
        Me.DataGridView6 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label29 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label34 = New System.Windows.Forms.Label
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.DataGridView7 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.DataGridView8 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.Label41 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.Label66 = New System.Windows.Forms.Label
        Me.lb_marca2 = New System.Windows.Forms.ListBox
        Me.SpconsultaMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_marc2 = New System.Windows.Forms.TextBox
        Me.chk_fr = New System.Windows.Forms.CheckBox
        Me.tb_compra = New System.Windows.Forms.TextBox
        Me.chk_compra = New System.Windows.Forms.CheckBox
        Me.chk_POculto = New System.Windows.Forms.CheckBox
        Me.cb_proveedor = New System.Windows.Forms.TextBox
        Me.cb_grup = New System.Windows.Forms.TextBox
        Me.cb_model = New System.Windows.Forms.TextBox
        Me.cb_marc = New System.Windows.Forms.TextBox
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.lb_modelo = New System.Windows.Forms.ListBox
        Me.TblModeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_marca = New System.Windows.Forms.ListBox
        Me.lb_grupo = New System.Windows.Forms.ListBox
        Me.TblGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.DataGridView9 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label53 = New System.Windows.Forms.Label
        Me.DataGridView10 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView11 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label54 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.DataGridView12 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView13 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label57 = New System.Windows.Forms.Label
        Me.DataGridView14 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Sp_infoGeneralTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_infoGeneralTableAdapter
        Me.Sp_infoGeneralComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_infoGeneralComprasTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_infoGeneralComprasTableAdapter
        Me.Sp_consultaMarcaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
        Me.Tbl_ModeloTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_ModeloTableAdapter
        Me.Tbl_GrupoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_GrupoTableAdapter
        Me.lb_proveedor = New System.Windows.Forms.ListBox
        Me.TblFabricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_FabricaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
        Me.bt_actualizar = New System.Windows.Forms.Button
        Me.chk_exacto = New System.Windows.Forms.CheckBox
        Me.lbl_totalUniC = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.lbl_totalUniPro = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.bt_etiquetas = New System.Windows.Forms.Button
        Me.Ped = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Euro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dolar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Arancel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ArancelBs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Flete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OtrosG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoBs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_obs.SuspendLayout()
        CType(Me.DGV_Ajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Direccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Devoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Arancelarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.gb_funciones.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SpinfoGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Indicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.TblModeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_infoGeneralComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ti_productos
        '
        Me.ti_productos.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_productos.Location = New System.Drawing.Point(2, 52)
        Me.ti_productos.Name = "ti_productos"
        Me.ti_productos.Size = New System.Drawing.Size(603, 23)
        Me.ti_productos.TabIndex = 16
        Me.ti_productos.Text = "PRODUCTOS"
        Me.ti_productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ti_pedidos
        '
        Me.ti_pedidos.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_pedidos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_pedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_pedidos.Location = New System.Drawing.Point(2, 575)
        Me.ti_pedidos.Name = "ti_pedidos"
        Me.ti_pedidos.Size = New System.Drawing.Size(603, 23)
        Me.ti_pedidos.TabIndex = 18
        Me.ti_pedidos.Text = "PEDIDOS PENDIENTES"
        Me.ti_pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ti_compras
        '
        Me.ti_compras.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_compras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_compras.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_compras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_compras.Location = New System.Drawing.Point(2, 419)
        Me.ti_compras.Name = "ti_compras"
        Me.ti_compras.Size = New System.Drawing.Size(603, 23)
        Me.ti_compras.TabIndex = 20
        Me.ti_compras.Text = "COMPRAS REALIZADAS"
        Me.ti_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(608, 162)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 562)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.gb_obs)
        Me.TabPage1.Controls.Add(Me.lbl_info)
        Me.TabPage1.Controls.Add(Me.chk_oculto)
        Me.TabPage1.Controls.Add(Me.Label61)
        Me.TabPage1.Controls.Add(Me.Label59)
        Me.TabPage1.Controls.Add(Me.Label62)
        Me.TabPage1.Controls.Add(Me.Label60)
        Me.TabPage1.Controls.Add(Me.Label45)
        Me.TabPage1.Controls.Add(Me.Label46)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.DGV_Ajustes)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DGV_Direccion)
        Me.TabPage1.Controls.Add(Me.DGV_Devoluciones)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DGV_Arancelarios)
        Me.TabPage1.Controls.Add(Me.DGV_Grupos)
        Me.TabPage1.Controls.Add(Me.ti_fabricas)
        Me.TabPage1.Controls.Add(Me.DGV_Proveedor)
        Me.TabPage1.Controls.Add(Me.ti_grupos)
        Me.TabPage1.Controls.Add(Me.gb_funciones)
        Me.TabPage1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(544, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(390, 445)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10063
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'gb_obs
        '
        Me.gb_obs.Controls.Add(Me.Button1)
        Me.gb_obs.Controls.Add(Me.tb_obs)
        Me.gb_obs.Location = New System.Drawing.Point(382, 397)
        Me.gb_obs.Name = "gb_obs"
        Me.gb_obs.Size = New System.Drawing.Size(150, 130)
        Me.gb_obs.TabIndex = 109
        Me.gb_obs.TabStop = False
        Me.gb_obs.Text = "Observaciones"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(61, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 25)
        Me.Button1.TabIndex = 10062
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tb_obs
        '
        Me.tb_obs.Location = New System.Drawing.Point(6, 18)
        Me.tb_obs.MaxLength = 100
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.Size = New System.Drawing.Size(139, 80)
        Me.tb_obs.TabIndex = 0
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.White
        Me.lbl_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_info.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_info.Location = New System.Drawing.Point(2, 147)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(95, 14)
        Me.lbl_info.TabIndex = 99
        Me.lbl_info.Text = "Más información"
        '
        'chk_oculto
        '
        Me.chk_oculto.AutoSize = True
        Me.chk_oculto.Location = New System.Drawing.Point(423, 145)
        Me.chk_oculto.Name = "chk_oculto"
        Me.chk_oculto.Size = New System.Drawing.Size(112, 18)
        Me.chk_oculto.TabIndex = 105
        Me.chk_oculto.Text = "Producto oculto"
        Me.chk_oculto.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label61.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(504, 5)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(14, 14)
        Me.Label61.TabIndex = 94
        Me.Label61.Text = "0"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label59.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(341, 419)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(14, 14)
        Me.Label59.TabIndex = 104
        Me.Label59.Text = "0"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label62.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label62.ForeColor = System.Drawing.Color.White
        Me.Label62.Location = New System.Drawing.Point(463, 5)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(36, 14)
        Me.Label62.TabIndex = 93
        Me.Label62.Text = "Total:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label60.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(220, 419)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(120, 14)
        Me.Label60.TabIndex = 103
        Me.Label60.Text = "Total en Ubicaciones:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label45.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(343, 308)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(14, 14)
        Me.Label45.TabIndex = 102
        Me.Label45.Text = "0"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label46.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(249, 308)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(91, 14)
        Me.Label46.TabIndex = 101
        Me.Label46.Text = "Total Ajustados:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label43.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(496, 166)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(14, 14)
        Me.Label43.TabIndex = 94
        Me.Label43.Text = "0"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label44.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(402, 166)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(90, 14)
        Me.Label44.TabIndex = 93
        Me.Label44.Text = "Total devueltos:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(161, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(376, 20)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "Devoluciones"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(5, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(371, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Ajustes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV_Ajustes
        '
        Me.DGV_Ajustes.AllowUserToAddRows = False
        Me.DGV_Ajustes.AllowUserToDeleteRows = False
        Me.DGV_Ajustes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Ajustes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Ajustes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Ajustes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Ajustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ajustes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.DGV_Ajustes.Location = New System.Drawing.Point(5, 328)
        Me.DGV_Ajustes.MultiSelect = False
        Me.DGV_Ajustes.Name = "DGV_Ajustes"
        Me.DGV_Ajustes.ReadOnly = True
        Me.DGV_Ajustes.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Ajustes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Ajustes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Ajustes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Ajustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ajustes.Size = New System.Drawing.Size(371, 87)
        Me.DGV_Ajustes.TabIndex = 95
        '
        'DataGridViewTextBoxColumn16
        '
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 90
        '
        'DataGridViewTextBoxColumn17
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n0"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 195
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(5, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(371, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Ubicación"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV_Direccion
        '
        Me.DGV_Direccion.AllowUserToAddRows = False
        Me.DGV_Direccion.AllowUserToDeleteRows = False
        Me.DGV_Direccion.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DGV_Direccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Direccion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Direccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Direccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Almacen, Me.Cuarto, Me.Estante, Me.Tramo, Me.DataGridViewTextBoxColumn15, Me.CodigoTramo})
        Me.DGV_Direccion.Location = New System.Drawing.Point(5, 439)
        Me.DGV_Direccion.MultiSelect = False
        Me.DGV_Direccion.Name = "DGV_Direccion"
        Me.DGV_Direccion.ReadOnly = True
        Me.DGV_Direccion.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Direccion.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Direccion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Direccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Direccion.Size = New System.Drawing.Size(371, 87)
        Me.DGV_Direccion.TabIndex = 93
        '
        'Almacen
        '
        Me.Almacen.HeaderText = "Almacén"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 75
        '
        'Cuarto
        '
        Me.Cuarto.HeaderText = "Cuarto"
        Me.Cuarto.Name = "Cuarto"
        Me.Cuarto.ReadOnly = True
        Me.Cuarto.Width = 75
        '
        'Estante
        '
        Me.Estante.HeaderText = "Estante"
        Me.Estante.Name = "Estante"
        Me.Estante.ReadOnly = True
        Me.Estante.Width = 75
        '
        'Tramo
        '
        Me.Tramo.HeaderText = "Tramo"
        Me.Tramo.Name = "Tramo"
        Me.Tramo.ReadOnly = True
        Me.Tramo.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n0"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'CodigoTramo
        '
        Me.CodigoTramo.HeaderText = "CodigoTramo"
        Me.CodigoTramo.Name = "CodigoTramo"
        Me.CodigoTramo.ReadOnly = True
        Me.CodigoTramo.Visible = False
        '
        'DGV_Devoluciones
        '
        Me.DGV_Devoluciones.AllowUserToAddRows = False
        Me.DGV_Devoluciones.AllowUserToDeleteRows = False
        Me.DGV_Devoluciones.AllowUserToResizeRows = False
        Me.DGV_Devoluciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Devoluciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV_Devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Devoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.CodNc, Me.DataGridViewTextBoxColumn23, Me.Razon, Me.Fecha, Me.Ajust, Me.CantidadAjustada, Me.Obs})
        Me.DGV_Devoluciones.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Devoluciones.Location = New System.Drawing.Point(161, 186)
        Me.DGV_Devoluciones.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Devoluciones.Name = "DGV_Devoluciones"
        Me.DGV_Devoluciones.ReadOnly = True
        Me.DGV_Devoluciones.RowHeadersVisible = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DGV_Devoluciones.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_Devoluciones.RowTemplate.Height = 19
        Me.DGV_Devoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Devoluciones.Size = New System.Drawing.Size(376, 116)
        Me.DGV_Devoluciones.TabIndex = 98
        '
        'DataGridViewTextBoxColumn22
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn22.HeaderText = "Dv"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 28
        '
        'CodNc
        '
        Me.CodNc.HeaderText = "NC"
        Me.CodNc.Name = "CodNc"
        Me.CodNc.ReadOnly = True
        Me.CodNc.Width = 40
        '
        'DataGridViewTextBoxColumn23
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn23.HeaderText = "Fct"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 35
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razon Social"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 135
        '
        'Fecha
        '
        DataGridViewCellStyle10.Format = "d"
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle10
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 68
        '
        'Ajust
        '
        Me.Ajust.HeaderText = "Aj"
        Me.Ajust.Name = "Ajust"
        Me.Ajust.ReadOnly = True
        Me.Ajust.Width = 23
        '
        'CantidadAjustada
        '
        Me.CantidadAjustada.HeaderText = "Ct."
        Me.CantidadAjustada.Name = "CantidadAjustada"
        Me.CantidadAjustada.ReadOnly = True
        Me.CantidadAjustada.Width = 35
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs."
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Width = 150
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(5, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Cod. Arancelario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV_Arancelarios
        '
        Me.DGV_Arancelarios.AllowUserToAddRows = False
        Me.DGV_Arancelarios.AllowUserToDeleteRows = False
        Me.DGV_Arancelarios.AllowUserToResizeRows = False
        Me.DGV_Arancelarios.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Arancelarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV_Arancelarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Arancelarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.DGV_Arancelarios.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Arancelarios.Location = New System.Drawing.Point(5, 186)
        Me.DGV_Arancelarios.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Arancelarios.Name = "DGV_Arancelarios"
        Me.DGV_Arancelarios.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Arancelarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGV_Arancelarios.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Arancelarios.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_Arancelarios.RowTemplate.Height = 19
        Me.DGV_Arancelarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Arancelarios.Size = New System.Drawing.Size(149, 116)
        Me.DGV_Arancelarios.TabIndex = 92
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "Imp."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'DGV_Grupos
        '
        Me.DGV_Grupos.AllowUserToAddRows = False
        Me.DGV_Grupos.AllowUserToDeleteRows = False
        Me.DGV_Grupos.AllowUserToResizeRows = False
        Me.DGV_Grupos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Grupos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DGV_Grupos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Grupos.Location = New System.Drawing.Point(338, 21)
        Me.DGV_Grupos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Grupos.Name = "DGV_Grupos"
        Me.DGV_Grupos.ReadOnly = True
        Me.DGV_Grupos.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Grupos.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGV_Grupos.RowTemplate.Height = 19
        Me.DGV_Grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Grupos.Size = New System.Drawing.Size(195, 116)
        Me.DGV_Grupos.TabIndex = 87
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.Frozen = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 170
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'ti_fabricas
        '
        Me.ti_fabricas.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_fabricas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_fabricas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_fabricas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_fabricas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_fabricas.Location = New System.Drawing.Point(9, 3)
        Me.ti_fabricas.Name = "ti_fabricas"
        Me.ti_fabricas.Size = New System.Drawing.Size(303, 20)
        Me.ti_fabricas.TabIndex = 30
        Me.ti_fabricas.Text = "Cod. Proveedor / OEM"
        Me.ti_fabricas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV_Proveedor
        '
        Me.DGV_Proveedor.AllowUserToAddRows = False
        Me.DGV_Proveedor.AllowUserToDeleteRows = False
        Me.DGV_Proveedor.AllowUserToResizeRows = False
        Me.DGV_Proveedor.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Proveedor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Vari1, Me.Vari2, Me.CodF})
        Me.DGV_Proveedor.ContextMenuStrip = Me.ContextMenuStrip3
        Me.DGV_Proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Proveedor.Location = New System.Drawing.Point(5, 22)
        Me.DGV_Proveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Proveedor.Name = "DGV_Proveedor"
        Me.DGV_Proveedor.ReadOnly = True
        Me.DGV_Proveedor.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Proveedor.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGV_Proveedor.RowTemplate.Height = 19
        Me.DGV_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Proveedor.Size = New System.Drawing.Size(303, 119)
        Me.DGV_Proveedor.TabIndex = 85
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cod. Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 130
        '
        'Vari1
        '
        Me.Vari1.HeaderText = "Variante1"
        Me.Vari1.Name = "Vari1"
        Me.Vari1.ReadOnly = True
        Me.Vari1.Width = 110
        '
        'Vari2
        '
        Me.Vari2.HeaderText = "Variante2"
        Me.Vari2.Name = "Vari2"
        Me.Vari2.ReadOnly = True
        Me.Vari2.Width = 110
        '
        'CodF
        '
        Me.CodF.HeaderText = "CodF"
        Me.CodF.Name = "CodF"
        Me.CodF.ReadOnly = True
        Me.CodF.Visible = False
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(217, 26)
        Me.ContextMenuStrip3.Text = "Modificar cantidad"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem4.Text = "Eliminar Código de Fábrica"
        '
        'ti_grupos
        '
        Me.ti_grupos.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_grupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_grupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_grupos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_grupos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_grupos.Location = New System.Drawing.Point(338, 3)
        Me.ti_grupos.Name = "ti_grupos"
        Me.ti_grupos.Size = New System.Drawing.Size(195, 20)
        Me.ti_grupos.TabIndex = 31
        Me.ti_grupos.Text = "Grupos"
        Me.ti_grupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gb_funciones
        '
        Me.gb_funciones.Controls.Add(Me.lbl_F_Pedidos)
        Me.gb_funciones.Controls.Add(Me.lbl_F_Productos)
        Me.gb_funciones.Location = New System.Drawing.Point(383, 308)
        Me.gb_funciones.Name = "gb_funciones"
        Me.gb_funciones.Size = New System.Drawing.Size(150, 89)
        Me.gb_funciones.TabIndex = 108
        Me.gb_funciones.TabStop = False
        Me.gb_funciones.Text = "Funciones (F)"
        '
        'lbl_F_Pedidos
        '
        Me.lbl_F_Pedidos.AutoSize = True
        Me.lbl_F_Pedidos.Location = New System.Drawing.Point(6, 15)
        Me.lbl_F_Pedidos.Name = "lbl_F_Pedidos"
        Me.lbl_F_Pedidos.Size = New System.Drawing.Size(122, 70)
        Me.lbl_F_Pedidos.TabIndex = 107
        Me.lbl_F_Pedidos.Text = "F3 Mover a pedido ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F5 Modificar cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F6 Modificar Pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F8 Modificar F" & _
            ".O.B." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F10 Modificar Status"
        Me.lbl_F_Pedidos.Visible = False
        '
        'lbl_F_Productos
        '
        Me.lbl_F_Productos.AutoSize = True
        Me.lbl_F_Productos.Location = New System.Drawing.Point(6, 23)
        Me.lbl_F_Productos.Name = "lbl_F_Productos"
        Me.lbl_F_Productos.Size = New System.Drawing.Size(129, 56)
        Me.lbl_F_Productos.TabIndex = 106
        Me.lbl_F_Productos.Text = "F3 Agregar a pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F5 Modificar precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F8 Por facturar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DC Modificar Producto"
        Me.lbl_F_Productos.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.lbl_cantI)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.lbl_fechaI)
        Me.TabPage2.Controls.Add(Me.lbl_grafico)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.DGV_Ventas)
        Me.TabPage2.Controls.Add(Me.a)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ventas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_cantI
        '
        Me.lbl_cantI.AutoSize = True
        Me.lbl_cantI.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantI.Location = New System.Drawing.Point(416, 227)
        Me.lbl_cantI.Name = "lbl_cantI"
        Me.lbl_cantI.Size = New System.Drawing.Size(0, 18)
        Me.lbl_cantI.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(115, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 14)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(22, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 14)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "Total Devueltos:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(514, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 14)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(426, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 14)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Total Vendidos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_mesesGrafico)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 56)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'cb_mesesGrafico
        '
        Me.cb_mesesGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mesesGrafico.FormattingEnabled = True
        Me.cb_mesesGrafico.Items.AddRange(New Object() {"3", "6", "9", "12"})
        Me.cb_mesesGrafico.Location = New System.Drawing.Point(77, 23)
        Me.cb_mesesGrafico.Name = "cb_mesesGrafico"
        Me.cb_mesesGrafico.Size = New System.Drawing.Size(40, 22)
        Me.cb_mesesGrafico.TabIndex = 98
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(357, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker2.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(339, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 14)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "y"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(243, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker1.TabIndex = 104
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(181, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 18)
        Me.RadioButton2.TabIndex = 103
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Entre"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(7, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 18)
        Me.RadioButton1.TabIndex = 102
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ultimos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(117, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 14)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Meses"
        '
        'lbl_fechaI
        '
        Me.lbl_fechaI.AutoSize = True
        Me.lbl_fechaI.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaI.Location = New System.Drawing.Point(303, 226)
        Me.lbl_fechaI.Name = "lbl_fechaI"
        Me.lbl_fechaI.Size = New System.Drawing.Size(0, 18)
        Me.lbl_fechaI.TabIndex = 108
        '
        'lbl_grafico
        '
        Me.lbl_grafico.AutoSize = True
        Me.lbl_grafico.Font = New System.Drawing.Font("Eras Medium ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grafico.Location = New System.Drawing.Point(121, 364)
        Me.lbl_grafico.Name = "lbl_grafico"
        Me.lbl_grafico.Size = New System.Drawing.Size(331, 31)
        Me.lbl_grafico.TabIndex = 99
        Me.lbl_grafico.Text = "El Gráfico no tiene datos"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(4, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 23)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Ventas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.AllowUserToAddRows = False
        Me.DGV_Ventas.AllowUserToDeleteRows = False
        Me.DGV_Ventas.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.DGV_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DGV_Ventas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pedido, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.Precio2, Me.Dev, Me.Empresa})
        Me.DGV_Ventas.EnableHeadersVisualStyles = False
        Me.DGV_Ventas.Location = New System.Drawing.Point(4, 27)
        Me.DGV_Ventas.MultiSelect = False
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.ReadOnly = True
        Me.DGV_Ventas.RowHeadersVisible = False
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DGV_Ventas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ventas.Size = New System.Drawing.Size(552, 132)
        Me.DGV_Ventas.TabIndex = 97
        '
        'Pedido
        '
        Me.Pedido.HeaderText = "Fact."
        Me.Pedido.Name = "Pedido"
        Me.Pedido.ReadOnly = True
        Me.Pedido.Width = 75
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 210
        '
        'DataGridViewTextBoxColumn19
        '
        DataGridViewCellStyle18.Format = "d"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "n0"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn20.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'Precio2
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "n2"
        Me.Precio2.DefaultCellStyle = DataGridViewCellStyle20
        Me.Precio2.HeaderText = "Precio"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.ReadOnly = True
        Me.Precio2.Width = 70
        '
        'Dev
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "n0"
        Me.Dev.DefaultCellStyle = DataGridViewCellStyle21
        Me.Dev.HeaderText = "Dev"
        Me.Dev.Name = "Dev"
        Me.Dev.ReadOnly = True
        Me.Dev.Width = 39
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        Me.Empresa.Visible = False
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.White
        Me.a.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.a.Location = New System.Drawing.Point(8, 220)
        Me.a.Margin = New System.Windows.Forms.Padding(4)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(548, 309)
        Me.a.TabIndex = 107
        Me.a.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(544, 535)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Foto"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 31)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Foto del producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(116, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 328)
        Me.Panel2.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 325)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label65)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_PorFacturar)
        Me.Panel1.Location = New System.Drawing.Point(938, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 24)
        Me.Panel1.TabIndex = 90
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.White
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label65.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!, System.Drawing.FontStyle.Underline)
        Me.Label65.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label65.Location = New System.Drawing.Point(151, 6)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 14)
        Me.Label65.TabIndex = 98
        Me.Label65.Text = "Ver detalles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Por facturar:"
        '
        'lbl_PorFacturar
        '
        Me.lbl_PorFacturar.AutoSize = True
        Me.lbl_PorFacturar.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PorFacturar.Location = New System.Drawing.Point(114, 3)
        Me.lbl_PorFacturar.Name = "lbl_PorFacturar"
        Me.lbl_PorFacturar.Size = New System.Drawing.Size(28, 18)
        Me.lbl_PorFacturar.TabIndex = 89
        Me.lbl_PorFacturar.Text = "##"
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(246, 13)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(172, 24)
        Me.tb_buscarcodigo.TabIndex = 25
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(8, 15)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(56, 23)
        Me.Label73.TabIndex = 78
        Me.Label73.Text = "Buscar:"
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToOrderColumns = True
        Me.DGV_Productos.AllowUserToResizeRows = False
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.OEMDataGridViewTextBoxColumn, Me.Var1DataGridViewTextBoxColumn, Me.Var2DataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.VendidosDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.FotoDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.CodigoFabricaDataGridViewTextBoxColumn, Me.OcultoDataGridViewCheckBoxColumn, Me.PorComplementarDataGridViewCheckBoxColumn})
        Me.DGV_Productos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV_Productos.DataSource = Me.SpinfoGeneralBindingSource
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Productos.DefaultCellStyle = DataGridViewCellStyle25
        Me.DGV_Productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.Location = New System.Drawing.Point(2, 75)
        Me.DGV_Productos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DGV_Productos.RowHeadersVisible = False
        Me.DGV_Productos.RowTemplate.Height = 19
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(603, 339)
        Me.DGV_Productos.TabIndex = 79
        Me.DGV_Productos.VirtualMode = True
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 110
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 210
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 140
        '
        'CantDataGridViewTextBoxColumn
        '
        Me.CantDataGridViewTextBoxColumn.DataPropertyName = "Cant"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.CantDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.CantDataGridViewTextBoxColumn.HeaderText = "Exist."
        Me.CantDataGridViewTextBoxColumn.Name = "CantDataGridViewTextBoxColumn"
        Me.CantDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantDataGridViewTextBoxColumn.Width = 45
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 75
        '
        'OEMDataGridViewTextBoxColumn
        '
        Me.OEMDataGridViewTextBoxColumn.DataPropertyName = "OEM"
        Me.OEMDataGridViewTextBoxColumn.HeaderText = "OEM"
        Me.OEMDataGridViewTextBoxColumn.Name = "OEMDataGridViewTextBoxColumn"
        Me.OEMDataGridViewTextBoxColumn.ReadOnly = True
        Me.OEMDataGridViewTextBoxColumn.Visible = False
        '
        'Var1DataGridViewTextBoxColumn
        '
        Me.Var1DataGridViewTextBoxColumn.DataPropertyName = "Var1"
        Me.Var1DataGridViewTextBoxColumn.HeaderText = "Var1"
        Me.Var1DataGridViewTextBoxColumn.Name = "Var1DataGridViewTextBoxColumn"
        Me.Var1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Var1DataGridViewTextBoxColumn.Visible = False
        '
        'Var2DataGridViewTextBoxColumn
        '
        Me.Var2DataGridViewTextBoxColumn.DataPropertyName = "Var2"
        Me.Var2DataGridViewTextBoxColumn.HeaderText = "Var2"
        Me.Var2DataGridViewTextBoxColumn.Name = "Var2DataGridViewTextBoxColumn"
        Me.Var2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Var2DataGridViewTextBoxColumn.Visible = False
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Visible = False
        '
        'VendidosDataGridViewTextBoxColumn
        '
        Me.VendidosDataGridViewTextBoxColumn.DataPropertyName = "Vendidos"
        Me.VendidosDataGridViewTextBoxColumn.HeaderText = "Vendidos"
        Me.VendidosDataGridViewTextBoxColumn.Name = "VendidosDataGridViewTextBoxColumn"
        Me.VendidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendidosDataGridViewTextBoxColumn.Visible = False
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoDataGridViewTextBoxColumn.Visible = False
        '
        'FotoDataGridViewTextBoxColumn
        '
        Me.FotoDataGridViewTextBoxColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewTextBoxColumn.HeaderText = "Foto"
        Me.FotoDataGridViewTextBoxColumn.Name = "FotoDataGridViewTextBoxColumn"
        Me.FotoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FotoDataGridViewTextBoxColumn.Visible = False
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoFabricaDataGridViewTextBoxColumn
        '
        Me.CodigoFabricaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.HeaderText = "CodigoFabrica"
        Me.CodigoFabricaDataGridViewTextBoxColumn.Name = "CodigoFabricaDataGridViewTextBoxColumn"
        Me.CodigoFabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFabricaDataGridViewTextBoxColumn.Visible = False
        '
        'OcultoDataGridViewCheckBoxColumn
        '
        Me.OcultoDataGridViewCheckBoxColumn.DataPropertyName = "Oculto"
        Me.OcultoDataGridViewCheckBoxColumn.HeaderText = "Oculto"
        Me.OcultoDataGridViewCheckBoxColumn.Name = "OcultoDataGridViewCheckBoxColumn"
        Me.OcultoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.OcultoDataGridViewCheckBoxColumn.Visible = False
        '
        'PorComplementarDataGridViewCheckBoxColumn
        '
        Me.PorComplementarDataGridViewCheckBoxColumn.DataPropertyName = "PorComplementar"
        Me.PorComplementarDataGridViewCheckBoxColumn.HeaderText = "PorComplementar"
        Me.PorComplementarDataGridViewCheckBoxColumn.Name = "PorComplementarDataGridViewCheckBoxColumn"
        Me.PorComplementarDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PorComplementarDataGridViewCheckBoxColumn.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModiToolStripMenuItem, Me.AgregarAPedidoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 70)
        Me.ContextMenuStrip1.Text = "Modificar"
        '
        'ModiToolStripMenuItem
        '
        Me.ModiToolStripMenuItem.Image = CType(resources.GetObject("ModiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModiToolStripMenuItem.Name = "ModiToolStripMenuItem"
        Me.ModiToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ModiToolStripMenuItem.Text = "Modificar"
        '
        'AgregarAPedidoToolStripMenuItem
        '
        Me.AgregarAPedidoToolStripMenuItem.Image = CType(resources.GetObject("AgregarAPedidoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarAPedidoToolStripMenuItem.Name = "AgregarAPedidoToolStripMenuItem"
        Me.AgregarAPedidoToolStripMenuItem.ShortcutKeyDisplayString = "F3"
        Me.AgregarAPedidoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AgregarAPedidoToolStripMenuItem.Text = "Agregar a pedido ..."
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Image = CType(resources.GetObject("EliminarProductoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar producto"
        '
        'SpinfoGeneralBindingSource
        '
        Me.SpinfoGeneralBindingSource.DataMember = "sp_infoGeneral"
        Me.SpinfoGeneralBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGV_Compras
        '
        Me.DGV_Compras.AllowUserToAddRows = False
        Me.DGV_Compras.AllowUserToDeleteRows = False
        Me.DGV_Compras.AllowUserToResizeRows = False
        Me.DGV_Compras.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ped, Me.Fact, Me.Nombre, Me.Compra, Me.Fecha2, Me.TC, Me.Euro, Me.Dolar, Me.Costo, Me.Arancel, Me.ArancelBs, Me.Flete, Me.OtrosG, Me.CostoBs})
        Me.DGV_Compras.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Compras.Location = New System.Drawing.Point(2, 442)
        Me.DGV_Compras.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Compras.Name = "DGV_Compras"
        Me.DGV_Compras.ReadOnly = True
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Compras.RowHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.DGV_Compras.RowHeadersVisible = False
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Compras.RowsDefaultCellStyle = DataGridViewCellStyle35
        Me.DGV_Compras.RowTemplate.Height = 19
        Me.DGV_Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Compras.Size = New System.Drawing.Size(603, 128)
        Me.DGV_Compras.TabIndex = 80
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!, System.Drawing.FontStyle.Underline)
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(387, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 14)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Desactivar filtros"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(325, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 20)
        Me.Label22.TabIndex = 97
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Chk_Proveedor
        '
        Me.Chk_Proveedor.AutoSize = True
        Me.Chk_Proveedor.Location = New System.Drawing.Point(6, 98)
        Me.Chk_Proveedor.Name = "Chk_Proveedor"
        Me.Chk_Proveedor.Size = New System.Drawing.Size(80, 18)
        Me.Chk_Proveedor.TabIndex = 86
        Me.Chk_Proveedor.Text = "Proveedor"
        Me.Chk_Proveedor.UseVisualStyleBackColor = True
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(367, 38)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(13, 14)
        Me.Label75.TabIndex = 14
        Me.Label75.Text = "y"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(385, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(42, 21)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(321, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 21)
        Me.TextBox1.TabIndex = 12
        '
        'Chk_ExistEntre
        '
        Me.Chk_ExistEntre.AutoSize = True
        Me.Chk_ExistEntre.Location = New System.Drawing.Point(231, 37)
        Me.Chk_ExistEntre.Name = "Chk_ExistEntre"
        Me.Chk_ExistEntre.Size = New System.Drawing.Size(84, 18)
        Me.Chk_ExistEntre.TabIndex = 5
        Me.Chk_ExistEntre.Text = "Exist. entre"
        Me.Chk_ExistEntre.UseVisualStyleBackColor = True
        '
        'Chk_Exist
        '
        Me.Chk_Exist.AutoSize = True
        Me.Chk_Exist.Location = New System.Drawing.Point(434, 6)
        Me.Chk_Exist.Name = "Chk_Exist"
        Me.Chk_Exist.Size = New System.Drawing.Size(73, 18)
        Me.Chk_Exist.TabIndex = 4
        Me.Chk_Exist.Text = "Exist. > 0"
        Me.Chk_Exist.UseVisualStyleBackColor = True
        '
        'Chk_Grupo
        '
        Me.Chk_Grupo.AutoSize = True
        Me.Chk_Grupo.Location = New System.Drawing.Point(6, 68)
        Me.Chk_Grupo.Name = "Chk_Grupo"
        Me.Chk_Grupo.Size = New System.Drawing.Size(60, 18)
        Me.Chk_Grupo.TabIndex = 2
        Me.Chk_Grupo.Text = "Grupo"
        Me.Chk_Grupo.UseVisualStyleBackColor = True
        '
        'Chk_Modelo
        '
        Me.Chk_Modelo.AutoSize = True
        Me.Chk_Modelo.Location = New System.Drawing.Point(6, 37)
        Me.Chk_Modelo.Name = "Chk_Modelo"
        Me.Chk_Modelo.Size = New System.Drawing.Size(66, 18)
        Me.Chk_Modelo.TabIndex = 1
        Me.Chk_Modelo.Text = "Modelo"
        Me.Chk_Modelo.UseVisualStyleBackColor = True
        '
        'Chk_Marca
        '
        Me.Chk_Marca.AutoSize = True
        Me.Chk_Marca.Location = New System.Drawing.Point(6, 6)
        Me.Chk_Marca.Name = "Chk_Marca"
        Me.Chk_Marca.Size = New System.Drawing.Size(58, 18)
        Me.Chk_Marca.TabIndex = 0
        Me.Chk_Marca.Text = "Marca"
        Me.Chk_Marca.UseVisualStyleBackColor = True
        '
        'DGV_Pedidos
        '
        Me.DGV_Pedidos.AllowUserToAddRows = False
        Me.DGV_Pedidos.AllowUserToDeleteRows = False
        Me.DGV_Pedidos.AllowUserToResizeRows = False
        Me.DGV_Pedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.BO, Me.CostoBs2})
        Me.DGV_Pedidos.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DGV_Pedidos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.Location = New System.Drawing.Point(2, 598)
        Me.DGV_Pedidos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Pedidos.Name = "DGV_Pedidos"
        Me.DGV_Pedidos.ReadOnly = True
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Pedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.DGV_Pedidos.RowHeadersVisible = False
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Pedidos.RowsDefaultCellStyle = DataGridViewCellStyle45
        Me.DGV_Pedidos.RowTemplate.Height = 19
        Me.DGV_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pedidos.Size = New System.Drawing.Size(603, 128)
        Me.DGV_Pedidos.TabIndex = 84
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridViewTextBoxColumn1.HeaderText = "St."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 122
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle37.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle38.Format = "d"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha St."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.Format = "n0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ped."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle40.Format = "#,##0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridViewTextBoxColumn6.HeaderText = "T/C"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 42
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle41.Format = "#,##0.00"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridViewTextBoxColumn7.HeaderText = "F.O.B"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle42.Format = "n0"
        DataGridViewCellStyle42.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'BO
        '
        Me.BO.HeaderText = "B/O"
        Me.BO.Name = "BO"
        Me.BO.ReadOnly = True
        Me.BO.Width = 37
        '
        'CostoBs2
        '
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CostoBs2.DefaultCellStyle = DataGridViewCellStyle43
        Me.CostoBs2.HeaderText = "Costo Bs."
        Me.CostoBs2.Name = "CostoBs2"
        Me.CostoBs2.ReadOnly = True
        Me.CostoBs2.Visible = False
        Me.CostoBs2.Width = 80
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(206, 48)
        Me.ContextMenuStrip2.Text = "Modificar cantidad"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeyDisplayString = "F5"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(205, 22)
        Me.ToolStripMenuItem2.Text = "Modificar cantidad ..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.ToolStripMenuItem1.Text = "Eliminar del pedido"
        '
        'cb_buscar
        '
        Me.cb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_buscar.FormattingEnabled = True
        Me.cb_buscar.Items.AddRange(New Object() {"Código Interno", "Descripción", "Código Fábrica", "OEM"})
        Me.cb_buscar.Location = New System.Drawing.Point(70, 12)
        Me.cb_buscar.Name = "cb_buscar"
        Me.cb_buscar.Size = New System.Drawing.Size(164, 23)
        Me.cb_buscar.TabIndex = 85
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(499, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Total Art.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(557, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 14)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(485, 422)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 14)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(390, 422)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 14)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Total renglones:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(485, 578)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 14)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(391, 578)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 14)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Total renglones:"
        '
        'DGV_Indicadores
        '
        Me.DGV_Indicadores.AllowUserToAddRows = False
        Me.DGV_Indicadores.AllowUserToDeleteRows = False
        Me.DGV_Indicadores.AllowUserToResizeColumns = False
        Me.DGV_Indicadores.AllowUserToResizeRows = False
        Me.DGV_Indicadores.ColumnHeadersHeight = 22
        Me.DGV_Indicadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Indicador, Me.Valor, Me.MD, Me.PorcInv, Me.Sugerida, Me.Otros})
        Me.DGV_Indicadores.Location = New System.Drawing.Point(4, 40)
        Me.DGV_Indicadores.MultiSelect = False
        Me.DGV_Indicadores.Name = "DGV_Indicadores"
        Me.DGV_Indicadores.ReadOnly = True
        Me.DGV_Indicadores.RowHeadersVisible = False
        Me.DGV_Indicadores.RowTemplate.Height = 32
        Me.DGV_Indicadores.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Indicadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Indicadores.Size = New System.Drawing.Size(465, 54)
        Me.DGV_Indicadores.TabIndex = 36
        '
        'Indicador
        '
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle46.Format = "N0"
        DataGridViewCellStyle46.NullValue = Nothing
        Me.Indicador.DefaultCellStyle = DataGridViewCellStyle46
        Me.Indicador.HeaderText = "Total Uni."
        Me.Indicador.Name = "Indicador"
        Me.Indicador.ReadOnly = True
        Me.Indicador.Width = 70
        '
        'Valor
        '
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle47.Format = "N0"
        DataGridViewCellStyle47.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle47
        Me.Valor.HeaderText = "Consumidos"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 85
        '
        'MD
        '
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle48.Format = "N2"
        DataGridViewCellStyle48.NullValue = Nothing
        Me.MD.DefaultCellStyle = DataGridViewCellStyle48
        Me.MD.HeaderText = "Disponibilidad"
        Me.MD.Name = "MD"
        Me.MD.ReadOnly = True
        Me.MD.Width = 94
        '
        'PorcInv
        '
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle49.Format = "N2"
        DataGridViewCellStyle49.NullValue = Nothing
        Me.PorcInv.DefaultCellStyle = DataGridViewCellStyle49
        Me.PorcInv.HeaderText = "% Inventario"
        Me.PorcInv.Name = "PorcInv"
        Me.PorcInv.ReadOnly = True
        Me.PorcInv.Width = 82
        '
        'Sugerida
        '
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle50.Format = "N0"
        DataGridViewCellStyle50.NullValue = Nothing
        Me.Sugerida.DefaultCellStyle = DataGridViewCellStyle50
        Me.Sugerida.HeaderText = "Sugerida"
        Me.Sugerida.Name = "Sugerida"
        Me.Sugerida.ReadOnly = True
        Me.Sugerida.Width = 70
        '
        'Otros
        '
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Otros.DefaultCellStyle = DataGridViewCellStyle51
        Me.Otros.HeaderText = "Otras C."
        Me.Otros.Name = "Otros"
        Me.Otros.ReadOnly = True
        Me.Otros.Width = 60
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage5.Controls.Add(Me.CheckBox1)
        Me.TabPage5.Controls.Add(Me.PictureBox2)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.DataGridView1)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Controls.Add(Me.DataGridView3)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Controls.Add(Me.DataGridView4)
        Me.TabPage5.Controls.Add(Me.DataGridView5)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.DataGridView6)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(478, 518)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Información"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(342, 425)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 18)
        Me.CheckBox1.TabIndex = 100
        Me.CheckBox1.Text = "Más Información"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(324, 456)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 99
        Me.PictureBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(165, 166)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(308, 20)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "Devoluciones"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(9, 293)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(306, 20)
        Me.Label23.TabIndex = 96
        Me.Label23.Text = "Ajustes"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle52.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle52
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 313)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle55.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle55
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(306, 87)
        Me.DataGridView1.TabIndex = 95
        '
        'DataGridViewTextBoxColumn24
        '
        DataGridViewCellStyle53.Format = "d"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle53
        Me.DataGridViewTextBoxColumn24.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 90
        '
        'DataGridViewTextBoxColumn25
        '
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle54.Format = "n0"
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle54
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 60
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 135
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(9, 405)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(308, 20)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "Ubicación"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle56.BackColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle56
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.DataGridView2.Location = New System.Drawing.Point(9, 425)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle58
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(306, 87)
        Me.DataGridView2.TabIndex = 93
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 65
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "Cuarto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 60
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Estante"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 58
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Tramo"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 55
        '
        'DataGridViewTextBoxColumn31
        '
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle57.Format = "n0"
        Me.DataGridViewTextBoxColumn31.DefaultCellStyle = DataGridViewCellStyle57
        Me.DataGridViewTextBoxColumn31.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 50
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "CodigoTramo"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.DataGridView3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView3.Location = New System.Drawing.Point(165, 186)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle62
        Me.DataGridView3.RowTemplate.Height = 19
        Me.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(307, 101)
        Me.DataGridView3.TabIndex = 98
        '
        'DataGridViewTextBoxColumn33
        '
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle59.Format = "N0"
        DataGridViewCellStyle59.NullValue = Nothing
        Me.DataGridViewTextBoxColumn33.DefaultCellStyle = DataGridViewCellStyle59
        Me.DataGridViewTextBoxColumn33.HeaderText = "Dv"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 28
        '
        'DataGridViewTextBoxColumn34
        '
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle60
        Me.DataGridViewTextBoxColumn34.HeaderText = "Fct"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 35
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "Razon Social"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 135
        '
        'DataGridViewTextBoxColumn36
        '
        DataGridViewCellStyle61.Format = "d"
        Me.DataGridViewTextBoxColumn36.DefaultCellStyle = DataGridViewCellStyle61
        Me.DataGridViewTextBoxColumn36.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 68
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "Aj"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 23
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(9, 166)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 20)
        Me.Label25.TabIndex = 91
        Me.Label25.Text = "Cod. Arancelario"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Location = New System.Drawing.Point(9, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(158, 37)
        Me.Panel3.TabIndex = 90
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 18)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "Por facturar:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(118, 8)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 18)
        Me.Label27.TabIndex = 89
        Me.Label27.Text = "##"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39})
        Me.DataGridView4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView4.Location = New System.Drawing.Point(9, 186)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.RowHeadersDefaultCellStyle = DataGridViewCellStyle64
        Me.DataGridView4.RowHeadersVisible = False
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView4.RowsDefaultCellStyle = DataGridViewCellStyle65
        Me.DataGridView4.RowTemplate.Height = 19
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(149, 101)
        Me.DataGridView4.TabIndex = 92
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 80
        '
        'DataGridViewTextBoxColumn39
        '
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle63.NullValue = Nothing
        Me.DataGridViewTextBoxColumn39.DefaultCellStyle = DataGridViewCellStyle63
        Me.DataGridViewTextBoxColumn39.HeaderText = "Imp."
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 50
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41})
        Me.DataGridView5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView5.Location = New System.Drawing.Point(304, 30)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersVisible = False
        DataGridViewCellStyle66.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView5.RowsDefaultCellStyle = DataGridViewCellStyle66
        Me.DataGridView5.RowTemplate.Height = 19
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(152, 87)
        Me.DataGridView5.TabIndex = 87
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.Frozen = True
        Me.DataGridViewTextBoxColumn40.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 135
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        Me.DataGridViewTextBoxColumn41.Width = 150
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label28.Location = New System.Drawing.Point(6, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(272, 20)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Cod. Proveedor / OEM"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.AllowUserToResizeRows = False
        Me.DataGridView6.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45})
        Me.DataGridView6.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView6.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.RowHeadersVisible = False
        DataGridViewCellStyle67.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView6.RowsDefaultCellStyle = DataGridViewCellStyle67
        Me.DataGridView6.RowTemplate.Height = 19
        Me.DataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView6.Size = New System.Drawing.Size(272, 87)
        Me.DataGridView6.TabIndex = 85
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.HeaderText = "Cod. Producto"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Width = 170
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.HeaderText = "Variante1"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Width = 160
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.HeaderText = "Variante2"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 160
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Location = New System.Drawing.Point(304, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(152, 20)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Grupos"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.Label31)
        Me.TabPage6.Controls.Add(Me.Label32)
        Me.TabPage6.Controls.Add(Me.Label33)
        Me.TabPage6.Controls.Add(Me.GroupBox2)
        Me.TabPage6.Controls.Add(Me.Label36)
        Me.TabPage6.Controls.Add(Me.Label37)
        Me.TabPage6.Controls.Add(Me.DataGridView7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(478, 518)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Ventas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(115, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 14)
        Me.Label30.TabIndex = 106
        Me.Label30.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(22, 10)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(84, 14)
        Me.Label31.TabIndex = 105
        Me.Label31.Text = "Total Devueltos:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label32.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(443, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 14)
        Me.Label32.TabIndex = 104
        Me.Label32.Text = "0"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label33.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(355, 9)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(82, 14)
        Me.Label33.TabIndex = 103
        Me.Label33.Text = "Total Vendidos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 56)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parámetros"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"3", "6", "9", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox1.TabIndex = 98
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(357, 22)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker3.TabIndex = 105
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label34.Location = New System.Drawing.Point(339, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 14)
        Me.Label34.TabIndex = 105
        Me.Label34.Text = "y"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Enabled = False
        Me.DateTimePicker4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(243, 22)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker4.TabIndex = 104
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(181, 25)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(53, 18)
        Me.RadioButton3.TabIndex = 103
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Entre"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.RadioButton4.Location = New System.Drawing.Point(7, 26)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 18)
        Me.RadioButton4.TabIndex = 102
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Ultimos"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(117, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 14)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Meses"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Eras Medium ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(77, 357)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(331, 31)
        Me.Label36.TabIndex = 99
        Me.Label36.Text = "El Gráfico no tiene datos"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label37.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label37.Location = New System.Drawing.Point(7, 6)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(465, 23)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "Ventas"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView7
        '
        Me.DataGridView7.AllowUserToAddRows = False
        Me.DataGridView7.AllowUserToDeleteRows = False
        Me.DataGridView7.AllowUserToResizeRows = False
        DataGridViewCellStyle68.BackColor = System.Drawing.Color.White
        Me.DataGridView7.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle68
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51})
        Me.DataGridView7.EnableHeadersVisualStyles = False
        Me.DataGridView7.Location = New System.Drawing.Point(7, 27)
        Me.DataGridView7.MultiSelect = False
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.ReadOnly = True
        Me.DataGridView7.RowHeadersVisible = False
        DataGridViewCellStyle73.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView7.RowsDefaultCellStyle = DataGridViewCellStyle73
        Me.DataGridView7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView7.Size = New System.Drawing.Size(465, 132)
        Me.DataGridView7.TabIndex = 97
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.HeaderText = "Fact."
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 50
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Width = 170
        '
        'DataGridViewTextBoxColumn48
        '
        DataGridViewCellStyle69.Format = "d"
        Me.DataGridViewTextBoxColumn48.DefaultCellStyle = DataGridViewCellStyle69
        Me.DataGridViewTextBoxColumn48.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Width = 80
        '
        'DataGridViewTextBoxColumn49
        '
        DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle70.Format = "n0"
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle70
        Me.DataGridViewTextBoxColumn49.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Width = 50
        '
        'DataGridViewTextBoxColumn50
        '
        DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle71.Format = "n2"
        Me.DataGridViewTextBoxColumn50.DefaultCellStyle = DataGridViewCellStyle71
        Me.DataGridViewTextBoxColumn50.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Width = 55
        '
        'DataGridViewTextBoxColumn51
        '
        DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle72.Format = "n0"
        Me.DataGridViewTextBoxColumn51.DefaultCellStyle = DataGridViewCellStyle72
        Me.DataGridViewTextBoxColumn51.HeaderText = "Dev"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 39
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DataGridView8)
        Me.TabPage7.Controls.Add(Me.GroupBox3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(478, 518)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Indicadores"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.AllowUserToResizeColumns = False
        Me.DataGridView8.AllowUserToResizeRows = False
        Me.DataGridView8.ColumnHeadersHeight = 22
        Me.DataGridView8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53})
        Me.DataGridView8.Location = New System.Drawing.Point(19, 28)
        Me.DataGridView8.MultiSelect = False
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.RowHeadersVisible = False
        DataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle75.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.DataGridView8.RowsDefaultCellStyle = DataGridViewCellStyle75
        Me.DataGridView8.RowTemplate.Height = 32
        Me.DataGridView8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView8.Size = New System.Drawing.Size(433, 254)
        Me.DataGridView8.TabIndex = 36
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.HeaderText = "Indicador"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Width = 310
        '
        'DataGridViewTextBoxColumn53
        '
        DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle74.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn53.DefaultCellStyle = DataGridViewCellStyle74
        Me.DataGridViewTextBoxColumn53.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox5)
        Me.GroupBox3.Controls.Add(Me.CheckBox6)
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 152)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label38.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!, System.Drawing.FontStyle.Underline)
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(393, 119)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(85, 14)
        Me.Label38.TabIndex = 92
        Me.Label38.Text = "Desactivar filtros"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Red
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label39.Location = New System.Drawing.Point(235, 119)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(143, 20)
        Me.Label39.TabIndex = 97
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label39.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(102, 115)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 87
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 119)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 21)
        Me.CheckBox2.TabIndex = 86
        Me.CheckBox2.Text = "Proveedor"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(366, 61)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(15, 17)
        Me.Label40.TabIndex = 14
        Me.Label40.Text = "y"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(387, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(25, 23)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(335, 57)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(25, 23)
        Me.TextBox4.TabIndex = 12
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(102, 85)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox3.TabIndex = 9
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(102, 56)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox4.TabIndex = 8
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(102, 27)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox5.TabIndex = 7
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(232, 58)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(95, 21)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "Exist. entre"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(232, 27)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(82, 21)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "Exist. > 0"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(7, 89)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(66, 21)
        Me.CheckBox5.TabIndex = 2
        Me.CheckBox5.Text = "Grupo"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(7, 58)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(73, 21)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "Modelo"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(7, 27)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(65, 21)
        Me.CheckBox7.TabIndex = 0
        Me.CheckBox7.Text = "Marca"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.White
        Me.TabPage8.Controls.Add(Me.Label41)
        Me.TabPage8.Controls.Add(Me.Panel4)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(478, 518)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "Foto"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Eras Medium ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(116, 52)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(247, 31)
        Me.Label41.TabIndex = 89
        Me.Label41.Text = "Foto del producto"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(78, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 277)
        Me.Panel4.TabIndex = 76
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(79, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(168, 174)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.TabControl2.Location = New System.Drawing.Point(612, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(547, 152)
        Me.TabControl2.TabIndex = 92
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.White
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage9.Controls.Add(Me.Label66)
        Me.TabPage9.Controls.Add(Me.lb_marca2)
        Me.TabPage9.Controls.Add(Me.cb_marc2)
        Me.TabPage9.Controls.Add(Me.chk_fr)
        Me.TabPage9.Controls.Add(Me.tb_compra)
        Me.TabPage9.Controls.Add(Me.chk_compra)
        Me.TabPage9.Controls.Add(Me.chk_POculto)
        Me.TabPage9.Controls.Add(Me.cb_proveedor)
        Me.TabPage9.Controls.Add(Me.cb_grup)
        Me.TabPage9.Controls.Add(Me.cb_model)
        Me.TabPage9.Controls.Add(Me.cb_marc)
        Me.TabPage9.Controls.Add(Me.Label16)
        Me.TabPage9.Controls.Add(Me.Chk_Marca)
        Me.TabPage9.Controls.Add(Me.Label22)
        Me.TabPage9.Controls.Add(Me.Chk_Modelo)
        Me.TabPage9.Controls.Add(Me.Chk_Grupo)
        Me.TabPage9.Controls.Add(Me.Chk_Proveedor)
        Me.TabPage9.Controls.Add(Me.Chk_Exist)
        Me.TabPage9.Controls.Add(Me.Label75)
        Me.TabPage9.Controls.Add(Me.Chk_ExistEntre)
        Me.TabPage9.Controls.Add(Me.TextBox2)
        Me.TabPage9.Controls.Add(Me.TextBox1)
        Me.TabPage9.Location = New System.Drawing.Point(4, 23)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(539, 125)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Filtros"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(228, 10)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(49, 14)
        Me.Label66.TabIndex = 10066
        Me.Label66.Text = "Marca 2"
        '
        'lb_marca2
        '
        Me.lb_marca2.DataSource = Me.SpconsultaMarcaBindingSource
        Me.lb_marca2.DisplayMember = "Marca"
        Me.lb_marca2.FormattingEnabled = True
        Me.lb_marca2.ItemHeight = 14
        Me.lb_marca2.Location = New System.Drawing.Point(292, 26)
        Me.lb_marca2.Name = "lb_marca2"
        Me.lb_marca2.Size = New System.Drawing.Size(121, 74)
        Me.lb_marca2.TabIndex = 10065
        Me.lb_marca2.ValueMember = "Marca"
        Me.lb_marca2.Visible = False
        '
        'SpconsultaMarcaBindingSource
        '
        Me.SpconsultaMarcaBindingSource.DataMember = "sp_consultaMarca"
        Me.SpconsultaMarcaBindingSource.DataSource = Me.MELDataSet
        '
        'cb_marc2
        '
        Me.cb_marc2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_marc2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_marc2.Enabled = False
        Me.cb_marc2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marc2.ForeColor = System.Drawing.Color.Black
        Me.cb_marc2.Location = New System.Drawing.Point(292, 6)
        Me.cb_marc2.Name = "cb_marc2"
        Me.cb_marc2.Size = New System.Drawing.Size(121, 21)
        Me.cb_marc2.TabIndex = 10064
        '
        'chk_fr
        '
        Me.chk_fr.AutoSize = True
        Me.chk_fr.Location = New System.Drawing.Point(321, 68)
        Me.chk_fr.Name = "chk_fr"
        Me.chk_fr.Size = New System.Drawing.Size(94, 18)
        Me.chk_fr.TabIndex = 10063
        Me.chk_fr.Text = "Líneas Varias"
        Me.chk_fr.UseVisualStyleBackColor = True
        '
        'tb_compra
        '
        Me.tb_compra.Enabled = False
        Me.tb_compra.Location = New System.Drawing.Point(321, 94)
        Me.tb_compra.Name = "tb_compra"
        Me.tb_compra.Size = New System.Drawing.Size(59, 21)
        Me.tb_compra.TabIndex = 10062
        '
        'chk_compra
        '
        Me.chk_compra.AutoSize = True
        Me.chk_compra.Location = New System.Drawing.Point(231, 98)
        Me.chk_compra.Name = "chk_compra"
        Me.chk_compra.Size = New System.Drawing.Size(68, 18)
        Me.chk_compra.TabIndex = 10061
        Me.chk_compra.Text = "Compra"
        Me.chk_compra.UseVisualStyleBackColor = True
        '
        'chk_POculto
        '
        Me.chk_POculto.AutoSize = True
        Me.chk_POculto.Location = New System.Drawing.Point(231, 68)
        Me.chk_POculto.Name = "chk_POculto"
        Me.chk_POculto.Size = New System.Drawing.Size(68, 18)
        Me.chk_POculto.TabIndex = 10060
        Me.chk_POculto.Text = "Ocultos"
        Me.chk_POculto.UseVisualStyleBackColor = True
        '
        'cb_proveedor
        '
        Me.cb_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_proveedor.Enabled = False
        Me.cb_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.ForeColor = System.Drawing.Color.Black
        Me.cb_proveedor.Location = New System.Drawing.Point(82, 94)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(121, 21)
        Me.cb_proveedor.TabIndex = 10059
        '
        'cb_grup
        '
        Me.cb_grup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_grup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_grup.Enabled = False
        Me.cb_grup.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_grup.ForeColor = System.Drawing.Color.Black
        Me.cb_grup.Location = New System.Drawing.Point(83, 67)
        Me.cb_grup.Name = "cb_grup"
        Me.cb_grup.Size = New System.Drawing.Size(121, 21)
        Me.cb_grup.TabIndex = 10058
        '
        'cb_model
        '
        Me.cb_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_model.Enabled = False
        Me.cb_model.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_model.ForeColor = System.Drawing.Color.Black
        Me.cb_model.Location = New System.Drawing.Point(82, 34)
        Me.cb_model.Name = "cb_model"
        Me.cb_model.Size = New System.Drawing.Size(121, 21)
        Me.cb_model.TabIndex = 10057
        '
        'cb_marc
        '
        Me.cb_marc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_marc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_marc.Enabled = False
        Me.cb_marc.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marc.ForeColor = System.Drawing.Color.Black
        Me.cb_marc.Location = New System.Drawing.Point(82, 6)
        Me.cb_marc.Name = "cb_marc"
        Me.cb_marc.Size = New System.Drawing.Size(121, 21)
        Me.cb_marc.TabIndex = 10055
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.White
        Me.TabPage10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage10.Controls.Add(Me.ComboBox6)
        Me.TabPage10.Controls.Add(Me.Label42)
        Me.TabPage10.Controls.Add(Me.DGV_Indicadores)
        Me.TabPage10.Location = New System.Drawing.Point(4, 23)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(539, 125)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Indicadores"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox6.Location = New System.Drawing.Point(347, 16)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(49, 22)
        Me.ComboBox6.TabIndex = 102
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label42.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label42.Location = New System.Drawing.Point(4, 14)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(465, 28)
        Me.Label42.TabIndex = 101
        Me.Label42.Text = "Indicadores de compras"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_modelo
        '
        Me.lb_modelo.DataSource = Me.TblModeloBindingSource
        Me.lb_modelo.DisplayMember = "Modelo"
        Me.lb_modelo.FormattingEnabled = True
        Me.lb_modelo.ItemHeight = 15
        Me.lb_modelo.Location = New System.Drawing.Point(702, 84)
        Me.lb_modelo.Name = "lb_modelo"
        Me.lb_modelo.Size = New System.Drawing.Size(121, 94)
        Me.lb_modelo.TabIndex = 10058
        Me.lb_modelo.ValueMember = "Modelo"
        Me.lb_modelo.Visible = False
        '
        'TblModeloBindingSource
        '
        Me.TblModeloBindingSource.DataMember = "Tbl_Modelo"
        Me.TblModeloBindingSource.DataSource = Me.MELDataSet
        '
        'lb_marca
        '
        Me.lb_marca.DataSource = Me.SpconsultaMarcaBindingSource
        Me.lb_marca.DisplayMember = "Marca"
        Me.lb_marca.FormattingEnabled = True
        Me.lb_marca.ItemHeight = 15
        Me.lb_marca.Location = New System.Drawing.Point(702, 56)
        Me.lb_marca.Name = "lb_marca"
        Me.lb_marca.Size = New System.Drawing.Size(121, 79)
        Me.lb_marca.TabIndex = 10056
        Me.lb_marca.ValueMember = "Marca"
        Me.lb_marca.Visible = False
        '
        'lb_grupo
        '
        Me.lb_grupo.DataSource = Me.TblGrupoBindingSource
        Me.lb_grupo.DisplayMember = "NombreGrupo"
        Me.lb_grupo.FormattingEnabled = True
        Me.lb_grupo.ItemHeight = 15
        Me.lb_grupo.Location = New System.Drawing.Point(703, 116)
        Me.lb_grupo.Name = "lb_grupo"
        Me.lb_grupo.Size = New System.Drawing.Size(121, 79)
        Me.lb_grupo.TabIndex = 10059
        Me.lb_grupo.ValueMember = "NombreGrupo"
        Me.lb_grupo.Visible = False
        '
        'TblGrupoBindingSource
        '
        Me.TblGrupoBindingSource.DataMember = "Tbl_Grupo"
        Me.TblGrupoBindingSource.DataSource = Me.MELDataSet
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label47.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(282, 295)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(14, 14)
        Me.Label47.TabIndex = 102
        Me.Label47.Text = "0"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label48.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(188, 295)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(90, 14)
        Me.Label48.TabIndex = 101
        Me.Label48.Text = "Total devueltos:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label49.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(436, 170)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(14, 14)
        Me.Label49.TabIndex = 94
        Me.Label49.Text = "0"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(342, 425)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(114, 18)
        Me.CheckBox8.TabIndex = 100
        Me.CheckBox8.Text = "Más Información"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label50.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(342, 170)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(90, 14)
        Me.Label50.TabIndex = 93
        Me.Label50.Text = "Total devueltos:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(324, 456)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(148, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 99
        Me.PictureBox5.TabStop = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label51.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Location = New System.Drawing.Point(165, 166)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(308, 20)
        Me.Label51.TabIndex = 97
        Me.Label51.Text = "Devoluciones"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label52.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label52.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label52.Location = New System.Drawing.Point(9, 293)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(306, 20)
        Me.Label52.TabIndex = 96
        Me.Label52.Text = "Ajustes"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.AllowUserToDeleteRows = False
        Me.DataGridView9.AllowUserToResizeRows = False
        DataGridViewCellStyle76.BackColor = System.Drawing.Color.White
        Me.DataGridView9.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle76
        Me.DataGridView9.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56})
        Me.DataGridView9.Location = New System.Drawing.Point(9, 313)
        Me.DataGridView9.MultiSelect = False
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.ReadOnly = True
        Me.DataGridView9.RowHeadersVisible = False
        DataGridViewCellStyle79.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView9.RowsDefaultCellStyle = DataGridViewCellStyle79
        Me.DataGridView9.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView9.Size = New System.Drawing.Size(306, 87)
        Me.DataGridView9.TabIndex = 95
        '
        'DataGridViewTextBoxColumn54
        '
        DataGridViewCellStyle77.Format = "d"
        Me.DataGridViewTextBoxColumn54.DefaultCellStyle = DataGridViewCellStyle77
        Me.DataGridViewTextBoxColumn54.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Width = 90
        '
        'DataGridViewTextBoxColumn55
        '
        DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle78.Format = "n0"
        Me.DataGridViewTextBoxColumn55.DefaultCellStyle = DataGridViewCellStyle78
        Me.DataGridViewTextBoxColumn55.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 60
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 135
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label53.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label53.Location = New System.Drawing.Point(9, 405)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(308, 20)
        Me.Label53.TabIndex = 94
        Me.Label53.Text = "Ubicación"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView10
        '
        Me.DataGridView10.AllowUserToAddRows = False
        Me.DataGridView10.AllowUserToDeleteRows = False
        Me.DataGridView10.AllowUserToResizeRows = False
        DataGridViewCellStyle80.BackColor = System.Drawing.Color.White
        Me.DataGridView10.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle80
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.DataGridView10.Location = New System.Drawing.Point(9, 425)
        Me.DataGridView10.MultiSelect = False
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.ReadOnly = True
        Me.DataGridView10.RowHeadersVisible = False
        DataGridViewCellStyle82.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView10.RowsDefaultCellStyle = DataGridViewCellStyle82
        Me.DataGridView10.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView10.Size = New System.Drawing.Size(306, 87)
        Me.DataGridView10.TabIndex = 93
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 65
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.HeaderText = "Cuarto"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 60
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.HeaderText = "Estante"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Width = 58
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.HeaderText = "Tramo"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Width = 55
        '
        'DataGridViewTextBoxColumn61
        '
        DataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle81.Format = "n0"
        Me.DataGridViewTextBoxColumn61.DefaultCellStyle = DataGridViewCellStyle81
        Me.DataGridViewTextBoxColumn61.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        Me.DataGridViewTextBoxColumn61.Width = 50
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.HeaderText = "CodigoTramo"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        Me.DataGridViewTextBoxColumn62.Visible = False
        '
        'DataGridView11
        '
        Me.DataGridView11.AllowUserToAddRows = False
        Me.DataGridView11.AllowUserToDeleteRows = False
        Me.DataGridView11.AllowUserToResizeRows = False
        Me.DataGridView11.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView11.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67})
        Me.DataGridView11.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView11.Location = New System.Drawing.Point(165, 186)
        Me.DataGridView11.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView11.Name = "DataGridView11"
        Me.DataGridView11.ReadOnly = True
        Me.DataGridView11.RowHeadersVisible = False
        DataGridViewCellStyle86.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DataGridView11.RowsDefaultCellStyle = DataGridViewCellStyle86
        Me.DataGridView11.RowTemplate.Height = 19
        Me.DataGridView11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView11.Size = New System.Drawing.Size(307, 101)
        Me.DataGridView11.TabIndex = 98
        '
        'DataGridViewTextBoxColumn63
        '
        DataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle83.Format = "N0"
        DataGridViewCellStyle83.NullValue = Nothing
        Me.DataGridViewTextBoxColumn63.DefaultCellStyle = DataGridViewCellStyle83
        Me.DataGridViewTextBoxColumn63.HeaderText = "Dv"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Width = 28
        '
        'DataGridViewTextBoxColumn64
        '
        DataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn64.DefaultCellStyle = DataGridViewCellStyle84
        Me.DataGridViewTextBoxColumn64.HeaderText = "Fct"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Width = 35
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.HeaderText = "Razon Social"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        Me.DataGridViewTextBoxColumn65.Width = 135
        '
        'DataGridViewTextBoxColumn66
        '
        DataGridViewCellStyle85.Format = "d"
        Me.DataGridViewTextBoxColumn66.DefaultCellStyle = DataGridViewCellStyle85
        Me.DataGridViewTextBoxColumn66.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        Me.DataGridViewTextBoxColumn66.Width = 68
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.HeaderText = "Aj"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        Me.DataGridViewTextBoxColumn67.Width = 23
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label54.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label54.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.Location = New System.Drawing.Point(9, 166)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(149, 20)
        Me.Label54.TabIndex = 91
        Me.Label54.Text = "Cod. Arancelario"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label55)
        Me.Panel5.Controls.Add(Me.Label56)
        Me.Panel5.Location = New System.Drawing.Point(9, 123)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 37)
        Me.Panel5.TabIndex = 90
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(8, 8)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(101, 18)
        Me.Label55.TabIndex = 88
        Me.Label55.Text = "Por facturar:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(118, 8)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(28, 18)
        Me.Label56.TabIndex = 89
        Me.Label56.Text = "##"
        '
        'DataGridView12
        '
        Me.DataGridView12.AllowUserToAddRows = False
        Me.DataGridView12.AllowUserToDeleteRows = False
        Me.DataGridView12.AllowUserToResizeRows = False
        Me.DataGridView12.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69})
        Me.DataGridView12.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView12.Location = New System.Drawing.Point(9, 186)
        Me.DataGridView12.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.ReadOnly = True
        DataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle88.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle88.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle88.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle88.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle88.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle88.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView12.RowHeadersDefaultCellStyle = DataGridViewCellStyle88
        Me.DataGridView12.RowHeadersVisible = False
        DataGridViewCellStyle89.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView12.RowsDefaultCellStyle = DataGridViewCellStyle89
        Me.DataGridView12.RowTemplate.Height = 19
        Me.DataGridView12.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView12.Size = New System.Drawing.Size(149, 101)
        Me.DataGridView12.TabIndex = 92
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        Me.DataGridViewTextBoxColumn68.Width = 80
        '
        'DataGridViewTextBoxColumn69
        '
        DataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle87.NullValue = Nothing
        Me.DataGridViewTextBoxColumn69.DefaultCellStyle = DataGridViewCellStyle87
        Me.DataGridViewTextBoxColumn69.HeaderText = "Imp."
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.ReadOnly = True
        Me.DataGridViewTextBoxColumn69.Width = 50
        '
        'DataGridView13
        '
        Me.DataGridView13.AllowUserToAddRows = False
        Me.DataGridView13.AllowUserToDeleteRows = False
        Me.DataGridView13.AllowUserToResizeRows = False
        Me.DataGridView13.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView13.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71})
        Me.DataGridView13.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView13.Location = New System.Drawing.Point(304, 30)
        Me.DataGridView13.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView13.Name = "DataGridView13"
        Me.DataGridView13.ReadOnly = True
        Me.DataGridView13.RowHeadersVisible = False
        DataGridViewCellStyle90.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView13.RowsDefaultCellStyle = DataGridViewCellStyle90
        Me.DataGridView13.RowTemplate.Height = 19
        Me.DataGridView13.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView13.Size = New System.Drawing.Size(152, 87)
        Me.DataGridView13.TabIndex = 87
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.Frozen = True
        Me.DataGridViewTextBoxColumn70.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Width = 135
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.ReadOnly = True
        Me.DataGridViewTextBoxColumn71.Visible = False
        Me.DataGridViewTextBoxColumn71.Width = 150
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label57.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label57.Location = New System.Drawing.Point(6, 10)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(272, 20)
        Me.Label57.TabIndex = 30
        Me.Label57.Text = "Cod. Proveedor / OEM"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView14
        '
        Me.DataGridView14.AllowUserToAddRows = False
        Me.DataGridView14.AllowUserToDeleteRows = False
        Me.DataGridView14.AllowUserToResizeRows = False
        Me.DataGridView14.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75})
        Me.DataGridView14.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView14.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView14.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView14.Name = "DataGridView14"
        Me.DataGridView14.ReadOnly = True
        Me.DataGridView14.RowHeadersVisible = False
        DataGridViewCellStyle91.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataGridView14.RowsDefaultCellStyle = DataGridViewCellStyle91
        Me.DataGridView14.RowTemplate.Height = 19
        Me.DataGridView14.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView14.Size = New System.Drawing.Size(272, 87)
        Me.DataGridView14.TabIndex = 85
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.ReadOnly = True
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.HeaderText = "Cod. Producto"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.ReadOnly = True
        Me.DataGridViewTextBoxColumn73.Width = 170
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.HeaderText = "Variante1"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.ReadOnly = True
        Me.DataGridViewTextBoxColumn74.Width = 160
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.HeaderText = "Variante2"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        Me.DataGridViewTextBoxColumn75.ReadOnly = True
        Me.DataGridViewTextBoxColumn75.Width = 160
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label58.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label58.Location = New System.Drawing.Point(304, 10)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(152, 20)
        Me.Label58.TabIndex = 31
        Me.Label58.Text = "Grupos"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.White
        Me.Label63.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label63.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label63.Location = New System.Drawing.Point(734, 2)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(426, 22)
        Me.Label63.TabIndex = 93
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.White
        Me.Label64.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label64.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label64.Location = New System.Drawing.Point(796, 160)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(318, 22)
        Me.Label64.TabIndex = 94
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(165, 424)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 14)
        Me.LinkLabel1.TabIndex = 95
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "(Flitrar)"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.White
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(165, 580)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(45, 14)
        Me.LinkLabel2.TabIndex = 96
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "(Flitrar)"
        '
        'Sp_infoGeneralTableAdapter
        '
        Me.Sp_infoGeneralTableAdapter.ClearBeforeFill = True
        '
        'Sp_infoGeneralComprasBindingSource
        '
        Me.Sp_infoGeneralComprasBindingSource.DataMember = "sp_infoGeneralCompras"
        Me.Sp_infoGeneralComprasBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_infoGeneralComprasTableAdapter
        '
        Me.Sp_infoGeneralComprasTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaMarcaTableAdapter
        '
        Me.Sp_consultaMarcaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_ModeloTableAdapter
        '
        Me.Tbl_ModeloTableAdapter.ClearBeforeFill = True
        '
        'Tbl_GrupoTableAdapter
        '
        Me.Tbl_GrupoTableAdapter.ClearBeforeFill = True
        '
        'lb_proveedor
        '
        Me.lb_proveedor.DataSource = Me.TblFabricaBindingSource
        Me.lb_proveedor.DisplayMember = "Nombre"
        Me.lb_proveedor.FormattingEnabled = True
        Me.lb_proveedor.ItemHeight = 15
        Me.lb_proveedor.Location = New System.Drawing.Point(702, 144)
        Me.lb_proveedor.Name = "lb_proveedor"
        Me.lb_proveedor.Size = New System.Drawing.Size(121, 79)
        Me.lb_proveedor.TabIndex = 10060
        Me.lb_proveedor.ValueMember = "Nombre"
        Me.lb_proveedor.Visible = False
        '
        'TblFabricaBindingSource
        '
        Me.TblFabricaBindingSource.DataMember = "Tbl_Fabrica"
        Me.TblFabricaBindingSource.DataSource = Me.MELDataSet
        '
        'Tbl_FabricaTableAdapter
        '
        Me.Tbl_FabricaTableAdapter.ClearBeforeFill = True
        '
        'bt_actualizar
        '
        Me.bt_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_actualizar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_actualizar.Image = CType(resources.GetObject("bt_actualizar.Image"), System.Drawing.Image)
        Me.bt_actualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_actualizar.Location = New System.Drawing.Point(499, 8)
        Me.bt_actualizar.Name = "bt_actualizar"
        Me.bt_actualizar.Size = New System.Drawing.Size(36, 31)
        Me.bt_actualizar.TabIndex = 10061
        Me.bt_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_actualizar.UseVisualStyleBackColor = False
        '
        'chk_exacto
        '
        Me.chk_exacto.AutoSize = True
        Me.chk_exacto.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_exacto.Location = New System.Drawing.Point(431, 15)
        Me.chk_exacto.Name = "chk_exacto"
        Me.chk_exacto.Size = New System.Drawing.Size(62, 18)
        Me.chk_exacto.TabIndex = 10062
        Me.chk_exacto.Text = "Exacto"
        Me.chk_exacto.UseVisualStyleBackColor = True
        '
        'lbl_totalUniC
        '
        Me.lbl_totalUniC.AutoSize = True
        Me.lbl_totalUniC.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_totalUniC.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.lbl_totalUniC.ForeColor = System.Drawing.Color.White
        Me.lbl_totalUniC.Location = New System.Drawing.Point(340, 422)
        Me.lbl_totalUniC.Name = "lbl_totalUniC"
        Me.lbl_totalUniC.Size = New System.Drawing.Size(14, 14)
        Me.lbl_totalUniC.TabIndex = 10064
        Me.lbl_totalUniC.Text = "0"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label67.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label67.ForeColor = System.Drawing.Color.White
        Me.Label67.Location = New System.Drawing.Point(246, 422)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(89, 14)
        Me.Label67.TabIndex = 10063
        Me.Label67.Text = "Total Unidades:"
        '
        'lbl_totalUniPro
        '
        Me.lbl_totalUniPro.AutoSize = True
        Me.lbl_totalUniPro.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_totalUniPro.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.lbl_totalUniPro.ForeColor = System.Drawing.Color.White
        Me.lbl_totalUniPro.Location = New System.Drawing.Point(415, 55)
        Me.lbl_totalUniPro.Name = "lbl_totalUniPro"
        Me.lbl_totalUniPro.Size = New System.Drawing.Size(14, 14)
        Me.lbl_totalUniPro.TabIndex = 10066
        Me.lbl_totalUniPro.Text = "0"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label68.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label68.ForeColor = System.Drawing.Color.White
        Me.Label68.Location = New System.Drawing.Point(353, 55)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(61, 14)
        Me.Label68.TabIndex = 10065
        Me.Label68.Text = "Total Uni.:"
        '
        'bt_etiquetas
        '
        Me.bt_etiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_etiquetas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_etiquetas.Image = CType(resources.GetObject("bt_etiquetas.Image"), System.Drawing.Image)
        Me.bt_etiquetas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_etiquetas.Location = New System.Drawing.Point(541, 8)
        Me.bt_etiquetas.Name = "bt_etiquetas"
        Me.bt_etiquetas.Size = New System.Drawing.Size(36, 31)
        Me.bt_etiquetas.TabIndex = 10067
        Me.bt_etiquetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_etiquetas.UseVisualStyleBackColor = False
        '
        'Ped
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N0"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.Ped.DefaultCellStyle = DataGridViewCellStyle27
        Me.Ped.HeaderText = "Cant."
        Me.Ped.Name = "Ped"
        Me.Ped.ReadOnly = True
        Me.Ped.Width = 48
        '
        'Fact
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.Format = "N0"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.Fact.DefaultCellStyle = DataGridViewCellStyle28
        Me.Fact.HeaderText = "Fact."
        Me.Fact.Name = "Fact"
        Me.Fact.ReadOnly = True
        Me.Fact.Width = 75
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Proveedor"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 75
        '
        'Compra
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.Format = "N0"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.Compra.DefaultCellStyle = DataGridViewCellStyle29
        Me.Compra.HeaderText = "Cod."
        Me.Compra.Name = "Compra"
        Me.Compra.ReadOnly = True
        Me.Compra.Width = 40
        '
        'Fecha2
        '
        DataGridViewCellStyle30.Format = "d"
        DataGridViewCellStyle30.NullValue = Nothing
        Me.Fecha2.DefaultCellStyle = DataGridViewCellStyle30
        Me.Fecha2.HeaderText = "Fecha"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.ReadOnly = True
        Me.Fecha2.Width = 75
        '
        'TC
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "#,##0.00"
        Me.TC.DefaultCellStyle = DataGridViewCellStyle31
        Me.TC.HeaderText = "T/C"
        Me.TC.Name = "TC"
        Me.TC.ReadOnly = True
        Me.TC.Visible = False
        Me.TC.Width = 45
        '
        'Euro
        '
        Me.Euro.HeaderText = "€"
        Me.Euro.Name = "Euro"
        Me.Euro.ReadOnly = True
        Me.Euro.Visible = False
        Me.Euro.Width = 35
        '
        'Dolar
        '
        Me.Dolar.HeaderText = "$"
        Me.Dolar.Name = "Dolar"
        Me.Dolar.ReadOnly = True
        Me.Dolar.Visible = False
        Me.Dolar.Width = 35
        '
        'Costo
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle32
        Me.Costo.HeaderText = "FOB"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 60
        '
        'Arancel
        '
        Me.Arancel.HeaderText = "Ara (%)"
        Me.Arancel.Name = "Arancel"
        Me.Arancel.ReadOnly = True
        Me.Arancel.Visible = False
        Me.Arancel.Width = 45
        '
        'ArancelBs
        '
        Me.ArancelBs.HeaderText = "Ara Bs."
        Me.ArancelBs.Name = "ArancelBs"
        Me.ArancelBs.ReadOnly = True
        Me.ArancelBs.Visible = False
        Me.ArancelBs.Width = 50
        '
        'Flete
        '
        Me.Flete.HeaderText = "Flete"
        Me.Flete.Name = "Flete"
        Me.Flete.ReadOnly = True
        Me.Flete.Visible = False
        Me.Flete.Width = 40
        '
        'OtrosG
        '
        Me.OtrosG.HeaderText = "Otros G."
        Me.OtrosG.Name = "OtrosG"
        Me.OtrosG.ReadOnly = True
        Me.OtrosG.Visible = False
        Me.OtrosG.Width = 50
        '
        'CostoBs
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CostoBs.DefaultCellStyle = DataGridViewCellStyle33
        Me.CostoBs.HeaderText = "Costo Bs."
        Me.CostoBs.Name = "CostoBs"
        Me.CostoBs.ReadOnly = True
        Me.CostoBs.Visible = False
        Me.CostoBs.Width = 75
        '
        'Frm_Compras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1162, 729)
        Me.Controls.Add(Me.bt_etiquetas)
        Me.Controls.Add(Me.lb_proveedor)
        Me.Controls.Add(Me.lb_grupo)
        Me.Controls.Add(Me.lb_modelo)
        Me.Controls.Add(Me.lbl_totalUniPro)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.lbl_totalUniC)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.chk_exacto)
        Me.Controls.Add(Me.bt_actualizar)
        Me.Controls.Add(Me.lb_marca)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.cb_buscar)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.DGV_Compras)
        Me.Controls.Add(Me.ti_compras)
        Me.Controls.Add(Me.ti_pedidos)
        Me.Controls.Add(Me.ti_productos)
        Me.Controls.Add(Me.DGV_Pedidos)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Compras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información General"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_obs.ResumeLayout(False)
        Me.gb_obs.PerformLayout()
        CType(Me.DGV_Ajustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Direccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Devoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Arancelarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Grupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.gb_funciones.ResumeLayout(False)
        Me.gb_funciones.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SpinfoGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Indicadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        CType(Me.TblModeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_infoGeneralComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_Compras_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If indice > 0 Then
            act = True
            DGV_Productos.Rows(indice).Cells(0).Selected = True
            DGV_Productos.Focus()
            act = False
        End If
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

            If Frm_Principal.conex.State = ConnectionState.Broken Or Frm_Principal.conex.State = ConnectionState.Closed Then
                Frm_Principal.conex.Open()
            End If

            Me.Tbl_FabricaTableAdapter.Fill(Me.MELDataSet.Tbl_Fabrica, 0)
            cb_proveedor.Text = "- Selecciona -"
            Me.Tbl_GrupoTableAdapter.Fill(Me.MELDataSet.Tbl_Grupo, 0, 0, "")
            cb_grup.Text = "- Selecciona -"
            Me.Tbl_ModeloTableAdapter.Fill(Me.MELDataSet.Tbl_Modelo, 0, 0)
            cb_model.Text = "- Selecciona -"
            Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
            cb_marc.Text = "- Selecciona -"
            Datos.consultaLogo(PictureBox3)

            MELDataSet.EnforceConstraints = False

            If My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 1)
            ElseIf My.Settings.Empresa = 1 Then
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 2)
            ElseIf My.Settings.Empresa = 5 Then
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 1)
            Else
                chk_fr.Visible = False
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 0)
            End If

            'chk_fr.Visible = False
            ComboBox6.SelectedIndex = 0
            'chk_info.Checked = True
            DGV_Productos.ClearSelection()
            cb_buscar.SelectedIndex = 0
            DateTimePicker1.Value = DateAdd(DateInterval.Month, -3, Today)
            cb_mesesGrafico.SelectedIndex = 0
            RadioButton1.Checked = True
            contarfilas()
            DGV_Indicadores.Rows.Clear()
            DGV_Indicadores.Rows.Add(0, 0, 0, 0, 0, 0)
            DGV_Indicadores.ClearSelection()

            CrearWhere()

            tb_buscarcodigo.Focus()
            tb_buscarcodigo.Select()

            If Me.e = False Then
                AgregarAPedidoToolStripMenuItem.Visible = False
                DGV_Productos.Size = New Drawing.Size(603, 634)
                DGV_Compras.Visible = False
                DGV_Pedidos.Visible = False
                ti_pedidos.Visible = False
                ti_compras.Visible = False
                DGV_Productos.BringToFront()
                chk_oculto.Visible = False
                gb_obs.Visible = False
                TabControl2.TabPages(1).Dispose()
                lbl_info.Visible = False
                gb_funciones.Visible = False
                PictureBox3.Visible = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub FillDGV()
        CrearWhere()
        DGV_Productos.ClearSelection()
        contarfilas()
    End Sub

    '------------------------------------------------------ COMBO MARCA ----------------------------'

    Private Sub cb_marc_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_marc.MouseClick
        If lb_marca.Visible = False Then
            lb_marca.Visible = True
            Me.SpconsultaMarcaBindingSource.RemoveFilter()
            lb_marca.SelectedValue = cb_marc.Text
        End If
    End Sub
    Private Sub cb_marc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marc.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_marca.Visible = False Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
                lb_marca.Visible = True
                lb_marca.SelectedValue = cb_marc.Text
            Else
                If lb_marca.Items.Count > 1 Then
                    lb_marca.Focus()
                    lb_marca.SelectedIndex = lb_marca.SelectedIndex + 1
                Else
                    cb_marc.SelectionStart = 0
                    cb_marc.SelectionLength = cb_marc.Text.Length
                    cb_marc.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_marca.Visible = True Then
                If lb_marca.Items.Count > 1 Then
                    lb_marca.Focus()
                    lb_marca.SelectedIndex = lb_marca.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_marca.Visible Then
            lb_marca.Visible = False
            If lb_marca.Items.Count > 0 Then
                cb_marc.Text = lb_marca.SelectedItem(0).ToString
                FillDGV()
                lb_marca.SelectedIndex = 0
            Else
                cb_marc.Text = ""
            End If
            cb_marc.SelectionStart = cb_marc.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_marc.Text.Length <= 1 Or cb_marc.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text.Substring(0, cb_marc.Text.Length - 1) & "%'"
            End If
        End If
    End Sub
    Private Sub cb_marc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_marc.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_marc.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & e.KeyChar & "%'"
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text & e.KeyChar & "%'"
            End If

            If lb_marca.Items.Count = 0 Then
                e.Handled = True
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text & "%'"
            Else
                e.Handled = False
                lb_marca.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_marca.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_marc_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marc.GotFocus
        If cb_marc.Text = "- Selecciona -" Then
            cb_marc.Text = ""
            Me.SpconsultaMarcaBindingSource.Filter = "Marca  LIKE '%" & cb_marc.Text & "%'"
            lb_marca.Visible = True
        End If
    End Sub
    Public Sub lb_marca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_marca.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_marca.SelectedIndex = 1 Then
                cb_marc.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_marca.Visible = False
            cb_marc.Text = lb_marca.SelectedItem(0).ToString
            FillDGV()
            lb_marca.SelectedIndex = 0
            cb_marc.Focus()
            cb_marc.SelectionStart = cb_marc.Text.Length
        End If
    End Sub
    Private Sub lb_marca_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_marca.MouseClick
        lb_marca.Visible = False
        cb_marc.Text = lb_marca.SelectedItem(0).ToString
        FillDGV()
        lb_marca.SelectedIndex = 0
        cb_marc.Focus()
        cb_marc.SelectionStart = cb_marc.Text.Length
    End Sub

    '--------------fin combo

    '------------------------------------------------------ COMBO MARCA 2 ----------------------------'

    Private Sub cb_marc2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_marc2.MouseClick
        If lb_marca2.Visible = False Then
            lb_marca2.Visible = True
            Me.SpconsultaMarcaBindingSource.RemoveFilter()
            lb_marca2.SelectedValue = cb_marc2.Text
        End If
    End Sub
    Private Sub cb_marc2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marc2.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_marca2.Visible = False Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
                lb_marca2.Visible = True
                lb_marca2.SelectedValue = cb_marc2.Text
            Else
                If lb_marca2.Items.Count > 1 Then
                    lb_marca2.Focus()
                    lb_marca2.SelectedIndex = lb_marca2.SelectedIndex + 1
                Else
                    cb_marc2.SelectionStart = 0
                    cb_marc2.SelectionLength = cb_marc2.Text.Length
                    cb_marc2.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_marca2.Visible = True Then
                If lb_marca2.Items.Count > 1 Then
                    lb_marca2.Focus()
                    lb_marca2.SelectedIndex = lb_marca2.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_marca2.Visible Then
            lb_marca2.Visible = False
            If lb_marca2.Items.Count > 0 Then
                cb_marc2.Text = lb_marca2.SelectedItem(0).ToString
                FillDGV()
                lb_marca2.SelectedIndex = 0
            Else
                cb_marc2.Text = ""
            End If
            cb_marc2.SelectionStart = cb_marc2.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_marc2.Text.Length <= 1 Or cb_marc2.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc2.Text.Substring(0, cb_marc2.Text.Length - 1) & "%'"
            End If
        End If
    End Sub
    Private Sub cb_marc2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_marc2.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_marc2.SelectedText <> "" Then
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & e.KeyChar & "%'"
            Else
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc2.Text & e.KeyChar & "%'"
            End If

            If lb_marca2.Items.Count = 0 Then
                e.Handled = True
                Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc2.Text & "%'"
            Else
                e.Handled = False
                lb_marca2.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_marca2.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_marc2_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marc2.GotFocus
        If cb_marc2.Text = "- Selecciona -" Then
            cb_marc2.Text = ""
            Me.SpconsultaMarcaBindingSource.Filter = "Marca  LIKE '%" & cb_marc2.Text & "%'"
            lb_marca2.Visible = True
        End If
    End Sub
    Public Sub lb_marca2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_marca2.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_marca2.SelectedIndex = 1 Then
                cb_marc2.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_marca2.Visible = False
            cb_marc2.Text = lb_marca2.SelectedItem(0).ToString
            FillDGV()
            lb_marca2.SelectedIndex = 0
            cb_marc2.Focus()
            cb_marc2.SelectionStart = cb_marc2.Text.Length
        End If
    End Sub
    Private Sub lb_marca2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_marca2.MouseClick
        lb_marca2.Visible = False
        cb_marc2.Text = lb_marca2.SelectedItem(0).ToString
        FillDGV()
        lb_marca2.SelectedIndex = 0
        cb_marc2.Focus()
        cb_marc2.SelectionStart = cb_marc2.Text.Length
    End Sub

    '--------------fin combo


    '------------------------------------------------------ COMBO MODELO -------------------------'

    Private Sub cb_model_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_model.MouseClick
        If lb_modelo.Visible = False Then
            lb_modelo.Visible = True
            Me.TblModeloBindingSource.RemoveFilter()
            If cb_marc.Text = "- Selecciona -" Then
                Me.TblModeloBindingSource.RemoveFilter()
            Else
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
            End If


            lb_modelo.SelectedValue = cb_model.Text
        End If
    End Sub
    Private Sub cb_model_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_model.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_modelo.Visible = False Then
                Me.TblModeloBindingSource.RemoveFilter()
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                lb_modelo.Visible = True
                lb_modelo.SelectedValue = cb_model.Text
            Else
                If lb_modelo.Items.Count > 1 Then
                    lb_modelo.Focus()
                    lb_modelo.SelectedIndex = lb_modelo.SelectedIndex + 1
                Else
                    cb_model.SelectionStart = 0
                    cb_model.SelectionLength = cb_model.Text.Length
                    cb_model.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_modelo.Visible = True Then
                If lb_modelo.Items.Count > 1 Then
                    lb_modelo.Focus()
                    lb_modelo.SelectedIndex = lb_modelo.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_modelo.Visible Then
            lb_modelo.Visible = False
            If lb_modelo.Items.Count > 0 Then
                cb_model.Text = lb_modelo.SelectedItem(0).ToString
                cb_model.Tag = lb_modelo.SelectedItem(1).ToString
                FillDGV()
                If Chk_Marca.Checked Then
                    cb_marc.Enabled = False
                End If
                lb_modelo.SelectedIndex = 0
            Else
                cb_model.Text = ""
            End If
            cb_model.SelectionStart = cb_model.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_model.Text.Length <= 1 Or cb_model.SelectedText <> "" Then
                If cb_marc.Text = "- Selecciona -" Then
                    Me.TblModeloBindingSource.RemoveFilter()
                Else
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                End If
            Else
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text.Substring(0, cb_model.Text.Length - 1) & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text.Substring(0, cb_model.Text.Length - 1) & "%'"
                End If

            End If
        End If
    End Sub
    Private Sub cb_model_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_model.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_model.SelectedText <> "" Then
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & e.KeyChar & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & e.KeyChar & "%'"
                End If
            Else
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & e.KeyChar & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text & e.KeyChar & "%'"
                End If
            End If
            If lb_modelo.Items.Count = 0 Then
                e.Handled = True
                If Chk_Marca.Checked Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Modelo LIKE '%" & cb_model.Text & "%'"
                End If
            Else
                e.Handled = False
                lb_modelo.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_modelo.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_model_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_model.GotFocus
        If cb_model.Text = "- Selecciona -" Then
            cb_model.Text = ""
            If Chk_Marca.Checked Then
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo  LIKE '%" & cb_model.Text & "%'"
            Else
                Me.TblModeloBindingSource.Filter = "Modelo  LIKE '%" & cb_model.Text & "%'"
            End If
            lb_modelo.Visible = True
        End If
    End Sub
    Public Sub lb_modelo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_modelo.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_modelo.SelectedIndex = 1 Then
                cb_model.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_modelo.Visible = False
            cb_model.Text = lb_modelo.SelectedItem(0).ToString
            cb_model.Tag = lb_modelo.SelectedItem(1).ToString
            FillDGV()
            If Chk_Marca.Checked Then
                cb_marc.Enabled = False
            End If
            lb_modelo.SelectedIndex = 0
            cb_model.Focus()
            cb_model.SelectionStart = cb_model.Text.Length
        End If
    End Sub
    Private Sub lb_modelo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_modelo.MouseClick
        lb_modelo.Visible = False
        cb_model.Text = lb_modelo.SelectedItem(0).ToString
        cb_model.Tag = lb_modelo.SelectedItem(1).ToString
        FillDGV()
        If Chk_Marca.Checked Then
            cb_marc.Enabled = False
        End If
        lb_modelo.SelectedIndex = 0
        cb_model.Focus()
        cb_model.SelectionStart = cb_model.Text.Length
    End Sub

    '--------------fin combo



    '------------------------------------------------------ COMBO GRUPO ----------------------------'

    Private Sub cb_grup_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_grup.MouseClick
        If lb_grupo.Visible = False Then
            lb_grupo.Visible = True
            Me.TblGrupoBindingSource.RemoveFilter()
            lb_grupo.SelectedValue = cb_grup.Text
        End If
    End Sub
    Private Sub cb_grup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_grup.KeyDown
        If e.KeyData = Keys.Down Then
            If lb_grupo.Visible = False Then
                Me.TblGrupoBindingSource.RemoveFilter()
                lb_grupo.Visible = True
                lb_grupo.SelectedValue = cb_grup.Text
            Else
                If lb_grupo.Items.Count > 1 Then
                    lb_grupo.Focus()
                    lb_grupo.SelectedIndex = lb_grupo.SelectedIndex + 1
                Else
                    cb_grup.SelectionStart = 0
                    cb_grup.SelectionLength = cb_grup.Text.Length
                    cb_grup.Focus()
                End If
            End If
        ElseIf e.KeyData = Keys.Up Then
            If lb_grupo.Visible = True Then
                If lb_grupo.Items.Count > 1 Then
                    lb_grupo.Focus()
                    lb_grupo.SelectedIndex = lb_grupo.SelectedIndex - 1
                End If
            End If
        ElseIf e.KeyData = Keys.Enter And lb_grupo.Visible Then
            lb_grupo.Visible = False
            If lb_grupo.Items.Count > 0 Then
                cb_grup.Text = lb_grupo.SelectedItem(0).ToString
                cb_grup.Tag = lb_grupo.SelectedItem(1).ToString
                FillDGV()
                lb_grupo.SelectedIndex = 0
            Else
                cb_grup.Text = ""
            End If
            cb_grup.SelectionStart = cb_grup.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_grup.Text.Length <= 1 Or cb_grup.SelectedText <> "" Then
                Me.TblGrupoBindingSource.RemoveFilter()
            Else
                Me.TblGrupoBindingSource.Filter = "NombreGrupo LIKE '%" & cb_grup.Text.Substring(0, cb_grup.Text.Length - 1) & "%'"
            End If
        End If
    End Sub
    Private Sub cb_grup_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_grup.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            If Me.cb_grup.SelectedText <> "" Then
                Me.TblGrupoBindingSource.Filter = "NombreGrupo LIKE '%" & e.KeyChar & "%'"
            Else
                Me.TblGrupoBindingSource.Filter = "NombreGrupo LIKE '%" & cb_grup.Text & e.KeyChar & "%'"
            End If

            If lb_grupo.Items.Count = 0 Then
                e.Handled = True
                Me.TblGrupoBindingSource.Filter = "NombreGrupo LIKE '%" & cb_grup.Text & "%'"
            Else
                e.Handled = False
                lb_grupo.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_grupo.Visible = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cb_grup_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_grup.GotFocus
        If cb_grup.Text = "- Selecciona -" Then
            cb_grup.Text = ""
            Me.TblGrupoBindingSource.Filter = "NombreGrupo LIKE '%" & cb_grup.Text & "%'"
            lb_grupo.Visible = True
        End If
    End Sub
    Public Sub lb_grupo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_grupo.KeyDown
        If e.KeyData = Keys.Up Then
            If lb_grupo.SelectedIndex = 1 Then
                cb_grup.Focus()
            End If
        ElseIf e.KeyData = Keys.Enter Then
            lb_grupo.Visible = False
            cb_grup.Text = lb_grupo.SelectedItem(0).ToString
            cb_grup.Tag = lb_grupo.SelectedItem(1).ToString
            FillDGV()
            lb_grupo.SelectedIndex = 0
            cb_grup.Focus()
            cb_grup.SelectionStart = cb_grup.Text.Length
        End If
    End Sub
    Private Sub lb_grupo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_grupo.MouseClick
        lb_grupo.Visible = False
        cb_grup.Text = lb_grupo.SelectedItem(0).ToString
        cb_grup.Tag = lb_grupo.SelectedItem(1).ToString
        FillDGV()
        lb_grupo.SelectedIndex = 0
        cb_grup.Focus()
        cb_grup.SelectionStart = cb_grup.Text.Length
    End Sub

    '--------------fin combo

    '------------------------------------------------------ COMBO PROVEEDOR ----------------------------'

    Private Sub cb_proveedor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_proveedor.MouseClick
        If lb_proveedor.Visible = False Then
            lb_proveedor.Visible = True
            Me.TblFabricaBindingSource.RemoveFilter()
            lb_proveedor.SelectedValue = cb_proveedor.Text
        End If
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
                cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
                cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
                FillDGV()
                lb_proveedor.SelectedIndex = 0
            Else
                cb_proveedor.Text = ""
            End If
            cb_proveedor.SelectionStart = cb_proveedor.Text.Length
        ElseIf e.KeyData = Keys.Back Then
            If cb_proveedor.Text.Length <= 1 Or cb_proveedor.SelectedText <> "" Then
                Me.TblFabricaBindingSource.RemoveFilter()
            Else
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text.Substring(0, cb_proveedor.Text.Length - 1) & "%'"
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
            cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
            cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
            FillDGV()
            lb_proveedor.SelectedIndex = 0
            cb_proveedor.Focus()
            cb_proveedor.SelectionStart = cb_proveedor.Text.Length
        End If
    End Sub
    Private Sub lb_proveedor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_proveedor.MouseClick
        lb_proveedor.Visible = False
        cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
        cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
        FillDGV()
        lb_proveedor.SelectedIndex = 0
        cb_proveedor.Focus()
        cb_proveedor.SelectionStart = cb_proveedor.Text.Length
    End Sub

    '--------------fin combo


    Private Sub Chk_Marca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Marca.CheckedChanged

        If Chk_Marca.Checked Then

            If Chk_Modelo.Checked Then

                If cb_model.Text <> "" Then
                    cb_marc.Text = cb_model.Tag
                End If

            Else

                cb_marc.Enabled = True
                cb_marc2.Enabled = True
                cb_marc.Focus()

            End If

        Else

            cb_marc.Enabled = False
            cb_marc2.Enabled = False

            cb_marc.Text = "- Selecciona -"
            cb_marc2.Text = "- Selecciona -"

            DGV_Productos.SelectAll()
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            If compras = False Then
                DGV_Compras.Rows.Clear()
            End If
            If pedidos = False Then
                DGV_Pedidos.Rows.Clear()
            End If
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            DGV_Productos.ClearSelection()

            lb_marca.Visible = False
            lb_marca2.Visible = False

        End If
    End Sub

    Private Sub Chk_Modelo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Modelo.CheckedChanged
        If Chk_Modelo.Checked Then
            cb_model.Enabled = True
            cb_model.Focus()
        Else
            cb_model.Enabled = False
            cb_model.Text = "- Selecciona -"
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            If compras = False Then
                DGV_Compras.Rows.Clear()
            End If
            If pedidos = False Then
                DGV_Pedidos.Rows.Clear()
            End If
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            DGV_Productos.ClearSelection()
            lb_modelo.Visible = False
        End If
    End Sub

    Private Sub Chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Grupo.CheckedChanged
        If Chk_Grupo.Checked Then
            cb_grup.Enabled = True
            cb_grup.Focus()
        Else
            cb_grup.Enabled = False
            cb_grup.Text = "- Selecciona -"
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            DGV_Compras.Rows.Clear()
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Pedidos.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            DGV_Productos.ClearSelection()
            lb_grupo.Visible = False
        End If
    End Sub

    Private Sub Chk_Proveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Proveedor.CheckedChanged
        If Chk_Proveedor.Checked Then
            cb_proveedor.Enabled = True
            cb_proveedor.Focus()
        Else
            cb_proveedor.Enabled = False
            cb_proveedor.Text = "- Selecciona -"
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            DGV_Compras.Rows.Clear()
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Pedidos.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            proveedorb = True
            DGV_Productos.ClearSelection()
            lb_proveedor.Visible = False
        End If
    End Sub

    Private Sub Chk_Exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Exist.CheckedChanged
        If Chk_Exist.Checked Then
            Chk_ExistEntre.Checked = False
        End If
        CrearWhere()
        DGV_Ajustes.Rows.Clear()
        DGV_Arancelarios.Rows.Clear()
        If compras = False Then
            DGV_Compras.Rows.Clear()
        End If
        If pedidos = False Then
            DGV_Pedidos.Rows.Clear()
        End If
        DGV_Direccion.Rows.Clear()
        DGV_Proveedor.Rows.Clear()
        DGV_Ventas.Rows.Clear()
        DGV_Grupos.Rows.Clear()
        DGV_Productos.ClearSelection()
        lbl_PorFacturar.Text = ""
        lbl_grafico.Visible = True
        a.Visible = False
        PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        DGV_Productos.ClearSelection()
        contarfilas()
    End Sub

    Private Sub Chk_ExistEntre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_ExistEntre.CheckedChanged
        If Chk_ExistEntre.Checked Then
            If Chk_Exist.Checked Then
                Chk_Exist.Checked = False
            End If
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox1.Focus()
        Else
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            If compras = False Then
                DGV_Compras.Rows.Clear()
            End If
            If pedidos = False Then
                DGV_Pedidos.Rows.Clear()
            End If
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            entreb = False
            DGV_Productos.ClearSelection()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub


    Private Sub DGV_Productos_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellDoubleClick
        Try

            If e.ColumnIndex = 0 Then

                'If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                '    'If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then

                '    '    MsgBox("No puede modificar este producto, pertenece a distribuidora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

                '    'ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then

                '    '    MsgBox("No puede modificar este producto, pertenece a CONAVE", MsgBoxStyle.Exclamation, "SINPRO")

                '    'Else

                '    Dim index As Integer = 0

                '    If DGV_Productos.SortedColumn IsNot Nothing Then
                '        If DGV_Productos.SortedColumn.Index <> -1 Then
                '            index = DGV_Productos.SortedColumn.Index
                '        End If
                '    End If

                '    Frm_Productos.Show()
                '    Frm_Productos.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                '    Frm_Productos.SpconsultaProductoFBindingSource.Filter = "CodigoInterno = '" & DGV_Productos.SelectedRows(0).Cells(0).Value.ToString & "'"
                '    Frm_Productos.DGV_Productos.Rows(0).Cells(0).Selected = True
                '    Frm_Productos.DGV_Productos_selection(New DataGridViewTextBoxCell, New EventArgs)
                '    Frm_Productos.ToolBar1_ButtonClick(Frm_Productos.bt_modificar, New ToolBarButtonClickEventArgs(Frm_Productos.bt_modificar))
                '    Frm_Productos.varboton = 10
                '    Frm_Productos.compras = True
                '    Frm_Productos.recibeDGV(cb_buscar.Text, tb_buscarcodigo.Text, Me, index, DGV_Productos.SortOrder, DGV_Productos.SelectedRows(0).Index)
                '    Frm_Productos.TopMost = True
                '    Frm_Productos.Button1.Visible = True
                '    Me.Enabled = False

                '    'End If


                'Else

                Dim index As Integer = 0

                If DGV_Productos.SortedColumn IsNot Nothing Then
                    If DGV_Productos.SortedColumn.Index <> -1 Then
                        index = DGV_Productos.SortedColumn.Index
                    End If
                End If

                Frm_Productos.Show()
                Frm_Productos.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                Frm_Productos.SpconsultaProductoFBindingSource.Filter = "CodigoInterno = '" & DGV_Productos.SelectedRows(0).Cells(0).Value.ToString & "'"
                Frm_Productos.DGV_Productos.Rows(0).Cells(0).Selected = True
                Frm_Productos.DGV_Productos_selection(New DataGridViewTextBoxCell, New EventArgs)
                Frm_Productos.ToolBar1_ButtonClick(Frm_Productos.bt_modificar, New ToolBarButtonClickEventArgs(Frm_Productos.bt_modificar))
                Frm_Productos.varboton = 10
                Frm_Productos.compras = True
                Frm_Productos.recibeDGV(cb_buscar.Text, tb_buscarcodigo.Text, Me, index, DGV_Productos.SortOrder, DGV_Productos.SelectedRows(0).Index)
                Frm_Productos.TopMost = True
                Frm_Productos.Button1.Visible = True
                Me.Enabled = False

                'End If

            ElseIf e.ColumnIndex = 1 Then


                If DGV_Productos.SelectedRows.Count > 0 Then

                    tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString.Trim
                    cb_buscar.SelectedIndex = 1

                End If

            End If


        Catch ex As Exception

            MsgBox("Error")


        End Try

    End Sub

    Public Sub DGV_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_Productos.CellClick, DGV_Productos.KeyUp

        Try

            If DGV_Productos.SelectedRows.Count > 0 Then

                'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then
                '    DatosCompras.consulta_pedidos_Producto_brwme(DGV_Pedidos, DGV_Productos.SelectedRows(0).Cells(0).Value)
                'Else
                DatosCompras.consulta_pedidos_Producto(DGV_Pedidos, DGV_Productos.SelectedRows(0).Cells(0).Value)
                'End If

                DatosCompras.consulta_compras_Producto(DGV_Compras, DGV_Productos.SelectedRows(0).Cells(0).Value, lbl_totalUniC.Text)

                If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                    'If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                    '    DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV_Productos.SelectedRows(0).Cells(0).Value, 2)
                    'ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                    '    DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV_Productos.SelectedRows(0).Cells(0).Value, 1)
                    'Else
                    DatosCompras.PorFacturar_brwme(lbl_PorFacturar.Text, DGV_Productos.SelectedRows(0).Cells(0).Value)
                    'End If

                Else
                    DatosCompras.PorFacturar(lbl_PorFacturar.Text, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                End If

                If TabControl1.SelectedIndex = 0 Then

                    '-------------------
                    consulta = True
                    chk_oculto.Checked = DGV_Productos.SelectedRows(0).Cells(14).Value
                    consulta = False

                    'SON COMUNES PARA TODAS LA EMPRESAS
                    DatosCompras.consulta_ajustes_Producto(DGV_Ajustes, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    DatosCompras.consulta_grupos_Producto(DGV_Grupos, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    DatosCompras.consulta_producto_Obs(DGV_Productos.SelectedRows(0).Cells(0).Value, tb_obs.Text, 0)
                    DatosCompras.consulta_CodigoArancelario_Producto(DGV_Arancelarios, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    DatosCompras.consulta_Proveedor_Producto(DGV_Proveedor, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    DatosCompras.Llenar_DGV_por_id(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Direccion, 0)

                    If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then
                        DatosCompras.consulta_devoluciones_Producto_brwme(DGV_Devoluciones, DGV_Productos.SelectedRows(0).Cells(0).Value)
                    Else
                        DatosCompras.consulta_devoluciones_Producto(DGV_Devoluciones, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    End If

                    If tb_obs.Text <> "" Then
                        DGV_Productos.DefaultCellStyle.SelectionBackColor = Color.DarkOrange
                    Else
                        DGV_Productos.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue
                    End If

                    DGV_Proveedor.Rows.Add("OEM", DGV_Productos.SelectedRows(0).Cells(5).Value, DGV_Productos.SelectedRows(0).Cells(6).Value, DGV_Productos.SelectedRows(0).Cells(7).Value)

                End If

                If TabControl1.SelectedIndex = 1 Then

                    If RadioButton1.Checked Then

                        If My.Settings.Empresa = 1 Then
                            DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                        Else
                            DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                        End If

                        If DGV_Ventas.RowCount > 0 Then

                            If My.Settings.Empresa = 1 Then
                                DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                            Else
                                DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                            End If

                            lbl_grafico.Visible = False
                            a.Visible = True

                        Else

                            a.Visible = False
                            lbl_grafico.Visible = True

                        End If

                    ElseIf RadioButton2.Checked Then

                        If My.Settings.Empresa = 1 Then
                            DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                        Else
                            DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                        End If

                        If DGV_Ventas.RowCount > 0 Then

                            If My.Settings.Empresa = 1 Then
                                DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                            Else
                                DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                            End If

                            lbl_grafico.Visible = False
                            a.Visible = True

                        Else

                            a.Visible = False
                            lbl_grafico.Visible = True

                        End If
                    End If


                End If


                If CInt(lbl_PorFacturar.Text) > 0 Then

                    lbl_PorFacturar.ForeColor = Color.Red
                    Label1.ForeColor = Color.Red

                Else

                    lbl_PorFacturar.ForeColor = Color.Black
                    Label1.ForeColor = Color.Black

                End If

                If DGV_Productos.SelectedRows(0).Cells(11).Value IsNot Nothing Then

                    If DGV_Productos.SelectedRows(0).Cells(11).Value.GetType.ToString = "System.DBNull" Then

                        TabControl1.TabPages(2).Text = ""

                    Else

                        If DGV_Productos.SelectedRows(0).Cells(11).Value = "" Then

                            TabControl1.TabPages(2).Text = ""

                        Else

                            TabControl1.TabPages(2).Text = "Foto"

                        End If

                    End If

                Else

                    If DGV_Productos.SelectedRows(0).Cells(11).Value = "" Then

                        TabControl1.TabPages(2).Text = ""

                    Else

                        TabControl1.TabPages(2).Text = "Foto"

                    End If

                End If

                DatosCompras.consulta_ultimo_Conteo_Inv(DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, lbl_fechaI.Text, lbl_cantI.Text)


                If TabControl1.TabCount > 2 Then

                    If TabControl1.SelectedIndex = 2 Then

                        Try
                            Me.PictureBox1.Image = Image.FromFile(DGV_Productos.SelectedRows(0).Cells(11).Value.ToString)
                        Catch
                            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
                        End Try

                    End If

                Else

                    If TabControl1.TabCount > 2 Then

                        TabControl1.Controls.Remove(TabControl1.TabPages(2))

                    End If

                End If

                If TabControl2.SelectedIndex = 1 Then

                    If DGV_Productos.SelectedRows.Count > 0 Then

                        DatosCompras.consulta_indicadores(DGV_Indicadores, ComboBox6.SelectedIndex + 1, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString)

                        Dim hay As Boolean = False

                        If DGV_Pedidos.RowCount > 0 Then

                            For cont As Integer = 0 To DGV_Pedidos.RowCount - 1

                                If DGV_Pedidos.Rows(cont).Cells(0).Value.ToString = "O" Or DGV_Pedidos.Rows(cont).Cells(0).Value.ToString = "N" Then

                                    hay = True

                                End If

                            Next

                            If hay Then

                                DGV_Indicadores.Rows(0).Cells(5).Value = "Sí"
                                DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Blue

                            Else

                                DGV_Indicadores.Rows(0).Cells(5).Value = "No"
                                DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Black



                            End If

                        Else

                            DGV_Indicadores.Rows(0).Cells(5).Value = "No"
                            DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Black

                        End If

                    End If

                End If

            End If

            If DGV_Productos.SelectedRows.Count > 0 Then
                indice = DGV_Productos.SelectedRows(0).Index
            End If

        Catch ex As Exception



        Finally

            DGV_Ajustes.ClearSelection()
            DGV_Arancelarios.ClearSelection()
            DGV_Compras.ClearSelection()
            DGV_Direccion.ClearSelection()
            DGV_Grupos.ClearSelection()
            DGV_Pedidos.ClearSelection()
            DGV_Proveedor.ClearSelection()
            DGV_Ventas.ClearSelection()
            DGV_Devoluciones.ClearSelection()
            lbl_F_Productos.Visible = True
            lbl_F_Pedidos.Visible = False

            If nrocompra <> 0 Then

                For cont As Integer = 0 To DGV_Compras.RowCount - 1

                    If CInt(DGV_Compras.Rows(cont).Cells(3).Value) = nrocompra Then

                        DGV_Compras.Rows(cont).Selected = True

                    End If

                Next

            ElseIf nroPedido <> 0 Then

                For cont As Integer = 0 To DGV_Pedidos.RowCount - 1

                    If CInt(DGV_Pedidos.Rows(cont).Cells(4).Value) = nroPedido And DGV_Pedidos.Rows(cont).Cells(0).Value = status Then

                        DGV_Pedidos.Rows(cont).Selected = True

                    End If

                Next

            End If

        End Try

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If DGV_Productos.SelectedRows.Count > 0 Then

            DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)
            DGV_Productos.Focus()

        End If

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
            TextBox2.Select()
        End If

    End Sub



    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress


        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números"
        End If


    End Sub



    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width - 110, c.Location.Y + 55)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub tx_buscar_Key(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                CrearWhere()
            End If
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            If compras = False Then
                DGV_Compras.Rows.Clear()
            End If
            If pedidos = False Then
                DGV_Pedidos.Rows.Clear()
            End If
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Grupos.Rows.Clear()
            lbl_PorFacturar.Text = ""
            lbl_grafico.Visible = True
            a.Visible = False
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            contarfilas()
            entreb = False
            DGV_Productos.ClearSelection()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_buscarcodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.GotFocus
        tb_buscarcodigo.SelectAll()
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then

            If DGV_Productos.RowCount > 0 Then

                DGV_Productos.ClearSelection()
                Me.DGV_Productos.Rows(0).Cells(0).Selected = True
                Me.DGV_Productos.FirstDisplayedScrollingRowIndex = 0
                Me.DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)
                Me.DGV_Productos.Focus()

            End If

        End If
    End Sub



    Public Sub tb_buscarcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        CrearWhere()
        DGV_Productos.ClearSelection()
        DGV_Ajustes.Rows.Clear()
        DGV_Arancelarios.Rows.Clear()
        If compras = False Then
            DGV_Compras.Rows.Clear()
        End If
        If pedidos = False Then
            DGV_Pedidos.Rows.Clear()
        End If
        DGV_Direccion.Rows.Clear()
        DGV_Proveedor.Rows.Clear()
        tb_obs.Clear()
        DGV_Ventas.Rows.Clear()
        DGV_Indicadores.Rows.Clear()
        DGV_Devoluciones.Rows.Clear()
        lbl_totalUniC.Text = "0"
        DGV_Grupos.Rows.Clear()
        lbl_PorFacturar.Text = ""
        lbl_grafico.Visible = True
        a.Visible = False
        PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        contarfilas()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_mesesGrafico.SelectedIndexChanged

        If cb_mesesGrafico.SelectedIndex <> -1 Then

            If DGV_Productos.SelectedRows.Count > 0 Then

                If My.Settings.Empresa = 1 Then
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                Else
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                End If

                If DGV_Ventas.RowCount > 0 Then
                    If My.Settings.Empresa = 1 Then
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    DGV_Ventas.ClearSelection()
                    a.Visible = True
                    lbl_grafico.Visible = False
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If

                DGV_Productos.Focus()
                DGV_Productos.Select()

            End If

        End If

    End Sub

    Private Sub cb_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_buscar.SelectedIndexChanged
        CrearWhere()
        tb_buscarcodigo.Focus()
        tb_buscarcodigo.Select()
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            cb_mesesGrafico.Enabled = True
            If DGV_Productos.SelectedRows.Count > 0 Then
                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                Else
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                End If
                If DGV_Ventas.RowCount > 0 Then
                    If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 2, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 0, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True

                End If

                DGV_Ventas.ClearSelection()
                cb_mesesGrafico.Focus()

            End If
        Else
            cb_mesesGrafico.Enabled = False
            a.Visible = False
            lbl_grafico.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            If DGV_Productos.SelectedRows.Count > 0 Then
                If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                Else
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                End If
                If DGV_Ventas.RowCount > 0 Then
                    If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True

                End If

                DGV_Ventas.ClearSelection()
                DateTimePicker1.Focus()

            End If
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            a.Visible = False
            lbl_grafico.Visible = True
        End If

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If Not CDate(DateTimePicker1.Value.ToShortDateString) > CDate(DateTimePicker2.Value.ToShortDateString) Or Not CDate(DateTimePicker1.Value.ToShortDateString) > Today Then
            If DGV_Productos.SelectedRows.Count > 0 Then

                If My.Settings.Empresa = 1 Then
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                Else
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                End If

                If DGV_Ventas.RowCount > 0 Then
                    If My.Settings.Empresa = 1 Then
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If
            End If
            DGV_Ventas.ClearSelection()
            entro = False
        Else
            a.Visible = False
            lbl_grafico.Visible = True
            DGV_Ventas.Rows.Clear()
        End If
    End Sub


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

        If Not CDate(DateTimePicker2.Value.ToShortDateString) < CDate(DateTimePicker1.Value.ToShortDateString) And Not CDate(DateTimePicker2.Value.ToShortDateString) > Today Then

            If DGV_Productos.SelectedRows.Count > 0 Then

                If My.Settings.Empresa = 1 Then
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                Else
                    DatosCompras.Dgv_Ventas(DGV_Ventas, DGV_Productos.SelectedRows(0).Cells(0).Value, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                End If

                If DGV_Ventas.RowCount > 0 Then
                    If My.Settings.Empresa = 1 Then
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 3, DateTimePicker1.Value, DateTimePicker2.Value)
                    Else
                        DatosCompras.VentasPorMes(DGV_Productos.SelectedRows(0).Cells(0).Value, a.Chart1, CInt(cb_mesesGrafico.Text), 1, DateTimePicker1.Value, DateTimePicker2.Value)
                    End If
                    lbl_grafico.Visible = False
                    a.Visible = True
                Else
                    a.Visible = False
                    lbl_grafico.Visible = True
                End If
                DGV_Ventas.ClearSelection()
            End If
        Else
            a.Visible = False
            lbl_grafico.Visible = True
            DGV_Ventas.Rows.Clear()
        End If
    End Sub

    Private Sub DGV_Compras_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Compras.CellClick, DGV_Compras.KeyUp
        lbl_F_Pedidos.Visible = False
        lbl_F_Productos.Visible = False
    End Sub

    Private Sub DGV_Compras_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Compras.CellDoubleClick
        If e.ColumnIndex = 3 Then
            Dim frm As New Frm_Comprascargadas
            frm.Show()
            frm.DomainUpDown1.SelectedIndex = 0
            frm.tb_buscarcodigo.Text = DGV_Compras.SelectedRows(0).Cells(3).Value
            frm.tb_buscarcodigo.ReadOnly = True
            If frm.DGV_Pedidos.RowCount > 0 Then
                frm.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                frm.DGV_Pedidos.Focus()
                frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)
                frm.DGV_Pedidos.Enabled = False
            End If

        ElseIf e.ColumnIndex = 1 Then

            Dim frm As New Frm_Comprascargadas
            frm.Show()
            frm.DomainUpDown1.SelectedIndex = 1
            frm.tb_buscarcodigo.Text = DGV_Compras.SelectedRows(0).Cells(1).Value
            frm.tb_buscarcodigo.ReadOnly = True
            If frm.DGV_Pedidos.RowCount > 0 Then
                frm.DGV_Pedidos.Rows(0).Cells(0).Selected = True
                frm.DGV_Pedidos.Focus()
                frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)
                frm.DGV_Pedidos.Enabled = False
            End If

        End If
    End Sub

    Private Sub DGV_Compras_RowsAdded(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Compras.RowsAdded, DGV_Compras.RowsRemoved
        Label12.Text = DGV_Compras.RowCount
    End Sub

    Private Sub DGV_Pedidos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Pedidos.CellClick, DGV_Pedidos.KeyUp
        lbl_F_Productos.Visible = False
        lbl_F_Pedidos.Visible = True
    End Sub

    Private Sub DGV_Pedidos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellDoubleClick

        'If My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then

        If e.ColumnIndex = 4 Then
            Dim frm As New Frm_Pedidos_Proveedores
            frm.Show()
            frm.DomainUpDown1.SelectedIndex = 0
            frm.tb_buscarcodigo.Text = DGV_Pedidos.SelectedRows(0).Cells(4).Value
            frm.tb_buscarcodigo.ReadOnly = True
            frm.DGV_Pedidos.Rows(0).Cells(0).Selected = True
            frm.DGV_Pedidos.Focus()
            frm.DGV_Pedidos_CellClick(frm.DGV_Pedidos, New EventArgs)

        ElseIf e.ColumnIndex = 6 Then

            If DGV_Productos.SelectedRows.Count > 0 And DGV_Pedidos.SelectedRows.Count > 0 Then

                Dim frm As New Frm_ModificarPrecio
                frm.tipo = 1
                frm.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                frm.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
                frm.Precio = DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString
                frm.pedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString)
                If DGV_Pedidos.SelectedRows(0).Cells(8).Value = "No" Then
                    frm.bo = False
                Else
                    frm.bo = True
                End If

                frm.recibe(Me)
                frm.Show()
                Me.Enabled = False

            End If

        ElseIf e.ColumnIndex = 7 Then

            If DGV_Pedidos.RowCount > 0 Then

                If DGV_Pedidos.SelectedRows.Count > 0 Then

                    Dim frm3 As New Frm_ModificarPedido
                    frm3.BO = DGV_Pedidos.SelectedRows(0).Cells(8).Value.ToString
                    frm3.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                    frm3.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString + " " + DGV_Productos.SelectedRows(0).Cells(2).Value.ToString
                    frm3.fob = CDbl(DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString)
                    frm3.cant = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
                    frm3.tb_cantidad.Text = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
                    frm3.codigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                    frm3.frm = Me
                    frm3.Show()
                    Me.Enabled = False

                Else

                    MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            Else

                MsgBox("El produco no tiene pedidos asociados", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        ElseIf e.ColumnIndex = 0 Then

            Dim frm As New Frm_CambioStatus
            frm.Show()
            frm.TopMost = True
            frm.lbl_codProducto.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
            frm.lbl_pedido.Text = DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString
            frm.lbl_descripcion.Text = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
            frm.frm = Me

            If DGV_Pedidos.SelectedRows(0).Cells(8).Value.ToString = "Sí" Then
                frm.BO = True
            End If

            frm.cb_de.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString

            Me.Enabled = False

        End If

        'Else

        '    MsgBox("No puede modificar el pedido, pertenece a comercializadora", MsgBoxStyle.Information, "SINPRO")

        'End If

    End Sub

    Private Sub DGV_Pedidos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Pedidos.KeyDown

        If My.Settings.Empresa <> 4 Or My.Settings.Empresa <> 6 Then

            If e.KeyCode = Keys.F6 Then

                If DGV_Pedidos.RowCount > 0 Then

                    If DGV_Pedidos.SelectedRows.Count > 0 Then

                        Dim frm2 As New Frm_CalculoCostos
                        frm2.pedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                        frm2.lbl_Pedido.Text = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                        frm2.lbl_Proveedor.Text = DGV_Pedidos.SelectedRows(0).Cells(1).Value.ToString
                        frm2.TopMost = True
                        frm2.Show()

                        Dim valor As Integer = 0

                        For cont As Integer = 0 To frm2.Dgv_Costos.RowCount - 1

                            If frm2.Dgv_Costos.Rows(cont).Cells(2).Value.ToString.ToUpper = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString.ToUpper Then

                                valor = cont

                            End If

                        Next

                        frm2.Dgv_Costos.Rows(valor).Cells(6).Selected = True
                        frm2.Dgv_Costos_CellClick(frm2.Dgv_Costos, New EventArgs)
                        frm2.Dgv_Costos.FirstDisplayedScrollingRowIndex() = valor

                    Else

                        MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                Else

                    MsgBox("El producto no tiene pedidos asociados", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            ElseIf e.KeyCode = Keys.F5 Then

                If DGV_Pedidos.RowCount > 0 Then

                    If DGV_Pedidos.SelectedRows.Count > 0 Then

                        Dim frm3 As New Frm_ModificarPedido
                        frm3.BO = DGV_Pedidos.SelectedRows(0).Cells(8).Value.ToString
                        frm3.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                        frm3.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString + " " + DGV_Productos.SelectedRows(0).Cells(2).Value.ToString
                        frm3.fob = CDbl(DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString)
                        frm3.cant = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
                        frm3.tb_cantidad.Text = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
                        frm3.codigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                        frm3.frm = Me
                        frm3.Show()
                        Me.Enabled = False

                    Else

                        MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                Else

                    MsgBox("El produco no tiene pedidos asociados", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            ElseIf e.KeyCode = Keys.F8 Then

                If DGV_Productos.SelectedRows.Count > 0 And DGV_Pedidos.SelectedRows.Count > 0 Then

                    Dim frm As New Frm_ModificarPrecio
                    frm.tipo = 1
                    frm.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                    frm.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
                    frm.Precio = DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString.Replace(".", "")
                    frm.pedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString)
                    If DGV_Pedidos.SelectedRows(0).Cells(8).Value = "No" Then
                        frm.bo = False
                    Else
                        frm.bo = True
                    End If

                    frm.recibe(Me)
                    frm.Show()
                    Me.Enabled = False

                Else
                    MsgBox("No existe ningún producto o pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
                End If

            ElseIf e.KeyCode = Keys.F3 Then

                If DGV_Productos.SelectedRows.Count > 0 And DGV_Pedidos.SelectedRows.Count > 0 Then

                    If Me.e = True Then
                        If ya = False Then
                            frm.producto_pedido(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, DGV_Productos.SelectedRows(0).Cells(2).Value, DGV_Proveedor, True)
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
                            frm.CodigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                            Label3.Visible = False
                            frm.moneda = "$"
                            frm.frm = Me
                            frm.TopMost = True
                            ya = True
                            Me.Enabled = False
                            frm.Show()
                        Else
                            frm.producto_pedido(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, DGV_Productos.SelectedRows(0).Cells(2).Value, DGV_Proveedor, False)
                            frm.Text = "Mover pedido"
                            frm.tipo = 1
                            frm.Panel1.Visible = True
                            frm.Button1.Visible = True
                            frm.cb_filtroStatus.ResetText()
                            frm.rb_todos.Checked = True
                            frm.Button2.Visible = True
                            frm.CodigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
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
                            frm.frm = Me
                            Label3.Visible = False
                            Me.Enabled = False
                            If Not frm Is Nothing Then
                                frm.Visible = True
                            End If
                        End If
                    End If

                Else
                    MsgBox("No existe ningún producto o pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
                End If

            ElseIf e.KeyCode = Keys.F10 Then

                If DGV_Pedidos.SelectedRows.Count > 0 And DGV_Productos.SelectedRows.Count > 0 Then

                    Dim frm As New Frm_CambioStatus
                    frm.Show()
                    frm.TopMost = True
                    frm.lbl_codProducto.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                    frm.lbl_pedido.Text = DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString
                    frm.lbl_descripcion.Text = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
                    frm.frm = Me

                    If DGV_Pedidos.SelectedRows(0).Cells(8).Value.ToString = "Sí" Then
                        frm.BO = True
                    End If

                    frm.cb_de.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString

                    Me.Enabled = False

                Else
                    MsgBox("No existe ningún producto o pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

        End If

    End Sub

    Private Sub DGV_Pedidos_RowsAdded(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Pedidos.RowsAdded, DGV_Pedidos.RowsRemoved
        Label14.Text = DGV_Pedidos.RowCount
    End Sub

    Public Sub contarfilas()
        'Label11.Text = DGV_Productos.RowCount
        If compras Or pedidos Then
            Dim Uni As Object
            Uni = Me.MELDataSet.sp_infoGeneralCompras.Compute("Sum(Cant)", Sp_infoGeneralComprasBindingSource.Filter)

            If Uni.ToString = "" Then
                Uni = "0"
            End If

            Me.lbl_totalUniPro.Text = Format(CInt(Uni.ToString), "N0")
            Me.Label11.Text = Format(CInt(Sp_infoGeneralComprasBindingSource.Count.ToString), "N0")
        Else
            Dim Uni As Object
            Uni = Me.MELDataSet.sp_infoGeneral.Compute("Sum(Cant)", SpinfoGeneralBindingSource.Filter)

            If Uni.ToString = "" Then
                Uni = "0"
            End If

            Me.lbl_totalUniPro.Text = Format(CInt(Uni.ToString), "N0")
            Me.Label11.Text = Format(CInt(SpinfoGeneralBindingSource.Count.ToString), "N0")
        End If
    End Sub

    Private Sub DGV_Productos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_Productos.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_Productos.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_Productos.ClearSelection()

                    DGV_Productos.Rows(hti.RowIndex).Selected = True
                    DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)

                End If

            End If

        End If
    End Sub


    Private Sub DGV_Pedidos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_Pedidos.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_Pedidos.Rows(hti.RowIndex).Selected Then

                    DGV_Pedidos.ClearSelection()

                    DGV_Pedidos.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If
    End Sub

    Private Sub ModiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModiToolStripMenuItem.Click

        Try

            'If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

            '    'If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then

            '    '    MsgBox("No puede modificar este producto, pertenece a distribuidora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

            '    'ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then

            '    '    MsgBox("No puede modificar este producto, pertenece a CONAVE", MsgBoxStyle.Exclamation, "SINPRO")

            '    'Else

            '    Dim index As Integer = 0

            '    If DGV_Productos.SortedColumn IsNot Nothing Then
            '        If DGV_Productos.SortedColumn.Index <> -1 Then
            '            index = DGV_Productos.SortedColumn.Index
            '        End If
            '    End If

            '    Frm_Productos.Show()
            '    Frm_Productos.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
            '    Frm_Productos.SpconsultaProductoFBindingSource.Filter = "CodigoInterno = '" & DGV_Productos.SelectedRows(0).Cells(0).Value.ToString & "'"
            '    Frm_Productos.DGV_Productos.Rows(0).Cells(0).Selected = True
            '    Frm_Productos.DGV_Productos_selection(New DataGridViewTextBoxCell, New EventArgs)
            '    Frm_Productos.ToolBar1_ButtonClick(Frm_Productos.bt_modificar, New ToolBarButtonClickEventArgs(Frm_Productos.bt_modificar))
            '    Frm_Productos.varboton = 10
            '    Frm_Productos.compras = True
            '    Frm_Productos.recibeDGV(cb_buscar.Text, tb_buscarcodigo.Text, Me, index, DGV_Productos.SortOrder, DGV_Productos.SelectedRows(0).Index)
            '    Frm_Productos.TopMost = True
            '    Frm_Productos.Button1.Visible = True
            '    Me.Enabled = False

            '    'End If


            'Else

            Dim index As Integer = 0

            If DGV_Productos.SortedColumn IsNot Nothing Then
                If DGV_Productos.SortedColumn.Index <> -1 Then
                    index = DGV_Productos.SortedColumn.Index
                End If
            End If

            Frm_Productos.Show()
            Frm_Productos.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
            Frm_Productos.SpconsultaProductoFBindingSource.Filter = "CodigoInterno = '" & DGV_Productos.SelectedRows(0).Cells(0).Value.ToString & "'"
            Frm_Productos.DGV_Productos.Rows(0).Cells(0).Selected = True
            Frm_Productos.DGV_Productos_selection(New DataGridViewTextBoxCell, New EventArgs)
            Frm_Productos.ToolBar1_ButtonClick(Frm_Productos.bt_modificar, New ToolBarButtonClickEventArgs(Frm_Productos.bt_modificar))
            Frm_Productos.varboton = 10
            Frm_Productos.compras = True
            Frm_Productos.recibeDGV(cb_buscar.Text, tb_buscarcodigo.Text, Me, index, DGV_Productos.SortOrder, DGV_Productos.SelectedRows(0).Index)
            Frm_Productos.TopMost = True
            Frm_Productos.Button1.Visible = True
            Me.Enabled = False

            'End If

        Catch ex As Exception
            MsgBox("Error")

        End Try

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        deactivate = True
        compras = False
        nrocompra = 0
        pedidos = False
        nroPedido = 0
        status = ""
        chk_compra.Checked = False
        tb_compra.Enabled = False
        DGV_Compras.Rows.Clear()
        DGV_Pedidos.Rows.Clear()
        DGV_Devoluciones.Rows.Clear()
        DGV_Grupos.Rows.Clear()
        DGV_Direccion.Rows.Clear()
        DGV_Ventas.Rows.Clear()
        DGV_Ajustes.Rows.Clear()
        DGV_Arancelarios.Rows.Clear()
        chk_compra.Enabled = True
        chk_compra.Checked = False
        tb_compra.Enabled = False
        DGV_Proveedor.Rows.Clear()
        lbl_PorFacturar.Text = ""
        Chk_Exist.Checked = False
        Chk_ExistEntre.Checked = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        Chk_Grupo.Checked = False
        Chk_Grupo.Enabled = True
        Chk_Marca.Checked = False
        cb_marc.Text = "- Selecciona -"
        cb_marc.Enabled = False
        Chk_Modelo.Checked = False
        cb_model.Text = "- Selecciona -"
        cb_proveedor.Text = "- Selecciona -"
        cb_grup.Text = "- Selecciona -"
        cb_model.Enabled = False
        Chk_Proveedor.Enabled = True
        Chk_Proveedor.Checked = False
        cb_proveedor.Enabled = False

        DGV_Productos.DataSource = SpinfoGeneralBindingSource
        CrearWhere()
        contarfilas()
        tb_buscarcodigo.Clear()
        deactivate = False
    End Sub
    Private Sub DGV_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Productos.KeyDown
        If e.KeyCode = Keys.F3 Then
            If My.Settings.Empresa <> 4 Or My.Settings.Empresa <> 6 Then
                If Me.e = True Then
                    ventana()
                End If
            End If
        ElseIf e.KeyCode = Keys.ControlKey Then
            DGV_Productos.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then

            If My.Settings.Empresa <> 4 Or My.Settings.Empresa <> 6 Then

                If Me.e = True Then

                    If DGV_Pedidos.RowCount > 0 Then

                        If DGV_Pedidos.SelectedRows.Count > 0 Then

                            Dim frm2 As New Frm_CalculoCostos
                            frm2.pedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                            frm2.lbl_Pedido.Text = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
                            frm2.lbl_Proveedor.Text = DGV_Pedidos.SelectedRows(0).Cells(1).Value.ToString
                            frm2.Show()

                            Dim valor As Integer = 0

                            For cont As Integer = 0 To frm2.Dgv_Costos.RowCount - 1

                                If frm2.Dgv_Costos.Rows(cont).Cells(2).Value.ToString.ToUpper = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString.ToUpper Then

                                    valor = cont

                                End If

                            Next

                            frm2.Dgv_Costos.Rows(valor).Cells(6).Selected = True
                            frm2.Dgv_Costos_CellClick(frm2.Dgv_Costos, New EventArgs)
                            frm2.Dgv_Costos.FirstDisplayedScrollingRowIndex() = valor

                        Else

                            MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

                        End If

                    Else

                        MsgBox("El produco no tiene pedidos asociados", MsgBoxStyle.Exclamation, "SINPRO")

                    End If

                End If

            End If

        ElseIf e.KeyCode = Keys.F8 Then

            If DGV_Productos.SelectedRows.Count > 0 Then

                Dim frm As New Frm_Productos_Por_Facturar
                Dim f As Boolean = False
                Dim r As Boolean = False

                If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                    f = True
                ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                    r = True
                End If

                frm.recibe(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, f, r)
                frm.Show()
            Else
                MsgBox("No existe ningún producto seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
            End If


        ElseIf e.KeyCode = Keys.F5 Then

            If Me.e Then

                If DGV_Productos.SelectedRows.Count > 0 Then

                    Dim frm As New Frm_ModificarPrecio
                    Dim Fiat As Boolean = False
                    Dim Renault As Boolean = False
                    frm.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
                    frm.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
                    frm.Precio = DGV_Productos.SelectedRows(0).Cells(4).Value.ToString.Replace(".", "")

                    If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                        Fiat = True
                    ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                        Renault = True
                    End If

                    frm.Fiat = Fiat
                    frm.Renault = Renault
                    frm.recibe(Me)
                    frm.tipo = 0
                    frm.Show()

                Else
                    MsgBox("No existe ningún producto seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
                End If

            End If

        End If
    End Sub

    Private Sub AgregarAPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAPedidoToolStripMenuItem.Click
        ventana()
    End Sub

    Public Sub ventana()
        If ya = False Then
            frm.producto_pedido(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, DGV_Productos.SelectedRows(0).Cells(2).Value, DGV_Proveedor, True)
            frm.moneda = "$"

            frm.Text = "Agregar a pedido"
            frm.Panel1.Visible = False
            frm.Button1.Visible = False
            frm.Button2.Visible = False
            frm.bt_agregarCuarto.Visible = True
            frm.bt_eliminarCuarto.Visible = True
            frm.tb_cantidad.Visible = True
            frm.lb_producto.Visible = True
            frm.lb_codigo.Visible = True

            frm.tb_nuevo.Clear()
            frm.tb_nuevo.Visible = False
            frm.lb_cod.Visible = False
            frm.tb_codfab.Visible = False
            frm.tb_proveedor.Enabled = True

            Label3.Visible = True
            frm.tipo = 0

            frm.frm = Me
            frm.TopMost = True
            ya = True
            Me.Enabled = False
            frm.Show()
        Else
            frm.producto_pedido(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, DGV_Productos.SelectedRows(0).Cells(2).Value, DGV_Proveedor, False)
            Me.Enabled = False
            frm.tipo = 0
            frm.Text = "Agregar a pedido"
            frm.Panel1.Visible = False
            frm.Button1.Visible = False
            frm.Button2.Visible = False
            frm.bt_agregarCuarto.Visible = True
            frm.bt_eliminarCuarto.Visible = True
            frm.tb_cantidad.Visible = True
            frm.lb_producto.Visible = True

            frm.tb_nuevo.Clear()
            frm.tb_proveedor.Enabled = True
            frm.tb_nuevo.Visible = False
            frm.lb_cod.Visible = False
            frm.tb_codfab.Visible = False
            frm.frm = Me
            frm.lb_codigo.Visible = True
            Label3.Visible = True
            frm.Visible = True
        End If
    End Sub

    Private Sub DGV_Ventas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Ventas.CellDoubleClick
        Try

            If e.ColumnIndex = 0 Then

                If DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "D" And My.Settings.Empresa <> 4 Then

                    MsgBox("Esta factura pertenece a Distribuidora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "CO" And My.Settings.Empresa <> 6 Then

                    MsgBox("Esta factura pertenece a CONAVE", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "V" And My.Settings.Empresa <> 7 Then

                    MsgBox("Esta factura pertenece a VENPER", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "C" And My.Settings.Empresa <> 1 Then

                    MsgBox("Esta factura pertenece a Comercializadora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

                Else

                    Frm_Facturas_Ventas.Show()

                    Dim Cont As Integer = 0
                    Dim valor As Integer = 0

                    Frm_Facturas_Ventas.tb_buscarcodigo.Text = DGV_Ventas.SelectedRows(0).Cells(0).Value.ToString
                    Frm_Facturas_Ventas.SpConsultaClienteFacturaBindingSource.Filter = "ControlInicio = '" & DGV_Ventas.SelectedRows(0).Cells(0).Value.ToString & "'"
                    Frm_Facturas_Ventas.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                    Frm_Facturas_Ventas.DGV_TodasLasFacturas_CellClick()
                    Frm_Facturas_Ventas.tb_buscarcodigo.Enabled = False

                End If

            ElseIf e.ColumnIndex = 5 Then

                If DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "D" And My.Settings.Empresa <> 4 Then

                    MsgBox("Esta factura pertenece a Distribuidora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "CO" And My.Settings.Empresa <> 6 Then

                    MsgBox("Esta factura pertenece a CONAVE", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "V" And My.Settings.Empresa <> 7 Then

                    MsgBox("Esta factura pertenece a VENPER", MsgBoxStyle.Exclamation, "SINPRO")

                ElseIf DGV_Ventas.SelectedRows(0).Cells(6).Value.ToString = "C" And My.Settings.Empresa <> 1 Then

                    MsgBox("Esta factura pertenece a Comercializadora BRWME", MsgBoxStyle.Exclamation, "SINPRO")

                Else

                    Dim FRM As New Frm_NotaCredito
                    FRM.Show()
                    FRM.dud_buscar.SelectedIndex = 1
                    FRM.tb_buscarcodigo.Text = DGV_Ventas.SelectedRows(0).Cells(0).Value
                    FRM.BringToFront()
                    FRM.tb_buscarcodigo.Enabled = False
                    If FRM.Dgv_NotasC.RowCount > 0 Then
                        FRM.Dgv_NotasC.Rows(0).Cells(1).Selected = True
                        FRM.Dgv_NotasC_CellClick(FRM.Dgv_NotasC, New EventArgs)
                    End If
                    FRM.TopMost = True

                End If

            End If

        Catch ex As Exception

            MsgBox("Error")


        End Try
    End Sub

    Public Sub totalVendidos() Handles DGV_Ventas.RowsAdded, DGV_Ventas.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Ventas.RowCount - 1

            acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(3).Value)

        Next

        Label17.Text = acum

    End Sub

    Public Sub totalDevueltos2() Handles DGV_Devoluciones.RowsAdded, DGV_Devoluciones.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Devoluciones.RowCount - 1

            acum = acum + CInt(DGV_Devoluciones.Rows(cont).Cells(0).Value)

        Next

        Label43.Text = acum

    End Sub

    Public Sub totalAjustados() Handles DGV_Ajustes.RowsAdded, DGV_Ajustes.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Ajustes.RowCount - 1

            acum = acum + CInt(DGV_Ajustes.Rows(cont).Cells(1).Value)

        Next

        Label45.Text = acum

    End Sub

    Public Sub totalEnUbicaciones() Handles DGV_Direccion.RowsAdded, DGV_Direccion.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Direccion.RowCount - 1

            acum = acum + CInt(DGV_Direccion.Rows(cont).Cells(4).Value)

        Next

        Label59.Text = acum

    End Sub

    Public Sub totalGrupos() Handles DGV_Grupos.RowsAdded, DGV_Grupos.RowsRemoved

        Label61.Text = DGV_Grupos.RowCount

    End Sub


    Public Sub totalDevueltos() Handles DGV_Ventas.RowsAdded, DGV_Ventas.RowsRemoved

        Dim acum As Integer = 0

        For cont As Integer = 0 To DGV_Ventas.RowCount - 1

            If DGV_Ventas.Rows(cont).Cells(5).Value = "" Then

                acum = acum + 0

            Else

                acum = acum + CInt(DGV_Ventas.Rows(cont).Cells(5).Value)

            End If

        Next

        Label7.Text = acum

    End Sub

    Private Sub multiples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.DoubleClick
        tb_buscarcodigo.SelectAll()
    End Sub
    Public Sub ActualizarPedidos()
        If primera = True Then
            If DGV_Productos.SelectedRows.Count > 0 Then
                DatosCompras.consulta_pedidos_Producto(DGV_Pedidos, DGV_Productos.SelectedRows(0).Cells(0).Value)
                If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then
                    If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Or DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                        DatosCompras.consulta_Proveedor_Producto(DGV_Proveedor, DGV_Productos.SelectedRows(0).Cells(0).Value, 1)
                    Else
                        DatosCompras.consulta_Proveedor_Producto(DGV_Proveedor, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                    End If
                Else
                    DatosCompras.consulta_Proveedor_Producto(DGV_Proveedor, DGV_Productos.SelectedRows(0).Cells(0).Value, 0)
                End If
            End If

        End If

        DGV_Ajustes.ClearSelection()
        DGV_Arancelarios.ClearSelection()
        DGV_Compras.ClearSelection()
        DGV_Direccion.ClearSelection()
        DGV_Grupos.ClearSelection()
        DGV_Pedidos.ClearSelection()
        DGV_Proveedor.ClearSelection()
        DGV_Ventas.ClearSelection()
        DGV_Devoluciones.ClearSelection()

        primera = True
    End Sub

    'Private Sub DGV_Productos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Productos.GotFocus

    '    If act = False Then
    '        If otra = True Then
    '            If produc = False Then
    '                ActualizarPedidos()
    '                If Me.DGV_Productos.SelectedRows.Count > 0 Then
    '                    Dim num As Integer = DGV_Productos.SelectedRows(0).Index
    '                    tb_buscarcodigo_TextChanged(tb_buscarcodigo, New System.EventArgs)
    '                    DGV_Productos.Rows(num).Selected = True
    '                    DGV_Productos_CellContentClick(DGV_Productos, New DataGridViewCellEventArgs(0, Me.DGV_Productos.SelectedRows(0).Index))
    '                    CrearWhere()
    '                    If Chk_ExistEntre.Checked Then
    '                        DGV_Productos.Sort(DGV_Productos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    '                    End If
    '                    otra = False
    '                End If
    '            End If
    '            If produc Then
    '                DGV_Productos.Sort(DGV_Productos.Columns(ind), order)
    '                produc = False
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged

        If DGV_Productos.SelectedRows.Count > 0 Then

            DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)

        End If

        DGV_Productos.Focus()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged

        If DGV_Productos.SelectedRows.Count > 0 Then

            If DGV_Indicadores.RowCount > 0 Then

                DatosCompras.consulta_indicadores(DGV_Indicadores, ComboBox6.SelectedIndex + 1, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString)

                Dim hay As Boolean = False

                If DGV_Pedidos.RowCount > 0 Then

                    For cont As Integer = 0 To DGV_Pedidos.RowCount - 1

                        If DGV_Pedidos.Rows(cont).Cells(0).Value.ToString = "O" Or DGV_Pedidos.Rows(cont).Cells(0).Value.ToString = "N" Then

                            hay = True

                        End If

                    Next

                    If hay Then

                        DGV_Indicadores.Rows(0).Cells(5).Value = "Sí"
                        DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Blue

                    Else

                        DGV_Indicadores.Rows(0).Cells(5).Value = "No"
                        DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Black

                    End If

                Else

                    DGV_Indicadores.Rows(0).Cells(5).Value = "No"
                    DGV_Indicadores.Columns(5).DefaultCellStyle.ForeColor = Color.Black

                End If

            End If

        End If
    End Sub

    Private Sub DGV_Indicadores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Indicadores.CellClick
        DGV_Indicadores.ClearSelection()
    End Sub

    Private Sub chk_oculto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_oculto.CheckedChanged
        If DGV_Productos.SelectedRows.Count > 0 Then
            If consulta = False Then
                Dim resp As Integer = MsgBox("Está seguro de ocultar/mostrar este producto?", MsgBoxStyle.YesNo, "Confirmación")
                If resp = vbYes Then


                    If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then
                        Dim f As Boolean = False
                        Dim r As Boolean = False

                        If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                            f = True
                        End If

                        If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                            r = True
                        End If

                        If r Then
                            DatosCompras.modifica_producto_oculto(chk_oculto.Checked, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 1)
                        ElseIf f Then
                            DatosCompras.modifica_producto_oculto(chk_oculto.Checked, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 2)
                        Else
                            DatosCompras.modifica_producto_oculto(chk_oculto.Checked, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 0)
                        End If
                    Else
                        DatosCompras.modifica_producto_oculto(chk_oculto.Checked, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 0)
                    End If

                    DGV_Productos.SelectedRows(0).Cells(14).Value = chk_oculto.Checked

                End If
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If DGV_Pedidos.SelectedRows.Count > 0 And DGV_Productos.SelectedRows.Count > 0 Then

            Dim frm3 As New Frm_ModificarPedido
            frm3.codigoProducto = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
            frm3.DescProducto = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString + " " + DGV_Productos.SelectedRows(0).Cells(2).Value.ToString
            frm3.fob = CDbl(DGV_Pedidos.SelectedRows(0).Cells(6).Value.ToString)
            frm3.cant = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
            frm3.tb_cantidad.Text = CInt(DGV_Pedidos.SelectedRows(0).Cells(7).Value)
            frm3.codigoPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
            frm3.Button2.Visible = False
            frm3.frm = Me
            frm3.Show()

        Else

            MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

        End If
    End Sub



    Public Sub Pro(ByVal otra2 As Boolean)
        otra = otra2
    End Sub

    Private Sub ToolStripMenuItem1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Try

            If DGV_Pedidos.SelectedRows.Count > 0 And DGV_Productos.SelectedRows.Count > 0 Then

                Dim frm3 As Integer = MsgBox("¿Confirma que desea eliminar el artículo del pedido?", MsgBoxStyle.YesNo, "SINPRO")
                If frm3 = vbYes Then

                    If DGV_Pedidos.SelectedRows(0).Cells(8).Value = "Sí" Then

                        DatosCompras.elimina_pedido_producto_C(CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value), DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 1)

                    Else

                        DatosCompras.elimina_pedido_producto_C(CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value), DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 0)

                    End If

                End If

            Else

                MsgBox("No existe ningún pedido seleccionado", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Catch ex As Exception

            MsgBox("Error eliminando artículo del pedido", MsgBoxStyle.Critical, "Error")

        Finally

            DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)

        End Try

    End Sub

    Private Sub DGV_Productos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_Productos.ColumnHeaderMouseClick
        ind = DGV_Productos.SortedColumn.Index
        If DGV_Productos.SortOrder = SortOrder.Ascending Then
            order = System.ComponentModel.ListSortDirection.Ascending
        ElseIf DGV_Productos.SortOrder = SortOrder.Descending Then
            order = System.ComponentModel.ListSortDirection.Descending
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If DGV_Compras.SelectedRows.Count > 0 Then
            compras = True
            pedidos = False
            nrocompra = CInt(DGV_Compras.SelectedRows(0).Cells(3).Value)
            tb_buscarcodigo.Clear()
            Chk_Grupo.Checked = False
            Chk_Grupo.Enabled = False
            Chk_Proveedor.Checked = False
            Chk_Proveedor.Enabled = False
            Chk_Marca.Checked = False
            Chk_ExistEntre.Checked = False
            Chk_Modelo.Checked = False
            Chk_Exist.Checked = False

            chk_compra.Enabled = False
            chk_compra.Checked = True
            tb_compra.Enabled = False
            tb_compra.Text = nrocompra

            If My.Settings.Empresa = 1 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 2, "")
            ElseIf My.Settings.Empresa = 4 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 1, "")
            ElseIf My.Settings.Empresa = 6 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 1, "")
            ElseIf My.Settings.Empresa = 7 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 1, "")
            Else
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 0, "")
            End If

            DGV_Productos.DataSource = Sp_infoGeneralComprasBindingSource
            contarfilas()
            tb_buscarcodigo.Focus()
        Else
            MsgBox("Debe seleccionar una compra para filtrar", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If DGV_Pedidos.SelectedRows.Count > 0 Then
            pedidos = True
            compras = False
            nroPedido = CInt(DGV_Pedidos.SelectedRows(0).Cells(4).Value)
            status = DGV_Pedidos.SelectedRows(0).Cells(0).Value
            tb_buscarcodigo.Clear()
            Chk_Grupo.Checked = False
            Chk_Grupo.Enabled = False
            Chk_Proveedor.Checked = False
            Chk_Proveedor.Enabled = False
            Chk_Marca.Checked = False
            Chk_ExistEntre.Checked = False
            Chk_Modelo.Checked = False
            Chk_Exist.Checked = False

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then

                If pedidos = True Then
                    Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, -1, 2, status)
                ElseIf compras = True Then
                    Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, -1, 2, "")
                End If

            Else

                If pedidos = True Then
                    Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, -1, 0, status)
                ElseIf compras = True Then
                    Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, -1, 0, "")
                End If

            End If

            DGV_Productos.DataSource = Sp_infoGeneralComprasBindingSource
            contarfilas()
            If DGV_Productos.RowCount > 0 Then
                DGV_Productos.Rows(0).Cells(0).Selected = True
                DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)
            End If
            tb_buscarcodigo.Focus()
        Else
            MsgBox("Debe seleccionar un pedido para filtrar", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

    Public Sub CrearWhere()

        Try

            Dim where As String = ""
            Dim y As String = ""
            Dim exacto As String = ""

            If chk_exacto.Checked = False Then
                exacto = "%"
            End If

            If tb_buscarcodigo.Text <> "" Then

                If cb_buscar.SelectedIndex = 0 Then

                    where = where + "CodigoInterno LIKE '" & exacto & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf cb_buscar.SelectedIndex = 2 Then

                    where = where + "CodigoFabrica LIKE '" & exacto & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf cb_buscar.SelectedIndex = 1 Then

                    where = where + "Descripcion LIKE '" & exacto & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                ElseIf cb_buscar.SelectedIndex = 3 Then

                    where = where + "OEM LIKE '" & exacto & tb_buscarcodigo.Text & "%'" + y
                    y = " and "

                End If

            End If

            If Chk_Exist.Checked Then

                where = where + y + "Cant > 0 "
                y = " and "
            End If

            If Chk_ExistEntre.Checked And TextBox1.Text <> "" And TextBox2.Text <> "" Then
                where = where + y + "Cant >= " & TextBox1.Text & " and Cant <= " & TextBox2.Text
                y = " and "
            End If

            If Chk_Marca.Checked And cb_marc.Text <> "" Then

                If cb_marc2.Text <> "" Then

                    where = where + y + "(Marca LIKE '%" & cb_marc.Text & "%' OR Marca LIKE '%" & cb_marc2.Text & "%')"
                    y = " and "

                Else

                    where = where + y + "Marca LIKE '%" & cb_marc.Text & "%'"
                    y = " and "

                End If

            End If



            If chk_fr.Checked And chk_fr.Visible Then
                where = where + y + "Marca NOT LIKE '%Fiat%' AND Marca NOT LIKE '%Renault%'"
                y = " and "
            End If

            If Chk_Modelo.Checked And cb_model.Text <> "" Then
                where = where + y + "(substring(Modelo,1," & cb_model.Text.Length + 1 & ") = '" & cb_model.Text & " ' or Modelo LIKE '%/ " & cb_model.Text & "%')"
                y = " and "
            End If

            If Chk_Grupo.Checked And cb_grup.Text <> "" Then
                where = where + y + "Grupo LIKE '%" & cb_grup.Tag & cb_grup.Text & "%'"
                y = " and "
            End If

            If Chk_Proveedor.Checked And cb_proveedor.Text <> "" Then
                where = where + y + "Proveedor LIKE '%" & cb_proveedor.Tag & cb_proveedor.Text & "%'"
                y = " and "
            End If

            If chk_POculto.Checked Then
                where = where + y + "Oculto = 1"
                y = " and "
            End If

            If Chk_Proveedor.Enabled And Chk_Grupo.Enabled Then
                Me.SpinfoGeneralBindingSource.Filter = where
                Dim Count As Object
                Dim Uni As Object
                Count = Me.MELDataSet.sp_infoGeneral.Compute("COUNT(CodigoInterno)", where)
                Uni = Me.MELDataSet.sp_infoGeneral.Compute("Sum(Cant)", where)

                If Uni.ToString = "" Then
                    Uni = "0"
                End If

                If Count.ToString = "" Then
                    Count = "0"
                End If

                Me.lbl_totalUniPro.Text = Format(CInt(Uni.ToString), "N0")
                Me.Label11.Text = Format(CInt(Count.ToString), "N0")

            Else

                Me.Sp_infoGeneralComprasBindingSource.Filter = where
                Dim Count As Object
                Dim Uni As Object

                Uni = Me.MELDataSet.sp_infoGeneralCompras.Compute("Sum(Cant)", where)
                Count = Me.MELDataSet.sp_infoGeneralCompras.Compute("COUNT(CodigoInterno)", where)

                If Uni.ToString = "" Then
                    Uni = "0"
                End If

                If Count.ToString = "" Then
                    Count = "0"
                End If

                Me.lbl_totalUniPro.Text = Format(CInt(Uni.ToString), "N0")
                Me.Label11.Text = Format(CInt(Count.ToString), "N0")

            End If

            tb_obs.Clear()
            DGV_Productos.ClearSelection()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.Click
        If DGV_Productos.SelectedRows.Count > 0 Then
            Dim frm As New Frm_Productos_Por_Facturar
            Dim f As Boolean = False
            Dim r As Boolean = False

            If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                f = True
            ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                r = True
            End If

            frm.recibe(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Productos.SelectedRows(0).Cells(1).Value, f, r)
            frm.Show()
        Else
            MsgBox("No existe ningún producto seleccionado", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub


    Private Sub bt_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_actualizar.Click

        Dim valor As Integer = 0

        If DGV_Productos.SelectedRows.Count > 0 Then
            valor = DGV_Productos.SelectedRows(0).Index
        End If


        If My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
            Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 1)
        ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
            Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 2)
        Else
            Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 0)
        End If

        If nrocompra <> 0 Then
            nroPedido = -1
        ElseIf nroPedido <> 0 Then
            nrocompra = -1
        End If

        If nrocompra = 0 And nroPedido = 0 Then
            If My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 1)
            ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 2)
            Else
                Me.Sp_infoGeneralTableAdapter.Fill(Me.MELDataSet.sp_infoGeneral, 0)
            End If
            DGV_Productos.DataSource = SpinfoGeneralBindingSource
        Else

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 0 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, nrocompra, 1, "")
            Else
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, nroPedido, nrocompra, 0, "")
            End If


            DGV_Productos.DataSource = Sp_infoGeneralComprasBindingSource
        End If

        CrearWhere()

        Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Actualización exitosa!", ToolTipIcon.Info)

        If valor > 0 Then
            Try
                DGV_Productos.Rows(valor).Cells(0).Selected = True
                DGV_Productos.FirstDisplayedScrollingRowIndex = valor
                DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)
                DGV_Productos.Select()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_POculto.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub lbl_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_info.Click

        Dim frm As New Frm_OcultarColmumnas
        frm.recibe(DGV_Compras, DGV_Pedidos, Me)
        Me.Enabled = False
        frm.Show()
        frm.TopMost = True

    End Sub

    Private Sub CheckBox9_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_compra.CheckedChanged

        If chk_compra.Checked = True Then
            tb_compra.Enabled = True
            Chk_Proveedor.Enabled = False
            cb_proveedor.Enabled = False
            cb_proveedor.Text = ""
            lb_proveedor.Visible = False
            tb_compra.Focus()
        Else
            Chk_Proveedor.Enabled = True
            compras = False
            nrocompra = -1
            tb_compra.Clear()
            tb_compra.Enabled = False
            DGV_Productos.DataSource = SpinfoGeneralBindingSource
            CrearWhere()
            DGV_Ajustes.Rows.Clear()
            DGV_Arancelarios.Rows.Clear()
            DGV_Compras.Rows.Clear()
            DGV_Direccion.Rows.Clear()
            DGV_Proveedor.Rows.Clear()
            DGV_Ventas.Rows.Clear()
            DGV_Pedidos.Rows.Clear()
            DGV_Grupos.Rows.Clear()
        End If

    End Sub

    Private Sub tb_compra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_compra.KeyDown

        If e.KeyCode = Keys.Enter Then

            nrocompra = CInt(tb_compra.Text)

            If My.Settings.Empresa = 1 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 2, "")
            ElseIf My.Settings.Empresa = 4 Then
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 1, "")
            Else
                Me.Sp_infoGeneralComprasTableAdapter.Fill(Me.MELDataSet.sp_infoGeneralCompras, -1, nrocompra, 0, "")
            End If

            DGV_Productos.DataSource = Sp_infoGeneralComprasBindingSource
            compras = True
            CrearWhere()

        End If

    End Sub

    Private Sub DGV_Arancelarios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Arancelarios.CellDoubleClick

        If e.ColumnIndex = 0 And e.RowIndex = 0 Then

            If Me.e Then

                Dim frm As New Frm_Codigos_Arancelarios
                frm.w = True
                frm.Show()
                frm.TextBox1.Text = DGV_Arancelarios.SelectedRows(0).Cells(0).Value.ToString
                If frm.Dgv_CodArancelario.RowCount > 0 Then
                    frm.Dgv_CodArancelario.Rows(0).Cells(0).Selected = True
                End If
                frm.Dgv_CodArancelario_SelectionChanged(frm.Dgv_CodArancelario, New EventArgs)
                frm.TextBox1.Enabled = False

            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DGV_Productos.SelectedRows.Count > 0 Then
            If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                    DatosCompras.modifica_producto_obs(tb_obs.Text, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 1)
                ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                    DatosCompras.modifica_producto_obs(tb_obs.Text, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 2)
                Else
                    DatosCompras.modifica_producto_obs(tb_obs.Text, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 0)
                End If

            Else
                DatosCompras.modifica_producto_obs(tb_obs.Text, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, 0)
            End If
        Else
            MsgBox("Debe seleccionar un producto", MsgBoxStyle.Exclamation, "SINPRO")
        End If
    End Sub

    Private Sub tb_bultos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_buscarcodigo.KeyPress
        If e.KeyChar = "*" Or e.KeyChar = "'" Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub DGV_Proveedor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Proveedor.CellDoubleClick

        If DGV_Productos.SelectedRows.Count > 0 Then

            If e.ColumnIndex = 1 And DGV_Proveedor.SelectedRows.Count > 0 And Me.e Then

                If DGV_Proveedor.SelectedRows(0).Index <> DGV_Proveedor.RowCount - 1 Then

                    Dim frm As New Frm_ModificaCodigoFabrica
                    Dim f As Boolean = False
                    Dim r As Boolean = False

                    If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                        If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                            f = True
                        ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                            r = True
                        End If

                        frm.Recibe(DGV_Proveedor.SelectedRows(0).Cells(0).Value.ToString, DGV_Proveedor.SelectedRows(0).Cells(4).Value.ToString, DGV_Proveedor.SelectedRows(0).Cells(1).Value.ToString, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, DGV_Productos.SelectedRows(0).Cells(1).Value.ToString, 0, f, r, , , Me)

                    Else
                        frm.Recibe(DGV_Proveedor.SelectedRows(0).Cells(0).Value.ToString, DGV_Proveedor.SelectedRows(0).Cells(4).Value.ToString, DGV_Proveedor.SelectedRows(0).Cells(1).Value.ToString, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, DGV_Productos.SelectedRows(0).Cells(1).Value.ToString, 0, f, r, , , Me)
                    End If

                    frm.Show()
                    Me.Enabled = False

                Else

                    Dim frm As New Frm_ModificaCodigoFabrica
                    Dim f As Boolean = False
                    Dim r As Boolean = False

                    If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

                        If DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("FIAT") Then
                            f = True
                        ElseIf DGV_Productos.SelectedRows(0).Cells(8).Value.ToString.ToUpper.Contains("RENAULT") Then
                            r = True
                        End If

                        frm.Recibe(DGV_Proveedor.SelectedRows(0).Cells(0).Value.ToString, -1, DGV_Proveedor.SelectedRows(0).Cells(1).Value.ToString, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, DGV_Productos.SelectedRows(0).Cells(1).Value.ToString, 1, f, r, , , Me)

                    Else
                        frm.Recibe(DGV_Proveedor.SelectedRows(0).Cells(0).Value.ToString, -1, DGV_Proveedor.SelectedRows(0).Cells(1).Value.ToString, DGV_Productos.SelectedRows(0).Cells(0).Value.ToString, DGV_Productos.SelectedRows(0).Cells(1).Value.ToString, 1, f, r, , , Me)
                    End If

                    frm.Show()
                    Me.Enabled = False


                End If

            End If

        End If
    End Sub

    Private Sub chk_exacto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exacto.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarProductoToolStripMenuItem.Click

        If DGV_Productos.SelectedRows.Count > 0 Then

            Dim index As Integer = DGV_Productos.SelectedRows(0).Index

            'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 Then
            DatosProducto.elimina_producto(DGV_Productos.SelectedRows(0).Cells(0).Value)
            'Else
            '    DatosProducto.elimina_producto_BRWME(DGV_Productos.SelectedRows(0).Cells(0).Value)
            'End If

            bt_actualizar_Click(bt_actualizar, New EventArgs)

            If DGV_Productos.RowCount > 0 Then
                DGV_Productos.Rows(index).Cells(0).Selected = True
                DGV_Productos.FirstDisplayedScrollingRowIndex = index
            End If

        End If

    End Sub

    Private Sub DGV_Proveedor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_Proveedor.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_Proveedor.Rows(hti.RowIndex).Selected Then

                    ' User right clicked a row that is not selected, so throw away all other selections and select this row

                    DGV_Proveedor.ClearSelection()
                    DGV_Proveedor.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        If DGV_Productos.SelectedRows.Count > 0 Then

            Dim resp As Integer = MsgBox("Seguro que desea eliminar este código de fábrica?", MsgBoxStyle.YesNo, "SINPRO")

            If resp = vbYes Then

                If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                    DatosProveedor.EliminarCodigoFabrica(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Proveedor.SelectedRows(0).Cells(4).Value)
                Else
                    DatosProveedor.EliminarCodigoFabrica_BRWME(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Proveedor.SelectedRows(0).Cells(4).Value)
                End If

                DGV_Productos_CellContentClick(DGV_Productos, New EventArgs)

            End If

        End If

    End Sub

    Private Sub chk_fr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fr.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_etiquetas.Click

        If DGV_Productos.SelectedRows.Count > 0 Then

            Dim frm As New Frm_Cantidad_Etiquetas_Indvidual
            frm.CodPro = DGV_Productos.SelectedRows(0).Cells(0).Value.ToString
            frm.CodFab = ""
            frm.Nombre = DGV_Productos.SelectedRows(0).Cells(1).Value.ToString
            frm.Proveedor = ""
            frm.cant = CInt(DGV_Productos.SelectedRows(0).Cells(3).Value.ToString)

            Dim modelo As String = DGV_Productos.SelectedRows(0).Cells(2).Value.ToString

            frm.Modelo = modelo
            frm.Marca = ""
            frm.precio = CDbl(DGV_Productos.SelectedRows(0).Cells(4).Value.ToString)

            frm.Show()

        End If

    End Sub

End Class
