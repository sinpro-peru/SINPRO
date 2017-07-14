<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TipoUsuario
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TipoUsuario))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cb_ninguno = New System.Windows.Forms.RadioButton
        Me.cb_todos = New System.Windows.Forms.RadioButton
        Me.rb_Activos = New System.Windows.Forms.RadioButton
        Me.rb_eliminados = New System.Windows.Forms.RadioButton
        Me.tb_usuario = New System.Windows.Forms.ComboBox
        Me.tb_nuevo = New System.Windows.Forms.TextBox
        Me.lb_nom = New System.Windows.Forms.Label
        Me.lb_id = New System.Windows.Forms.Label
        Me.DGV_TipoUsuario = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.W = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DGV_busqueda = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_restaurar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupbox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_TipoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(441, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Datos Tipo Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.Panel1)
        Me.groupbox1.Controls.Add(Me.rb_Activos)
        Me.groupbox1.Controls.Add(Me.rb_eliminados)
        Me.groupbox1.Controls.Add(Me.tb_usuario)
        Me.groupbox1.Controls.Add(Me.tb_nuevo)
        Me.groupbox1.Controls.Add(Me.lb_nom)
        Me.groupbox1.Controls.Add(Me.lb_id)
        Me.groupbox1.Location = New System.Drawing.Point(12, 93)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(441, 136)
        Me.groupbox1.TabIndex = 12
        Me.groupbox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb_ninguno)
        Me.Panel1.Controls.Add(Me.cb_todos)
        Me.Panel1.Location = New System.Drawing.Point(14, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 27)
        Me.Panel1.TabIndex = 109
        '
        'cb_ninguno
        '
        Me.cb_ninguno.AutoSize = True
        Me.cb_ninguno.Location = New System.Drawing.Point(83, 5)
        Me.cb_ninguno.Name = "cb_ninguno"
        Me.cb_ninguno.Size = New System.Drawing.Size(72, 18)
        Me.cb_ninguno.TabIndex = 107
        Me.cb_ninguno.TabStop = True
        Me.cb_ninguno.Text = "Ninguno"
        Me.cb_ninguno.UseVisualStyleBackColor = True
        '
        'cb_todos
        '
        Me.cb_todos.AutoSize = True
        Me.cb_todos.Location = New System.Drawing.Point(6, 6)
        Me.cb_todos.Name = "cb_todos"
        Me.cb_todos.Size = New System.Drawing.Size(57, 18)
        Me.cb_todos.TabIndex = 106
        Me.cb_todos.TabStop = True
        Me.cb_todos.Text = "Todos"
        Me.cb_todos.UseVisualStyleBackColor = True
        '
        'rb_Activos
        '
        Me.rb_Activos.AutoSize = True
        Me.rb_Activos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Activos.Location = New System.Drawing.Point(14, 20)
        Me.rb_Activos.Name = "rb_Activos"
        Me.rb_Activos.Size = New System.Drawing.Size(66, 19)
        Me.rb_Activos.TabIndex = 102
        Me.rb_Activos.TabStop = True
        Me.rb_Activos.Text = "Activos"
        Me.rb_Activos.UseVisualStyleBackColor = True
        '
        'rb_eliminados
        '
        Me.rb_eliminados.AutoSize = True
        Me.rb_eliminados.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_eliminados.Location = New System.Drawing.Point(86, 20)
        Me.rb_eliminados.Name = "rb_eliminados"
        Me.rb_eliminados.Size = New System.Drawing.Size(88, 19)
        Me.rb_eliminados.TabIndex = 103
        Me.rb_eliminados.TabStop = True
        Me.rb_eliminados.Text = "Eliminados"
        Me.rb_eliminados.UseVisualStyleBackColor = True
        '
        'tb_usuario
        '
        Me.tb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usuario.FormattingEnabled = True
        Me.tb_usuario.Location = New System.Drawing.Point(168, 59)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(163, 23)
        Me.tb_usuario.TabIndex = 108
        '
        'tb_nuevo
        '
        Me.tb_nuevo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nuevo.Location = New System.Drawing.Point(168, 60)
        Me.tb_nuevo.Name = "tb_nuevo"
        Me.tb_nuevo.Size = New System.Drawing.Size(163, 22)
        Me.tb_nuevo.TabIndex = 101
        Me.tb_nuevo.Visible = False
        '
        'lb_nom
        '
        Me.lb_nom.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nom.Location = New System.Drawing.Point(101, 62)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(71, 25)
        Me.lb_nom.TabIndex = 0
        Me.lb_nom.Text = "Nombre:"
        '
        'lb_id
        '
        Me.lb_id.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.Location = New System.Drawing.Point(372, 46)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(41, 22)
        Me.lb_id.TabIndex = 102
        Me.lb_id.Visible = False
        '
        'DGV_TipoUsuario
        '
        Me.DGV_TipoUsuario.AllowUserToAddRows = False
        Me.DGV_TipoUsuario.AllowUserToDeleteRows = False
        Me.DGV_TipoUsuario.AllowUserToResizeColumns = False
        Me.DGV_TipoUsuario.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TipoUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_TipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TipoUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.id, Me.idAnterior, Me.W, Me.E, Me.Descripción})
        Me.DGV_TipoUsuario.Location = New System.Drawing.Point(12, 255)
        Me.DGV_TipoUsuario.MultiSelect = False
        Me.DGV_TipoUsuario.Name = "DGV_TipoUsuario"
        Me.DGV_TipoUsuario.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_TipoUsuario.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_TipoUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_TipoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_TipoUsuario.ShowEditingIcon = False
        Me.DGV_TipoUsuario.Size = New System.Drawing.Size(441, 257)
        Me.DGV_TipoUsuario.TabIndex = 86
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = ""
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 20
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'idAnterior
        '
        Me.idAnterior.HeaderText = "idAnterior"
        Me.idAnterior.Name = "idAnterior"
        Me.idAnterior.Visible = False
        '
        'W
        '
        Me.W.HeaderText = "W"
        Me.W.Name = "W"
        Me.W.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.W.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.W.ThreeState = True
        Me.W.Width = 20
        '
        'E
        '
        Me.E.HeaderText = "E"
        Me.E.Name = "E"
        Me.E.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.E.Width = 20
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Width = 110
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 25)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Módulos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(256, 533)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(87, 25)
        Me.bt_cancelar.TabIndex = 89
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(116, 533)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(87, 25)
        Me.bt_aceptar.TabIndex = 88
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(12, -1)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(228, 72)
        Me.ToolBar1.TabIndex = 90
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
        Me.ImageList2.Images.SetKeyName(5, "")
        '
        'DGV_busqueda
        '
        Me.DGV_busqueda.AllowUserToAddRows = False
        Me.DGV_busqueda.AllowUserToDeleteRows = False
        Me.DGV_busqueda.AllowUserToResizeColumns = False
        Me.DGV_busqueda.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_busqueda.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_busqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.DGV_busqueda.Location = New System.Drawing.Point(12, 255)
        Me.DGV_busqueda.MultiSelect = False
        Me.DGV_busqueda.Name = "DGV_busqueda"
        Me.DGV_busqueda.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_busqueda.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_busqueda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_busqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_busqueda.ShowEditingIcon = False
        Me.DGV_busqueda.Size = New System.Drawing.Size(370, 257)
        Me.DGV_busqueda.TabIndex = 88
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 20
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 280
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "idAnterior"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'bt_restaurar
        '
        Me.bt_restaurar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_restaurar.Location = New System.Drawing.Point(116, 533)
        Me.bt_restaurar.Name = "bt_restaurar"
        Me.bt_restaurar.Size = New System.Drawing.Size(87, 25)
        Me.bt_restaurar.TabIndex = 103
        Me.bt_restaurar.Text = "Restaurar"
        Me.bt_restaurar.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'Frm_TipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 580)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.DGV_TipoUsuario)
        Me.Controls.Add(Me.bt_restaurar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_busqueda)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_TipoUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de usuario"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_TipoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_nom As System.Windows.Forms.Label
    Friend WithEvents DGV_TipoUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents tb_nuevo As System.Windows.Forms.TextBox
    Friend WithEvents rb_eliminados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Activos As System.Windows.Forms.RadioButton
    Friend WithEvents bt_restaurar As System.Windows.Forms.Button
    Friend WithEvents DGV_busqueda As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents cb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents cb_ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents tb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents W As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents E As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
