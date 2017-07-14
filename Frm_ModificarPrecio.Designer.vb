<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ModificarPrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ModificarPrecio))
        Me.lb_codigo = New System.Windows.Forms.Label
        Me.lb_producto = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_precio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lb_codigo
        '
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(73, 10)
        Me.lb_codigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(167, 20)
        Me.lb_codigo.TabIndex = 49
        Me.lb_codigo.Text = "cod"
        Me.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_producto
        '
        Me.lb_producto.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_producto.Location = New System.Drawing.Point(4, 33)
        Me.lb_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_producto.Name = "lb_producto"
        Me.lb_producto.Size = New System.Drawing.Size(298, 20)
        Me.lb_producto.TabIndex = 48
        Me.lb_producto.Text = "Descripción del artículo"
        Me.lb_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(172, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(49, 156)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(97, 23)
        Me.bt_aceptar.TabIndex = 46
        Me.bt_aceptar.Text = "Aceptar"
        '
        'tb_precio
        '
        Me.tb_precio.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_precio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_precio.Location = New System.Drawing.Point(119, 79)
        Me.tb_precio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_precio.Name = "tb_precio"
        Me.tb_precio.Size = New System.Drawing.Size(121, 44)
        Me.tb_precio.TabIndex = 45
        Me.tb_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Pedido:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'lbl_pedido
        '
        Me.lbl_pedido.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.Location = New System.Drawing.Point(154, 53)
        Me.lbl_pedido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(86, 20)
        Me.lbl_pedido.TabIndex = 51
        Me.lbl_pedido.Text = "##"
        Me.lbl_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_pedido.Visible = False
        '
        'Frm_ModificarPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 189)
        Me.Controls.Add(Me.lbl_pedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.lb_producto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tb_precio)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ModificarPrecio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Precio"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_producto As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
End Class
