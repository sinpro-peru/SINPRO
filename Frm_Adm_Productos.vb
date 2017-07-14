Public Class Frm_Adm_Productos
    Inherits System.Windows.Forms.Form
    Private choice As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGV_productos As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Adm_Productos))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.DGV_productos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(444, 23)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Productos Eliminados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Restaurar"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Light ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 19)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.ReadOnly = True
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 25)
        Me.DomainUpDown1.TabIndex = 79
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Light ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(184, 19)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(173, 25)
        Me.tb_buscarcodigo.TabIndex = 78
        '
        'DGV_productos
        '
        Me.DGV_productos.AllowUserToAddRows = False
        Me.DGV_productos.AllowUserToDeleteRows = False
        Me.DGV_productos.AllowUserToResizeColumns = False
        Me.DGV_productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.Modelo})
        Me.DGV_productos.Location = New System.Drawing.Point(6, 86)
        Me.DGV_productos.MultiSelect = False
        Me.DGV_productos.Name = "DGV_productos"
        Me.DGV_productos.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_productos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_productos.ShowEditingIcon = False
        Me.DGV_productos.Size = New System.Drawing.Size(442, 219)
        Me.DGV_productos.TabIndex = 84
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 205
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Width = 135
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox1.Controls.Add(Me.tb_buscarcodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 54)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(417, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 14)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(359, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Total Art.:"
        '
        'Frm_Adm_Productos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 364)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_productos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(283, 227)
        Me.MaximizeBox = False
        Me.Name = "Frm_Adm_Productos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Productos"
        CType(Me.DGV_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        DatosProducto.consulta_productos_eliminados(DGV_productos)
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim response As MsgBoxResult
        Dim cod As String


        If DGV_productos.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el Producto que desea restaurar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        ElseIf DGV_productos.SelectedRows.Count = 1 Then
            response = MsgBox("¿Confirma que desea restaurar el Producto '" + DGV_productos.Rows(DGV_productos.SelectedRows(0).Index).Cells(1).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            cod = DGV_productos.Rows(DGV_productos.SelectedRows(0).Index).Cells(0).Value
            If (response = MsgBoxResult.Yes) Then
                DatosProducto.restaura_producto(cod)
                MsgBox("El Producto ha sido restaurado Exitosamente")
            End If

        Else
            'response = MsgBox("¿Confirma que desea restaurar estos (" + n.ToString + ") productos?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            'If (response = MsgBoxResult.Yes) Then
            '    Dim i As Integer = 0
            '    Dim x As ListViewItem
            '    For Each x In Me.ListView1.Items
            '        If Me.ListView1.Items(i).Selected() Then
            '            cod = CInt(Me.ListView1.Items(i).SubItems(0).Text())
            '            DatosProducto.restaura_producto(cod)
            '        End If
            '        i = i + 1
            '    Next
            '    MsgBox("Se han restaurado (" + n.ToString + ") Productos Exitosamente")
            'End If
        End If
        DGV_productos.Rows.Clear()
        DatosProducto.consulta_productos_eliminados(DGV_productos)
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Me.DGV_productos.Enabled = True Then
            Dim s1 As String
            s1 = Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then
                DatosProducto.lv_ProductoR(Me.DGV_productos, s1, 0)
                'Label2.Text = Me.ListView1.Items.Count
            ElseIf choice = 1 Then
                DatosProducto.lv_ProductoR(Me.DGV_productos, s1, 1)
                'Label2.Text = Me.ListView1.Items.Count
            End If
        End If


    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedItemChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DGV_productos.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.DGV_productos.Rows(0).Cells(0).Selected = True
                DGV_productos.Focus()

            End If

        End If

    End Sub

    Private Sub DGV_productos_RowsAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_productos.RowsAdded, DGV_productos.RowsRemoved

        Label11.Text = DGV_productos.RowCount.ToString

    End Sub
End Class
