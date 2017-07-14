<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MensajesFuturos
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_Futuros = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.bt_enviar = New System.Windows.Forms.Button
        Me.id_m = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.login = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.imp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Futuros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Futuros)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 450)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respuestas"
        '
        'DGV_Futuros
        '
        Me.DGV_Futuros.AllowUserToAddRows = False
        Me.DGV_Futuros.AllowUserToDeleteRows = False
        Me.DGV_Futuros.AllowUserToOrderColumns = True
        Me.DGV_Futuros.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Futuros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Futuros.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Futuros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Futuros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_m, Me.Tipo, Me.Fecha, Me.Usuario, Me.Titulo, Me.login, Me.imp})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Futuros.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Futuros.Location = New System.Drawing.Point(6, 20)
        Me.DGV_Futuros.MultiSelect = False
        Me.DGV_Futuros.Name = "DGV_Futuros"
        Me.DGV_Futuros.RowHeadersVisible = False
        Me.DGV_Futuros.RowTemplate.Height = 40
        Me.DGV_Futuros.RowTemplate.ReadOnly = True
        Me.DGV_Futuros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Futuros.Size = New System.Drawing.Size(544, 424)
        Me.DGV_Futuros.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 57)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(200, 21)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(113, 21)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "y"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Entre"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(62, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'bt_enviar
        '
        Me.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enviar.Location = New System.Drawing.Point(239, 531)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(75, 23)
        Me.bt_enviar.TabIndex = 10022
        Me.bt_enviar.Text = "Cerrar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'id_m
        '
        Me.id_m.HeaderText = "id_m"
        Me.id_m.Name = "id_m"
        Me.id_m.Visible = False
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "T"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 40
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 80
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 150
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Título"
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Width = 250
        '
        'login
        '
        Me.login.HeaderText = "login"
        Me.login.Name = "login"
        Me.login.Visible = False
        '
        'imp
        '
        Me.imp.HeaderText = "imp"
        Me.imp.Name = "imp"
        Me.imp.Visible = False
        '
        'Frm_MensajesFuturos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 560)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "Frm_MensajesFuturos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensajes/Recordatorios Futuros"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Futuros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Futuros As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_enviar As System.Windows.Forms.Button
    Friend WithEvents id_m As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
