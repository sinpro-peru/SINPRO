Public Class Frm_Adm_Usuarios
    Inherits System.Windows.Forms.Form
    Dim b As String
    Dim w As Boolean
    Dim e As Boolean
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
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_razon As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents tb_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents tb_ci As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rb_activos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_eliminados As System.Windows.Forms.RadioButton
    Friend WithEvents DGV_Usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents bt_restaurar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Adm_Usuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tb_usuario = New System.Windows.Forms.ComboBox
        Me.tb_razon = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_email = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lb_nombre = New System.Windows.Forms.Label
        Me.tb_ci = New System.Windows.Forms.TextBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tb_telefono = New System.Windows.Forms.TextBox
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_restaurar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.rb_activos = New System.Windows.Forms.RadioButton
        Me.rb_eliminados = New System.Windows.Forms.RadioButton
        Me.DGV_Usuarios = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.groupbox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(311, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Datos del Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupbox1.Controls.Add(Me.GroupBox2)
        Me.groupbox1.Controls.Add(Me.bt_aceptar)
        Me.groupbox1.Controls.Add(Me.bt_restaurar)
        Me.groupbox1.Controls.Add(Me.Label2)
        Me.groupbox1.Controls.Add(Me.bt_cancelar)
        Me.groupbox1.Location = New System.Drawing.Point(312, 25)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(309, 398)
        Me.groupbox1.TabIndex = 10
        Me.groupbox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_usuario)
        Me.GroupBox2.Controls.Add(Me.tb_razon)
        Me.GroupBox2.Controls.Add(Me.tb_codigo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_email)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lb_nombre)
        Me.GroupBox2.Controls.Add(Me.tb_ci)
        Me.GroupBox2.Controls.Add(Me.tb_nombre)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb_telefono)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 232)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        '
        'tb_usuario
        '
        Me.tb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usuario.ForeColor = System.Drawing.Color.Black
        Me.tb_usuario.FormattingEnabled = True
        Me.tb_usuario.Location = New System.Drawing.Point(137, 188)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(142, 23)
        Me.tb_usuario.TabIndex = 7
        '
        'tb_razon
        '
        Me.tb_razon.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_razon.ForeColor = System.Drawing.Color.Black
        Me.tb_razon.Location = New System.Drawing.Point(137, 47)
        Me.tb_razon.Name = "tb_razon"
        Me.tb_razon.Size = New System.Drawing.Size(142, 22)
        Me.tb_razon.TabIndex = 2
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.ForeColor = System.Drawing.Color.Black
        Me.tb_codigo.Location = New System.Drawing.Point(137, 19)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(142, 22)
        Me.tb_codigo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "(*)Password:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "(*)Login:"
        '
        'tb_email
        '
        Me.tb_email.Enabled = False
        Me.tb_email.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.ForeColor = System.Drawing.Color.Black
        Me.tb_email.Location = New System.Drawing.Point(137, 159)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(142, 22)
        Me.tb_email.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "(*)Tipo Usuario:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "E-mail:"
        '
        'lb_nombre
        '
        Me.lb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre.Location = New System.Drawing.Point(8, 78)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(121, 20)
        Me.lb_nombre.TabIndex = 42
        Me.lb_nombre.Text = "Nombre y Apellido:"
        '
        'tb_ci
        '
        Me.tb_ci.Enabled = False
        Me.tb_ci.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ci.ForeColor = System.Drawing.Color.Black
        Me.tb_ci.Location = New System.Drawing.Point(137, 103)
        Me.tb_ci.Name = "tb_ci"
        Me.tb_ci.Size = New System.Drawing.Size(142, 22)
        Me.tb_ci.TabIndex = 4
        '
        'tb_nombre
        '
        Me.tb_nombre.Enabled = False
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.ForeColor = System.Drawing.Color.Black
        Me.tb_nombre.Location = New System.Drawing.Point(137, 75)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(142, 22)
        Me.tb_nombre.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "C.I:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Telefono"
        '
        'tb_telefono
        '
        Me.tb_telefono.Enabled = False
        Me.tb_telefono.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono.ForeColor = System.Drawing.Color.Black
        Me.tb_telefono.Location = New System.Drawing.Point(137, 131)
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.Size = New System.Drawing.Size(142, 22)
        Me.tb_telefono.TabIndex = 5
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(65, 302)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 8
        Me.bt_aceptar.Text = "Aceptar"
        '
        'bt_restaurar
        '
        Me.bt_restaurar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_restaurar.Location = New System.Drawing.Point(65, 302)
        Me.bt_restaurar.Name = "bt_restaurar"
        Me.bt_restaurar.Size = New System.Drawing.Size(75, 23)
        Me.bt_restaurar.TabIndex = 100
        Me.bt_restaurar.Text = "Restaurar"
        Me.bt_restaurar.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "(*)Datos requeridos"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(173, 302)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 6
        Me.bt_cancelar.Text = "Cancelar"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(3, 4)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(293, 58)
        Me.ToolBar1.TabIndex = 58
        '
        'bt_nuevo
        '
        Me.bt_nuevo.ImageIndex = 0
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Text = "Nuevo"
        '
        'bt_modificar
        '
        Me.bt_modificar.ImageIndex = 1
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Text = "Modificar"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.ImageIndex = 2
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Text = "Eliminar"
        '
        'bt_salir
        '
        Me.bt_salir.ImageIndex = 3
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Text = "Salir"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        '
        'rb_activos
        '
        Me.rb_activos.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_activos.Location = New System.Drawing.Point(12, 77)
        Me.rb_activos.Name = "rb_activos"
        Me.rb_activos.Size = New System.Drawing.Size(120, 24)
        Me.rb_activos.TabIndex = 59
        Me.rb_activos.Text = "Activos"
        '
        'rb_eliminados
        '
        Me.rb_eliminados.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_eliminados.Location = New System.Drawing.Point(99, 77)
        Me.rb_eliminados.Name = "rb_eliminados"
        Me.rb_eliminados.Size = New System.Drawing.Size(104, 24)
        Me.rb_eliminados.TabIndex = 60
        Me.rb_eliminados.Text = "Eliminados"
        '
        'DGV_Usuarios
        '
        Me.DGV_Usuarios.AllowUserToAddRows = False
        Me.DGV_Usuarios.AllowUserToDeleteRows = False
        Me.DGV_Usuarios.AllowUserToResizeColumns = False
        Me.DGV_Usuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Usuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.DGV_Usuarios.Location = New System.Drawing.Point(12, 116)
        Me.DGV_Usuarios.MultiSelect = False
        Me.DGV_Usuarios.Name = "DGV_Usuarios"
        Me.DGV_Usuarios.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Usuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Usuarios.ShowEditingIcon = False
        Me.DGV_Usuarios.Size = New System.Drawing.Size(284, 307)
        Me.DGV_Usuarios.TabIndex = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 93
        '
        'Frm_Adm_Usuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(633, 444)
        Me.Controls.Add(Me.DGV_Usuarios)
        Me.Controls.Add(Me.rb_eliminados)
        Me.Controls.Add(Me.rb_activos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(232, 285)
        Me.MaximizeBox = False
        Me.Name = "Frm_Adm_Usuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Usuarios"
        Me.groupbox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_nuevo Then
            b = "n"
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Enabled = True
            Me.tb_razon.Enabled = True
            Me.tb_ci.Enabled = True
            Me.tb_email.Enabled = True
            Me.tb_nombre.Enabled = True
            Me.tb_telefono.Enabled = True
            Me.tb_usuario.Enabled = True
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_ci.Clear()
            Me.tb_email.Clear()
            Me.tb_telefono.Clear()
            Me.tb_nombre.Clear()
            Me.ToolBar1.Enabled = False
            DGV_Usuarios.Enabled = False


        ElseIf e.Button Is Me.bt_modificar Then

            If DGV_Usuarios.SelectedRows.Count = 0 Then
                MsgBox("Debe seleccionar el usuario que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else

                b = "m"

                Me.ToolBar1.Enabled = False
                DGV_Usuarios.Enabled = False
                Me.bt_cancelar.Visible = True
                If rb_eliminados.Checked = True Then
                    bt_restaurar.Visible = True
                    bt_aceptar.Visible = False
                Else
                    bt_restaurar.Visible = False
                    bt_aceptar.Visible = True
                    Me.tb_codigo.Enabled = False
                    Me.tb_razon.Enabled = True
                    Me.tb_ci.Enabled = True
                    Me.tb_email.Enabled = True
                    Me.tb_nombre.Enabled = True
                    Me.tb_telefono.Enabled = True
                    Me.tb_usuario.Enabled = True

                End If


            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            If rb_activos.Checked = True Then
                Dim response As MsgBoxResult
                Dim l As String

                If DGV_Usuarios.SelectedRows.Count = 0 Then
                    MsgBox("Debe seleccionar el usuario que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
                ElseIf DGV_Usuarios.SelectedRows.Count = 1 Then
                    response = MsgBox("¿Confirma que desea eliminar el usuario '" + DGV_Usuarios.Rows(DGV_Usuarios.SelectedRows(0).Index).Cells(0).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
                    l = DGV_Usuarios.SelectedRows(0).Cells(0).Value.ToString
                    If (response = MsgBoxResult.Yes) Then
                        DatosUsuarios.elimina_usuario(l)
                        MsgBox("El usuario ha sido eliminado Exitosamente", MsgBoxStyle.OkOnly)
                        DGV_Usuarios.ClearSelection()
                    End If
                    DatosUsuarios.consulta_usuarios(Me.DGV_Usuarios)

                End If
            Else
                If DGV_Usuarios.SelectedRows.Count = 0 Then
                    MsgBox("Debe seleccionar el usuario que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
                Else
                    MsgBox("El usuario ya se encuentra eliminado", MsgBoxStyle.OkOnly, "Mensaje de Error")
                    DGV_Usuarios.ClearSelection()
                End If


            End If
            DGV_Usuarios.ClearSelection()
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Enabled = False
            Me.tb_razon.Enabled = False
            Me.tb_ci.Enabled = False
            Me.tb_email.Enabled = False
            Me.tb_nombre.Enabled = False
            Me.tb_telefono.Enabled = False
            Me.tb_usuario.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_ci.Clear()
            Me.tb_email.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.tb_usuario.ResetText()
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            DatosUsuarios.llenarTipos(tb_usuario, True)
            Me.ToolBar1.Enabled = True
            DGV_Usuarios.Enabled = True
        ElseIf e.Button Is Me.bt_salir Then
            Me.Close()
        End If
    End Sub

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.tb_codigo.Enabled = False
        Me.tb_razon.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.rb_activos.Checked = True
        Me.rb_eliminados.Checked = False
        DatosUsuarios.consulta_usuarios(Me.DGV_Usuarios)
        DGV_Usuarios.Rows(0).Selected = False
        DatosUsuarios.llenarTipos(tb_usuario, True)
        DGV_Usuarios.ClearSelection()
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click


        If tb_codigo.Text = "" Or tb_razon.Text = "" Or tb_usuario.Text = "" Then
            MsgBox("Debe ingresas todos los datos requeridos (*) ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        Else
            If b = "n" Then
                Dim sw As Boolean = False
                DatosUsuarios.consulta_usuario(Me.tb_codigo.Text, sw)
                If sw = True Then
                    MsgBox("No se puede registrar el usuario " + Me.tb_codigo.Text + ". Ya existe un usuario con ese login")
                Else

                    DatosUsuarios.inserta_usuario(Me.tb_codigo.Text, Me.tb_razon.Text, Me.tb_ci.Text, Me.tb_nombre.Text, Me.tb_telefono.Text, Me.tb_email.Text, CInt(tb_usuario.Items.Item(tb_usuario.SelectedIndex).Code.ToString))

                    MsgBox("El Usuario ha sido registrado exitosamente")

                End If
            ElseIf b = "m" Then
                If rb_activos.Checked = True Then
                    DatosUsuarios.modifica_usuario(Me.tb_codigo.Text, Me.tb_razon.Text, Me.tb_ci.Text, Me.tb_nombre.Text, Me.tb_telefono.Text, Me.tb_email.Text, CInt(tb_usuario.Items.Item(tb_usuario.SelectedIndex).Code.ToString))
                    MsgBox("El usuario ha sido modificado Exitosamente")
                End If
            End If

            Me.ToolBar1.Enabled = True
            DGV_Usuarios.Enabled = True

            DatosUsuarios.llenarTipos(tb_usuario, True)
            DatosUsuarios.consulta_usuarios(Me.DGV_Usuarios)

            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Enabled = False
            Me.tb_razon.Enabled = False
            Me.tb_ci.Enabled = False
            Me.tb_email.Enabled = False
            Me.tb_nombre.Enabled = False
            Me.tb_telefono.Enabled = False
            Me.tb_usuario.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_codigo.Clear()
            Me.tb_razon.Clear()
            Me.tb_ci.Clear()
            Me.tb_email.Clear()
            Me.tb_nombre.Clear()
            Me.tb_telefono.Clear()
            Me.tb_usuario.ResetText()
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.DGV_Usuarios.ClearSelection()

        End If



    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        DGV_Usuarios.ClearSelection()
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Enabled = False
        Me.tb_razon.Enabled = False
        Me.tb_ci.Enabled = False
        Me.tb_email.Enabled = False
        Me.tb_nombre.Enabled = False
        Me.tb_telefono.Enabled = False
        Me.tb_usuario.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_ci.Clear()
        Me.tb_email.Clear()
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_usuario.ResetText()
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.bt_restaurar.Visible = False
        DatosUsuarios.llenarTipos(tb_usuario, True)
        Me.ToolBar1.Enabled = True
        DGV_Usuarios.Enabled = True
        b = ""
    End Sub




    Private Sub rb_activos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_activos.CheckedChanged

        DatosUsuarios.consulta_usuarios(Me.DGV_Usuarios)
        DGV_Usuarios.ClearSelection()
        DatosUsuarios.llenarTipos(tb_usuario, True)
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Enabled = False
        Me.tb_razon.Enabled = False
        Me.tb_ci.Enabled = False
        Me.tb_email.Enabled = False
        Me.tb_nombre.Enabled = False
        Me.tb_telefono.Enabled = False
        Me.tb_usuario.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_ci.Clear()
        Me.tb_email.Clear()
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_usuario.ResetText()
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.bt_restaurar.Visible = False
        Me.ToolBar1.Enabled = True
        DGV_Usuarios.Enabled = True
        b = ""
    End Sub

    Private Sub rb_eliminados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_eliminados.CheckedChanged
        DatosUsuarios.consulta_usuario_eliminado(Me.DGV_Usuarios)
        DGV_Usuarios.ClearSelection()
        DatosUsuarios.llenarTipos(tb_usuario, True)
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Enabled = False
        Me.tb_razon.Enabled = False
        Me.tb_ci.Enabled = False
        Me.tb_email.Enabled = False
        Me.tb_nombre.Enabled = False
        Me.tb_telefono.Enabled = False
        Me.tb_usuario.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_ci.Clear()
        Me.tb_email.Clear()
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_usuario.ResetText()
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.bt_restaurar.Visible = False
        Me.ToolBar1.Enabled = True
        DGV_Usuarios.Enabled = True
        b = ""
    End Sub




    Private Sub DGV_Usuarios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Usuarios.KeyDown, DGV_Usuarios.KeyUp

        If DGV_Usuarios.SelectedRows.Count <> 0 Then
            DatosUsuarios.llenarTipos(tb_usuario, True)
            Me.tb_codigo.Text = Me.DGV_Usuarios.Rows(DGV_Usuarios.SelectedRows(0).Index).Cells(0).Value
            DatosUsuarios.consulta_datos_usuario(Me.tb_codigo.Text, Me.tb_razon, Me.tb_ci, Me.tb_nombre, Me.tb_telefono, Me.tb_email, tb_usuario)




        End If

    End Sub

    Private Sub DGV_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Usuarios.Click

        If DGV_Usuarios.SelectedRows.Count <> 0 Then
            DatosUsuarios.llenarTipos(tb_usuario, True)
            Me.tb_codigo.Text = Me.DGV_Usuarios.Rows(DGV_Usuarios.SelectedRows(0).Index).Cells(0).Value
            DatosUsuarios.consulta_datos_usuario(Me.tb_codigo.Text, Me.tb_razon, Me.tb_ci, Me.tb_nombre, Me.tb_telefono, Me.tb_email, tb_usuario)




        End If
    End Sub

    Private Sub bt_restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_restaurar.Click

        Dim response As MsgBoxResult
        Dim cod As String

        If DGV_Usuarios.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el Usuario que desea restaurar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
        ElseIf DGV_Usuarios.SelectedRows.Count = 1 Then
            response = MsgBox("¿Confirma que desea restaurar el Usuario '" + DGV_Usuarios.Rows(DGV_Usuarios.SelectedRows(0).Index).Cells(0).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Restauración")
            cod = DGV_Usuarios.Rows(DGV_Usuarios.SelectedRows(0).Index).Cells(0).Value
            If (response = MsgBoxResult.Yes) Then
                DatosUsuarios.restaura_usuario(cod)
                MsgBox("El Usuario ha sido restaurado Exitosamente")
            End If


        End If

        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_codigo.Clear()
        Me.tb_razon.Clear()
        Me.tb_ci.Clear()
        Me.tb_email.Clear()
        Me.tb_nombre.Clear()
        Me.tb_telefono.Clear()
        Me.tb_usuario.ResetText()
        Me.bt_aceptar.Visible = False
        DatosUsuarios.llenarTipos(tb_usuario, True)
        Me.ToolBar1.Enabled = True
        DGV_Usuarios.Enabled = True
        DGV_Usuarios.Rows.Clear()
        bt_restaurar.Visible = False
        bt_cancelar.Visible = False
        DatosUsuarios.consulta_usuario_eliminado(Me.DGV_Usuarios)
        bt_aceptar.Visible = False

    End Sub


End Class
