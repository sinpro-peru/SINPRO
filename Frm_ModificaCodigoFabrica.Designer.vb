<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ModificaCodigoFabrica
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
        Me.gb_codigoFabrica = New System.Windows.Forms.GroupBox
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lbl_desc = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_codProd = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_CodigoProv = New System.Windows.Forms.Label
        Me.lbl_Proveedor = New System.Windows.Forms.Label
        Me.tb_codigoFabrica = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.gb_codigoFabrica.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_codigoFabrica
        '
        Me.gb_codigoFabrica.BackColor = System.Drawing.Color.White
        Me.gb_codigoFabrica.Controls.Add(Me.Button2)
        Me.gb_codigoFabrica.Controls.Add(Me.bt_aceptar)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_desc)
        Me.gb_codigoFabrica.Controls.Add(Me.Label4)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_codProd)
        Me.gb_codigoFabrica.Controls.Add(Me.Label2)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_CodigoProv)
        Me.gb_codigoFabrica.Controls.Add(Me.lbl_Proveedor)
        Me.gb_codigoFabrica.Controls.Add(Me.tb_codigoFabrica)
        Me.gb_codigoFabrica.Controls.Add(Me.Label23)
        Me.gb_codigoFabrica.Controls.Add(Me.Label29)
        Me.gb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_codigoFabrica.Location = New System.Drawing.Point(12, 12)
        Me.gb_codigoFabrica.Name = "gb_codigoFabrica"
        Me.gb_codigoFabrica.Size = New System.Drawing.Size(236, 163)
        Me.gb_codigoFabrica.TabIndex = 20005
        Me.gb_codigoFabrica.TabStop = False
        Me.gb_codigoFabrica.Text = "Código de Fábrica"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Location = New System.Drawing.Point(30, 126)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 110
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(87, 66)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(53, 16)
        Me.lbl_desc.TabIndex = 109
        Me.lbl_desc.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Descripción: "
        '
        'lbl_codProd
        '
        Me.lbl_codProd.AutoSize = True
        Me.lbl_codProd.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codProd.Location = New System.Drawing.Point(87, 43)
        Me.lbl_codProd.Name = "lbl_codProd"
        Me.lbl_codProd.Size = New System.Drawing.Size(53, 16)
        Me.lbl_codProd.TabIndex = 107
        Me.lbl_codProd.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Producto: "
        '
        'lbl_CodigoProv
        '
        Me.lbl_CodigoProv.AutoSize = True
        Me.lbl_CodigoProv.Location = New System.Drawing.Point(3, 145)
        Me.lbl_CodigoProv.Name = "lbl_CodigoProv"
        Me.lbl_CodigoProv.Size = New System.Drawing.Size(45, 15)
        Me.lbl_CodigoProv.TabIndex = 105
        Me.lbl_CodigoProv.Text = "Label1"
        Me.lbl_CodigoProv.Visible = False
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
        'tb_codigoFabrica
        '
        Me.tb_codigoFabrica.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigoFabrica.Location = New System.Drawing.Point(90, 89)
        Me.tb_codigoFabrica.Name = "tb_codigoFabrica"
        Me.tb_codigoFabrica.Size = New System.Drawing.Size(136, 22)
        Me.tb_codigoFabrica.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 89)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 23)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Cod. Fábrica:"
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
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(131, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frm_ModificaCodigoFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(260, 178)
        Me.Controls.Add(Me.gb_codigoFabrica)
        Me.Name = "Frm_ModificaCodigoFabrica"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Codigo Fábrica"
        Me.gb_codigoFabrica.ResumeLayout(False)
        Me.gb_codigoFabrica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_codigoFabrica As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents tb_codigoFabrica As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lbl_CodigoProv As System.Windows.Forms.Label
    Friend WithEvents lbl_desc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_codProd As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
