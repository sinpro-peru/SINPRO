<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Inventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_reporte = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantNueva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dif = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_consultaProductosParaInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Dgv_ProductosI = New System.Windows.Forms.DataGridView
        Me.CodigoInternoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFabrica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_consultaProductosInvetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cb_almacenes = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.cb_cuartos = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_Usuario = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Tb_Descripcion = New System.Windows.Forms.TextBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.DGV_Inventarios = New System.Windows.Forms.DataGridView
        Me.CodigoInv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ajustado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.chk_dif = New System.Windows.Forms.CheckBox
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.Sp_consultaProductosParaInventarioTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosParaInventarioTableAdapter
        Me.Sp_consultaProductosInvetarioTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosInvetarioTableAdapter
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaProductosParaInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ProductosI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaProductosInvetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_Inventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_reporte, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(60, 45)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-7, 6)
        Me.ToolBar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(288, 54)
        Me.ToolBar1.TabIndex = 10031
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
        'bt_reporte
        '
        Me.bt_reporte.ImageIndex = 5
        Me.bt_reporte.Name = "bt_reporte"
        Me.bt_reporte.Text = "Dif."
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 3
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Cerrar"
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
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Items.AddRange(New Object() {"Código Inventario", "Código Interno", "Descripción", "Código Fábrica"})
        Me.DomainUpDown1.Location = New System.Drawing.Point(4, 65)
        Me.DomainUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(130, 23)
        Me.DomainUpDown1.TabIndex = 10042
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.DGV_Productos)
        Me.GroupBox3.Controls.Add(Me.Dgv_ProductosI)
        Me.GroupBox3.Location = New System.Drawing.Point(263, 186)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(797, 505)
        Me.GroupBox3.TabIndex = 10035
        Me.GroupBox3.TabStop = False
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CantNueva, Me.Dif, Me.Observacion2, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.CodigoTramoDataGridViewTextBoxColumn, Me.CodigoEstanteDataGridViewTextBoxColumn, Me.CodigoCuartoDataGridViewTextBoxColumn, Me.CodigoAlmacenDataGridViewTextBoxColumn, Me.PrecioVenta, Me.DataGridViewTextBoxColumn1})
        Me.DGV_Productos.DataSource = Me.Sp_consultaProductosParaInventarioBindingSource
        Me.DGV_Productos.Location = New System.Drawing.Point(4, 11)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.RowHeadersVisible = False
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(790, 489)
        Me.DGV_Productos.TabIndex = 0
        Me.DGV_Productos.Visible = False
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Width = 90
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 210
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Visible = False
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 120
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Ant."
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 40
        '
        'CantNueva
        '
        Me.CantNueva.DataPropertyName = "Cantidad2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantNueva.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantNueva.HeaderText = "Act."
        Me.CantNueva.Name = "CantNueva"
        Me.CantNueva.ReadOnly = True
        Me.CantNueva.Width = 40
        '
        'Dif
        '
        Me.Dif.DataPropertyName = "Dif"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Dif.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dif.HeaderText = "Dif."
        Me.Dif.Name = "Dif"
        Me.Dif.ReadOnly = True
        Me.Dif.Width = 40
        '
        'Observacion2
        '
        Me.Observacion2.DataPropertyName = "Observacion"
        Me.Observacion2.HeaderText = "Obs."
        Me.Observacion2.Name = "Observacion2"
        Me.Observacion2.ReadOnly = True
        Me.Observacion2.Width = 130
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Visible = False
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
        'CodigoEstanteDataGridViewTextBoxColumn
        '
        Me.CodigoEstanteDataGridViewTextBoxColumn.DataPropertyName = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn.HeaderText = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn.Name = "CodigoEstanteDataGridViewTextBoxColumn"
        Me.CodigoEstanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoEstanteDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoCuartoDataGridViewTextBoxColumn
        '
        Me.CodigoCuartoDataGridViewTextBoxColumn.DataPropertyName = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn.HeaderText = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn.Name = "CodigoCuartoDataGridViewTextBoxColumn"
        Me.CodigoCuartoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoCuartoDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoAlmacenDataGridViewTextBoxColumn
        '
        Me.CodigoAlmacenDataGridViewTextBoxColumn.DataPropertyName = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.Name = "CodigoAlmacenDataGridViewTextBoxColumn"
        Me.CodigoAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioVenta
        '
        Me.PrecioVenta.DataPropertyName = "PrecioVenta"
        Me.PrecioVenta.HeaderText = "PrecioVenta"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        Me.PrecioVenta.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoFabrica"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoFabrica"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'Sp_consultaProductosParaInventarioBindingSource
        '
        Me.Sp_consultaProductosParaInventarioBindingSource.DataMember = "sp_consultaProductosParaInventario"
        Me.Sp_consultaProductosParaInventarioBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dgv_ProductosI
        '
        Me.Dgv_ProductosI.AllowUserToAddRows = False
        Me.Dgv_ProductosI.AllowUserToDeleteRows = False
        Me.Dgv_ProductosI.AllowUserToResizeRows = False
        Me.Dgv_ProductosI.AutoGenerateColumns = False
        Me.Dgv_ProductosI.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_ProductosI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ProductosI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.MarcaDataGridViewTextBoxColumn1, Me.ModeloDataGridViewTextBoxColumn1, Me.CantidadAnteriorDataGridViewTextBoxColumn, Me.CantidadActualDataGridViewTextBoxColumn, Me.DIFDataGridViewTextBoxColumn, Me.Observacion, Me.UbicacionDataGridViewTextBoxColumn1, Me.CodigoTramoDataGridViewTextBoxColumn1, Me.CodigoEstanteDataGridViewTextBoxColumn1, Me.CodigoCuartoDataGridViewTextBoxColumn1, Me.CodigoAlmacenDataGridViewTextBoxColumn1, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CodigoFabrica})
        Me.Dgv_ProductosI.DataSource = Me.Sp_consultaProductosInvetarioBindingSource
        Me.Dgv_ProductosI.Location = New System.Drawing.Point(4, 11)
        Me.Dgv_ProductosI.MultiSelect = False
        Me.Dgv_ProductosI.Name = "Dgv_ProductosI"
        Me.Dgv_ProductosI.RowHeadersVisible = False
        Me.Dgv_ProductosI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_ProductosI.Size = New System.Drawing.Size(790, 489)
        Me.Dgv_ProductosI.TabIndex = 10044
        '
        'CodigoInternoDataGridViewTextBoxColumn1
        '
        Me.CodigoInternoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoInterno"
        Me.CodigoInternoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoInternoDataGridViewTextBoxColumn1.Name = "CodigoInternoDataGridViewTextBoxColumn1"
        Me.CodigoInternoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn1.Width = 90
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn1.Width = 210
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn1.Visible = False
        '
        'ModeloDataGridViewTextBoxColumn1
        '
        Me.ModeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn1.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn1.Name = "ModeloDataGridViewTextBoxColumn1"
        Me.ModeloDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn1.Width = 120
        '
        'CantidadAnteriorDataGridViewTextBoxColumn
        '
        Me.CantidadAnteriorDataGridViewTextBoxColumn.DataPropertyName = "CantidadAnterior"
        Me.CantidadAnteriorDataGridViewTextBoxColumn.HeaderText = "Ant."
        Me.CantidadAnteriorDataGridViewTextBoxColumn.Name = "CantidadAnteriorDataGridViewTextBoxColumn"
        Me.CantidadAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadAnteriorDataGridViewTextBoxColumn.Width = 40
        '
        'CantidadActualDataGridViewTextBoxColumn
        '
        Me.CantidadActualDataGridViewTextBoxColumn.DataPropertyName = "CantidadActual"
        Me.CantidadActualDataGridViewTextBoxColumn.HeaderText = "Act."
        Me.CantidadActualDataGridViewTextBoxColumn.Name = "CantidadActualDataGridViewTextBoxColumn"
        Me.CantidadActualDataGridViewTextBoxColumn.Width = 40
        '
        'DIFDataGridViewTextBoxColumn
        '
        Me.DIFDataGridViewTextBoxColumn.DataPropertyName = "DIF"
        Me.DIFDataGridViewTextBoxColumn.HeaderText = "Dif."
        Me.DIFDataGridViewTextBoxColumn.Name = "DIFDataGridViewTextBoxColumn"
        Me.DIFDataGridViewTextBoxColumn.ReadOnly = True
        Me.DIFDataGridViewTextBoxColumn.Width = 40
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "Observacion"
        Me.Observacion.HeaderText = "Obs."
        Me.Observacion.Name = "Observacion"
        Me.Observacion.Width = 130
        '
        'UbicacionDataGridViewTextBoxColumn1
        '
        Me.UbicacionDataGridViewTextBoxColumn1.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn1.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn1.Name = "UbicacionDataGridViewTextBoxColumn1"
        Me.UbicacionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CodigoTramoDataGridViewTextBoxColumn1
        '
        Me.CodigoTramoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn1.HeaderText = "CodigoTramo"
        Me.CodigoTramoDataGridViewTextBoxColumn1.Name = "CodigoTramoDataGridViewTextBoxColumn1"
        Me.CodigoTramoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoTramoDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoEstanteDataGridViewTextBoxColumn1
        '
        Me.CodigoEstanteDataGridViewTextBoxColumn1.DataPropertyName = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.HeaderText = "CodigoEstante"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.Name = "CodigoEstanteDataGridViewTextBoxColumn1"
        Me.CodigoEstanteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoEstanteDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoCuartoDataGridViewTextBoxColumn1
        '
        Me.CodigoCuartoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.HeaderText = "CodigoCuarto"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.Name = "CodigoCuartoDataGridViewTextBoxColumn1"
        Me.CodigoCuartoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoCuartoDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoAlmacenDataGridViewTextBoxColumn1
        '
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.DataPropertyName = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.Name = "CodigoAlmacenDataGridViewTextBoxColumn1"
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoAlmacenDataGridViewTextBoxColumn1.Visible = False
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoFabrica
        '
        Me.CodigoFabrica.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabrica.HeaderText = "CodigoFabrica"
        Me.CodigoFabrica.Name = "CodigoFabrica"
        Me.CodigoFabrica.ReadOnly = True
        Me.CodigoFabrica.Width = 150
        '
        'Sp_consultaProductosInvetarioBindingSource
        '
        Me.Sp_consultaProductosInvetarioBindingSource.DataMember = "sp_consultaProductosInvetario"
        Me.Sp_consultaProductosInvetarioBindingSource.DataSource = Me.MELDataSet
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(263, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(797, 23)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Productos del inventario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 699)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 10041
        Me.Label5.Text = "#"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(153, 699)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 10040
        Me.Label8.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(685, 703)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10039
        Me.Button1.Text = "Cancelar"
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(573, 703)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 10038
        Me.Button2.Text = "Aceptar"
        Me.Button2.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(268, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(788, 22)
        Me.Label3.TabIndex = 10033
        Me.Label3.Text = "Detalles del conteo de inventario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.Panel2)
        Me.groupbox1.Controls.Add(Me.tb_Usuario)
        Me.groupbox1.Controls.Add(Me.Label11)
        Me.groupbox1.Controls.Add(Me.dtp_fecha)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Label14)
        Me.groupbox1.Controls.Add(Me.tb_codigo)
        Me.groupbox1.Controls.Add(Me.Label10)
        Me.groupbox1.Controls.Add(Me.Tb_Descripcion)
        Me.groupbox1.Controls.Add(Me.txt1)
        Me.groupbox1.Location = New System.Drawing.Point(268, 17)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Size = New System.Drawing.Size(791, 151)
        Me.groupbox1.TabIndex = 10034
        Me.groupbox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cb_tramo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cb_estante)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cb_almacenes)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.cb_cuartos)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Enabled = False
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(5, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 29)
        Me.Panel2.TabIndex = 77
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Enabled = False
        Me.cb_tramo.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(656, 3)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(103, 22)
        Me.cb_tramo.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(596, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "(*)Tramo:"
        '
        'cb_estante
        '
        Me.cb_estante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante.Enabled = False
        Me.cb_estante.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_estante.FormattingEnabled = True
        Me.cb_estante.Location = New System.Drawing.Point(487, 2)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(103, 22)
        Me.cb_estante.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(426, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "(*)Estante:"
        '
        'cb_almacenes
        '
        Me.cb_almacenes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacenes.DisplayMember = "Nombre"
        Me.cb_almacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacenes.Enabled = False
        Me.cb_almacenes.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_almacenes.FormattingEnabled = True
        Me.cb_almacenes.Location = New System.Drawing.Point(153, 2)
        Me.cb_almacenes.Name = "cb_almacenes"
        Me.cb_almacenes.Size = New System.Drawing.Size(103, 22)
        Me.cb_almacenes.TabIndex = 105
        Me.cb_almacenes.ValueMember = "Id"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 18)
        Me.CheckBox1.TabIndex = 108
        Me.CheckBox1.Text = "Filtrar por:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cb_cuartos
        '
        Me.cb_cuartos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuartos.Enabled = False
        Me.cb_cuartos.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_cuartos.FormattingEnabled = True
        Me.cb_cuartos.Location = New System.Drawing.Point(319, 2)
        Me.cb_cuartos.Name = "cb_cuartos"
        Me.cb_cuartos.Size = New System.Drawing.Size(103, 22)
        Me.cb_cuartos.TabIndex = 106
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label15.Location = New System.Drawing.Point(258, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "(*)Cuarto:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(81, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "(*)Almacén:"
        '
        'tb_Usuario
        '
        Me.tb_Usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Usuario.Location = New System.Drawing.Point(104, 42)
        Me.tb_Usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_Usuario.Name = "tb_Usuario"
        Me.tb_Usuario.ReadOnly = True
        Me.tb_Usuario.Size = New System.Drawing.Size(112, 22)
        Me.tb_Usuario.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "(*)Realizado:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(332, 20)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 22)
        Me.dtp_fecha.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(226, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "(*)Fecha:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(226, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 17)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "(*)Observación:"
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(104, 18)
        Me.tb_codigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.ReadOnly = True
        Me.tb_codigo.Size = New System.Drawing.Size(112, 22)
        Me.tb_codigo.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "(*)Código:"
        '
        'Tb_Descripcion
        '
        Me.Tb_Descripcion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Descripcion.Location = New System.Drawing.Point(332, 43)
        Me.Tb_Descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tb_Descripcion.Multiline = True
        Me.Tb_Descripcion.Name = "Tb_Descripcion"
        Me.Tb_Descripcion.ReadOnly = True
        Me.Tb_Descripcion.Size = New System.Drawing.Size(444, 61)
        Me.Tb_Descripcion.TabIndex = 69
        Me.Tb_Descripcion.Text = " "
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(636, 43)
        Me.txt1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(112, 22)
        Me.txt1.TabIndex = 78
        Me.txt1.Visible = False
        '
        'DGV_Inventarios
        '
        Me.DGV_Inventarios.AllowUserToAddRows = False
        Me.DGV_Inventarios.AllowUserToDeleteRows = False
        Me.DGV_Inventarios.AllowUserToResizeColumns = False
        Me.DGV_Inventarios.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_Inventarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Inventarios.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Inventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Inventarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInv, Me.Fecha, Me.Usuario, Me.Ajustado, Me.Obs})
        Me.DGV_Inventarios.EnableHeadersVisualStyles = False
        Me.DGV_Inventarios.Location = New System.Drawing.Point(4, 97)
        Me.DGV_Inventarios.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_Inventarios.MultiSelect = False
        Me.DGV_Inventarios.Name = "DGV_Inventarios"
        Me.DGV_Inventarios.ReadOnly = True
        Me.DGV_Inventarios.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Inventarios.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Inventarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Inventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Inventarios.Size = New System.Drawing.Size(247, 596)
        Me.DGV_Inventarios.TabIndex = 10032
        '
        'CodigoInv
        '
        Me.CodigoInv.HeaderText = "Cod."
        Me.CodigoInv.Name = "CodigoInv"
        Me.CodigoInv.ReadOnly = True
        Me.CodigoInv.Width = 35
        '
        'Fecha
        '
        DataGridViewCellStyle5.Format = "d"
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 85
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 80
        '
        'Ajustado
        '
        Me.Ajustado.HeaderText = "Aj."
        Me.Ajustado.Name = "Ajustado"
        Me.Ajustado.ReadOnly = True
        Me.Ajustado.Width = 25
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Visible = False
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(139, 64)
        Me.tb_buscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(110, 25)
        Me.tb_buscar.TabIndex = 10030
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(461, 703)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 10043
        Me.Button3.Text = "Aplicar"
        Me.Button3.Visible = False
        '
        'chk_dif
        '
        Me.chk_dif.AutoSize = True
        Me.chk_dif.BackColor = System.Drawing.Color.DodgerBlue
        Me.chk_dif.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.chk_dif.ForeColor = System.Drawing.Color.White
        Me.chk_dif.Location = New System.Drawing.Point(275, 173)
        Me.chk_dif.Name = "chk_dif"
        Me.chk_dif.Size = New System.Drawing.Size(163, 18)
        Me.chk_dif.TabIndex = 110
        Me.chk_dif.Text = "Productos con diferencias"
        Me.chk_dif.UseVisualStyleBackColor = False
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.BackColor = System.Drawing.Color.DodgerBlue
        Me.chk_exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.chk_exist.ForeColor = System.Drawing.Color.White
        Me.chk_exist.Location = New System.Drawing.Point(975, 175)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(73, 18)
        Me.chk_exist.TabIndex = 10044
        Me.chk_exist.Text = "Exist. > 0"
        Me.chk_exist.UseVisualStyleBackColor = False
        '
        'Sp_consultaProductosParaInventarioTableAdapter
        '
        Me.Sp_consultaProductosParaInventarioTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaProductosInvetarioTableAdapter
        '
        Me.Sp_consultaProductosInvetarioTableAdapter.ClearBeforeFill = True
        '
        'Frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1061, 746)
        Me.Controls.Add(Me.chk_exist)
        Me.Controls.Add(Me.chk_dif)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.DGV_Inventarios)
        Me.Controls.Add(Me.tb_buscar)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "Frm_Inventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conteo de inventario"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaProductosParaInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ProductosI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaProductosInvetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV_Inventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_cerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cb_almacenes As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cuartos As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tb_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGV_Inventarios As System.Windows.Forms.DataGridView
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaProductosParaInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosParaInventarioTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosParaInventarioTableAdapter
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_cierre As System.Windows.Forms.ToolBarButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chk_dif As System.Windows.Forms.CheckBox
    Friend WithEvents Sp_consultaProductosInvetarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosInvetarioTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosInvetarioTableAdapter
    Friend WithEvents Dgv_ProductosI As System.Windows.Forms.DataGridView
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents CodigoInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ajustado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAnteriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadActualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabrica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantNueva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_reporte As System.Windows.Forms.ToolBarButton
End Class
