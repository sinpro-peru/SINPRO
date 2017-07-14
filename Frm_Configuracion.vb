Public Class Frm_Configuracion
    Inherits System.Windows.Forms.Form
    Dim boton As String
    Dim boton2 As String
    Dim boton3 As Integer = 0
    Dim boton4 As Integer = 0
    Dim CuentaVieja As String = ""
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tp_Moneda As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents bt_eliminarMoneda As System.Windows.Forms.Button
    Friend WithEvents DGV_Monedas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_modificarMoneda As System.Windows.Forms.Button
    Friend WithEvents bt_agregarMoneda As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tb_moneda As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public Conex As String = ""
    Dim w As Boolean
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents tp_cuentas As System.Windows.Forms.TabPage
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents DGV_Cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents tb_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelarCuenta As System.Windows.Forms.Button
    Friend WithEvents bt_aceptarCuenta As System.Windows.Forms.Button
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tb_titular As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents cb_tipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Banco3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tp_logo As System.Windows.Forms.TabPage
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents tb_foto As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents bt_foto As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bt_restaurar As System.Windows.Forms.Button
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents bt_aceptarIva As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aplicar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tab_general As System.Windows.Forms.TabControl
    Friend WithEvents tp_iva As System.Windows.Forms.TabPage
    Friend WithEvents tp_prefArancelaria As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Preferencia As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Prferencia As System.Windows.Forms.Label
    Friend WithEvents gb_cuartos As System.Windows.Forms.GroupBox
    Friend WithEvents bt_ModificarPreferencia As System.Windows.Forms.Button
    Friend WithEvents bt_agregarPreferencia As System.Windows.Forms.Button
    Friend WithEvents bt_eliminarPreferencia As System.Windows.Forms.Button
    Friend WithEvents Dgv_Preferencias As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tp_diasCredito As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv_DiasCred As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bt_ModificarDiasCred As System.Windows.Forms.Button
    Friend WithEvents tb_DiasCred As System.Windows.Forms.TextBox
    Friend WithEvents bt_EliminarDiasCred As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bt_AgregarDiasCred As System.Windows.Forms.Button
    Friend WithEvents tp_bancos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv_Bancos As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tp_comision As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Comision As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_DFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bt_modificarComision As System.Windows.Forms.Button
    Friend WithEvents tb_DInicio As System.Windows.Forms.TextBox
    Friend WithEvents bt_eliminarComision As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bt_agregarComision As System.Windows.Forms.Button
    Friend WithEvents tb_comision As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tp_dominio As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IVA")
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle81 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Configuracion))
        Dim DataGridViewCellStyle82 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle83 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle84 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle85 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle86 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle87 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle88 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle89 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle90 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.bt_aceptarIva = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aplicar = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_iva = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tab_general = New System.Windows.Forms.TabControl
        Me.tp_iva = New System.Windows.Forms.TabPage
        Me.tp_prefArancelaria = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gb_cuartos = New System.Windows.Forms.GroupBox
        Me.Dgv_Preferencias = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.bt_ModificarPreferencia = New System.Windows.Forms.Button
        Me.tb_Preferencia = New System.Windows.Forms.TextBox
        Me.bt_eliminarPreferencia = New System.Windows.Forms.Button
        Me.Lbl_Prferencia = New System.Windows.Forms.Label
        Me.bt_agregarPreferencia = New System.Windows.Forms.Button
        Me.tp_diasCredito = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Dgv_DiasCred = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_ModificarDiasCred = New System.Windows.Forms.Button
        Me.tb_DiasCred = New System.Windows.Forms.TextBox
        Me.bt_EliminarDiasCred = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.bt_AgregarDiasCred = New System.Windows.Forms.Button
        Me.tp_bancos = New System.Windows.Forms.TabPage
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Dgv_Bancos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tb_nombre = New System.Windows.Forms.TextBox
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tp_comision = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.tb_comision = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.bt_eliminarComision = New System.Windows.Forms.Button
        Me.tb_DFinal = New System.Windows.Forms.TextBox
        Me.dgv_Comision = New System.Windows.Forms.DataGridView
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.bt_modificarComision = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.tb_DInicio = New System.Windows.Forms.TextBox
        Me.bt_agregarComision = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.tp_dominio = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tp_Moneda = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.tb_moneda = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.bt_eliminarMoneda = New System.Windows.Forms.Button
        Me.DGV_Monedas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_modificarMoneda = New System.Windows.Forms.Button
        Me.bt_agregarMoneda = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.tp_cuentas = New System.Windows.Forms.TabPage
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo2 = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar2 = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar2 = New System.Windows.Forms.ToolBarButton
        Me.bt_salir2 = New System.Windows.Forms.ToolBarButton
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.DGV_Cuentas = New System.Windows.Forms.DataGridView
        Me.Banco3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Banco2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.tb_titular = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.cb_tipoCuenta = New System.Windows.Forms.ComboBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.cb_banco = New System.Windows.Forms.ComboBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.tb_cuenta = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.bt_cancelarCuenta = New System.Windows.Forms.Button
        Me.bt_aceptarCuenta = New System.Windows.Forms.Button
        Me.tp_logo = New System.Windows.Forms.TabPage
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.bt_restaurar = New System.Windows.Forms.Button
        Me.bt_foto = New System.Windows.Forms.Button
        Me.tb_foto = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Label75 = New System.Windows.Forms.Label
        Me.tb_direccion = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tab_general.SuspendLayout()
        Me.tp_iva.SuspendLayout()
        Me.tp_prefArancelaria.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_cuartos.SuspendLayout()
        CType(Me.Dgv_Preferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_diasCredito.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv_DiasCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_bancos.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Dgv_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.tp_comision.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgv_Comision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_dominio.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tp_Moneda.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DGV_Monedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_cuentas.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.DGV_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.tp_logo.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(333, 192)
        Me.TreeView1.Name = "TreeView1"
        TreeNode6.Name = ""
        TreeNode6.Text = "IVA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.TreeView1.Scrollable = False
        Me.TreeView1.Size = New System.Drawing.Size(76, 37)
        Me.TreeView1.TabIndex = 0
        '
        'bt_aceptarIva
        '
        Me.bt_aceptarIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptarIva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptarIva.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptarIva.Location = New System.Drawing.Point(303, 480)
        Me.bt_aceptarIva.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aceptarIva.Name = "bt_aceptarIva"
        Me.bt_aceptarIva.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptarIva.TabIndex = 11
        Me.bt_aceptarIva.Text = "Aceptar"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.ForeColor = System.Drawing.Color.Black
        Me.bt_cancelar.Location = New System.Drawing.Point(407, 480)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 12
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aplicar
        '
        Me.bt_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aplicar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aplicar.ForeColor = System.Drawing.Color.Black
        Me.bt_aplicar.Location = New System.Drawing.Point(511, 480)
        Me.bt_aplicar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aplicar.TabIndex = 13
        Me.bt_aplicar.Text = "Aplicar"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label36.Location = New System.Drawing.Point(493, 231)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(131, 23)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "(*)Datos requeridos"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(855, 416)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General -> IVA"
        Me.GroupBox3.Visible = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(192, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(432, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Establezca el Impuesto al Valor Agregado (IVA) en porcentaje.  Recuerde que"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(192, 91)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(356, 23)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "será utilizado en todas sus transacciones."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tb_iva)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(290, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 60)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(*)I.V.A.:"
        '
        'tb_iva
        '
        Me.tb_iva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_iva.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_iva.Location = New System.Drawing.Point(56, 16)
        Me.tb_iva.Name = "tb_iva"
        Me.tb_iva.Size = New System.Drawing.Size(100, 22)
        Me.tb_iva.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "%"
        '
        'tab_general
        '
        Me.tab_general.Controls.Add(Me.tp_iva)
        Me.tab_general.Controls.Add(Me.tp_prefArancelaria)
        Me.tab_general.Controls.Add(Me.tp_diasCredito)
        Me.tab_general.Controls.Add(Me.tp_bancos)
        Me.tab_general.Controls.Add(Me.tp_comision)
        Me.tab_general.Controls.Add(Me.tp_dominio)
        Me.tab_general.Controls.Add(Me.tp_Moneda)
        Me.tab_general.Controls.Add(Me.tp_cuentas)
        Me.tab_general.Controls.Add(Me.tp_logo)
        Me.tab_general.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_general.HotTrack = True
        Me.tab_general.Location = New System.Drawing.Point(12, 12)
        Me.tab_general.Multiline = True
        Me.tab_general.Name = "tab_general"
        Me.tab_general.SelectedIndex = 0
        Me.tab_general.Size = New System.Drawing.Size(872, 456)
        Me.tab_general.TabIndex = 16
        '
        'tp_iva
        '
        Me.tp_iva.BackColor = System.Drawing.Color.Transparent
        Me.tp_iva.Controls.Add(Me.GroupBox3)
        Me.tp_iva.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.tp_iva.Location = New System.Drawing.Point(4, 24)
        Me.tp_iva.Name = "tp_iva"
        Me.tp_iva.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_iva.Size = New System.Drawing.Size(864, 428)
        Me.tp_iva.TabIndex = 0
        Me.tp_iva.Text = "IVA"
        Me.tp_iva.UseVisualStyleBackColor = True
        '
        'tp_prefArancelaria
        '
        Me.tp_prefArancelaria.BackColor = System.Drawing.Color.Transparent
        Me.tp_prefArancelaria.Controls.Add(Me.GroupBox1)
        Me.tp_prefArancelaria.Location = New System.Drawing.Point(4, 24)
        Me.tp_prefArancelaria.Name = "tp_prefArancelaria"
        Me.tp_prefArancelaria.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_prefArancelaria.Size = New System.Drawing.Size(864, 428)
        Me.tp_prefArancelaria.TabIndex = 1
        Me.tp_prefArancelaria.Text = "Pref. Arancelarias"
        Me.tp_prefArancelaria.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.gb_cuartos)
        Me.GroupBox1.Controls.Add(Me.bt_ModificarPreferencia)
        Me.GroupBox1.Controls.Add(Me.tb_Preferencia)
        Me.GroupBox1.Controls.Add(Me.bt_eliminarPreferencia)
        Me.GroupBox1.Controls.Add(Me.Lbl_Prferencia)
        Me.GroupBox1.Controls.Add(Me.bt_agregarPreferencia)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 419)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Códigos Arancelarios"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(183, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(432, 37)
        Me.Label9.TabIndex = 10042
        Me.Label9.Text = "Establezca el Código Arancelario en porcentaje.  Recuerde que será utilizado en t" & _
            "odas sus transacciones."
        '
        'gb_cuartos
        '
        Me.gb_cuartos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gb_cuartos.Controls.Add(Me.Dgv_Preferencias)
        Me.gb_cuartos.Controls.Add(Me.Label6)
        Me.gb_cuartos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cuartos.Location = New System.Drawing.Point(373, 137)
        Me.gb_cuartos.Name = "gb_cuartos"
        Me.gb_cuartos.Size = New System.Drawing.Size(222, 151)
        Me.gb_cuartos.TabIndex = 10041
        Me.gb_cuartos.TabStop = False
        '
        'Dgv_Preferencias
        '
        Me.Dgv_Preferencias.AllowUserToAddRows = False
        Me.Dgv_Preferencias.AllowUserToDeleteRows = False
        Me.Dgv_Preferencias.AllowUserToResizeColumns = False
        Me.Dgv_Preferencias.AllowUserToResizeRows = False
        DataGridViewCellStyle76.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Preferencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle76
        Me.Dgv_Preferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Preferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column3})
        Me.Dgv_Preferencias.Location = New System.Drawing.Point(0, 20)
        Me.Dgv_Preferencias.MultiSelect = False
        Me.Dgv_Preferencias.Name = "Dgv_Preferencias"
        Me.Dgv_Preferencias.ReadOnly = True
        Me.Dgv_Preferencias.RowHeadersVisible = False
        Me.Dgv_Preferencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Preferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Preferencias.Size = New System.Drawing.Size(222, 131)
        Me.Dgv_Preferencias.TabIndex = 93
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle77.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle77.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle77
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'Column3
        '
        DataGridViewCellStyle78.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle78.ForeColor = System.Drawing.Color.Black
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle78
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 153
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Preferencias Arancelarias"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_ModificarPreferencia
        '
        Me.bt_ModificarPreferencia.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_ModificarPreferencia.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarPreferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarPreferencia.Location = New System.Drawing.Point(296, 211)
        Me.bt_ModificarPreferencia.Name = "bt_ModificarPreferencia"
        Me.bt_ModificarPreferencia.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarPreferencia.TabIndex = 10031
        Me.bt_ModificarPreferencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_Preferencia
        '
        Me.tb_Preferencia.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Preferencia.Location = New System.Drawing.Point(259, 178)
        Me.tb_Preferencia.Name = "tb_Preferencia"
        Me.tb_Preferencia.Size = New System.Drawing.Size(100, 22)
        Me.tb_Preferencia.TabIndex = 1
        '
        'bt_eliminarPreferencia
        '
        Me.bt_eliminarPreferencia.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarPreferencia.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarPreferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarPreferencia.Location = New System.Drawing.Point(329, 212)
        Me.bt_eliminarPreferencia.Name = "bt_eliminarPreferencia"
        Me.bt_eliminarPreferencia.Size = New System.Drawing.Size(25, 22)
        Me.bt_eliminarPreferencia.TabIndex = 10026
        Me.bt_eliminarPreferencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Lbl_Prferencia
        '
        Me.Lbl_Prferencia.AutoSize = True
        Me.Lbl_Prferencia.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Prferencia.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Prferencia.Location = New System.Drawing.Point(176, 181)
        Me.Lbl_Prferencia.Name = "Lbl_Prferencia"
        Me.Lbl_Prferencia.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_Prferencia.TabIndex = 0
        Me.Lbl_Prferencia.Text = "Preferencia"
        '
        'bt_agregarPreferencia
        '
        Me.bt_agregarPreferencia.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarPreferencia.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarPreferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarPreferencia.Location = New System.Drawing.Point(265, 211)
        Me.bt_agregarPreferencia.Name = "bt_agregarPreferencia"
        Me.bt_agregarPreferencia.Size = New System.Drawing.Size(25, 23)
        Me.bt_agregarPreferencia.TabIndex = 10021
        Me.bt_agregarPreferencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tp_diasCredito
        '
        Me.tp_diasCredito.Controls.Add(Me.GroupBox2)
        Me.tp_diasCredito.Location = New System.Drawing.Point(4, 24)
        Me.tp_diasCredito.Name = "tp_diasCredito"
        Me.tp_diasCredito.Size = New System.Drawing.Size(864, 428)
        Me.tp_diasCredito.TabIndex = 2
        Me.tp_diasCredito.Text = "Días Crédito"
        Me.tp_diasCredito.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.bt_ModificarDiasCred)
        Me.GroupBox2.Controls.Add(Me.tb_DiasCred)
        Me.GroupBox2.Controls.Add(Me.bt_EliminarDiasCred)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.bt_AgregarDiasCred)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(858, 422)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Días de Crédito"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(186, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 37)
        Me.Label4.TabIndex = 10042
        Me.Label4.Text = "Establezca los días de crédito para los clientes. Recuerde que será utilizado en " & _
            "todas sus transacciones."
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.Dgv_DiasCred)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(373, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 151)
        Me.GroupBox4.TabIndex = 10041
        Me.GroupBox4.TabStop = False
        '
        'Dgv_DiasCred
        '
        Me.Dgv_DiasCred.AllowUserToAddRows = False
        Me.Dgv_DiasCred.AllowUserToDeleteRows = False
        Me.Dgv_DiasCred.AllowUserToResizeColumns = False
        Me.Dgv_DiasCred.AllowUserToResizeRows = False
        DataGridViewCellStyle79.BackColor = System.Drawing.Color.White
        Me.Dgv_DiasCred.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle79
        Me.Dgv_DiasCred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_DiasCred.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.Dgv_DiasCred.Location = New System.Drawing.Point(0, 20)
        Me.Dgv_DiasCred.MultiSelect = False
        Me.Dgv_DiasCred.Name = "Dgv_DiasCred"
        Me.Dgv_DiasCred.ReadOnly = True
        Me.Dgv_DiasCred.RowHeadersVisible = False
        Me.Dgv_DiasCred.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_DiasCred.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_DiasCred.Size = New System.Drawing.Size(222, 131)
        Me.Dgv_DiasCred.TabIndex = 93
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle80.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle80.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle80
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle81.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle81
        Me.DataGridViewTextBoxColumn3.HeaderText = "Días"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 135
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Días de Crédito"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_ModificarDiasCred
        '
        Me.bt_ModificarDiasCred.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_ModificarDiasCred.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarDiasCred.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarDiasCred.Location = New System.Drawing.Point(293, 210)
        Me.bt_ModificarDiasCred.Name = "bt_ModificarDiasCred"
        Me.bt_ModificarDiasCred.Size = New System.Drawing.Size(25, 22)
        Me.bt_ModificarDiasCred.TabIndex = 10031
        Me.bt_ModificarDiasCred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_DiasCred
        '
        Me.tb_DiasCred.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_DiasCred.Location = New System.Drawing.Point(254, 177)
        Me.tb_DiasCred.Name = "tb_DiasCred"
        Me.tb_DiasCred.Size = New System.Drawing.Size(100, 22)
        Me.tb_DiasCred.TabIndex = 1
        '
        'bt_EliminarDiasCred
        '
        Me.bt_EliminarDiasCred.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_EliminarDiasCred.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_EliminarDiasCred.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_EliminarDiasCred.Location = New System.Drawing.Point(325, 210)
        Me.bt_EliminarDiasCred.Name = "bt_EliminarDiasCred"
        Me.bt_EliminarDiasCred.Size = New System.Drawing.Size(25, 22)
        Me.bt_EliminarDiasCred.TabIndex = 10026
        Me.bt_EliminarDiasCred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(214, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Días"
        '
        'bt_AgregarDiasCred
        '
        Me.bt_AgregarDiasCred.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_AgregarDiasCred.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_AgregarDiasCred.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_AgregarDiasCred.Location = New System.Drawing.Point(261, 209)
        Me.bt_AgregarDiasCred.Name = "bt_AgregarDiasCred"
        Me.bt_AgregarDiasCred.Size = New System.Drawing.Size(25, 23)
        Me.bt_AgregarDiasCred.TabIndex = 10021
        Me.bt_AgregarDiasCred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tp_bancos
        '
        Me.tp_bancos.Controls.Add(Me.ToolBar1)
        Me.tp_bancos.Controls.Add(Me.GroupBox6)
        Me.tp_bancos.Location = New System.Drawing.Point(4, 24)
        Me.tp_bancos.Name = "tp_bancos"
        Me.tp_bancos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_bancos.Size = New System.Drawing.Size(864, 428)
        Me.tp_bancos.TabIndex = 3
        Me.tp_bancos.Text = "Bancos"
        Me.tp_bancos.UseVisualStyleBackColor = True
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 50)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(188, 44)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(266, 58)
        Me.ToolBar1.TabIndex = 10044
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
        Me.bt_salir.ImageIndex = 4
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
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "icono-impresion.gif")
        Me.ImageList2.Images.SetKeyName(6, "ok.gif")
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Dgv_Bancos)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(852, 416)
        Me.GroupBox6.TabIndex = 94
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bancos"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(187, 321)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(432, 37)
        Me.Label14.TabIndex = 10043
        Me.Label14.Text = "Agregue, modifique o elimine los bancos con los que trabaja. Recuerde que serán u" & _
            "tilizados en todas sus transacciones."
        '
        'Dgv_Bancos
        '
        Me.Dgv_Bancos.AllowUserToAddRows = False
        Me.Dgv_Bancos.AllowUserToDeleteRows = False
        Me.Dgv_Bancos.AllowUserToResizeColumns = False
        Me.Dgv_Bancos.AllowUserToResizeRows = False
        DataGridViewCellStyle82.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Bancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle82
        Me.Dgv_Bancos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_Bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Bancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Dgv_Bancos.Location = New System.Drawing.Point(182, 108)
        Me.Dgv_Bancos.MultiSelect = False
        Me.Dgv_Bancos.Name = "Dgv_Bancos"
        Me.Dgv_Bancos.ReadOnly = True
        Me.Dgv_Bancos.RowHeadersVisible = False
        Me.Dgv_Bancos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgv_Bancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Bancos.Size = New System.Drawing.Size(195, 197)
        Me.Dgv_Bancos.TabIndex = 96
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle83.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle83.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle83
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 42
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle84.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle84.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle84
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 132
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(383, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 23)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Datos del Banco"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.tb_nombre)
        Me.GroupBox5.Controls.Add(Me.tb_codigo)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.bt_aceptar)
        Me.GroupBox5.Location = New System.Drawing.Point(383, 124)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 181)
        Me.GroupBox5.TabIndex = 95
        Me.GroupBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 23)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "(*)Datos requeridos"
        '
        'tb_nombre
        '
        Me.tb_nombre.Enabled = False
        Me.tb_nombre.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.ForeColor = System.Drawing.Color.Black
        Me.tb_nombre.Location = New System.Drawing.Point(105, 68)
        Me.tb_nombre.MaxLength = 50
        Me.tb_nombre.Multiline = True
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(130, 48)
        Me.tb_nombre.TabIndex = 2
        '
        'tb_codigo
        '
        Me.tb_codigo.Enabled = False
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.ForeColor = System.Drawing.Color.Black
        Me.tb_codigo.Location = New System.Drawing.Point(105, 40)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(130, 22)
        Me.tb_codigo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(13, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "(*)Nombre:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(13, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "(*)Código:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(140, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.Visible = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptar.Location = New System.Drawing.Point(40, 149)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 6
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.Visible = False
        '
        'tp_comision
        '
        Me.tp_comision.Controls.Add(Me.GroupBox7)
        Me.tp_comision.Location = New System.Drawing.Point(4, 24)
        Me.tp_comision.Name = "tp_comision"
        Me.tp_comision.Size = New System.Drawing.Size(864, 428)
        Me.tp_comision.TabIndex = 4
        Me.tp_comision.Text = "Comisión"
        Me.tp_comision.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.tb_comision)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.bt_eliminarComision)
        Me.GroupBox7.Controls.Add(Me.tb_DFinal)
        Me.GroupBox7.Controls.Add(Me.dgv_Comision)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.bt_modificarComision)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.tb_DInicio)
        Me.GroupBox7.Controls.Add(Me.bt_agregarComision)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(858, 422)
        Me.GroupBox7.TabIndex = 10041
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Comisión"
        '
        'tb_comision
        '
        Me.tb_comision.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comision.Location = New System.Drawing.Point(247, 205)
        Me.tb_comision.Name = "tb_comision"
        Me.tb_comision.Size = New System.Drawing.Size(105, 22)
        Me.tb_comision.TabIndex = 10040
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(182, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(432, 37)
        Me.Label21.TabIndex = 10044
        Me.Label21.Text = "Agregue, modifique o elimine las comisiones con las que trabaja. Recuerde que ser" & _
            "án utilizadas en todas sus transacciones."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(171, 205)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 15)
        Me.Label18.TabIndex = 10039
        Me.Label18.Text = "Comisión: "
        '
        'bt_eliminarComision
        '
        Me.bt_eliminarComision.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarComision.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarComision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarComision.Location = New System.Drawing.Point(317, 242)
        Me.bt_eliminarComision.Name = "bt_eliminarComision"
        Me.bt_eliminarComision.Size = New System.Drawing.Size(25, 22)
        Me.bt_eliminarComision.TabIndex = 10035
        Me.bt_eliminarComision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_DFinal
        '
        Me.tb_DFinal.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_DFinal.Location = New System.Drawing.Point(247, 168)
        Me.tb_DFinal.Name = "tb_DFinal"
        Me.tb_DFinal.Size = New System.Drawing.Size(105, 22)
        Me.tb_DFinal.TabIndex = 10038
        '
        'dgv_Comision
        '
        Me.dgv_Comision.AllowUserToAddRows = False
        Me.dgv_Comision.AllowUserToDeleteRows = False
        Me.dgv_Comision.AllowUserToResizeColumns = False
        Me.dgv_Comision.AllowUserToResizeRows = False
        DataGridViewCellStyle85.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Comision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle85
        Me.dgv_Comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Comision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Comision})
        Me.dgv_Comision.Location = New System.Drawing.Point(379, 132)
        Me.dgv_Comision.MultiSelect = False
        Me.dgv_Comision.Name = "dgv_Comision"
        Me.dgv_Comision.ReadOnly = True
        Me.dgv_Comision.RowHeadersVisible = False
        Me.dgv_Comision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_Comision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Comision.Size = New System.Drawing.Size(247, 181)
        Me.dgv_Comision.TabIndex = 95
        '
        'Cod
        '
        Me.Cod.HeaderText = "Cod"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Visible = False
        Me.Cod.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle86.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle86.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle86
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dia I."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle87.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle87.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle87
        Me.DataGridViewTextBoxColumn7.HeaderText = "Dia F."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'Comision
        '
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        Me.Comision.Width = 80
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(171, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 15)
        Me.Label17.TabIndex = 10037
        Me.Label17.Text = "Día Final:"
        '
        'bt_modificarComision
        '
        Me.bt_modificarComision.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_modificarComision.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificarComision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificarComision.Location = New System.Drawing.Point(286, 241)
        Me.bt_modificarComision.Name = "bt_modificarComision"
        Me.bt_modificarComision.Size = New System.Drawing.Size(25, 22)
        Me.bt_modificarComision.TabIndex = 10036
        Me.bt_modificarComision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(171, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 15)
        Me.Label16.TabIndex = 10032
        Me.Label16.Text = "Día Inicio:"
        '
        'tb_DInicio
        '
        Me.tb_DInicio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_DInicio.Location = New System.Drawing.Point(247, 135)
        Me.tb_DInicio.Name = "tb_DInicio"
        Me.tb_DInicio.Size = New System.Drawing.Size(105, 22)
        Me.tb_DInicio.TabIndex = 10033
        '
        'bt_agregarComision
        '
        Me.bt_agregarComision.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarComision.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarComision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarComision.Location = New System.Drawing.Point(255, 241)
        Me.bt_agregarComision.Name = "bt_agregarComision"
        Me.bt_agregarComision.Size = New System.Drawing.Size(25, 23)
        Me.bt_agregarComision.TabIndex = 10034
        Me.bt_agregarComision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(379, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(247, 23)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Comisiones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tp_dominio
        '
        Me.tp_dominio.Controls.Add(Me.GroupBox8)
        Me.tp_dominio.Location = New System.Drawing.Point(4, 24)
        Me.tp_dominio.Name = "tp_dominio"
        Me.tp_dominio.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_dominio.Size = New System.Drawing.Size(864, 428)
        Me.tp_dominio.TabIndex = 5
        Me.tp_dominio.Text = "Dominio"
        Me.tp_dominio.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.Button2)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Panel2)
        Me.GroupBox8.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox8.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(855, 416)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Dominio"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button2.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(532, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 22)
        Me.Button2.TabIndex = 10046
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(180, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(485, 37)
        Me.Label22.TabIndex = 10045
        Me.Label22.Text = "Modifique el nombre del dominio al cual debe conectarse el equipo para conexiones" & _
            " remotas. Si no esta utlizando conexiones remotas, NO cambiar este campo."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(506, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "(*)Datos requeridos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(307, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 60)
        Me.Panel2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Location = New System.Drawing.Point(77, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "(*)Dominio:"
        '
        'tp_Moneda
        '
        Me.tp_Moneda.Controls.Add(Me.GroupBox9)
        Me.tp_Moneda.Location = New System.Drawing.Point(4, 24)
        Me.tp_Moneda.Name = "tp_Moneda"
        Me.tp_Moneda.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Moneda.Size = New System.Drawing.Size(864, 428)
        Me.tp_Moneda.TabIndex = 6
        Me.tp_Moneda.Text = "Moneda"
        Me.tp_Moneda.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.tb_moneda)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.bt_eliminarMoneda)
        Me.GroupBox9.Controls.Add(Me.DGV_Monedas)
        Me.GroupBox9.Controls.Add(Me.bt_modificarMoneda)
        Me.GroupBox9.Controls.Add(Me.bt_agregarMoneda)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox9.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(855, 416)
        Me.GroupBox9.TabIndex = 10042
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Moneda"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(205, 185)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 15)
        Me.Label25.TabIndex = 10045
        Me.Label25.Text = "Moneda:"
        '
        'tb_moneda
        '
        Me.tb_moneda.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_moneda.Location = New System.Drawing.Point(270, 182)
        Me.tb_moneda.Name = "tb_moneda"
        Me.tb_moneda.Size = New System.Drawing.Size(105, 22)
        Me.tb_moneda.TabIndex = 10046
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(194, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(432, 37)
        Me.Label23.TabIndex = 10044
        Me.Label23.Text = "Agregue, modifique o elimine las monedas con las que trabaja. Recuerde que serán " & _
            "utilizadas en todas sus transacciones."
        '
        'bt_eliminarMoneda
        '
        Me.bt_eliminarMoneda.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_eliminarMoneda.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarMoneda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarMoneda.Location = New System.Drawing.Point(344, 211)
        Me.bt_eliminarMoneda.Name = "bt_eliminarMoneda"
        Me.bt_eliminarMoneda.Size = New System.Drawing.Size(25, 22)
        Me.bt_eliminarMoneda.TabIndex = 10035
        Me.bt_eliminarMoneda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DGV_Monedas
        '
        Me.DGV_Monedas.AllowUserToAddRows = False
        Me.DGV_Monedas.AllowUserToDeleteRows = False
        Me.DGV_Monedas.AllowUserToResizeColumns = False
        Me.DGV_Monedas.AllowUserToResizeRows = False
        DataGridViewCellStyle88.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Monedas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle88
        Me.DGV_Monedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Monedas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.DGV_Monedas.Location = New System.Drawing.Point(393, 154)
        Me.DGV_Monedas.MultiSelect = False
        Me.DGV_Monedas.Name = "DGV_Monedas"
        Me.DGV_Monedas.ReadOnly = True
        Me.DGV_Monedas.RowHeadersVisible = False
        Me.DGV_Monedas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Monedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Monedas.Size = New System.Drawing.Size(154, 142)
        Me.DGV_Monedas.TabIndex = 95
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 135
        '
        'bt_modificarMoneda
        '
        Me.bt_modificarMoneda.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_modificarMoneda.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificarMoneda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificarMoneda.Location = New System.Drawing.Point(313, 210)
        Me.bt_modificarMoneda.Name = "bt_modificarMoneda"
        Me.bt_modificarMoneda.Size = New System.Drawing.Size(25, 22)
        Me.bt_modificarMoneda.TabIndex = 10036
        Me.bt_modificarMoneda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarMoneda
        '
        Me.bt_agregarMoneda.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarMoneda.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarMoneda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarMoneda.Location = New System.Drawing.Point(282, 210)
        Me.bt_agregarMoneda.Name = "bt_agregarMoneda"
        Me.bt_agregarMoneda.Size = New System.Drawing.Size(25, 23)
        Me.bt_agregarMoneda.TabIndex = 10034
        Me.bt_agregarMoneda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(393, 132)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(155, 23)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "Monedas"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tp_cuentas
        '
        Me.tp_cuentas.Controls.Add(Me.ToolBar2)
        Me.tp_cuentas.Controls.Add(Me.GroupBox14)
        Me.tp_cuentas.Location = New System.Drawing.Point(4, 24)
        Me.tp_cuentas.Name = "tp_cuentas"
        Me.tp_cuentas.Size = New System.Drawing.Size(864, 428)
        Me.tp_cuentas.TabIndex = 11
        Me.tp_cuentas.Text = "Cuentas Compañía"
        Me.tp_cuentas.UseVisualStyleBackColor = True
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.AutoSize = False
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo2, Me.bt_modificar2, Me.bt_eliminar2, Me.bt_salir2})
        Me.ToolBar2.ButtonSize = New System.Drawing.Size(70, 50)
        Me.ToolBar2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Location = New System.Drawing.Point(121, 47)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(266, 58)
        Me.ToolBar2.TabIndex = 10045
        '
        'bt_nuevo2
        '
        Me.bt_nuevo2.ImageIndex = 0
        Me.bt_nuevo2.Name = "bt_nuevo2"
        Me.bt_nuevo2.Text = "Nuevo"
        '
        'bt_modificar2
        '
        Me.bt_modificar2.ImageIndex = 1
        Me.bt_modificar2.Name = "bt_modificar2"
        Me.bt_modificar2.Text = "Modificar"
        '
        'bt_eliminar2
        '
        Me.bt_eliminar2.ImageIndex = 2
        Me.bt_eliminar2.Name = "bt_eliminar2"
        Me.bt_eliminar2.Text = "Eliminar"
        '
        'bt_salir2
        '
        Me.bt_salir2.ImageIndex = 4
        Me.bt_salir2.Name = "bt_salir2"
        Me.bt_salir2.Text = "Salir"
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.White
        Me.GroupBox14.Controls.Add(Me.Label50)
        Me.GroupBox14.Controls.Add(Me.DGV_Cuentas)
        Me.GroupBox14.Controls.Add(Me.Label51)
        Me.GroupBox14.Controls.Add(Me.GroupBox15)
        Me.GroupBox14.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox14.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(856, 425)
        Me.GroupBox14.TabIndex = 95
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Bancos"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(225, 356)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(432, 31)
        Me.Label50.TabIndex = 10043
        Me.Label50.Text = "Agregue, modifique o elimine las cuentas de bancos con las que trabaja. Recuerde " & _
            "que serán utilizadas en todas sus transacciones."
        '
        'DGV_Cuentas
        '
        Me.DGV_Cuentas.AllowUserToAddRows = False
        Me.DGV_Cuentas.AllowUserToDeleteRows = False
        Me.DGV_Cuentas.AllowUserToResizeColumns = False
        Me.DGV_Cuentas.AllowUserToResizeRows = False
        DataGridViewCellStyle89.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Cuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle89
        Me.DGV_Cuentas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Banco3, Me.DataGridViewTextBoxColumn9, Me.Cuenta, Me.TipoC, Me.Banco2})
        Me.DGV_Cuentas.Location = New System.Drawing.Point(116, 107)
        Me.DGV_Cuentas.MultiSelect = False
        Me.DGV_Cuentas.Name = "DGV_Cuentas"
        Me.DGV_Cuentas.ReadOnly = True
        Me.DGV_Cuentas.RowHeadersVisible = False
        Me.DGV_Cuentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Cuentas.Size = New System.Drawing.Size(266, 221)
        Me.DGV_Cuentas.TabIndex = 96
        '
        'Banco3
        '
        Me.Banco3.HeaderText = "Banco"
        Me.Banco3.Name = "Banco3"
        Me.Banco3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        DataGridViewCellStyle90.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle90.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle90
        Me.DataGridViewTextBoxColumn9.HeaderText = "Titular"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 110
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        Me.Cuenta.Width = 120
        '
        'TipoC
        '
        Me.TipoC.HeaderText = "Column1"
        Me.TipoC.Name = "TipoC"
        Me.TipoC.ReadOnly = True
        Me.TipoC.Visible = False
        '
        'Banco2
        '
        Me.Banco2.HeaderText = "Column1"
        Me.Banco2.Name = "Banco2"
        Me.Banco2.ReadOnly = True
        Me.Banco2.Visible = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Location = New System.Drawing.Point(442, 47)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(299, 23)
        Me.Label51.TabIndex = 94
        Me.Label51.Text = "Datos de la cuenta"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Controls.Add(Me.tb_titular)
        Me.GroupBox15.Controls.Add(Me.Label56)
        Me.GroupBox15.Controls.Add(Me.cb_tipoCuenta)
        Me.GroupBox15.Controls.Add(Me.Label55)
        Me.GroupBox15.Controls.Add(Me.cb_banco)
        Me.GroupBox15.Controls.Add(Me.Label52)
        Me.GroupBox15.Controls.Add(Me.tb_cuenta)
        Me.GroupBox15.Controls.Add(Me.Label53)
        Me.GroupBox15.Controls.Add(Me.Label54)
        Me.GroupBox15.Controls.Add(Me.bt_cancelarCuenta)
        Me.GroupBox15.Controls.Add(Me.bt_aceptarCuenta)
        Me.GroupBox15.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(442, 64)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(299, 264)
        Me.GroupBox15.TabIndex = 95
        Me.GroupBox15.TabStop = False
        '
        'tb_titular
        '
        Me.tb_titular.Enabled = False
        Me.tb_titular.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_titular.ForeColor = System.Drawing.Color.Black
        Me.tb_titular.Location = New System.Drawing.Point(119, 121)
        Me.tb_titular.MaxLength = 75
        Me.tb_titular.Name = "tb_titular"
        Me.tb_titular.Size = New System.Drawing.Size(154, 21)
        Me.tb_titular.TabIndex = 54
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(28, 124)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(90, 23)
        Me.Label56.TabIndex = 55
        Me.Label56.Text = "(*)Titular:"
        '
        'cb_tipoCuenta
        '
        Me.cb_tipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipoCuenta.Enabled = False
        Me.cb_tipoCuenta.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipoCuenta.FormattingEnabled = True
        Me.cb_tipoCuenta.Items.AddRange(New Object() {"Ahorros", "Corriente"})
        Me.cb_tipoCuenta.Location = New System.Drawing.Point(119, 65)
        Me.cb_tipoCuenta.Name = "cb_tipoCuenta"
        Me.cb_tipoCuenta.Size = New System.Drawing.Size(121, 22)
        Me.cb_tipoCuenta.TabIndex = 51
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(28, 68)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(90, 23)
        Me.Label55.TabIndex = 50
        Me.Label55.Text = "(*)Tipo Cuenta:"
        '
        'cb_banco
        '
        Me.cb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_banco.Enabled = False
        Me.cb_banco.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_banco.FormattingEnabled = True
        Me.cb_banco.Location = New System.Drawing.Point(119, 39)
        Me.cb_banco.Name = "cb_banco"
        Me.cb_banco.Size = New System.Drawing.Size(121, 22)
        Me.cb_banco.TabIndex = 49
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(32, 166)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(125, 23)
        Me.Label52.TabIndex = 48
        Me.Label52.Text = "(*)Datos requeridos"
        '
        'tb_cuenta
        '
        Me.tb_cuenta.Enabled = False
        Me.tb_cuenta.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cuenta.ForeColor = System.Drawing.Color.Black
        Me.tb_cuenta.Location = New System.Drawing.Point(119, 94)
        Me.tb_cuenta.MaxLength = 21
        Me.tb_cuenta.Name = "tb_cuenta"
        Me.tb_cuenta.Size = New System.Drawing.Size(154, 21)
        Me.tb_cuenta.TabIndex = 2
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(28, 97)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(90, 23)
        Me.Label53.TabIndex = 7
        Me.Label53.Text = "(*)Nro. Cuenta:"
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(28, 42)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(72, 23)
        Me.Label54.TabIndex = 6
        Me.Label54.Text = "(*)Banco:"
        '
        'bt_cancelarCuenta
        '
        Me.bt_cancelarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelarCuenta.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelarCuenta.ForeColor = System.Drawing.Color.Black
        Me.bt_cancelarCuenta.Location = New System.Drawing.Point(161, 227)
        Me.bt_cancelarCuenta.Name = "bt_cancelarCuenta"
        Me.bt_cancelarCuenta.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelarCuenta.TabIndex = 7
        Me.bt_cancelarCuenta.Text = "Cancelar"
        Me.bt_cancelarCuenta.Visible = False
        '
        'bt_aceptarCuenta
        '
        Me.bt_aceptarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptarCuenta.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptarCuenta.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptarCuenta.Location = New System.Drawing.Point(61, 227)
        Me.bt_aceptarCuenta.Name = "bt_aceptarCuenta"
        Me.bt_aceptarCuenta.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptarCuenta.TabIndex = 6
        Me.bt_aceptarCuenta.Text = "Aceptar"
        Me.bt_aceptarCuenta.Visible = False
        '
        'tp_logo
        '
        Me.tp_logo.BackColor = System.Drawing.Color.White
        Me.tp_logo.Controls.Add(Me.Panel15)
        Me.tp_logo.Controls.Add(Me.Label74)
        Me.tp_logo.Controls.Add(Me.Panel14)
        Me.tp_logo.Location = New System.Drawing.Point(4, 24)
        Me.tp_logo.Name = "tp_logo"
        Me.tp_logo.Size = New System.Drawing.Size(864, 428)
        Me.tp_logo.TabIndex = 17
        Me.tp_logo.Text = "Logo y Dirección"
        Me.tp_logo.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.bt_restaurar)
        Me.Panel15.Controls.Add(Me.bt_foto)
        Me.Panel15.Controls.Add(Me.tb_foto)
        Me.Panel15.Controls.Add(Me.Label77)
        Me.Panel15.Controls.Add(Me.PictureBox1)
        Me.Panel15.Controls.Add(Me.Label76)
        Me.Panel15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel15.Location = New System.Drawing.Point(211, 89)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(474, 134)
        Me.Panel15.TabIndex = 26
        '
        'bt_restaurar
        '
        Me.bt_restaurar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_restaurar.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_restaurar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_restaurar.Location = New System.Drawing.Point(440, 7)
        Me.bt_restaurar.Name = "bt_restaurar"
        Me.bt_restaurar.Size = New System.Drawing.Size(25, 22)
        Me.bt_restaurar.TabIndex = 32
        Me.bt_restaurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_foto
        '
        Me.bt_foto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_foto.Image = CType(resources.GetObject("bt_foto.Image"), System.Drawing.Image)
        Me.bt_foto.Location = New System.Drawing.Point(414, 7)
        Me.bt_foto.Name = "bt_foto"
        Me.bt_foto.Size = New System.Drawing.Size(25, 22)
        Me.bt_foto.TabIndex = 31
        Me.bt_foto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'tb_foto
        '
        Me.tb_foto.Location = New System.Drawing.Point(181, 6)
        Me.tb_foto.Name = "tb_foto"
        Me.tb_foto.ReadOnly = True
        Me.tb_foto.Size = New System.Drawing.Size(227, 22)
        Me.tb_foto.TabIndex = 30
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label77.Location = New System.Drawing.Point(114, 9)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(68, 20)
        Me.Label77.TabIndex = 29
        Me.Label77.Text = "Examinar:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(117, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label76.Location = New System.Drawing.Point(5, 9)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(68, 20)
        Me.Label76.TabIndex = 27
        Me.Label76.Text = "(*) Logo:"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(208, 50)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(469, 35)
        Me.Label74.TabIndex = 26
        Me.Label74.Text = "Escriba aquí el logo y la dirección que serán mostrados en todos sus reportes."
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Label75)
        Me.Panel14.Controls.Add(Me.tb_direccion)
        Me.Panel14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(211, 229)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(474, 111)
        Me.Panel14.TabIndex = 25
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label75.Location = New System.Drawing.Point(5, 9)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(92, 22)
        Me.Label75.TabIndex = 4
        Me.Label75.Text = "(*) Dirección:"
        '
        'tb_direccion
        '
        Me.tb_direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_direccion.Location = New System.Drawing.Point(117, 3)
        Me.tb_direccion.MaxLength = 200
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(348, 101)
        Me.tb_direccion.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Name = "ToolBarButton3"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Name = "ToolBarButton4"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Seleccione imagen para Logo"
        '
        'Frm_Configuracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(890, 518)
        Me.Controls.Add(Me.tab_general)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptarIva)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(164, 200)
        Me.MaximizeBox = False
        Me.Name = "Frm_Configuracion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Configuración"
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tab_general.ResumeLayout(False)
        Me.tp_iva.ResumeLayout(False)
        Me.tp_prefArancelaria.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_cuartos.ResumeLayout(False)
        CType(Me.Dgv_Preferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_diasCredito.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Dgv_DiasCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_bancos.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Dgv_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tp_comision.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgv_Comision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_dominio.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tp_Moneda.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.DGV_Monedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_cuentas.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.DGV_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.tp_logo.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node Is Me.TreeView1.Nodes(0) Then
            Me.GroupBox3.Visible = True
            Me.tb_iva.Focus()
        ElseIf e.Node Is Me.TreeView1.Nodes(1) Then
            Me.GroupBox3.Visible = False
        ElseIf e.Node Is Me.TreeView1.Nodes(2) Then
            Me.GroupBox3.Visible = False
        End If
        DatosConfiguracion.consulta_Comision(dgv_Comision, 0)
        ponerporcentaje()
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click

        If tab_general.SelectedTab Is tp_iva Then

            If Me.tb_iva.Text = "" Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
            Else
                Dim sw2 As Boolean = False

                DatosConfiguracion.consulta_iva(sw2)

                If sw2 = False Then
                    DatosConfiguracion.inserta_iva(CDbl(Me.tb_iva.Text))
                Else
                    DatosConfiguracion.modifica_iva(CDbl(Me.tb_iva.Text))
                End If
            End If

        ElseIf tab_general.SelectedTab Is tp_logo Then

            Datos.ModificaLogo(PictureBox1.Image.ToString, PictureBox1.Image.ToString, tb_direccion.Text, 2)
            MsgBox("Parámetros modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        End If

    End Sub

    Public Sub arreglar()

        If Dgv_Preferencias.RowCount < 5 Then
            Dgv_Preferencias.Columns(1).Width = 154
            Dgv_DiasCred.Columns(1).Width = 154
        Else
            Dgv_Preferencias.Columns(1).Width = 137
            Dgv_DiasCred.Columns(1).Width = 137
        End If

        If Dgv_DiasCred.RowCount < 5 Then
            Dgv_DiasCred.Columns(1).Width = 154
        Else
            Dgv_DiasCred.Columns(1).Width = 137
        End If

    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If Me.tb_iva.Text = "" Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function

    Private Sub bt_agregarPreferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarPreferencia.Click
        If tb_Preferencia.Text <> "" Then

            If verificar(tb_Preferencia.Text, Dgv_Preferencias) = False Then

                DatosConfiguracion.inserta_Pref_Arancelaria(tb_Preferencia.Text)
                Dgv_Preferencias.Rows.Clear()
                DatosConfiguracion.consulta_PrefArancelaria(Dgv_Preferencias)
                arreglar()
                Dgv_Preferencias.ClearSelection()
                tb_Preferencia.Clear()
            End If

        Else
            MsgBox("Introduzca la Preferencia", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Dgv_Preferencias_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_Preferencias.CellClick, Dgv_Preferencias.KeyDown, Dgv_Preferencias.KeyUp
        If Dgv_Preferencias.SelectedRows.Count > 0 Then
            tb_Preferencia.Text = Dgv_Preferencias.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub bt_ModificarPreferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarPreferencia.Click

        If Dgv_Preferencias.RowCount > 0 Then

            If tb_Preferencia.Text <> "" Then
                DatosConfiguracion.modifica_Pref_Arancelaria(tb_Preferencia.Text, Dgv_Preferencias.SelectedRows(0).Cells(0).Value)
                Dgv_Preferencias.Rows.Clear()
                DatosConfiguracion.consulta_PrefArancelaria(Dgv_Preferencias)
                arreglar()
                Dgv_Preferencias.ClearSelection()
                tb_Preferencia.Clear()
            Else
                MsgBox("No puede dejar el campo vacío!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Seleccione la preferencia a modificar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub bt_eliminarPreferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarPreferencia.Click

        If Dgv_Preferencias.SelectedRows.Count > 0 Then

            If MsgBox("Está seguro de eliminar la Preferencia con: " & Dgv_Preferencias.SelectedRows(0).Cells(1).Value.ToString, MsgBoxStyle.YesNo, "Eliminar Preferencia") = MsgBoxResult.Yes Then
                DatosConfiguracion.Eliminar_Preferencia(Dgv_Preferencias.SelectedRows(0).Cells(0).Value)
                Dgv_Preferencias.Rows.Clear()
                DatosConfiguracion.consulta_PrefArancelaria(Dgv_Preferencias)
                arreglar()
                Dgv_Preferencias.ClearSelection()
                tb_Preferencia.Clear()
            Else
                tb_Preferencia.Clear()
                Dgv_Preferencias.ClearSelection()
            End If

        Else
            MsgBox("Seleccione la Preferencia a eliminar", MsgBoxStyle.Critical)
        End If

    End Sub

    Public Function verificar(ByVal valor As String, ByRef Dgv As DataGridView) As Boolean

        Dim ver As Boolean = False
        Dim i As Integer

        For i = 0 To Dgv.RowCount - 1

            If valor.ToUpper = Dgv.Rows(i).Cells(1).Value.ToString.ToUpper Then
                ver = True
            End If
        Next

        If ver = True Then
            MsgBox("La preferencia ya existe!!!", MsgBoxStyle.Critical)
            tb_Preferencia.Clear()
            Dgv_Preferencias.ClearSelection()
        End If

        Return ver

    End Function

    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_general.SelectedIndexChanged

        If tab_general.SelectedTab Is tp_dominio Then

            Dim a As String = Frm_Principal.conex.ConnectionString.Substring(12)
            Dim b As String() = a.Split(";")
            Dim c As String() = b(0).Split(",")
            a = c(0)
            TextBox1.Text = a

            TextBox1.Focus()
            TextBox1.SelectAll()
            Conex = TextBox1.Text

        ElseIf tab_general.SelectedTab Is tp_bancos Then
            DatosBanco.ver_Bancos(Dgv_Bancos)
        ElseIf tab_general.SelectedTab Is tp_cuentas Then
            DatosConfiguracion.consulta_bancos(cb_banco)
            DatosConfiguracion.consulta_Cuentas(DGV_Cuentas)
        ElseIf tab_general.SelectedTab Is tp_comision Then

            tb_codigo.Clear()
            tb_nombre.Clear()
            tb_DFinal.Clear()
            tb_DInicio.Clear()
            tb_comision.Clear()

            arreglar()

            dgv_Comision.ClearSelection()

        ElseIf tab_general.SelectedTab Is tp_iva Then
            DatosConfiguracion.tb_iva(Me.tb_iva.Text)
        ElseIf tab_general.SelectedTab Is tp_diasCredito Then
            DatosConfiguracion.consulta_DiasCred(Dgv_DiasCred)
        ElseIf tab_general.SelectedTab Is tp_prefArancelaria Then
            Dgv_Preferencias.Rows.Clear()
            DatosConfiguracion.consulta_PrefArancelaria(Dgv_Preferencias)
            Dgv_Preferencias.ClearSelection()
        ElseIf tab_general.SelectedTab Is tp_Moneda Then
            Datos.consulta_Monedas(DGV_Monedas)
            DGV_Monedas.ClearSelection()
        ElseIf tab_general.SelectedTab Is tp_logo Then
            Datos.consultaLogo(PictureBox1)
            Datos.consultaDireccion(tb_direccion.Text)
        End If
    End Sub

    Private Sub bt_AgregarDiasCred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AgregarDiasCred.Click
        Try
            If tb_DiasCred.Text <> "" Then

                If verificar(tb_DiasCred.Text, Dgv_DiasCred) = False Then

                    DatosConfiguracion.inserta_DiasCred(CInt(tb_DiasCred.Text))
                    Dgv_DiasCred.Rows.Clear()
                    DatosConfiguracion.consulta_DiasCred(Dgv_DiasCred)
                    arreglar()
                    Dgv_DiasCred.ClearSelection()
                    tb_DiasCred.Clear()

                End If

            Else
                MsgBox("Introduzca los días", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Solo puede introducir Números")
            tb_DiasCred.Clear()
        End Try

    End Sub

    Private Sub bt_ModificarDiasCred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarDiasCred.Click

        Try
            If Dgv_DiasCred.SelectedRows.Count > 0 Then

                If tb_DiasCred.Text <> "" Then

                    DatosConfiguracion.modifica_DiasCred(CInt(Dgv_DiasCred.SelectedRows(0).Cells(0).Value), CInt(tb_DiasCred.Text))
                    Dgv_DiasCred.Rows.Clear()
                    DatosConfiguracion.consulta_DiasCred(Dgv_DiasCred)
                    arreglar()
                    Dgv_DiasCred.ClearSelection()
                    tb_DiasCred.Clear()
                Else
                    MsgBox("No puede dejar el campo vacío!", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Seleccione el dato a modificar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Introduzca sólo números", MsgBoxStyle.Critical)
            tb_DiasCred.Clear()
        End Try


    End Sub

    Private Sub bt_EliminarDiasCred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EliminarDiasCred.Click
        If Dgv_DiasCred.SelectedRows.Count > 0 Then

            If MsgBox("Está seguro de eliminar el dato con código: " & Dgv_DiasCred.SelectedRows(0).Cells(0).Value.ToString, MsgBoxStyle.YesNo, "Eliminar Días Crédito") = MsgBoxResult.Yes Then

                DatosConfiguracion.Eliminar_DiasCred(Dgv_DiasCred.SelectedRows(0).Cells(0).Value)
                Dgv_DiasCred.Rows.Clear()
                DatosConfiguracion.consulta_DiasCred(Dgv_DiasCred)
                arreglar()
                Dgv_DiasCred.ClearSelection()
                tb_DiasCred.Clear()
            Else
                tb_DiasCred.Clear()
                Dgv_DiasCred.ClearSelection()
            End If
        Else
            MsgBox("Seleccione el dato a eliminar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Dgv_DiasCred_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv_DiasCred.CellClick, Dgv_DiasCred.KeyDown, Dgv_DiasCred.KeyUp

        If Dgv_DiasCred.SelectedRows.Count > 0 Then

            tb_DiasCred.Text = Dgv_DiasCred.SelectedRows(0).Cells(1).Value.ToString

        End If
    End Sub


    Private Sub Frm_Bancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If

        DatosConfiguracion.tb_iva(Me.tb_iva.Text)
        tb_iva.Focus()
        tb_iva.SelectAll()

    End Sub


    Private Sub Dgv_Bancos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim n As Integer
        n = Dgv_Bancos.SelectedRows.Count

        If n = 0 Then
            tb_codigo.Clear()
            tb_nombre.Clear()
        ElseIf n = 1 Then
            tb_codigo.Text = Dgv_Bancos.SelectedRows(0).Cells(0).Value.ToString
            tb_nombre.Text = Dgv_Bancos.SelectedRows(0).Cells(1).Value.ToString
        Else
            Dgv_Bancos.ClearSelection()
        End If


    End Sub
    Private Sub bt_aceptarIva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptarIva.Click

        If tab_general.SelectedTab Is tp_iva Then

            If Me.tb_iva.Text = "" Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
            Else
                Dim sw2 As Boolean = False

                DatosConfiguracion.consulta_iva(sw2)

                If sw2 = False Then
                    DatosConfiguracion.inserta_iva(CDbl(Me.tb_iva.Text))
                Else
                    DatosConfiguracion.modifica_iva(CDbl(Me.tb_iva.Text))
                End If
            End If

        ElseIf tab_general.SelectedTab Is tp_logo Then

            Datos.ModificaLogo(PictureBox1.Image.ToString, PictureBox1.Image.ToString, tb_direccion.Text, 2)
            MsgBox("Parámetros modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        End If

        Me.Close()

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim a As Boolean = False

        If boton = "n" Then

            If tb_codigo.Text <> "" And tb_nombre.Text <> "" Then

                DatosBanco.Insertar_Banco(tb_nombre.Text)
                MsgBox("El Banco Ha sido Registrado Exitosamente", MsgBoxStyle.Information, "Confirmar Registro")
                a = True

            End If

        ElseIf boton = "m" Then

            If tb_codigo.Text <> "" And tb_nombre.Text <> "" Then

                DatosBanco.Modificar_Banco(tb_codigo.Text, tb_nombre.Text)
                MsgBox("El Banco Ha sido Modificado Exitosamente", MsgBoxStyle.Information, "Confirmar Modificación")
                a = True

            End If

        ElseIf boton = "e" Then

            a = True
        End If

        If a = True Then

            tb_codigo.Enabled = False
            tb_nombre.Enabled = False
            tb_codigo.Clear()
            tb_nombre.Clear()
            ToolBar1.Enabled = True
            Dgv_Bancos.Enabled = True
            DatosBanco.ver_Bancos(Dgv_Bancos)
            bt_aceptar.Visible = False
            Button1.Visible = False
            Dgv_Bancos.ClearSelection()
        Else
            MsgBox("Introduzca los Datos requeridos (*)", MsgBoxStyle.Critical, "Datos Requeridos")
            tb_nombre.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        tb_codigo.Enabled = False
        tb_nombre.Enabled = False
        tb_codigo.Clear()
        tb_nombre.Clear()
        ToolBar1.Enabled = True
        Dgv_Bancos.Enabled = True
        bt_aceptar.Visible = False
        Button1.Visible = False
        Dgv_Bancos.ClearSelection()
    End Sub


    Private Sub Dgv_Bancos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles Dgv_Bancos.CellClick, Dgv_Bancos.KeyDown, Dgv_Bancos.KeyUp

        If Dgv_Bancos.SelectedRows.Count > 0 Then

            tb_codigo.Text = Dgv_Bancos.SelectedRows(0).Cells(0).Value
            tb_nombre.Text = Dgv_Bancos.SelectedRows(0).Cells(1).Value

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        tb_codigo.Enabled = False
        tb_nombre.Enabled = False
        tb_codigo.Clear()
        tb_nombre.Clear()
        ToolBar1.Enabled = True
        Dgv_Bancos.Enabled = True
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        Button1.Visible = False
        Dgv_Bancos.ClearSelection()

    End Sub

    Private Sub bt_aceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim a As Boolean = False

        If boton = "n" Then

            If tb_codigo.Text <> "" And tb_nombre.Text <> "" Then

                DatosBanco.Insertar_Banco(tb_nombre.Text)
                MsgBox("El Banco Ha sido Registrado Exitosamente", MsgBoxStyle.Information, "Confirmar Registro")
                a = True

            End If

        ElseIf boton = "m" Then

            If tb_codigo.Text <> "" And tb_nombre.Text <> "" Then

                DatosBanco.Modificar_Banco(tb_codigo.Text, tb_nombre.Text)
                MsgBox("El Banco Ha sido Modificado Exitosamente", MsgBoxStyle.Information, "Confirmar Modificación")
                a = True

            End If

        ElseIf boton = "e" Then

            a = True
        End If

        If a = True Then

            tb_codigo.Enabled = False
            tb_nombre.Enabled = False
            tb_codigo.Clear()
            tb_nombre.Clear()
            Button1.Visible = False
            ToolBar1.Enabled = True
            Dgv_Bancos.Enabled = True
            DatosBanco.ver_Bancos(Dgv_Bancos)
            bt_aceptar.Visible = False
            bt_cancelar.Visible = False
            Dgv_Bancos.ClearSelection()
        Else
            MsgBox("Introduzca los Datos requeridos (*)", MsgBoxStyle.Critical, "Datos Requeridos")
            tb_nombre.Focus()
        End If
    End Sub

    Private Sub bt_agregarComision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarComision.Click
        Try

            If tb_DInicio.Text <> "" And tb_DFinal.Text <> "" And tb_comision.Text <> "" Then
                quitarporcentaje()
                If verificaComision(tb_DInicio.Text, tb_DFinal.Text, tb_comision.Text, dgv_Comision) = False Then

                    DatosConfiguracion.inserta_Comision(CInt(tb_DInicio.Text), CInt(tb_DFinal.Text), CDbl(tb_comision.Text))
                    dgv_Comision.ClearSelection()
                    tb_DInicio.Clear()
                    tb_DFinal.Clear()
                    tb_comision.Clear()
                    dgv_Comision.ClearSelection()
                    dgv_Comision.Rows.Clear()
                    DatosConfiguracion.consulta_Comision(dgv_Comision, 0)
                End If
                ponerporcentaje()
            Else
                MsgBox("No puede dejar ningún campo vacío!", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Solo puede introducir Números")
            tb_DInicio.Clear()
            tb_DFinal.Clear()
            tb_comision.Clear()
        End Try

    End Sub

    Public Function verificaComision(ByVal inicio As String, ByVal final As String, ByVal comision As String, ByRef Dgv As DataGridView) As Boolean

        Dim ver As Boolean = False
        Dim i As Integer

        For i = 0 To Dgv.RowCount - 1

            If inicio.ToUpper = Dgv.Rows(i).Cells(1).Value.ToString.ToUpper And final.ToUpper = Dgv.Rows(i).Cells(2).Value.ToString.ToUpper And comision.ToUpper = Dgv.Rows(i).Cells(3).Value.ToString.ToUpper Then
                ver = True
            End If
        Next

        If ver = True Then
            MsgBox("La comisión ya existe!!!", MsgBoxStyle.Critical)
            tb_DInicio.Clear()
            tb_DFinal.Clear()
            tb_comision.Clear()
            dgv_Comision.ClearSelection()
        End If

        Return ver

    End Function

    Private Sub bt_modificarComision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarComision.Click
        Try
            If dgv_Comision.SelectedRows.Count > 0 Then

                If tb_DInicio.Text <> "" And tb_DFinal.Text <> "" And tb_comision.Text <> "" Then

                    DatosConfiguracion.modifica_comision(CInt(dgv_Comision.SelectedRows(0).Cells(0).Value), CInt(tb_DInicio.Text), CInt(tb_DFinal.Text), CDbl(tb_comision.Text))
                    dgv_Comision.Rows.Clear()
                    DatosConfiguracion.consulta_Comision(dgv_Comision, 0)
                    ponerporcentaje()
                    dgv_Comision.ClearSelection()
                    tb_DInicio.Clear()
                    tb_DFinal.Clear()
                    tb_comision.Clear()
                    dgv_Comision.ClearSelection()
                Else
                    MsgBox("No puede dejar ningún campo vacío!", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Seleccione el dato a modificar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Introduzca sólo números", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub bt_eliminarComision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarComision.Click
        If dgv_Comision.SelectedRows.Count > 0 Then

            If MsgBox("¿Está seguro de eliminar esa comisión? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                DatosConfiguracion.Eliminar_Comision(CInt(dgv_Comision.SelectedRows(0).Cells(0).Value))
                dgv_Comision.Rows.Clear()
                DatosConfiguracion.consulta_Comision(dgv_Comision, 0)
                ponerporcentaje()
                tb_DInicio.Clear()
                tb_DFinal.Clear()
                tb_comision.Clear()
                dgv_Comision.ClearSelection()
            Else
                tb_DInicio.Clear()
                tb_DFinal.Clear()
                tb_comision.Clear()
                dgv_Comision.ClearSelection()
            End If
        Else
            MsgBox("Seleccione el dato a eliminar", MsgBoxStyle.Critical)
        End If
    End Sub



    Private Sub dgv_Comision_CellClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgv_Comision.CellClick, dgv_Comision.KeyDown, dgv_Comision.KeyUp
        If Not (dgv_Comision.SelectedRows.Count = 0) Then
            quitarporcentaje()
            tb_DInicio.Text = dgv_Comision.SelectedRows(0).Cells(1).Value
            tb_DFinal.Text = dgv_Comision.SelectedRows(0).Cells(2).Value
            tb_comision.Text = dgv_Comision.SelectedRows(0).Cells(3).Value

        End If
    End Sub
    Public Sub ponerporcentaje()
        Try
            Dim i As Integer = 0

            For i = 0 To dgv_Comision.RowCount - 1

                dgv_Comision.Rows(i).Cells(3).Value = dgv_Comision.Rows(i).Cells(3).Value.ToString & "%"

            Next
        Catch ex As Exception

        End Try


    End Sub
    Public Sub quitarporcentaje()

        Try
            Dim i As Integer = 0

            For i = 0 To dgv_Comision.RowCount - 1

                dgv_Comision.Rows(i).Cells(3).Value = dgv_Comision.Rows(i).Cells(3).Value.ToString.Replace("%", "")

            Next
        Catch ex As Exception

        End Try


    End Sub


    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then

            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then

            ToolBar1.Enabled = False
            boton = "n"
            Dgv_Bancos.Enabled = False
            DatosBanco.identidad_Banco(tb_codigo)
            tb_nombre.Enabled = True
            tb_nombre.Clear()
            bt_aceptar.Visible = True
            Button1.Visible = True
            tb_nombre.Focus()
            Dgv_Bancos.ClearSelection()

        ElseIf e.Button Is Me.bt_modificar Then
            Dim n As Integer
            n = Dgv_Bancos.SelectedRows.Count
            If n = 0 Then
                MsgBox("Debe seleccionar el Banco que desea modificar", MsgBoxStyle.Critical)
            ElseIf n = 1 Then
                If tb_codigo.Text <> "" And tb_nombre.Text <> "" Then
                    boton = "m"
                    ToolBar1.Enabled = False
                    tb_nombre.Enabled = True
                    bt_aceptar.Visible = True
                    Button1.Visible = True
                    tb_nombre.Focus()
                    tb_nombre.SelectAll()
                End If
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            Dim n As Integer
            n = Dgv_Bancos.SelectedRows.Count

            boton = "e"

            If n = 0 Then
                MsgBox("Elija el banco a eliminar", MsgBoxStyle.Critical, "Eliminar")
            ElseIf n = 1 Then

                If MsgBox("¿Está seguro que desea eliminar el Banco " & Dgv_Bancos.SelectedRows(0).Cells(1).Value & "?", MsgBoxStyle.YesNo, "Confirmar Eliminación") = MsgBoxResult.Yes Then
                    ToolBar1.Enabled = False
                    DatosBanco.Eliminar_Banco(Dgv_Bancos.SelectedRows(0).Cells(0).Value)
                    tb_codigo.Enabled = False
                    tb_nombre.Enabled = False
                    tb_codigo.Clear()
                    tb_nombre.Clear()
                    ToolBar1.Enabled = True
                    DatosBanco.ver_Bancos(Dgv_Bancos)
                End If
            End If
        End If
        Dgv_Bancos.ClearSelection()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Frm_Principal.conex.Close()

            If TextBox1.Text = "" Then

                MsgBox("No puede introducir un dominio vacío", MsgBoxStyle.Exclamation)

            Else



                Frm_Principal.conex.ConnectionString = "Data Source=" & TextBox1.Text & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MEL;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"
                Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=" & TextBox1.Text & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MEL;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"

                Dim conex2 As New SqlClient.SqlConnection
                conex2.ConnectionString = Frm_Principal.conex.ConnectionString

                Frm_Principal.conex.Open()

                Datos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                'DatosNota.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosProveedor.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosProducto.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosTransporte.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCodigoVariacion.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosRecibo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCodigosArancelarios.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosGrupos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosVendedores.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosFacturas.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosPedidosCompras.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosPedidoCliente.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCompras.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                'DatosVentas.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                'DatosAlmacenes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosNotaCredito.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosComprasProveedores.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                'DatosDemandaInsatisfecha.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                'DatosPronostico.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosConfiguracion.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosGuiaTransporte.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosBanco.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosComisiones.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosMarcaModelo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAlmacenes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAjustes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAnalisisPedido.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)

                Dim fic As String = My.Application.Info.DirectoryPath() + "\Dominio.txt"
                Dim texto As String = TextBox1.Text

                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(texto)
                sw.Close()


                MsgBox("Dominio modificado satisfactoriamente", MsgBoxStyle.Information, "Cambio de dominio")

            End If
        Catch ex As Exception

            Frm_Principal.conex.Close()
            Dim texto As String = ""
            Datos.RetornaDominio(texto)

            Frm_Principal.conex.ConnectionString = "Data Source=" & texto & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MIL-26;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"
            Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=" & texto & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MIL-26;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"
            'Frm_Principal.conex.ConnectionString = "Data Source=" & texto & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MELPRUEBA;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"
            'Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=" & texto & ", 1433; Network Library=DBMSSOCN; Initial Catalog=MELPRUEBA;Integrated Security=SSPI; Trusted_Connection=false;User ID=HugoEstrada; Password=Hugo16096946"

            Dim conex2 As New SqlClient.SqlConnection
            conex2.ConnectionString = Frm_Principal.conex.ConnectionString

            Frm_Principal.conex.Open()

            Datos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            'DatosNota.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosProveedor.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosProducto.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosTransporte.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosCodigoVariacion.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosRecibo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosCodigosArancelarios.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosGrupos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosVendedores.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosFacturas.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosPedidosCompras.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosPedidoCliente.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosCompras.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            'DatosVentas.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            'DatosAlmacenes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosNotaCredito.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosComprasProveedores.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            'DatosDemandaInsatisfecha.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            'DatosPronostico.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosConfiguracion.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosGuiaTransporte.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosBanco.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosComisiones.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosMarcaModelo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosAlmacenes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosAjustes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            DatosAnalisisPedido.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)


            MsgBox("No se puede conectar con ese dominio o servidor, se utilizó la conexión anterior", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarMoneda.Click

        Dim esta As Boolean = False

        If tb_moneda.Text <> "" Then

            For cont As Integer = 0 To DGV_Monedas.RowCount - 1

                If tb_moneda.Text.ToUpper = DGV_Monedas.Rows(cont).Cells(0).Value.ToString.ToUpper Then

                    esta = True

                End If

            Next


            If esta Then

                MsgBox("Ya existe esta moneda", MsgBoxStyle.Exclamation, "Error")

            Else
                Datos.Inserta_Moneda(tb_moneda.Text)
                DGV_Monedas.Rows.Add(tb_moneda.Text)
            End If

        End If
        tb_moneda.Clear()
        DGV_Monedas.ClearSelection()
    End Sub

    Private Sub bt_modificarMoneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarMoneda.Click

        Dim esta As Boolean = False

        If tb_moneda.Text <> "" Then

            For cont As Integer = 0 To DGV_Monedas.RowCount - 1

                If tb_moneda.Text.ToUpper = DGV_Monedas.Rows(cont).Cells(0).Value.ToString.ToUpper Then

                    esta = True

                End If

            Next


            If esta Then

                MsgBox("Ya existe esta moneda", MsgBoxStyle.Exclamation, "Error")

            Else

                If DGV_Monedas.SelectedRows.Count > 0 Then

                    Datos.modifica_Moneda(tb_moneda.Text, DGV_Monedas.SelectedRows(0).Cells(0).Value.ToString)
                    DGV_Monedas.SelectedRows(0).Cells(0).Value = tb_moneda.Text

                End If

            End If

        End If

        tb_moneda.Clear()
        DGV_Monedas.ClearSelection()

    End Sub

    Private Sub bt_eliminarMoneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarMoneda.Click

        If DGV_Monedas.SelectedRows.Count > 0 Then

            Datos.elimina_Moneda(DGV_Monedas.SelectedRows(0).Cells(0).Value.ToString)
            DGV_Monedas.Rows.Remove(DGV_Monedas.SelectedRows(0))
            tb_moneda.Clear()
            DGV_Monedas.ClearSelection()

        End If

    End Sub

    Private Sub DGV_Monedas_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Monedas.CellClick, DGV_Monedas.KeyUp
        tb_moneda.Text = DGV_Monedas.SelectedRows(0).Cells(0).Value.ToString
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
            Me.Label22.Text = "      Sólo números y (,)"
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick

        If e.Button Is Me.bt_salir2 Then

            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo2 Then

            ToolBar2.Enabled = False
            boton2 = "n"
            DGV_Cuentas.Enabled = False
            DatosConfiguracion.consulta_bancos(cb_banco)
            tb_titular.Enabled = True
            tb_titular.Clear()
            bt_aceptarCuenta.Visible = True
            bt_cancelarCuenta.Visible = True
            cb_tipoCuenta.Items.Clear()
            cb_tipoCuenta.Items.Add("Ahorros")
            cb_tipoCuenta.Items.Add("Corriente")
            cb_banco.Enabled = True
            cb_banco.Text = ""
            cb_tipoCuenta.Enabled = True
            cb_tipoCuenta.Text = ""
            tb_cuenta.Enabled = True
            tb_cuenta.Clear()
            cb_banco.Focus()

            DGV_Cuentas.ClearSelection()

        ElseIf e.Button Is Me.bt_modificar2 Then

            Dim n As Integer
            n = DGV_Cuentas.SelectedRows.Count
            If n = 0 Then
                MsgBox("Debe seleccionar la cuenta que desea modificar", MsgBoxStyle.Critical)
            ElseIf n = 1 Then
                boton2 = "m"
                'DatosConfiguracion.consulta_bancos(cb_banco)

                ToolBar2.Enabled = False

                If cb_tipoCuenta.Items.Count = 0 Then
                    cb_tipoCuenta.Items.Add("Ahorros")
                    cb_tipoCuenta.Items.Add("Corriente")
                End If

                DGV_Cuentas.Enabled = False
                CuentaVieja = tb_cuenta.Text
                bt_aceptarCuenta.Visible = True
                bt_cancelarCuenta.Visible = True
                cb_banco.Enabled = True
                cb_tipoCuenta.Enabled = True
                tb_cuenta.Enabled = True
            End If
        ElseIf e.Button Is Me.bt_eliminar2 Then

            Dim n As Integer
            n = DGV_Cuentas.SelectedRows.Count

            boton = "e"

            If n = 0 Then
                MsgBox("Elija la cuenta a eliminar", MsgBoxStyle.Critical, "Eliminar")
            ElseIf n = 1 Then

                If MsgBox("¿Está seguro que desea eliminar la cuenta " & DGV_Cuentas.SelectedRows(0).Cells(3).Value & " del banco" & DGV_Cuentas.SelectedRows(0).Cells(2).Value & "?", MsgBoxStyle.YesNo, "Confirmar Eliminación") = MsgBoxResult.Yes Then
                    DatosConfiguracion.Eliminar_Cuenta(DGV_Cuentas.SelectedRows(0).Cells(2).Value)
                    cb_banco.Text = ""
                    cb_tipoCuenta.Text = ""
                    tb_cuenta.Clear()
                    tb_titular.Clear()
                    DGV_Cuentas.ClearSelection()
                    DatosConfiguracion.consulta_Cuentas(DGV_Cuentas)
                End If
            End If
        End If
    End Sub

    Private Sub bt_cancelarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelarCuenta.Click
        DGV_Cuentas.Enabled = True
        DatosConfiguracion.consulta_Cuentas(DGV_Cuentas)
        ToolBar2.Enabled = True
        cb_banco.Items.Clear()
        tb_titular.Enabled = False
        tb_titular.Clear()
        bt_aceptarCuenta.Visible = False
        bt_cancelarCuenta.Visible = False
        cb_banco.Enabled = False
        cb_banco.Text = ""
        cb_banco.Items.Clear()
        cb_tipoCuenta.Items.Clear()
        cb_tipoCuenta.Items.Add("Ahorros")
        cb_tipoCuenta.Items.Add("Corriente")
        cb_tipoCuenta.Enabled = False
        cb_tipoCuenta.Text = ""
        tb_cuenta.Enabled = False
        DatosConfiguracion.consulta_bancos(cb_banco)
        tb_cuenta.Clear()
        DGV_Cuentas.ClearSelection()
    End Sub

    Private Sub bt_aceptarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptarCuenta.Click

        Try

            Dim deny As Boolean = False

            If cb_banco.SelectedIndex <> -1 Or cb_tipoCuenta.SelectedIndex <> -1 Or tb_cuenta.Text <> "" Or tb_titular.Text <> "" Then

                If boton2 = "n" Then
                    DatosConfiguracion.inserta_Cuenta(tb_titular.Text, tb_cuenta.Text, cb_tipoCuenta.Text, CInt(cb_banco.SelectedItem.code))
                ElseIf boton2 = "m" Then
                    DatosConfiguracion.modifica_Cuenta(tb_titular.Text, tb_cuenta.Text, cb_tipoCuenta.Text, CInt(cb_banco.SelectedItem.code), CuentaVieja)
                End If

                If deny = False Then

                    DGV_Cuentas.Enabled = True
                    ToolBar2.Enabled = True
                    tb_titular.Enabled = False
                    tb_titular.Clear()
                    bt_aceptarCuenta.Visible = False
                    bt_cancelarCuenta.Visible = False
                    cb_banco.Enabled = False
                    cb_banco.Text = ""
                    cb_tipoCuenta.Enabled = False
                    cb_tipoCuenta.Text = ""
                    cb_banco.Items.Clear()
                    DGV_Cuentas.ClearSelection()
                    cb_tipoCuenta.Items.Clear()
                    cb_tipoCuenta.Items.Add("Ahorros")
                    cb_tipoCuenta.Items.Add("Corriente")
                    tb_cuenta.Enabled = False
                    tb_cuenta.Clear()
                    DatosConfiguracion.consulta_bancos(cb_banco)
                    DatosConfiguracion.consulta_Cuentas(DGV_Cuentas)

                End If

            Else

                MsgBox("Debe llenar todos los campos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Catch ex As Exception

            MsgBox("Error insertando o modificando la cuenta, favor intente de nuevo", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub DGV_Cuentas_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Cuentas.CellClick, DGV_Cuentas.KeyDown, DGV_Cuentas.KeyUp

        tb_titular.Text = DGV_Cuentas.SelectedRows(0).Cells(1).Value
        tb_cuenta.Text = DGV_Cuentas.SelectedRows(0).Cells(2).Value
        cb_tipoCuenta.Text = DGV_Cuentas.SelectedRows(0).Cells(3).Value
        For cont As Integer = 0 To cb_banco.Items.Count - 1
            If cb_banco.Items(cont).code = DGV_Cuentas.SelectedRows(0).Cells(4).Value Then
                cb_banco.SelectedIndex = cont
            End If
        Next

    End Sub

    Private Sub bt_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_foto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.tb_foto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub tb_foto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_foto.TextChanged

        Try
            Me.PictureBox1.Image = Image.FromFile(Me.tb_foto.Text)
        Catch
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        End Try

    End Sub

    Private Sub bt_ModificarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_restaurar.Click
        tb_foto.Clear()
        Datos.consultaLogo(PictureBox1)
    End Sub

End Class