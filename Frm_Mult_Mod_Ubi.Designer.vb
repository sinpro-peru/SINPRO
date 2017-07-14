<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mult_Mod_Ubi
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mult_Mod_Ubi))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Dgv_Ubicacion = New System.Windows.Forms.DataGridView
        Me.Ubicación = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tramo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lb_modelos = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.Dgv_Ubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Dgv_Ubicacion
        '
        Me.Dgv_Ubicacion.AllowUserToAddRows = False
        Me.Dgv_Ubicacion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Ubicacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Ubicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Ubicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ubicación, Me.Existencia, Me.Pedido, Me.Tramo})
        Me.Dgv_Ubicacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Dgv_Ubicacion.Location = New System.Drawing.Point(11, 19)
        Me.Dgv_Ubicacion.MultiSelect = False
        Me.Dgv_Ubicacion.Name = "Dgv_Ubicacion"
        Me.Dgv_Ubicacion.RowHeadersVisible = False
        Me.Dgv_Ubicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Ubicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Ubicacion.Size = New System.Drawing.Size(187, 109)
        Me.Dgv_Ubicacion.TabIndex = 2
        '
        'Ubicación
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Ubicación.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ubicación.HeaderText = "Ubicación"
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        Me.Ubicación.Width = 70
        '
        'Existencia
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Existencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.Existencia.HeaderText = "Exist."
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 50
        '
        'Pedido
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Pedido.DefaultCellStyle = DataGridViewCellStyle4
        Me.Pedido.HeaderText = "Cant."
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Width = 46
        '
        'Tramo
        '
        Me.Tramo.HeaderText = "Tramo"
        Me.Tramo.Name = "Tramo"
        Me.Tramo.Visible = False
        '
        'lb_modelos
        '
        Me.lb_modelos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_modelos.FormattingEnabled = True
        Me.lb_modelos.ItemHeight = 15
        Me.lb_modelos.Location = New System.Drawing.Point(6, 21)
        Me.lb_modelos.Name = "lb_modelos"
        Me.lb_modelos.Size = New System.Drawing.Size(163, 109)
        Me.lb_modelos.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_modelos)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 139)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_Ubicacion)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 139)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicaciones:"
        '
        'Frm_Mult_Mod_Ubi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 198)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Mult_Mod_Ubi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelo y Ubicación"
        CType(Me.Dgv_Ubicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Dgv_Ubicacion As System.Windows.Forms.DataGridView
    Friend WithEvents lb_modelos As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tramo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
