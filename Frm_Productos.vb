Public Class Frm_Productos
    Inherits System.Windows.Forms.Form
    Public indice2 As Integer = 0
    Public varboton As Integer = 0
    Public cambio2 As Boolean = False
    Public ordendgv As Integer = 0
    Public orden2 As System.ComponentModel.ListSortDirection
    Private choice As Integer
    Private swC As Boolean = False
    Private swload As Boolean = False
    Public compras As Boolean = False
    Public cambio As Boolean = False
    Private sww As Boolean = False
    Private indice As Integer = 0
    Dim enter1 As Boolean = False
    Dim down As Boolean = False
    Dim up As Boolean = False
    Dim selected As Boolean = False
    Dim num As Integer = 0
    Dim OEM As String = ""
    Dim presionado As Boolean = False
    Dim presionado2 As Boolean = False
    Dim CodI As String = ""
    Dim codigoAnterior As String = ""
    Dim proveedorA As Integer = 0
    Dim columna As Integer = 0
    Dim cont As Integer = 0
    Dim w As Boolean = True
    Dim e As Boolean = True
    Private swX As Boolean = False
    Public text1 As String = ""
    Public frm As Frm_Compras
    Public text2 As String = ""
    Public productosCompras As DataGridView
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents bt_quitar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cuarto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents TableAlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_AlmacenTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
    Friend WithEvents gb_Direccion As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DGV_Direccion As System.Windows.Forms.DataGridView
    Friend WithEvents tb_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents bt_ModificarCuarto As System.Windows.Forms.Button
    Friend WithEvents bt_agregarCuarto As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarCuarto As System.Windows.Forms.Button
    Friend WithEvents tb_Var2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_Var1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_OEM As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpconsultaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductoTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGV_Seleccionados As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Modelo As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_CodigoP As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuarto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_empaque As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents gb_codigoFabrica As System.Windows.Forms.GroupBox
    Friend WithEvents tb_modificarCF As System.Windows.Forms.Button
    Friend WithEvents bt_agregarCF As System.Windows.Forms.Button
    Friend WithEvents bt_eliminaCF As System.Windows.Forms.Button
    Friend WithEvents tb_codigoFabrica As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk_oculto As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb_info As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents SpconsultaCodigoArancelarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaCodigoArancelarioTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigoArancelarioTableAdapter
    Friend WithEvents lb_marca As System.Windows.Forms.ListBox
    Friend WithEvents cb_marc As System.Windows.Forms.TextBox
    Friend WithEvents SpconsultaMarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaMarcaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
    Friend WithEvents cb_model As System.Windows.Forms.TextBox
    Friend WithEvents lb_modelo As System.Windows.Forms.ListBox
    Friend WithEvents lb_proveedor As System.Windows.Forms.ListBox
    Friend WithEvents cb_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents TblFabricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FabricaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
    Friend WithEvents lb_nombre As System.Windows.Forms.ListBox
    Friend WithEvents cb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents TblModeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_ModeloTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_ModeloTableAdapter
    Friend WithEvents SpconsultaCodigosInternosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaCodigosInternosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigosInternosTableAdapter
    Friend WithEvents SpconsultaProductoFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductoFTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductoFTableAdapter
    Friend WithEvents SpconsultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Friend WithEvents Chk_PorC As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_porC As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Oculto As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PorComplementar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private swY As Boolean = False
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_clasificacion As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_precioventa As System.Windows.Forms.TextBox
    Friend WithEvents tb_cantidadexistencia As System.Windows.Forms.TextBox
    Friend WithEvents cb_marcproducto As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigointerno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_foto As System.Windows.Forms.TextBox
    Friend WithEvents tb_costopromedio As System.Windows.Forms.TextBox
    Friend WithEvents tb_cantidadvendida As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bt_foto As System.Windows.Forms.Button
    Friend WithEvents tb_codigoarancelario As MTGCComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.lb_nombre = New System.Windows.Forms.ListBox
        Me.SpconsultaCodigosInternosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Button2 = New System.Windows.Forms.Button
        Me.Chk_PorC = New System.Windows.Forms.CheckBox
        Me.lb_modelo = New System.Windows.Forms.ListBox
        Me.TblModeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_marca = New System.Windows.Forms.ListBox
        Me.SpconsultaMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_nombre = New System.Windows.Forms.TextBox
        Me.cb_model = New System.Windows.Forms.TextBox
        Me.cb_marc = New System.Windows.Forms.TextBox
        Me.tb_info = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.chk_oculto = New System.Windows.Forms.CheckBox
        Me.gb_codigoFabrica = New System.Windows.Forms.GroupBox
        Me.lb_proveedor = New System.Windows.Forms.ListBox
        Me.TblFabricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_proveedor = New System.Windows.Forms.TextBox
        Me.tb_modificarCF = New System.Windows.Forms.Button
        Me.bt_agregarCF = New System.Windows.Forms.Button
        Me.bt_eliminaCF = New System.Windows.Forms.Button
        Me.tb_codigoFabrica = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DGV_Direccion = New System.Windows.Forms.DataGridView
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuarto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tb_empaque = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.DGV_CodigoP = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Seleccionados = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gb_Direccion = New System.Windows.Forms.GroupBox
        Me.bt_ModificarCuarto = New System.Windows.Forms.Button
        Me.bt_agregarCuarto = New System.Windows.Forms.Button
        Me.bt_eliminarCuarto = New System.Windows.Forms.Button
        Me.tb_cantidad = New System.Windows.Forms.TextBox
        Me.cb_cuarto = New System.Windows.Forms.ComboBox
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.TableAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.DGV_Modelo = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_foto = New System.Windows.Forms.Button
        Me.tb_Var2 = New System.Windows.Forms.TextBox
        Me.tb_Var1 = New System.Windows.Forms.TextBox
        Me.tb_OEM = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.cb_marcproducto = New System.Windows.Forms.TextBox
        Me.tb_codigoarancelario = New MTGCComboBox
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.bt_quitar = New System.Windows.Forms.Button
        Me.tb_cantidadvendida = New System.Windows.Forms.TextBox
        Me.tb_costopromedio = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_clasificacion = New System.Windows.Forms.TextBox
        Me.tb_precioventa = New System.Windows.Forms.TextBox
        Me.tb_cantidadexistencia = New System.Windows.Forms.TextBox
        Me.tb_foto = New System.Windows.Forms.TextBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.tb_codigointerno = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SpconsultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpconsultaCodigoArancelarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoProductoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Oculto = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PorComplementar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SpconsultaProductoFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_AlmacenTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpconsultaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaProductoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductoTableAdapter
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.Sp_consultaCodigoArancelarioTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigoArancelarioTableAdapter
        Me.Sp_consultaMarcaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaMarcaTableAdapter
        Me.Tbl_FabricaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_FabricaTableAdapter
        Me.Tbl_ModeloTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_ModeloTableAdapter
        Me.Sp_consultaCodigosInternosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCodigosInternosTableAdapter
        Me.Sp_consultaProductoFTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductoFTableAdapter
        Me.Sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.rb_porC = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.groupbox1.SuspendLayout()
        CType(Me.SpconsultaCodigosInternosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblModeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_codigoFabrica.SuspendLayout()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Direccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CodigoP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Seleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Direccion.SuspendLayout()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Modelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaCodigoArancelarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SpconsultaProductoFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 681)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 681)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(351, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Datos del Producto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(190, 78)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(149, 23)
        Me.tb_buscarcodigo.TabIndex = 0
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.Transparent
        Me.groupbox1.Controls.Add(Me.lb_nombre)
        Me.groupbox1.Controls.Add(Me.Button2)
        Me.groupbox1.Controls.Add(Me.Chk_PorC)
        Me.groupbox1.Controls.Add(Me.lb_modelo)
        Me.groupbox1.Controls.Add(Me.lb_marca)
        Me.groupbox1.Controls.Add(Me.cb_nombre)
        Me.groupbox1.Controls.Add(Me.cb_model)
        Me.groupbox1.Controls.Add(Me.cb_marc)
        Me.groupbox1.Controls.Add(Me.tb_info)
        Me.groupbox1.Controls.Add(Me.Label30)
        Me.groupbox1.Controls.Add(Me.chk_oculto)
        Me.groupbox1.Controls.Add(Me.gb_codigoFabrica)
        Me.groupbox1.Controls.Add(Me.tb_observacion)
        Me.groupbox1.Controls.Add(Me.Panel1)
        Me.groupbox1.Controls.Add(Me.DGV_Direccion)
        Me.groupbox1.Controls.Add(Me.tb_empaque)
        Me.groupbox1.Controls.Add(Me.Label27)
        Me.groupbox1.Controls.Add(Me.Label28)
        Me.groupbox1.Controls.Add(Me.DGV_CodigoP)
        Me.groupbox1.Controls.Add(Me.DGV_Seleccionados)
        Me.groupbox1.Controls.Add(Me.gb_Direccion)
        Me.groupbox1.Controls.Add(Me.DGV_Modelo)
        Me.groupbox1.Controls.Add(Me.Button1)
        Me.groupbox1.Controls.Add(Me.bt_foto)
        Me.groupbox1.Controls.Add(Me.tb_Var2)
        Me.groupbox1.Controls.Add(Me.tb_Var1)
        Me.groupbox1.Controls.Add(Me.tb_OEM)
        Me.groupbox1.Controls.Add(Me.Label24)
        Me.groupbox1.Controls.Add(Me.Label25)
        Me.groupbox1.Controls.Add(Me.Label26)
        Me.groupbox1.Controls.Add(Me.cb_marcproducto)
        Me.groupbox1.Controls.Add(Me.tb_codigoarancelario)
        Me.groupbox1.Controls.Add(Me.bt_agregar)
        Me.groupbox1.Controls.Add(Me.Label22)
        Me.groupbox1.Controls.Add(Me.Label15)
        Me.groupbox1.Controls.Add(Me.bt_quitar)
        Me.groupbox1.Controls.Add(Me.tb_cantidadvendida)
        Me.groupbox1.Controls.Add(Me.tb_costopromedio)
        Me.groupbox1.Controls.Add(Me.Label6)
        Me.groupbox1.Controls.Add(Me.bt_cancelar)
        Me.groupbox1.Controls.Add(Me.bt_aceptar)
        Me.groupbox1.Controls.Add(Me.tb_clasificacion)
        Me.groupbox1.Controls.Add(Me.tb_precioventa)
        Me.groupbox1.Controls.Add(Me.tb_cantidadexistencia)
        Me.groupbox1.Controls.Add(Me.tb_foto)
        Me.groupbox1.Controls.Add(Me.tb_nombre)
        Me.groupbox1.Controls.Add(Me.tb_codigointerno)
        Me.groupbox1.Controls.Add(Me.Label21)
        Me.groupbox1.Controls.Add(Me.Label10)
        Me.groupbox1.Controls.Add(Me.Label8)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Label4)
        Me.groupbox1.Controls.Add(Me.Label14)
        Me.groupbox1.Controls.Add(Me.Label12)
        Me.groupbox1.Controls.Add(Me.Label11)
        Me.groupbox1.Controls.Add(Me.Label5)
        Me.groupbox1.Controls.Add(Me.Label7)
        Me.groupbox1.Controls.Add(Me.Label13)
        Me.groupbox1.Location = New System.Drawing.Point(351, 16)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(675, 685)
        Me.groupbox1.TabIndex = 25
        Me.groupbox1.TabStop = False
        '
        'lb_nombre
        '
        Me.lb_nombre.DataSource = Me.SpconsultaCodigosInternosBindingSource
        Me.lb_nombre.DisplayMember = "nombre"
        Me.lb_nombre.FormattingEnabled = True
        Me.lb_nombre.ItemHeight = 15
        Me.lb_nombre.Location = New System.Drawing.Point(128, 31)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(330, 79)
        Me.lb_nombre.TabIndex = 20013
        Me.lb_nombre.ValueMember = "nombre"
        Me.lb_nombre.Visible = False
        '
        'SpconsultaCodigosInternosBindingSource
        '
        Me.SpconsultaCodigosInternosBindingSource.DataMember = "sp_consultaCodigosInternos"
        Me.SpconsultaCodigosInternosBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(264, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 22)
        Me.Button2.TabIndex = 20015
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Visible = False
        '
        'Chk_PorC
        '
        Me.Chk_PorC.AutoSize = True
        Me.Chk_PorC.Enabled = False
        Me.Chk_PorC.Location = New System.Drawing.Point(521, 385)
        Me.Chk_PorC.Name = "Chk_PorC"
        Me.Chk_PorC.Size = New System.Drawing.Size(136, 19)
        Me.Chk_PorC.TabIndex = 20014
        Me.Chk_PorC.Text = "Por Complementar"
        Me.Chk_PorC.UseVisualStyleBackColor = True
        '
        'lb_modelo
        '
        Me.lb_modelo.DataSource = Me.TblModeloBindingSource
        Me.lb_modelo.DisplayMember = "Modelo"
        Me.lb_modelo.FormattingEnabled = True
        Me.lb_modelo.ItemHeight = 15
        Me.lb_modelo.Location = New System.Drawing.Point(128, 343)
        Me.lb_modelo.Name = "lb_modelo"
        Me.lb_modelo.Size = New System.Drawing.Size(130, 94)
        Me.lb_modelo.TabIndex = 20011
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
        Me.lb_marca.Location = New System.Drawing.Point(128, 319)
        Me.lb_marca.Name = "lb_marca"
        Me.lb_marca.Size = New System.Drawing.Size(130, 79)
        Me.lb_marca.TabIndex = 20009
        Me.lb_marca.ValueMember = "Marca"
        Me.lb_marca.Visible = False
        '
        'SpconsultaMarcaBindingSource
        '
        Me.SpconsultaMarcaBindingSource.DataMember = "sp_consultaMarca"
        Me.SpconsultaMarcaBindingSource.DataSource = Me.MELDataSet
        '
        'cb_nombre
        '
        Me.cb_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_nombre.Enabled = False
        Me.cb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_nombre.ForeColor = System.Drawing.Color.Black
        Me.cb_nombre.Location = New System.Drawing.Point(128, 13)
        Me.cb_nombre.Name = "cb_nombre"
        Me.cb_nombre.Size = New System.Drawing.Size(330, 21)
        Me.cb_nombre.TabIndex = 20012
        '
        'cb_model
        '
        Me.cb_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_model.Enabled = False
        Me.cb_model.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_model.ForeColor = System.Drawing.Color.Black
        Me.cb_model.Location = New System.Drawing.Point(128, 321)
        Me.cb_model.Name = "cb_model"
        Me.cb_model.Size = New System.Drawing.Size(130, 21)
        Me.cb_model.TabIndex = 20010
        Me.cb_model.Visible = False
        '
        'cb_marc
        '
        Me.cb_marc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_marc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_marc.Enabled = False
        Me.cb_marc.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marc.ForeColor = System.Drawing.Color.Black
        Me.cb_marc.Location = New System.Drawing.Point(128, 298)
        Me.cb_marc.Name = "cb_marc"
        Me.cb_marc.Size = New System.Drawing.Size(130, 21)
        Me.cb_marc.TabIndex = 20008
        Me.cb_marc.Visible = False
        '
        'tb_info
        '
        Me.tb_info.Enabled = False
        Me.tb_info.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_info.Location = New System.Drawing.Point(128, 124)
        Me.tb_info.MaxLength = 250
        Me.tb_info.Name = "tb_info"
        Me.tb_info.Size = New System.Drawing.Size(288, 22)
        Me.tb_info.TabIndex = 20007
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(4, 151)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 23)
        Me.Label30.TabIndex = 20006
        Me.Label30.Text = "Observación:"
        '
        'chk_oculto
        '
        Me.chk_oculto.AutoSize = True
        Me.chk_oculto.Enabled = False
        Me.chk_oculto.Location = New System.Drawing.Point(521, 365)
        Me.chk_oculto.Name = "chk_oculto"
        Me.chk_oculto.Size = New System.Drawing.Size(122, 19)
        Me.chk_oculto.TabIndex = 20005
        Me.chk_oculto.Text = "Producto Oculto"
        Me.chk_oculto.UseVisualStyleBackColor = True
        '
        'gb_codigoFabrica
        '
        Me.gb_codigoFabrica.BackColor = System.Drawing.Color.White
        Me.gb_codigoFabrica.Controls.Add(Me.lb_proveedor)
        Me.gb_codigoFabrica.Controls.Add(Me.cb_proveedor)
        Me.gb_codigoFabrica.Controls.Add(Me.tb_modificarCF)
        Me.gb_codigoFabrica.Controls.Add(Me.bt_agregarCF)
        Me.gb_codigoFabrica.Controls.Add(Me.bt_eliminaCF)
        Me.gb_codigoFabrica.Controls.Add(Me.tb_codigoFabrica)
        Me.gb_codigoFabrica.Controls.Add(Me.Label23)
        Me.gb_codigoFabrica.Controls.Add(Me.Label29)
        Me.gb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_codigoFabrica.Location = New System.Drawing.Point(448, 558)
        Me.gb_codigoFabrica.Name = "gb_codigoFabrica"
        Me.gb_codigoFabrica.Size = New System.Drawing.Size(221, 110)
        Me.gb_codigoFabrica.TabIndex = 20004
        Me.gb_codigoFabrica.TabStop = False
        Me.gb_codigoFabrica.Text = "Código de Fábrica"
        Me.gb_codigoFabrica.Visible = False
        '
        'lb_proveedor
        '
        Me.lb_proveedor.DataSource = Me.TblFabricaBindingSource
        Me.lb_proveedor.DisplayMember = "Nombre"
        Me.lb_proveedor.FormattingEnabled = True
        Me.lb_proveedor.ItemHeight = 15
        Me.lb_proveedor.Location = New System.Drawing.Point(73, 39)
        Me.lb_proveedor.Name = "lb_proveedor"
        Me.lb_proveedor.Size = New System.Drawing.Size(136, 64)
        Me.lb_proveedor.TabIndex = 20013
        Me.lb_proveedor.ValueMember = "CodigoFabrica"
        Me.lb_proveedor.Visible = False
        '
        'TblFabricaBindingSource
        '
        Me.TblFabricaBindingSource.DataMember = "Tbl_Fabrica"
        Me.TblFabricaBindingSource.DataSource = Me.MELDataSet
        '
        'cb_proveedor
        '
        Me.cb_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.ForeColor = System.Drawing.Color.Black
        Me.cb_proveedor.Location = New System.Drawing.Point(73, 18)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(136, 21)
        Me.cb_proveedor.TabIndex = 20012
        '
        'tb_modificarCF
        '
        Me.tb_modificarCF.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_modificarCF.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.tb_modificarCF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tb_modificarCF.Location = New System.Drawing.Point(125, 82)
        Me.tb_modificarCF.Name = "tb_modificarCF"
        Me.tb_modificarCF.Size = New System.Drawing.Size(25, 22)
        Me.tb_modificarCF.TabIndex = 29
        Me.tb_modificarCF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarCF
        '
        Me.bt_agregarCF.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarCF.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCF.Location = New System.Drawing.Point(99, 82)
        Me.bt_agregarCF.Name = "bt_agregarCF"
        Me.bt_agregarCF.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarCF.TabIndex = 28
        Me.bt_agregarCF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminaCF
        '
        Me.bt_eliminaCF.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminaCF.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminaCF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminaCF.Location = New System.Drawing.Point(153, 82)
        Me.bt_eliminaCF.Name = "bt_eliminaCF"
        Me.bt_eliminaCF.Size = New System.Drawing.Size(25, 21)
        Me.bt_eliminaCF.TabIndex = 30
        Me.bt_eliminaCF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_codigoFabrica
        '
        Me.tb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigoFabrica.Location = New System.Drawing.Point(73, 50)
        Me.tb_codigoFabrica.Name = "tb_codigoFabrica"
        Me.tb_codigoFabrica.Size = New System.Drawing.Size(136, 22)
        Me.tb_codigoFabrica.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 23)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Cod. F.:"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 23)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Proveedor: "
        '
        'tb_observacion
        '
        Me.tb_observacion.Enabled = False
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(128, 146)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.Size = New System.Drawing.Size(288, 37)
        Me.tb_observacion.TabIndex = 20003
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(507, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 150)
        Me.Panel1.TabIndex = 75
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DGV_Direccion
        '
        Me.DGV_Direccion.AllowUserToAddRows = False
        Me.DGV_Direccion.AllowUserToDeleteRows = False
        Me.DGV_Direccion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Direccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Direccion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Direccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Direccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Almacen, Me.Cuarto, Me.Estante, Me.Tramo, Me.Cantidad, Me.CodigoTramo})
        Me.DGV_Direccion.EnableHeadersVisualStyles = False
        Me.DGV_Direccion.Location = New System.Drawing.Point(4, 217)
        Me.DGV_Direccion.MultiSelect = False
        Me.DGV_Direccion.Name = "DGV_Direccion"
        Me.DGV_Direccion.ReadOnly = True
        Me.DGV_Direccion.RowHeadersVisible = False
        Me.DGV_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Direccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Direccion.Size = New System.Drawing.Size(306, 73)
        Me.DGV_Direccion.TabIndex = 89
        '
        'Almacen
        '
        Me.Almacen.HeaderText = "Almacén"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 65
        '
        'Cuarto
        '
        Me.Cuarto.HeaderText = "Cuarto"
        Me.Cuarto.Name = "Cuarto"
        Me.Cuarto.ReadOnly = True
        Me.Cuarto.Width = 65
        '
        'Estante
        '
        Me.Estante.HeaderText = "Estante"
        Me.Estante.Name = "Estante"
        Me.Estante.ReadOnly = True
        Me.Estante.Width = 58
        '
        'Tramo
        '
        Me.Tramo.HeaderText = "Tramo"
        Me.Tramo.Name = "Tramo"
        Me.Tramo.ReadOnly = True
        Me.Tramo.Width = 55
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'CodigoTramo
        '
        Me.CodigoTramo.HeaderText = "CodigoTramo"
        Me.CodigoTramo.Name = "CodigoTramo"
        Me.CodigoTramo.ReadOnly = True
        Me.CodigoTramo.Visible = False
        '
        'tb_empaque
        '
        Me.tb_empaque.Enabled = False
        Me.tb_empaque.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_empaque.Location = New System.Drawing.Point(542, 132)
        Me.tb_empaque.Name = "tb_empaque"
        Me.tb_empaque.Size = New System.Drawing.Size(129, 22)
        Me.tb_empaque.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(4, 129)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 23)
        Me.Label27.TabIndex = 10043
        Me.Label27.Text = "Característica:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(422, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 23)
        Me.Label28.TabIndex = 10042
        Me.Label28.Text = "Empaque:"
        '
        'DGV_CodigoP
        '
        Me.DGV_CodigoP.AllowUserToAddRows = False
        Me.DGV_CodigoP.AllowUserToDeleteRows = False
        Me.DGV_CodigoP.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CodigoP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CodigoP.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_CodigoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CodigoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.CodP})
        Me.DGV_CodigoP.EnableHeadersVisualStyles = False
        Me.DGV_CodigoP.Location = New System.Drawing.Point(4, 334)
        Me.DGV_CodigoP.MultiSelect = False
        Me.DGV_CodigoP.Name = "DGV_CodigoP"
        Me.DGV_CodigoP.ReadOnly = True
        Me.DGV_CodigoP.RowHeadersVisible = False
        Me.DGV_CodigoP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_CodigoP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_CodigoP.Size = New System.Drawing.Size(422, 75)
        Me.DGV_CodigoP.TabIndex = 10039
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 120
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Código "
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Variante1"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 95
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Variante2"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 95
        '
        'CodP
        '
        Me.CodP.HeaderText = "CodProveedor"
        Me.CodP.Name = "CodP"
        Me.CodP.ReadOnly = True
        Me.CodP.Visible = False
        '
        'DGV_Seleccionados
        '
        Me.DGV_Seleccionados.AllowUserToAddRows = False
        Me.DGV_Seleccionados.AllowUserToDeleteRows = False
        Me.DGV_Seleccionados.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Seleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Seleccionados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Seleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Column1})
        Me.DGV_Seleccionados.EnableHeadersVisualStyles = False
        Me.DGV_Seleccionados.Location = New System.Drawing.Point(4, 470)
        Me.DGV_Seleccionados.MultiSelect = False
        Me.DGV_Seleccionados.Name = "DGV_Seleccionados"
        Me.DGV_Seleccionados.ReadOnly = True
        Me.DGV_Seleccionados.RowHeadersVisible = False
        Me.DGV_Seleccionados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Seleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Seleccionados.Size = New System.Drawing.Size(572, 82)
        Me.DGV_Seleccionados.TabIndex = 10037
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Motor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ptas"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Versión"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Obs."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'gb_Direccion
        '
        Me.gb_Direccion.BackColor = System.Drawing.Color.White
        Me.gb_Direccion.Controls.Add(Me.bt_ModificarCuarto)
        Me.gb_Direccion.Controls.Add(Me.bt_agregarCuarto)
        Me.gb_Direccion.Controls.Add(Me.bt_eliminarCuarto)
        Me.gb_Direccion.Controls.Add(Me.tb_cantidad)
        Me.gb_Direccion.Controls.Add(Me.cb_cuarto)
        Me.gb_Direccion.Controls.Add(Me.cb_tramo)
        Me.gb_Direccion.Controls.Add(Me.cb_almacen)
        Me.gb_Direccion.Controls.Add(Me.cb_estante)
        Me.gb_Direccion.Controls.Add(Me.Label20)
        Me.gb_Direccion.Controls.Add(Me.Label19)
        Me.gb_Direccion.Controls.Add(Me.Label18)
        Me.gb_Direccion.Controls.Add(Me.Label17)
        Me.gb_Direccion.Controls.Add(Me.Label16)
        Me.gb_Direccion.Enabled = False
        Me.gb_Direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Direccion.Location = New System.Drawing.Point(313, 216)
        Me.gb_Direccion.Name = "gb_Direccion"
        Me.gb_Direccion.Size = New System.Drawing.Size(190, 135)
        Me.gb_Direccion.TabIndex = 22
        Me.gb_Direccion.TabStop = False
        Me.gb_Direccion.Text = "Dirección"
        Me.gb_Direccion.Visible = False
        '
        'bt_ModificarCuarto
        '
        Me.bt_ModificarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ModificarCuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ModificarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarCuarto.Location = New System.Drawing.Point(123, 108)
        Me.bt_ModificarCuarto.Name = "bt_ModificarCuarto"
        Me.bt_ModificarCuarto.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarCuarto.TabIndex = 29
        Me.bt_ModificarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarCuarto
        '
        Me.bt_agregarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregarCuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCuarto.Location = New System.Drawing.Point(97, 108)
        Me.bt_agregarCuarto.Name = "bt_agregarCuarto"
        Me.bt_agregarCuarto.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarCuarto.TabIndex = 28
        Me.bt_agregarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarCuarto
        '
        Me.bt_eliminarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminarCuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCuarto.Location = New System.Drawing.Point(151, 108)
        Me.bt_eliminarCuarto.Name = "bt_eliminarCuarto"
        Me.bt_eliminarCuarto.Size = New System.Drawing.Size(25, 21)
        Me.bt_eliminarCuarto.TabIndex = 30
        Me.bt_eliminarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_cantidad
        '
        Me.tb_cantidad.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidad.Location = New System.Drawing.Point(64, 108)
        Me.tb_cantidad.Name = "tb_cantidad"
        Me.tb_cantidad.Size = New System.Drawing.Size(32, 22)
        Me.tb_cantidad.TabIndex = 27
        '
        'cb_cuarto
        '
        Me.cb_cuarto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cuarto.FormattingEnabled = True
        Me.cb_cuarto.Location = New System.Drawing.Point(64, 37)
        Me.cb_cuarto.Name = "cb_cuarto"
        Me.cb_cuarto.Size = New System.Drawing.Size(121, 23)
        Me.cb_cuarto.TabIndex = 24
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(64, 83)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(121, 23)
        Me.cb_tramo.TabIndex = 26
        '
        'cb_almacen
        '
        Me.cb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen.DataSource = Me.TableAlmacenBindingSource
        Me.cb_almacen.DisplayMember = "Nombre"
        Me.cb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen.FormattingEnabled = True
        Me.cb_almacen.Location = New System.Drawing.Point(64, 14)
        Me.cb_almacen.Name = "cb_almacen"
        Me.cb_almacen.Size = New System.Drawing.Size(121, 23)
        Me.cb_almacen.TabIndex = 23
        Me.cb_almacen.ValueMember = "Id"
        '
        'TableAlmacenBindingSource
        '
        Me.TableAlmacenBindingSource.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource.DataSource = Me.MELDataSet
        '
        'cb_estante
        '
        Me.cb_estante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_estante.FormattingEnabled = True
        Me.cb_estante.Location = New System.Drawing.Point(64, 60)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(121, 23)
        Me.cb_estante.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 23)
        Me.Label20.TabIndex = 103
        Me.Label20.Text = "Cantidad:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 23)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Tramo:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 23)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Estante:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 23)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "Cuarto:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 23)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Almacén:"
        '
        'DGV_Modelo
        '
        Me.DGV_Modelo.AllowUserToAddRows = False
        Me.DGV_Modelo.AllowUserToDeleteRows = False
        Me.DGV_Modelo.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Modelo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Modelo.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Modelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Modelo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGV_Modelo.EnableHeadersVisualStyles = False
        Me.DGV_Modelo.Location = New System.Drawing.Point(4, 354)
        Me.DGV_Modelo.MultiSelect = False
        Me.DGV_Modelo.Name = "DGV_Modelo"
        Me.DGV_Modelo.ReadOnly = True
        Me.DGV_Modelo.RowHeadersVisible = False
        Me.DGV_Modelo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Modelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Modelo.Size = New System.Drawing.Size(482, 74)
        Me.DGV_Modelo.TabIndex = 10036
        Me.DGV_Modelo.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Motor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ptas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Versión"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Obs."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(264, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 10035
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_foto
        '
        Me.bt_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_foto.Image = CType(resources.GetObject("bt_foto.Image"), System.Drawing.Image)
        Me.bt_foto.Location = New System.Drawing.Point(511, 157)
        Me.bt_foto.Name = "bt_foto"
        Me.bt_foto.Size = New System.Drawing.Size(25, 22)
        Me.bt_foto.TabIndex = 19
        Me.bt_foto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_foto.Visible = False
        '
        'tb_Var2
        '
        Me.tb_Var2.Enabled = False
        Me.tb_Var2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Var2.Location = New System.Drawing.Point(542, 109)
        Me.tb_Var2.Name = "tb_Var2"
        Me.tb_Var2.Size = New System.Drawing.Size(129, 22)
        Me.tb_Var2.TabIndex = 18
        '
        'tb_Var1
        '
        Me.tb_Var1.Enabled = False
        Me.tb_Var1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Var1.Location = New System.Drawing.Point(542, 86)
        Me.tb_Var1.Name = "tb_Var1"
        Me.tb_Var1.Size = New System.Drawing.Size(129, 22)
        Me.tb_Var1.TabIndex = 17
        '
        'tb_OEM
        '
        Me.tb_OEM.Enabled = False
        Me.tb_OEM.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_OEM.Location = New System.Drawing.Point(542, 63)
        Me.tb_OEM.Name = "tb_OEM"
        Me.tb_OEM.Size = New System.Drawing.Size(129, 22)
        Me.tb_OEM.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(422, 87)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(103, 23)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Variante Ant.:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(422, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 23)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "OEM:"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(422, 113)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 23)
        Me.Label26.TabIndex = 95
        Me.Label26.Text = "Variante Post.:"
        '
        'cb_marcproducto
        '
        Me.cb_marcproducto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marcproducto.Location = New System.Drawing.Point(128, 58)
        Me.cb_marcproducto.Name = "cb_marcproducto"
        Me.cb_marcproducto.Size = New System.Drawing.Size(130, 22)
        Me.cb_marcproducto.TabIndex = 7
        '
        'tb_codigoarancelario
        '
        Me.tb_codigoarancelario.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_codigoarancelario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_codigoarancelario.ColumnNum = 2
        Me.tb_codigoarancelario.ColumnWidth = "85;30"
        Me.tb_codigoarancelario.DisplayMember = "Text"
        Me.tb_codigoarancelario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_codigoarancelario.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_codigoarancelario.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_codigoarancelario.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_codigoarancelario.DropDownWidth = 164
        Me.tb_codigoarancelario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigoarancelario.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_codigoarancelario.GridLineHorizontal = False
        Me.tb_codigoarancelario.GridLineVertical = False
        Me.tb_codigoarancelario.ItemHeight = 17
        Me.tb_codigoarancelario.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_codigoarancelario.Location = New System.Drawing.Point(542, 38)
        Me.tb_codigoarancelario.ManagingFastMouseMoving = True
        Me.tb_codigoarancelario.ManagingFastMouseMovingInterval = 30
        Me.tb_codigoarancelario.Name = "tb_codigoarancelario"
        Me.tb_codigoarancelario.Size = New System.Drawing.Size(129, 23)
        Me.tb_codigoarancelario.TabIndex = 15
        Me.tb_codigoarancelario.ValueMember = "CodigoArancelario"
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.Color.Transparent
        Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar.Image = CType(resources.GetObject("bt_agregar.Image"), System.Drawing.Image)
        Me.bt_agregar.Location = New System.Drawing.Point(218, 433)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(53, 32)
        Me.bt_agregar.TabIndex = 86
        Me.bt_agregar.UseVisualStyleBackColor = False
        Me.bt_agregar.Visible = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(530, 654)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 20)
        Me.Label22.TabIndex = 74
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 441)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 23)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Modelos asociados:"
        '
        'bt_quitar
        '
        Me.bt_quitar.BackColor = System.Drawing.Color.Transparent
        Me.bt_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_quitar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_quitar.Image = CType(resources.GetObject("bt_quitar.Image"), System.Drawing.Image)
        Me.bt_quitar.Location = New System.Drawing.Point(282, 433)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(53, 32)
        Me.bt_quitar.TabIndex = 87
        Me.bt_quitar.UseVisualStyleBackColor = False
        Me.bt_quitar.Visible = False
        '
        'tb_cantidadvendida
        '
        Me.tb_cantidadvendida.Enabled = False
        Me.tb_cantidadvendida.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidadvendida.Location = New System.Drawing.Point(171, 607)
        Me.tb_cantidadvendida.Name = "tb_cantidadvendida"
        Me.tb_cantidadvendida.Size = New System.Drawing.Size(130, 22)
        Me.tb_cantidadvendida.TabIndex = 11
        Me.tb_cantidadvendida.Text = "0"
        Me.tb_cantidadvendida.Visible = False
        '
        'tb_costopromedio
        '
        Me.tb_costopromedio.Enabled = False
        Me.tb_costopromedio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_costopromedio.Location = New System.Drawing.Point(128, 183)
        Me.tb_costopromedio.Name = "tb_costopromedio"
        Me.tb_costopromedio.Size = New System.Drawing.Size(130, 22)
        Me.tb_costopromedio.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Código Arancelario:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(351, 656)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 32
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(254, 656)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 31
        Me.bt_aceptar.Text = "Aceptar"
        '
        'tb_clasificacion
        '
        Me.tb_clasificacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_clasificacion.Location = New System.Drawing.Point(169, 600)
        Me.tb_clasificacion.Name = "tb_clasificacion"
        Me.tb_clasificacion.Size = New System.Drawing.Size(129, 22)
        Me.tb_clasificacion.TabIndex = 14
        Me.tb_clasificacion.Text = "C"
        Me.tb_clasificacion.Visible = False
        '
        'tb_precioventa
        '
        Me.tb_precioventa.Enabled = False
        Me.tb_precioventa.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_precioventa.Location = New System.Drawing.Point(128, 102)
        Me.tb_precioventa.Name = "tb_precioventa"
        Me.tb_precioventa.Size = New System.Drawing.Size(130, 22)
        Me.tb_precioventa.TabIndex = 9
        '
        'tb_cantidadexistencia
        '
        Me.tb_cantidadexistencia.Enabled = False
        Me.tb_cantidadexistencia.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidadexistencia.Location = New System.Drawing.Point(128, 80)
        Me.tb_cantidadexistencia.Name = "tb_cantidadexistencia"
        Me.tb_cantidadexistencia.Size = New System.Drawing.Size(130, 22)
        Me.tb_cantidadexistencia.TabIndex = 8
        '
        'tb_foto
        '
        Me.tb_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_foto.Location = New System.Drawing.Point(542, 155)
        Me.tb_foto.Name = "tb_foto"
        Me.tb_foto.Size = New System.Drawing.Size(129, 22)
        Me.tb_foto.TabIndex = 20000
        Me.tb_foto.Visible = False
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(461, 13)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(211, 22)
        Me.tb_nombre.TabIndex = 2
        '
        'tb_codigointerno
        '
        Me.tb_codigointerno.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigointerno.Location = New System.Drawing.Point(128, 36)
        Me.tb_codigointerno.Name = "tb_codigointerno"
        Me.tb_codigointerno.Size = New System.Drawing.Size(130, 22)
        Me.tb_codigointerno.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(49, 603)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 23)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "(*)ABC:"
        Me.Label21.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(422, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Foto:"
        Me.Label10.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 611)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 23)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Cantidad Vendida:"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "(*) Modelos:"
        Me.Label9.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "(*)Código Interno:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Marca Producto:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Precio de Venta:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 23)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cant. Existencia:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "(*)Nombre:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 23)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Costo promedio:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 23)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "(*) Marca del Carro:"
        Me.Label13.Visible = False
        '
        'SpconsultaClienteBindingSource
        '
        Me.SpconsultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.SpconsultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'SpconsultaCodigoArancelarioBindingSource
        '
        Me.SpconsultaCodigoArancelarioBindingSource.DataMember = "sp_consultaCodigoArancelario"
        Me.SpconsultaCodigoArancelarioBindingSource.DataSource = Me.MELDataSetBindingSource1
        '
        'MELDataSetBindingSource1
        '
        Me.MELDataSetBindingSource1.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource1.Position = 0
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 4
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
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
        Me.ToolBar1.Location = New System.Drawing.Point(3, 7)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(336, 67)
        Me.ToolBar1.TabIndex = 21
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos de Imágenes|*.jpg"
        Me.OpenFileDialog1.Title = "Explorador de Archivos"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodigoProductoFDataGridViewTextBoxColumn, Me.Oculto, Me.PorComplementar})
        Me.DGV_Productos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV_Productos.DataSource = Me.SpconsultaProductoFBindingSource
        Me.DGV_Productos.EnableHeadersVisualStyles = False
        Me.DGV_Productos.Location = New System.Drawing.Point(10, 140)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(337, 526)
        Me.DGV_Productos.TabIndex = 10000
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo Interno"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 190
        '
        'CodigoProductoFDataGridViewTextBoxColumn
        '
        Me.CodigoProductoFDataGridViewTextBoxColumn.DataPropertyName = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.HeaderText = "CodigoProductoF"
        Me.CodigoProductoFDataGridViewTextBoxColumn.Name = "CodigoProductoFDataGridViewTextBoxColumn"
        Me.CodigoProductoFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoProductoFDataGridViewTextBoxColumn.Visible = False
        '
        'Oculto
        '
        Me.Oculto.DataPropertyName = "Oculto"
        Me.Oculto.HeaderText = "Oculto"
        Me.Oculto.Name = "Oculto"
        Me.Oculto.ReadOnly = True
        Me.Oculto.Visible = False
        '
        'PorComplementar
        '
        Me.PorComplementar.DataPropertyName = "PorComplementar"
        Me.PorComplementar.HeaderText = "PorComplementar"
        Me.PorComplementar.Name = "PorComplementar"
        Me.PorComplementar.ReadOnly = True
        Me.PorComplementar.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem1.Text = "Crear igual"
        '
        'SpconsultaProductoFBindingSource
        '
        Me.SpconsultaProductoFBindingSource.DataMember = "sp_consultaProductoF"
        Me.SpconsultaProductoFBindingSource.DataSource = Me.MELDataSet
        '
        'Table_AlmacenTableAdapter
        '
        Me.Table_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'SpconsultaProductoBindingSource
        '
        Me.SpconsultaProductoBindingSource.DataMember = "sp_consultaProducto"
        Me.SpconsultaProductoBindingSource.DataSource = Me.MELDataSetBindingSource
        '
        'Sp_consultaProductoTableAdapter
        '
        Me.Sp_consultaProductoTableAdapter.ClearBeforeFill = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(10, 79)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(174, 23)
        Me.DomainUpDown1.TabIndex = 10001
        '
        'Sp_consultaCodigoArancelarioTableAdapter
        '
        Me.Sp_consultaCodigoArancelarioTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaMarcaTableAdapter
        '
        Me.Sp_consultaMarcaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_FabricaTableAdapter
        '
        Me.Tbl_FabricaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_ModeloTableAdapter
        '
        Me.Tbl_ModeloTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaCodigosInternosTableAdapter
        '
        Me.Sp_consultaCodigosInternosTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaProductoFTableAdapter
        '
        Me.Sp_consultaProductoFTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaClienteTableAdapter
        '
        Me.Sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'rb_porC
        '
        Me.rb_porC.AutoSize = True
        Me.rb_porC.Location = New System.Drawing.Point(3, 6)
        Me.rb_porC.Name = "rb_porC"
        Me.rb_porC.Size = New System.Drawing.Size(133, 19)
        Me.rb_porC.TabIndex = 10002
        Me.rb_porC.Text = "Por complementar"
        Me.rb_porC.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Location = New System.Drawing.Point(142, 6)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(61, 19)
        Me.rb_todos.TabIndex = 10003
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rb_porC)
        Me.Panel2.Controls.Add(Me.rb_todos)
        Me.Panel2.Location = New System.Drawing.Point(10, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 31)
        Me.Panel2.TabIndex = 10004
        '
        'Frm_Productos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 699)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupbox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Productos"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        CType(Me.SpconsultaCodigosInternosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblModeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_codigoFabrica.ResumeLayout(False)
        Me.gb_codigoFabrica.PerformLayout()
        CType(Me.TblFabricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Direccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CodigoP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Seleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Direccion.ResumeLayout(False)
        Me.gb_Direccion.PerformLayout()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Modelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaCodigoArancelarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SpconsultaProductoFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_Productos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If compras Then
            frm.Enabled = True
            frm.DGV_Productos.Rows(indice).Cells(0).Selected = True
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Try
            MELDataSet.EnforceConstraints = False
            Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
            Me.Sp_consultaProductoFTableAdapter.Fill(Me.MELDataSet.sp_consultaProductoF, "Todos")
            Me.Sp_consultaCodigosInternosTableAdapter.Fill(Me.MELDataSet.sp_consultaCodigosInternos)
            'TODO: This line of code loads data into the 'MELDataSet.Tbl_Fabrica' table. You can move, or remove it, as needed.
            Me.Tbl_FabricaTableAdapter.Fill(Me.MELDataSet.Tbl_Fabrica, 0)
            'TODO: This line of code loads data into the 'MELDataSet.Tbl_Modelo' table. You can move, or remove it, as needed.
            Me.Tbl_ModeloTableAdapter.Fill(Me.MELDataSet.Tbl_Modelo, "", 0)
            'TODO: This line of code loads data into the 'MELDataSet.sp_consultaMarca' table. You can move, or remove it, as needed.
            Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
        Catch ex As Exception
        End Try
        Me.tb_cantidadexistencia.ReadOnly = True
        Me.tb_cantidadvendida.ReadOnly = True
        Me.tb_clasificacion.ReadOnly = True
        Me.tb_codigoarancelario.Enabled = False
        Me.tb_codigointerno.ReadOnly = True
        Me.tb_costopromedio.ReadOnly = True
        Me.tb_foto.ReadOnly = True
        Me.cb_marcproducto.ReadOnly = True
        Me.cb_nombre.Enabled = False
        Me.cb_marc.Enabled = False
        Me.cb_model.Enabled = False
        Me.DGV_Modelo.Enabled = False
        Me.bt_agregar.Enabled = False
        Me.bt_quitar.Enabled = False
        Me.tb_nombre.ReadOnly = True
        Me.tb_precioventa.ReadOnly = True
        Me.bt_foto.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        DatosProducto.consulta_arancelarios(Me.tb_codigoarancelario)
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.Items.Add("Código Proveedor")
        Me.DomainUpDown1.SelectedIndex = 0
        Me.tb_nombre.Visible = False
        swload = True
        sww = True
        DGV_Productos.ClearSelection()

        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If

        Me.Label2.Text = Me.SpconsultaProductoFBindingSource.Count
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            If swC = True Then
                swC = False
                If num = 0 Then
                    'Frm_Principal.Frm_Compras.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Compras.bt_actualizar))
                    'Frm_Principal.Frm_Compras.refresca_lvproductos(indice)
                Else
                    'Frm_Principal.Frm_Ventas.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Ventas.bt_actualizar))
                    'Frm_Principal.Frm_Ventas.refresca_lvproductos(indice)
                End If
            End If
            If swX Then
                swX = False
                'Frm_Principal.Frm_Compras.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Compras.bt_actualizar))
            ElseIf swY Then
                swY = False
                'Frm_Principal.Frm_Ventas.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Frm_Principal.Frm_Ventas.bt_actualizar))
            End If

            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then
            varboton = 1
            Me.DGV_CodigoP.Location = New System.Drawing.Point(4, 562)
            'DatosProducto.consulta_proveedores(cb_proveedor)
            'If cb_proveedor.Items.Count > 0 Then
            '    cb_proveedor.SelectedIndex = 0
            'End If
            tb_empaque.Enabled = True
            tb_observacion.Enabled = True
            bt_foto.Visible = True
            tb_OEM.Clear()
            tb_Var1.Clear()
            Chk_PorC.Enabled = True
            tb_Var2.Clear()
            Me.gb_codigoFabrica.Visible = True
            Label10.Visible = True
            tb_foto.Visible = True
            bt_quitar.Visible = True
            bt_agregar.Visible = True
            Panel2.Enabled = False
            cont = 0
            DGV_Modelo.Visible = True
            gb_Direccion.Visible = True
            cb_marc.Visible = True
            cb_marc.ReadOnly = False
            Me.chk_oculto.Enabled = True
            Me.chk_oculto.Checked = False
            cb_model.Visible = True
            Label13.Visible = True
            Label9.Visible = True
            Label15.Text = "Modelos Seleccionados:"
            DGV_Direccion.Rows.Clear()
            tb_OEM.Enabled = True
            tb_info.Enabled = True
            tb_Var1.Enabled = True
            tb_Var2.Enabled = True
            gb_Direccion.Enabled = True
            Me.DGV_Modelo.Enabled = True
            Me.DGV_Seleccionados.Enabled = True
            Me.bt_agregar.Enabled = True
            Me.bt_quitar.Enabled = True
            Me.tb_nombre.Visible = False
            Me.cb_nombre.Enabled = True
            Me.tb_cantidadexistencia.Clear()
            Me.tb_codigoarancelario.ResetText()
            Me.tb_codigointerno.Clear()
            Me.tb_costopromedio.Clear()
            Me.tb_foto.Clear()
            Me.cb_marcproducto.Clear()
            Me.tb_nombre.Clear()
            Me.tb_precioventa.Clear()
            Me.DGV_Productos.Enabled = False
            Me.DomainUpDown1.Enabled = False
            Me.tb_buscarcodigo.Enabled = False
            Me.ToolBar1.Enabled = False
            Me.tb_clasificacion.ReadOnly = False
            Me.tb_codigoarancelario.Enabled = True
            Me.tb_codigointerno.Enabled = True
            Me.tb_codigointerno.ReadOnly = False
            Me.tb_foto.ReadOnly = False
            Me.cb_marcproducto.ReadOnly = False
            Me.tb_nombre.ReadOnly = False
            Me.bt_foto.Enabled = True
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            'Me.cb_nombre.Focus()
            Me.DGV_Seleccionados.Rows.Clear()
            Me.cb_marc.Enabled = True
            cb_marc.Text = "- Selecciona -"
            Me.cb_model.Enabled = True
            cb_model.Text = "- Selecciona -"
            cb_proveedor.Text = "- Selecciona -"
            Me.DGV_Productos.ClearSelection()
            Me.DGV_CodigoP.Rows.Clear()
            SpconsultaCodigosInternosBindingSource.RemoveFilter()
            lb_nombre.Visible = True
            cb_nombre.Clear()
            'lb_nombre.SelectedIndex = 0
            cb_nombre.Focus()
        ElseIf e.Button Is Me.bt_modificar Then
            varboton = 2
            CodI = tb_codigointerno.Text
            Dim n1 As Integer
            n1 = Me.DGV_Productos.SelectedRows.Count
            If n1 = 1 Then
                Me.gb_codigoFabrica.Visible = True
                cb_proveedor.Text = ""
                Panel2.Enabled = False
                'DatosProducto.consulta_proveedores(cb_proveedor)
                'If cb_proveedor.Items.Count > 0 Then
                '    cb_proveedor.SelectedIndex = 0
                'End If
                Me.DGV_CodigoP.Location = New System.Drawing.Point(4, 562)
                tb_empaque.Enabled = True
                tb_observacion.Enabled = True
                bt_foto.Visible = True
                Label10.Visible = True
                Me.chk_oculto.Enabled = True
                Chk_PorC.Enabled = True
                tb_foto.Visible = True
                bt_quitar.Visible = True
                bt_agregar.Visible = True
                tb_info.Enabled = True
                Button2.Visible = True
                DGV_Modelo.Visible = True
                gb_Direccion.Visible = True
                cb_marc.Visible = True
                cb_model.Visible = True
                Label13.Visible = True
                Label9.Visible = True
                Label15.Text = "Modelos Seleccionados:"
                Button1.Visible = True
                tb_OEM.Enabled = True
                tb_Var1.Enabled = True
                tb_Var2.Enabled = True
                Me.cb_nombre.Enabled = True
                Me.DGV_Productos.Enabled = False
                Me.DomainUpDown1.Enabled = False
                Me.tb_buscarcodigo.Enabled = False
                Me.ToolBar1.Enabled = False
                'Me.tb_cantidadexistencia.ReadOnly = False                
                Me.tb_clasificacion.ReadOnly = False
                Me.tb_codigoarancelario.Enabled = True
                Me.tb_codigointerno.Enabled = False                
                'Me.tb_costopromedio.ReadOnly = False
                Me.tb_foto.ReadOnly = False
                Me.cb_marcproducto.ReadOnly = False
                Me.tb_nombre.ReadOnly = False
                Me.bt_foto.Enabled = True
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                'DatosProducto.consulta_codigosInternos(Me.cb_Nombre)
                'DatosProducto.consulta_Marca(Me.cb_marc, "")
                Me.cb_marc.Enabled = True
                Me.cb_model.Enabled = True
                Me.DGV_Modelo.Enabled = True
                Me.DGV_Seleccionados.Enabled = True
                Me.bt_agregar.Enabled = True
                Me.bt_quitar.Enabled = True
                gb_Direccion.Enabled = True
                cb_model.Text = "- Selecciona -"
                cb_proveedor.Text = "- Selecciona -"
                cb_marc.Text = "- Selecciona -"
                cont = 0
            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el producto que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Solo puede modificar un producto a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            varboton = 3
            Dim var As Integer = 0
            Dim s As String = ""
            Dim n As Integer
            Dim response As MsgBoxResult
            Dim cod As String
            n = Me.DGV_Productos.SelectedRows.Count
            If n = 0 Then
                response = MsgBox("Debe seleccionar el producto que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            ElseIf n = 1 Then
                cod = Me.DGV_Productos.SelectedRows(0).Cells(0).Value
                response = MsgBox("¿Confirma que desea eliminar el producto '" + cod + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    DatosProducto.evalua_eliminaproducto(cod, var, s)
                    If var = 0 Then
                        DatosProducto.elimina_producto(cod)

                        MsgBox("El Producto '" + cod + "' Ha Sido Eliminado Exitosamente")
                        Me.DGV_Productos.ClearSelection()
                        Me.tb_buscarcodigo.Text = ""
                        Me.tb_buscarcodigo.Focus()
                        Me.Sp_consultaProductoFTableAdapter.Fill(Me.MELDataSet.sp_consultaProductoF, "Todos")
                        Me.tb_codigoarancelario.ResetText()
                        Me.tb_codigoarancelario.Items.Clear()
                        Me.tb_codigointerno.Clear()
                        Me.cb_marcproducto.Clear()
                        Me.tb_nombre.Clear()
                        Me.tb_cantidadexistencia.Clear()
                        Me.tb_precioventa.Clear()
                        Me.tb_clasificacion.Clear()
                        Me.tb_costopromedio.Clear()
                        Me.tb_foto.Clear()
                        PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
                    ElseIf var = 2 Then
                        response = MsgBox("El Producto Tiene Existencia en Almacén. ¿Está Seguro de Eliminarlo?", MsgBoxStyle.YesNo)
                        If response = MsgBoxResult.Yes Then
                            DatosProducto.elimina_producto(cod)
                            MsgBox("El Producto Ha Sido Eliminado Exitosamente")
                            Me.DGV_Productos.ClearSelection()
                            Me.tb_buscarcodigo.Text = ""
                            Me.tb_buscarcodigo.Focus()
                            Me.tb_codigoarancelario.ResetText()
                            Me.tb_codigoarancelario.Items.Clear()
                            Me.tb_codigointerno.Clear()
                            Me.cb_marcproducto.Clear()
                            Me.tb_nombre.Clear()
                            Me.tb_cantidadexistencia.Clear()
                            Me.tb_precioventa.Clear()
                            Me.tb_clasificacion.Clear()
                            Me.tb_costopromedio.Clear()
                            Me.tb_cantidadvendida.Clear()
                            Me.tb_foto.Clear()
                            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
                        End If
                    Else
                        MsgBox(s)
                    End If
                End If
            Else
                response = MsgBox("¿Confirma que desea eliminar estos (" + n.ToString + ") productos?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then

                    Dim i As Integer = 0
                    Dim switch As Boolean = False
                    Dim acum_elim As Integer = 0
                    While i < Me.DGV_Productos.SelectedRows.Count
                        var = 0
                        cod = Me.DGV_Productos.SelectedRows(i).Cells(0).Value
                        DatosProducto.evalua_eliminaproducto(cod, var, s)
                        If var = 0 Then
                            DatosProducto.elimina_producto(cod)
                            switch = True
                            acum_elim = acum_elim + 1
                        ElseIf var = 2 Then
                            response = MsgBox("El Producto Tiene Existencia en Almacén. ¿Está Seguro de Eliminarlo?", MsgBoxStyle.YesNo)
                            If response = MsgBoxResult.Yes Then
                                DatosProducto.elimina_producto(cod)
                                switch = True
                                acum_elim = acum_elim + 1
                            End If
                        Else
                            Dim s2 As String = "El Producto '" + CStr(cod) + "' no se Puede Eliminar. "
                            s2 = s2 + s
                            MsgBox(s2)
                        End If
                        i = i + 1
                    End While
                    If switch Then
                        If acum_elim = 1 Then
                            MsgBox("El producto ha sido eliminado exitosamente.")
                        Else
                            MsgBox("Se han eliminado los productos Exitosamente")
                        End If
                    End If
                    Me.DGV_Productos.ClearSelection()
                    Me.tb_buscarcodigo.Text = ""
                    Me.tb_buscarcodigo.Focus()
                    Me.tb_codigoarancelario.ResetText()
                    Me.tb_codigoarancelario.Items.Clear()
                    Me.tb_codigointerno.Clear()
                    Me.cb_marcproducto.Clear()
                    Me.tb_nombre.Clear()
                    Me.tb_cantidadexistencia.Clear()
                    Me.tb_precioventa.Clear()
                    Me.tb_clasificacion.Clear()
                    Me.tb_costopromedio.Clear()
                    Me.tb_cantidadvendida.Clear()
                    Me.tb_foto.Clear()
                    PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")

                End If
            End If

            Me.DGV_Productos.ClearSelection()
        End If
    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click


        If compras Then

            Me.Close()

        End If

        SpconsultaProductoFBindingSource.Filter = ""
        Dim busqueda As String
        busqueda = tb_buscarcodigo.Text
        PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        tb_empaque.Enabled = False
        tb_observacion.Enabled = False
        bt_foto.Visible = False
        Label10.Visible = False
        tb_foto.Visible = False
        bt_quitar.Visible = False
        bt_agregar.Visible = False
        DGV_Modelo.Visible = False
        gb_Direccion.Visible = False
        Panel2.Enabled = True
        cb_marc.Visible = False
        cb_model.Visible = False
        Label13.Visible = False
        Label9.Visible = False
        OEM = ""
        tb_OEM.Enabled = False
        Button2.Visible = False
        Chk_PorC.Enabled = False
        lb_nombre.Visible = False
        Button1.Visible = False
        tb_info.Enabled = False
        tb_info.Clear()
        cambio2 = False
        presionado2 = False
        tb_costopromedio.Enabled = False
        tb_costopromedio.ReadOnly = True
        tb_Var1.Enabled = False
        tb_Var2.Enabled = False
        lb_marca.Visible = False
        lb_modelo.Visible = False
        Me.chk_oculto.Enabled = False
        Me.chk_oculto.Checked = False
        Me.DGV_Productos.Enabled = True
        Me.DomainUpDown1.Enabled = True
        Me.tb_buscarcodigo.Enabled = True
        Me.tb_codigoFabrica.Clear()
        Me.cb_proveedor.ResetText()
        Me.ToolBar1.Enabled = True
        Me.tb_cantidadexistencia.Clear()
        Me.cb_marc.Text = ""
        Me.cb_model.Text = ""
        Me.tb_cantidadvendida.Clear()
        Me.tb_clasificacion.Clear()
        Me.tb_codigoarancelario.ResetText()
        Me.cb_proveedor.ResetText()
        Me.tb_codigointerno.Clear()
        Me.tb_costopromedio.Clear()
        Me.tb_foto.Clear()
        Me.cb_marcproducto.Clear()
        Me.tb_nombre.Clear()
        Me.tb_precioventa.Clear()
        Me.tb_cantidadexistencia.ReadOnly = True
        Me.tb_cantidadvendida.ReadOnly = True
        Me.gb_codigoFabrica.Visible = False
        Me.DGV_CodigoP.ClearSelection()
        Me.tb_clasificacion.ReadOnly = True
        Me.tb_codigoarancelario.Enabled = False
        Me.tb_codigointerno.ReadOnly = True
        Me.tb_costopromedio.ReadOnly = True
        Me.tb_foto.ReadOnly = True
        cont = 0
        Me.cb_marcproducto.ReadOnly = True
        Me.tb_nombre.ReadOnly = True
        Me.tb_precioventa.ReadOnly = True
        Me.bt_foto.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.bt_agregar.Enabled = False
        Me.bt_quitar.Enabled = False
        Me.DGV_Modelo.Rows.Clear()
        Me.DGV_Seleccionados.Rows.Clear()
        Me.DomainUpDown1.SelectedItem = 1
        Me.tb_buscarcodigo.Text = ""
        Me.cb_marc.Enabled = False
        Me.cb_model.Enabled = False
        Me.tb_buscarcodigo.Focus()
        'Me.cb_nombre.Items.Clear()
        Me.cb_nombre.Text = ""
        Me.cb_nombre.Enabled = False
        Me.tb_nombre.Visible = False
        gb_Direccion.Enabled = False
        Me.DGV_CodigoP.Rows.Clear()
        tb_Var1.Clear()
        tb_Var2.Clear()
        tb_observacion.Clear()
        tb_OEM.Clear()
        DGV_Direccion.Rows.Clear()
        DGV_Productos.ClearSelection()
        DGV_CodigoP.Rows.Clear()
        Me.DGV_CodigoP.Location = New System.Drawing.Point(5, 330)
        tb_buscarcodigo.Text = busqueda

    End Sub
    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.cb_nombre.Text = "" Or Me.tb_cantidadexistencia.Text = "" Or Me.tb_precioventa.Text = "" Or Me.tb_clasificacion.Text = "" Or tb_codigointerno.Text = "" Or (DGV_Direccion.Rows.Count = 0 And tb_cantidadexistencia.Text <> "0") Or presionado Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function
    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False
        If tb_costopromedio.Text = "" Then
            tb_costopromedio.Text = 0
        End If
        If tb_precioventa.Text = "" Then
            tb_precioventa.Text = 0
        End If
        If tb_cantidadexistencia.Text = "" Then
            tb_cantidadexistencia.Text = 0
        End If
        If tb_clasificacion.Text = "" Then
            tb_clasificacion.Text = "C"
        End If

        If CDbl(tb_costopromedio.Text) > CDbl(tb_precioventa.Text) Then
            Dim resp As Integer = MsgBox("El costo promedio del artículo es mayor a su precio de venta, desea continar?", MsgBoxStyle.YesNo, "Advertencia")

            If resp = vbYes Then
                If (varboton = 1) Then
                    If llenos() Then
                        MsgBox("Debe ingresar todos los datos requeridos (*) o confirmar el cambio de codigo interno presionando nuevamente el botón de modificación de codigo", MsgBoxStyle.Critical, "Error")
                        deny = True
                    Else
                        Dim codAran As String
                        If Me.tb_codigoarancelario.Text = "Ninguno" Then
                            codAran = "0"
                        Else
                            codAran = Me.tb_codigoarancelario.Text
                        End If
                        Dim name As String
                        If Me.tb_nombre.Text = "" Then
                            name = Me.cb_nombre.Text
                        Else
                            name = Me.tb_nombre.Text
                        End If

                        If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                            '    DatosProducto.inserta_producto_BRWME(Me.tb_codigointerno.Text, codAran, name, Me.cb_marcproducto.Text, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, Me.DGV_Seleccionados, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, deny, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                            'Else
                            DatosProducto.inserta_producto(Me.tb_codigointerno.Text, codAran, name, Me.cb_marcproducto.Text, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, Me.DGV_Seleccionados, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, deny, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                            'End If

                            Dim cont As Integer = 0

                            For cont = 0 To DGV_Direccion.RowCount - 1
                                DatosProducto.InsertarUbicaciones(Me.tb_codigointerno.Text, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)
                            Next
                        Else
                            MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                            deny = True
                    End If

                        If DGV_CodigoP.RowCount > 0 Then

                            For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                                DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                            Next

                        End If



                    End If




                ElseIf (varboton = 2) Then

                    If llenos() Then
                        MsgBox("Debe ingresar todos los datos requeridos (*) o confirmar el cambio de codigo interno presionando nuevamente el botón de modificación de codigo", MsgBoxStyle.Critical, "Error")
                        deny = True
                    Else

                        If DatosProducto.Busca_Producto(tb_codigointerno.Text) And tb_codigointerno.Enabled = True Then
                            MsgBox("El codigo interno ya existe, favor verificar", MsgBoxStyle.Critical)
                            deny = True
                            tb_codigointerno.Focus()
                            tb_codigointerno.SelectAll()
                        Else
                            Dim codA2 As String
                            If Me.tb_codigoarancelario.Text = "Ninguno" Then
                                codA2 = Nothing
                            Else
                                codA2 = Me.tb_codigoarancelario.Text
                            End If
                            Dim name As String
                            If Me.tb_nombre.Text = "" Then
                                name = Me.cb_nombre.Text
                            Else
                                name = Me.tb_nombre.Text
                            End If

                            If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then
                                DatosProducto.EliminarUbicaciones(tb_codigointerno.Text)
                                Dim cont As Integer = 0

                                For cont = 0 To DGV_Direccion.RowCount - 1

                                    DatosProducto.InsertarUbicaciones(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)

                                Next

                                If CodI <> tb_codigointerno.Text Then

                                    'If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 Then
                                    DatosProducto.ModificaCodigoInterno(CodI, tb_codigointerno.Text)
                                    'Else
                                    'DatosProducto.ModificaCodigoInterno_BRWME(CodI, tb_codigointerno.Text)
                                    'End If

                                End If

                                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                '    DatosProducto.modifica_producto_BRWME(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'Else
                                DatosProducto.modifica_producto(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'End If

                                DatosProducto.modificaProveedores(tb_codigointerno.Text)

                                If DGV_CodigoP.RowCount > 0 Then
                                    For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                                        DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                    Next

                                End If

                                MsgBox("Producto Modificado satisfactoriamente", MsgBoxStyle.Information)

                            Else
                                MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                                deny = True
                            End If

                        End If

                    End If

                ElseIf (varboton = 10) Then

                    If llenos() Then
                        MsgBox("Debe ingresar todos los datos requeridos (*) o confirmar el cambio de codigo interno presionando nuevamente el botón de modificación de codigo", MsgBoxStyle.Critical, "Error")
                        deny = True
                    Else

                        If DatosProducto.Busca_Producto(tb_codigointerno.Text) And tb_codigointerno.Enabled = True Then
                            MsgBox("El codigo interno ya existe", MsgBoxStyle.Critical)
                            deny = True
                            tb_codigointerno.Focus()
                            tb_codigointerno.SelectAll()
                        Else
                            Dim codA2 As String
                            If Me.tb_codigoarancelario.Text = "Ninguno" Then
                                codA2 = Nothing
                            Else
                                codA2 = Me.tb_codigoarancelario.Text
                            End If
                            Dim name As String
                            If Me.tb_nombre.Text = "" Then
                                name = Me.cb_nombre.Text
                            Else
                                name = Me.tb_nombre.Text
                            End If

                            If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then
                                DatosProducto.EliminarUbicaciones(DGV_Productos.SelectedRows(0).Cells(0).Value)

                                Dim cont As Integer = 0

                                For cont = 0 To DGV_Direccion.RowCount - 1

                                    DatosProducto.InsertarUbicaciones(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)

                                Next

                                DatosProducto.modificaProveedores(tb_codigointerno.Text)

                                If DGV_CodigoP.RowCount > 0 Then
                                    For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                                        DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                    Next

                                End If

                                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                '    DatosProducto.modifica_producto_BRWME(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'Else
                                DatosProducto.modifica_producto(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'End If

                                If CodI <> tb_codigointerno.Text Then

                                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                    '    DatosProducto.ModificaCodigoInterno_BRWME(CodI, tb_codigointerno.Text)
                                    'Else
                                    DatosProducto.ModificaCodigoInterno(CodI, tb_codigointerno.Text)
                                    'End If

                                    cambio = True

                                End If

                                frm.Pro(True)

                                MsgBox("Producto Modificado satisfactoriamente", MsgBoxStyle.Information)
                            Else
                                MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                                deny = True
                            End If

                        End If

                    End If


                End If

            Else

                deny = True

            End If

        Else

            If (varboton = 1) Then
                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*)", MsgBoxStyle.Critical, "Error")
                    deny = True
                Else
                    Dim codAran As String
                    If Me.tb_codigoarancelario.Text = "Ninguno" Or Me.tb_codigoarancelario.Text = "" Then
                        codAran = "0"
                    Else
                        codAran = Me.tb_codigoarancelario.Text
                    End If
                    Dim name As String
                    If Me.tb_nombre.Text = "" Then
                        name = Me.cb_nombre.Text
                    Else
                        name = Me.tb_nombre.Text
                    End If
                    If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then

                        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                        '    DatosProducto.inserta_producto_BRWME(Me.tb_codigointerno.Text, codAran, name, Me.cb_marcproducto.Text, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, Me.DGV_Seleccionados, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, deny, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                        'Else
                        DatosProducto.inserta_producto(Me.tb_codigointerno.Text, codAran, name, Me.cb_marcproducto.Text, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, Me.DGV_Seleccionados, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, deny, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                        'End If

                        Dim cont As Integer = 0

                        For cont = 0 To DGV_Direccion.RowCount - 1

                            DatosProducto.InsertarUbicaciones(Me.tb_codigointerno.Text, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)

                        Next
                        'insertar_en_bloque(DGV_Direccion)

                    Else
                        MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                        deny = True
                End If

                    If DGV_CodigoP.RowCount > 0 Then

                        For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                            DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                        Next

                    End If



                End If




            ElseIf (varboton = 2) Then

                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*) o confirmar el cambio de codigo interno presionando nuevamente el botón de modificación de codigo", MsgBoxStyle.Critical, "Error")
                    deny = True
                Else

                    If DatosProducto.Busca_Producto(tb_codigointerno.Text) And tb_codigointerno.Enabled = True Then
                        MsgBox("El codigo interno ya existe", MsgBoxStyle.Critical)
                        deny = True
                        tb_codigointerno.Focus()
                        tb_codigointerno.SelectAll()
                    Else
                        Dim codA2 As String
                        If Me.tb_codigoarancelario.Text = "Ninguno" Then
                            codA2 = Nothing
                        Else
                            codA2 = Me.tb_codigoarancelario.Text
                        End If
                        Dim name As String
                        If Me.tb_nombre.Text = "" Then
                            name = Me.cb_nombre.Text
                        Else
                            name = Me.tb_nombre.Text
                        End If

                        If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then

                            If cambio2 = True Then
                                DatosProducto.EliminarUbicaciones(CodI)
                            Else
                                DatosProducto.EliminarUbicaciones(tb_codigointerno.Text)
                            End If

                            Dim cont As Integer = 0

                            For cont = 0 To DGV_Direccion.RowCount - 1

                                If cambio2 = True Then
                                    DatosProducto.InsertarUbicaciones(CodI, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)
                                Else
                                    DatosProducto.InsertarUbicaciones(tb_codigointerno.Text, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)
                                End If

                            Next
                            'insertar_en_bloque(DGV_Productos)

                            If cambio2 Then

                                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                '    DatosProducto.modifica_producto_BRWME(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'Else
                                DatosProducto.modifica_producto(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'End If

                            Else

                                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                '    DatosProducto.modifica_producto_BRWME(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, tb_codigointerno.Text, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'Else
                                DatosProducto.modifica_producto(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, tb_codigointerno.Text, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                                'End If

                            End If

                        If cambio2 Then
                            DatosProducto.modificaProveedores(CodI)
                        Else
                            DatosProducto.modificaProveedores(tb_codigointerno.Text)
                        End If

                        If DGV_CodigoP.RowCount > 0 Then
                            For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                                If cambio2 Then
                                    DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), CodI, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                Else
                                    DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                End If

                            Next

                        End If

                        If CodI <> tb_codigointerno.Text And tb_codigointerno.Enabled = True Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                            '    DatosProducto.ModificaCodigoInterno_BRWME(CodI, tb_codigointerno.Text)
                            'Else
                            DatosProducto.ModificaCodigoInterno(CodI, tb_codigointerno.Text)
                            'End If

                        End If


                        MsgBox("Producto Modificado satisfactoriamente", MsgBoxStyle.Information)
                        Else
                        MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                        deny = True
                    End If

                    End If

                End If

            ElseIf (varboton = 10) Then

                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*) o confirmar el cambio de codigo interno presionando nuevamente el botón de modificación de codigo", MsgBoxStyle.Critical, "Error")
                    deny = True
                Else

                    If DatosProducto.Busca_Producto(tb_codigointerno.Text) And tb_codigointerno.Enabled = True Then
                        MsgBox("El codigo interno ya existe", MsgBoxStyle.Critical)
                        deny = True
                        tb_codigointerno.Focus()
                        tb_codigointerno.SelectAll()
                    Else

                        Dim codA2 As String
                        If Me.tb_codigoarancelario.Text = "Ninguno" Then
                            codA2 = Nothing
                        Else
                            codA2 = Me.tb_codigoarancelario.Text
                        End If
                        Dim name As String
                        If Me.tb_nombre.Text = "" Then
                            name = Me.cb_nombre.Text
                        Else
                            name = Me.tb_nombre.Text
                        End If

                        If SumarCantidades() = CInt(tb_cantidadexistencia.Text) Then
                            DatosProducto.EliminarUbicaciones(DGV_Productos.SelectedRows(0).Cells(0).Value)

                            Dim cont As Integer = 0

                            For cont = 0 To DGV_Direccion.RowCount - 1

                                DatosProducto.InsertarUbicaciones(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Direccion.Rows(cont).Cells(5).Value, DGV_Direccion.Rows(cont).Cells(4).Value)

                            Next

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                            '    DatosProducto.modifica_producto_BRWME(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                            'Else
                            DatosProducto.modifica_producto(codA2, name, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, 0, CodI, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, tb_empaque.Text, tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
                            'End If

                            If cambio2 Then
                                DatosProducto.modificaProveedores(CodI)
                            Else
                                DatosProducto.modificaProveedores(tb_codigointerno.Text)
                            End If

                            If DGV_CodigoP.RowCount > 0 Then
                                For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1
                                    If cambio2 Then
                                        DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), CodI, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                    Else
                                        DatosProducto.InsertarProveedores(CInt(DGV_CodigoP.Rows(cont2).Cells(4).Value), tb_codigointerno.Text, DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString, DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString)
                                    End If

                                Next

                            End If

                            If CodI <> tb_codigointerno.Text And tb_codigointerno.Enabled = True Then

                                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                                '   DatosProducto.ModificaCodigoInterno_BRWME(CodI, tb_codigointerno.Text)
                                'Else
                                DatosProducto.ModificaCodigoInterno(CodI, tb_codigointerno.Text)
                                'End If

                                cambio = True

                            End If

                            frm.Pro(True)

                            MsgBox("Producto Modificado satisfactoriamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("La cantidad total en la ubicaciones no coincide con la cantidad total en existencia", MsgBoxStyle.Critical)
                            deny = True
                    End If

                    End If

                End If


            End If

        End If

        If deny = False Then

            Dim codigo As String = tb_codigointerno.Text


            bt_foto.Visible = False
            Label10.Visible = False
            tb_foto.Visible = False
            DGV_Modelo.Visible = False
            gb_Direccion.Visible = False
            cb_marc.Visible = False
            presionado2 = False
            tb_costopromedio.Enabled = False
            tb_costopromedio.ReadOnly = True
            cb_model.Visible = False
            Label13.Visible = False
            OEM = ""
            lb_marca.Visible = False
            lb_modelo.Visible = False
            lb_nombre.Visible = False
            Label9.Visible = False
            tb_info.Enabled = False
            Chk_PorC.Enabled = False
            tb_empaque.Enabled = False
            tb_observacion.Enabled = False
            Panel2.Enabled = True
            Me.gb_codigoFabrica.Visible = False
            Button2.Visible = False
            Me.DGV_CodigoP.ClearSelection()
            PictureBox1.Image.Dispose()
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            Me.DGV_Productos.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.tb_buscarcodigo.Enabled = True
            Me.ToolBar1.Enabled = True
            tb_info.Clear()
            Me.chk_oculto.Enabled = False
            Me.chk_oculto.Checked = False
            Me.cb_marc.Enabled = False
            tb_observacion.Clear()
            cambio2 = False
            Me.cb_model.Enabled = False
            Me.DGV_Modelo.Enabled = False
            Me.DGV_Seleccionados.Enabled = False
            Me.tb_cantidadexistencia.ReadOnly = True
            Me.tb_cantidadvendida.ReadOnly = True
            Button1.Visible = False
            cont = 0
            Me.tb_codigoFabrica.Clear()
            Me.cb_proveedor.ResetText()
            Me.cb_proveedor.ResetText()
            Me.tb_clasificacion.ReadOnly = True
            Me.tb_codigoarancelario.Enabled = False
            Me.tb_codigointerno.ReadOnly = True
            Me.tb_costopromedio.ReadOnly = True
            Me.tb_foto.ReadOnly = True
            Me.cb_marcproducto.ReadOnly = True
            Me.cb_nombre.Enabled = False
            Me.tb_precioventa.ReadOnly = True
            Me.bt_agregar.Enabled = False
            Me.bt_quitar.Enabled = False
            Me.tb_nombre.Visible = False
            Me.bt_foto.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            gb_Direccion.Enabled = False
            cb_almacen.Text = ""
            cb_cuarto.Text = ""
            cb_estante.Text = ""
            cb_tramo.Text = ""
            tb_cantidad.Text = ""

            Me.cb_model.ResetText()
            Me.cb_marc.ResetText()
            Me.DGV_Modelo.Rows.Clear()
            Me.DGV_Seleccionados.Rows.Clear()
            Me.tb_cantidadexistencia.Clear()
            Me.tb_cantidadvendida.Clear()
            Me.tb_clasificacion.Clear()
            Me.tb_codigoarancelario.ResetText()
            Me.tb_codigointerno.Clear()
            Me.tb_costopromedio.Clear()
            Me.tb_foto.Clear()
            Me.cb_marcproducto.Clear()
            Me.tb_nombre.Clear()
            Me.tb_precioventa.Clear()

            Me.DomainUpDown1.SelectedItem = 1
            If compras = False Then
                Me.Sp_consultaProductoFTableAdapter.Fill(Me.MELDataSet.sp_consultaProductoF, "Todos")
            End If


            Me.cb_nombre.Text = ""
            Me.tb_buscarcodigo.Focus()
            If compras = False Then
                tb_buscar_TextChanged(tb_buscarcodigo, New System.EventArgs)
            End If
            Me.DGV_Direccion.Rows.Clear()

            tb_OEM.Clear()
            tb_Var1.Clear()
            tb_Var2.Clear()
            tb_OEM.Enabled = False
            tb_Var1.Enabled = False
            tb_Var2.Enabled = False
            DGV_Productos.ClearSelection()
            DGV_CodigoP.Rows.Clear()
            Me.DGV_CodigoP.Location = New System.Drawing.Point(5, 330)


            If compras Then

                Me.Close()

            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_foto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.tb_foto.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Me.DGV_Productos.Enabled = True Then
            Dim s1 As String = ""
            sww = False

            If choice = 0 Then
                s1 = "CodigoInterno LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
            ElseIf choice = 1 Then
                s1 = "Nombre LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
            ElseIf choice = 2 Then
                s1 = "CodigoProductoF LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
            End If

            If rb_porC.Checked Then
                s1 = s1 + " AND PorComplementar = 1"
            End If

            SpconsultaProductoFBindingSource.Filter = s1

            Me.tb_cantidadexistencia.Clear()
            Me.tb_cantidadvendida.Clear()
            Me.tb_clasificacion.Clear()
            Me.tb_codigoarancelario.ResetText()
            'Me.tb_codigoarancelario.Items.Clear()
            Me.tb_codigointerno.Clear()
            Me.tb_costopromedio.Clear()
            Me.tb_foto.Clear()
            Me.cb_marcproducto.Clear()
            Me.tb_nombre.Clear()
            Me.tb_precioventa.Clear()
            Me.cb_nombre.Text = ""
            Me.cb_almacen.Text = ""
            Me.cb_cuarto.Text = ""
            Me.tb_OEM.Clear()
            Me.tb_Var1.Clear()
            Me.tb_Var2.Clear()
            Me.cb_tramo.Text = ""
            Me.tb_observacion.Clear()
            Me.tb_empaque.Clear()
            Me.tb_cantidad.Clear()
            DGV_CodigoP.Rows.Clear()
            DGV_Modelo.Rows.Clear()
            DGV_Seleccionados.Rows.Clear()
            DGV_Direccion.Rows.Clear()
            DGV_Productos.ClearSelection()
            Me.Label2.Text = Me.SpconsultaProductoFBindingSource.Count
        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Public Sub abreM(ByVal cod As Integer, ByVal ind As Integer, ByVal n As Integer)
        swC = True
        num = n
        indice = ind
        Dim sw2 As Boolean = False
        Dim cont As Integer = 0
        While (cont <= Me.DGV_Productos.Rows.Count) And (sw2 = False)
            If CInt(Me.DGV_Productos.Rows(cont).Cells(0).Value) = cod Then
                sw2 = True
            Else
                cont = cont + 1
            End If
        End While
        Me.DGV_Productos.Rows(cont).Selected = True
        'DatosProducto.consulta_producto(cod, Me.tb_codigointerno.Text, Me.tb_codigoarancelario, Me.tb_nombre.Text, Me.cb_marcproducto.Text, Me.cb_marccarro.Text, Me.cb_modelcarro.Text, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text)
        Me.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Me.bt_modificar))
    End Sub

    '-------------------------- VALIDACIONES
    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cantidadexistencia.KeyPress, tb_cantidadvendida.KeyPress, tb_costopromedio.KeyPress, tb_precioventa.KeyPress
        If (sender Is Me.tb_costopromedio) Or (sender Is Me.tb_precioventa) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo números y (,)"
            End If
        Else
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números"
            End If
        End If
    End Sub

    Private Sub tb_cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            bt_agregarCuarto_Click(DGV_Direccion, New System.EventArgs)
            tb_cantidad.SelectAll()
        End If
    End Sub

    Private Sub tb_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_cantidad.KeyPress

        If (sender Is Me.tb_cantidad) Then

            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

                e.Handled = False
                muestra_label(sender, 1)

            Else

                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números"

            End If

        End If

    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.Label22.Location = New System.Drawing.Point(c.Location.X - c.Size.Width, c.Location.Y + 400)
            Me.ErrorProvider1.SetIconAlignment(Label22, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.ErrorProvider1.SetIconPadding(Label22, 2)
            Me.ErrorProvider1.SetError(Label22, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_cantidadexistencia.LostFocus, tb_cantidadvendida.LostFocus, tb_costopromedio.LostFocus, tb_precioventa.LostFocus, tb_clasificacion.LostFocus
        muestra_label(sender, 1)
    End Sub

    Private Sub tb_clasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_clasificacion.KeyPress
        If e.KeyChar = "a" Or e.KeyChar = "b" Or e.KeyChar = "c" Or Char.IsControl(e.KeyChar) Or e.KeyChar = "A" Or e.KeyChar = "B" Or e.KeyChar = "C" Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
        Me.Label22.Text = "      Ingrese sólo A,B ó C"
    End Sub
    Public Sub nuevo()
        swX = True
    End Sub
    Public Sub nuevoY()
        swY = True
    End Sub
    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click
        If Me.DGV_Modelo.SelectedRows.Count = 0 Then
            Dim response As MsgBoxResult
            response = MsgBox("Debe seleccionar el/los modelos que desea seleccionar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        Else
            Dim ii As Integer = 0
            Dim jj As Integer = 0
            Dim sw As Boolean = False
            If Not Me.DGV_Modelo.SelectedRows.Count = 0 Then
                While ii < Me.DGV_Modelo.SelectedRows.Count
                    jj = 0
                    While (jj < Me.DGV_Seleccionados.RowCount) And (sw = False)
                        If (Me.DGV_Modelo.SelectedRows(0).Cells(0).Value = Me.DGV_Seleccionados.Rows(jj).Cells(1).Value) And (Me.DGV_Modelo.SelectedRows(0).Cells(1).Value = Me.DGV_Seleccionados.Rows(jj).Cells(2).Value) And (Me.DGV_Modelo.SelectedRows(0).Cells(2).Value = Me.DGV_Seleccionados.Rows(jj).Cells(3).Value) And (Me.DGV_Modelo.SelectedRows(0).Cells(3).Value = Me.DGV_Seleccionados.Rows(jj).Cells(4).Value) And (Me.DGV_Modelo.SelectedRows(0).Cells(4).Value = Me.DGV_Seleccionados.Rows(jj).Cells(5).Value) And (Me.DGV_Modelo.SelectedRows(0).Cells(5).Value = Me.DGV_Seleccionados.Rows(jj).Cells(6).Value) Then
                            sw = True
                        End If
                        jj = jj + 1
                    End While
                    If (sw = False) Then
                        DGV_Seleccionados.Rows.Add(cb_marc.Text, DGV_Modelo.SelectedRows(0).Cells(0).Value, DGV_Modelo.SelectedRows(0).Cells(1).Value, DGV_Modelo.SelectedRows(0).Cells(2).Value, DGV_Modelo.SelectedRows(0).Cells(3).Value, DGV_Modelo.SelectedRows(0).Cells(4).Value, DGV_Modelo.SelectedRows(0).Cells(5).Value)
                    End If
                    ii = ii + 1
                End While
            Else

                MsgBox("Debe seleccionar un modelo", MsgBoxStyle.Critical)

            End If
            Me.DGV_Modelo.ClearSelection()
        End If
    End Sub

    Private Sub bt_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_quitar.Click
        If Me.DGV_Seleccionados.SelectedRows.Count = 0 Then
            Dim response As MsgBoxResult
            response = MsgBox("Debe seleccionar el/los modelos que desea quitar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        Else
            Dim i As Integer = 0
            Dim i_s As Integer = Me.DGV_Seleccionados.SelectedRows.Count
            While i < i_s
                Me.DGV_Seleccionados.Rows.Remove(Me.DGV_Seleccionados.SelectedRows.Item(0))
                i = i + 1
            End While
        End If
    End Sub


    Public Sub DGV_Productos_selection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Productos.CellClick, DGV_Productos.KeyUp, DGV_Productos.KeyDown
        Try
            Dim cod As String
            cod = Me.DGV_Productos.SelectedRows(0).Cells(0).Value
            Me.DGV_Seleccionados.Rows.Clear()
            DatosProducto.consulta_producto(cod, Me.tb_codigointerno.Text(), Me.tb_codigoarancelario, Me.cb_nombre.Text, Me.cb_marcproducto.Text, Me.DGV_Seleccionados, Me.tb_foto.Text, Me.tb_cantidadexistencia.Text, Me.tb_precioventa.Text, Me.tb_costopromedio.Text, Me.tb_clasificacion.Text, Me.tb_cantidadvendida.Text, tb_OEM.Text, tb_Var1.Text, tb_Var2.Text, Me.tb_empaque.Text, Me.tb_observacion.Text, chk_oculto.Checked, tb_info.Text, Chk_PorC.Checked)
            DatosProducto.Llenar_DGV_por_id(DGV_Productos.SelectedRows(0).Cells(0).Value, DGV_Direccion)
            DatosProducto.consulta_codigoProductoF(Me.DGV_CodigoP, tb_codigointerno.Text)
            DGV_Direccion.ClearSelection()
            DGV_CodigoP.ClearSelection()
            DGV_Seleccionados.ClearSelection()
            Try
                Me.PictureBox1.Image = Image.FromFile(Me.tb_foto.Text)
            Catch
                PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            End Try

        Catch ex As Exception
            'DGV_Productos.ClearSelection()
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedValueChanged

        DatosProducto.llenar_cuartos(cb_cuarto, cb_almacen.SelectedValue)

    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedValueChanged

        DatosProducto.llenar_estantes(cb_estante, cb_cuarto.SelectedValue)

    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedValueChanged

        DatosProducto.llenar_tramos(cb_tramo, cb_estante.SelectedValue)

    End Sub

    Public Sub SeleccionarElementoEnCombos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Direccion.KeyUp, DGV_Direccion.KeyDown, DGV_Direccion.CellClick

        Try

            If DGV_Direccion.SelectedRows.Count > 0 Then
                cb_almacen.Text = DGV_Direccion.SelectedRows(0).Cells(0).Value
                cb_cuarto.Text = DGV_Direccion.SelectedRows(0).Cells(1).Value
                cb_estante.Text = DGV_Direccion.SelectedRows(0).Cells(2).Value
                cb_tramo.Text = DGV_Direccion.SelectedRows(0).Cells(3).Value
                tb_cantidad.Text = DGV_Direccion.SelectedRows(0).Cells(4).Value
            End If

        Catch ex As Exception

        End Try

    End Sub




    Private Sub bt_agregarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCuarto.Click


        If cb_almacen.Text <> "" And cb_cuarto.Text <> "" And cb_estante.Text <> "" And cb_tramo.Text <> "" And tb_cantidad.Text <> "" Then

            If EstaEnDGV() Then

                MsgBox("La ubicación ya existe, haga las modificaciones correspondientes", MsgBoxStyle.Critical)

            Else

                DGV_Direccion.Rows.Add(cb_almacen.Text, cb_cuarto.Text, cb_estante.Text, cb_tramo.Text, tb_cantidad.Text, cb_tramo.SelectedValue)

            End If


        Else

            MsgBox("Existe un campo obligatorio vacío", MsgBoxStyle.Critical)

        End If

        DGV_Direccion.ClearSelection()

    End Sub


    Public Function EstaEnDGV() As Boolean

        Try

            Dim esta As Boolean = False

            Dim cont As Integer = 0


            For cont = 0 To DGV_Direccion.RowCount - 1

                If DGV_Direccion.Rows(cont).Cells(0).Value = cb_almacen.Text And DGV_Direccion.Rows(cont).Cells(1).Value = cb_cuarto.Text And DGV_Direccion.Rows(cont).Cells(2).Value = cb_estante.Text And DGV_Direccion.Rows(cont).Cells(3).Value = cb_tramo.Text Then

                    esta = True

                End If

            Next


            Return esta

        Catch ex As Exception

        End Try

    End Function

    Public Sub ModificarDGV_Direccion(ByVal tipo As Integer)

        Try

            For cont As Integer = 0 To DGV_Direccion.RowCount - 1

                If DGV_Direccion.Rows(cont).Cells(0).Value = cb_almacen.Text And DGV_Direccion.Rows(cont).Cells(1).Value = cb_cuarto.Text And DGV_Direccion.Rows(cont).Cells(2).Value = cb_estante.Text And DGV_Direccion.Rows(cont).Cells(3).Value = cb_tramo.Text Then

                    If tipo = 0 Then

                        DGV_Direccion.Rows(cont).Cells(0).Value = cb_almacen.Text
                        DGV_Direccion.Rows(cont).Cells(1).Value = cb_cuarto.Text
                        DGV_Direccion.Rows(cont).Cells(2).Value = cb_estante.Text
                        DGV_Direccion.Rows(cont).Cells(3).Value = cb_tramo.Text
                        DGV_Direccion.Rows(cont).Cells(4).Value = CInt(tb_cantidad.Text) + CInt(DGV_Direccion.Rows(cont).Cells(4).Value)
                        DGV_Direccion.Rows(cont).Cells(5).Value = CInt(cb_tramo.SelectedValue)

                    Else
                        DGV_Direccion.Rows(cont).Cells(0).Value = cb_almacen.Text
                        DGV_Direccion.Rows(cont).Cells(1).Value = cb_cuarto.Text
                        DGV_Direccion.Rows(cont).Cells(2).Value = cb_estante.Text
                        DGV_Direccion.Rows(cont).Cells(3).Value = cb_tramo.Text
                        DGV_Direccion.Rows(cont).Cells(4).Value = CInt(tb_cantidad.Text)
                        DGV_Direccion.Rows(cont).Cells(5).Value = CInt(cb_tramo.SelectedValue)

                    End If



                End If

            Next


        Catch ex As Exception

        End Try

    End Sub

    Private Sub bt_ModificarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarCuarto.Click

        Try

            If DGV_Direccion.SelectedRows.Count > 0 Then

                If cb_almacen.Text <> "" And cb_cuarto.Text <> "" And cb_estante.Text <> "" And cb_tramo.Text <> "" And tb_cantidad.Text <> "" Then

                    If EstaEnDGV() Then

                        Dim ubi As Integer = DGV_Direccion.SelectedRows(0).Index
                        If cb_almacen.Text = DGV_Direccion.SelectedRows(0).Cells(0).Value And cb_cuarto.Text = DGV_Direccion.SelectedRows(0).Cells(1).Value And cb_estante.Text = DGV_Direccion.SelectedRows(0).Cells(2).Value And cb_tramo.Text = DGV_Direccion.SelectedRows(0).Cells(3).Value Then
                            ModificarDGV_Direccion(1)
                        Else
                            ModificarDGV_Direccion(0)
                            DGV_Direccion.Rows.RemoveAt(ubi)
                        End If


                    Else

                        DGV_Direccion.SelectedRows(0).Cells(0).Value = cb_almacen.Text
                        DGV_Direccion.SelectedRows(0).Cells(1).Value = cb_cuarto.Text
                        DGV_Direccion.SelectedRows(0).Cells(2).Value = cb_estante.Text
                        DGV_Direccion.SelectedRows(0).Cells(3).Value = cb_tramo.Text
                        DGV_Direccion.SelectedRows(0).Cells(4).Value = tb_cantidad.Text
                        DGV_Direccion.SelectedRows(0).Cells(5).Value = CInt(cb_tramo.SelectedValue)

                    End If

                    DGV_Direccion.ClearSelection()

                Else

                    MsgBox("Existe un campo obligatorio vacío", MsgBoxStyle.Critical)

                End If

            Else

                MsgBox("Debe seleccionar una ubiación para modificar", MsgBoxStyle.Exclamation, "Error")

            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub bt_eliminarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCuarto.Click

        Dim cont As Integer = 0


        If DGV_Direccion.SelectedRows.Count > 0 Then

            DGV_Direccion.Rows.RemoveAt(DGV_Direccion.CurrentRow.Index)
            tb_cantidad.Clear()
            SeleccionarElementoEnCombos(DGV_Direccion, New EventArgs)


        Else

            MsgBox("Debe seleccionar una ubicación a eliminar", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub


    Public Function SumarCantidades() As Integer

        Try

            Dim Cantidad As Integer = 0
            Dim Cont As Integer = 0


            For Cont = 0 To DGV_Direccion.RowCount - 1

                Cantidad = Cantidad + DGV_Direccion.Rows(Cont).Cells(4).Value

            Next

            Return Cantidad

        Catch ex As Exception


        End Try

    End Function

    Public Function CopiarOEM() As String Handles tb_OEM.Enter, tb_OEM.Click

        OEM = tb_OEM.Text
        tb_OEM.Focus()
        tb_OEM.SelectAll()
        Return OEM

    End Function

    Public Sub Variante() Handles tb_OEM.TextChanged

        If OEM <> "" Then
            tb_Var1.Text = OEM
        End If

        OEM = ""

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If presionado Then
            tb_codigointerno.Enabled = True
            tb_codigointerno.ReadOnly = True
            presionado = False
            cambio2 = True
        Else
            Dim resp As Integer = MsgBox("Esta opción cambiará el codigo interno del producto asi como sus relaciones en facturas, pedidos, ect. Desea continuar?", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                tb_codigointerno.Enabled = True
                tb_codigointerno.ReadOnly = False
                presionado = True
            End If

        End If
    End Sub

    Private Sub tb_codigointerno_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_codigointerno.Enter
        If cont = 0 Then
            CodI = tb_codigointerno.Text
        End If
        cont = cont + 1
    End Sub

    Public Function Buscar_Elemento_En_DGV(ByVal Nombre As String, ByVal DGV As DataGridView, ByVal tipo As Integer) As Boolean

        Try

            Dim Cont As Integer = 0
            Dim retorno As Boolean = False

            If DGV.Rows(0).Cells(tipo).Value.ToString.ToUpper = Nombre.ToUpper Then
                retorno = True
            End If

            For Cont = 0 To DGV.Rows.Count - 1

                If DGV.Rows(Cont).Cells(tipo).Value.ToString.ToUpper = Nombre.ToUpper Then
                    retorno = True
                End If

            Next

            Return retorno

        Catch ex As Exception


        End Try

    End Function

    Public Sub clear() Handles DGV_Productos.ColumnHeaderMouseClick

        DGV_Productos.ClearSelection()

    End Sub


    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyData = Keys.Enter Then

            If DGV_Productos.RowCount > 0 Then
                Me.DGV_Productos.Rows(0).Cells(0).Selected = True
                DGV_Productos.Focus()
            End If

        End If

    End Sub

    Private Sub tb_foto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_foto.TextChanged

        Try
            Me.PictureBox1.Image = Image.FromFile(Me.tb_foto.Text)
        Catch
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        End Try

    End Sub

    Public Sub recibeDGV(ByVal a As String, ByVal b As String, ByRef frm2 As Frm_Compras, ByVal index As Integer, ByVal orden As System.ComponentModel.ListSortDirection, ByVal ind As Integer)

        frm = frm2
        'productosCompras = frm2.DGV_Productos
        text1 = a
        text2 = b
        If frm2.DGV_Productos.SortedColumn IsNot Nothing Then
            ordendgv = frm2.DGV_Productos.SortedColumn.Index
        End If

        orden2 = frm2.DGV_Productos.SortOrder
        indice = ind
        Button1.Visible = False

    End Sub


    Private Sub bt_agregarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCF.Click

        If cb_proveedor.Text <> "" Then

            If tb_codigoFabrica.Text <> "" Then

                If DatosProducto.verifica_Codigo_Fabrica(tb_codigoFabrica.Text, CInt(cb_proveedor.Tag.ToString)) = False Then

                    Dim esta1 As Boolean = False
                    Dim esta2 As Boolean = False
                    Dim esta3 As Boolean = False
                    Dim entro As Boolean = False


                    For cont2 As Integer = 0 To DGV_CodigoP.RowCount - 1

                        If cont2 > DGV_CodigoP.RowCount - 1 Then
                            cont2 = cont2 - 1
                        End If
                        If ((DGV_CodigoP.Rows(cont2).Cells(4).Value.ToString = cb_proveedor.Tag.ToString)) And (DGV_CodigoP.Rows(cont2).Cells(1).Value.ToString = tb_codigoFabrica.Text) Then

                            esta1 = True
                            cont2 = DGV_CodigoP.RowCount
                        End If
                        If cont2 > DGV_CodigoP.RowCount - 1 Then
                            cont2 = cont2 - 1
                        End If
                        If ((DGV_CodigoP.Rows(cont2).Cells(4).Value.ToString = cb_proveedor.Tag.ToString) And (DGV_CodigoP.Rows(cont2).Cells(2).Value.ToString = tb_codigoFabrica.Text)) Then

                            esta2 = True
                            cont2 = DGV_CodigoP.RowCount
                        End If
                        If cont2 > DGV_CodigoP.RowCount - 1 Then
                            cont2 = cont2 - 1
                        End If
                        If ((DGV_CodigoP.Rows(cont2).Cells(4).Value.ToString = cb_proveedor.Tag.ToString)) And (DGV_CodigoP.Rows(cont2).Cells(3).Value.ToString = tb_codigoFabrica.Text) Then

                            esta3 = True
                            cont2 = DGV_CodigoP.RowCount
                        End If

                    Next


                    If esta1 = False And esta2 = False And esta3 = False Then

                        For cont3 As Integer = 0 To DGV_CodigoP.RowCount - 1
                            If (DGV_CodigoP.Rows(cont3).Cells(4).Value.ToString = cb_proveedor.Tag.ToString) Then
                                entro = True

                                If DGV_CodigoP.Rows(cont3).Cells(1).Value.ToString = "" Then
                                    DGV_CodigoP.Rows(cont3).Cells(1).Value = tb_codigoFabrica.Text
                                    'If cb_proveedor.Items.Count > 0 Then
                                    '    cb_proveedor.SelectedIndex = 0

                                    'End If
                                    tb_codigoFabrica.SelectAll()

                                ElseIf DGV_CodigoP.Rows(cont3).Cells(2).Value.ToString = "" Then

                                    DGV_CodigoP.Rows(cont3).Cells(2).Value = tb_codigoFabrica.Text
                                    'If cb_proveedor.Items.Count > 0 Then
                                    '    cb_proveedor.SelectedIndex = 0

                                    'End If
                                    tb_codigoFabrica.SelectAll()
                                ElseIf DGV_CodigoP.Rows(cont3).Cells(3).Value.ToString = "" Then

                                    DGV_CodigoP.Rows(cont3).Cells(3).Value = tb_codigoFabrica.Text
                                    'If cb_proveedor.Items.Count > 0 Then
                                    '    cb_proveedor.SelectedIndex = 0

                                    'End If
                                    tb_codigoFabrica.SelectAll()

                                End If

                            End If

                        Next


                        If entro = False Then

                            DGV_CodigoP.Rows.Add(cb_proveedor.Text, tb_codigoFabrica.Text, "", "", cb_proveedor.Tag.ToString)

                        End If
                        tb_codigoFabrica.Focus()
                        tb_codigoFabrica.SelectAll()

                    Else
                        MsgBox("El código ya existe", MsgBoxStyle.Critical, "Advertencia")

                    End If

                Else

                    tb_codigoFabrica.Focus()
                    tb_codigoFabrica.SelectAll()

                End If

            Else
                MsgBox("Debe introducir un código de fábrica", MsgBoxStyle.Critical, "Advertencia")
            End If

        Else

            MsgBox("Debe seleccionar un proveedor", MsgBoxStyle.Exclamation, "Error")

        End If



    End Sub

    Private Sub DGV_CodigoP_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_CodigoP.CellClick

        Try

            If DGV_CodigoP.SelectedRows.Count > 0 Then
                If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Then
                    tb_codigoFabrica.Text = DGV_CodigoP.SelectedRows(0).Cells(1).Value.ToString
                    DGV_CodigoP.SelectedRows(0).Cells(1).Selected = True
                ElseIf e.ColumnIndex = 2 Then
                    tb_codigoFabrica.Text = DGV_CodigoP.SelectedRows(0).Cells(2).Value.ToString
                ElseIf e.ColumnIndex = 3 Then
                    tb_codigoFabrica.Text = DGV_CodigoP.SelectedRows(0).Cells(3).Value.ToString

                End If

                'Ojo aqui

                For cont2 As Integer = 0 To lb_proveedor.Items.Count - 1
                    If lb_proveedor.Items(cont2).Item(0) = DGV_CodigoP.SelectedRows(0).Cells(0).Value.ToString Then
                        lb_proveedor.SelectedIndex = cont2
                        cb_proveedor.Text = lb_proveedor.Items(cont2).Item(0).ToString
                        cb_proveedor.Tag = lb_proveedor.Items(cont2).Item(1).ToString
                    End If

                Next

                codigoAnterior = tb_codigoFabrica.Text
                proveedorA = lb_proveedor.SelectedIndex
                columna = DGV_CodigoP.CurrentCell.ColumnIndex
                tb_codigoFabrica.SelectAll()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_modificarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_modificarCF.Click

        Try
            If cb_proveedor.Text <> "" Then

                If DatosProducto.verifica_Codigo_Fabrica(tb_codigoFabrica.Text, CInt(cb_proveedor.Tag.ToString)) = False Then
                    If DGV_CodigoP.SelectedRows(0).Cells(4).Value.ToString = cb_proveedor.Tag.ToString Then
                        If columna <> 0 Then
                            DGV_CodigoP.SelectedRows(0).Cells(columna).Value = tb_codigoFabrica.Text
                        End If
                    End If
                Else
                    tb_codigoFabrica.Focus()
                    tb_codigoFabrica.SelectAll()
                End If

            Else

                MsgBox("Debe seleccionar un proveedor", MsgBoxStyle.Exclamation, "Error")

            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub tb_codigoFabrica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_codigoFabrica.KeyDown

        If e.KeyCode = Keys.Enter Then

            bt_agregarCF_Click(DGV_CodigoP, New System.EventArgs)

        End If

    End Sub


    Private Sub DGV_CodigoP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_CodigoP.KeyDown, DGV_CodigoP.KeyUp
        DGV_CodigoP_CellClick(DGV_CodigoP, New System.Windows.Forms.DataGridViewCellEventArgs(columna, DGV_CodigoP.SelectedRows(0).Index))
    End Sub

    Private Sub bt_eliminaCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminaCF.Click

        If DGV_CodigoP.RowCount > 0 And DGV_CodigoP.SelectedRows.Count > 0 Then
            Dim p As Integer = DGV_CodigoP.SelectedRows(0).Index
            If columna = 0 Then
                DGV_CodigoP.Rows.RemoveAt(DGV_CodigoP.SelectedRows(0).Index)
                If DGV_CodigoP.RowCount > p Then
                    DGV_CodigoP.Rows(p).Selected = True
                ElseIf DGV_CodigoP.RowCount = 1 Then
                    DGV_CodigoP.Rows(0).Cells(0).Selected = True
                ElseIf DGV_CodigoP.RowCount < p Then
                    DGV_CodigoP.Rows(p - 1).Selected = True
                End If
            ElseIf columna = 1 Then
                If DGV_CodigoP.SelectedRows(0).Cells(1).Value.ToString <> "" And DGV_CodigoP.SelectedRows(0).Cells(2).Value.ToString = "" And DGV_CodigoP.SelectedRows(0).Cells(3).Value.ToString = "" Then
                    DGV_CodigoP.Rows.RemoveAt(DGV_CodigoP.SelectedRows(0).Index)
                    If DGV_CodigoP.RowCount > p Then
                        DGV_CodigoP.Rows(p).Selected = True
                    ElseIf DGV_CodigoP.RowCount = 1 Then
                        DGV_CodigoP.Rows(0).Cells(0).Selected = True
                    ElseIf DGV_CodigoP.RowCount < p Then
                        DGV_CodigoP.Rows(p - 1).Selected = True
                    End If
                Else
                    DGV_CodigoP.SelectedRows(0).Cells(1).Value = ""


                End If
            ElseIf columna = 2 Then
                If DGV_CodigoP.SelectedRows(0).Cells(1).Value.ToString = "" And DGV_CodigoP.SelectedRows(0).Cells(2).Value.ToString <> "" And DGV_CodigoP.SelectedRows(0).Cells(3).Value.ToString = "" Then
                    DGV_CodigoP.Rows.RemoveAt(DGV_CodigoP.SelectedRows(0).Index)
                    If DGV_CodigoP.RowCount > p Then
                        DGV_CodigoP.Rows(p).Selected = True
                    ElseIf DGV_CodigoP.RowCount = 1 Then
                        DGV_CodigoP.Rows(0).Cells(0).Selected = True
                    ElseIf DGV_CodigoP.RowCount < p Then
                        DGV_CodigoP.Rows(p - 1).Selected = True
                    End If
                Else
                    DGV_CodigoP.SelectedRows(0).Cells(2).Value = ""
                End If
            ElseIf columna = 3 Then
                If DGV_CodigoP.SelectedRows(0).Cells(1).Value.ToString = "" And DGV_CodigoP.SelectedRows(0).Cells(2).Value.ToString = "" And DGV_CodigoP.SelectedRows(0).Cells(3).Value.ToString <> "" Then
                    DGV_CodigoP.Rows.RemoveAt(DGV_CodigoP.SelectedRows(0).Index)
                    If DGV_CodigoP.RowCount > p Then
                        DGV_CodigoP.Rows(p).Selected = True
                    ElseIf DGV_CodigoP.RowCount = 1 Then
                        DGV_CodigoP.Rows(0).Cells(0).Selected = True
                    ElseIf DGV_CodigoP.RowCount < p Then
                        DGV_CodigoP.Rows(p - 1).Selected = True
                    End If
                Else
                    DGV_CodigoP.SelectedRows(0).Cells(3).Value = ""
                End If

            End If

        End If

        If DGV_CodigoP.RowCount = 0 Then
            tb_codigoFabrica.Clear()
        End If

    End Sub



    Private Sub cb_proveedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.tb_codigoFabrica.SelectAll()
        Me.tb_codigoFabrica.Focus()
    End Sub


    Private Sub insertar_en_bloque(ByVal DGV As DataGridView)

        Dim S As String = ""

        For i As Integer = 0 To DGV.RowCount - 1
            For j As Integer = 0 To DGV.ColumnCount - 1

                If j = 0 Then
                    S = S + "(" + DGV.Rows(i).Cells(j).Value.ToString + ","
                ElseIf j = DGV.ColumnCount - 1 Then
                    S = S + DGV.Rows(i).Cells(j).Value.ToString + "),"
                Else
                    S = S + DGV.Rows(i).Cells(j).Value.ToString + ","
                End If

            Next
        Next

        If S.Length > 0 Then
            S = S.Substring(0, S.Length - 1) + ";"
        Else
            S = S.Substring(0, S.Length) + ";"
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
                    DGV_Productos_selection(DGV_Productos, New EventArgs)

                End If

            End If


        End If
    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ToolBar1_ButtonClick(ToolBar1, New ToolBarButtonClickEventArgs(bt_modificar))
        varboton = 1
        DGV_CodigoP.Rows.Clear()
        tb_codigointerno.ReadOnly = False
        tb_codigointerno.Enabled = True
        tb_codigointerno.Clear()
        Button1.Visible = False
        cb_nombre.ResetText()
    End Sub

    '------------------------------------------------------ COMBO MARCA ----------------------------'

    Private Sub cb_marc_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_marc.MouseClick
        Try
            If lb_marca.Visible = False Then
                lb_marca.Visible = True
                Me.SpconsultaMarcaBindingSource.RemoveFilter()
                lb_marca.SelectedValue = cb_marc.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_marc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_marc.KeyDown
        Try
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
                If lb_marca.Items.Count > 0 Then
                    cb_marc.Text = lb_marca.SelectedItem(0).ToString
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                    'FillDGV()
                    lb_marca.SelectedIndex = 0
                    cb_model.Text = ""
                    cb_model.Focus()
                    lb_marca.Visible = False
                    cb_marc.SelectionStart = cb_marc.Text.Length
                Else
                    cb_marc.Text = ""
                End If

            ElseIf e.KeyData = Keys.Back Then
                If cb_marc.Text.Length <= 1 Or cb_marc.SelectedText <> "" Then
                    Me.SpconsultaMarcaBindingSource.RemoveFilter()
                Else
                    Me.SpconsultaMarcaBindingSource.Filter = "Marca LIKE '%" & cb_marc.Text.Substring(0, cb_marc.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_marc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_marc.KeyPress
        Try
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
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_marc_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marc.GotFocus
        Try
            If cb_marc.Text = "- Selecciona -" Then
                cb_marc.Text = ""
                Me.SpconsultaMarcaBindingSource.Filter = "Marca  LIKE '%" & cb_marc.Text & "%'"
                lb_marca.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_marca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_marca.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_marca.SelectedIndex = 1 Then
                    cb_marc.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                cb_marc.Text = lb_marca.SelectedItem(0).ToString
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                'FillDGV()
                lb_marca.SelectedIndex = 0
                cb_marc.Focus()
                cb_marc.SelectionStart = cb_marc.Text.Length
                cb_model.Text = ""
                lb_marca.Visible = False
                cb_model.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_marca_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_marca.MouseClick
        Try
            lb_marca.Visible = False
            cb_marc.Text = lb_marca.SelectedItem(0).ToString
            Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
            'FillDGV()
            lb_marca.SelectedIndex = 0
            cb_marc.Focus()
            cb_marc.SelectionStart = cb_marc.Text.Length
            cb_model.Text = ""
            cb_model.Focus()
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo


    '------------------------------------------------------ COMBO MODELO -------------------------'

    Private Sub cb_model_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_model.MouseClick
        Try
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
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_model_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_model.KeyDown
        Try
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
                If lb_modelo.Items.Count > 0 Then
                    cb_model.Text = lb_modelo.SelectedItem(0).ToString
                    cb_model.Tag = lb_modelo.SelectedItem(1).ToString
                    'FillDGV()
                    'If Chk_Marca.Checked Then
                    '    cb_marc.Enabled = False
                    'End If
                    DatosProducto.consulta_Modelo(Me.DGV_Modelo, CStr(Me.cb_model.Text))
                    lb_modelo.SelectedIndex = 0
                    cb_model.SelectionStart = cb_model.Text.Length
                    lb_modelo.Visible = False
                Else
                    cb_model.Text = ""
                End If
            ElseIf e.KeyData = Keys.Back Then
                If cb_model.Text.Length <= 1 Or cb_model.SelectedText <> "" Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "'"
                Else
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text.Substring(0, cb_model.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_model_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_model.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Then
                If Me.cb_model.SelectedText <> "" Then
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & e.KeyChar & "%'"
                Else
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & e.KeyChar & "%'"
                End If
                If lb_modelo.Items.Count = 0 Then
                    e.Handled = True
                    Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo LIKE '%" & cb_model.Text & "%'"
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
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_model_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_model.GotFocus
        Try
            If cb_model.Text = "- Selecciona -" Then
                cb_model.Text = ""
                Me.TblModeloBindingSource.Filter = "Marca = '" & cb_marc.Text & "' and Modelo  LIKE '%" & cb_model.Text & "%'"
            End If
            lb_modelo.Visible = True
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_modelo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_modelo.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_modelo.SelectedIndex = 1 Then
                    cb_model.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_modelo.Visible = False
                cb_model.Text = lb_modelo.SelectedItem(0).ToString
                cb_model.Tag = lb_modelo.SelectedItem(1).ToString
                'FillDGV()
                'If Chk_Marca.Checked Then
                '    cb_marc.Enabled = False
                'End If
                lb_modelo.SelectedIndex = 0
                DatosProducto.consulta_Modelo(Me.DGV_Modelo, CStr(Me.cb_model.Text))
                cb_model.Focus()
                cb_model.SelectionStart = cb_model.Text.Length
                lb_modelo.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_modelo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_modelo.MouseClick
        Try
            lb_modelo.Visible = False
            cb_model.Text = lb_modelo.SelectedItem(0).ToString
            cb_model.Tag = lb_modelo.SelectedItem(1).ToString
            'FillDGV()
            'If Chk_Marca.Checked Then
            '    cb_marc.Enabled = False
            'End If
            lb_modelo.SelectedIndex = 0
            DatosProducto.consulta_Modelo(Me.DGV_Modelo, CStr(Me.cb_model.Text))
            cb_model.Focus()
            lb_modelo.Visible = False
            cb_model.SelectionStart = cb_model.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

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
        Try
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
                If lb_proveedor.Items.Count > 0 Then
                    cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
                    cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
                    'FillDGV()
                    lb_proveedor.SelectedIndex = 0
                Else
                    cb_proveedor.Text = ""
                End If
                cb_proveedor.SelectionStart = cb_proveedor.Text.Length
                lb_proveedor.Visible = False
            ElseIf e.KeyData = Keys.Back Then
                If cb_proveedor.Text.Length <= 1 Or cb_proveedor.SelectedText <> "" Then
                    Me.TblFabricaBindingSource.RemoveFilter()
                Else
                    Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text.Substring(0, cb_proveedor.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_proveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_proveedor.KeyPress
        Try
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
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_proveedor_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_proveedor.GotFocus
        Try
            If cb_proveedor.Text = "- Selecciona -" Then
                cb_proveedor.Text = ""
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & cb_proveedor.Text & "%'"
                lb_proveedor.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_proveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_proveedor.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_proveedor.SelectedIndex = 1 Then
                    cb_proveedor.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
                cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
                'FillDGV()
                lb_proveedor.SelectedIndex = 0
                'cb_proveedor.Focus()
                cb_proveedor.SelectionStart = cb_proveedor.Text.Length
                lb_proveedor.Visible = False
                tb_codigoFabrica.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_proveedor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_proveedor.MouseClick
        Try
            lb_proveedor.Visible = False
            cb_proveedor.Text = lb_proveedor.SelectedItem(0).ToString
            cb_proveedor.Tag = lb_proveedor.SelectedItem(1).ToString
            'FillDGV()
            lb_proveedor.SelectedIndex = 0
            'cb_proveedor.Focus()
            cb_proveedor.SelectionStart = cb_proveedor.Text.Length
            tb_codigoFabrica.Focus()
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo



    '------------------------------------------------------ COMBO NOMBRE ----------------------------'

    Private Sub cb_nombre_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_nombre.MouseClick
        Try
            If lb_nombre.Visible = False Then
                lb_nombre.Visible = True
                Me.SpconsultaCodigosInternosBindingSource.RemoveFilter()
                lb_nombre.SelectedValue = cb_nombre.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_nombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_nombre.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_nombre.Visible = False Then
                    Me.SpconsultaCodigosInternosBindingSource.RemoveFilter()
                    lb_nombre.Visible = True
                    lb_nombre.SelectedValue = cb_nombre.Text
                Else
                    If lb_nombre.Items.Count > 1 Then
                        lb_nombre.Focus()
                        lb_nombre.SelectedIndex = lb_nombre.SelectedIndex + 1
                    Else
                        cb_nombre.SelectionStart = 0
                        cb_nombre.SelectionLength = cb_nombre.Text.Length
                        cb_nombre.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_nombre.Visible = True Then
                    If lb_nombre.Items.Count > 1 Then
                        lb_nombre.Focus()
                        lb_nombre.SelectedIndex = lb_nombre.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_nombre.Visible Then
                If lb_nombre.Items.Count > 0 Then
                    cb_nombre.Text = lb_nombre.SelectedItem(0).ToString
                    If Me.cb_nombre.Text = "Nuevo" Then
                        Me.tb_nombre.Visible = True
                        Me.tb_nombre.Focus()
                        If varboton = 1 Then
                            Me.tb_codigointerno.Clear()
                        End If
                    Else
                        Me.tb_nombre.Clear()
                        Me.tb_nombre.Visible = False
                        If varboton = 1 Then
                            Me.tb_codigointerno.Text = ""
                        End If
                        lb_nombre.SelectedIndex = 0
                    End If
                Else
                    cb_nombre.Text = ""
                End If
                cb_nombre.SelectionStart = cb_nombre.Text.Length
                lb_nombre.Visible = False
            ElseIf e.KeyData = Keys.Back Then
                If cb_nombre.Text.Length <= 1 Or cb_nombre.SelectedText <> "" Then
                    Me.SpconsultaCodigosInternosBindingSource.RemoveFilter()
                Else
                    Me.SpconsultaCodigosInternosBindingSource.Filter = "Nombre LIKE '%" & cb_nombre.Text.Substring(0, cb_nombre.Text.Length - 1) & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_nombre.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                If Me.cb_nombre.SelectedText <> "" Then
                    Me.SpconsultaCodigosInternosBindingSource.Filter = "Nombre LIKE '%" & e.KeyChar & "%'"
                Else
                    Me.SpconsultaCodigosInternosBindingSource.Filter = "Nombre LIKE '%" & cb_nombre.Text & e.KeyChar & "%'"
                End If

                If lb_nombre.Items.Count = 0 Then
                    e.Handled = True
                    Me.SpconsultaCodigosInternosBindingSource.Filter = "Nombre LIKE '%" & cb_nombre.Text & "%'"
                Else
                    e.Handled = False
                    lb_nombre.Visible = True
                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                lb_nombre.Visible = True
            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_nombre_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_nombre.GotFocus
        Try
            If cb_nombre.Text = "- Selecciona -" Then
                cb_nombre.Text = ""
                Me.SpconsultaCodigosInternosBindingSource.Filter = "Nombre LIKE '%" & cb_nombre.Text & "%'"
                lb_nombre.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_nombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_nombre.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_nombre.SelectedIndex = 1 Then
                    cb_nombre.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_nombre.Visible = False
                cb_nombre.Text = lb_nombre.SelectedItem(0).ToString
                'FillDGV()
                If Me.cb_nombre.Text = "Nuevo" Then
                    Me.tb_nombre.Visible = True
                    Me.tb_nombre.Focus()
                    If varboton = 1 Then
                        Me.tb_codigointerno.Clear()
                    End If
                Else
                    Me.tb_nombre.Clear()
                    Me.tb_nombre.Visible = False
                    If varboton = 1 Then
                        Me.tb_codigointerno.Text = ""
                    End If
                    lb_nombre.SelectedIndex = 0
                    cb_nombre.Focus()
                    cb_nombre.SelectionStart = cb_nombre.Text.Length
                End If
                lb_nombre.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lb_nombre_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_nombre.MouseClick
        Try
            lb_nombre.Visible = False
            cb_nombre.Text = lb_nombre.SelectedItem(0).ToString
            If Me.cb_nombre.Text = "Nuevo" Then
                Me.tb_nombre.Visible = True
                Me.tb_nombre.Focus()
                Me.tb_codigointerno.Clear()
            Else
                Me.tb_nombre.Clear()
                Me.tb_nombre.Visible = False
                If varboton = 1 Then
                    Me.tb_codigointerno.Text = ""
                End If
                lb_nombre.SelectedIndex = 0
                cb_nombre.Focus()
                cb_nombre.SelectionStart = cb_nombre.Text.Length
            End If
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    Private Sub rb_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged, rb_porC.CheckedChanged

        Dim s1 As String = ""
        sww = False

        If choice = 0 Then
            s1 = "CodigoInterno LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
        ElseIf choice = 1 Then
            s1 = "Nombre LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
        ElseIf choice = 2 Then
            s1 = "CodigoProductoF LIKE '%" & Me.tb_buscarcodigo.Text & "%'"
        End If

        If rb_porC.Checked Then
            s1 = s1 + " AND PorComplementar = 1"
        End If

        SpconsultaProductoFBindingSource.Filter = s1

        Me.tb_cantidadexistencia.Clear()
        Me.tb_cantidadvendida.Clear()
        Me.tb_clasificacion.Clear()
        Me.tb_codigoarancelario.ResetText()
        Me.tb_codigoarancelario.Items.Clear()
        Me.tb_codigointerno.Clear()
        Me.tb_costopromedio.Clear()
        Me.tb_foto.Clear()
        Me.cb_marcproducto.Clear()
        Me.tb_nombre.Clear()
        Me.tb_precioventa.Clear()
        Me.cb_nombre.Text = ""
        Me.cb_almacen.Text = ""
        Me.cb_cuarto.Text = ""
        Me.tb_OEM.Clear()
        Me.tb_Var1.Clear()
        Me.tb_Var2.Clear()
        Me.cb_tramo.Text = ""
        Me.tb_observacion.Clear()
        Me.tb_empaque.Clear()
        Me.tb_cantidad.Clear()
        DGV_CodigoP.Rows.Clear()
        DGV_Modelo.Rows.Clear()
        DGV_Seleccionados.Rows.Clear()
        DGV_Direccion.Rows.Clear()
        DGV_Productos.ClearSelection()
        Me.Label2.Text = Me.SpconsultaProductoFBindingSource.Count

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If presionado2 Then
            tb_costopromedio.Enabled = True
            tb_costopromedio.ReadOnly = True
            presionado2 = False
        Else
            Dim resp As Integer = MsgBox("Esta opción cambiará el costo promedio del producto, Desea continuar?", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                tb_costopromedio.Enabled = True
                tb_costopromedio.ReadOnly = False
                presionado2 = True
            End If

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub groupbox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupbox1.Enter

    End Sub
End Class

