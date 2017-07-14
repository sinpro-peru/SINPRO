<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CalculoPagoImpuestos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_Productos = New System.Windows.Forms.DataGridView
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_TotalFact = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_TotalPed = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_fleteySeg = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_TotalTSS = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_TotalIva = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_TotalTSA = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_TotalADV = New System.Windows.Forms.Label
        Me.bt_salir = New System.Windows.Forms.Button
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BaseImp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.AllowUserToOrderColumns = True
        Me.DGV_Productos.AllowUserToResizeColumns = False
        Me.DGV_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.BaseImp, Me.Tarifa, Me.Importe})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Productos.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Productos.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Productos.Location = New System.Drawing.Point(35, 131)
        Me.DGV_Productos.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_Productos.MultiSelect = False
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Productos.RowHeadersVisible = False
        Me.DGV_Productos.RowTemplate.Height = 19
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(420, 342)
        Me.DGV_Productos.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 19)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Total Fact.:"
        '
        'lbl_TotalFact
        '
        Me.lbl_TotalFact.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalFact.Location = New System.Drawing.Point(121, 16)
        Me.lbl_TotalFact.Name = "lbl_TotalFact"
        Me.lbl_TotalFact.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalFact.TabIndex = 82
        Me.lbl_TotalFact.Text = "0.00"
        Me.lbl_TotalFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_TotalPed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_fleteySeg)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_TotalFact)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 110)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "_______"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Total:"
        '
        'lbl_TotalPed
        '
        Me.lbl_TotalPed.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalPed.Location = New System.Drawing.Point(121, 75)
        Me.lbl_TotalPed.Name = "lbl_TotalPed"
        Me.lbl_TotalPed.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalPed.TabIndex = 86
        Me.lbl_TotalPed.Text = "0.00"
        Me.lbl_TotalPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Flete y Seg.:"
        '
        'lbl_fleteySeg
        '
        Me.lbl_fleteySeg.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fleteySeg.Location = New System.Drawing.Point(121, 35)
        Me.lbl_fleteySeg.Name = "lbl_fleteySeg"
        Me.lbl_fleteySeg.Size = New System.Drawing.Size(100, 23)
        Me.lbl_fleteySeg.TabIndex = 84
        Me.lbl_fleteySeg.Text = "0.00"
        Me.lbl_fleteySeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_TotalTSS)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl_TotalIva)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_TotalTSA)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbl_TotalADV)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(249, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 110)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "TSS:"
        '
        'lbl_TotalTSS
        '
        Me.lbl_TotalTSS.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalTSS.Location = New System.Drawing.Point(121, 55)
        Me.lbl_TotalTSS.Name = "lbl_TotalTSS"
        Me.lbl_TotalTSS.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalTSS.TabIndex = 88
        Me.lbl_TotalTSS.Text = "0.00"
        Me.lbl_TotalTSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "IVA:"
        '
        'lbl_TotalIva
        '
        Me.lbl_TotalIva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalIva.Location = New System.Drawing.Point(121, 75)
        Me.lbl_TotalIva.Name = "lbl_TotalIva"
        Me.lbl_TotalIva.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalIva.TabIndex = 86
        Me.lbl_TotalIva.Text = "0.00"
        Me.lbl_TotalIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 19)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "TSA:"
        '
        'lbl_TotalTSA
        '
        Me.lbl_TotalTSA.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalTSA.Location = New System.Drawing.Point(121, 35)
        Me.lbl_TotalTSA.Name = "lbl_TotalTSA"
        Me.lbl_TotalTSA.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalTSA.TabIndex = 84
        Me.lbl_TotalTSA.Text = "0.00"
        Me.lbl_TotalTSA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 19)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "ADV:"
        '
        'lbl_TotalADV
        '
        Me.lbl_TotalADV.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalADV.Location = New System.Drawing.Point(121, 16)
        Me.lbl_TotalADV.Name = "lbl_TotalADV"
        Me.lbl_TotalADV.Size = New System.Drawing.Size(100, 23)
        Me.lbl_TotalADV.TabIndex = 82
        Me.lbl_TotalADV.Text = "0.00"
        Me.lbl_TotalADV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_salir
        '
        Me.bt_salir.BackColor = System.Drawing.Color.White
        Me.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_salir.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_salir.Location = New System.Drawing.Point(214, 485)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(75, 23)
        Me.bt_salir.TabIndex = 89
        Me.bt_salir.Text = "Salir"
        Me.bt_salir.UseVisualStyleBackColor = False
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 110
        '
        'BaseImp
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.BaseImp.DefaultCellStyle = DataGridViewCellStyle2
        Me.BaseImp.HeaderText = "Base Imp."
        Me.BaseImp.Name = "BaseImp"
        Me.BaseImp.ReadOnly = True
        Me.BaseImp.Width = 120
        '
        'Tarifa
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Tarifa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tarifa.HeaderText = "%"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        Me.Tarifa.Width = 55
        '
        'Importe
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle4
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 110
        '
        'Frm_CalculoPagoImpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 520)
        Me.Controls.Add(Me.bt_salir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_CalculoPagoImpuestos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de impuestos"
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalFact As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalPed As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fleteySeg As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalIva As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalTSA As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalADV As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalTSS As System.Windows.Forms.Label
    Friend WithEvents bt_salir As System.Windows.Forms.Button
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaseImp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
