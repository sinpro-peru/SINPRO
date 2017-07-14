<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DesglosarMov
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbl_banco = New System.Windows.Forms.Label
        Me.lbl_mov = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_monto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_cantDesglose = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGV_Desglose = New System.Windows.Forms.DataGridView
        Me.Movi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Desglose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_banco
        '
        Me.lbl_banco.AutoSize = True
        Me.lbl_banco.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banco.Location = New System.Drawing.Point(66, 43)
        Me.lbl_banco.Name = "lbl_banco"
        Me.lbl_banco.Size = New System.Drawing.Size(43, 15)
        Me.lbl_banco.TabIndex = 117
        Me.lbl_banco.Text = "Banco"
        '
        'lbl_mov
        '
        Me.lbl_mov.AutoSize = True
        Me.lbl_mov.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mov.Location = New System.Drawing.Point(130, 20)
        Me.lbl_mov.Name = "lbl_mov"
        Me.lbl_mov.Size = New System.Drawing.Size(112, 15)
        Me.lbl_mov.TabIndex = 116
        Me.lbl_mov.Text = "###############"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Banco:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 23)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Nro. Movimiento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monto.Location = New System.Drawing.Point(66, 66)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(62, 15)
        Me.lbl_monto.TabIndex = 119
        Me.lbl_monto.Text = "##.###,##"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Monto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_cantDesglose
        '
        Me.tb_cantDesglose.Location = New System.Drawing.Point(149, 19)
        Me.tb_cantDesglose.MaxLength = 2
        Me.tb_cantDesglose.Name = "tb_cantDesglose"
        Me.tb_cantDesglose.Size = New System.Drawing.Size(39, 20)
        Me.tb_cantDesglose.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 23)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Cantidad a desglosar:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_mov)
        Me.GroupBox1.Controls.Add(Me.lbl_monto)
        Me.GroupBox1.Controls.Add(Me.lbl_banco)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 89)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Movimiento bancario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_cantDesglose)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 52)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parámetros de desglose"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_total)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DGV_Desglose)
        Me.GroupBox3.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 189)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movimientos desglosados"
        '
        'DGV_Desglose
        '
        Me.DGV_Desglose.AllowUserToAddRows = False
        Me.DGV_Desglose.AllowUserToDeleteRows = False
        Me.DGV_Desglose.AllowUserToResizeRows = False
        Me.DGV_Desglose.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Desglose.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV_Desglose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Desglose.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Movi, Me.Monto1})
        Me.DGV_Desglose.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Desglose.Location = New System.Drawing.Point(8, 20)
        Me.DGV_Desglose.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Desglose.Name = "DGV_Desglose"
        Me.DGV_Desglose.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DGV_Desglose.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Desglose.RowTemplate.Height = 19
        Me.DGV_Desglose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Desglose.Size = New System.Drawing.Size(244, 143)
        Me.DGV_Desglose.TabIndex = 86
        '
        'Movi
        '
        Me.Movi.HeaderText = "Movimiento"
        Me.Movi.Name = "Movi"
        '
        'Monto1
        '
        Me.Monto1.HeaderText = "Monto"
        Me.Monto1.Name = "Monto1"
        Me.Monto1.Width = 120
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(149, 160)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(91, 29)
        Me.bt_cancelar.TabIndex = 126
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(34, 160)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(91, 29)
        Me.bt_aceptar.TabIndex = 125
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(190, 168)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 15)
        Me.lbl_total.TabIndex = 121
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_DesglosarMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(273, 202)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_DesglosarMov"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglosar Movimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Desglose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_banco As System.Windows.Forms.Label
    Friend WithEvents lbl_mov As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_monto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_cantDesglose As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Desglose As System.Windows.Forms.DataGridView
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Movi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
