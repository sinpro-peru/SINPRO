<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Actividades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tb_buscar = New System.Windows.Forms.TextBox
        Me.lbl_Catalogo = New System.Windows.Forms.Label
        Me.DGV_Actividades = New System.Windows.Forms.DataGridView
        Me.Sp_consulta_actividades_SINPROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Sp_consulta_actividades_SINPROTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_actividades_SINPROTableAdapter
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consulta_actividades_SINPROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox1.Controls.Add(Me.tb_buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 52)
        Me.GroupBox1.TabIndex = 10046
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'tb_buscar
        '
        Me.tb_buscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscar.Location = New System.Drawing.Point(227, 16)
        Me.tb_buscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(157, 25)
        Me.tb_buscar.TabIndex = 0
        '
        'lbl_Catalogo
        '
        Me.lbl_Catalogo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Catalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Catalogo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Catalogo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Catalogo.Location = New System.Drawing.Point(10, 109)
        Me.lbl_Catalogo.Name = "lbl_Catalogo"
        Me.lbl_Catalogo.Size = New System.Drawing.Size(878, 24)
        Me.lbl_Catalogo.TabIndex = 10049
        Me.lbl_Catalogo.Text = "Catálogo de productos"
        Me.lbl_Catalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Actividades
        '
        Me.DGV_Actividades.AllowUserToAddRows = False
        Me.DGV_Actividades.AllowUserToDeleteRows = False
        Me.DGV_Actividades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Actividades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Actividades.AutoGenerateColumns = False
        Me.DGV_Actividades.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Actividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_Actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Actividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn})
        Me.DGV_Actividades.DataSource = Me.Sp_consulta_actividades_SINPROBindingSource
        Me.DGV_Actividades.GridColor = System.Drawing.Color.DarkGray
        Me.DGV_Actividades.Location = New System.Drawing.Point(11, 132)
        Me.DGV_Actividades.MultiSelect = False
        Me.DGV_Actividades.Name = "DGV_Actividades"
        Me.DGV_Actividades.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Actividades.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Actividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Actividades.Size = New System.Drawing.Size(877, 357)
        Me.DGV_Actividades.TabIndex = 10048
        '
        'Sp_consulta_actividades_SINPROBindingSource
        '
        Me.Sp_consulta_actividades_SINPROBindingSource.DataMember = "sp_consulta_actividades_SINPRO"
        Me.Sp_consulta_actividades_SINPROBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(4, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 18)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Entre las fechas:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 32)
        Me.Panel2.TabIndex = 10047
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(259, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker2.TabIndex = 10052
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker1.TabIndex = 10051
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label15.Location = New System.Drawing.Point(234, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 17)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "y"
        '
        'Sp_consulta_actividades_SINPROTableAdapter
        '
        Me.Sp_consulta_actividades_SINPROTableAdapter.ClearBeforeFill = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 10.0!)
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Items.AddRange(New Object() {"Nombre o Nro. de Doc.", "Usuario"})
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 18)
        Me.DomainUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(214, 23)
        Me.DomainUpDown1.TabIndex = 2
        Me.DomainUpDown1.TabStop = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 140
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.Width = 560
        '
        'Frm_Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_Catalogo)
        Me.Controls.Add(Me.DGV_Actividades)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Actividades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Actividades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Actividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consulta_actividades_SINPROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Catalogo As System.Windows.Forms.Label
    Friend WithEvents DGV_Actividades As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consulta_actividades_SINPROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consulta_actividades_SINPROTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_actividades_SINPROTableAdapter
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
