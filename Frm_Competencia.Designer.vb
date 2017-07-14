<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Competencia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Competencia))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_competencia = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dd_buscar = New System.Windows.Forms.ComboBox
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_agregar1 = New System.Windows.Forms.ToolBarButton
        Me.bt_asociar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_eliminapro = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_codFab = New System.Windows.Forms.Label
        Me.tb_telefono = New System.Windows.Forms.TextBox
        Me.tb_razonsocial = New System.Windows.Forms.TextBox
        Me.tb_rif = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.CodImportador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodFab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodOEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_competencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_competencia)
        Me.GroupBox1.Controls.Add(Me.dd_buscar)
        Me.GroupBox1.Controls.Add(Me.tb_buscarcodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 630)
        Me.GroupBox1.TabIndex = 10008
        Me.GroupBox1.TabStop = False
        '
        'DGV_competencia
        '
        Me.DGV_competencia.AllowUserToAddRows = False
        Me.DGV_competencia.AllowUserToDeleteRows = False
        Me.DGV_competencia.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_competencia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_competencia.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_competencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_competencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_competencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DGV_competencia.EnableHeadersVisualStyles = False
        Me.DGV_competencia.Location = New System.Drawing.Point(6, 42)
        Me.DGV_competencia.MultiSelect = False
        Me.DGV_competencia.Name = "DGV_competencia"
        Me.DGV_competencia.ReadOnly = True
        Me.DGV_competencia.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_competencia.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_competencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_competencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_competencia.Size = New System.Drawing.Size(249, 582)
        Me.DGV_competencia.TabIndex = 10010
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rif"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'dd_buscar
        '
        Me.dd_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_buscar.FormattingEnabled = True
        Me.dd_buscar.Location = New System.Drawing.Point(7, 15)
        Me.dd_buscar.Name = "dd_buscar"
        Me.dd_buscar.Size = New System.Drawing.Size(107, 21)
        Me.dd_buscar.TabIndex = 10009
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(120, 13)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(135, 22)
        Me.tb_buscarcodigo.TabIndex = 10008
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_agregar1, Me.bt_asociar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(8, 5)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(308, 65)
        Me.ToolBar1.TabIndex = 10009
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
        'bt_agregar1
        '
        Me.bt_agregar1.ImageIndex = 5
        Me.bt_agregar1.Name = "bt_agregar1"
        Me.bt_agregar1.Text = "Agregar"
        '
        'bt_asociar
        '
        Me.bt_asociar.ImageIndex = 6
        Me.bt_asociar.Name = "bt_asociar"
        Me.bt_asociar.Text = "Asociar"
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
        Me.ImageList2.Images.SetKeyName(5, "agregar.JPG")
        Me.ImageList2.Images.SetKeyName(6, "Asociar.JPG")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bt_eliminapro)
        Me.GroupBox2.Controls.Add(Me.bt_cancelar)
        Me.GroupBox2.Controls.Add(Me.bt_aceptar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_codFab)
        Me.GroupBox2.Controls.Add(Me.tb_telefono)
        Me.GroupBox2.Controls.Add(Me.tb_razonsocial)
        Me.GroupBox2.Controls.Add(Me.tb_rif)
        Me.GroupBox2.Location = New System.Drawing.Point(322, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 102)
        Me.GroupBox2.TabIndex = 10010
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la empresa"
        '
        'bt_eliminapro
        '
        Me.bt_eliminapro.BackColor = System.Drawing.Color.White
        Me.bt_eliminapro.BackgroundImage = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminapro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_eliminapro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminapro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminapro.Location = New System.Drawing.Point(626, 61)
        Me.bt_eliminapro.Name = "bt_eliminapro"
        Me.bt_eliminapro.Size = New System.Drawing.Size(51, 29)
        Me.bt_eliminapro.TabIndex = 10017
        Me.bt_eliminapro.UseVisualStyleBackColor = False
        Me.bt_eliminapro.Visible = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(328, 61)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(87, 29)
        Me.bt_cancelar.TabIndex = 89
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(194, 61)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(87, 29)
        Me.bt_aceptar.TabIndex = 88
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        Me.bt_aceptar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Razón Social:"
        '
        'lbl_codFab
        '
        Me.lbl_codFab.AutoSize = True
        Me.lbl_codFab.Location = New System.Drawing.Point(12, 23)
        Me.lbl_codFab.Name = "lbl_codFab"
        Me.lbl_codFab.Size = New System.Drawing.Size(23, 13)
        Me.lbl_codFab.TabIndex = 83
        Me.lbl_codFab.Text = "Rif:"
        '
        'tb_telefono
        '
        Me.tb_telefono.Location = New System.Drawing.Point(523, 18)
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.ReadOnly = True
        Me.tb_telefono.Size = New System.Drawing.Size(154, 20)
        Me.tb_telefono.TabIndex = 2
        '
        'tb_razonsocial
        '
        Me.tb_razonsocial.Location = New System.Drawing.Point(269, 18)
        Me.tb_razonsocial.Name = "tb_razonsocial"
        Me.tb_razonsocial.ReadOnly = True
        Me.tb_razonsocial.Size = New System.Drawing.Size(188, 20)
        Me.tb_razonsocial.TabIndex = 1
        '
        'tb_rif
        '
        Me.tb_rif.Location = New System.Drawing.Point(41, 20)
        Me.tb_rif.Name = "tb_rif"
        Me.tb_rif.ReadOnly = True
        Me.tb_rif.Size = New System.Drawing.Size(139, 20)
        Me.tb_rif.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DGV_Productos)
        Me.GroupBox3.Location = New System.Drawing.Point(271, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(744, 586)
        Me.GroupBox3.TabIndex = 10011
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(0, -5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 23)
        Me.Label3.TabIndex = 10002
        Me.Label3.Text = "Productos Competencia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodImportador, Me.CodFab, Me.CodOEM, Me.Descripcion, Me.Marca, Me.Modelo, Me.Año, Me.Stock, Me.Precio})
        Me.DGV_Productos.EnableHeadersVisualStyles = False
        Me.DGV_Productos.Location = New System.Drawing.Point(0, 21)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        Me.DGV_Productos.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(735, 559)
        Me.DGV_Productos.TabIndex = 10001
        '
        'CodImportador
        '
        Me.CodImportador.HeaderText = "Cod. Import."
        Me.CodImportador.Name = "CodImportador"
        Me.CodImportador.ReadOnly = True
        Me.CodImportador.Width = 120
        '
        'CodFab
        '
        Me.CodFab.HeaderText = "Cod.Fab."
        Me.CodFab.Name = "CodFab"
        Me.CodFab.ReadOnly = True
        Me.CodFab.Width = 95
        '
        'CodOEM
        '
        Me.CodOEM.HeaderText = "Cod.OEM"
        Me.CodOEM.Name = "CodOEM"
        Me.CodOEM.ReadOnly = True
        Me.CodOEM.Width = 95
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 115
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 70
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 65
        '
        'Año
        '
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        Me.Año.ReadOnly = True
        Me.Año.Width = 45
        '
        'Stock
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Stock.DefaultCellStyle = DataGridViewCellStyle6
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 48
        '
        'Precio
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "#,##0.00"
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 62
        '
        'Frm_Competencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 707)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Competencia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Competencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_competencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents dd_buscar As System.Windows.Forms.ComboBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_telefono As System.Windows.Forms.TextBox
    Friend WithEvents tb_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents tb_rif As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codFab As System.Windows.Forms.Label
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents DGV_competencia As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_eliminapro As System.Windows.Forms.Button
    Friend WithEvents bt_agregar1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents CodImportador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodFab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodOEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_asociar As System.Windows.Forms.ToolBarButton
End Class
