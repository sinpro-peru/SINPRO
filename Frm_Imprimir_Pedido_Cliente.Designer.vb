<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Imprimir_Pedido_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Imprimir_Pedido_Cliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ch_cuarto = New System.Windows.Forms.CheckBox
        Me.ch_almacen = New System.Windows.Forms.CheckBox
        Me.ch_todo = New System.Windows.Forms.CheckBox
        Me.rb_prefactura = New System.Windows.Forms.RadioButton
        Me.rb_valesalida = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ch_cuarto)
        Me.GroupBox1.Controls.Add(Me.ch_almacen)
        Me.GroupBox1.Controls.Add(Me.ch_todo)
        Me.GroupBox1.Controls.Add(Me.rb_prefactura)
        Me.GroupBox1.Controls.Add(Me.rb_valesalida)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imprimir"
        '
        'ch_cuarto
        '
        Me.ch_cuarto.AutoSize = True
        Me.ch_cuarto.Location = New System.Drawing.Point(151, 81)
        Me.ch_cuarto.Name = "ch_cuarto"
        Me.ch_cuarto.Size = New System.Drawing.Size(66, 19)
        Me.ch_cuarto.TabIndex = 20010
        Me.ch_cuarto.Text = "Cuarto"
        Me.ch_cuarto.UseVisualStyleBackColor = True
        Me.ch_cuarto.Visible = False
        '
        'ch_almacen
        '
        Me.ch_almacen.AutoSize = True
        Me.ch_almacen.Location = New System.Drawing.Point(151, 56)
        Me.ch_almacen.Name = "ch_almacen"
        Me.ch_almacen.Size = New System.Drawing.Size(77, 19)
        Me.ch_almacen.TabIndex = 20009
        Me.ch_almacen.Text = "Almacen"
        Me.ch_almacen.UseVisualStyleBackColor = True
        Me.ch_almacen.Visible = False
        '
        'ch_todo
        '
        Me.ch_todo.AutoSize = True
        Me.ch_todo.Location = New System.Drawing.Point(151, 31)
        Me.ch_todo.Name = "ch_todo"
        Me.ch_todo.Size = New System.Drawing.Size(57, 19)
        Me.ch_todo.TabIndex = 20008
        Me.ch_todo.Text = "Todo"
        Me.ch_todo.UseVisualStyleBackColor = True
        Me.ch_todo.Visible = False
        '
        'rb_prefactura
        '
        Me.rb_prefactura.AutoSize = True
        Me.rb_prefactura.Location = New System.Drawing.Point(31, 105)
        Me.rb_prefactura.Name = "rb_prefactura"
        Me.rb_prefactura.Size = New System.Drawing.Size(85, 19)
        Me.rb_prefactura.TabIndex = 20007
        Me.rb_prefactura.TabStop = True
        Me.rb_prefactura.Text = "Prefactura"
        Me.rb_prefactura.UseVisualStyleBackColor = True
        '
        'rb_valesalida
        '
        Me.rb_valesalida.AutoSize = True
        Me.rb_valesalida.Location = New System.Drawing.Point(31, 30)
        Me.rb_valesalida.Name = "rb_valesalida"
        Me.rb_valesalida.Size = New System.Drawing.Size(106, 19)
        Me.rb_valesalida.TabIndex = 20006
        Me.rb_valesalida.TabStop = True
        Me.rb_valesalida.Text = "Vale de Salida"
        Me.rb_valesalida.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(174, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20005
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20004
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(93, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20011
        Me.Button3.Text = "Express"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Frm_Imprimir_Pedido_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(282, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Imprimir_Pedido_Cliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ch_cuarto As System.Windows.Forms.CheckBox
    Friend WithEvents ch_almacen As System.Windows.Forms.CheckBox
    Friend WithEvents ch_todo As System.Windows.Forms.CheckBox
    Friend WithEvents rb_prefactura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_valesalida As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
