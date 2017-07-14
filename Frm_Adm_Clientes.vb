Public Class Frm_Adm_Clientes
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
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DGV_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Adm_Clientes))
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGV_clientes = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.Location = New System.Drawing.Point(58, 16)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.ReadOnly = True
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 25)
        Me.DomainUpDown1.TabIndex = 73
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(250, 16)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(136, 25)
        Me.tb_buscarcodigo.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Restaurar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(58, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Clientes Eliminados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_clientes
        '
        Me.DGV_clientes.AllowUserToAddRows = False
        Me.DGV_clientes.AllowUserToDeleteRows = False
        Me.DGV_clientes.AllowUserToResizeColumns = False
        Me.DGV_clientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.DGV_clientes.Location = New System.Drawing.Point(58, 85)
        Me.DGV_clientes.MultiSelect = False
        Me.DGV_clientes.Name = "DGV_clientes"
        Me.DGV_clientes.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_clientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_clientes.ShowEditingIcon = False
        Me.DGV_clientes.Size = New System.Drawing.Size(328, 216)
        Me.DGV_clientes.TabIndex = 77
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
        Me.DataGridViewTextBoxColumn6.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 228
        '
        'Frm_Adm_Clientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(450, 361)
        Me.Controls.Add(Me.DGV_clientes)
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
        Me.Name = "Frm_Adm_Clientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Clientes"
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Datos.consulta_clientes_eliminados(Me.DGV_clientes)
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Razón Social")
        Me.DomainUpDown1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim response As MsgBoxResult
        Dim cod As Integer


        If DGV_clientes.SelectedRows.Count = 0 Then

            MsgBox("Debe seleccionar el cliente que desea restaurar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        ElseIf DGV_clientes.SelectedRows.Count = 1 Then
            response = MsgBox("¿Confirma que desea restaurar el cliente '" + DGV_clientes.Rows(DGV_clientes.SelectedRows(0).Index).Cells(1).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            cod = CInt(DGV_clientes.Rows(DGV_clientes.SelectedRows(0).Index).Cells(0).Value)
            If (response = MsgBoxResult.Yes) Then
                Datos.restaura_cliente(cod)
                MsgBox("El cliente ha sido restaurado Exitosamente")
            End If

        Else
            'response = MsgBox("¿Confirma que desea restaurar estos (" + DGV_clientes.SelectedRows.Count.ToString + ") clientes?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            'If (response = MsgBoxResult.Yes) Then
            '    Dim i As Integer = 0
            '    Dim x As ListViewItem
            '    For Each x In Me.ListView1.Items
            '        If Me.ListView1.Items(i).Selected() Then
            '            cod = CInt(Me.ListView1.Items(i).SubItems(0).Text())
            '            Datos.restaura_cliente(cod)
            '        End If
            '        i = i + 1
            '    Next
            '    MsgBox("Se han restaurado (" + n.ToString + ") clientes Exitosamente")
            'End If
        End If
        DGV_clientes.Rows.Clear()
        Datos.consulta_clientes_eliminados(Me.DGV_clientes)
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()




    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        If Me.DGV_clientes.Enabled = True Then
            Dim s1 As String
            s1 = "%" + Me.tb_buscarcodigo.Text + "%"
            If choice = 0 Then
                Datos.lv_ClienteR(DGV_clientes, s1, 0)

            ElseIf choice = 1 Then
                Datos.lv_ClienteR(DGV_clientes, s1, 1)

            End If
        End If


    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedItemChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DGV_clientes.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.DGV_clientes.Rows(0).Cells(0).Selected = True
                DGV_clientes.Focus()

            End If
        End If


    End Sub
End Class
