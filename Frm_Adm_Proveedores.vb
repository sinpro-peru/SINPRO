Public Class Frm_Adm_Proveedores
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
    Friend WithEvents DGV_proveedor As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Adm_Proveedores))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.DGV_proveedor = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(61, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 23)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Proveedores Eliminados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Restaurar"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.Location = New System.Drawing.Point(61, 17)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.ReadOnly = True
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 25)
        Me.DomainUpDown1.TabIndex = 79
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(253, 17)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(136, 25)
        Me.tb_buscarcodigo.TabIndex = 78
        '
        'DGV_proveedor
        '
        Me.DGV_proveedor.AllowUserToAddRows = False
        Me.DGV_proveedor.AllowUserToDeleteRows = False
        Me.DGV_proveedor.AllowUserToResizeColumns = False
        Me.DGV_proveedor.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_proveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.DGV_proveedor.Location = New System.Drawing.Point(61, 87)
        Me.DGV_proveedor.MultiSelect = False
        Me.DGV_proveedor.Name = "DGV_proveedor"
        Me.DGV_proveedor.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_proveedor.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_proveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_proveedor.ShowEditingIcon = False
        Me.DGV_proveedor.Size = New System.Drawing.Size(328, 216)
        Me.DGV_proveedor.TabIndex = 83
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
        Me.DataGridViewTextBoxColumn6.Width = 228
        '
        'Frm_Adm_Proveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(450, 361)
        Me.Controls.Add(Me.DGV_proveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(283, 227)
        Me.MaximizeBox = False
        Me.Name = "Frm_Adm_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Proveedores"
        CType(Me.DGV_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        DatosProveedor.consulta_proveedores_eliminados(DGV_proveedor)
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Nombre")
        Me.DomainUpDown1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim response As MsgBoxResult
        Dim cod As Integer

        If DGV_proveedor.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el proveedor que desea restaurar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        ElseIf DGV_proveedor.SelectedRows.Count = 1 Then
            response = MsgBox("¿Confirma que desea restaurar el proveedor '" + DGV_proveedor.Rows(DGV_proveedor.SelectedRows(0).Index).Cells(1).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            cod = CInt(DGV_proveedor.Rows(DGV_proveedor.SelectedRows(0).Index).Cells(0).Value)
            If (response = MsgBoxResult.Yes) Then
                DatosProveedor.restaura_proveedor(cod)
                MsgBox("El proveedor ha sido restaurado Exitosamente")
            End If

        Else
            'response = MsgBox("¿Confirma que desea restaurar estos (" + n.ToString + ") proveedores?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            'If (response = MsgBoxResult.Yes) Then
            '    Dim i As Integer = 0
            '    Dim x As ListViewItem
            '    For Each x In Me.ListView1.Items
            '        If Me.ListView1.Items(i).Selected() Then
            '            cod = CInt(Me.ListView1.Items(i).SubItems(0).Text())
            '            DatosProveedor.restaura_proveedor(cod)
            '        End If
            '        i = i + 1
            '    Next
            '    MsgBox("Se han restaurado (" + n.ToString + ") proveedores Exitosamente")
            'End If
        End If
        DGV_proveedor.Rows.Clear()

        DatosProveedor.consulta_proveedores_eliminados(DGV_proveedor)
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        If DGV_proveedor.Enabled = True Then
            Dim s1 As String
            s1 = Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then
                DatosProveedor.lv_ProveedorR(DGV_proveedor, s1, 0)

            ElseIf choice = 1 Then
                DatosProveedor.lv_ProveedorR(DGV_proveedor, s1, 1)

            End If
        End If


    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedItemChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DGV_proveedor.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.DGV_proveedor.Rows(0).Cells(0).Selected = True
                DGV_proveedor.Focus()

            End If
        End If


    End Sub
End Class
