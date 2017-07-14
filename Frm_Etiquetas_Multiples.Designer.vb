<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Etiquetas_Multiples
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbl_Catalogo = New System.Windows.Forms.Label
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodigoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AquiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aqui = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCuartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoEstanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTramoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sp_consulta_ubicacion_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.chk_exist = New System.Windows.Forms.CheckBox
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Sp_consulta_ubicacion_productosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_ubicacion_productosTableAdapter
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consulta_ubicacion_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Catalogo
        '
        Me.lbl_Catalogo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Catalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Catalogo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Catalogo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Catalogo.Location = New System.Drawing.Point(11, 109)
        Me.lbl_Catalogo.Name = "lbl_Catalogo"
        Me.lbl_Catalogo.Size = New System.Drawing.Size(876, 24)
        Me.lbl_Catalogo.TabIndex = 10041
        Me.lbl_Catalogo.Text = "Catálogo de productos"
        Me.lbl_Catalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Productos.AutoGenerateColumns = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProductoDataGridViewTextBoxColumn, Me.CodigoFDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CantidadExistenciaDataGridViewTextBoxColumn, Me.AquiDataGridViewTextBoxColumn, Me.aqui, Me.CodigoAlmacenDataGridViewTextBoxColumn, Me.CodigoCuartoDataGridViewTextBoxColumn, Me.CodigoEstanteDataGridViewTextBoxColumn, Me.CodigoTramoDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn})
        Me.DGV_Productos.DataSource = Me.Sp_consulta_ubicacion_productosBindingSource
        Me.DGV_Productos.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Productos.Location = New System.Drawing.Point(12, 132)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(875, 357)
        Me.DGV_Productos.TabIndex = 10040
        '
        'CodigoProductoDataGridViewTextBoxColumn
        '
        Me.CodigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto"
        Me.CodigoProductoDataGridViewTextBoxColumn.HeaderText = "Cod. Interno"
        Me.CodigoProductoDataGridViewTextBoxColumn.Name = "CodigoProductoDataGridViewTextBoxColumn"
        Me.CodigoProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoFDataGridViewTextBoxColumn
        '
        Me.CodigoFDataGridViewTextBoxColumn.DataPropertyName = "codigoF"
        Me.CodigoFDataGridViewTextBoxColumn.HeaderText = "Codigo Fab."
        Me.CodigoFDataGridViewTextBoxColumn.Name = "CodigoFDataGridViewTextBoxColumn"
        Me.CodigoFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFDataGridViewTextBoxColumn.Width = 120
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 180
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
        Me.ModeloDataGridViewTextBoxColumn.Width = 140
        '
        'CantidadExistenciaDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciaDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.HeaderText = "CantidadExistencia"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Name = "CantidadExistenciaDataGridViewTextBoxColumn"
        Me.CantidadExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadExistenciaDataGridViewTextBoxColumn.Visible = False
        '
        'AquiDataGridViewTextBoxColumn
        '
        Me.AquiDataGridViewTextBoxColumn.DataPropertyName = "aqui"
        Me.AquiDataGridViewTextBoxColumn.HeaderText = "Exist."
        Me.AquiDataGridViewTextBoxColumn.Name = "AquiDataGridViewTextBoxColumn"
        Me.AquiDataGridViewTextBoxColumn.ReadOnly = True
        Me.AquiDataGridViewTextBoxColumn.Width = 50
        '
        'aqui
        '
        Me.aqui.DataPropertyName = "aqui2"
        Me.aqui.HeaderText = "Etiq"
        Me.aqui.Name = "aqui"
        Me.aqui.Width = 50
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
        Me.UbicacionDataGridViewTextBoxColumn.Width = 110
        '
        'Sp_consulta_ubicacion_productosBindingSource
        '
        Me.Sp_consulta_ubicacion_productosBindingSource.DataMember = "sp_consulta_ubicacion_productos"
        Me.Sp_consulta_ubicacion_productosBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(13, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 32)
        Me.Panel2.TabIndex = 2
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Enabled = False
        Me.cb_tramo.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(656, 5)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(103, 22)
        Me.cb_tramo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(596, 8)
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
        Me.cb_estante.Location = New System.Drawing.Point(487, 4)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(103, 22)
        Me.cb_estante.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(426, 7)
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
        Me.cb_almacenes.Location = New System.Drawing.Point(153, 4)
        Me.cb_almacenes.Name = "cb_almacenes"
        Me.cb_almacenes.Size = New System.Drawing.Size(103, 22)
        Me.cb_almacenes.TabIndex = 3
        Me.cb_almacenes.ValueMember = "Id"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(4, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 18)
        Me.CheckBox1.TabIndex = 2
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
        Me.cb_cuartos.Location = New System.Drawing.Point(319, 4)
        Me.cb_cuartos.Name = "cb_cuartos"
        Me.cb_cuartos.Size = New System.Drawing.Size(103, 22)
        Me.cb_cuartos.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label15.Location = New System.Drawing.Point(258, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "(*)Cuarto:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(81, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "(*)Almacén:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(407, 502)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 27)
        Me.Button2.TabIndex = 10043
        Me.Button2.Text = "Imprimir"
        '
        'chk_exist
        '
        Me.chk_exist.AutoSize = True
        Me.chk_exist.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.chk_exist.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.chk_exist.ForeColor = System.Drawing.Color.White
        Me.chk_exist.Location = New System.Drawing.Point(809, 112)
        Me.chk_exist.Name = "chk_exist"
        Me.chk_exist.Size = New System.Drawing.Size(69, 18)
        Me.chk_exist.TabIndex = 10045
        Me.chk_exist.Text = "Etiq. > 0"
        Me.chk_exist.UseVisualStyleBackColor = False
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Items.AddRange(New Object() {"Código Interno", "Descripción", "Código Fábrica", "Marca", "Modelo"})
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 18)
        Me.DomainUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(130, 23)
        Me.DomainUpDown1.TabIndex = 2
        Me.DomainUpDown1.TabStop = False
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(141, 17)
        Me.tb_buscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(157, 25)
        Me.tb_buscar.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox1.Controls.Add(Me.tb_buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'Sp_consulta_ubicacion_productosTableAdapter
        '
        Me.Sp_consulta_ubicacion_productosTableAdapter.ClearBeforeFill = True
        '
        'Frm_Etiquetas_Multiples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(899, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_exist)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_Catalogo)
        Me.Controls.Add(Me.DGV_Productos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Etiquetas_Multiples"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir etiquetas"
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consulta_ubicacion_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Catalogo As System.Windows.Forms.Label
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consulta_ubicacion_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consulta_ubicacion_productosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_ubicacion_productosTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_almacenes As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cuartos As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chk_exist As System.Windows.Forms.CheckBox
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AquiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aqui As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCuartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoEstanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTramoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
