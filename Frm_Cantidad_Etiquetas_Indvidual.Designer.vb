<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cantidad_Etiquetas_Indvidual
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
        Me.lb_codigo = New System.Windows.Forms.Label
        Me.lb_producto = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_cant = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lb_codigo
        '
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(80, 10)
        Me.lb_codigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(131, 20)
        Me.lb_codigo.TabIndex = 57
        Me.lb_codigo.Text = "cod"
        Me.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_producto
        '
        Me.lb_producto.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_producto.Location = New System.Drawing.Point(11, 33)
        Me.lb_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_producto.Name = "lb_producto"
        Me.lb_producto.Size = New System.Drawing.Size(262, 20)
        Me.lb_producto.TabIndex = 56
        Me.lb_producto.Text = "Descripción del artículo"
        Me.lb_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(162, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(73, 126)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(61, 23)
        Me.bt_aceptar.TabIndex = 54
        Me.bt_aceptar.Text = "Aceptar"
        '
        'tb_cant
        '
        Me.tb_cant.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_cant.Location = New System.Drawing.Point(126, 63)
        Me.tb_cant.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_cant.Name = "tb_cant"
        Me.tb_cant.Size = New System.Drawing.Size(85, 44)
        Me.tb_cant.TabIndex = 53
        Me.tb_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Cant:"
        '
        'Frm_Cantidad_Etiquetas_Indvidual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.lb_producto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tb_cant)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Cantidad_Etiquetas_Indvidual"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidad de etiquetas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_producto As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_cant As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
