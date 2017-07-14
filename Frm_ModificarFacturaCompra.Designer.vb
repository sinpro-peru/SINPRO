<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ModificarFacturaCompra
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
        Me.gb_codigoFabrica = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lbl_codCompra = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.tb_factura = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.gb_codigoFabrica.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_codigoFabrica
        '
        Me.gb_codigoFabrica.BackColor = System.Drawing.Color.White
        Me.gb_codigoFabrica.Controls.Add(Me.Button2)
        Me.gb_codigoFabrica.Controls.Add(Me.bt_aceptar)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_codCompra)
        Me.gb_codigoFabrica.Controls.Add(Me.Label2)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_Proveedor)
        Me.gb_codigoFabrica.Controls.Add(Me.tb_factura)
        Me.gb_codigoFabrica.Controls.Add(Me.Label23)
        Me.gb_codigoFabrica.Controls.Add(Me.Label29)
        Me.gb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_codigoFabrica.Location = New System.Drawing.Point(12, 12)
        Me.gb_codigoFabrica.Name = "gb_codigoFabrica"
        Me.gb_codigoFabrica.Size = New System.Drawing.Size(236, 147)
        Me.gb_codigoFabrica.TabIndex = 20006
        Me.gb_codigoFabrica.TabStop = False
        Me.gb_codigoFabrica.Text = "Código de Fábrica"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(131, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Location = New System.Drawing.Point(30, 108)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 110
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_codCompra
        '
        Me.lbl_codCompra.AutoSize = True
        Me.lbl_codCompra.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codCompra.Location = New System.Drawing.Point(87, 43)
        Me.lbl_codCompra.Name = "lbl_codCompra"
        Me.lbl_codCompra.Size = New System.Drawing.Size(53, 16)
        Me.lbl_codCompra.TabIndex = 107
        Me.lbl_codCompra.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Cod. Compra: "
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Proveedor.Location = New System.Drawing.Point(87, 20)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(53, 16)
        Me.lbl_Proveedor.TabIndex = 104
        Me.lbl_Proveedor.Text = "Label1"
        '
        'tb_factura
        '
        Me.tb_factura.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_factura.Location = New System.Drawing.Point(90, 66)
        Me.tb_factura.Name = "tb_factura"
        Me.tb_factura.Size = New System.Drawing.Size(136, 22)
        Me.tb_factura.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 23)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Nro. Factura:"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 23)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Proveedor: "
        '
        'Frm_ModificarFacturaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(261, 169)
        Me.Controls.Add(Me.gb_codigoFabrica)
        Me.Name = "Frm_ModificarFacturaCompra"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar num. factura"
        Me.gb_codigoFabrica.ResumeLayout(False)
        Me.gb_codigoFabrica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_codigoFabrica As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_codCompra As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents tb_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
End Class
