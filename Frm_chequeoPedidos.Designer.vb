<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_chequeoPedidos
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_chequeoPedidos))
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.DGV_Ped = New System.Windows.Forms.DataGridView
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Raz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_pedido = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_cliente = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_bultos = New System.Windows.Forms.TextBox
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_bultos = New System.Windows.Forms.Button
        Me.lbl_dest = New System.Windows.Forms.Label
        Me.groupbox1.SuspendLayout()
        CType(Me.DGV_Ped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(430, 610)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(90, 27)
        Me.bt_cancelar.TabIndex = 107
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(140, 610)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(90, 27)
        Me.bt_aceptar.TabIndex = 106
        Me.bt_aceptar.Text = "Chequear"
        Me.bt_aceptar.Visible = False
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.DGV_Ped)
        Me.groupbox1.Controls.Add(Me.Label7)
        Me.groupbox1.Location = New System.Drawing.Point(8, 155)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(634, 443)
        Me.groupbox1.TabIndex = 109
        Me.groupbox1.TabStop = False
        '
        'DGV_Ped
        '
        Me.DGV_Ped.AllowUserToAddRows = False
        Me.DGV_Ped.AllowUserToDeleteRows = False
        Me.DGV_Ped.AllowUserToResizeColumns = False
        Me.DGV_Ped.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Ped.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ped.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.fac, Me.Factura, Me.CCliente, Me.Raz})
        Me.DGV_Ped.Location = New System.Drawing.Point(10, 37)
        Me.DGV_Ped.Name = "DGV_Ped"
        Me.DGV_Ped.ReadOnly = True
        Me.DGV_Ped.RowHeadersVisible = False
        Me.DGV_Ped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ped.Size = New System.Drawing.Size(613, 400)
        Me.DGV_Ped.TabIndex = 9
        '
        'Fecha
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Cant"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 45
        '
        'fac
        '
        Me.fac.HeaderText = "Cod. Producto"
        Me.fac.Name = "fac"
        Me.fac.ReadOnly = True
        Me.fac.Width = 120
        '
        'Factura
        '
        Me.Factura.HeaderText = "Cod. Fábrica"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Factura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Factura.Width = 110
        '
        'CCliente
        '
        Me.CCliente.HeaderText = "Descripción"
        Me.CCliente.Name = "CCliente"
        Me.CCliente.ReadOnly = True
        Me.CCliente.Width = 165
        '
        'Raz
        '
        Me.Raz.HeaderText = "Modelo"
        Me.Raz.Name = "Raz"
        Me.Raz.ReadOnly = True
        Me.Raz.Width = 150
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(634, 28)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Productos Pedido"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_pedido
        '
        Me.tb_pedido.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pedido.Location = New System.Drawing.Point(167, 7)
        Me.tb_pedido.MaxLength = 8
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.Size = New System.Drawing.Size(180, 26)
        Me.tb_pedido.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 19)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Código Pedido:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(408, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(236, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 111
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Cliente:"
        Me.Label1.Visible = False
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(165, 55)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(0, 19)
        Me.lbl_cliente.TabIndex = 113
        Me.lbl_cliente.Visible = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(416, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 20)
        Me.Label22.TabIndex = 114
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Observación:"
        '
        'tb_observacion
        '
        Me.tb_observacion.BackColor = System.Drawing.Color.White
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(167, 86)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.Size = New System.Drawing.Size(213, 54)
        Me.tb_observacion.TabIndex = 10046
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 10047
        Me.Label4.Text = "Bultos:"
        '
        'tb_bultos
        '
        Me.tb_bultos.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bultos.Location = New System.Drawing.Point(482, 102)
        Me.tb_bultos.MaxLength = 8
        Me.tb_bultos.Name = "tb_bultos"
        Me.tb_bultos.Size = New System.Drawing.Size(52, 26)
        Me.tb_bultos.TabIndex = 10048
        '
        'bt_modificar
        '
        Me.bt_modificar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificar.Location = New System.Drawing.Point(233, 610)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(101, 27)
        Me.bt_modificar.TabIndex = 10049
        Me.bt_modificar.Text = "Observacion"
        Me.bt_modificar.Visible = False
        '
        'bt_bultos
        '
        Me.bt_bultos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_bultos.Location = New System.Drawing.Point(337, 611)
        Me.bt_bultos.Name = "bt_bultos"
        Me.bt_bultos.Size = New System.Drawing.Size(90, 27)
        Me.bt_bultos.TabIndex = 10050
        Me.bt_bultos.Text = "Bultos"
        Me.bt_bultos.Visible = False
        '
        'lbl_dest
        '
        Me.lbl_dest.AutoSize = True
        Me.lbl_dest.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dest.Location = New System.Drawing.Point(14, 121)
        Me.lbl_dest.Name = "lbl_dest"
        Me.lbl_dest.Size = New System.Drawing.Size(45, 19)
        Me.lbl_dest.TabIndex = 10051
        Me.lbl_dest.Text = "Dest"
        Me.lbl_dest.Visible = False
        '
        'Frm_chequeoPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 649)
        Me.Controls.Add(Me.lbl_dest)
        Me.Controls.Add(Me.bt_bultos)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.tb_bultos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_observacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.tb_pedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_chequeoPedidos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chequeo de pedidos"
        Me.groupbox1.ResumeLayout(False)
        CType(Me.DGV_Ped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Ped As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_pedido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Raz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents tb_bultos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_bultos As System.Windows.Forms.Button
    Friend WithEvents lbl_dest As System.Windows.Forms.Label
End Class
