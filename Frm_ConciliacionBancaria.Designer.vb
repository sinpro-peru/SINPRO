<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConciliacionBancaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConciliacionBancaria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button3 = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chk_fecha = New System.Windows.Forms.CheckBox
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cb_bancos = New System.Windows.Forms.ComboBox
        Me.chk_banco = New System.Windows.Forms.CheckBox
        Me.dgv_movimientos = New System.Windows.Forms.DataGridView
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_salir = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cb_categoria = New System.Windows.Forms.ComboBox
        Me.chk_categoria = New System.Windows.Forms.CheckBox
        Me.chk_subCategoria = New System.Windows.Forms.CheckBox
        Me.cb_subCategoria = New System.Windows.Forms.ComboBox
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.SpconsultaMovimientosAsociadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consulta_Movimientos_AsociadosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Movimientos_AsociadosTableAdapter
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroDepositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EgresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaMovimientosAsociadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(632, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 29)
        Me.Button3.TabIndex = 20024
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.White
        Me.bt_eliminar.BackgroundImage = CType(resources.GetObject("bt_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.bt_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(689, 51)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(51, 29)
        Me.bt_eliminar.TabIndex = 20023
        Me.bt_eliminar.UseVisualStyleBackColor = False
        Me.bt_eliminar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chk_fecha)
        Me.Panel2.Controls.Add(Me.dtp_hasta)
        Me.Panel2.Controls.Add(Me.dtp_desde)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(773, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 65)
        Me.Panel2.TabIndex = 20022
        '
        'chk_fecha
        '
        Me.chk_fecha.AutoSize = True
        Me.chk_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fecha.Location = New System.Drawing.Point(7, 22)
        Me.chk_fecha.Name = "chk_fecha"
        Me.chk_fecha.Size = New System.Drawing.Size(66, 18)
        Me.chk_fecha.TabIndex = 10016
        Me.chk_fecha.Text = "Fecha:"
        Me.chk_fecha.UseVisualStyleBackColor = True
        '
        'dtp_hasta
        '
        Me.dtp_hasta.Enabled = False
        Me.dtp_hasta.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_hasta.Location = New System.Drawing.Point(119, 34)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(94, 21)
        Me.dtp_hasta.TabIndex = 10010
        '
        'dtp_desde
        '
        Me.dtp_desde.Enabled = False
        Me.dtp_desde.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(119, 7)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(94, 21)
        Me.dtp_desde.TabIndex = 10009
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10007
        Me.Label2.Text = "Desde: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10008
        Me.Label3.Text = "Hasta: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb_bancos)
        Me.Panel1.Controls.Add(Me.chk_banco)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 34)
        Me.Panel1.TabIndex = 20021
        '
        'cb_bancos
        '
        Me.cb_bancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_bancos.Enabled = False
        Me.cb_bancos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_bancos.FormattingEnabled = True
        Me.cb_bancos.Location = New System.Drawing.Point(106, 5)
        Me.cb_bancos.Name = "cb_bancos"
        Me.cb_bancos.Size = New System.Drawing.Size(161, 23)
        Me.cb_bancos.TabIndex = 10006
        '
        'chk_banco
        '
        Me.chk_banco.AutoSize = True
        Me.chk_banco.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_banco.Location = New System.Drawing.Point(10, 10)
        Me.chk_banco.Name = "chk_banco"
        Me.chk_banco.Size = New System.Drawing.Size(68, 18)
        Me.chk_banco.TabIndex = 10015
        Me.chk_banco.Text = "Banco:"
        Me.chk_banco.UseVisualStyleBackColor = True
        '
        'dgv_movimientos
        '
        Me.dgv_movimientos.AllowUserToAddRows = False
        Me.dgv_movimientos.AllowUserToDeleteRows = False
        Me.dgv_movimientos.AllowUserToOrderColumns = True
        Me.dgv_movimientos.AllowUserToResizeRows = False
        Me.dgv_movimientos.AutoGenerateColumns = False
        Me.dgv_movimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_movimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BancoDataGridViewTextBoxColumn, Me.OficinaDataGridViewTextBoxColumn, Me.NumeroDepositoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.EgresoDataGridViewTextBoxColumn, Me.NombreCDataGridViewTextBoxColumn, Me.NombreSDataGridViewTextBoxColumn, Me.IdSDataGridViewTextBoxColumn, Me.IdCDataGridViewTextBoxColumn})
        Me.dgv_movimientos.DataSource = Me.SpconsultaMovimientosAsociadosBindingSource
        Me.dgv_movimientos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_movimientos.Location = New System.Drawing.Point(8, 88)
        Me.dgv_movimientos.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_movimientos.MultiSelect = False
        Me.dgv_movimientos.Name = "dgv_movimientos"
        Me.dgv_movimientos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_movimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_movimientos.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgv_movimientos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_movimientos.RowTemplate.Height = 19
        Me.dgv_movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_movimientos.Size = New System.Drawing.Size(993, 428)
        Me.dgv_movimientos.TabIndex = 20020
        '
        'bt_imprimir
        '
        Me.bt_imprimir.BackColor = System.Drawing.Color.White
        Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_imprimir.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_imprimir.Location = New System.Drawing.Point(422, 525)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 25)
        Me.bt_imprimir.TabIndex = 20025
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = False
        '
        'bt_salir
        '
        Me.bt_salir.BackColor = System.Drawing.Color.White
        Me.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_salir.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_salir.Location = New System.Drawing.Point(520, 525)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(75, 25)
        Me.bt_salir.TabIndex = 20026
        Me.bt_salir.Text = "Salir"
        Me.bt_salir.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cb_subCategoria)
        Me.Panel3.Controls.Add(Me.chk_subCategoria)
        Me.Panel3.Controls.Add(Me.cb_categoria)
        Me.Panel3.Controls.Add(Me.chk_categoria)
        Me.Panel3.Location = New System.Drawing.Point(8, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(572, 34)
        Me.Panel3.TabIndex = 20022
        '
        'cb_categoria
        '
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.Enabled = False
        Me.cb_categoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(106, 5)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(161, 23)
        Me.cb_categoria.TabIndex = 10006
        '
        'chk_categoria
        '
        Me.chk_categoria.AutoSize = True
        Me.chk_categoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_categoria.Location = New System.Drawing.Point(10, 10)
        Me.chk_categoria.Name = "chk_categoria"
        Me.chk_categoria.Size = New System.Drawing.Size(90, 18)
        Me.chk_categoria.TabIndex = 10015
        Me.chk_categoria.Text = "Categoría:"
        Me.chk_categoria.UseVisualStyleBackColor = True
        '
        'chk_subCategoria
        '
        Me.chk_subCategoria.AutoSize = True
        Me.chk_subCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_subCategoria.Location = New System.Drawing.Point(281, 8)
        Me.chk_subCategoria.Name = "chk_subCategoria"
        Me.chk_subCategoria.Size = New System.Drawing.Size(117, 18)
        Me.chk_subCategoria.TabIndex = 10017
        Me.chk_subCategoria.Text = "Sub-Categoría:"
        Me.chk_subCategoria.UseVisualStyleBackColor = True
        '
        'cb_subCategoria
        '
        Me.cb_subCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subCategoria.Enabled = False
        Me.cb_subCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subCategoria.FormattingEnabled = True
        Me.cb_subCategoria.Location = New System.Drawing.Point(404, 5)
        Me.cb_subCategoria.Name = "cb_subCategoria"
        Me.cb_subCategoria.Size = New System.Drawing.Size(161, 23)
        Me.cb_subCategoria.TabIndex = 10016
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpconsultaMovimientosAsociadosBindingSource
        '
        Me.SpconsultaMovimientosAsociadosBindingSource.DataMember = "sp_consulta_Movimientos_Asociados"
        Me.SpconsultaMovimientosAsociadosBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consulta_Movimientos_AsociadosTableAdapter
        '
        Me.Sp_consulta_Movimientos_AsociadosTableAdapter.ClearBeforeFill = True
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OficinaDataGridViewTextBoxColumn
        '
        Me.OficinaDataGridViewTextBoxColumn.DataPropertyName = "Oficina"
        Me.OficinaDataGridViewTextBoxColumn.HeaderText = "Oficina"
        Me.OficinaDataGridViewTextBoxColumn.Name = "OficinaDataGridViewTextBoxColumn"
        Me.OficinaDataGridViewTextBoxColumn.ReadOnly = True
        Me.OficinaDataGridViewTextBoxColumn.Width = 110
        '
        'NumeroDepositoDataGridViewTextBoxColumn
        '
        Me.NumeroDepositoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDeposito"
        Me.NumeroDepositoDataGridViewTextBoxColumn.HeaderText = "Nro. Depósito"
        Me.NumeroDepositoDataGridViewTextBoxColumn.Name = "NumeroDepositoDataGridViewTextBoxColumn"
        Me.NumeroDepositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDepositoDataGridViewTextBoxColumn.Width = 135
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'EgresoDataGridViewTextBoxColumn
        '
        Me.EgresoDataGridViewTextBoxColumn.DataPropertyName = "Egreso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#,##0.00"
        Me.EgresoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.EgresoDataGridViewTextBoxColumn.HeaderText = "Egreso"
        Me.EgresoDataGridViewTextBoxColumn.Name = "EgresoDataGridViewTextBoxColumn"
        Me.EgresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCDataGridViewTextBoxColumn
        '
        Me.NombreCDataGridViewTextBoxColumn.DataPropertyName = "NombreC"
        Me.NombreCDataGridViewTextBoxColumn.HeaderText = "Categoría"
        Me.NombreCDataGridViewTextBoxColumn.Name = "NombreCDataGridViewTextBoxColumn"
        Me.NombreCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCDataGridViewTextBoxColumn.Width = 120
        '
        'NombreSDataGridViewTextBoxColumn
        '
        Me.NombreSDataGridViewTextBoxColumn.DataPropertyName = "NombreS"
        Me.NombreSDataGridViewTextBoxColumn.HeaderText = "Sub-Categoría"
        Me.NombreSDataGridViewTextBoxColumn.Name = "NombreSDataGridViewTextBoxColumn"
        Me.NombreSDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreSDataGridViewTextBoxColumn.Width = 130
        '
        'IdSDataGridViewTextBoxColumn
        '
        Me.IdSDataGridViewTextBoxColumn.DataPropertyName = "IdS"
        Me.IdSDataGridViewTextBoxColumn.HeaderText = "IdS"
        Me.IdSDataGridViewTextBoxColumn.Name = "IdSDataGridViewTextBoxColumn"
        Me.IdSDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSDataGridViewTextBoxColumn.Visible = False
        '
        'IdCDataGridViewTextBoxColumn
        '
        Me.IdCDataGridViewTextBoxColumn.DataPropertyName = "IdC"
        Me.IdCDataGridViewTextBoxColumn.HeaderText = "IdC"
        Me.IdCDataGridViewTextBoxColumn.Name = "IdCDataGridViewTextBoxColumn"
        Me.IdCDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCDataGridViewTextBoxColumn.Visible = False
        '
        'Frm_ConciliacionBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 559)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bt_salir)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_movimientos)
        Me.Name = "Frm_ConciliacionBancaria"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliación Bancaria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaMovimientosAsociadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chk_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_bancos As System.Windows.Forms.ComboBox
    Friend WithEvents chk_banco As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_salir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents chk_categoria As System.Windows.Forms.CheckBox
    Friend WithEvents cb_subCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents chk_subCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaMovimientosAsociadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consulta_Movimientos_AsociadosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Movimientos_AsociadosTableAdapter
    Friend WithEvents BancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OficinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDepositoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EgresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
