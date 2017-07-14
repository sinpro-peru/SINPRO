<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AutorizarPedido
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Pedido = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_PendienteC = New System.Windows.Forms.Label
        Me.lbl_pendiente = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_vencidoC = New System.Windows.Forms.Label
        Me.lbl_vencido = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_chequesDev = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_autorizar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbl_limite = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.bt_express = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Monto Pendiente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Pedido
        '
        Me.lbl_Pedido.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Pedido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pedido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Pedido.Location = New System.Drawing.Point(9, 111)
        Me.lbl_Pedido.Name = "lbl_Pedido"
        Me.lbl_Pedido.Size = New System.Drawing.Size(343, 23)
        Me.lbl_Pedido.TabIndex = 102
        Me.lbl_Pedido.Text = "Indicadores"
        Me.lbl_Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Cantidad Facturas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_PendienteC)
        Me.GroupBox1.Controls.Add(Me.lbl_pendiente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 63)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Por vencer"
        '
        'lbl_PendienteC
        '
        Me.lbl_PendienteC.AutoSize = True
        Me.lbl_PendienteC.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PendienteC.Location = New System.Drawing.Point(128, 41)
        Me.lbl_PendienteC.Name = "lbl_PendienteC"
        Me.lbl_PendienteC.Size = New System.Drawing.Size(56, 15)
        Me.lbl_PendienteC.TabIndex = 114
        Me.lbl_PendienteC.Text = "Facturas"
        '
        'lbl_pendiente
        '
        Me.lbl_pendiente.AutoSize = True
        Me.lbl_pendiente.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendiente.Location = New System.Drawing.Point(128, 18)
        Me.lbl_pendiente.Name = "lbl_pendiente"
        Me.lbl_pendiente.Size = New System.Drawing.Size(167, 15)
        Me.lbl_pendiente.TabIndex = 113
        Me.lbl_pendiente.Text = "Saldo Pendiente por Vencer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_vencidoC)
        Me.GroupBox2.Controls.Add(Me.lbl_vencido)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 63)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vencido"
        '
        'lbl_vencidoC
        '
        Me.lbl_vencidoC.AutoSize = True
        Me.lbl_vencidoC.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vencidoC.Location = New System.Drawing.Point(128, 41)
        Me.lbl_vencidoC.Name = "lbl_vencidoC"
        Me.lbl_vencidoC.Size = New System.Drawing.Size(56, 15)
        Me.lbl_vencidoC.TabIndex = 116
        Me.lbl_vencidoC.Text = "Facturas"
        '
        'lbl_vencido
        '
        Me.lbl_vencido.AutoSize = True
        Me.lbl_vencido.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vencido.Location = New System.Drawing.Point(128, 18)
        Me.lbl_vencido.Name = "lbl_vencido"
        Me.lbl_vencido.Size = New System.Drawing.Size(148, 15)
        Me.lbl_vencido.TabIndex = 115
        Me.lbl_vencido.Text = "Saldo Pendiente vencido"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Monto Pendiente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Cantidad Facturas:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(9, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 194)
        Me.Panel1.TabIndex = 109
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_chequesDev)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 42)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Devuelto"
        '
        'lbl_chequesDev
        '
        Me.lbl_chequesDev.AutoSize = True
        Me.lbl_chequesDev.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chequesDev.Location = New System.Drawing.Point(150, 19)
        Me.lbl_chequesDev.Name = "lbl_chequesDev"
        Me.lbl_chequesDev.Size = New System.Drawing.Size(21, 15)
        Me.lbl_chequesDev.TabIndex = 115
        Me.lbl_chequesDev.Text = "##"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 22)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Cheques por reponer:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(230, 332)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(91, 29)
        Me.bt_cancelar.TabIndex = 112
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        '
        'bt_autorizar
        '
        Me.bt_autorizar.BackColor = System.Drawing.Color.White
        Me.bt_autorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_autorizar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_autorizar.Location = New System.Drawing.Point(36, 332)
        Me.bt_autorizar.Name = "bt_autorizar"
        Me.bt_autorizar.Size = New System.Drawing.Size(91, 29)
        Me.bt_autorizar.TabIndex = 87
        Me.bt_autorizar.Text = "Autorizar"
        Me.bt_autorizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 23)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Datos Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_limite)
        Me.Panel2.Controls.Add(Me.lbl_Cliente)
        Me.Panel2.Controls.Add(Me.lbl_codigo)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(8, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 79)
        Me.Panel2.TabIndex = 111
        '
        'lbl_limite
        '
        Me.lbl_limite.AutoSize = True
        Me.lbl_limite.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limite.Location = New System.Drawing.Point(102, 56)
        Me.lbl_limite.Name = "lbl_limite"
        Me.lbl_limite.Size = New System.Drawing.Size(102, 15)
        Me.lbl_limite.TabIndex = 114
        Me.lbl_limite.Text = "Límite de crédito"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(68, 33)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(78, 15)
        Me.lbl_Cliente.TabIndex = 113
        Me.lbl_Cliente.Text = "Razón Social"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(59, 11)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(88, 15)
        Me.lbl_codigo.TabIndex = 112
        Me.lbl_codigo.Text = "CodigoCliente"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Limite Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 23)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Nombre:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 23)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Codigo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_express
        '
        Me.bt_express.BackColor = System.Drawing.Color.White
        Me.bt_express.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_express.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_express.Location = New System.Drawing.Point(133, 332)
        Me.bt_express.Name = "bt_express"
        Me.bt_express.Size = New System.Drawing.Size(91, 29)
        Me.bt_express.TabIndex = 113
        Me.bt_express.Text = "Express"
        Me.bt_express.UseVisualStyleBackColor = False
        '
        'Frm_AutorizarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(359, 369)
        Me.Controls.Add(Me.bt_express)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_Pedido)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_autorizar)
        Me.Name = "Frm_AutorizarPedido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizar Pedido"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Pedido As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_limite As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_PendienteC As System.Windows.Forms.Label
    Friend WithEvents lbl_pendiente As System.Windows.Forms.Label
    Friend WithEvents lbl_vencidoC As System.Windows.Forms.Label
    Friend WithEvents lbl_vencido As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_chequesDev As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_autorizar As System.Windows.Forms.Button
    Friend WithEvents bt_express As System.Windows.Forms.Button
End Class
