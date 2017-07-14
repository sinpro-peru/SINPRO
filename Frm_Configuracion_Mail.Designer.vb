<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Configuracion_Mail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tab_correos = New System.Windows.Forms.TabControl
        Me.tp_correos = New System.Windows.Forms.TabPage
        Me.DGV_Eventos = New System.Windows.Forms.DataGridView
        Me.Label105 = New System.Windows.Forms.Label
        Me.tp_correosListados = New System.Windows.Forms.TabPage
        Me.bt_aplicar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usuarios = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Clientes = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Vendedores = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.tab_correos.SuspendLayout()
        Me.tp_correos.SuspendLayout()
        CType(Me.DGV_Eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_correos
        '
        Me.tab_correos.Controls.Add(Me.tp_correos)
        Me.tab_correos.Controls.Add(Me.tp_correosListados)
        Me.tab_correos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_correos.HotTrack = True
        Me.tab_correos.Location = New System.Drawing.Point(3, 2)
        Me.tab_correos.Multiline = True
        Me.tab_correos.Name = "tab_correos"
        Me.tab_correos.SelectedIndex = 0
        Me.tab_correos.Size = New System.Drawing.Size(882, 459)
        Me.tab_correos.TabIndex = 20
        '
        'tp_correos
        '
        Me.tp_correos.BackColor = System.Drawing.Color.White
        Me.tp_correos.Controls.Add(Me.DGV_Eventos)
        Me.tp_correos.Controls.Add(Me.Label105)
        Me.tp_correos.Location = New System.Drawing.Point(4, 24)
        Me.tp_correos.Name = "tp_correos"
        Me.tp_correos.Size = New System.Drawing.Size(874, 431)
        Me.tp_correos.TabIndex = 22
        Me.tp_correos.Text = "Envío Correos"
        Me.tp_correos.UseVisualStyleBackColor = True
        '
        'DGV_Eventos
        '
        Me.DGV_Eventos.AllowUserToAddRows = False
        Me.DGV_Eventos.AllowUserToDeleteRows = False
        Me.DGV_Eventos.AllowUserToResizeColumns = False
        Me.DGV_Eventos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Eventos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Eventos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Eventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.Usuarios, Me.Clientes, Me.Vendedores})
        Me.DGV_Eventos.Location = New System.Drawing.Point(209, 125)
        Me.DGV_Eventos.MultiSelect = False
        Me.DGV_Eventos.Name = "DGV_Eventos"
        Me.DGV_Eventos.RowHeadersVisible = False
        Me.DGV_Eventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Eventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_Eventos.Size = New System.Drawing.Size(475, 172)
        Me.DGV_Eventos.TabIndex = 10048
        '
        'Label105
        '
        Me.Label105.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label105.Location = New System.Drawing.Point(216, 96)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(534, 16)
        Me.Label105.TabIndex = 21
        Me.Label105.Text = "Elija las notificaciones que serán enviadas por email cuando el evento ocurra"
        '
        'tp_correosListados
        '
        Me.tp_correosListados.BackColor = System.Drawing.Color.White
        Me.tp_correosListados.Location = New System.Drawing.Point(4, 24)
        Me.tp_correosListados.Name = "tp_correosListados"
        Me.tp_correosListados.Size = New System.Drawing.Size(874, 431)
        Me.tp_correosListados.TabIndex = 23
        Me.tp_correosListados.Text = "Envío de Listados"
        Me.tp_correosListados.UseVisualStyleBackColor = True
        '
        'bt_aplicar
        '
        Me.bt_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aplicar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aplicar.ForeColor = System.Drawing.Color.Black
        Me.bt_aplicar.Location = New System.Drawing.Point(503, 474)
        Me.bt_aplicar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aplicar.TabIndex = 19
        Me.bt_aplicar.Text = "Aplicar"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.ForeColor = System.Drawing.Color.Black
        Me.bt_cancelar.Location = New System.Drawing.Point(399, 474)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 18
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptar.Location = New System.Drawing.Point(295, 474)
        Me.bt_aceptar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 17
        Me.bt_aceptar.Text = "Aceptar"
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 42
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn10.HeaderText = "Evento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.Width = 202
        '
        'Usuarios
        '
        Me.Usuarios.HeaderText = "Usuarios"
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Usuarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Usuarios.Width = 80
        '
        'Clientes
        '
        Me.Clientes.HeaderText = "Clientes"
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Clientes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Clientes.Width = 80
        '
        'Vendedores
        '
        Me.Vendedores.HeaderText = "Vendedores"
        Me.Vendedores.Name = "Vendedores"
        Me.Vendedores.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vendedores.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Vendedores.Width = 85
        '
        'Frm_Configuracion_Mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 516)
        Me.Controls.Add(Me.tab_correos)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Configuracion_Mail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones Correos"
        Me.tab_correos.ResumeLayout(False)
        Me.tp_correos.ResumeLayout(False)
        CType(Me.DGV_Eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_correos As System.Windows.Forms.TabControl
    Friend WithEvents tp_correos As System.Windows.Forms.TabPage
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents bt_aplicar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tp_correosListados As System.Windows.Forms.TabPage
    Friend WithEvents DGV_Eventos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuarios As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Clientes As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Vendedores As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
