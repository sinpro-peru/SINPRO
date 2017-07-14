<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ExportarAExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ExportarAExcel))
        Me.Chk_Todos = New System.Windows.Forms.CheckBox
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.DGV_Pesos = New System.Windows.Forms.DataGridView
        Me.Chk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DGV_Pesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chk_Todos
        '
        Me.Chk_Todos.AutoSize = True
        Me.Chk_Todos.Location = New System.Drawing.Point(13, 11)
        Me.Chk_Todos.Margin = New System.Windows.Forms.Padding(2)
        Me.Chk_Todos.Name = "Chk_Todos"
        Me.Chk_Todos.Size = New System.Drawing.Size(62, 19)
        Me.Chk_Todos.TabIndex = 7
        Me.Chk_Todos.Text = "Todos"
        Me.Chk_Todos.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(148, 332)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(83, 25)
        Me.bt_cancelar.TabIndex = 6
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(46, 332)
        Me.bt_aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(83, 25)
        Me.bt_aceptar.TabIndex = 5
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'DGV_Pesos
        '
        Me.DGV_Pesos.AllowUserToAddRows = False
        Me.DGV_Pesos.AllowUserToDeleteRows = False
        Me.DGV_Pesos.AllowUserToResizeRows = False
        Me.DGV_Pesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chk, Me.Descripcion})
        Me.DGV_Pesos.Location = New System.Drawing.Point(10, 37)
        Me.DGV_Pesos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_Pesos.Name = "DGV_Pesos"
        Me.DGV_Pesos.RowHeadersVisible = False
        Me.DGV_Pesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pesos.Size = New System.Drawing.Size(242, 287)
        Me.DGV_Pesos.TabIndex = 4
        '
        'Chk
        '
        Me.Chk.HeaderText = ""
        Me.Chk.Name = "Chk"
        Me.Chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chk.Width = 20
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.Width = 200
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(90, 381)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(166, 23)
        Me.ProgressBar1.TabIndex = 8
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Exportando:"
        Me.Label1.Visible = False
        '
        'Frm_ExportarAExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(262, 364)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Chk_Todos)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.DGV_Pesos)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ExportarAExcel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar a excel"
        CType(Me.DGV_Pesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents DGV_Pesos As System.Windows.Forms.DataGridView
    Friend WithEvents Chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
