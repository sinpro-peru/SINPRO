<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListadoClientes
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
        Me.components = New System.ComponentModel.Container
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txt_finalVend = New System.Windows.Forms.TextBox
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.rb_vendedor = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Tbl_VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Tbl_VendedorTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_finalVend)
        Me.Panel2.Controls.Add(Me.rb_todos)
        Me.Panel2.Controls.Add(Me.rb_vendedor)
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(7, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 72)
        Me.Panel2.TabIndex = 17
        '
        'txt_finalVend
        '
        Me.txt_finalVend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_finalVend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_finalVend.Enabled = False
        Me.txt_finalVend.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_finalVend.ForeColor = System.Drawing.Color.Black
        Me.txt_finalVend.Location = New System.Drawing.Point(112, 38)
        Me.txt_finalVend.Name = "txt_finalVend"
        Me.txt_finalVend.Size = New System.Drawing.Size(208, 21)
        Me.txt_finalVend.TabIndex = 122
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Location = New System.Drawing.Point(6, 12)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(57, 18)
        Me.rb_todos.TabIndex = 2
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'rb_vendedor
        '
        Me.rb_vendedor.AutoSize = True
        Me.rb_vendedor.Location = New System.Drawing.Point(6, 38)
        Me.rb_vendedor.Name = "rb_vendedor"
        Me.rb_vendedor.Size = New System.Drawing.Size(99, 18)
        Me.rb_vendedor.TabIndex = 12
        Me.rb_vendedor.Text = "Por vendedor:"
        Me.rb_vendedor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(120, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.Tbl_VendedorBindingSource
        Me.ListBox2.DisplayMember = "Nombre"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(120, 70)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(208, 60)
        Me.ListBox2.TabIndex = 123
        Me.ListBox2.ValueMember = "CodigoVendedor"
        Me.ListBox2.Visible = False
        '
        'Tbl_VendedorBindingSource
        '
        Me.Tbl_VendedorBindingSource.DataMember = "Tbl_Vendedor"
        Me.Tbl_VendedorBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_VendedorTableAdapter
        '
        Me.Tbl_VendedorTableAdapter.ClearBeforeFill = True
        '
        'Frm_ListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 136)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_ListadoClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vendedor As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_finalVend As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Tbl_VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_VendedorTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_VendedorTableAdapter
End Class
