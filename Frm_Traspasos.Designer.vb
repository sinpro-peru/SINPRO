<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Traspasos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Traspasos))
        Me.gb_Direccion = New System.Windows.Forms.GroupBox
        Me.cb_cuarto = New System.Windows.Forms.ComboBox
        Me.cb_tramo = New System.Windows.Forms.ComboBox
        Me.cb_almacen = New System.Windows.Forms.ComboBox
        Me.TableAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.cb_estante = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cb_cuarto2 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cb_tramo2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cb_almacen2 = New System.Windows.Forms.ComboBox
        Me.TableAlmacenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb_estante2 = New System.Windows.Forms.ComboBox
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.Table_AlmacenTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
        Me.gb_Direccion.SuspendLayout()
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TableAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gb_Direccion.Location = New System.Drawing.Point(26, 37)
        Me.gb_Direccion.Name = "gb_Direccion"
        Me.gb_Direccion.Size = New System.Drawing.Size(229, 187)
        Me.gb_Direccion.TabIndex = 99
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
        Me.cb_almacen.DataSource = Me.TableAlmacenBindingSource
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
        'TableAlmacenBindingSource
        '
        Me.TableAlmacenBindingSource.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(26, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 23)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(308, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_cuarto2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cb_tramo2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_almacen2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb_estante2)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 187)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "(*)Tramo:"
        '
        'cb_cuarto2
        '
        Me.cb_cuarto2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_cuarto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuarto2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cuarto2.FormattingEnabled = True
        Me.cb_cuarto2.Location = New System.Drawing.Point(92, 67)
        Me.cb_cuarto2.Name = "cb_cuarto2"
        Me.cb_cuarto2.Size = New System.Drawing.Size(121, 22)
        Me.cb_cuarto2.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "(*)Estante:"
        '
        'cb_tramo2
        '
        Me.cb_tramo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tramo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tramo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tramo2.FormattingEnabled = True
        Me.cb_tramo2.Location = New System.Drawing.Point(92, 141)
        Me.cb_tramo2.Name = "cb_tramo2"
        Me.cb_tramo2.Size = New System.Drawing.Size(121, 22)
        Me.cb_tramo2.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "(*)Cuarto:"
        '
        'cb_almacen2
        '
        Me.cb_almacen2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_almacen2.DataSource = Me.TableAlmacenBindingSource1
        Me.cb_almacen2.DisplayMember = "Nombre"
        Me.cb_almacen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_almacen2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_almacen2.FormattingEnabled = True
        Me.cb_almacen2.Location = New System.Drawing.Point(92, 30)
        Me.cb_almacen2.Name = "cb_almacen2"
        Me.cb_almacen2.Size = New System.Drawing.Size(121, 22)
        Me.cb_almacen2.TabIndex = 94
        Me.cb_almacen2.ValueMember = "Id"
        '
        'TableAlmacenBindingSource1
        '
        Me.TableAlmacenBindingSource1.DataMember = "Table_Almacen"
        Me.TableAlmacenBindingSource1.DataSource = Me.MELDataSet
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "(*)Almacén:"
        '
        'cb_estante2
        '
        Me.cb_estante2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_estante2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estante2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_estante2.FormattingEnabled = True
        Me.cb_estante2.Location = New System.Drawing.Point(92, 104)
        Me.cb_estante2.Name = "cb_estante2"
        Me.cb_estante2.Size = New System.Drawing.Size(121, 22)
        Me.cb_estante2.TabIndex = 96
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(201, 267)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 10043
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(295, 267)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 10044
        Me.bt_cancelar.Text = "Cancelar"
        '
        'Table_AlmacenTableAdapter
        '
        Me.Table_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'Frm_Traspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 302)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_Direccion)
        Me.Font = New System.Drawing.Font("Papyrus", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Traspasos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspasos"
        Me.gb_Direccion.ResumeLayout(False)
        CType(Me.TableAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TableAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Direccion As System.Windows.Forms.GroupBox
    Friend WithEvents cb_cuarto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estante As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_cuarto2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tramo2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_almacen2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_estante2 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents TableAlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_AlmacenTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Table_AlmacenTableAdapter
    Friend WithEvents TableAlmacenBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
