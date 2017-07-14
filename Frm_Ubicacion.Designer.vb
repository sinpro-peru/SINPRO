<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ubicacion
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.gb_Direccion = New System.Windows.Forms.GroupBox
        Me.cb_cuarto = New System.Windows.Forms.ComboBox
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.gb_Direccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 23)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Desitno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_Direccion
        '
        Me.gb_Direccion.BackColor = System.Drawing.Color.White
        Me.gb_Direccion.Controls.Add(Me.cb_cuarto)
        Me.gb_Direccion.Controls.Add(Me.cb_tramo)
        Me.gb_Direccion.Controls.Add(Me.cb_almacen)
        Me.gb_Direccion.Controls.Add(Me.cb_estante)
        Me.gb_Direccion.Controls.Add(Me.Label19)
        Me.gb_Direccion.Controls.Add(Me.Label18)
        Me.gb_Direccion.Controls.Add(Me.Label17)
        Me.gb_Direccion.Controls.Add(Me.Label16)
        Me.gb_Direccion.Location = New System.Drawing.Point(12, 22)
        Me.gb_Direccion.Name = "gb_Direccion"
        Me.gb_Direccion.Size = New System.Drawing.Size(229, 187)
        Me.gb_Direccion.TabIndex = 101
        Me.gb_Direccion.TabStop = False
        '
        'cb_cuarto
        '
        Me.cb_cuarto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuarto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cuarto.FormattingEnabled = True
        Me.cb_cuarto.Location = New System.Drawing.Point(86, 67)
        Me.cb_cuarto.Name = "cb_cuarto"
        Me.cb_cuarto.Size = New System.Drawing.Size(121, 22)
        Me.cb_cuarto.TabIndex = 95
        '
        'cb_tramo
        '
        Me.cb_tramo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tramo.FormattingEnabled = True
        Me.cb_tramo.Location = New System.Drawing.Point(86, 141)
        Me.cb_tramo.Name = "cb_tramo"
        Me.cb_tramo.Size = New System.Drawing.Size(121, 22)
        Me.cb_tramo.TabIndex = 97
        '
        'cb_almacen
        '
        Me.cb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen.DisplayMember = "Nombre"
        Me.cb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen.FormattingEnabled = True
        Me.cb_almacen.Location = New System.Drawing.Point(86, 30)
        Me.cb_almacen.Name = "cb_almacen"
        Me.cb_almacen.Size = New System.Drawing.Size(121, 22)
        Me.cb_almacen.TabIndex = 94
        Me.cb_almacen.ValueMember = "Id"
        '
        'cb_estante
        '
        Me.cb_estante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_estante.FormattingEnabled = True
        Me.cb_estante.Location = New System.Drawing.Point(86, 104)
        Me.cb_estante.Name = "cb_estante"
        Me.cb_estante.Size = New System.Drawing.Size(121, 22)
        Me.cb_estante.TabIndex = 96
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 23)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "(*)Tramo:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 23)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "(*)Estante:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 23)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "(*)Cuarto:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 23)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "(*)Almacén:"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(45, 219)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 10044
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(135, 219)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 10045
        Me.bt_cancelar.Text = "Cancelar"
        '
        'Frm_Ubicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(254, 252)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gb_Direccion)
        Me.Name = "Frm_Ubicacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elija Ubicacion"
        Me.gb_Direccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gb_Direccion As System.Windows.Forms.GroupBox
    Friend WithEvents cb_cuarto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
End Class
