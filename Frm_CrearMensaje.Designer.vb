<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CrearMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CrearMensaje))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb_usuario = New System.Windows.Forms.ComboBox
        Me.Sp_consultaUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_hora = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_minutos = New System.Windows.Forms.TextBox
        Me.cb_AM_PM = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chk_repetir = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cb_tope = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cb_frecuencia = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cb_importancia = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_mensaje = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_titulo = New System.Windows.Forms.TextBox
        Me.bt_enviar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.chk_finalizado = New System.Windows.Forms.CheckBox
        Me.Sp_consultaUsuariosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaUsuariosTableAdapter
        CType(Me.Sp_consultaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Para:"
        '
        'cb_usuario
        '
        Me.cb_usuario.DataSource = Me.Sp_consultaUsuariosBindingSource
        Me.cb_usuario.DisplayMember = "nombre"
        Me.cb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_usuario.FormattingEnabled = True
        Me.cb_usuario.Location = New System.Drawing.Point(41, 25)
        Me.cb_usuario.Name = "cb_usuario"
        Me.cb_usuario.Size = New System.Drawing.Size(205, 22)
        Me.cb_usuario.TabIndex = 1
        Me.cb_usuario.ValueMember = "Login"
        '
        'Sp_consultaUsuariosBindingSource
        '
        Me.Sp_consultaUsuariosBindingSource.DataMember = "sp_consultaUsuarios"
        Me.Sp_consultaUsuariosBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(303, 25)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(107, 21)
        Me.dtp_fecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora:"
        '
        'tb_hora
        '
        Me.tb_hora.Location = New System.Drawing.Point(303, 58)
        Me.tb_hora.MaxLength = 2
        Me.tb_hora.Name = "tb_hora"
        Me.tb_hora.Size = New System.Drawing.Size(31, 21)
        Me.tb_hora.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ":"
        '
        'tb_minutos
        '
        Me.tb_minutos.Location = New System.Drawing.Point(348, 58)
        Me.tb_minutos.MaxLength = 2
        Me.tb_minutos.Name = "tb_minutos"
        Me.tb_minutos.Size = New System.Drawing.Size(31, 21)
        Me.tb_minutos.TabIndex = 7
        '
        'cb_AM_PM
        '
        Me.cb_AM_PM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_AM_PM.FormattingEnabled = True
        Me.cb_AM_PM.Items.AddRange(New Object() {"A.M.", "P.M."})
        Me.cb_AM_PM.Location = New System.Drawing.Point(384, 58)
        Me.cb_AM_PM.Name = "cb_AM_PM"
        Me.cb_AM_PM.Size = New System.Drawing.Size(57, 22)
        Me.cb_AM_PM.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.chk_repetir)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cb_tope)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cb_frecuencia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_importancia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_AM_PM)
        Me.GroupBox1.Controls.Add(Me.cb_usuario)
        Me.GroupBox1.Controls.Add(Me.tb_minutos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.tb_hora)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 125)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 10022
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'chk_repetir
        '
        Me.chk_repetir.AutoSize = True
        Me.chk_repetir.Location = New System.Drawing.Point(252, 93)
        Me.chk_repetir.Name = "chk_repetir"
        Me.chk_repetir.Size = New System.Drawing.Size(93, 18)
        Me.chk_repetir.TabIndex = 16
        Me.chk_repetir.Text = "Repeticiones"
        Me.chk_repetir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(486, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 14)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "días"
        '
        'cb_tope
        '
        Me.cb_tope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tope.Enabled = False
        Me.cb_tope.FormattingEnabled = True
        Me.cb_tope.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cb_tope.Location = New System.Drawing.Point(439, 91)
        Me.cb_tope.Name = "cb_tope"
        Me.cb_tope.Size = New System.Drawing.Size(45, 22)
        Me.cb_tope.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(406, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Por:"
        '
        'cb_frecuencia
        '
        Me.cb_frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_frecuencia.Enabled = False
        Me.cb_frecuencia.FormattingEnabled = True
        Me.cb_frecuencia.Items.AddRange(New Object() {"Diaria", "Semanal", "Mensual", "Anual"})
        Me.cb_frecuencia.Location = New System.Drawing.Point(347, 91)
        Me.cb_frecuencia.Name = "cb_frecuencia"
        Me.cb_frecuencia.Size = New System.Drawing.Size(57, 22)
        Me.cb_frecuencia.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Importancia:"
        '
        'cb_importancia
        '
        Me.cb_importancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_importancia.FormattingEnabled = True
        Me.cb_importancia.Items.AddRange(New Object() {"Normal", "Urgente"})
        Me.cb_importancia.Location = New System.Drawing.Point(85, 57)
        Me.cb_importancia.Name = "cb_importancia"
        Me.cb_importancia.Size = New System.Drawing.Size(87, 22)
        Me.cb_importancia.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb_mensaje)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tb_titulo)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 249)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mensaje"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "(No más de 200 caracteres)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(No más de 30 caracteres)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Mensaje:"
        '
        'tb_mensaje
        '
        Me.tb_mensaje.Location = New System.Drawing.Point(65, 79)
        Me.tb_mensaje.MaxLength = 200
        Me.tb_mensaje.Multiline = True
        Me.tb_mensaje.Name = "tb_mensaje"
        Me.tb_mensaje.Size = New System.Drawing.Size(468, 147)
        Me.tb_mensaje.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Título:"
        '
        'tb_titulo
        '
        Me.tb_titulo.Location = New System.Drawing.Point(65, 29)
        Me.tb_titulo.MaxLength = 30
        Me.tb_titulo.Name = "tb_titulo"
        Me.tb_titulo.Size = New System.Drawing.Size(468, 21)
        Me.tb_titulo.TabIndex = 0
        '
        'bt_enviar
        '
        Me.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enviar.Location = New System.Drawing.Point(239, 404)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(75, 23)
        Me.bt_enviar.TabIndex = 12
        Me.bt_enviar.Text = "Enviar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.White
        Me.bt_eliminar.BackgroundImage = CType(resources.GetObject("bt_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.bt_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_eliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(491, 402)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(51, 25)
        Me.bt_eliminar.TabIndex = 10021
        Me.bt_eliminar.UseVisualStyleBackColor = True
        Me.bt_eliminar.Visible = False
        '
        'chk_finalizado
        '
        Me.chk_finalizado.AutoSize = True
        Me.chk_finalizado.Location = New System.Drawing.Point(5, 407)
        Me.chk_finalizado.Name = "chk_finalizado"
        Me.chk_finalizado.Size = New System.Drawing.Size(79, 18)
        Me.chk_finalizado.TabIndex = 10020
        Me.chk_finalizado.Text = "Finalizado"
        Me.chk_finalizado.UseVisualStyleBackColor = True
        Me.chk_finalizado.Visible = False
        '
        'Sp_consultaUsuariosTableAdapter
        '
        Me.Sp_consultaUsuariosTableAdapter.ClearBeforeFill = True
        '
        'Frm_CrearMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 431)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.chk_finalizado)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_CrearMensaje"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Mensaje"
        CType(Me.Sp_consultaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_minutos As System.Windows.Forms.TextBox
    Friend WithEvents cb_AM_PM As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_importancia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bt_enviar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_finalizado As System.Windows.Forms.CheckBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaUsuariosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaUsuariosTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cb_tope As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_frecuencia As System.Windows.Forms.ComboBox
    Friend WithEvents chk_repetir As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
