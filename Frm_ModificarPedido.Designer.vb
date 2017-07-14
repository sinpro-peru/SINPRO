<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ModificarPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ModificarPedido))
        Me.tb_cantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lb_codigo = New System.Windows.Forms.Label
        Me.lb_producto = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tb_cantidad
        '
        Me.tb_cantidad.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_cantidad.Location = New System.Drawing.Point(138, 78)
        Me.tb_cantidad.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tb_cantidad.Name = "tb_cantidad"
        Me.tb_cantidad.Size = New System.Drawing.Size(87, 44)
        Me.tb_cantidad.TabIndex = 34
        Me.tb_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Cant.:"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(41, 155)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(104, 23)
        Me.bt_aceptar.TabIndex = 35
        Me.bt_aceptar.Text = "Con Backorder"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(171, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Sin Backorder"
        '
        'lb_codigo
        '
        Me.lb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_codigo.Location = New System.Drawing.Point(72, 9)
        Me.lb_codigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(167, 20)
        Me.lb_codigo.TabIndex = 43
        Me.lb_codigo.Text = "cod"
        Me.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_producto
        '
        Me.lb_producto.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_producto.Location = New System.Drawing.Point(3, 32)
        Me.lb_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_producto.Name = "lb_producto"
        Me.lb_producto.Size = New System.Drawing.Size(298, 20)
        Me.lb_producto.TabIndex = 42
        Me.lb_producto.Text = "Descripción del artículo"
        Me.lb_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(111, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Modificar"
        '
        'Frm_ModificarPedido
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 189)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.lb_producto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tb_cantidad)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ModificarPedido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar cantidad en pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_producto As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
