<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Analisis_Pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Analisis_Pedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_MontoVendedor = New System.Windows.Forms.Label
        Me.lbl_cantPVendedor = New System.Windows.Forms.Label
        Me.lbl_TotalVendedor = New System.Windows.Forms.Label
        Me.Dgv_PedidosPorVendedor = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ubicación = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_montoAlmacen = New System.Windows.Forms.Label
        Me.lbl_cantItems = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Dgv_PedidosPorAlmacen = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_MontoZona = New System.Windows.Forms.Label
        Me.lbl_cantPZona = New System.Windows.Forms.Label
        Me.lbl_TotalZona = New System.Windows.Forms.Label
        Me.Dgv_pedidosPorZona = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_PedidosPorFechaMonto = New System.Windows.Forms.Label
        Me.lbl_PedidosPorFechaCantP = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Dgv_pedidosPorFecha = New System.Windows.Forms.DataGridView
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbl_PedidoPorMonto = New System.Windows.Forms.Label
        Me.lbl_pedidosPorMonto = New System.Windows.Forms.Label
        Me.Dgv_pedidosPorMonto = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.gb_pedidosPorZona = New System.Windows.Forms.GroupBox
        Me.gb_pedidosPorFecha = New System.Windows.Forms.GroupBox
        Me.gb_pedidosPorMonto = New System.Windows.Forms.GroupBox
        Me.gb_PedidosPorVendedor = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.gb_PedidosPorAlmacen = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.Dgv_PedidosPorVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_PedidosPorAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_pedidosPorZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_pedidosPorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_pedidosPorMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_pedidosPorZona.SuspendLayout()
        Me.gb_pedidosPorFecha.SuspendLayout()
        Me.gb_pedidosPorMonto.SuspendLayout()
        Me.gb_PedidosPorVendedor.SuspendLayout()
        Me.gb_PedidosPorAlmacen.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(12, 3)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(265, 63)
        Me.ToolBar1.TabIndex = 22
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Ver Todos"
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 5
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Imprimir"
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
        'lbl_MontoVendedor
        '
        Me.lbl_MontoVendedor.Location = New System.Drawing.Point(319, 388)
        Me.lbl_MontoVendedor.Name = "lbl_MontoVendedor"
        Me.lbl_MontoVendedor.Size = New System.Drawing.Size(65, 20)
        Me.lbl_MontoVendedor.TabIndex = 10003
        Me.lbl_MontoVendedor.Text = "##"
        Me.lbl_MontoVendedor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_cantPVendedor
        '
        Me.lbl_cantPVendedor.Location = New System.Drawing.Point(266, 388)
        Me.lbl_cantPVendedor.Name = "lbl_cantPVendedor"
        Me.lbl_cantPVendedor.Size = New System.Drawing.Size(36, 23)
        Me.lbl_cantPVendedor.TabIndex = 10002
        Me.lbl_cantPVendedor.Text = "#"
        Me.lbl_cantPVendedor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_TotalVendedor
        '
        Me.lbl_TotalVendedor.Location = New System.Drawing.Point(192, 388)
        Me.lbl_TotalVendedor.Name = "lbl_TotalVendedor"
        Me.lbl_TotalVendedor.Size = New System.Drawing.Size(37, 20)
        Me.lbl_TotalVendedor.TabIndex = 10001
        Me.lbl_TotalVendedor.Text = "Total"
        '
        'Dgv_PedidosPorVendedor
        '
        Me.Dgv_PedidosPorVendedor.AllowUserToAddRows = False
        Me.Dgv_PedidosPorVendedor.AllowUserToDeleteRows = False
        Me.Dgv_PedidosPorVendedor.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_PedidosPorVendedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_PedidosPorVendedor.ColumnHeadersHeight = 25
        Me.Dgv_PedidosPorVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_PedidosPorVendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Cantidad, Me.Ubicación})
        Me.Dgv_PedidosPorVendedor.EnableHeadersVisualStyles = False
        Me.Dgv_PedidosPorVendedor.Location = New System.Drawing.Point(0, 25)
        Me.Dgv_PedidosPorVendedor.MultiSelect = False
        Me.Dgv_PedidosPorVendedor.Name = "Dgv_PedidosPorVendedor"
        Me.Dgv_PedidosPorVendedor.ReadOnly = True
        Me.Dgv_PedidosPorVendedor.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Dgv_PedidosPorVendedor.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_PedidosPorVendedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_PedidosPorVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_PedidosPorVendedor.Size = New System.Drawing.Size(390, 360)
        Me.Dgv_PedidosPorVendedor.TabIndex = 10000
        '
        'Codigo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Codigo.HeaderText = "Cod."
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 40
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Cantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cantidad.HeaderText = "Cant. P."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'Ubicación
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Ubicación.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ubicación.HeaderText = "Monto"
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        Me.Ubicación.Width = 75
        '
        'lbl_montoAlmacen
        '
        Me.lbl_montoAlmacen.Location = New System.Drawing.Point(187, 163)
        Me.lbl_montoAlmacen.Name = "lbl_montoAlmacen"
        Me.lbl_montoAlmacen.Size = New System.Drawing.Size(78, 20)
        Me.lbl_montoAlmacen.TabIndex = 10003
        Me.lbl_montoAlmacen.Text = "##"
        Me.lbl_montoAlmacen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_cantItems
        '
        Me.lbl_cantItems.Location = New System.Drawing.Point(126, 163)
        Me.lbl_cantItems.Name = "lbl_cantItems"
        Me.lbl_cantItems.Size = New System.Drawing.Size(36, 19)
        Me.lbl_cantItems.TabIndex = 10002
        Me.lbl_cantItems.Text = "#"
        Me.lbl_cantItems.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(83, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 10001
        Me.Label6.Text = "Total"
        '
        'Dgv_PedidosPorAlmacen
        '
        Me.Dgv_PedidosPorAlmacen.AllowUserToAddRows = False
        Me.Dgv_PedidosPorAlmacen.AllowUserToDeleteRows = False
        Me.Dgv_PedidosPorAlmacen.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_PedidosPorAlmacen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_PedidosPorAlmacen.ColumnHeadersHeight = 25
        Me.Dgv_PedidosPorAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_PedidosPorAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.CodigoAlmacen})
        Me.Dgv_PedidosPorAlmacen.EnableHeadersVisualStyles = False
        Me.Dgv_PedidosPorAlmacen.Location = New System.Drawing.Point(0, 20)
        Me.Dgv_PedidosPorAlmacen.MultiSelect = False
        Me.Dgv_PedidosPorAlmacen.Name = "Dgv_PedidosPorAlmacen"
        Me.Dgv_PedidosPorAlmacen.ReadOnly = True
        Me.Dgv_PedidosPorAlmacen.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Dgv_PedidosPorAlmacen.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_PedidosPorAlmacen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_PedidosPorAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_PedidosPorAlmacen.Size = New System.Drawing.Size(271, 139)
        Me.Dgv_PedidosPorAlmacen.TabIndex = 10000
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° Items"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'CodigoAlmacen
        '
        Me.CodigoAlmacen.HeaderText = "CodigoAlmacen"
        Me.CodigoAlmacen.Name = "CodigoAlmacen"
        Me.CodigoAlmacen.ReadOnly = True
        Me.CodigoAlmacen.Visible = False
        '
        'lbl_MontoZona
        '
        Me.lbl_MontoZona.Location = New System.Drawing.Point(194, 157)
        Me.lbl_MontoZona.Name = "lbl_MontoZona"
        Me.lbl_MontoZona.Size = New System.Drawing.Size(71, 20)
        Me.lbl_MontoZona.TabIndex = 10003
        Me.lbl_MontoZona.Text = "##"
        Me.lbl_MontoZona.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_cantPZona
        '
        Me.lbl_cantPZona.Location = New System.Drawing.Point(152, 158)
        Me.lbl_cantPZona.Name = "lbl_cantPZona"
        Me.lbl_cantPZona.Size = New System.Drawing.Size(36, 18)
        Me.lbl_cantPZona.TabIndex = 10002
        Me.lbl_cantPZona.Text = "#"
        Me.lbl_cantPZona.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_TotalZona
        '
        Me.lbl_TotalZona.Location = New System.Drawing.Point(83, 158)
        Me.lbl_TotalZona.Name = "lbl_TotalZona"
        Me.lbl_TotalZona.Size = New System.Drawing.Size(37, 20)
        Me.lbl_TotalZona.TabIndex = 10001
        Me.lbl_TotalZona.Text = "Total"
        '
        'Dgv_pedidosPorZona
        '
        Me.Dgv_pedidosPorZona.AllowUserToAddRows = False
        Me.Dgv_pedidosPorZona.AllowUserToDeleteRows = False
        Me.Dgv_pedidosPorZona.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_pedidosPorZona.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_pedidosPorZona.ColumnHeadersHeight = 25
        Me.Dgv_pedidosPorZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_pedidosPorZona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Dgv_pedidosPorZona.EnableHeadersVisualStyles = False
        Me.Dgv_pedidosPorZona.Location = New System.Drawing.Point(0, 25)
        Me.Dgv_pedidosPorZona.MultiSelect = False
        Me.Dgv_pedidosPorZona.Name = "Dgv_pedidosPorZona"
        Me.Dgv_pedidosPorZona.ReadOnly = True
        Me.Dgv_pedidosPorZona.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Dgv_pedidosPorZona.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.Dgv_pedidosPorZona.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_pedidosPorZona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_pedidosPorZona.Size = New System.Drawing.Size(271, 130)
        Me.Dgv_pedidosPorZona.TabIndex = 10000
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cód."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cant. P."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 52
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn7.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'lbl_PedidosPorFechaMonto
        '
        Me.lbl_PedidosPorFechaMonto.Location = New System.Drawing.Point(197, 156)
        Me.lbl_PedidosPorFechaMonto.Name = "lbl_PedidosPorFechaMonto"
        Me.lbl_PedidosPorFechaMonto.Size = New System.Drawing.Size(68, 20)
        Me.lbl_PedidosPorFechaMonto.TabIndex = 10003
        Me.lbl_PedidosPorFechaMonto.Text = "##"
        Me.lbl_PedidosPorFechaMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_PedidosPorFechaCantP
        '
        Me.lbl_PedidosPorFechaCantP.Location = New System.Drawing.Point(143, 158)
        Me.lbl_PedidosPorFechaCantP.Name = "lbl_PedidosPorFechaCantP"
        Me.lbl_PedidosPorFechaCantP.Size = New System.Drawing.Size(36, 18)
        Me.lbl_PedidosPorFechaCantP.TabIndex = 10002
        Me.lbl_PedidosPorFechaCantP.Text = "#"
        Me.lbl_PedidosPorFechaCantP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(83, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 10001
        Me.Label4.Text = "Total"
        '
        'Dgv_pedidosPorFecha
        '
        Me.Dgv_pedidosPorFecha.AllowUserToAddRows = False
        Me.Dgv_pedidosPorFecha.AllowUserToDeleteRows = False
        Me.Dgv_pedidosPorFecha.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_pedidosPorFecha.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.Dgv_pedidosPorFecha.ColumnHeadersHeight = 25
        Me.Dgv_pedidosPorFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_pedidosPorFecha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Periodo, Me.CantP, Me.Monto})
        Me.Dgv_pedidosPorFecha.EnableHeadersVisualStyles = False
        Me.Dgv_pedidosPorFecha.Location = New System.Drawing.Point(0, 24)
        Me.Dgv_pedidosPorFecha.MultiSelect = False
        Me.Dgv_pedidosPorFecha.Name = "Dgv_pedidosPorFecha"
        Me.Dgv_pedidosPorFecha.ReadOnly = True
        Me.Dgv_pedidosPorFecha.RowHeadersVisible = False
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Dgv_pedidosPorFecha.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.Dgv_pedidosPorFecha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_pedidosPorFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_pedidosPorFecha.Size = New System.Drawing.Size(271, 129)
        Me.Dgv_pedidosPorFecha.TabIndex = 10000
        '
        'Periodo
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Periodo.DefaultCellStyle = DataGridViewCellStyle16
        Me.Periodo.HeaderText = "Período"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        Me.Periodo.Width = 127
        '
        'CantP
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantP.DefaultCellStyle = DataGridViewCellStyle17
        Me.CantP.HeaderText = "Cant. P."
        Me.CantP.Name = "CantP"
        Me.CantP.ReadOnly = True
        Me.CantP.Width = 60
        '
        'Monto
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle18
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 80
        '
        'lbl_PedidoPorMonto
        '
        Me.lbl_PedidoPorMonto.Location = New System.Drawing.Point(322, 176)
        Me.lbl_PedidoPorMonto.Name = "lbl_PedidoPorMonto"
        Me.lbl_PedidoPorMonto.Size = New System.Drawing.Size(63, 17)
        Me.lbl_PedidoPorMonto.TabIndex = 10003
        Me.lbl_PedidoPorMonto.Text = "##"
        Me.lbl_PedidoPorMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_pedidosPorMonto
        '
        Me.lbl_pedidosPorMonto.Location = New System.Drawing.Point(192, 176)
        Me.lbl_pedidosPorMonto.Name = "lbl_pedidosPorMonto"
        Me.lbl_pedidosPorMonto.Size = New System.Drawing.Size(37, 17)
        Me.lbl_pedidosPorMonto.TabIndex = 10001
        Me.lbl_pedidosPorMonto.Text = "Total"
        '
        'Dgv_pedidosPorMonto
        '
        Me.Dgv_pedidosPorMonto.AllowUserToAddRows = False
        Me.Dgv_pedidosPorMonto.AllowUserToDeleteRows = False
        Me.Dgv_pedidosPorMonto.AllowUserToResizeRows = False
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_pedidosPorMonto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle20
        Me.Dgv_pedidosPorMonto.ColumnHeadersHeight = 25
        Me.Dgv_pedidosPorMonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_pedidosPorMonto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.Fecha, Me.Cliente, Me.ClienteN, Me.DataGridViewTextBoxColumn15})
        Me.Dgv_pedidosPorMonto.EnableHeadersVisualStyles = False
        Me.Dgv_pedidosPorMonto.Location = New System.Drawing.Point(0, 23)
        Me.Dgv_pedidosPorMonto.MultiSelect = False
        Me.Dgv_pedidosPorMonto.Name = "Dgv_pedidosPorMonto"
        Me.Dgv_pedidosPorMonto.ReadOnly = True
        Me.Dgv_pedidosPorMonto.RowHeadersVisible = False
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Dgv_pedidosPorMonto.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.Dgv_pedidosPorMonto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_pedidosPorMonto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_pedidosPorMonto.Size = New System.Drawing.Size(390, 149)
        Me.Dgv_pedidosPorMonto.TabIndex = 10000
        '
        'DataGridViewTextBoxColumn12
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cod. P."
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 48
        '
        'Fecha
        '
        DataGridViewCellStyle22.Format = "d"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle22
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 80
        '
        'Cliente
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cliente.DefaultCellStyle = DataGridViewCellStyle23
        Me.Cliente.HeaderText = "Cod. C."
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 50
        '
        'ClienteN
        '
        Me.ClienteN.HeaderText = "Razón Social"
        Me.ClienteN.Name = "ClienteN"
        Me.ClienteN.ReadOnly = True
        Me.ClienteN.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn15.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 58
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 25)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Pedidos Por Zona"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, -1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(271, 25)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Pedidos Por Fecha"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(0, -2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(390, 25)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Top 5 Pedidos Por Monto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_pedidosPorZona
        '
        Me.gb_pedidosPorZona.BackColor = System.Drawing.SystemColors.Control
        Me.gb_pedidosPorZona.Controls.Add(Me.lbl_MontoZona)
        Me.gb_pedidosPorZona.Controls.Add(Me.Label7)
        Me.gb_pedidosPorZona.Controls.Add(Me.lbl_cantPZona)
        Me.gb_pedidosPorZona.Controls.Add(Me.lbl_TotalZona)
        Me.gb_pedidosPorZona.Controls.Add(Me.Dgv_pedidosPorZona)
        Me.gb_pedidosPorZona.Location = New System.Drawing.Point(12, 72)
        Me.gb_pedidosPorZona.Name = "gb_pedidosPorZona"
        Me.gb_pedidosPorZona.Size = New System.Drawing.Size(271, 181)
        Me.gb_pedidosPorZona.TabIndex = 10005
        Me.gb_pedidosPorZona.TabStop = False
        '
        'gb_pedidosPorFecha
        '
        Me.gb_pedidosPorFecha.BackColor = System.Drawing.SystemColors.Control
        Me.gb_pedidosPorFecha.Controls.Add(Me.Label8)
        Me.gb_pedidosPorFecha.Controls.Add(Me.lbl_PedidosPorFechaMonto)
        Me.gb_pedidosPorFecha.Controls.Add(Me.Label4)
        Me.gb_pedidosPorFecha.Controls.Add(Me.lbl_PedidosPorFechaCantP)
        Me.gb_pedidosPorFecha.Controls.Add(Me.Dgv_pedidosPorFecha)
        Me.gb_pedidosPorFecha.Location = New System.Drawing.Point(12, 449)
        Me.gb_pedidosPorFecha.Name = "gb_pedidosPorFecha"
        Me.gb_pedidosPorFecha.Size = New System.Drawing.Size(271, 180)
        Me.gb_pedidosPorFecha.TabIndex = 10006
        Me.gb_pedidosPorFecha.TabStop = False
        '
        'gb_pedidosPorMonto
        '
        Me.gb_pedidosPorMonto.BackColor = System.Drawing.SystemColors.Control
        Me.gb_pedidosPorMonto.Controls.Add(Me.lbl_PedidoPorMonto)
        Me.gb_pedidosPorMonto.Controls.Add(Me.lbl_pedidosPorMonto)
        Me.gb_pedidosPorMonto.Controls.Add(Me.Dgv_pedidosPorMonto)
        Me.gb_pedidosPorMonto.Controls.Add(Me.Label9)
        Me.gb_pedidosPorMonto.Location = New System.Drawing.Point(289, 432)
        Me.gb_pedidosPorMonto.Name = "gb_pedidosPorMonto"
        Me.gb_pedidosPorMonto.Size = New System.Drawing.Size(390, 197)
        Me.gb_pedidosPorMonto.TabIndex = 10007
        Me.gb_pedidosPorMonto.TabStop = False
        '
        'gb_PedidosPorVendedor
        '
        Me.gb_PedidosPorVendedor.BackColor = System.Drawing.SystemColors.Control
        Me.gb_PedidosPorVendedor.Controls.Add(Me.lbl_MontoVendedor)
        Me.gb_PedidosPorVendedor.Controls.Add(Me.lbl_cantPVendedor)
        Me.gb_PedidosPorVendedor.Controls.Add(Me.Label11)
        Me.gb_PedidosPorVendedor.Controls.Add(Me.lbl_TotalVendedor)
        Me.gb_PedidosPorVendedor.Controls.Add(Me.Dgv_PedidosPorVendedor)
        Me.gb_PedidosPorVendedor.Location = New System.Drawing.Point(289, 13)
        Me.gb_PedidosPorVendedor.Name = "gb_PedidosPorVendedor"
        Me.gb_PedidosPorVendedor.Size = New System.Drawing.Size(390, 414)
        Me.gb_PedidosPorVendedor.TabIndex = 10005
        Me.gb_PedidosPorVendedor.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(390, 25)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Pedidos Por Vendedor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_PedidosPorAlmacen
        '
        Me.gb_PedidosPorAlmacen.BackColor = System.Drawing.SystemColors.Control
        Me.gb_PedidosPorAlmacen.Controls.Add(Me.Dgv_PedidosPorAlmacen)
        Me.gb_PedidosPorAlmacen.Controls.Add(Me.lbl_montoAlmacen)
        Me.gb_PedidosPorAlmacen.Controls.Add(Me.lbl_cantItems)
        Me.gb_PedidosPorAlmacen.Controls.Add(Me.Label10)
        Me.gb_PedidosPorAlmacen.Controls.Add(Me.Label6)
        Me.gb_PedidosPorAlmacen.Location = New System.Drawing.Point(12, 260)
        Me.gb_PedidosPorAlmacen.Name = "gb_PedidosPorAlmacen"
        Me.gb_PedidosPorAlmacen.Size = New System.Drawing.Size(271, 185)
        Me.gb_PedidosPorAlmacen.TabIndex = 10006
        Me.gb_PedidosPorAlmacen.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(0, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(271, 25)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Pedidos Por Almacen"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Analisis_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(688, 642)
        Me.Controls.Add(Me.gb_pedidosPorMonto)
        Me.Controls.Add(Me.gb_PedidosPorAlmacen)
        Me.Controls.Add(Me.gb_pedidosPorFecha)
        Me.Controls.Add(Me.gb_PedidosPorVendedor)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.gb_pedidosPorZona)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(70, 79)
        Me.MaximizeBox = False
        Me.Name = "Frm_Analisis_Pedido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de pedidos"
        CType(Me.Dgv_PedidosPorVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_PedidosPorAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_pedidosPorZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_pedidosPorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_pedidosPorMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_pedidosPorZona.ResumeLayout(False)
        Me.gb_pedidosPorFecha.ResumeLayout(False)
        Me.gb_pedidosPorMonto.ResumeLayout(False)
        Me.gb_PedidosPorVendedor.ResumeLayout(False)
        Me.gb_PedidosPorAlmacen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_vertodos As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Dgv_PedidosPorVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents lbl_MontoVendedor As System.Windows.Forms.Label
    Friend WithEvents lbl_cantPVendedor As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalVendedor As System.Windows.Forms.Label
    Friend WithEvents lbl_montoAlmacen As System.Windows.Forms.Label
    Friend WithEvents lbl_cantItems As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Dgv_PedidosPorAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_MontoZona As System.Windows.Forms.Label
    Friend WithEvents lbl_cantPZona As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalZona As System.Windows.Forms.Label
    Friend WithEvents Dgv_pedidosPorZona As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_PedidosPorFechaMonto As System.Windows.Forms.Label
    Friend WithEvents lbl_PedidosPorFechaCantP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dgv_pedidosPorFecha As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_PedidoPorMonto As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidosPorMonto As System.Windows.Forms.Label
    Friend WithEvents Dgv_pedidosPorMonto As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bt_vTodos As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_imprim As System.Windows.Forms.ToolBarButton
    Friend WithEvents gb_pedidosPorZona As System.Windows.Forms.GroupBox
    Friend WithEvents gb_pedidosPorFecha As System.Windows.Forms.GroupBox
    Friend WithEvents gb_pedidosPorMonto As System.Windows.Forms.GroupBox
    Friend WithEvents gb_PedidosPorVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gb_PedidosPorAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
