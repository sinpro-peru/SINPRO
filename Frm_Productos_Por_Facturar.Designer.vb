<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Productos_Por_Facturar
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Productos_Por_Facturar))
        Me.ti_productos = New System.Windows.Forms.Label
        Me.DGV_Pedidos = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_producto = New System.Windows.Forms.Label
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ti_productos
        '
        Me.ti_productos.BackColor = System.Drawing.Color.DodgerBlue
        Me.ti_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ti_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ti_productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ti_productos.Location = New System.Drawing.Point(10, 99)
        Me.ti_productos.Name = "ti_productos"
        Me.ti_productos.Size = New System.Drawing.Size(410, 23)
        Me.ti_productos.TabIndex = 80
        Me.ti_productos.Text = "PEDIDOS PENDIENTES"
        Me.ti_productos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Pedidos
        '
        Me.DGV_Pedidos.AllowUserToAddRows = False
        Me.DGV_Pedidos.AllowUserToDeleteRows = False
        Me.DGV_Pedidos.AllowUserToOrderColumns = True
        Me.DGV_Pedidos.AllowUserToResizeRows = False
        Me.DGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Fecha, Me.Cliente, Me.Cantidad, Me.Empresa})
        Me.DGV_Pedidos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pedidos.Location = New System.Drawing.Point(10, 122)
        Me.DGV_Pedidos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Pedidos.MultiSelect = False
        Me.DGV_Pedidos.Name = "DGV_Pedidos"
        Me.DGV_Pedidos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Pedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Pedidos.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Pedidos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Pedidos.RowTemplate.Height = 19
        Me.DGV_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pedidos.Size = New System.Drawing.Size(416, 252)
        Me.DGV_Pedidos.TabIndex = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_producto)
        Me.GroupBox1.Controls.Add(Me.lbl_codigo)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 81)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'lbl_producto
        '
        Me.lbl_producto.Font = New System.Drawing.Font("Eras Light ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.Location = New System.Drawing.Point(5, 44)
        Me.lbl_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(412, 29)
        Me.lbl_producto.TabIndex = 42
        Me.lbl_producto.Text = "Descripción del artículo"
        Me.lbl_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_codigo
        '
        Me.lbl_codigo.Font = New System.Drawing.Font("Eras Light ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(5, 12)
        Me.lbl_codigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(411, 29)
        Me.lbl_codigo.TabIndex = 43
        Me.lbl_codigo.Text = "cod"
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(147, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cod"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Fecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 85
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Razón Social"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 195
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        Me.Empresa.Visible = False
        '
        'Frm_Productos_Por_Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(432, 382)
        Me.Controls.Add(Me.DGV_Pedidos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ti_productos)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Productos_Por_Facturar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de pedidos por facturar"
        CType(Me.DGV_Pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ti_productos As System.Windows.Forms.Label
    Friend WithEvents DGV_Pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_producto As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
