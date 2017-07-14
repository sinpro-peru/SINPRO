<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Respuestas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Respuestas))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_titulo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_mensaje = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_remitente = New System.Windows.Forms.TextBox
        Me.DGV_Respuestas = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.chk_finalizado = New System.Windows.Forms.CheckBox
        Me.bt_enviar = New System.Windows.Forms.Button
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Respuesta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Respuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Título:"
        '
        'tb_titulo
        '
        Me.tb_titulo.Location = New System.Drawing.Point(65, 53)
        Me.tb_titulo.Name = "tb_titulo"
        Me.tb_titulo.ReadOnly = True
        Me.tb_titulo.Size = New System.Drawing.Size(468, 21)
        Me.tb_titulo.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mensaje:"
        '
        'tb_mensaje
        '
        Me.tb_mensaje.Location = New System.Drawing.Point(65, 80)
        Me.tb_mensaje.Multiline = True
        Me.tb_mensaje.Name = "tb_mensaje"
        Me.tb_mensaje.ReadOnly = True
        Me.tb_mensaje.Size = New System.Drawing.Size(468, 89)
        Me.tb_mensaje.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_remitente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_titulo)
        Me.GroupBox1.Controls.Add(Me.tb_mensaje)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 180)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mensaje original"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "De:"
        '
        'tb_remitente
        '
        Me.tb_remitente.Location = New System.Drawing.Point(65, 26)
        Me.tb_remitente.Name = "tb_remitente"
        Me.tb_remitente.ReadOnly = True
        Me.tb_remitente.Size = New System.Drawing.Size(231, 21)
        Me.tb_remitente.TabIndex = 6
        '
        'DGV_Respuestas
        '
        Me.DGV_Respuestas.AllowUserToAddRows = False
        Me.DGV_Respuestas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Respuestas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Respuestas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Respuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Respuestas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario, Me.Fecha, Me.Respuesta, Me.Login})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Respuestas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Respuestas.Location = New System.Drawing.Point(6, 20)
        Me.DGV_Respuestas.Name = "DGV_Respuestas"
        Me.DGV_Respuestas.RowHeadersVisible = False
        Me.DGV_Respuestas.RowTemplate.Height = 80
        Me.DGV_Respuestas.RowTemplate.ReadOnly = True
        Me.DGV_Respuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Respuestas.Size = New System.Drawing.Size(534, 264)
        Me.DGV_Respuestas.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Respuestas)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 291)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respuestas"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.White
        Me.bt_eliminar.BackgroundImage = CType(resources.GetObject("bt_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.bt_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_eliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(494, 495)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(51, 25)
        Me.bt_eliminar.TabIndex = 10019
        Me.bt_eliminar.UseVisualStyleBackColor = True
        Me.bt_eliminar.Visible = False
        '
        'chk_finalizado
        '
        Me.chk_finalizado.AutoSize = True
        Me.chk_finalizado.Location = New System.Drawing.Point(8, 500)
        Me.chk_finalizado.Name = "chk_finalizado"
        Me.chk_finalizado.Size = New System.Drawing.Size(79, 18)
        Me.chk_finalizado.TabIndex = 10018
        Me.chk_finalizado.Text = "Finalizado"
        Me.chk_finalizado.UseVisualStyleBackColor = True
        Me.chk_finalizado.Visible = False
        '
        'bt_enviar
        '
        Me.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enviar.Location = New System.Drawing.Point(242, 497)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(75, 23)
        Me.bt_enviar.TabIndex = 10020
        Me.bt_enviar.Text = "Enviar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 90
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 130
        '
        'Respuesta
        '
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Respuesta.DefaultCellStyle = DataGridViewCellStyle2
        Me.Respuesta.HeaderText = "Respuesta"
        Me.Respuesta.MaxInputLength = 200
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Width = 290
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Visible = False
        '
        'Frm_Respuestas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 530)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.chk_finalizado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_Respuestas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de respuestas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Respuestas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Respuestas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_finalizado As System.Windows.Forms.CheckBox
    Friend WithEvents bt_enviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_remitente As System.Windows.Forms.TextBox
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Respuesta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
