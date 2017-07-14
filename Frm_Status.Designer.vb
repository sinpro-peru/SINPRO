<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Status))
        Me.Label3 = New System.Windows.Forms.Label
        Me.gb_Direccion = New System.Windows.Forms.GroupBox
        Me.Cb_a = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb_de = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.gb_Direccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 23)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_Direccion
        '
        Me.gb_Direccion.BackColor = System.Drawing.Color.White
        Me.gb_Direccion.Controls.Add(Me.Cb_a)
        Me.gb_Direccion.Controls.Add(Me.Label1)
        Me.gb_Direccion.Controls.Add(Me.cb_de)
        Me.gb_Direccion.Controls.Add(Me.Label16)
        Me.gb_Direccion.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Direccion.Location = New System.Drawing.Point(8, 34)
        Me.gb_Direccion.Name = "gb_Direccion"
        Me.gb_Direccion.Size = New System.Drawing.Size(198, 122)
        Me.gb_Direccion.TabIndex = 103
        Me.gb_Direccion.TabStop = False
        '
        'Cb_a
        '
        Me.Cb_a.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cb_a.DisplayMember = "Nombre"
        Me.Cb_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_a.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_a.FormattingEnabled = True
        Me.Cb_a.Items.AddRange(New Object() {"S", "R", "O", "N"})
        Me.Cb_a.Location = New System.Drawing.Point(101, 67)
        Me.Cb_a.Name = "Cb_a"
        Me.Cb_a.Size = New System.Drawing.Size(75, 23)
        Me.Cb_a.TabIndex = 1
        Me.Cb_a.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "(*)A status:"
        '
        'cb_de
        '
        Me.cb_de.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_de.DisplayMember = "Nombre"
        Me.cb_de.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_de.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_de.FormattingEnabled = True
        Me.cb_de.Items.AddRange(New Object() {"S", "R", "O", "N"})
        Me.cb_de.Location = New System.Drawing.Point(101, 30)
        Me.cb_de.Name = "cb_de"
        Me.cb_de.Size = New System.Drawing.Size(75, 23)
        Me.cb_de.TabIndex = 0
        Me.cb_de.ValueMember = "Id"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 23)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "(*)De status:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(28, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(109, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Frm_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(214, 197)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gb_Direccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Status"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de status"
        Me.gb_Direccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gb_Direccion As System.Windows.Forms.GroupBox
    Friend WithEvents cb_de As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cb_a As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
