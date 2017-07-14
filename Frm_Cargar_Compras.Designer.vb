<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cargar_Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cargar_Compras))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_codPedido = New System.Windows.Forms.Label
        Me.lbl_proveedor = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_CodFac = New System.Windows.Forms.TextBox
        Me.btn_presentar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.ch_precios = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Cod. Pedido:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 10047
        Me.Label1.Text = "Fecha:"
        '
        'lbl_codPedido
        '
        Me.lbl_codPedido.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codPedido.Location = New System.Drawing.Point(140, 15)
        Me.lbl_codPedido.Name = "lbl_codPedido"
        Me.lbl_codPedido.Size = New System.Drawing.Size(113, 23)
        Me.lbl_codPedido.TabIndex = 10048
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proveedor.Location = New System.Drawing.Point(140, 45)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(112, 23)
        Me.lbl_proveedor.TabIndex = 10049
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 10050
        Me.Label3.Text = "(*)Cod. Factura:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(143, 72)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(109, 22)
        Me.dtp_fecha.TabIndex = 10051
        Me.dtp_fecha.Value = New Date(2008, 10, 9, 0, 0, 0, 0)
        '
        'tb_CodFac
        '
        Me.tb_CodFac.Location = New System.Drawing.Point(143, 105)
        Me.tb_CodFac.Name = "tb_CodFac"
        Me.tb_CodFac.Size = New System.Drawing.Size(109, 20)
        Me.tb_CodFac.TabIndex = 1
        '
        'btn_presentar
        '
        Me.btn_presentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_presentar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_presentar.Location = New System.Drawing.Point(20, 223)
        Me.btn_presentar.Name = "btn_presentar"
        Me.btn_presentar.Size = New System.Drawing.Size(75, 23)
        Me.btn_presentar.TabIndex = 3
        Me.btn_presentar.Text = "Presentar"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Location = New System.Drawing.Point(114, 223)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Aceptar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(212, 223)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "(*)Almacén:"
        '
        'cb_almacen
        '
        Me.cb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen.DisplayMember = "Nombre"
        Me.cb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen.FormattingEnabled = True
        Me.cb_almacen.Location = New System.Drawing.Point(143, 137)
        Me.cb_almacen.Name = "cb_almacen"
        Me.cb_almacen.Size = New System.Drawing.Size(109, 23)
        Me.cb_almacen.TabIndex = 2
        Me.cb_almacen.ValueMember = "Id"
        '
        'ch_precios
        '
        Me.ch_precios.AutoSize = True
        Me.ch_precios.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_precios.ForeColor = System.Drawing.Color.Red
        Me.ch_precios.Location = New System.Drawing.Point(31, 178)
        Me.ch_precios.Name = "ch_precios"
        Me.ch_precios.Size = New System.Drawing.Size(263, 19)
        Me.ch_precios.TabIndex = 10052
        Me.ch_precios.Text = "Cargar los Precios de los Productos"
        Me.ch_precios.UseVisualStyleBackColor = True
        '
        'Frm_Cargar_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(296, 257)
        Me.Controls.Add(Me.ch_precios)
        Me.Controls.Add(Me.cb_almacen)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_presentar)
        Me.Controls.Add(Me.tb_CodFac)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.lbl_codPedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cargar_Compras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar compras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codPedido As System.Windows.Forms.Label
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_CodFac As System.Windows.Forms.TextBox
    Friend WithEvents btn_presentar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents ch_precios As System.Windows.Forms.CheckBox
End Class
