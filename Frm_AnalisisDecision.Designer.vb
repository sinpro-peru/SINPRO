<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AnalisisDecision
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AnalisisDecision))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Apoyo = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Laplace = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Emin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_evaluar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.DGV_Apoyo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(41, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 14)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Alternativas a considerar:"
        '
        'DGV_Apoyo
        '
        Me.DGV_Apoyo.AllowUserToAddRows = False
        Me.DGV_Apoyo.AllowUserToDeleteRows = False
        Me.DGV_Apoyo.AllowUserToResizeColumns = False
        Me.DGV_Apoyo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Apoyo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Apoyo.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Apoyo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Apoyo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Apoyo.ColumnHeadersHeight = 35
        Me.DGV_Apoyo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Apoyo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column13, Me.Column15, Me.Column17, Me.Column14, Me.Column16, Me.Min, Me.Max, Me.Total, Me.Laplace, Me.Ai, Me.EMax, Me.Emin})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Apoyo.DefaultCellStyle = DataGridViewCellStyle16
        Me.DGV_Apoyo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Apoyo.Location = New System.Drawing.Point(12, 138)
        Me.DGV_Apoyo.Name = "DGV_Apoyo"
        Me.DGV_Apoyo.RowHeadersVisible = False
        Me.DGV_Apoyo.RowTemplate.Height = 35
        Me.DGV_Apoyo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Apoyo.Size = New System.Drawing.Size(986, 293)
        Me.DGV_Apoyo.TabIndex = 3
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Alternativas / Escenario"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 180
        '
        'Column13
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "#,##0.00"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column13.HeaderText = "Optimista"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 80
        '
        'Column15
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "#,##0.00"
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column15.HeaderText = "Bueno"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 80
        '
        'Column17
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "#,##0.00"
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column17.HeaderText = "Base"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 80
        '
        'Column14
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "#,##0.00"
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column14.HeaderText = "Malo"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 80
        '
        'Column16
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "#,##0.00"
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column16.HeaderText = "Pesimista"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 80
        '
        'Min
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "#,##0.00"
        Me.Min.DefaultCellStyle = DataGridViewCellStyle9
        Me.Min.HeaderText = "Min"
        Me.Min.Name = "Min"
        Me.Min.ReadOnly = True
        Me.Min.Width = 80
        '
        'Max
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "#,##0.00"
        Me.Max.DefaultCellStyle = DataGridViewCellStyle10
        Me.Max.HeaderText = "Max"
        Me.Max.Name = "Max"
        Me.Max.ReadOnly = True
        Me.Max.Width = 80
        '
        'Total
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "#,##0.00"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle11
        Me.Total.HeaderText = "Hurwicz"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'Laplace
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.Format = "##,#0.00"
        Me.Laplace.DefaultCellStyle = DataGridViewCellStyle12
        Me.Laplace.HeaderText = "Laplace"
        Me.Laplace.Name = "Laplace"
        Me.Laplace.ReadOnly = True
        Me.Laplace.Width = 80
        '
        'Ai
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Format = "#,##0.00"
        Me.Ai.DefaultCellStyle = DataGridViewCellStyle13
        Me.Ai.HeaderText = "Amplitud"
        Me.Ai.Name = "Ai"
        Me.Ai.ReadOnly = True
        Me.Ai.Width = 80
        '
        'EMax
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.Format = "#,##0.00"
        Me.EMax.DefaultCellStyle = DataGridViewCellStyle14
        Me.EMax.HeaderText = "EMA (Max)"
        Me.EMax.Name = "EMax"
        Me.EMax.ReadOnly = True
        Me.EMax.Width = 80
        '
        'Emin
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.Format = "#,##0.00"
        Me.Emin.DefaultCellStyle = DataGridViewCellStyle15
        Me.Emin.HeaderText = "EMA (Min)"
        Me.Emin.Name = "Emin"
        Me.Emin.ReadOnly = True
        Me.Emin.Width = 80
        '
        'bt_evaluar
        '
        Me.bt_evaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_evaluar.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_evaluar.Location = New System.Drawing.Point(476, 441)
        Me.bt_evaluar.Name = "bt_evaluar"
        Me.bt_evaluar.Size = New System.Drawing.Size(63, 23)
        Me.bt_evaluar.TabIndex = 4
        Me.bt_evaluar.Text = "Evaluar"
        Me.bt_evaluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(986, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(802, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(178, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 167
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(135, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(556, 14)
        Me.Label6.TabIndex = 166
        Me.Label6.Text = "(Valor entre 0 y 1 que indica cuán optimista es el modelo, se define para los mét" & _
            "odos de Hurwicz y EMA)"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(41, 21)
        Me.TextBox2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Parámetro α:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(752, 23)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(752, 23)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(125, 466)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 230)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        Me.GroupBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(752, 23)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(752, 23)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Label12"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(752, 14)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Nota: Recordar que los criterios de Wald y Savage son métodos conservadores mient" & _
            "ras que el método MaxiMax es un método muy optmista."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(752, 23)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(752, 23)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(752, 23)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_AnalisisDecision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 704)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_evaluar)
        Me.Controls.Add(Me.DGV_Apoyo)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_AnalisisDecision"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de decisiones"
        CType(Me.DGV_Apoyo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_Apoyo As System.Windows.Forms.DataGridView
    Friend WithEvents bt_evaluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Laplace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
