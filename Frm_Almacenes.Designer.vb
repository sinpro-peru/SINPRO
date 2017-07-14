<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Almacenes
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Almacenes))
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Cuartos = New System.Windows.Forms.DataGridView
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuarto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblNombreCuarto = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_reporte = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DGV_Almacenes = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableAlmacenBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.TableAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.gb_cuartos = New System.Windows.Forms.GroupBox
        Me.tb_NombreCuarto = New System.Windows.Forms.TextBox
        Me.bt_ModificarCuarto = New System.Windows.Forms.Button
        Me.bt_agregarCuarto = New System.Windows.Forms.Button
        Me.bt_eliminarCuarto = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Lbl_DireccionAlmacen = New System.Windows.Forms.Label
        Me.tb_direccionAlmacen = New System.Windows.Forms.TextBox
        Me.Lbl_NombreAlmacen = New System.Windows.Forms.Label
        Me.Tb_NombreAlmacen = New System.Windows.Forms.TextBox
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.DGV_Tramos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_Tramos = New System.Windows.Forms.Label
        Me.lbl_Estantes = New System.Windows.Forms.Label
        Me.gb_tramos = New System.Windows.Forms.GroupBox
        Me.tb_NombreTramo = New System.Windows.Forms.TextBox
        Me.bt_ModificarTramo = New System.Windows.Forms.Button
        Me.LblNombreTramo = New System.Windows.Forms.Label
        Me.bt_AgregarTramo = New System.Windows.Forms.Button
        Me.bt_EliminarTramo = New System.Windows.Forms.Button
        Me.lbl_Cuartos = New System.Windows.Forms.Label
        Me.gb_estantes = New System.Windows.Forms.GroupBox
        Me.tb_NombreEstante = New System.Windows.Forms.TextBox
        Me.DGV_Estantes = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_modificarEstante = New System.Windows.Forms.Button
        Me.LblNombreEstante = New System.Windows.Forms.Label
        Me.bt_agregarEstante = New System.Windows.Forms.Button
        Me.bt_EliminarEstante = New System.Windows.Forms.Button
        Me.DGV_Catalogo = New System.Windows.Forms.DataGridView
        Me.CodigoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AquiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpconsultaubicacionproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Catalogo = New System.Windows.Forms.Label
        Me.lbl_Almacenes = New System.Windows.Forms.Label
        Me.TabControlAlmace = New System.Windows.Forms.TabControl
        Me.Ubicación = New System.Windows.Forms.TabPage
        Me.Chk_Exist = New System.Windows.Forms.CheckBox
        Me.Reubicación = New System.Windows.Forms.TabPage
        Me.DGV_UbicacionActual = New Tesis_Nueva.MyDGVdigit
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoProductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AquiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_NuevaUbicacion = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodFabrica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicaciónA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicaAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantTramoAnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_cuarto = New System.Windows.Forms.ComboBox
        Me.TblCuartoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.TblTramoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.TblEstanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.bt_aceptar_tab1 = New System.Windows.Forms.Button
        Me.bt_cancelar_tab1 = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tb_almacenes = New System.Windows.Forms.GroupBox
        Me.cb_tramoD = New System.Windows.Forms.ComboBox
        Me.cb_estanteD = New System.Windows.Forms.ComboBox
        Me.cb_cuartoD = New System.Windows.Forms.ComboBox
        Me.cb_almacenD = New System.Windows.Forms.ComboBox
        Me.TableAlmacenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cb_tramoH = New System.Windows.Forms.ComboBox
        Me.TblTramoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_estanteH = New System.Windows.Forms.ComboBox
        Me.TblEstanteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_cuartoH = New System.Windows.Forms.ComboBox
        Me.TblCuartoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_almacenH = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DGV_ProductoActual = New System.Windows.Forms.DataGridView
        Me.CodigoProductoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AquiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cb_aceptar_D = New System.Windows.Forms.Button
        Me.DomainUpDown2 = New System.Windows.Forms.ComboBox
        Me.Table_AlmacenTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
        Me.Sp_consulta_ubicacion_productosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_ubicacion_productosTableAdapter
        Me.Tbl_CuartoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_CuartoTableAdapter
        Me.Tbl_EstanteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_EstanteTableAdapter
        Me.Tbl_TramoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_TramoTableAdapter
        CType(Me.DGV_Cuartos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Almacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableAlmacenBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_cuartos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Tramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tramos.SuspendLayout()
        Me.gb_estantes.SuspendLayout()
        CType(Me.DGV_Estantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Catalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaubicacionproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAlmace.SuspendLayout()
        Me.Ubicación.SuspendLayout()
        Me.Reubicación.SuspendLayout()
        CType(Me.DGV_UbicacionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_NuevaUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblCuartoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTramoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEstanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.tb_almacenes.SuspendLayout()
        CType(Me.TableAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.TblTramoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEstanteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCuartoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ProductoActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Cuartos
        '
        Me.DGV_Cuartos.AllowUserToAddRows = False
        Me.DGV_Cuartos.AllowUserToDeleteRows = False
        Me.DGV_Cuartos.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DGV_Cuartos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DGV_Cuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Cuartos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Cuartos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Cuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Cuartos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modelo, Me.CodigoCuarto})
        Me.DGV_Cuartos.EnableHeadersVisualStyles = False
        Me.DGV_Cuartos.Location = New System.Drawing.Point(55, 45)
        Me.DGV_Cuartos.MultiSelect = False
        Me.DGV_Cuartos.Name = "DGV_Cuartos"
        Me.DGV_Cuartos.ReadOnly = True
        Me.DGV_Cuartos.RowHeadersVisible = False
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Cuartos.RowsDefaultCellStyle = DataGridViewCellStyle23
        Me.DGV_Cuartos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Cuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Cuartos.Size = New System.Drawing.Size(161, 95)
        Me.DGV_Cuartos.TabIndex = 10030
        '
        'Modelo
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modelo.DefaultCellStyle = DataGridViewCellStyle22
        Me.Modelo.HeaderText = "Nombre"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'CodigoCuarto
        '
        Me.CodigoCuarto.HeaderText = "Id"
        Me.CodigoCuarto.Name = "CodigoCuarto"
        Me.CodigoCuarto.ReadOnly = True
        Me.CodigoCuarto.Visible = False
        '
        'LblNombreCuarto
        '
        Me.LblNombreCuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblNombreCuarto.Location = New System.Drawing.Point(3, 17)
        Me.LblNombreCuarto.Name = "LblNombreCuarto"
        Me.LblNombreCuarto.Size = New System.Drawing.Size(54, 20)
        Me.LblNombreCuarto.TabIndex = 10023
        Me.LblNombreCuarto.Text = "Cuarto:"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_reporte, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(22, 22)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(-6, -1)
        Me.ToolBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(292, 60)
        Me.ToolBar1.TabIndex = 10028
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
        Me.bt_reporte.Text = "Traspasos"
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
        Me.ImageList2.Images.SetKeyName(5, "Move32x32.png")
        '
        'DGV_Almacenes
        '
        Me.DGV_Almacenes.AllowUserToAddRows = False
        Me.DGV_Almacenes.AllowUserToDeleteRows = False
        Me.DGV_Almacenes.AllowUserToResizeRows = False
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        Me.DGV_Almacenes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DGV_Almacenes.AutoGenerateColumns = False
        Me.DGV_Almacenes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Almacenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Almacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Almacenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DGV_Almacenes.DataSource = Me.TableAlmacenBindingSource2
        Me.DGV_Almacenes.EnableHeadersVisualStyles = False
        Me.DGV_Almacenes.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Almacenes.Location = New System.Drawing.Point(11, 114)
        Me.DGV_Almacenes.MultiSelect = False
        Me.DGV_Almacenes.Name = "DGV_Almacenes"
        Me.DGV_Almacenes.ReadOnly = True
        Me.DGV_Almacenes.RowHeadersVisible = False
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Almacenes.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DGV_Almacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Almacenes.Size = New System.Drawing.Size(263, 561)
        Me.DGV_Almacenes.TabIndex = 10029
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.FillWeight = 47.71573!
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Almacén"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 90
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.FillWeight = 152.2843!
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 152
        '
        'TableAlmacenBindingSource2
        '
        Me.TableAlmacenBindingSource2.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource2.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAlmacenBindingSource
        '
        Me.TableAlmacenBindingSource.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource.DataSource = Me.MELDataSet
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(142, 61)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(132, 22)
        Me.tb_buscar.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(9, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(694, 23)
        Me.Label17.TabIndex = 10031
        Me.Label17.Text = "Datos del Almacén"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_cuartos
        '
        Me.gb_cuartos.BackColor = System.Drawing.Color.White
        Me.gb_cuartos.Controls.Add(Me.DGV_Cuartos)
        Me.gb_cuartos.Controls.Add(Me.tb_NombreCuarto)
        Me.gb_cuartos.Controls.Add(Me.bt_ModificarCuarto)
        Me.gb_cuartos.Controls.Add(Me.LblNombreCuarto)
        Me.gb_cuartos.Controls.Add(Me.bt_agregarCuarto)
        Me.gb_cuartos.Controls.Add(Me.bt_eliminarCuarto)
        Me.gb_cuartos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cuartos.Location = New System.Drawing.Point(9, 98)
        Me.gb_cuartos.Name = "gb_cuartos"
        Me.gb_cuartos.Size = New System.Drawing.Size(222, 145)
        Me.gb_cuartos.TabIndex = 10036
        Me.gb_cuartos.TabStop = False
        '
        'tb_NombreCuarto
        '
        Me.tb_NombreCuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NombreCuarto.Location = New System.Drawing.Point(55, 13)
        Me.tb_NombreCuarto.MaxLength = 20
        Me.tb_NombreCuarto.Name = "tb_NombreCuarto"
        Me.tb_NombreCuarto.Size = New System.Drawing.Size(79, 22)
        Me.tb_NombreCuarto.TabIndex = 10046
        '
        'bt_ModificarCuarto
        '
        Me.bt_ModificarCuarto.Enabled = False
        Me.bt_ModificarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ModificarCuarto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_ModificarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarCuarto.Location = New System.Drawing.Point(164, 14)
        Me.bt_ModificarCuarto.Name = "bt_ModificarCuarto"
        Me.bt_ModificarCuarto.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarCuarto.TabIndex = 10031
        Me.bt_ModificarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarCuarto
        '
        Me.bt_agregarCuarto.Enabled = False
        Me.bt_agregarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregarCuarto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCuarto.Location = New System.Drawing.Point(137, 14)
        Me.bt_agregarCuarto.Name = "bt_agregarCuarto"
        Me.bt_agregarCuarto.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarCuarto.TabIndex = 10021
        Me.bt_agregarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_eliminarCuarto
        '
        Me.bt_eliminarCuarto.Enabled = False
        Me.bt_eliminarCuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminarCuarto.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarCuarto.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCuarto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCuarto.Location = New System.Drawing.Point(191, 14)
        Me.bt_eliminarCuarto.Name = "bt_eliminarCuarto"
        Me.bt_eliminarCuarto.Size = New System.Drawing.Size(25, 21)
        Me.bt_eliminarCuarto.TabIndex = 10026
        Me.bt_eliminarCuarto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Lbl_DireccionAlmacen)
        Me.GroupBox2.Controls.Add(Me.tb_direccionAlmacen)
        Me.GroupBox2.Controls.Add(Me.Lbl_NombreAlmacen)
        Me.GroupBox2.Controls.Add(Me.Tb_NombreAlmacen)
        Me.GroupBox2.Controls.Add(Me.bt_aceptar)
        Me.GroupBox2.Controls.Add(Me.bt_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(694, 63)
        Me.GroupBox2.TabIndex = 10037
        Me.GroupBox2.TabStop = False
        '
        'Lbl_DireccionAlmacen
        '
        Me.Lbl_DireccionAlmacen.AutoSize = True
        Me.Lbl_DireccionAlmacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DireccionAlmacen.Location = New System.Drawing.Point(279, 14)
        Me.Lbl_DireccionAlmacen.Name = "Lbl_DireccionAlmacen"
        Me.Lbl_DireccionAlmacen.Size = New System.Drawing.Size(84, 15)
        Me.Lbl_DireccionAlmacen.TabIndex = 10041
        Me.Lbl_DireccionAlmacen.Text = " (*)Dirección:"
        '
        'tb_direccionAlmacen
        '
        Me.tb_direccionAlmacen.Enabled = False
        Me.tb_direccionAlmacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccionAlmacen.Location = New System.Drawing.Point(372, 11)
        Me.tb_direccionAlmacen.MaxLength = 50
        Me.tb_direccionAlmacen.Multiline = True
        Me.tb_direccionAlmacen.Name = "tb_direccionAlmacen"
        Me.tb_direccionAlmacen.Size = New System.Drawing.Size(316, 26)
        Me.tb_direccionAlmacen.TabIndex = 10040
        '
        'Lbl_NombreAlmacen
        '
        Me.Lbl_NombreAlmacen.AutoSize = True
        Me.Lbl_NombreAlmacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreAlmacen.Location = New System.Drawing.Point(9, 14)
        Me.Lbl_NombreAlmacen.Name = "Lbl_NombreAlmacen"
        Me.Lbl_NombreAlmacen.Size = New System.Drawing.Size(77, 15)
        Me.Lbl_NombreAlmacen.TabIndex = 10039
        Me.Lbl_NombreAlmacen.Text = " (*)Nombre:"
        '
        'Tb_NombreAlmacen
        '
        Me.Tb_NombreAlmacen.Enabled = False
        Me.Tb_NombreAlmacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_NombreAlmacen.Location = New System.Drawing.Point(93, 11)
        Me.Tb_NombreAlmacen.MaxLength = 20
        Me.Tb_NombreAlmacen.Name = "Tb_NombreAlmacen"
        Me.Tb_NombreAlmacen.Size = New System.Drawing.Size(149, 22)
        Me.Tb_NombreAlmacen.TabIndex = 10038
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(208, 37)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 10042
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        Me.bt_aceptar.Visible = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(296, 37)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 10043
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        Me.bt_cancelar.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label24.Font = New System.Drawing.Font("Eras Light ITC", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(12, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(126, 17)
        Me.Label24.TabIndex = 10047
        Me.Label24.Text = "(*) Datos Requeridos"
        '
        'DGV_Tramos
        '
        Me.DGV_Tramos.AllowUserToAddRows = False
        Me.DGV_Tramos.AllowUserToDeleteRows = False
        Me.DGV_Tramos.AllowUserToResizeRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        Me.DGV_Tramos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.DGV_Tramos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Tramos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Tramos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Tramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Tramos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.CodigoTramo})
        Me.DGV_Tramos.EnableHeadersVisualStyles = False
        Me.DGV_Tramos.Location = New System.Drawing.Point(51, 39)
        Me.DGV_Tramos.MultiSelect = False
        Me.DGV_Tramos.Name = "DGV_Tramos"
        Me.DGV_Tramos.ReadOnly = True
        Me.DGV_Tramos.RowHeadersVisible = False
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Tramos.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DGV_Tramos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Tramos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Tramos.Size = New System.Drawing.Size(165, 101)
        Me.DGV_Tramos.TabIndex = 10030
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CodigoTramo
        '
        Me.CodigoTramo.HeaderText = "Id"
        Me.CodigoTramo.Name = "CodigoTramo"
        Me.CodigoTramo.ReadOnly = True
        Me.CodigoTramo.Visible = False
        '
        'lbl_Tramos
        '
        Me.lbl_Tramos.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Tramos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Tramos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Tramos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tramos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Tramos.Location = New System.Drawing.Point(481, 85)
        Me.lbl_Tramos.Name = "lbl_Tramos"
        Me.lbl_Tramos.Size = New System.Drawing.Size(222, 23)
        Me.lbl_Tramos.TabIndex = 10037
        Me.lbl_Tramos.Text = "Tramos"
        Me.lbl_Tramos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Estantes
        '
        Me.lbl_Estantes.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Estantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Estantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Estantes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estantes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Estantes.Location = New System.Drawing.Point(243, 85)
        Me.lbl_Estantes.Name = "lbl_Estantes"
        Me.lbl_Estantes.Size = New System.Drawing.Size(222, 23)
        Me.lbl_Estantes.TabIndex = 10044
        Me.lbl_Estantes.Text = "Estantes"
        Me.lbl_Estantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_tramos
        '
        Me.gb_tramos.BackColor = System.Drawing.Color.White
        Me.gb_tramos.Controls.Add(Me.DGV_Tramos)
        Me.gb_tramos.Controls.Add(Me.tb_NombreTramo)
        Me.gb_tramos.Controls.Add(Me.bt_ModificarTramo)
        Me.gb_tramos.Controls.Add(Me.LblNombreTramo)
        Me.gb_tramos.Controls.Add(Me.bt_AgregarTramo)
        Me.gb_tramos.Controls.Add(Me.bt_EliminarTramo)
        Me.gb_tramos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tramos.Location = New System.Drawing.Point(481, 98)
        Me.gb_tramos.Name = "gb_tramos"
        Me.gb_tramos.Size = New System.Drawing.Size(222, 145)
        Me.gb_tramos.TabIndex = 10038
        Me.gb_tramos.TabStop = False
        '
        'tb_NombreTramo
        '
        Me.tb_NombreTramo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NombreTramo.Location = New System.Drawing.Point(51, 12)
        Me.tb_NombreTramo.MaxLength = 20
        Me.tb_NombreTramo.Name = "tb_NombreTramo"
        Me.tb_NombreTramo.Size = New System.Drawing.Size(86, 22)
        Me.tb_NombreTramo.TabIndex = 10049
        '
        'bt_ModificarTramo
        '
        Me.bt_ModificarTramo.Enabled = False
        Me.bt_ModificarTramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ModificarTramo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_ModificarTramo.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarTramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarTramo.Location = New System.Drawing.Point(166, 13)
        Me.bt_ModificarTramo.Name = "bt_ModificarTramo"
        Me.bt_ModificarTramo.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarTramo.TabIndex = 10031
        Me.bt_ModificarTramo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblNombreTramo
        '
        Me.LblNombreTramo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreTramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblNombreTramo.Location = New System.Drawing.Point(4, 16)
        Me.LblNombreTramo.Name = "LblNombreTramo"
        Me.LblNombreTramo.Size = New System.Drawing.Size(59, 20)
        Me.LblNombreTramo.TabIndex = 10023
        Me.LblNombreTramo.Text = "Tramo:"
        '
        'bt_AgregarTramo
        '
        Me.bt_AgregarTramo.Enabled = False
        Me.bt_AgregarTramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_AgregarTramo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_AgregarTramo.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_AgregarTramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_AgregarTramo.Location = New System.Drawing.Point(140, 13)
        Me.bt_AgregarTramo.Name = "bt_AgregarTramo"
        Me.bt_AgregarTramo.Size = New System.Drawing.Size(25, 22)
        Me.bt_AgregarTramo.TabIndex = 10021
        Me.bt_AgregarTramo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_EliminarTramo
        '
        Me.bt_EliminarTramo.Enabled = False
        Me.bt_EliminarTramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_EliminarTramo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_EliminarTramo.Image = CType(resources.GetObject("bt_EliminarTramo.Image"), System.Drawing.Image)
        Me.bt_EliminarTramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_EliminarTramo.Location = New System.Drawing.Point(192, 13)
        Me.bt_EliminarTramo.Name = "bt_EliminarTramo"
        Me.bt_EliminarTramo.Size = New System.Drawing.Size(25, 21)
        Me.bt_EliminarTramo.TabIndex = 10026
        Me.bt_EliminarTramo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_Cuartos
        '
        Me.lbl_Cuartos.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Cuartos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Cuartos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Cuartos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuartos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Cuartos.Location = New System.Drawing.Point(9, 84)
        Me.lbl_Cuartos.Name = "lbl_Cuartos"
        Me.lbl_Cuartos.Size = New System.Drawing.Size(222, 23)
        Me.lbl_Cuartos.TabIndex = 10033
        Me.lbl_Cuartos.Text = "Cuartos"
        Me.lbl_Cuartos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_estantes
        '
        Me.gb_estantes.BackColor = System.Drawing.Color.White
        Me.gb_estantes.Controls.Add(Me.tb_NombreEstante)
        Me.gb_estantes.Controls.Add(Me.DGV_Estantes)
        Me.gb_estantes.Controls.Add(Me.bt_modificarEstante)
        Me.gb_estantes.Controls.Add(Me.LblNombreEstante)
        Me.gb_estantes.Controls.Add(Me.bt_agregarEstante)
        Me.gb_estantes.Controls.Add(Me.bt_EliminarEstante)
        Me.gb_estantes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_estantes.Location = New System.Drawing.Point(243, 100)
        Me.gb_estantes.Name = "gb_estantes"
        Me.gb_estantes.Size = New System.Drawing.Size(222, 143)
        Me.gb_estantes.TabIndex = 10045
        Me.gb_estantes.TabStop = False
        '
        'tb_NombreEstante
        '
        Me.tb_NombreEstante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NombreEstante.Location = New System.Drawing.Point(50, 11)
        Me.tb_NombreEstante.MaxLength = 20
        Me.tb_NombreEstante.Name = "tb_NombreEstante"
        Me.tb_NombreEstante.Size = New System.Drawing.Size(86, 22)
        Me.tb_NombreEstante.TabIndex = 10047
        '
        'DGV_Estantes
        '
        Me.DGV_Estantes.AllowUserToAddRows = False
        Me.DGV_Estantes.AllowUserToDeleteRows = False
        Me.DGV_Estantes.AllowUserToResizeRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        Me.DGV_Estantes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.DGV_Estantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Estantes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Estantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Estantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Estantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodigoEstante})
        Me.DGV_Estantes.EnableHeadersVisualStyles = False
        Me.DGV_Estantes.Location = New System.Drawing.Point(48, 43)
        Me.DGV_Estantes.MultiSelect = False
        Me.DGV_Estantes.Name = "DGV_Estantes"
        Me.DGV_Estantes.ReadOnly = True
        Me.DGV_Estantes.RowHeadersVisible = False
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Estantes.RowsDefaultCellStyle = DataGridViewCellStyle31
        Me.DGV_Estantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Estantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Estantes.Size = New System.Drawing.Size(166, 95)
        Me.DGV_Estantes.TabIndex = 10030
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CodigoEstante
        '
        Me.CodigoEstante.HeaderText = "Id"
        Me.CodigoEstante.Name = "CodigoEstante"
        Me.CodigoEstante.ReadOnly = True
        Me.CodigoEstante.Visible = False
        '
        'bt_modificarEstante
        '
        Me.bt_modificarEstante.Enabled = False
        Me.bt_modificarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modificarEstante.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_modificarEstante.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificarEstante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificarEstante.Location = New System.Drawing.Point(168, 11)
        Me.bt_modificarEstante.Name = "bt_modificarEstante"
        Me.bt_modificarEstante.Size = New System.Drawing.Size(25, 22)
        Me.bt_modificarEstante.TabIndex = 10031
        Me.bt_modificarEstante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblNombreEstante
        '
        Me.LblNombreEstante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreEstante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblNombreEstante.Location = New System.Drawing.Point(0, 15)
        Me.LblNombreEstante.Name = "LblNombreEstante"
        Me.LblNombreEstante.Size = New System.Drawing.Size(54, 20)
        Me.LblNombreEstante.TabIndex = 10023
        Me.LblNombreEstante.Text = "Estante:"
        '
        'bt_agregarEstante
        '
        Me.bt_agregarEstante.Enabled = False
        Me.bt_agregarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregarEstante.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarEstante.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarEstante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarEstante.Location = New System.Drawing.Point(142, 11)
        Me.bt_agregarEstante.Name = "bt_agregarEstante"
        Me.bt_agregarEstante.Size = New System.Drawing.Size(25, 22)
        Me.bt_agregarEstante.TabIndex = 10021
        Me.bt_agregarEstante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_EliminarEstante
        '
        Me.bt_EliminarEstante.Enabled = False
        Me.bt_EliminarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_EliminarEstante.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_EliminarEstante.Image = CType(resources.GetObject("bt_EliminarEstante.Image"), System.Drawing.Image)
        Me.bt_EliminarEstante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_EliminarEstante.Location = New System.Drawing.Point(191, 11)
        Me.bt_EliminarEstante.Name = "bt_EliminarEstante"
        Me.bt_EliminarEstante.Size = New System.Drawing.Size(25, 21)
        Me.bt_EliminarEstante.TabIndex = 10026
        Me.bt_EliminarEstante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DGV_Catalogo
        '
        Me.DGV_Catalogo.AllowUserToAddRows = False
        Me.DGV_Catalogo.AllowUserToDeleteRows = False
        Me.DGV_Catalogo.AllowUserToResizeRows = False
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.White
        Me.DGV_Catalogo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DGV_Catalogo.AutoGenerateColumns = False
        Me.DGV_Catalogo.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Catalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Catalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Catalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProductoDataGridViewTextBoxColumn, Me.CodigoFDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn1, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.AquiDataGridViewTextBoxColumn, Me.CodigoAlmacenDataGridViewTextBoxColumn, Me.CodigoCuartoDataGridViewTextBoxColumn, Me.CodigoEstanteDataGridViewTextBoxColumn, Me.CodigoTramoDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn})
        Me.DGV_Catalogo.DataSource = Me.SpconsultaubicacionproductosBindingSource
        Me.DGV_Catalogo.EnableHeadersVisualStyles = False
        Me.DGV_Catalogo.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Catalogo.Location = New System.Drawing.Point(4, 271)
        Me.DGV_Catalogo.MultiSelect = False
        Me.DGV_Catalogo.Name = "DGV_Catalogo"
        Me.DGV_Catalogo.ReadOnly = True
        Me.DGV_Catalogo.RowHeadersVisible = False
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Catalogo.RowsDefaultCellStyle = DataGridViewCellStyle33
        Me.DGV_Catalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Catalogo.Size = New System.Drawing.Size(724, 357)
        Me.DGV_Catalogo.TabIndex = 10038
        '
        'CodigoProductoDataGridViewTextBoxColumn
        '
        Me.CodigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto"
        Me.CodigoProductoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoProductoDataGridViewTextBoxColumn.Name = "CodigoProductoDataGridViewTextBoxColumn"
        Me.CodigoProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoProductoDataGridViewTextBoxColumn.Width = 95
        '
        'CodigoFDataGridViewTextBoxColumn
        '
        Me.CodigoFDataGridViewTextBoxColumn.DataPropertyName = "codigoF"
        Me.CodigoFDataGridViewTextBoxColumn.HeaderText = "Cod. Fab."
        Me.CodigoFDataGridViewTextBoxColumn.Name = "CodigoFDataGridViewTextBoxColumn"
        Me.CodigoFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFDataGridViewTextBoxColumn.Width = 95
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn1.Width = 160
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "Exis."
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Width = 35
        '
        'AquiDataGridViewTextBoxColumn
        '
        Me.AquiDataGridViewTextBoxColumn.DataPropertyName = "aqui"
        Me.AquiDataGridViewTextBoxColumn.HeaderText = "Aquí"
        Me.AquiDataGridViewTextBoxColumn.Name = "AquiDataGridViewTextBoxColumn"
        Me.AquiDataGridViewTextBoxColumn.ReadOnly = True
        Me.AquiDataGridViewTextBoxColumn.Width = 35
        '
        'CodigoAlmacenDataGridViewTextBoxColumn
        '
        Me.CodigoAlmacenDataGridViewTextBoxColumn.DataPropertyName = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.Name = "CodigoAlmacenDataGridViewTextBoxColumn"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoCuartoDataGridViewTextBoxColumn
        '
        Me.CodigoCuartoDataGridViewTextBoxColumn.DataPropertyName = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn.HeaderText = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn.Name = "CodigoCuartoDataGridViewTextBoxColumn"
        Me.CodigoCuartoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoCuartoDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoEstanteDataGridViewTextBoxColumn
        '
        Me.CodigoEstanteDataGridViewTextBoxColumn.DataPropertyName = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn.HeaderText = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn.Name = "CodigoEstanteDataGridViewTextBoxColumn"
        Me.CodigoEstanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoEstanteDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoTramoDataGridViewTextBoxColumn
        '
        Me.CodigoTramoDataGridViewTextBoxColumn.DataPropertyName = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn.HeaderText = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn.Name = "CodigoTramoDataGridViewTextBoxColumn"
        Me.CodigoTramoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoTramoDataGridViewTextBoxColumn.Visible = False
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpconsultaubicacionproductosBindingSource
        '
        Me.SpconsultaubicacionproductosBindingSource.DataMember = "sp_consulta_ubicacion_productos"
        Me.SpconsultaubicacionproductosBindingSource.DataSource = Me.MELDataSet
        '
        'lbl_Catalogo
        '
        Me.lbl_Catalogo.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Catalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Catalogo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Catalogo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Catalogo.Location = New System.Drawing.Point(3, 248)
        Me.lbl_Catalogo.Name = "lbl_Catalogo"
        Me.lbl_Catalogo.Size = New System.Drawing.Size(724, 24)
        Me.lbl_Catalogo.TabIndex = 10039
        Me.lbl_Catalogo.Text = "Catálogo de productos"
        Me.lbl_Catalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Almacenes
        '
        Me.lbl_Almacenes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Almacenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Almacenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Almacenes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Almacenes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Almacenes.Location = New System.Drawing.Point(12, 90)
        Me.lbl_Almacenes.Name = "lbl_Almacenes"
        Me.lbl_Almacenes.Size = New System.Drawing.Size(262, 24)
        Me.lbl_Almacenes.TabIndex = 10044
        Me.lbl_Almacenes.Text = "Almacenes"
        Me.lbl_Almacenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControlAlmace
        '
        Me.TabControlAlmace.Controls.Add(Me.Ubicación)
        Me.TabControlAlmace.Controls.Add(Me.Reubicación)
        Me.TabControlAlmace.Controls.Add(Me.TabPage1)
        Me.TabControlAlmace.Location = New System.Drawing.Point(280, 12)
        Me.TabControlAlmace.Name = "TabControlAlmace"
        Me.TabControlAlmace.SelectedIndex = 0
        Me.TabControlAlmace.Size = New System.Drawing.Size(740, 663)
        Me.TabControlAlmace.TabIndex = 10048
        '
        'Ubicación
        '
        Me.Ubicación.BackColor = System.Drawing.Color.White
        Me.Ubicación.Controls.Add(Me.Label24)
        Me.Ubicación.Controls.Add(Me.Chk_Exist)
        Me.Ubicación.Controls.Add(Me.lbl_Cuartos)
        Me.Ubicación.Controls.Add(Me.lbl_Estantes)
        Me.Ubicación.Controls.Add(Me.Label17)
        Me.Ubicación.Controls.Add(Me.lbl_Tramos)
        Me.Ubicación.Controls.Add(Me.gb_cuartos)
        Me.Ubicación.Controls.Add(Me.lbl_Catalogo)
        Me.Ubicación.Controls.Add(Me.gb_tramos)
        Me.Ubicación.Controls.Add(Me.gb_estantes)
        Me.Ubicación.Controls.Add(Me.GroupBox2)
        Me.Ubicación.Controls.Add(Me.DGV_Catalogo)
        Me.Ubicación.Location = New System.Drawing.Point(4, 24)
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.Padding = New System.Windows.Forms.Padding(3)
        Me.Ubicación.Size = New System.Drawing.Size(732, 635)
        Me.Ubicación.TabIndex = 0
        Me.Ubicación.Text = "Ubicación"
        '
        'Chk_Exist
        '
        Me.Chk_Exist.AutoSize = True
        Me.Chk_Exist.BackColor = System.Drawing.Color.DodgerBlue
        Me.Chk_Exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Exist.ForeColor = System.Drawing.Color.White
        Me.Chk_Exist.Location = New System.Drawing.Point(617, 249)
        Me.Chk_Exist.Name = "Chk_Exist"
        Me.Chk_Exist.Size = New System.Drawing.Size(74, 19)
        Me.Chk_Exist.TabIndex = 10051
        Me.Chk_Exist.Text = "Exist. > 0"
        Me.Chk_Exist.UseVisualStyleBackColor = False
        '
        'Reubicación
        '
        Me.Reubicación.BackColor = System.Drawing.Color.White
        Me.Reubicación.Controls.Add(Me.DGV_UbicacionActual)
        Me.Reubicación.Controls.Add(Me.Label4)
        Me.Reubicación.Controls.Add(Me.Label2)
        Me.Reubicación.Controls.Add(Me.Label1)
        Me.Reubicación.Controls.Add(Me.DGV_NuevaUbicacion)
        Me.Reubicación.Controls.Add(Me.GroupBox1)
        Me.Reubicación.Controls.Add(Me.bt_aceptar_tab1)
        Me.Reubicación.Controls.Add(Me.bt_cancelar_tab1)
        Me.Reubicación.Location = New System.Drawing.Point(4, 24)
        Me.Reubicación.Name = "Reubicación"
        Me.Reubicación.Padding = New System.Windows.Forms.Padding(3)
        Me.Reubicación.Size = New System.Drawing.Size(732, 635)
        Me.Reubicación.TabIndex = 1
        Me.Reubicación.Text = "Reubicación"
        '
        'DGV_UbicacionActual
        '
        Me.DGV_UbicacionActual.AllowUserToAddRows = False
        Me.DGV_UbicacionActual.AllowUserToResizeRows = False
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.White
        Me.DGV_UbicacionActual.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle36
        Me.DGV_UbicacionActual.AutoGenerateColumns = False
        Me.DGV_UbicacionActual.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_UbicacionActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_UbicacionActual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Qty, Me.CodigoProductoDataGridViewTextBoxColumn1, Me.CodigoFDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn2, Me.MarcaDataGridViewTextBoxColumn1, Me.ModeloDataGridViewTextBoxColumn1, Me.CantidadExistenciaDataGridViewTextBoxColumn1, Me.AquiDataGridViewTextBoxColumn1, Me.CodigoAlmacenDataGridViewTextBoxColumn1, Me.CodigoCuartoDataGridViewTextBoxColumn1, Me.CodigoEstanteDataGridViewTextBoxColumn1, Me.CodigoTramoDataGridViewTextBoxColumn1, Me.UbicacionDataGridViewTextBoxColumn1})
        Me.DGV_UbicacionActual.DataSource = Me.SpconsultaubicacionproductosBindingSource
        Me.DGV_UbicacionActual.EnableHeadersVisualStyles = False
        Me.DGV_UbicacionActual.Location = New System.Drawing.Point(5, 96)
        Me.DGV_UbicacionActual.MultiSelect = False
        Me.DGV_UbicacionActual.Name = "DGV_UbicacionActual"
        Me.DGV_UbicacionActual.RowHeadersVisible = False
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_UbicacionActual.RowsDefaultCellStyle = DataGridViewCellStyle37
        Me.DGV_UbicacionActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_UbicacionActual.Size = New System.Drawing.Size(720, 178)
        Me.DGV_UbicacionActual.TabIndex = 10000
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 30
        '
        'CodigoProductoDataGridViewTextBoxColumn1
        '
        Me.CodigoProductoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoProducto"
        Me.CodigoProductoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoProductoDataGridViewTextBoxColumn1.Name = "CodigoProductoDataGridViewTextBoxColumn1"
        Me.CodigoProductoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoProductoDataGridViewTextBoxColumn1.Width = 85
        '
        'CodigoFDataGridViewTextBoxColumn1
        '
        Me.CodigoFDataGridViewTextBoxColumn1.DataPropertyName = "codigoF"
        Me.CodigoFDataGridViewTextBoxColumn1.HeaderText = "Cod Fab"
        Me.CodigoFDataGridViewTextBoxColumn1.Name = "CodigoFDataGridViewTextBoxColumn1"
        Me.CodigoFDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoFDataGridViewTextBoxColumn1.Width = 85
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        Me.NombreDataGridViewTextBoxColumn2.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn2.Width = 150
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn1.Width = 80
        '
        'ModeloDataGridViewTextBoxColumn1
        '
        Me.ModeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn1.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn1.Name = "ModeloDataGridViewTextBoxColumn1"
        Me.ModeloDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn1.Width = 90
        '
        'CantidadExistenciaDataGridViewTextBoxColumn1
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn1.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn1.HeaderText = "Exis."
        Me.CantidadExistenciaDataGridViewTextBoxColumn1.Name = "CantidadExistenciaDataGridViewTextBoxColumn1"
        Me.CantidadExistenciaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn1.Width = 40
        '
        'AquiDataGridViewTextBoxColumn1
        '
        Me.AquiDataGridViewTextBoxColumn1.DataPropertyName = "aqui"
        Me.AquiDataGridViewTextBoxColumn1.HeaderText = "Aquí"
        Me.AquiDataGridViewTextBoxColumn1.Name = "AquiDataGridViewTextBoxColumn1"
        Me.AquiDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AquiDataGridViewTextBoxColumn1.Width = 40
        '
        'CodigoAlmacenDataGridViewTextBoxColumn1
        '
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.DataPropertyName = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.Name = "CodigoAlmacenDataGridViewTextBoxColumn1"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoCuartoDataGridViewTextBoxColumn1
        '
        Me.CodigoCuartoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.HeaderText = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.Name = "CodigoCuartoDataGridViewTextBoxColumn1"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoCuartoDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoEstanteDataGridViewTextBoxColumn1
        '
        Me.CodigoEstanteDataGridViewTextBoxColumn1.DataPropertyName = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.HeaderText = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.Name = "CodigoEstanteDataGridViewTextBoxColumn1"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoEstanteDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoTramoDataGridViewTextBoxColumn1
        '
        Me.CodigoTramoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn1.HeaderText = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn1.Name = "CodigoTramoDataGridViewTextBoxColumn1"
        Me.CodigoTramoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoTramoDataGridViewTextBoxColumn1.Visible = False
        '
        'UbicacionDataGridViewTextBoxColumn1
        '
        Me.UbicacionDataGridViewTextBoxColumn1.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn1.HeaderText = "Ubicación"
        Me.UbicacionDataGridViewTextBoxColumn1.Name = "UbicacionDataGridViewTextBoxColumn1"
        Me.UbicacionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(5, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(720, 25)
        Me.Label4.TabIndex = 10036
        Me.Label4.Text = "Nueva Ubicación de los Productos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(5, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(720, 24)
        Me.Label2.TabIndex = 10033
        Me.Label2.Text = "Ubicación Actual de los Productos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(714, 23)
        Me.Label1.TabIndex = 10032
        Me.Label1.Text = "Destino"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_NuevaUbicacion
        '
        Me.DGV_NuevaUbicacion.AllowUserToAddRows = False
        Me.DGV_NuevaUbicacion.AllowUserToResizeRows = False
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.White
        Me.DGV_NuevaUbicacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle38
        Me.DGV_NuevaUbicacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_NuevaUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_NuevaUbicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.CodFabrica, Me.DataGridViewTextBoxColumn16, Me.Marca, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.UbicaciónA, Me.UbicaAnterior, Me.cantTramoAnt})
        Me.DGV_NuevaUbicacion.EnableHeadersVisualStyles = False
        Me.DGV_NuevaUbicacion.Location = New System.Drawing.Point(5, 316)
        Me.DGV_NuevaUbicacion.MultiSelect = False
        Me.DGV_NuevaUbicacion.Name = "DGV_NuevaUbicacion"
        Me.DGV_NuevaUbicacion.RowHeadersVisible = False
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_NuevaUbicacion.RowsDefaultCellStyle = DataGridViewCellStyle40
        Me.DGV_NuevaUbicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_NuevaUbicacion.Size = New System.Drawing.Size(720, 284)
        Me.DGV_NuevaUbicacion.TabIndex = 10035
        '
        'DataGridViewTextBoxColumn14
        '
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewTextBoxColumn14.HeaderText = "Qty."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 30
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 85
        '
        'CodFabrica
        '
        Me.CodFabrica.HeaderText = "Cod Fab"
        Me.CodFabrica.Name = "CodFabrica"
        Me.CodFabrica.ReadOnly = True
        Me.CodFabrica.Width = 85
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 135
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 85
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 80
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Nueva Ubic"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 105
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "CodT N"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'UbicaciónA
        '
        Me.UbicaciónA.HeaderText = "Ubic. Ant."
        Me.UbicaciónA.Name = "UbicaciónA"
        Me.UbicaciónA.ReadOnly = True
        '
        'UbicaAnterior
        '
        Me.UbicaAnterior.HeaderText = "CodT A"
        Me.UbicaAnterior.Name = "UbicaAnterior"
        Me.UbicaAnterior.ReadOnly = True
        Me.UbicaAnterior.Visible = False
        Me.UbicaAnterior.Width = 85
        '
        'cantTramoAnt
        '
        Me.cantTramoAnt.HeaderText = "cantTramoAnt"
        Me.cantTramoAnt.Name = "cantTramoAnt"
        Me.cantTramoAnt.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cb_cuarto)
        Me.GroupBox1.Controls.Add(Me.cb_tramo)
        Me.GroupBox1.Controls.Add(Me.cb_almacen)
        Me.GroupBox1.Controls.Add(Me.cb_estante)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 40)
        Me.GroupBox1.TabIndex = 10038
        Me.GroupBox1.TabStop = False
        '
        'cb_cuarto
        '
        Me.cb_cuarto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuarto.DataSource = Me.TblCuartoBindingSource
        Me.cb_cuarto.DisplayMember = "Nombre"
        Me.cb_cuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuarto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cuarto.FormattingEnabled = True
        Me.cb_cuarto.Location = New System.Drawing.Point(237, 13)
        Me.cb_cuarto.Name = "cb_cuarto"
        Me.cb_cuarto.Size = New System.Drawing.Size(117, 23)
        Me.cb_cuarto.TabIndex = 95
        Me.cb_cuarto.ValueMember = "Nombre"
        '
        'TblCuartoBindingSource
        '
        Me.TblCuartoBindingSource.DataMember = "Tbl_Cuarto"
        Me.TblCuartoBindingSource.DataSource = Me.MELDataSet
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DataSource = Me.TblTramoBindingSource
        Me.cb_tramo.DisplayMember = "Nombre"
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(583, 13)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(117, 23)
        Me.cb_tramo.TabIndex = 97
        Me.cb_tramo.ValueMember = "Nombre"
        '
        'TblTramoBindingSource
        '
        Me.TblTramoBindingSource.DataMember = "Tbl_Tramo"
        Me.TblTramoBindingSource.DataSource = Me.MELDataSet
        '
        'cb_almacen
        '
        Me.cb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen.DataSource = Me.TableAlmacenBindingSource
        Me.cb_almacen.DisplayMember = "Nombre"
        Me.cb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen.FormattingEnabled = True
        Me.cb_almacen.Location = New System.Drawing.Point(72, 13)
        Me.cb_almacen.Name = "cb_almacen"
        Me.cb_almacen.Size = New System.Drawing.Size(117, 23)
        Me.cb_almacen.TabIndex = 94
        Me.cb_almacen.ValueMember = "Id"
        '
        'cb_estante
        '
        Me.cb_estante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante.DataSource = Me.TblEstanteBindingSource
        Me.cb_estante.DisplayMember = "Nombre"
        Me.cb_estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_estante.FormattingEnabled = True
        Me.cb_estante.Location = New System.Drawing.Point(412, 13)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(117, 23)
        Me.cb_estante.TabIndex = 96
        Me.cb_estante.ValueMember = "Nombre"
        '
        'TblEstanteBindingSource
        '
        Me.TblEstanteBindingSource.DataMember = "Tbl_Estante"
        Me.TblEstanteBindingSource.DataSource = Me.MELDataSet
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 23)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Almacén:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(537, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 23)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Tramo:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Cuarto:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(363, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 23)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Estante:"
        '
        'bt_aceptar_tab1
        '
        Me.bt_aceptar_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar_tab1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar_tab1.Location = New System.Drawing.Point(277, 606)
        Me.bt_aceptar_tab1.Name = "bt_aceptar_tab1"
        Me.bt_aceptar_tab1.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar_tab1.TabIndex = 10043
        Me.bt_aceptar_tab1.Text = "Aceptar"
        '
        'bt_cancelar_tab1
        '
        Me.bt_cancelar_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar_tab1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar_tab1.Location = New System.Drawing.Point(383, 606)
        Me.bt_cancelar_tab1.Name = "bt_cancelar_tab1"
        Me.bt_cancelar_tab1.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar_tab1.TabIndex = 10044
        Me.bt_cancelar_tab1.Text = "Cancelar"
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.tb_almacenes)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.DGV_ProductoActual)
        Me.TabPage1.Controls.Add(Me.cb_aceptar_D)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(732, 635)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Mover"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(371, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 23)
        Me.Label5.TabIndex = 10048
        Me.Label5.Text = "Hasta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(69, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 23)
        Me.Label6.TabIndex = 10046
        Me.Label6.Text = "Desde"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(6, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(716, 24)
        Me.Label15.TabIndex = 10052
        Me.Label15.Text = "Productos en Ubicación Actual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_almacenes
        '
        Me.tb_almacenes.BackColor = System.Drawing.Color.White
        Me.tb_almacenes.Controls.Add(Me.cb_tramoD)
        Me.tb_almacenes.Controls.Add(Me.cb_estanteD)
        Me.tb_almacenes.Controls.Add(Me.cb_cuartoD)
        Me.tb_almacenes.Controls.Add(Me.cb_almacenD)
        Me.tb_almacenes.Controls.Add(Me.Label11)
        Me.tb_almacenes.Controls.Add(Me.Label12)
        Me.tb_almacenes.Controls.Add(Me.Label13)
        Me.tb_almacenes.Controls.Add(Me.Label14)
        Me.tb_almacenes.Location = New System.Drawing.Point(69, 46)
        Me.tb_almacenes.Name = "tb_almacenes"
        Me.tb_almacenes.Size = New System.Drawing.Size(234, 209)
        Me.tb_almacenes.TabIndex = 10045
        Me.tb_almacenes.TabStop = False
        '
        'cb_tramoD
        '
        Me.cb_tramoD.DataSource = Me.TblTramoBindingSource
        Me.cb_tramoD.DisplayMember = "Nombre"
        Me.cb_tramoD.FormattingEnabled = True
        Me.cb_tramoD.Location = New System.Drawing.Point(91, 171)
        Me.cb_tramoD.Name = "cb_tramoD"
        Me.cb_tramoD.Size = New System.Drawing.Size(121, 23)
        Me.cb_tramoD.TabIndex = 106
        Me.cb_tramoD.ValueMember = "Nombre"
        '
        'cb_estanteD
        '
        Me.cb_estanteD.DataSource = Me.TblEstanteBindingSource
        Me.cb_estanteD.DisplayMember = "Nombre"
        Me.cb_estanteD.FormattingEnabled = True
        Me.cb_estanteD.Location = New System.Drawing.Point(91, 121)
        Me.cb_estanteD.Name = "cb_estanteD"
        Me.cb_estanteD.Size = New System.Drawing.Size(121, 23)
        Me.cb_estanteD.TabIndex = 105
        Me.cb_estanteD.ValueMember = "Nombre"
        '
        'cb_cuartoD
        '
        Me.cb_cuartoD.DataSource = Me.TblCuartoBindingSource
        Me.cb_cuartoD.DisplayMember = "Nombre"
        Me.cb_cuartoD.FormattingEnabled = True
        Me.cb_cuartoD.Location = New System.Drawing.Point(91, 71)
        Me.cb_cuartoD.Name = "cb_cuartoD"
        Me.cb_cuartoD.Size = New System.Drawing.Size(121, 23)
        Me.cb_cuartoD.TabIndex = 104
        Me.cb_cuartoD.ValueMember = "Nombre"
        '
        'cb_almacenD
        '
        Me.cb_almacenD.DataSource = Me.TableAlmacenBindingSource1
        Me.cb_almacenD.DisplayMember = "Nombre"
        Me.cb_almacenD.FormattingEnabled = True
        Me.cb_almacenD.Location = New System.Drawing.Point(91, 21)
        Me.cb_almacenD.Name = "cb_almacenD"
        Me.cb_almacenD.Size = New System.Drawing.Size(121, 23)
        Me.cb_almacenD.TabIndex = 103
        Me.cb_almacenD.ValueMember = "Nombre"
        '
        'TableAlmacenBindingSource1
        '
        Me.TableAlmacenBindingSource1.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource1.DataSource = Me.MELDataSet
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 23)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "(*)Tramo:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 23)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "(*)Estante:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 23)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "(*)Cuarto:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "(*)Almacén:"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.cb_tramoH)
        Me.GroupBox9.Controls.Add(Me.cb_estanteH)
        Me.GroupBox9.Controls.Add(Me.cb_cuartoH)
        Me.GroupBox9.Controls.Add(Me.cb_almacenH)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(371, 46)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(234, 209)
        Me.GroupBox9.TabIndex = 10047
        Me.GroupBox9.TabStop = False
        '
        'cb_tramoH
        '
        Me.cb_tramoH.DataSource = Me.TblTramoBindingSource1
        Me.cb_tramoH.DisplayMember = "Nombre"
        Me.cb_tramoH.FormattingEnabled = True
        Me.cb_tramoH.Location = New System.Drawing.Point(98, 171)
        Me.cb_tramoH.Name = "cb_tramoH"
        Me.cb_tramoH.Size = New System.Drawing.Size(121, 23)
        Me.cb_tramoH.TabIndex = 110
        Me.cb_tramoH.ValueMember = "Nombre"
        '
        'TblTramoBindingSource1
        '
        Me.TblTramoBindingSource1.DataMember = "Tbl_Tramo"
        Me.TblTramoBindingSource1.DataSource = Me.MELDataSet
        '
        'cb_estanteH
        '
        Me.cb_estanteH.DataSource = Me.TblEstanteBindingSource1
        Me.cb_estanteH.DisplayMember = "Nombre"
        Me.cb_estanteH.FormattingEnabled = True
        Me.cb_estanteH.Location = New System.Drawing.Point(98, 121)
        Me.cb_estanteH.Name = "cb_estanteH"
        Me.cb_estanteH.Size = New System.Drawing.Size(121, 23)
        Me.cb_estanteH.TabIndex = 109
        Me.cb_estanteH.ValueMember = "Nombre"
        '
        'TblEstanteBindingSource1
        '
        Me.TblEstanteBindingSource1.DataMember = "Tbl_Estante"
        Me.TblEstanteBindingSource1.DataSource = Me.MELDataSet
        '
        'cb_cuartoH
        '
        Me.cb_cuartoH.DataSource = Me.TblCuartoBindingSource1
        Me.cb_cuartoH.DisplayMember = "Nombre"
        Me.cb_cuartoH.FormattingEnabled = True
        Me.cb_cuartoH.Location = New System.Drawing.Point(98, 71)
        Me.cb_cuartoH.Name = "cb_cuartoH"
        Me.cb_cuartoH.Size = New System.Drawing.Size(121, 23)
        Me.cb_cuartoH.TabIndex = 108
        Me.cb_cuartoH.ValueMember = "Nombre"
        '
        'TblCuartoBindingSource1
        '
        Me.TblCuartoBindingSource1.DataMember = "Tbl_Cuarto"
        Me.TblCuartoBindingSource1.DataSource = Me.MELDataSet
        '
        'cb_almacenH
        '
        Me.cb_almacenH.DataSource = Me.TableAlmacenBindingSource
        Me.cb_almacenH.DisplayMember = "Nombre"
        Me.cb_almacenH.FormattingEnabled = True
        Me.cb_almacenH.Location = New System.Drawing.Point(98, 21)
        Me.cb_almacenH.Name = "cb_almacenH"
        Me.cb_almacenH.Size = New System.Drawing.Size(121, 23)
        Me.cb_almacenH.TabIndex = 107
        Me.cb_almacenH.ValueMember = "Nombre"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 23)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "(*)Tramo:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "(*)Estante:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 23)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "(*)Cuarto:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 23)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "(*)Almacén:"
        '
        'DGV_ProductoActual
        '
        Me.DGV_ProductoActual.AllowUserToAddRows = False
        Me.DGV_ProductoActual.AllowUserToDeleteRows = False
        Me.DGV_ProductoActual.AllowUserToResizeRows = False
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.White
        Me.DGV_ProductoActual.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle34
        Me.DGV_ProductoActual.AutoGenerateColumns = False
        Me.DGV_ProductoActual.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_ProductoActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_ProductoActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductoActual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProductoDataGridViewTextBoxColumn2, Me.CodigoFDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn3, Me.MarcaDataGridViewTextBoxColumn2, Me.ModeloDataGridViewTextBoxColumn2, Me.CantidadExistenciaDataGridViewTextBoxColumn2, Me.AquiDataGridViewTextBoxColumn2, Me.CodigoAlmacenDataGridViewTextBoxColumn2, Me.CodigoCuartoDataGridViewTextBoxColumn2, Me.CodigoEstanteDataGridViewTextBoxColumn2, Me.CodigoTramoDataGridViewTextBoxColumn2, Me.UbicacionDataGridViewTextBoxColumn2})
        Me.DGV_ProductoActual.DataSource = Me.SpconsultaubicacionproductosBindingSource
        Me.DGV_ProductoActual.EnableHeadersVisualStyles = False
        Me.DGV_ProductoActual.Location = New System.Drawing.Point(6, 285)
        Me.DGV_ProductoActual.MultiSelect = False
        Me.DGV_ProductoActual.Name = "DGV_ProductoActual"
        Me.DGV_ProductoActual.ReadOnly = True
        Me.DGV_ProductoActual.RowHeadersVisible = False
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ProductoActual.RowsDefaultCellStyle = DataGridViewCellStyle35
        Me.DGV_ProductoActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ProductoActual.Size = New System.Drawing.Size(713, 315)
        Me.DGV_ProductoActual.TabIndex = 10053
        '
        'CodigoProductoDataGridViewTextBoxColumn2
        '
        Me.CodigoProductoDataGridViewTextBoxColumn2.DataPropertyName = "CodigoProducto"
        Me.CodigoProductoDataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.CodigoProductoDataGridViewTextBoxColumn2.Name = "CodigoProductoDataGridViewTextBoxColumn2"
        Me.CodigoProductoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoProductoDataGridViewTextBoxColumn2.Width = 95
        '
        'CodigoFDataGridViewTextBoxColumn2
        '
        Me.CodigoFDataGridViewTextBoxColumn2.DataPropertyName = "codigoF"
        Me.CodigoFDataGridViewTextBoxColumn2.HeaderText = "Código F."
        Me.CodigoFDataGridViewTextBoxColumn2.Name = "CodigoFDataGridViewTextBoxColumn2"
        Me.CodigoFDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoFDataGridViewTextBoxColumn2.Width = 95
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        Me.NombreDataGridViewTextBoxColumn3.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn3.Width = 150
        '
        'MarcaDataGridViewTextBoxColumn2
        '
        Me.MarcaDataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn2.Name = "MarcaDataGridViewTextBoxColumn2"
        Me.MarcaDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn2.Width = 68
        '
        'ModeloDataGridViewTextBoxColumn2
        '
        Me.ModeloDataGridViewTextBoxColumn2.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn2.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn2.Name = "ModeloDataGridViewTextBoxColumn2"
        Me.ModeloDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn2.Width = 75
        '
        'CantidadExistenciaDataGridViewTextBoxColumn2
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn2.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn2.HeaderText = "Exis."
        Me.CantidadExistenciaDataGridViewTextBoxColumn2.Name = "CantidadExistenciaDataGridViewTextBoxColumn2"
        Me.CantidadExistenciaDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn2.Width = 50
        '
        'AquiDataGridViewTextBoxColumn2
        '
        Me.AquiDataGridViewTextBoxColumn2.DataPropertyName = "aqui"
        Me.AquiDataGridViewTextBoxColumn2.HeaderText = "Aquí"
        Me.AquiDataGridViewTextBoxColumn2.Name = "AquiDataGridViewTextBoxColumn2"
        Me.AquiDataGridViewTextBoxColumn2.ReadOnly = True
        Me.AquiDataGridViewTextBoxColumn2.Width = 50
        '
        'CodigoAlmacenDataGridViewTextBoxColumn2
        '
        Me.CodigoAlmacenDataGridViewTextBoxColumn2.DataPropertyName = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn2.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn2.Name = "CodigoAlmacenDataGridViewTextBoxColumn2"
        Me.CodigoAlmacenDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoAlmacenDataGridViewTextBoxColumn2.Visible = False
        '
        'CodigoCuartoDataGridViewTextBoxColumn2
        '
        Me.CodigoCuartoDataGridViewTextBoxColumn2.DataPropertyName = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn2.HeaderText = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn2.Name = "CodigoCuartoDataGridViewTextBoxColumn2"
        Me.CodigoCuartoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoCuartoDataGridViewTextBoxColumn2.Visible = False
        '
        'CodigoEstanteDataGridViewTextBoxColumn2
        '
        Me.CodigoEstanteDataGridViewTextBoxColumn2.DataPropertyName = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn2.HeaderText = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn2.Name = "CodigoEstanteDataGridViewTextBoxColumn2"
        Me.CodigoEstanteDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoEstanteDataGridViewTextBoxColumn2.Visible = False
        '
        'CodigoTramoDataGridViewTextBoxColumn2
        '
        Me.CodigoTramoDataGridViewTextBoxColumn2.DataPropertyName = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn2.HeaderText = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn2.Name = "CodigoTramoDataGridViewTextBoxColumn2"
        Me.CodigoTramoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CodigoTramoDataGridViewTextBoxColumn2.Visible = False
        '
        'UbicacionDataGridViewTextBoxColumn2
        '
        Me.UbicacionDataGridViewTextBoxColumn2.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn2.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn2.Name = "UbicacionDataGridViewTextBoxColumn2"
        Me.UbicacionDataGridViewTextBoxColumn2.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn2.Width = 110
        '
        'cb_aceptar_D
        '
        Me.cb_aceptar_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_aceptar_D.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_aceptar_D.Location = New System.Drawing.Point(297, 606)
        Me.cb_aceptar_D.Name = "cb_aceptar_D"
        Me.cb_aceptar_D.Size = New System.Drawing.Size(75, 23)
        Me.cb_aceptar_D.TabIndex = 10049
        Me.cb_aceptar_D.Text = "Mover"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown2.FormattingEnabled = True
        Me.DomainUpDown2.Items.AddRange(New Object() {"Código", "Código F.", "Descripción"})
        Me.DomainUpDown2.Location = New System.Drawing.Point(10, 59)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(126, 23)
        Me.DomainUpDown2.TabIndex = 10049
        '
        'Table_AlmacenTableAdapter
        '
        Me.Table_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'Sp_consulta_ubicacion_productosTableAdapter
        '
        Me.Sp_consulta_ubicacion_productosTableAdapter.ClearBeforeFill = True
        '
        'Tbl_CuartoTableAdapter
        '
        Me.Tbl_CuartoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_EstanteTableAdapter
        '
        Me.Tbl_EstanteTableAdapter.ClearBeforeFill = True
        '
        'Tbl_TramoTableAdapter
        '
        Me.Tbl_TramoTableAdapter.ClearBeforeFill = True
        '
        'Frm_Almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 714)
        Me.ControlBox = False
        Me.Controls.Add(Me.DomainUpDown2)
        Me.Controls.Add(Me.TabControlAlmace)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.lbl_Almacenes)
        Me.Controls.Add(Me.DGV_Almacenes)
        Me.Controls.Add(Me.tb_buscar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Frm_Almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Almacenes"
        CType(Me.DGV_Cuartos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Almacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableAlmacenBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_cuartos.ResumeLayout(False)
        Me.gb_cuartos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Tramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tramos.ResumeLayout(False)
        Me.gb_tramos.PerformLayout()
        Me.gb_estantes.ResumeLayout(False)
        Me.gb_estantes.PerformLayout()
        CType(Me.DGV_Estantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Catalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaubicacionproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAlmace.ResumeLayout(False)
        Me.Ubicación.ResumeLayout(False)
        Me.Ubicación.PerformLayout()
        Me.Reubicación.ResumeLayout(False)
        CType(Me.DGV_UbicacionActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_NuevaUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TblCuartoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTramoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEstanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.tb_almacenes.ResumeLayout(False)
        CType(Me.TableAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.TblTramoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEstanteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCuartoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ProductoActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Cuartos As System.Windows.Forms.DataGridView
    Friend WithEvents LblNombreCuarto As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_catalogo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_agregarCuarto As System.Windows.Forms.Button
    Friend WithEvents DGV_Almacenes As System.Windows.Forms.DataGridView
    Friend WithEvents bt_eliminarCuarto As System.Windows.Forms.Button
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents gb_cuartos As System.Windows.Forms.GroupBox
    Friend WithEvents bt_ModificarCuarto As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_DireccionAlmacen As System.Windows.Forms.Label
    Friend WithEvents tb_direccionAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NombreAlmacen As System.Windows.Forms.Label
    Friend WithEvents Tb_NombreAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents DGV_Catalogo As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Catalogo As System.Windows.Forms.Label
    Friend WithEvents lbl_Almacenes As System.Windows.Forms.Label
    Friend WithEvents lbl_Tramos As System.Windows.Forms.Label
    Friend WithEvents lbl_Estantes As System.Windows.Forms.Label
    Friend WithEvents gb_tramos As System.Windows.Forms.GroupBox
    Friend WithEvents bt_ModificarTramo As System.Windows.Forms.Button
    Friend WithEvents DGV_Tramos As System.Windows.Forms.DataGridView
    Friend WithEvents LblNombreTramo As System.Windows.Forms.Label
    Friend WithEvents bt_AgregarTramo As System.Windows.Forms.Button
    Friend WithEvents bt_EliminarTramo As System.Windows.Forms.Button
    Friend WithEvents gb_estantes As System.Windows.Forms.GroupBox
    Friend WithEvents bt_modificarEstante As System.Windows.Forms.Button
    Friend WithEvents DGV_Estantes As System.Windows.Forms.DataGridView
    Friend WithEvents LblNombreEstante As System.Windows.Forms.Label
    Friend WithEvents bt_agregarEstante As System.Windows.Forms.Button
    Friend WithEvents bt_EliminarEstante As System.Windows.Forms.Button
    Friend WithEvents lbl_Cuartos As System.Windows.Forms.Label
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Table_AlmacenTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
    Friend WithEvents TableAlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuarto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_NombreCuarto As System.Windows.Forms.TextBox
    Friend WithEvents tb_NombreTramo As System.Windows.Forms.TextBox
    Friend WithEvents tb_NombreEstante As System.Windows.Forms.TextBox
    Friend WithEvents bt_reporte As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabControlAlmace As System.Windows.Forms.TabControl
    Friend WithEvents Ubicación As System.Windows.Forms.TabPage
    Friend WithEvents Reubicación As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar_tab1 As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar_tab1 As System.Windows.Forms.Button
    Friend WithEvents cb_cuarto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cb_aceptar_D As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_almacenes As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DGV_ProductoActual As System.Windows.Forms.DataGridView
    Friend WithEvents Chk_Exist As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV_NuevaUbicacion As System.Windows.Forms.DataGridView
    Friend WithEvents SpconsultaubicacionproductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consulta_ubicacion_productosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_ubicacion_productosTableAdapter
    Friend WithEvents DGV_UbicacionActual As Tesis_Nueva.MyDGVdigit
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AquiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb_almacenD As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacenH As System.Windows.Forms.ComboBox
    Friend WithEvents TableAlmacenBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cb_cuartoD As System.Windows.Forms.ComboBox
    Friend WithEvents TblCuartoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_CuartoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_CuartoTableAdapter
    Friend WithEvents cb_tramoD As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estanteD As System.Windows.Forms.ComboBox
    Friend WithEvents TblEstanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_EstanteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_EstanteTableAdapter
    Friend WithEvents TblTramoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_TramoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_TramoTableAdapter
    Friend WithEvents cb_tramoH As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estanteH As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cuartoH As System.Windows.Forms.ComboBox
    Friend WithEvents TblTramoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblEstanteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblCuartoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAlmacenBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AquiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AquiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodFabrica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicaciónA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicaAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantTramoAnt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
